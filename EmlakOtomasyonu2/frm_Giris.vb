Public Class frm_Giris
    Public Shared SecilenEmlakTuru As Byte = 0
    Private Sub btn_ilanVer_Click(sender As Object, e As EventArgs) Handles btn_ilanVer.Click, btn_ilanAra.Click
        Dim frm As Form
        If sender.Name.IndexOf("A") <> -1 Then : frm = New frmIlanAra
        Else : frm = New cbxBulunduguKat
        End If
        formAc(frm)
    End Sub
    Private Sub btn_ilan_ResimDuzenle(sender As Object, e As EventArgs) Handles btn_ilanAra.MouseEnter, btn_ilanVer.MouseEnter
        If sender.Name.IndexOf("A") <> -1 Then : sender.BackgroundImage = My.Resources.ilanAra
        Else : sender.BackgroundImage = My.Resources.ilanVer
        End If
    End Sub

    Private Sub btn_ilanVer_MouseLeave(sender As Object, e As EventArgs) Handles btn_ilanVer.MouseLeave, btn_ilanAra.MouseLeave
        If sender.Name.IndexOf("A") <> -1 Then : sender.BackgroundImage = My.Resources.ilanAra_saydam
        Else : sender.BackgroundImage = My.Resources.ilanVer_saydam
        End If
    End Sub

    Private Sub formAc(frm As Form)
        Me.Hide()
        frm.ShowDialog()
        Me.Close()
    End Sub
End Class