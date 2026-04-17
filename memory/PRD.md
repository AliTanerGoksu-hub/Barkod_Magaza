# Barkod Magaza ERP/POS - Product Requirements Document

## Original Problem Statement
Multi-platform ERP/POS ecosystem with:
1. Desktop VB.NET Windows Forms app (DevExpress, OleDb/SQL Server)
2. C# .NET 8 Web API Mobile Backend (Dapper)
3. .NET MAUI Blazor Mobile App

## Architecture
```
/app/ (Barkod_Magaza) - Desktop VB.NET
/tmp/New_Backend/ - C# .NET 8 Web API
/tmp/New_Mobile/ - MAUI Blazor Mobile
```

## Completed Work
- [x] Image Migration Tool (Frm_Resim_Cevir.vb) - varbinary fix
- [x] MAUI Demo Mode lock
- [x] App Store "demo" word removal
- [x] iOS Build Error fix
- [x] MAUI Route Auto-Refresh timers
- [x] Toplu Maliyet KDV doubling fix
- [x] **Araya Satir Ekle (frm_fatura.vb)** - ORDER BY + DefaultView.Sort + bSatirKontrol bypass
- [x] **Araya Satir Ekle (frm_tbSiparis.vb)** - Yeni özellik: toolbar + sağ tık menüsü
- [x] **Maliyet çift KDV fix** - İkinci KDV sadece oran farkında, normal durumda eklenmez
- [x] **Alış fiyatı fix** - lBrutFiyat yerine lGirisTutar/lGirisMiktar1 (iskonto dahil)
- [x] **Web gönderim stok filtresi** - stok<=0 varyantlar + varyantsız ürün kontrolü
- [x] **AI Toplu İşlem** - Seçili checkbox'lara göre AI üretim + DB kayıt
- [x] **AI beden tablosu** - Giyim kategorilerine özel, ürün bedenleri DB'den okunuyor
- [x] **AI donma sorunu** - Task.Run ile async çalışma

## In Progress / Pending
- Kullanıcı testi bekleniyor: Toplu Maliyetlendir doğruluğu
- Kullanıcı testi bekleniyor: AI beden tablosu çıktı kalitesi

## Backlog (Prioritized)
- P1: Cost calculation standardization (FIFO, LIFO, Weighted Average)
- P1: E-Fatura/E-Arsiv auto-matching logic
- P2: AI usage logs UI (frm_AIKullanimRaporu)

## Key DB Schema
- `tbStokFisiDetayi`: Invoice row details. `nEkSaha1` = physical row order
- `tbStokResmi`: Legacy images (varbinary)
- `tbStokUzunNot`: sBedenTablosu, sUzunNot, sOzellikler, sKullanimTalimati
- `tbStokAIIcerik`: AI generated content (SEO, descriptions, size charts)
- `tbSiparis`: Order rows. `nSiparisID` = primary key, ORDER BY for display

## Critical Notes
- /tmp/ directories volatile (Kubernetes wipes between steps)
- User language: Turkish
- Always push changes via git bash
- DevExpress grid: Use ORDER BY in SQL + DataTable manipulation for row ordering
- AI prompts: CP1254 encoding for AIService.vb, UTF-8-sig for frm_AIUrunIsle.vb
- Maliyet: lGirisTutar = KDV hariç net tutar, tek KDV ekleme yeterli
