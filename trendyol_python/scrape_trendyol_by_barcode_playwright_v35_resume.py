# -*- coding: utf-8 -*-
r"""
Playwright v3.5 (Resume) — Yarım kaldığı yerden devam eder

Özellikler:
- Çalışma sırasında --save-every ile ara kayıt (output_partial.xlsx) yazar.
- Aynı komutu tekrar çalıştırırsan, VAR OLAN output dosyasını okur ve
  Trendyol_Durum dolu olan satırları otomatik atlayıp KALDIĞI YERDEN devam eder.
- Resume mantığı: Trendyol_Durum 'Evet' veya 'Hayır' ise satır bitmiş kabul edilir.
  Bir satırı yeniden denemek istersen Trendyol_Durum hücresini boş bırak.

Kullanım (tek komut, resume otomatik):
  python scrape_trendyol_by_barcode_playwright_v35_resume.py --headful --manual-captcha ^
    --accept-recommendations --min-token-overlap 1 --sleep 1.8 --save-every 50 ^
    --in "C:\...\15432421.xlsx" --out "C:\...\Trendyol_global_sonuc.xlsx"
"""

from __future__ import annotations

import argparse
import json
import random
import re
import sys
import time
from dataclasses import dataclass
from difflib import SequenceMatcher
from pathlib import Path
from typing import Any, Dict, List, Optional, Tuple

import pandas as pd
from bs4 import BeautifulSoup
from playwright.sync_api import sync_playwright, TimeoutError as PWTimeoutError

SEARCH_URL = "https://www.trendyol.com/sr?q={query}"
HOME_URL = "https://www.trendyol.com/"

DEFAULT_UA = (
    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 "
    "(KHTML, like Gecko) Chrome/122.0.0.0 Safari/537.36"
)

BLOCK_STATUS = {403, 429, 503, 520, 521, 522, 523, 524}

# Çok genel kelimeler: 1 token overlap ile yanlış eşleşmesin diye
GENERIC_TOKENS = {
    "kadin","erkek","cocuk","bebek","kiz","oğlan","oglan",
    "takim","takımı","takimi","set","ikili","üçlü","uclu","uc","3lü","2li",
    "pijama","esofman","eşofman","bermuda","kapri","mont","tulum","body",
    "sort","şort","tişört","tshirt","tsirt","atlet","ic","iç","giyim",
    "renk","lacivert","siyah","beyaz","krem","yesil","yeşil","mavi","pembe","turuncu",
    "lila","mor","kirmizi","kırmızı","gri","bej","haki","kahve","mocha","mint",
    "basic","standart","model","urun","ürün","yeni",
}

def norm_text(s: str) -> str:
    s = (s or "").strip().lower()
    s = re.sub(r"\s+", " ", s)
    return s

def tokenize(s: str) -> List[str]:
    s = norm_text(s)
    s = re.sub(r"[^\w\sçğıöşü]", " ", s, flags=re.UNICODE)
    parts = [p for p in re.split(r"\s+", s) if p]
    parts = [p for p in parts if len(p) >= 3 and not p.isdigit()]
    return parts

def token_overlap(a: str, b: str) -> Tuple[int, List[str]]:
    ta = [t for t in tokenize(a) if t not in GENERIC_TOKENS]
    tb = [t for t in tokenize(b) if t not in GENERIC_TOKENS]
    common = sorted(set(ta).intersection(set(tb)))
    return len(common), common

def similarity(a: str, b: str) -> float:
    a, b = norm_text(a), norm_text(b)
    if not a or not b:
        return 0.0
    return SequenceMatcher(None, a, b).ratio()

def normalize_barcode(x: Any) -> str:
    if x is None or (isinstance(x, float) and pd.isna(x)):
        return ""
    s = str(x).strip()
    s = s.replace(".0", "") if re.fullmatch(r"\d+\.0", s) else s
    s = re.sub(r"\s+", "", s)
    return s

def extract_json_ld(html: str) -> List[Dict[str, Any]]:
    soup = BeautifulSoup(html, "lxml")
    out: List[Dict[str, Any]] = []
    for script in soup.find_all("script", attrs={"type": "application/ld+json"}):
        try:
            txt = script.get_text(strip=True)
            if not txt:
                continue
            j = json.loads(txt)
            if isinstance(j, dict):
                out.append(j)
            elif isinstance(j, list):
                out.extend([x for x in j if isinstance(x, dict)])
        except Exception:
            continue
    return out

