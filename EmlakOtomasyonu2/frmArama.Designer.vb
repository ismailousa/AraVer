<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArama))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EmlakOtomasyonuDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmlakOtomasyonuDataSet = New EmlakOtomasyonu2.EmlakOtomasyonuDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlKonutFiltre = New System.Windows.Forms.Panel()
        Me.btnKonut_Kredi = New System.Windows.Forms.Button()
        Me.btnKonut_FotoVideo = New System.Windows.Forms.Button()
        Me.pnlKonut_fotoVideo = New System.Windows.Forms.Panel()
        Me.chKonutFoto_video = New System.Windows.Forms.CheckBox()
        Me.chkKonutFoto_foto = New System.Windows.Forms.CheckBox()
        Me.btnKonut_IlanTarihi = New System.Windows.Forms.Button()
        Me.btnKonut_Takas = New System.Windows.Forms.Button()
        Me.btnKonut_SiteIcerisinde = New System.Windows.Forms.Button()
        Me.pnlKonut_kredi = New System.Windows.Forms.Panel()
        Me.rbKonutKredi_hayir = New System.Windows.Forms.RadioButton()
        Me.rbKonutKredi_evet = New System.Windows.Forms.RadioButton()
        Me.pnlKonut_takas = New System.Windows.Forms.Panel()
        Me.rbKonutTakas_Hayir = New System.Windows.Forms.RadioButton()
        Me.rbKonutTakas_evet = New System.Windows.Forms.RadioButton()
        Me.pnlKonut_Kullanimda = New System.Windows.Forms.Panel()
        Me.rbKonutKullanimda_Hayir = New System.Windows.Forms.RadioButton()
        Me.rbKonutKullanimda_Evet = New System.Windows.Forms.RadioButton()
        Me.pnlKonut_ilanTarihi = New System.Windows.Forms.Panel()
        Me.rbKonutIlan_30gun = New System.Windows.Forms.RadioButton()
        Me.rbKonutIlan_15gun = New System.Windows.Forms.RadioButton()
        Me.rbKonutIlan_7gun = New System.Windows.Forms.RadioButton()
        Me.rbKonutIlan_3gun = New System.Windows.Forms.RadioButton()
        Me.rbKonutIlan_24saat = New System.Windows.Forms.RadioButton()
        Me.pnlKonut_siteIcerisinde = New System.Windows.Forms.Panel()
        Me.rbKonutSite_Hayir = New System.Windows.Forms.RadioButton()
        Me.rbKonutSite_Evet = New System.Windows.Forms.RadioButton()
        Me.btnKonut_Adres = New System.Windows.Forms.Button()
        Me.btnKonut_BanyoSayi = New System.Windows.Forms.Button()
        Me.btnKonut_Kullanimda = New System.Windows.Forms.Button()
        Me.pnlKonut_Esyali = New System.Windows.Forms.Panel()
        Me.rbKonutEsyali_Hayir = New System.Windows.Forms.RadioButton()
        Me.rbKonutEsyali_Evet = New System.Windows.Forms.RadioButton()
        Me.btnKonut_Buyukluk = New System.Windows.Forms.Button()
        Me.btnKonut_OdaSayi = New System.Windows.Forms.Button()
        Me.btnKonut_BulunduguKat = New System.Windows.Forms.Button()
        Me.btnKonut_KatSayi = New System.Windows.Forms.Button()
        Me.btnKonut_Isitma = New System.Windows.Forms.Button()
        Me.btnKonut_Esyali = New System.Windows.Forms.Button()
        Me.pnlKonut_Fiyat = New System.Windows.Forms.Panel()
        Me.txtKonut_MaxTL = New System.Windows.Forms.TextBox()
        Me.txtKonut_MinTL = New System.Windows.Forms.TextBox()
        Me.pnlKonut_binaYas = New System.Windows.Forms.Panel()
        Me.txtKonut_MaxBinaYas3 = New System.Windows.Forms.TextBox()
        Me.txtKonut_MinBinaYas3 = New System.Windows.Forms.TextBox()
        Me.pnlKonut_bulunduguKat = New System.Windows.Forms.Panel()
        Me.cbxKonut_bulunduguKat = New System.Windows.Forms.ComboBox()
        Me.pnlKonut_katSayi = New System.Windows.Forms.Panel()
        Me.txtKonut_MaxKatSayi2 = New System.Windows.Forms.TextBox()
        Me.txtKonut_MinKatSayi2 = New System.Windows.Forms.TextBox()
        Me.pnlKonut_isitma = New System.Windows.Forms.Panel()
        Me.cbxKonut_isitma = New System.Windows.Forms.ComboBox()
        Me.pnlKonut_banyoSayi = New System.Windows.Forms.Panel()
        Me.txtKonut_MaxBanyoSayisi2 = New System.Windows.Forms.TextBox()
        Me.txtKonut_MinBanyoSayisi2 = New System.Windows.Forms.TextBox()
        Me.btnKonut_Fiyat = New System.Windows.Forms.Button()
        Me.btnKonut_BinaYas = New System.Windows.Forms.Button()
        Me.pnlKonut_odaSayi = New System.Windows.Forms.Panel()
        Me.cbxKonut_odaSayi = New System.Windows.Forms.ComboBox()
        Me.pnlKonut_buyukluk = New System.Windows.Forms.Panel()
        Me.txtKonut_MaxBuyukluk = New System.Windows.Forms.TextBox()
        Me.txtKonut_MinBuyukluk = New System.Windows.Forms.TextBox()
        Me.pnlKonut_Adres = New System.Windows.Forms.Panel()
        Me.cbxIl = New System.Windows.Forms.ComboBox()
        Me.cbxMahalle = New System.Windows.Forms.ComboBox()
        Me.cbxIlce = New System.Windows.Forms.ComboBox()
        Me.btnTemizle = New System.Windows.Forms.Button()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.btnSatisTuru = New System.Windows.Forms.Button()
        Me.btnFiyat = New System.Windows.Forms.Button()
        Me.btnAdres = New System.Windows.Forms.Button()
        Me.btnEmlakTipi = New System.Windows.Forms.Button()
        Me.btnEkBilgi = New System.Windows.Forms.Button()
        Me.btnAra = New System.Windows.Forms.Button()
        Me.pnlFiltre = New System.Windows.Forms.Panel()
        Me.pnlBinaFiltre = New System.Windows.Forms.Panel()
        Me.btnBina_isitma = New System.Windows.Forms.Button()
        Me.btnBina_buyukluk = New System.Windows.Forms.Button()
        Me.btnBina_Adres = New System.Windows.Forms.Button()
        Me.btnBina_takas = New System.Windows.Forms.Button()
        Me.btnBina_ilanTarihi = New System.Windows.Forms.Button()
        Me.btnBina_fotoVideo = New System.Windows.Forms.Button()
        Me.pnlBina_birKattakiDaire = New System.Windows.Forms.Panel()
        Me.txtBina_MaxBirKattakiDaire2 = New System.Windows.Forms.TextBox()
        Me.txtBina_MinBirKattakiDaire2 = New System.Windows.Forms.TextBox()
        Me.pnlBina_kredi = New System.Windows.Forms.Panel()
        Me.rbBinaKredi_hayir = New System.Windows.Forms.RadioButton()
        Me.rbBinaKredi_evet = New System.Windows.Forms.RadioButton()
        Me.pnlBina_takas = New System.Windows.Forms.Panel()
        Me.rbBinaTakas_hayir = New System.Windows.Forms.RadioButton()
        Me.rbBinaTakas_evet = New System.Windows.Forms.RadioButton()
        Me.pnlBina_ilanTarihi = New System.Windows.Forms.Panel()
        Me.rbBinaIlan_30gun = New System.Windows.Forms.RadioButton()
        Me.rbBinaIlan_15gun = New System.Windows.Forms.RadioButton()
        Me.rbBinaIlan_7gun = New System.Windows.Forms.RadioButton()
        Me.rbBinaIlan_3gun = New System.Windows.Forms.RadioButton()
        Me.rbBinaIlan_24saat = New System.Windows.Forms.RadioButton()
        Me.pnlBina_fotoVideo = New System.Windows.Forms.Panel()
        Me.chkBina_video = New System.Windows.Forms.CheckBox()
        Me.chkBina_foto = New System.Windows.Forms.CheckBox()
        Me.btnBina_Fiyat = New System.Windows.Forms.Button()
        Me.btnBina_KatSayi = New System.Windows.Forms.Button()
        Me.btnBina_birKattakiDaire = New System.Windows.Forms.Button()
        Me.btnBina_kredi = New System.Windows.Forms.Button()
        Me.pnlBina_fiyat = New System.Windows.Forms.Panel()
        Me.txtBina_MaxTL = New System.Windows.Forms.TextBox()
        Me.txtBina_MinTL = New System.Windows.Forms.TextBox()
        Me.pnlBina_katSayi = New System.Windows.Forms.Panel()
        Me.txtBina_MaxKatSayi3 = New System.Windows.Forms.TextBox()
        Me.txtBina_MinKatSayi3 = New System.Windows.Forms.TextBox()
        Me.pnlBina_adres = New System.Windows.Forms.Panel()
        Me.cbxBina_mahalle = New System.Windows.Forms.ComboBox()
        Me.cbxBina_ilce = New System.Windows.Forms.ComboBox()
        Me.cbxBina_il = New System.Windows.Forms.ComboBox()
        Me.pnlBina_buyukluk = New System.Windows.Forms.Panel()
        Me.txtBina_MaxBuyukluk = New System.Windows.Forms.TextBox()
        Me.txtBina_MinBuyukluk = New System.Windows.Forms.TextBox()
        Me.pnlBina_isitma = New System.Windows.Forms.Panel()
        Me.cbxBina_isitma = New System.Windows.Forms.ComboBox()
        Me.pnlIsyeriFiltre = New System.Windows.Forms.Panel()
        Me.pnlIsyeri_fotoVideo = New System.Windows.Forms.Panel()
        Me.chkIsyeri_video = New System.Windows.Forms.CheckBox()
        Me.chkIsyeri_foto = New System.Windows.Forms.CheckBox()
        Me.btnIsyeri_FotoVideo = New System.Windows.Forms.Button()
        Me.btnIsyeri_Adres = New System.Windows.Forms.Button()
        Me.pnlIsyeri_ilanTarihi = New System.Windows.Forms.Panel()
        Me.rbIsyeriIlan_30gun = New System.Windows.Forms.RadioButton()
        Me.rbIsyeriIlan_15gun = New System.Windows.Forms.RadioButton()
        Me.rbIsyeriIlan_7gun = New System.Windows.Forms.RadioButton()
        Me.rbIsyeriIlan_3gun = New System.Windows.Forms.RadioButton()
        Me.rbIsyeriIlan_24saat = New System.Windows.Forms.RadioButton()
        Me.btnIsyeri_Fiyat = New System.Windows.Forms.Button()
        Me.btnIsyeri_IlanTarihi = New System.Windows.Forms.Button()
        Me.pnlIsyeri_takas = New System.Windows.Forms.Panel()
        Me.rbIsyeriTakas_hayir = New System.Windows.Forms.RadioButton()
        Me.rbIsyeriTakas_evet = New System.Windows.Forms.RadioButton()
        Me.btnIsyeri_Takas = New System.Windows.Forms.Button()
        Me.pnlIsyeri_adres = New System.Windows.Forms.Panel()
        Me.cbxIsyeri_mahalle = New System.Windows.Forms.ComboBox()
        Me.cbxIsyeri_ilce = New System.Windows.Forms.ComboBox()
        Me.cbxIsyeri_il = New System.Windows.Forms.ComboBox()
        Me.pnlIsyeri_fiyat = New System.Windows.Forms.Panel()
        Me.txtIsyeri_MaxTL = New System.Windows.Forms.TextBox()
        Me.txtIsyeri_MinTL = New System.Windows.Forms.TextBox()
        Me.pnlArsaFiltre = New System.Windows.Forms.Panel()
        Me.btnArsa_Adres = New System.Windows.Forms.Button()
        Me.btnArsa_Takas = New System.Windows.Forms.Button()
        Me.btnArsa_IlanTarihi = New System.Windows.Forms.Button()
        Me.btnArsa_FotoVideo = New System.Windows.Forms.Button()
        Me.pnlArsa_kredi = New System.Windows.Forms.Panel()
        Me.rbArsaKredi_hayir = New System.Windows.Forms.RadioButton()
        Me.rbArsaKredi_evet = New System.Windows.Forms.RadioButton()
        Me.pnlArsa_takas = New System.Windows.Forms.Panel()
        Me.rbArsaTakas_hayir = New System.Windows.Forms.RadioButton()
        Me.rbArsaTakas_evet = New System.Windows.Forms.RadioButton()
        Me.pnlArsa_fotoVideo = New System.Windows.Forms.Panel()
        Me.chkArsa_video = New System.Windows.Forms.CheckBox()
        Me.chkArsa_foto = New System.Windows.Forms.CheckBox()
        Me.pnlArsa_ilanTarih = New System.Windows.Forms.Panel()
        Me.rbArsaIlan_30gun = New System.Windows.Forms.RadioButton()
        Me.rbArsaIlan_15gun = New System.Windows.Forms.RadioButton()
        Me.rbArsaIlan_7gun = New System.Windows.Forms.RadioButton()
        Me.rbArsaIlan_3gun = New System.Windows.Forms.RadioButton()
        Me.rbArsaIlan_24saat = New System.Windows.Forms.RadioButton()
        Me.btnArsa_Gabari = New System.Windows.Forms.Button()
        Me.btnArsa_TapuDurumu = New System.Windows.Forms.Button()
        Me.btnArsa_KatKarsilik = New System.Windows.Forms.Button()
        Me.pnlArsa_Gabari = New System.Windows.Forms.Panel()
        Me.cbxArsa_gabari = New System.Windows.Forms.ComboBox()
        Me.pnlArsa_kaks = New System.Windows.Forms.Panel()
        Me.cbxArsa_kaks = New System.Windows.Forms.ComboBox()
        Me.btnArsa_Kredi = New System.Windows.Forms.Button()
        Me.pnlArsa_katKarsiligi = New System.Windows.Forms.Panel()
        Me.rbArsaKat_hayir = New System.Windows.Forms.RadioButton()
        Me.rbArsaKat_evet = New System.Windows.Forms.RadioButton()
        Me.pnlArsa_tapuDurum = New System.Windows.Forms.Panel()
        Me.cbxArsa_tapuDurum = New System.Windows.Forms.ComboBox()
        Me.btnArsa_Buyukluk = New System.Windows.Forms.Button()
        Me.btnArsa_m2Fiyati = New System.Windows.Forms.Button()
        Me.pnlArsa_imarDurum = New System.Windows.Forms.Panel()
        Me.cbxArsa_imarDurum = New System.Windows.Forms.ComboBox()
        Me.btnArsa_Kaks = New System.Windows.Forms.Button()
        Me.pnlArsa_m2Fiyat = New System.Windows.Forms.Panel()
        Me.txtArsa_MaxM4Fiyat = New System.Windows.Forms.TextBox()
        Me.txtArsa_MinM4Fiyat = New System.Windows.Forms.TextBox()
        Me.pnlArsa_buyukluk = New System.Windows.Forms.Panel()
        Me.txtArsa_MaxBuyukluk = New System.Windows.Forms.TextBox()
        Me.txtArsa_MinBuyukluk = New System.Windows.Forms.TextBox()
        Me.btnArsa_Fiyat = New System.Windows.Forms.Button()
        Me.btnArsa_ImarDurumu = New System.Windows.Forms.Button()
        Me.pnlArsa_fiyat = New System.Windows.Forms.Panel()
        Me.txtArsaFiyat_MaxTL = New System.Windows.Forms.TextBox()
        Me.txtArsaFiyat_MinTL = New System.Windows.Forms.TextBox()
        Me.pnlArsa_adres = New System.Windows.Forms.Panel()
        Me.cbxArsa_mahalle = New System.Windows.Forms.ComboBox()
        Me.cbxArsa_ilce = New System.Windows.Forms.ComboBox()
        Me.cbxArsa_il = New System.Windows.Forms.ComboBox()
        Me.pnlTuristikFiltre = New System.Windows.Forms.Panel()
        Me.btnTuristik_fotoVideo = New System.Windows.Forms.Button()
        Me.btnTuristik_fiyat = New System.Windows.Forms.Button()
        Me.btnTuristik_adres = New System.Windows.Forms.Button()
        Me.btnTuristik_ilanTarihi = New System.Windows.Forms.Button()
        Me.pnlTuristik_adres = New System.Windows.Forms.Panel()
        Me.cbxTuristik_mahalle = New System.Windows.Forms.ComboBox()
        Me.cbxTuristik_ilce = New System.Windows.Forms.ComboBox()
        Me.cbxTuristik_il = New System.Windows.Forms.ComboBox()
        Me.pnlTuristik_fiyat = New System.Windows.Forms.Panel()
        Me.txtTuristik_MaxTL = New System.Windows.Forms.TextBox()
        Me.txtTuristik_MinTL = New System.Windows.Forms.TextBox()
        Me.pnlTuristik_fotoVideo = New System.Windows.Forms.Panel()
        Me.chkTuristik_video = New System.Windows.Forms.CheckBox()
        Me.chkTuristik_foto = New System.Windows.Forms.CheckBox()
        Me.pnlTuristik_ilanTarihi = New System.Windows.Forms.Panel()
        Me.rbTuristikIlan_30gun = New System.Windows.Forms.RadioButton()
        Me.rbTuristikIlan_15gun = New System.Windows.Forms.RadioButton()
        Me.rbTuristikIlan_7gun = New System.Windows.Forms.RadioButton()
        Me.rbTuristikIlan_3gun = New System.Windows.Forms.RadioButton()
        Me.rbTuristikIlan_24saat = New System.Windows.Forms.RadioButton()
        Me.dtgridAramaSonucu = New System.Windows.Forms.DataGridView()
        Me.clmresim1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.clmBaslik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmM2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFiyat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTarih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIlce = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSehirAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmilanno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmaciklama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmilanveren = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmilanturid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmresim2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmresim3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmresim4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmresim5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmresim6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmresim7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmresim8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmVideo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAdres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIslemTamamMi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKonutAcikAlan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBinaYasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKatSayisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKonutBanyoSayisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKonutEsyali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKonutKullanimDurumu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKonutSiteİçi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKonutAidat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKredi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTakasli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMahalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKonutOdaSayisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBulunduguKat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIsitma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSatisTuru = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKonutTip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmArsaParsel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmArsaPafta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmArsaAda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmArsaKatKarsiligi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmArsaImarDurumu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmGbari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmArsaKaks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmArsaTapuDurumu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmArsaMetrekareFiyat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBirKattakiDaireSayisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTOtelYıldız = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTApartSayisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTodaSayisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTYatakSayisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTAcikAlan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTKapaliAlan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTZeminEtudu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTYapiDurum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTToplamArazi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTPlaj_Buyukluk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTPlajKapasite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTTTip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBufeDurum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBufem2ORacik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBudeIsitma_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBufeOda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBudeDurum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTavan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDepozito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMasa_Sayisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmkisiKapasite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAracSayisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCinsiyet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmYapiTipi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIsyeriTipi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSpor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSatisTurID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIsyeri_Tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAsansor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmOtoparkTur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmGiris = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTapuD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBinaAdet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBinaTipID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EmlakOtomasyonuDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmlakOtomasyonuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKonutFiltre.SuspendLayout()
        Me.pnlKonut_fotoVideo.SuspendLayout()
        Me.pnlKonut_kredi.SuspendLayout()
        Me.pnlKonut_takas.SuspendLayout()
        Me.pnlKonut_Kullanimda.SuspendLayout()
        Me.pnlKonut_ilanTarihi.SuspendLayout()
        Me.pnlKonut_siteIcerisinde.SuspendLayout()
        Me.pnlKonut_Esyali.SuspendLayout()
        Me.pnlKonut_Fiyat.SuspendLayout()
        Me.pnlKonut_binaYas.SuspendLayout()
        Me.pnlKonut_bulunduguKat.SuspendLayout()
        Me.pnlKonut_katSayi.SuspendLayout()
        Me.pnlKonut_isitma.SuspendLayout()
        Me.pnlKonut_banyoSayi.SuspendLayout()
        Me.pnlKonut_odaSayi.SuspendLayout()
        Me.pnlKonut_buyukluk.SuspendLayout()
        Me.pnlKonut_Adres.SuspendLayout()
        Me.pnlFiltre.SuspendLayout()
        Me.pnlBinaFiltre.SuspendLayout()
        Me.pnlBina_birKattakiDaire.SuspendLayout()
        Me.pnlBina_kredi.SuspendLayout()
        Me.pnlBina_takas.SuspendLayout()
        Me.pnlBina_ilanTarihi.SuspendLayout()
        Me.pnlBina_fotoVideo.SuspendLayout()
        Me.pnlBina_fiyat.SuspendLayout()
        Me.pnlBina_katSayi.SuspendLayout()
        Me.pnlBina_adres.SuspendLayout()
        Me.pnlBina_buyukluk.SuspendLayout()
        Me.pnlBina_isitma.SuspendLayout()
        Me.pnlIsyeriFiltre.SuspendLayout()
        Me.pnlIsyeri_fotoVideo.SuspendLayout()
        Me.pnlIsyeri_ilanTarihi.SuspendLayout()
        Me.pnlIsyeri_takas.SuspendLayout()
        Me.pnlIsyeri_adres.SuspendLayout()
        Me.pnlIsyeri_fiyat.SuspendLayout()
        Me.pnlArsaFiltre.SuspendLayout()
        Me.pnlArsa_kredi.SuspendLayout()
        Me.pnlArsa_takas.SuspendLayout()
        Me.pnlArsa_fotoVideo.SuspendLayout()
        Me.pnlArsa_ilanTarih.SuspendLayout()
        Me.pnlArsa_Gabari.SuspendLayout()
        Me.pnlArsa_kaks.SuspendLayout()
        Me.pnlArsa_katKarsiligi.SuspendLayout()
        Me.pnlArsa_tapuDurum.SuspendLayout()
        Me.pnlArsa_imarDurum.SuspendLayout()
        Me.pnlArsa_m2Fiyat.SuspendLayout()
        Me.pnlArsa_buyukluk.SuspendLayout()
        Me.pnlArsa_fiyat.SuspendLayout()
        Me.pnlArsa_adres.SuspendLayout()
        Me.pnlTuristikFiltre.SuspendLayout()
        Me.pnlTuristik_adres.SuspendLayout()
        Me.pnlTuristik_fiyat.SuspendLayout()
        Me.pnlTuristik_fotoVideo.SuspendLayout()
        Me.pnlTuristik_ilanTarihi.SuspendLayout()
        CType(Me.dtgridAramaSonucu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmlakOtomasyonuDataSetBindingSource
        '
        Me.EmlakOtomasyonuDataSetBindingSource.DataSource = Me.EmlakOtomasyonuDataSet
        Me.EmlakOtomasyonuDataSetBindingSource.Position = 0
        '
        'EmlakOtomasyonuDataSet
        '
        Me.EmlakOtomasyonuDataSet.DataSetName = "EmlakOtomasyonuDataSet"
        Me.EmlakOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EmlakOtomasyonu2.My.Resources.Resources.background1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 640)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1366, 100)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'pnlKonutFiltre
        '
        Me.pnlKonutFiltre.AutoSize = True
        Me.pnlKonutFiltre.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_Kredi)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_FotoVideo)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_fotoVideo)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_IlanTarihi)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_Takas)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_SiteIcerisinde)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_kredi)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_takas)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_Kullanimda)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_ilanTarihi)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_siteIcerisinde)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_Adres)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_BanyoSayi)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_Kullanimda)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_Esyali)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_Buyukluk)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_OdaSayi)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_BulunduguKat)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_KatSayi)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_Isitma)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_Esyali)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_Fiyat)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_binaYas)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_bulunduguKat)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_katSayi)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_isitma)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_banyoSayi)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_Fiyat)
        Me.pnlKonutFiltre.Controls.Add(Me.btnKonut_BinaYas)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_odaSayi)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_buyukluk)
        Me.pnlKonutFiltre.Controls.Add(Me.pnlKonut_Adres)
        Me.pnlKonutFiltre.Location = New System.Drawing.Point(5, 0)
        Me.pnlKonutFiltre.Name = "pnlKonutFiltre"
        Me.pnlKonutFiltre.Size = New System.Drawing.Size(250, 708)
        Me.pnlKonutFiltre.TabIndex = 17
        '
        'btnKonut_Kredi
        '
        Me.btnKonut_Kredi.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_Kredi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_Kredi.FlatAppearance.BorderSize = 0
        Me.btnKonut_Kredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_Kredi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_Kredi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_Kredi.Image = CType(resources.GetObject("btnKonut_Kredi.Image"), System.Drawing.Image)
        Me.btnKonut_Kredi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_Kredi.Location = New System.Drawing.Point(5, 425)
        Me.btnKonut_Kredi.Name = "btnKonut_Kredi"
        Me.btnKonut_Kredi.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_Kredi.TabIndex = 12
        Me.btnKonut_Kredi.Text = "Krediye Uygun"
        Me.btnKonut_Kredi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_Kredi.UseVisualStyleBackColor = False
        '
        'btnKonut_FotoVideo
        '
        Me.btnKonut_FotoVideo.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_FotoVideo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_FotoVideo.FlatAppearance.BorderSize = 0
        Me.btnKonut_FotoVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_FotoVideo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_FotoVideo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_FotoVideo.Image = CType(resources.GetObject("btnKonut_FotoVideo.Image"), System.Drawing.Image)
        Me.btnKonut_FotoVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_FotoVideo.Location = New System.Drawing.Point(5, 530)
        Me.btnKonut_FotoVideo.Name = "btnKonut_FotoVideo"
        Me.btnKonut_FotoVideo.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_FotoVideo.TabIndex = 15
        Me.btnKonut_FotoVideo.Text = "Fotoğraf Video"
        Me.btnKonut_FotoVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_FotoVideo.UseVisualStyleBackColor = False
        '
        'pnlKonut_fotoVideo
        '
        Me.pnlKonut_fotoVideo.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_fotoVideo.Controls.Add(Me.chKonutFoto_video)
        Me.pnlKonut_fotoVideo.Controls.Add(Me.chkKonutFoto_foto)
        Me.pnlKonut_fotoVideo.Location = New System.Drawing.Point(5, 565)
        Me.pnlKonut_fotoVideo.Name = "pnlKonut_fotoVideo"
        Me.pnlKonut_fotoVideo.Size = New System.Drawing.Size(240, 75)
        Me.pnlKonut_fotoVideo.TabIndex = 15
        Me.pnlKonut_fotoVideo.Visible = False
        '
        'chKonutFoto_video
        '
        Me.chKonutFoto_video.AutoSize = True
        Me.chKonutFoto_video.Location = New System.Drawing.Point(25, 40)
        Me.chKonutFoto_video.Name = "chKonutFoto_video"
        Me.chKonutFoto_video.Size = New System.Drawing.Size(122, 23)
        Me.chKonutFoto_video.TabIndex = 1
        Me.chKonutFoto_video.Text = "Videolu İlanlar"
        Me.chKonutFoto_video.UseVisualStyleBackColor = True
        '
        'chkKonutFoto_foto
        '
        Me.chkKonutFoto_foto.AutoSize = True
        Me.chkKonutFoto_foto.Location = New System.Drawing.Point(25, 10)
        Me.chkKonutFoto_foto.Name = "chkKonutFoto_foto"
        Me.chkKonutFoto_foto.Size = New System.Drawing.Size(134, 23)
        Me.chkKonutFoto_foto.TabIndex = 0
        Me.chkKonutFoto_foto.Text = "Fotoğraflı İlanlar"
        Me.chkKonutFoto_foto.UseVisualStyleBackColor = True
        '
        'btnKonut_IlanTarihi
        '
        Me.btnKonut_IlanTarihi.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_IlanTarihi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_IlanTarihi.FlatAppearance.BorderSize = 0
        Me.btnKonut_IlanTarihi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_IlanTarihi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_IlanTarihi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_IlanTarihi.Image = CType(resources.GetObject("btnKonut_IlanTarihi.Image"), System.Drawing.Image)
        Me.btnKonut_IlanTarihi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_IlanTarihi.Location = New System.Drawing.Point(5, 495)
        Me.btnKonut_IlanTarihi.Name = "btnKonut_IlanTarihi"
        Me.btnKonut_IlanTarihi.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_IlanTarihi.TabIndex = 14
        Me.btnKonut_IlanTarihi.Text = "İlan Tarihi"
        Me.btnKonut_IlanTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_IlanTarihi.UseVisualStyleBackColor = False
        '
        'btnKonut_Takas
        '
        Me.btnKonut_Takas.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_Takas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_Takas.FlatAppearance.BorderSize = 0
        Me.btnKonut_Takas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_Takas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_Takas.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_Takas.Image = CType(resources.GetObject("btnKonut_Takas.Image"), System.Drawing.Image)
        Me.btnKonut_Takas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_Takas.Location = New System.Drawing.Point(5, 460)
        Me.btnKonut_Takas.Name = "btnKonut_Takas"
        Me.btnKonut_Takas.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_Takas.TabIndex = 13
        Me.btnKonut_Takas.Text = "Takaslı"
        Me.btnKonut_Takas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_Takas.UseVisualStyleBackColor = False
        '
        'btnKonut_SiteIcerisinde
        '
        Me.btnKonut_SiteIcerisinde.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_SiteIcerisinde.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_SiteIcerisinde.FlatAppearance.BorderSize = 0
        Me.btnKonut_SiteIcerisinde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_SiteIcerisinde.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_SiteIcerisinde.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_SiteIcerisinde.Image = CType(resources.GetObject("btnKonut_SiteIcerisinde.Image"), System.Drawing.Image)
        Me.btnKonut_SiteIcerisinde.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_SiteIcerisinde.Location = New System.Drawing.Point(5, 390)
        Me.btnKonut_SiteIcerisinde.Name = "btnKonut_SiteIcerisinde"
        Me.btnKonut_SiteIcerisinde.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_SiteIcerisinde.TabIndex = 11
        Me.btnKonut_SiteIcerisinde.Text = "Site İçerisinde"
        Me.btnKonut_SiteIcerisinde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_SiteIcerisinde.UseVisualStyleBackColor = False
        '
        'pnlKonut_kredi
        '
        Me.pnlKonut_kredi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_kredi.Controls.Add(Me.rbKonutKredi_hayir)
        Me.pnlKonut_kredi.Controls.Add(Me.rbKonutKredi_evet)
        Me.pnlKonut_kredi.Location = New System.Drawing.Point(5, 460)
        Me.pnlKonut_kredi.Name = "pnlKonut_kredi"
        Me.pnlKonut_kredi.Size = New System.Drawing.Size(240, 40)
        Me.pnlKonut_kredi.TabIndex = 12
        Me.pnlKonut_kredi.Visible = False
        '
        'rbKonutKredi_hayir
        '
        Me.rbKonutKredi_hayir.AutoSize = True
        Me.rbKonutKredi_hayir.Location = New System.Drawing.Point(140, 10)
        Me.rbKonutKredi_hayir.Name = "rbKonutKredi_hayir"
        Me.rbKonutKredi_hayir.Size = New System.Drawing.Size(61, 23)
        Me.rbKonutKredi_hayir.TabIndex = 1
        Me.rbKonutKredi_hayir.TabStop = True
        Me.rbKonutKredi_hayir.Text = "Hayır"
        Me.rbKonutKredi_hayir.UseVisualStyleBackColor = True
        '
        'rbKonutKredi_evet
        '
        Me.rbKonutKredi_evet.AutoSize = True
        Me.rbKonutKredi_evet.Location = New System.Drawing.Point(30, 10)
        Me.rbKonutKredi_evet.Name = "rbKonutKredi_evet"
        Me.rbKonutKredi_evet.Size = New System.Drawing.Size(55, 23)
        Me.rbKonutKredi_evet.TabIndex = 0
        Me.rbKonutKredi_evet.TabStop = True
        Me.rbKonutKredi_evet.Text = "Evet"
        Me.rbKonutKredi_evet.UseVisualStyleBackColor = True
        '
        'pnlKonut_takas
        '
        Me.pnlKonut_takas.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_takas.Controls.Add(Me.rbKonutTakas_Hayir)
        Me.pnlKonut_takas.Controls.Add(Me.rbKonutTakas_evet)
        Me.pnlKonut_takas.Location = New System.Drawing.Point(5, 495)
        Me.pnlKonut_takas.Name = "pnlKonut_takas"
        Me.pnlKonut_takas.Size = New System.Drawing.Size(240, 40)
        Me.pnlKonut_takas.TabIndex = 13
        Me.pnlKonut_takas.Visible = False
        '
        'rbKonutTakas_Hayir
        '
        Me.rbKonutTakas_Hayir.AutoSize = True
        Me.rbKonutTakas_Hayir.Location = New System.Drawing.Point(140, 10)
        Me.rbKonutTakas_Hayir.Name = "rbKonutTakas_Hayir"
        Me.rbKonutTakas_Hayir.Size = New System.Drawing.Size(61, 23)
        Me.rbKonutTakas_Hayir.TabIndex = 1
        Me.rbKonutTakas_Hayir.TabStop = True
        Me.rbKonutTakas_Hayir.Text = "Hayır"
        Me.rbKonutTakas_Hayir.UseVisualStyleBackColor = True
        '
        'rbKonutTakas_evet
        '
        Me.rbKonutTakas_evet.AutoSize = True
        Me.rbKonutTakas_evet.Location = New System.Drawing.Point(30, 10)
        Me.rbKonutTakas_evet.Name = "rbKonutTakas_evet"
        Me.rbKonutTakas_evet.Size = New System.Drawing.Size(55, 23)
        Me.rbKonutTakas_evet.TabIndex = 0
        Me.rbKonutTakas_evet.TabStop = True
        Me.rbKonutTakas_evet.Text = "Evet"
        Me.rbKonutTakas_evet.UseVisualStyleBackColor = True
        '
        'pnlKonut_Kullanimda
        '
        Me.pnlKonut_Kullanimda.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_Kullanimda.Controls.Add(Me.rbKonutKullanimda_Hayir)
        Me.pnlKonut_Kullanimda.Controls.Add(Me.rbKonutKullanimda_Evet)
        Me.pnlKonut_Kullanimda.Location = New System.Drawing.Point(5, 390)
        Me.pnlKonut_Kullanimda.Name = "pnlKonut_Kullanimda"
        Me.pnlKonut_Kullanimda.Size = New System.Drawing.Size(240, 40)
        Me.pnlKonut_Kullanimda.TabIndex = 10
        Me.pnlKonut_Kullanimda.Visible = False
        '
        'rbKonutKullanimda_Hayir
        '
        Me.rbKonutKullanimda_Hayir.AutoSize = True
        Me.rbKonutKullanimda_Hayir.Location = New System.Drawing.Point(140, 10)
        Me.rbKonutKullanimda_Hayir.Name = "rbKonutKullanimda_Hayir"
        Me.rbKonutKullanimda_Hayir.Size = New System.Drawing.Size(61, 23)
        Me.rbKonutKullanimda_Hayir.TabIndex = 1
        Me.rbKonutKullanimda_Hayir.TabStop = True
        Me.rbKonutKullanimda_Hayir.Text = "Hayır"
        Me.rbKonutKullanimda_Hayir.UseVisualStyleBackColor = True
        '
        'rbKonutKullanimda_Evet
        '
        Me.rbKonutKullanimda_Evet.AutoSize = True
        Me.rbKonutKullanimda_Evet.Location = New System.Drawing.Point(30, 10)
        Me.rbKonutKullanimda_Evet.Name = "rbKonutKullanimda_Evet"
        Me.rbKonutKullanimda_Evet.Size = New System.Drawing.Size(55, 23)
        Me.rbKonutKullanimda_Evet.TabIndex = 0
        Me.rbKonutKullanimda_Evet.TabStop = True
        Me.rbKonutKullanimda_Evet.Text = "Evet"
        Me.rbKonutKullanimda_Evet.UseVisualStyleBackColor = True
        '
        'pnlKonut_ilanTarihi
        '
        Me.pnlKonut_ilanTarihi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_ilanTarihi.Controls.Add(Me.rbKonutIlan_30gun)
        Me.pnlKonut_ilanTarihi.Controls.Add(Me.rbKonutIlan_15gun)
        Me.pnlKonut_ilanTarihi.Controls.Add(Me.rbKonutIlan_7gun)
        Me.pnlKonut_ilanTarihi.Controls.Add(Me.rbKonutIlan_3gun)
        Me.pnlKonut_ilanTarihi.Controls.Add(Me.rbKonutIlan_24saat)
        Me.pnlKonut_ilanTarihi.Location = New System.Drawing.Point(5, 530)
        Me.pnlKonut_ilanTarihi.Name = "pnlKonut_ilanTarihi"
        Me.pnlKonut_ilanTarihi.Size = New System.Drawing.Size(240, 175)
        Me.pnlKonut_ilanTarihi.TabIndex = 14
        Me.pnlKonut_ilanTarihi.Visible = False
        '
        'rbKonutIlan_30gun
        '
        Me.rbKonutIlan_30gun.AutoSize = True
        Me.rbKonutIlan_30gun.Location = New System.Drawing.Point(25, 135)
        Me.rbKonutIlan_30gun.Name = "rbKonutIlan_30gun"
        Me.rbKonutIlan_30gun.Size = New System.Drawing.Size(145, 23)
        Me.rbKonutIlan_30gun.TabIndex = 5
        Me.rbKonutIlan_30gun.TabStop = True
        Me.rbKonutIlan_30gun.Text = "Son 30 gün  içinde"
        Me.rbKonutIlan_30gun.UseVisualStyleBackColor = True
        '
        'rbKonutIlan_15gun
        '
        Me.rbKonutIlan_15gun.AutoSize = True
        Me.rbKonutIlan_15gun.Location = New System.Drawing.Point(25, 105)
        Me.rbKonutIlan_15gun.Name = "rbKonutIlan_15gun"
        Me.rbKonutIlan_15gun.Size = New System.Drawing.Size(141, 23)
        Me.rbKonutIlan_15gun.TabIndex = 4
        Me.rbKonutIlan_15gun.TabStop = True
        Me.rbKonutIlan_15gun.Text = "Son 15 gün içinde"
        Me.rbKonutIlan_15gun.UseVisualStyleBackColor = True
        '
        'rbKonutIlan_7gun
        '
        Me.rbKonutIlan_7gun.AutoSize = True
        Me.rbKonutIlan_7gun.Location = New System.Drawing.Point(25, 75)
        Me.rbKonutIlan_7gun.Name = "rbKonutIlan_7gun"
        Me.rbKonutIlan_7gun.Size = New System.Drawing.Size(133, 23)
        Me.rbKonutIlan_7gun.TabIndex = 3
        Me.rbKonutIlan_7gun.TabStop = True
        Me.rbKonutIlan_7gun.Text = "Son 7 gün içinde"
        Me.rbKonutIlan_7gun.UseVisualStyleBackColor = True
        '
        'rbKonutIlan_3gun
        '
        Me.rbKonutIlan_3gun.AutoSize = True
        Me.rbKonutIlan_3gun.Location = New System.Drawing.Point(25, 45)
        Me.rbKonutIlan_3gun.Name = "rbKonutIlan_3gun"
        Me.rbKonutIlan_3gun.Size = New System.Drawing.Size(133, 23)
        Me.rbKonutIlan_3gun.TabIndex = 2
        Me.rbKonutIlan_3gun.TabStop = True
        Me.rbKonutIlan_3gun.Text = "Son 3 gün içinde"
        Me.rbKonutIlan_3gun.UseVisualStyleBackColor = True
        '
        'rbKonutIlan_24saat
        '
        Me.rbKonutIlan_24saat.AutoSize = True
        Me.rbKonutIlan_24saat.Location = New System.Drawing.Point(25, 15)
        Me.rbKonutIlan_24saat.Name = "rbKonutIlan_24saat"
        Me.rbKonutIlan_24saat.Size = New System.Drawing.Size(145, 23)
        Me.rbKonutIlan_24saat.TabIndex = 1
        Me.rbKonutIlan_24saat.TabStop = True
        Me.rbKonutIlan_24saat.Text = "Son 24 saat içinde"
        Me.rbKonutIlan_24saat.UseVisualStyleBackColor = True
        '
        'pnlKonut_siteIcerisinde
        '
        Me.pnlKonut_siteIcerisinde.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_siteIcerisinde.Controls.Add(Me.rbKonutSite_Hayir)
        Me.pnlKonut_siteIcerisinde.Controls.Add(Me.rbKonutSite_Evet)
        Me.pnlKonut_siteIcerisinde.Location = New System.Drawing.Point(5, 425)
        Me.pnlKonut_siteIcerisinde.Name = "pnlKonut_siteIcerisinde"
        Me.pnlKonut_siteIcerisinde.Size = New System.Drawing.Size(240, 40)
        Me.pnlKonut_siteIcerisinde.TabIndex = 11
        Me.pnlKonut_siteIcerisinde.Visible = False
        '
        'rbKonutSite_Hayir
        '
        Me.rbKonutSite_Hayir.AutoSize = True
        Me.rbKonutSite_Hayir.Location = New System.Drawing.Point(140, 10)
        Me.rbKonutSite_Hayir.Name = "rbKonutSite_Hayir"
        Me.rbKonutSite_Hayir.Size = New System.Drawing.Size(61, 23)
        Me.rbKonutSite_Hayir.TabIndex = 1
        Me.rbKonutSite_Hayir.TabStop = True
        Me.rbKonutSite_Hayir.Text = "Hayır"
        Me.rbKonutSite_Hayir.UseVisualStyleBackColor = True
        '
        'rbKonutSite_Evet
        '
        Me.rbKonutSite_Evet.AutoSize = True
        Me.rbKonutSite_Evet.Location = New System.Drawing.Point(30, 10)
        Me.rbKonutSite_Evet.Name = "rbKonutSite_Evet"
        Me.rbKonutSite_Evet.Size = New System.Drawing.Size(55, 23)
        Me.rbKonutSite_Evet.TabIndex = 0
        Me.rbKonutSite_Evet.TabStop = True
        Me.rbKonutSite_Evet.Text = "Evet"
        Me.rbKonutSite_Evet.UseVisualStyleBackColor = True
        '
        'btnKonut_Adres
        '
        Me.btnKonut_Adres.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_Adres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_Adres.FlatAppearance.BorderSize = 0
        Me.btnKonut_Adres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_Adres.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_Adres.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_Adres.Image = CType(resources.GetObject("btnKonut_Adres.Image"), System.Drawing.Image)
        Me.btnKonut_Adres.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_Adres.Location = New System.Drawing.Point(5, 5)
        Me.btnKonut_Adres.Name = "btnKonut_Adres"
        Me.btnKonut_Adres.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_Adres.TabIndex = 0
        Me.btnKonut_Adres.Text = "Adres"
        Me.btnKonut_Adres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_Adres.UseVisualStyleBackColor = False
        '
        'btnKonut_BanyoSayi
        '
        Me.btnKonut_BanyoSayi.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_BanyoSayi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_BanyoSayi.FlatAppearance.BorderSize = 0
        Me.btnKonut_BanyoSayi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_BanyoSayi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_BanyoSayi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_BanyoSayi.Image = CType(resources.GetObject("btnKonut_BanyoSayi.Image"), System.Drawing.Image)
        Me.btnKonut_BanyoSayi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_BanyoSayi.Location = New System.Drawing.Point(5, 285)
        Me.btnKonut_BanyoSayi.Name = "btnKonut_BanyoSayi"
        Me.btnKonut_BanyoSayi.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_BanyoSayi.TabIndex = 8
        Me.btnKonut_BanyoSayi.Text = "Banyo Sayısı"
        Me.btnKonut_BanyoSayi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_BanyoSayi.UseVisualStyleBackColor = False
        '
        'btnKonut_Kullanimda
        '
        Me.btnKonut_Kullanimda.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_Kullanimda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_Kullanimda.FlatAppearance.BorderSize = 0
        Me.btnKonut_Kullanimda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_Kullanimda.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_Kullanimda.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_Kullanimda.Image = CType(resources.GetObject("btnKonut_Kullanimda.Image"), System.Drawing.Image)
        Me.btnKonut_Kullanimda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_Kullanimda.Location = New System.Drawing.Point(5, 355)
        Me.btnKonut_Kullanimda.Name = "btnKonut_Kullanimda"
        Me.btnKonut_Kullanimda.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_Kullanimda.TabIndex = 10
        Me.btnKonut_Kullanimda.Text = "Kullanımda"
        Me.btnKonut_Kullanimda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_Kullanimda.UseVisualStyleBackColor = False
        '
        'pnlKonut_Esyali
        '
        Me.pnlKonut_Esyali.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_Esyali.Controls.Add(Me.rbKonutEsyali_Hayir)
        Me.pnlKonut_Esyali.Controls.Add(Me.rbKonutEsyali_Evet)
        Me.pnlKonut_Esyali.Location = New System.Drawing.Point(5, 355)
        Me.pnlKonut_Esyali.Name = "pnlKonut_Esyali"
        Me.pnlKonut_Esyali.Size = New System.Drawing.Size(240, 40)
        Me.pnlKonut_Esyali.TabIndex = 9
        Me.pnlKonut_Esyali.Visible = False
        '
        'rbKonutEsyali_Hayir
        '
        Me.rbKonutEsyali_Hayir.AutoSize = True
        Me.rbKonutEsyali_Hayir.Location = New System.Drawing.Point(140, 10)
        Me.rbKonutEsyali_Hayir.Name = "rbKonutEsyali_Hayir"
        Me.rbKonutEsyali_Hayir.Size = New System.Drawing.Size(61, 23)
        Me.rbKonutEsyali_Hayir.TabIndex = 1
        Me.rbKonutEsyali_Hayir.TabStop = True
        Me.rbKonutEsyali_Hayir.Text = "Hayır"
        Me.rbKonutEsyali_Hayir.UseVisualStyleBackColor = True
        '
        'rbKonutEsyali_Evet
        '
        Me.rbKonutEsyali_Evet.AutoSize = True
        Me.rbKonutEsyali_Evet.Location = New System.Drawing.Point(30, 10)
        Me.rbKonutEsyali_Evet.Name = "rbKonutEsyali_Evet"
        Me.rbKonutEsyali_Evet.Size = New System.Drawing.Size(55, 23)
        Me.rbKonutEsyali_Evet.TabIndex = 0
        Me.rbKonutEsyali_Evet.TabStop = True
        Me.rbKonutEsyali_Evet.Text = "Evet"
        Me.rbKonutEsyali_Evet.UseVisualStyleBackColor = True
        '
        'btnKonut_Buyukluk
        '
        Me.btnKonut_Buyukluk.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_Buyukluk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_Buyukluk.FlatAppearance.BorderSize = 0
        Me.btnKonut_Buyukluk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_Buyukluk.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_Buyukluk.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_Buyukluk.Image = CType(resources.GetObject("btnKonut_Buyukluk.Image"), System.Drawing.Image)
        Me.btnKonut_Buyukluk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_Buyukluk.Location = New System.Drawing.Point(5, 75)
        Me.btnKonut_Buyukluk.Name = "btnKonut_Buyukluk"
        Me.btnKonut_Buyukluk.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_Buyukluk.TabIndex = 2
        Me.btnKonut_Buyukluk.Text = "Büyüklük (m2)"
        Me.btnKonut_Buyukluk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_Buyukluk.UseVisualStyleBackColor = False
        '
        'btnKonut_OdaSayi
        '
        Me.btnKonut_OdaSayi.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_OdaSayi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_OdaSayi.FlatAppearance.BorderSize = 0
        Me.btnKonut_OdaSayi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_OdaSayi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_OdaSayi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_OdaSayi.Image = CType(resources.GetObject("btnKonut_OdaSayi.Image"), System.Drawing.Image)
        Me.btnKonut_OdaSayi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_OdaSayi.Location = New System.Drawing.Point(5, 110)
        Me.btnKonut_OdaSayi.Name = "btnKonut_OdaSayi"
        Me.btnKonut_OdaSayi.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_OdaSayi.TabIndex = 3
        Me.btnKonut_OdaSayi.Text = "Oda Sayısı"
        Me.btnKonut_OdaSayi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_OdaSayi.UseVisualStyleBackColor = False
        '
        'btnKonut_BulunduguKat
        '
        Me.btnKonut_BulunduguKat.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_BulunduguKat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_BulunduguKat.FlatAppearance.BorderSize = 0
        Me.btnKonut_BulunduguKat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_BulunduguKat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_BulunduguKat.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_BulunduguKat.Image = CType(resources.GetObject("btnKonut_BulunduguKat.Image"), System.Drawing.Image)
        Me.btnKonut_BulunduguKat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_BulunduguKat.Location = New System.Drawing.Point(5, 180)
        Me.btnKonut_BulunduguKat.Name = "btnKonut_BulunduguKat"
        Me.btnKonut_BulunduguKat.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_BulunduguKat.TabIndex = 5
        Me.btnKonut_BulunduguKat.Text = "Bulunduğu Kat"
        Me.btnKonut_BulunduguKat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_BulunduguKat.UseVisualStyleBackColor = False
        '
        'btnKonut_KatSayi
        '
        Me.btnKonut_KatSayi.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_KatSayi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_KatSayi.FlatAppearance.BorderSize = 0
        Me.btnKonut_KatSayi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_KatSayi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_KatSayi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_KatSayi.Image = CType(resources.GetObject("btnKonut_KatSayi.Image"), System.Drawing.Image)
        Me.btnKonut_KatSayi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_KatSayi.Location = New System.Drawing.Point(5, 215)
        Me.btnKonut_KatSayi.Name = "btnKonut_KatSayi"
        Me.btnKonut_KatSayi.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_KatSayi.TabIndex = 6
        Me.btnKonut_KatSayi.Text = "Kat Sayısı"
        Me.btnKonut_KatSayi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_KatSayi.UseVisualStyleBackColor = False
        '
        'btnKonut_Isitma
        '
        Me.btnKonut_Isitma.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_Isitma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_Isitma.FlatAppearance.BorderSize = 0
        Me.btnKonut_Isitma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_Isitma.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_Isitma.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_Isitma.Image = CType(resources.GetObject("btnKonut_Isitma.Image"), System.Drawing.Image)
        Me.btnKonut_Isitma.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_Isitma.Location = New System.Drawing.Point(5, 250)
        Me.btnKonut_Isitma.Name = "btnKonut_Isitma"
        Me.btnKonut_Isitma.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_Isitma.TabIndex = 7
        Me.btnKonut_Isitma.Text = "Isıtma"
        Me.btnKonut_Isitma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_Isitma.UseVisualStyleBackColor = False
        '
        'btnKonut_Esyali
        '
        Me.btnKonut_Esyali.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_Esyali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_Esyali.FlatAppearance.BorderSize = 0
        Me.btnKonut_Esyali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_Esyali.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_Esyali.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_Esyali.Image = CType(resources.GetObject("btnKonut_Esyali.Image"), System.Drawing.Image)
        Me.btnKonut_Esyali.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_Esyali.Location = New System.Drawing.Point(5, 320)
        Me.btnKonut_Esyali.Name = "btnKonut_Esyali"
        Me.btnKonut_Esyali.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_Esyali.TabIndex = 9
        Me.btnKonut_Esyali.Text = "Eşyalı"
        Me.btnKonut_Esyali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_Esyali.UseVisualStyleBackColor = False
        '
        'pnlKonut_Fiyat
        '
        Me.pnlKonut_Fiyat.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_Fiyat.Controls.Add(Me.txtKonut_MaxTL)
        Me.pnlKonut_Fiyat.Controls.Add(Me.txtKonut_MinTL)
        Me.pnlKonut_Fiyat.Location = New System.Drawing.Point(5, 75)
        Me.pnlKonut_Fiyat.Name = "pnlKonut_Fiyat"
        Me.pnlKonut_Fiyat.Size = New System.Drawing.Size(240, 50)
        Me.pnlKonut_Fiyat.TabIndex = 1
        Me.pnlKonut_Fiyat.Visible = False
        '
        'txtKonut_MaxTL
        '
        Me.txtKonut_MaxTL.ForeColor = System.Drawing.Color.Gray
        Me.txtKonut_MaxTL.Location = New System.Drawing.Point(130, 10)
        Me.txtKonut_MaxTL.Name = "txtKonut_MaxTL"
        Me.txtKonut_MaxTL.Size = New System.Drawing.Size(100, 27)
        Me.txtKonut_MaxTL.TabIndex = 1
        Me.txtKonut_MaxTL.Text = "Max TL"
        Me.txtKonut_MaxTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKonut_MinTL
        '
        Me.txtKonut_MinTL.ForeColor = System.Drawing.Color.Gray
        Me.txtKonut_MinTL.Location = New System.Drawing.Point(10, 10)
        Me.txtKonut_MinTL.Name = "txtKonut_MinTL"
        Me.txtKonut_MinTL.Size = New System.Drawing.Size(100, 27)
        Me.txtKonut_MinTL.TabIndex = 0
        Me.txtKonut_MinTL.Text = "Min TL"
        Me.txtKonut_MinTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlKonut_binaYas
        '
        Me.pnlKonut_binaYas.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_binaYas.Controls.Add(Me.txtKonut_MaxBinaYas3)
        Me.pnlKonut_binaYas.Controls.Add(Me.txtKonut_MinBinaYas3)
        Me.pnlKonut_binaYas.Location = New System.Drawing.Point(5, 180)
        Me.pnlKonut_binaYas.Name = "pnlKonut_binaYas"
        Me.pnlKonut_binaYas.Size = New System.Drawing.Size(240, 50)
        Me.pnlKonut_binaYas.TabIndex = 4
        Me.pnlKonut_binaYas.Visible = False
        '
        'txtKonut_MaxBinaYas3
        '
        Me.txtKonut_MaxBinaYas3.ForeColor = System.Drawing.Color.Gray
        Me.txtKonut_MaxBinaYas3.Location = New System.Drawing.Point(130, 10)
        Me.txtKonut_MaxBinaYas3.Name = "txtKonut_MaxBinaYas3"
        Me.txtKonut_MaxBinaYas3.Size = New System.Drawing.Size(100, 27)
        Me.txtKonut_MaxBinaYas3.TabIndex = 29
        Me.txtKonut_MaxBinaYas3.Text = "Max"
        Me.txtKonut_MaxBinaYas3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKonut_MinBinaYas3
        '
        Me.txtKonut_MinBinaYas3.ForeColor = System.Drawing.Color.Gray
        Me.txtKonut_MinBinaYas3.Location = New System.Drawing.Point(10, 10)
        Me.txtKonut_MinBinaYas3.Name = "txtKonut_MinBinaYas3"
        Me.txtKonut_MinBinaYas3.Size = New System.Drawing.Size(100, 27)
        Me.txtKonut_MinBinaYas3.TabIndex = 0
        Me.txtKonut_MinBinaYas3.Text = "Min"
        Me.txtKonut_MinBinaYas3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlKonut_bulunduguKat
        '
        Me.pnlKonut_bulunduguKat.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_bulunduguKat.Controls.Add(Me.cbxKonut_bulunduguKat)
        Me.pnlKonut_bulunduguKat.Location = New System.Drawing.Point(5, 215)
        Me.pnlKonut_bulunduguKat.Name = "pnlKonut_bulunduguKat"
        Me.pnlKonut_bulunduguKat.Size = New System.Drawing.Size(240, 50)
        Me.pnlKonut_bulunduguKat.TabIndex = 5
        Me.pnlKonut_bulunduguKat.Visible = False
        '
        'cbxKonut_bulunduguKat
        '
        Me.cbxKonut_bulunduguKat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKonut_bulunduguKat.FormattingEnabled = True
        Me.cbxKonut_bulunduguKat.Location = New System.Drawing.Point(10, 10)
        Me.cbxKonut_bulunduguKat.Name = "cbxKonut_bulunduguKat"
        Me.cbxKonut_bulunduguKat.Size = New System.Drawing.Size(220, 27)
        Me.cbxKonut_bulunduguKat.TabIndex = 0
        '
        'pnlKonut_katSayi
        '
        Me.pnlKonut_katSayi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_katSayi.Controls.Add(Me.txtKonut_MaxKatSayi2)
        Me.pnlKonut_katSayi.Controls.Add(Me.txtKonut_MinKatSayi2)
        Me.pnlKonut_katSayi.Location = New System.Drawing.Point(5, 250)
        Me.pnlKonut_katSayi.Name = "pnlKonut_katSayi"
        Me.pnlKonut_katSayi.Size = New System.Drawing.Size(240, 50)
        Me.pnlKonut_katSayi.TabIndex = 6
        Me.pnlKonut_katSayi.Visible = False
        '
        'txtKonut_MaxKatSayi2
        '
        Me.txtKonut_MaxKatSayi2.ForeColor = System.Drawing.Color.Gray
        Me.txtKonut_MaxKatSayi2.Location = New System.Drawing.Point(130, 10)
        Me.txtKonut_MaxKatSayi2.Name = "txtKonut_MaxKatSayi2"
        Me.txtKonut_MaxKatSayi2.Size = New System.Drawing.Size(100, 27)
        Me.txtKonut_MaxKatSayi2.TabIndex = 31
        Me.txtKonut_MaxKatSayi2.Text = "Max"
        Me.txtKonut_MaxKatSayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKonut_MinKatSayi2
        '
        Me.txtKonut_MinKatSayi2.ForeColor = System.Drawing.Color.Gray
        Me.txtKonut_MinKatSayi2.Location = New System.Drawing.Point(10, 10)
        Me.txtKonut_MinKatSayi2.Name = "txtKonut_MinKatSayi2"
        Me.txtKonut_MinKatSayi2.Size = New System.Drawing.Size(100, 27)
        Me.txtKonut_MinKatSayi2.TabIndex = 30
        Me.txtKonut_MinKatSayi2.Text = "Min"
        Me.txtKonut_MinKatSayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlKonut_isitma
        '
        Me.pnlKonut_isitma.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_isitma.Controls.Add(Me.cbxKonut_isitma)
        Me.pnlKonut_isitma.Location = New System.Drawing.Point(5, 285)
        Me.pnlKonut_isitma.Name = "pnlKonut_isitma"
        Me.pnlKonut_isitma.Size = New System.Drawing.Size(240, 50)
        Me.pnlKonut_isitma.TabIndex = 7
        Me.pnlKonut_isitma.Visible = False
        '
        'cbxKonut_isitma
        '
        Me.cbxKonut_isitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKonut_isitma.FormattingEnabled = True
        Me.cbxKonut_isitma.Location = New System.Drawing.Point(10, 10)
        Me.cbxKonut_isitma.Name = "cbxKonut_isitma"
        Me.cbxKonut_isitma.Size = New System.Drawing.Size(220, 27)
        Me.cbxKonut_isitma.TabIndex = 0
        '
        'pnlKonut_banyoSayi
        '
        Me.pnlKonut_banyoSayi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_banyoSayi.Controls.Add(Me.txtKonut_MaxBanyoSayisi2)
        Me.pnlKonut_banyoSayi.Controls.Add(Me.txtKonut_MinBanyoSayisi2)
        Me.pnlKonut_banyoSayi.Location = New System.Drawing.Point(5, 320)
        Me.pnlKonut_banyoSayi.Name = "pnlKonut_banyoSayi"
        Me.pnlKonut_banyoSayi.Size = New System.Drawing.Size(240, 50)
        Me.pnlKonut_banyoSayi.TabIndex = 8
        Me.pnlKonut_banyoSayi.Visible = False
        '
        'txtKonut_MaxBanyoSayisi2
        '
        Me.txtKonut_MaxBanyoSayisi2.ForeColor = System.Drawing.Color.Gray
        Me.txtKonut_MaxBanyoSayisi2.Location = New System.Drawing.Point(130, 10)
        Me.txtKonut_MaxBanyoSayisi2.Name = "txtKonut_MaxBanyoSayisi2"
        Me.txtKonut_MaxBanyoSayisi2.Size = New System.Drawing.Size(100, 27)
        Me.txtKonut_MaxBanyoSayisi2.TabIndex = 31
        Me.txtKonut_MaxBanyoSayisi2.Text = "Max"
        Me.txtKonut_MaxBanyoSayisi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKonut_MinBanyoSayisi2
        '
        Me.txtKonut_MinBanyoSayisi2.ForeColor = System.Drawing.Color.Gray
        Me.txtKonut_MinBanyoSayisi2.Location = New System.Drawing.Point(10, 10)
        Me.txtKonut_MinBanyoSayisi2.Name = "txtKonut_MinBanyoSayisi2"
        Me.txtKonut_MinBanyoSayisi2.Size = New System.Drawing.Size(100, 27)
        Me.txtKonut_MinBanyoSayisi2.TabIndex = 30
        Me.txtKonut_MinBanyoSayisi2.Text = "Min"
        Me.txtKonut_MinBanyoSayisi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnKonut_Fiyat
        '
        Me.btnKonut_Fiyat.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_Fiyat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_Fiyat.FlatAppearance.BorderSize = 0
        Me.btnKonut_Fiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_Fiyat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_Fiyat.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_Fiyat.Image = CType(resources.GetObject("btnKonut_Fiyat.Image"), System.Drawing.Image)
        Me.btnKonut_Fiyat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_Fiyat.Location = New System.Drawing.Point(5, 40)
        Me.btnKonut_Fiyat.Name = "btnKonut_Fiyat"
        Me.btnKonut_Fiyat.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_Fiyat.TabIndex = 1
        Me.btnKonut_Fiyat.Text = "Fiyat (TL)"
        Me.btnKonut_Fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_Fiyat.UseVisualStyleBackColor = False
        '
        'btnKonut_BinaYas
        '
        Me.btnKonut_BinaYas.BackColor = System.Drawing.Color.Silver
        Me.btnKonut_BinaYas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKonut_BinaYas.FlatAppearance.BorderSize = 0
        Me.btnKonut_BinaYas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonut_BinaYas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonut_BinaYas.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnKonut_BinaYas.Image = CType(resources.GetObject("btnKonut_BinaYas.Image"), System.Drawing.Image)
        Me.btnKonut_BinaYas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKonut_BinaYas.Location = New System.Drawing.Point(5, 145)
        Me.btnKonut_BinaYas.Name = "btnKonut_BinaYas"
        Me.btnKonut_BinaYas.Size = New System.Drawing.Size(240, 30)
        Me.btnKonut_BinaYas.TabIndex = 4
        Me.btnKonut_BinaYas.Text = "Bina Yaşı"
        Me.btnKonut_BinaYas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKonut_BinaYas.UseVisualStyleBackColor = False
        '
        'pnlKonut_odaSayi
        '
        Me.pnlKonut_odaSayi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_odaSayi.Controls.Add(Me.cbxKonut_odaSayi)
        Me.pnlKonut_odaSayi.Location = New System.Drawing.Point(5, 145)
        Me.pnlKonut_odaSayi.Name = "pnlKonut_odaSayi"
        Me.pnlKonut_odaSayi.Size = New System.Drawing.Size(240, 50)
        Me.pnlKonut_odaSayi.TabIndex = 3
        Me.pnlKonut_odaSayi.Visible = False
        '
        'cbxKonut_odaSayi
        '
        Me.cbxKonut_odaSayi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKonut_odaSayi.FormattingEnabled = True
        Me.cbxKonut_odaSayi.Location = New System.Drawing.Point(10, 10)
        Me.cbxKonut_odaSayi.Name = "cbxKonut_odaSayi"
        Me.cbxKonut_odaSayi.Size = New System.Drawing.Size(220, 27)
        Me.cbxKonut_odaSayi.TabIndex = 0
        '
        'pnlKonut_buyukluk
        '
        Me.pnlKonut_buyukluk.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_buyukluk.Controls.Add(Me.txtKonut_MaxBuyukluk)
        Me.pnlKonut_buyukluk.Controls.Add(Me.txtKonut_MinBuyukluk)
        Me.pnlKonut_buyukluk.Location = New System.Drawing.Point(5, 110)
        Me.pnlKonut_buyukluk.Name = "pnlKonut_buyukluk"
        Me.pnlKonut_buyukluk.Size = New System.Drawing.Size(240, 50)
        Me.pnlKonut_buyukluk.TabIndex = 2
        Me.pnlKonut_buyukluk.Visible = False
        '
        'txtKonut_MaxBuyukluk
        '
        Me.txtKonut_MaxBuyukluk.ForeColor = System.Drawing.Color.Gray
        Me.txtKonut_MaxBuyukluk.Location = New System.Drawing.Point(130, 10)
        Me.txtKonut_MaxBuyukluk.Name = "txtKonut_MaxBuyukluk"
        Me.txtKonut_MaxBuyukluk.Size = New System.Drawing.Size(100, 27)
        Me.txtKonut_MaxBuyukluk.TabIndex = 1
        Me.txtKonut_MaxBuyukluk.Text = "Max"
        Me.txtKonut_MaxBuyukluk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKonut_MinBuyukluk
        '
        Me.txtKonut_MinBuyukluk.ForeColor = System.Drawing.Color.Gray
        Me.txtKonut_MinBuyukluk.Location = New System.Drawing.Point(10, 10)
        Me.txtKonut_MinBuyukluk.Name = "txtKonut_MinBuyukluk"
        Me.txtKonut_MinBuyukluk.Size = New System.Drawing.Size(100, 27)
        Me.txtKonut_MinBuyukluk.TabIndex = 0
        Me.txtKonut_MinBuyukluk.Text = "Min"
        Me.txtKonut_MinBuyukluk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlKonut_Adres
        '
        Me.pnlKonut_Adres.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlKonut_Adres.Controls.Add(Me.cbxIl)
        Me.pnlKonut_Adres.Controls.Add(Me.cbxMahalle)
        Me.pnlKonut_Adres.Controls.Add(Me.cbxIlce)
        Me.pnlKonut_Adres.Location = New System.Drawing.Point(5, 40)
        Me.pnlKonut_Adres.Name = "pnlKonut_Adres"
        Me.pnlKonut_Adres.Size = New System.Drawing.Size(240, 115)
        Me.pnlKonut_Adres.TabIndex = 0
        Me.pnlKonut_Adres.Visible = False
        '
        'cbxIl
        '
        Me.cbxIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIl.FormattingEnabled = True
        Me.cbxIl.Location = New System.Drawing.Point(10, 10)
        Me.cbxIl.Name = "cbxIl"
        Me.cbxIl.Size = New System.Drawing.Size(220, 27)
        Me.cbxIl.TabIndex = 0
        '
        'cbxMahalle
        '
        Me.cbxMahalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMahalle.FormattingEnabled = True
        Me.cbxMahalle.Location = New System.Drawing.Point(10, 75)
        Me.cbxMahalle.Name = "cbxMahalle"
        Me.cbxMahalle.Size = New System.Drawing.Size(220, 27)
        Me.cbxMahalle.TabIndex = 2
        '
        'cbxIlce
        '
        Me.cbxIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIlce.FormattingEnabled = True
        Me.cbxIlce.Location = New System.Drawing.Point(10, 43)
        Me.cbxIlce.Name = "cbxIlce"
        Me.cbxIlce.Size = New System.Drawing.Size(220, 27)
        Me.cbxIlce.TabIndex = 1
        '
        'btnTemizle
        '
        Me.btnTemizle.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTemizle.FlatAppearance.BorderSize = 2
        Me.btnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnTemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTemizle.Font = New System.Drawing.Font("Cambria", 14.0!)
        Me.btnTemizle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTemizle.Location = New System.Drawing.Point(50, 555)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(166, 40)
        Me.btnTemizle.TabIndex = 18
        Me.btnTemizle.Text = "Fitreyi Temizle"
        Me.btnTemizle.UseVisualStyleBackColor = False
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.Transparent
        Me.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogo.FlatAppearance.BorderSize = 0
        Me.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogo.ForeColor = System.Drawing.Color.White
        Me.btnLogo.Image = Global.EmlakOtomasyonu2.My.Resources.Resources.Capturesmall
        Me.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogo.Location = New System.Drawing.Point(65, 27)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(161, 100)
        Me.btnLogo.TabIndex = 21
        Me.btnLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogo.UseVisualStyleBackColor = False
        '
        'btnSatisTuru
        '
        Me.btnSatisTuru.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSatisTuru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSatisTuru.Enabled = False
        Me.btnSatisTuru.FlatAppearance.BorderSize = 0
        Me.btnSatisTuru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSatisTuru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSatisTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSatisTuru.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSatisTuru.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnSatisTuru.Location = New System.Drawing.Point(386, 43)
        Me.btnSatisTuru.Name = "btnSatisTuru"
        Me.btnSatisTuru.Size = New System.Drawing.Size(260, 35)
        Me.btnSatisTuru.TabIndex = 22
        Me.btnSatisTuru.Text = "Satılık İşyeri"
        Me.btnSatisTuru.UseVisualStyleBackColor = False
        '
        'btnFiyat
        '
        Me.btnFiyat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnFiyat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiyat.Enabled = False
        Me.btnFiyat.FlatAppearance.BorderSize = 0
        Me.btnFiyat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnFiyat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiyat.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFiyat.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnFiyat.Location = New System.Drawing.Point(711, 83)
        Me.btnFiyat.Name = "btnFiyat"
        Me.btnFiyat.Size = New System.Drawing.Size(200, 35)
        Me.btnFiyat.TabIndex = 23
        Me.btnFiyat.Text = "1800-2000 TL"
        Me.btnFiyat.UseVisualStyleBackColor = False
        '
        'btnAdres
        '
        Me.btnAdres.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdres.Enabled = False
        Me.btnAdres.FlatAppearance.BorderSize = 0
        Me.btnAdres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAdres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAdres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdres.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdres.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnAdres.Location = New System.Drawing.Point(386, 83)
        Me.btnAdres.Name = "btnAdres"
        Me.btnAdres.Size = New System.Drawing.Size(320, 35)
        Me.btnAdres.TabIndex = 24
        Me.btnAdres.Text = "Maltepe, İstanbul"
        Me.btnAdres.UseVisualStyleBackColor = False
        '
        'btnEmlakTipi
        '
        Me.btnEmlakTipi.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEmlakTipi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmlakTipi.Enabled = False
        Me.btnEmlakTipi.FlatAppearance.BorderSize = 0
        Me.btnEmlakTipi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEmlakTipi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEmlakTipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmlakTipi.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEmlakTipi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnEmlakTipi.Location = New System.Drawing.Point(651, 43)
        Me.btnEmlakTipi.Name = "btnEmlakTipi"
        Me.btnEmlakTipi.Size = New System.Drawing.Size(380, 35)
        Me.btnEmlakTipi.TabIndex = 25
        Me.btnEmlakTipi.Text = "Konferans Salonu"
        Me.btnEmlakTipi.UseVisualStyleBackColor = False
        '
        'btnEkBilgi
        '
        Me.btnEkBilgi.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEkBilgi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEkBilgi.Enabled = False
        Me.btnEkBilgi.FlatAppearance.BorderSize = 0
        Me.btnEkBilgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEkBilgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEkBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEkBilgi.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEkBilgi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnEkBilgi.Location = New System.Drawing.Point(916, 83)
        Me.btnEkBilgi.Name = "btnEkBilgi"
        Me.btnEkBilgi.Size = New System.Drawing.Size(115, 35)
        Me.btnEkBilgi.TabIndex = 26
        Me.btnEkBilgi.Text = "4+1"
        Me.btnEkBilgi.UseVisualStyleBackColor = False
        '
        'btnAra
        '
        Me.btnAra.BackColor = System.Drawing.Color.Transparent
        Me.btnAra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAra.FlatAppearance.BorderSize = 0
        Me.btnAra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAra.Font = New System.Drawing.Font("Cambria", 14.0!)
        Me.btnAra.ForeColor = System.Drawing.Color.White
        Me.btnAra.Image = CType(resources.GetObject("btnAra.Image"), System.Drawing.Image)
        Me.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAra.Location = New System.Drawing.Point(1078, 41)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(172, 79)
        Me.btnAra.TabIndex = 27
        Me.btnAra.Text = "       Aramayı Değiştir"
        Me.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAra.UseVisualStyleBackColor = False
        '
        'pnlFiltre
        '
        Me.pnlFiltre.AutoScroll = True
        Me.pnlFiltre.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlFiltre.Controls.Add(Me.pnlKonutFiltre)
        Me.pnlFiltre.Controls.Add(Me.pnlBinaFiltre)
        Me.pnlFiltre.Controls.Add(Me.pnlIsyeriFiltre)
        Me.pnlFiltre.Controls.Add(Me.pnlArsaFiltre)
        Me.pnlFiltre.Controls.Add(Me.pnlTuristikFiltre)
        Me.pnlFiltre.Location = New System.Drawing.Point(12, 152)
        Me.pnlFiltre.Name = "pnlFiltre"
        Me.pnlFiltre.Size = New System.Drawing.Size(280, 388)
        Me.pnlFiltre.TabIndex = 28
        '
        'pnlBinaFiltre
        '
        Me.pnlBinaFiltre.AutoSize = True
        Me.pnlBinaFiltre.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlBinaFiltre.Controls.Add(Me.btnBina_isitma)
        Me.pnlBinaFiltre.Controls.Add(Me.btnBina_buyukluk)
        Me.pnlBinaFiltre.Controls.Add(Me.btnBina_Adres)
        Me.pnlBinaFiltre.Controls.Add(Me.btnBina_takas)
        Me.pnlBinaFiltre.Controls.Add(Me.btnBina_ilanTarihi)
        Me.pnlBinaFiltre.Controls.Add(Me.btnBina_fotoVideo)
        Me.pnlBinaFiltre.Controls.Add(Me.pnlBina_birKattakiDaire)
        Me.pnlBinaFiltre.Controls.Add(Me.pnlBina_kredi)
        Me.pnlBinaFiltre.Controls.Add(Me.pnlBina_takas)
        Me.pnlBinaFiltre.Controls.Add(Me.pnlBina_ilanTarihi)
        Me.pnlBinaFiltre.Controls.Add(Me.pnlBina_fotoVideo)
        Me.pnlBinaFiltre.Controls.Add(Me.btnBina_Fiyat)
        Me.pnlBinaFiltre.Controls.Add(Me.btnBina_KatSayi)
        Me.pnlBinaFiltre.Controls.Add(Me.btnBina_birKattakiDaire)
        Me.pnlBinaFiltre.Controls.Add(Me.btnBina_kredi)
        Me.pnlBinaFiltre.Controls.Add(Me.pnlBina_fiyat)
        Me.pnlBinaFiltre.Controls.Add(Me.pnlBina_katSayi)
        Me.pnlBinaFiltre.Controls.Add(Me.pnlBina_adres)
        Me.pnlBinaFiltre.Controls.Add(Me.pnlBina_buyukluk)
        Me.pnlBinaFiltre.Controls.Add(Me.pnlBina_isitma)
        Me.pnlBinaFiltre.Location = New System.Drawing.Point(5, 0)
        Me.pnlBinaFiltre.Name = "pnlBinaFiltre"
        Me.pnlBinaFiltre.Size = New System.Drawing.Size(250, 711)
        Me.pnlBinaFiltre.TabIndex = 19
        '
        'btnBina_isitma
        '
        Me.btnBina_isitma.BackColor = System.Drawing.Color.Silver
        Me.btnBina_isitma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBina_isitma.FlatAppearance.BorderSize = 0
        Me.btnBina_isitma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBina_isitma.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBina_isitma.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBina_isitma.Image = CType(resources.GetObject("btnBina_isitma.Image"), System.Drawing.Image)
        Me.btnBina_isitma.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBina_isitma.Location = New System.Drawing.Point(5, 145)
        Me.btnBina_isitma.Name = "btnBina_isitma"
        Me.btnBina_isitma.Size = New System.Drawing.Size(240, 30)
        Me.btnBina_isitma.TabIndex = 37
        Me.btnBina_isitma.Text = "Isıtma"
        Me.btnBina_isitma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBina_isitma.UseVisualStyleBackColor = False
        '
        'btnBina_buyukluk
        '
        Me.btnBina_buyukluk.BackColor = System.Drawing.Color.Silver
        Me.btnBina_buyukluk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBina_buyukluk.FlatAppearance.BorderSize = 0
        Me.btnBina_buyukluk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBina_buyukluk.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBina_buyukluk.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBina_buyukluk.Image = CType(resources.GetObject("btnBina_buyukluk.Image"), System.Drawing.Image)
        Me.btnBina_buyukluk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBina_buyukluk.Location = New System.Drawing.Point(5, 180)
        Me.btnBina_buyukluk.Name = "btnBina_buyukluk"
        Me.btnBina_buyukluk.Size = New System.Drawing.Size(240, 30)
        Me.btnBina_buyukluk.TabIndex = 38
        Me.btnBina_buyukluk.Text = "Büyüklük (m2)"
        Me.btnBina_buyukluk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBina_buyukluk.UseVisualStyleBackColor = False
        '
        'btnBina_Adres
        '
        Me.btnBina_Adres.BackColor = System.Drawing.Color.Silver
        Me.btnBina_Adres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBina_Adres.FlatAppearance.BorderSize = 0
        Me.btnBina_Adres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBina_Adres.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBina_Adres.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBina_Adres.Image = CType(resources.GetObject("btnBina_Adres.Image"), System.Drawing.Image)
        Me.btnBina_Adres.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBina_Adres.Location = New System.Drawing.Point(5, 5)
        Me.btnBina_Adres.Name = "btnBina_Adres"
        Me.btnBina_Adres.Size = New System.Drawing.Size(240, 30)
        Me.btnBina_Adres.TabIndex = 33
        Me.btnBina_Adres.Text = "Adres"
        Me.btnBina_Adres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBina_Adres.UseVisualStyleBackColor = False
        '
        'btnBina_takas
        '
        Me.btnBina_takas.BackColor = System.Drawing.Color.Silver
        Me.btnBina_takas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBina_takas.FlatAppearance.BorderSize = 0
        Me.btnBina_takas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBina_takas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBina_takas.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBina_takas.Image = CType(resources.GetObject("btnBina_takas.Image"), System.Drawing.Image)
        Me.btnBina_takas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBina_takas.Location = New System.Drawing.Point(5, 250)
        Me.btnBina_takas.Name = "btnBina_takas"
        Me.btnBina_takas.Size = New System.Drawing.Size(240, 30)
        Me.btnBina_takas.TabIndex = 40
        Me.btnBina_takas.Text = "Takaslı"
        Me.btnBina_takas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBina_takas.UseVisualStyleBackColor = False
        '
        'btnBina_ilanTarihi
        '
        Me.btnBina_ilanTarihi.BackColor = System.Drawing.Color.Silver
        Me.btnBina_ilanTarihi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBina_ilanTarihi.FlatAppearance.BorderSize = 0
        Me.btnBina_ilanTarihi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBina_ilanTarihi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBina_ilanTarihi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBina_ilanTarihi.Image = CType(resources.GetObject("btnBina_ilanTarihi.Image"), System.Drawing.Image)
        Me.btnBina_ilanTarihi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBina_ilanTarihi.Location = New System.Drawing.Point(5, 285)
        Me.btnBina_ilanTarihi.Name = "btnBina_ilanTarihi"
        Me.btnBina_ilanTarihi.Size = New System.Drawing.Size(240, 30)
        Me.btnBina_ilanTarihi.TabIndex = 41
        Me.btnBina_ilanTarihi.Text = "İlan Tarihi"
        Me.btnBina_ilanTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBina_ilanTarihi.UseVisualStyleBackColor = False
        '
        'btnBina_fotoVideo
        '
        Me.btnBina_fotoVideo.BackColor = System.Drawing.Color.Silver
        Me.btnBina_fotoVideo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBina_fotoVideo.FlatAppearance.BorderSize = 0
        Me.btnBina_fotoVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBina_fotoVideo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBina_fotoVideo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBina_fotoVideo.Image = CType(resources.GetObject("btnBina_fotoVideo.Image"), System.Drawing.Image)
        Me.btnBina_fotoVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBina_fotoVideo.Location = New System.Drawing.Point(5, 320)
        Me.btnBina_fotoVideo.Name = "btnBina_fotoVideo"
        Me.btnBina_fotoVideo.Size = New System.Drawing.Size(240, 30)
        Me.btnBina_fotoVideo.TabIndex = 42
        Me.btnBina_fotoVideo.Text = "Fotoğraf Video"
        Me.btnBina_fotoVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBina_fotoVideo.UseVisualStyleBackColor = False
        '
        'pnlBina_birKattakiDaire
        '
        Me.pnlBina_birKattakiDaire.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlBina_birKattakiDaire.Controls.Add(Me.txtBina_MaxBirKattakiDaire2)
        Me.pnlBina_birKattakiDaire.Controls.Add(Me.txtBina_MinBirKattakiDaire2)
        Me.pnlBina_birKattakiDaire.Location = New System.Drawing.Point(5, 145)
        Me.pnlBina_birKattakiDaire.Name = "pnlBina_birKattakiDaire"
        Me.pnlBina_birKattakiDaire.Size = New System.Drawing.Size(240, 50)
        Me.pnlBina_birKattakiDaire.TabIndex = 36
        Me.pnlBina_birKattakiDaire.Visible = False
        '
        'txtBina_MaxBirKattakiDaire2
        '
        Me.txtBina_MaxBirKattakiDaire2.ForeColor = System.Drawing.Color.Gray
        Me.txtBina_MaxBirKattakiDaire2.Location = New System.Drawing.Point(130, 10)
        Me.txtBina_MaxBirKattakiDaire2.Name = "txtBina_MaxBirKattakiDaire2"
        Me.txtBina_MaxBirKattakiDaire2.Size = New System.Drawing.Size(100, 27)
        Me.txtBina_MaxBirKattakiDaire2.TabIndex = 31
        Me.txtBina_MaxBirKattakiDaire2.Text = "Max"
        Me.txtBina_MaxBirKattakiDaire2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBina_MinBirKattakiDaire2
        '
        Me.txtBina_MinBirKattakiDaire2.ForeColor = System.Drawing.Color.Gray
        Me.txtBina_MinBirKattakiDaire2.Location = New System.Drawing.Point(10, 10)
        Me.txtBina_MinBirKattakiDaire2.Name = "txtBina_MinBirKattakiDaire2"
        Me.txtBina_MinBirKattakiDaire2.Size = New System.Drawing.Size(100, 27)
        Me.txtBina_MinBirKattakiDaire2.TabIndex = 30
        Me.txtBina_MinBirKattakiDaire2.Text = "Min"
        Me.txtBina_MinBirKattakiDaire2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlBina_kredi
        '
        Me.pnlBina_kredi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlBina_kredi.Controls.Add(Me.rbBinaKredi_hayir)
        Me.pnlBina_kredi.Controls.Add(Me.rbBinaKredi_evet)
        Me.pnlBina_kredi.Location = New System.Drawing.Point(5, 250)
        Me.pnlBina_kredi.Name = "pnlBina_kredi"
        Me.pnlBina_kredi.Size = New System.Drawing.Size(240, 40)
        Me.pnlBina_kredi.TabIndex = 39
        Me.pnlBina_kredi.Visible = False
        '
        'rbBinaKredi_hayir
        '
        Me.rbBinaKredi_hayir.AutoSize = True
        Me.rbBinaKredi_hayir.Location = New System.Drawing.Point(140, 10)
        Me.rbBinaKredi_hayir.Name = "rbBinaKredi_hayir"
        Me.rbBinaKredi_hayir.Size = New System.Drawing.Size(61, 23)
        Me.rbBinaKredi_hayir.TabIndex = 1
        Me.rbBinaKredi_hayir.TabStop = True
        Me.rbBinaKredi_hayir.Text = "Hayır"
        Me.rbBinaKredi_hayir.UseVisualStyleBackColor = True
        '
        'rbBinaKredi_evet
        '
        Me.rbBinaKredi_evet.AutoSize = True
        Me.rbBinaKredi_evet.Location = New System.Drawing.Point(30, 10)
        Me.rbBinaKredi_evet.Name = "rbBinaKredi_evet"
        Me.rbBinaKredi_evet.Size = New System.Drawing.Size(55, 23)
        Me.rbBinaKredi_evet.TabIndex = 0
        Me.rbBinaKredi_evet.TabStop = True
        Me.rbBinaKredi_evet.Text = "Evet"
        Me.rbBinaKredi_evet.UseVisualStyleBackColor = True
        '
        'pnlBina_takas
        '
        Me.pnlBina_takas.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlBina_takas.Controls.Add(Me.rbBinaTakas_hayir)
        Me.pnlBina_takas.Controls.Add(Me.rbBinaTakas_evet)
        Me.pnlBina_takas.Location = New System.Drawing.Point(5, 285)
        Me.pnlBina_takas.Name = "pnlBina_takas"
        Me.pnlBina_takas.Size = New System.Drawing.Size(240, 40)
        Me.pnlBina_takas.TabIndex = 40
        Me.pnlBina_takas.Visible = False
        '
        'rbBinaTakas_hayir
        '
        Me.rbBinaTakas_hayir.AutoSize = True
        Me.rbBinaTakas_hayir.Location = New System.Drawing.Point(140, 10)
        Me.rbBinaTakas_hayir.Name = "rbBinaTakas_hayir"
        Me.rbBinaTakas_hayir.Size = New System.Drawing.Size(61, 23)
        Me.rbBinaTakas_hayir.TabIndex = 1
        Me.rbBinaTakas_hayir.TabStop = True
        Me.rbBinaTakas_hayir.Text = "Hayır"
        Me.rbBinaTakas_hayir.UseVisualStyleBackColor = True
        '
        'rbBinaTakas_evet
        '
        Me.rbBinaTakas_evet.AutoSize = True
        Me.rbBinaTakas_evet.Location = New System.Drawing.Point(30, 10)
        Me.rbBinaTakas_evet.Name = "rbBinaTakas_evet"
        Me.rbBinaTakas_evet.Size = New System.Drawing.Size(55, 23)
        Me.rbBinaTakas_evet.TabIndex = 0
        Me.rbBinaTakas_evet.TabStop = True
        Me.rbBinaTakas_evet.Text = "Evet"
        Me.rbBinaTakas_evet.UseVisualStyleBackColor = True
        '
        'pnlBina_ilanTarihi
        '
        Me.pnlBina_ilanTarihi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlBina_ilanTarihi.Controls.Add(Me.rbBinaIlan_30gun)
        Me.pnlBina_ilanTarihi.Controls.Add(Me.rbBinaIlan_15gun)
        Me.pnlBina_ilanTarihi.Controls.Add(Me.rbBinaIlan_7gun)
        Me.pnlBina_ilanTarihi.Controls.Add(Me.rbBinaIlan_3gun)
        Me.pnlBina_ilanTarihi.Controls.Add(Me.rbBinaIlan_24saat)
        Me.pnlBina_ilanTarihi.Location = New System.Drawing.Point(5, 320)
        Me.pnlBina_ilanTarihi.Name = "pnlBina_ilanTarihi"
        Me.pnlBina_ilanTarihi.Size = New System.Drawing.Size(240, 175)
        Me.pnlBina_ilanTarihi.TabIndex = 41
        Me.pnlBina_ilanTarihi.Visible = False
        '
        'rbBinaIlan_30gun
        '
        Me.rbBinaIlan_30gun.AutoSize = True
        Me.rbBinaIlan_30gun.Location = New System.Drawing.Point(25, 135)
        Me.rbBinaIlan_30gun.Name = "rbBinaIlan_30gun"
        Me.rbBinaIlan_30gun.Size = New System.Drawing.Size(145, 23)
        Me.rbBinaIlan_30gun.TabIndex = 5
        Me.rbBinaIlan_30gun.TabStop = True
        Me.rbBinaIlan_30gun.Text = "Son 30 gün  içinde"
        Me.rbBinaIlan_30gun.UseVisualStyleBackColor = True
        '
        'rbBinaIlan_15gun
        '
        Me.rbBinaIlan_15gun.AutoSize = True
        Me.rbBinaIlan_15gun.Location = New System.Drawing.Point(25, 105)
        Me.rbBinaIlan_15gun.Name = "rbBinaIlan_15gun"
        Me.rbBinaIlan_15gun.Size = New System.Drawing.Size(141, 23)
        Me.rbBinaIlan_15gun.TabIndex = 4
        Me.rbBinaIlan_15gun.TabStop = True
        Me.rbBinaIlan_15gun.Text = "Son 15 gün içinde"
        Me.rbBinaIlan_15gun.UseVisualStyleBackColor = True
        '
        'rbBinaIlan_7gun
        '
        Me.rbBinaIlan_7gun.AutoSize = True
        Me.rbBinaIlan_7gun.Location = New System.Drawing.Point(25, 75)
        Me.rbBinaIlan_7gun.Name = "rbBinaIlan_7gun"
        Me.rbBinaIlan_7gun.Size = New System.Drawing.Size(133, 23)
        Me.rbBinaIlan_7gun.TabIndex = 3
        Me.rbBinaIlan_7gun.TabStop = True
        Me.rbBinaIlan_7gun.Text = "Son 7 gün içinde"
        Me.rbBinaIlan_7gun.UseVisualStyleBackColor = True
        '
        'rbBinaIlan_3gun
        '
        Me.rbBinaIlan_3gun.AutoSize = True
        Me.rbBinaIlan_3gun.Location = New System.Drawing.Point(25, 45)
        Me.rbBinaIlan_3gun.Name = "rbBinaIlan_3gun"
        Me.rbBinaIlan_3gun.Size = New System.Drawing.Size(133, 23)
        Me.rbBinaIlan_3gun.TabIndex = 2
        Me.rbBinaIlan_3gun.TabStop = True
        Me.rbBinaIlan_3gun.Text = "Son 3 gün içinde"
        Me.rbBinaIlan_3gun.UseVisualStyleBackColor = True
        '
        'rbBinaIlan_24saat
        '
        Me.rbBinaIlan_24saat.AutoSize = True
        Me.rbBinaIlan_24saat.Location = New System.Drawing.Point(25, 15)
        Me.rbBinaIlan_24saat.Name = "rbBinaIlan_24saat"
        Me.rbBinaIlan_24saat.Size = New System.Drawing.Size(145, 23)
        Me.rbBinaIlan_24saat.TabIndex = 1
        Me.rbBinaIlan_24saat.TabStop = True
        Me.rbBinaIlan_24saat.Text = "Son 24 saat içinde"
        Me.rbBinaIlan_24saat.UseVisualStyleBackColor = True
        '
        'pnlBina_fotoVideo
        '
        Me.pnlBina_fotoVideo.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlBina_fotoVideo.Controls.Add(Me.chkBina_video)
        Me.pnlBina_fotoVideo.Controls.Add(Me.chkBina_foto)
        Me.pnlBina_fotoVideo.Location = New System.Drawing.Point(5, 355)
        Me.pnlBina_fotoVideo.Name = "pnlBina_fotoVideo"
        Me.pnlBina_fotoVideo.Size = New System.Drawing.Size(240, 75)
        Me.pnlBina_fotoVideo.TabIndex = 42
        Me.pnlBina_fotoVideo.Visible = False
        '
        'chkBina_video
        '
        Me.chkBina_video.AutoSize = True
        Me.chkBina_video.Location = New System.Drawing.Point(25, 40)
        Me.chkBina_video.Name = "chkBina_video"
        Me.chkBina_video.Size = New System.Drawing.Size(122, 23)
        Me.chkBina_video.TabIndex = 1
        Me.chkBina_video.Text = "Videolu İlanlar"
        Me.chkBina_video.UseVisualStyleBackColor = True
        '
        'chkBina_foto
        '
        Me.chkBina_foto.AutoSize = True
        Me.chkBina_foto.Location = New System.Drawing.Point(25, 10)
        Me.chkBina_foto.Name = "chkBina_foto"
        Me.chkBina_foto.Size = New System.Drawing.Size(134, 23)
        Me.chkBina_foto.TabIndex = 0
        Me.chkBina_foto.Text = "Fotoğraflı İlanlar"
        Me.chkBina_foto.UseVisualStyleBackColor = True
        '
        'btnBina_Fiyat
        '
        Me.btnBina_Fiyat.BackColor = System.Drawing.Color.Silver
        Me.btnBina_Fiyat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBina_Fiyat.FlatAppearance.BorderSize = 0
        Me.btnBina_Fiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBina_Fiyat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBina_Fiyat.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBina_Fiyat.Image = CType(resources.GetObject("btnBina_Fiyat.Image"), System.Drawing.Image)
        Me.btnBina_Fiyat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBina_Fiyat.Location = New System.Drawing.Point(5, 40)
        Me.btnBina_Fiyat.Name = "btnBina_Fiyat"
        Me.btnBina_Fiyat.Size = New System.Drawing.Size(240, 30)
        Me.btnBina_Fiyat.TabIndex = 34
        Me.btnBina_Fiyat.Text = "Fiyat"
        Me.btnBina_Fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBina_Fiyat.UseVisualStyleBackColor = False
        '
        'btnBina_KatSayi
        '
        Me.btnBina_KatSayi.BackColor = System.Drawing.Color.Silver
        Me.btnBina_KatSayi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBina_KatSayi.FlatAppearance.BorderSize = 0
        Me.btnBina_KatSayi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBina_KatSayi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBina_KatSayi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBina_KatSayi.Image = CType(resources.GetObject("btnBina_KatSayi.Image"), System.Drawing.Image)
        Me.btnBina_KatSayi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBina_KatSayi.Location = New System.Drawing.Point(5, 75)
        Me.btnBina_KatSayi.Name = "btnBina_KatSayi"
        Me.btnBina_KatSayi.Size = New System.Drawing.Size(240, 30)
        Me.btnBina_KatSayi.TabIndex = 35
        Me.btnBina_KatSayi.Text = "Kat Sayısı"
        Me.btnBina_KatSayi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBina_KatSayi.UseVisualStyleBackColor = False
        '
        'btnBina_birKattakiDaire
        '
        Me.btnBina_birKattakiDaire.BackColor = System.Drawing.Color.Silver
        Me.btnBina_birKattakiDaire.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBina_birKattakiDaire.FlatAppearance.BorderSize = 0
        Me.btnBina_birKattakiDaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBina_birKattakiDaire.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBina_birKattakiDaire.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBina_birKattakiDaire.Image = CType(resources.GetObject("btnBina_birKattakiDaire.Image"), System.Drawing.Image)
        Me.btnBina_birKattakiDaire.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBina_birKattakiDaire.Location = New System.Drawing.Point(5, 110)
        Me.btnBina_birKattakiDaire.Name = "btnBina_birKattakiDaire"
        Me.btnBina_birKattakiDaire.Size = New System.Drawing.Size(240, 30)
        Me.btnBina_birKattakiDaire.TabIndex = 36
        Me.btnBina_birKattakiDaire.Text = "Bir Kattaki Daire"
        Me.btnBina_birKattakiDaire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBina_birKattakiDaire.UseVisualStyleBackColor = False
        '
        'btnBina_kredi
        '
        Me.btnBina_kredi.BackColor = System.Drawing.Color.Silver
        Me.btnBina_kredi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBina_kredi.FlatAppearance.BorderSize = 0
        Me.btnBina_kredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBina_kredi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBina_kredi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBina_kredi.Image = CType(resources.GetObject("btnBina_kredi.Image"), System.Drawing.Image)
        Me.btnBina_kredi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBina_kredi.Location = New System.Drawing.Point(5, 215)
        Me.btnBina_kredi.Name = "btnBina_kredi"
        Me.btnBina_kredi.Size = New System.Drawing.Size(240, 30)
        Me.btnBina_kredi.TabIndex = 39
        Me.btnBina_kredi.Text = "Krediye Uygun"
        Me.btnBina_kredi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBina_kredi.UseVisualStyleBackColor = False
        '
        'pnlBina_fiyat
        '
        Me.pnlBina_fiyat.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlBina_fiyat.Controls.Add(Me.txtBina_MaxTL)
        Me.pnlBina_fiyat.Controls.Add(Me.txtBina_MinTL)
        Me.pnlBina_fiyat.Location = New System.Drawing.Point(5, 75)
        Me.pnlBina_fiyat.Name = "pnlBina_fiyat"
        Me.pnlBina_fiyat.Size = New System.Drawing.Size(240, 50)
        Me.pnlBina_fiyat.TabIndex = 34
        Me.pnlBina_fiyat.Visible = False
        '
        'txtBina_MaxTL
        '
        Me.txtBina_MaxTL.ForeColor = System.Drawing.Color.Gray
        Me.txtBina_MaxTL.Location = New System.Drawing.Point(130, 10)
        Me.txtBina_MaxTL.Name = "txtBina_MaxTL"
        Me.txtBina_MaxTL.Size = New System.Drawing.Size(100, 27)
        Me.txtBina_MaxTL.TabIndex = 1
        Me.txtBina_MaxTL.Text = "Max TL"
        Me.txtBina_MaxTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBina_MinTL
        '
        Me.txtBina_MinTL.ForeColor = System.Drawing.Color.Gray
        Me.txtBina_MinTL.Location = New System.Drawing.Point(10, 10)
        Me.txtBina_MinTL.Name = "txtBina_MinTL"
        Me.txtBina_MinTL.Size = New System.Drawing.Size(100, 27)
        Me.txtBina_MinTL.TabIndex = 0
        Me.txtBina_MinTL.Text = "Min TL"
        Me.txtBina_MinTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlBina_katSayi
        '
        Me.pnlBina_katSayi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlBina_katSayi.Controls.Add(Me.txtBina_MaxKatSayi3)
        Me.pnlBina_katSayi.Controls.Add(Me.txtBina_MinKatSayi3)
        Me.pnlBina_katSayi.Location = New System.Drawing.Point(5, 110)
        Me.pnlBina_katSayi.Name = "pnlBina_katSayi"
        Me.pnlBina_katSayi.Size = New System.Drawing.Size(240, 50)
        Me.pnlBina_katSayi.TabIndex = 35
        Me.pnlBina_katSayi.Visible = False
        '
        'txtBina_MaxKatSayi3
        '
        Me.txtBina_MaxKatSayi3.ForeColor = System.Drawing.Color.Gray
        Me.txtBina_MaxKatSayi3.Location = New System.Drawing.Point(130, 10)
        Me.txtBina_MaxKatSayi3.Name = "txtBina_MaxKatSayi3"
        Me.txtBina_MaxKatSayi3.Size = New System.Drawing.Size(100, 27)
        Me.txtBina_MaxKatSayi3.TabIndex = 31
        Me.txtBina_MaxKatSayi3.Text = "Max"
        Me.txtBina_MaxKatSayi3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBina_MinKatSayi3
        '
        Me.txtBina_MinKatSayi3.ForeColor = System.Drawing.Color.Gray
        Me.txtBina_MinKatSayi3.Location = New System.Drawing.Point(10, 10)
        Me.txtBina_MinKatSayi3.Name = "txtBina_MinKatSayi3"
        Me.txtBina_MinKatSayi3.Size = New System.Drawing.Size(100, 27)
        Me.txtBina_MinKatSayi3.TabIndex = 30
        Me.txtBina_MinKatSayi3.Text = "Min"
        Me.txtBina_MinKatSayi3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlBina_adres
        '
        Me.pnlBina_adres.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlBina_adres.Controls.Add(Me.cbxBina_mahalle)
        Me.pnlBina_adres.Controls.Add(Me.cbxBina_ilce)
        Me.pnlBina_adres.Controls.Add(Me.cbxBina_il)
        Me.pnlBina_adres.Location = New System.Drawing.Point(5, 40)
        Me.pnlBina_adres.Name = "pnlBina_adres"
        Me.pnlBina_adres.Size = New System.Drawing.Size(240, 115)
        Me.pnlBina_adres.TabIndex = 33
        Me.pnlBina_adres.Visible = False
        '
        'cbxBina_mahalle
        '
        Me.cbxBina_mahalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBina_mahalle.FormattingEnabled = True
        Me.cbxBina_mahalle.Location = New System.Drawing.Point(10, 75)
        Me.cbxBina_mahalle.Name = "cbxBina_mahalle"
        Me.cbxBina_mahalle.Size = New System.Drawing.Size(220, 27)
        Me.cbxBina_mahalle.TabIndex = 2
        '
        'cbxBina_ilce
        '
        Me.cbxBina_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBina_ilce.FormattingEnabled = True
        Me.cbxBina_ilce.Location = New System.Drawing.Point(10, 43)
        Me.cbxBina_ilce.Name = "cbxBina_ilce"
        Me.cbxBina_ilce.Size = New System.Drawing.Size(220, 27)
        Me.cbxBina_ilce.TabIndex = 1
        '
        'cbxBina_il
        '
        Me.cbxBina_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBina_il.FormattingEnabled = True
        Me.cbxBina_il.Location = New System.Drawing.Point(10, 10)
        Me.cbxBina_il.Name = "cbxBina_il"
        Me.cbxBina_il.Size = New System.Drawing.Size(220, 27)
        Me.cbxBina_il.TabIndex = 0
        '
        'pnlBina_buyukluk
        '
        Me.pnlBina_buyukluk.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlBina_buyukluk.Controls.Add(Me.txtBina_MaxBuyukluk)
        Me.pnlBina_buyukluk.Controls.Add(Me.txtBina_MinBuyukluk)
        Me.pnlBina_buyukluk.Location = New System.Drawing.Point(5, 215)
        Me.pnlBina_buyukluk.Name = "pnlBina_buyukluk"
        Me.pnlBina_buyukluk.Size = New System.Drawing.Size(240, 50)
        Me.pnlBina_buyukluk.TabIndex = 38
        Me.pnlBina_buyukluk.Visible = False
        '
        'txtBina_MaxBuyukluk
        '
        Me.txtBina_MaxBuyukluk.ForeColor = System.Drawing.Color.Gray
        Me.txtBina_MaxBuyukluk.Location = New System.Drawing.Point(130, 10)
        Me.txtBina_MaxBuyukluk.Name = "txtBina_MaxBuyukluk"
        Me.txtBina_MaxBuyukluk.Size = New System.Drawing.Size(100, 27)
        Me.txtBina_MaxBuyukluk.TabIndex = 1
        Me.txtBina_MaxBuyukluk.Text = "Max"
        Me.txtBina_MaxBuyukluk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBina_MinBuyukluk
        '
        Me.txtBina_MinBuyukluk.ForeColor = System.Drawing.Color.Gray
        Me.txtBina_MinBuyukluk.Location = New System.Drawing.Point(10, 10)
        Me.txtBina_MinBuyukluk.Name = "txtBina_MinBuyukluk"
        Me.txtBina_MinBuyukluk.Size = New System.Drawing.Size(100, 27)
        Me.txtBina_MinBuyukluk.TabIndex = 0
        Me.txtBina_MinBuyukluk.Text = "Min"
        Me.txtBina_MinBuyukluk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlBina_isitma
        '
        Me.pnlBina_isitma.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlBina_isitma.Controls.Add(Me.cbxBina_isitma)
        Me.pnlBina_isitma.Location = New System.Drawing.Point(5, 180)
        Me.pnlBina_isitma.Name = "pnlBina_isitma"
        Me.pnlBina_isitma.Size = New System.Drawing.Size(240, 50)
        Me.pnlBina_isitma.TabIndex = 37
        Me.pnlBina_isitma.Visible = False
        '
        'cbxBina_isitma
        '
        Me.cbxBina_isitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBina_isitma.FormattingEnabled = True
        Me.cbxBina_isitma.Location = New System.Drawing.Point(10, 10)
        Me.cbxBina_isitma.Name = "cbxBina_isitma"
        Me.cbxBina_isitma.Size = New System.Drawing.Size(220, 27)
        Me.cbxBina_isitma.TabIndex = 0
        '
        'pnlIsyeriFiltre
        '
        Me.pnlIsyeriFiltre.AutoSize = True
        Me.pnlIsyeriFiltre.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlIsyeriFiltre.Controls.Add(Me.pnlIsyeri_fotoVideo)
        Me.pnlIsyeriFiltre.Controls.Add(Me.btnIsyeri_FotoVideo)
        Me.pnlIsyeriFiltre.Controls.Add(Me.btnIsyeri_Adres)
        Me.pnlIsyeriFiltre.Controls.Add(Me.pnlIsyeri_ilanTarihi)
        Me.pnlIsyeriFiltre.Controls.Add(Me.btnIsyeri_Fiyat)
        Me.pnlIsyeriFiltre.Controls.Add(Me.btnIsyeri_IlanTarihi)
        Me.pnlIsyeriFiltre.Controls.Add(Me.pnlIsyeri_takas)
        Me.pnlIsyeriFiltre.Controls.Add(Me.btnIsyeri_Takas)
        Me.pnlIsyeriFiltre.Controls.Add(Me.pnlIsyeri_adres)
        Me.pnlIsyeriFiltre.Controls.Add(Me.pnlIsyeri_fiyat)
        Me.pnlIsyeriFiltre.Location = New System.Drawing.Point(5, 0)
        Me.pnlIsyeriFiltre.Name = "pnlIsyeriFiltre"
        Me.pnlIsyeriFiltre.Size = New System.Drawing.Size(250, 714)
        Me.pnlIsyeriFiltre.TabIndex = 18
        '
        'pnlIsyeri_fotoVideo
        '
        Me.pnlIsyeri_fotoVideo.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlIsyeri_fotoVideo.Controls.Add(Me.chkIsyeri_video)
        Me.pnlIsyeri_fotoVideo.Controls.Add(Me.chkIsyeri_foto)
        Me.pnlIsyeri_fotoVideo.Location = New System.Drawing.Point(5, 180)
        Me.pnlIsyeri_fotoVideo.Name = "pnlIsyeri_fotoVideo"
        Me.pnlIsyeri_fotoVideo.Size = New System.Drawing.Size(240, 75)
        Me.pnlIsyeri_fotoVideo.TabIndex = 20
        Me.pnlIsyeri_fotoVideo.Visible = False
        '
        'chkIsyeri_video
        '
        Me.chkIsyeri_video.AutoSize = True
        Me.chkIsyeri_video.Location = New System.Drawing.Point(25, 40)
        Me.chkIsyeri_video.Name = "chkIsyeri_video"
        Me.chkIsyeri_video.Size = New System.Drawing.Size(122, 23)
        Me.chkIsyeri_video.TabIndex = 1
        Me.chkIsyeri_video.Text = "Videolu İlanlar"
        Me.chkIsyeri_video.UseVisualStyleBackColor = True
        '
        'chkIsyeri_foto
        '
        Me.chkIsyeri_foto.AutoSize = True
        Me.chkIsyeri_foto.Location = New System.Drawing.Point(25, 10)
        Me.chkIsyeri_foto.Name = "chkIsyeri_foto"
        Me.chkIsyeri_foto.Size = New System.Drawing.Size(134, 23)
        Me.chkIsyeri_foto.TabIndex = 0
        Me.chkIsyeri_foto.Text = "Fotoğraflı İlanlar"
        Me.chkIsyeri_foto.UseVisualStyleBackColor = True
        '
        'btnIsyeri_FotoVideo
        '
        Me.btnIsyeri_FotoVideo.BackColor = System.Drawing.Color.Silver
        Me.btnIsyeri_FotoVideo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIsyeri_FotoVideo.FlatAppearance.BorderSize = 0
        Me.btnIsyeri_FotoVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIsyeri_FotoVideo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIsyeri_FotoVideo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnIsyeri_FotoVideo.Image = CType(resources.GetObject("btnIsyeri_FotoVideo.Image"), System.Drawing.Image)
        Me.btnIsyeri_FotoVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIsyeri_FotoVideo.Location = New System.Drawing.Point(5, 145)
        Me.btnIsyeri_FotoVideo.Name = "btnIsyeri_FotoVideo"
        Me.btnIsyeri_FotoVideo.Size = New System.Drawing.Size(240, 30)
        Me.btnIsyeri_FotoVideo.TabIndex = 20
        Me.btnIsyeri_FotoVideo.Text = "Fotoğraf Video"
        Me.btnIsyeri_FotoVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIsyeri_FotoVideo.UseVisualStyleBackColor = False
        '
        'btnIsyeri_Adres
        '
        Me.btnIsyeri_Adres.BackColor = System.Drawing.Color.Silver
        Me.btnIsyeri_Adres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIsyeri_Adres.FlatAppearance.BorderSize = 0
        Me.btnIsyeri_Adres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIsyeri_Adres.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIsyeri_Adres.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnIsyeri_Adres.Image = CType(resources.GetObject("btnIsyeri_Adres.Image"), System.Drawing.Image)
        Me.btnIsyeri_Adres.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIsyeri_Adres.Location = New System.Drawing.Point(5, 5)
        Me.btnIsyeri_Adres.Name = "btnIsyeri_Adres"
        Me.btnIsyeri_Adres.Size = New System.Drawing.Size(240, 30)
        Me.btnIsyeri_Adres.TabIndex = 16
        Me.btnIsyeri_Adres.Text = "Adres"
        Me.btnIsyeri_Adres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIsyeri_Adres.UseVisualStyleBackColor = False
        '
        'pnlIsyeri_ilanTarihi
        '
        Me.pnlIsyeri_ilanTarihi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlIsyeri_ilanTarihi.Controls.Add(Me.rbIsyeriIlan_30gun)
        Me.pnlIsyeri_ilanTarihi.Controls.Add(Me.rbIsyeriIlan_15gun)
        Me.pnlIsyeri_ilanTarihi.Controls.Add(Me.rbIsyeriIlan_7gun)
        Me.pnlIsyeri_ilanTarihi.Controls.Add(Me.rbIsyeriIlan_3gun)
        Me.pnlIsyeri_ilanTarihi.Controls.Add(Me.rbIsyeriIlan_24saat)
        Me.pnlIsyeri_ilanTarihi.Location = New System.Drawing.Point(5, 145)
        Me.pnlIsyeri_ilanTarihi.Name = "pnlIsyeri_ilanTarihi"
        Me.pnlIsyeri_ilanTarihi.Size = New System.Drawing.Size(240, 175)
        Me.pnlIsyeri_ilanTarihi.TabIndex = 19
        Me.pnlIsyeri_ilanTarihi.Visible = False
        '
        'rbIsyeriIlan_30gun
        '
        Me.rbIsyeriIlan_30gun.AutoSize = True
        Me.rbIsyeriIlan_30gun.Location = New System.Drawing.Point(25, 135)
        Me.rbIsyeriIlan_30gun.Name = "rbIsyeriIlan_30gun"
        Me.rbIsyeriIlan_30gun.Size = New System.Drawing.Size(145, 23)
        Me.rbIsyeriIlan_30gun.TabIndex = 5
        Me.rbIsyeriIlan_30gun.TabStop = True
        Me.rbIsyeriIlan_30gun.Text = "Son 30 gün  içinde"
        Me.rbIsyeriIlan_30gun.UseVisualStyleBackColor = True
        '
        'rbIsyeriIlan_15gun
        '
        Me.rbIsyeriIlan_15gun.AutoSize = True
        Me.rbIsyeriIlan_15gun.Location = New System.Drawing.Point(25, 105)
        Me.rbIsyeriIlan_15gun.Name = "rbIsyeriIlan_15gun"
        Me.rbIsyeriIlan_15gun.Size = New System.Drawing.Size(141, 23)
        Me.rbIsyeriIlan_15gun.TabIndex = 4
        Me.rbIsyeriIlan_15gun.TabStop = True
        Me.rbIsyeriIlan_15gun.Text = "Son 15 gün içinde"
        Me.rbIsyeriIlan_15gun.UseVisualStyleBackColor = True
        '
        'rbIsyeriIlan_7gun
        '
        Me.rbIsyeriIlan_7gun.AutoSize = True
        Me.rbIsyeriIlan_7gun.Location = New System.Drawing.Point(25, 75)
        Me.rbIsyeriIlan_7gun.Name = "rbIsyeriIlan_7gun"
        Me.rbIsyeriIlan_7gun.Size = New System.Drawing.Size(133, 23)
        Me.rbIsyeriIlan_7gun.TabIndex = 3
        Me.rbIsyeriIlan_7gun.TabStop = True
        Me.rbIsyeriIlan_7gun.Text = "Son 7 gün içinde"
        Me.rbIsyeriIlan_7gun.UseVisualStyleBackColor = True
        '
        'rbIsyeriIlan_3gun
        '
        Me.rbIsyeriIlan_3gun.AutoSize = True
        Me.rbIsyeriIlan_3gun.Location = New System.Drawing.Point(25, 45)
        Me.rbIsyeriIlan_3gun.Name = "rbIsyeriIlan_3gun"
        Me.rbIsyeriIlan_3gun.Size = New System.Drawing.Size(133, 23)
        Me.rbIsyeriIlan_3gun.TabIndex = 2
        Me.rbIsyeriIlan_3gun.TabStop = True
        Me.rbIsyeriIlan_3gun.Text = "Son 3 gün içinde"
        Me.rbIsyeriIlan_3gun.UseVisualStyleBackColor = True
        '
        'rbIsyeriIlan_24saat
        '
        Me.rbIsyeriIlan_24saat.AutoSize = True
        Me.rbIsyeriIlan_24saat.Location = New System.Drawing.Point(25, 15)
        Me.rbIsyeriIlan_24saat.Name = "rbIsyeriIlan_24saat"
        Me.rbIsyeriIlan_24saat.Size = New System.Drawing.Size(145, 23)
        Me.rbIsyeriIlan_24saat.TabIndex = 1
        Me.rbIsyeriIlan_24saat.TabStop = True
        Me.rbIsyeriIlan_24saat.Text = "Son 24 saat içinde"
        Me.rbIsyeriIlan_24saat.UseVisualStyleBackColor = True
        '
        'btnIsyeri_Fiyat
        '
        Me.btnIsyeri_Fiyat.BackColor = System.Drawing.Color.Silver
        Me.btnIsyeri_Fiyat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIsyeri_Fiyat.FlatAppearance.BorderSize = 0
        Me.btnIsyeri_Fiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIsyeri_Fiyat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIsyeri_Fiyat.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnIsyeri_Fiyat.Image = CType(resources.GetObject("btnIsyeri_Fiyat.Image"), System.Drawing.Image)
        Me.btnIsyeri_Fiyat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIsyeri_Fiyat.Location = New System.Drawing.Point(5, 40)
        Me.btnIsyeri_Fiyat.Name = "btnIsyeri_Fiyat"
        Me.btnIsyeri_Fiyat.Size = New System.Drawing.Size(240, 30)
        Me.btnIsyeri_Fiyat.TabIndex = 17
        Me.btnIsyeri_Fiyat.Text = "Fiyat"
        Me.btnIsyeri_Fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIsyeri_Fiyat.UseVisualStyleBackColor = False
        '
        'btnIsyeri_IlanTarihi
        '
        Me.btnIsyeri_IlanTarihi.BackColor = System.Drawing.Color.Silver
        Me.btnIsyeri_IlanTarihi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIsyeri_IlanTarihi.FlatAppearance.BorderSize = 0
        Me.btnIsyeri_IlanTarihi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIsyeri_IlanTarihi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIsyeri_IlanTarihi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnIsyeri_IlanTarihi.Image = CType(resources.GetObject("btnIsyeri_IlanTarihi.Image"), System.Drawing.Image)
        Me.btnIsyeri_IlanTarihi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIsyeri_IlanTarihi.Location = New System.Drawing.Point(5, 110)
        Me.btnIsyeri_IlanTarihi.Name = "btnIsyeri_IlanTarihi"
        Me.btnIsyeri_IlanTarihi.Size = New System.Drawing.Size(240, 30)
        Me.btnIsyeri_IlanTarihi.TabIndex = 19
        Me.btnIsyeri_IlanTarihi.Text = "İlan Tarihi"
        Me.btnIsyeri_IlanTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIsyeri_IlanTarihi.UseVisualStyleBackColor = False
        '
        'pnlIsyeri_takas
        '
        Me.pnlIsyeri_takas.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlIsyeri_takas.Controls.Add(Me.rbIsyeriTakas_hayir)
        Me.pnlIsyeri_takas.Controls.Add(Me.rbIsyeriTakas_evet)
        Me.pnlIsyeri_takas.Location = New System.Drawing.Point(5, 110)
        Me.pnlIsyeri_takas.Name = "pnlIsyeri_takas"
        Me.pnlIsyeri_takas.Size = New System.Drawing.Size(240, 40)
        Me.pnlIsyeri_takas.TabIndex = 18
        Me.pnlIsyeri_takas.Visible = False
        '
        'rbIsyeriTakas_hayir
        '
        Me.rbIsyeriTakas_hayir.AutoSize = True
        Me.rbIsyeriTakas_hayir.Location = New System.Drawing.Point(140, 10)
        Me.rbIsyeriTakas_hayir.Name = "rbIsyeriTakas_hayir"
        Me.rbIsyeriTakas_hayir.Size = New System.Drawing.Size(61, 23)
        Me.rbIsyeriTakas_hayir.TabIndex = 1
        Me.rbIsyeriTakas_hayir.TabStop = True
        Me.rbIsyeriTakas_hayir.Text = "Hayır"
        Me.rbIsyeriTakas_hayir.UseVisualStyleBackColor = True
        '
        'rbIsyeriTakas_evet
        '
        Me.rbIsyeriTakas_evet.AutoSize = True
        Me.rbIsyeriTakas_evet.Location = New System.Drawing.Point(30, 10)
        Me.rbIsyeriTakas_evet.Name = "rbIsyeriTakas_evet"
        Me.rbIsyeriTakas_evet.Size = New System.Drawing.Size(55, 23)
        Me.rbIsyeriTakas_evet.TabIndex = 0
        Me.rbIsyeriTakas_evet.TabStop = True
        Me.rbIsyeriTakas_evet.Text = "Evet"
        Me.rbIsyeriTakas_evet.UseVisualStyleBackColor = True
        '
        'btnIsyeri_Takas
        '
        Me.btnIsyeri_Takas.BackColor = System.Drawing.Color.Silver
        Me.btnIsyeri_Takas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIsyeri_Takas.FlatAppearance.BorderSize = 0
        Me.btnIsyeri_Takas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIsyeri_Takas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIsyeri_Takas.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnIsyeri_Takas.Image = CType(resources.GetObject("btnIsyeri_Takas.Image"), System.Drawing.Image)
        Me.btnIsyeri_Takas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIsyeri_Takas.Location = New System.Drawing.Point(5, 75)
        Me.btnIsyeri_Takas.Name = "btnIsyeri_Takas"
        Me.btnIsyeri_Takas.Size = New System.Drawing.Size(240, 30)
        Me.btnIsyeri_Takas.TabIndex = 18
        Me.btnIsyeri_Takas.Text = "Takaslı"
        Me.btnIsyeri_Takas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIsyeri_Takas.UseVisualStyleBackColor = False
        '
        'pnlIsyeri_adres
        '
        Me.pnlIsyeri_adres.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlIsyeri_adres.Controls.Add(Me.cbxIsyeri_mahalle)
        Me.pnlIsyeri_adres.Controls.Add(Me.cbxIsyeri_ilce)
        Me.pnlIsyeri_adres.Controls.Add(Me.cbxIsyeri_il)
        Me.pnlIsyeri_adres.Location = New System.Drawing.Point(5, 40)
        Me.pnlIsyeri_adres.Name = "pnlIsyeri_adres"
        Me.pnlIsyeri_adres.Size = New System.Drawing.Size(240, 115)
        Me.pnlIsyeri_adres.TabIndex = 16
        Me.pnlIsyeri_adres.Visible = False
        '
        'cbxIsyeri_mahalle
        '
        Me.cbxIsyeri_mahalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIsyeri_mahalle.FormattingEnabled = True
        Me.cbxIsyeri_mahalle.Location = New System.Drawing.Point(10, 75)
        Me.cbxIsyeri_mahalle.Name = "cbxIsyeri_mahalle"
        Me.cbxIsyeri_mahalle.Size = New System.Drawing.Size(220, 27)
        Me.cbxIsyeri_mahalle.TabIndex = 2
        '
        'cbxIsyeri_ilce
        '
        Me.cbxIsyeri_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIsyeri_ilce.FormattingEnabled = True
        Me.cbxIsyeri_ilce.Location = New System.Drawing.Point(10, 43)
        Me.cbxIsyeri_ilce.Name = "cbxIsyeri_ilce"
        Me.cbxIsyeri_ilce.Size = New System.Drawing.Size(220, 27)
        Me.cbxIsyeri_ilce.TabIndex = 1
        '
        'cbxIsyeri_il
        '
        Me.cbxIsyeri_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIsyeri_il.FormattingEnabled = True
        Me.cbxIsyeri_il.Location = New System.Drawing.Point(10, 10)
        Me.cbxIsyeri_il.Name = "cbxIsyeri_il"
        Me.cbxIsyeri_il.Size = New System.Drawing.Size(220, 27)
        Me.cbxIsyeri_il.TabIndex = 17
        '
        'pnlIsyeri_fiyat
        '
        Me.pnlIsyeri_fiyat.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlIsyeri_fiyat.Controls.Add(Me.txtIsyeri_MaxTL)
        Me.pnlIsyeri_fiyat.Controls.Add(Me.txtIsyeri_MinTL)
        Me.pnlIsyeri_fiyat.Location = New System.Drawing.Point(5, 75)
        Me.pnlIsyeri_fiyat.Name = "pnlIsyeri_fiyat"
        Me.pnlIsyeri_fiyat.Size = New System.Drawing.Size(240, 50)
        Me.pnlIsyeri_fiyat.TabIndex = 17
        Me.pnlIsyeri_fiyat.Visible = False
        '
        'txtIsyeri_MaxTL
        '
        Me.txtIsyeri_MaxTL.ForeColor = System.Drawing.Color.Gray
        Me.txtIsyeri_MaxTL.Location = New System.Drawing.Point(130, 10)
        Me.txtIsyeri_MaxTL.Name = "txtIsyeri_MaxTL"
        Me.txtIsyeri_MaxTL.Size = New System.Drawing.Size(100, 27)
        Me.txtIsyeri_MaxTL.TabIndex = 1
        Me.txtIsyeri_MaxTL.Text = "Max TL"
        Me.txtIsyeri_MaxTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIsyeri_MinTL
        '
        Me.txtIsyeri_MinTL.ForeColor = System.Drawing.Color.Gray
        Me.txtIsyeri_MinTL.Location = New System.Drawing.Point(10, 10)
        Me.txtIsyeri_MinTL.Name = "txtIsyeri_MinTL"
        Me.txtIsyeri_MinTL.Size = New System.Drawing.Size(100, 27)
        Me.txtIsyeri_MinTL.TabIndex = 0
        Me.txtIsyeri_MinTL.Text = "Min TL"
        Me.txtIsyeri_MinTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlArsaFiltre
        '
        Me.pnlArsaFiltre.AutoSize = True
        Me.pnlArsaFiltre.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_Adres)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_Takas)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_IlanTarihi)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_FotoVideo)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_kredi)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_takas)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_fotoVideo)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_ilanTarih)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_Gabari)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_TapuDurumu)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_KatKarsilik)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_Gabari)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_kaks)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_Kredi)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_katKarsiligi)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_tapuDurum)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_Buyukluk)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_m2Fiyati)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_imarDurum)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_Kaks)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_m2Fiyat)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_buyukluk)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_Fiyat)
        Me.pnlArsaFiltre.Controls.Add(Me.btnArsa_ImarDurumu)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_fiyat)
        Me.pnlArsaFiltre.Controls.Add(Me.pnlArsa_adres)
        Me.pnlArsaFiltre.Location = New System.Drawing.Point(5, 0)
        Me.pnlArsaFiltre.Name = "pnlArsaFiltre"
        Me.pnlArsaFiltre.Size = New System.Drawing.Size(250, 603)
        Me.pnlArsaFiltre.TabIndex = 18
        '
        'btnArsa_Adres
        '
        Me.btnArsa_Adres.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_Adres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_Adres.FlatAppearance.BorderSize = 0
        Me.btnArsa_Adres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_Adres.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_Adres.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_Adres.Image = CType(resources.GetObject("btnArsa_Adres.Image"), System.Drawing.Image)
        Me.btnArsa_Adres.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_Adres.Location = New System.Drawing.Point(5, 5)
        Me.btnArsa_Adres.Name = "btnArsa_Adres"
        Me.btnArsa_Adres.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_Adres.TabIndex = 20
        Me.btnArsa_Adres.Text = "Adres"
        Me.btnArsa_Adres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_Adres.UseVisualStyleBackColor = False
        '
        'btnArsa_Takas
        '
        Me.btnArsa_Takas.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_Takas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_Takas.FlatAppearance.BorderSize = 0
        Me.btnArsa_Takas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_Takas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_Takas.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_Takas.Image = CType(resources.GetObject("btnArsa_Takas.Image"), System.Drawing.Image)
        Me.btnArsa_Takas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_Takas.Location = New System.Drawing.Point(5, 355)
        Me.btnArsa_Takas.Name = "btnArsa_Takas"
        Me.btnArsa_Takas.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_Takas.TabIndex = 30
        Me.btnArsa_Takas.Text = "Takaslı"
        Me.btnArsa_Takas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_Takas.UseVisualStyleBackColor = False
        '
        'btnArsa_IlanTarihi
        '
        Me.btnArsa_IlanTarihi.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_IlanTarihi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_IlanTarihi.FlatAppearance.BorderSize = 0
        Me.btnArsa_IlanTarihi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_IlanTarihi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_IlanTarihi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_IlanTarihi.Image = CType(resources.GetObject("btnArsa_IlanTarihi.Image"), System.Drawing.Image)
        Me.btnArsa_IlanTarihi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_IlanTarihi.Location = New System.Drawing.Point(5, 390)
        Me.btnArsa_IlanTarihi.Name = "btnArsa_IlanTarihi"
        Me.btnArsa_IlanTarihi.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_IlanTarihi.TabIndex = 31
        Me.btnArsa_IlanTarihi.Text = "İlan Tarihi"
        Me.btnArsa_IlanTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_IlanTarihi.UseVisualStyleBackColor = False
        '
        'btnArsa_FotoVideo
        '
        Me.btnArsa_FotoVideo.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_FotoVideo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_FotoVideo.FlatAppearance.BorderSize = 0
        Me.btnArsa_FotoVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_FotoVideo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_FotoVideo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_FotoVideo.Image = CType(resources.GetObject("btnArsa_FotoVideo.Image"), System.Drawing.Image)
        Me.btnArsa_FotoVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_FotoVideo.Location = New System.Drawing.Point(5, 425)
        Me.btnArsa_FotoVideo.Name = "btnArsa_FotoVideo"
        Me.btnArsa_FotoVideo.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_FotoVideo.TabIndex = 32
        Me.btnArsa_FotoVideo.Text = "Fotoğraf Video"
        Me.btnArsa_FotoVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_FotoVideo.UseVisualStyleBackColor = False
        '
        'pnlArsa_kredi
        '
        Me.pnlArsa_kredi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_kredi.Controls.Add(Me.rbArsaKredi_hayir)
        Me.pnlArsa_kredi.Controls.Add(Me.rbArsaKredi_evet)
        Me.pnlArsa_kredi.Location = New System.Drawing.Point(5, 355)
        Me.pnlArsa_kredi.Name = "pnlArsa_kredi"
        Me.pnlArsa_kredi.Size = New System.Drawing.Size(240, 40)
        Me.pnlArsa_kredi.TabIndex = 29
        Me.pnlArsa_kredi.Visible = False
        '
        'rbArsaKredi_hayir
        '
        Me.rbArsaKredi_hayir.AutoSize = True
        Me.rbArsaKredi_hayir.Location = New System.Drawing.Point(140, 10)
        Me.rbArsaKredi_hayir.Name = "rbArsaKredi_hayir"
        Me.rbArsaKredi_hayir.Size = New System.Drawing.Size(61, 23)
        Me.rbArsaKredi_hayir.TabIndex = 1
        Me.rbArsaKredi_hayir.TabStop = True
        Me.rbArsaKredi_hayir.Text = "Hayır"
        Me.rbArsaKredi_hayir.UseVisualStyleBackColor = True
        '
        'rbArsaKredi_evet
        '
        Me.rbArsaKredi_evet.AutoSize = True
        Me.rbArsaKredi_evet.Location = New System.Drawing.Point(30, 10)
        Me.rbArsaKredi_evet.Name = "rbArsaKredi_evet"
        Me.rbArsaKredi_evet.Size = New System.Drawing.Size(55, 23)
        Me.rbArsaKredi_evet.TabIndex = 0
        Me.rbArsaKredi_evet.TabStop = True
        Me.rbArsaKredi_evet.Text = "Evet"
        Me.rbArsaKredi_evet.UseVisualStyleBackColor = True
        '
        'pnlArsa_takas
        '
        Me.pnlArsa_takas.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_takas.Controls.Add(Me.rbArsaTakas_hayir)
        Me.pnlArsa_takas.Controls.Add(Me.rbArsaTakas_evet)
        Me.pnlArsa_takas.Location = New System.Drawing.Point(5, 390)
        Me.pnlArsa_takas.Name = "pnlArsa_takas"
        Me.pnlArsa_takas.Size = New System.Drawing.Size(240, 40)
        Me.pnlArsa_takas.TabIndex = 30
        Me.pnlArsa_takas.Visible = False
        '
        'rbArsaTakas_hayir
        '
        Me.rbArsaTakas_hayir.AutoSize = True
        Me.rbArsaTakas_hayir.Location = New System.Drawing.Point(140, 10)
        Me.rbArsaTakas_hayir.Name = "rbArsaTakas_hayir"
        Me.rbArsaTakas_hayir.Size = New System.Drawing.Size(61, 23)
        Me.rbArsaTakas_hayir.TabIndex = 1
        Me.rbArsaTakas_hayir.TabStop = True
        Me.rbArsaTakas_hayir.Text = "Hayır"
        Me.rbArsaTakas_hayir.UseVisualStyleBackColor = True
        '
        'rbArsaTakas_evet
        '
        Me.rbArsaTakas_evet.AutoSize = True
        Me.rbArsaTakas_evet.Location = New System.Drawing.Point(30, 10)
        Me.rbArsaTakas_evet.Name = "rbArsaTakas_evet"
        Me.rbArsaTakas_evet.Size = New System.Drawing.Size(55, 23)
        Me.rbArsaTakas_evet.TabIndex = 0
        Me.rbArsaTakas_evet.TabStop = True
        Me.rbArsaTakas_evet.Text = "Evet"
        Me.rbArsaTakas_evet.UseVisualStyleBackColor = True
        '
        'pnlArsa_fotoVideo
        '
        Me.pnlArsa_fotoVideo.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_fotoVideo.Controls.Add(Me.chkArsa_video)
        Me.pnlArsa_fotoVideo.Controls.Add(Me.chkArsa_foto)
        Me.pnlArsa_fotoVideo.Location = New System.Drawing.Point(5, 460)
        Me.pnlArsa_fotoVideo.Name = "pnlArsa_fotoVideo"
        Me.pnlArsa_fotoVideo.Size = New System.Drawing.Size(240, 75)
        Me.pnlArsa_fotoVideo.TabIndex = 32
        Me.pnlArsa_fotoVideo.Visible = False
        '
        'chkArsa_video
        '
        Me.chkArsa_video.AutoSize = True
        Me.chkArsa_video.Location = New System.Drawing.Point(25, 40)
        Me.chkArsa_video.Name = "chkArsa_video"
        Me.chkArsa_video.Size = New System.Drawing.Size(122, 23)
        Me.chkArsa_video.TabIndex = 1
        Me.chkArsa_video.Text = "Videolu İlanlar"
        Me.chkArsa_video.UseVisualStyleBackColor = True
        '
        'chkArsa_foto
        '
        Me.chkArsa_foto.AutoSize = True
        Me.chkArsa_foto.Location = New System.Drawing.Point(25, 10)
        Me.chkArsa_foto.Name = "chkArsa_foto"
        Me.chkArsa_foto.Size = New System.Drawing.Size(134, 23)
        Me.chkArsa_foto.TabIndex = 0
        Me.chkArsa_foto.Text = "Fotoğraflı İlanlar"
        Me.chkArsa_foto.UseVisualStyleBackColor = True
        '
        'pnlArsa_ilanTarih
        '
        Me.pnlArsa_ilanTarih.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_ilanTarih.Controls.Add(Me.rbArsaIlan_30gun)
        Me.pnlArsa_ilanTarih.Controls.Add(Me.rbArsaIlan_15gun)
        Me.pnlArsa_ilanTarih.Controls.Add(Me.rbArsaIlan_7gun)
        Me.pnlArsa_ilanTarih.Controls.Add(Me.rbArsaIlan_3gun)
        Me.pnlArsa_ilanTarih.Controls.Add(Me.rbArsaIlan_24saat)
        Me.pnlArsa_ilanTarih.Location = New System.Drawing.Point(5, 425)
        Me.pnlArsa_ilanTarih.Name = "pnlArsa_ilanTarih"
        Me.pnlArsa_ilanTarih.Size = New System.Drawing.Size(240, 175)
        Me.pnlArsa_ilanTarih.TabIndex = 31
        Me.pnlArsa_ilanTarih.Visible = False
        '
        'rbArsaIlan_30gun
        '
        Me.rbArsaIlan_30gun.AutoSize = True
        Me.rbArsaIlan_30gun.Location = New System.Drawing.Point(25, 135)
        Me.rbArsaIlan_30gun.Name = "rbArsaIlan_30gun"
        Me.rbArsaIlan_30gun.Size = New System.Drawing.Size(145, 23)
        Me.rbArsaIlan_30gun.TabIndex = 5
        Me.rbArsaIlan_30gun.TabStop = True
        Me.rbArsaIlan_30gun.Text = "Son 30 gün  içinde"
        Me.rbArsaIlan_30gun.UseVisualStyleBackColor = True
        '
        'rbArsaIlan_15gun
        '
        Me.rbArsaIlan_15gun.AutoSize = True
        Me.rbArsaIlan_15gun.Location = New System.Drawing.Point(25, 105)
        Me.rbArsaIlan_15gun.Name = "rbArsaIlan_15gun"
        Me.rbArsaIlan_15gun.Size = New System.Drawing.Size(141, 23)
        Me.rbArsaIlan_15gun.TabIndex = 4
        Me.rbArsaIlan_15gun.TabStop = True
        Me.rbArsaIlan_15gun.Text = "Son 15 gün içinde"
        Me.rbArsaIlan_15gun.UseVisualStyleBackColor = True
        '
        'rbArsaIlan_7gun
        '
        Me.rbArsaIlan_7gun.AutoSize = True
        Me.rbArsaIlan_7gun.Location = New System.Drawing.Point(25, 75)
        Me.rbArsaIlan_7gun.Name = "rbArsaIlan_7gun"
        Me.rbArsaIlan_7gun.Size = New System.Drawing.Size(133, 23)
        Me.rbArsaIlan_7gun.TabIndex = 3
        Me.rbArsaIlan_7gun.TabStop = True
        Me.rbArsaIlan_7gun.Text = "Son 7 gün içinde"
        Me.rbArsaIlan_7gun.UseVisualStyleBackColor = True
        '
        'rbArsaIlan_3gun
        '
        Me.rbArsaIlan_3gun.AutoSize = True
        Me.rbArsaIlan_3gun.Location = New System.Drawing.Point(25, 45)
        Me.rbArsaIlan_3gun.Name = "rbArsaIlan_3gun"
        Me.rbArsaIlan_3gun.Size = New System.Drawing.Size(133, 23)
        Me.rbArsaIlan_3gun.TabIndex = 2
        Me.rbArsaIlan_3gun.TabStop = True
        Me.rbArsaIlan_3gun.Text = "Son 3 gün içinde"
        Me.rbArsaIlan_3gun.UseVisualStyleBackColor = True
        '
        'rbArsaIlan_24saat
        '
        Me.rbArsaIlan_24saat.AutoSize = True
        Me.rbArsaIlan_24saat.Location = New System.Drawing.Point(25, 15)
        Me.rbArsaIlan_24saat.Name = "rbArsaIlan_24saat"
        Me.rbArsaIlan_24saat.Size = New System.Drawing.Size(145, 23)
        Me.rbArsaIlan_24saat.TabIndex = 1
        Me.rbArsaIlan_24saat.TabStop = True
        Me.rbArsaIlan_24saat.Text = "Son 24 saat içinde"
        Me.rbArsaIlan_24saat.UseVisualStyleBackColor = True
        '
        'btnArsa_Gabari
        '
        Me.btnArsa_Gabari.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_Gabari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_Gabari.FlatAppearance.BorderSize = 0
        Me.btnArsa_Gabari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_Gabari.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_Gabari.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_Gabari.Image = CType(resources.GetObject("btnArsa_Gabari.Image"), System.Drawing.Image)
        Me.btnArsa_Gabari.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_Gabari.Location = New System.Drawing.Point(5, 215)
        Me.btnArsa_Gabari.Name = "btnArsa_Gabari"
        Me.btnArsa_Gabari.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_Gabari.TabIndex = 26
        Me.btnArsa_Gabari.Text = "Gabari"
        Me.btnArsa_Gabari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_Gabari.UseVisualStyleBackColor = False
        '
        'btnArsa_TapuDurumu
        '
        Me.btnArsa_TapuDurumu.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_TapuDurumu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_TapuDurumu.FlatAppearance.BorderSize = 0
        Me.btnArsa_TapuDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_TapuDurumu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_TapuDurumu.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_TapuDurumu.Image = CType(resources.GetObject("btnArsa_TapuDurumu.Image"), System.Drawing.Image)
        Me.btnArsa_TapuDurumu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_TapuDurumu.Location = New System.Drawing.Point(5, 250)
        Me.btnArsa_TapuDurumu.Name = "btnArsa_TapuDurumu"
        Me.btnArsa_TapuDurumu.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_TapuDurumu.TabIndex = 27
        Me.btnArsa_TapuDurumu.Text = "Tapu Durumu"
        Me.btnArsa_TapuDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_TapuDurumu.UseVisualStyleBackColor = False
        '
        'btnArsa_KatKarsilik
        '
        Me.btnArsa_KatKarsilik.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_KatKarsilik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_KatKarsilik.FlatAppearance.BorderSize = 0
        Me.btnArsa_KatKarsilik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_KatKarsilik.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_KatKarsilik.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_KatKarsilik.Image = CType(resources.GetObject("btnArsa_KatKarsilik.Image"), System.Drawing.Image)
        Me.btnArsa_KatKarsilik.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_KatKarsilik.Location = New System.Drawing.Point(5, 285)
        Me.btnArsa_KatKarsilik.Name = "btnArsa_KatKarsilik"
        Me.btnArsa_KatKarsilik.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_KatKarsilik.TabIndex = 28
        Me.btnArsa_KatKarsilik.Text = "Kat Karşılığı"
        Me.btnArsa_KatKarsilik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_KatKarsilik.UseVisualStyleBackColor = False
        '
        'pnlArsa_Gabari
        '
        Me.pnlArsa_Gabari.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_Gabari.Controls.Add(Me.cbxArsa_gabari)
        Me.pnlArsa_Gabari.Location = New System.Drawing.Point(5, 250)
        Me.pnlArsa_Gabari.Name = "pnlArsa_Gabari"
        Me.pnlArsa_Gabari.Size = New System.Drawing.Size(240, 50)
        Me.pnlArsa_Gabari.TabIndex = 26
        Me.pnlArsa_Gabari.Visible = False
        '
        'cbxArsa_gabari
        '
        Me.cbxArsa_gabari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxArsa_gabari.FormattingEnabled = True
        Me.cbxArsa_gabari.Location = New System.Drawing.Point(10, 10)
        Me.cbxArsa_gabari.Name = "cbxArsa_gabari"
        Me.cbxArsa_gabari.Size = New System.Drawing.Size(220, 27)
        Me.cbxArsa_gabari.TabIndex = 0
        '
        'pnlArsa_kaks
        '
        Me.pnlArsa_kaks.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_kaks.Controls.Add(Me.cbxArsa_kaks)
        Me.pnlArsa_kaks.Location = New System.Drawing.Point(5, 215)
        Me.pnlArsa_kaks.Name = "pnlArsa_kaks"
        Me.pnlArsa_kaks.Size = New System.Drawing.Size(240, 50)
        Me.pnlArsa_kaks.TabIndex = 25
        Me.pnlArsa_kaks.Visible = False
        '
        'cbxArsa_kaks
        '
        Me.cbxArsa_kaks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxArsa_kaks.FormattingEnabled = True
        Me.cbxArsa_kaks.Location = New System.Drawing.Point(10, 10)
        Me.cbxArsa_kaks.Name = "cbxArsa_kaks"
        Me.cbxArsa_kaks.Size = New System.Drawing.Size(220, 27)
        Me.cbxArsa_kaks.TabIndex = 0
        '
        'btnArsa_Kredi
        '
        Me.btnArsa_Kredi.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_Kredi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_Kredi.FlatAppearance.BorderSize = 0
        Me.btnArsa_Kredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_Kredi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_Kredi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_Kredi.Image = CType(resources.GetObject("btnArsa_Kredi.Image"), System.Drawing.Image)
        Me.btnArsa_Kredi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_Kredi.Location = New System.Drawing.Point(5, 320)
        Me.btnArsa_Kredi.Name = "btnArsa_Kredi"
        Me.btnArsa_Kredi.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_Kredi.TabIndex = 29
        Me.btnArsa_Kredi.Text = "Krediye Uygun"
        Me.btnArsa_Kredi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_Kredi.UseVisualStyleBackColor = False
        '
        'pnlArsa_katKarsiligi
        '
        Me.pnlArsa_katKarsiligi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_katKarsiligi.Controls.Add(Me.rbArsaKat_hayir)
        Me.pnlArsa_katKarsiligi.Controls.Add(Me.rbArsaKat_evet)
        Me.pnlArsa_katKarsiligi.Location = New System.Drawing.Point(5, 320)
        Me.pnlArsa_katKarsiligi.Name = "pnlArsa_katKarsiligi"
        Me.pnlArsa_katKarsiligi.Size = New System.Drawing.Size(240, 40)
        Me.pnlArsa_katKarsiligi.TabIndex = 28
        Me.pnlArsa_katKarsiligi.Visible = False
        '
        'rbArsaKat_hayir
        '
        Me.rbArsaKat_hayir.AutoSize = True
        Me.rbArsaKat_hayir.Location = New System.Drawing.Point(140, 10)
        Me.rbArsaKat_hayir.Name = "rbArsaKat_hayir"
        Me.rbArsaKat_hayir.Size = New System.Drawing.Size(61, 23)
        Me.rbArsaKat_hayir.TabIndex = 1
        Me.rbArsaKat_hayir.TabStop = True
        Me.rbArsaKat_hayir.Text = "Hayır"
        Me.rbArsaKat_hayir.UseVisualStyleBackColor = True
        '
        'rbArsaKat_evet
        '
        Me.rbArsaKat_evet.AutoSize = True
        Me.rbArsaKat_evet.Location = New System.Drawing.Point(30, 10)
        Me.rbArsaKat_evet.Name = "rbArsaKat_evet"
        Me.rbArsaKat_evet.Size = New System.Drawing.Size(55, 23)
        Me.rbArsaKat_evet.TabIndex = 0
        Me.rbArsaKat_evet.TabStop = True
        Me.rbArsaKat_evet.Text = "Evet"
        Me.rbArsaKat_evet.UseVisualStyleBackColor = True
        '
        'pnlArsa_tapuDurum
        '
        Me.pnlArsa_tapuDurum.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_tapuDurum.Controls.Add(Me.cbxArsa_tapuDurum)
        Me.pnlArsa_tapuDurum.Location = New System.Drawing.Point(5, 285)
        Me.pnlArsa_tapuDurum.Name = "pnlArsa_tapuDurum"
        Me.pnlArsa_tapuDurum.Size = New System.Drawing.Size(240, 50)
        Me.pnlArsa_tapuDurum.TabIndex = 27
        Me.pnlArsa_tapuDurum.Visible = False
        '
        'cbxArsa_tapuDurum
        '
        Me.cbxArsa_tapuDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxArsa_tapuDurum.FormattingEnabled = True
        Me.cbxArsa_tapuDurum.Location = New System.Drawing.Point(10, 10)
        Me.cbxArsa_tapuDurum.Name = "cbxArsa_tapuDurum"
        Me.cbxArsa_tapuDurum.Size = New System.Drawing.Size(220, 27)
        Me.cbxArsa_tapuDurum.TabIndex = 0
        '
        'btnArsa_Buyukluk
        '
        Me.btnArsa_Buyukluk.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_Buyukluk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_Buyukluk.FlatAppearance.BorderSize = 0
        Me.btnArsa_Buyukluk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_Buyukluk.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_Buyukluk.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_Buyukluk.Image = CType(resources.GetObject("btnArsa_Buyukluk.Image"), System.Drawing.Image)
        Me.btnArsa_Buyukluk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_Buyukluk.Location = New System.Drawing.Point(5, 110)
        Me.btnArsa_Buyukluk.Name = "btnArsa_Buyukluk"
        Me.btnArsa_Buyukluk.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_Buyukluk.TabIndex = 23
        Me.btnArsa_Buyukluk.Text = "Büyüklük (m2)"
        Me.btnArsa_Buyukluk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_Buyukluk.UseVisualStyleBackColor = False
        '
        'btnArsa_m2Fiyati
        '
        Me.btnArsa_m2Fiyati.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_m2Fiyati.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_m2Fiyati.FlatAppearance.BorderSize = 0
        Me.btnArsa_m2Fiyati.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_m2Fiyati.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_m2Fiyati.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_m2Fiyati.Image = CType(resources.GetObject("btnArsa_m2Fiyati.Image"), System.Drawing.Image)
        Me.btnArsa_m2Fiyati.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_m2Fiyati.Location = New System.Drawing.Point(5, 145)
        Me.btnArsa_m2Fiyati.Name = "btnArsa_m2Fiyati"
        Me.btnArsa_m2Fiyati.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_m2Fiyati.TabIndex = 24
        Me.btnArsa_m2Fiyati.Text = "m2 Fiyatı"
        Me.btnArsa_m2Fiyati.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_m2Fiyati.UseVisualStyleBackColor = False
        '
        'pnlArsa_imarDurum
        '
        Me.pnlArsa_imarDurum.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_imarDurum.Controls.Add(Me.cbxArsa_imarDurum)
        Me.pnlArsa_imarDurum.Location = New System.Drawing.Point(5, 110)
        Me.pnlArsa_imarDurum.Name = "pnlArsa_imarDurum"
        Me.pnlArsa_imarDurum.Size = New System.Drawing.Size(240, 50)
        Me.pnlArsa_imarDurum.TabIndex = 22
        Me.pnlArsa_imarDurum.Visible = False
        '
        'cbxArsa_imarDurum
        '
        Me.cbxArsa_imarDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxArsa_imarDurum.FormattingEnabled = True
        Me.cbxArsa_imarDurum.Location = New System.Drawing.Point(10, 10)
        Me.cbxArsa_imarDurum.Name = "cbxArsa_imarDurum"
        Me.cbxArsa_imarDurum.Size = New System.Drawing.Size(220, 27)
        Me.cbxArsa_imarDurum.TabIndex = 0
        '
        'btnArsa_Kaks
        '
        Me.btnArsa_Kaks.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_Kaks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_Kaks.FlatAppearance.BorderSize = 0
        Me.btnArsa_Kaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_Kaks.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_Kaks.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_Kaks.Image = CType(resources.GetObject("btnArsa_Kaks.Image"), System.Drawing.Image)
        Me.btnArsa_Kaks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_Kaks.Location = New System.Drawing.Point(5, 180)
        Me.btnArsa_Kaks.Name = "btnArsa_Kaks"
        Me.btnArsa_Kaks.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_Kaks.TabIndex = 25
        Me.btnArsa_Kaks.Text = "Kaks (Emsal)"
        Me.btnArsa_Kaks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_Kaks.UseVisualStyleBackColor = False
        '
        'pnlArsa_m2Fiyat
        '
        Me.pnlArsa_m2Fiyat.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_m2Fiyat.Controls.Add(Me.txtArsa_MaxM4Fiyat)
        Me.pnlArsa_m2Fiyat.Controls.Add(Me.txtArsa_MinM4Fiyat)
        Me.pnlArsa_m2Fiyat.Location = New System.Drawing.Point(5, 180)
        Me.pnlArsa_m2Fiyat.Name = "pnlArsa_m2Fiyat"
        Me.pnlArsa_m2Fiyat.Size = New System.Drawing.Size(240, 50)
        Me.pnlArsa_m2Fiyat.TabIndex = 24
        Me.pnlArsa_m2Fiyat.Visible = False
        '
        'txtArsa_MaxM4Fiyat
        '
        Me.txtArsa_MaxM4Fiyat.ForeColor = System.Drawing.Color.Gray
        Me.txtArsa_MaxM4Fiyat.Location = New System.Drawing.Point(130, 10)
        Me.txtArsa_MaxM4Fiyat.Name = "txtArsa_MaxM4Fiyat"
        Me.txtArsa_MaxM4Fiyat.Size = New System.Drawing.Size(100, 27)
        Me.txtArsa_MaxM4Fiyat.TabIndex = 1
        Me.txtArsa_MaxM4Fiyat.Text = "Max TL"
        Me.txtArsa_MaxM4Fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtArsa_MinM4Fiyat
        '
        Me.txtArsa_MinM4Fiyat.ForeColor = System.Drawing.Color.Gray
        Me.txtArsa_MinM4Fiyat.Location = New System.Drawing.Point(10, 10)
        Me.txtArsa_MinM4Fiyat.Name = "txtArsa_MinM4Fiyat"
        Me.txtArsa_MinM4Fiyat.Size = New System.Drawing.Size(100, 27)
        Me.txtArsa_MinM4Fiyat.TabIndex = 0
        Me.txtArsa_MinM4Fiyat.Text = "Min TL"
        Me.txtArsa_MinM4Fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlArsa_buyukluk
        '
        Me.pnlArsa_buyukluk.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_buyukluk.Controls.Add(Me.txtArsa_MaxBuyukluk)
        Me.pnlArsa_buyukluk.Controls.Add(Me.txtArsa_MinBuyukluk)
        Me.pnlArsa_buyukluk.Location = New System.Drawing.Point(5, 145)
        Me.pnlArsa_buyukluk.Name = "pnlArsa_buyukluk"
        Me.pnlArsa_buyukluk.Size = New System.Drawing.Size(240, 50)
        Me.pnlArsa_buyukluk.TabIndex = 23
        Me.pnlArsa_buyukluk.Visible = False
        '
        'txtArsa_MaxBuyukluk
        '
        Me.txtArsa_MaxBuyukluk.ForeColor = System.Drawing.Color.Gray
        Me.txtArsa_MaxBuyukluk.Location = New System.Drawing.Point(130, 10)
        Me.txtArsa_MaxBuyukluk.Name = "txtArsa_MaxBuyukluk"
        Me.txtArsa_MaxBuyukluk.Size = New System.Drawing.Size(100, 27)
        Me.txtArsa_MaxBuyukluk.TabIndex = 1
        Me.txtArsa_MaxBuyukluk.Text = "Max"
        Me.txtArsa_MaxBuyukluk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtArsa_MinBuyukluk
        '
        Me.txtArsa_MinBuyukluk.ForeColor = System.Drawing.Color.Gray
        Me.txtArsa_MinBuyukluk.Location = New System.Drawing.Point(10, 10)
        Me.txtArsa_MinBuyukluk.Name = "txtArsa_MinBuyukluk"
        Me.txtArsa_MinBuyukluk.Size = New System.Drawing.Size(100, 27)
        Me.txtArsa_MinBuyukluk.TabIndex = 0
        Me.txtArsa_MinBuyukluk.Text = "Min"
        Me.txtArsa_MinBuyukluk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnArsa_Fiyat
        '
        Me.btnArsa_Fiyat.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_Fiyat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_Fiyat.FlatAppearance.BorderSize = 0
        Me.btnArsa_Fiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_Fiyat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_Fiyat.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_Fiyat.Image = CType(resources.GetObject("btnArsa_Fiyat.Image"), System.Drawing.Image)
        Me.btnArsa_Fiyat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_Fiyat.Location = New System.Drawing.Point(5, 40)
        Me.btnArsa_Fiyat.Name = "btnArsa_Fiyat"
        Me.btnArsa_Fiyat.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_Fiyat.TabIndex = 21
        Me.btnArsa_Fiyat.Text = "Fiyat"
        Me.btnArsa_Fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_Fiyat.UseVisualStyleBackColor = False
        '
        'btnArsa_ImarDurumu
        '
        Me.btnArsa_ImarDurumu.BackColor = System.Drawing.Color.Silver
        Me.btnArsa_ImarDurumu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArsa_ImarDurumu.FlatAppearance.BorderSize = 0
        Me.btnArsa_ImarDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArsa_ImarDurumu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArsa_ImarDurumu.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnArsa_ImarDurumu.Image = CType(resources.GetObject("btnArsa_ImarDurumu.Image"), System.Drawing.Image)
        Me.btnArsa_ImarDurumu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArsa_ImarDurumu.Location = New System.Drawing.Point(5, 75)
        Me.btnArsa_ImarDurumu.Name = "btnArsa_ImarDurumu"
        Me.btnArsa_ImarDurumu.Size = New System.Drawing.Size(240, 30)
        Me.btnArsa_ImarDurumu.TabIndex = 22
        Me.btnArsa_ImarDurumu.Text = "İmar Durumu"
        Me.btnArsa_ImarDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArsa_ImarDurumu.UseVisualStyleBackColor = False
        '
        'pnlArsa_fiyat
        '
        Me.pnlArsa_fiyat.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_fiyat.Controls.Add(Me.txtArsaFiyat_MaxTL)
        Me.pnlArsa_fiyat.Controls.Add(Me.txtArsaFiyat_MinTL)
        Me.pnlArsa_fiyat.Location = New System.Drawing.Point(5, 75)
        Me.pnlArsa_fiyat.Name = "pnlArsa_fiyat"
        Me.pnlArsa_fiyat.Size = New System.Drawing.Size(240, 50)
        Me.pnlArsa_fiyat.TabIndex = 21
        Me.pnlArsa_fiyat.Visible = False
        '
        'txtArsaFiyat_MaxTL
        '
        Me.txtArsaFiyat_MaxTL.ForeColor = System.Drawing.Color.Gray
        Me.txtArsaFiyat_MaxTL.Location = New System.Drawing.Point(130, 10)
        Me.txtArsaFiyat_MaxTL.Name = "txtArsaFiyat_MaxTL"
        Me.txtArsaFiyat_MaxTL.Size = New System.Drawing.Size(100, 27)
        Me.txtArsaFiyat_MaxTL.TabIndex = 1
        Me.txtArsaFiyat_MaxTL.Text = "Max TL"
        Me.txtArsaFiyat_MaxTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtArsaFiyat_MinTL
        '
        Me.txtArsaFiyat_MinTL.ForeColor = System.Drawing.Color.Gray
        Me.txtArsaFiyat_MinTL.Location = New System.Drawing.Point(10, 10)
        Me.txtArsaFiyat_MinTL.Name = "txtArsaFiyat_MinTL"
        Me.txtArsaFiyat_MinTL.Size = New System.Drawing.Size(100, 27)
        Me.txtArsaFiyat_MinTL.TabIndex = 0
        Me.txtArsaFiyat_MinTL.Text = "Min TL"
        Me.txtArsaFiyat_MinTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlArsa_adres
        '
        Me.pnlArsa_adres.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlArsa_adres.Controls.Add(Me.cbxArsa_mahalle)
        Me.pnlArsa_adres.Controls.Add(Me.cbxArsa_ilce)
        Me.pnlArsa_adres.Controls.Add(Me.cbxArsa_il)
        Me.pnlArsa_adres.Location = New System.Drawing.Point(5, 40)
        Me.pnlArsa_adres.Name = "pnlArsa_adres"
        Me.pnlArsa_adres.Size = New System.Drawing.Size(240, 115)
        Me.pnlArsa_adres.TabIndex = 20
        Me.pnlArsa_adres.Visible = False
        '
        'cbxArsa_mahalle
        '
        Me.cbxArsa_mahalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxArsa_mahalle.FormattingEnabled = True
        Me.cbxArsa_mahalle.Location = New System.Drawing.Point(10, 75)
        Me.cbxArsa_mahalle.Name = "cbxArsa_mahalle"
        Me.cbxArsa_mahalle.Size = New System.Drawing.Size(220, 27)
        Me.cbxArsa_mahalle.TabIndex = 2
        '
        'cbxArsa_ilce
        '
        Me.cbxArsa_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxArsa_ilce.FormattingEnabled = True
        Me.cbxArsa_ilce.Location = New System.Drawing.Point(10, 43)
        Me.cbxArsa_ilce.Name = "cbxArsa_ilce"
        Me.cbxArsa_ilce.Size = New System.Drawing.Size(220, 27)
        Me.cbxArsa_ilce.TabIndex = 1
        '
        'cbxArsa_il
        '
        Me.cbxArsa_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxArsa_il.FormattingEnabled = True
        Me.cbxArsa_il.Location = New System.Drawing.Point(10, 10)
        Me.cbxArsa_il.Name = "cbxArsa_il"
        Me.cbxArsa_il.Size = New System.Drawing.Size(220, 27)
        Me.cbxArsa_il.TabIndex = 0
        '
        'pnlTuristikFiltre
        '
        Me.pnlTuristikFiltre.AutoSize = True
        Me.pnlTuristikFiltre.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlTuristikFiltre.Controls.Add(Me.btnTuristik_fotoVideo)
        Me.pnlTuristikFiltre.Controls.Add(Me.btnTuristik_fiyat)
        Me.pnlTuristikFiltre.Controls.Add(Me.btnTuristik_adres)
        Me.pnlTuristikFiltre.Controls.Add(Me.btnTuristik_ilanTarihi)
        Me.pnlTuristikFiltre.Controls.Add(Me.pnlTuristik_adres)
        Me.pnlTuristikFiltre.Controls.Add(Me.pnlTuristik_fiyat)
        Me.pnlTuristikFiltre.Controls.Add(Me.pnlTuristik_fotoVideo)
        Me.pnlTuristikFiltre.Controls.Add(Me.pnlTuristik_ilanTarihi)
        Me.pnlTuristikFiltre.Location = New System.Drawing.Point(5, 0)
        Me.pnlTuristikFiltre.Name = "pnlTuristikFiltre"
        Me.pnlTuristikFiltre.Size = New System.Drawing.Size(250, 288)
        Me.pnlTuristikFiltre.TabIndex = 19
        '
        'btnTuristik_fotoVideo
        '
        Me.btnTuristik_fotoVideo.BackColor = System.Drawing.Color.Silver
        Me.btnTuristik_fotoVideo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTuristik_fotoVideo.FlatAppearance.BorderSize = 0
        Me.btnTuristik_fotoVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTuristik_fotoVideo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTuristik_fotoVideo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnTuristik_fotoVideo.Image = CType(resources.GetObject("btnTuristik_fotoVideo.Image"), System.Drawing.Image)
        Me.btnTuristik_fotoVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTuristik_fotoVideo.Location = New System.Drawing.Point(5, 110)
        Me.btnTuristik_fotoVideo.Name = "btnTuristik_fotoVideo"
        Me.btnTuristik_fotoVideo.Size = New System.Drawing.Size(240, 30)
        Me.btnTuristik_fotoVideo.TabIndex = 46
        Me.btnTuristik_fotoVideo.Text = "Fotoğraf Video"
        Me.btnTuristik_fotoVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTuristik_fotoVideo.UseVisualStyleBackColor = False
        '
        'btnTuristik_fiyat
        '
        Me.btnTuristik_fiyat.BackColor = System.Drawing.Color.Silver
        Me.btnTuristik_fiyat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTuristik_fiyat.FlatAppearance.BorderSize = 0
        Me.btnTuristik_fiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTuristik_fiyat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTuristik_fiyat.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnTuristik_fiyat.Image = CType(resources.GetObject("btnTuristik_fiyat.Image"), System.Drawing.Image)
        Me.btnTuristik_fiyat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTuristik_fiyat.Location = New System.Drawing.Point(5, 40)
        Me.btnTuristik_fiyat.Name = "btnTuristik_fiyat"
        Me.btnTuristik_fiyat.Size = New System.Drawing.Size(240, 30)
        Me.btnTuristik_fiyat.TabIndex = 44
        Me.btnTuristik_fiyat.Text = "Fiyat"
        Me.btnTuristik_fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTuristik_fiyat.UseVisualStyleBackColor = False
        '
        'btnTuristik_adres
        '
        Me.btnTuristik_adres.BackColor = System.Drawing.Color.Silver
        Me.btnTuristik_adres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTuristik_adres.FlatAppearance.BorderSize = 0
        Me.btnTuristik_adres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTuristik_adres.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTuristik_adres.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnTuristik_adres.Image = CType(resources.GetObject("btnTuristik_adres.Image"), System.Drawing.Image)
        Me.btnTuristik_adres.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTuristik_adres.Location = New System.Drawing.Point(5, 5)
        Me.btnTuristik_adres.Name = "btnTuristik_adres"
        Me.btnTuristik_adres.Size = New System.Drawing.Size(240, 30)
        Me.btnTuristik_adres.TabIndex = 43
        Me.btnTuristik_adres.Text = "Adres"
        Me.btnTuristik_adres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTuristik_adres.UseVisualStyleBackColor = False
        '
        'btnTuristik_ilanTarihi
        '
        Me.btnTuristik_ilanTarihi.BackColor = System.Drawing.Color.Silver
        Me.btnTuristik_ilanTarihi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTuristik_ilanTarihi.FlatAppearance.BorderSize = 0
        Me.btnTuristik_ilanTarihi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTuristik_ilanTarihi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTuristik_ilanTarihi.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnTuristik_ilanTarihi.Image = CType(resources.GetObject("btnTuristik_ilanTarihi.Image"), System.Drawing.Image)
        Me.btnTuristik_ilanTarihi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTuristik_ilanTarihi.Location = New System.Drawing.Point(5, 75)
        Me.btnTuristik_ilanTarihi.Name = "btnTuristik_ilanTarihi"
        Me.btnTuristik_ilanTarihi.Size = New System.Drawing.Size(240, 30)
        Me.btnTuristik_ilanTarihi.TabIndex = 45
        Me.btnTuristik_ilanTarihi.Text = "İlan Tarihi"
        Me.btnTuristik_ilanTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTuristik_ilanTarihi.UseVisualStyleBackColor = False
        '
        'pnlTuristik_adres
        '
        Me.pnlTuristik_adres.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlTuristik_adres.Controls.Add(Me.cbxTuristik_mahalle)
        Me.pnlTuristik_adres.Controls.Add(Me.cbxTuristik_ilce)
        Me.pnlTuristik_adres.Controls.Add(Me.cbxTuristik_il)
        Me.pnlTuristik_adres.Location = New System.Drawing.Point(5, 40)
        Me.pnlTuristik_adres.Name = "pnlTuristik_adres"
        Me.pnlTuristik_adres.Size = New System.Drawing.Size(240, 115)
        Me.pnlTuristik_adres.TabIndex = 43
        Me.pnlTuristik_adres.Visible = False
        '
        'cbxTuristik_mahalle
        '
        Me.cbxTuristik_mahalle.FormattingEnabled = True
        Me.cbxTuristik_mahalle.Location = New System.Drawing.Point(10, 75)
        Me.cbxTuristik_mahalle.Name = "cbxTuristik_mahalle"
        Me.cbxTuristik_mahalle.Size = New System.Drawing.Size(220, 27)
        Me.cbxTuristik_mahalle.TabIndex = 2
        '
        'cbxTuristik_ilce
        '
        Me.cbxTuristik_ilce.FormattingEnabled = True
        Me.cbxTuristik_ilce.Location = New System.Drawing.Point(10, 43)
        Me.cbxTuristik_ilce.Name = "cbxTuristik_ilce"
        Me.cbxTuristik_ilce.Size = New System.Drawing.Size(220, 27)
        Me.cbxTuristik_ilce.TabIndex = 1
        '
        'cbxTuristik_il
        '
        Me.cbxTuristik_il.FormattingEnabled = True
        Me.cbxTuristik_il.Location = New System.Drawing.Point(10, 10)
        Me.cbxTuristik_il.Name = "cbxTuristik_il"
        Me.cbxTuristik_il.Size = New System.Drawing.Size(220, 27)
        Me.cbxTuristik_il.TabIndex = 0
        '
        'pnlTuristik_fiyat
        '
        Me.pnlTuristik_fiyat.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlTuristik_fiyat.Controls.Add(Me.txtTuristik_MaxTL)
        Me.pnlTuristik_fiyat.Controls.Add(Me.txtTuristik_MinTL)
        Me.pnlTuristik_fiyat.Location = New System.Drawing.Point(5, 75)
        Me.pnlTuristik_fiyat.Name = "pnlTuristik_fiyat"
        Me.pnlTuristik_fiyat.Size = New System.Drawing.Size(240, 50)
        Me.pnlTuristik_fiyat.TabIndex = 44
        Me.pnlTuristik_fiyat.Visible = False
        '
        'txtTuristik_MaxTL
        '
        Me.txtTuristik_MaxTL.ForeColor = System.Drawing.Color.Gray
        Me.txtTuristik_MaxTL.Location = New System.Drawing.Point(130, 10)
        Me.txtTuristik_MaxTL.Name = "txtTuristik_MaxTL"
        Me.txtTuristik_MaxTL.Size = New System.Drawing.Size(100, 27)
        Me.txtTuristik_MaxTL.TabIndex = 1
        Me.txtTuristik_MaxTL.Text = "Max TL"
        Me.txtTuristik_MaxTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTuristik_MinTL
        '
        Me.txtTuristik_MinTL.ForeColor = System.Drawing.Color.Gray
        Me.txtTuristik_MinTL.Location = New System.Drawing.Point(10, 10)
        Me.txtTuristik_MinTL.Name = "txtTuristik_MinTL"
        Me.txtTuristik_MinTL.Size = New System.Drawing.Size(100, 27)
        Me.txtTuristik_MinTL.TabIndex = 0
        Me.txtTuristik_MinTL.Text = "Min TL"
        Me.txtTuristik_MinTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlTuristik_fotoVideo
        '
        Me.pnlTuristik_fotoVideo.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlTuristik_fotoVideo.Controls.Add(Me.chkTuristik_video)
        Me.pnlTuristik_fotoVideo.Controls.Add(Me.chkTuristik_foto)
        Me.pnlTuristik_fotoVideo.Location = New System.Drawing.Point(5, 145)
        Me.pnlTuristik_fotoVideo.Name = "pnlTuristik_fotoVideo"
        Me.pnlTuristik_fotoVideo.Size = New System.Drawing.Size(240, 75)
        Me.pnlTuristik_fotoVideo.TabIndex = 46
        Me.pnlTuristik_fotoVideo.Visible = False
        '
        'chkTuristik_video
        '
        Me.chkTuristik_video.AutoSize = True
        Me.chkTuristik_video.Location = New System.Drawing.Point(25, 40)
        Me.chkTuristik_video.Name = "chkTuristik_video"
        Me.chkTuristik_video.Size = New System.Drawing.Size(122, 23)
        Me.chkTuristik_video.TabIndex = 1
        Me.chkTuristik_video.Text = "Videolu İlanlar"
        Me.chkTuristik_video.UseVisualStyleBackColor = True
        '
        'chkTuristik_foto
        '
        Me.chkTuristik_foto.AutoSize = True
        Me.chkTuristik_foto.Location = New System.Drawing.Point(25, 10)
        Me.chkTuristik_foto.Name = "chkTuristik_foto"
        Me.chkTuristik_foto.Size = New System.Drawing.Size(134, 23)
        Me.chkTuristik_foto.TabIndex = 0
        Me.chkTuristik_foto.Text = "Fotoğraflı İlanlar"
        Me.chkTuristik_foto.UseVisualStyleBackColor = True
        '
        'pnlTuristik_ilanTarihi
        '
        Me.pnlTuristik_ilanTarihi.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlTuristik_ilanTarihi.Controls.Add(Me.rbTuristikIlan_30gun)
        Me.pnlTuristik_ilanTarihi.Controls.Add(Me.rbTuristikIlan_15gun)
        Me.pnlTuristik_ilanTarihi.Controls.Add(Me.rbTuristikIlan_7gun)
        Me.pnlTuristik_ilanTarihi.Controls.Add(Me.rbTuristikIlan_3gun)
        Me.pnlTuristik_ilanTarihi.Controls.Add(Me.rbTuristikIlan_24saat)
        Me.pnlTuristik_ilanTarihi.Location = New System.Drawing.Point(5, 110)
        Me.pnlTuristik_ilanTarihi.Name = "pnlTuristik_ilanTarihi"
        Me.pnlTuristik_ilanTarihi.Size = New System.Drawing.Size(240, 175)
        Me.pnlTuristik_ilanTarihi.TabIndex = 45
        Me.pnlTuristik_ilanTarihi.Visible = False
        '
        'rbTuristikIlan_30gun
        '
        Me.rbTuristikIlan_30gun.AutoSize = True
        Me.rbTuristikIlan_30gun.Location = New System.Drawing.Point(25, 135)
        Me.rbTuristikIlan_30gun.Name = "rbTuristikIlan_30gun"
        Me.rbTuristikIlan_30gun.Size = New System.Drawing.Size(145, 23)
        Me.rbTuristikIlan_30gun.TabIndex = 5
        Me.rbTuristikIlan_30gun.TabStop = True
        Me.rbTuristikIlan_30gun.Text = "Son 30 gün  içinde"
        Me.rbTuristikIlan_30gun.UseVisualStyleBackColor = True
        '
        'rbTuristikIlan_15gun
        '
        Me.rbTuristikIlan_15gun.AutoSize = True
        Me.rbTuristikIlan_15gun.Location = New System.Drawing.Point(25, 105)
        Me.rbTuristikIlan_15gun.Name = "rbTuristikIlan_15gun"
        Me.rbTuristikIlan_15gun.Size = New System.Drawing.Size(141, 23)
        Me.rbTuristikIlan_15gun.TabIndex = 4
        Me.rbTuristikIlan_15gun.TabStop = True
        Me.rbTuristikIlan_15gun.Text = "Son 15 gün içinde"
        Me.rbTuristikIlan_15gun.UseVisualStyleBackColor = True
        '
        'rbTuristikIlan_7gun
        '
        Me.rbTuristikIlan_7gun.AutoSize = True
        Me.rbTuristikIlan_7gun.Location = New System.Drawing.Point(25, 75)
        Me.rbTuristikIlan_7gun.Name = "rbTuristikIlan_7gun"
        Me.rbTuristikIlan_7gun.Size = New System.Drawing.Size(133, 23)
        Me.rbTuristikIlan_7gun.TabIndex = 3
        Me.rbTuristikIlan_7gun.TabStop = True
        Me.rbTuristikIlan_7gun.Text = "Son 7 gün içinde"
        Me.rbTuristikIlan_7gun.UseVisualStyleBackColor = True
        '
        'rbTuristikIlan_3gun
        '
        Me.rbTuristikIlan_3gun.AutoSize = True
        Me.rbTuristikIlan_3gun.Location = New System.Drawing.Point(25, 45)
        Me.rbTuristikIlan_3gun.Name = "rbTuristikIlan_3gun"
        Me.rbTuristikIlan_3gun.Size = New System.Drawing.Size(133, 23)
        Me.rbTuristikIlan_3gun.TabIndex = 2
        Me.rbTuristikIlan_3gun.TabStop = True
        Me.rbTuristikIlan_3gun.Text = "Son 3 gün içinde"
        Me.rbTuristikIlan_3gun.UseVisualStyleBackColor = True
        '
        'rbTuristikIlan_24saat
        '
        Me.rbTuristikIlan_24saat.AutoSize = True
        Me.rbTuristikIlan_24saat.Location = New System.Drawing.Point(25, 15)
        Me.rbTuristikIlan_24saat.Name = "rbTuristikIlan_24saat"
        Me.rbTuristikIlan_24saat.Size = New System.Drawing.Size(145, 23)
        Me.rbTuristikIlan_24saat.TabIndex = 1
        Me.rbTuristikIlan_24saat.TabStop = True
        Me.rbTuristikIlan_24saat.Text = "Son 24 saat içinde"
        Me.rbTuristikIlan_24saat.UseVisualStyleBackColor = True
        '
        'dtgridAramaSonucu
        '
        Me.dtgridAramaSonucu.AllowUserToAddRows = False
        Me.dtgridAramaSonucu.AllowUserToDeleteRows = False
        Me.dtgridAramaSonucu.AllowUserToResizeColumns = False
        Me.dtgridAramaSonucu.AllowUserToResizeRows = False
        Me.dtgridAramaSonucu.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dtgridAramaSonucu.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgridAramaSonucu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgridAramaSonucu.ColumnHeadersHeight = 40
        Me.dtgridAramaSonucu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmresim1, Me.clmBaslik, Me.clmM2, Me.clmFiyat, Me.clmTarih, Me.clmIlce, Me.clmSehirAdi, Me.clmilanno, Me.clmaciklama, Me.clmilanveren, Me.clmilanturid, Me.clmresim2, Me.clmresim3, Me.clmresim4, Me.clmresim5, Me.clmresim6, Me.clmresim7, Me.clmresim8, Me.clmVideo, Me.clmAdres, Me.clmIslemTamamMi, Me.clmKonutAcikAlan, Me.clmBinaYasi, Me.clmKatSayisi, Me.clmKonutBanyoSayisi, Me.clmKonutEsyali, Me.clmKonutKullanimDurumu, Me.clmKonutSiteİçi, Me.clmKonutAidat, Me.clmKredi, Me.clmTakasli, Me.clmMahalle, Me.clmKonutOdaSayisi, Me.clmBulunduguKat, Me.clmIsitma, Me.clmSatisTuru, Me.clmKonutTip, Me.clmArsaParsel, Me.clmArsaPafta, Me.clmArsaAda, Me.clmArsaKatKarsiligi, Me.clmArsaImarDurumu, Me.clmGbari, Me.clmArsaKaks, Me.clmArsaTapuDurumu, Me.clmArsaMetrekareFiyat, Me.clmBirKattakiDaireSayisi, Me.clmTTOtelYıldız, Me.clmTTApartSayisi, Me.clmTTodaSayisi, Me.clmTTYatakSayisi, Me.clmTTAcikAlan, Me.clmTTKapaliAlan, Me.clmTTZeminEtudu, Me.clmTTYapiDurum, Me.clmTTToplamArazi, Me.clmTTPlaj_Buyukluk, Me.clmTTPlajKapasite, Me.clmTTTip, Me.clmBufeDurum, Me.clmBufem2ORacik, Me.clmBudeIsitma_ID, Me.clmBufeOda, Me.clmBudeDurum, Me.clmTavan, Me.clmDepozito, Me.clmMasa_Sayisi, Me.clmkisiKapasite, Me.clmAracSayisi, Me.clmCinsiyet, Me.clmYapiTipi, Me.clmIsyeriTipi, Me.clmSpor, Me.clmSatisTurID, Me.clmIsyeri_Tip, Me.clmAsansor, Me.clmOtoparkTur, Me.clmGiris, Me.clmTapuD, Me.clmBinaAdet, Me.clmBinaTipID})
        Me.dtgridAramaSonucu.GridColor = System.Drawing.Color.White
        Me.dtgridAramaSonucu.Location = New System.Drawing.Point(310, 152)
        Me.dtgridAramaSonucu.MultiSelect = False
        Me.dtgridAramaSonucu.Name = "dtgridAramaSonucu"
        Me.dtgridAramaSonucu.ReadOnly = True
        Me.dtgridAramaSonucu.RowHeadersVisible = False
        Me.dtgridAramaSonucu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgridAramaSonucu.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgridAramaSonucu.RowTemplate.Height = 80
        Me.dtgridAramaSonucu.Size = New System.Drawing.Size(1040, 385)
        Me.dtgridAramaSonucu.TabIndex = 29
        '
        'clmresim1
        '
        Me.clmresim1.DataPropertyName = "ilan_Resim1"
        Me.clmresim1.HeaderText = "Resim"
        Me.clmresim1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.clmresim1.Name = "clmresim1"
        Me.clmresim1.ReadOnly = True
        Me.clmresim1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmresim1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmresim1.Width = 120
        '
        'clmBaslik
        '
        Me.clmBaslik.DataPropertyName = "ilan_Baslik"
        Me.clmBaslik.HeaderText = "Başlık"
        Me.clmBaslik.Name = "clmBaslik"
        Me.clmBaslik.ReadOnly = True
        Me.clmBaslik.Width = 300
        '
        'clmM2
        '
        Me.clmM2.DataPropertyName = "Buyukluk"
        Me.clmM2.HeaderText = "Büyüklük (m2)"
        Me.clmM2.Name = "clmM2"
        Me.clmM2.ReadOnly = True
        Me.clmM2.Width = 120
        '
        'clmFiyat
        '
        Me.clmFiyat.DataPropertyName = "Fiyat"
        Me.clmFiyat.HeaderText = "Fiyat"
        Me.clmFiyat.Name = "clmFiyat"
        Me.clmFiyat.ReadOnly = True
        Me.clmFiyat.Width = 120
        '
        'clmTarih
        '
        Me.clmTarih.DataPropertyName = "ilan_Tarihi"
        Me.clmTarih.HeaderText = "İlan Tarihi"
        Me.clmTarih.Name = "clmTarih"
        Me.clmTarih.ReadOnly = True
        Me.clmTarih.Width = 120
        '
        'clmIlce
        '
        Me.clmIlce.DataPropertyName = "ilceAdi"
        Me.clmIlce.HeaderText = "İlçe"
        Me.clmIlce.Name = "clmIlce"
        Me.clmIlce.ReadOnly = True
        Me.clmIlce.Width = 120
        '
        'clmSehirAdi
        '
        Me.clmSehirAdi.DataPropertyName = "SehirAdi"
        Me.clmSehirAdi.HeaderText = "Şehir"
        Me.clmSehirAdi.Name = "clmSehirAdi"
        Me.clmSehirAdi.ReadOnly = True
        Me.clmSehirAdi.Width = 120
        '
        'clmilanno
        '
        Me.clmilanno.DataPropertyName = "ilan_No"
        Me.clmilanno.HeaderText = "Iln No"
        Me.clmilanno.Name = "clmilanno"
        Me.clmilanno.ReadOnly = True
        Me.clmilanno.Visible = False
        '
        'clmaciklama
        '
        Me.clmaciklama.DataPropertyName = "ilan_Aciklama"
        Me.clmaciklama.HeaderText = "Açıklama"
        Me.clmaciklama.Name = "clmaciklama"
        Me.clmaciklama.ReadOnly = True
        Me.clmaciklama.Visible = False
        '
        'clmilanveren
        '
        Me.clmilanveren.DataPropertyName = "ilan_Veren"
        Me.clmilanveren.HeaderText = "İlan Veren"
        Me.clmilanveren.Name = "clmilanveren"
        Me.clmilanveren.ReadOnly = True
        Me.clmilanveren.Visible = False
        '
        'clmilanturid
        '
        Me.clmilanturid.DataPropertyName = "ilan_Tur_ID"
        Me.clmilanturid.HeaderText = "İlan Tur ID"
        Me.clmilanturid.Name = "clmilanturid"
        Me.clmilanturid.ReadOnly = True
        Me.clmilanturid.Visible = False
        '
        'clmresim2
        '
        Me.clmresim2.DataPropertyName = "ilan_Resim2"
        Me.clmresim2.HeaderText = "Resim"
        Me.clmresim2.Name = "clmresim2"
        Me.clmresim2.ReadOnly = True
        Me.clmresim2.Visible = False
        '
        'clmresim3
        '
        Me.clmresim3.DataPropertyName = "ilan_Resim3"
        Me.clmresim3.HeaderText = "Resim"
        Me.clmresim3.Name = "clmresim3"
        Me.clmresim3.ReadOnly = True
        Me.clmresim3.Visible = False
        '
        'clmresim4
        '
        Me.clmresim4.DataPropertyName = "ilan_Resim4"
        Me.clmresim4.HeaderText = "Resim"
        Me.clmresim4.Name = "clmresim4"
        Me.clmresim4.ReadOnly = True
        Me.clmresim4.Visible = False
        '
        'clmresim5
        '
        Me.clmresim5.DataPropertyName = "ilan_Resim5"
        Me.clmresim5.HeaderText = "Resim"
        Me.clmresim5.Name = "clmresim5"
        Me.clmresim5.ReadOnly = True
        Me.clmresim5.Visible = False
        '
        'clmresim6
        '
        Me.clmresim6.DataPropertyName = "ilan_Resim6"
        Me.clmresim6.HeaderText = "Resim"
        Me.clmresim6.Name = "clmresim6"
        Me.clmresim6.ReadOnly = True
        Me.clmresim6.Visible = False
        '
        'clmresim7
        '
        Me.clmresim7.DataPropertyName = "ilan_Resim7"
        Me.clmresim7.HeaderText = "Resim"
        Me.clmresim7.Name = "clmresim7"
        Me.clmresim7.ReadOnly = True
        Me.clmresim7.Visible = False
        '
        'clmresim8
        '
        Me.clmresim8.DataPropertyName = "ilan_Resim8"
        Me.clmresim8.HeaderText = "Resim"
        Me.clmresim8.Name = "clmresim8"
        Me.clmresim8.ReadOnly = True
        Me.clmresim8.Visible = False
        '
        'clmVideo
        '
        Me.clmVideo.DataPropertyName = "ilan_Video"
        Me.clmVideo.HeaderText = "Video"
        Me.clmVideo.Name = "clmVideo"
        Me.clmVideo.ReadOnly = True
        Me.clmVideo.Visible = False
        '
        'clmAdres
        '
        Me.clmAdres.DataPropertyName = "Adres"
        Me.clmAdres.HeaderText = "Adres"
        Me.clmAdres.Name = "clmAdres"
        Me.clmAdres.ReadOnly = True
        Me.clmAdres.Visible = False
        '
        'clmIslemTamamMi
        '
        Me.clmIslemTamamMi.DataPropertyName = "islem_Tamam_mi"
        Me.clmIslemTamamMi.HeaderText = "Islem Tamam"
        Me.clmIslemTamamMi.Name = "clmIslemTamamMi"
        Me.clmIslemTamamMi.ReadOnly = True
        Me.clmIslemTamamMi.Visible = False
        '
        'clmKonutAcikAlan
        '
        Me.clmKonutAcikAlan.DataPropertyName = "Acik_Alan_Buyuklugu"
        Me.clmKonutAcikAlan.HeaderText = "Açık Alan (m2)"
        Me.clmKonutAcikAlan.Name = "clmKonutAcikAlan"
        Me.clmKonutAcikAlan.ReadOnly = True
        Me.clmKonutAcikAlan.Visible = False
        '
        'clmBinaYasi
        '
        Me.clmBinaYasi.DataPropertyName = "Bina_Yasi"
        Me.clmBinaYasi.HeaderText = "Bina Yaşı"
        Me.clmBinaYasi.Name = "clmBinaYasi"
        Me.clmBinaYasi.ReadOnly = True
        Me.clmBinaYasi.Visible = False
        '
        'clmKatSayisi
        '
        Me.clmKatSayisi.DataPropertyName = "Kat_Sayisi"
        Me.clmKatSayisi.HeaderText = "Kat Sayısı"
        Me.clmKatSayisi.Name = "clmKatSayisi"
        Me.clmKatSayisi.ReadOnly = True
        Me.clmKatSayisi.Visible = False
        '
        'clmKonutBanyoSayisi
        '
        Me.clmKonutBanyoSayisi.DataPropertyName = "Banyo_Sayisi"
        Me.clmKonutBanyoSayisi.HeaderText = "BanyoSayısı"
        Me.clmKonutBanyoSayisi.Name = "clmKonutBanyoSayisi"
        Me.clmKonutBanyoSayisi.ReadOnly = True
        Me.clmKonutBanyoSayisi.Visible = False
        '
        'clmKonutEsyali
        '
        Me.clmKonutEsyali.DataPropertyName = "Esyali"
        Me.clmKonutEsyali.HeaderText = "Eşyalı"
        Me.clmKonutEsyali.Name = "clmKonutEsyali"
        Me.clmKonutEsyali.ReadOnly = True
        Me.clmKonutEsyali.Visible = False
        '
        'clmKonutKullanimDurumu
        '
        Me.clmKonutKullanimDurumu.DataPropertyName = "Kullanim_Durumu"
        Me.clmKonutKullanimDurumu.HeaderText = "Kullanım Durumu"
        Me.clmKonutKullanimDurumu.Name = "clmKonutKullanimDurumu"
        Me.clmKonutKullanimDurumu.ReadOnly = True
        Me.clmKonutKullanimDurumu.Visible = False
        '
        'clmKonutSiteİçi
        '
        Me.clmKonutSiteİçi.DataPropertyName = "Site_Icerisinde"
        Me.clmKonutSiteİçi.HeaderText = "Site İçerisinde"
        Me.clmKonutSiteİçi.Name = "clmKonutSiteİçi"
        Me.clmKonutSiteİçi.ReadOnly = True
        Me.clmKonutSiteİçi.Visible = False
        '
        'clmKonutAidat
        '
        Me.clmKonutAidat.DataPropertyName = "Aidat"
        Me.clmKonutAidat.HeaderText = "Aidat"
        Me.clmKonutAidat.Name = "clmKonutAidat"
        Me.clmKonutAidat.ReadOnly = True
        Me.clmKonutAidat.Visible = False
        '
        'clmKredi
        '
        Me.clmKredi.DataPropertyName = "Krediye_Uygun"
        Me.clmKredi.HeaderText = "Krediye Uygunluk"
        Me.clmKredi.Name = "clmKredi"
        Me.clmKredi.ReadOnly = True
        Me.clmKredi.Visible = False
        '
        'clmTakasli
        '
        Me.clmTakasli.DataPropertyName = "Takasli"
        Me.clmTakasli.HeaderText = "Takas Durumu"
        Me.clmTakasli.Name = "clmTakasli"
        Me.clmTakasli.ReadOnly = True
        Me.clmTakasli.Visible = False
        '
        'clmMahalle
        '
        Me.clmMahalle.DataPropertyName = "MahalleAdi"
        Me.clmMahalle.HeaderText = "Mahalle "
        Me.clmMahalle.Name = "clmMahalle"
        Me.clmMahalle.ReadOnly = True
        Me.clmMahalle.Visible = False
        '
        'clmKonutOdaSayisi
        '
        Me.clmKonutOdaSayisi.DataPropertyName = "Oda_Sayisi"
        Me.clmKonutOdaSayisi.HeaderText = "Oda Sayisi"
        Me.clmKonutOdaSayisi.Name = "clmKonutOdaSayisi"
        Me.clmKonutOdaSayisi.ReadOnly = True
        Me.clmKonutOdaSayisi.Visible = False
        '
        'clmBulunduguKat
        '
        Me.clmBulunduguKat.DataPropertyName = "Bulundugu_Kat"
        Me.clmBulunduguKat.HeaderText = "Bulunduğu Kat"
        Me.clmBulunduguKat.Name = "clmBulunduguKat"
        Me.clmBulunduguKat.ReadOnly = True
        Me.clmBulunduguKat.Visible = False
        '
        'clmIsitma
        '
        Me.clmIsitma.DataPropertyName = "Isitma"
        Me.clmIsitma.HeaderText = "Isıtma"
        Me.clmIsitma.Name = "clmIsitma"
        Me.clmIsitma.ReadOnly = True
        Me.clmIsitma.Visible = False
        '
        'clmSatisTuru
        '
        Me.clmSatisTuru.DataPropertyName = "Satis_Turu"
        Me.clmSatisTuru.HeaderText = "Satış Türü"
        Me.clmSatisTuru.Name = "clmSatisTuru"
        Me.clmSatisTuru.ReadOnly = True
        Me.clmSatisTuru.Visible = False
        '
        'clmKonutTip
        '
        Me.clmKonutTip.DataPropertyName = "Konut_Tip"
        Me.clmKonutTip.HeaderText = "Konut Tipi"
        Me.clmKonutTip.Name = "clmKonutTip"
        Me.clmKonutTip.ReadOnly = True
        Me.clmKonutTip.Visible = False
        '
        'clmArsaParsel
        '
        Me.clmArsaParsel.DataPropertyName = "Parsel_No"
        Me.clmArsaParsel.HeaderText = "Parsel No"
        Me.clmArsaParsel.Name = "clmArsaParsel"
        Me.clmArsaParsel.ReadOnly = True
        Me.clmArsaParsel.Visible = False
        '
        'clmArsaPafta
        '
        Me.clmArsaPafta.DataPropertyName = "Pafta_No"
        Me.clmArsaPafta.HeaderText = "Pafta No"
        Me.clmArsaPafta.Name = "clmArsaPafta"
        Me.clmArsaPafta.ReadOnly = True
        Me.clmArsaPafta.Visible = False
        '
        'clmArsaAda
        '
        Me.clmArsaAda.DataPropertyName = "Ada_No"
        Me.clmArsaAda.HeaderText = "Ada No"
        Me.clmArsaAda.Name = "clmArsaAda"
        Me.clmArsaAda.ReadOnly = True
        Me.clmArsaAda.Visible = False
        '
        'clmArsaKatKarsiligi
        '
        Me.clmArsaKatKarsiligi.DataPropertyName = "Kat_Karsiligi"
        Me.clmArsaKatKarsiligi.HeaderText = "Kat Karşılığı"
        Me.clmArsaKatKarsiligi.Name = "clmArsaKatKarsiligi"
        Me.clmArsaKatKarsiligi.ReadOnly = True
        Me.clmArsaKatKarsiligi.Visible = False
        '
        'clmArsaImarDurumu
        '
        Me.clmArsaImarDurumu.DataPropertyName = "imar_Durumu"
        Me.clmArsaImarDurumu.HeaderText = "İmar Durumu"
        Me.clmArsaImarDurumu.Name = "clmArsaImarDurumu"
        Me.clmArsaImarDurumu.ReadOnly = True
        Me.clmArsaImarDurumu.Visible = False
        '
        'clmGbari
        '
        Me.clmGbari.DataPropertyName = "Gabari"
        Me.clmGbari.HeaderText = "Gabari"
        Me.clmGbari.Name = "clmGbari"
        Me.clmGbari.ReadOnly = True
        Me.clmGbari.Visible = False
        '
        'clmArsaKaks
        '
        Me.clmArsaKaks.DataPropertyName = "Kaks"
        Me.clmArsaKaks.HeaderText = "Kaks"
        Me.clmArsaKaks.Name = "clmArsaKaks"
        Me.clmArsaKaks.ReadOnly = True
        Me.clmArsaKaks.Visible = False
        '
        'clmArsaTapuDurumu
        '
        Me.clmArsaTapuDurumu.DataPropertyName = "Tapu_Durumu"
        Me.clmArsaTapuDurumu.HeaderText = "Tapu Durumu"
        Me.clmArsaTapuDurumu.Name = "clmArsaTapuDurumu"
        Me.clmArsaTapuDurumu.ReadOnly = True
        Me.clmArsaTapuDurumu.Visible = False
        '
        'clmArsaMetrekareFiyat
        '
        Me.clmArsaMetrekareFiyat.DataPropertyName = "metrekareFiyati"
        Me.clmArsaMetrekareFiyat.HeaderText = "MetreKare Fiyatı"
        Me.clmArsaMetrekareFiyat.Name = "clmArsaMetrekareFiyat"
        Me.clmArsaMetrekareFiyat.ReadOnly = True
        Me.clmArsaMetrekareFiyat.Visible = False
        '
        'clmBirKattakiDaireSayisi
        '
        Me.clmBirKattakiDaireSayisi.DataPropertyName = "Bir_Kattaki_Daire_Sayisi"
        Me.clmBirKattakiDaireSayisi.HeaderText = "Kat Başı Daire Sayısı"
        Me.clmBirKattakiDaireSayisi.Name = "clmBirKattakiDaireSayisi"
        Me.clmBirKattakiDaireSayisi.ReadOnly = True
        Me.clmBirKattakiDaireSayisi.Visible = False
        '
        'clmTTOtelYıldız
        '
        Me.clmTTOtelYıldız.DataPropertyName = "Otel_Yildiz_Sayisi"
        Me.clmTTOtelYıldız.HeaderText = "Otel Yıldızı"
        Me.clmTTOtelYıldız.Name = "clmTTOtelYıldız"
        Me.clmTTOtelYıldız.ReadOnly = True
        Me.clmTTOtelYıldız.Visible = False
        '
        'clmTTApartSayisi
        '
        Me.clmTTApartSayisi.DataPropertyName = "Apart_Otel_Apart_Sayisi"
        Me.clmTTApartSayisi.HeaderText = "Apart Sayisi"
        Me.clmTTApartSayisi.Name = "clmTTApartSayisi"
        Me.clmTTApartSayisi.ReadOnly = True
        Me.clmTTApartSayisi.Visible = False
        '
        'clmTTodaSayisi
        '
        Me.clmTTodaSayisi.DataPropertyName = "oda_Sayisi"
        Me.clmTTodaSayisi.HeaderText = "Oda Sayisi"
        Me.clmTTodaSayisi.Name = "clmTTodaSayisi"
        Me.clmTTodaSayisi.ReadOnly = True
        Me.clmTTodaSayisi.Visible = False
        '
        'clmTTYatakSayisi
        '
        Me.clmTTYatakSayisi.DataPropertyName = "yatak_Sayisi"
        Me.clmTTYatakSayisi.HeaderText = "Yatak Sayisi"
        Me.clmTTYatakSayisi.Name = "clmTTYatakSayisi"
        Me.clmTTYatakSayisi.ReadOnly = True
        Me.clmTTYatakSayisi.Visible = False
        '
        'clmTTAcikAlan
        '
        Me.clmTTAcikAlan.DataPropertyName = "Acik_Alan"
        Me.clmTTAcikAlan.HeaderText = "Açık Alan"
        Me.clmTTAcikAlan.Name = "clmTTAcikAlan"
        Me.clmTTAcikAlan.ReadOnly = True
        Me.clmTTAcikAlan.Visible = False
        '
        'clmTTKapaliAlan
        '
        Me.clmTTKapaliAlan.DataPropertyName = "Kapali_Alan"
        Me.clmTTKapaliAlan.HeaderText = "KapalıAlan"
        Me.clmTTKapaliAlan.Name = "clmTTKapaliAlan"
        Me.clmTTKapaliAlan.ReadOnly = True
        Me.clmTTKapaliAlan.Visible = False
        '
        'clmTTZeminEtudu
        '
        Me.clmTTZeminEtudu.DataPropertyName = "Zemin_Etudu"
        Me.clmTTZeminEtudu.HeaderText = "Zemin Etüdü"
        Me.clmTTZeminEtudu.Name = "clmTTZeminEtudu"
        Me.clmTTZeminEtudu.ReadOnly = True
        Me.clmTTZeminEtudu.Visible = False
        '
        'clmTTYapiDurum
        '
        Me.clmTTYapiDurum.DataPropertyName = "Yapi_Durumu"
        Me.clmTTYapiDurum.HeaderText = "Yapi Durumu"
        Me.clmTTYapiDurum.Name = "clmTTYapiDurum"
        Me.clmTTYapiDurum.ReadOnly = True
        Me.clmTTYapiDurum.Visible = False
        '
        'clmTTToplamArazi
        '
        Me.clmTTToplamArazi.DataPropertyName = "Mocamp_Toplam_Arazi"
        Me.clmTTToplamArazi.HeaderText = "Toplam Arazi(Mocamp)"
        Me.clmTTToplamArazi.Name = "clmTTToplamArazi"
        Me.clmTTToplamArazi.ReadOnly = True
        Me.clmTTToplamArazi.Visible = False
        '
        'clmTTPlaj_Buyukluk
        '
        Me.clmTTPlaj_Buyukluk.DataPropertyName = "Plaj_Buyukluk"
        Me.clmTTPlaj_Buyukluk.HeaderText = "plaj Büyüklük"
        Me.clmTTPlaj_Buyukluk.Name = "clmTTPlaj_Buyukluk"
        Me.clmTTPlaj_Buyukluk.ReadOnly = True
        Me.clmTTPlaj_Buyukluk.Visible = False
        '
        'clmTTPlajKapasite
        '
        Me.clmTTPlajKapasite.DataPropertyName = "Plaj_Kapasite"
        Me.clmTTPlajKapasite.HeaderText = "Plaj Kapasite"
        Me.clmTTPlajKapasite.Name = "clmTTPlajKapasite"
        Me.clmTTPlajKapasite.ReadOnly = True
        Me.clmTTPlajKapasite.Visible = False
        '
        'clmTTTip
        '
        Me.clmTTTip.DataPropertyName = "TT_Tip"
        Me.clmTTTip.HeaderText = "Turistik Tesis Tip"
        Me.clmTTTip.Name = "clmTTTip"
        Me.clmTTTip.ReadOnly = True
        Me.clmTTTip.Visible = False
        '
        'clmBufeDurum
        '
        Me.clmBufeDurum.DataPropertyName = "Durumu"
        Me.clmBufeDurum.HeaderText = "BufeDurum"
        Me.clmBufeDurum.Name = "clmBufeDurum"
        Me.clmBufeDurum.ReadOnly = True
        Me.clmBufeDurum.Visible = False
        '
        'clmBufem2ORacik
        '
        Me.clmBufem2ORacik.DataPropertyName = "m2ORacik"
        Me.clmBufem2ORacik.HeaderText = "m2ORacik"
        Me.clmBufem2ORacik.Name = "clmBufem2ORacik"
        Me.clmBufem2ORacik.ReadOnly = True
        Me.clmBufem2ORacik.Visible = False
        '
        'clmBudeIsitma_ID
        '
        Me.clmBudeIsitma_ID.DataPropertyName = "Isitma_ID"
        Me.clmBudeIsitma_ID.HeaderText = "Isıtma ID"
        Me.clmBudeIsitma_ID.Name = "clmBudeIsitma_ID"
        Me.clmBudeIsitma_ID.ReadOnly = True
        Me.clmBudeIsitma_ID.Visible = False
        '
        'clmBufeOda
        '
        Me.clmBufeOda.DataPropertyName = "Oda_Bolum_Sayisi"
        Me.clmBufeOda.HeaderText = "Oda Bolum Sayısı"
        Me.clmBufeOda.Name = "clmBufeOda"
        Me.clmBufeOda.ReadOnly = True
        Me.clmBufeOda.Visible = False
        '
        'clmBudeDurum
        '
        Me.clmBudeDurum.DataPropertyName = "Kullanim_Durumu"
        Me.clmBudeDurum.HeaderText = "Durum"
        Me.clmBudeDurum.Name = "clmBudeDurum"
        Me.clmBudeDurum.ReadOnly = True
        Me.clmBudeDurum.Visible = False
        '
        'clmTavan
        '
        Me.clmTavan.DataPropertyName = "Tavan_Yuksekligi"
        Me.clmTavan.HeaderText = "Tavan Yukseklik"
        Me.clmTavan.Name = "clmTavan"
        Me.clmTavan.ReadOnly = True
        Me.clmTavan.Visible = False
        '
        'clmDepozito
        '
        Me.clmDepozito.DataPropertyName = "Depozito"
        Me.clmDepozito.HeaderText = "Depozito"
        Me.clmDepozito.Name = "clmDepozito"
        Me.clmDepozito.ReadOnly = True
        Me.clmDepozito.Visible = False
        '
        'clmMasa_Sayisi
        '
        Me.clmMasa_Sayisi.DataPropertyName = "Masa_Sayisi"
        Me.clmMasa_Sayisi.HeaderText = "Masa Sayısı"
        Me.clmMasa_Sayisi.Name = "clmMasa_Sayisi"
        Me.clmMasa_Sayisi.ReadOnly = True
        Me.clmMasa_Sayisi.Visible = False
        '
        'clmkisiKapasite
        '
        Me.clmkisiKapasite.DataPropertyName = "Kisi_kapasitesi"
        Me.clmkisiKapasite.HeaderText = "Kişi Kapasite"
        Me.clmkisiKapasite.Name = "clmkisiKapasite"
        Me.clmkisiKapasite.ReadOnly = True
        Me.clmkisiKapasite.Visible = False
        '
        'clmAracSayisi
        '
        Me.clmAracSayisi.DataPropertyName = "Arac_Sayisi"
        Me.clmAracSayisi.HeaderText = "Araç Sayisi"
        Me.clmAracSayisi.Name = "clmAracSayisi"
        Me.clmAracSayisi.ReadOnly = True
        Me.clmAracSayisi.Visible = False
        '
        'clmCinsiyet
        '
        Me.clmCinsiyet.DataPropertyName = "Cinsiyet"
        Me.clmCinsiyet.HeaderText = "Cinsiyet"
        Me.clmCinsiyet.Name = "clmCinsiyet"
        Me.clmCinsiyet.ReadOnly = True
        Me.clmCinsiyet.Visible = False
        '
        'clmYapiTipi
        '
        Me.clmYapiTipi.DataPropertyName = "Yapi_Tipi"
        Me.clmYapiTipi.HeaderText = "Yapı Tipi"
        Me.clmYapiTipi.Name = "clmYapiTipi"
        Me.clmYapiTipi.ReadOnly = True
        Me.clmYapiTipi.Visible = False
        '
        'clmIsyeriTipi
        '
        Me.clmIsyeriTipi.DataPropertyName = "Isyeri_Tipi"
        Me.clmIsyeriTipi.HeaderText = "İşyeri Tipi"
        Me.clmIsyeriTipi.Name = "clmIsyeriTipi"
        Me.clmIsyeriTipi.ReadOnly = True
        Me.clmIsyeriTipi.Visible = False
        '
        'clmSpor
        '
        Me.clmSpor.DataPropertyName = "SporTesis_Tipi"
        Me.clmSpor.HeaderText = "Spor Tesis Tip"
        Me.clmSpor.Name = "clmSpor"
        Me.clmSpor.ReadOnly = True
        Me.clmSpor.Visible = False
        '
        'clmSatisTurID
        '
        Me.clmSatisTurID.DataPropertyName = "Satis_Turu_ID"
        Me.clmSatisTurID.HeaderText = "Satış Tur ID"
        Me.clmSatisTurID.Name = "clmSatisTurID"
        Me.clmSatisTurID.ReadOnly = True
        Me.clmSatisTurID.Visible = False
        '
        'clmIsyeri_Tip
        '
        Me.clmIsyeri_Tip.DataPropertyName = "Isyeri_Tipi_ID"
        Me.clmIsyeri_Tip.HeaderText = "Isyeri Tip ID"
        Me.clmIsyeri_Tip.Name = "clmIsyeri_Tip"
        Me.clmIsyeri_Tip.ReadOnly = True
        Me.clmIsyeri_Tip.Visible = False
        '
        'clmAsansor
        '
        Me.clmAsansor.DataPropertyName = "Asansor_Sayisi"
        Me.clmAsansor.HeaderText = "Asansör Sayısı"
        Me.clmAsansor.Name = "clmAsansor"
        Me.clmAsansor.ReadOnly = True
        Me.clmAsansor.Visible = False
        '
        'clmOtoparkTur
        '
        Me.clmOtoparkTur.DataPropertyName = "Otopark_Turu"
        Me.clmOtoparkTur.HeaderText = "Otopark Türü"
        Me.clmOtoparkTur.Name = "clmOtoparkTur"
        Me.clmOtoparkTur.ReadOnly = True
        Me.clmOtoparkTur.Visible = False
        '
        'clmGiris
        '
        Me.clmGiris.DataPropertyName = "Giris_yukseklik"
        Me.clmGiris.HeaderText = "Giriş Yukseklik"
        Me.clmGiris.Name = "clmGiris"
        Me.clmGiris.ReadOnly = True
        Me.clmGiris.Visible = False
        '
        'clmTapuD
        '
        Me.clmTapuD.DataPropertyName = "Tapu_Durumu_ID"
        Me.clmTapuD.HeaderText = "Tapu Durumu (D)"
        Me.clmTapuD.Name = "clmTapuD"
        Me.clmTapuD.ReadOnly = True
        Me.clmTapuD.Visible = False
        '
        'clmBinaAdet
        '
        Me.clmBinaAdet.DataPropertyName = "Bina_Adedi"
        Me.clmBinaAdet.HeaderText = "Bina Adedi"
        Me.clmBinaAdet.Name = "clmBinaAdet"
        Me.clmBinaAdet.ReadOnly = True
        Me.clmBinaAdet.Visible = False
        '
        'clmBinaTipID
        '
        Me.clmBinaTipID.DataPropertyName = "Bina_Tipi_ID"
        Me.clmBinaTipID.HeaderText = "Bina Tipi"
        Me.clmBinaTipID.Name = "clmBinaTipID"
        Me.clmBinaTipID.ReadOnly = True
        Me.clmBinaTipID.Visible = False
        '
        'frmArama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1350, 733)
        Me.Controls.Add(Me.dtgridAramaSonucu)
        Me.Controls.Add(Me.pnlFiltre)
        Me.Controls.Add(Me.btnAra)
        Me.Controls.Add(Me.btnEkBilgi)
        Me.Controls.Add(Me.btnEmlakTipi)
        Me.Controls.Add(Me.btnAdres)
        Me.Controls.Add(Me.btnFiyat)
        Me.Controls.Add(Me.btnSatisTuru)
        Me.Controls.Add(Me.btnLogo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnTemizle)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmArama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emlak Otomasyonu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EmlakOtomasyonuDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmlakOtomasyonuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKonutFiltre.ResumeLayout(False)
        Me.pnlKonut_fotoVideo.ResumeLayout(False)
        Me.pnlKonut_fotoVideo.PerformLayout()
        Me.pnlKonut_kredi.ResumeLayout(False)
        Me.pnlKonut_kredi.PerformLayout()
        Me.pnlKonut_takas.ResumeLayout(False)
        Me.pnlKonut_takas.PerformLayout()
        Me.pnlKonut_Kullanimda.ResumeLayout(False)
        Me.pnlKonut_Kullanimda.PerformLayout()
        Me.pnlKonut_ilanTarihi.ResumeLayout(False)
        Me.pnlKonut_ilanTarihi.PerformLayout()
        Me.pnlKonut_siteIcerisinde.ResumeLayout(False)
        Me.pnlKonut_siteIcerisinde.PerformLayout()
        Me.pnlKonut_Esyali.ResumeLayout(False)
        Me.pnlKonut_Esyali.PerformLayout()
        Me.pnlKonut_Fiyat.ResumeLayout(False)
        Me.pnlKonut_Fiyat.PerformLayout()
        Me.pnlKonut_binaYas.ResumeLayout(False)
        Me.pnlKonut_binaYas.PerformLayout()
        Me.pnlKonut_bulunduguKat.ResumeLayout(False)
        Me.pnlKonut_katSayi.ResumeLayout(False)
        Me.pnlKonut_katSayi.PerformLayout()
        Me.pnlKonut_isitma.ResumeLayout(False)
        Me.pnlKonut_banyoSayi.ResumeLayout(False)
        Me.pnlKonut_banyoSayi.PerformLayout()
        Me.pnlKonut_odaSayi.ResumeLayout(False)
        Me.pnlKonut_buyukluk.ResumeLayout(False)
        Me.pnlKonut_buyukluk.PerformLayout()
        Me.pnlKonut_Adres.ResumeLayout(False)
        Me.pnlFiltre.ResumeLayout(False)
        Me.pnlFiltre.PerformLayout()
        Me.pnlBinaFiltre.ResumeLayout(False)
        Me.pnlBina_birKattakiDaire.ResumeLayout(False)
        Me.pnlBina_birKattakiDaire.PerformLayout()
        Me.pnlBina_kredi.ResumeLayout(False)
        Me.pnlBina_kredi.PerformLayout()
        Me.pnlBina_takas.ResumeLayout(False)
        Me.pnlBina_takas.PerformLayout()
        Me.pnlBina_ilanTarihi.ResumeLayout(False)
        Me.pnlBina_ilanTarihi.PerformLayout()
        Me.pnlBina_fotoVideo.ResumeLayout(False)
        Me.pnlBina_fotoVideo.PerformLayout()
        Me.pnlBina_fiyat.ResumeLayout(False)
        Me.pnlBina_fiyat.PerformLayout()
        Me.pnlBina_katSayi.ResumeLayout(False)
        Me.pnlBina_katSayi.PerformLayout()
        Me.pnlBina_adres.ResumeLayout(False)
        Me.pnlBina_buyukluk.ResumeLayout(False)
        Me.pnlBina_buyukluk.PerformLayout()
        Me.pnlBina_isitma.ResumeLayout(False)
        Me.pnlIsyeriFiltre.ResumeLayout(False)
        Me.pnlIsyeri_fotoVideo.ResumeLayout(False)
        Me.pnlIsyeri_fotoVideo.PerformLayout()
        Me.pnlIsyeri_ilanTarihi.ResumeLayout(False)
        Me.pnlIsyeri_ilanTarihi.PerformLayout()
        Me.pnlIsyeri_takas.ResumeLayout(False)
        Me.pnlIsyeri_takas.PerformLayout()
        Me.pnlIsyeri_adres.ResumeLayout(False)
        Me.pnlIsyeri_fiyat.ResumeLayout(False)
        Me.pnlIsyeri_fiyat.PerformLayout()
        Me.pnlArsaFiltre.ResumeLayout(False)
        Me.pnlArsa_kredi.ResumeLayout(False)
        Me.pnlArsa_kredi.PerformLayout()
        Me.pnlArsa_takas.ResumeLayout(False)
        Me.pnlArsa_takas.PerformLayout()
        Me.pnlArsa_fotoVideo.ResumeLayout(False)
        Me.pnlArsa_fotoVideo.PerformLayout()
        Me.pnlArsa_ilanTarih.ResumeLayout(False)
        Me.pnlArsa_ilanTarih.PerformLayout()
        Me.pnlArsa_Gabari.ResumeLayout(False)
        Me.pnlArsa_kaks.ResumeLayout(False)
        Me.pnlArsa_katKarsiligi.ResumeLayout(False)
        Me.pnlArsa_katKarsiligi.PerformLayout()
        Me.pnlArsa_tapuDurum.ResumeLayout(False)
        Me.pnlArsa_imarDurum.ResumeLayout(False)
        Me.pnlArsa_m2Fiyat.ResumeLayout(False)
        Me.pnlArsa_m2Fiyat.PerformLayout()
        Me.pnlArsa_buyukluk.ResumeLayout(False)
        Me.pnlArsa_buyukluk.PerformLayout()
        Me.pnlArsa_fiyat.ResumeLayout(False)
        Me.pnlArsa_fiyat.PerformLayout()
        Me.pnlArsa_adres.ResumeLayout(False)
        Me.pnlTuristikFiltre.ResumeLayout(False)
        Me.pnlTuristik_adres.ResumeLayout(False)
        Me.pnlTuristik_fiyat.ResumeLayout(False)
        Me.pnlTuristik_fiyat.PerformLayout()
        Me.pnlTuristik_fotoVideo.ResumeLayout(False)
        Me.pnlTuristik_fotoVideo.PerformLayout()
        Me.pnlTuristik_ilanTarihi.ResumeLayout(False)
        Me.pnlTuristik_ilanTarihi.PerformLayout()
        CType(Me.dtgridAramaSonucu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlKonutFiltre As Panel
    Friend WithEvents btnTemizle As Button
    Friend WithEvents btnLogo As Button
    Friend WithEvents btnSatisTuru As Button
    Friend WithEvents btnFiyat As Button
    Friend WithEvents btnAdres As Button
    Friend WithEvents btnEmlakTipi As Button
    Friend WithEvents btnEkBilgi As Button
    Friend WithEvents btnAra As Button
    Friend WithEvents btnKonut_Takas As Button
    Friend WithEvents btnKonut_FotoVideo As Button
    Friend WithEvents btnKonut_IlanTarihi As Button
    Friend WithEvents btnKonut_Kredi As Button
    Friend WithEvents btnKonut_SiteIcerisinde As Button
    Friend WithEvents btnKonut_OdaSayi As Button
    Friend WithEvents btnKonut_BinaYas As Button
    Friend WithEvents btnKonut_BulunduguKat As Button
    Friend WithEvents btnKonut_KatSayi As Button
    Friend WithEvents btnKonut_Isitma As Button
    Friend WithEvents btnKonut_BanyoSayi As Button
    Friend WithEvents btnKonut_Esyali As Button
    Friend WithEvents btnKonut_Kullanimda As Button
    Friend WithEvents btnKonut_Buyukluk As Button
    Friend WithEvents btnKonut_Fiyat As Button
    Friend WithEvents btnKonut_Adres As Button
    Friend WithEvents pnlFiltre As Panel
    Friend WithEvents pnlIsyeriFiltre As Panel
    Friend WithEvents btnIsyeri_Takas As Button
    Friend WithEvents btnIsyeri_FotoVideo As Button
    Friend WithEvents btnIsyeri_IlanTarihi As Button
    Friend WithEvents btnIsyeri_Fiyat As Button
    Friend WithEvents btnIsyeri_Adres As Button
    Friend WithEvents pnlTuristikFiltre As Panel
    Friend WithEvents btnTuristik_fotoVideo As Button
    Friend WithEvents btnTuristik_ilanTarihi As Button
    Friend WithEvents btnTuristik_fiyat As Button
    Friend WithEvents btnTuristik_adres As Button
    Friend WithEvents pnlArsaFiltre As Panel
    Friend WithEvents btnArsa_Takas As Button
    Friend WithEvents btnArsa_FotoVideo As Button
    Friend WithEvents btnArsa_IlanTarihi As Button
    Friend WithEvents btnArsa_Buyukluk As Button
    Friend WithEvents btnArsa_m2Fiyati As Button
    Friend WithEvents btnArsa_Kaks As Button
    Friend WithEvents btnArsa_Gabari As Button
    Friend WithEvents btnArsa_TapuDurumu As Button
    Friend WithEvents btnArsa_KatKarsilik As Button
    Friend WithEvents btnArsa_Kredi As Button
    Friend WithEvents btnArsa_ImarDurumu As Button
    Friend WithEvents btnArsa_Fiyat As Button
    Friend WithEvents btnArsa_Adres As Button
    Friend WithEvents pnlBinaFiltre As Panel
    Friend WithEvents btnBina_takas As Button
    Friend WithEvents btnBina_fotoVideo As Button
    Friend WithEvents btnBina_ilanTarihi As Button
    Friend WithEvents btnBina_birKattakiDaire As Button
    Friend WithEvents btnBina_isitma As Button
    Friend WithEvents btnBina_buyukluk As Button
    Friend WithEvents btnBina_kredi As Button
    Friend WithEvents btnBina_KatSayi As Button
    Friend WithEvents btnBina_Fiyat As Button
    Friend WithEvents btnBina_Adres As Button
    Friend WithEvents pnlKonut_Adres As Panel
    Friend WithEvents cbxMahalle As ComboBox
    Friend WithEvents cbxIlce As ComboBox
    Friend WithEvents cbxIl As ComboBox
    Friend WithEvents pnlKonut_Fiyat As Panel
    Friend WithEvents txtKonut_MaxTL As TextBox
    Friend WithEvents txtKonut_MinTL As TextBox
    Friend WithEvents pnlKonut_buyukluk As Panel
    Friend WithEvents txtKonut_MaxBuyukluk As TextBox
    Friend WithEvents txtKonut_MinBuyukluk As TextBox
    Friend WithEvents pnlKonut_Esyali As Panel
    Friend WithEvents rbKonutEsyali_Hayir As RadioButton
    Friend WithEvents rbKonutEsyali_Evet As RadioButton
    Friend WithEvents pnlKonut_Kullanimda As Panel
    Friend WithEvents rbKonutKullanimda_Hayir As RadioButton
    Friend WithEvents rbKonutKullanimda_Evet As RadioButton
    Friend WithEvents pnlKonut_siteIcerisinde As Panel
    Friend WithEvents rbKonutSite_Hayir As RadioButton
    Friend WithEvents rbKonutSite_Evet As RadioButton
    Friend WithEvents pnlKonut_kredi As Panel
    Friend WithEvents rbKonutKredi_hayir As RadioButton
    Friend WithEvents rbKonutKredi_evet As RadioButton
    Friend WithEvents pnlKonut_takas As Panel
    Friend WithEvents rbKonutTakas_Hayir As RadioButton
    Friend WithEvents rbKonutTakas_evet As RadioButton
    Friend WithEvents pnlKonut_isitma As Panel
    Friend WithEvents cbxKonut_isitma As ComboBox
    Friend WithEvents pnlKonut_bulunduguKat As Panel
    Friend WithEvents cbxKonut_bulunduguKat As ComboBox
    Friend WithEvents pnlKonut_katSayi As Panel
    Friend WithEvents pnlKonut_banyoSayi As Panel
    Friend WithEvents pnlKonut_binaYas As Panel
    Friend WithEvents txtKonut_MinBinaYas3 As TextBox
    Friend WithEvents pnlKonut_odaSayi As Panel
    Friend WithEvents cbxKonut_odaSayi As ComboBox
    Friend WithEvents pnlKonut_fotoVideo As Panel
    Friend WithEvents chKonutFoto_video As CheckBox
    Friend WithEvents chkKonutFoto_foto As CheckBox
    Friend WithEvents pnlKonut_ilanTarihi As Panel
    Friend WithEvents rbKonutIlan_30gun As RadioButton
    Friend WithEvents rbKonutIlan_15gun As RadioButton
    Friend WithEvents rbKonutIlan_7gun As RadioButton
    Friend WithEvents rbKonutIlan_3gun As RadioButton
    Friend WithEvents rbKonutIlan_24saat As RadioButton
    Friend WithEvents pnlArsa_adres As Panel
    Friend WithEvents cbxArsa_mahalle As ComboBox
    Friend WithEvents cbxArsa_ilce As ComboBox
    Friend WithEvents cbxArsa_il As ComboBox
    Friend WithEvents pnlArsa_fiyat As Panel
    Friend WithEvents txtArsaFiyat_MaxTL As TextBox
    Friend WithEvents txtArsaFiyat_MinTL As TextBox
    Friend WithEvents pnlArsa_buyukluk As Panel
    Friend WithEvents txtArsa_MaxBuyukluk As TextBox
    Friend WithEvents txtArsa_MinBuyukluk As TextBox
    Friend WithEvents pnlArsa_imarDurum As Panel
    Friend WithEvents cbxArsa_imarDurum As ComboBox
    Friend WithEvents pnlArsa_katKarsiligi As Panel
    Friend WithEvents rbArsaKat_hayir As RadioButton
    Friend WithEvents rbArsaKat_evet As RadioButton
    Friend WithEvents pnlArsa_m2Fiyat As Panel
    Friend WithEvents txtArsa_MaxM4Fiyat As TextBox
    Friend WithEvents txtArsa_MinM4Fiyat As TextBox
    Friend WithEvents pnlArsa_kaks As Panel
    Friend WithEvents cbxArsa_kaks As ComboBox
    Friend WithEvents pnlArsa_Gabari As Panel
    Friend WithEvents cbxArsa_gabari As ComboBox
    Friend WithEvents pnlArsa_tapuDurum As Panel
    Friend WithEvents cbxArsa_tapuDurum As ComboBox
    Friend WithEvents pnlArsa_fotoVideo As Panel
    Friend WithEvents chkArsa_video As CheckBox
    Friend WithEvents chkArsa_foto As CheckBox
    Friend WithEvents pnlArsa_kredi As Panel
    Friend WithEvents rbArsaKredi_hayir As RadioButton
    Friend WithEvents rbArsaKredi_evet As RadioButton
    Friend WithEvents pnlArsa_takas As Panel
    Friend WithEvents rbArsaTakas_hayir As RadioButton
    Friend WithEvents rbArsaTakas_evet As RadioButton
    Friend WithEvents pnlArsa_ilanTarih As Panel
    Friend WithEvents rbArsaIlan_30gun As RadioButton
    Friend WithEvents rbArsaIlan_15gun As RadioButton
    Friend WithEvents rbArsaIlan_7gun As RadioButton
    Friend WithEvents rbArsaIlan_3gun As RadioButton
    Friend WithEvents rbArsaIlan_24saat As RadioButton
    Friend WithEvents pnlIsyeri_fotoVideo As Panel
    Friend WithEvents chkIsyeri_video As CheckBox
    Friend WithEvents chkIsyeri_foto As CheckBox
    Friend WithEvents pnlIsyeri_adres As Panel
    Friend WithEvents cbxIsyeri_mahalle As ComboBox
    Friend WithEvents cbxIsyeri_ilce As ComboBox
    Friend WithEvents cbxIsyeri_il As ComboBox
    Friend WithEvents pnlIsyeri_fiyat As Panel
    Friend WithEvents txtIsyeri_MaxTL As TextBox
    Friend WithEvents txtIsyeri_MinTL As TextBox
    Friend WithEvents pnlIsyeri_takas As Panel
    Friend WithEvents rbIsyeriTakas_hayir As RadioButton
    Friend WithEvents rbIsyeriTakas_evet As RadioButton
    Friend WithEvents pnlIsyeri_ilanTarihi As Panel
    Friend WithEvents rbIsyeriIlan_30gun As RadioButton
    Friend WithEvents rbIsyeriIlan_15gun As RadioButton
    Friend WithEvents rbIsyeriIlan_7gun As RadioButton
    Friend WithEvents rbIsyeriIlan_3gun As RadioButton
    Friend WithEvents rbIsyeriIlan_24saat As RadioButton
    Friend WithEvents pnlBina_fotoVideo As Panel
    Friend WithEvents chkBina_video As CheckBox
    Friend WithEvents chkBina_foto As CheckBox
    Friend WithEvents pnlBina_adres As Panel
    Friend WithEvents cbxBina_mahalle As ComboBox
    Friend WithEvents cbxBina_ilce As ComboBox
    Friend WithEvents cbxBina_il As ComboBox
    Friend WithEvents pnlBina_fiyat As Panel
    Friend WithEvents txtBina_MaxTL As TextBox
    Friend WithEvents txtBina_MinTL As TextBox
    Friend WithEvents pnlBina_katSayi As Panel
    Friend WithEvents pnlBina_birKattakiDaire As Panel
    Friend WithEvents pnlBina_isitma As Panel
    Friend WithEvents cbxBina_isitma As ComboBox
    Friend WithEvents pnlBina_buyukluk As Panel
    Friend WithEvents txtBina_MaxBuyukluk As TextBox
    Friend WithEvents txtBina_MinBuyukluk As TextBox
    Friend WithEvents pnlBina_kredi As Panel
    Friend WithEvents rbBinaKredi_hayir As RadioButton
    Friend WithEvents rbBinaKredi_evet As RadioButton
    Friend WithEvents pnlBina_takas As Panel
    Friend WithEvents rbBinaTakas_hayir As RadioButton
    Friend WithEvents rbBinaTakas_evet As RadioButton
    Friend WithEvents pnlBina_ilanTarihi As Panel
    Friend WithEvents rbBinaIlan_30gun As RadioButton
    Friend WithEvents rbBinaIlan_15gun As RadioButton
    Friend WithEvents rbBinaIlan_7gun As RadioButton
    Friend WithEvents rbBinaIlan_3gun As RadioButton
    Friend WithEvents rbBinaIlan_24saat As RadioButton
    Friend WithEvents pnlTuristik_fotoVideo As Panel
    Friend WithEvents chkTuristik_video As CheckBox
    Friend WithEvents chkTuristik_foto As CheckBox
    Friend WithEvents pnlTuristik_adres As Panel
    Friend WithEvents cbxTuristik_mahalle As ComboBox
    Friend WithEvents cbxTuristik_ilce As ComboBox
    Friend WithEvents cbxTuristik_il As ComboBox
    Friend WithEvents pnlTuristik_fiyat As Panel
    Friend WithEvents txtTuristik_MaxTL As TextBox
    Friend WithEvents txtTuristik_MinTL As TextBox
    Friend WithEvents pnlTuristik_ilanTarihi As Panel
    Friend WithEvents rbTuristikIlan_30gun As RadioButton
    Friend WithEvents rbTuristikIlan_15gun As RadioButton
    Friend WithEvents rbTuristikIlan_7gun As RadioButton
    Friend WithEvents rbTuristikIlan_3gun As RadioButton
    Friend WithEvents rbTuristikIlan_24saat As RadioButton
    Friend WithEvents txtKonut_MaxBinaYas3 As TextBox
    Friend WithEvents txtKonut_MaxBanyoSayisi2 As TextBox
    Friend WithEvents txtKonut_MinBanyoSayisi2 As TextBox
    Friend WithEvents txtKonut_MaxKatSayi2 As TextBox
    Friend WithEvents txtKonut_MinKatSayi2 As TextBox
    Friend WithEvents txtBina_MaxKatSayi3 As TextBox
    Friend WithEvents txtBina_MinKatSayi3 As TextBox
    Friend WithEvents txtBina_MaxBirKattakiDaire2 As TextBox
    Friend WithEvents txtBina_MinBirKattakiDaire2 As TextBox
    Friend WithEvents dtgridAramaSonucu As DataGridView
    Friend WithEvents EmlakOtomasyonuDataSetBindingSource As BindingSource
    Friend WithEvents EmlakOtomasyonuDataSet As EmlakOtomasyonuDataSet
    Friend WithEvents clmresim1 As DataGridViewImageColumn
    Friend WithEvents clmBaslik As DataGridViewTextBoxColumn
    Friend WithEvents clmM2 As DataGridViewTextBoxColumn
    Friend WithEvents clmFiyat As DataGridViewTextBoxColumn
    Friend WithEvents clmTarih As DataGridViewTextBoxColumn
    Friend WithEvents clmIlce As DataGridViewTextBoxColumn
    Friend WithEvents clmSehirAdi As DataGridViewTextBoxColumn
    Friend WithEvents clmilanno As DataGridViewTextBoxColumn
    Friend WithEvents clmaciklama As DataGridViewTextBoxColumn
    Friend WithEvents clmilanveren As DataGridViewTextBoxColumn
    Friend WithEvents clmilanturid As DataGridViewTextBoxColumn
    Friend WithEvents clmresim2 As DataGridViewTextBoxColumn
    Friend WithEvents clmresim3 As DataGridViewTextBoxColumn
    Friend WithEvents clmresim4 As DataGridViewTextBoxColumn
    Friend WithEvents clmresim5 As DataGridViewTextBoxColumn
    Friend WithEvents clmresim6 As DataGridViewTextBoxColumn
    Friend WithEvents clmresim7 As DataGridViewTextBoxColumn
    Friend WithEvents clmresim8 As DataGridViewTextBoxColumn
    Friend WithEvents clmVideo As DataGridViewTextBoxColumn
    Friend WithEvents clmAdres As DataGridViewTextBoxColumn
    Friend WithEvents clmIslemTamamMi As DataGridViewTextBoxColumn
    Friend WithEvents clmKonutAcikAlan As DataGridViewTextBoxColumn
    Friend WithEvents clmBinaYasi As DataGridViewTextBoxColumn
    Friend WithEvents clmKatSayisi As DataGridViewTextBoxColumn
    Friend WithEvents clmKonutBanyoSayisi As DataGridViewTextBoxColumn
    Friend WithEvents clmKonutEsyali As DataGridViewTextBoxColumn
    Friend WithEvents clmKonutKullanimDurumu As DataGridViewTextBoxColumn
    Friend WithEvents clmKonutSiteİçi As DataGridViewTextBoxColumn
    Friend WithEvents clmKonutAidat As DataGridViewTextBoxColumn
    Friend WithEvents clmKredi As DataGridViewTextBoxColumn
    Friend WithEvents clmTakasli As DataGridViewTextBoxColumn
    Friend WithEvents clmMahalle As DataGridViewTextBoxColumn
    Friend WithEvents clmKonutOdaSayisi As DataGridViewTextBoxColumn
    Friend WithEvents clmBulunduguKat As DataGridViewTextBoxColumn
    Friend WithEvents clmIsitma As DataGridViewTextBoxColumn
    Friend WithEvents clmSatisTuru As DataGridViewTextBoxColumn
    Friend WithEvents clmKonutTip As DataGridViewTextBoxColumn
    Friend WithEvents clmArsaParsel As DataGridViewTextBoxColumn
    Friend WithEvents clmArsaPafta As DataGridViewTextBoxColumn
    Friend WithEvents clmArsaAda As DataGridViewTextBoxColumn
    Friend WithEvents clmArsaKatKarsiligi As DataGridViewTextBoxColumn
    Friend WithEvents clmArsaImarDurumu As DataGridViewTextBoxColumn
    Friend WithEvents clmGbari As DataGridViewTextBoxColumn
    Friend WithEvents clmArsaKaks As DataGridViewTextBoxColumn
    Friend WithEvents clmArsaTapuDurumu As DataGridViewTextBoxColumn
    Friend WithEvents clmArsaMetrekareFiyat As DataGridViewTextBoxColumn
    Friend WithEvents clmBirKattakiDaireSayisi As DataGridViewTextBoxColumn
    Friend WithEvents clmTTOtelYıldız As DataGridViewTextBoxColumn
    Friend WithEvents clmTTApartSayisi As DataGridViewTextBoxColumn
    Friend WithEvents clmTTodaSayisi As DataGridViewTextBoxColumn
    Friend WithEvents clmTTYatakSayisi As DataGridViewTextBoxColumn
    Friend WithEvents clmTTAcikAlan As DataGridViewTextBoxColumn
    Friend WithEvents clmTTKapaliAlan As DataGridViewTextBoxColumn
    Friend WithEvents clmTTZeminEtudu As DataGridViewTextBoxColumn
    Friend WithEvents clmTTYapiDurum As DataGridViewTextBoxColumn
    Friend WithEvents clmTTToplamArazi As DataGridViewTextBoxColumn
    Friend WithEvents clmTTPlaj_Buyukluk As DataGridViewTextBoxColumn
    Friend WithEvents clmTTPlajKapasite As DataGridViewTextBoxColumn
    Friend WithEvents clmTTTip As DataGridViewTextBoxColumn
    Friend WithEvents clmBufeDurum As DataGridViewTextBoxColumn
    Friend WithEvents clmBufem2ORacik As DataGridViewTextBoxColumn
    Friend WithEvents clmBudeIsitma_ID As DataGridViewTextBoxColumn
    Friend WithEvents clmBufeOda As DataGridViewTextBoxColumn
    Friend WithEvents clmBudeDurum As DataGridViewTextBoxColumn
    Friend WithEvents clmTavan As DataGridViewTextBoxColumn
    Friend WithEvents clmDepozito As DataGridViewTextBoxColumn
    Friend WithEvents clmMasa_Sayisi As DataGridViewTextBoxColumn
    Friend WithEvents clmkisiKapasite As DataGridViewTextBoxColumn
    Friend WithEvents clmAracSayisi As DataGridViewTextBoxColumn
    Friend WithEvents clmCinsiyet As DataGridViewTextBoxColumn
    Friend WithEvents clmYapiTipi As DataGridViewTextBoxColumn
    Friend WithEvents clmIsyeriTipi As DataGridViewTextBoxColumn
    Friend WithEvents clmSpor As DataGridViewTextBoxColumn
    Friend WithEvents clmSatisTurID As DataGridViewTextBoxColumn
    Friend WithEvents clmIsyeri_Tip As DataGridViewTextBoxColumn
    Friend WithEvents clmAsansor As DataGridViewTextBoxColumn
    Friend WithEvents clmOtoparkTur As DataGridViewTextBoxColumn
    Friend WithEvents clmGiris As DataGridViewTextBoxColumn
    Friend WithEvents clmTapuD As DataGridViewTextBoxColumn
    Friend WithEvents clmBinaAdet As DataGridViewTextBoxColumn
    Friend WithEvents clmBinaTipID As DataGridViewTextBoxColumn
End Class
