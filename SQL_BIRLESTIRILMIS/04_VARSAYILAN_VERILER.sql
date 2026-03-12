-- =====================================================================
-- BARKOD MAGAZA - VARSAYILAN VERİLER
-- =====================================================================
-- Versiyon: 1.0
-- Tarih: Ocak 2025
-- Açıklama: Sistem için gerekli varsayılan veriler
-- =====================================================================

USE [VERITABANI_ADINIZ]
GO

PRINT '╔══════════════════════════════════════════════════════════════╗'
PRINT '║     VARSAYILAN VERİLER EKLENIYOR                             ║'
PRINT '╚══════════════════════════════════════════════════════════════╝'
PRINT ''

-- =====================================================================
-- 1. E-TİCARET PAZAR YERİ PARAMETRELERİ
-- =====================================================================
PRINT '▶ 1. E-Ticaret Pazar Yeri Parametreleri'
GO

IF NOT EXISTS (SELECT * FROM tbParamETicaret WHERE sKodu = 'TY')
BEGIN
    INSERT INTO tbParamETicaret (sPazarYeri, sKodu, sSiparisNoOnek, nKomisyonOrani, lKargoSabitBedel, nIadeOperasyonOrani, nPaketlemeOrani, lOdemeIslemSabitUcret, bAktif, sKullaniciAdi)
    VALUES 
    ('Trendyol', 'TY', 'ty(', 15.00, 25.00, 3.00, 5.00, 10.00, 1, 'Admin'),
    ('HepsiBurada', 'HB', 'Hb(', 12.00, 20.00, 3.00, 5.00, 10.00, 1, 'Admin'),
    ('N11', 'N11', 'n11', 14.00, 22.00, 2.50, 5.00, 10.00, 1, 'Admin'),
    ('Amazon', 'AM', 'am(', 15.00, 30.00, 3.00, 5.00, 10.00, 1, 'Admin'),
    ('GittiGidiyor', 'GG', 'gg(', 10.00, 20.00, 2.00, 5.00, 10.00, 1, 'Admin'),
    ('Çiçek Sepeti', 'CS', 'cs(', 18.00, 25.00, 3.50, 5.00, 10.00, 1, 'Admin'),
    ('Kitapyurdu', 'KY', 'ky(', 20.00, 15.00, 2.00, 5.00, 10.00, 1, 'Admin'),
    ('Pttavm', 'PT', 'pt(', 12.50, 18.00, 2.50, 5.00, 10.00, 1, 'Admin'),
    ('Morhipo', 'MH', 'mh(', 16.00, 22.00, 3.00, 5.00, 10.00, 1, 'Admin')
    
    PRINT '  ✓ E-ticaret pazar yeri parametreleri eklendi (9 adet)'
END
ELSE
    PRINT '  - E-ticaret parametreleri zaten mevcut'
GO

-- =====================================================================
-- 2. AUDIT İŞLEM TİPLERİ
-- =====================================================================
PRINT ''
PRINT '▶ 2. Audit İşlem Tipleri'
GO

IF NOT EXISTS (SELECT * FROM tbAuditIslemTipleri WHERE sIslemKodu = 'INSERT')
BEGIN
    INSERT INTO [dbo].[tbAuditIslemTipleri] ([sIslemKodu], [sIslemAdi], [sAciklama], [sRenk], [nSiraNo])
    VALUES 
        ('INSERT', 'Yeni Kayıt', 'Yeni kayıt oluşturuldu', 'Green', 1),
        ('UPDATE', 'Güncelleme', 'Kayıt güncellendi', 'Blue', 2),
        ('DELETE', 'Silme', 'Kayıt silindi', 'Red', 3),
        ('APPROVE', 'Onay', 'Kayıt onaylandı', 'DarkGreen', 4),
        ('CANCEL', 'İptal', 'Kayıt iptal edildi', 'Orange', 5),
        ('RESTORE', 'Geri Yükleme', 'Silinen kayıt geri yüklendi', 'Purple', 6),
        ('ROLLBACK', 'Geri Alma', 'İşlem geri alındı', 'DarkRed', 7),
        ('VIEW', 'Görüntüleme', 'Kayıt görüntülendi', 'Gray', 8),
        ('PRINT', 'Yazdırma', 'Kayıt yazdırıldı', 'Navy', 9),
        ('EXPORT', 'Dışa Aktarma', 'Kayıt dışa aktarıldı', 'Teal', 10)
    
    PRINT '  ✓ Audit işlem tipleri eklendi (10 adet)'
END
ELSE
    PRINT '  - Audit işlem tipleri zaten mevcut'
GO

-- =====================================================================
-- 3. AUDIT MODÜLLER
-- =====================================================================
PRINT ''
PRINT '▶ 3. Audit Modüller'
GO

