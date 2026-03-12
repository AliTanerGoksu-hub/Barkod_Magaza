Option Strict Off
Option Explicit On
Imports System.Management
Imports System.Text
Imports System.Collections
Imports System.Threading
Imports DevExpress.XtraEditors
Imports Microsoft.Win32
Module KeyCode
    Public Const MyProductName As String = "BusinessSolutions"
    Public sDatabaseGenel As String = "Business"
    Public nKayitSinir As Integer = 0
    Public firmano As Integer = 100
    Public donemno As Integer = 1
    Public dteSistemTarihi As DateTime
    Public kullaniciKodu As String = "Admin"
    Public kullanici As String = "1"
    Public perakendeSKasiyer As String = ""
    Public perakendeSKasiyerRumuzu As String = ""
    Public kullaniciadi As String = "Admin"
    Public sDepo As String = "D001"
    Public sSubeMagaza As String = "001"
    Public sHareketTipi As String = "001"
    Public connection As String = ""
    Public SQLconnection As String = ""
    Public sLicenseModule As New System.Windows.Forms.ListBox
    Public sLicensekey As String = ""
    Public sOnayKodu As String = ""
    Public sBilgisayar As String = ""
    Public sOturum As String = ""
    Public bYasal As Boolean = True
    Public sRaporUzanti As String = ""
    Public ds_tbParamGenel As DataSet
    Public ds_tbParamStok As DataSet
    Public ds_tbParamStokKodlama As DataSet
    Public ds_tbParamCari As DataSet
    Public sFiyat1 As String = "1"
    Public sFiyat2 As String = "2"
    Public sFiyat3 As String = "3"
    Public sFiyat4 As String = "4"
    Public sFiyat5 As String = "5"
    Public sFiyat6 As String = "6"
    Public sFiyat7 As String = "7"
    Public sFiyat8 As String = "8"
    Public sFiyat9 As String = "9"
    Public sFiyat10 As String = "10"
    Public sFiyatA As String = "A"
    Public sFiyatM As String = "M"
    Public sAktifFiyatTipi As String = "1"
    Public EsFiyat1 As String = ""
    Public EsFiyat2 As String = ""
    Public EsFiyat3 As String = ""
    Public EsFiyat4 As String = ""
    Public EsFiyat5 As String = ""
    Public EsFiyat6 As String = ""
    Public EsFiyat7 As String = ""
    Public EsFiyat8 As String = ""
    Public EsFiyat9 As String = ""
    Public EsFiyat10 As String = ""
    Public EsFiyatA As String = ""
    Public EsFiyatM As String = ""
    Public sKrediliFiyat As String = ""
    Public sPesinFiyat As String = ""
    Public dteSonFaturaTarihi As DateTime = "01/01/1900"
    Public dteSonIrsaliyeTarihi As DateTime = "01/01/1900"
    Public dteSonStokFisiTarihi As DateTime = "01/01/1900"
    Public dteSonNakitKasaTarihi As DateTime = "01/01/1900"
    Public nFirmaGrupKodUzunlugu As Int64 = 0
    Public bCalcVadeDagilim As Boolean = False
    Public bOtomatikTaksit As Boolean = False
    Public bOtomatikPesinatDuzelt As Boolean = False
    Public bKdvKontrolluMaliyet As Boolean = False
    Public bSatirKontrol As Boolean = False
    Public bOtomatikMaliyetFiyati As Boolean = False
    Public bOtomatikAlisFiyati As Boolean = False
    Public bAlisFiyatiUyar As Boolean = False
    Public nTaksitGun As Int64 = 0
    Public nTaksitBaslangic As Int64 = 0
    Public nTaksitSayi As Int64 = 1
    Public sKrediliFiyatTipi As String = "1"
    Public sPesinFiyatTipi As String = "1"
    Public bMessageCheck As Boolean = False
    Public bNamazVaktiGosterme As Boolean = True
    Public otoFaaliyetCalistir As Boolean = False
    Public otoFaturaCalistir As Boolean = False
    Public sec_eticaret As Boolean = False
    Public bMagazalarChart As Boolean = False
    Public sSaticiRumuzu As String = ""
    Public PrinterTermal As String = ""
    Public PrinterDepo As String = ""
    Public nFontSize As Decimal = 8.25
    Public bFiyatKdvHaric As Boolean = False
    Public bFaturaKdvDahil As Boolean = False
    Public bFaturaKdvSiz As Boolean = False
    Public bFaturaIskontosuz As Boolean = False
    Public nFaturaCiktiSatirSayisi As Int64 = 25
    Public bIrsaliyeKdvSiz As Boolean = False
    Public bIrsaliyeIskontosuz As Boolean = False
    Public nIrsaliyeCiktiSatirSayisi As Int64 = 25
    Public bStokFisiKdvSiz As Boolean = False
    Public bStokFisiIskontosuz As Boolean = False
    Public nStokFisiCiktiSatirSayisi As Int64 = 25
    Public bTransferEnvanterKontrol As Boolean = False
    Public bTransferTeslimatYok As Boolean = False
    Public sYaziIleGenelToplam As String = "TR"
    Public sBarcodeStd As String = "27"
    Public sBarcodeStd_KG As Integer = 2
    Public sBarcodeStd_GR As Integer = 3
    Public sCariSinirla As String = ""
    Public sStokSinirla As String = ""
    Public sBankaSinirla As String = ""
    Public sFihristSinirla As String = ""
    Public sGiderSinirla As String = ""
    Public sCariSinifKoduSinirla As String = ""
    Public sAltFiyatTipi As String = ""
    Public sDil As String = ""
    Public sDegistirDil As String = ""
    Public bKendiFisNo As Boolean = False
    Public bDovizliFatura As Boolean = False
    Public sStokSinifTipi1 As String = "Sýnýf1"
    Public sStokSinifTipi2 As String = "Sýnýf2"
    Public sStokSinifTipi3 As String = "Sýnýf3"
    Public sStokSinifTipi4 As String = "Sýnýf4"
    Public sStokSinifTipi5 As String = "Sýnýf5"
    Public sStokSinifTipi6 As String = "Sýnýf6"
    Public sStokSinifTipi7 As String = "Sýnýf7"
    Public sStokSinifTipi8 As String = "Sýnýf8"
    Public sStokSinifTipi9 As String = "Sýnýf9"
    Public sStokSinifTipi10 As String = "Sýnýf10"
    Public sStokSinifTipi11 As String = "Sýnýf11"
    Public sStokSinifTipi12 As String = "Sýnýf12"
    Public sStokSinifTipi13 As String = "Sýnýf13"
    Public sStokSinifTipi14 As String = "Sýnýf14"
    Public sStokSinifTipi15 As String = "Sýnýf15"
    Public sDepo1Aciklama As String = ""
    Public sDepo2Aciklama As String = ""
    Public sDepo3Aciklama As String = ""
    Public sDepo4Aciklama As String = ""
    Public sDepo5Aciklama As String = ""
    Public sDepo6Aciklama As String = ""
    Public sDepo7Aciklama As String = ""
    Public sDepo8Aciklama As String = ""
    Public sFiyat1Aciklama As String = ""
    Public sFiyat2Aciklama As String = ""
    Public sFiyat3Aciklama As String = ""
    Public sFiyat4Aciklama As String = ""
    Public sFiyat5Aciklama As String = ""
    Public sFiyat6Aciklama As String = "Alaplý"
    Public sFiyat7Aciklama As String = "7.Fiyat"
    Public sFiyat8Aciklama As String = "8.Fiyat"
    Public sFiyat9Aciklama As String = "9.Fiyat"
    Public sFiyat10Aciklama As String = "10.Fiyat"
    Public bStokAciklamaZorunlumu As Boolean = False
    Public bKisaAdiZorunlumu As Boolean = False
    Public bBirimCinsi1Zorunlumu As Boolean = False
    Public bBirimCinsi2Zorunlumu As Boolean = False
    Public bIskontoYuzdesiZorunlumu As Boolean = False
    Public bKdvTipiZorunlumu As Boolean = False
    Public bTeminSuresiZorunlumu As Boolean = False
    Public bAsgariMiktarZorunlumu As Boolean = False
    Public bAzamiMiktarZorunlumu As Boolean = False
    Public bOzelNotZorunlumu As Boolean = False
    Public bIskontoYuzdesiAVZorunlumu As Boolean = False
    Public bPrimZorunlumu As Boolean = False
    Public bAgirlikZorunlumu As Boolean = False
    Public bHacimZorunlumu As Boolean = False
    Public bFiyatSifirGirilsin As Boolean = False
    Public sDefaultBirimCinsi As String = ""
    Public bEksiyeDusulebilirmi As Boolean = False
    Public sDefaultKdvCinsi As String = ""
    Public sDefaultOTVTipi As String = ""
    Public bAlisPartiNoVar As Boolean = False
    Public bSatisPartiNoVar As Boolean = False
    Public bSinifKodu1Zorunlumu As Boolean = False
    Public bSinifKodu2Zorunlumu As Boolean = False
    Public bSinifKodu3Zorunlumu As Boolean = False
    Public bSinifKodu4Zorunlumu As Boolean = False
    Public bSinifKodu5Zorunlumu As Boolean = False
    Public bSinifKodu6Zorunlumu As Boolean = False
    Public bSinifKodu7Zorunlumu As Boolean = False
    Public bSinifKodu8Zorunlumu As Boolean = False
    Public bSinifKodu9Zorunlumu As Boolean = False
    Public bSinifKodu10Zorunlumu As Boolean = False
    Public bSinifKodu11Zorunlumu As Boolean = False
    Public bSinifKodu12Zorunlumu As Boolean = False
    Public bSinifKodu13Zorunlumu As Boolean = False
    Public bSinifKodu14Zorunlumu As Boolean = False
    Public bSinifKodu15Zorunlumu As Boolean = False
    Public bCariAciklamaZorunlumu As Boolean = False
    Public bCariTCZorunlumu As Boolean = False
    Public bCariAdres1Zorunlumu As Boolean = False
    Public bCariAdres2Zorunlumu As Boolean = False
    Public bCariSemtZorunlumu As Boolean = False
    Public bCariPostaKoduZorunlumu As Boolean = False
    Public bCariIlZorunlumu As Boolean = False
    Public bCariUlkeZorunlumu As Boolean = False
    Public bCariDepoZorunlumu As Boolean = False
    Public bCariSaticiZorunlumu As Boolean = False
    Public bCariVergiDairesiZorunlumu As Boolean = False
    Public bCariVergiNoZorunlumu As Boolean = False
    Public bCariOzelNotZorunlumu As Boolean = False
    Public bCariYetkiliZorunlumu As Boolean = False
    Public bCariIletisimZorunlumu As Boolean = False
    Public bCariSinifKodu1Zorunlumu As Boolean = False
    Public bCariSinifKodu2Zorunlumu As Boolean = False
    Public bCariSinifKodu3Zorunlumu As Boolean = False
    Public bCariSinifKodu4Zorunlumu As Boolean = False
    Public bCariSinifKodu5Zorunlumu As Boolean = False
    Private thread As Thread
    Private [stop] As Boolean
    Private fprogress As frmProgress = Nothing
    Private fkeyboard As frm_Keyboard = Nothing
    Public sAktifTeslimatDepo As String = ""
    Public bAlisFatOtoMuh As Boolean = False
    Public bSatFatOtoMuh As Boolean = False
    Public bPerOtoMuh As Boolean = False
    Public bPerYerelMuh As Boolean = False
    Public bSatirKendiEnvanteri As Boolean = False
    Public ReadOnly Property Progress() As frmProgress
        Get
            If Object.Equals(fprogress, Nothing) Then
                fprogress = New frmProgress()
            End If
            Return fprogress
        End Get
    End Property
    Public ReadOnly Property Keyboard() As frm_Keyboard
        Get
            If Object.Equals(fkeyboard, Nothing) Then
                fkeyboard = New frm_Keyboard
            End If
            Return fkeyboard
        End Get
    End Property
    Public Function GenKeyString(ByVal UserName As Object, ByRef ProdName As String, ByRef F_Code As Integer) As String
        Dim StubStr As Object
        Dim RC2 As Object
        Dim RC1 As Object
        Dim RawChk As Object
        Dim ChrV2 As Object
        Dim ChrV1 As Object
        Dim KeyLow2 As Object
        Dim KeyLow1 As Object
        Dim TempStr As String
        Dim KeyStr As String
        Dim KeyVal As String
        Dim CodeVal As Integer
        Dim CodeLow As Byte
        Dim CodeHigh As Byte
        Dim KeyLowV1 As Byte
        Dim KeyLowV2 As Byte
        ' Make sure we're not case-sensitive since that is a pain for end users
        'UPGRADE_WARNING: Couldn't resolve default property of object UserName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        TempStr = LCase(UserName) & LCase(ProdName)
        KeyStr = DigestStrToHexStr(TempStr)
        KeyVal = HexStrToBinStr(KeyStr)
        ' Mask off low order 16 bits from F_Code
        CodeVal = F_Code And &HFFFFS
        CodeLow = CodeVal And &HFFS
        CodeHigh = ((CShort(CodeVal And &HFF00S) / 256) And &HFFS)
        'UPGRADE_WARNING: Couldn't resolve default property of object KeyLow1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        KeyLow1 = Mid(KeyVal, Len(KeyVal), 1)
        'UPGRADE_WARNING: Couldn't resolve default property of object KeyLow2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        KeyLow2 = Mid(KeyVal, Len(KeyVal) - 1, 1)
        'UPGRADE_WARNING: Couldn't resolve default property of object KeyLow1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        KeyLowV1 = Asc(KeyLow1)
        'UPGRADE_WARNING: Couldn't resolve default property of object KeyLow2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        KeyLowV2 = Asc(KeyLow2)
        KeyLowV1 = (KeyLowV1 Xor CodeLow)
        KeyLowV2 = (KeyLowV2 Xor CodeHigh)
        'KeyLowV1 = KeyLowV1 Xor KeyLowV2
        'UPGRADE_WARNING: Couldn't resolve default property of object ChrV1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        ChrV1 = Chr(KeyLowV1)
        'UPGRADE_WARNING: Couldn't resolve default property of object ChrV2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        ChrV2 = Chr(KeyLowV2)
        ' Cut original first 2 bytes from KeyVal string
        KeyVal = Mid(KeyVal, 1, Len(KeyVal) - 2)
        ' Now append modified bytes
        'UPGRADE_WARNING: Couldn't resolve default property of object ChrV1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ChrV2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        KeyVal = KeyVal & ChrV2 & ChrV1
        'KeyVal = KeyVal & ChrV1
        ' Now we get sneaky and modify the KeyVal by replacing the first 2 bytes
        ' of KeyVal with the first and last bytes of the MD5 of KeyVal minus first 2 bytes
        KeyVal = Mid(KeyVal, 3, Len(KeyVal) - 2)
        'UPGRADE_WARNING: Couldn't resolve default property of object RawChk. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        RawChk = DigestStrToHexStr(KeyVal)
        'UPGRADE_WARNING: Couldn't resolve default property of object RawChk. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'UPGRADE_WARNING: Couldn't resolve default property of object RC1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        RC1 = Mid(RawChk, 1, 2)
        'UPGRADE_WARNING: Couldn't resolve default property of object RawChk. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'UPGRADE_WARNING: Couldn't resolve default property of object RC2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        RC2 = Mid(RawChk, Len(RawChk) - 1, 2)
        'UPGRADE_WARNING: Couldn't resolve default property of object StubStr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        StubStr = BinStrToHexStr(KeyVal)
        'UPGRADE_WARNING: Couldn't resolve default property of object StubStr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'UPGRADE_WARNING: Couldn't resolve default property of object RC2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'UPGRADE_WARNING: Couldn't resolve default property of object RC1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        GenKeyString = RC1 & RC2 & StubStr
    End Function
    Public Function hdd() As String
        Dim disk As New ManagementClass("Win32_PhysicalMedia")
        Dim s As String = ""
        For Each Hdisk As ManagementObject In disk.GetInstances()
            If Hdisk("SerialNumber") <> Nothing Then
                s += CStr(Hdisk("SerialNumber"))
            End If
        Next Hdisk
        Return Trim(s)
    End Function
    Public Function ParseCIMDateTime(ByVal wmiDate As String) As DateTime
        'datetime object to store the return value
        Dim [date] As DateTime = DateTime.MinValue
        'check date integrity
        If wmiDate IsNot Nothing AndAlso wmiDate.IndexOf("."c) <> -1 Then
            'obtain the date with miliseconds
            Dim tempDate As String = wmiDate.Substring(0, wmiDate.IndexOf("."c) + 4)
            'check the lenght
            If tempDate.Length = 18 Then
                'extract each date component
                Dim year As Integer = Convert.ToInt32(tempDate.Substring(0, 4))
                Dim month As Integer = Convert.ToInt32(tempDate.Substring(4, 2))
                Dim day As Integer = Convert.ToInt32(tempDate.Substring(6, 2))
                Dim hour As Integer = Convert.ToInt32(tempDate.Substring(8, 2))
                Dim minute As Integer = Convert.ToInt32(tempDate.Substring(10, 2))
                Dim second As Integer = Convert.ToInt32(tempDate.Substring(12, 2))
                Dim milisecond As Integer = Convert.ToInt32(tempDate.Substring(15, 3))
                'compose the new datetime object
                [date] = New DateTime(year, month, day, hour, minute, second, _
                 milisecond)
            End If
        End If
        'return datetime
        Return [date]
    End Function
    Public Function Systemdaten(ByVal iQuery As Integer) As String
        Dim s As String = ""
        Dim query As String = "SELECT * FROM Win32_OperatingSystem"
        Dim sucher As New ManagementObjectSearcher(query)
        Dim oReturnCollection As ManagementObjectCollection = sucher.[Get]()
        For Each m As ManagementObject In oReturnCollection
            Select Case iQuery
                Case 1
                    Dim lastBootUp As DateTime = ParseCIMDateTime(m("LastBootUpTime").ToString())
                    s += lastBootUp.ToString("dd.MM.yyyy HH:mm") & vbLf
                    Exit Select
                Case 2
                    s += CalcSize(m("FreePhysicalMemory").ToString(), 2) & vbLf
                    Exit Select
                Case 3
                    s += m("CSName").ToString() & vbLf
                    Exit Select
                Case 4
                    s += m("RegisteredUser").ToString() & vbLf
                    Exit Select
                Case 5
                    s += m("Caption").ToString() & vbLf
                    Exit Select
                Case 6
                    s += m("CSDVersion").ToString() & vbLf
                    Exit Select
            End Select
        Next
        Return s
    End Function
    Private Function CalcSize(ByVal sVal As String, ByVal iType As Integer) As String
        Dim sCalc As String = ""
        Dim Mbytes As Single = 0
        Select Case iType
            Case 1
                Mbytes = CSng((Convert.ToInt64(sVal) \ 1024) \ 1024)
                Exit Select
            Case 2
                Mbytes = CSng(Convert.ToInt64(sVal) \ 1024)
                Exit Select
        End Select
        If Mbytes > 1024 Then
            Mbytes = Mbytes / 1024
            sCalc = Mbytes.ToString("N2") & " GB "
        Else
            sCalc = Mbytes.ToString() & " MB "
        End If
        Return sCalc
    End Function
    Public Function Disk() As String
        Dim s As String = ""
        Dim sLetter As String = ""
        Dim sFSType As String = ""
        Dim sSerial As String = ""
        Dim query As String = "SELECT * FROM Win32_LogicalDisk WHERE FileSystem IS NOT NULL"
        Dim sucher As New ManagementObjectSearcher(query)
        Dim oReturnCollection As ManagementObjectCollection = sucher.[Get]()
        For Each m As ManagementObject In oReturnCollection
            sLetter = m("DeviceID").ToString()
            sFSType = m("FileSystem").ToString()
            If sLetter = "C:" Then
                sSerial = m("VolumeSerialNumber").ToString
            Else
                sSerial = ""
            End If
            s += sLetter & " " & CalcSize(m("FreeSpace").ToString(), 1) & " " & sFSType & vbLf & "Serial: " & sSerial
        Next
        Return s
    End Function
    Public Function Netzwerk(ByVal iQuery As Integer) As String
        Dim s As String = ""
        Dim query As String = "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = TRUE"
        Dim sucher As New ManagementObjectSearcher(query)
        Dim oReturnCollection As ManagementObjectCollection = sucher.[Get]()
        For Each m As ManagementObject In oReturnCollection
            Select Case iQuery
                Case 1
                    Try
                        For Each r As String In TryCast(m("IPAddress"), Array)
                            If r.Length < 25 AndAlso r.Length > 6 Then
                                s += r & vbLf & Netzwerkadapter(r) & vbLf
                            End If
                        Next
                    Catch
                    End Try
                    Exit Select
                Case 2
                    Try
                        For Each r As String In TryCast(m("IPSubnet"), Array)
                            s += r & vbLf
                        Next
                    Catch
                    End Try
                    Exit Select
                Case 3
                    Try
                        s += m("MACAddress").ToString() & vbLf
                    Catch
                    End Try
                    Exit Select
                Case 4
                    Try
                        For Each r As String In TryCast(m("DefaultIPGateway"), Array)
                            s += r & vbLf
                        Next
                    Catch
                    End Try
                    Exit Select
            End Select
        Next
        Return s
    End Function
    Public Function Netzwerkadapter(ByVal sIP As String) As String
        Dim rK As RegistryKey = Registry.LocalMachine
        Dim s As String = ""
        Dim query As String = "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = TRUE"
        Dim sucher As New ManagementObjectSearcher(query)
        Dim oReturnCollection As ManagementObjectCollection = sucher.[Get]()
        For Each m As ManagementObject In oReturnCollection
            For Each r As String In TryCast(m("IPAddress"), Array)
                If r.Length < 25 AndAlso r.Length > 6 Then
                    s += r
                End If
            Next
            If s = sIP Then
                s = m("SettingID").ToString()
                Exit For
            Else
                s = ""
            End If
        Next
        If s <> "" Then
            Dim rSub As RegistryKey = rK.OpenSubKey("SYSTEM\CurrentControlSet\Control\Network\{4D36E972-E325-11CE-BFC1-08002BE10318}\" & s & "\Connection")
            s = rSub.GetValue("Name").ToString()
        End If
        Return s
    End Function
    Public Function GetComputerModel(ByVal sKriter As String)
        Dim search As New ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem")
        Dim info As ManagementObject
        Dim s As String = ""
        For Each info In search.Get()
            If sKriter = "Manufacturer" Then
                s += info("manufacturer").ToString
            ElseIf sKriter = "Model" Then
                s += info("model").ToString()
            ElseIf sKriter = "SystemType" Then
                s += info("systemtype").ToString
            End If
            'TextBox1.Text = "Manufacturer: " & info("manufacturer").ToString() & vbCrLf
            'TextBox1.Text += "Model: " & info("model").ToString() & vbCrLf
            'TextBox1.Text += "System Type: " & info("systemtype").ToString() & vbCrLf
            'TextBox1.Text += "Total Physical Memory: " & _
            'info("totalphysicalmemory").ToString() & vbCrLf
        Next
        Return Trim(s)
    End Function
    Public Function GetCPUId() As String
        Dim cpuInfo As String = String.Empty
        Dim temp As String = String.Empty
        Dim mc As ManagementClass = _
            New ManagementClass("Win32_Processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        For Each mo As ManagementObject In moc
            If cpuInfo = String.Empty Then
                cpuInfo = _
                 mo.Properties("ProcessorId").Value.ToString()
            End If
        Next
        Return cpuInfo
    End Function
    Public Function GetBiosId() As String
        Dim BiosInfo As String = String.Empty
        Dim temp As String = String.Empty
        Dim mc As ManagementClass = New ManagementClass("Win32_bios")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        For Each mo As ManagementObject In moc
            If BiosInfo = String.Empty Then
                BiosInfo = mo.Properties("version").Value.ToString()
            End If
        Next
        Return BiosInfo
    End Function
    ' ValidateKeyCode() validates that a keycode is valid.
    ' Basically it is the inverse of GenKeyString()
    Public Function ValidateKeyCode(ByVal KeyCode As Object, ByRef UserName As Object, ByRef ProjName As String) As Boolean
        Dim ValidSig As Object
        Dim BinKeyCode As Object
        Dim ActiveBytes As String
        Dim LUNameHash As String
        Dim LUName As String
        Dim ValidKey As Boolean
        Dim KeyMD5 As String
        Dim KeySig As String
        ValidKey = False
        ' Key must be 32 bytes long - otherwise reject immediately
        If Len(KeyCode) = 32 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object KeyCode. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            'UPGRADE_WARNING: Couldn't resolve default property of object BinKeyCode. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            BinKeyCode = HexStrToBinStr(KeyCode)
            'UPGRADE_WARNING: Couldn't resolve default property of object BinKeyCode. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            ActiveBytes = Right(BinKeyCode, 14)
            KeyMD5 = DigestStrToHexStr(ActiveBytes)
            'UPGRADE_WARNING: Couldn't resolve default property of object ValidSig. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            ValidSig = Left(KeyMD5, 2) & Right(KeyMD5, 2)
            'UPGRADE_WARNING: Couldn't resolve default property of object KeyCode. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            KeySig = Left(KeyCode, 4)
            'UPGRADE_WARNING: Couldn't resolve default property of object ValidSig. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            If KeySig = ValidSig Then
                ValidKey = True
            Else
                ValidKey = False
            End If
            If ValidKey Then
                'UPGRADE_WARNING: Couldn't resolve default property of object UserName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                LUName = LCase(UserName) & LCase(ProjName)
                LUNameHash = DigestStrToHexStr(LUName)
                'UPGRADE_WARNING: Couldn't resolve default property of object KeyCode. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                ActiveBytes = Mid(KeyCode, 5, 24)
                LUNameHash = Mid(LUNameHash, 5, 24)
                If ActiveBytes = LUNameHash Then
                    ValidKey = True
                Else
                    ValidKey = False
                End If
            End If
        Else
            ValidKey = False
        End If
        ValidateKeyCode = ValidKey
    End Function
    ' ExtractKeyFBits() returns the bitmap originally passed as F_Code
    ' when a key is created with GenKeyString()
    ' Note: it will return zero (0) if an invalid keycode is passed or if
    '       username or projectname are not a match.
    Public Function ExtractKeyFBits(ByVal KeyCode As Object, ByRef UserName As Object, ByRef ProjName As String) As Object
        Dim LoCodePerm As Object
        Dim UHashPerm As Object
        Dim KCodedPerm As Object
        Dim UserHash As Object
        Dim PermVal As Integer
        'Dim RealHash As String
        Dim LUser As String
        'Dim Perms As Integer
        Dim BinCodePerm As String
        Dim BinUHashPerm As String
        Dim HiCodePerm As Byte
        Dim HIUMask As Byte
        Dim LoUMask As Byte
        Dim HiPerm As Integer
        Dim LoPerm As Integer
        PermVal = 0
        If ValidateKeyCode(KeyCode, UserName, ProjName) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object UserName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            LUser = LCase(UserName) & LCase(ProjName)
            'UPGRADE_WARNING: Couldn't resolve default property of object UserHash. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            UserHash = DigestStrToHexStr(LUser)
            'UPGRADE_WARNING: Couldn't resolve default property of object KeyCode. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            'UPGRADE_WARNING: Couldn't resolve default property of object KCodedPerm. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            KCodedPerm = Right(KeyCode, 4)
            'UPGRADE_WARNING: Couldn't resolve default property of object UserHash. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            'UPGRADE_WARNING: Couldn't resolve default property of object UHashPerm. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            UHashPerm = Right(UserHash, 4)
            'UPGRADE_WARNING: Couldn't resolve default property of object KCodedPerm. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            BinCodePerm = HexStrToBinStr(KCodedPerm)
            'UPGRADE_WARNING: Couldn't resolve default property of object UHashPerm. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            BinUHashPerm = HexStrToBinStr(UHashPerm)
            HiCodePerm = Asc(Mid(BinCodePerm, 1, 1))
            'UPGRADE_WARNING: Couldn't resolve default property of object LoCodePerm. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            LoCodePerm = Asc(Mid(BinCodePerm, 2, 1))
            HIUMask = Asc(Mid(BinUHashPerm, 1, 1))
            LoUMask = Asc(Mid(BinUHashPerm, 2, 1))
            HiPerm = HiCodePerm Xor HIUMask
            LoPerm = LoCodePerm Xor LoUMask
            PermVal = (HiPerm * 256) Or LoPerm
        Else
            PermVal = 0
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object ExtractKeyFBits. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        ExtractKeyFBits = PermVal
    End Function
    Public Function FormatKeyCode(ByVal StrIn As String, ByVal GrpLen As Integer) As String
        Dim StrLeftOver As Object
        Dim StrGroups As Object
        Dim StrLen As Integer
        Dim CurGrp As Integer
        Dim OutStr As String = ""
        Dim GrpStr As String
        Dim GrpStart As Integer
        StrLen = Len(StrIn)
        'UPGRADE_WARNING: Couldn't resolve default property of object StrGroups. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        StrGroups = Int(StrLen / GrpLen)
        'UPGRADE_WARNING: Couldn't resolve default property of object StrLeftOver. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        StrLeftOver = StrLen Mod GrpLen
        ' Run loop to add dashes into StrIn
        'UPGRADE_WARNING: Couldn't resolve default property of object StrGroups. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        For CurGrp = 0 To (StrGroups - 1)
            GrpStart = (CurGrp * GrpLen) + 1
            GrpStr = Mid(StrIn, GrpStart, GrpLen)
            If CurGrp > 0 Then
                OutStr = OutStr & "-" & GrpStr
            Else
                OutStr = OutStr & GrpStr
            End If
        Next CurGrp
        ' Append a final group if any leftover charaters
        ' exist in StrIn
        'UPGRADE_WARNING: Couldn't resolve default property of object StrLeftOver. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        If StrLeftOver > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object StrLeftOver. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            OutStr = OutStr & "-" & Right(StrIn, StrLeftOver)
        End If
        FormatKeyCode = OutStr
    End Function
    Public sConnection As String = ""
    Dim nFirmaNo = 100
    Dim nDonemNo = 1
    Public Function KayitSiniri_kontrol(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Boolean
        Dim pass As Boolean = False
        If nKayitSinir > 0 Then
            Dim yetki As Int64 = Sorgu_tbKayitSayisi(tbTable, kriter, nKayitSinir)
            If yetki = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Kýsýtlý Kullaným.Maximum Kayýt Sýnýrýný Aþamazsýnýz...!" & vbCrLf & "Lütfen Yetkili Satýcýnýzla Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                pass = False
            ElseIf yetki = 1 Then
                pass = True
            End If
        Else
            pass = True
        End If
        Return pass
    End Function
    Private Function Sorgu_tbKayitSayisi(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         " & tbTable & "  " & kriter & " ")
        formkayitsayisi = cmd.ExecuteScalar
        con.Close()
        If formkayitsayisi >= nKayitSinir Then
            kayitsayisi = 0
        Else
            kayitsayisi = 1
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
        cmd = Nothing
        con = Nothing
    End Function
    Public Function yetki_kontrol(ByVal kullanici As String, ByVal frm As String, Optional ByVal bUyar As Boolean = True, Optional ByVal bYetki As Integer = 0, Optional ByVal kasiyer As Integer = 0) As Boolean
        Dim pass As Boolean = True
        Dim yetki As Int64
        If kasiyer = 0 Then
            If kullanici > 3 Then
                yetki = Sorgu_Yetki(kullanici, frm, 0, bYetki)
                If yetki = 0 Then
                    If bUyar = True Then
                        XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok!", sDil) & vbCrLf & Sorgu_sDil("Lütfen Sistem Yönecinizle Görüþün...", sDil) & vbCrLf & Sorgu_sDil("FormID: ", sDil) & frm, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    pass = False
                ElseIf yetki = 1 Then
                    pass = True
                End If
            Else
                If frm.Contains("_IslemYapamaz") = True Then
                    pass = False
                End If
            End If
        Else
            yetki = Sorgu_Yetki_Kasiyer(kullanici, frm, 0, bYetki)
            If yetki = 0 Then
                If bUyar = True Then
                    XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok!", sDil) & vbCrLf & Sorgu_sDil("Lütfen Sistem Yönecinizle Görüþün...", sDil) & vbCrLf & Sorgu_sDil("FormID: ", sDil) & frm, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                pass = False
            ElseIf yetki = 1 Then
                pass = True
            End If
        End If
        Return pass
    End Function
    'Mesaj vermeyen Yetki Kontrol
    Public Function yetki_kontrol1(ByVal kullanici As String, ByVal frm As String, Optional ByVal bUyar As Boolean = True, Optional ByVal bYetki As Integer = 0, Optional ByVal kasiyer As Integer = 0) As Boolean
        Dim pass As Boolean = True
        Dim yetki As Int64
        If kasiyer = 0 Then
            If kullanici > 3 Then
                yetki = Sorgu_Yetki(kullanici, frm, 0, bYetki)
                If yetki = 0 Then
                    'If bUyar = True Then
                    'XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok!", sDil) & vbCrLf & Sorgu_sDil("Lütfen Sistem Yönecinizle Görüþün...", sDil) & vbCrLf & Sorgu_sDil("FormID: ", sDil) & frm, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'End If
                    pass = False
                ElseIf yetki = 1 Then
                    pass = True
                End If
            Else
                If frm.Contains("_IslemYapamaz") = True Then
                    pass = False
                End If
            End If
        Else
            yetki = Sorgu_Yetki_Kasiyer(kullanici, frm, 0, bYetki)
            If yetki = 0 Then
                'If bUyar = True Then
                'XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok!", sDil) & vbCrLf & Sorgu_sDil("Lütfen Sistem Yönecinizle Görüþün...", sDil) & vbCrLf & Sorgu_sDil("FormID: ", sDil) & frm, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End If
                pass = False
            ElseIf yetki = 1 Then
                pass = True
            End If
        End If
        Return pass
    End Function
    Private Function Sorgu_Yetki(ByVal kasiyerno As String, ByVal Form As String, Optional ByVal islem As Integer = 0, Optional ByVal bYetki As Integer = 0) As Int64
        Dim kriter
        kriter = " WHERE (Personel.PersonelNo = '" & kasiyerno & "') AND (Forms.Form = '" & Form & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*), 0) AS Kayit FROM aEmirForms WHERE (Form = '" & Form & "')")
        formkayitsayisi = cmd.ExecuteScalar
        If formkayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('Genel', '" & Form & "', '" & Form & "', " & bYetki & ")")
            cmd.ExecuteNonQuery()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(CAST(Personel.Yetki AS int), 0) AS Yetki FROM aPersonelYetki Personel INNER JOIN aEmirForms Forms ON Personel.Form = Forms.Form  " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        If islem = 1 Then
            If kayitsayisi = 0 Then
                kayitsayisi = 1
            ElseIf kayitsayisi = 1 Then
                kayitsayisi = 0
            End If
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
    End Function
    Private Function Sorgu_Yetki_Kasiyer(ByVal kasiyerno As String, ByVal Form As String, Optional ByVal islem As Integer = 0, Optional ByVal bYetki As Integer = 0) As Int64
        Dim kriter
        kriter = " WHERE (Personel.PersonelNo = (SELECT IND FROM APERSONEL WHERE PERSONELADI='" & kasiyerno & "')) AND (Forms.Form = '" & Form & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*), 0) AS Kayit FROM aEmirForms WHERE (Form = '" & Form & "')")
        formkayitsayisi = cmd.ExecuteScalar
        If formkayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('Genel', '" & Form & "', '" & Form & "', " & bYetki & ")")
            cmd.ExecuteNonQuery()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(CAST(Personel.Yetki AS int), 0) AS Yetki FROM aPersonelYetki Personel INNER JOIN aEmirForms Forms ON Personel.Form = Forms.Form  " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        If islem = 1 Then
            If kayitsayisi = 0 Then
                kayitsayisi = 1
            ElseIf kayitsayisi = 1 Then
                kayitsayisi = 0
            End If
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
    End Function
    Public Function Sorgu_sDil(ByVal sOrjinal As String, ByVal sDil As String) As String
        Dim sAciklama As String = ""
        sOrjinal = sOrjinal.Replace("'", "''")

        If sDil = "TR" Then
            sAciklama = sOrjinal
        Else
            Dim kriter
            If sDegistirDil = "TR" Then
                kriter = " WHERE     (sDil = '" & sDil & "') AND (sAciklama = '" & sOrjinal & "') "
            ElseIf sDegistirDil = "EN" Then
                kriter = " WHERE     (sDil = '" & sDil & "') AND (sOrjinal = '" & sOrjinal & "') "
            ElseIf sDegistirDil = "AR" Then
                kriter = " WHERE     (sDil = '" & sDil & "') AND (sOrjinal = '" & sOrjinal & "') "
            Else
                kriter = " WHERE     (sDil = '" & sDil & "') AND (sAciklama = '" & sOrjinal & "') "
            End If
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            cmd.Connection = con
            con.ConnectionString = connection
            'cmd.CommandTimeout = Nothing
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim formkayitsayisi As Int64 = 0
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         tbDilCevir " & kriter & "")
            formkayitsayisi = cmd.ExecuteScalar
            If sDegistirDil = "TR" Then
                If formkayitsayisi = 0 Then
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbDilCevir                       (sOrjinal, sDil, sAciklama) VALUES     ('" & sOrjinal & "', '" & sDil & "', N'')")
                    cmd.ExecuteNonQuery()
                End If
            ElseIf sDegistirDil = "EN" Then
                If formkayitsayisi = 0 Then
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbDilCevir                       (sOrjinal, sDil, sAciklama) VALUES     ('" & sOrjinal & "', '" & sDil & "', N'')")
                    cmd.ExecuteNonQuery()
                End If
            ElseIf sDegistirDil = "AR" Then
                If formkayitsayisi = 0 Then
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbDilCevir                       (sOrjinal, sDil, sAciklama) VALUES     ('" & sOrjinal & "', '" & sDil & "', N'')")
                    cmd.ExecuteNonQuery()
                End If
            End If
            If sDegistirDil = "TR" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sAciklama = CASE WHEN sAciklama = '' THEN sAciklama ELSE sOrjinal END FROM         tbDilCevir " & kriter & "")
            ElseIf sDegistirDil = "EN" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sAciklama = CASE WHEN sAciklama = '' THEN sAciklama ELSE sAciklama END FROM         tbDilCevir " & kriter & "")
            ElseIf sDegistirDil = "AR" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sAciklama = CASE WHEN sAciklama = '' THEN sOrjinal ELSE sAciklama END FROM         tbDilCevir " & kriter & "")
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sAciklama = CASE WHEN sAciklama = '' THEN sOrjinal ELSE sAciklama END FROM         tbDilCevir " & kriter & "")
            End If
            sAciklama = cmd.ExecuteScalar
            con.Close()
            If sAciklama = "" Then
                sAciklama = sOrjinal
            End If

            formkayitsayisi = Nothing
        End If

        Return sAciklama

        'kayitsayisi = Nothing
    End Function
    Public Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + nfirmano.ToString)
        query = Replace(query, "!D", "D000" + ndonemno.ToString)
        Return query
    End Function
    Public Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
        cmd.Dispose()
        con.Dispose()
        adapter.Dispose()
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Public Sub tbFisKilit_ekle(ByVal nKayitID As String, ByVal sFisTipi As String, ByVal sKullanici As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sFisTipi = Trim(sFisTipi)
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFisKilit                       (nKayitID, sFisTipi, sKullanici, dteKayitTarihi) VALUES     ('" & nKayitID & "', '" & sFisTipi & "', '" & sKullanici & "', '" & dteKayitTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Sub tbFisKilit_sil(ByVal nKayitID As String, ByVal sFisTipi As String, ByVal sKullanici As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = '" & nKayitID & "' AND sFisTipi ='" & sFisTipi & "' and sKullanici ='" & sKullanici & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Sub tbFisKilit_sil_Tumu()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_nStokID(ByVal sBarkod As String) As Int64
        Dim kriter
        kriter = " WHERE     (sBarkod = '" & sBarkod & "')"
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nStokID,0) from tbStokBarkodu " & kriter & " ")
        formkayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return formkayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
    End Function
    Public Function sorgu_sDepoAdi(ByVal sDepo As String) As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim sAciklama As String
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sAciklama,'') FROM         tbDepo WHERE     (sDepo = '" & sDepo & "')")
        sAciklama = cmd.ExecuteScalar
        con.Close()
        Return sAciklama
        'kayitsayisi = Nothing
        sAciklama = Nothing
    End Function
    Public Function sorgu_lDovizKuru(ByVal sDovizCinsi As String, Optional ByVal sKur As String = "lAlisKuru") As Decimal
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim lKur As Decimal
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lAlisKuru, 1) AS lKur FROM         tbDovizKuru WHERE     (dteKurTarihi <= '" & dteSistemTarihi & "') AND (sDovizCinsi = '" & sDovizCinsi & "') ORDER BY dteKurTarihi DESC  ")
        lKur = sorgu_sayi(cmd.ExecuteScalar, 1)
        con.Close()
        Return lKur
        'kayitsayisi = Nothing
        lKur = Nothing
    End Function
    Public Function sorgu_nDeger(ByVal sSorgu As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim lKur As Decimal
        cmd.CommandText = sorgu_query(sSorgu)
        lKur = cmd.ExecuteScalar
        con.Close()
        Return lKur
        'kayitsayisi = Nothing
        lKur = Nothing
    End Function
    Public Function sorgu_nKilit(ByVal nKayitID As String, ByVal sFisTipi As String, ByVal sKullanici As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim nKayit As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(sKullanici) AS nKayit FROM         tbFisKilit WHERE     (sFisTipi = '" & sFisTipi & "') AND (nKayitID = '" & nKayit & "')")
        nKayit = cmd.ExecuteScalar
        con.Close()
        Return nKayit
        'kayitsayisi = Nothing
        nKayit = Nothing
    End Function
    Public Function ygeneltoplam(ByVal geneltoplam As Decimal) As String
        geneltoplam = Math.Abs(geneltoplam)
        Dim para As String = ParaYaziya_TL(geneltoplam, ParaYaziyaGosterimTipi.AralardaBoslukVar Or ParaYaziyaGosterimTipi.YTL Or ParaYaziyaGosterimTipi.BirimOlsun Or ParaYaziyaGosterimTipi.KurusDaimaGozuksun Or ParaYaziyaGosterimTipi.BuyukHarf)
        Return para
        para = Nothing
    End Function
    Public Function ygeneltoplam_arabic(ByVal geneltoplam As Decimal) As String
        Dim para As String = ParaYaziya_arabic(geneltoplam, ParaYaziyaGosterimTipi.AralardaBoslukVar Or ParaYaziyaGosterimTipi.YTL Or ParaYaziyaGosterimTipi.BirimOlsun Or ParaYaziyaGosterimTipi.KurusDaimaGozuksun Or ParaYaziyaGosterimTipi.BuyukHarf)
        para = para.Replace("Ten One", "Eleven")
        para = para.Replace("Ten Two", "Twelve")
        para = para.Replace("Ten Three", "Thirteen")
        para = para.Replace("Ten Four", "Fourteen")
        para = para.Replace("Ten Five", "Fifteen")
        para = para.Replace("Ten Six", "Sixteen")
        para = para.Replace("Ten Seven", "Seventeen")
        para = para.Replace("Ten Eight", "Eighteen")
        para = para.Replace("Ten Nine", "Nineteen")
        Return para
        para = Nothing
    End Function
    Public Function ygeneltoplam_english(ByVal geneltoplam As Decimal) As String
        Dim para As String = ParaYaziya_english(geneltoplam, ParaYaziyaGosterimTipi.AralardaBoslukVar Or ParaYaziyaGosterimTipi.YTL Or ParaYaziyaGosterimTipi.BirimOlsun Or ParaYaziyaGosterimTipi.KurusDaimaGozuksun Or ParaYaziyaGosterimTipi.BuyukHarf)
        para = para.Replace("Ten One", "Eleven")
        para = para.Replace("Ten Two", "Twelve")
        para = para.Replace("Ten Three", "Thirteen")
        para = para.Replace("Ten Four", "Fourteen")
        para = para.Replace("Ten Five", "Fifteen")
        para = para.Replace("Ten Six", "Sixteen")
        para = para.Replace("Ten Seven", "Seventeen")
        para = para.Replace("Ten Eight", "Eighteen")
        para = para.Replace("Ten Nine", "Nineteen")
        Return para
        para = Nothing
    End Function
    Public Enum ParaYaziyaGosterimTipi As Byte
        BuyukHarf = 2 : BasHarflerBuyuk = 1
        AralardaBoslukVar = 4 : UcerliGrupBoslugu = 8
        BirimOlsun = 16 : YTL = 32
        KurusDaimaGozuksun = 63
        Varsayilan = BuyukHarf + BirimOlsun + YTL + KurusDaimaGozuksun
    End Enum
    Public Function ParaYaziya_TL(ByVal para As Decimal, Optional ByVal gosterimTipi As ParaYaziyaGosterimTipi = ParaYaziyaGosterimTipi.Varsayilan, _
                                      Optional ByVal paraBirimi As String = "", Optional ByVal kurusBirimi As String = "") As String
        Dim a(,) As String = {{"Sýfýr ", "Bir ", "Ýki ", "Üç ", "Dört ", "Beþ ", "Altý ", "Yedi ", "Sekiz ", "Dokuz "}, _
                              {"", "On ", "Yirmi ", "Otuz ", "Kýrk ", "Elli ", "Altmýþ ", "Yetmiþ ", "Seksen ", "Doksan "}, _
                              {"", "Yüz ", "Ýkiyüz ", "Üçyüz ", "Dörtyüz ", "Beþyüz ", "Altýyüz ", "Yediyüz ", "Sekizyüz ", "Dokuzyüz "}, _
                              {"", "_Bin_", "_Milyon_", "_Milyar_", "_Trilyon_", "_Katrilyon_", "_Kentrilyon_", "_Bin_Kentrilyon_", "_Milyon_Kentrilyon_", "_Milyar_Kentrilyon_"}}
        Dim t() As String = {"TL", "KURUÞ", "TL", "Kurus"}, sf As String = a(0, 0)
        If paraBirimi <> "" OrElse kurusBirimi <> "" Then t(2) = Trim(UCase(paraBirimi)) : t(3) = Trim(UCase(kurusBirimi)) _
                                                        : gosterimTipi = gosterimTipi Or ParaYaziyaGosterimTipi.YTL Or ParaYaziyaGosterimTipi.BirimOlsun
        If para <> 0 Then para = Format(para, ".00")
        Dim kr As String = Mid(para - Decimal.Truncate(para), 3), z() As String = {"", "", Decimal.Truncate(para), IIf((gosterimTipi And 64) AndAlso kr = "", "0", kr)}
        For j As Integer = 0 To 1
            a(0, 0) = IIf(z(2 + j) = "0", sf, "")
            Dim p As String = ("00" & z(j + 2)).Substring((z(j + 2).Length + 2) Mod 3) ' ="  00 0".Substring(z(j+2).Length Mod 3 << 1, 2).Trim() & z(j+2) de olabilir   
            For i As Integer = p.Length - 3 To 0 Step -3
                z(j) = a(2, p.Substring(i, 1)) & a(1, p.Substring(i + 1, 1)) & IIf(p.Substring(i, 3) = "001" AndAlso i = 0 AndAlso p.Length = 6, _
                       "", a(0, p.Substring(i + 2, 1))) & IIf(p.Substring(i, 3) = "000", "", a(3, (p.Length - i) / 3 - 1)) & z(j)
            Next
            z(j) = IIf(gosterimTipi And 2, z(j), IIf(gosterimTipi And 1, z(j).ToUpper(), z(j).ToLower())).Replace(" ", _
                   IIf(gosterimTipi And 4, " ", "")).Replace("_", IIf(gosterimTipi And &HC, " ", "")).Trim().Replace("  ", " ")
        Next
        ParaYaziya_TL = z(0) & IIf(z(0).Length > 0 AndAlso ((gosterimTipi And &H10) OrElse z(1).Length > 0), " " & t((gosterimTipi And &H20) >> 4), "") & _
                     IIf(z(1).Length > 0, IIf(z(0).Length > 0, " ", "") & z(1) & " " & t(((gosterimTipi And &H20) >> 4) + 1), "")
    End Function
    Public Function ParaYaziya_arabic(ByVal para As Decimal, Optional ByVal gosterimTipi As ParaYaziyaGosterimTipi = ParaYaziyaGosterimTipi.Varsayilan, _
                                      Optional ByVal paraBirimi As String = "", Optional ByVal kurusBirimi As String = "") As String
        Dim a(,) As String = {{"Zero ", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine "}, _
       {"", "Ten ", "Twenty ", "Thirty ", "Fourty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety "}, _
       {"", "OneHundred ", "Two Hundred ", "Three Hundred ", "Four Hundred ", "Five Hundred ", "Six Hundred ", "Seven Hundred ", "Eight Hundred ", "Nine Hundred "}, _
       {"", "_Thousand_", "_Million_", "_Billion_", "_Trilyon_", "_Katrilyon_", "_Kentrilyon_", "_Bin_Kentrilyon_", "_Milyon_Kentrilyon_", "_Milyar_Kentrilyon_"}}
        Dim t() As String = {"SAR", "HALALA", "SAR", "HALALA"}, sf As String = a(0, 0)
        If paraBirimi <> "" OrElse kurusBirimi <> "" Then t(2) = Trim(UCase(paraBirimi)) : t(3) = Trim(UCase(kurusBirimi)) _
                                                        : gosterimTipi = gosterimTipi Or ParaYaziyaGosterimTipi.YTL Or ParaYaziyaGosterimTipi.BirimOlsun
        If para <> 0 Then para = Format(para, ".00")
        Dim kr As String = Mid(para - Decimal.Truncate(para), 3), z() As String = {"", "", Decimal.Truncate(para), IIf((gosterimTipi And 64) AndAlso kr = "", "0", kr)}
        For j As Integer = 0 To 1
            a(0, 0) = IIf(z(2 + j) = "0", sf, "")
            Dim p As String = ("00" & z(j + 2)).Substring((z(j + 2).Length + 2) Mod 3) ' ="  00 0".Substring(z(j+2).Length Mod 3 << 1, 2).Trim() & z(j+2) de olabilir   
            For i As Integer = p.Length - 3 To 0 Step -3
                z(j) = a(2, p.Substring(i, 1)) & a(1, p.Substring(i + 1, 1)) & IIf(p.Substring(i, 3) = "001" AndAlso i = 0 AndAlso p.Length = 6, _
                       "", a(0, p.Substring(i + 2, 1))) & IIf(p.Substring(i, 3) = "000", "", a(3, (p.Length - i) / 3 - 1)) & z(j)
            Next
            z(j) = IIf(gosterimTipi And 2, z(j), IIf(gosterimTipi And 1, z(j).ToUpper(), z(j).ToLower())).Replace(" ", _
                   IIf(gosterimTipi And 4, " ", "")).Replace("_", IIf(gosterimTipi And &HC, " ", "")).Trim().Replace("  ", " ")
        Next
        ParaYaziya_arabic = z(0) & IIf(z(0).Length > 0 AndAlso ((gosterimTipi And &H10) OrElse z(1).Length > 0), " " & t((gosterimTipi And &H20) >> 4), "") & _
                     IIf(z(1).Length > 0, IIf(z(0).Length > 0, " ", "") & z(1) & " " & t(((gosterimTipi And &H20) >> 4) + 1), "")
    End Function
    Public Function ParaYaziya_english(ByVal para As Decimal, Optional ByVal gosterimTipi As ParaYaziyaGosterimTipi = ParaYaziyaGosterimTipi.Varsayilan, _
                                      Optional ByVal paraBirimi As String = "", Optional ByVal kurusBirimi As String = "") As String
        Dim a(,) As String = {{"Zero ", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine "}, _
       {"", "Ten ", "Twenty ", "Thirty ", "Fourty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety "}, _
       {"", "OneHundred ", "Two Hundred ", "Three Hundred ", "Four Hundred ", "Five Hundred ", "Six Hundred ", "Seven Hundred ", "Eight Hundred ", "Nine Hundred "}, _
       {"", "_Thousand_", "_Million_", "_Billion_", "_Trilyon_", "_Katrilyon_", "_Kentrilyon_", "_Bin_Kentrilyon_", "_Milyon_Kentrilyon_", "_Milyar_Kentrilyon_"}}
        Dim t() As String = {"USD", "CENT", "USD", "CENT"}, sf As String = a(0, 0)
        If paraBirimi <> "" OrElse kurusBirimi <> "" Then t(2) = Trim(UCase(paraBirimi)) : t(3) = Trim(UCase(kurusBirimi)) _
                                                        : gosterimTipi = gosterimTipi Or ParaYaziyaGosterimTipi.YTL Or ParaYaziyaGosterimTipi.BirimOlsun
        If para <> 0 Then para = Format(para, ".00")
        Dim kr As String = Mid(para - Decimal.Truncate(para), 3), z() As String = {"", "", Decimal.Truncate(para), IIf((gosterimTipi And 64) AndAlso kr = "", "0", kr)}
        For j As Integer = 0 To 1
            a(0, 0) = IIf(z(2 + j) = "0", sf, "")
            Dim p As String = ("00" & z(j + 2)).Substring((z(j + 2).Length + 2) Mod 3) ' ="  00 0".Substring(z(j+2).Length Mod 3 << 1, 2).Trim() & z(j+2) de olabilir   
            For i As Integer = p.Length - 3 To 0 Step -3
                z(j) = a(2, p.Substring(i, 1)) & a(1, p.Substring(i + 1, 1)) & IIf(p.Substring(i, 3) = "001" AndAlso i = 0 AndAlso p.Length = 6, _
                       "", a(0, p.Substring(i + 2, 1))) & IIf(p.Substring(i, 3) = "000", "", a(3, (p.Length - i) / 3 - 1)) & z(j)
            Next
            z(j) = IIf(gosterimTipi And 2, z(j), IIf(gosterimTipi And 1, z(j).ToUpper(), z(j).ToLower())).Replace(" ", _
                   IIf(gosterimTipi And 4, " ", "")).Replace("_", IIf(gosterimTipi And &HC, " ", "")).Trim().Replace("  ", " ")
        Next
        ParaYaziya_english = z(0) & IIf(z(0).Length > 0 AndAlso ((gosterimTipi And &H10) OrElse z(1).Length > 0), " " & t((gosterimTipi And &H20) >> 4), "") & _
                     IIf(z(1).Length > 0, IIf(z(0).Length > 0, " ", "") & z(1) & " " & t(((gosterimTipi And &H20) >> 4) + 1), "")
    End Function
    Public Sub calculator()
        Dim frm As New frm_calc
        If frm.ShowDialog = DialogResult.OK Then
            'dr(GridView1.FocusedColumn().FieldName) = frm.tutar
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Public Sub tbDovizKuru()
        Dim frm As New frm_tbDovizKuru
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Public Function sorgula_nStokID(ByVal query As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        cmd.CommandTimeout = Nothing
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = query
        Dim kayitsayisi
        Try
            kayitsayisi = sorgu_sayi(cmd.ExecuteScalar, 0)
        Catch ex As Exception
            kayitsayisi = 0
        End Try
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgula_dteSonYedekTarihi() As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        cmd.CommandTimeout = Nothing
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select top 1 backup_finish_date from msdb.dbo.backupset where database_name='" & sDatabaseGenel & "' order by backup_finish_date desc")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgula_Decimal(ByVal query As String) As Decimal
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        cmd.CommandTimeout = Nothing
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = query
        Dim kayitsayisi As Decimal = sorgu_sayi(cmd.ExecuteScalar, 0)
        Return sorgu_sayi(kayitsayisi, 0)
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgula_String(ByVal query As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        cmd.CommandTimeout = Nothing
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = query
        Dim kayitsayisi = sorgu_string(cmd.ExecuteScalar, "")
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgula_Boolean(ByVal query As String) As Boolean
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        cmd.CommandTimeout = Nothing
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = query
        Dim kayitsayisi = sorgu_string(cmd.ExecuteScalar, "")
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Decimal) As Decimal
        Try
            If deger.ToString = "" Then
                deger = sonuc
            End If
        Catch ex As Exception
            deger = sonuc
        End Try
        Try
            Return deger
        Catch ex As Exception
            Return sonuc
        End Try
    End Function
    Public Function sorgu_string(ByVal deger As Object, ByVal sonuc As String) As String
        Try
            If deger.ToString = "" Then
                deger = sonuc
            End If
        Catch ex As Exception
            deger = sonuc
        End Try

        Return deger
    End Function
    Public Function sorgu_boolean(ByVal deger As Object, ByVal sonuc As Boolean) As Boolean
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Public Function degeruzunlukkontrol(ByVal deger As String, ByVal uzunluk As String, Optional ByVal sEkle As String = " ") As String
        deger = deger.Replace("Ý", "I")
        deger = deger.Replace("Þ", "S")
        deger = deger.Replace("Ç", "C")
        deger = deger.Replace("Ð", "G")
        deger = deger.Replace("Ü", "U")
        deger = deger.Replace("Ö", "O")
        deger = deger.Replace("ý", "i")
        deger = deger.Replace("þ", "s")
        deger = deger.Replace("ç", "c")
        deger = deger.Replace("ð", "g")
        deger = deger.Replace("ü", "u")
        deger = deger.Replace("ö", "o")
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk = Len(deger)
        If Len(deger) < uzunluk Then
            Dim degerfark As Integer = degeruzunluk - muzunluk
            Dim i As Integer
            For i = 1 To degerfark
                deger = deger.Insert(muzunluk, sEkle)
            Next
        Else
            deger = Microsoft.VisualBasic.Left(deger, uzunluk)
        End If
        Return deger
    End Function
    Public Function sayiuzunlukkontrol(ByVal deger As String, ByVal uzunluk As String, Optional ByVal sEkle As String = "0") As String
        If uzunluk < 0 Then
            uzunluk = 1
        End If
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk = Len(deger)
        If Len(deger) < uzunluk Then
            Dim degerfark As Integer = degeruzunluk - muzunluk
            Dim i As Integer
            For i = 1 To degerfark
                deger = deger.Insert(0, sEkle)
            Next
        Else
            deger = Microsoft.VisualBasic.Left(deger, uzunluk)
        End If
        Return deger
    End Function
    Public Sub StartExport()
        Thread.Sleep(400)
        If [stop] Then
            Return
        End If
        Dim progressForm As ExportForm = New ExportForm(Form1)
        progressForm.Show()
        Try
            Do While Not [stop]
                Application.DoEvents()
                Thread.Sleep(100)
            Loop
        Catch
        End Try
        progressForm.Dispose()
    End Sub
    Public Sub EndExport()
        [stop] = True
        thread.Join()
    End Sub
    Public Sub takip_ekle_stok_fiyatdegisim(ByVal nStokID As Int64, ByVal sKodu As String, ByVal sAciklama As String, ByVal lFiyat As Decimal, ByVal sFiyatTipi As String)
        Dim dr As DataRow
        Dim ds_personel As DataSet
        If Trim(sFiyatTipi) = Trim(sFiyat1) Then
            ds_personel = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     tbFiyatTipi.sFiyatTipi, APERSONEL.IND FROM         tbFiyatTipi INNER JOIN                       APERSONEL ON tbFiyatTipi.sFiyatTipi = APERSONEL.PERSONELKODU WHERE     (ISNUMERIC(tbFiyatTipi.sFiyatTipi) = 1) and tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "' ORDER BY tbFiyatTipi.sFiyatTipi")
            For Each dr In ds_personel.Tables(0).Rows
                gorev_ekle(3, nStokID, sAciklama, dr("IND"), 2, "Stok Fiyat Deðiþimi " & sAciklama, Trim(sKodu) & "-" & Trim(sAciklama) & "-" & FormatNumber(lFiyat, 2), 0, Now, DateAdd(DateInterval.Minute, 5, Now), "Fiyat Deðiþti " & Trim(sKodu) & "-" & Trim(sAciklama) & "-" & FormatNumber(lFiyat, 2), 0, 0, "", "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, Now), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""00:10:00""/></Reminders>", lFiyat, "", 0, 0, 0)
            Next
            ds_personel = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT tbFiyatTipi.sFiyatTipi, APERSONEL.IND FROM tbFiyatTipi INNER JOIN APERSONEL ON tbFiyatTipi.sFiyatTipi = APERSONEL.PERSONELKODU WHERE (ISNUMERIC(tbFiyatTipi.sFiyatTipi) = 1) AND (tbFiyatTipi.sFiyatTipi NOT IN (SELECT sFiyatTipi FROM tbStokFiyati WHERE lFiyat <> 0 AND (nStokID = " & nStokID & ") AND (sFiyatTipi NOT IN ('" & sFiyatA & "' , '" & sFiyatM & "'))))")
            For Each dr In ds_personel.Tables(0).Rows
                gorev_ekle(3, nStokID, sAciklama, dr("IND"), 2, "Stok Fiyat Deðiþimi " & sAciklama, Trim(sKodu) & "-" & Trim(sAciklama) & "-" & FormatNumber(lFiyat, 2), 0, Now, DateAdd(DateInterval.Minute, 5, Now), "Fiyat Deðiþti " & Trim(sKodu) & "-" & Trim(sAciklama) & "-" & FormatNumber(lFiyat, 2), 0, 0, "", "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, Now), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""00:10:00""/></Reminders>", lFiyat, "", 0, 0, 0)
            Next
        Else
            ds_personel = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     tbFiyatTipi.sFiyatTipi, APERSONEL.IND FROM         tbFiyatTipi INNER JOIN                       APERSONEL ON tbFiyatTipi.sFiyatTipi = APERSONEL.PERSONELKODU WHERE     (ISNUMERIC(tbFiyatTipi.sFiyatTipi) = 1) and tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "' ORDER BY tbFiyatTipi.sFiyatTipi")
            For Each dr In ds_personel.Tables(0).Rows
                gorev_ekle(3, nStokID, sAciklama, dr("IND"), 2, "Stok Fiyat Deðiþimi " & sAciklama, Trim(sKodu) & "-" & Trim(sAciklama) & "-" & FormatNumber(lFiyat, 2), 0, Now, DateAdd(DateInterval.Minute, 5, Now), "Fiyat Deðiþti " & Trim(sKodu) & "-" & Trim(sAciklama) & "-" & FormatNumber(lFiyat, 2), 0, 0, "", "<Reminders><Reminder AlertTime=""" & Format(DateAdd(DateInterval.Minute, 0, Now), "MM/dd/yyyy HH:mm:ss") & """ TimeBeforeStart=""00:10:00""/></Reminders>", lFiyat, "", 0, 0, 0)
            Next
        End If
    End Sub
    Public Function gorev_ekle(ByVal FirmaTipi As Integer, ByVal FirmaNo As String, ByVal Firma As String, ByVal PersonelNo As Int64, ByVal Status As Integer, ByVal Subject As String, ByVal Description As String, ByVal Label As Integer, ByVal StartTime As DateTime, ByVal EndTime As DateTime, ByVal Location As String, ByVal AllDay As Byte, ByVal EventType As Integer, ByVal RecurrenceInfo As String, ByVal ReminderInfo As String, ByVal Tutar As Decimal, ByVal Pb As String, ByVal Odendi As Byte, ByVal Gelecekmi As Byte, ByVal Tamamlandi As Byte) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirAjanda                       (FirmaTipi, FirmaNo, Firma, PersonelNo, Status, Subject, Description, Label, StartTime, EndTime, Location, AllDay, EventType, RecurrenceInfo, ReminderInfo, Tutar, Pb, Odendi, Gelecekmi, Tamamlandi) VALUES     (" & FirmaTipi & ", '" & FirmaNo & "', '" & Firma & "', '" & PersonelNo & "', " & Status & ", '" & Subject & "', '" & Description & "', " & Label & ", '" & StartTime & "', '" & EndTime & "', '" & Location & "', " & AllDay & ", " & EventType & ", NULL,'" & ReminderInfo & "', " & Tutar & ", '" & Pb & "', " & Odendi & ", " & Gelecekmi & ", " & Tamamlandi & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno As Int64 = sorgu_sayi(cmd.ExecuteScalar, 0)
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Sub gorev_duzelt(ByVal ID As Int64, ByVal FirmaTipi As Integer, ByVal FirmaNo As String, ByVal Firma As String, ByVal PersonelNo As Int64, ByVal Status As Integer, ByVal Subject As String, ByVal Description As String, ByVal Label As Integer, ByVal StartTime As DateTime, ByVal EndTime As DateTime, ByVal Location As String, ByVal AllDay As Byte, ByVal EventType As Integer, ByVal RecurrenceInfo As String, ByVal ReminderInfo As String, ByVal Tutar As Decimal, ByVal Pb As String, ByVal Odendi As Byte, ByVal Gelecekmi As Byte, ByVal Tamamlandi As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirAjanda SET              FirmaTipi = " & FirmaTipi & ", FirmaNo = '" & FirmaNo & "', Firma = '" & Firma & "', PersonelNo = " & PersonelNo & ", Status = " & Status & ", Subject = '" & Subject & "', Description = '" & Description & "', StartTime = '" & StartTime & "', EndTime = '" & EndTime & "', Location = '" & Location & "', AllDay = " & AllDay & ", EventType = " & EventType & ",   Tutar = " & Tutar & ", Pb = '" & Pb & "', Odendi = " & Odendi & ", Gelecekmi = " & Gelecekmi & "  WHERE ID= '" & ID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Sub gorev_sil(ByVal ID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Delete from FROM         tbMarketSozlesmeDetayiTakip WHERE     (nGorevID = 39)")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM    aEmirAjanda  WHERE ID= '" & ID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Sub tbCekSenet_Bakim()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Dim trdCekSenet As Threading.Thread
        trdCekSenet = New Threading.Thread(AddressOf tbCekSenet_Bakim_Sorgu)
        trdCekSenet.IsBackground = True
        trdCekSenet.Start()
    End Sub
    Private Sub tbCekSenet_Bakim_Sorgu()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenet SET nSonCekSenetIslem = (SELECT TOP 1 nCekSenetIslem FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID ORDER BY nBordroSatirID) WHERE (nCekSenetID = " & nCekSenetID & ")")
        'cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenet SET nSonBordroSatirID = (SELECT TOP 1 ISNULL(nBordroSatirID,1) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID ORDER BY nBordroSatirID DESC),nSonCekSenetIslem = (SELECT TOP 1 ISNULL(nCekSenetIslem,1) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID ORDER BY nBordroSatirID DESC) WHERE ((SELECT TOP 1 ISNULL(nCekSenetIslem , 0) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID ORDER BY nBordroSatirID DESC) <> 0)")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function CariHesapTuruSorgula(ByVal sKodu As String) As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select sCariHesapTuru From tbFirma Where sKodu = '" & sKodu & "'")
        Dim kayitno = cmd.ExecuteScalar.ToString()
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Function MusteriSozlesmeNoDuzenle(ByVal nMusteriID As String, ByVal sKartID As String) As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select ISNULL(sozlesmeNoDuzenleme, 1) From tbMusteriKarti Where (nMusteriID = '" & nMusteriID & "') AND (sKartID = '" & sKartID & "')")
        Dim kayitno = cmd.ExecuteScalar.ToString()
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Function HesapIDDenFirmaIDBul(ByVal nHesapID As String) As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select nFirmaID from tbFirma where nHesapID = '" & Trim(nHesapID) & "'")
        Dim kayitno = cmd.ExecuteScalar.ToString()
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Function FirmaIDDenHesapIDBul(ByVal nFirmaID As String) As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select nHesapID from tbFirma where nFirmaID = '" & Trim(nFirmaID) & "'")
        Dim kayitno = cmd.ExecuteScalar.ToString()
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Function SonYevmiyeNoBul(ByVal yevmiyeTuru As Integer) As Integer
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If yevmiyeTuru = 1 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select ISNULL(lSonTahsilYevmiyeNo, 0) from tbParamMuhasebe")
        ElseIf yevmiyeTuru = 2 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select ISNULL(lSonTediyeYevmiyeNo, 0) from tbParamMuhasebe")
        ElseIf yevmiyeTuru = 3 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select ISNULL(lSonMahsupYevmiyeNo, 0) from tbParamMuhasebe")
        End If
        Dim kayitno As Integer = Integer.Parse(cmd.ExecuteScalar.ToString())
        kayitno += 1
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Sub SonYevmiyeKaydet(ByVal yevmiyeTuru As Integer, ByVal sonYevmiyeNo As Integer)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If yevmiyeTuru = 1 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamMuhasebe SET lSonTahsilYevmiyeNo = " & sonYevmiyeNo & "")
        ElseIf yevmiyeTuru = 2 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamMuhasebe SET lSonTediyeYevmiyeNo = " & sonYevmiyeNo & "")
        ElseIf yevmiyeTuru = 3 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamMuhasebe SET lSonMahsupYevmiyeNo = " & sonYevmiyeNo & "")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function HareketTipindenMuhasebeKodu(ByVal sFisTipi As String, ByVal sHareketTipi As String) As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If sFisTipi = "FS" Then
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select sSatisMuhasebeHesapID from tbHareketTipi where sHareketTipi = '" & Trim(sHareketTipi) & "'")
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select nHesapID from tbSubeMagazaHesaplari where (sHareketTipi = '" & Trim(sHareketTipi) & "') AND (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (nSubeMagazaHesapTipi = 13)")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY select skodu from tbHesapPlani where nHesapID = (Select Case when ISNULL((Select IsNULL(nHesapID, 0) from tbSubeMagazaHesaplari where (sHareketTipi = '" & Trim(sHareketTipi) & "') AND (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (nSubeMagazaHesapTipi = 13)), 0) > 0 then (Select nHesapID from tbSubeMagazaHesaplari where (sHareketTipi = '" & Trim(sHareketTipi) & "') AND (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (nSubeMagazaHesapTipi = 13)) else (Select sSatisMuhasebeHesapID from tbHareketTipi where sHareketTipi = '" & Trim(sHareketTipi) & "') END)")
        ElseIf sFisTipi = "FA" Then
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select sAlisMuhasebeHesapID from tbHareketTipi where sHareketTipi = '" & Trim(sHareketTipi) & "'")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY select skodu from tbHesapPlani where nHesapID = (Select Case when ISNULL((Select IsNULL(nHesapID, 0) from tbSubeMagazaHesaplari where (sHareketTipi = '" & Trim(sHareketTipi) & "') AND (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (nSubeMagazaHesapTipi = 6)), 0) > 0 then (Select nHesapID from tbSubeMagazaHesaplari where (sHareketTipi = '" & Trim(sHareketTipi) & "') AND (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (nSubeMagazaHesapTipi = 6)) else (Select sAlisMuhasebeHesapID from tbHareketTipi where sHareketTipi = '" & Trim(sHareketTipi) & "') END)")
        End If
        Dim kayitno As String = cmd.ExecuteScalar.ToString()
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Function MuhasebeFisiSil(ByVal lFisNo As String, ByVal sMuhFisTipi As String) As Boolean
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        Dim kayitno As Boolean = False
        Try
            If con.State = ConnectionState.Closed = True Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY delete from tbMuhasebeFisi where lFisno = " & Trim(lFisNo) & " AND sMuhFisTipi = '" & Trim(sMuhFisTipi) & "' delete from tbMuhasebeFisiAciklamasi Where lFisno = " & Trim(lFisNo) & " AND sMuhFisTipi = '" & Trim(sMuhFisTipi) & "'")
            cmd.ExecuteNonQuery()
            kayitno = True
        Catch ex As Exception
            kayitno = False
        End Try
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Function MuhasebeFisiVarMi(ByVal lFisNo As String, ByVal sMuhFisTipi As String) As Integer
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select ((Select count(*) from tbMuhasebeFisi where lFisno = " & Trim(lFisNo) & " AND sMuhFisTipi = '" & Trim(sMuhFisTipi) & "') + (Select count(*) from tbMuhasebeFisiAciklamasi where lFisno = " & Trim(lFisNo) & " AND sMuhFisTipi = '" & Trim(sMuhFisTipi) & "'))")
        Dim kayitno As Integer = Integer.Parse(cmd.ExecuteScalar.ToString())
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Function MuhasebeKodundanHesapID(ByVal sKodu As String) As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY select nHesapID from tbHesapPlani where skodu = '" & sKodu & "'")
        Dim kayitno As String = cmd.ExecuteScalar.ToString()
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Function KasaMuhasebeKoduBul(ByVal sSubeMagaza As String, ByVal MuhsHareketTipi As String) As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY (SELECT nHesapID from tbSubeMagazaHesaplari where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = 0))")
        Dim kayitno As String = cmd.ExecuteScalar.ToString()
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Sub tbStokMuhasebeEntegrasyonu_kaydet_duzelt(ByVal sKdvTipi As String, ByVal sSubeMagaza As String, ByVal nSubeMagazaHesapTipi As Int64, ByVal sHareketTipi As String, ByVal nHesapID As Int64, Optional ByVal nIslem As Integer = 0)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If nIslem = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbSubeMagazaHesaplari WHERE sSubeMagaza = '" & sSubeMagaza & "' and sHareketTipi = '" & sHareketTipi & "' and nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipi & " ")
            cmd.ExecuteNonQuery()
            If nHesapID <> 0 Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSubeMagazaHesaplari(sSubeMagaza, nSubeMagazaHesapTipi, sHareketTipi, nHesapID) VALUES('" & sSubeMagaza & "', " & nSubeMagazaHesapTipi & ", '" & sHareketTipi & "', " & nHesapID & ") ")
                cmd.ExecuteNonQuery()
            End If
        ElseIf nIslem = 1 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbSubeMagazaKdv WHERE sSubeMagaza = '" & sSubeMagaza & "' and sHareketTipi = '" & sHareketTipi & "' and nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipi & " and sKdvTipi = '" & sKdvTipi & "'")
            cmd.ExecuteNonQuery()
            If nHesapID <> 0 Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSubeMagazaKdv(sKdvTipi, sSubeMagaza, nSubeMagazaHesapTipi, sHareketTipi, nHesapID) VALUES('" & sKdvTipi & "', '" & sSubeMagaza & "', " & nSubeMagazaHesapTipi & ", '" & sHareketTipi & "', " & nHesapID & ") ")
                cmd.ExecuteNonQuery()
            End If
        ElseIf nIslem = 2 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbSubeMagazaKdv WHERE sSubeMagaza = '" & sSubeMagaza & "' and sHareketTipi = '" & sHareketTipi & "' and nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipi & " and sOTVTipi = '" & sKdvTipi & "'")
            cmd.ExecuteNonQuery()
            If nHesapID <> 0 Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSubeMagazaKdv(sOTVTipi, sSubeMagaza, nSubeMagazaHesapTipi, sHareketTipi, nHesapID) VALUES('" & sKdvTipi & "', '" & sSubeMagaza & "', " & nSubeMagazaHesapTipi & ", '" & sHareketTipi & "', " & nHesapID & ") ")
                cmd.ExecuteNonQuery()
            End If
        End If
        con.Close()
    End Sub
    Public Sub PerakendeNotMuhasebelestir(ByVal lFaturaNo As String, ByVal nAlisverisID As String, ByVal veri As String, Optional ByVal islem As Integer = 0)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If islem = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisVeris SET sMuhasebeFaturalasma = '" & veri & "' Where (lFaturaNo = " & lFaturaNo & ") AND (nAlisverisID = '" & nAlisverisID & "')")
        ElseIf islem = 1 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisVeris SET sMuhasebeFaturalasma = '" & veri & "' Where (nAlisverisID = '" & nAlisverisID & "')")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function PerakendeMuhasebeFisiVarMi(ByVal TümlFisNo As String, ByVal sMuhFisTipi As String, Optional ByVal islem As Integer = 0) As Integer
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If islem = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select (Select count(Distinct nAlisverisID) from tbMuhasebeFisi where (lFisno = " & Trim(TümlFisNo) & ") AND (sMuhFisTipi = '" & Trim(sMuhFisTipi) & "'))")
        ElseIf islem = 1 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select (Select count(Distinct nAlisverisID) from tbMuhasebeFisi where (nEvrakNo = " & Trim(TümlFisNo) & ") AND (sMuhFisTipi = '" & Trim(sMuhFisTipi) & "'))")
        ElseIf islem = 2 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select (Select count(Distinct nAlisverisID) from tbMuhasebeFisi where (lFisno = (select Distinct lFisno from tbMuhasebeFisi where nEvrakNo = " & Trim(TümlFisNo) & ")) AND (sMuhFisTipi = '" & Trim(sMuhFisTipi) & "'))")
        End If
        Dim kayitno As Integer = Integer.Parse(cmd.ExecuteScalar.ToString())
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Function PerakendeMuhasebeFisiSil(ByVal TümlFisNo As String, ByVal lFisNo As String, ByVal nAlisverisID As String, ByVal sMuhFisTipi As String, ByVal fisSayisi As Integer) As Boolean
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        Dim kayitno As Boolean = False
        Try
            If con.State = ConnectionState.Closed = True Then
                con.Open()
            End If
            If fisSayisi = 1 Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY delete from tbMuhasebeFisiAciklamasi Where (lFisno = (select Distinct lFisno from tbMuhasebeFisi where nEvrakNo = " & Trim(TümlFisNo) & ")) AND (sMuhFisTipi = '" & Trim(sMuhFisTipi) & "') delete from tbMuhasebeFisi where (lFisno = (select Distinct lFisno from tbMuhasebeFisi where nEvrakNo = " & Trim(TümlFisNo) & ")) AND (sMuhFisTipi = '" & Trim(sMuhFisTipi) & "')")
            ElseIf fisSayisi > 1 Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY delete from tbMuhasebeFisi where (nAlisverisID = '" & Trim(nAlisverisID) & "') AND (sMuhFisTipi = '" & Trim(sMuhFisTipi) & "')")
            End If
            cmd.ExecuteNonQuery()
            PerakendeNotMuhasebelestir(lFisNo, nAlisverisID, "")
            kayitno = True
        Catch ex As Exception
            kayitno = False
        End Try
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Function PerakendeCokluFisBilgiSorgula(ByVal nAlisverisID As String, ByVal sMuhFisTipi As String, ByVal islem As Integer) As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If islem = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select lFisno from tbMuhasebeFisi where (nAlisverisID = '" & Trim(nAlisverisID) & "') AND (sMuhFisTipi = '" & Trim(sMuhFisTipi) & "')")
        ElseIf islem = 1 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select dteFisTarihi from tbMuhasebeFisi where (nAlisverisID = '" & Trim(nAlisverisID) & "') AND (sMuhFisTipi = '" & Trim(sMuhFisTipi) & "')")
        ElseIf islem = 2 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select lYevmiyeNo from tbMuhasebeFisi where (nAlisverisID = '" & Trim(nAlisverisID) & "') AND (sMuhFisTipi = '" & Trim(sMuhFisTipi) & "')")
        End If
        Dim kayitno As String = cmd.ExecuteScalar.ToString()
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Public Function Kod3ZorunluMu(ByVal sSubeMagaza As String) As Boolean
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select bKod3ZorunluMu From tbDepo Where sDepo = '" & sSubeMagaza & "'")
        Dim kayitno As String = cmd.ExecuteScalar.ToString()
        cmd = Nothing
        con = Nothing
        Return Boolean.Parse(kayitno)
    End Function
    Public Function TalepDogrulamaKontrol(ByVal sSubeMagaza As String) As Boolean
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Select bTalepDogrulamaKontrol From tbDepo Where sDepo = '" & sSubeMagaza & "'")
        Dim kayitno As String = cmd.ExecuteScalar.ToString()
        cmd = Nothing
        con = Nothing
        Return Boolean.Parse(kayitno)
    End Function
    Public Function sorgu_resimAdet(ByVal sModel As String) As Integer
        Dim OK As Integer = 0
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("Set dateformat Dmy Select COUNT(nSira) +1 As nSira from tbStokResmi Where (sModel = '" & sModel & "')")
            OK = Integer.Parse(cmd.ExecuteScalar.ToString())
            'OK += 1
            con.Close()
        Catch ex As Exception
            'OK = 0
        End Try
        Return OK
    End Function
    Public Function sorgu_resimYol(ByVal sModel As String) As Integer
        Dim yol As Integer = 1
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("Set dateformat Dmy Select Count(*) from tbStokResmi Where (sModel = '" & sModel & "')")
            yol = Integer.Parse(cmd.ExecuteScalar.ToString())
            yol += 1
            con.Close()
        Catch ex As Exception
            yol = 0
        End Try
        Return yol
    End Function
    Public Function sorgu_resimYol1(ByVal sModel As String) As Integer
        Dim yol As Integer = 1
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("Set dateformat Dmy Select YOL2 AS YOL2,YOL3 AS YOL3,YOL4 AS YOL4,YOL5 AS YOL5,YOL6 AS YOL6,YOL7 AS YOL7,YOL8 AS YOL8,YOL9 AS YOL9,YOL10 AS YOL10,YOL11 AS YOL11 from tbStokResmi Where (sModel = '" & sModel & "')")
            yol = Integer.Parse(cmd.ExecuteScalar.ToString())

            con.Close()
        Catch ex As Exception
            yol = 0
        End Try
        Return yol
    End Function
    Public Function TalepDogrulamaOnayi(ByVal EVRAKNO As String) As Boolean
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        Dim cevap As Boolean = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select (SUM(DogrulamaAdet) - sum(MIKTAR)) as Fark From (SELECT ISNULL((Select SUM(MIKTAR) From ASTOKETIKETTALEPDETAYDOGRULAMA dog Where (dog.STOKNO = HAREKET.STOKNO) AND (dog.EVRAKNO = HAREKET.EVRAKNO)), 0) as DogrulamaAdet, HAREKET.MIKTAR as MIKTAR, HAREKET.STOKNO as STOKNO FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE HAREKET.EVRAKNO = " & Trim(EVRAKNO) & ") as tt")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT (SUM(MIKTAR) - SUM(DogrulamaAdet)) as fark from (Select SUM(HAREKET.MIKTAR) as MIKTAR, ISNULL((Select sum (MIKTAR) From ASTOKETIKETTALEPDETAYDOGRULAMA dog Where (dog.STOKNO = HAREKET.STOKNO) AND (dog.EVRAKNO = " & Trim(EVRAKNO) & ")), 0) as DogrulamaAdet FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE HAREKET.EVRAKNO = " & Trim(EVRAKNO) & " GROUP BY HAREKET.STOKNO) as tt")
        Dim kayitno As Double = Double.Parse(cmd.ExecuteScalar.ToString())
        If kayitno <> 0 Then
            cevap = False
        Else
            cevap = True
        End If
        If cevap = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select (select SUM(dog.MIKTAR) FROM ASTOKETIKETTALEPDETAYDOGRULAMA dog WHERE dog.EVRAKNO = " & Trim(EVRAKNO) & ") - (select sum(HAREKET.MIKTAR) as s FROM ASTOKETIKETTALEPDETAY HAREKET WHERE HAREKET.EVRAKNO = " & Trim(EVRAKNO) & ") as fark")
            kayitno = Double.Parse(cmd.ExecuteScalar.ToString())
            If kayitno <> 0 Then
                cevap = False
            Else
                cevap = True
            End If
        End If
        cmd = Nothing
        con = Nothing
        Return cevap
    End Function
    Public Function TeslimDogrulamaOnayi(ByVal EVRAKNO As String) As Boolean
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        Dim cevap As Boolean = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT (SUM(MIKTAR) - SUM(DogrulamaAdet)) as fark from (Select SUM(HAREKET.MIKTAR) as MIKTAR, ISNULL((Select Sum(MIKTAR) From ASTOKETIKETTESLIMDETAY dog Where (dog.STOKNO = HAREKET.STOKNO) AND (dog.EVRAKNO = (Select IND from ASTOKETIKETTESLIMBASLIK where REFIND = " & EVRAKNO & "))), 0) as DogrulamaAdet FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE HAREKET.EVRAKNO = " & EVRAKNO & " GROUP BY HAREKET.STOKNO) as tt")
        Dim kayitno As Double = Double.Parse(cmd.ExecuteScalar.ToString())
        If kayitno <> 0 Then
            cevap = False
        Else
            cevap = True
        End If
        If cevap = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select (select SUM(dog.MIKTAR) FROM ASTOKETIKETTESLIMDETAY dog WHERE dog.EVRAKNO = (Select IND from ASTOKETIKETTESLIMBASLIK where REFIND = " & EVRAKNO & ")) - (select sum(HAREKET.MIKTAR) as s FROM ASTOKETIKETTALEPDETAY HAREKET WHERE HAREKET.EVRAKNO = " & EVRAKNO & ") as fark")
            kayitno = Double.Parse(cmd.ExecuteScalar.ToString())
            If kayitno <> 0 Then
                cevap = False
            Else
                cevap = True
            End If
        End If
        cmd = Nothing
        con = Nothing
        Return cevap
    End Function
    Public Sub sorguCalistir(ByVal sorgu As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(sorgu)
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
End Module