Public Class Arsa
    Inherits Emlak
    Private imar_Durumu_ID As Byte
    Private Buyuklk As UShort
    Private Ada_No As Integer = -1
    Private Parsel_No As Integer = -1
    Private Pafta_No As Integer = -1
    Private Kaks_ID As Byte = 255
    Private Gabari_ID As Byte = 255
    Private Tapu_Durumu_ID As Byte = 255
    Private KrediUygun As Boolean = False
    Private Takasli As Boolean = False
    Private Kat_Karsiligi As Boolean = False
    Public Property KatKarsiligi() As Boolean
        Get
            Return Kat_Karsiligi
        End Get
        Set(ByVal value As Boolean)
            Kat_Karsiligi = value
        End Set
    End Property
    Public Property Takas() As Boolean
        Get
            Return Takasli
        End Get
        Set(ByVal value As Boolean)
            Takasli = value
        End Set
    End Property
    Public Property Kredi() As Boolean
        Get
            Return KrediUygun
        End Get
        Set(ByVal value As Boolean)
            KrediUygun = value
        End Set
    End Property
    Public Property imarDurumuID As Byte
        Get
            Return imar_Durumu_ID
        End Get
        Set(value As Byte)
            imar_Durumu_ID = value
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
    Public Property AdaNo As Integer
        Get
            Return Ada_No
        End Get
        Set(value As Integer)
            Ada_No = value
        End Set
    End Property
    Public Property ParselNo As Integer
        Get
            Return Parsel_No
        End Get
        Set(value As Integer)
            Parsel_No = value
        End Set
    End Property
    Public Property PaftaNo As Integer
        Get
            Return Pafta_No
        End Get
        Set(value As Integer)
            Pafta_No = value
        End Set
    End Property
    Public Property KaksID As Byte
        Get
            Return Kaks_ID
        End Get
        Set(value As Byte)
            Kaks_ID = value
        End Set
    End Property
    Public Property GabariID As Byte
        Get
            Return Gabari_ID
        End Get
        Set(value As Byte)
            Gabari_ID = value
        End Set
    End Property
    Public Property TapuDurumuID As Byte
        Get
            Return Tapu_Durumu_ID
        End Get
        Set(value As Byte)
            Tapu_Durumu_ID = value
        End Set
    End Property
End Class