IF NOT EXISTS (SELECT * FROM tbAuditModuller WHERE sModulKodu = 'SIPARIS')
BEGIN
    INSERT INTO [dbo].[tbAuditModuller] ([sModulKodu], [sModulAdi], [sAciklama], [sAnaTabloAdi], [bLogAktif], [bDetayliLog], [nSiraNo])
    VALUES 
        ('SIPARIS', 'Sipariş Yönetimi', 'Satın alma ve satış siparişleri', 'tbSiparis', 1, 1, 1),
        ('FATURA', 'Fatura İşlemleri', 'Alış ve satış faturaları', 'tbStokFisiMaster', 1, 1, 2),
        ('PERAKENDE', 'Perakende Satış', 'POS satış işlemleri', 'tbStokFisiMaster', 1, 1, 3),
        ('STOK', 'Stok Yönetimi', 'Stok kartı ve hareket işlemleri', 'tbStok', 1, 1, 4),
        ('MUSTERI', 'Müşteri/Cari Yönetimi', 'Müşteri ve cari kart işlemleri', 'tbCari', 1, 1, 5),
        ('FINANS', 'Finans İşlemleri', 'Kasa, banka, çek işlemleri', 'tbFinans', 1, 1, 6),
        ('ETICARET', 'E-Ticaret', 'E-ticaret sipariş ve entegrasyon işlemleri', 'tbEticaretSiparis', 1, 1, 7),
        ('PERSONEL', 'Personel Yönetimi', 'Personel ve yetki işlemleri', 'tbPersonel', 1, 0, 8),
        ('PARAMETRE', 'Parametre Yönetimi', 'Sistem parametreleri', 'tbParametre', 1, 0, 9),
        ('SISTEM', 'Sistem İşlemleri', 'Genel sistem işlemleri', NULL, 1, 0, 10)
    
    PRINT '  ✓ Audit modülleri eklendi (10 adet)'
END
ELSE
    PRINT '  - Audit modülleri zaten mevcut'
GO

-- =====================================================================
-- 4. BİLDİRİM TİPLERİ
-- =====================================================================
PRINT ''
PRINT '▶ 4. Bildirim Tipleri'
GO

IF NOT EXISTS (SELECT * FROM tbBildirimTipleri WHERE sTipKodu = 'SIPARIS_ONAY')
BEGIN
    INSERT INTO tbBildirimTipleri (sTipKodu, sTipAdi, bEmailVarsayilan, bSMSVarsayilan, bWhatsAppVarsayilan, bUygulamaVarsayilan) VALUES
    ('SIPARIS_ONAY', 'Siparis Onayi', 1, 0, 0, 1),
    ('URETIM_EMRI_YENI', 'Yeni Uretim Emri', 1, 0, 1, 1),
    ('URETIM_RECETE_EKSIK', 'Uretim Recetesi Eksik', 1, 1, 1, 1),
    ('SATINALMA_SIPARIS_OLUSTURULDU', 'Satin Alma Siparisi Olusturuldu', 1, 1, 1, 1),
    ('SIPARIS_ONAYLANDI', 'Siparis Onaylandi', 1, 0, 1, 1),
    ('URETIM_ASAMA_BASLADI', 'Uretim Asamasi Basladi', 0, 0, 1, 1),
    ('URETIM_ASAMA_TAMAMLANDI', 'Uretim Asamasi Tamamlandi', 0, 0, 1, 1),
    ('URETIM_ONAY_TALEBI', 'Uretim Onay Talebi', 1, 1, 1, 1),
    ('URETIM_ONAY_REDDEDILDI', 'Uretim Onayi Reddedildi', 1, 1, 1, 1),
    ('SATINALMA_ONAY_TALEBI', 'Satin Alma Onay Talebi', 1, 1, 1, 1),
    ('SATINALMA_ONAYLANDI', 'Satin Alma Onaylandi', 1, 0, 1, 1),
    ('SATINALMA_REDDEDILDI', 'Satin Alma Reddedildi', 1, 1, 1, 1),
    ('GOREV_OLUSTURULDU', 'Yeni Gorev', 1, 0, 1, 1),
    ('GOREV_TAMAMLANDI', 'Gorev Tamamlandi', 1, 0, 0, 1),
    ('MALIYET_ALTI_SATIS', 'Maliyet Alti Satis', 1, 1, 1, 1),
    ('KRITIK_STOK', 'Kritik Stok Seviyesi', 1, 0, 1, 1),
    ('CEK_VADE_YAKLASTI', 'Cek Vadesi Yaklasti', 1, 1, 0, 1),
    ('SENET_VADE_YAKLASTI', 'Senet Vadesi Yaklasti', 1, 1, 0, 1),
    ('ETICARET_YENI_SIPARIS', 'E-Ticaret Yeni Siparis', 1, 1, 1, 1),
    ('BELGE_SILINDI', 'Kritik Belge Silindi', 1, 0, 0, 1),
    ('YUKSEK_NAKIT_ISLEM', 'Yuksek Tutarli Nakit Islem', 1, 1, 1, 1)
    
    PRINT '  ✓ Bildirim tipleri eklendi (21 adet)'
END
ELSE
    PRINT '  - Bildirim tipleri zaten mevcut'
GO

-- =====================================================================
-- 5. SİSTEM AYARLARI
-- =====================================================================
PRINT ''
PRINT '▶ 5. Sistem Ayarları'
GO

