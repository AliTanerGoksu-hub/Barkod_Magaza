# Barkod Magaza - POS/ERP Application PRD

## Original Problem Statement
VB.NET Windows Forms POS/ERP uygulaması (Barkod_Magaza) üzerinde geliştirme ve bakım çalışmaları.

## Core Requirements
- B2B yönetim sekmeleri ve işlevselliği ekleme
- POS API entegrasyonları için hata yönetimini iyileştirme
- R2 image upload (Sınıf ve Firma logoları)
- Otomatik yedekleme hatalarını düzeltme ve FTP'den C# .NET API'ye geçiş
- Değişiklikleri GitHub'a push etme

## Architecture
- **Frontend**: VB.NET Windows Forms, DevExpress UI Components
- **Backend/API**: C# .NET 8.0 Minimal APIs (BusinessSmartDesktopAPI)
- **Database**: SQL Server (OleDb)
- **File Encoding**: cp1254 / latin-1 for VB files

## Completed Tasks
- [x] B2B Settings tab (frm_personel.vb)
- [x] General B2B Settings form (Form1.vb)
- [x] SQL Scripts for B2B tables
- [x] POS 400 Bad Request error handling (frm_perakende_odeme.vb)
- [x] R2 Image upload for Class Logos (frm_tbSinif.vb)
- [x] Company Logo upload (Form1.vb)
- [x] Automatic backup bugs fixed
- [x] C# API updated to .NET 8.0 with /api/backup/delete endpoint
- [x] ApiClient.vb refactored for API-based backup management
- [x] **Form1.vb derleme hatası düzeltildi** - FtpEskiYedekleriSil_ESKI ve FtpDosyaSil ölü kodları temizlendi (2026-02)

## Pending / In Progress
- Backup API Migration doğrulaması (kullanıcı tarafında test gerekiyor)

## Upcoming Tasks (P1)
- C# API (BusinessSmartDesktopAPI) build.bat çalıştırma ve deploy
- B2B senkronizasyonu uçtan uca testi

## Future / Backlog (P2)
- Form1.vb yedekleme fonksiyonlarının refactoring'i
- Eski FTP kodlarının kalıcı olarak silinmesi

## Key API Endpoints
- GET /api/backup/list
- POST /api/backup/delete
- POST /api/backup/upload

## GitHub
- Repo: https://github.com/AliTanerGoksu-hub/Barkod_Magaza_Git.git
- Branch: main
