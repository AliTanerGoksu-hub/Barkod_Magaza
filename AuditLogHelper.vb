Imports System.Data.OleDb

''' <summary>
''' Audit Log Helper - Kolay Entegrasyon Modülü
''' </summary>
''' <remarks>
''' Mevcut kodlara minimum dahale ile audit log eklemek için
''' </remarks>
Public Module AuditLogHelper
    
    ''' <summary>
    ''' Sipariş işlemleri için audit log
    ''' </summary>
    Public Sub LogSiparis(islemTipi As String, siparisID As Long, siparisNo As String,
                          aciklama As String, Optional eskiDeger As String = "", 
                          Optional yeniDeger As String = "", Optional alanAdi As String = "Degisiklik")
        Try
            ' DÜZELTİLDİ: eskiDeger ve yeniDeger boş olsa bile log yaz!
            ' Eski kod: If eskiDeger = yeniDeger Then Return ' YANLIŞ!
            ' Yeni kod: Kontrol yok, her zaman log yaz
            
            Select Case islemTipi.ToUpper()
                Case "INSERT", "YENI"
                    AuditLogger.LogInsert(
                        AuditLogger.ModulAdi.SIPARIS,
                        "tbSiparis",
                        siparisID,
                        siparisNo,
                        "{""aciklama"":""" & aciklama & """}",
                        aciklama
                    )
                    
                Case "UPDATE", "GUNCELLE"
                    AuditLogger.LogUpdate(
                        AuditLogger.ModulAdi.SIPARIS,
                        "tbSiparis",
                        siparisID,
                        siparisNo,
                        alanAdi,
                        eskiDeger,
                        yeniDeger,
                        aciklama
                    )
                    
                Case "DELETE", "SIL"
                    AuditLogger.LogDelete(
                        AuditLogger.ModulAdi.SIPARIS,
                        "tbSiparis",
                        siparisID,
                        siparisNo,
                        "{""silindi"":true}",
                        aciklama
                    )
                    
                Case "APPROVE", "ONAYLA"
                    AuditLogger.LogApprove(
                        AuditLogger.ModulAdi.SIPARIS,
                        "tbSiparis",
                        siparisID,
                        siparisNo,
                        aciklama
                    )
                    
                Case "CANCEL", "IPTAL"
                    AuditLogger.LogCancel(
                        AuditLogger.ModulAdi.SIPARIS,
                        "tbSiparis",
                        siparisID,
                        siparisNo,
                        aciklama
                    )
            End Select
        Catch ex As Exception
            ' Log hatası uygulamayı etkilemesin
            Debug.WriteLine("Audit log hatası: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Fatura işlemleri için audit log
    ''' </summary>
    Public Sub LogFatura(islemTipi As String, fisID As Long, fisNo As String,
                         aciklama As String, Optional eskiDeger As String = "", 
                         Optional yeniDeger As String = "")
        Try
            ' DÜZELTİLDİ: eskiDeger ve yeniDeger boş olsa bile log yaz!
            
            Select Case islemTipi.ToUpper()
                Case "INSERT", "YENI"
                    AuditLogger.LogInsert(
                        AuditLogger.ModulAdi.FATURA,
                        "tbStokFisiMaster",
                        fisID,
                        fisNo,
                        "{""aciklama"":""" & aciklama & """}",
                        aciklama
                    )
                    
                Case "UPDATE", "GUNCELLE"
                    AuditLogger.LogUpdate(
                        AuditLogger.ModulAdi.FATURA,
                        "tbStokFisiMaster",
                        fisID,
                        fisNo,
                        "Degisiklik",
                        eskiDeger,
                        yeniDeger,
                        aciklama
                    )
                    
                Case "DELETE", "SIL", "IPTAL"
                    AuditLogger.LogDelete(
                        AuditLogger.ModulAdi.FATURA,
                        "tbStokFisiMaster",
                        fisID,
                        fisNo,
                        "{""silindi"":true}",
                        aciklama
                    )
            End Select
        Catch ex As Exception
            ' Log hatası uygulamayı etkilemesin
            Debug.WriteLine("Audit log hatası: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Perakende satış işlemleri için audit log
    ''' </summary>
    Public Sub LogPerakende(islemTipi As String, fisID As Long, fisNo As String,
                            aciklama As String, Optional eskiDeger As String = "", 
                            Optional yeniDeger As String = "")
        Try
            ' DÜZELTİLDİ: eskiDeger ve yeniDeger boş olsa bile log yaz!
            
            Select Case islemTipi.ToUpper()
                Case "INSERT", "YENI"
                    AuditLogger.LogInsert(
                        AuditLogger.ModulAdi.PERAKENDE,
                        "tbStokFisiMaster",
                        fisID,
                        fisNo,
                        "{""aciklama"":""" & aciklama & """}",
                        aciklama
                    )
                    
                Case "UPDATE", "GUNCELLE"
                    AuditLogger.LogUpdate(
                        AuditLogger.ModulAdi.PERAKENDE,
                        "tbStokFisiMaster",
                        fisID,
                        fisNo,
                        "Degisiklik",
                        eskiDeger,
                        yeniDeger,
                        aciklama
                    )
                    
                Case "DELETE", "SIL", "IPTAL"
                    AuditLogger.LogCancel(
                        AuditLogger.ModulAdi.PERAKENDE,
                        "tbStokFisiMaster",
                        fisID,
                        fisNo,
                        aciklama
                    )
            End Select
        Catch ex As Exception
            ' Log hatası uygulamayı etkilemesin
            Debug.WriteLine("Audit log hatası: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Stok işlemleri için audit log
    ''' </summary>
    Public Sub LogStok(islemTipi As String, stokID As Long, stokKodu As String,
                       aciklama As String, Optional eskiDeger As String = "", 
                       Optional yeniDeger As String = "")
        Try
            ' DÜZELTİLDİ: eskiDeger ve yeniDeger boş olsa bile log yaz!
            
            Select Case islemTipi.ToUpper()
                Case "INSERT", "YENI"
                    AuditLogger.LogInsert(
                        AuditLogger.ModulAdi.STOK,
                        "tbStok",
                        stokID,
                        stokKodu,
                        "{""aciklama"":""" & aciklama & """}",
                        aciklama
                    )
                    
                Case "UPDATE", "GUNCELLE"
                    AuditLogger.LogUpdate(
                        AuditLogger.ModulAdi.STOK,
                        "tbStok",
                        stokID,
                        stokKodu,
                        "Degisiklik",
                        eskiDeger,
                        yeniDeger,
                        aciklama
                    )
                    
                Case "DELETE", "SIL"
                    AuditLogger.LogDelete(
                        AuditLogger.ModulAdi.STOK,
                        "tbStok",
                        stokID,
                        stokKodu,
                        "{""silindi"":true}",
                        aciklama
                    )
            End Select
        Catch ex As Exception
            ' Log hatası uygulamayı etkilemesin
            Debug.WriteLine("Audit log hatası: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Müşteri/Cari işlemleri için audit log
    ''' </summary>
    Public Sub LogMusteri(islemTipi As String, cariID As Long, cariKodu As String,
                          aciklama As String, Optional eskiDeger As String = "", 
                          Optional yeniDeger As String = "")
        Try
            ' DÜZELTİLDİ: eskiDeger ve yeniDeger boş olsa bile log yaz!
            
            Select Case islemTipi.ToUpper()
                Case "INSERT", "YENI"
                    AuditLogger.LogInsert(
                        AuditLogger.ModulAdi.MUSTERI,
                        "tbCari",
                        cariID,
                        cariKodu,
                        "{""aciklama"":""" & aciklama & """}",
                        aciklama
                    )
                    
                Case "UPDATE", "GUNCELLE"
                    AuditLogger.LogUpdate(
                        AuditLogger.ModulAdi.MUSTERI,
                        "tbCari",
                        cariID,
                        cariKodu,
                        "Degisiklik",
                        eskiDeger,
                        yeniDeger,
                        aciklama
                    )
                    
                Case "DELETE", "SIL"
                    AuditLogger.LogDelete(
                        AuditLogger.ModulAdi.MUSTERI,
                        "tbCari",
                        cariID,
                        cariKodu,
                        "{""silindi"":true}",
                        aciklama
                    )
            End Select
        Catch ex As Exception
            ' Log hatası uygulamayı etkilemesin
            Debug.WriteLine("Audit log hatası: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Finans işlemleri için audit log
    ''' </summary>
    Public Sub LogFinans(islemTipi As String, finansID As Long, islemNo As String,
                         aciklama As String, Optional eskiDeger As String = "", 
                         Optional yeniDeger As String = "")
        Try
            ' DÜZELTİLDİ: eskiDeger ve yeniDeger boş olsa bile log yaz!
            
            Select Case islemTipi.ToUpper()
                Case "INSERT", "YENI"
                    AuditLogger.LogInsert(
                        AuditLogger.ModulAdi.FINANS,
                        "tbFinans",
                        finansID,
                        islemNo,
                        "{""aciklama"":""" & aciklama & """}",
                        aciklama
                    )
                    
                Case "UPDATE", "GUNCELLE"
                    AuditLogger.LogUpdate(
                        AuditLogger.ModulAdi.FINANS,
                        "tbFinans",
                        finansID,
                        islemNo,
                        "Degisiklik",
                        eskiDeger,
                        yeniDeger,
                        aciklama
                    )
                    
                Case "DELETE", "SIL"
                    AuditLogger.LogDelete(
                        AuditLogger.ModulAdi.FINANS,
                        "tbFinans",
                        finansID,
                        islemNo,
                        "{""silindi"":true}",
                        aciklama
                    )
            End Select
        Catch ex As Exception
            ' Log hatası uygulamayı etkilemesin
            Debug.WriteLine("Audit log hatası: " & ex.Message)
        End Try
    End Sub
    
End Module
