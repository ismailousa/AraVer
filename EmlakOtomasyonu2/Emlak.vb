Public Class Emlak
    Protected ilan_No As String
    Private ilan_Aciklama As String
    Private ilan_Baslik As String
    Private ilan_Tarihi As Date
    Private ilan_Veren_ID As Integer
    Private ilan_Tur_ID As Byte
    Private ilan_Satis_ID As Byte
    Private resim1() As Byte = Nothing
    Private resim2() As Byte = Nothing
    Private resim3() As Byte = Nothing
    Private resim4() As Byte = Nothing
    Private resim5() As Byte = Nothing
    Private resim6() As Byte = Nothing
    Private resim7() As Byte = Nothing
    Private resim8() As Byte = Nothing
    Private video As String = Nothing
    Private myMahalle As Integer
    Private myFiyat As Integer
    Private islem_Tamam As Boolean = False
    Private ilan_Adres As String
    Sub New()
        ilan_Tarihi = Date.Today
    End Sub
    Public Property ilanAdres() As String
        Get
            Return ilan_Adres
        End Get
        Set(ByVal value As String)
            ilan_Adres = value
        End Set
    End Property

    Public Property ilanSatisID() As Byte
        Get
            Return ilan_Satis_ID
        End Get
        Set(ByVal value As Byte)
            ilan_Satis_ID = value
        End Set
    End Property

    Private Sub AdetToString(adet As Integer)
        If adet < 10 Then : ilan_No += "000000"
        ElseIf adet < 100 Then : ilan_No += "00000"
        ElseIf adet < 1000 Then : ilan_No += "0000"
        ElseIf adet < 10000 Then : ilan_No += "000"
        ElseIf adet < 100000 Then : ilan_No += "00"
        ElseIf adet < 1000000 Then : ilan_No += "0"
        End If
    End Sub
    Public Sub ilanNoOlustur(ilan_Tur As Byte, Tip As Byte, Satis_Tur As Byte, adet As Integer)
        ilanTurID = ilan_Tur
        ilan_No = ilan_Tur.ToString()
        If Tip < 10 Then : ilan_No += "0" & Tip.ToString()
        Else : ilan_No += Tip.ToString()
        End If
        ilan_No += Satis_Tur.ToString()
        AdetToString(adet)
        ilan_No += adet.ToString()
    End Sub
    Public Sub ilanNoOlustur(ilan_Tur As Byte, Satis_Tur As Byte, adet As Integer)
        ilanTurID = ilan_Tur
        ilan_No = ilan_Tur.ToString() & "60" & Satis_Tur.ToString()
        AdetToString(adet)
        ilan_No += adet.ToString()
    End Sub
    Public Property ilanNo As String
        Get
            Return ilan_No
        End Get
        Set(value As String)
            ilan_No = value
        End Set
    End Property
    Public Property ilanAciklama As String
        Get
            Return ilan_Aciklama
        End Get
        Set(value As String)
            ilan_Aciklama = value
        End Set
    End Property
    Public Property ilanBaslik As String
        Get
            Return ilan_Baslik
        End Get
        Set(value As String)
            ilan_Baslik = value
        End Set
    End Property
    Public Property ilanTarihi As Date
        Get
            Return ilan_Tarihi
        End Get
        Set(value As Date)
            ilan_Tarihi = value
        End Set
    End Property
    Public Property ilanVerenID As Integer
        Get
            Return ilan_Veren_ID
        End Get
        Set(value As Integer)
            ilan_Veren_ID = value
        End Set
    End Property
    Public Property ilanTurID As Byte
        Get
            Return ilan_Tur_ID
        End Get
        Set(value As Byte)
            ilan_Tur_ID = value
        End Set
    End Property

    Public Property mahalle As Integer
        Get
            Return myMahalle
        End Get
        Set(value As Integer)
            myMahalle = value
        End Set
    End Property
    Public Property fiyat As Integer
        Get
            Return myFiyat
        End Get
        Set(value As Integer)
            myFiyat = value
        End Set
    End Property
    Public Property islemTamam As Boolean
        Get
            Return islem_Tamam
        End Get
        Set(value As Boolean)
            islem_Tamam = value
        End Set
    End Property
    Public Property foto1 As Byte()
        Get
            Return resim1
        End Get
        Set(ByVal value As Byte())
            resim1 = value
        End Set
    End Property
    Public Property foto2 As Byte()
        Get
            Return resim2
        End Get
        Set(ByVal value As Byte())
            resim2 = value
        End Set
    End Property
    Public Property foto3 As Byte()
        Get
            Return resim3
        End Get
        Set(ByVal value As Byte())
            resim3 = value
        End Set
    End Property
    Public Property foto4 As Byte()
        Get
            Return resim4
        End Get
        Set(ByVal value As Byte())
            resim4 = value
        End Set
    End Property
    Public Property foto5 As Byte()
        Get
            Return resim5
        End Get
        Set(ByVal value As Byte())
            resim5 = value
        End Set
    End Property
    Public Property foto6 As Byte()
        Get
            Return resim6
        End Get
        Set(ByVal value As Byte())
            resim6 = value
        End Set
    End Property
    Public Property foto7 As Byte()
        Get
            Return resim7
        End Get
        Set(ByVal value As Byte())
            resim7 = value
        End Set
    End Property
    Public Property foto8 As Byte()
        Get
            Return resim8
        End Get
        Set(ByVal value As Byte())
            resim8 = value
        End Set
    End Property
    Public Property myVideo() As String
        Get
            Return video
        End Get
        Set(ByVal value As String)
            video = value
        End Set
    End Property

End Class
