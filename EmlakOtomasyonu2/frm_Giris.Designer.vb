<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Giris
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Giris))
        Me.btn_ilanAra = New System.Windows.Forms.Button()
        Me.btn_ilanVer = New System.Windows.Forms.Button()
        Me.lbl_ilanGiris = New System.Windows.Forms.Label()
        Me.lblHosGeldin = New System.Windows.Forms.Label()
        Me.lbl_ilanAra = New System.Windows.Forms.Label()
        Me.lbl_ilanVer = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picBorderUp = New System.Windows.Forms.PictureBox()
        Me.picBorderDown = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBorderUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBorderDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ilanAra
        '
        Me.btn_ilanAra.BackColor = System.Drawing.Color.Transparent
        Me.btn_ilanAra.BackgroundImage = Global.EmlakOtomasyonu2.My.Resources.Resources.ilanAra_saydam1
        Me.btn_ilanAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ilanAra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ilanAra.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_ilanAra.FlatAppearance.BorderSize = 10
        Me.btn_ilanAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ilanAra.Location = New System.Drawing.Point(496, 131)
        Me.btn_ilanAra.Name = "btn_ilanAra"
        Me.btn_ilanAra.Size = New System.Drawing.Size(360, 360)
        Me.btn_ilanAra.TabIndex = 3
        Me.btn_ilanAra.UseVisualStyleBackColor = False
        '
        'btn_ilanVer
        '
        Me.btn_ilanVer.BackColor = System.Drawing.Color.Transparent
        Me.btn_ilanVer.BackgroundImage = Global.EmlakOtomasyonu2.My.Resources.Resources.ilanVer_saydam1
        Me.btn_ilanVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ilanVer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ilanVer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_ilanVer.FlatAppearance.BorderSize = 10
        Me.btn_ilanVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ilanVer.Location = New System.Drawing.Point(936, 131)
        Me.btn_ilanVer.Name = "btn_ilanVer"
        Me.btn_ilanVer.Size = New System.Drawing.Size(360, 360)
        Me.btn_ilanVer.TabIndex = 2
        Me.btn_ilanVer.UseVisualStyleBackColor = False
        '
        'lbl_ilanGiris
        '
        Me.lbl_ilanGiris.AutoSize = True
        Me.lbl_ilanGiris.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ilanGiris.ForeColor = System.Drawing.Color.White
        Me.lbl_ilanGiris.Location = New System.Drawing.Point(957, 51)
        Me.lbl_ilanGiris.Name = "lbl_ilanGiris"
        Me.lbl_ilanGiris.Size = New System.Drawing.Size(0, 73)
        Me.lbl_ilanGiris.TabIndex = 4
        '
        'lblHosGeldin
        '
        Me.lblHosGeldin.AutoSize = True
        Me.lblHosGeldin.BackColor = System.Drawing.Color.Transparent
        Me.lblHosGeldin.Font = New System.Drawing.Font("Cambria", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHosGeldin.ForeColor = System.Drawing.Color.PowderBlue
        Me.lblHosGeldin.Location = New System.Drawing.Point(82, 427)
        Me.lblHosGeldin.Name = "lblHosGeldin"
        Me.lblHosGeldin.Size = New System.Drawing.Size(340, 75)
        Me.lblHosGeldin.TabIndex = 8
        Me.lblHosGeldin.Text = "Hoş geldin!"
        '
        'lbl_ilanAra
        '
        Me.lbl_ilanAra.AutoSize = True
        Me.lbl_ilanAra.Font = New System.Drawing.Font("Cambria", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ilanAra.ForeColor = System.Drawing.Color.White
        Me.lbl_ilanAra.Location = New System.Drawing.Point(557, 504)
        Me.lbl_ilanAra.Name = "lbl_ilanAra"
        Me.lbl_ilanAra.Size = New System.Drawing.Size(247, 75)
        Me.lbl_ilanAra.TabIndex = 9
        Me.lbl_ilanAra.Text = "İlan Ara"
        '
        'lbl_ilanVer
        '
        Me.lbl_ilanVer.AutoSize = True
        Me.lbl_ilanVer.Font = New System.Drawing.Font("Cambria", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ilanVer.ForeColor = System.Drawing.Color.White
        Me.lbl_ilanVer.Location = New System.Drawing.Point(999, 504)
        Me.lbl_ilanVer.Name = "lbl_ilanVer"
        Me.lbl_ilanVer.Size = New System.Drawing.Size(243, 75)
        Me.lbl_ilanVer.TabIndex = 10
        Me.lbl_ilanVer.Text = "İlan Ver"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = Global.EmlakOtomasyonu2.My.Resources.Resources.Capture
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogo.Location = New System.Drawing.Point(114, 223)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(270, 180)
        Me.picLogo.TabIndex = 11
        Me.picLogo.TabStop = False
        '
        'picBorderUp
        '
        Me.picBorderUp.BackgroundImage = CType(resources.GetObject("picBorderUp.BackgroundImage"), System.Drawing.Image)
        Me.picBorderUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBorderUp.Location = New System.Drawing.Point(0, 3)
        Me.picBorderUp.Name = "picBorderUp"
        Me.picBorderUp.Size = New System.Drawing.Size(1366, 334)
        Me.picBorderUp.TabIndex = 12
        Me.picBorderUp.TabStop = False
        '
        'picBorderDown
        '
        Me.picBorderDown.BackgroundImage = Global.EmlakOtomasyonu2.My.Resources.Resources.background1
        Me.picBorderDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBorderDown.Location = New System.Drawing.Point(0, 640)
        Me.picBorderDown.Name = "picBorderDown"
        Me.picBorderDown.Size = New System.Drawing.Size(1366, 100)
        Me.picBorderDown.TabIndex = 13
        Me.picBorderDown.TabStop = False
        '
        'frm_Giris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1350, 741)
        Me.Controls.Add(Me.picBorderDown)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lbl_ilanVer)
        Me.Controls.Add(Me.lbl_ilanAra)
        Me.Controls.Add(Me.lblHosGeldin)
        Me.Controls.Add(Me.lbl_ilanGiris)
        Me.Controls.Add(Me.btn_ilanAra)
        Me.Controls.Add(Me.btn_ilanVer)
        Me.Controls.Add(Me.picBorderUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Giris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emlak Otomasyonu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBorderUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBorderDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ilanVer As Button
    Friend WithEvents btn_ilanAra As Button
    Friend WithEvents lbl_ilanGiris As Label
    Friend WithEvents lblHosGeldin As Label
    Friend WithEvents lbl_ilanAra As Label
    Friend WithEvents lbl_ilanVer As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents picBorderUp As PictureBox
    Friend WithEvents picBorderDown As PictureBox
End Class
