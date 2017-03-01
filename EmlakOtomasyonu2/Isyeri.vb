Public Class Isyeri
    Inherits Emlak
    Private Isyeri_Grup_ID As Byte
    Private Bina_Yasi As Byte = 255
    Private Isitma_ID As Byte = 255
    Private Durumu As Boolean
    Private krediye_Uygun As Boolean
    Private Buykluk As Integer = -1
    Private Takasli As Boolean
    Public Property IsyeriGrupID() As Byte
        Get
            Return Isyeri_Grup_ID
        End Get
        Set(ByVal value As Byte)
            Isyeri_Grup_ID = value
        End Set
    End Property
    Public Property BinaYasi() As Byte
        Get
            Return Bina_Yasi
        End Get
        Set(ByVal value As Byte)
            Bina_Yasi = value
        End Set
    End Property
    Public Property IsitmaID() As Byte
        Get
            Return Isitma_ID
        End Get
        Set(ByVal value As Byte)
            Isitma_ID = value
        End Set
    End Property
    Public Property Durum() As Boolean
        Get
            Return Durumu
        End Get
        Set(ByVal value As Boolean)
            Durumu = value
        End Set
    End Property
    Public Property krediyeUygun() As Boolean
        Get
            Return krediye_Uygun
        End Get
        Set(ByVal value As Boolean)
            krediye_Uygun = value
        End Set
    End Property
    Public Property Buyukluk() As Integer
        Get
            Return Buykluk
        End Get
        Set(ByVal value As Integer)
            Buykluk = value
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
End Class
