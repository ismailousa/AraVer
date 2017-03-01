Public Class SporRadyoPazarCiftlik
    Inherits Isyeri
    Private Isyeri_ID As Integer
    Private Isyeri_Tipi As Byte
    Private Kapali_Alan As Short
    Private Kullanim_Durumu As Boolean
    Private SporTesis_Tipi As Byte
    Public Property SporTesisTipi() As Byte
        Get
            Return SporTesis_Tipi
        End Get
        Set(ByVal value As Byte)
            SporTesis_Tipi = value
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
    Public Property KapaliAlan() As Short
        Get
            Return Kapali_Alan
        End Get
        Set(ByVal value As Short)
            Kapali_Alan = value
        End Set
    End Property
    Public Property IsyeriTipi() As Byte
        Get
            Return Isyeri_Tipi
        End Get
        Set(ByVal value As Byte)
            Isyeri_Tipi = value
        End Set
    End Property
    Public Property IsyeriID() As Integer
        Get
            Return Isyeri_ID
        End Get
        Set(ByVal value As Integer)
            Isyeri_ID = value
        End Set
    End Property
End Class
