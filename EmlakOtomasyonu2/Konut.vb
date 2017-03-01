Public Class Konut
    Inherits Emlak
    Private Satis_Tur_ID As Byte
    Private Konut_Tip_ID As Byte
    Private Buyuklk As UShort
    Private Acik_Alan_Buyuklugu As Integer = Nothing
    Private Bina_Yasi As Byte
    Private Oda_Sayisi_ID As Byte
    Private Bulundugu_Kat_ID As Byte
    Private Kat_Sayisi As Byte
    Private Isitma_ID As Byte
    Private Banyo_Sayisi As Byte
    Private Esyli As Boolean = False
    Private Kullanim_Durumu As Boolean = False
    Private Site_Icerisinde As Boolean = False
    Private Aidatt As UShort
    Private Krediye_Uygun As Boolean = False
    Private Takass As Boolean = False
    Public Property SatisTurID As Byte
        Get
            Return Satis_Tur_ID
        End Get
        Set(value As Byte)
            Satis_Tur_ID = value
        End Set
    End Property
    Public Property KonutTipID As Byte
        Get
            Return Konut_Tip_ID
        End Get
        Set(value As Byte)
            Konut_Tip_ID = value
        End Set
    End Property
    Public Property Buyukluk As UShort
        Get
            Return Buyuklk
        End Get
        Set(value As UShort)
            Buyuklk = value
        End Set
    End Property
    Public Property AcikAlanBuyuklugu As Integer
        Get
            Return Acik_Alan_Buyuklugu
        End Get
        Set(value As Integer)
            Acik_Alan_Buyuklugu = value
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
    Public Property OdaSayisiID As Byte
        Get
            Return Oda_Sayisi_ID
        End Get
        Set(value As Byte)
            Oda_Sayisi_ID = value
        End Set
    End Property
    Public Property BulunduguKatID As Byte
        Get
            Return Bulundugu_Kat_ID
        End Get
        Set(value As Byte)
            Bulundugu_Kat_ID = value
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
    Public Property IsitmaID As Byte
        Get
            Return Isitma_ID
        End Get
        Set(value As Byte)
            Isitma_ID = value
        End Set
    End Property
    Public Property BanyoSayisi As Byte
        Get
            Return Banyo_Sayisi
        End Get
        Set(value As Byte)
            Banyo_Sayisi = value
        End Set
    End Property
    Public Property Esyali As Boolean
        Get
            Return Esyli
        End Get
        Set(value As Boolean)
            Esyli = value
        End Set
    End Property
    Public Property KullanimDurumu As Boolean
        Get
            Return Kullanim_Durumu
        End Get
        Set(value As Boolean)
            Kullanim_Durumu = value
        End Set
    End Property
    Public Property SiteIcerisinde As Boolean
        Get
            Return Site_Icerisinde
        End Get
        Set(value As Boolean)
            Site_Icerisinde = value
        End Set
    End Property
    Public Property Aidat As UShort
        Get
            Return Aidatt
        End Get
        Set(value As UShort)
            Aidatt = value
        End Set
    End Property
    Public Property KrediyeUygun As Boolean
        Get
            Return Krediye_Uygun
        End Get
        Set(value As Boolean)
            Krediye_Uygun = value
        End Set
    End Property
    Public Property Takas As Boolean
        Get
            Return Takass
        End Get
        Set(value As Boolean)
            Takass = value
        End Set
    End Property
End Class
