Imports System.Data.SqlClient

Public Class Form1
    Dim konut() As String = {"Daire", "Villa", "Residence", "Müstakil Ev", "Çiftlik Evi", "Köşk ve Konak", "Yalı", "Yalı Dairesi", "Yazlık", "Prefabrik Ev", "Kooperatif"}
    Dim adim As Integer = 1
    Dim connString As String = "Data Source=TRINALDI-PC;Initial Catalog=EmlakOtomasyonu;Integrated Security=True"
    Dim conn As New SqlConnection(connString)
    Private Function baglan() As DataTable
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Sehirler ORDER BY SehirAdi", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        Return dt
    End Function
    Private Function komutVer(ByVal str As String, ByVal con As SqlConnection) As DataTable
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Sehirler ORDER BY SehirAdi", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        conn.Close()
        Return dt

    End Function
    Private Sub lstBx_emlakDuzenle()
        lstBx_Satis.Items.Clear()
        lstBx_Satis.Items.Add("Satılık")
        lstBx_Satis.Items.Add("Kiralık")
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBx_Emlak.SelectedIndexChanged
        btn_ileri.Visible = False
        If lstBx_Emlak.SelectedIndex <> -1 Then
            lstBx_emlakDuzenle()
            If lstBx_Emlak.SelectedIndex = 0 Then
                lstBx_Satis.Items.Add("Günlük Kiralık")
                lstBx_Satis.Items.Add("Devren Satılık Konut")
            ElseIf lstBx_Emlak.SelectedIndex = 1 Then
                lstBx_Satis.Items.Add("Devren")
            End If
            lstBx_Satis.Visible = True
            lstBx_EmlakTip.Visible = False

            lbl_Ktgori2.Text = "Emlak > " & lstBx_Emlak.SelectedItem.ToString()
        End If
    End Sub
    Private Sub lstBx_Satis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBx_Satis.SelectedIndexChanged
        btn_ileri.Visible = False
        If lstBx_Satis.SelectedIndex <> -1 Then
            lstBx_EmlakTip.Items.Clear()

            Select Case lstBx_Emlak.SelectedIndex
                Case 0
                    If lstBx_Satis.SelectedIndex = 0 Then
                        For Each tip As String In konut
                            lstBx_EmlakTip.Items.Add(tip)
                        Next
                    ElseIf lstBx_Satis.SelectedIndex = 1 Or 2 Then
                        For i As Integer = 0 To konut.Count - 3
                            lstBx_EmlakTip.Items.Add(konut(i))
                        Next
                    Else
                        lstBx_EmlakTip.Items.Add(konut(0))
                        lstBx_EmlakTip.Items.Add(konut(1))
                    End If
                    lstBx_EmlakTip.Visible = True
                Case 1
                    If lstBx_Satis.SelectedIndex = 0 Then

                        lstBx_EmlakTip.Items.AddRange(IO.File.ReadAllLines("F:\satIY.txt"))
                    ElseIf lstBx_Satis.SelectedIndex = 1 Then
                        lstBx_EmlakTip.Items.AddRange(IO.File.ReadAllLines("F:\kirIY.txt"))
                    Else
                        lstBx_EmlakTip.Items.AddRange(IO.File.ReadAllLines("F:\devIY.txt"))
                    End If
                    lstBx_EmlakTip.Visible = True
                Case 4
                    If lstBx_Satis.SelectedIndex = 0 Or 1 Then
                        lstBx_EmlakTip.Items.AddRange(IO.File.ReadAllLines("F:\kirTT.txt"))
                        lstBx_EmlakTip.Visible = True
                    End If
                Case 2, 3
                    lstBx_EmlakTip.Visible = False
                    btn_ileri.Visible = True

            End Select
            lbl_Ktgori2.Text = "Emlak > " & lstBx_Emlak.SelectedItem.ToString() & " > " & lstBx_Satis.SelectedItem.ToString()
        End If
    End Sub
    Private Sub lstBx_EmlakTip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBx_EmlakTip.SelectedIndexChanged
        btn_ileri.Visible = True
        If lstBx_EmlakTip.SelectedIndex <> -1 Then
            btn_ileri.Visible = True
            lbl_Ktgori2.Text = "Emlak > " & lstBx_Emlak.SelectedItem.ToString() & " > " & lstBx_Satis.SelectedItem.ToString() & " > " & lstBx_EmlakTip.SelectedItem.ToString()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btn_ileri_Click(sender As Object, e As EventArgs) Handles btn_ileri.Click
        If adim < 4 Then
            adim += 1
            geriIleri(adim)
        End If
    End Sub
    Private Sub geriIleri(ByVal sayfa As Integer)
        Dim str1 As String = "SELECT * FROM Sehirler ORDER BY SehirAdi"
        Dim db1 As DataTable = komutVer(str1, conn)
        cmbBx_il.DisplayMember = "sehirAdi"
        cmbBx_il.ValueMember = "sehirId"
        Select Case sayfa
            Case 1
                grp_adim2.Visible = False
                grp_adim3.Visible = False
                grp_adim1.Location = New Point(100, 15)
                grp_adim1.Size = New Size(1060, 530)
                grp_adim1.Visible = True

            Case 2
                grp_adim1.Visible = False
                grp_adim3.Visible = False
                grp_adim2.Location = New Point(100, 15)
                grp_adim2.Size = New Size(1060, 530)
                grp_adim2.Visible = True
                cmbBx_il.DataSource = db1
            Case 3
                grp_adim1.Visible = False
                grp_adim2.Visible = False
                grp_adim3.Location = New Point(100, 15)
                grp_adim3.Size = New Size(1060, 530)
                grp_adim3.Visible = True
            Case 4
                grp_adim1.Visible = False
                grp_adim2.Visible = False
                grp_adim3.Visible = False
                btn_geri.Visible = False
                btn_ileri.Visible = False
                grpBasari.Visible = True
        End Select

    End Sub
    Private Sub btn_geri_Click(sender As Object, e As EventArgs) Handles btn_geri.Click
        If adim > 1 Then
            adim -= 1
            geriIleri(adim)
        End If
    End Sub

    Private Sub lbl_anaSayfa_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_anaSayfa.LinkClicked
        Dim anaSayfa As New frm_Giris
        anaSayfa.Show()
        Me.Close()
    End Sub
End Class


