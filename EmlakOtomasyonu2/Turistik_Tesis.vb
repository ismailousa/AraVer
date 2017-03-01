Public Class Turistik_Tesis
    Inherits Emlak
    Private Tip_ID As Byte = 255
    Private Otel_Yildiz_Sayisi As Byte = 255
    Private Apart_Sayisi As Short = -1
    Private Oda_Sayisi As Short = -1
    Private Yatak_Sayisi As Short = -1
    Private Kat_Sayisi As Byte = 255
    Private Bina_Yasi As Byte = 255
    Private Acik_Alan As Integer = -1
    Private Kapali_Alan As Integer = -1
    Private Zemin_Etudu? As Boolean = Nothing
    Private Yapi_Durumu? As Boolean = Nothing
    Private Krediye_Uygun? As Boolean = Nothing
    Public Property TipID As Byte
        Get
            Return Tip_ID
        End Get
        Set(value As Byte)
            Tip_ID = value
        End Set
    End Property
    Public Property OtelYildizSayisi As Byte
        Get
            Return Otel_Yildiz_Sayisi
        End Get
        Set(value As Byte)
            Otel_Yildiz_Sayisi = value
        End Set
    End Property
    Public Property ApartSayisi As Short
        Get
            Return Apart_Sayisi
        End Get
        Set(value As Short)
            Apart_Sayisi = value
        End Set
    End Property
    Public Property OdaSayisi As Short
        Get
            Return Oda_Sayisi
        End Get
        Set(value As Short)
            Oda_Sayisi = value
        End Set
    End Property
    Public Property YatakSayisi As Short
        Get
            Return Yatak_Sayisi
        End Get
        Set(value As Short)
            Yatak_Sayisi = value
        End Set
    End Property
    Public Property KatSayisi As Byte
        Get
            Return Kat_Sayisi
        End Get
        Set(value As Byte)
            Kat_Sayisi = value
        End Set
    End Property
    Public Property BinaYasi As Byte
        Get
            Return Bina_Yasi
        End Get
        Set(value As Byte)
            Bina_Yasi = value
        End Set
    End Property
    Public Property AcikAlan As Integer
        Get
            Return Acik_Alan
        End Get
        Set(value As Integer)
            Acik_Alan = value
        End Set
    End Property
    Public Property KapaliAlan As Integer
        Get
            Return Kapali_Alan
        End Get
        Set(value As Integer)
            Kapali_Alan = value
        End Set
    End Property
    Public Property ZeminEtudu As Boolean?
        Get
            Return Zemin_Etudu
        End Get
        Set(value? As Boolean)
            Zemin_Etudu = value
        End Set
    End Property
    Public Property YapiDurumu As Boolean?
        Get
            Return Yapi_Durumu
        End Get
        Set(value? As Boolean)
            Yapi_Durumu = value
        End Set
    End Property
    Public Property KrediyeUygun As Boolean?
        Get
            Return Krediye_Uygun
        End Get
        Set(value? As Boolean)
            Krediye_Uygun = value
        End Set
    End Property
End Class
