Public Class BufeDugunSpaSineOto
    Inherits Isyeri
    Private isyeri_tipi As Byte
    Private oda_bolum_sayisi As Short = -1
    Private depozito As Boolean = Nothing
    Private kullanim_durumu As Boolean
    Private tavan_yukseklik As Byte = 255
    Private kat_sayisi As Byte = 255
    Private otopark_turu As Byte = 255
    Private bunlundugu_kat As Byte = 255
    Private cinsiyet As Byte = 255
    Private masa_sayisi As Short = -1
    Private kisi_kapasitesi As Integer = -1
    Private arac_sayisi As Integer = -1
    Private Yapi_Tipi As Byte = 255

    Public Property isyeriTipi() As Byte
        Get
            Return isyeri_tipi
        End Get
        Set(value As Byte)
            isyeri_tipi = value
        End Set
    End Property
    Public Property YapiTipi() As Byte
        Get
            Return Yapi_Tipi
        End Get
        Set(value As Byte)
            Yapi_Tipi = value
        End Set
    End Property
    Public Property odaBolumSayisi() As Short
        Get
            Return oda_bolum_sayisi
        End Get
        Set(value As Short)
            oda_bolum_sayisi = value
        End Set
    End Property
    Public Property depozitosu() As Boolean
        Get
            Return depozito
        End Get
        Set(value As Boolean)
            depozito = value
        End Set
    End Property
    Public Property katSayisi() As Byte
        Get
            Return kat_sayisi
        End Get
        Set(value As Byte)
            kat_sayisi = value
        End Set
    End Property
    Public Property kullanimDurumu() As Boolean
        Get
            Return kullanim_durumu
        End Get
        Set(value As Boolean)
            kullanim_durumu = value
        End Set
    End Property
    Public Property tavanYukseklik() As Byte
        Get
            Return tavan_yukseklik
        End Get
        Set(value As Byte)
            tavan_yukseklik = value
        End Set
    End Property
    Public Property otoparkTuru() As Byte
        Get
            Return otopark_turu
        End Get
        Set(value As Byte)
            otopark_turu = value
        End Set
    End Property
    Public Property bulunduguKat() As Byte
        Get
            Return bunlundugu_kat
        End Get
        Set(value As Byte)
            bunlundugu_kat = value
        End Set
    End Property
    Public Property cinsiyeti() As Byte
        Get
            Return cinsiyet
        End Get
        Set(value As Byte)
            cinsiyet = value
        End Set
    End Property
    Public Property masaSayisi As Short
        Get
            Return masa_sayisi
        End Get
        Set(value As Short)
            masa_sayisi = value
        End Set
    End Property
    Public Property kisiKapasitesi() As Integer
        Get
            Return kisi_kapasitesi
        End Get
        Set(value As Integer)
            kisi_kapasitesi = value
        End Set
    End Property
    Public Property aracSayisi() As Integer
        Get
            Return arac_sayisi
        End Get
        Set(value As Integer)
            arac_sayisi = value
        End Set
    End Property
End Class
