Public Class DepoBinaPlazaFabrika
    Inherits Isyeri
    Private Isyeri_Tipi As Byte
    Private Giris_Yukseklik As Byte = 255
    Private Kullanim_Durumu As Boolean
    Private Tapu_Durumu As Byte
    Private Zemin_Etudu As Boolean
    Private Oda_Bolum_Sayisi As Short = -1
    Private Kat_Sayisi As Byte = 255
    Private Kapali_ALan As Short = -1
    Private Bina_Adedi As Byte = 255
    Private Aidatt As Short = -1
    Private Bulundugu_Kat As Byte = 255
    Private Bina_Tipi_ID As Byte = 255
    Private depozito As Boolean
    Public Property depozitosu() As Boolean
        Get
            Return depozito
        End Get
        Set(value As Boolean)
            depozito = value
        End Set
    End Property
    Public Property BinaTipiID() As Byte
        Get
            Return Bina_Tipi_ID
        End Get
        Set(ByVal value As Byte)
            Bina_Tipi_ID = value
        End Set
    End Property
    Public Property BulunduguKat() As Byte
        Get
            Return Bulundugu_Kat
        End Get
        Set(ByVal value As Byte)
            Bulundugu_Kat = value
        End Set
    End Property
    Public Property Aidat() As Short
        Get
            Return Aidatt
        End Get
        Set(ByVal value As Short)
            Aidatt = value
        End Set
    End Property
    Public Property BinaAdedi() As Byte
        Get
            Return Bina_Adedi
        End Get
        Set(ByVal value As Byte)
            Bina_Adedi = value
        End Set
    End Property
    Public Property KapaliAlan() As Short
        Get
            Return Kapali_ALan
        End Get
        Set(ByVal value As Short)
            Kapali_ALan = value
        End Set
    End Property
    Public Property KatSayisi() As Byte
        Get
            Return Kat_Sayisi
        End Get
        Set(ByVal value As Byte)
            Kat_Sayisi = value
        End Set
    End Property
    Public Property odaBolumSayisi() As Short
        Get
            Return Oda_Bolum_Sayisi
        End Get
        Set(value As Short)
            Oda_Bolum_Sayisi = value
        End Set
    End Property
    Public Property ZeminEtudu() As Boolean
        Get
            Return Zemin_Etudu
        End Get
        Set(ByVal value As Boolean)
            Zemin_Etudu = value
        End Set
    End Property
    Public Property TapuDurumu() As Byte
        Get
            Return Tapu_Durumu
        End Get
        Set(ByVal value As Byte)
            Tapu_Durumu = value
        End Set
    End Property
    Public Property KullanimDurumu() As Boolean
        Get
            Return Kullanim_Durumu
        End Get
        Set(ByVal value As Boolean)
            Kullanim_Durumu = value
        End Set
    End Property
    Public Property GirisYukseklik() As Byte
        Get
            Return Giris_Yukseklik
        End Get
        Set(ByVal value As Byte)
            Giris_Yukseklik = value
        End Set
    End Property
    Public Property isyeriTipi() As Byte
        Get
            Return Isyeri_Tipi
        End Get
        Set(value As Byte)
            Isyeri_Tipi = value
        End Set
    End Property
End Class
