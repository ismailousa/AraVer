Imports System.Drawing.Imaging

Public Class frmGallery
    Dim sayi As Integer = 1
    Dim fotoSayisi As Integer
    Dim imgOriginal(8) As Image
    Dim imgThumbnail(8) As Image
    Dim baslik As String

    Sub New(ByVal str As String, ByVal bas As String)
        InitializeComponent()
        videoPlayer.Size = New Size(800, 500)
        videoPlayer.URL = str
        videoPlayer.Ctlcontrols.stop()
        videoPlayer.Visible = True
        lblBilgi.Visible = True
        videoPlayer.currentPlaylist.name = bas
    End Sub
    Sub New(ByVal imgArray() As Image, ByVal bas As String)
        InitializeComponent()
        For i = 1 To 8
            If Not imgArray(i) Is Nothing Then fotoSayisi += 1
        Next
        picKucuk1.BackgroundImage = imgArray(1)
        picKucuk2.BackgroundImage = imgArray(2)
        picKucuk3.BackgroundImage = imgArray(3)
        picKucuk4.BackgroundImage = imgArray(4)
        picKucuk5.BackgroundImage = imgArray(5)
        picKucuk6.BackgroundImage = imgArray(6)
        picKucuk7.BackgroundImage = imgArray(7)
        picKucuk8.BackgroundImage = imgArray(8)
        picBuyuk.Visible = True
        pnlGallery.Visible = True
        btnIleri.Visible = True
        btnGeri.Visible = True
        baslik = bas
    End Sub
    Private Sub btnFormKapat_Click(sender As Object, e As EventArgs) Handles btnFormKapat.Click
        videoPlayer.Ctlcontrols.stop()
        Me.Close()
    End Sub
    Private Sub frmGallery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        saveImage()
        picBuyuk.Image = picKucuk1.BackgroundImage
        galleryControl()
    End Sub
    Private Sub saveImage()
        For Each ctrl As Control In pnlGallery.Controls
            If TypeOf ctrl Is PictureBox Then
                If ctrl.Tag > fotoSayisi Then
                    CType(ctrl, PictureBox).Visible = False
                End If
            End If
        Next
        imgOriginal(1) = picKucuk1.BackgroundImage
        imgOriginal(2) = picKucuk2.BackgroundImage
        imgOriginal(3) = picKucuk3.BackgroundImage
        imgOriginal(4) = picKucuk4.BackgroundImage
        imgOriginal(5) = picKucuk5.BackgroundImage
        imgOriginal(6) = picKucuk6.BackgroundImage
        imgOriginal(7) = picKucuk7.BackgroundImage
        imgOriginal(8) = picKucuk8.BackgroundImage
    End Sub
    Private Sub btnGeri_Click(sender As Object, e As EventArgs) Handles btnGeri.Click
        If sayi > 1 Then sayi -= 1
        galleryControl()
    End Sub

    Private Sub btnIleri_Click(sender As Object, e As EventArgs) Handles btnIleri.Click
        If sayi < fotoSayisi Then sayi += 1
        galleryControl()
    End Sub
    Private Sub galleryControl()
        For Each ctrl As Control In pnlGallery.Controls
            If TypeOf ctrl Is PictureBox Then
                If ctrl.Tag = sayi Then
                    CType(ctrl, PictureBox).Image = Nothing
                    picBuyuk.Image = CType(ctrl, PictureBox).BackgroundImage
                Else
                    CType(ctrl, PictureBox).Image = My.Resources.transblack
                End If
            End If
        Next
        lblGallery.Text = ""
        lblGallery.Text = "(" & sayi & " / 8) " & baslik
        Me.Refresh()
    End Sub

    Private Sub picKucuk_Click(sender As Object, e As EventArgs) Handles picKucuk1.Click, picKucuk2.Click, picKucuk3.Click, picKucuk4.Click, picKucuk5.Click, picKucuk6.Click, picKucuk7.Click, picKucuk8.Click
        sayi = sender.tag
        galleryControl()
    End Sub
End Class