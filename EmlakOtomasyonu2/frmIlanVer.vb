Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class cbxBulunduguKat
    Dim SQL As New SqlEmlak

    Dim emlakTurleri As New Dictionary(Of Integer, String) ' ListEmlak indexi ile veri tabanı tablo eşleştirmeleri için kullanılmıştır
    Dim emptyMaskedTextBox As String
    Dim adim As Integer = 1
    Dim fotoSayisi As Integer = 0
    Dim secilmis As Integer = 0
    Dim ilce(1000, 1) As String
    Dim secilenGroupbox As New GroupBox 'Gropubox'taki doldurulması gereken alanların doldurulup doldurulmadığını kontol edebimemiz için oluşturulmuştur
    Dim dt As New DataTable
    Dim degistirmekİcinCagrildi As Boolean = False
    Dim DegistirilenEmlakTur As Byte
    Dim DegisitirilenEmlakTip As Byte
    Dim DegistirilenSatisTur As Byte
    Dim updateIlanNo As String
    Sub New()
        InitializeComponent()
        lblIlanDegistir.Visible = False
    End Sub
    Sub New(groupboxAdi As String, dr As DataRow)
        InitializeComponent()
        degistirmekİcinCagrildi = True
        gbxSifirla()
        lblIlanDegistir.Visible = True
        btn_geri.Text = "Diğer"
        btn_ileri.Text = "Kaydet"
        btn_ileri.Visible = True
        pnlilanDetayi.Visible = False
        pnlKategori.Visible = False
        pnlBasari.Visible = False
        pnlIlanOzellikleri.Visible = True
        DegistirilenEmlakTur = dr(5)

        For Each gbx As Object In pnlIlanOzellikleri.Controls
            If TypeOf gbx Is GroupBox Then
                Dim gbxx As New GroupBox
                gbxx = gbx
                If gbxx.Name = groupboxAdi Then
                    gbxx.Visible = True
                    degistirilecekVerileriYerlestir(groupboxAdi, dr)
                    Exit For
                End If
            End If
        Next
    End Sub

    Public Function byteArrayToImage(byteArrayIn As Byte()) As Image
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        Dim returnImage As Image = Image.FromStream(New MemoryStream(byteArrayIn))
        Return returnImage
    End Function

    Private Sub degistirilecekVerileriYerlestir(gbxname As String, dr As DataRow)
        cbxIl.Items.Clear()
        cbxIlce.Items.Clear()
        cbxMahalle.Items.Clear()
        updateIlanNo = dr(0)
        lblKategori.Text = "Emlak > "
        If dr("ilan_Video") IsNot DBNull.Value Then Label1.Text = dr("ilan_Video")
        Select Case dr(5)
            Case 0 ' konut
                DegisitirilenEmlakTip = dr(36)
                lblKategori.Text += "Konut > "
                If dr("Satis_Turu_ID") Then lblKategori.Text += "Kiralık > " Else lblKategori.Text += "Satılık > "
                lblKategori.Text += dr("Konut_Tip")
            Case 1 ' işyeri
                DegisitirilenEmlakTip = dr("Isyeri_Tipi_ID")
                lblKategori.Text += "İşyeri > "
                If dr("Satis_Turu_ID") Then lblKategori.Text += "Kiralık > " Else lblKategori.Text += "Satılık > "
                lblKategori.Text += dr("Isyeri_Tipi")
            Case 2 ' arsa
                DegisitirilenEmlakTip = 255
                lblKategori.Text += "Arsa >"
                If dr("Satis_Turu_ID") Then lblKategori.Text += "Kiralık > " Else lblKategori.Text += "Satılık > "
            Case 3 ' bina
                DegisitirilenEmlakTip = 255
                lblKategori.Text += "Bina > "
                If dr("Satis_Turu_ID") Then lblKategori.Text += "Kiralık > " Else lblKategori.Text += "Satılık > "
            Case 4 ' Turistik Tesis
                DegisitirilenEmlakTip = dr(33)
                lblKategori.Text += "Turistik Tesis >"
                If dr("Satis_Turu_ID") Then lblKategori.Text += "Kiralık > " Else lblKategori.Text += "Satılık > "
                lblKategori.Text += dr("TT_Tip")
        End Select
        Dim bytearray() As Byte
        If dr(6) IsNot DBNull.Value Then
            bytearray = dr(6)
            foto1.Image = byteArrayToImage(bytearray)
            fotoSayisi += 1
        End If
        If dr(7) IsNot DBNull.Value Then
            bytearray = dr(7)
            foto2.Image = byteArrayToImage(bytearray)
            fotoSayisi += 1
        End If
        If dr(8) IsNot DBNull.Value Then
            bytearray = dr(8)
            foto3.Image = byteArrayToImage(bytearray)
            fotoSayisi += 1
        End If
        If dr(9) IsNot DBNull.Value Then
            bytearray = dr(9)
            foto4.Image = byteArrayToImage(bytearray)
            fotoSayisi += 1
        End If
        If dr(10) IsNot DBNull.Value Then
            bytearray = dr(10)
            foto5.Image = byteArrayToImage(bytearray)
            fotoSayisi += 1
        End If
        If dr(11) IsNot DBNull.Value Then
            bytearray = dr(11)
            foto6.Image = byteArrayToImage(bytearray)
            fotoSayisi += 1
        End If
        If dr(12) IsNot DBNull.Value Then
            bytearray = dr(12)
            foto7.Image = byteArrayToImage(bytearray)
            fotoSayisi += 1
        End If
        If dr(13) IsNot DBNull.Value Then
            bytearray = dr(13)
            foto8.Image = byteArrayToImage(bytearray)
            fotoSayisi += 1
        End If
        If dr(14) IsNot DBNull.Value Then
            AxWindowsMediaPlayer1.URL = dr(14)
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            CBVideo.Enabled = True
        End If
        Select Case gbxname
            Case "gbxABD"
                secilenGroupbox = gbxABD
                txtABD_aidat.Text = dr("aidat")
                txtABD_binaYas.Text = dr("Bina_Yasi")
                txtABD_m2.Text = dr("m2ORacik")
                txtABD_odaBolumSayi.Text = dr("oda_bolum_sayisi")
                If dr("Durumu") Then cbxABD_durum.Text = "İkinci El" Else cbxABD_durum.Text = "Sıfır"
                SQL.Tablo_Veri_Doldur("Isitma", cbxABD_isitma)
                cbxABD_isitma.Text = dr("Isitma")
                If dr("Satis_Turu_ID") Then
                    chkABD_kredi.Checked = dr("depozito")
                    lblABD_kredi.Text = "Depozito"
                Else
                    chkABD_kredi.Checked = dr("Krediye_Uygun")
                End If
                chkABD_takas.Checked = dr("Takasli")
            Case "gbxArsaDetay"
                secilenGroupbox = gbxArsaDetay
                SQL.Tablo_Veri_Doldur("imar_Durumu", cbxImarDurumu)
                cbxImarDurumu.Text = dr(30)
                SQL.Tablo_Veri_Doldur("Gabari", cbxGabari)
                cbxGabari.Text = dr(31)
                SQL.Tablo_Veri_Doldur("Kaks", cbxKaks)
                cbxKaks.Text = dr(32)
                SQL.Tablo_Veri_Doldur("Tapu_Durumu", cbxTapu)
                cbxTapu.Text = dr(33)
                txtArsaBuyukluk.Text = dr(18)
                txtParselNo.Text = dr(19)
                txtPaftaNo.Text = dr(20)
                txtAdaNo.Text = dr(21)
                chkArsaKatKarsiligi.Checked = dr(22)
                If dr("Satis_Turu_ID") Then
                    chkArsaKredi.Checked = dr("depozito")
                    lblArsaKredi.Text = "Depozito"
                Else
                    chkArsaKredi.Checked = dr("Krediye_Uygun")
                End If
                chkArsaTakas.Checked = dr(24)
            Case "gbxAVM"
                secilenGroupbox = gbxAVM
                txtAVM_asansorSayi.Text = dr("Asansor_Sayisi")
                txtAVM_binaYas.Text = dr("Bina_Yasi")
                txtAVM_katSayi.Text = dr("kat_Sayisi")
                txtAVM_m2.Text = dr("m2ORacik")
                If dr("Durumu") Then cbxAVM_durum.Text = "İkinci El" Else cbxAVM_durum.Text = "Sıfır"
                SQL.Tablo_Veri_Doldur("Isitma", cbxAVM_isitma)
                cbxAVM_isitma.Text = dr("Isitma")
                If dr("Satis_Turu_ID") Then
                    chkAVM_kredi.Checked = dr("depozito")
                    lblAVM_kredi.Text = "Depozito"
                Else
                    chkAVM_kredi.Checked = dr("Krediye_Uygun")
                End If
                chkAVM_takas.Checked = dr("Takasli")
            Case "gbxBinaDetay"
                secilenGroupbox = gbxBinaDetay
                txtBinaKatsayisi.Text = dr(21)
                txtBinaKatBasiDaireSayisi.Text = dr(19)
                SQL.Tablo_Veri_Doldur("Isitma", cbxBinaIsitma)
                cbxBinaIsitma.Text = dr(27)
                txtBinaBuyukluk.Text = dr(20)
                txtBinaBinaYasi.Text = dr(18)
                If dr("Satis_Turu_ID") Then
                    cbxBinaKrediUygun.Checked = dr("depozito")
                    lblBinaKredi.Text = "Depozito"
                Else
                    cbxBinaKrediUygun.Checked = dr("Krediye_Uygun")
                End If
                cbxBinaTakas.Checked = dr(23)
            Case "gbxBufe"
                secilenGroupbox = gbxBufe
                txtBufe_m2.Text = dr("m2ORacik")
                If dr("Durumu") Then cbxBufe_durum.Text = "İkinci El" Else cbxBufe_durum.Text = "Sıfır"
                SQL.Tablo_Veri_Doldur("Yapi_Tipi", cbxBufe_yapiTip)
                Select Case dr("Yapi_Tipi")
                    Case 0
                        cbxBufe_yapiTip.Text = "Ahşap"
                    Case 1
                        cbxBufe_yapiTip.Text = "Kütük"
                    Case 2
                        cbxBufe_yapiTip.Text = "Çelik"
                    Case 3
                        cbxBufe_yapiTip.Text = "Prefabrik"
                    Case 4
                        cbxBufe_yapiTip.Text = "Betonarme"
                End Select
                If dr("Satis_Turu_ID") Then
                    chkBufe_kredi.Checked = dr("depozito")
                    lblBufe_kredi.Text = "Depozito"
                Else
                    chkBufe_kredi.Checked = dr("Krediye_Uygun")
                End If
                chkBufe_kullanim.Checked = dr("Kullanim_Durumu")
            Case "gbxCiftlik"
                secilenGroupbox = gbxCiftlik
                txtCiftlik_m2acik.Text = dr("m2ORAcik")
                txtCiftlik_m2kapali.Text = dr("Kapali_Alan")
                If dr("Durumu") Then cbxCiftlik_durum.Text = "İkinci El" Else cbxCiftlik_durum.Text = "Sıfır"
                If dr("Satis_Turu_ID") Then
                    chkCiftlik_kredi.Checked = dr("depozito")
                    lblCiftlik_kredi.Text = "Depozito"
                Else
                    chkCiftlik_kredi.Checked = dr("Krediye_Uygun")
                End If
            Case "gbxDepo"
                secilenGroupbox = gbxDepo
                txtDepo_binaYas.Text = dr("Bina_Yasi")
                txtDepo_giris.Text = dr("Giris_yukseklik")
                txtDepo_m2.Text = dr("m2ORacik")
                If dr("Durumu") Then cbxDepo_durum.Text = "İkinci El" Else cbxDepo_durum.Text = "Sıfır"
                SQL.Tablo_Veri_Doldur("Isitma", cbxDepo_isitma)
                cbxDepo_isitma.Text = dr("Isitma")
                SQL.Tablo_Veri_Doldur("Depo_Tapu_Durumu", cbxDepo_tapu)
                Select Case dr("Tapu_Durumu")
                    Case 0
                        cbxDepo_tapu.Text = "Arsa Tapusu"
                    Case 1
                        cbxDepo_tapu.Text = "Kat İrtifaklı Tapu"
                    Case 2
                        cbxDepo_tapu.Text = "Kat Mülkiyetli Tapu"
                End Select
                If dr("Satis_Turu_ID") Then
                    chkDepo_kredi.Checked = dr("depozito")
                    lblDepo_kredi.Text = "Depozito"
                Else
                    chkDepo_kredi.Checked = dr("Krediye_Uygun")
                End If
                chkDepo_kullanim.Checked = dr("Kullanim_Durumu")
                chkDepo_takas.Checked = dr("Takasli")
                chkDepo_zeminEtudu.Checked = dr("Zemin_Etudu")
            Case "gbxDugun"
                secilenGroupbox = gbxDugun
                txtDugun_binaYas.Text = dr("Bina_Yasi")
                txtDugun_kisiKapasitesi.Text = dr("Kisi_kapasitesi")
                txtDugun_m2.Text = dr("m2ORacik")
                txtDugun_masaSayi.Text = dr("Masa_Sayisi")
            Case "gbxFabrika"
                secilenGroupbox = gbxFabrika
                txtFabrika_binaAdet.Text = dr("Bina_Adedi")
                txtFabrika_binaYas.Text = dr("Bina_Yasi")
                txtFabrika_giris.Text = dr("Giris_yukseklik")
                txtFabrika_katSayi.Text = dr("Kat_Sayisi")
                txtFabrika_m2acik.Text = dr("m2ORacik")
                txtFabrika_m2kapali.Text = dr("Kapali_Alan")
                txtFabrika_odaBolumSayi.Text = dr("Oda_Bolum_Sayisi")
                If dr("Durumu") Then cbxFabrika_durum.Text = "İkinci El" Else cbxFabrika_durum.Text = "Sıfır"
                SQL.Tablo_Veri_Doldur("Isitma", cbxFabrika_isitma)
                cbxFabrika_isitma.Text = dr("Isitma")
                SQL.Tablo_Veri_Doldur("Depo_Tapu_Durumu", cbxFabrika_tapu)
                Select Case dr("Tapu_Durumu")
                    Case 0
                        cbxFabrika_tapu.Text = "Arsa Tapusu"
                    Case 1
                        cbxFabrika_tapu.Text = "Kat İrtifaklı Tapu"
                    Case 2
                        cbxFabrika_tapu.Text = "Kat Mülkiyetli Tapu"
                End Select
                If dr("Satis_Turu_ID") Then
                    chkFabrika_kredi.Checked = dr("depozito")
                    lblFabrika_kredi.Text = "Depozito"
                Else
                    chkFabrika_kredi.Checked = dr("Krediye_Uygun")
                End If
                chkFabrika_kullanim.Checked = dr("Kullanim_Durumu")
                chkFabrika_takas.Checked = dr("Takasli")
                chkFabrika_zeminEtudu.Checked = dr("Zemin_Etudu")
            Case "gbxImalat"
                secilenGroupbox = gbxImalat
                txtIMA_binaYas.Text = dr("Bina_Yasi")
                txtIMA_m2.Text = dr("m2ORacik")
                txtIMA_odaBolumSayi.Text = dr("Oda_Bolum_Sayisi")
                If dr("Durumu") Then cbxIMA_durum.Text = "İkinci El" Else cbxIMA_durum.Text = "Sıfır"
                SQL.Tablo_Veri_Doldur("Isitma", cbxIMA_isitma)
                cbxIMA_isitma.Text = dr("Isitma")
                If dr("Satis_Turu_ID") Then
                    chkIMA_kredi.Checked = dr("depozito")
                    lblIMA_kredi.Text = "Depozito"
                Else
                    chkIMA_kredi.Checked = dr("Krediye_Uygun")
                End If
                chkIMA_takas.Checked = dr("Takasli")
            Case "gbxKBina"
                secilenGroupbox = gbxKBina
                txtKBina_binaYas.Text = dr("Bina_Yasi")
                txtKBina_katSayi.Text = dr("Kat_Sayisi")
                txtKBina_m2.Text = dr("m2ORacik")
                If dr("Durumu") Then cbxKBina_durum.Text = "İkinci El" Else cbxKBina_durum.Text = "Sıfır"
                SQL.Tablo_Veri_Doldur("Isitma", cbxKBina_isitma)
                cbxKBina_isitma.Text = dr("Isitma")
                SQL.Tablo_Veri_Doldur("Depo_Tapu_Durumu", cbxKBina_tapu)
                Select Case dr("Tapu_Durumu")
                    Case 0
                        cbxKBina_tapu.Text = "Arsa Tapusu"
                    Case 1
                        cbxKBina_tapu.Text = "Kat İrtifaklı Tapu"
                    Case 2
                        cbxKBina_tapu.Text = "Kat Mülkiyetli Tapu"
                End Select
                SQL.Tablo_Veri_Doldur("Bina_Tipi", cbxKBina_binaTip)
                Select Case dr("Bina_Tipi_ID")
                    Case 0
                        cbxKBina_binaTip.Text = "Apartman"
                    Case 1
                        cbxKBina_binaTip.Text = "Plaza"
                    Case 2
                        cbxKBina_binaTip.Text = "İş Hanı"
                    Case 3
                        cbxKBina_binaTip.Text = "Müstakil"
                    Case 4
                        cbxKBina_binaTip.Text = "Villa"
                End Select
                If dr("Satis_Turu_ID") Then
                    chkKBina_kredi.Checked = dr("depozito")
                    lblKBina_kredi.Text = "Depozito"
                Else
                    chkKBina_kredi.Checked = dr("Krediye_Uygun")
                End If
                chkKBina_kullanim.Checked = dr("Kullanim_Durumu")
                chkKBina_zeminEtudu.Checked = dr("Zemin_Etudu")
            Case "gbxKonutDetay"
                secilenGroupbox = gbxKonutDetay
                txtKonutBuyukluk.Text = dr(18)
                txtBinaYasi.Text = dr(20)
                txtKatSayisi.Text = dr(21)
                txtBanyoSayisi.Text = dr(22)
                txtAidat.Text = dr(26)
                SQL.Tablo_Veri_Doldur("Oda_Sayisi", cbxOdaSayisi)
                cbxOdaSayisi.Text = dr(32)
                SQL.Tablo_Veri_Doldur("Isitma", cbxIsitma)
                cbxIsitma.Text = dr(34)
                SQL.Tablo_Veri_Doldur("Bulundugu_Kat", cbxBulunduKat)
                cbxBulunduKat.Text = dr(33)
                chkSiteIceri.Checked = dr(25)
                chkEsyali.Checked = dr(23)
                chkKonutKullanim.Checked = dr(24)
                If dr("Satis_Turu_ID") Then
                    chkKonutKredi.Checked = dr("depozito")
                    lblKonutKredi.Text = "Depozito"
                Else
                    chkKonutKredi.Checked = dr("Krediye_Uygun")
                End If
                chkKonutTakas.Checked = dr(28)
            Case "gbxOtopark"
                secilenGroupbox = gbxOtopark
                txtOto_aracKapasitesi.Text = dr("Arac_Sayisi")
                txtOto_binaYas.Text = dr("Bina_Yasi")
                txtOto_katSayi.Text = dr("Kat_Sayisi")
                txtOto_m2.Text = dr("m2ORacik")
                SQL.Tablo_Veri_Doldur("Otopark_Turu", cbxOto_tur)
                Select Case dr("Otopark_Turu")
                    Case 0
                        cbxOto_tur.Text = "Açık"
                    Case 1
                        cbxOto_tur.Text = "Kapalı"
                    Case 2
                        cbxOto_tur.Text = "Hepsi"
                End Select
                If dr("Satis_Turu_ID") Then
                    chkOto_kredi.Checked = dr("depozito")
                    lblOto_kredi.Text = "Depozito"
                Else
                    chkOto_kredi.Checked = dr("Krediye_Uygun")
                End If
            Case "gbxPazar"
                secilenGroupbox = gbxPazar
                txtPazar_m2.Text = dr("m2ORacik")
                chkPazar_takas.Checked = dr("Takasli")
            Case "gbxPlaza"
                secilenGroupbox = gbxPlaza
                txtPlaza_aidat.Text = dr("aidat")
                txtPlaza_binaYas.Text = dr("Bina_Yasi")
                txtPlaza_katSayi.Text = dr("Kat_Sayisi")
                txtPlaza_m2.Text = dr("m2ORacik")
                txtPlaza_odaBolumSayi.Text = dr("Oda_Bolum_Sayisi")
                SQL.Tablo_Veri_Doldur("Bulundugu_Kat", cbxPlaza_bulunduguKat)
                cbxPlaza_bulunduguKat.Text = SQL.BulundugKatString(dr("Bulundugu_Kat"))
                If dr("Durumu") Then cbxPlaza_durum.Text = "İkinci El" Else cbxPlaza_durum.Text = "Sıfır"
                SQL.Tablo_Veri_Doldur("Isitma", cbxPlaza_isitma)
                cbxPlaza_isitma.Text = dr("Isitma")
                SQL.Tablo_Veri_Doldur("Depo_Tapu_Durumu", cbxPlaza_tapu)
                Select Case dr("Tapu_Durumu")
                    Case 0
                        cbxPlaza_tapu.Text = "Arsa Tapusu"
                    Case 1
                        cbxPlaza_tapu.Text = "Kat İrtifaklı Tapu"
                    Case 2
                        cbxPlaza_tapu.Text = "Kat Mülkiyetli Tapu"
                End Select
                If dr("Satis_Turu_ID") Then
                    chkPlaza_kredi.Checked = dr("depozito")
                    lblPlaza_kredi.Text = "Depozito"
                Else
                    chkPlaza_kredi.Checked = dr("Krediye_Uygun")
                End If
                chkPlaza_kullanim.Checked = dr("Kullanim_Durumu")
                chkPlaza_takas.Checked = dr("Takasli")
                chkPlaza_zeminEtudu.Checked = dr("Zemin_Etudu")
            Case "gbxRadyo"
                secilenGroupbox = gbxRadyo
                txtRadyo_m2.Text = dr("m2ORacik")
                SQL.Tablo_Veri_Doldur("Isitma", cbxRadyo_Isitma)
                cbxRadyo_Isitma.Text = SQL.IsitmaString(dr("Isitma_ID"))
                If dr("Satis_Turu_ID") Then
                    ChkRadyo_Kredi.Checked = dr("depozito")
                    lblRadyo_kredi.Text = "Depozito"
                Else
                    ChkRadyo_Kredi.Checked = dr("Krediye_Uygun")
                End If
                ChkRadyo_Takasli.Checked = dr("Takasli")
            Case "gbxSinema"
                secilenGroupbox = gbxSinema
                txtSinema_binaYas.Text = dr("Bina_Yasi")
                txtSinema_katSayi.Text = dr("Kat_Sayisi")
                txtSinema_m2.Text = dr("m2ORacik")
                txtSinema_odaBolumSayi.Text = dr("Oda_Bolum_Sayisi")
                txtSinema_kisiKapasitesi.Text = dr("Kisi_kapasitesi")
                txtSinema_tavan.Text = dr("Tavan_Yuksekligi")
                SQL.Tablo_Veri_Doldur("Bulundugu_Kat", cbxSinema_bulunduguKat)
                cbxSinema_bulunduguKat.Text = dr("Bulundugu_Kat")
                If dr("Durumu") Then cbxSinema_durum.Text = "İkinci El" Else cbxSinema_durum.Text = "Sıfır"
                SQL.Tablo_Veri_Doldur("Isitma", cbxSinema_isitma)

                cbxSinema_isitma.Text = SQL.IsitmaString(dr("Isitma_ID"))
                If dr("Satis_Turu_ID") Then
                    chkSinema_kredi.Checked = dr("depozito")
                    lblSinema_kredi.Text = "Depozito"
                Else
                    chkSinema_kredi.Checked = dr("Krediye_Uygun")
                End If
                chkSinema_kullanim.Checked = dr("Kullanim_Durumu")
                chkSinema_takas.Checked = dr("Takasli")
            Case "gbxSpa"
                txtSpa_binaYas.Text = dr("Bina_Yasi")
                txtSpa_m2.Text = dr("m2ORacik")
                txtSpa_odaBolumSayi.Text = dr("Oda_Bolum_Sayisi")
                txtSpa_kisiKapasitesi.Text = dr("Kisi_kapasitesi")
                If dr("Durumu") Then cbxSpa_durum.Text = "İkinci El" Else cbxSpa_durum.Text = "Sıfır"
                Select Case dr("Cinsiyet")
                    Case 0
                        cbxSpa_cinsiyet.Text = "Erkek"
                    Case 1
                        cbxSpa_cinsiyet.Text = "Bayan"
                    Case 2
                        cbxSpa_cinsiyet.Text = "Unisex"
                End Select
                If dr("Krediye_Uygun") IsNot DBNull.Value Then
                    chkSpa_kredi.Checked = dr("Krediye_Uygun")
                Else
                    chkSpa_kredi.Checked = dr("Depozito")
                    lblSpa_kredi.Text = "Depozito"
                End If
                chkSpa_kullanim.Checked = dr("Kullanim_Durumu")
                SQL.Tablo_Veri_Doldur("Cinsiyet", cbxSpa_cinsiyet)
                Select Case dr("Cinsiyet")
                    Case 0
                        cbxSpa_cinsiyet.Text = "Erkek"
                    Case 1
                        cbxSpa_cinsiyet.Text = "Bayan"
                    Case 2
                        cbxSpa_cinsiyet.Text = "Unisex"
                End Select
            Case "gbxSpor"
                txtSpor_binaYas.Text = dr("Bina_Yasi")
                txtSpor_m2.Text = dr("m2ORacik")
                If dr("Durumu") Then cbxSpor_durum.Text = "İkinci El" Else cbxSpor_durum.Text = "Sıfır"
                SQL.Tablo_Veri_Doldur("SporTesis_Turu", cbxSpor_tip)
                Select Case dr("SporTesis_Tipi")
                    Case 0
                        cbxSpor_tip.Text = "Komple Tesis"
                    Case 1
                        cbxSpor_tip.Text = "Spor Salonu"
                    Case 2
                        cbxSpor_tip.Text = "Yarış Pisti"
                    Case 3
                        cbxSpor_tip.Text = "Halı & Çim Saha"
                End Select
                If dr("Satis_Turu_ID") Then
                    chkSpor_kredi.Checked = dr("depozito")
                    lblSpor_kredi.Text = "Depozito"
                Else
                    chkSpor_kredi.Checked = dr("Krediye_Uygun")
                End If
                chkSpor_kullanim.Checked = dr("Kullanim_Durumu")
            Case "gbxTuristikTesis"
                secilenGroupbox = gbxTuristikTesis
                turistikSifirla()
                Select Case dr("TT_Tip")
                    Case "Otel", "Tatil Köyü"
                        lblTuristik_yildizSayi.Visible = True
                        txtTuristik_yildizSayi.Visible = True
                        txtTuristik_yildizSayi.Text = dr(18)
                        TTVeriDoldur(dr)
                    Case "Apart Otel"
                        lblTuristik_apartSayi.Visible = True
                        txtTuristik_apartSayi.Visible = True
                        txtTuristik_apartSayi.Text = dr(19)
                        TTVeriDoldur(dr)
                    Case "Butik Otel", "Motel", "Pansiyon"
                        TTVeriDoldur(dr)
                    Case "Kamp Yeri"
                        lblTuristik_topArazi.Visible = True
                        txtTuristik_topArazi.Visible = True
                        txtTuristik_topArazi.Text = dr("Kapali_Alan")
                    Case "Plaj"
                        lblTuristik_m2.Visible = True
                        txtTuristik_m2.Visible = True
                        lblTuristik_kapasite.Visible = True
                        txtTuristik_kapasite.Visible = True
                        txtTuristik_m2.Text = dr("Kapali_Alan")
                        txtTuristik_kapasite.Text = dr("yatak_Sayisi")
                End Select
        End Select
        DegistirilenSatisTur = dr("Satis_Turu_ID")
        txtIlanBasligi.Text = dr(2)
        txtAciklama.Text = dr(1)
        txtFiyat.Text = dr(16)

        Dim iller(82) As String
        SQL.Tablo_Veri_Doldur("Sehirler", iller)
        For index As Integer = 81 To 0 Step -1
            cbxIl.Items.Add(iller(index))
        Next
        cbxIl.Text = dr("SehirAdi")
        SQL.ilce_Doldur(ilce, 82 - cbxIl.SelectedIndex)
        For i As Integer = 0 To ilce.Length
            If ilce(i, 1) = Nothing Then Exit For
            cbxIlce.Items.Add(ilce(i, 1))
        Next
        cbxIlce.Text = dr("ilceAdi")
        For i As Integer = 0 To ilce.Length
            If ilce(i, 1) = Nothing Then Exit For
            If ilce(i, 1) = cbxIlce.SelectedItem Then
                SQL.semtMah_Doldur(cbxMahalle, ilce(i, 0))
                Exit For
            End If
        Next
        cbxMahalle.Text = dr("MahalleAdi")
        dt = SQL.EmlakSahipTablosu(dr(4))
        txtAdres.Text = dr(15)

        txtAd.Text = dt.Rows(0)(1).ToString.Split(",")(0)
        txtSoyad.Text = dt.Rows(0)(1).ToString.Split(",")(1)
        txtCepTel.Text = dt.Rows(0)(2)
        txtEvTel.Text = dt.Rows(0)(3)
        txtEmail.Text = dt.Rows(0)(4)
    End Sub

    Private Sub TTVeriDoldur(dr As DataRow)
        turistikOtelDuzenle()
        txtTuristik_odaSayi.Text = dr(20)
        txtTuristik_yatakSayi.Text = dr(21)
        txtTuristik_katSayi.Text = dr(22)
        txtTuristik_binaYas.Text = dr(23)
        txtTuristik_m2acik.Text = dr(24)
        txtTuristik_m2kapali.Text = dr(25)
        chkTuristik_zeminEtudu.Checked = dr(26)
        chkTuristik_kredi.Checked = dr(28)
        If dr(27) Then cbxTuristik_yapiDurum.Text = "İkinci El" Else cbxTuristik_yapiDurum.Text = "Sıfır"
    End Sub

    Private Sub lstBx_emlakDuzenle()
        listSatis.Items.Clear()
        listSatis.Items.Add("Satılık")
        listSatis.Items.Add("Kiralık")

        listSatis.Visible = True
        listEmlakTip.Visible = False
        lblSecilenKategori.Text = "Kategori  :   Emlak > " & listEmlak.SelectedItem
    End Sub
    Private Sub lstBx_SatisDuzenle()
        listEmlakTip.Items.Clear()
        Dim emlak(50) As String
        Dim sqle As New SqlEmlak()
        listEmlakTip.Visible = True
        Select Case listEmlak.SelectedIndex
            Case 0
                sqle.Tablo_Veri_Doldur("Konut_Tip", emlak)
                If listSatis.SelectedIndex = 0 Then
                    For Each tip As String In emlak
                        If tip = Nothing Then Exit For
                        listEmlakTip.Items.Add(tip)
                    Next
                ElseIf listSatis.SelectedIndex = 1 Or listSatis.SelectedIndex = 2 Then
                    For i As Integer = 0 To emlak.Count - 3
                        If emlak(i) = Nothing Then Exit For
                        listEmlakTip.Items.Add(emlak(i))
                    Next
                Else
                    listEmlakTip.Items.Add(emlak(0))
                    listEmlakTip.Items.Add(emlak(1))
                End If
            Case 1
                sqle.Tablo_Veri_Doldur("Isyeri_Tipi", emlak)
                For i As Integer = 0 To emlak.Count
                    If emlak(i) = Nothing Then Exit For
                    listEmlakTip.Items.Add(emlak(i))
                Next
            Case 4
                sqle.Tablo_Veri_Doldur("TT_Tip", emlak)
                For Each tip As String In emlak
                    If tip = Nothing Then : Exit For
                    End If
                    listEmlakTip.Items.Add(tip)
                Next
            Case 2, 3
                listEmlakTip.Visible = False
                btn_ileri.Visible = True
        End Select
        lblSecilenKategori.Text = "Kategori  :   Emlak > " & listEmlak.SelectedItem & " > " & listSatis.SelectedItem
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listEmlak.SelectedIndexChanged
        btn_ileri.Visible = False
        If listEmlak.SelectedIndex <> -1 Then lstBx_emlakDuzenle()
    End Sub
    Private Sub lstBx_Satis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listSatis.SelectedIndexChanged
        btn_ileri.Visible = False
        If listSatis.SelectedIndex = 1 Then
            lblArsaKredi.Text = "Depozito"
            lblKonutKredi.Text = "Depozito"
            lblBinaKredi.Text = "Depozito"
        Else
            lblArsaKredi.Text = "Krediye Uygun"
            lblKonutKredi.Text = "Krediye Uygun"
            lblBinaKredi.Text = "Krediye Uygun"
        End If
        If listSatis.SelectedIndex <> -1 Then lstBx_SatisDuzenle()
    End Sub
    Private Sub lstBx_EmlakTip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listEmlakTip.SelectedIndexChanged
        btn_ileri.Visible = True
        If listEmlakTip.SelectedIndex <> -1 Then
            btn_ileri.Visible = True
            lblSecilenKategori.Text = "Kategori  :   Emlak > " & listEmlak.SelectedItem & " > " & listSatis.SelectedItem & " > " & listEmlakTip.SelectedItem
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emlakTurleri.Add(0, "Konut")
        emlakTurleri.Add(1, "Isyerleri")
        emlakTurleri.Add(2, "Arsa")
        emlakTurleri.Add(3, "Bina")
        emlakTurleri.Add(4, "Turistik_Tesis")
        If degistirmekİcinCagrildi = False Then
            emptyMaskedTextBox = txtEvTel.Text
            geriIleri(1)
        End If
    End Sub
    Private Sub btn_ileri_Click(sender As Object, e As EventArgs) Handles btn_ileri.Click
        If degistirmekİcinCagrildi = True Then
            If btn_ileri.Text <> "Kaydet" Then
                If Kontrol.GerekliAlanKontrolu(gbxIlanDetayi) Then
                    If Kontrol.GerekliAlanKontrolu(gbxIletisim) Then
                        If Kontrol.GerekliAlanKontrolu(gbxAdresBilgi) Then
                            If txtAd.Text.Length + txtSoyad.Text.Length > 39 Then
                                MsgBox("İsim uzunluğunuz sınırı aşmıştır. Lütfen isim uzunluğu en fazla 39 olacak şekilde değiştiriniz.", MsgBoxStyle.Exclamation, "Limit Aşma Hatası")
                            Else
                                btn_ileri.Text = "Kaydet"
                                pnlIlanOzellikleri.Visible = True
                                pnlilanDetayi.Visible = False
                                btn_geri.Text = "Diğer"
                            End If
                        Else
                                MsgBox("Lütfen adres bilgileri alanındaki eksik bilgileri doldurunuz", MsgBoxStyle.Exclamation, "Eksik Bilgi Hatası")
                        End If
                    Else
                        MsgBox("Lütfen iletişim bilgileri alanındaki eksik bilgileri doldurunuz", MsgBoxStyle.Exclamation, "Eksik Bilgi Hatası")
                    End If
                Else
                    MsgBox("Lütfen ilan detayı alanındaki eksik bilgileri doldurunuz", MsgBoxStyle.Exclamation, "Eksik Bilgi Hatası")
                End If
            Else
                If Kontrol.GerekliAlanKontrolu(secilenGroupbox) Then
                    DegerleriAl(DegistirilenEmlakTur, DegistirilenSatisTur, DegisitirilenEmlakTip)
                Else
                    MsgBox("Bilgilerinizi Kontrol Ediniz", MsgBoxStyle.Exclamation, "Eksik Bilgi Hatası")
                End If
            End If
        Else
            If adim < 4 Then
                adim += 1
                geriIleri(adim)
            End If
        End If
    End Sub
    Private Sub gbxSifirla()
        gbxABD.Visible = False
        gbxArsaDetay.Visible = False
        gbxAVM.Visible = False
        gbxBinaDetay.Visible = False
        gbxBufe.Visible = False
        gbxCiftlik.Visible = False
        gbxDepo.Visible = False
        gbxDugun.Visible = False
        gbxFabrika.Visible = False
        gbxImalat.Visible = False
        gbxKBina.Visible = False
        gbxKonutDetay.Visible = False
        gbxOtopark.Visible = False
        gbxPazar.Visible = False
        gbxPlaza.Visible = False
        gbxRadyo.Visible = False
        gbxSinema.Visible = False
        gbxSpa.Visible = False
        gbxSpor.Visible = False
        gbxTuristikTesis.Visible = False
    End Sub

    Private Sub geriIleri(ByVal sayfa As Integer)
        Select Case sayfa
            Case 0
                Dim giris As New frm_Giris
                Me.Hide()
                giris.ShowDialog()
                Me.Close()
            Case 1
                SQL.IlanSahipleriniOku(cbxMevcutKisi)
                dt = SQL.EmlakSahipTablosu()

                pnlilanDetayi.Visible = False
                pnlIlanOzellikleri.Visible = False
                pnlBasari.Visible = False
                pnlKategori.Visible = True

                btnProg1.Image = My.Resources.step1
                btnProg1.Visible = True
                btnProg3.Visible = False
                btnProg2.Visible = False

                btn_geri.Text = "Ana Sayfa"
            Case 2

                Dim sql As New SqlEmlak()
                pnlKategori.Visible = False
                pnlIlanOzellikleri.Visible = False
                pnlBasari.Visible = False
                pnlilanDetayi.Visible = True

                btn_geri.Text = "Geri"
                btnProg1.Image = My.Resources.Checkmark3
                btnProg2.Image = My.Resources.step2
                btnProg1.Visible = True
                btnProg2.Visible = True
                btnProg3.Visible = False
                lblKategori.Text = lblSecilenKategori.Text

                Dim iller(82) As String
                sql.Tablo_Veri_Doldur("Sehirler", iller)
                For index As Integer = 81 To 0 Step -1
                    cbxIl.Items.Add(iller(index))
                Next
            Case 3
                If Kontrol.GerekliAlanKontrolu(gbxIlanDetayi) Then
                    If Kontrol.GerekliAlanKontrolu(gbxIletisim) Then
                        If Kontrol.GerekliAlanKontrolu(gbxAdresBilgi) Then
                            If txtAd.Text.Length + txtSoyad.Text.Length > 39 Then
                                adim -= 1
                                MsgBox("İsim uzunluğunuz sınırı aşmıştır. Lütfen isim uzunluğu en fazla 39 olacak şekilde değiştiriniz.", MsgBoxStyle.Exclamation, "Limit Aşma Hatası")
                            Else
                                pnlilanDetayi.Visible = False
                                pnlKategori.Visible = False
                                pnlBasari.Visible = False
                                pnlIlanOzellikleri.Visible = True

                                gbxSifirla()

                                btn_geri.Text = "Geri"
                                btnProg1.Image = My.Resources.Checkmark3
                                btnProg2.Image = My.Resources.Checkmark3
                                btnProg3.Image = My.Resources.step3
                                btnProg1.Visible = True
                                btnProg3.Visible = True
                                btnProg2.Visible = True
                                gbxduzenle()
                            End If
                        Else
                            adim -= 1
                            MsgBox("Lütfen adres bilgileri alanındaki eksik bilgileri doldurunuz", MsgBoxStyle.Exclamation, "Eksik Bilgi Hatası")
                        End If
                    Else
                        adim -= 1
                        MsgBox("Lütfen iletişim bilgileri alanındaki eksik bilgileri doldurunuz", MsgBoxStyle.Exclamation, "Eksik Bilgi Hatası")
                    End If
                Else
                    adim -= 1
                    MsgBox("Lütfen ilan detayı alanındaki eksik bilgileri doldurunuz", MsgBoxStyle.Exclamation, "Eksik Bilgi Hatası")
                End If

            Case 4
                If Kontrol.GerekliAlanKontrolu(secilenGroupbox) Then

                    If listEmlakTip.SelectedIndex <> -1 Then DegerleriAl(listEmlak.SelectedIndex, listSatis.SelectedIndex, listEmlakTip.SelectedIndex) Else DegerleriAl(listEmlak.SelectedIndex, listSatis.SelectedIndex)

                    pnlKategori.Visible = False
                    pnlilanDetayi.Visible = False
                    pnlIlanOzellikleri.Visible = False
                    pnlProgress.Visible = False
                    btn_geri.Visible = False
                    btn_ileri.Visible = False
                    pnlBasari.Visible = True
                    btnYeniDetayEkle.BringToFront()
                Else
                    adim -= 1
                    MsgBox("Bilgilerinizi Kontrol Ediniz", MsgBoxStyle.Exclamation, "Eksik Bilgi Hatası")
                End If
        End Select
    End Sub
    Private Sub gbxduzenle()
        Select Case listEmlak.SelectedIndex
            Case 0 'Konut
                secilenGroupbox = gbxKonutDetay
                SQL.Tablo_Veri_Doldur("Oda_Sayisi", cbxOdaSayisi)
                SQL.Tablo_Veri_Doldur("Isitma", cbxIsitma)
                SQL.Tablo_Veri_Doldur("Bulundugu_Kat", cbxBulunduKat)
                gbxKonutDetay.Visible = True
                If listEmlakTip.SelectedItem = "Çiftlik Evi" Or
                   listEmlakTip.SelectedItem = "Kösk ve Konak" Or
                   listEmlakTip.SelectedItem = "Yali" Then
                    lblKonut_acikAlanM2.Visible = True
                    txtKonut_acikAlanM2.Visible = True
                    pnlKonut.Location = New Point(pnlKonut.Location.X, 70)
                    pnlKonut.Size = New Size(468, 375)
                Else
                    lblKonut_acikAlanM2.Visible = False
                    txtKonut_acikAlanM2.Visible = False
                    pnlKonut.Location = New Point(pnlKonut.Location.X, 40)
                    pnlKonut.Size = New Size(468, 405)
                End If
            Case 1 'İşyeri
                Select Case listEmlakTip.SelectedIndex
                    Case 0, 3, 7 'Atölye, Büro, Dükkan
                        secilenGroupbox = gbxABD
                        If listSatis.SelectedIndex = 1 Then : lblABD_kredi.Text = "Depozito"
                        Else : lblABD_kredi.Text = "Krediye Uygun"
                        End If
                        gbxABD.Text = listEmlakTip.SelectedItem + " Detayı"
                        SQL.Tablo_Veri_Doldur("Isitma", cbxABD_isitma)
                        gbxABD.Visible = True
                    Case 1 'AVM
                        secilenGroupbox = gbxAVM
                        If listSatis.SelectedIndex = 1 Then : lblAVM_kredi.Text = "Depozito"
                        Else : lblAVM_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("Isitma", cbxAVM_isitma)
                        gbxAVM.Visible = True
                    Case 2 'Büfe
                        secilenGroupbox = gbxBufe
                        If listSatis.SelectedIndex = 1 Then : lblBufe_kredi.Text = "Depozito"
                        Else : lblBufe_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("Yapi_Tipi", cbxBufe_yapiTip)
                        gbxBufe.Visible = True
                    Case 4 'Çiftlik
                        secilenGroupbox = gbxCiftlik
                        If listSatis.SelectedIndex = 1 Then : lblCiftlik_kredi.Text = "Depozito"
                        Else : lblCiftlik_kredi.Text = "Krediye Uygun"
                        End If
                        gbxCiftlik.Visible = True
                    Case 5 'Depo & Antrepo
                        secilenGroupbox = gbxDepo
                        If listSatis.SelectedIndex = 1 Then : lblDepo_kredi.Text = "Depozito"
                        Else : lblDepo_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("Isitma", cbxDepo_isitma)
                        SQL.Tablo_Veri_Doldur("Depo_Tapu_Durumu", cbxDepo_tapu)
                        gbxDepo.Visible = True
                    Case 6 'Düğün Salonu
                        secilenGroupbox = gbxDugun
                        gbxDugun.Visible = True
                    Case 8 'Fabrika
                        secilenGroupbox = gbxFabrika
                        SQL.Tablo_Veri_Doldur("Depo_Tapu_Durumu", cbxFabrika_tapu)
                        If listSatis.SelectedIndex = 1 Then : lblFabrika_kredi.Text = "Depozito"
                        Else : lblFabrika_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("Isitma", cbxFabrika_isitma)
                        gbxFabrika.Visible = True
                    Case 9 'İmalathane
                        secilenGroupbox = gbxImalat
                        If listSatis.SelectedIndex = 1 Then : lblIMA_kredi.Text = "Depozito"
                        Else : lblIMA_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("Isitma", cbxIMA_isitma)
                        gbxImalat.Visible = True
                    Case 10 'Kompe Bina
                        secilenGroupbox = gbxKBina
                        If listSatis.SelectedIndex = 1 Then : lblKBina_kredi.Text = "Depozito"
                        Else : lblKBina_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("Isitma", cbxKBina_isitma)
                        SQL.Tablo_Veri_Doldur("Bina_Tipi", cbxKBina_binaTip)
                        SQL.Tablo_Veri_Doldur("Depo_Tapu_Durumu", cbxKBina_tapu)
                        gbxKBina.Visible = True
                    Case 11 'Otopark
                        secilenGroupbox = gbxOtopark
                        If listSatis.SelectedIndex = 1 Then : lblOto_kredi.Text = "Depozito"
                        Else : lblOto_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("Otopark_Turu", cbxOto_tur)
                        gbxOtopark.Visible = True
                    Case 12 'Pazar Yeri
                        secilenGroupbox = gbxPazar
                        gbxPazar.Visible = True
                    Case 13 'Plaka Katı
                        secilenGroupbox = gbxPlaza
                        If listSatis.SelectedIndex = 1 Then : lblPlaza_kredi.Text = "Depozito"
                        Else : lblPlaza_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("Isitma", cbxPlaza_isitma)
                        SQL.Tablo_Veri_Doldur("Bulundugu_Kat", cbxPlaza_bulunduguKat)
                        SQL.Tablo_Veri_Doldur("Depo_Tapu_Durumu", cbxPlaza_tapu)
                        gbxPlaza.Visible = True
                    Case 14 'Radyo İstasyonu
                        secilenGroupbox = gbxRadyo
                        If listSatis.SelectedIndex = 1 Then : lblRadyo_kredi.Text = "Depozito"
                        Else : lblRadyo_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("Isitma", cbxRadyo_Isitma)
                        gbxRadyo.Visible = True
                    Case 15 'Sinema
                        secilenGroupbox = gbxSinema
                        If listSatis.SelectedIndex = 1 Then : lblSinema_kredi.Text = "Depozito"
                        Else : lblSinema_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("Isitma", cbxSinema_isitma)
                        SQL.Tablo_Veri_Doldur("Bulundugu_Kat", cbxSinema_bulunduguKat)
                        gbxSinema.Visible = True
                    Case 16 'Spa, Hamam, Sauna
                        secilenGroupbox = gbxSpa
                        If listSatis.SelectedIndex = 1 Then : lblSpa_kredi.Text = "Depozito"
                        Else : lblSpa_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("Cinsiyet", cbxSpa_cinsiyet)
                        gbxSpa.Visible = True
                    Case 17 'Spor Tesisi
                        secilenGroupbox = gbxSpor
                        If listSatis.SelectedIndex = 1 Then : lblSpor_kredi.Text = "Depozito"
                        Else : lblSpor_kredi.Text = "Krediye Uygun"
                        End If
                        SQL.Tablo_Veri_Doldur("SporTesis_Turu", cbxSpor_tip)
                        gbxSpor.Visible = True
                End Select
            Case 2 'Arsa
                secilenGroupbox = gbxArsaDetay
                SQL.Tablo_Veri_Doldur("imar_Durumu", cbxImarDurumu)
                SQL.Tablo_Veri_Doldur("Gabari", cbxGabari)
                SQL.Tablo_Veri_Doldur("Kaks", cbxKaks)
                SQL.Tablo_Veri_Doldur("Tapu_Durumu", cbxTapu)
                gbxArsaDetay.Visible = True
            Case 3 'Bina
                secilenGroupbox = gbxBinaDetay
                SQL.Tablo_Veri_Doldur("Isitma", cbxBinaIsitma)
                gbxBinaDetay.Visible = True
            Case 4 'Turistik Tesis
                secilenGroupbox = gbxTuristikTesis
                turistikSifirla()
                If listSatis.SelectedIndex = 1 Then : lblTuristik_kredi.Text = "Depozito"
                Else : lblTuristik_kredi.Text = "Krediye Uygun"
                End If
                gbxTuristikTesis.Text = listEmlakTip.SelectedItem + " Detayı"
                Select Case listEmlakTip.SelectedIndex
                    Case 0, 6 'Otel, Tatil Köyü
                        lblTuristik_yildizSayi.Visible = True
                        txtTuristik_yildizSayi.Visible = True
                        turistikOtelDuzenle()
                    Case 1 'Apart Otel
                        lblTuristik_apartSayi.Visible = True
                        txtTuristik_apartSayi.Visible = True
                        turistikOtelDuzenle()
                    Case 2, 3, 4 'Butik Otel, Motel, Pansiyon
                        turistikOtelDuzenle()
                    Case 5 'Kamp Yeri
                        lblTuristik_topArazi.Visible = True
                        txtTuristik_topArazi.Visible = True
                    Case 7 'Plaj
                        lblTuristik_m2.Visible = True
                        txtTuristik_m2.Visible = True
                        lblTuristik_kapasite.Visible = True
                        txtTuristik_kapasite.Visible = True
                End Select
                gbxTuristikTesis.Visible = True
        End Select
    End Sub
    Private Sub DegerleriAl(emlakTur As Byte, satis As Byte, Optional emlakTip As Byte = 255)
        Dim emlakSahibNesne As New EmlakSahibi

        emlakSahibNesne.Isim = txtAd.Text.Trim & "," & txtSoyad.Text.Trim 'İlan Veren Bilgileri değer atama işlemleri
        emlakSahibNesne.CepTel = ToTelNo(txtCepTel.Text)
        emlakSahibNesne.EvTel = ToTelNo(txtEvTel.Text)
        emlakSahibNesne.Email = txtEmail.Text.Trim

        Select Case emlakTur
            Case 0
                Dim konutNesne As New Konut
                EmlakVeriYukle(konutNesne, emlakTur, satis)
                EmlakFotoVid(konutNesne)
                konutNesne.SatisTurID = satis
                konutNesne.KonutTipID = emlakTip
                konutNesne.Buyukluk = CShort(txtKonutBuyukluk.Text)
                If txtKonut_acikAlanM2.Visible = True Then konutNesne.AcikAlanBuyuklugu = CInt(txtKonut_acikAlanM2.Text)
                konutNesne.BinaYasi = CByte(txtBinaYasi.Text)
                konutNesne.OdaSayisiID = cbxOdaSayisi.SelectedIndex
                konutNesne.BulunduguKatID = cbxBulunduKat.SelectedIndex
                konutNesne.KatSayisi = CByte(txtKatSayisi.Text)
                konutNesne.IsitmaID = cbxIsitma.SelectedIndex
                konutNesne.BanyoSayisi = CByte(txtBanyoSayisi.Text)
                konutNesne.Aidat = CShort(txtAidat.Text)
                konutNesne.Esyali = chkEsyali.Checked
                konutNesne.SiteIcerisinde = chkSiteIceri.Checked
                konutNesne.KrediyeUygun = chkKonutKredi.Checked
                konutNesne.Takas = chkKonutTakas.Checked
                konutNesne.KullanimDurumu = chkKonutKullanim.Checked
                If degistirmekİcinCagrildi = False Then
                    SQL.KonutEkle(konutNesne, emlakSahibNesne)
                Else
                    Select Case MsgBox("Değiştirmek istediğinize emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                        Case vbYes
                            SQL.KonutGuncelle(konutNesne, updateIlanNo)
                            MsgBox("Güncelleme işlemi başarı ile gerçekleşmiştir", MsgBoxStyle.Information, "Başarılı İşlem")
                            Me.Close()
                        Case vbNo
                            Me.Close()
                        Case vbCancel
                            'HiçBirşey Yapma
                    End Select
                End If
            Case 1
                Select Case emlakTip
                    Case 0, 1, 3, 7, 9 'AtölyeBuroDukkanAVMİmalathane
                        Dim isyeriNesne As New AtolyeBuroDukkanImaAVM
                        isyeriNesne.IsyeriGrupID = 0
                        isyeriNesne.isyeriTipi = emlakTip
                        EmlakVeriYukle(isyeriNesne, emlakTur, satis)
                        EmlakFotoVid(isyeriNesne)
                        Select Case emlakTip
                            Case 1 'AVM
                                isyeriNesne.Buyukluk = txtAVM_m2.Text
                                isyeriNesne.Durum = cbxAVM_durum.SelectedIndex
                                isyeriNesne.BinaYasi = txtAVM_binaYas.Text
                                isyeriNesne.IsitmaID = cbxAVM_isitma.SelectedIndex
                                isyeriNesne.katSayisi = CByte(txtAVM_katSayi.Text)
                                isyeriNesne.asansorSayisi = CByte(txtAVM_asansorSayi.Text)
                                If satis = 1 Then : isyeriNesne.depozitosu = chkAVM_kredi.Checked
                                Else : isyeriNesne.krediyeUygun = chkAVM_kredi.Checked
                                End If
                                isyeriNesne.Takas = chkAVM_takas.Checked
                            Case 0, 3, 7 'Atölye, Büro, Dükkan
                                isyeriNesne.Buyukluk = CInt(txtABD_m2.Text)
                                isyeriNesne.Durum = cbxABD_durum.SelectedIndex
                                isyeriNesne.BinaYasi = CByte(txtABD_binaYas.Text)
                                isyeriNesne.IsitmaID = cbxABD_isitma.SelectedIndex
                                isyeriNesne.odaBolumSayisi = CShort(txtABD_odaBolumSayi.Text)
                                isyeriNesne.aidati = CShort(txtABD_aidat.Text)
                                If satis = 1 Then : isyeriNesne.depozitosu = chkABD_kredi.Checked
                                Else : isyeriNesne.krediyeUygun = chkABD_kredi.Checked
                                End If
                                isyeriNesne.Takas = chkABD_takas.Checked
                            Case 9 'Imalathane
                                isyeriNesne.Buyukluk = CInt(txtIMA_m2.Text)
                                isyeriNesne.Durum = cbxIMA_durum.SelectedIndex
                                isyeriNesne.BinaYasi = CByte(txtIMA_binaYas.Text)
                                isyeriNesne.IsitmaID = cbxIMA_isitma.SelectedIndex
                                isyeriNesne.odaBolumSayisi = CShort(txtIMA_odaBolumSayi.Text)
                                If satis = 1 Then : isyeriNesne.depozitosu = chkIMA_kredi.Checked
                                Else : isyeriNesne.krediyeUygun = chkIMA_kredi.Checked
                                End If
                                isyeriNesne.Takas = chkIMA_takas.Checked
                        End Select
                        If degistirmekİcinCagrildi = False Then
                            SQL.AtölyeBuroDukkanAVMİmalathaneEKLE(isyeriNesne, emlakSahibNesne)
                        Else
                            Select Case MsgBox("Değiştirmek istediğinize emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                                Case vbYes
                                    SQL.AtölyeBuroDukkanAVMİmalathaneGuncelle(isyeriNesne, updateIlanNo)
                                    MsgBox("Güncelleme işlemi başarı ile gerçekleşmiştir", MsgBoxStyle.Information, "Başarılı İşlem")
                                    Me.Close()
                                Case vbNo
                                    Me.Close()
                                Case vbCancel
                                    'HiçBirşey Yapma
                            End Select
                        End If
                    Case 2, 6, 11, 15, 16 'BufeDugunSinSpaOto
                        Dim isyeriNesne As New BufeDugunSpaSineOto
                        isyeriNesne.IsyeriGrupID = 1
                        isyeriNesne.isyeriTipi = emlakTip
                        EmlakVeriYukle(isyeriNesne, emlakTur, satis)
                        EmlakFotoVid(isyeriNesne)
                        Select Case emlakTip
                            Case 2 'Bufe
                                isyeriNesne.Buyukluk = CInt(txtBufe_m2.Text)
                                isyeriNesne.Durum = cbxBufe_durum.SelectedIndex
                                isyeriNesne.YapiTipi = cbxBufe_yapiTip.SelectedIndex
                                If satis = 1 Then : isyeriNesne.depozitosu = chkBufe_kredi.Checked
                                Else : isyeriNesne.krediyeUygun = chkBufe_kredi.Checked
                                End If
                                isyeriNesne.kullanimDurumu = chkBufe_kullanim.Checked
                            Case 16 'Spa
                                isyeriNesne.Buyukluk = CInt(txtSpa_binaYas.Text)
                                isyeriNesne.Durum = cbxSpa_durum.SelectedIndex
                                isyeriNesne.cinsiyeti = cbxSpa_cinsiyet.SelectedIndex
                                isyeriNesne.BinaYasi = CByte(txtSpa_binaYas.Text)
                                isyeriNesne.kisiKapasitesi = txtSpa_kisiKapasitesi.Text
                                isyeriNesne.odaBolumSayisi = CShort(txtSpa_odaBolumSayi.Text)
                                If satis = 1 Then : isyeriNesne.depozitosu = chkSpa_kredi.Checked
                                Else : isyeriNesne.krediyeUygun = chkSpa_kredi.Checked
                                End If
                                isyeriNesne.kullanimDurumu = chkSpa_kullanim.Checked
                            Case 15 'Sinema
                                isyeriNesne.Buyukluk = CInt(txtSinema_m2.Text)
                                isyeriNesne.Durum = cbxSinema_durum.SelectedIndex
                                isyeriNesne.BinaYasi = CByte(txtSinema_binaYas.Text)
                                isyeriNesne.tavanYukseklik = CByte(txtSinema_tavan.Text)
                                isyeriNesne.odaBolumSayisi = CShort(txtSinema_odaBolumSayi.Text)
                                isyeriNesne.katSayisi = CByte(txtSinema_odaBolumSayi.Text)
                                isyeriNesne.bulunduguKat = CByte(cbxSinema_bulunduguKat.SelectedIndex)
                                isyeriNesne.kisiKapasitesi = CInt(txtSinema_kisiKapasitesi.Text)
                                isyeriNesne.IsitmaID = cbxSinema_isitma.SelectedIndex
                                If satis = 1 Then : isyeriNesne.depozitosu = chkSinema_kredi.Checked
                                Else : isyeriNesne.krediyeUygun = chkSinema_kredi.Checked
                                End If
                                isyeriNesne.kullanimDurumu = chkSinema_kullanim.Checked
                                isyeriNesne.Takas = chkSinema_takas.Checked
                            Case 11 'Otopark
                                isyeriNesne.Buyukluk = CInt(txtOto_m2.Text)
                                isyeriNesne.otoparkTuru = CByte(cbxOto_tur.SelectedIndex)
                                isyeriNesne.BinaYasi = CByte(txtOto_binaYas.Text)
                                isyeriNesne.katSayisi = CByte(txtOto_katSayi.Text)
                                isyeriNesne.aracSayisi = CInt(txtOto_aracKapasitesi.Text)
                                If satis = 1 Then : isyeriNesne.depozitosu = chkOto_kredi.Checked
                                Else : isyeriNesne.krediyeUygun = chkOto_kredi.Checked
                                End If
                            Case 6 'Dugun Salonu
                                isyeriNesne.Buyukluk = CInt(txtDugun_m2.Text)
                                isyeriNesne.BinaYasi = CByte(txtDugun_binaYas.Text)
                                isyeriNesne.masaSayisi = CShort(txtDugun_masaSayi.Text)
                                isyeriNesne.kisiKapasitesi = CInt(txtDugun_kisiKapasitesi.Text)
                        End Select
                        If degistirmekİcinCagrildi = False Then
                            SQL.BufeDugunSinSpaOtoEKLE(isyeriNesne, emlakSahibNesne)
                        Else
                            Select Case MsgBox("Değiştirmek istediğinize emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                                Case vbYes
                                    SQL.BufeDugunSinSpaOtoGuncelle(isyeriNesne, updateIlanNo)
                                    MsgBox("Güncelleme işlemi başarı ile gerçekleşmiştir", MsgBoxStyle.Information, "Başarılı İşlem")
                                    Me.Close()
                                Case vbNo
                                    Me.Close()
                                Case vbCancel
                                    'HiçBirşey Yapma
                            End Select
                        End If

                    Case 5, 8, 10, 13 ' DepoBinaPlazaFabrika
                        Dim isyeriNesne As New DepoBinaPlazaFabrika
                        isyeriNesne.IsyeriGrupID = 2
                        isyeriNesne.isyeriTipi = emlakTip
                        EmlakVeriYukle(isyeriNesne, emlakTur, satis)
                        EmlakFotoVid(isyeriNesne)
                        Select Case emlakTip
                            Case 8 'Fabrika
                                isyeriNesne.Buyukluk = CInt(txtFabrika_m2acik.Text)
                                isyeriNesne.KapaliAlan = CShort(txtFabrika_m2kapali.Text)
                                isyeriNesne.Durum = CByte(cbxFabrika_durum.SelectedIndex)
                                isyeriNesne.BinaYasi = CByte(txtFabrika_binaYas.Text)
                                isyeriNesne.BinaAdedi = CByte(txtFabrika_binaAdet.Text)
                                isyeriNesne.GirisYukseklik = CByte(txtFabrika_giris.Text)
                                isyeriNesne.odaBolumSayisi = CShort(txtFabrika_odaBolumSayi.Text)
                                isyeriNesne.KatSayisi = CByte(txtFabrika_katSayi.Text)
                                isyeriNesne.IsitmaID = CByte(cbxFabrika_isitma.SelectedIndex)
                                isyeriNesne.TapuDurumu = CByte(cbxFabrika_tapu.SelectedIndex)
                                isyeriNesne.ZeminEtudu = chkFabrika_zeminEtudu.Checked
                                isyeriNesne.KullanimDurumu = chkFabrika_kullanim.Checked
                                If satis = 1 Then : isyeriNesne.depozitosu = chkFabrika_kredi.Checked
                                Else : isyeriNesne.krediyeUygun = chkFabrika_kredi.Checked
                                End If
                                isyeriNesne.Takas = chkFabrika_takas.Checked
                            Case 5 'Depo 
                                isyeriNesne.Buyukluk = CInt(txtDepo_m2.Text)
                                isyeriNesne.Durum = CByte(cbxDepo_durum.SelectedIndex)
                                    isyeriNesne.BinaYasi = CByte(txtDepo_binaYas.Text)
                                isyeriNesne.IsitmaID = CByte(cbxDepo_isitma.SelectedIndex)
                                isyeriNesne.GirisYukseklik = CByte(txtDepo_giris.Text)
                                isyeriNesne.TapuDurumu = CByte(cbxDepo_tapu.SelectedIndex)
                                isyeriNesne.ZeminEtudu = chkDepo_zeminEtudu.Checked
                                If satis = 1 Then : isyeriNesne.depozitosu = chkDepo_kredi.Checked
                                Else : isyeriNesne.krediyeUygun = chkDepo_kredi.Checked
                                End If
                                isyeriNesne.KullanimDurumu = chkDepo_kullanim.Checked
                                isyeriNesne.Takas = chkDepo_takas.Checked
                            Case 10 'Komple Bina
                                isyeriNesne.Buyukluk = CInt(txtKBina_m2.Text)
                                isyeriNesne.Durum = CByte(cbxKBina_durum.SelectedIndex)
                                isyeriNesne.BinaYasi = CByte(txtKBina_binaYas.Text)
                                isyeriNesne.KatSayisi = CByte(txtKBina_katSayi.Text)
                                isyeriNesne.IsitmaID = CByte(cbxKBina_isitma.SelectedIndex)
                                isyeriNesne.BinaTipiID = CByte(cbxKBina_binaTip.SelectedIndex)
                                isyeriNesne.TapuDurumu = CByte(cbxKBina_tapu.SelectedIndex)
                                isyeriNesne.ZeminEtudu = chkKBina_zeminEtudu.Checked
                                If satis = 1 Then : isyeriNesne.depozitosu = chkKBina_kredi.Checked
                                Else : isyeriNesne.krediyeUygun = chkKBina_kredi.Checked
                                End If
                                isyeriNesne.KullanimDurumu = chkKBina_kullanim.Checked
                            Case 13 'Plaza
                                isyeriNesne.Buyukluk = CInt(txtPlaza_m2.Text)
                                isyeriNesne.Durum = CByte(cbxPlaza_durum.SelectedIndex)
                                isyeriNesne.BinaYasi = CByte(txtPlaza_binaYas.Text)
                                isyeriNesne.IsitmaID = CByte(cbxPlaza_isitma.SelectedIndex)
                                isyeriNesne.odaBolumSayisi = CShort(txtPlaza_odaBolumSayi.Text)
                                isyeriNesne.BulunduguKat = CByte(cbxPlaza_bulunduguKat.SelectedIndex)
                                isyeriNesne.Aidat = CShort(txtPlaza_aidat.Text)
                                isyeriNesne.KatSayisi = CByte(txtPlaza_katSayi.Text)
                                isyeriNesne.TapuDurumu = CByte(cbxPlaza_tapu.SelectedIndex)
                                isyeriNesne.ZeminEtudu = chkPlaza_zeminEtudu.Checked
                                isyeriNesne.Takas = chkPlaza_takas.Checked
                                If satis = 1 Then : isyeriNesne.depozitosu = chkPlaza_kredi.Checked
                                Else : isyeriNesne.krediyeUygun = chkPlaza_kredi.Checked
                                End If
                                isyeriNesne.KullanimDurumu = chkPlaza_kullanim.Checked
                        End Select
                        If degistirmekİcinCagrildi = False Then
                            SQL.DepoBinaPlazaFabrikaEKLE(isyeriNesne, emlakSahibNesne)
                        Else
                            Select Case MsgBox("Değiştirmek istediğinize emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                                Case vbYes
                                    SQL.DepoBinaPlazaFabrikaGuncelle(isyeriNesne, updateIlanNo)
                                    MsgBox("Güncelleme işlemi başarı ile gerçekleşmiştir", MsgBoxStyle.Information, "Başarılı İşlem")
                                    Me.Close()
                                Case vbNo
                                    Me.Close()
                                Case vbCancel
                                    'HiçBirşey Yapma
                            End Select
                        End If
                    Case 4, 12, 14, 17 'SporRadyoPazarCiftlik
                        Dim isyeriNesne As New SporRadyoPazarCiftlik
                        isyeriNesne.IsyeriGrupID = 3
                        isyeriNesne.IsyeriTipi = emlakTip
                        EmlakVeriYukle(isyeriNesne, emlakTur, satis)
                        EmlakFotoVid(isyeriNesne)
                        Select Case emlakTip
                            Case 4 'Ciftlik
                                isyeriNesne.Buyukluk = CInt(txtCiftlik_m2acik.Text)
                                isyeriNesne.KapaliAlan = CShort(txtCiftlik_m2kapali.Text)
                                isyeriNesne.Durum = CByte(cbxCiftlik_durum.SelectedIndex)
                                isyeriNesne.krediyeUygun = chkCiftlik_kredi.Checked
                            Case 12 'Pazar
                                isyeriNesne.Buyukluk = CInt(txtPazar_m2.Text)
                                isyeriNesne.Takas = CByte(chkPazar_takas.Checked)
                            Case 14 'Radyo
                                isyeriNesne.Buyukluk = CInt(txtRadyo_m2.Text)
                                isyeriNesne.IsitmaID = CByte(cbxRadyo_Isitma.SelectedIndex)
                                isyeriNesne.krediyeUygun = CByte(ChkRadyo_Kredi.Checked)
                                isyeriNesne.Takas = CByte(ChkRadyo_Takasli.Checked)
                            Case 17 'Spor
                                isyeriNesne.Buyukluk = CInt(txtSpor_m2.Text)
                                isyeriNesne.Durum = CByte(cbxSpor_durum.SelectedIndex)
                                isyeriNesne.BinaYasi = CByte(txtSpor_binaYas.Text)
                                isyeriNesne.SporTesisTipi = CByte(cbxSpor_tip.SelectedIndex)
                                isyeriNesne.krediyeUygun = chkSpor_kredi.Checked
                                isyeriNesne.KullanimDurumu = chkSpor_kullanim.Checked
                        End Select
                        If degistirmekİcinCagrildi = False Then
                            SQL.SporRadyoPazarCiftlikEKLE(isyeriNesne, emlakSahibNesne)
                        Else
                            Select Case MsgBox("Değiştirmek istediğinize emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                                Case vbYes
                                    SQL.SporRadyoPazarCiftlikGuncelle(isyeriNesne, updateIlanNo)
                                    MsgBox("Güncelleme işlemi başarı ile gerçekleşmiştir", MsgBoxStyle.Information, "Başarılı İşlem")
                                    Me.Close()
                                Case vbNo
                                    Me.Close()
                                Case vbCancel
                                    'HiçBirşey Yapma
                            End Select
                        End If
                End Select
                        'İşyeri
            Case 2
                Dim arsaNesne As New Arsa
                EmlakVeriYukle(arsaNesne, emlakTur, satis)
                EmlakFotoVid(arsaNesne)
                arsaNesne.imarDurumuID = cbxImarDurumu.SelectedIndex
                arsaNesne.Buyukluk = CShort(txtArsaBuyukluk.Text)
                arsaNesne.AdaNo = txtAdaNo.Text
                arsaNesne.ParselNo = txtParselNo.Text
                arsaNesne.PaftaNo = txtPaftaNo.Text
                arsaNesne.KaksID = cbxKaks.SelectedIndex
                arsaNesne.GabariID = cbxGabari.SelectedIndex
                arsaNesne.TapuDurumuID = cbxTapu.SelectedIndex
                arsaNesne.KatKarsiligi = chkArsaKatKarsiligi.Checked
                arsaNesne.Kredi = chkArsaKredi.Checked
                arsaNesne.Takas = chkArsaTakas.Checked
                If degistirmekİcinCagrildi = False Then
                    SQL.ArsaEkle(arsaNesne, emlakSahibNesne)
                Else
                    Select Case MsgBox("Değiştirmek istediğinize emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                        Case vbYes
                            SQL.ArsaGuncelle(arsaNesne, updateIlanNo)
                            MsgBox("Güncelleme işlemi başarı ile gerçekleşmiştir", MsgBoxStyle.Information, "Başarılı İşlem")
                            Me.Close()
                        Case vbNo
                            Me.Close()
                        Case vbCancel
                            'HiçBirşey Yapma
                    End Select
                End If
            Case 3
                Dim binaNesne As New Bina
                EmlakVeriYukle(binaNesne, emlakTur, satis)
                EmlakFotoVid(binaNesne)
                binaNesne.KatSayisi = CByte(txtBinaKatsayisi.Text)
                binaNesne.BirKattakiDaireSayisi = CByte(txtBinaKatBasiDaireSayisi.Text)
                binaNesne.IsitmaID = CByte(cbxBinaIsitma.SelectedIndex)
                binaNesne.Buyukluk = CShort(txtBinaBuyukluk.Text)
                binaNesne.BinaYasi = CByte(txtBinaBinaYasi.Text)
                binaNesne.KrediyeUygun = cbxBinaKrediUygun.Checked
                binaNesne.Takas = cbxBinaTakas.Checked
                If degistirmekİcinCagrildi = False Then
                    SQL.BinaEkle(binaNesne, emlakSahibNesne)
                Else
                    Select Case MsgBox("Değiştirmek istediğinize emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                        Case vbYes
                            SQL.BinaGuncelle(binaNesne, updateIlanNo)
                            MsgBox("Güncelleme işlemi başarı ile gerçekleşmiştir", MsgBoxStyle.Information, "Başarılı İşlem")
                            Me.Close()
                        Case vbNo
                            Me.Close()
                        Case vbCancel
                            'HiçBirşey Yapma
                    End Select
                End If
            Case 4 'Turistik tesisleri
                Dim TTNesne As New Turistik_Tesis
                EmlakVeriYukle(TTNesne, emlakTur, satis)
                EmlakFotoVid(TTNesne)
                TTNesne.TipID = emlakTip
                Select Case emlakTip
                    Case 0, 1, 2, 3, 4, 6 'Otel, Apart Otel, Butik Otel, Motel, Pansiyon, Tatil Köyü
                        TTNesne.OdaSayisi = CShort(txtTuristik_odaSayi.Text)
                        TTNesne.YatakSayisi = CShort(txtTuristik_yatakSayi.Text)
                        TTNesne.KatSayisi = CByte(txtTuristik_katSayi.Text)
                        TTNesne.BinaYasi = CByte(txtTuristik_binaYas.Text)
                        TTNesne.AcikAlan = CInt(txtTuristik_m2acik.Text)
                        TTNesne.KapaliAlan = CInt(txtTuristik_m2kapali.Text)
                        TTNesne.ZeminEtudu = chkTuristik_zeminEtudu.Checked
                        TTNesne.KrediyeUygun = chkTuristik_kredi.Checked
                        If cbxTuristik_yapiDurum.SelectedIndex = 1 Then
                            TTNesne.YapiDurumu = True
                        Else
                            TTNesne.YapiDurumu = False
                        End If
                        Select Case emlakTip
                            Case 0, 6 'Otel veya Tatil Köyü
                                TTNesne.OtelYildizSayisi = CByte(txtTuristik_yildizSayi.Text)
                            Case 1 'Apart Otel
                                TTNesne.ApartSayisi = CShort(txtTuristik_apartSayi.Text)
                        End Select
                    Case 5 'Kamp Yeri
                        TTNesne.KapaliAlan = txtTuristik_topArazi.Text
                    Case 7 'Plaj
                        TTNesne.KapaliAlan = txtTuristik_m2.Text
                        TTNesne.YatakSayisi = txtTuristik_kapasite.Text
                End Select
                If degistirmekİcinCagrildi = False Then
                    SQL.TT_Ekle(TTNesne, emlakSahibNesne)
                Else
                    Select Case MsgBox("Değiştirmek istediğinize emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
                        Case vbYes
                            SQL.TT_Guncelle(TTNesne, updateIlanNo)
                            MsgBox("Güncelleme işlemi başarı ile gerçekleşmiştir", MsgBoxStyle.Information, "Başarılı İşlem")
                            Me.Close()
                        Case vbNo
                            Me.Close()
                        Case vbCancel
                            'HiçBirşey Yapma
                    End Select
                End If
        End Select
    End Sub
    Private Sub turistikSifirla()
        lblTuristik_apartSayi.Visible = False
        lblTuristik_binaYas.Visible = False
        lblTuristik_kapasite.Visible = False
        lblTuristik_katSayi.Visible = False
        lblTuristik_kredi.Visible = False
        lblTuristik_m2.Visible = False
        lblTuristik_m2acik.Visible = False
        lblTuristik_m2kapali.Visible = False
        lblTuristik_odaSayi.Visible = False
        lblTuristik_topArazi.Visible = False
        lblTuristik_yapiDurum.Visible = False
        lblTuristik_yatakSayi.Visible = False
        lblTuristik_yildizSayi.Visible = False
        lblTuristik_zeminEtudu.Visible = False
        txtTuristik_apartSayi.Visible = False
        txtTuristik_binaYas.Visible = False
        txtTuristik_kapasite.Visible = False
        txtTuristik_katSayi.Visible = False
        txtTuristik_m2.Visible = False
        txtTuristik_m2acik.Visible = False
        txtTuristik_m2kapali.Visible = False
        txtTuristik_odaSayi.Visible = False
        txtTuristik_topArazi.Visible = False
        txtTuristik_yatakSayi.Visible = False
        txtTuristik_yildizSayi.Visible = False
        cbxTuristik_yapiDurum.Visible = False
        chkTuristik_kredi.Visible = False
        chkTuristik_zeminEtudu.Visible = False
    End Sub
    Private Sub turistikOtelDuzenle()
        lblTuristik_odaSayi.Visible = True
        lblTuristik_yatakSayi.Visible = True
        lblTuristik_katSayi.Visible = True
        lblTuristik_binaYas.Visible = True
        lblTuristik_m2acik.Visible = True
        lblTuristik_m2kapali.Visible = True
        lblTuristik_zeminEtudu.Visible = True
        lblTuristik_kredi.Visible = True
        lblTuristik_yapiDurum.Visible = True
        txtTuristik_odaSayi.Visible = True
        txtTuristik_yatakSayi.Visible = True
        txtTuristik_katSayi.Visible = True
        txtTuristik_binaYas.Visible = True
        txtTuristik_m2acik.Visible = True
        txtTuristik_m2kapali.Visible = True
        chkTuristik_zeminEtudu.Visible = True
        chkTuristik_kredi.Visible = True
        cbxTuristik_yapiDurum.Visible = True
    End Sub
    Private Sub btn_geri_Click(sender As Object, e As EventArgs) Handles btn_geri.Click
        If degistirmekİcinCagrildi = True Then
            If btn_geri.Text = "Diğer" Then
                btn_ileri.Text = "ileri"
                pnlIlanOzellikleri.Visible = False
                pnlilanDetayi.Visible = True
                btn_geri.Text = "Geri"
                rbtnMevcutKisi.Visible = False
                rbtnYeniKisi.Visible = False
            Else
                Me.Close()
            End If
        Else
            If adim > 0 Then
                adim -= 1
                geriIleri(adim)
            End If
        End If
    End Sub
    Private Sub lbl_anaSayfa_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_anaSayfa.LinkClicked
        Dim giris As New frm_Giris
        Me.Hide()
        giris.ShowDialog()
        Me.Close()
    End Sub

    Private Sub cbxIl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIl.SelectedIndexChanged
        cbxMahalle.Items.Clear()
        cbxIlce.Items.Clear()
        SQL.ilce_Doldur(ilce, 82 - cbxIl.SelectedIndex)
        For i As Integer = 0 To ilce.Length
            If ilce(i, 1) = Nothing Then Exit For
            cbxIlce.Items.Add(ilce(i, 1))
        Next
    End Sub

    Private Sub cbxIlce_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIlce.SelectedIndexChanged
        cbxMahalle.Items.Clear()
        For i As Integer = 0 To ilce.Length
            If ilce(i, 1) = Nothing Then Exit For
            If ilce(i, 1) = cbxIlce.SelectedItem Then
                SQL.semtMah_Doldur(cbxMahalle, ilce(i, 0))
                Exit For
            End If
        Next
    End Sub

    Private Sub integerLimitKontrol(sender As Object, e As EventArgs) Handles txtFiyat.Leave, txtSinema_m2.Leave, txtSinema_kisiKapasitesi.Leave, txtOto_m2.Leave, txtOto_aracKapasitesi.Leave, txtDugun_m2.Leave, txtDugun_kisiKapasitesi.Leave, txtBufe_m2.Leave, txtFabrika_m2acik.Leave, txtDepo_m2.Leave, txtKBina_m2.Leave, txtPlaza_m2.Leave, txtCiftlik_m2acik.Leave, txtPazar_m2.Leave, txtAVM_m2.Leave, txtSpa_m2.Leave, txtSpa_kisiKapasitesi.Leave, txtABD_m2.Leave, txtIMA_m2.Leave, txtRadyo_m2.Leave, txtSpor_m2.Leave, txtTuristik_m2kapali.Leave, txtTuristik_m2acik.Leave
        If Not sender.Text = "" Then Kontrol.LimitKontrol(DirectCast(sender, TextBox), "integer")
    End Sub
    Private Sub smallintLimitKontrol(sender As Object, e As EventArgs) Handles txtAdaNo.Leave, txtPaftaNo.Leave, txtParselNo.Leave, txtAidat.Leave, txtKonutBuyukluk.Leave, txtArsaBuyukluk.Leave, txtBinaBuyukluk.Leave, txtSinema_odaBolumSayi.Leave, txtDugun_masaSayi.Leave, txtFabrika_odaBolumSayi.Leave, txtFabrika_m2kapali.Leave, txtPlaza_odaBolumSayi.Leave, txtPlaza_aidat.Leave, txtCiftlik_m2kapali.Leave, txtSpa_odaBolumSayi.Leave, txtABD_odaBolumSayi.Leave, txtABD_aidat.Leave, txtIMA_odaBolumSayi.Leave, txtTuristik_yatakSayi.Leave, txtTuristik_topArazi.Leave, txtTuristik_odaSayi.Leave, txtTuristik_m2.Leave, txtTuristik_kapasite.Leave, txtTuristik_apartSayi.Leave
        If Not sender.Text = "" Then Kontrol.LimitKontrol(DirectCast(sender, TextBox), "short")
    End Sub
    Private Sub tinyintLimitKontrol(sender As Object, e As EventArgs) Handles txtBinaYasi.Leave, txtBinaBinaYasi.Leave, txtBinaKatBasiDaireSayisi.Leave, txtKatSayisi.Leave, txtBinaKatsayisi.Leave, txtSinema_tavan.Leave, txtSinema_katSayi.Leave, txtSinema_binaYas.Leave, txtOto_katSayi.Leave, txtOto_binaYas.Leave, txtDugun_binaYas.Leave, txtFabrika_katSayi.Leave, txtFabrika_giris.Leave, txtFabrika_binaYas.Leave, txtFabrika_binaAdet.Leave, txtDepo_giris.Leave, txtDepo_binaYas.Leave, txtKBina_katSayi.Leave, txtKBina_binaYas.Leave, txtPlaza_katSayi.Leave, txtPlaza_binaYas.Leave, txtAVM_katSayi.Leave, txtAVM_binaYas.Leave, txtAVM_asansorSayi.Leave, txtSpa_binaYas.Leave, txtABD_binaYas.Leave, txtIMA_binaYas.Leave, txtSpor_binaYas.Leave, txtTuristik_yildizSayi.Leave, txtTuristik_katSayi.Leave, txtTuristik_binaYas.Leave
        If Not sender.Text = "" Then Kontrol.LimitKontrol(DirectCast(sender, TextBox), "byte")
    End Sub
    Private Sub integer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEvTel.KeyPress, txtCepTel.KeyPress, txtFiyat.KeyPress, txtSinema_m2.KeyPress, txtSinema_kisiKapasitesi.KeyPress, txtOto_m2.KeyPress, txtOto_aracKapasitesi.KeyPress, txtDugun_m2.KeyPress, txtDugun_kisiKapasitesi.KeyPress, txtBufe_m2.KeyPress, txtFabrika_m2acik.KeyPress, txtDepo_m2.KeyPress, txtKBina_m2.KeyPress, txtPlaza_m2.KeyPress, txtCiftlik_m2acik.KeyPress, txtPazar_m2.KeyPress, txtAVM_m2.KeyPress, txtSpa_m2.KeyPress, txtSpa_kisiKapasitesi.KeyPress, txtABD_m2.KeyPress, txtIMA_m2.KeyPress, txtRadyo_m2.KeyPress, txtSpor_m2.KeyPress, txtTuristik_m2kapali.KeyPress, txtTuristik_m2acik.KeyPress
        e.Handled = Kontrol.SayiKontrolu(9, sender, e)
    End Sub
    Private Sub smallint_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdaNo.KeyPress, txtPaftaNo.KeyPress, txtParselNo.KeyPress, txtAidat.KeyPress, txtKonutBuyukluk.KeyPress, txtArsaBuyukluk.KeyPress, txtBinaBuyukluk.KeyPress, txtSinema_odaBolumSayi.KeyPress, txtDugun_masaSayi.KeyPress, txtFabrika_odaBolumSayi.KeyPress, txtFabrika_m2kapali.KeyPress, txtPlaza_odaBolumSayi.KeyPress, txtPlaza_aidat.KeyPress, txtCiftlik_m2kapali.KeyPress, txtSpa_odaBolumSayi.KeyPress, txtABD_odaBolumSayi.KeyPress, txtABD_aidat.KeyPress, txtIMA_odaBolumSayi.KeyPress, txtTuristik_yatakSayi.KeyPress, txtTuristik_topArazi.KeyPress, txtTuristik_odaSayi.KeyPress, txtTuristik_m2.KeyPress, txtTuristik_kapasite.KeyPress, txtTuristik_apartSayi.KeyPress
        e.Handled = Kontrol.SayiKontrolu(5, DirectCast(sender, TextBox), e)
    End Sub
    Private Sub tinyint_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBinaYasi.KeyPress, txtBinaBinaYasi.KeyPress, txtBinaKatBasiDaireSayisi.KeyPress, txtKatSayisi.KeyPress, txtBinaKatsayisi.KeyPress, txtSinema_tavan.KeyPress, txtSinema_katSayi.KeyPress, txtSinema_binaYas.KeyPress, txtOto_katSayi.KeyPress, txtOto_binaYas.KeyPress, txtDugun_binaYas.KeyPress, txtFabrika_katSayi.KeyPress, txtFabrika_giris.KeyPress, txtFabrika_binaYas.KeyPress, txtFabrika_binaAdet.KeyPress, txtDepo_giris.KeyPress, txtDepo_binaYas.KeyPress, txtKBina_katSayi.KeyPress, txtKBina_binaYas.KeyPress, txtPlaza_katSayi.KeyPress, txtPlaza_binaYas.KeyPress, txtAVM_katSayi.KeyPress, txtAVM_binaYas.KeyPress, txtAVM_asansorSayi.KeyPress, txtSpa_binaYas.KeyPress, txtABD_binaYas.KeyPress, txtIMA_binaYas.KeyPress, txtSpor_binaYas.KeyPress, txtTuristik_yildizSayi.KeyPress, txtTuristik_katSayi.KeyPress, txtTuristik_binaYas.KeyPress
        e.Handled = Kontrol.SayiKontrolu(2, DirectCast(sender, TextBox), e)
    End Sub
    Private Sub ikibasamak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBanyoSayisi.KeyPress
        e.Handled = Kontrol.SayiKontrolu(1, sender, e)
    End Sub
    Private Sub txtEvTel_Leave(sender As Object, e As EventArgs) Handles txtEvTel.Leave
        If SQL.SahipVarMi("Sahip_Ev_Tel", txtEvTel.Text) Then
            MessageBox.Show("Bu numara zaten sistemde kayıtlı. Lütfen yeni bir numara giriniz")
            txtEvTel.Clear()
        End If
    End Sub

    Private Sub txtCepTel_Leave(sender As Object, e As EventArgs) Handles txtCepTel.Leave
        If SQL.SahipVarMi("Sahip_Cep_Tel", txtCepTel.Text) Then
            MessageBox.Show("Bu numara zaten sistemde kayıtlı. Lütfen yeni bir numara giriniz.")
            txtCepTel.Clear()
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If SQL.SahipVarMi("Sahip_Email", txtEmail.Text) Then
            MessageBox.Show("Bu mail hesabı zaten sistemde kayıtlı. Lütfen yeni bir numara giriniz.")
            txtEmail.Clear()
        End If
    End Sub

    Private Sub btnFotoEkle_Click_1(sender As Object, e As EventArgs) Handles btnFotoEkle.Click
        ofdFotoVideo.Filter = "Fotoğraflar (*.BMP;*.JPG;*.GIF*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" & "Bütün Dosyalar (*.*)|*.*"
        ofdFotoVideo.Title = "Fotoğraf(lar)ı Seçin | Maksimum " & 8 - fotoSayisi
        ofdFotoVideo.Multiselect = True
        AddHandler ofdFotoVideo.FileOk, Sub(s, ce)
                                            If ofdFotoVideo.FileNames.Length > 8 - fotoSayisi Then
                                                MessageBox.Show("En fazla " & 8 - fotoSayisi & " fotografi seciniz")
                                                ce.Cancel = True
                                            End If
                                        End Sub
        Dim name As String
        If ofdFotoVideo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim foto() As PictureBox = {foto1, foto2, foto3, foto4, foto5, foto6, foto7, foto8}
                For Each name In ofdFotoVideo.FileNames
                    For Each pic As PictureBox In foto
                        If pic.Image Is Nothing Then
                            pic.Image = Image.FromFile(name)
                            fotoSayisi += 1
                            Exit For
                        End If
                    Next
                Next
            Catch
                MessageBox.Show("Bir Hata Oldu", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            If fotoSayisi > 0 Then ChBxAllPics.Enabled = True
        End If
    End Sub

    Private Sub btnVideoEkle_Click(sender As Object, e As EventArgs) Handles btnVideoEkle.Click
        VideoEkle()
    End Sub

    Private Sub ChBxAllPics_CheckedChanged(sender As Object, e As EventArgs) Handles ChBxAllPics.CheckedChanged
        Dim foto() As PictureBox = {foto1, foto2, foto3, foto4, foto5, foto6, foto7, foto8}
        If ChBxAllPics.Checked = True Then
            For Each pic As PictureBox In foto
                If pic.Image IsNot Nothing And pic.BorderStyle = BorderStyle.None Then
                    pic.BorderStyle = BorderStyle.Fixed3D
                    secilmis += 1
                End If
            Next
            DegisKaydetCtrl()
        Else
            If secilmis <> fotoSayisi Then Exit Sub
            UncheckPics()
        End If
    End Sub

    Private Sub UncheckPics()
        Dim foto() As PictureBox = {foto1, foto2, foto3, foto4, foto5, foto6, foto7, foto8}
        For Each pic As PictureBox In foto
            If pic.BorderStyle <> BorderStyle.None Then
                pic.BorderStyle = BorderStyle.None
                secilmis -= 1
            End If
        Next
        If ChBxAllPics.Checked = True Then ChBxAllPics.Checked = False
        DegisKaydetCtrl()
    End Sub

    Private Sub pnlFoto_Click(sender As Object, e As EventArgs) Handles pnlFoto.Click, pnlIlanOzellikleri.Click, MyBase.Click
        UncheckPics()
        UncheckCBVideo()
    End Sub

    Private Sub foto1_Click(sender As Object, e As EventArgs) Handles foto1.Click, foto2.Click, foto3.Click, foto4.Click, foto5.Click, foto6.Click, foto7.Click, foto8.Click
        If sender.Borderstyle = BorderStyle.None And sender.Image IsNot Nothing Then
            sender.BorderStyle = BorderStyle.Fixed3D
            secilmis += 1
            UncheckCBVideo()
        ElseIf sender.image IsNot Nothing Then
            sender.BorderStyle = BorderStyle.None
            secilmis -= 1
            UncheckCBVideo()
        End If
        If secilmis = fotoSayisi Then
            ChBxAllPics.Checked = True
        Else
            ChBxAllPics.Checked = False
        End If
        DegisKaydetCtrl()
    End Sub

    Private Sub DegisKaydetCtrl() 'aktif hale getirilip getirilemeyecegine karar verir
        If secilmis > 0 Then
            btnFotoVidKaldir.Enabled = True
        Else
            btnFotoVidKaldir.Enabled = False
        End If

        If secilmis = 1 Then
            btnFotoVidDegistir.Enabled = True
        Else
            btnFotoVidDegistir.Enabled = False
        End If
    End Sub

    Private Sub UncheckCBVideo()
        If CBVideo.Checked = True Then
            CBVideo.Checked = False
        End If
    End Sub
    Private Sub VideoEkle()
        ofdFotoVideo.Filter = "Video (*.MP4)|*.MP4"
        ofdFotoVideo.Title = "Video'yu Seçin"
        ofdFotoVideo.Multiselect = False
        If ofdFotoVideo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                AxWindowsMediaPlayer1.URL = ofdFotoVideo.FileName
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
                Label1.Text = ofdFotoVideo.FileName
                CBVideo.Enabled = True
            Catch
                MessageBox.Show("Bir Hata Oldu", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub btnFotoVidKaldir_Click(sender As Object, e As EventArgs) Handles btnFotoVidKaldir.Click
        If CBVideo.Checked = True And AxWindowsMediaPlayer1.currentPlaylist.count() > 0 Then

            AxWindowsMediaPlayer1.currentPlaylist.clear()
            Label1.Text = ""
            CBVideo.Enabled = False
        Else
            Dim foto() As PictureBox = {foto1, foto2, foto3, foto4, foto5, foto6, foto7, foto8}
            For Each pic As PictureBox In foto
                If pic.BorderStyle <> BorderStyle.None Then
                    pic.Image = Nothing
                    fotoSayisi -= 1
                End If
            Next
        End If
        UncheckCBVideo()
        UncheckPics()
        If fotoSayisi = 0 Then ChBxAllPics.Enabled = False
    End Sub

    Private Sub btnFotoVidDegistir_Click(sender As Object, e As EventArgs) Handles btnFotoVidDegistir.Click
        If CBVideo.Checked = True And AxWindowsMediaPlayer1.currentPlaylist.count() > 0 Then
            VideoEkle()
            UncheckCBVideo()
        Else
            ofdFotoVideo.Title = "Fotoğrafı Seçin"
            ofdFotoVideo.Multiselect = False
            If ofdFotoVideo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    Dim foto() As PictureBox = {foto1, foto2, foto3, foto4, foto5, foto6, foto7, foto8}
                    For Each pic As PictureBox In foto
                        If pic.BorderStyle <> BorderStyle.None Then
                            pic.BorderStyle = BorderStyle.None
                            pic.Image = Image.FromFile(ofdFotoVideo.FileName)
                            secilmis -= 1
                            Exit For
                        End If
                    Next
                Catch
                    MessageBox.Show("Bir Hata Oldu", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        End If
        DegisKaydetCtrl()
    End Sub

    Private Sub CBVideo_CheckedChanged(sender As Object, e As EventArgs) Handles CBVideo.CheckedChanged
        If CBVideo.Checked = True Then
            UncheckPics()
            secilmis += 1
        Else
            secilmis -= 1
        End If
        DegisKaydetCtrl()
    End Sub

    Private Sub AxWindowsMediaPlayer1_EndOfStream(sender As Object, e As AxWMPLib._WMPOCXEvents_EndOfStreamEvent)
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent)
        Select Case (e.newState)
            Case 1 'Stopped
                AxWindowsMediaPlayer1.fullScreen = False
            Case 3 'Playing
                AxWindowsMediaPlayer1.fullScreen = True
        End Select
    End Sub

    Private Sub EmlakFotoVid(ByRef emlakNesne As Emlak)
        Dim foto() As PictureBox = {foto1, foto2, foto3, foto4, foto5, foto6, foto7, foto8}
        For i = 0 To 7
            If foto(i).Image IsNot Nothing Then
                Dim ms As New IO.MemoryStream
                foto(i).Image.Save(ms, Imaging.ImageFormat.Jpeg)
                Select Case i
                    Case 0
                        emlakNesne.foto1 = ms.GetBuffer()
                    Case 1
                        emlakNesne.foto2 = ms.GetBuffer()
                    Case 2
                        emlakNesne.foto3 = ms.GetBuffer()
                    Case 3
                        emlakNesne.foto4 = ms.GetBuffer()
                    Case 4
                        emlakNesne.foto5 = ms.GetBuffer()
                    Case 5
                        emlakNesne.foto6 = ms.GetBuffer()
                    Case 6
                        emlakNesne.foto7 = ms.GetBuffer()
                    Case 7
                        emlakNesne.foto8 = ms.GetBuffer()
                End Select
            End If
        Next

        If Label1.Text <> "" Then
            Dim ProjeDosyasi As String = IO.Directory.GetCurrentDirectory
            IO.Directory.CreateDirectory(IO.Path.Combine(ProjeDosyasi, "Emlak Videolari"))
            Dim hedef As String = IO.Path.Combine(ProjeDosyasi, "Emlak Videolari\vid-" & emlakNesne.ilanNo & ".mp4")
            If Not System.IO.File.Exists(IO.Path.Combine(ProjeDosyasi, hedef)) Then
                My.Computer.FileSystem.CopyFile(Label1.Text, hedef)
            End If
            emlakNesne.myVideo = hedef
        End If
    End Sub

    Private Function ToTelNo(ByVal No As String) As String
        No = No.Replace("(", "")
        No = No.Replace(")", "")
        No = No.Replace(" ", "")
        Return No.Replace("-", "")
    End Function
    Private Function dosyadanoku(emlakTur As Byte) As Integer
        Dim dosyaYolu As String = Nothing
        Select Case emlakTur
            Case 0
                dosyaYolu = "konut.txt"
            Case 1
                dosyaYolu = "işyeri.txt"
            Case 2
                dosyaYolu = "arsa.txt"
            Case 3
                dosyaYolu = "bina.txt"
            Case 4
                dosyaYolu = "turistik tesis.txt"
        End Select
        Dim file As New FileStream(dosyaYolu, FileMode.OpenOrCreate)
        Dim oku As New StreamReader(file)
        Dim adet As String = Nothing
        adet = oku.ReadLine()
        oku.Close()
        If adet <> Nothing Then
            Dim dosyaIcerik As String = Nothing
            dosyaIcerik = My.Computer.FileSystem.ReadAllText(dosyaYolu)
            dosyaIcerik = dosyaIcerik.Replace(adet & vbCrLf, "")
            My.Computer.FileSystem.WriteAllText(dosyaYolu, dosyaIcerik, False)
        End If
        If adet = Nothing Then adet = -1
        Return adet
    End Function
    Private Sub EmlakVeriYukle(ByRef emlakNesne As Emlak, emlakTur As Byte, satis As Byte)
        Dim ilanadet As Integer = -1
        ilanadet = dosyadanoku(emlakTur)
        If ilanadet = -1 Then ilanadet = SQL.EmlakSayisi(emlakTurleri.Item(emlakTur))
        If emlakTur = 2 OrElse listEmlakTip.SelectedIndex = 3 Then : emlakNesne.ilanNoOlustur(CByte(emlakTur), CByte(satis), ilanadet)
        Else : emlakNesne.ilanNoOlustur(CByte(emlakTur), CByte(satis), CByte(satis), ilanadet)
        End If 'Emlak İlanNO Oluşturuyoruz
        emlakNesne.ilanSatisID = satis
        emlakNesne.ilanBaslik = txtIlanBasligi.Text.Trim 'ilanların ortak özelliklerine değer atama
        emlakNesne.ilanAciklama = txtAciklama.Text.Trim
        emlakNesne.ilanAdres = txtAdres.Text
        emlakNesne.ilanTarihi = Date.Today
        emlakNesne.mahalle = SQL.mahalleIdBul(cbxMahalle.SelectedItem.ToString, cbxIl.SelectedItem.ToString)
        emlakNesne.fiyat = txtFiyat.Text
    End Sub

    Private Sub rbtnYeniKisi_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnYeniKisi.CheckedChanged, rbtnMevcutKisi.CheckedChanged
        txtAd.Text = ""
        txtSoyad.Text = ""
        txtEvTel.Text = emptyMaskedTextBox
        txtCepTel.Text = emptyMaskedTextBox
        txtEmail.Text = ""
        yeniMevcut(True)
    End Sub

    Private Sub rbtnMevcutKisi_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMevcutKisi.CheckedChanged
        yeniMevcut(False)
    End Sub

    Private Sub yeniMevcut(ByVal yeni As Boolean)
        txtAd.Enabled = yeni
        txtSoyad.Enabled = yeni
        txtEvTel.Enabled = yeni
        txtCepTel.Enabled = yeni
        txtEmail.Enabled = yeni
        chkDegisitrMevcutKisi.Visible = Not yeni
        cbxMevcutKisi.Visible = Not yeni
    End Sub

    Private Sub chkMevcutKisi_CheckedChanged(sender As Object, e As EventArgs) Handles chkDegisitrMevcutKisi.CheckedChanged
        txtAd.Enabled = chkDegisitrMevcutKisi.Checked
        txtSoyad.Enabled = chkDegisitrMevcutKisi.Checked
        txtEvTel.Enabled = chkDegisitrMevcutKisi.Checked
        txtCepTel.Enabled = chkDegisitrMevcutKisi.Checked
        txtEmail.Enabled = chkDegisitrMevcutKisi.Checked
        btnIletisimKaydet.Visible = chkDegisitrMevcutKisi.Checked
        If chkDegisitrMevcutKisi.Checked = False Then
            SecileniDoldur(sender, e)
        End If
    End Sub

    Private Sub SecileniDoldur(sender As Object, e As EventArgs) Handles cbxMevcutKisi.SelectedIndexChanged
        If cbxMevcutKisi.SelectedIndex <> -1 Then
            txtAd.Text = dt.Rows(cbxMevcutKisi.SelectedIndex)(1).ToString.Split(",")(0)
            txtSoyad.Text = dt.Rows(cbxMevcutKisi.SelectedIndex)(1).ToString.Split(",")(1)
            txtEvTel.Text = dt.Rows(cbxMevcutKisi.SelectedIndex)(3).ToString
            txtCepTel.Text = dt.Rows(cbxMevcutKisi.SelectedIndex)(2).ToString
            txtEmail.Text = dt.Rows(cbxMevcutKisi.SelectedIndex)(4).ToString
        End If
    End Sub

    Private Sub HarfKontrolu(sender As Object, e As KeyPressEventArgs) Handles txtAd.KeyPress, txtSoyad.KeyPress
        e.Handled = Kontrol.HarfKontrolu(e)
    End Sub



    Private Sub btnIletisimKaydet_Click(sender As Object, e As EventArgs) Handles btnIletisimKaydet.Click
        If txtAd.Text.Length + txtSoyad.Text.Length > 39 Then
            MsgBox("İsim uzunluğunuz sınırı aşmıştır. Lütfen isim uzunluğu en fazla 39 olacak şekilde değiştiriniz.", MsgBoxStyle.Exclamation, "Limit Aşma Hatası")
        Else
            Dim sahip As New EmlakSahibi
            sahip.Isim = txtAd.Text & "," & txtSoyad.Text
            sahip.CepTel = ToTelNo(txtCepTel.Text)
            sahip.EvTel = ToTelNo(txtEvTel.Text)
            sahip.Email = txtEmail.Text
            sahip.ID = SQL.sahipIDGetir(sahip.Email)
            SQL.EmlakSahibiGuncelle(sahip)
            MsgBox("Güncelleme başarıyla gerçekleşmiştir", MsgBoxStyle.Information, "Başarılı İşlem")
        End If
    End Sub

    Private Sub btnYeniDetayEkle_Click(sender As Object, e As EventArgs) Handles btnYeniDetayEkle.Click
        yeniFormAc()
        gbxduzenle()
    End Sub

    ' emlaktipekle ise yeniformac.cbx ta emlaklar eklensin, detayekle ise yeniformac.cbx ta secilen gbx taki cbx lar eklensin
    Private Sub yeniFormAc()
        Dim df As New Form
        Dim btn1 As New Button
        Dim lbl1 As New Label
        Dim lbl2 As New Label
        Dim cbx1 As New ComboBox
        Dim txt1 As New TextBox

        df.Text = "DETAY EKLE" ' secilene gore baslik ciksin
        df.StartPosition = FormStartPosition.CenterScreen
        df.BackColor = Color.CadetBlue
        df.ForeColor = Color.White
        df.FormBorderStyle = FormBorderStyle.FixedToolWindow
        df.Size = New Size(340, 300)

        lbl1.Font = New Font("cambria", 16)
        lbl1.AutoSize = True
        lbl1.Location = New Point(30, 20)
        lbl1.Text = "Kategori Seç"

        cbx1.FlatStyle = FlatStyle.Flat
        cbx1.DropDownStyle = ComboBoxStyle.DropDownList
        cbx1.Location = New Point(35, 60)
        cbx1.Font = New Font("cambria", 14)
        cbx1.Width = 250


        Dim ctrl As New Control
        If secilenGroupbox.Text = "Konut Detayı" Then : ctrl = pnlKonut
        ElseIf secilenGroupbox.Text = "Fabrika Detayı" Then : ctrl = pnlFabrika
        Else : ctrl = secilenGroupbox
        End If

        For Each cb As Control In ctrl.Controls
            If TypeOf cb Is ComboBox Then
                Select Case CType(cb, ComboBox).Name
                    Case "cbxABD_durum", "cbxAVM_durum", "cbxIMA_durum", "cbxBufe_durum", "cbxCiftlik_durum", "cbxDepo_durum", "cbxFabrika_durum", "cbxTuristik_yapiDurum", "cbxKBina_durum", "cbxPlaza_durum", "cbxSinema_durum", "cbxSpa_durum", "cbxSpor_durum"
                        Continue For
                    Case Else
                        cbx1.Items.Add(CType(cb, ComboBox).Name.ToString())
                End Select
            End If
        Next

        lbl2.Font = New Font("cambria", 16)
        lbl2.AutoSize = True
        lbl2.Location = New Point(30, 120)
        lbl2.Text = "Yeni Değer Ekle"

        txt1.Location = New Point(35, 160)
        txt1.Font = New Font("cambria", 14)
        txt1.Width = 250

        btn1.Font = New Font("calibri", 18, FontStyle.Bold)
        btn1.FlatStyle = FlatStyle.Flat
        btn1.FlatAppearance.BorderSize = 0
        btn1.BackColor = Color.White
        btn1.ForeColor = Color.CadetBlue
        btn1.Dock = DockStyle.Bottom
        btn1.Height = 40
        btn1.Cursor = Cursors.Hand
        btn1.Text = "KAYDET"
        AddHandler cbx1.SelectedIndexChanged, Sub()
                                                  Select Case cbx1.Text
                                                      Case "cbxABD_isitma", "cbxIsitma", "cbxAVM_isitma", "cbxIMA_isitma", "cbxDepo_isitma", "cbxFabrika_isitma", "cbxKBina_isitma", "cbxPlaza_isitma", "cbxRadyo_Isitma", "cbxSinema_isitma", "cbxBinaIsitma"
                                                          txt1.MaxLength = 25
                                                      Case "cbxBulunduKat", "cbxPlaza_bulunduguKat", "cbxSinema_bulunduguKat"
                                                          txt1.MaxLength = 12
                                                      Case "cbxOdaSayisi"
                                                          txt1.MaxLength = 3
                                                      Case "cbxBufe_yapiTip"
                                                          txt1.MaxLength = 9
                                                      Case "cbxDepo_tapu", "cbxFabrika_tapu", "cbxKBina_tapu", "cbxPlaza_tapu"
                                                          txt1.MaxLength = 19
                                                      Case "cbxKBina_binaTip"
                                                          txt1.MaxLength = 8
                                                      Case "cbxOto_tur", "cbxSpa_cinsiyet"
                                                          txt1.MaxLength = 6
                                                      Case "cbxSpor_tip", "cbxImarDurumu"
                                                          txt1.MaxLength = 15
                                                      Case "cbxKaks"
                                                          txt1.MaxLength = 10
                                                      Case "cbxTapu"
                                                          txt1.MaxLength = 16
                                                  End Select
                                              End Sub
        AddHandler btn1.Click, Sub()
                                   Dim str As String = ""
                                   Select Case cbx1.Text
                                       Case "cbxABD_isitma", "cbxIsitma", "cbxAVM_isitma", "cbxIMA_isitma", "cbxDepo_isitma", "cbxFabrika_isitma", "cbxKBina_isitma", "cbxPlaza_isitma", "cbxRadyo_Isitma", "cbxSinema_isitma", "cbxBinaIsitma"
                                           str = "Isitma"
                                       Case "cbxBulunduKat", "cbxPlaza_bulunduguKat", "cbxSinema_bulunduguKat"
                                           str = "Bulundugu_Kat"
                                       Case "cbxOdaSayisi"
                                           str = "Oda_Sayisi"
                                       Case "cbxBufe_yapiTip"
                                           str = "Yapi_Tipi"
                                       Case "cbxDepo_tapu", "cbxFabrika_tapu", "cbxKBina_tapu", "cbxPlaza_tapu"
                                           str = "Depo_Tapu_Durumu"
                                       Case "cbxKBina_binaTip"
                                           str = "Bina_Tipi"
                                       Case "cbxOto_tur"
                                           str = "Otopark_Turu"
                                       Case "cbxSpa_cinsiyet"
                                           str = "Cinsiyet"
                                       Case "cbxSpor_tip"
                                           str = "SporTesis_Turu"
                                       Case "cbxImarDurumu"
                                           str = "imar_Durumu"
                                       Case "cbxKaks"
                                           str = "Kaks"
                                       Case "cbxTapu"
                                           str = "Tapu_Durumu"
                                   End Select

                                   If str <> "" And txt1.Text <> "" Then SQL.KategoriEkle(str, txt1.Text)
                                   df.Close()
                                   Me.Refresh()
                               End Sub
        df.Controls.Add(lbl1)
        df.Controls.Add(cbx1)
        df.Controls.Add(lbl2)
        df.Controls.Add(txt1)
        df.Controls.Add(btn1)
        df.ShowDialog()

        Me.Refresh()
    End Sub

    'Private Sub mailKontrol(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
    '    e.Handled = Kontrol.EmailKarakterKontrolu(e)
    'End Sub
End Class