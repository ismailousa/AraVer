Public Class frmArama
    Dim filtreAcik As Boolean = False
    Dim secilenPanel As Panel
    Dim txtboxikililer As New Dictionary(Of TextBox, TextBox)
    Dim SQL As New SqlEmlak
    Dim ilce(1000, 1) As String
    Dim sehir_ilceVeilce_mah As New Dictionary(Of ComboBox, ComboBox)
    Dim ControlItem_vs_ColoumnName As New Dictionary(Of String, String)
    Dim dt As New DataTable
    Dim dv As New DataView
    Dim secilenEmlak As String = ""
    Dim filterString As String = ""
    Dim secilenIl As String = ""
    Dim minFiyat = "", maxFiyat As String = ""
    Dim isyeriTipi As Integer = 0
    Sub New(ByVal emlakTip As String, ByVal satisTur As String, ByVal emlakTipTur As String, ByVal il As String, ByVal ilce As String, ByVal minTL As String, ByVal maxTL As String, ByVal ekBilgi As String, ByVal isyTip As Integer)
        InitializeComponent()
        secilenEmlak = emlakTip
        btnSatisTuru.Text = satisTur & " " & emlakTip
        btnEmlakTipi.Text = emlakTipTur
        btnAdres.Text = IIf(ilce = "", " ", ilce & ", ") & il
        btnFiyat.Text = minTL & " - " & maxTL & " TL"
        btnEkBilgi.Text = ekBilgi
        filterString = "ilan_Tur_ID = '" & frm_Giris.SecilenEmlakTuru & "'"
        If satisTur <> "" Then filterString += " and Satis_Turu = '" & satisTur & "'"
        Select Case frm_Giris.SecilenEmlakTuru
            Case 0 ' Konut
                If emlakTipTur <> "Belirlenmemiş" Then filterString += " and Konut_Tip = '" & emlakTipTur & "'"
            Case 1 ' İşyeri
                filterString += " and   Isyeri_Tipi = '" & emlakTipTur & "'"
                isyeriTipi = isyTip
            Case 4 ' Turistik Tesis
                If emlakTipTur <> "Belirlenmemiş" Then filterString += " and TT_Tip = '" & emlakTipTur & "'"
        End Select
        If il <> "Belirlenmemiş" Then filterString += " and SehirAdi = '" & il & "'"
        If ilce <> "" Then filterString += " and ilceAdi = '" & ilce & "'"
        If minTL <> "..." Then filterString += " and Fiyat >= " & minTL
        If maxTL <> "..." Then filterString += " and Fiyat <= " & maxTL
        If ekBilgi <> "" Then filterString += " and Oda_Sayisi = '" & ekBilgi & "'"

        ' frmLoad 'tan tasinmistir
        DataTableOlustur()

        Dim iller(82) As String
        SQL.Tablo_Veri_Doldur("Sehirler", iller)
        FiltrePanelSifirla()
        Select Case frm_Giris.SecilenEmlakTuru
            Case 0
                pnlKonutFiltre.Visible = True
                secilenPanel = pnlKonutFiltre
            Case 1
                pnlIsyeriFiltre.Visible = True
                secilenPanel = pnlIsyeriFiltre
            Case 2
                pnlArsaFiltre.Visible = True
                secilenPanel = pnlArsaFiltre
            Case 3
                pnlBinaFiltre.Visible = True
                secilenPanel = pnlBinaFiltre
            Case 4
                pnlTuristikFiltre.Visible = True
                secilenPanel = pnlTuristikFiltre
        End Select

        ComboBoxVeriDoldur()

        txtboxikililer.Add(txtArsaFiyat_MaxTL, txtArsaFiyat_MinTL) ' Arsa textboxları
        txtboxikililer.Add(txtArsaFiyat_MinTL, txtArsaFiyat_MaxTL)
        txtboxikililer.Add(txtArsa_MaxBuyukluk, txtArsa_MinBuyukluk)
        txtboxikililer.Add(txtArsa_MinBuyukluk, txtArsa_MaxBuyukluk)
        txtboxikililer.Add(txtArsa_MaxM4Fiyat, txtArsa_MinM4Fiyat)
        txtboxikililer.Add(txtArsa_MinM4Fiyat, txtArsa_MaxM4Fiyat)

        txtboxikililer.Add(txtBina_MaxBirKattakiDaire2, txtBina_MinBirKattakiDaire2) ' Bina textboxları
        txtboxikililer.Add(txtBina_MinBirKattakiDaire2, txtBina_MaxBirKattakiDaire2)
        txtboxikililer.Add(txtBina_MaxBuyukluk, txtBina_MinBuyukluk)
        txtboxikililer.Add(txtBina_MinBuyukluk, txtBina_MaxBuyukluk)
        txtboxikililer.Add(txtBina_MaxKatSayi3, txtBina_MinKatSayi3)
        txtboxikililer.Add(txtBina_MinKatSayi3, txtBina_MaxKatSayi3)
        txtboxikililer.Add(txtBina_MaxTL, txtBina_MinTL)
        txtboxikililer.Add(txtBina_MinTL, txtBina_MaxTL)

        txtboxikililer.Add(txtIsyeri_MaxTL, txtIsyeri_MinTL) ' İşyeri textboxları
        txtboxikililer.Add(txtIsyeri_MinTL, txtIsyeri_MaxTL)

        txtboxikililer.Add(txtKonut_MaxBanyoSayisi2, txtKonut_MinBanyoSayisi2) ' Konut textboxları
        txtboxikililer.Add(txtKonut_MinBanyoSayisi2, txtKonut_MaxBanyoSayisi2)
        txtboxikililer.Add(txtKonut_MaxBinaYas3, txtKonut_MinBinaYas3)
        txtboxikililer.Add(txtKonut_MinBinaYas3, txtKonut_MaxBinaYas3)
        txtboxikililer.Add(txtKonut_MaxBuyukluk, txtKonut_MinBuyukluk)
        txtboxikililer.Add(txtKonut_MinBuyukluk, txtKonut_MaxBuyukluk)
        txtboxikililer.Add(txtKonut_MaxKatSayi2, txtKonut_MinKatSayi2)
        txtboxikililer.Add(txtKonut_MinKatSayi2, txtKonut_MaxKatSayi2)
        txtboxikililer.Add(txtKonut_MaxTL, txtKonut_MinTL)
        txtboxikililer.Add(txtKonut_MinTL, txtKonut_MaxTL)

        txtboxikililer.Add(txtTuristik_MaxTL, txtTuristik_MinTL) ' Turistik Tesis textboxları
        txtboxikililer.Add(txtTuristik_MinTL, txtTuristik_MaxTL)

        sehir_ilceVeilce_mah.Add(cbxArsa_il, cbxArsa_ilce) ' Arsa Comboboxları
        sehir_ilceVeilce_mah.Add(cbxArsa_ilce, cbxArsa_mahalle)

        sehir_ilceVeilce_mah.Add(cbxBina_il, cbxBina_ilce) ' Bina Comboboxları
        sehir_ilceVeilce_mah.Add(cbxBina_ilce, cbxBina_mahalle)

        sehir_ilceVeilce_mah.Add(cbxIsyeri_il, cbxIsyeri_ilce) ' İşyeri Comboboxları
        sehir_ilceVeilce_mah.Add(cbxIsyeri_ilce, cbxIsyeri_mahalle) ' Arsa Comboboxları

        sehir_ilceVeilce_mah.Add(cbxIl, cbxIlce) ' Konut Comboboxları
        sehir_ilceVeilce_mah.Add(cbxIlce, cbxMahalle)

        sehir_ilceVeilce_mah.Add(cbxTuristik_il, cbxTuristik_ilce) ' Turistik Tesis Comboboxları
        sehir_ilceVeilce_mah.Add(cbxTuristik_ilce, cbxTuristik_mahalle)

        ControlItem_vs_ColoumnName.Add(txtKonut_MinTL.Name, "Fiyat") 'Fiyat TextBox
        ControlItem_vs_ColoumnName.Add(txtArsaFiyat_MinTL.Name, "Fiyat")
        ControlItem_vs_ColoumnName.Add(txtBina_MinTL.Name, "Fiyat")
        ControlItem_vs_ColoumnName.Add(txtTuristik_MinTL.Name, "Fiyat")
        ControlItem_vs_ColoumnName.Add(txtIsyeri_MinTL.Name, "Fiyat")

        ControlItem_vs_ColoumnName.Add(txtKonut_MaxTL.Name, "Fiyat")
        ControlItem_vs_ColoumnName.Add(txtArsaFiyat_MaxTL.Name, "Fiyat")
        ControlItem_vs_ColoumnName.Add(txtBina_MaxTL.Name, "Fiyat")
        ControlItem_vs_ColoumnName.Add(txtTuristik_MaxTL.Name, "Fiyat")
        ControlItem_vs_ColoumnName.Add(txtIsyeri_MaxTL.Name, "Fiyat")

        ControlItem_vs_ColoumnName.Add(txtKonut_MinKatSayi2.Name, "Kat_Sayisi") 'Konut TextBox
        ControlItem_vs_ColoumnName.Add(txtKonut_MinBuyukluk.Name, "Buyukluk")
        ControlItem_vs_ColoumnName.Add(txtKonut_MinBinaYas3.Name, "Bina_Yasi")
        ControlItem_vs_ColoumnName.Add(txtKonut_MinBanyoSayisi2.Name, "Banyo_Sayisi")

        ControlItem_vs_ColoumnName.Add(txtKonut_MaxKatSayi2.Name, "Kat_Sayisi")
        ControlItem_vs_ColoumnName.Add(txtKonut_MaxBuyukluk.Name, "Buyukluk")
        ControlItem_vs_ColoumnName.Add(txtKonut_MaxBinaYas3.Name, "Bina_Yasi")
        ControlItem_vs_ColoumnName.Add(txtKonut_MaxBanyoSayisi2.Name, "Banyo_Sayisi")

        ControlItem_vs_ColoumnName.Add(cbxKonut_bulunduguKat.Name, "Bulundugu_Kat") 'Konut ComboBox
        ControlItem_vs_ColoumnName.Add(cbxKonut_isitma.Name, "Isitma")
        ControlItem_vs_ColoumnName.Add(cbxKonut_odaSayi.Name, "Oda_Sayisi")

        ControlItem_vs_ColoumnName.Add(rbKonutEsyali_Evet.Name, "Esyali") 'Konut Radiobutton
        ControlItem_vs_ColoumnName.Add(rbKonutEsyali_Hayir.Name, "Esyali")
        ControlItem_vs_ColoumnName.Add(rbKonutKredi_evet.Name, "Krediye_Uygun")
        ControlItem_vs_ColoumnName.Add(rbKonutKredi_hayir.Name, "Krediye_Uygun")
        ControlItem_vs_ColoumnName.Add(rbKonutKullanimda_Evet.Name, "Kullanim_Durumu")
        ControlItem_vs_ColoumnName.Add(rbKonutKullanimda_Hayir.Name, "Kullanim_Durumu")
        ControlItem_vs_ColoumnName.Add(rbKonutSite_Evet.Name, "Site_Icerisinde")
        ControlItem_vs_ColoumnName.Add(rbKonutSite_Hayir.Name, "Site_Icerisinde")
        ControlItem_vs_ColoumnName.Add(rbKonutTakas_evet.Name, "Takasli")
        ControlItem_vs_ColoumnName.Add(rbKonutTakas_Hayir.Name, "Takasli")

        ControlItem_vs_ColoumnName.Add(txtArsa_MinBuyukluk.Name, "Buyukluk") ' Arsa TextBox
        ControlItem_vs_ColoumnName.Add(txtArsa_MinM4Fiyat.Name, "Buyukluk")

        ControlItem_vs_ColoumnName.Add(txtArsa_MaxBuyukluk.Name, "Buyukluk")
        ControlItem_vs_ColoumnName.Add(txtArsa_MaxM4Fiyat.Name, "Buyukluk")

        ControlItem_vs_ColoumnName.Add(cbxArsa_gabari.Name, "Gabari") ' Arsa ComboBox
        ControlItem_vs_ColoumnName.Add(cbxArsa_imarDurum.Name, "imar_Durumu")
        ControlItem_vs_ColoumnName.Add(cbxArsa_kaks.Name, "Kaks")
        ControlItem_vs_ColoumnName.Add(cbxArsa_tapuDurum.Name, "Tapu_Durumu")

        ControlItem_vs_ColoumnName.Add(rbArsaKat_evet.Name, "Kat_Karsiligi") 'Arsa RadioButton
        ControlItem_vs_ColoumnName.Add(rbArsaKat_hayir.Name, "Kat_Karsiligi")
        ControlItem_vs_ColoumnName.Add(rbArsaKredi_evet.Name, "Krediye_Uygun")
        ControlItem_vs_ColoumnName.Add(rbArsaKredi_hayir.Name, "Krediye_Uygun")
        ControlItem_vs_ColoumnName.Add(rbArsaTakas_evet.Name, "Takasli")
        ControlItem_vs_ColoumnName.Add(rbArsaTakas_hayir.Name, "Takasli")

        ControlItem_vs_ColoumnName.Add(txtBina_MinBirKattakiDaire2.Name, "Bir_Kattaki_Daire_Sayisi") 'Bina TextBox
        ControlItem_vs_ColoumnName.Add(txtBina_MinBuyukluk.Name, "Buyukluk")
        ControlItem_vs_ColoumnName.Add(txtBina_MinKatSayi3.Name, "Kat_Sayisi")

        ControlItem_vs_ColoumnName.Add(txtBina_MaxBirKattakiDaire2.Name, "Bir_Kattaki_Daire_Sayisi")
        ControlItem_vs_ColoumnName.Add(txtBina_MaxBuyukluk.Name, "Buyukluk")
        ControlItem_vs_ColoumnName.Add(txtBina_MaxKatSayi3.Name, "Kat_Sayisi")

        ControlItem_vs_ColoumnName.Add(cbxBina_isitma.Name, "Isitma") ' Bina ComboBox

        ControlItem_vs_ColoumnName.Add(rbBinaKredi_evet.Name, "Krediye_Uygun") 'Bina RadioButton
        ControlItem_vs_ColoumnName.Add(rbBinaKredi_hayir.Name, "Krediye_Uygun")
        ControlItem_vs_ColoumnName.Add(rbBinaTakas_evet.Name, "Takasli")
        ControlItem_vs_ColoumnName.Add(rbBinaTakas_hayir.Name, "Takasli")

        ControlItem_vs_ColoumnName.Add(cbxIl.Name, "SehirAdi") 'Sehir ComboBox
        ControlItem_vs_ColoumnName.Add(cbxArsa_il.Name, "SehirAdi")
        ControlItem_vs_ColoumnName.Add(cbxBina_il.Name, "SehirAdi")
        ControlItem_vs_ColoumnName.Add(cbxTuristik_il.Name, "SehirAdi")
        ControlItem_vs_ColoumnName.Add(cbxIsyeri_il.Name, "SehirAdi")

        ControlItem_vs_ColoumnName.Add(cbxIlce.Name, "ilceAdi") 'İlçe ComboBox
        ControlItem_vs_ColoumnName.Add(cbxArsa_ilce.Name, "ilceAdi")
        ControlItem_vs_ColoumnName.Add(cbxBina_ilce.Name, "ilceAdi")
        ControlItem_vs_ColoumnName.Add(cbxTuristik_ilce.Name, "ilceAdi")
        ControlItem_vs_ColoumnName.Add(cbxIsyeri_ilce.Name, "ilceAdi")

        ControlItem_vs_ColoumnName.Add(cbxMahalle.Name, "MahalleAdi") 'Mahalle ComboBox
        ControlItem_vs_ColoumnName.Add(cbxArsa_mahalle.Name, "MahalleAdi")
        ControlItem_vs_ColoumnName.Add(cbxBina_mahalle.Name, "MahalleAdi")
        ControlItem_vs_ColoumnName.Add(cbxTuristik_mahalle.Name, "MahalleAdi")
        ControlItem_vs_ColoumnName.Add(cbxIsyeri_mahalle.Name, "MahalleAdi")

        ControlItem_vs_ColoumnName.Add(rbIsyeriTakas_evet.Name, "Takasli") ' İşyeri RadioButton
        ControlItem_vs_ColoumnName.Add(rbIsyeriTakas_hayir.Name, "Takasli")

        ControlItem_vs_ColoumnName.Add(rbKonutIlan_15gun.Name, "ilan_Tarihi") ' Konut Tarih RadioButton
        ControlItem_vs_ColoumnName.Add(rbKonutIlan_3gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbKonutIlan_30gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbKonutIlan_24saat.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbKonutIlan_7gun.Name, "ilan_Tarihi")

        ControlItem_vs_ColoumnName.Add(rbArsaIlan_15gun.Name, "ilan_Tarihi") ' Arsa Tarih RadioButton
        ControlItem_vs_ColoumnName.Add(rbArsaIlan_3gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbArsaIlan_30gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbArsaIlan_7gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbArsaIlan_24saat.Name, "ilan_Tarihi")

        ControlItem_vs_ColoumnName.Add(rbBinaIlan_15gun.Name, "ilan_Tarihi") ' Bina Tarih RadioButton
        ControlItem_vs_ColoumnName.Add(rbBinaIlan_3gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbBinaIlan_30gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbBinaIlan_7gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbBinaIlan_24saat.Name, "ilan_Tarihi")

        ControlItem_vs_ColoumnName.Add(rbTuristikIlan_15gun.Name, "ilan_Tarihi") ' TuristikTesis Tarih RadioButton
        ControlItem_vs_ColoumnName.Add(rbTuristikIlan_30gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbTuristikIlan_3gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbTuristikIlan_7gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbTuristikIlan_24saat.Name, "ilan_Tarihi")

        ControlItem_vs_ColoumnName.Add(rbIsyeriIlan_15gun.Name, "ilan_Tarihi") ' İşyeri Tarih RadioButton
        ControlItem_vs_ColoumnName.Add(rbIsyeriIlan_3gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbIsyeriIlan_30gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbIsyeriIlan_7gun.Name, "ilan_Tarihi")
        ControlItem_vs_ColoumnName.Add(rbIsyeriIlan_24saat.Name, "ilan_Tarihi")

        ControlItem_vs_ColoumnName.Add(chkKonutFoto_foto.Name, "ilan_Resim1")
        ControlItem_vs_ColoumnName.Add(chKonutFoto_video.Name, "ilan_Video")
    End Sub
    Private Sub ClearFilter(sender As Object, e As EventArgs) Handles btnTemizle.Click
        btnEmlakTipi.Text = "Belirlenmemiş"
        btnAdres.Text = "Belirlenmemiş"
        btnFiyat.Text = "... - ... TL"
        btnEkBilgi.Text = ""
        Kontrol.PanelTemizle(secilenPanel, sehir_ilceVeilce_mah)
        ComboBoxVeriDoldur()
        filterString = "ilan_Tur_ID = '" & frm_Giris.SecilenEmlakTuru & "'"
        dv.RowFilter = filterString
        dtgridAramaSonucu.DataSource = dv
    End Sub
    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim giris As New frm_Giris
        Me.Hide()
        giris.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        Dim ara As New frmIlanAra
        Me.Hide()
        ara.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnFiltre_MouseEnter(sender As Object, e As EventArgs) Handles btnTemizle.MouseEnter
        btnTemizle.ForeColor = Color.SteelBlue
        btnTemizle.FlatAppearance.BorderColor = Color.White
    End Sub

    Private Sub btnFiltre_MouseLeave(sender As Object, e As EventArgs) Handles btnTemizle.MouseLeave
        btnTemizle.ForeColor = Color.White
    End Sub

    Private Sub filtreDuzenle(ByVal btn As Button, ByVal pnl As Panel)
        Dim sayi As Integer = btn.TabIndex
        Dim subPanel As Panel = paneliAra(btn, pnl)
        If subPanel.Visible = False Then
            subPanel.Visible = True
            btn.Image = My.Resources.up
            For Each ctrl As Control In pnl.Controls
                If TypeOf ctrl Is Button OrElse TypeOf ctrl Is Panel Then
                    If ctrl.TabIndex > sayi Then ctrl.Location = New Point(ctrl.Location.X, ctrl.Location.Y + subPanel.Height + 5)
                End If
            Next
        Else
            subPanel.Visible = False
            btn.Image = My.Resources.down
            For Each ctrl As Control In pnl.Controls
                If TypeOf ctrl Is Button OrElse TypeOf ctrl Is Panel Then
                    If ctrl.TabIndex > sayi Then ctrl.Location = New Point(ctrl.Location.X, ctrl.Location.Y - subPanel.Height - 5)
                End If
            Next
        End If
    End Sub

    Private Function paneliAra(ByVal buton As Button, ByVal pnl As Panel) As Panel
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Panel Then
                If ctrl.TabIndex = buton.TabIndex Then Return ctrl
            End If
        Next
    End Function
    Private Sub btnKonut_Adres_Click(sender As Object, e As EventArgs) Handles btnKonut_Adres.Click, btnKonut_BanyoSayi.Click, btnKonut_BinaYas.Click, btnKonut_BulunduguKat.Click, btnKonut_Buyukluk.Click, btnKonut_Esyali.Click, btnKonut_Fiyat.Click, btnKonut_FotoVideo.Click, btnKonut_IlanTarihi.Click, btnKonut_Isitma.Click, btnKonut_KatSayi.Click, btnKonut_Kredi.Click, btnKonut_Kullanimda.Click, btnKonut_OdaSayi.Click, btnKonut_SiteIcerisinde.Click, btnKonut_Takas.Click,
                                                                               btnArsa_Adres.Click, btnArsa_Buyukluk.Click, btnArsa_Fiyat.Click, btnArsa_FotoVideo.Click, btnArsa_Gabari.Click, btnArsa_IlanTarihi.Click, btnArsa_ImarDurumu.Click, btnArsa_Kaks.Click, btnArsa_KatKarsilik.Click, btnArsa_Kredi.Click, btnArsa_m2Fiyati.Click, btnArsa_Takas.Click, btnArsa_TapuDurumu.Click,
                                                                               btnIsyeri_Adres.Click, btnIsyeri_Fiyat.Click, btnIsyeri_FotoVideo.Click, btnIsyeri_IlanTarihi.Click, btnIsyeri_Takas.Click,
                                                                               btnBina_Adres.Click, btnBina_birKattakiDaire.Click, btnBina_buyukluk.Click, btnBina_Fiyat.Click, btnBina_fotoVideo.Click, btnBina_ilanTarihi.Click, btnBina_isitma.Click, btnBina_KatSayi.Click, btnBina_kredi.Click, btnBina_takas.Click,
                                                                               btnTuristik_adres.Click, btnTuristik_fiyat.Click, btnTuristik_fotoVideo.Click, btnTuristik_ilanTarihi.Click
        filtreDuzenle(sender, secilenPanel)
    End Sub

    Private Sub pnlKonutFiltre_MouseEnter(sender As Object, e As EventArgs) Handles pnlKonutFiltre.MouseEnter, pnlIsyeriFiltre.MouseEnter, pnlArsaFiltre.MouseEnter, pnlBinaFiltre.MouseEnter, pnlTuristikFiltre.MouseEnter
        secilenPanel = sender
    End Sub
    Private Sub SayiKontolEt(sender As Object, e As KeyPressEventArgs) Handles txtArsaFiyat_MaxTL.KeyPress, txtArsaFiyat_MinTL.KeyPress, txtArsa_MaxBuyukluk.KeyPress, txtArsa_MaxM4Fiyat.KeyPress, txtArsa_MinBuyukluk.KeyPress, txtArsa_MinM4Fiyat.KeyPress,
                                                                               txtBina_MaxBirKattakiDaire2.KeyPress, txtBina_MaxBuyukluk.KeyPress, txtBina_MaxKatSayi3.KeyPress, txtBina_MaxTL.KeyPress, txtBina_MinBirKattakiDaire2.KeyPress, txtBina_MinBuyukluk.KeyPress, txtBina_MinKatSayi3.KeyPress, txtBina_MinTL.KeyPress,
                                                                               txtIsyeri_MaxTL.KeyPress, txtIsyeri_MinTL.KeyPress,
                                                                               txtKonut_MaxBanyoSayisi2.KeyPress, txtKonut_MaxBinaYas3.KeyPress, txtKonut_MaxBuyukluk.KeyPress, txtKonut_MaxKatSayi2.KeyPress, txtKonut_MaxTL.KeyPress, txtKonut_MinBanyoSayisi2.KeyPress, txtKonut_MinBinaYas3.KeyPress, txtKonut_MinBuyukluk.KeyPress, txtKonut_MinKatSayi2.KeyPress, txtKonut_MinTL.KeyPress,
                                                                               txtTuristik_MaxTL.KeyPress, txtTuristik_MinTL.KeyPress
        If sender.Name.IndexOf(" TL") <> -1 Then : e.Handled = Kontrol.SayiKontrolu(9, sender, e)
        ElseIf sender.Name.IndexOf("Buyukluk") <> -1 Then : e.Handled = Kontrol.SayiKontrolu(7, sender, e)
        ElseIf sender.Name.IndexOf("4") <> -1 Then : e.Handled = Kontrol.SayiKontrolu(5, sender, e)
        ElseIf sender.name.IndexOf("3") <> -1 Then : e.Handled = Kontrol.SayiKontrolu(2, sender, e)
        ElseIf sender.Name.IndexOf("2") <> -1 Then : e.Handled = Kontrol.SayiKontrolu(2, sender, e)
        End If
    End Sub
    Private Sub txtTemizle(sender As Object, e As EventArgs) Handles txtArsaFiyat_MaxTL.Enter, txtArsaFiyat_MaxTL.MouseEnter, txtArsaFiyat_MinTL.Enter, txtArsaFiyat_MinTL.MouseEnter, txtArsa_MaxBuyukluk.Enter, txtArsa_MaxBuyukluk.MouseEnter, txtArsa_MaxM4Fiyat.Enter, txtArsa_MaxM4Fiyat.MouseEnter, txtArsa_MinBuyukluk.Enter, txtArsa_MinBuyukluk.MouseEnter, txtArsa_MinM4Fiyat.Enter, txtArsa_MinM4Fiyat.MouseEnter,
                                                                     txtBina_MaxBirKattakiDaire2.Enter, txtBina_MaxBirKattakiDaire2.MouseEnter, txtBina_MaxBuyukluk.Enter, txtBina_MaxBuyukluk.MouseEnter, txtBina_MaxKatSayi3.Enter, txtBina_MaxKatSayi3.MouseEnter, txtBina_MaxTL.Enter, txtBina_MaxTL.MouseEnter, txtBina_MinBirKattakiDaire2.Enter, txtBina_MinBirKattakiDaire2.MouseEnter, txtBina_MinBuyukluk.Enter, txtBina_MinBuyukluk.MouseEnter, txtBina_MinKatSayi3.Enter, txtBina_MinKatSayi3.MouseEnter, txtBina_MinTL.Enter, txtBina_MinTL.MouseEnter,
                                                                     txtIsyeri_MaxTL.Enter, txtIsyeri_MaxTL.MouseEnter, txtIsyeri_MinTL.Enter, txtIsyeri_MinTL.MouseEnter,
                                                                     txtKonut_MaxBanyoSayisi2.Enter, txtKonut_MaxBanyoSayisi2.MouseEnter, txtKonut_MaxBinaYas3.Enter, txtKonut_MaxBinaYas3.MouseEnter, txtKonut_MaxBuyukluk.Enter, txtKonut_MaxBuyukluk.MouseEnter, txtKonut_MaxKatSayi2.Enter, txtKonut_MaxKatSayi2.MouseEnter, txtKonut_MaxTL.Enter, txtKonut_MaxTL.MouseEnter, txtKonut_MinBanyoSayisi2.Enter, txtKonut_MinBanyoSayisi2.MouseEnter, txtKonut_MinBinaYas3.Enter, txtKonut_MinBinaYas3.MouseEnter, txtKonut_MinBuyukluk.Enter, txtKonut_MinBuyukluk.MouseEnter, txtKonut_MinKatSayi2.Enter, txtKonut_MinKatSayi2.MouseEnter, txtKonut_MinTL.Enter, txtKonut_MinTL.MouseEnter,
                                                                     txtTuristik_MaxTL.Enter, txtTuristik_MaxTL.MouseEnter, txtTuristik_MinTL.Enter, txtTuristik_MinTL.MouseEnter
        Kontrol.AlanTemizle(sender)
        sender.ForeColor = Color.Black
    End Sub
    Private Sub integerLimitKontrol(sender As Object, e As EventArgs) Handles txtArsaFiyat_MaxTL.Leave, txtArsaFiyat_MinTL.Leave, txtBina_MaxTL.Leave, txtBina_MinTL.Leave, txtKonut_MaxTL.Leave, txtKonut_MinTL.Leave, txtIsyeri_MaxTL.Leave, txtIsyeri_MinTL.Leave, txtTuristik_MaxTL.Leave, txtTuristik_MinTL.Leave
        If Not sender.Text = "" Then Kontrol.LimitKontrol(DirectCast(sender, TextBox), "integer")
    End Sub
    Private Sub smallintLimitKontrol(sender As Object, e As EventArgs) Handles txtArsa_MaxBuyukluk.Leave, txtArsa_MaxM4Fiyat.Leave, txtArsa_MinBuyukluk.Leave, txtArsa_MinM4Fiyat.Leave, txtBina_MaxBuyukluk.Leave, txtBina_MinBuyukluk.Leave, txtKonut_MaxBuyukluk.Leave, txtKonut_MinBuyukluk.Leave
        If Not sender.Text = "" Then Kontrol.LimitKontrol(DirectCast(sender, TextBox), "short")
    End Sub
    Private Sub tinyintLimitKontrol(sender As Object, e As EventArgs) Handles txtBina_MaxKatSayi3.Leave, txtBina_MaxBirKattakiDaire2.Leave, txtBina_MinBirKattakiDaire2.Leave, txtBina_MinKatSayi3.Leave, txtKonut_MaxBanyoSayisi2.Leave, txtKonut_MaxBinaYas3.Leave, txtKonut_MaxKatSayi2.Leave, txtKonut_MinBanyoSayisi2.Leave, txtKonut_MinBinaYas3.Leave, txtKonut_MinKatSayi2.Leave
        If Not sender.Text = "" Then Kontrol.LimitKontrol(DirectCast(sender, TextBox), "byte")
    End Sub
    Private Sub txtTekrarYaz(sender As Object, e As EventArgs) Handles txtArsaFiyat_MaxTL.Leave, txtArsaFiyat_MaxTL.MouseLeave, txtArsaFiyat_MinTL.Leave, txtArsaFiyat_MinTL.MouseLeave, txtArsa_MaxBuyukluk.Leave, txtArsa_MaxBuyukluk.MouseLeave, txtArsa_MaxM4Fiyat.Leave, txtArsa_MaxM4Fiyat.MouseLeave, txtArsa_MinBuyukluk.Leave, txtArsa_MinBuyukluk.MouseLeave, txtArsa_MinM4Fiyat.Leave, txtArsa_MinM4Fiyat.MouseLeave,
                                                                     txtBina_MaxBirKattakiDaire2.Leave, txtBina_MaxBirKattakiDaire2.MouseLeave, txtBina_MaxBuyukluk.Leave, txtBina_MaxBuyukluk.MouseLeave, txtBina_MaxKatSayi3.Leave, txtBina_MaxKatSayi3.MouseLeave, txtBina_MaxTL.Leave, txtBina_MaxTL.MouseLeave, txtBina_MinBirKattakiDaire2.Leave, txtBina_MinBirKattakiDaire2.MouseLeave, txtBina_MinBuyukluk.Leave, txtBina_MinBuyukluk.MouseLeave, txtBina_MinKatSayi3.Leave, txtBina_MinKatSayi3.MouseLeave, txtBina_MinTL.Leave, txtBina_MinTL.MouseLeave,
                                                                     txtIsyeri_MaxTL.Leave, txtIsyeri_MaxTL.MouseLeave, txtIsyeri_MinTL.Leave, txtIsyeri_MinTL.MouseLeave,
                                                                     txtKonut_MaxBanyoSayisi2.Leave, txtKonut_MaxBanyoSayisi2.MouseLeave, txtKonut_MaxBinaYas3.Leave, txtKonut_MaxBinaYas3.MouseLeave, txtKonut_MaxBuyukluk.Leave, txtKonut_MaxBuyukluk.MouseLeave, txtKonut_MaxKatSayi2.Leave, txtKonut_MaxKatSayi2.MouseLeave, txtKonut_MaxTL.Leave, txtKonut_MaxTL.MouseLeave, txtKonut_MinBanyoSayisi2.Leave, txtKonut_MinBanyoSayisi2.MouseLeave, txtKonut_MinBinaYas3.Leave, txtKonut_MinBinaYas3.MouseLeave, txtKonut_MinBuyukluk.Leave, txtKonut_MinBuyukluk.MouseLeave, txtKonut_MinKatSayi2.Leave, txtKonut_MinKatSayi2.MouseLeave, txtKonut_MinTL.Leave, txtKonut_MinTL.MouseLeave,
                                                                     txtTuristik_MaxTL.Leave, txtTuristik_MaxTL.MouseLeave, txtTuristik_MinTL.Leave, txtTuristik_MinTL.MouseLeave
        If sender.text = "" And Not DirectCast(sender, TextBox).Focused Then Kontrol.bosTextboxDoldur(sender)
    End Sub
    Private Sub txtMinMaxKontrol(sender As Object, e As EventArgs) Handles txtArsaFiyat_MaxTL.Leave, txtArsaFiyat_MinTL.Leave, txtArsa_MaxBuyukluk.Leave, txtArsa_MaxM4Fiyat.Leave, txtArsa_MinBuyukluk.Leave, txtArsa_MinM4Fiyat.Leave,
                                                                     txtBina_MaxBirKattakiDaire2.Leave, txtBina_MaxBuyukluk.Leave, txtBina_MaxKatSayi3.Leave, txtBina_MaxTL.Leave, txtBina_MinBirKattakiDaire2.Leave, txtBina_MinBuyukluk.Leave, txtBina_MinKatSayi3.Leave, txtBina_MinTL.Leave,
                                                                     txtIsyeri_MaxTL.Leave, txtIsyeri_MinTL.Leave,
                                                                     txtKonut_MaxBanyoSayisi2.Leave, txtKonut_MaxBinaYas3.Leave, txtKonut_MaxBuyukluk.Leave, txtKonut_MaxKatSayi2.Leave, txtKonut_MaxTL.Leave, txtKonut_MinBanyoSayisi2.Leave, txtKonut_MinBinaYas3.Leave, txtKonut_MinBuyukluk.Leave, txtKonut_MinKatSayi2.Leave, txtKonut_MinTL.Leave,
                                                                     txtTuristik_MaxTL.Leave, txtTuristik_MinTL.Leave
        If Not sender.Text = "" Then Kontrol.txtMinMaxKontrolu(sender, txtboxikililer)
    End Sub

    Private Sub FiltrePanelSifirla()
        pnlArsaFiltre.Visible = False
        pnlBinaFiltre.Visible = False
        pnlIsyeriFiltre.Visible = False
        pnlKonutFiltre.Visible = False
        pnlTuristikFiltre.Visible = False
    End Sub
    Private Sub frmArama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sub New ' a tasinmistir
    End Sub
    Private Sub ilceDoldur(sender As Object, e As EventArgs) Handles cbxArsa_il.SelectedIndexChanged, cbxBina_il.SelectedIndexChanged, cbxIsyeri_il.SelectedIndexChanged, cbxIl.SelectedIndexChanged, cbxTuristik_il.SelectedIndexChanged
        Dim cbx As New ComboBox
        cbx = DirectCast(sender, ComboBox)
        sehir_ilceVeilce_mah(cbx).Items.Clear()
        sehir_ilceVeilce_mah(sehir_ilceVeilce_mah(cbx)).Items.Clear()
        SQL.ilce_Doldur(ilce, 82 - cbx.SelectedIndex)
        For i As Integer = 0 To ilce.Length
            If ilce(i, 1) = Nothing Then Exit For
            sehir_ilceVeilce_mah(cbx).Items.Add(ilce(i, 1))
        Next
        secilenIl = CType(sender, ComboBox).SelectedItem
        btnAdres.Text = secilenIl
    End Sub
    Private Sub MahalleDoldur(sender As Object, e As EventArgs) Handles cbxArsa_ilce.SelectedIndexChanged, cbxBina_ilce.SelectedIndexChanged, cbxIsyeri_ilce.SelectedIndexChanged, cbxIlce.SelectedIndexChanged, cbxTuristik_ilce.SelectedIndexChanged
        Dim cbx As New ComboBox
        cbx = DirectCast(sender, ComboBox)
        sehir_ilceVeilce_mah(cbx).Items.Clear()
        For i As Integer = 0 To ilce.Length
            If ilce(i, 1) = Nothing Then Exit For
            If ilce(i, 1) = cbx.SelectedItem Then
                SQL.semtMah_Doldur(sehir_ilceVeilce_mah(cbx), ilce(i, 0))
                Exit For
            End If
        Next
        btnAdres.Text = ""
        btnAdres.Text = CType(sender, ComboBox).SelectedItem + ", " + secilenIl
    End Sub
    Private Sub ComboBoxFiltrele(sender As Object, e As EventArgs) Handles cbxIl.SelectedIndexChanged, cbxArsa_il.SelectedIndexChanged, cbxBina_il.SelectedIndexChanged, cbxTuristik_il.SelectedIndexChanged, cbxIsyeri_il.SelectedIndexChanged, cbxIlce.SelectedIndexChanged, cbxArsa_ilce.SelectedIndexChanged, cbxBina_ilce.SelectedIndexChanged, cbxTuristik_ilce.SelectedIndexChanged, cbxIsyeri_ilce.SelectedIndexChanged, cbxMahalle.SelectedIndexChanged, cbxArsa_mahalle.SelectedIndexChanged, cbxBina_mahalle.SelectedIndexChanged, cbxTuristik_mahalle.SelectedIndexChanged, cbxIsyeri_mahalle.SelectedIndexChanged, cbxKonut_bulunduguKat.SelectedIndexChanged, cbxKonut_isitma.SelectedIndexChanged, cbxKonut_odaSayi.SelectedIndexChanged, cbxArsa_gabari.SelectedIndexChanged, cbxArsa_imarDurum.SelectedIndexChanged, cbxArsa_kaks.SelectedIndexChanged, cbxArsa_tapuDurum.SelectedIndexChanged, cbxBina_isitma.SelectedIndexChanged
        If sender.name = "cbxKonut_odaSayi" Then
            btnEkBilgi.Text = CType(sender, ComboBox).SelectedItem
        End If
        If sender.SelectedIndex <> -1 Then dv.RowFilter() = CreateFilter(ControlItem_vs_ColoumnName(sender.Name) & " = '" & sender.SelectedItem & "'")
        If sender.SelectedIndex = -1 Then dv.RowFilter = RemoveFilter(ControlItem_vs_ColoumnName(sender.Name) & " = ")
        dtgridAramaSonucu.DataSource = dv
    End Sub
    Private Sub MinFiltrele(sender As Object, e As EventArgs) Handles txtKonut_MinTL.Leave, txtArsaFiyat_MinTL.Leave, txtBina_MinTL.Leave, txtTuristik_MinTL.Leave, txtIsyeri_MinTL.Leave, txtKonut_MinBanyoSayisi2.Leave, txtKonut_MinBinaYas3.Leave, txtKonut_MinBuyukluk.Leave, txtKonut_MinKatSayi2.Leave, txtArsa_MinBuyukluk.Leave, txtArsa_MinM4Fiyat.Leave, txtBina_MinBirKattakiDaire2.Leave, txtBina_MinBuyukluk.Leave, txtBina_MinKatSayi3.Leave
        If sender.Text.IndexOf("M") = -1 And sender.Text <> Nothing Then dv.RowFilter() = CreateFilter(ControlItem_vs_ColoumnName(sender.Name) & " >= " & CInt(sender.Text) & "")
        If sender.Text = Nothing Or sender.Text.IndexOf("M") <> -1 Then dv.RowFilter() = RemoveFilter(ControlItem_vs_ColoumnName(sender.Name) & " >= ")
        dtgridAramaSonucu.DataSource = dv
    End Sub
    Private Sub minFiyatKontrol(sender As Object, e As EventArgs) Handles txtKonut_MinTL.TextChanged, txtArsaFiyat_MinTL.TextChanged, txtBina_MinTL.TextChanged, txtTuristik_MinTL.TextChanged, txtIsyeri_MinTL.TextChanged
        minFiyat = CType(sender, TextBox).Text
        btnFiyat.Text = IIf(minFiyat = "" Or minFiyat = "Min TL", "...", minFiyat) + " - " + IIf(maxFiyat = "" Or maxFiyat = "Max TL", "...", maxFiyat) + " TL"
    End Sub
    Private Sub maxFiyatKontrol(sender As Object, e As EventArgs) Handles txtKonut_MaxTL.TextChanged, txtArsaFiyat_MaxTL.TextChanged, txtBina_MaxTL.TextChanged, txtTuristik_MaxTL.TextChanged, txtIsyeri_MaxTL.TextChanged
        maxFiyat = CType(sender, TextBox).Text
        btnFiyat.Text = IIf(minFiyat = "" Or minFiyat = "Min TL", "...", minFiyat) + " - " + IIf(maxFiyat = "" Or maxFiyat = "Max TL", "...", maxFiyat) + " TL"
    End Sub
    Private Sub MaxFiltrele(sender As Object, e As EventArgs) Handles txtKonut_MaxTL.Leave, txtArsaFiyat_MaxTL.Leave, txtBina_MaxTL.Leave, txtTuristik_MaxTL.Leave, txtIsyeri_MaxTL.Leave, txtKonut_MaxBanyoSayisi2.Leave, txtKonut_MaxBinaYas3.Leave, txtKonut_MaxBuyukluk.Leave, txtKonut_MaxKatSayi2.Leave, txtArsa_MaxBuyukluk.Leave, txtArsa_MaxM4Fiyat.Leave, txtBina_MaxBirKattakiDaire2.Leave, txtBina_MaxBuyukluk.Leave, txtBina_MaxKatSayi3.Leave
        If sender.Text.IndexOf("M") = -1 And sender.Text <> Nothing Then dv.RowFilter() = CreateFilter(ControlItem_vs_ColoumnName(sender.Name) & " <= " & CInt(sender.Text) & "")
        If sender.Text = Nothing Or sender.Text.IndexOf("M") <> -1 Then dv.RowFilter() = RemoveFilter(ControlItem_vs_ColoumnName(sender.Name) & " <= ")
        dtgridAramaSonucu.DataSource = dv
    End Sub
    Private Sub EvetHayirFiltrele(sender As Object, e As EventArgs) Handles rbKonutEsyali_Evet.CheckedChanged, rbKonutEsyali_Hayir.CheckedChanged, rbKonutKredi_evet.CheckedChanged, rbKonutKredi_hayir.CheckedChanged, rbKonutKullanimda_Evet.CheckedChanged, rbKonutKullanimda_Hayir.CheckedChanged, rbKonutSite_Evet.CheckedChanged, rbKonutSite_Hayir.CheckedChanged, rbKonutTakas_evet.CheckedChanged, rbKonutTakas_Hayir.CheckedChanged, rbArsaKat_evet.CheckedChanged, rbArsaKat_hayir.CheckedChanged, rbArsaKredi_evet.CheckedChanged, rbArsaKredi_hayir.CheckedChanged, rbArsaTakas_evet.CheckedChanged, rbArsaTakas_hayir.CheckedChanged, rbBinaKredi_evet.CheckedChanged, rbBinaKredi_hayir.CheckedChanged, rbBinaTakas_evet.CheckedChanged, rbBinaTakas_hayir.CheckedChanged, rbIsyeriTakas_evet.CheckedChanged, rbIsyeriTakas_hayir.CheckedChanged
        If sender.Name.IndexOf("vet") <> -1 And sender.Checked Then
            dv.RowFilter() = CreateFilter(ControlItem_vs_ColoumnName(sender.Name) & " = True")
        ElseIf sender.Checked Then
            dv.RowFilter() = CreateFilter(ControlItem_vs_ColoumnName(sender.Name) & " = False")
        End If
        dtgridAramaSonucu.DataSource = dv
    End Sub
    Private Sub TarihFiltrele(sender As Object, e As EventArgs) Handles rbKonutIlan_15gun.CheckedChanged, rbKonutIlan_24saat.CheckedChanged, rbKonutIlan_30gun.CheckedChanged, rbKonutIlan_3gun.CheckedChanged, rbKonutIlan_7gun.CheckedChanged, rbArsaIlan_15gun.CheckedChanged, rbArsaIlan_24saat.CheckedChanged, rbArsaIlan_30gun.CheckedChanged, rbArsaIlan_3gun.CheckedChanged, rbArsaIlan_7gun.CheckedChanged, rbBinaIlan_15gun.CheckedChanged, rbBinaIlan_24saat.CheckedChanged, rbBinaIlan_30gun.CheckedChanged, rbBinaIlan_3gun.CheckedChanged, rbBinaIlan_7gun.CheckedChanged, rbIsyeriIlan_15gun.CheckedChanged, rbIsyeriIlan_24saat.CheckedChanged, rbIsyeriIlan_30gun.CheckedChanged, rbIsyeriIlan_3gun.CheckedChanged, rbIsyeriIlan_7gun.CheckedChanged, rbTuristikIlan_15gun.CheckedChanged, rbTuristikIlan_24saat.CheckedChanged, rbTuristikIlan_30gun.CheckedChanged, rbTuristikIlan_3gun.CheckedChanged, rbTuristikIlan_7gun.CheckedChanged
        If sender.Checked Then
            If sender.Text.Split(" ")(1) = 24 Then
                dv.RowFilter() = CreateFilter(ControlItem_vs_ColoumnName(sender.Name) & " >= " & CreateDateFilterString(1))
            Else
                dv.RowFilter() = CreateFilter(ControlItem_vs_ColoumnName(sender.Name) & " >= " & CreateDateFilterString(CByte(sender.Text.Split(" ")(1))))
            End If
        End If
        dtgridAramaSonucu.DataSource = dv
    End Sub
    Private Sub checkboxFiltrele(sender As Object, e As EventArgs) Handles chkKonutFoto_foto.CheckedChanged, chKonutFoto_video.CheckedChanged
        Dim check As CheckBox = DirectCast(sender, CheckBox)
        If check.Checked = True Then
            dv.RowFilter() = CreateFilter(ControlItem_vs_ColoumnName(check.Name) & " IS NOT NULL")
        Else
            dv.RowFilter() = RemoveFilter(ControlItem_vs_ColoumnName(check.Name) & " IS NOT ")
        End If
    End Sub
    Private Function CreateFilter(filter As String) As String
        Dim subfilters() As String = filter.Split(" ")
        If filterString = Nothing Then 'filtre boş mu
            filterString += filter
        Else
            If filterString.IndexOf(subfilters(0)) <> -1 Then ' var olan karşılaştırma mı
                Dim subFilterString As String
                subFilterString = filterString.Substring(filterString.IndexOf(subfilters(0)))
                Dim oldfiltercondition As String = Nothing
                If filter.IndexOf("'") <> -1 Then oldfiltercondition = subFilterString.Split("'")(1)
                If filter.IndexOf("IS NOT") <> -1 Then oldfiltercondition = "NULL"
                If subFilterString.Split(" ")(1) = subfilters(1) Then ' var olan karşılaştırmanın karşılaştırma koşulu aynı mı
                    If oldfiltercondition IsNot Nothing Then
                        subFilterString = subFilterString.Substring(subFilterString.IndexOf(subfilters(0)), (subFilterString.Split(" ")(0) & subFilterString.Split(" ")(1) & oldfiltercondition).Length + 4)
                    ElseIf oldfiltercondition = "NULL" Then
                        subFilterString = subFilterString.Substring(subFilterString.IndexOf(subfilters(0)), (subFilterString.Split(" ")(0) & "IS NOT NULL").Length + 1)
                    Else
                        subFilterString = subFilterString.Substring(subFilterString.IndexOf(subfilters(0)), (subFilterString.Split(" ")(0) & subFilterString.Split(" ")(1) & subFilterString.Split(" ")(2)).Length + 2) 'öyleyse eski koşulu bul
                    End If
                    filterString = filterString.Replace(subFilterString, filter) 'eski koşulu yeni koşulla değiştir
                Else
                    subFilterString = filterString.Substring(filterString.IndexOf(subfilters(0)) + 5)
                    If subFilterString.IndexOf(subfilters(0)) <> -1 Then ' var olan karşılaştırmanın diğer koşulu ile yapılan karşılaştırma mı
                        subFilterString = subFilterString.Substring(subFilterString.IndexOf(subfilters(0))) 'öyleyse eski koşulu bul
                        filterString = filterString.Replace(subFilterString, filter) 'eski koşulu yeni koşulla değiştir
                    Else
                        filterString += " and " & filter ' değilse filteryi ekle
                    End If
                End If
            Else
                filterString += " and " & filter ' yoksa filteryi ekle
            End If
        End If
        Return filterString
    End Function
    Private Function RemoveFilter(rmvFilter As String) As String
        If filterString.IndexOf(rmvFilter) <> -1 Then
            Dim FilterValue As String = filterString.Substring(filterString.IndexOf(rmvFilter) + rmvFilter.Length).Split(" ")(0)
            rmvFilter += FilterValue
            If filterString.IndexOf(rmvFilter) <> 0 Then
                rmvFilter = " and " & rmvFilter
            End If
            filterString = filterString.Replace(rmvFilter, "")
        End If
        Return filterString
    End Function
    Private Function CreateDateFilterString(day As Byte) As String
        Dim DateFilter As String = Nothing
        If Date.Today.Day <= day Then ' Mevcut gün ötelenecek günden küöük bir değer mi
            CheckMonth(DateFilter, day)
        Else
            DateFilter = "'" & Date.Today.Day - day & "." & Date.Today.Month & "." & Date.Today.Year & "'"
        End If
        Return DateFilter
    End Function
    Private Sub CheckMonth(ByRef filerString As String, day As Byte)
        Select Case Date.Today.Month' Ayın ilk günüyse hangi aydayız
            Case 1 ' Ocak Ayıysa
                filerString = "'" & 31 + Date.Today.Day - day & ".12." & Date.Today.Year - 1 & "'"
            Case 2, 4, 6, 8, 9, 11 ' kendinden önceki ay, gün sayısı 31 olan ay mı
                filerString = "'" & 31 + Date.Today.Day - day & "." & Date.Today.Month - 1 & "." & Date.Today.Year & "'"
            Case 3 'Mart Ayı mı
                If Date.Today.Year Mod 4 = 0 Then 'Şubat ayının bu seneki gün sayısı kontrolü
                    filerString = "'" & 29 + Date.Today.Day - day & "." & Date.Today.Month - 1 & "." & Date.Today.Year & "'"
                Else
                    filerString = "'" & 28 + Date.Today.Day - day & "." & Date.Today.Month - 1 & "." & Date.Today.Year & "'"
                End If
            Case 5, 7, 10, 12 ' kendinden önceki ay, gün sayısı 30 olan ay mı
                filerString = "'" & 30 + Date.Today.Day - day & "." & Date.Today.Month - 1 & "." & Date.Today.Year & "'"
        End Select
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridAramaSonucu.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim dr As DataRow = dt.Rows(e.RowIndex)
            Dim frm As New frmProfil(dr)
            Me.Hide()
            frm.ShowDialog()
            DataTableOlustur()
            Me.Show()
        End If
    End Sub
    Private Sub ComboBoxVeriDoldur()
        Dim iller(82) As String
        SQL.Tablo_Veri_Doldur("Sehirler", iller)
        Select Case frm_Giris.SecilenEmlakTuru
            Case 0
                btnSatisTuru.Text = "Konut"
                For index As Integer = 81 To 0 Step -1
                    cbxIl.Items.Add(iller(index))
                Next
                SQL.Tablo_Veri_Doldur("Oda_Sayisi", cbxKonut_odaSayi)
                SQL.Tablo_Veri_Doldur("Isitma", cbxKonut_isitma)
                SQL.Tablo_Veri_Doldur("Bulundugu_Kat", cbxKonut_bulunduguKat)
            Case 1
                btnSatisTuru.Text = "İşyeri"
                For index As Integer = 81 To 0 Step -1
                    cbxIsyeri_il.Items.Add(iller(index))
                Next
            Case 2
                btnSatisTuru.Text = "Arsa"
                For index As Integer = 81 To 0 Step -1
                    cbxArsa_il.Items.Add(iller(index))
                Next
                SQL.Tablo_Veri_Doldur("imar_Durumu", cbxArsa_imarDurum)
                SQL.Tablo_Veri_Doldur("Gabari", cbxArsa_gabari)
                SQL.Tablo_Veri_Doldur("Kaks", cbxArsa_kaks)
                SQL.Tablo_Veri_Doldur("Tapu_Durumu", cbxArsa_tapuDurum)
            Case 3
                btnSatisTuru.Text = "Bina"
                For index As Integer = 81 To 0 Step -1
                    cbxBina_il.Items.Add(iller(index))
                Next
                SQL.Tablo_Veri_Doldur("Isitma", cbxBina_isitma)
            Case 4
                btnSatisTuru.Text = "Turistik Tesis"
                For index As Integer = 81 To 0 Step -1
                    cbxTuristik_il.Items.Add(iller(index))
                Next
        End Select
    End Sub

    Private Sub DataTableOlustur()
        Select Case frm_Giris.SecilenEmlakTuru
            Case 0
                dt = SQL.KonutTablosu()
            Case 1
                Select Case btnEmlakTipi.Text
                    Case "Büfe", "Düğün Salonu", "Spa, Hamam & Sauna", "Sinema", "Otopark"
                        dt = SQL.BufeDugunSpaSineOtoTablosu(isyeriTipi)
                    Case "Atölye", "Büro", "Dükkan & Mağaza", "İmalathane", "AVM"
                        dt = SQL.AtolyeBuroDukkanImaAVMTablosu(isyeriTipi)
                    Case "Depo & Antrepo", "Komple Bina", "Plaza Katı", "Fabrika"
                        dt = SQL.DepoBinaPlazaFabrikaTablosu(isyeriTipi)
                    Case "Spor Tesisi", "Radyo İstasyonu", "Pazar Yeri", "Çiftlik"
                        dt = SQL.SporRadyoPazarCiftlikTablosu(isyeriTipi)
                End Select
            Case 2
                dt = SQL.ArsaTablosu()
            Case 3
                dt = SQL.BinaTablosu()
            Case 4
                dt = SQL.TuristikTesisTablosu()
        End Select
        dv = dt.DefaultView
        dv.RowFilter = filterString
        dtgridAramaSonucu.DataSource = dv
        ' TABLO AYARLAMALARI
        dtgridAramaSonucu.Columns("clmBaslik").DisplayIndex = 1
        dtgridAramaSonucu.Columns("clmFiyat").DisplayIndex = 4
    End Sub
End Class