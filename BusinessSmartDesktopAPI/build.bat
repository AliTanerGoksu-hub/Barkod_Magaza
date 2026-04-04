@echo off
echo ================================================
echo   BusinessSmart Desktop API - Derleme ve Yayinlama
echo ================================================
echo.

REM .NET SDK kontrolu
dotnet --version >nul 2>&1
if errorlevel 1 (
    echo HATA: .NET SDK bulunamadi!
    echo Lutfen .NET 8.0 SDK yukleyin: https://dotnet.microsoft.com/download/dotnet/8.0
    pause
    exit /b 1
)

echo .NET SDK Versiyon:
dotnet --version
echo.

REM Onceki publish klasorunu temizle
if exist "publish" (
    echo Onceki publish klasoru temizleniyor...
    rmdir /s /q publish
)

REM Publish (self-contained, tek dosya)
echo [1/2] Derleniyor (self-contained, win-x64)...
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -o publish

if errorlevel 1 (
    echo.
    echo HATA: Derleme basarisiz!
    pause
    exit /b 1
)

echo.
echo [2/2] Derleme tamamlandi!
echo.
echo ================================================
echo   Dosyalar: publish\ klasorunde
echo ================================================
echo.
echo Kullanim:
echo   1. publish\ klasorunu sunucuya kopyalayin
echo   2. appsettings.json icinde baglanti bilgilerini duzenleyin
echo   3. BusinessSmartDesktopAPI.exe calistirin
echo.
pause
