' ============================================
' TRENDYOL API MODEL SINIFLARI
' Dosya: TrendyolModels.vb
' Tarih: 2026-01-30
' Açıklama: Trendyol API için veri modelleri
' ============================================

Imports System.Collections.Generic

''' <summary>
''' Fiyat ve stok güncelleme için item modeli
''' </summary>
Public Class PriceStockItem
    Public Property Barcode As String
    Public Property Quantity As Integer
    Public Property SalePrice As Decimal
    Public Property ListPrice As Decimal
End Class

''' <summary>
''' Fiyat/Stok güncelleme isteği
''' </summary>
Public Class PriceStockRequest
    Public Property Items As List(Of PriceStockItem)
    
    Public Sub New()
        Items = New List(Of PriceStockItem)()
    End Sub
End Class

''' <summary>
''' Batch request sonucu
''' </summary>
Public Class BatchResponse
    Public Property BatchRequestId As String
End Class

''' <summary>
''' Batch status item
''' </summary>
Public Class BatchStatusItem
    Public Property Barcode As String
    Public Property Status As String
    Public Property FailureReasons As List(Of String)
    
    Public Sub New()
        FailureReasons = New List(Of String)()
    End Sub
End Class

''' <summary>
''' Batch status response
''' </summary>
Public Class BatchStatusResponse
    Public Property BatchRequestId As String
    Public Property Status As String
    Public Property Items As List(Of BatchStatusItem)
    Public Property ItemCount As Integer
    Public Property FailedItemCount As Integer
    
    Public Sub New()
        Items = New List(Of BatchStatusItem)()
    End Sub
End Class

''' <summary>
''' Ürün arama sonucu (tek ürün)
''' </summary>
Public Class TrendyolProduct
    Public Property Id As String
    Public Property Barcode As String
    Public Property Title As String
    Public Property Description As String
    Public Property ProductMainId As String
    Public Property BrandId As String
    Public Property BrandName As String
    Public Property Brand As String
    Public Property CategoryId As String
    Public Property CategoryName As String
    Public Property ListPrice As Decimal
    Public Property SalePrice As Decimal
    Public Property Quantity As Integer
    Public Property OnSale As Boolean
    Public Property Approved As Boolean
    Public Property Archived As Boolean
    Public Property Rejected As Boolean
    Public Property ProductCode As String
    Public Property StockCode As String
End Class

''' <summary>
''' Ürün listesi response
''' </summary>
Public Class ProductListResponse
    Public Property TotalElements As Integer
    Public Property TotalPages As Integer
    Public Property Page As Integer
    Public Property Size As Integer
    Public Property Content As List(Of TrendyolProduct)
    
    Public Sub New()
        Content = New List(Of TrendyolProduct)()
    End Sub
End Class

''' <summary>
''' Kategori modeli
''' </summary>
Public Class TrendyolCategory
    Public Property Id As Integer
    Public Property Name As String
    Public Property ParentId As Integer?
    Public Property SubCategories As List(Of TrendyolCategory)
    
    Public Sub New()
        SubCategories = New List(Of TrendyolCategory)()
    End Sub
End Class

''' <summary>
''' Kategori listesi response
''' </summary>
Public Class CategoryListResponse
    Public Property Categories As List(Of TrendyolCategory)
    
    Public Sub New()
        Categories = New List(Of TrendyolCategory)()
    End Sub
End Class

''' <summary>
''' Marka modeli
''' </summary>
Public Class TrendyolBrand
    Public Property Id As Integer
    Public Property Name As String
End Class

''' <summary>
''' Marka listesi response
''' </summary>
Public Class BrandListResponse
    Public Property Brands As List(Of TrendyolBrand)
    
    Public Sub New()
        Brands = New List(Of TrendyolBrand)()
    End Sub
End Class

''' <summary>
''' Trendyol Public API Search Response
''' </summary>
Public Class TrendyolPublicSearchResponse
    Public Property IsSuccess As Boolean
    Public Property StatusCode As Integer
    Public Property Result As TrendyolPublicSearchResultData
End Class

Public Class TrendyolPublicSearchResultData
    Public Property Products As List(Of TrendyolPublicProduct)
End Class

Public Class TrendyolPublicProduct
    Public Property Id As Long
    Public Property Name As String
    Public Property CategoryId As Integer
    Public Property CategoryName As String
    Public Property CategoryHierarchy As String
    Public Property MerchantId As Integer
    Public Property Url As String
    Public Property Brand As TrendyolPublicBrand
    Public Property Price As TrendyolPublicPrice
End Class

Public Class TrendyolPublicBrand
    Public Property Id As Integer
    Public Property Name As String
End Class

Public Class TrendyolPublicPrice
    Public Property SellingPrice As Decimal
    Public Property DiscountedPrice As Decimal
    Public Property OriginalPrice As Decimal
End Class

Public Class TrendyolPublicSearchResult
    Public Property Products As List(Of TrendyolPublicProduct)
    
    Public Sub New()
        Products = New List(Of TrendyolPublicProduct)()
    End Sub
End Class

''' <summary>
''' API yanıt wrapper
''' </summary>
Public Class ApiResult(Of T)
    Public Property Success As Boolean
    Public Property Data As T
    Public Property ErrorMessage As String
    Public Property HttpStatusCode As Integer
    Public Property BatchRequestId As String
    
    Public Sub New()
        Success = False
    End Sub
    
    Public Shared Function Ok(data As T, Optional batchId As String = Nothing) As ApiResult(Of T)
        Return New ApiResult(Of T) With {
            .Success = True,
            .Data = data,
            .BatchRequestId = batchId
        }
    End Function
    
    Public Shared Function Fail(errorMessage As String, Optional statusCode As Integer = 0) As ApiResult(Of T)
        Return New ApiResult(Of T) With {
            .Success = False,
            .ErrorMessage = errorMessage,
            .HttpStatusCode = statusCode
        }
    End Function
End Class

''' <summary>
''' Yerel eşleştirme modeli (tbTrendyolUrunEsleme tablosu için)
''' </summary>
Public Class UrunEsleme
    Public Property EslemeId As Integer
    Public Property StokId As Integer
    Public Property BizimBarkod As String
    Public Property StokKodu As String
    Public Property TrendyolBarkod As String
    Public Property TrendyolProductId As Long
    Public Property TrendyolTitle As String
    Public Property TrendyolCategoryId As Integer
    Public Property TrendyolBrand As String
    Public Property ModelCode As String
    Public Property EslesmeDurumu As Integer  ' 0=Bekliyor, 1=Eşleşti, 2=Eşleşemedi, 3=Manuel
    Public Property BuyBoxDurumu As Integer   ' 0=Bilinmiyor, 1=BuyBox'ta, 2=BuyBox dışı
    Public Property BuyBoxFiyat As Decimal
    Public Property SaticiSayisi As Integer
    Public Property SonFiyat As Decimal
    Public Property SonStok As Integer
    Public Property SonSenkron As DateTime?
    Public Property SonHata As String
    Public Property ManuelKontrolGerekli As Boolean
    Public Property Aktif As Boolean
End Class

''' <summary>
''' Eşleşme durumu enum
''' </summary>
Public Enum EslesmeDurumuEnum
    Bekliyor = 0
    Eslesti = 1
    Eslesemedi = 2
    Manuel = 3
End Enum

''' <summary>
''' BuyBox durumu enum
''' </summary>
Public Enum BuyBoxDurumuEnum
    Bilinmiyor = 0
    BuyBoxta = 1
    BuyBoxDisi = 2
    TekSatici = 3
End Enum
