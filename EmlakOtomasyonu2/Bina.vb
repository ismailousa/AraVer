Public Class Bina
    Inherits Emlak
    Private Kat_Sayisi As Byte
    Private Bina_Yasi As Byte
    Private Bir_Kattaki_Daire_Sayisi As Byte
    Private Isitma_ID As Byte
    Private Buyuklk As UShort
    Private Krediye_Uygun As Boolean
    Private Takasli As Boolean
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
    Public Property BirKattakiDaireSayisi As Byte
        Get
            Return Bir_Kattaki_Daire_Sayisi
        End Get
        Set(value As Byte)
            Bir_Kattaki_Daire_Sayisi = value
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
    Public Property Buyukluk As UShort
        Get
            Return Buyuklk
        End Get
        Set(value As UShort)
            Buyuklk = value
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
            Return Takasli
        End Get
        Set(value As Boolean)
            Takasli = value
        End Set
    End Property
End Class
