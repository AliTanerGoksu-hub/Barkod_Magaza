using System;
using System.Collections.Generic;

namespace BusinessSmartDesktopAPI.Services
{
    public class KuralMotoru
    {
        // Kural bazli risk aciklamasi ve oneriler (AI olmadan da calisir)
        public static (string aciklama, List<string> oneriler, string satisKarari) RiskDegerlendirme(
            decimal bakiye, decimal gecikmisBakiye, int gecikmisTaksit, int maxGecikmeGun,
            decimal krediLimiti, int bekleyenAdet, decimal bekleyenTutar, int ortOdemeSuresi,
            int riskSkor)
        {
            var aciklamaParcalari = new List<string>();
            var oneriler = new List<string>();

            // BAKIYE DURUMU
            if (bakiye <= 0 && gecikmisBakiye <= 0)
            {
                aciklamaParcalari.Add("Musterinin borcu bulunmuyor, temiz bir hesap durumuna sahip.");
            }
            else
            {
                aciklamaParcalari.Add($"Musteri toplam {bakiye:N2} TL bakiyeye sahip.");
            }

            // GECIKME ANALIZI
            if (gecikmisBakiye > 0)
            {
                aciklamaParcalari.Add($"{gecikmisTaksit} adet odeme/taksit gecikme durumunda. Toplam geciken tutar: {gecikmisBakiye:N2} TL. En uzun gecikme suresi: {maxGecikmeGun} gun.");

                if (maxGecikmeGun > 90)
                {
                    oneriler.Add("ACIL: 90 gunu asan gecikme mevcut. Yasal tahsilat sureci baslatilmali.");
                    oneriler.Add("Tum veresiye satislar durdurulmali, sadece nakit/pesinat ile calisilmali.");
                }
                else if (maxGecikmeGun > 60)
                {
                    oneriler.Add("60 gun ustu gecikme var. Resmi ihtar/bildirim gonderilmeli.");
                    oneriler.Add("Yeni siparis oncesi en az %50 odeme alinmali.");
                }
                else if (maxGecikmeGun > 45)
                {
                    oneriler.Add("45 gunu asan gecikme nedeniyle veresiye satis sinirlandirilmali.");
                    oneriler.Add("Musteri ile taksit plani gorusulmeli.");
                }
                else if (maxGecikmeGun > 30)
                {
                    oneriler.Add("30 gun ustu gecikme var. Musteri ile odeme plani gorusmesi yapilmali.");
                }
                else if (maxGecikmeGun > 0)
                {
                    oneriler.Add("Kisa sureli gecikme mevcut. Telefonla hatirlatma yapilmali.");
                }
            }

            // KREDI LIMIT ANALIZI
            if (krediLimiti > 0)
            {
                decimal toplamYuk = bakiye + bekleyenTutar;
                decimal kullanımOrani = toplamYuk / krediLimiti * 100;
                aciklamaParcalari.Add($"Kredi limiti: {krediLimiti:N2} TL. Kullanim orani: %{kullanımOrani:N0} (Bakiye + Bekleyen: {toplamYuk:N2} TL).");

                if (toplamYuk > krediLimiti)
                {
                    oneriler.Add($"UYARI: Kredi limiti {(toplamYuk - krediLimiti):N2} TL asilmis! Yeni satis yapmadan once odeme alinmali.");
                }
                else if (kullanımOrani > 80)
                {
                    oneriler.Add("Kredi limiti %80 uzeri kullanilmis. Yeni satislarda dikkatli olunmali.");
                }
            }
            else
            {
                aciklamaParcalari.Add("Kredi limiti tanimlanmamis. Limit belirlenmesi onerilir.");
                if (bakiye > 50000)
                {
                    oneriler.Add("Yuksek bakiye olan musteri icin kredi limiti tanimlanmali.");
                }
            }

            // BEKLEYEN SIPARIS/TESLIM
            if (bekleyenAdet > 0)
            {
                aciklamaParcalari.Add($"{bekleyenAdet} adet bekleyen siparis/teslim var (Toplam: {bekleyenTutar:N2} TL).");
                if (gecikmisBakiye > 0)
                {
                    oneriler.Add("Bekleyen teslimatlar ve geciken odeme birlikte risk olusturuyor. Teslim oncesi odeme sartli olarak yapilabilir.");
                }
            }

            // ODEME ALISKANLIGI
            if (ortOdemeSuresi > 15)
            {
                aciklamaParcalari.Add($"Musterinin ortalama odeme suresi vadeden {ortOdemeSuresi} gun sonra. Odeme disiplini zayif.");
                oneriler.Add("Odeme vadelerini kısaltmayi veya pesinat oranini artirmayi dusunun.");
            }
            else if (ortOdemeSuresi > 5)
            {
                aciklamaParcalari.Add($"Musteri genellikle vadeden {ortOdemeSuresi} gun sonra odeme yapiyor.");
            }
            else if (bakiye > 0)
            {
                aciklamaParcalari.Add("Musteri odeme disiplini genel olarak iyi.");
            }

            // SATIS KARARI
            string satisKarari;
            if (riskSkor >= 70)
            {
                satisKarari = "EVET - Musteri guvenli seviyede. Normal satis yapilabilir.";
                if (oneriler.Count == 0)
                {
                    oneriler.Add("Musteriye yeni kampanya ve urun onerileri yapilabilir.");
                    oneriler.Add("Sadakat programi veya toplu alim indirimi teklif edilebilir.");
                }
            }
            else if (riskSkor >= 40)
            {
                satisKarari = "SARTLI - Dikkatli olunmali. Kucuk tutarli veya pesinatli satis yapilabilir.";
                if (!oneriler.Exists(o => o.Contains("odeme")))
                {
                    oneriler.Add("Yeni satis yapmadan once mevcut geciken odemelerin durumunu kontrol edin.");
                }
            }
            else
            {
                satisKarari = "HAYIR - Yuksek risk! Veresiye satis yapilmamali. Sadece nakit veya on odemeli calisilmali.";
            }

            string aciklama = string.Join("\n", aciklamaParcalari);
            return (aciklama, oneriler, satisKarari);
        }
    }
}
