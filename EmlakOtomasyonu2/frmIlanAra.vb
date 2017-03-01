Imports System.IO

Public Class frmIlanAra
    Dim SQL As New SqlEmlak
    Dim ilce(1000, 1) As String
    Dim secilenEmlak As New Button
    Dim txtikili As New Dictionary(Of TextBox, TextBox)
    Dim dt As New DataTable
    Dim ms As System.IO.MemoryStream
    Sub New()
        InitializeComponent()
        dt = SQL.EmlakTablosu()
        If dt.Rows.Count > 0 Then
            Dim array() As Byte
            For i As Byte = 0 To dt.Rows.Count - 1
                If dt.Rows(i)(7) IsNot DBNull.Value Then
                    array = dt.Rows(i)(7)
                    ms = New IO.MemoryStream(array)
                    Select Case i
                        Case 0
                            btnEmlak1.BackgroundImage = msToImage(ms)
                            btnEmlak1.Text = dt.Rows(i)(20)
                        Case 1
                            btnEmlak2.BackgroundImage = msToImage(ms)
                            btnEmlak2.Text = dt.Rows(i)(20)
                        Case 2
                            btnEmlak3.BackgroundImage = msToImage(ms)
                            btnEmlak3.Text = dt.Rows(i)(20)
                        Case 3
                            btnEmlak4.BackgroundImage = msToImage(ms)
                            btnEmlak4.Text = dt.Rows(i)(20)
                        Case 4
                            btnEmlak5.BackgroundImage = msToImage(ms)
                            btnEmlak5.Text = dt.Rows(i)(20)
                        Case 5
                            btnEmlak6.BackgroundImage = msToImage(ms)
                            btnEmlak6.Text = dt.Rows(i)(20)
                        Case 6
                            btnEmlak7.BackgroundImage = msToImage(ms)
                            btnEmlak7.Text = dt.Rows(i)(20)
                        Case 7
                            btnEmlak8.BackgroundImage = msToImage(ms)
                            btnEmlak8.Text = dt.Rows(i)(20)
                        Case 8
                            btnEmlak9.BackgroundImage = msToImage(ms)
                            btnEmlak9.Text = dt.Rows(i)(20)
                        Case 9
                            btnEmlak10.BackgroundImage = msToImage(ms)
                            btnEmlak10.Text = dt.Rows(i)(20)
                        Case 10
                            btnEmlak11.BackgroundImage = msToImage(ms)
                            btnEmlak11.Text = dt.Rows(i)(20)
                        Case 11
                            btnEmlak12.BackgroundImage = msToImage(ms)
                            btnEmlak12.Text = dt.Rows(i)(20)
                        Case 12
                            btnEmlak13.BackgroundImage = msToImage(ms)
                            btnEmlak13.Text = dt.Rows(i)(20)
                        Case 13
                            btnEmlak14.BackgroundImage = msToImage(ms)
                            btnEmlak14.Text = dt.Rows(i)(20)
                        Case Else : Exit For
                    End Select
                End If
            Next
        End If
        secilenEmlak = btnKonut
        frm_Giris.SecilenEmlakTuru = 0
        txtikili.Add(txtMaxTL, txtMinTL)
        txtikili.Add(txtMinTL, txtMaxTL)
        SQL.Tablo_Veri_Doldur("Konut_Tip", cbxEmlakTipininTuru)
        SQL.Tablo_Veri_Doldur("Oda_Sayisi", cbxSecenek)
        Dim iller(82) As String
        SQL.Tablo_Veri_Doldur("Sehirler", iller)
        For index As Integer = 81 To 0 Step -1
            cbxIl.Items.Add(iller(index))
        Next
        pnlKonut.BackColor = Color.FromArgb(79, 148, 205)
        btnKonut.BackColor = Color.Teal
        btnIsyeri.BackColor = Color.FromArgb(79, 148, 205)
        btnArsa.BackColor = Color.FromArgb(79, 148, 205)
        btnTuristik.BackColor = Color.FromArgb(79, 148, 205)
        btnBina.BackColor = Color.FromArgb(79, 148, 205)
    End Sub
    Private Sub btnKonut_Click(sender As Object, e As EventArgs) Handles btnKonut.Click, btnIsyeri.Click, btnArsa.Click, btnBina.Click, btnTuristik.Click
        frm_Giris.SecilenEmlakTuru = sender.TabIndex - 5
        secilenEmlak = sender
        aramaKontrol(sender)
    End Sub
    Private Sub cbxTemizle()
        cbxIl.Items.Clear()
        cbxIlce.Items.Clear()
        cbxMahalle.Items.Clear()
        cbxSecenek.Items.Clear()
        cbxEmlakTipininTuru.Items.Clear()
    End Sub
    Private Sub aramaKontrol(secilenBtn As Button)
        cbxEmlakTipininTuru.Visible = False
        cbxTemizle()

        Dim iller(82) As String
        SQL.Tablo_Veri_Doldur("Sehirler", iller)
        For index As Integer = 81 To 0 Step -1
            cbxIl.Items.Add(iller(index))
        Next
        lblEkOzellik.Text = "Kat Sayısı"
        cbxIl.SelectedIndex = -1

        lblEkOzellik.Visible = False
        lblEmlakTip.Visible = True
        lblilce.Visible = True
        lblSehir.Visible = True
        lblMahalle.Visible = True
        lblSatisTur.Visible = True
        lblEmlakTip.Text = secilenBtn.Text & " Tipi"

        btnKonut.Location = New Point(430, 40)
        btnKonut.Size = New Size(145, 30)
        btnKonut.BackColor = Color.FromArgb(79, 148, 205)
        btnIsyeri.Location = New Point(590, 40)
        btnIsyeri.Size = New Size(130, 30)
        btnIsyeri.BackColor = Color.FromArgb(79, 148, 205)
        btnArsa.Location = New Point(734, 40)
        btnArsa.Size = New Size(130, 30)
        btnArsa.BackColor = Color.FromArgb(79, 148, 205)
        btnBina.Location = New Point(880, 40)
        btnBina.Size = New Size(130, 30)
        btnBina.BackColor = Color.FromArgb(79, 148, 205)
        btnTuristik.Location = New Point(1025, 40)
        btnTuristik.Size = New Size(160, 30)
        btnTuristik.BackColor = Color.FromArgb(79, 148, 205)
        cbxSatisTuru.Location = New Point(20, 40)
        lblSatisTur.Location = New Point(25, 45)
        cbxEmlakTipininTuru.Visible = True
        secilenBtn.Height += 10
        secilenBtn.Location = New Point(secilenBtn.Location.X, secilenBtn.Location.Y - 10)
        secilenBtn.BackColor = Color.Teal
        Select Case secilenBtn.Name
            Case btnKonut.Name
                cbxSecenek.Items.Clear()
                cbxSecenek.Visible = True
                lblEkOzellik.Text = "Oda Sayısı"
                lblEkOzellik.Visible = True
                SQL.Tablo_Veri_Doldur("Konut_Tip", cbxEmlakTipininTuru)
                SQL.Tablo_Veri_Doldur("Oda_Sayisi", cbxSecenek)
            Case btnIsyeri.Name
                cbxSecenek.Visible = False
                SQL.Tablo_Veri_Doldur("Isyeri_Tipi", cbxEmlakTipininTuru)
            Case btnArsa.Name
                lblEmlakTip.Visible = False
                lblSatisTur.Location = New Point(105, 45)
                cbxSatisTuru.Location = New Point(100, 40)
                cbxEmlakTipininTuru.Visible = False
                cbxSecenek.Visible = False
            Case btnBina.Name
                cbxSecenek.Items.Clear()
                lblEmlakTip.Visible = False
                lblSatisTur.Location = New Point(105, 45)
                cbxSatisTuru.Location = New Point(100, 40)
                lblEkOzellik.Visible = False
                cbxEmlakTipininTuru.Visible = False
                cbxSecenek.Visible = False
            Case btnTuristik.Name
                cbxSecenek.Visible = False
                SQL.Tablo_Veri_Doldur("TT_Tip", cbxEmlakTipininTuru)
        End Select
    End Sub
    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        If frm_Giris.SecilenEmlakTuru = 1 Then
            If cbxEmlakTipininTuru.SelectedIndex = -1 Then
                MsgBox("İşyeri araması için bir işyeri çeşidi seçmelisiniz.", MsgBoxStyle.Exclamation, "Uyarı")
            Else
                Dim arama As New frmArama(secilenEmlak.Text, sec(cbxSatisTuru),
                                      IIf(cbxEmlakTipininTuru.SelectedItem Is Nothing, "Belirlenmemiş", cbxEmlakTipininTuru.SelectedItem),
                                      IIf(cbxIl.SelectedItem Is Nothing, "Belirlenmemiş", cbxIl.SelectedItem), sec(cbxIlce),
                                      IIf(txtMinTL.Text = "Min TL", "...", txtMinTL.Text),
                                      IIf(txtMaxTL.Text = "Max TL", "...", txtMaxTL.Text), sec(cbxSecenek), cbxEmlakTipininTuru.SelectedIndex)
                Me.Hide()
                arama.ShowDialog()
                Me.Close()
            End If
        Else
            Dim arama As New frmArama(secilenEmlak.Text, sec(cbxSatisTuru),
                                     IIf(cbxEmlakTipininTuru.SelectedItem Is Nothing, "Belirlenmemiş", cbxEmlakTipininTuru.SelectedItem),
                                     IIf(cbxIl.SelectedItem Is Nothing, "Belirlenmemiş", cbxIl.SelectedItem), sec(cbxIlce),
                                     IIf(txtMinTL.Text = "Min TL", "...", txtMinTL.Text),
                                     IIf(txtMaxTL.Text = "Max TL", "...", txtMaxTL.Text), sec(cbxSecenek), cbxEmlakTipininTuru.SelectedIndex)
            Me.Hide()
            arama.ShowDialog()
            Me.Close()
        End If
    End Sub
    Private Function sec(secilen As ComboBox) As String
        Dim Item As String = ""
        If secilen.SelectedItem IsNot Nothing Then
            Item = secilen.SelectedItem
        End If
        Return Item
    End Function
    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim giris As New frm_Giris
        Me.Hide()
        giris.ShowDialog()
        Me.Close()
    End Sub
    Private Sub txtMinTL_Leave(sender As Object, e As EventArgs) Handles txtMinTL.Leave, txtMaxTL.Leave
        If Not sender.Text = "" Then Kontrol.LimitKontrol(DirectCast(sender, TextBox), "integer")
        If Not sender.Text = "" Then Kontrol.txtMinMaxKontrolu(sender, txtikili)
    End Sub
    Private Sub txtMinTL_Leave2(sender As Object, e As EventArgs) Handles txtMinTL.MouseLeave, txtMinTL.Leave, txtMaxTL.MouseLeave, txtMaxTL.Leave
        If sender.text = "" And Not DirectCast(sender, TextBox).Focused Then Kontrol.bosTextboxDoldur(sender)
    End Sub
    Private Sub txtMinTL_Enter(sender As Object, e As EventArgs) Handles txtMinTL.MouseEnter, txtMaxTL.MouseEnter, txtMinTL.Enter, txtMaxTL.Enter
        Kontrol.AlanTemizle(sender)
        sender.ForeColor = Color.Black
    End Sub
    Private Sub txtMinTL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinTL.KeyPress, txtMaxTL.KeyPress
        e.Handled = Kontrol.SayiKontrolu(9, sender, e)
    End Sub
    Private Sub profilAc(name As String)
        If dt.Rows.Count > 0 Then
            Dim indis As Byte = 0
            For i As SByte = 14 To 0 Step -1
                If name.IndexOf(i.ToString) <> -1 Then
                    indis = i - 1
                    Exit For
                End If
            Next
            '     Try
            Dim profil As New frmProfil(dt.Rows(indis), True)
                Me.Hide()
                profil.ShowDialog()
            '   Catch ex As Exception
            '   MessageBox.Show("Lutfen varolan bir emlak seciniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '   End Try
        End If

    End Sub
    Private Sub btnEmlak1_Click(sender As Object, e As EventArgs) Handles btnEmlak1.Click, btnEmlak10.Click, btnEmlak11.Click, btnEmlak12.Click, btnEmlak13.Click, btnEmlak14.Click, btnEmlak2.Click, btnEmlak3.Click, btnEmlak4.Click, btnEmlak5.Click, btnEmlak6.Click, btnEmlak7.Click, btnEmlak8.Click, btnEmlak9.Click
        profilAc(sender.Name)
    End Sub
    Public Function msToImage(ms As System.IO.MemoryStream) As Image
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function
    Private Sub frmIlanAra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sub New'a tasinmistir
    End Sub
    Private Sub btnAra_MouseEnter(sender As Object, e As EventArgs) Handles btnAra.MouseEnter
        btnAra.ForeColor = Color.FromArgb(79, 148, 205)
    End Sub
    Private Sub btnAra_MouseLeave(sender As Object, e As EventArgs) Handles btnAra.MouseLeave
        btnAra.ForeColor = Color.White
    End Sub
    Private Sub cbxIl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIl.SelectedIndexChanged
        cbxIlce.Items.Clear()
        SQL.ilce_Doldur(ilce, 82 - cbxIl.SelectedIndex)
        For i As Integer = 0 To ilce.Length
            If ilce(i, 1) = Nothing Then Exit For
            cbxIlce.Items.Add(ilce(i, 1))
        Next
    End Sub
    Private Sub cbxIlce_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIlce.SelectedIndexChanged
        cbxMahalle.Items.Clear()
        SQL.semtMah_Doldur(cbxMahalle, ilce(cbxIlce.SelectedIndex, 0))
        For i As Integer = 0 To ilce.Length
            If ilce(i, 1) = Nothing Then Exit For
            If ilce(i, 1) = cbxIlce.SelectedItem.ToString() Then SQL.semtMah_Doldur(cbxMahalle, ilce(i, 0))
        Next
    End Sub
    Private Sub lbl_MouseEnter(sender As Object, e As EventArgs) Handles cbxSatisTuru.MouseEnter, cbxEmlakTipininTuru.MouseEnter, cbxSecenek.MouseEnter, cbxIl.MouseEnter, cbxIlce.MouseEnter, cbxMahalle.MouseEnter
        Select Case sender.name
            Case cbxSatisTuru.Name
                lblSatisTur.Visible = False
            Case cbxEmlakTipininTuru.Name
                lblEmlakTip.Visible = False
            Case cbxSecenek.Name
                lblEkOzellik.Visible = False
            Case cbxIl.Name
                lblSehir.Visible = False
            Case cbxIlce.Name
                lblilce.Visible = False
            Case cbxMahalle.Name
                lblMahalle.Visible = False
        End Select
    End Sub
    Private Sub cbx_MouseLeave(sender As Object, e As EventArgs) Handles cbxSatisTuru.MouseLeave, cbxEmlakTipininTuru.MouseLeave, cbxSecenek.MouseLeave, cbxIl.MouseLeave, cbxIlce.MouseLeave, cbxMahalle.MouseLeave
        Select Case sender.name
            Case cbxSatisTuru.Name
                If sender.SelectedIndex = -1 Then lblSatisTur.Visible = True
            Case cbxEmlakTipininTuru.Name
                If sender.SelectedIndex = -1 Then lblEmlakTip.Visible = True
            Case cbxSecenek.Name
                If sender.SelectedIndex = -1 Then lblEkOzellik.Visible = True
            Case cbxIl.Name
                If sender.SelectedIndex = -1 Then lblSehir.Visible = True
            Case cbxIlce.Name
                If sender.SelectedIndex = -1 Then lblilce.Visible = True
            Case cbxMahalle.Name
                If sender.SelectedIndex = -1 Then lblMahalle.Visible = True
        End Select
        lblSatisTur.Focus()
    End Sub
End Class
