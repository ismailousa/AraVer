Public Class Currency

    Private dolar As Double = 0
    Private euro As Double = 0
    Private lira As Double = 0
    Private sterlin As Double = 0

    Sub New(ByVal val As Double, ByVal cur As Integer)
        Select Case cur
            Case 0
                dolar = 0.284357 * val
                euro = 0.272062 * val
                sterlin = 0.231467 * val
            Case 1
                lira = 3.5167 * val
                euro = 0.95676 * val
                sterlin = 0.814001 * val
            Case 2
                dolar = 1.04519 * val
                lira = 3.67563 * val
                sterlin = 0.850789 * val
            Case 3
                dolar = 1.2285 * val
                euro = 1.17538 * val
                lira = 4.32027 * val
        End Select
    End Sub

    Public Property dolars() As Double
        Get
            Return dolar
        End Get
        Set(value As Double)
            dolar = value
        End Set
    End Property

    Public Property euros() As Double
        Get
            Return euro
        End Get
        Set(value As Double)
            euro = value
        End Set
    End Property

    Public Property sterlins() As Double
        Get
            Return sterlin
        End Get
        Set(value As Double)
            sterlin = value
        End Set
    End Property

    Public Property liras() As Double
        Get
            Return lira
        End Get
        Set(value As Double)
            lira = value
        End Set
    End Property

End Class
