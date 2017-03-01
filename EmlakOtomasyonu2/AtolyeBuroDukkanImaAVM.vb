Public Class AtolyeBuroDukkanImaAVM
    Inherits Isyeri
    Private isyeri_tipi As Byte
    Private aidat As Short = -1
    Private oda_bolum_sayisi As Short = -1
    Private depozito As Boolean = Nothing
    Private kat_sayisi As Byte = 255
    Private asansor_sayisi As Byte = 255

    Public Property isyeriTipi() As Byte
        Get
            Return isyeri_tipi
        End Get
        Set(value As Byte)
            isyeri_tipi = value
        End Set
    End Property

    Public Property asansorSayisi() As Byte
        Get
            Return asansor_sayisi
        End Get
        Set(value As Byte)
            asansor_sayisi = value
        End Set
    End Property

    Public Property aidati() As Short
        Get
            Return aidat
        End Get
        Set(value As Short)
            aidat = value
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
    Public Property depozitosu() As Short
        Get
            Return depozito
        End Get
        Set(value As Short)
            depozito = value
        End Set
    End Property
    Public Property katSayisi() As Boolean
        Get
            Return kat_sayisi
        End Get
        Set(value As Boolean)
            kat_sayisi = value
        End Set
    End Property
End Class
