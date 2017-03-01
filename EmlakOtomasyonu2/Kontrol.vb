Public Class Kontrol
    Public Shared Sub PanelTemizle(pnl As Panel, sozluk As Dictionary(Of ComboBox, ComboBox))
        For i As Integer = 0 To pnl.Controls.Count - 1
            If TypeOf pnl.Controls.Item(i) Is TextBox Then
                Dim txt As New TextBox
                txt = pnl.Controls.Item(i)
                If txt.Text <> "" Then txt.Text = ""
            ElseIf TypeOf pnl.Controls.Item(i) Is ComboBox Then
                Dim cbx As New ComboBox
                cbx = pnl.Controls.Item(i)
                cbx.Items.Clear()
            ElseIf TypeOf pnl.Controls.Item(i) Is RadioButton Then
                Dim rbtn As New RadioButton
                rbtn = pnl.Controls.Item(i)
                If rbtn.Checked = True Then rbtn.Checked = False
            ElseIf TypeOf pnl.Controls.Item(i) Is CheckBox Then
                Dim chkbx As New CheckBox
                chkbx = pnl.Controls.Item(i)
                If chkbx.Checked = True Then chkbx.Checked = False
            ElseIf TypeOf pnl.Controls.Item(i) Is Panel Then
                Dim pnl2 As New Panel
                pnl2 = pnl.Controls.Item(i)
                Kontrol.PanelTemizle(pnl2, sozluk)
            End If 
        Next
    End Sub
    Public Shared Function SayiKontrolu(UstSninir As Integer, obj As Object, karakter As KeyPressEventArgs) As Boolean
        Dim txt As New TextBox
        Dim mstxt As New MaskedTextBox
        If TypeOf obj Is TextBox Then
            txt = obj
            If (txt.Text.Count <= UstSninir) Then
                If (Asc(karakter.KeyChar) < 48 OrElse Asc(karakter.KeyChar) > 57) AndAlso Asc(karakter.KeyChar) <> 8 Then : Return True
                Else : Return False
                End If
            ElseIf Asc(karakter.KeyChar) = 8 Then
                Return False
            End If
        ElseIf TypeOf obj Is MaskedTextBox Then
            mstxt = obj
            If (Asc(karakter.KeyChar) < 48 OrElse Asc(karakter.KeyChar) > 57) AndAlso Asc(karakter.KeyChar) <> 8 Then : Return True
            Else : Return False
            End If
            Return True
        End If
        Return True
    End Function
    Private Shared Function GerekliAlanKontrolu(pnl As Panel) As Boolean
        For i As Integer = 0 To pnl.Controls.Count - 1
            If TypeOf pnl.Controls.Item(i) Is TextBox Then
                Dim txt As New TextBox
                txt = pnl.Controls.Item(i)
                If txt.Visible = True Then
                    If txt.Text = "" Then Return False
                End If
            ElseIf TypeOf pnl.Controls.Item(i) Is ComboBox Then
                Dim cbx As New ComboBox
                cbx = pnl.Controls.Item(i)
                If cbx.SelectedIndex = -1 Then Return False
            End If
        Next
        Return True
    End Function
    Public Shared Function GerekliAlanKontrolu(gbx As GroupBox, Optional ByVal str As String = "") As Boolean
        For i As Integer = 0 To gbx.Controls.Count - 1
            If TypeOf gbx.Controls.Item(i) Is TextBox Then
                Dim txt As New TextBox
                txt = gbx.Controls.Item(i)
                If txt.Visible = True Then
                    If txt.Text = "" Then Return False
                    If txt.Name.IndexOf("Email") <> -1 And Not EmailKontrol(txt.Text) Then Return False
                End If
            ElseIf TypeOf gbx.Controls.Item(i) Is MaskedTextBox Then
                Dim mstxt As New MaskedTextBox
                mstxt = gbx.Controls.Item(i)
                If mstxt.Visible = True Then
                    If mstxt.Text = str Then Return False
                    If mstxt.Name.IndexOf("Ev") <> -1 Then
                        If Not TelKontrol(mstxt, True) Then Return False
                    ElseIf Not TelKontrol(mstxt) Then : Return False
                    End If
                End If

            ElseIf TypeOf gbx.Controls.Item(i) Is ComboBox Then
                Dim cbx As New ComboBox
                cbx = gbx.Controls.Item(i)
                If cbx.Visible = True Then
                    If cbx.Name = "cbxMevcutKisi" Then
                        Dim rbtn As New RadioButton
                        rbtn = gbx.Controls(5)
                        If rbtn.Checked Then
                            If cbx.SelectedIndex = -1 Then Return False
                        End If
                    ElseIf cbx.SelectedIndex = -1 Then
                        Return False
                    End If
                End If
            ElseIf TypeOf gbx.Controls.Item(i) Is Panel Then
                Dim pnl As New Panel
                pnl = gbx.Controls.Item(i)
                Return GerekliAlanKontrolu(pnl)
            End If
        Next
        Return True
    End Function
    Public Shared Sub AlanTemizle(obj As Object)
        If obj.Text.IndexOf("M") <> -1 Then obj.clear
    End Sub
    Public Shared Function Sayimi(str As String) As Boolean
        Dim chr(1) As Char
        chr = str
        If Not chr = Nothing Then If Asc(chr(0)) >= 48 And Asc(chr(0)) <= 57 Then Return True
        Return False
    End Function
    Public Shared Sub bosTextboxDoldur(obj As Object)
        obj.ForeColor = Color.Gray
        If obj.Name.IndexOf("TL") <> -1 Then
            If obj.Name.IndexOf("in") <> -1 Then : obj.Text = "Min TL"
            Else : obj.Text = "Max TL"
            End If
        ElseIf obj.Name.IndexOf("Min") <> -1 Then : obj.Text = "Min"
        Else : obj.Text = "Max"
        End If
    End Sub
    Public Shared Sub txtMinMaxKontrolu(obj As Object, sozluk As Dictionary(Of TextBox, TextBox))
        Dim txt As New TextBox
        txt = sozluk(DirectCast(obj, TextBox))
        Dim maxTextboxmi As Boolean = False
        If obj.Name.IndexOf("Max") <> -1 Then maxTextboxmi = True
        If Kontrol.Sayimi(obj.Text) And Kontrol.Sayimi(txt.Text) Then
            If maxTextboxmi Then
                If CInt(obj.text) < CInt(txt.Text) Then
                    MsgBox("Üst sınır alt sınırdan küçük olamaz. Lütfen yeni değeri bu koşula uyarak giriniz", MsgBoxStyle.Exclamation, "Limit Uyuşmazlığı Hatası")
                    obj.clear
                End If
            Else
                If CInt(txt.Text) < CInt(obj.text) Then
                    MsgBox("Alt sınır üst sınırdan büyük olamaz. Lütfen yeni değeri bu koşula uyarak giriniz", MsgBoxStyle.Exclamation, "Limit Uyuşmazlığı Hatası")
                    obj.clear
                End If
            End If
        End If
    End Sub
    Public Shared Function TelKontrol(mstxt As MaskedTextBox, Optional evTelMi As Boolean = False) As Boolean
        Dim chrs(13) As Char
        chrs = mstxt.Text
        Dim sayac As Integer = 0
        If evTelMi Then
            If chrs(1) = "2" Or chrs(1) = "3" Or chrs(1) = "4" Then
                For Each number In chrs
                    If Sayimi(number) Then sayac += 1
                Next
                If sayac = 10 Then Return True
            Else : Return False
            End If
        End If

        If chrs(1) = "5" And (chrs(2) = "0" Or chrs(2) = "3" Or chrs(2) = "4" Or chrs(2) = "5") Then
            For Each number In chrs
                If Sayimi(number) Then sayac += 1
            Next
            If sayac = 10 Then Return True
        End If
        Return False

    End Function
    Public Shared Function EmailKontrol(str As String) As Boolean
        If str.IndexOf("@") > -1 And str.IndexOf(".com") AndAlso str.IndexOf(".com") - str.IndexOf("@") > 4 Then Return True
        Return False
    End Function
    Public Shared Sub LimitKontrol(txt As TextBox, VeriTipi As String)
        Dim limit As Double = 0
        Dim sayi As Double = txt.Text
        Select Case VeriTipi
            Case "integer"
                limit = Integer.MaxValue - 1
            Case "byte"
                limit = Byte.MaxValue - 1
            Case "short"
                limit = Short.MaxValue - 1
        End Select
        If sayi > limit Then
            MsgBox("Lütfen " & limit & " değerinden büyük olmayacak şekilde daha küçük değer giriniz.", MsgBoxStyle.Exclamation, "Limit Aşma Hatası")
            txt.Text = ""
        End If
    End Sub
    Public Shared Function HarfKontrolu(karakter As KeyPressEventArgs) As Boolean
        Select Case karakter.KeyChar
            Case "ç", "Ç", "ğ", "Ğ", "ı", "İ", "ö", "Ö", "ş", "Ş", "ü", "Ü", " "
                Return False
            Case Else
                If (Asc(karakter.KeyChar) = 8 OrElse (Asc(karakter.KeyChar) >= 65 AndAlso Asc(karakter.KeyChar) <= 90) OrElse (Asc(karakter.KeyChar) >= 97 AndAlso Asc(karakter.KeyChar) <= 122)) Then
                    Return False
                Else
                    Return True
                End If
        End Select
    End Function
    'Public Shared Function EmailKarakterKontrolu(karakter As KeyPressEventArgs) As Boolean
    '    Select Case Asc(karakter.KeyChar)
    '        Case 8, >= 64, <= 90, >= 97, <= 122, >= 48, <= 57, 95, 46
    '            Return False
    '        Case Else
    '            Return True
    '    End Select
    'End Function
End Class
