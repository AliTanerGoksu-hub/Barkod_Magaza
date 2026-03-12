@echo off
echo Derleme baslatiliyor...
echo.

REM .NET SDK kontrolü
dotnet --version >nul 2>&1
if errorlevel 1 (
    echo HATA: .NET SDK bulunamadi!
    echo Lutfen .NET 6.0 SDK yukleyin: https://dotnet.microsoft.com/download/dotnet/6.0
    pause
    exit /b 1
)

REM Publish (self-contained, tek dosya)
echo [1/2] Derleniyor (self-contained)...
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o publish

if errorlevel 1 (
    echo HATA: Derleme basarisiz!
    pause
    exit /b 1
)

echo.
echo [2/2] Derleme tamamlandi!
echo.
echo Dosyalar: publish\ klasorunde
echo.
echo Simdi install.bat calistirin.
pause