IF NOT EXISTS (SELECT * FROM tbSistemAyar WHERE sAnahtar = 'EMAIL_AKTIF')
BEGIN
    INSERT INTO tbSistemAyar (sAnahtar, sDeger, sAciklama, sKategori) VALUES
    ('EMAIL_AKTIF', '0', 'Email bildirimi aktif mi', 'EMAIL'),
    ('EMAIL_SMTP_HOST', '', 'SMTP sunucu adresi', 'EMAIL'),
    ('EMAIL_SMTP_PORT', '587', 'SMTP port', 'EMAIL'),
    ('EMAIL_SMTP_USER', '', 'SMTP kullanici adi', 'EMAIL'),
    ('EMAIL_SMTP_PASS', '', 'SMTP sifre', 'EMAIL'),
    ('EMAIL_FROM', '', 'Gonderen email adresi', 'EMAIL'),
    ('SMS_AKTIF', '0', 'SMS bildirimi aktif mi', 'SMS'),
    ('WHATSAPP_AKTIF', '0', 'WhatsApp bildirimi aktif mi', 'WHATSAPP'),
    ('YUKSEK_TUTAR_LIMITI', '10000', 'Yuksek tutar bildirimi icin limit', 'GENEL'),
    ('VADE_UYARI_GUN', '7', 'Vade uyarisi kac gun once', 'GENEL'),
    ('BILDIRIM_TAKIP_SURESI_SAAT', '24', 'Teslim edilmeyen bildirimler icin uyari suresi', 'BILDIRIM'),
    ('BILDIRIM_TAKIP_AKTIF', '1', 'Bildirim takibi aktif mi', 'BILDIRIM')
    
    PRINT '  ✓ Sistem ayarları eklendi (12 adet)'
END
ELSE
    PRINT '  - Sistem ayarları zaten mevcut'
GO

-- =====================================================================
-- 6. ONAY TÜRLERİ
-- =====================================================================
PRINT ''
PRINT '▶ 6. Onay Türleri'
GO

IF NOT EXISTS (SELECT * FROM tbOnayTurleri WHERE sOnayTurKodu = 'URETIM_YETKILISI')
BEGIN
    INSERT INTO tbOnayTurleri (sOnayTurKodu, sOnayTurAdi, nOncelik, sAciklama) VALUES
    ('URETIM_YETKILISI', 'Uretim Yetkilisi', 1, 'Uretim hatti sorumlusu'),
    ('KALITE_KONTROL', 'Kalite Kontrol', 2, 'Kalite kontrol sorumlusu'),
    ('FIRMA_YETKILISI', 'Firma Yetkilisi', 3, 'Fabrika muduru'),
    ('YONETICI', 'Ust Yonetici', 4, 'Genel mudur')
    
    PRINT '  ✓ Onay türleri eklendi (4 adet)'
END
ELSE
    PRINT '  - Onay türleri zaten mevcut'
GO

-- =====================================================================
-- 7. AI PARAMETRELER VARSAYILAN DEĞERLERİ
-- =====================================================================
PRINT ''
PRINT '▶ 7. AI Parametreleri Varsayılan Değerler'
GO

IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbParamGenel')
BEGIN
    UPDATE tbParamGenel SET 
        bAIKullan = ISNULL(bAIKullan, 1),
        bBaslikOlustur = ISNULL(bBaslikOlustur, 1),
        bAciklamaOlustur = ISNULL(bAciklamaOlustur, 1),
        bKapsamliIcerik = ISNULL(bKapsamliIcerik, 1),
        bTalimatOlustur = ISNULL(bTalimatOlustur, 1),
        bBedenTablosuOlustur = ISNULL(bBedenTablosuOlustur, 1)
    WHERE bAIKullan IS NULL OR bAIKullan = 0
    
    PRINT '  ✓ AI parametreleri aktifleştirildi'
END
GO

-- =====================================================================
-- ÖZET
-- =====================================================================
PRINT ''
PRINT '╔══════════════════════════════════════════════════════════════╗'
PRINT '║     VARSAYILAN VERİLER EKLENDİ!                              ║'
PRINT '╚══════════════════════════════════════════════════════════════╝'
PRINT ''
PRINT 'Eklenen Veriler:'
PRINT '  - E-ticaret pazar yeri parametreleri (9 adet)'
PRINT '  - Audit işlem tipleri (10 adet)'
PRINT '  - Audit modülleri (10 adet)'
PRINT '  - Bildirim tipleri (21 adet)'
PRINT '  - Sistem ayarları (12 adet)'
PRINT '  - Onay türleri (4 adet)'
PRINT ''
PRINT '⚠️  ÖNEMLİ: Aşağıdaki değerleri kendi ihtiyaçlarınıza göre güncelleyin:'
PRINT '  - tbParamETicaret: Komisyon oranları, kargo bedelleri'
PRINT '  - tbParamGenel.DefaultImageUrl: Varsayılan resim URL''si'
PRINT '  - tbSistemAyar: Email/SMS/WhatsApp ayarları'
PRINT ''
PRINT 'Sonraki adım: 05_TEST_KONTROL.sql (kurulumu doğrulamak için)'
GO
