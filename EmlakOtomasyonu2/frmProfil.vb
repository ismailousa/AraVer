Imports System.IO
Public Class frmProfil
    Dim dt As New DataTable ' Tek Satırdan Oluşmalı
    Dim SQL As New SqlEmlak
    Dim bytearray() As Byte
    Dim videoString As String
    Dim ilanAra As Boolean
    Dim ilanNo As String
    Sub New(ByVal datarow As DataRow, Optional ByVal ara As Boolean = False)
        InitializeComponent()
        lblKategori.Text = "Emlak > "
        ilanAra = ara
        If datarow("Satis_Turu_ID") = 1 Then btnSat.Text = "Kirala"
        ilanNo = datarow(0)
        Select Case datarow(5)
            Case 0 ' Konut Tablosu
                dt = SQL.KonutTablosu(datarow(0))
                lblKategori.Text += "Konut > "
            Case 1 ' İşyeri Tablosu
                lblKategori.Text += "İşyeri > "
                Select Case SQL.IsyeriTuru(datarow(0))
                    Case 0
                        dt = SQL.AtolyeBuroDukkanImaAVMTablosu(datarow(0))
                    Case 1
                        dt = SQL.BufeDugunSpaSineOtoTablosu(datarow(0))
                    Case 2
                        dt = SQL.DepoBinaPlazaFabrikaTablosu(datarow(0))
                    Case 3
                        dt = SQL.SporRadyoPazarCiftlikTablosu(datarow(0))
                End Select
            Case 2 ' Arsa Tablosu
                lblKategori.Text += "Arsa > "
                dt = SQL.ArsaTablosu(datarow(0))
            Case 3 ' Bina Tablosu
                lblKategori.Text += "Bina > "
                dt = SQL.BinaTablosu(datarow(0))
            Case 4 ' Turistik Tesis Tablosu
                lblKategori.Text += "Turistik Tesis > "
                dt = SQL.TuristikTesisTablosu(datarow(0))
        End Select
        If dt.Rows(0)("Satis_Turu_ID") Then lblKategori.Text += "Kiralık > " Else lblKategori.Text += "Satılık > "

        ' frmLoad tan tasinmistir
        pnlVideoPlayer.Visible = False
        picKucuk1.BorderStyle = BorderStyle.Fixed3D
        picBuyuk.Image = picKucuk1.Image

        Dim sahiptablosu As New DataTable
        sahiptablosu = SQL.EmlakSahipTablosu(dt.Rows(0)(4))

        alanAd.Text = sahiptablosu.Rows(0)(1).ToString().Split(",")(0)
        alanSoyad.Text = sahiptablosu.Rows(0)(1).ToString().Split(",")(1)
        alanEvTel.Text = sahiptablosu.Rows(0)(3)
        alanCepTel.Text = sahiptablosu.Rows(0)(2)
        alanEmail.Text = sahiptablosu.Rows(0)(4)

        lblBaslik.Text = dt.Rows(0)(2)
        txtAciklama.Text = dt.Rows(0)(1)
        alanFiyat.Text = dt.Rows(0)(16)
        alanIlanTarihi.Text = dt.Rows(0)(3)

        Dim bytearray() As Byte
        Dim bmp As Bitmap = Nothing
        If dt.Rows(0)(6) IsNot DBNull.Value Then
            bytearray = dt.Rows(0)(6)
            picKucuk1.Image = byteArrayToImage(bytearray)
        End If
        If dt.Rows(0)(7) IsNot DBNull.Value Then
            bytearray = dt.Rows(0)(7)
            picKucuk2.Image = byteArrayToImage(bytearray)
        End If
        If dt.Rows(0)(8) IsNot DBNull.Value Then
            bytearray = dt.Rows(0)(8)
            picKucuk3.Image = byteArrayToImage(bytearray)
        End If
        If dt.Rows(0)(9) IsNot DBNull.Value Then
            bytearray = dt.Rows(0)(9)
            picKucuk4.Image = byteArrayToImage(bytearray)
        End If
        If dt.Rows(0)(10) IsNot DBNull.Value Then
            bytearray = dt.Rows(0)(10)
            picKucuk5.Image = byteArrayToImage(bytearray)
        End If
        If dt.Rows(0)(11) IsNot DBNull.Value Then
            bytearray = dt.Rows(0)(11)
            picKucuk6.Image = byteArrayToImage(bytearray)
        End If
        If dt.Rows(0)(12) IsNot DBNull.Value Then
            bytearray = dt.Rows(0)(12)
            picKucuk7.Image = byteArrayToImage(bytearray)
        End If
        If dt.Rows(0)(13) IsNot DBNull.Value Then
            bytearray = dt.Rows(0)(13)
            picKucuk8.Image = byteArrayToImage(bytearray)
        End If
        If dt.Rows(0)(14) IsNot DBNull.Value Then
            videoString = dt.Rows(0)(14)
            btnVideo.Visible = True
            btnFoto.Location = New Point(31, 385)
            btnFoto.Visible = True
        Else
            btnVideo.Visible = False
            btnFoto.Location = New Point(127, 385)
        End If
        txtAdres.Text = dt.Rows(0)("Adres") & vbCrLf & dt.Rows(0)("MahalleAdi") & " / " & dt.Rows(0)("ilceAdi") & " / " & dt.Rows(0)("SehirAdi")
        Select Case dt.Rows(0)(5)
            Case 0 ' Konut
                lblKategori.Text += dt.Rows(0)("Konut_Tip")
                pnlKonut.Visible = True
                alanKonut_aidat.Text = dt.Rows(0)(26)
                alanKonut_banyoSayisi.Text = dt.Rows(0)(22)
                alanKonut_binaYas.Text = dt.Rows(0)(20)
                alanKonut_bulunduguKat.Text = dt.Rows(0)(33)
                If dt.Rows(0)("Satis_Turu_ID") Then lblKonut_kredi.Text = "Depozito"
                If dt.Rows(0)(23) = True Then alanKonut_Esyali.Text = "Evet" Else alanKonut_Esyali.Text = "Hayır"
                alanKonut_isitma.Text = dt.Rows(0)(34)
                alanKonut_KatSayi.Text = dt.Rows(0)(21)
                If dt.Rows(0)(27) = True Then alanKonut_kredi.Text = "Evet" Else alanKonut_kredi.Text = "Hayır"
                If dt.Rows(0)(24) = True Then alanKonut_kullanim.Text = "Evet" Else alanKonut_kullanim.Text = "Hayır"
                alanKonut_m2.Text = dt.Rows(0)(18)
                alanKonut_odaSayi.Text = dt.Rows(0)(32)
                If dt.Rows(0)(25) = True Then alanKonut_siteIceri.Text = "Evet" Else alanKonut_siteIceri.Text = "Hayır"
                If dt.Rows(0)(28) = True Then alanKonut_takasli.Text = "Evet" Else alanKonut_takasli.Text = "Hayır"
            Case 1 ' İşyeri
                lblKategori.Text += dt.Rows(0)("Isyeri_Tipi")
                Select Case dt.Rows(0)("Isyeri_Tipi")
                    Case "Atölye", "Büro", "Dükkan & Mağaza" ' Atölye", "Büro", "Dükkan & Mağaza
                        pnlABD.Visible = True
                        alanABD_aidat.Text = dt.Rows(0)("aidat")
                        alanABD_binaYas.Text = dt.Rows(0)("Bina_Yasi")
                        If dt.Rows(0)("Durumu") Then alanABD_durum.Text = "İkinci El" Else alanABD_durum.Text = "Sıfır"
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanABD_kredi.Text = "Evet" Else alanABD_kredi.Text = "Hayır"
                            lblABD_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanABD_kredi.Text = "Evet" Else alanABD_kredi.Text = "Hayır"
                        End If
                        alanABD_isitma.Text = dt.Rows(0)("Isitma")
                        alanABD_m2.Text = dt.Rows(0)("m2ORacik")
                        alanABD_odaBolumSayi.Text = dt.Rows(0)("oda_bolum_sayisi")
                        If dt.Rows(0)("takasli") Then alanABD_takasli.Text = "Evet" Else alanABD_takasli.Text = "Hayır"
                    Case "AVM" ' AVM
                        pnlAVM.Visible = True
                        alanAVM_asansorSayi.Text = dt.Rows(0)("Asansor_Sayisi")
                        alanAVM_binaYas.Text = dt.Rows(0)("Bina_Yasi")
                        If dt.Rows(0)("Durumu") Then alanAVM_durum.Text = "İkinci El" Else alanAVM_durum.Text = "Sıfır"
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanAVM_kredi.Text = "Evet" Else alanAVM_kredi.Text = "Hayır"
                            lblAVM_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanAVM_kredi.Text = "Evet" Else alanAVM_kredi.Text = "Hayır"
                        End If
                        alanAVM_isitma.Text = dt.Rows(0)("Isitma")
                        alanAVM_katSayi.Text = dt.Rows(0)("kat_Sayisi")
                        alanAVM_m2.Text = dt.Rows(0)("m2ORacik")
                        If dt.Rows(0)("takasli") Then alanAVM_takasli.Text = "Evet" Else alanAVM_takasli.Text = "Hayır"
                    Case "Büfe" ' Büfe
                        pnlBufe.Visible = True
                        If dt.Rows(0)(19) Then alanBufe_durum.Text = "İkinci El" Else alanBufe_durum.Text = "Sıfır"
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanBufe_kredi.Text = "Evet" Else alanBufe_kredi.Text = "Hayır"
                            lblBufe_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanBufe_kredi.Text = "Evet" Else alanBufe_kredi.Text = "Hayır"
                        End If
                        If dt.Rows(0)(25) = True Then alanBufe_kullanim.Text = "Evet" Else alanBufe_kullanim.Text = "Hayır"
                        alanBufe_m2.Text = dt.Rows(0)(21)
                        Select Case dt.Rows(0)("Yapi_Tipi")
                            Case 0
                                alanBufe_yapiTip.Text = "Ahşap"
                            Case 1
                                alanBufe_yapiTip.Text = "Kütük"
                            Case 2
                                alanBufe_yapiTip.Text = "Çelik"
                            Case 3
                                alanBufe_yapiTip.Text = "Prefabrik"
                            Case 4
                                alanBufe_yapiTip.Text = "Betonarme"
                        End Select
                    Case "Çiftlik" ' Çiftlik
                        pnlCiftlik.Visible = True
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanCiftlik_kredi.Text = "Evet" Else alanCiftlik_kredi.Text = "Hayır"
                            lblCiftlik_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanCiftlik_kredi.Text = "Evet" Else alanCiftlik_kredi.Text = "Hayır"
                        End If
                        If dt.Rows(0)("Durumu") Then alanCiftlik_durum.Text = "İkinci El" Else alanCiftlik_durum.Text = "Sıfır"
                        alanCiftlik_m2acik.Text = dt.Rows(0)(22)
                        alanCiftlik_m2kapali.Text = dt.Rows(0)("Kapali_Alan")
                    Case "Depo & Antrepo" ' Depo & Antrepo
                        pnlDepo.Visible = True
                        alanDepo_binaYas.Text = dt.Rows(0)(18)
                        If dt.Rows(0)("Durumu") Then alanDepo_durum.Text = "İkinci El" Else alanDepo_durum.Text = "Sıfır"
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanABD_kredi.Text = "Evet" Else alanDepo_kredi.Text = "Hayır"
                            lblDepo_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanDepo_kredi.Text = "Evet" Else alanDepo_kredi.Text = "Hayır"
                        End If
                        If dt.Rows(0)("Satis_Turu_ID") Then lblDepo_kredi.Text = "Depozito"
                        If dt.Rows(0)("Kullanim_Durumu") = True Then alanDepo_kullanim.Text = "Evet" Else alanDepo_kullanim.Text = "Hayır"
                        If dt.Rows(0)("Takasli") = True Then alanDepo_takas.Text = "Evet" Else alanDepo_takas.Text = "Hayır"
                        alanDepo_m2.Text = dt.Rows(0)("m2ORacik")
                        alanDepo_giris.Text = dt.Rows(0)("Giris_yukseklik")
                        Select Case dt.Rows(0)("Tapu_Durumu")
                            Case 0
                                alanDepo_tapuDurum.Text = "Arsa Tapusu"
                            Case 1
                                alanDepo_tapuDurum.Text = "Kat İrtifaklı Tapu"
                            Case 2
                                alanDepo_tapuDurum.Text = "Kat Mülkiyetli Tapu"
                        End Select
                        If dt.Rows(0)("Zemin_Etudu") Then alanDepo_zeminEtudu.Text = "Var" Else alanDepo_zeminEtudu.Text = "Yok"
                        alanDepo_isitma.Text = dt.Rows(0)("Isitma")
                    Case "Düğün Salonu" ' Düğün Salonu
                        pnlDugun.Visible = True
                        alanDugun_binaYas.Text = dt.Rows(0)("Bina_Yasi")
                        alanDugun_kisiKapasite.Text = dt.Rows(0)("Kisi_kapasitesi")
                        alanDugun_m2.Text = dt.Rows(0)("m2ORacik")
                        alanDugun_masaSayi.Text = dt.Rows(0)("Masa_Sayisi")
                    Case "Fabrika" ' Fabrika
                        pnlFabrika.Visible = True
                        alanFabrika_binaAdet.Text = dt.Rows(0)("Bina_Adedi")
                        alanFabrika_binaYas.Text = dt.Rows(0)("Bina_Yasi")
                        If dt.Rows(0)(19) Then alanFabrika_durum.Text = "İkinci El" Else alanFabrika_durum.Text = "Sıfır"
                        If dt.Rows(0)("Krediye_Uygun") IsNot DBNull.Value Then
                            If dt.Rows(0)("Krediye_Uygun") Then alanFabrika_kredi.Text = "Evet" Else alanFabrika_kredi.Text = "Hayır"
                        Else
                            If dt.Rows(0)("Depozito") Then alanFabrika_kredi.Text = "Evet" Else alanFabrika_kredi.Text = "Hayır"
                        End If
                        If dt.Rows(0)("Satis_Turu_ID") Then lblFabrika_kredi.Text = "Depozito"
                        If dt.Rows(0)(25) = True Then alanFabrika_kullanim.Text = "Evet" Else alanFabrika_kullanim.Text = "Hayır"
                        alanFabrika_isitma.Text = dt.Rows(0)("Isitma")
                        alanFabrika_katSayi.Text = dt.Rows(0)("Kat_Sayisi")
                        alanFabrika_m2acik.Text = dt.Rows(0)(22)
                        Select Case dt.Rows(0)(26)
                            Case 0
                                alanFabrika_tapuDurum.Text = "Arsa Tapusu"
                            Case 1
                                alanFabrika_tapuDurum.Text = "Kat İrtifaklı Tapu"
                            Case 2
                                alanFabrika_tapuDurum.Text = "Kat Mülkiyetli Tapu"
                        End Select
                        If dt.Rows(0)(27) Then alanFabrika_zeminEtudu.Text = "Var" Else alanFabrika_zeminEtudu.Text = "Yok"
                        alanFabrika_girisYukseklik.Text = dt.Rows(0)("Giris_yukseklik")
                        alanFabrika_m2kapali.Text = dt.Rows(0)("Kapali_Alan")
                        alanFabrika_odaBolumSayi.Text = dt.Rows(0)("Oda_Bolum_Sayisi")
                        If dt.Rows(0)("Takasli") Then alanFabrika_takasli.Text = "Evet" Else alanFabrika_takasli.Text = "Hayır"
                    Case "İmalathane" 'İmalathane
                        pnlIMA.Visible = True
                        alanIMA_binaYas.Text = dt.Rows(0)("Bina_Yasi")
                        If dt.Rows(0)(19) Then alanIMA_durum.Text = "İkinci El" Else alanIMA_durum.Text = "Sıfır"
                        If dt.Rows(0)(21) Then alanIMA_kredi.Text = "Evet" Else alanIMA_kredi.Text = "Hayır"
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanIMA_kredi.Text = "Evet" Else alanIMA_kredi.Text = "Hayır"
                            lblIMA_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanIMA_kredi.Text = "Evet" Else alanIMA_kredi.Text = "Hayır"
                        End If
                        alanIMA_isitma.Text = dt.Rows(0)("Isitma")
                        alanIMA_m2.Text = dt.Rows(0)("m2ORacik")
                        alanIMA_odaBolumSayi.Text = dt.Rows(0)("Oda_Bolum_Sayisi")
                        If dt.Rows(0)("Takasli") Then alanIMA_takasli.Text = "Evet" Else alanIMA_takasli.Text = "Hayır"
                    Case "Komple Bina" ' Komple Bina
                        pnlKBina.Visible = True
                        Select Case dt.Rows(0)("Bina_Tipi_ID")
                            Case 0
                                alanKBina_binaTip.Text = "Apartman"
                            Case 1
                                alanKBina_binaTip.Text = "Plaza"
                            Case 2
                                alanKBina_binaTip.Text = "İş Hanı"
                            Case 3
                                alanKBina_binaTip.Text = "Müstakil"
                            Case 4
                                alanKBina_binaTip.Text = "Villa"
                        End Select
                        alanKBina_binaYas.Text = dt.Rows(0)("Bina_Yasi")
                        If dt.Rows(0)(19) Then alanKBina_durum.Text = "İkinci El" Else alanKBina_durum.Text = "Sıfır"
                        If dt.Rows(0)(21) Then alanKBina_kredi.Text = "Evet" Else alanKBina_kredi.Text = "Hayır"
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanKBina_kredi.Text = "Evet" Else alanKBina_kredi.Text = "Hayır"
                            lblKBina_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanKBina_kredi.Text = "Evet" Else alanKBina_kredi.Text = "Hayır"
                        End If
                        If dt.Rows(0)(25) = True Then alanKBina_kullanim.Text = "Evet" Else alanKBina_kullanim.Text = "Hayır"
                        alanKBina_isitma.Text = dt.Rows(0)("Isitma")
                        alanKBina_katSayi.Text = dt.Rows(0)("Kat_Sayisi")
                        alanKBina_m2.Text = dt.Rows(0)(22)
                        Select Case dt.Rows(0)(26)
                            Case 0
                                alanKBina_tapuDurum.Text = "Arsa Tapusu"
                            Case 1
                                alanKBina_tapuDurum.Text = "Kat İrtifaklı Tapu"
                            Case 2
                                alanKBina_tapuDurum.Text = "Kat Mülkiyetli Tapu"
                        End Select
                        If dt.Rows(0)(27) Then alanKBina_zeminEtudu.Text = "Var" Else alanKBina_zeminEtudu.Text = "Yok"
                    Case "Otopark" ' Otopark
                        pnlOtopark.Visible = True
                        alanOtopark_aracKapasite.Text = dt.Rows(0)("Arac_Sayisi")
                        alanOtopark_binaYas.Text = dt.Rows(0)("Bina_Yasi")
                        alanOtopark_katSayi.Text = dt.Rows(0)("Kat_Sayisi")
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanOtopark_kredi.Text = "Evet" Else alanOtopark_kredi.Text = "Hayır"
                            lblOto_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanOtopark_kredi.Text = "Evet" Else alanOtopark_kredi.Text = "Hayır"
                        End If
                        alanOtopark_m2.Text = dt.Rows(0)("m2ORacik")
                        Select Case dt.Rows(0)("Otopark_Turu")
                            Case 0
                                alanOtopark_tur.Text = "Açık"
                            Case 1
                                alanOtopark_tur.Text = "Kapalı"
                            Case 2
                                alanOtopark_tur.Text = "Hepsi"
                        End Select
                    Case "Pazar Yeri" ' Pazar Yeri
                        pnlPazar.Visible = True
                        alanPazar_m2.Text = dt.Rows(0)("m2ORacik")
                        If dt.Rows(0)("Takasli") Then alanPazar_takasli.Text = "Evet" Else alanPazar_takasli.Text = "Hayır"
                    Case "Plaza Katı" ' Plaza Katı
                        pnlPlaza.Visible = True
                        alanPlaza_aidat.Text = dt.Rows(0)("Aidat")
                        alanPlaza_binaYas.Text = dt.Rows(0)("Bina_Yasi")
                        alanPlaza_bulunduguKat.Text = SQL.BulundugKatString(dt.Rows(0)("Bulundugu_Kat"))
                        If dt.Rows(0)(19) Then alanPlaza_durum.Text = "İkinci El" Else alanPlaza_durum.Text = "Sıfır"
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanPlaza_kredi.Text = "Evet" Else alanPlaza_kredi.Text = "Hayır"
                            lblPlaza_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanPlaza_kredi.Text = "Evet" Else alanPlaza_kredi.Text = "Hayır"
                        End If
                        If dt.Rows(0)(25) = True Then alanPlaza_kullanim.Text = "Evet" Else alanKBina_kullanim.Text = "Hayır"
                        alanPlaza_isitma.Text = dt.Rows(0)("Isitma")
                        alanPlaza_katSayi.Text = dt.Rows(0)("Kat_Sayisi")
                        alanPlaza_m2.Text = dt.Rows(0)(22)
                        alanPlaza_odaBolumSayi.Text = dt.Rows(0)("Oda_Bolum_Sayisi")
                        If dt.Rows(0)("Takasli") Then alanPlaza_takasli.Text = "Evet" Else alanPlaza_takasli.Text = "Hayır"
                        Select Case dt.Rows(0)(26)
                            Case 0
                                alanPlaza_tapuDurum.Text = "Arsa Tapusu"
                            Case 1
                                alanPlaza_tapuDurum.Text = "Kat İrtifaklı Tapu"
                            Case 2
                                alanPlaza_tapuDurum.Text = "Kat Mülkiyetli Tapu"
                        End Select
                        If dt.Rows(0)(27) Then alanPlaza_zeminEtudu.Text = "Var" Else alanPlaza_zeminEtudu.Text = "Yok"
                    Case "Radyo İstasyonu" ' Radyo İstasyonu
                        pnlRadyo.Visible = True
                        If dt.Rows(0)(21) Then alanRadyo_kredi.Text = "Evet" Else alanRadyo_kredi.Text = "Hayır"
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanRadyo_kredi.Text = "Evet" Else alanRadyo_kredi.Text = "Hayır"
                            lblRadyo_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanRadyo_kredi.Text = "Evet" Else alanRadyo_kredi.Text = "Hayır"
                        End If
                        alanRadyo_isitma.Text = SQL.IsitmaString(dt.Rows(0)("Isitma_ID"))
                        alanRadyo_m2.Text = dt.Rows(0)("m2ORacik")
                        If dt.Rows(0)("Takasli") Then alanRadyo_takasli.Text = "Evet" Else alanRadyo_takasli.Text = "Hayır"
                    Case "Sinema" ' Sinema
                        pnlSinema.Visible = True
                        alanSinema_binaYas.Text = dt.Rows(0)("Bina_Yasi")
                        alanSinema_bulunduguKat.Text = dt.Rows(0)("Bulundugu_Kat")
                        If dt.Rows(0)("Durumu") Then alanSinema_durum.Text = "Sıfır" Else alanSinema_durum.Text = "İkinci El"
                        alanSinema_isitma.Text = SQL.IsitmaString(dt.Rows(0)("Isitma_ID"))
                        alanSinema_katSayi.Text = dt.Rows(0)("Kat_Sayisi")
                        alanSinema_kisiKapasite.Text = dt.Rows(0)("Kisi_kapasitesi")
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanSinema_kredi.Text = "Evet" Else alanSinema_kredi.Text = "Hayır"
                            lblSinema_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanSinema_kredi.Text = "Evet" Else alanSinema_kredi.Text = "Hayır"
                        End If
                        If dt.Rows(0)("Kullanim_Durumu") Then alanSinema_kullanim.Text = "Evet" Else alanSinema_kullanim.Text = "Hayır"
                        alanSinema_m2.Text = dt.Rows(0)("m2ORacik")
                        alanSinema_odaBolumSayi.Text = dt.Rows(0)("Oda_bolum_Sayisi")
                        alanSinema_tavanYukseklik.Text = dt.Rows(0)("Tavan_Yuksekligi")
                        If dt.Rows(0)("Takasli") Then alanSinema_takasli.Text = "Evet" Else alanSinema_takasli.Text = "Hayır"
                    Case "Spa, Hamam & Sauna" ' Spa, Hamam & Sauna
                        pnlSpa.Visible = True
                        alanSpa_binaYas.Text = dt.Rows(0)("Bina_Yasi")
                        Select Case dt.Rows(0)("Cinsiyet")
                            Case 0
                                alanSpa_cinsiyet.Text = "Erkek"
                            Case 1
                                alanSpa_cinsiyet.Text = "Bayan"
                            Case 2
                                alanSpa_cinsiyet.Text = "Unisex"
                        End Select
                        If dt.Rows(0)("Durumu") Then alanSpa_durum.Text = "Sıfır" Else alanSpa_durum.Text = "İkinci El"
                        alanSpa_kisiKapasite.Text = dt.Rows(0)("Kisi_kapasitesi")
                        If dt.Rows(0)("Krediye_Uygun") IsNot DBNull.Value Then
                            If dt.Rows(0)("Krediye_Uygun") Then alanSpa_kredi.Text = "Evet" Else alanSpa_kredi.Text = "Hayır"
                        Else
                            If dt.Rows(0)("Depozito") Then alanSpa_kredi.Text = "Evet" Else alanSpa_kredi.Text = "Hayır"
                        End If
                        If dt.Rows(0)("Satis_Turu_ID") Then lblSpa_kredi.Text = "Depozito"
                        If dt.Rows(0)("Kullanim_Durumu") Then alanSpa_kullanim.Text = "Evet" Else alanSpa_kullanim.Text = "Hayır"
                        alanSpa_m2.Text = dt.Rows(0)("m2ORacik")
                        alanSpa_odaBolumSayi.Text = dt.Rows(0)("Oda_bolum_Sayisi")
                    Case "Spor Tesisi" ' Spor Tesisi
                        pnlSpor.Visible = True
                        alanSpor_binaYas.Text = dt.Rows(0)("Bina_Yasi")
                        If dt.Rows(0)("Durumu") Then alanSpor_durum.Text = "Sıfır" Else alanSpor_durum.Text = "İkinci El"
                        If dt.Rows(0)("Satis_Turu_ID") Then
                            If dt.Rows(0)("depozito") Then alanSpor_kredi.Text = "Evet" Else alanSpor_kredi.Text = "Hayır"
                            lblSpor_kredi.Text = "Depozito"
                        Else
                            If dt.Rows(0)("Krediye_Uygun") Then alanSpor_kredi.Text = "Evet" Else alanSpor_kredi.Text = "Hayır"
                        End If
                        If dt.Rows(0)("Kullanim_Durumu") Then alanSpor_kullanim.Text = "Evet" Else alanSpor_kullanim.Text = "Hayır"
                        alanSpor_m2.Text = dt.Rows(0)("m2ORacik")
                        Select Case dt.Rows(0)("SporTesis_Tipi")
                            Case 0
                                alanSpor_tip.Text = "Komple Tesis"
                            Case 1
                                alanSpor_tip.Text = "Spor Salonu"
                            Case 2
                                alanSpor_tip.Text = "Yarış Pisti"
                            Case 3
                                alanSpor_tip.Text = "Halı & Çim Saha"
                        End Select
                End Select
            Case 2 ' Arsa
                pnlArsa.Visible = True
                alanArsa_adaNo.Text = dt.Rows(0)(21)
                alanArsa_gabari.Text = dt.Rows(0)(31)
                alanArsa_imarDurum.Text = dt.Rows(0)(30)
                alanArsa_kaks.Text = dt.Rows(0)(32)
                If dt.Rows(0)("Satis_Turu_ID") Then
                    If dt.Rows(0)("depozito") Then alanArsa_kredi.Text = "Evet" Else alanArsa_kredi.Text = "Hayır"
                    lblArsa_kredi.Text = "Depozito"
                Else
                    If dt.Rows(0)("Krediye_Uygun") Then alanArsa_kredi.Text = "Evet" Else alanArsa_kredi.Text = "Hayır"
                End If
                If dt.Rows(0)(22) = True Then alanArsa_katKarsiligi.Text = "Evet" Else alanArsa_katKarsiligi.Text = "Hayır"
                alanArsa_m2.Text = dt.Rows(0)(18)
                alanArsa_m2Fiyat.Text = CInt(dt.Rows(0)(16) / dt.Rows(0)(18))
                alanArsa_paftaNo.Text = dt.Rows(0)(20)
                alanArsa_parselNo.Text = dt.Rows(0)(19)
                If dt.Rows(0)(24) = True Then alanArsa_takasli.Text = "Evet" Else alanArsa_takasli.Text = "Hayır"
                alanArsa_tapuDurum.Text = dt.Rows(0)(33)
            Case 3 ' Bina
                pnlBina.Visible = True

                If dt.Rows(0)("Satis_Turu_ID") Then
                    If dt.Rows(0)("depozito") Then alanBina_kredi.Text = "Evet" Else alanBina_kredi.Text = "Hayır"
                    lblBina_kredi.Text = "Depozito"
                Else
                    If dt.Rows(0)("Krediye_Uygun") Then alanBina_kredi.Text = "Evet" Else alanBina_kredi.Text = "Hayır"
                End If
                alanBina_binaYas.Text = dt.Rows(0)(18)
                alanBina_birKattakiDaire.Text = dt.Rows(0)(19)
                alanBina_isitma.Text = dt.Rows(0)(27)
                alanBina_katSayi.Text = dt.Rows(0)(21)
                alanBina_m2.Text = dt.Rows(0)(20)
                If dt.Rows(0)(23) = True Then alanBina_takasli.Text = "Evet" Else alanBina_takasli.Text = "Hayır"

            Case 4 ' Turistik Tesis
                lblKategori.Text += dt.Rows(0)("TT_Tip")
                pnlTuristik.Visible = True
                Select Case dt.Rows(0)("TT_Tip")
                    Case "Otel", "Tatil Köyü"
                        lblTuristik_yildizSayi.Visible = True
                        alanTuristik_yildizSayi.Visible = True
                        alanTuristik_yildizSayi.Text = dt.Rows(0)(18)
                        TuristikAlanDoldur()
                    Case "Apart Otel"
                        lblTuristik_apartSayi.Visible = True
                        alanTuristik_apartSayi.Visible = True
                        alanTuristik_apartSayi.Text = dt.Rows(0)(19)
                        TuristikAlanDoldur()
                    Case "Butik Otel", "Motel", "Pansiyon"
                        TuristikAlanDoldur()
                    Case "Kamp Yeri"
                        lblTuristik_topArazi.Visible = True
                        alanTuristik_toparazi.Visible = True
                        alanTuristik_toparazi.Text = dt.Rows(0)("Kapali_Alan")
                    Case "Plaj"
                        lblTuristik_m2.Visible = True
                        alanTuristik_m2.Visible = True
                        lblTuristik_kapasite.Visible = True
                        alanTuristik_kapasite.Visible = True
                        alanTuristik_m2.Text = dt.Rows(0)("Kapali_Alan")
                        alanTuristik_kapasite.Text = dt.Rows(0)("yatak_Sayisi")
                End Select
        End Select
        picBuyuk.Image = picKucuk1.Image
    End Sub
    Private Sub btnGeri_Click(sender As Object, e As EventArgs) Handles btnGeri.Click
        If ilanAra = True Then
            Dim frm As New frmIlanAra
            Me.Hide()
            frm.ShowDialog()
        End If
        Me.Close()
    End Sub
    Public Function byteArrayToImage(byteArrayIn As Byte()) As Image
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        Dim returnImage As Image = Image.FromStream(New MemoryStream(byteArrayIn))
        Return returnImage
    End Function
    Private Sub TuristikAlanDoldur()
        lblTuristik_odaSayi.Visible = True
        alanTurisitk_odaSayi.Visible = True
        lblTuristik_binaYas.Visible = True
        alanTuristik_binaYas.Visible = True
        lblTuristik_katSayi.Visible = True
        alanTuristik_katSayi.Visible = True
        lblTuristik_m2acik.Visible = True
        alanTuristik_m2acik.Visible = True
        lblTuristik_m2kapali.Visible = True
        alanTuristik_m2kapali.Visible = True
        lblTuristik_yapiDurum.Visible = True
        alanTuristik_yapiDurum.Visible = True
        lblTuristik_yatakSayi.Visible = True
        alanTuristik_yatakSayi.Visible = True
        lblTuristik_kredi.Visible = True
        alanTuristik_kredi.Visible = True
        lblTuristik_zeminEtudu.Visible = True
        alanTuristik_zeminEtudu.Visible = True

        If dt.Rows(0)("Satis_Turu_ID") Then lblBina_kredi.Text = "Depozito"

        alanTurisitk_odaSayi.Text = dt.Rows(0)(20)
        alanTuristik_binaYas.Text = dt.Rows(0)(23)
        alanTuristik_katSayi.Text = dt.Rows(0)(22)
        alanTuristik_m2acik.Text = dt.Rows(0)(24)
        alanTuristik_m2kapali.Text = dt.Rows(0)(25)
        If dt.Rows(0)(27) Then alanTuristik_yapiDurum.Text = "İkinci El" Else alanTuristik_yapiDurum.Text = "Sıfır"
        alanTuristik_yatakSayi.Text = dt.Rows(0)(21)
        If dt.Rows(0)(26) = True Then alanTuristik_zeminEtudu.Text = "Evet" Else alanTuristik_zeminEtudu.Text = "Hayır"
        If dt.Rows(0)(28) = True Then alanTuristik_kredi.Text = "Evet" Else alanTuristik_kredi.Text = "Hayır"
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        Dim imgOriginal(8) As Image
        imgOriginal(1) = picKucuk1.Image
        imgOriginal(2) = picKucuk2.Image
        imgOriginal(3) = picKucuk3.Image
        imgOriginal(4) = picKucuk4.Image
        imgOriginal(5) = picKucuk5.Image
        imgOriginal(6) = picKucuk6.Image
        imgOriginal(7) = picKucuk7.Image
        imgOriginal(8) = picKucuk8.Image

        pnlGalleryMiddle.Visible = True
        pnlGalleryMiddle.Location = New Point(275, 65)
        pnlGalleryMiddle.Size = New Size(800, 450)
        pnlGalleryBottom.Visible = True
        pnlGalleryBottom.Location = New Point(0, 557)
        pnlGalleryBottom.Size = New Size(1366, 200)
        Dim frm_gallery As New frmGallery(imgOriginal, lblBaslik.Text)
        frm_gallery.ShowDialog()
        pnlGalleryMiddle.Visible = False
        pnlGalleryBottom.Visible = False
    End Sub

    Private Sub btnVideo_Click(sender As Object, e As EventArgs) Handles btnVideo.Click
        pnlVideoPlayer.Visible = True
        pnlVideoPlayer.Location = New Point(275, 120)
        pnlVideoPlayer.Size = New Size(800, 507)
        Dim frm_gallery As New frmGallery(videoString, lblBaslik.Text)
        frm_gallery.ShowDialog()
        pnlVideoPlayer.Visible = False
    End Sub

    Private Sub picKucuk_Click(sender As Object, e As EventArgs) Handles picKucuk1.Click, picKucuk2.Click, picKucuk3.Click, picKucuk4.Click, picKucuk5.Click, picKucuk6.Click, picKucuk7.Click, picKucuk8.Click
        picBuyuk.Image = sender.image
        picKucuk1.BorderStyle = BorderStyle.None
        picKucuk2.BorderStyle = BorderStyle.None
        picKucuk3.BorderStyle = BorderStyle.None
        picKucuk4.BorderStyle = BorderStyle.None
        picKucuk5.BorderStyle = BorderStyle.None
        picKucuk6.BorderStyle = BorderStyle.None
        picKucuk7.BorderStyle = BorderStyle.None
        picKucuk8.BorderStyle = BorderStyle.None
        sender.borderstyle = BorderStyle.Fixed3D
    End Sub
    Private Sub dosyayaYaz()
        Dim dosyaYolu As String = Nothing
        Select Case ilanNo.Substring(0, 1)
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
        Dim file As New FileStream(dosyaYolu, FileMode.Append)
        Dim yaz As New StreamWriter(file)
        yaz.WriteLine(ilanNo.Substring(4))
        yaz.Close()
    End Sub
    Private Sub btnDegistir_Click(sender As Object, e As EventArgs) Handles btnDegistir.Click
        Dim gbxAdi As String = Nothing
        Select Case dt.Rows(0)(5)
            Case 0 ' Konut
                gbxAdi = "gbxKonutDetay"
            Case 1 ' İşyeri
                Select Case dt.Rows(0)("Isyeri_Tipi")
                    Case "Atölye", "Büro", "Dükkan & Mağaza" ' Atölye Büra Dükkan & Mağaza
                        gbxAdi = "gbxABD"
                    Case "AVM" ' AVM
                        gbxAdi = "gbxAVM"
                    Case "Büfe" ' Büfe
                        gbxAdi = "gbxBufe"
                    Case "Çiftlik" ' Çiftlik
                        gbxAdi = "gbxCiftlik"
                    Case "Depo & Antrepo" ' Depo & Antrepo
                        gbxAdi = "gbxDepo"
                    Case "Düğün Salonu" ' Düğün Salonu
                        gbxAdi = "gbxDugun"
                    Case "Fabrika" ' Fabrika
                        gbxAdi = "gbxFabrika"
                    Case "İmalathane" 'İmalathane
                        gbxAdi = "gbxImalat"
                    Case "Komple Bina" ' Komple Bina
                        gbxAdi = "gbxKBina"
                    Case "Otopark" ' Otopark
                        gbxAdi = "gbxOtopark"
                    Case "Pazar Yeri" ' Pazar Yeri
                        gbxAdi = "gbxPazar"
                    Case "Plaza Katı" ' Plaza Katı
                        gbxAdi = "gbxPlaza"
                    Case "Radyo İstasyonu" ' Radyo İstasyonu
                        gbxAdi = "gbxRadyo"
                    Case "Sinema" ' Sinema
                        gbxAdi = "gbxSinema"
                    Case "Spa, Hamam & Sauna" ' Spa, Hamam & Sauna
                        gbxAdi = "gbxSpa"
                    Case "Spor Tesisi" ' Spor Tesisi
                        gbxAdi = "gbxSpor"
                End Select
            Case 2 ' Arsa
                gbxAdi = "gbxArsaDetay"
            Case 3 ' Bina
                gbxAdi = "gbxBinaDetay"
            Case 4 ' Turistik Tesis
                gbxAdi = "gbxTuristikTesis"
        End Select
        Dim ilanver As New cbxBulunduguKat(gbxAdi, dt.Rows(0))
        Me.Hide()
        ilanver.ShowDialog()
        If ilanAra Then
            Dim frilanara As New frmIlanAra
            frilanara.ShowDialog()
        End If
        Me.Close()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        Select Case MsgBox("Silmek istediğinize emin misiniz?", MsgBoxStyle.YesNoCancel, "Uyarı")
            Case vbYes
                dosyayaYaz()
                SQL.EmlakSil(dt.Rows(0)(0))
                Dim frm As New frmIlanAra
                Me.Hide()
                frm.ShowDialog()
                Me.Close()
            Case vbNo
                Dim frm As New frmIlanAra
                Me.Hide()
                frm.ShowDialog()
                Me.Close()
            Case vbCancel
                'HiçBirşey Yapma
        End Select
    End Sub

    Private Sub btnSat_Click(sender As Object, e As EventArgs) Handles btnSat.Click
        Dim mesaj As String
        If btnSat.Text = "Satın Al" Then mesaj = "Satış" Else mesaj = "Kiralama"
        If MsgBox(mesaj & " işlemi gerçekleştirmek istediğinize emin misiniz?", MsgBoxStyle.YesNo, mesaj & " İşlemi") = vbYes Then
            SQL.SatYadaKirala(ilanNo)
            MsgBox(mesaj & " işlemi başarılı bir şekilde gerçekleşti", MsgBoxStyle.Information, "Bilgilendirme")
            Dim frm As New frmIlanAra
            Me.Hide()
            frm.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class