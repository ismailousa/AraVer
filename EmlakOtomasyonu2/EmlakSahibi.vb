Public Class EmlakSahibi
    Private Isimm As String
    Private Cep_Tel As String
    Private Ev_Tel As String
    Private Emaill As String
    Private IDno As Integer
    Public Property ID() As Integer
        Get
            Return IDno
        End Get
        Set(ByVal value As Integer)
            IDno = value
        End Set
    End Property
    Public Property Isim As String
        Get
            Return Isimm
        End Get
        Set(value As String)
            Isimm = value
        End Set
    End Property
    Public Property CepTel As String
        Get
            Return Cep_Tel
        End Get
        Set(value As String)
            Cep_Tel = value
        End Set
    End Property
    Public Property EvTel As String
        Get
            Return Ev_Tel
        End Get
        Set(value As String)
            Ev_Tel = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return Emaill
        End Get
        Set(value As String)
            Emaill = value
        End Set
    End Property
End Class