def extract_next_data(html: str) -> Optional[Dict[str, Any]]:
    soup = BeautifulSoup(html, "lxml")
    node = soup.find("script", attrs={"id": "__NEXT_DATA__", "type": "application/json"})
    if not node:
        return None
    try:
        return json.loads(node.get_text())
    except Exception:
        return None

def deep_find_first(obj: Any, keys: set) -> Optional[Any]:
    if isinstance(obj, dict):
        for k, v in obj.items():
            if k in keys and v is not None:
                return v
        for v in obj.values():
            r = deep_find_first(v, keys)
            if r is not None:
                return r
    elif isinstance(obj, list):
        for v in obj:
            r = deep_find_first(v, keys)
            if r is not None:
                return r
    return None

def extract_breadcrumb_text(html: str) -> str:
    soup = BeautifulSoup(html, "lxml")
    for sel in [
        "nav[aria-label*=breadcrumb] a",
        "div[class*='breadcrumb'] a",
        "ul[class*='breadcrumb'] a",
        "ol[class*='breadcrumb'] a",
    ]:
        links = soup.select(sel)
        names = [a.get_text(" ", strip=True) for a in links if a.get_text(strip=True)]
        names = [n for n in names if n.lower() not in ("anasayfa", "home")]
        out=[]
        seen=set()
        for n in names:
            if n in seen:
                continue
            seen.add(n)
            out.append(n)
        if len(out) >= 2:
            return " / ".join(out)
    return ""

@dataclass
class ProductHit:
    url: str
    title: str = ""
    brand: str = ""
    category_path: str = ""
    barcode: str = ""
    score: float = 0.0
    note: str = ""

def parse_product_page(html: str, url: str) -> ProductHit:
    hit = ProductHit(url=url)
    hit.category_path = extract_breadcrumb_text(html)

    soup = BeautifulSoup(html, "lxml")
    h1 = soup.find("h1")
    if h1:
        hit.title = h1.get_text(" ", strip=True)
    if not hit.title:
        t = soup.find("title")
        if t:
            hit.title = t.get_text(" ", strip=True)

    for j in extract_json_ld(html):
        typ = j.get("@type") or ""
        if isinstance(typ, list):
            typ = " ".join(typ)
        if "Product" in str(typ):
            hit.title = hit.title or (j.get("name") or "")
            b = j.get("brand")
            if isinstance(b, dict):
                hit.brand = hit.brand or (b.get("name") or "")
            elif isinstance(b, str):
                hit.brand = hit.brand or b
            for k in ("gtin13", "gtin", "sku", "mpn"):
                v = j.get(k)
                if v:
                    hit.barcode = str(v).strip()
                    break
            cat = j.get("category")
            if isinstance(cat, str):
                hit.category_path = hit.category_path or cat

    nd = extract_next_data(html)
    if nd:
        crumb = deep_find_first(nd, {"breadcrumb", "breadcrumbs", "categoryPath", "categoryName", "breadcrumbItems"})
        if isinstance(crumb, list):
            names = []
            for it in crumb:
                if isinstance(it, dict):
                    nm = it.get("name") or it.get("text") or it.get("label")
                    if nm:
                        names.append(str(nm))
                elif isinstance(it, str):
                    names.append(it)
            if names:
                hit.category_path = hit.category_path or " / ".join(names)
        elif isinstance(crumb, str):
            hit.category_path = hit.category_path or crumb

        brand = deep_find_first(nd, {"brandName", "brand"})
        if isinstance(brand, str):
            hit.brand = hit.brand or brand

        bc = deep_find_first(nd, {"barcode", "barcodes", "gtin13", "gtin"})
        if isinstance(bc, str) and bc.strip():
            hit.barcode = hit.barcode or bc.strip()

    return hit

def unique_preserve(seq: List[str]) -> List[str]:
    seen=set()
    out=[]
    for x in seq:
        if x in seen:
            continue
        seen.add(x)
        out.append(x)
    return out

def add_basic_stealth(context):
    context.add_init_script("""
Object.defineProperty(navigator, 'webdriver', {get: () => undefined});
Object.defineProperty(navigator, 'languages', {get: () => ['tr-TR','tr','en-US','en']});
Object.defineProperty(navigator, 'plugins', {get: () => [1,2,3,4,5]});
window.chrome = window.chrome || { runtime: {} };
""")

def accept_cookies_if_possible(page):
    selectors = [
        "button#onetrust-accept-btn-handler",
        "button:has-text('Kabul Et')",
        "button:has-text('Kabul et')",
        "button:has-text('Accept')",
        "button:has-text('Tamam')",
    ]
    for sel in selectors:
        try:
            if page.locator(sel).first.is_visible(timeout=1500):
                page.locator(sel).first.click(timeout=1500)
                time.sleep(0.5)
                return
        except Exception:
            continue

