<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGallery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGallery))
        Me.btnFormKapat = New System.Windows.Forms.Button()
        Me.videoPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lblBilgi = New System.Windows.Forms.Label()
        Me.pnlGallery = New System.Windows.Forms.Panel()
        Me.lblGallery = New System.Windows.Forms.Label()
        Me.picKucuk8 = New System.Windows.Forms.PictureBox()
        Me.picKucuk7 = New System.Windows.Forms.PictureBox()
        Me.picKucuk6 = New System.Windows.Forms.PictureBox()
        Me.picKucuk5 = New System.Windows.Forms.PictureBox()
        Me.picKucuk4 = New System.Windows.Forms.PictureBox()
        Me.picKucuk3 = New System.Windows.Forms.PictureBox()
        Me.picKucuk2 = New System.Windows.Forms.PictureBox()
        Me.picKucuk1 = New System.Windows.Forms.PictureBox()
        Me.picBuyuk = New System.Windows.Forms.PictureBox()
        Me.btnGeri = New System.Windows.Forms.Button()
        Me.btnIleri = New System.Windows.Forms.Button()
        CType(Me.videoPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGallery.SuspendLayout()
        CType(Me.picKucuk8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKucuk7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKucuk6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKucuk5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKucuk4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKucuk3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKucuk2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKucuk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBuyuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFormKapat
        '
        Me.btnFormKapat.BackColor = System.Drawing.Color.Transparent
        Me.btnFormKapat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormKapat.FlatAppearance.BorderSize = 0
        Me.btnFormKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFormKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFormKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormKapat.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormKapat.Image = Global.EmlakOtomasyonu2.My.Resources.Resources.close2
        Me.btnFormKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFormKapat.Location = New System.Drawing.Point(1211, 26)
        Me.btnFormKapat.Name = "btnFormKapat"
        Me.btnFormKapat.Size = New System.Drawing.Size(129, 56)
        Me.btnFormKapat.TabIndex = 0
        Me.btnFormKapat.Text = "Kapat"
        Me.btnFormKapat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormKapat.UseVisualStyleBackColor = False
        '
        'videoPlayer
        '
        Me.videoPlayer.Enabled = True
        Me.videoPlayer.Location = New System.Drawing.Point(275, 150)
        Me.videoPlayer.Name = "videoPlayer"
        Me.videoPlayer.OcxState = CType(resources.GetObject("videoPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.videoPlayer.Size = New System.Drawing.Size(0, 0)
        Me.videoPlayer.TabIndex = 69
        Me.videoPlayer.Visible = False
        '
        'lblBilgi
        '
        Me.lblBilgi.AutoSize = True
        Me.lblBilgi.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Italic)
        Me.lblBilgi.Location = New System.Drawing.Point(271, 116)
        Me.lblBilgi.Name = "lblBilgi"
        Me.lblBilgi.Size = New System.Drawing.Size(174, 22)
        Me.lblBilgi.TabIndex = 70
        Me.lblBilgi.Text = "Tam ekran için çift tıkla"
        Me.lblBilgi.Visible = False
        '
        'pnlGallery
        '
        Me.pnlGallery.AutoScroll = True
        Me.pnlGallery.BackColor = System.Drawing.Color.Black
        Me.pnlGallery.Controls.Add(Me.lblGallery)
        Me.pnlGallery.Controls.Add(Me.picKucuk8)
        Me.pnlGallery.Controls.Add(Me.picKucuk7)
        Me.pnlGallery.Controls.Add(Me.picKucuk6)
        Me.pnlGallery.Controls.Add(Me.picKucuk5)
        Me.pnlGallery.Controls.Add(Me.picKucuk4)
        Me.pnlGallery.Controls.Add(Me.picKucuk3)
        Me.pnlGallery.Controls.Add(Me.picKucuk2)
        Me.pnlGallery.Controls.Add(Me.picKucuk1)
        Me.pnlGallery.Location = New System.Drawing.Point(0, 580)
        Me.pnlGallery.Name = "pnlGallery"
        Me.pnlGallery.Size = New System.Drawing.Size(1366, 200)
        Me.pnlGallery.TabIndex = 71
        Me.pnlGallery.Visible = False
        '
        'lblGallery
        '
        Me.lblGallery.AutoSize = True
        Me.lblGallery.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.lblGallery.ForeColor = System.Drawing.Color.White
        Me.lblGallery.Location = New System.Drawing.Point(270, 14)
        Me.lblGallery.Name = "lblGallery"
        Me.lblGallery.Size = New System.Drawing.Size(169, 27)
        Me.lblGallery.TabIndex = 84
        Me.lblGallery.Text = "  / 8 ILAN BASLIGI"
        '
        'picKucuk8
        '
        Me.picKucuk8.BackColor = System.Drawing.Color.White
        Me.picKucuk8.BackgroundImage = CType(resources.GetObject("picKucuk8.BackgroundImage"), System.Drawing.Image)
        Me.picKucuk8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picKucuk8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picKucuk8.Image = CType(resources.GetObject("picKucuk8.Image"), System.Drawing.Image)
        Me.picKucuk8.Location = New System.Drawing.Point(1155, 58)
        Me.picKucuk8.Name = "picKucuk8"
        Me.picKucuk8.Size = New System.Drawing.Size(150, 100)
        Me.picKucuk8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKucuk8.TabIndex = 83
        Me.picKucuk8.TabStop = False
        Me.picKucuk8.Tag = "8"
        '
        'picKucuk7
        '
        Me.picKucuk7.BackColor = System.Drawing.Color.White
        Me.picKucuk7.BackgroundImage = CType(resources.GetObject("picKucuk7.BackgroundImage"), System.Drawing.Image)
        Me.picKucuk7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picKucuk7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picKucuk7.Image = CType(resources.GetObject("picKucuk7.Image"), System.Drawing.Image)
        Me.picKucuk7.Location = New System.Drawing.Point(999, 58)
        Me.picKucuk7.Name = "picKucuk7"
        Me.picKucuk7.Size = New System.Drawing.Size(150, 100)
        Me.picKucuk7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKucuk7.TabIndex = 82
        Me.picKucuk7.TabStop = False
        Me.picKucuk7.Tag = "7"
        '
        'picKucuk6
        '
        Me.picKucuk6.BackColor = System.Drawing.Color.White
        Me.picKucuk6.BackgroundImage = CType(resources.GetObject("picKucuk6.BackgroundImage"), System.Drawing.Image)
        Me.picKucuk6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picKucuk6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picKucuk6.Image = CType(resources.GetObject("picKucuk6.Image"), System.Drawing.Image)
        Me.picKucuk6.Location = New System.Drawing.Point(843, 58)
        Me.picKucuk6.Name = "picKucuk6"
        Me.picKucuk6.Size = New System.Drawing.Size(150, 100)
        Me.picKucuk6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKucuk6.TabIndex = 81
        Me.picKucuk6.TabStop = False
        Me.picKucuk6.Tag = "6"
        '
        'picKucuk5
        '
        Me.picKucuk5.BackColor = System.Drawing.Color.White
        Me.picKucuk5.BackgroundImage = CType(resources.GetObject("picKucuk5.BackgroundImage"), System.Drawing.Image)
        Me.picKucuk5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picKucuk5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picKucuk5.Image = CType(resources.GetObject("picKucuk5.Image"), System.Drawing.Image)
        Me.picKucuk5.Location = New System.Drawing.Point(687, 58)
        Me.picKucuk5.Name = "picKucuk5"
        Me.picKucuk5.Size = New System.Drawing.Size(150, 100)
        Me.picKucuk5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKucuk5.TabIndex = 80
        Me.picKucuk5.TabStop = False
        Me.picKucuk5.Tag = "5"
        '
        'picKucuk4
        '
        Me.picKucuk4.BackColor = System.Drawing.Color.White
        Me.picKucuk4.BackgroundImage = CType(resources.GetObject("picKucuk4.BackgroundImage"), System.Drawing.Image)
        Me.picKucuk4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picKucuk4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picKucuk4.Image = CType(resources.GetObject("picKucuk4.Image"), System.Drawing.Image)
        Me.picKucuk4.Location = New System.Drawing.Point(531, 58)
        Me.picKucuk4.Name = "picKucuk4"
        Me.picKucuk4.Size = New System.Drawing.Size(150, 100)
        Me.picKucuk4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKucuk4.TabIndex = 79
        Me.picKucuk4.TabStop = False
        Me.picKucuk4.Tag = "4"
        '
        'picKucuk3
        '
        Me.picKucuk3.BackColor = System.Drawing.Color.White
        Me.picKucuk3.BackgroundImage = CType(resources.GetObject("picKucuk3.BackgroundImage"), System.Drawing.Image)
        Me.picKucuk3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picKucuk3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picKucuk3.Image = CType(resources.GetObject("picKucuk3.Image"), System.Drawing.Image)
        Me.picKucuk3.Location = New System.Drawing.Point(375, 58)
        Me.picKucuk3.Name = "picKucuk3"
        Me.picKucuk3.Size = New System.Drawing.Size(150, 100)
        Me.picKucuk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKucuk3.TabIndex = 78
        Me.picKucuk3.TabStop = False
        Me.picKucuk3.Tag = "3"
        '
        'picKucuk2
        '
        Me.picKucuk2.BackColor = System.Drawing.Color.White
        Me.picKucuk2.BackgroundImage = CType(resources.GetObject("picKucuk2.BackgroundImage"), System.Drawing.Image)
        Me.picKucuk2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picKucuk2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picKucuk2.Image = CType(resources.GetObject("picKucuk2.Image"), System.Drawing.Image)
        Me.picKucuk2.Location = New System.Drawing.Point(219, 58)
        Me.picKucuk2.Name = "picKucuk2"
        Me.picKucuk2.Size = New System.Drawing.Size(150, 100)
        Me.picKucuk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKucuk2.TabIndex = 77
        Me.picKucuk2.TabStop = False
        Me.picKucuk2.Tag = "2"
        '
        'picKucuk1
        '
        Me.picKucuk1.BackColor = System.Drawing.Color.White
        Me.picKucuk1.BackgroundImage = CType(resources.GetObject("picKucuk1.BackgroundImage"), System.Drawing.Image)
        Me.picKucuk1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picKucuk1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picKucuk1.Location = New System.Drawing.Point(63, 58)
        Me.picKucuk1.Name = "picKucuk1"
        Me.picKucuk1.Size = New System.Drawing.Size(150, 100)
        Me.picKucuk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKucuk1.TabIndex = 76
        Me.picKucuk1.TabStop = False
        Me.picKucuk1.Tag = "1"
        '
        'picBuyuk
        '
        Me.picBuyuk.BackColor = System.Drawing.Color.White
        Me.picBuyuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBuyuk.Location = New System.Drawing.Point(275, 88)
        Me.picBuyuk.Name = "picBuyuk"
        Me.picBuyuk.Size = New System.Drawing.Size(800, 450)
        Me.picBuyuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBuyuk.TabIndex = 72
        Me.picBuyuk.TabStop = False
        Me.picBuyuk.Visible = False
        '
        'btnGeri
        '
        Me.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGeri.FlatAppearance.BorderSize = 0
        Me.btnGeri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeri.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.btnGeri.ForeColor = System.Drawing.Color.White
        Me.btnGeri.Image = Global.EmlakOtomasyonu2.My.Resources.Resources.previmg
        Me.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGeri.Location = New System.Drawing.Point(12, 244)
        Me.btnGeri.Name = "btnGeri"
        Me.btnGeri.Size = New System.Drawing.Size(110, 136)
        Me.btnGeri.TabIndex = 74
        Me.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeri.UseVisualStyleBackColor = True
        Me.btnGeri.Visible = False
        '
        'btnIleri
        '
        Me.btnIleri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIleri.FlatAppearance.BorderSize = 0
        Me.btnIleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnIleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnIleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIleri.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.btnIleri.ForeColor = System.Drawing.Color.White
        Me.btnIleri.Image = Global.EmlakOtomasyonu2.My.Resources.Resources.nextimg
        Me.btnIleri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIleri.Location = New System.Drawing.Point(1244, 244)
        Me.btnIleri.Name = "btnIleri"
        Me.btnIleri.Size = New System.Drawing.Size(110, 136)
        Me.btnIleri.TabIndex = 75
        Me.btnIleri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIleri.UseVisualStyleBackColor = True
        Me.btnIleri.Visible = False
        '
        'frmGallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1366, 780)
        Me.Controls.Add(Me.pnlGallery)
        Me.Controls.Add(Me.btnIleri)
        Me.Controls.Add(Me.btnGeri)
        Me.Controls.Add(Me.lblBilgi)
        Me.Controls.Add(Me.btnFormKapat)
        Me.Controls.Add(Me.videoPlayer)
        Me.Controls.Add(Me.picBuyuk)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGallery"
        Me.Opacity = 0.8R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emlak Otomasyonu"
        Me.TransparencyKey = System.Drawing.Color.SteelBlue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.videoPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGallery.ResumeLayout(False)
        Me.pnlGallery.PerformLayout()
        CType(Me.picKucuk8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKucuk7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKucuk6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKucuk5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKucuk4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKucuk3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKucuk2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKucuk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBuyuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFormKapat As Button
    Friend WithEvents videoPlayer As AxWindowsMediaPlayer
    Friend WithEvents lblBilgi As Label
    Friend WithEvents pnlGallery As Panel
    Friend WithEvents picBuyuk As PictureBox
    Friend WithEvents btnGeri As Button
    Friend WithEvents btnIleri As Button
    Friend WithEvents picKucuk8 As PictureBox
    Friend WithEvents picKucuk7 As PictureBox
    Friend WithEvents picKucuk6 As PictureBox
    Friend WithEvents picKucuk5 As PictureBox
    Friend WithEvents picKucuk4 As PictureBox
    Friend WithEvents picKucuk3 As PictureBox
    Friend WithEvents picKucuk2 As PictureBox
    Friend WithEvents picKucuk1 As PictureBox
    Friend WithEvents lblGallery As Label
End Class
