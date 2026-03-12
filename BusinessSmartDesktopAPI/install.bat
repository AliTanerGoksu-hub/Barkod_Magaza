@echo off
echo ============================================
echo   Business Smart Desktop API - Installer
echo ============================================

REM Klasörleri oluştur
echo.
echo [1/4] Klasörler oluşturuluyor...
if not exist "C:\BusinessSmartFiles" mkdir "C:\BusinessSmartFiles"
if not exist "C:\BusinessSmartFiles\Updates" mkdir "C:\BusinessSmartFiles\Updates"
if not exist "C:\BusinessSmartFiles\Updates\x64" mkdir "C:\BusinessSmartFiles\Updates\x64"
if not exist "C:\BusinessSmartFiles\Updates\x86" mkdir "C:\BusinessSmartFiles\Updates\x86"
if not exist "C:\BusinessSmartFiles\Backups" mkdir "C:\BusinessSmartFiles\Backups"
if not exist "C:\Program Files\BusinessSmartDesktopAPI" mkdir "C:\Program Files\BusinessSmartDesktopAPI"
echo    Klasörler oluşturuldu!

REM Dosyaları kopyala
echo.
echo [2/4] Dosyalar kopyalanıyor...
xcopy /E /Y /I "publish\*" "C:\Program Files\BusinessSmartDesktopAPI\"
echo    Dosyalar kopyalandı!

REM Windows Service olarak kaydet
echo.
echo [3/4] Windows Service kaydediliyor...
sc stop BusinessSmartDesktopAPI 2>nul
sc delete BusinessSmartDesktopAPI 2>nul
sc create BusinessSmartDesktopAPI binPath= "\"C:\Program Files\BusinessSmartDesktopAPI\BusinessSmartDesktopAPI.exe\"" start= auto DisplayName= "Business Smart Desktop API"
sc description BusinessSmartDesktopAPI "Business Smart güncelleme ve yedekleme API servisi"
echo    Service kaydedildi!

REM Servisi başlat
echo.
echo [4/4] Service başlatılıyor...
sc start BusinessSmartDesktopAPI
echo    Service başlatıldı!

echo.
echo ============================================
echo   Kurulum tamamlandı!
echo ============================================
echo.
echo   API adresi: http://localhost:8080
echo   Updates: C:\BusinessSmartFiles\Updates
echo   Backups: C:\BusinessSmartFiles\Backups
echo.
echo   Cloudflare Tunnel'a ekleyin:
echo   desktop.barkodyazilimevi.com -> http://localhost:8080
echo.
pause