def save_debug(page, out_dir: Path, prefix: str):
    out_dir.mkdir(parents=True, exist_ok=True)
    ts = int(time.time())
    png = out_dir / f"{prefix}_{ts}.png"
    htmlp = out_dir / f"{prefix}_{ts}.html"
    try:
        page.screenshot(path=str(png), full_page=True)
    except Exception:
        pass
    try:
        htmlp.write_text(page.content(), encoding="utf-8", errors="ignore")
    except Exception:
        pass

def is_real_block(page, status_code: Optional[int]) -> bool:
    url = (page.url or "").lower()
    if status_code in BLOCK_STATUS:
        return True
    if any(x in url for x in ["cf-chl", "challenge", "captcha", "blocked", "security-check"]):
        return True
    try:
        if page.locator("iframe[src*='captcha'], iframe[src*='recaptcha'], iframe[src*='hcaptcha']").count() > 0:
            return True
        if page.locator("input[name*='cf-turnstile-response'], .cf-challenge-running, #cf-challenge-running").count() > 0:
            return True
        t = page.title().lower()
        if "access denied" in t or "forbidden" in t:
            return True
    except Exception:
        pass
    return False

def ensure_not_blocked(page, response_status: Optional[int], debug_dir: Path, tag: str, manual: bool, headful: bool, sleep: float) -> Tuple[bool, Optional[int]]:
    if is_real_block(page, response_status):
        save_debug(page, debug_dir, tag)
        if manual and headful:
            print(">> Bu sayfada CAPTCHA/ENGEL var. Tarayıcıda çöz, sonra ENTER...")
            try:
                input()
            except Exception:
                pass
            time.sleep(1.0)
            try:
                resp = page.reload(wait_until="domcontentloaded", timeout=60000)
                response_status = resp.status if resp else response_status
            except Exception:
                pass
            time.sleep(sleep + random.random()*0.6)
            if is_real_block(page, response_status):
                return False, response_status
            return True, response_status
        return False, response_status
    return True, response_status

def collect_search_links(page) -> List[str]:
    try:
        page.wait_for_selector("a[href*='-p-']", timeout=7000)
    except Exception:
        pass
    links = page.eval_on_selector_all("a[href*='-p-']", "els => els.map(e => e.href)")
    links = [u.split("?")[0] for u in (links or [])]
    links = unique_preserve([u for u in links if isinstance(u, str) and u.startswith("http")])
    return links[:20]

def search_has_not_found_banner(page) -> bool:
    try:
        loc = page.locator('[data-testid="information-banner"] [data-testid="information-text"]').first
        if loc.count() == 0:
            return False
        txt = loc.inner_text(timeout=1500).strip().lower()
        return "aradığın ürün bulunamadı" in txt
    except Exception:
        return False

def read_input_and_resume(in_path: str, out_path: str) -> Tuple[pd.DataFrame, str, Optional[str], Optional[str]]:
    df_in = pd.read_excel(in_path)
    if df_in.empty:
        raise ValueError("Input Excel boş.")

    cols = {c.lower(): c for c in df_in.columns}
    barcode_col = cols.get("barkodno") or cols.get("barcode") or list(df_in.columns)[0]
    title_col = cols.get("adi") or cols.get("urunadi") or cols.get("title")
    brand_col = cols.get("marka") or cols.get("brand")

    df_in[barcode_col] = df_in[barcode_col].map(normalize_barcode)

    out_cols = [
        "Trendyol_URL",
        "Trendyol_KategoriYolu",
        "Trendyol_Barkod",
        "Trendyol_Marka",
        "Trendyol_UrunAdi",
        "Trendyol_Skor",
        "Trendyol_Durum",
        "Trendyol_Not",
    ]
    for c in out_cols:
        if c not in df_in.columns:
            df_in[c] = ""
    df_in["Trendyol_Skor"] = pd.to_numeric(df_in["Trendyol_Skor"], errors="coerce")

    p_out = Path(out_path)
    if p_out.exists():
        try:
            df_out = pd.read_excel(out_path)
            for c in out_cols:
                if c not in df_out.columns:
                    df_out[c] = ""
            if barcode_col in df_out.columns:
                df_out[barcode_col] = df_out[barcode_col].map(normalize_barcode)

            if len(df_out) == len(df_in):
                return df_out, barcode_col, title_col, brand_col

            if barcode_col in df_out.columns:
                merge_cols = [barcode_col] + [c for c in out_cols if c in df_out.columns]
                df_merge = df_in.merge(df_out[merge_cols], on=barcode_col, how="left", suffixes=("", "_old"))
                for c in out_cols:
                    if c + "_old" in df_merge.columns:
                        df_merge[c] = df_merge[c].where(df_merge[c].astype(str).str.strip() != "", df_merge[c + "_old"])
                        df_merge.drop(columns=[c + "_old"], inplace=True)
                return df_merge, barcode_col, title_col, brand_col
        except Exception:
            pass

    return df_in, barcode_col, title_col, brand_col

def is_done(val: Any) -> bool:
    s = str(val).strip().lower()
    return s in ("evet", "hayır", "hayir")

def main() -> int:
    ap = argparse.ArgumentParser()
    ap.add_argument("--in", dest="in_path", required=True)
    ap.add_argument("--out", dest="out_path", required=True)
    ap.add_argument("--sleep", type=float, default=1.8)
    ap.add_argument("--save-every", type=int, default=50)
    ap.add_argument("--headful", action="store_true")
    ap.add_argument("--manual-captcha", action="store_true")
    ap.add_argument("--threshold", type=float, default=0.60)
    ap.add_argument("--force-first", action="store_true")
    ap.add_argument("--accept-recommendations", action="store_true")
    ap.add_argument("--min-token-overlap", type=int, default=1)
    ap.add_argument("--ua", default=DEFAULT_UA)
    ap.add_argument("--profile-dir", default="profile_trendyol")
    ap.add_argument("--proxy", default="")
    ap.add_argument("--debug-dir", default="debug_out")
    args = ap.parse_args()

    try:
        df, barcode_col, title_col, brand_col = read_input_and_resume(args.in_path, args.out_path)
    except Exception as e:
        print(f"Hata: {e}", file=sys.stderr)
        return 2

    indices = [i for i in range(len(df)) if not is_done(df.at[i, "Trendyol_Durum"])]
    total_todo = len(indices)
    if total_todo == 0:
        print("Hepsi tamam görünüyor. (Trendyol_Durum dolu)")
        return 0

    print(f"Toplam satır: {len(df)} | Kalan: {total_todo} | Resume: Evet")

    found = 0
    processed = 0

    profile_dir = Path(args.profile_dir).resolve()
    debug_dir = Path(args.debug_dir).resolve()

    with sync_playwright() as p:
        launch_kwargs = {"headless": (not args.headful)}
        if args.proxy.strip():
            launch_kwargs["proxy"] = {"server": args.proxy.strip()}

        context = p.chromium.launch_persistent_context(
            user_data_dir=str(profile_dir),
            locale="tr-TR",
            timezone_id="Europe/Istanbul",
            user_agent=args.ua,
            viewport={"width": random.choice([1280, 1366, 1440]), "height": random.choice([720, 768, 810])},
            **launch_kwargs
        )
        add_basic_stealth(context)
        page = context.new_page()

        try:
            page.goto(HOME_URL, wait_until="domcontentloaded", timeout=60000)
            time.sleep(2.0 + random.random())
            accept_cookies_if_possible(page)
        except Exception:
            pass

        for idx_i, i in enumerate(indices, start=1):
            barcode = normalize_barcode(df.at[i, barcode_col])
            if not barcode:
                df.at[i, "Trendyol_Durum"] = "Hayır"
                df.at[i, "Trendyol_Not"] = "Barkod boş"
                continue

            title_hint = str(df.at[i, title_col]) if title_col and title_col in df.columns else ""
            brand_hint = str(df.at[i, brand_col]) if brand_col and brand_col in df.columns else ""

            search_url = SEARCH_URL.format(query=barcode)

            try:
                resp = page.goto(search_url, wait_until="domcontentloaded", timeout=60000)
                status = resp.status if resp else None
                time.sleep(args.sleep + random.random() * 0.8)

                ok, status = ensure_not_blocked(page, status, debug_dir, f"blocked_search_{barcode}", args.manual_captcha, args.headful, args.sleep)
                if not ok:
                    df.at[i, "Trendyol_Durum"] = "Hayır"
                    df.at[i, "Trendyol_Not"] = f"ENGEL: arama sayfası (status={status})"
                    print(f"[{idx_i}/{total_todo}] ENGEL | {barcode} | arama (status={status})")
                    processed += 1
                    continue

                not_found = search_has_not_found_banner(page)
                if not_found and (not args.accept_recommendations):
                    df.at[i, "Trendyol_Durum"] = "Hayır"
                    df.at[i, "Trendyol_Not"] = "Barkod Trendyol aramasında bulunamadı (öneriler var)"
                    print(f"[{idx_i}/{total_todo}] YOK   | {barcode} | ürün bulunamadı (öneri var)")
                    processed += 1
                    continue

                links = collect_search_links(page)
                if not links:
                    df.at[i, "Trendyol_Durum"] = "Hayır"
                    df.at[i, "Trendyol_Not"] = "Arama sonucu link yok"
                    print(f"[{idx_i}/{total_todo}] YOK   | {barcode} | arama link yok")
                    processed += 1
                    continue

                if args.force_first:
                    links = links[:1]

                best: Optional[ProductHit] = None
                best_reason = ""

                for u in links:
                    try:
                        resp2 = page.goto(u, wait_until="domcontentloaded", timeout=60000)
                        status2 = resp2.status if resp2 else None
                        time.sleep(args.sleep + random.random() * 0.8)

                        okp, status2 = ensure_not_blocked(page, status2, debug_dir, f"blocked_product_{barcode}", args.manual_captcha, args.headful, args.sleep)
                        if not okp:
                            continue

                        ph = page.content()
                        hit = parse_product_page(ph, u)

                        if hit.barcode and normalize_barcode(hit.barcode) == barcode:
                            hit.score = 1.0
                            hit.note = "Barkod birebir eşleşti"
                            best = hit
                            best_reason = "barcode"
                            break

                        ov, common = token_overlap(title_hint, hit.title)
                        if args.accept_recommendations and ov >= args.min_token_overlap:
                            hit.score = max(hit.score, 0.85)
                            hit.note = f"Öneri kabul: token overlap={ov} ({', '.join(common[:6])})"
                            best = hit
                            best_reason = "token"
                            break

                        bscore = similarity(hit.brand, brand_hint) if brand_hint else 0.0
                        tscore = similarity(hit.title, title_hint) if title_hint else 0.0
                        hit.score = 0.35 * bscore + 0.65 * tscore
                        hit.note = f"Benzerlik: title={tscore:.2f} brand={bscore:.2f}"

                        if best is None or hit.score > best.score:
                            best = hit
                            best_reason = "score"

                    except PWTimeoutError:
                        continue
                    except Exception:
                        continue

                if best is None:
                    df.at[i, "Trendyol_Durum"] = "Hayır"
                    df.at[i, "Trendyol_Not"] = "Ürün sayfası okunamadı veya eşleşme yok"
                    print(f"[{idx_i}/{total_todo}] YOK   | {barcode} | eşleşme yok")
                else:
                    # Her durumda Excel'e bir şey yaz
                    df.at[i, "Trendyol_URL"] = best.url
                    df.at[i, "Trendyol_KategoriYolu"] = best.category_path
                    df.at[i, "Trendyol_Barkod"] = best.barcode
                    df.at[i, "Trendyol_Marka"] = best.brand
                    df.at[i, "Trendyol_UrunAdi"] = best.title
                    df.at[i, "Trendyol_Skor"] = float(best.score)
                    df.at[i, "Trendyol_Not"] = best.note + f" | reason={best_reason}"

                    if best.score >= args.threshold or best_reason in ("token", "barcode") or args.force_first:
                        df.at[i, "Trendyol_Durum"] = "Evet"
                        found += 1
                        print(f"[{idx_i}/{total_todo}] EVET  | {barcode} | skor={best.score:.3f} | {best_reason}")
                    else:
                        df.at[i, "Trendyol_Durum"] = "Hayır"
                        print(f"[{idx_i}/{total_todo}] HAYIR | {barcode} | skor={best.score:.3f} | {best_reason}")

            except Exception as e:
                df.at[i, "Trendyol_Durum"] = "Hayır"
                df.at[i, "Trendyol_Not"] = f"Hata: {e}"
                print(f"[{idx_i}/{total_todo}] HATA  | {barcode} | {e}")

            processed += 1
            if processed % args.save_every == 0:
                tmp_path = str(Path(args.out_path).with_suffix("")) + "_partial.xlsx"
                df.to_excel(tmp_path, index=False)
                df.to_excel(args.out_path, index=False)
                print(f"Ara kayıt: {tmp_path} | Kalan: {total_todo-idx_i} | Bulunan: {found}")

        context.close()

    df.to_excel(args.out_path, index=False)
    print(f"Tamamlandı. Kalan: 0 | Toplam bulunan: {found} | Çıktı: {args.out_path}")
    return 0

if __name__ == "__main__":
    raise SystemExit(main())
