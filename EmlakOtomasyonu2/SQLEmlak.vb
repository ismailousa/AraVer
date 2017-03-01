Imports System.Data.SqlClient
Public Class SqlEmlak
    Private SQL_Baglanti As New SqlClient.SqlConnection
    Private SQL_Komut As New SqlClient.SqlCommand
    Sub New()
        SQL_Baglanti.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=AraVer;Integrated Security=True"
        SQL_Komut.Connection = SQL_Baglanti
    End Sub
    Private Sub Ac_IslemYap_Kapat()
        SQL_Baglanti.Open()
        SQL_Komut.ExecuteNonQuery()
        SQL_Baglanti.Close()
        SQL_Komut.Parameters.Clear()
    End Sub

#Region "Emlak Ekleme"
    Public Sub KonutEkle(konut As Konut, sahip As EmlakSahibi)
        EmlakEkle(konut, sahip)
        If konut.AcikAlanBuyuklugu <> Nothing Then
            SQL_Komut.CommandText = "Insert Into Konut values('" & konut.ilanNo & "','" & konut.KonutTipID & "','" & konut.Buyukluk & "','" & konut.AcikAlanBuyuklugu & "','" & konut.BinaYasi & "','" & konut.OdaSayisiID & "','" & konut.BulunduguKatID & "','" & konut.KatSayisi & "','" & konut.IsitmaID & "','" & konut.BanyoSayisi & "','" & konut.Esyali & "','" & konut.KullanimDurumu & "','" & konut.SiteIcerisinde & "','" & konut.Aidat & "','" & konut.KrediyeUygun & "','" & konut.Takas & "')"
        Else
            SQL_Komut.CommandText = "Insert Into Konut(ilan_No, Konut_Tip_ID, Buyukluk, Bina_Yasi, Oda_Sayisi_ID, Bulundugu_Kat_ID, Kat_Sayisi, Isitma_ID, Banyo_Sayisi, Esyali,Kullanim_Durumu, Site_Icerisinde, Aidat, Krediye_Uygun, Takasli) values('" & konut.ilanNo & "','" & konut.KonutTipID & "','" & konut.Buyukluk & "','" & konut.BinaYasi & "','" & konut.OdaSayisiID & "','" & konut.BulunduguKatID & "','" & konut.KatSayisi & "','" & konut.IsitmaID & "','" & konut.BanyoSayisi & "','" & konut.Esyali & "','" & konut.KullanimDurumu & "','" & konut.SiteIcerisinde & "','" & konut.Aidat & "','" & konut.KrediyeUygun & "','" & konut.Takas & "')"
        End If
        Ac_IslemYap_Kapat()
    End Sub
    Public Sub ArsaEkle(arsa As Arsa, sahip As EmlakSahibi)
        EmlakEkle(arsa, sahip)
        Dim komutText As String = "insert into Arsa(ilan_No,imar_Durumu_ID,Buyukluk"
        Dim bir As Boolean = False
        Dim iki As Boolean = False
        Dim uc As Boolean = False
        Dim dort As Boolean = False
        Dim bes As Boolean = False
        Dim alti As Boolean = False
        If arsa.AdaNo <> -1 Then : komutText += ",Ada_No" : bir = True
        End If
        If arsa.ParselNo <> -1 Then : komutText += ",Parsel_No" : iki = True
        End If
        If arsa.PaftaNo <> -1 Then : komutText += ",Pafta_No" : uc = True
        End If
        If arsa.KaksID <> 255 Then : komutText += ",Kaks" : dort = True
        End If
        If arsa.GabariID <> 255 Then : komutText += ",Gabari" : bes = True
        End If
        If arsa.TapuDurumuID <> 255 Then : komutText += ",Tapu_Durumu" : alti = True
        End If
        komutText += ",Krediye_Uygun,Takasli,Kat_Karsiligi) values('" & arsa.ilanNo & "','" & arsa.imarDurumuID & "','" & arsa.Buyukluk & "'"
        If bir Then : komutText += ",'" & arsa.AdaNo & "'"
        End If
        If iki Then : komutText += ",'" & arsa.ParselNo & "'"
        End If
        If uc Then : komutText += ",'" & arsa.PaftaNo & "'"
        End If
        If dort Then : komutText += ",'" & arsa.KaksID & "'"
        End If
        If bes Then : komutText += ",'" & arsa.GabariID & "'"
        End If
        If alti Then : komutText += ",'" & arsa.TapuDurumuID & "'"
        End If
        komutText += ",'" & arsa.Kredi & "','" & arsa.Takas & "','" & arsa.KatKarsiligi & "')"
        SQL_Komut.CommandText = komutText
        Ac_IslemYap_Kapat()
    End Sub
    Public Sub BinaEkle(bina As Bina, sahip As EmlakSahibi)
        EmlakEkle(bina, sahip)
        SQL_Komut.CommandText = "insert into Bina values('" & bina.ilanNo & "','" & bina.KatSayisi & "','" & bina.BirKattakiDaireSayisi & "','" & bina.IsitmaID & "','" & bina.Buyukluk & "','" & bina.BinaYasi & "','" & bina.KrediyeUygun & "','" & bina.Takas & "')"
        Ac_IslemYap_Kapat()
    End Sub
    Public Sub TT_Ekle(tt As Turistik_Tesis, sahip As EmlakSahibi) 'Nullable Bool kullanildi
        EmlakEkle(tt, sahip)
        Dim komutText As String = "insert into Turistik_Tesis(ilan_NO,TT_Tipi"
        Dim bir As Boolean = False
        Dim iki As Boolean = False
        Dim uc As Boolean = False
        Dim dort As Boolean = False
        Dim bes As Boolean = False
        Dim alti As Boolean = False
        Dim yedi As Boolean = False
        Dim sekiz As Boolean = False
        Dim dokuz As Boolean = False
        Dim onn As Boolean = False
        Dim onbir As Boolean = False
        If tt.OtelYildizSayisi <> 255 Then : bir = True : komutText += ",Otel_Yildiz_Sayisi"
        End If
        If tt.ApartSayisi <> -1 Then : iki = True : komutText += ",Apart_Otel_Apart_Sayisi"
        End If
        If tt.OdaSayisi <> -1 Then : uc = True : komutText += ",Oda_Sayisi"
        End If
        If tt.YatakSayisi <> -1 Then : dort = True : komutText += ",yatak_Sayisi"
        End If
        If tt.KatSayisi <> 255 Then : bes = True : komutText += ",kat_Sayisi"
        End If
        If tt.BinaYasi <> 255 Then : alti = True : komutText += ",Bina_Yasi"
        End If
        If tt.AcikAlan <> -1 Then : yedi = True : komutText += ",Acik_Alan"
        End If
        If tt.KapaliAlan <> -1 Then : sekiz = True : komutText += ",Kapali_Alan"
        End If
        If tt.ZeminEtudu.HasValue Then : dokuz = True : komutText += ",Zemin_Etudu"
        End If
        If tt.YapiDurumu.HasValue Then : onn = True : komutText += ",Yapi_Durumu"
        End If
        If tt.KrediyeUygun.HasValue Then : onbir = True : komutText += ",Krediye_Uygun"
        End If
        komutText += ") values( @ilanno, @tipid"
        SQL_Komut.Parameters.Add(New SqlParameter("@ilanno", SqlDbType.Char)).Value = tt.ilanNo
        SQL_Komut.Parameters.Add(New SqlParameter("@tipid", SqlDbType.TinyInt)).Value = tt.TipID
        If bir Then : komutText += ",@OtelYildizSayisi"
            SQL_Komut.Parameters.Add(New SqlParameter("@OtelYildizSayisi", SqlDbType.TinyInt)).Value = tt.OtelYildizSayisi
        End If
        If iki Then : komutText += ",@ApartSayisi"
            SQL_Komut.Parameters.AddWithValue("@ApartSayisi", tt.ApartSayisi)
        End If
        If uc Then : komutText += ",@OdaSayisi"
            SQL_Komut.Parameters.AddWithValue("@OdaSayisi", tt.OdaSayisi)
        End If
        If dort Then : komutText += ",@YatakSayisi"
            SQL_Komut.Parameters.AddWithValue("@YatakSayisi", tt.YatakSayisi)
        End If
        If bes Then : komutText += ",@KatSayisi"
            SQL_Komut.Parameters.AddWithValue("@KatSayisi", tt.KatSayisi)
        End If
        If alti Then : komutText += ",@BinaYasi"
            SQL_Komut.Parameters.AddWithValue("@BinaYasi", tt.BinaYasi)
        End If
        If yedi Then : komutText += ",@AcikAlan"
            SQL_Komut.Parameters.Add(New SqlParameter("@AcikAlan", SqlDbType.Int)).Value = tt.AcikAlan
        End If
        If sekiz Then : komutText += ",@KapaliAlan"
            SQL_Komut.Parameters.Add(New SqlParameter("@KapaliAlan", SqlDbType.Int)).Value = tt.KapaliAlan
        End If
        If dokuz Then : komutText += ",@ZeminEtudu"
            SQL_Komut.Parameters.AddWithValue("@ZeminEtudu", tt.ZeminEtudu)
        End If
        If onn Then : komutText += ",@YapiDurumu"
            SQL_Komut.Parameters.AddWithValue("@YapiDurumu", tt.YapiDurumu)
        End If
        If onbir Then : komutText += ",@KrediyeUygun"
            SQL_Komut.Parameters.AddWithValue("@KrediyeUygun", tt.KrediyeUygun)
        End If
        komutText += ")"
        SQL_Komut.CommandText = komutText
        Ac_IslemYap_Kapat()
    End Sub
    Public Sub AtölyeBuroDukkanAVMİmalathaneEKLE(isyeri As AtolyeBuroDukkanImaAVM, sahip As EmlakSahibi)
        EmlakEkle(isyeri, sahip)
        If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Isitma_ID, Durumu, m2ORacik, Takasli, Krediye_Uygun) values (@ilanno, @tipi, @binayas, @isitma,@durumu,@buyukluk, @takasli,@kredi)"
        Else : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Isitma_ID, Durumu, m2ORacik, Takasli) values (@ilanno, @tipi, @binayas, @isitma,@durumu,@buyukluk, @takasli)"
        End If
        With SQL_Komut.Parameters
            .AddWithValue("@ilanno", isyeri.ilanNo)
            .AddWithValue("@tipi", isyeri.IsyeriGrupID)
            .AddWithValue("@binayas", isyeri.BinaYasi)
            .AddWithValue("@isitma", isyeri.IsitmaID)
            .AddWithValue("@buyukluk", isyeri.Buyukluk)
            .AddWithValue("@takasli", isyeri.Takas)
            .AddWithValue("@kredi", isyeri.krediyeUygun)
            .AddWithValue("@durumu", isyeri.Durum)
        End With
        Ac_IslemYap_Kapat()
        SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(isyeri.ilanNo))
        SQL_Komut.Parameters.AddWithValue("@tip", isyeri.isyeriTipi)
        SQL_Komut.Parameters.AddWithValue("@depozito", isyeri.depozitosu)
        Select Case isyeri.isyeriTipi
            Case 1 'AVM
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into AtolyeBuroDukkanImaAVM(Isyeri_ID,Isyeri_Tipi,kat_Sayisi, Asansor_Sayisi) values (@yerid, @tip,@katsayisi, @asansor)"
                Else : SQL_Komut.CommandText = "insert into AtolyeBuroDukkanImaAVM(Isyeri_ID,Isyeri_Tipi,kat_Sayisi, Asansor_Sayisi,depozito) values (@yerid, @tip,@katsayisi, @asansor,@depozito)"
                End If
                With SQL_Komut.Parameters
                    .AddWithValue("@katsayisi", isyeri.katSayisi)
                    .AddWithValue("@asansor", isyeri.asansorSayisi)
                End With
            Case 0, 3, 7 'Atölye, Büro, Dükkan
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into AtolyeBuroDukkanImaAVM(Isyeri_ID,Isyeri_Tipi,aidat,oda_bolum_sayisi) values(@yerid, @tip, @aidat,@odabolum)"
                Else : SQL_Komut.CommandText = "insert into AtolyeBuroDukkanImaAVM(Isyeri_ID,Isyeri_Tipi,aidat,oda_bolum_sayisi, depozito) values(@yerid, @tip, @aidat,@odabolum, @depozito)"
                End If
                With SQL_Komut.Parameters
                    .AddWithValue("@aidat", isyeri.aidati)
                    .AddWithValue("@odabolum", isyeri.odaBolumSayisi)
                End With
            Case 9 'Imalathane
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into AtolyeBuroDukkanImaAVM(Isyeri_ID,Isyeri_Tipi,oda_bolum_sayisi) values(@yerid, @tip,@odabolum)"
                Else : SQL_Komut.CommandText = "insert into AtolyeBuroDukkanImaAVM(Isyeri_ID,Isyeri_Tipi,oda_bolum_sayisi, depozito) values(@yerid, @tip,@odabolum, @depozito)"
                End If
                SQL_Komut.Parameters.AddWithValue("@odabolum", isyeri.odaBolumSayisi)
        End Select
        Ac_IslemYap_Kapat()
    End Sub
    Public Sub BufeDugunSinSpaOtoEKLE(isyeri As BufeDugunSpaSineOto, sahip As EmlakSahibi)
        EmlakEkle(isyeri, sahip)
        With SQL_Komut.Parameters
            .AddWithValue("@ilanno", isyeri.ilanNo)
            .AddWithValue("@tipi", isyeri.IsyeriGrupID)
            .AddWithValue("@binayas", isyeri.BinaYasi)
            .AddWithValue("@durumu", isyeri.Durum)
            .AddWithValue("@buyukluk", isyeri.Buyukluk)
            .AddWithValue("@kredi", isyeri.krediyeUygun)
        End With
        Select Case isyeri.isyeriTipi
            Case 2 'Bufe
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Durumu, m2ORacik, Krediye_Uygun) values (@ilanno, @tipi,@durumu,@buyukluk,@kredi)"
                Else : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Durumu, m2ORacik) values (@ilanno, @tipi, @durumu,@buyukluk)"
                End If
                Ac_IslemYap_Kapat()
                BufeVSParam(isyeri)
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into bufedugunspasineoto(Isyeri_ID, Isyeri_Tipi, Yapi_Tipi, Kullanim_Durumu) values(@yerid, @tip, @yapi, @kullanim)"
                Else : SQL_Komut.CommandText = "insert into BufeDugunSpaSineOto(Isyeri_ID, Isyeri_Tipi, Yapi_Tipi, Kullanim_Durumu, Depozito) values(@yerid, @tip, @yapi, @kullanim, @depozito)"
                End If
                SQL_Komut.Parameters.AddWithValue("@yapi", isyeri.YapiTipi)
                SQL_Komut.Parameters.AddWithValue("@kullanim", isyeri.kullanimDurumu)
                Ac_IslemYap_Kapat()
            Case 16 'Spa
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi ,Durumu, m2ORacik, Krediye_Uygun) values (@ilanno, @tipi, @binayas,@durumu,@buyukluk,@kredi)"
                Else : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Durumu, m2ORacik) values (@ilanno, @tipi, @binayas, @durumu,@buyukluk)"
                End If
                Ac_IslemYap_Kapat()
                BufeVSParam(isyeri)
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into bufedugunspasineoto(Isyeri_ID, Isyeri_Tipi, Kullanim_Durumu,Cinsiyet,Kisi_kapasitesi,Oda_bolum_Sayisi) values(@yerid, @tip, @kullanim,@cinsiyet,@kisi,@odabolum)"
                Else : SQL_Komut.CommandText = "insert into bufedugunspasineoto(Isyeri_ID, Isyeri_Tipi, Kullanim_Durumu,Cinsiyet,Kisi_kapasitesi,Oda_bolum_Sayisi ,Depozito) values(@yerid, @tip, @kullanim,@cinsiyet,@kisi,@odabolum, @depozito)"
                End If
                With SQL_Komut.Parameters
                    .AddWithValue("@cinsiyet", isyeri.cinsiyeti)
                    .AddWithValue("@kisi", isyeri.kisiKapasitesi)
                    .AddWithValue("@kullanim", isyeri.kullanimDurumu)
                    .AddWithValue("@odabolum", isyeri.odaBolumSayisi)
                End With
                Ac_IslemYap_Kapat()
            Case 15 'Sinema
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Isitma_ID, Durumu, m2ORacik, Takasli, Krediye_Uygun) values (@ilanno, @tipi, @binayas, @isitma, @durumu,@buyukluk, @takas, @kredi)"
                Else : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Durumu, m2ORacik, Takasli) values (@ilanno, @tipi, @binayas, @durumu,@buyukluk, @takas)"
                End If
                SQL_Komut.Parameters.AddWithValue("@takas", isyeri.tavanYukseklik)
                SQL_Komut.Parameters.AddWithValue("@isitma", isyeri.IsitmaID)
                Ac_IslemYap_Kapat()
                BufeVSParam(isyeri)
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into bufedugunspasineoto(Isyeri_ID, Isyeri_Tipi, Kullanim_Durumu,Tavan_Yuksekligi, Kat_Sayisi, Bulundugu_Kat,Kisi_kapasitesi,Oda_bolum_Sayisi) values(@yerid, @tip, @kullanim,@TavanYuksekligi, @KatSayisi, @Kat,@kisi,@odabolum)"
                Else : SQL_Komut.CommandText = "insert into BufeDugunSpaSineOto(Isyeri_ID, Isyeri_Tipi, Kullanim_Durumu,Tavan_Yuksekligi, Kat_Sayisi, Bulundugu_Kat,Kisi_kapasitesi,Oda_bolum_Sayisi ,Depozito) values(@yerid, @tip, @kullanim,@TavanYuksekligi, @KatSayisi, @Kat,@kisi,@odabolum, @depozito)"
                End If
                With SQL_Komut.Parameters
                    .AddWithValue("@kisi", isyeri.kisiKapasitesi)
                    .AddWithValue("@kullanim", isyeri.kullanimDurumu)
                    .AddWithValue("@odabolum", isyeri.odaBolumSayisi)
                    .AddWithValue("@Tavanyuksekligi", isyeri.tavanYukseklik)
                    .AddWithValue("@KatSayisi", isyeri.katSayisi)
                    .AddWithValue("@kat", isyeri.bulunduguKat)
                End With
                Ac_IslemYap_Kapat()
            Case 11 'Otopark
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, m2ORacik, Krediye_Uygun) values (@ilanno, @tipi, @binayas,@buyukluk, @kredi)"
                Else : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, m2ORacik) values (@ilanno, @tipi, @binayas,@buyukluk)"
                End If
                Ac_IslemYap_Kapat()
                BufeVSParam(isyeri)
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into bufedugunspasineoto(Isyeri_ID, Isyeri_Tipi, Kat_Sayisi, Arac_Sayisi, Otopark_Turu) values(@yerid, @tip, @KatSayisi,@aracSayisi, @otoparkTur)"
                Else : SQL_Komut.CommandText = "insert into BufeDugunSpaSineOto(Isyeri_ID, Isyeri_Tipi, Kat_Sayisi, Arac_Sayisi, Otopark_Turu,Depozito) values(@yerid, @tip, @KatSayisi,@aracSayisi, @otoparkTur,@depozito)"
                End If
                SQL_Komut.Parameters.AddWithValue("@KatSayisi", isyeri.katSayisi)
                SQL_Komut.Parameters.AddWithValue("@aracSayisi", isyeri.aracSayisi)
                SQL_Komut.Parameters.AddWithValue("@otoparkTur", isyeri.otoparkTuru)
                Ac_IslemYap_Kapat()
            Case 6 'Dugun Salonu
                SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, m2ORacik) values (@ilanno, @tipi, @binayas,@buyukluk)"
                Ac_IslemYap_Kapat()
                SQL_Komut.CommandText = "insert into BufeDugunSpaSineOto(Isyeri_ID, Isyeri_Tipi, Masa_Sayisi, Kisi_kapasitesi) values(@yerid, @tip, @masaSayisi, @kisiSayisi)"
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(isyeri.ilanNo))
                SQL_Komut.Parameters.AddWithValue("@tip", isyeri.isyeriTipi)
                SQL_Komut.Parameters.AddWithValue("@masaSayisi", isyeri.masaSayisi)
                SQL_Komut.Parameters.AddWithValue("@kisiSayisi", isyeri.kisiKapasitesi)
                Ac_IslemYap_Kapat()
        End Select
    End Sub
    Public Sub DepoBinaPlazaFabrikaEKLE(isyeri As DepoBinaPlazaFabrika, sahip As EmlakSahibi)
        EmlakEkle(isyeri, sahip)
        With SQL_Komut.Parameters
            .AddWithValue("@ilanno", isyeri.ilanNo)
            .AddWithValue("@tipi", isyeri.IsyeriGrupID)
            .AddWithValue("@binayas", isyeri.BinaYasi)
            .AddWithValue("@isitma", isyeri.IsitmaID)
            .AddWithValue("@durumu", isyeri.Durum)
            .AddWithValue("@buyukluk", isyeri.Buyukluk)
            .AddWithValue("@takasli", isyeri.Takas)
            .AddWithValue("@kredi", isyeri.krediyeUygun)
        End With
        Select Case isyeri.isyeriTipi
            Case 8 'Fabrika
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Isitma_ID, Durumu, m2ORacik, Takasli, Krediye_Uygun) values (@ilanno, @tipi, @binayas, @isitma,@durumu,@buyukluk, @takasli,@kredi)"
                Else : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Isitma_ID, Durumu, m2ORacik, Takasli) values (@ilanno, @tipi, @binayas, @isitma,@durumu,@buyukluk, @takasli)"
                End If
                Ac_IslemYap_Kapat()
                DepoVSParam(isyeri)
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into DepoBinaPlazaFabrika(Isyeri_ID, Isyeri_Tipi, Kapali_Alan, Bina_Adedi, Giris_yukseklik, Oda_Bolum_Sayisi, Kat_Sayisi, Zemin_Etudu,Kullanim_Durumu, Tapu_Durumu) values (@yerid, @tip,@kapalialan, @binaadet, @girisyukseklik, @odabolum, @katSayisi, @zemin, @kullanim, @tapu)"
                Else : SQL_Komut.CommandText = "insert into DepoBinaPlazaFabrika(Isyeri_ID, Isyeri_Tipi, Kapali_Alan, Bina_Adedi, Giris_yukseklik, Oda_Bolum_Sayisi, Kat_Sayisi, Zemin_Etudu,Kullanim_Durumu, Tapu_Durumu, Depozito) values (@yerid, @tip,@kapalialan, @binaadet, @girisyukseklik, @odabolum, @katSayisi, @zemin, @kullanim, @tapu, @depozito)"
                End If
                SQL_Komut.Parameters.AddWithValue("@kapalialan", isyeri.KapaliAlan)
                SQL_Komut.Parameters.AddWithValue("@binaadet", isyeri.BinaAdedi)
                SQL_Komut.Parameters.AddWithValue("@girisyukseklik", isyeri.GirisYukseklik)
                SQL_Komut.Parameters.AddWithValue("@odabolum", isyeri.odaBolumSayisi)
                SQL_Komut.Parameters.AddWithValue("@katSayisi", isyeri.KatSayisi)
                SQL_Komut.Parameters.AddWithValue("@depozito", isyeri.depozitosu)
                Ac_IslemYap_Kapat()
            Case 5 'Depo
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Isitma_ID, Durumu, m2ORacik, Takasli, Krediye_Uygun) values (@ilanno, @tipi, @binayas, @isitma,@durumu,@buyukluk, @takasli,@kredi)"
                Else : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Isitma_ID, Durumu, m2ORacik, Takasli) values (@ilanno, @tipi, @binayas, @isitma,@durumu,@buyukluk, @takasli)"
                End If
                Ac_IslemYap_Kapat()
                DepoVSParam(isyeri)
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into DepoBinaPlazaFabrika(Isyeri_ID, Isyeri_Tipi, Giris_yukseklik, Zemin_Etudu, Kullanim_Durumu, Tapu_Durumu) values(@yerid, @tip, @girisyukseklik, @zemin, @kullanim, @tapu)"
                Else : SQL_Komut.CommandText = "insert into DepoBinaPlazaFabrika(Isyeri_ID, Isyeri_Tipi, Giris_yukseklik, Zemin_Etudu, Kullanim_Durumu, Tapu_Durumu, Depozito) values(@yerid, @tip, @girisyukseklik, @zemin, @kullanim, @tapu, @depozito)"
                End If
                SQL_Komut.Parameters.AddWithValue("@depozito", isyeri.depozitosu)
                SQL_Komut.Parameters.AddWithValue("@girisyukseklik", isyeri.GirisYukseklik)
                Ac_IslemYap_Kapat()
            Case 10 'Komple bina
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Isitma_ID, Durumu, m2ORacik, Krediye_Uygun) values (@ilanno, @tipi, @binayas, @isitma,@durumu,@buyukluk,@kredi)"
                Else : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Isitma_ID, Durumu, m2ORacik) values (@ilanno, @tipi, @binayas, @isitma,@durumu,@buyukluk)"
                End If
                Ac_IslemYap_Kapat()
                DepoVSParam(isyeri)
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into DepoBinaPlazaFabrika(Isyeri_ID, Isyeri_Tipi, Zemin_Etudu, Kullanim_Durumu, Tapu_Durumu, Kat_Sayisi, Bina_Tipi_ID) values(@yerid, @tip, @zemin, @kullanim, @tapu, @katSayisi, @binaTipi)"
                Else : SQL_Komut.CommandText = "insert into DepoBinaPlazaFabrika(Isyeri_ID, Isyeri_Tipi, Zemin_Etudu, Kullanim_Durumu, Tapu_Durumu, Kat_Sayisi, Bina_Tipi_ID,Depozito) values(@yerid, @tip, @zemin, @kullanim, @tapu, @katSayisi, @binaTipi, @depozito)"
                End If
                SQL_Komut.Parameters.AddWithValue("@depozito", isyeri.depozitosu)
                SQL_Komut.Parameters.AddWithValue("@KatSayisi", isyeri.KatSayisi)
                SQL_Komut.Parameters.AddWithValue("@binaTipi", isyeri.BinaTipiID)
                Ac_IslemYap_Kapat()
            Case 13 'Plaza
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Isitma_ID, Durumu, m2ORacik, Takasli, Krediye_Uygun) values (@ilanno, @tipi, @binayas, @isitma,@durumu,@buyukluk,@takasli,@kredi)"
                Else : SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Bina_Yasi, Isitma_ID, Durumu, m2ORacik, Takasli) values (@ilanno, @tipi, @binayas, @isitma,@durumu,@buyukluk,@takasli)"
                End If
                Ac_IslemYap_Kapat()
                DepoVSParam(isyeri)
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "insert into DepoBinaPlazaFabrika(Isyeri_ID, Isyeri_Tipi, Zemin_Etudu, Kullanim_Durumu, Tapu_Durumu, Kat_Sayisi, Aidat, Bulundugu_Kat, Oda_Bolum_Sayisi) values(@yerid, @tip, @zemin, @kullanim, @tapu, @katSayisi, @aidat, @kat, @odabolum)"
                Else : SQL_Komut.CommandText = "insert into DepoBinaPlazaFabrika(Isyeri_ID, Isyeri_Tipi, Zemin_Etudu, Kullanim_Durumu, Tapu_Durumu, Kat_Sayisi, Aidat, Bulundugu_Kat, Oda_Bolum_Sayisi,Depozito) values(@yerid, @tip, @zemin, @kullanim, @tapu, @katSayisi, @aidat, @kat, @odabolum, @depozito)"
                End If
                SQL_Komut.Parameters.AddWithValue("@depozito", isyeri.depozitosu)
                SQL_Komut.Parameters.AddWithValue("@KatSayisi", isyeri.KatSayisi)
                SQL_Komut.Parameters.AddWithValue("@binaTipi", isyeri.BinaAdedi)
                SQL_Komut.Parameters.AddWithValue("@odabolum", isyeri.odaBolumSayisi)
                SQL_Komut.Parameters.AddWithValue("@aidat", isyeri.Aidat)
                SQL_Komut.Parameters.AddWithValue("@kat", isyeri.BulunduguKat)
                Ac_IslemYap_Kapat()
        End Select
    End Sub
    Public Sub SporRadyoPazarCiftlikEKLE(isyeri As SporRadyoPazarCiftlik, sahip As EmlakSahibi)
        EmlakEkle(isyeri, sahip)
        SQL_Komut.Parameters.AddWithValue("@buyukluk", isyeri.Buyukluk)
        SQL_Komut.Parameters.AddWithValue("@ilanno", isyeri.ilanNo)
        SQL_Komut.Parameters.AddWithValue("@tipi", isyeri.IsyeriGrupID)
        Select Case isyeri.IsyeriTipi
            Case 4 'Ciftlik
                SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu, Durumu, m2ORacik, Krediye_Uygun) values (@ilanno, @tipi,@durumu,@buyukluk,@kredi)"
                SQL_Komut.Parameters.AddWithValue("@durumu", isyeri.Durum)
                SQL_Komut.Parameters.AddWithValue("@kredi", isyeri.krediyeUygun)
                Ac_IslemYap_Kapat()
                SporVSParam(isyeri)
                SQL_Komut.CommandText = "insert into SporRadyoPazarCiftlik(Isyeri_ID, Isyeri_Tipi, Kapali_Alan) values(@yerid, @tip, @kapali)"
                SQL_Komut.Parameters.AddWithValue("@kapali", isyeri.KapaliAlan)
                Ac_IslemYap_Kapat()
            Case 12 'Pazar
                SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu,  m2ORacik, Takasli) values (@ilanno, @tipi,@buyukluk, @takas)"
                SQL_Komut.Parameters.AddWithValue("@takas", isyeri.Takas)
                Ac_IslemYap_Kapat()
                SporVSParam(isyeri)
                SQL_Komut.CommandText = "insert into SporRadyoPazarCiftlik(Isyeri_ID, Isyeri_Tipi) values(@yerid, @tip)"
                Ac_IslemYap_Kapat()
            Case 14 'Radyo
                SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu,  m2ORacik, Isitma_ID, Krediye_Uygun, Takasli) values (@ilanno, @tipi,@buyukluk,@isitma, @kredi, @takas)"
                SQL_Komut.Parameters.AddWithValue("@takas", isyeri.Takas)
                SQL_Komut.Parameters.AddWithValue("@isitma", isyeri.IsitmaID)
                SQL_Komut.Parameters.AddWithValue("@kredi", isyeri.krediyeUygun)
                Ac_IslemYap_Kapat()
                SporVSParam(isyeri)
                SQL_Komut.CommandText = "insert into SporRadyoPazarCiftlik(Isyeri_ID, Isyeri_Tipi) values(@yerid, @tip)"
                Ac_IslemYap_Kapat()
            Case 17 'Spor
                SQL_Komut.CommandText = "insert into Isyerleri(ilan_No, Isyeri_Grubu,  m2ORacik, Durumu, Bina_Yasi, Krediye_Uygun) values (@ilanno, @tipi,@buyukluk,@durumu, @binayas, @kredi)"
                SQL_Komut.Parameters.AddWithValue("@kredi", isyeri.krediyeUygun)
                SQL_Komut.Parameters.AddWithValue("@durumu", isyeri.Durum)
                SQL_Komut.Parameters.AddWithValue("@binayas", isyeri.BinaYasi)
                Ac_IslemYap_Kapat()
                SporVSParam(isyeri)
                SQL_Komut.CommandText = "insert into SporRadyoPazarCiftlik(Isyeri_ID, Isyeri_Tipi, SporTesis_Tipi, Kullanim_Durumu) values(@yerid, @tip,@sportipi, @kullanim)"
                SQL_Komut.Parameters.Add(New SqlParameter("@kullanim", SqlDbType.Bit)).Value = isyeri.KullanimDurumu
                SQL_Komut.Parameters.AddWithValue("@sportipi", isyeri.SporTesisTipi)
                Ac_IslemYap_Kapat()
        End Select
    End Sub
    Public Function EmlakSahibiEkle(sahip As EmlakSahibi) As Integer
        If Not SahipVarMi(sahip) Then
            If sahip.CepTel <> Nothing AndAlso sahip.EvTel <> Nothing Then : SQL_Komut.CommandText = "Insert Into Ilan_Sahipleri values ('" & sahip.Isim & "','" & sahip.CepTel & "','" & sahip.EvTel & "','" & sahip.Email & "')"
            ElseIf sahip.EvTel <> Nothing Then : SQL_Komut.CommandText = "Insert Into Ilan_Sahipleri(Sahip_Adi,Sahip_Ev_Tel,Sahip_Email) values ('" & sahip.Isim & "','" & sahip.EvTel & "','" & sahip.Email & "')"
            ElseIf sahip.CepTel <> Nothing Then : SQL_Komut.CommandText = "Insert Into Ilan_Sahipleri(Sahip_Adi,Sahip_Cep_Tel,Sahip_Email) values ('" & sahip.Isim & "','" & sahip.CepTel & "','" & sahip.Email & "')"
            Else : SQL_Komut.CommandText = "Insert Into Ilan_Sahipleri(Sahip_Adi,Sahip_Email) values ('" & sahip.Isim & "','" & sahip.Email & "')"
            End If
            Ac_IslemYap_Kapat()
        End If
        SQL_Komut.CommandText = "Select Sahip_ID From Ilan_Sahipleri where Sahip_Email = '" & sahip.Email & "'"
        Dim oku As SqlClient.SqlDataReader
        Dim Sahip_ID As Integer = -1
        SQL_Baglanti.Open()
        oku = SQL_Komut.ExecuteReader
        If oku.Read() Then Sahip_ID = oku.GetInt32(0)
        oku.Close()
        SQL_Baglanti.Close()
        Return Sahip_ID
    End Function
    Public Sub EmlakEkle(emlak As Emlak, sahip As EmlakSahibi)
        emlak.ilanVerenID = EmlakSahibiEkle(sahip)
        SQL_Komut.CommandText = "Insert Into Emlak values (@ilanno, @ilanaciklama,@ilanbaslik, @ilanTarihi, @ilanVeren, @ilanTur,@ilanSatis, @resim1,@resim2,@resim3,@resim4,@resim5,@resim6,@resim7,@resim8, @video, @ilanMahalle,@ilanAdres,@ilanFiyat,@ilanIslemTamam)"
        With SQL_Komut.Parameters
            .AddWithValue("@ilanno", emlak.ilanNo)
            .AddWithValue("@ilanaciklama", emlak.ilanAciklama)
            .AddWithValue("@ilanbaslik", emlak.ilanBaslik)
            .AddWithValue("@ilanVeren", emlak.ilanVerenID)
            .AddWithValue("@ilanTur", emlak.ilanTurID)
            .AddWithValue("@ilanSatis", emlak.ilanSatisID)
            .AddWithValue("@ilanMahalle", emlak.mahalle)
            .AddWithValue("@ilanAdres", emlak.ilanAdres)
            .AddWithValue("@ilanFiyat", emlak.fiyat)
            .AddWithValue("@ilanIslemTamam", emlak.islemTamam)
            .AddWithValue("@ilanTarihi", emlak.ilanTarihi)
            .Add(New SqlParameter("@resim1", SqlDbType.Image)).Value = ResimParametre(emlak.foto1)
            .Add(New SqlParameter("@resim2", SqlDbType.Image)).Value = ResimParametre(emlak.foto2)
            .Add(New SqlParameter("@resim3", SqlDbType.Image)).Value = ResimParametre(emlak.foto3)
            .Add(New SqlParameter("@resim4", SqlDbType.Image)).Value = ResimParametre(emlak.foto4)
            .Add(New SqlParameter("@resim5", SqlDbType.Image)).Value = ResimParametre(emlak.foto5)
            .Add(New SqlParameter("@resim6", SqlDbType.Image)).Value = ResimParametre(emlak.foto6)
            .Add(New SqlParameter("@resim7", SqlDbType.Image)).Value = ResimParametre(emlak.foto7)
            .Add(New SqlParameter("@resim8", SqlDbType.Image)).Value = ResimParametre(emlak.foto8)
            If Not emlak.myVideo Is Nothing Then
                .Add(New SqlParameter("@video", SqlDbType.NVarChar)).Value = emlak.myVideo
            Else
                .Add(New SqlParameter("@video", SqlDbType.NVarChar)).Value = DBNull.Value
            End If
        End With
        Try
            Ac_IslemYap_Kapat()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function isyeriID(ilanno As String) As Integer
        SQL_Komut.CommandText = "select ID from isyerleri where ilan_No = '" & ilanno & "'"
        Dim oku As SqlDataReader
        Dim ID As Integer
        SQL_Baglanti.Open()
        oku = SQL_Komut.ExecuteReader
        If oku.Read() Then ID = oku.GetInt32(0)
        oku.Close()
        SQL_Baglanti.Close()
        SQL_Komut.Parameters.Clear()
        Return ID
    End Function
    Private Sub BufeVSParam(isyeri As BufeDugunSpaSineOto)
        SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(isyeri.ilanNo))
        SQL_Komut.Parameters.AddWithValue("@tip", isyeri.isyeriTipi)
        SQL_Komut.Parameters.AddWithValue("@depozito", isyeri.depozitosu)
    End Sub
    Private Sub DepoVSParam(isyeri As DepoBinaPlazaFabrika)
        SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(isyeri.ilanNo))
        SQL_Komut.Parameters.AddWithValue("@tip", isyeri.isyeriTipi)
        SQL_Komut.Parameters.AddWithValue("@tapu", isyeri.TapuDurumu)
        SQL_Komut.Parameters.Add(New SqlParameter("@zemin", SqlDbType.Bit)).Value = isyeri.ZeminEtudu
        SQL_Komut.Parameters.Add(New SqlParameter("@kullanim", SqlDbType.Bit)).Value = isyeri.KullanimDurumu
    End Sub
    Private Sub SporVSParam(isyeri As SporRadyoPazarCiftlik)
        SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(isyeri.ilanNo))
        SQL_Komut.Parameters.AddWithValue("@tip", isyeri.IsyeriTipi)
    End Sub

#End Region

#Region "Diger"
    Public Sub IlanSahipleriniOku(cbx As ComboBox)
        cbx.Items.Clear()
        SQL_Komut.CommandText = "Select Sahip_Adi isim From Ilan_Sahipleri order by Sahip_ID"
        SQL_Baglanti.Open()
        Dim oku As SqlClient.SqlDataReader = SQL_Komut.ExecuteReader()
        While (oku.Read())
            cbx.Items.Add(oku.GetString(0).Replace(",", " "))
        End While
        SQL_Baglanti.Close()
    End Sub
    Public Sub Tablo_Veri_Doldur(Tablo_Adi As String, ByRef Dizi() As String)
        SQL_Komut.CommandText = "Select * From " & Tablo_Adi
        Dim indis As Integer = 0
        SQL_Baglanti.Open()
        Dim oku As SqlClient.SqlDataReader = SQL_Komut.ExecuteReader()
        While (oku.Read())
            Dizi(indis) = oku.GetString(1)
            indis += 1
        End While
        SQL_Baglanti.Close()
    End Sub ' Sabit toblaların idlerinie karşılık gelen kısımı bir dizi içerisine doldurur
    Public Sub Tablo_Veri_Doldur(Tablo_Adi As String, cbx As ComboBox)
        cbx.Items.Clear()
        SQL_Komut.CommandText = "Select * From " & Tablo_Adi
        SQL_Baglanti.Open()
        Dim oku As SqlClient.SqlDataReader = SQL_Komut.ExecuteReader()
        While (oku.Read())
            cbx.Items.Add(oku.GetString(1))
        End While
        SQL_Baglanti.Close()
    End Sub ' Sabit toblaların idlerinie karşılık gelen kısımı bir combobox içerisine doldurur
    Public Sub ilce_Doldur(ByRef ilceler(,) As String, indis As UShort)
        Dim sayac As Integer = 0
        SQL_Komut.CommandText = "Select * From Ilceler where SehirId = '" & indis.ToString() & "' order by ilceAdi"
        SQL_Baglanti.Open()
        Dim oku As SqlClient.SqlDataReader = SQL_Komut.ExecuteReader()
        While (oku.Read())
            ilceler(sayac, 0) = oku.GetValue(0)
            ilceler(sayac, 1) = oku.GetString(2)
            sayac += 1
        End While
        oku.Close()
        SQL_Baglanti.Close()
    End Sub ' Gonderilen indise karşılık gelen şehirin ilçelerini combobox'a doldurur
    Public Sub semtMah_Doldur(cbx As ComboBox, ilceID As String)
        SQL_Baglanti.Open()
        Dim oku As SqlClient.SqlDataReader
        SQL_Komut.CommandText = "Select MahalleAdi from SemtMah where ilceId = '" & ilceID & "' order by MahalleAdi"
        oku = SQL_Komut.ExecuteReader
        While oku.Read()
            cbx.Items.Add(oku.GetString(0))
        End While ' o ilçeye ait mahalleler combobox'a aktarılır
        oku.Close()
        SQL_Baglanti.Close()
    End Sub
    Public Function EmlakSayisi(Tablo_Adi As String) As Integer
        Dim adet As Integer = 0        '
        SQL_Komut.CommandText = "Select Count(ID) From " & Tablo_Adi
        SQL_Baglanti.Open()
        Dim oku As SqlClient.SqlDataReader = SQL_Komut.ExecuteReader()
        While oku.Read()
            adet = oku.GetValue(0)
        End While
        SQL_Baglanti.Close()
        Return adet
    End Function
    Public Function SahipVarMi(AlanAdi As String, veri As String) As Boolean
        Dim sda As New SqlDataAdapter()
        SQL_Komut.CommandText = "select * from Ilan_Sahipleri where " & AlanAdi & " = '" & veri & "' COLLATE Latin1_General_CS_AS"
        sda.SelectCommand = SQL_Komut
        Dim dt As New DataTable
        sda.Fill(dt)
        If dt.Rows.Count >= 1 Then Return True
        Return False
    End Function
    Public Function SahipVarMi(sahip As EmlakSahibi)
        Dim sda As New SqlDataAdapter()
        SQL_Komut.CommandText = "select * from Ilan_Sahipleri where Sahip_Email = '" & sahip.Email & "' COLLATE Latin1_General_CS_AS and Sahip_Adi = '" & sahip.Isim & "' and Sahip_Cep_Tel = '" & sahip.CepTel & "' and Sahip_Ev_Tel = '" & sahip.EvTel & "'"
        sda.SelectCommand = SQL_Komut
        Dim dt As New DataTable
        sda.Fill(dt)
        If dt.Rows.Count >= 1 Then Return True
        Return False
    End Function
    Private Function ResimParametre(ByVal pic() As Byte)
        If pic Is Nothing Then Return DBNull.Value Else Return pic
    End Function
    Public Function mahalleIdBul(ByVal mahalle As String, ByVal sehir As String) As Integer
        If mahalle.EndsWith("Mah") = True Then mahalle += "."
        Dim id As Integer
        SQL_Komut.CommandText = "select SemtMahId from SemtMah where mahalleadi = N'" & mahalle & "' And ilceId in (select ilceId from Ilceler where SehirId in (select SehirId from Sehirler where SehirAdi = N'" & sehir & "' ))"
        SQL_Baglanti.Open()
        Dim oku As SqlClient.SqlDataReader = SQL_Komut.ExecuteReader()
        While (oku.Read())
            id = oku.GetInt32(0)
        End While
        SQL_Baglanti.Close()
        Return id
    End Function
    Public Sub EmlakSil(ByVal ilanNo As String)
        SQL_Komut.CommandText = "delete from emlak where ilan_No = @ilanno"
        SQL_Komut.Parameters.AddWithValue("ilanno", ilanNo)
        Ac_IslemYap_Kapat()
        MsgBox("Silme işlemi başarıyla gerçekleşti", MsgBoxStyle.Information, "Bilgilendirme")
    End Sub
    'Public Sub EmlakSil(ByVal emlak As Emlak)
    '    SQL_Komut.CommandText = "delete from emlak where ilan_No = @ilanno"
    '    SQL_Komut.Parameters.AddWithValue("ilanno", emlak.ilanNo)
    '    Ac_IslemYap_Kapat()
    '    MsgBox("Silme işlemi başarıyla gerçekleşti", MsgBoxStyle.Information, "Bilgilendirme")
    'End Sub
    Public Sub KategoriEkle(TabloAdi As String, eklenecekVeri As String)
        SQL_Komut.CommandText = "Insert Into " & TabloAdi & " values (@deger)"
        SQL_Komut.Parameters.AddWithValue("@deger", eklenecekVeri)
        Ac_IslemYap_Kapat()
    End Sub
    Public Function sahipIDGetir(email As String) As Integer
        Dim id As Integer = 0
        SQL_Komut.CommandText = "select Sahip_ID from Ilan_Sahipleri where Sahip_Email=@mail"
        SQL_Komut.Parameters.AddWithValue("@mail", email)
        SQL_Baglanti.Open()
        Dim oku As SqlDataReader = SQL_Komut.ExecuteReader
        If oku.Read Then id = oku.GetValue(0)
        oku.Close()
        SQL_Baglanti.Close()
        Return id
    End Function
    Public Function IsyeriTuru(ilanNo As String) As Byte
        Dim TurNo As Byte
        SQL_Komut.CommandText = "Select I.Isyeri_Grubu from Isyerleri I, Emlak E where I.ilan_No = '" & ilanNo & "'"
        SQL_Baglanti.Open()
        Dim oku As SqlDataReader = SQL_Komut.ExecuteReader
        If oku.Read Then TurNo = oku.GetValue(0)
        SQL_Baglanti.Close()
        SQL_Komut.Parameters.Clear()
        Return TurNo
    End Function
    Public Function BulundugKatString(id As Integer) As String
        Dim str As String = Nothing
        SQL_Komut.CommandText = "Select * from Bulundugu_Kat where Bulundugu_Kat_ID = " & id
        SQL_Baglanti.Open()
        Dim oku As SqlDataReader = SQL_Komut.ExecuteReader
        If oku.Read Then str = oku.GetValue(1)
        oku.Close()
        SQL_Baglanti.Close()
        Return str
    End Function
    Public Function IsitmaString(id As Integer) As String
        Dim str As String = Nothing
        SQL_Komut.CommandText = "Select * from Isitma where Isitma_ID = " & id
        SQL_Baglanti.Open()
        Dim oku As SqlDataReader = SQL_Komut.ExecuteReader
        If oku.Read Then str = oku.GetValue(1)
        oku.Close()
        SQL_Baglanti.Close()
        Return str
    End Function
    Public Sub SatYadaKirala(ilanNo As String)
        SQL_Komut.CommandText = "Update Emlak set islem_Tamam_mi='true' where ilan_No = '" & ilanNo & "'"
        Ac_IslemYap_Kapat()
    End Sub
#End Region

#Region "Emlak Guncelleme"
    Public Sub KonutGuncelle(konut As Konut, ID As String)
        EmlakDuzenle(konut, ID)
        If konut.AcikAlanBuyuklugu <> Nothing Then
            SQL_Komut.CommandText = "Update Konut set Buyukluk = " & konut.Buyukluk & ", Bina_Yasi = " & konut.BinaYasi & ", Acik_Alan_Buyuklugu = " & konut.AcikAlanBuyuklugu & " Oda_Sayisi_ID = " & konut.OdaSayisiID & ", Bulundugu_Kat_ID = " & konut.BulunduguKatID & ", Kat_Sayisi = " & konut.KatSayisi & ", Isitma_ID = " & konut.IsitmaID & ", Banyo_Sayisi = " & konut.BanyoSayisi & ", Esyali = '" & konut.Esyali & "',Kullanim_Durumu = '" & konut.KullanimDurumu & "', Site_Icerisinde = '" & konut.SiteIcerisinde & "', Aidat = '" & konut.Aidat & "', Krediye_Uygun = '" & konut.KrediyeUygun & "', Takasli = '" & konut.Takas & "' where ilan_No = '" & ID & "'"
        Else
            SQL_Komut.CommandText = "Update Konut set Buyukluk = " & konut.Buyukluk & ", Bina_Yasi = " & konut.BinaYasi & ", Oda_Sayisi_ID = " & konut.OdaSayisiID & ", Bulundugu_Kat_ID = " & konut.BulunduguKatID & ", Kat_Sayisi = " & konut.KatSayisi & ", Isitma_ID = " & konut.IsitmaID & ", Banyo_Sayisi = '" & konut.BanyoSayisi & "', Esyali = '" & konut.Esyali & "',Kullanim_Durumu = '" & konut.KullanimDurumu & "', Site_Icerisinde = '" & konut.SiteIcerisinde & "', Aidat = '" & konut.Aidat & "', Krediye_Uygun = '" & konut.KrediyeUygun & "', Takasli = '" & konut.Takas & "' where ilan_No = '" & ID & "'"
        End If
        Ac_IslemYap_Kapat()
    End Sub
    Public Sub ArsaGuncelle(arsa As Arsa, ID As String)
        EmlakDuzenle(arsa, ID)
        Dim komutText As String = "Update Arsa set imar_Durumu_ID = " & arsa.imarDurumuID & ",Buyukluk = " & arsa.Buyukluk & ""
        If arsa.AdaNo <> -1 Then : komutText += ",Ada_No = " & arsa.AdaNo & ""
        End If
        If arsa.ParselNo <> -1 Then : komutText += ",Parsel_No = " & arsa.ParselNo & ""
        End If
        If arsa.PaftaNo <> -1 Then : komutText += ",Pafta_No = " & arsa.PaftaNo & ""
        End If
        If arsa.KaksID <> 255 Then : komutText += ",Kaks = " & arsa.KaksID & ""
        End If
        If arsa.GabariID <> 255 Then : komutText += ",Gabari = " & arsa.GabariID & ""
        End If
        If arsa.TapuDurumuID <> 255 Then : komutText += ",Tapu_Durumu = " & arsa.TapuDurumuID & ""
        End If
        komutText += ",Krediye_Uygun = '" & arsa.Kredi & "',Takasli = '" & arsa.Takas & "' ,Kat_Karsiligi = '" & arsa.KatKarsiligi & "' where ilan_No = '" & ID & "'"
        SQL_Komut.CommandText = komutText
        Ac_IslemYap_Kapat()
    End Sub
    Public Sub BinaGuncelle(bina As Bina, ID As String)
        EmlakDuzenle(bina, ID)
        SQL_Komut.CommandText = "Update Bina set Kat_Sayisi =  " & bina.KatSayisi & ", Bir_Kattaki_Daire_Sayisi = " & bina.BirKattakiDaireSayisi & ", Isitma = " & bina.IsitmaID & ", Buyukluk = " & bina.Buyukluk & ", Bina_Yasi = " & bina.BinaYasi & ", Krediye_Uygun = '" & bina.KrediyeUygun & "', Takasli = '" & bina.Takas & "' where ilan_No = '" & ID & "'"
        Ac_IslemYap_Kapat()
    End Sub
    Public Sub TT_Guncelle(tt As Turistik_Tesis, ID As String)
        EmlakDuzenle(tt, ID)
        Dim komutText As String = "Update Turistik_Tesis set TT_Tipi = " & tt.TipID & ""
        If tt.OtelYildizSayisi <> 255 Then : komutText += ",Otel_Yildiz_Sayisi = " & tt.OtelYildizSayisi & ""
        End If
        If tt.ApartSayisi <> -1 Then : komutText += ",Apart_Otel_Apart_Sayisi = " & tt.ApartSayisi & ""
        End If
        If tt.OdaSayisi <> -1 Then : komutText += ",Oda_Sayisi = " & tt.OdaSayisi & ""
        End If
        If tt.YatakSayisi <> -1 Then : komutText += ",yatak_Sayisi = " & tt.YatakSayisi & ""
        End If
        If tt.KatSayisi <> 255 Then : komutText += ",kat_Sayisi = " & tt.KatSayisi & ""
        End If
        If tt.BinaYasi <> 255 Then : komutText += ",Bina_Yasi = " & tt.BinaYasi & ""
        End If
        If tt.AcikAlan <> -1 Then : komutText += ",Acik_Alan = " & tt.AcikAlan & ""
        End If
        If tt.KapaliAlan <> -1 Then : komutText += ",Kapali_Alan = " & tt.KapaliAlan & ""
        End If
        If tt.ZeminEtudu.HasValue Then : komutText += ",Zemin_Etudu = '" & tt.ZeminEtudu & "'"
        End If
        If tt.YapiDurumu.HasValue Then : komutText += ",Yapi_Durumu = '" & tt.YapiDurumu & "'"
        End If
        If tt.KrediyeUygun.HasValue Then : komutText += ",Krediye_Uygun = '" & tt.KrediyeUygun & "'"
        End If
        komutText += " where ilan_NO = '" & ID & "'"
        SQL_Komut.CommandText = komutText
        Ac_IslemYap_Kapat()
    End Sub
    Public Sub EmlakDuzenle(emlak As Emlak, ID As String)
        SQL_Komut.CommandText = "update Emlak set ilan_Aciklama = @ilanaciklama, Ilan_Baslik = @ilanbaslik,ilan_Resim1 = @resim1, ilan_Resim2 = @resim2, ilan_Resim3 = @resim3, ilan_Resim4 = @resim4, ilan_Resim5 = @resim5,ilan_Resim6 = @resim6, ilan_Resim7 = @resim7, ilan_Resim8 = @resim8, ilan_Video = @video, Mahalle = @ilanMahalle, Adres = @ilanAdres, Fiyat = @ilanFiyat, islem_Tamam_mi = @ilanIslemTamam where ilan_No = @ilanno"
        With SQL_Komut.Parameters
            .AddWithValue("@ilanno", ID)
            .AddWithValue("@ilanaciklama", emlak.ilanAciklama)
            .AddWithValue("@ilanbaslik", emlak.ilanBaslik)
            .AddWithValue("@ilanSatis", emlak.ilanSatisID)
            .AddWithValue("@ilanMahalle", emlak.mahalle)
            .AddWithValue("@ilanAdres", emlak.ilanAdres)
            .AddWithValue("@ilanFiyat", emlak.fiyat)
            .AddWithValue("@ilanIslemTamam", emlak.islemTamam)
            .Add(New SqlParameter("@resim1", SqlDbType.Image)).Value = ResimParametre(emlak.foto1)
            .Add(New SqlParameter("@resim2", SqlDbType.Image)).Value = ResimParametre(emlak.foto2)
            .Add(New SqlParameter("@resim3", SqlDbType.Image)).Value = ResimParametre(emlak.foto3)
            .Add(New SqlParameter("@resim4", SqlDbType.Image)).Value = ResimParametre(emlak.foto4)
            .Add(New SqlParameter("@resim5", SqlDbType.Image)).Value = ResimParametre(emlak.foto5)
            .Add(New SqlParameter("@resim6", SqlDbType.Image)).Value = ResimParametre(emlak.foto6)
            .Add(New SqlParameter("@resim7", SqlDbType.Image)).Value = ResimParametre(emlak.foto7)
            .Add(New SqlParameter("@resim8", SqlDbType.Image)).Value = ResimParametre(emlak.foto8)
            If Not emlak.myVideo Is Nothing Then
                .Add(New SqlParameter("@video", SqlDbType.NVarChar)).Value = emlak.myVideo
            Else
                .Add(New SqlParameter("@video", SqlDbType.NVarChar)).Value = DBNull.Value
            End If
        End With
        Try
            Ac_IslemYap_Kapat()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub EmlakSahibiGuncelle(sahip As EmlakSahibi)
        SQL_Komut.CommandText = "Update Ilan_Sahipleri set Sahip_Adi=@ad,Sahip_Cep_Tel=@cep,Sahip_Ev_Tel=@ev,Sahip_Email=@email where Sahip_ID =@id"
        SQL_Komut.Parameters.AddWithValue("@ad", sahip.Isim)
        SQL_Komut.Parameters.AddWithValue("@cep", sahip.CepTel)
        SQL_Komut.Parameters.AddWithValue("@ev", sahip.EvTel)
        SQL_Komut.Parameters.AddWithValue("@email", sahip.Email)
        SQL_Komut.Parameters.AddWithValue("@id", sahip.ID)
        Ac_IslemYap_Kapat()
    End Sub
    Public Sub AtölyeBuroDukkanAVMİmalathaneGuncelle(isyeri As AtolyeBuroDukkanImaAVM, ID As String)
        EmlakDuzenle(isyeri, ID)
        If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "Update Isyerleri Set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durum, m2ORacik = @buyukluk, Takasli = @takasli , Krediye_Uygun = @kredi where ilan_No = @ID"
        Else : SQL_Komut.CommandText = "Update Isyerleri Set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durum, m2ORacik = @buyukluk, Takasli = @takasli where ilan_No = @ID"
        End If
        With SQL_Komut.Parameters
            .AddWithValue("@ID", ID)
            .AddWithValue("@binayas", isyeri.BinaYasi)
            .AddWithValue("@isitma", isyeri.IsitmaID)
            .AddWithValue("@durum", isyeri.Durum)
            .AddWithValue("@buyukluk", isyeri.Buyukluk)
            .AddWithValue("@takasli", isyeri.Takas)
            .AddWithValue("@kredi", isyeri.krediyeUygun)
        End With
        Ac_IslemYap_Kapat()
        SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID))
        SQL_Komut.Parameters.AddWithValue("@tip", isyeri.isyeriTipi)
        SQL_Komut.Parameters.AddWithValue("@depozito", isyeri.depozitosu)
        Select Case isyeri.isyeriTipi
            Case 1 'AVM
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update AtolyeBuroDukkanImaAVM set Isyeri_Tipi = @tip, kat_Sayisi = @katsayisi, Asansor_Sayisi = @asansor where Isyeri_ID = @yerid"
                Else : SQL_Komut.CommandText = "update AtolyeBuroDukkanImaAVM set Isyeri_Tipi = @tip, kat_Sayisi = @katsayisi, Asansor_Sayisi = @asansor,depozito = @depozito where Isyeri_ID = @yerid"
                End If
                With SQL_Komut.Parameters
                    .AddWithValue("@katsayisi", isyeri.katSayisi)
                    .AddWithValue("@asansor", isyeri.asansorSayisi)
                End With
            Case 0, 3, 7 'Atölye, Büro, Dükkan
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update AtolyeBuroDukkanImaAVM set Isyeri_Tipi = @tip,aidat = @aidat,oda_bolum_sayisi = @odabolum where Isyeri_ID = @yerid"
                Else : SQL_Komut.CommandText = "update AtolyeBuroDukkanImaAVM set Isyeri_Tipi = @tip,aidat = @aidat,oda_bolum_sayisi = @odabolum, depozito = @depozito where Isyeri_ID = @yerid"
                End If
                With SQL_Komut.Parameters
                    .AddWithValue("@aidat", isyeri.aidati)
                    .AddWithValue("@odabolum", isyeri.odaBolumSayisi)
                End With
            Case 9 'Imalathane
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "Update AtolyeBuroDukkanImaAVM set Isyeri_Tipi = @tip,oda_bolum_sayisi = @odabolum where Isyeri_ID = @yerid"
                Else : SQL_Komut.CommandText = "Update AtolyeBuroDukkanImaAVM set Isyeri_Tipi = @tip,oda_bolum_sayisi = @odabolum, depozito = @depozito where Isyeri_ID = @yerid"
                End If
                SQL_Komut.Parameters.AddWithValue("@odabolum", isyeri.odaBolumSayisi)
        End Select
        Ac_IslemYap_Kapat()
    End Sub
    Public Sub BufeDugunSinSpaOtoGuncelle(isyeri As BufeDugunSpaSineOto, ID As String)
        EmlakDuzenle(isyeri, ID)
        With SQL_Komut.Parameters
            .AddWithValue("@ilanno", ID)
            .AddWithValue("@binayas", isyeri.BinaYasi)
            .AddWithValue("@durumu", isyeri.Durum)
            .AddWithValue("@buyukluk", isyeri.Buyukluk)
            .AddWithValue("@kredi", isyeri.krediyeUygun)
        End With
        Select Case isyeri.isyeriTipi
            Case 2 'Bufe
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update Isyerleri set Durumu = @durumu, m2ORacik = @buyukluk, Krediye_Uygun = @kredi where ilan_No = @ilanno"
                Else : SQL_Komut.CommandText = "update Isyerleri set Durumu = @durumu, m2ORacik = @buyukluk where ilan_No = @ilanno"
                End If
                Ac_IslemYap_Kapat()
                BufeVSParam(isyeri)
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID)) 'yanlis id gelmesin
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update bufedugunspasineoto set Yapi_Tipi = @yapi, Kullanim_Durumu = @kullanim where Isyeri_ID = @yerid"
                Else : SQL_Komut.CommandText = "update bufedugunspasineoto set Yapi_Tipi = @yapi, Kullanim_Durumu = @kullanim, Depozito = @depozito where Isyeri_ID = @yerid"
                End If
                SQL_Komut.Parameters.AddWithValue("@yapi", isyeri.YapiTipi)
                SQL_Komut.Parameters.AddWithValue("@kullanim", isyeri.kullanimDurumu)
                Ac_IslemYap_Kapat()
            Case 16 'Spa
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "Update Isyerleri set Bina_Yasi = @binayas,Durumu = @durumu, m2ORacik = @buyukluk, Krediye_Uygun = @kredi where ilan_No = @ilanno"
                Else : SQL_Komut.CommandText = "Update Isyerleri set Bina_Yasi = @binayas,Durumu = @durumu, m2ORacik = @buyukluk where ilan_No = @ilanno"
                End If
                Ac_IslemYap_Kapat()
                BufeVSParam(isyeri)
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID))
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update bufedugunspasineoto set Kullanim_Durumu = @kullanim,Cinsiyet = @cinsiyet,Kisi_kapasitesi = @kisi,Oda_bolum_Sayisi = @odabolum where Isyeri_ID = @yerid"
                Else : SQL_Komut.CommandText = "update bufedugunspasineoto set Kullanim_Durumu = @kullanim,Cinsiyet = @cinsiyet,Kisi_kapasitesi = @kisi,Oda_bolum_Sayisi = @odabolum,Depozito = @depozito where Isyeri_ID = @yerid"
                End If
                With SQL_Komut.Parameters
                    .AddWithValue("@cinsiyet", isyeri.cinsiyeti)
                    .AddWithValue("@kisi", isyeri.kisiKapasitesi)
                    .AddWithValue("@kullanim", isyeri.kullanimDurumu)
                    .AddWithValue("@odabolum", isyeri.odaBolumSayisi)
                End With
                Ac_IslemYap_Kapat()
            Case 15 'Sinema
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "Update Isyerleri set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durum, m2ORacik = @buyukluk, Takasli = @takas, Krediye_Uygun = @kredi where ilan_No = @ilanno"
                Else : SQL_Komut.CommandText = "Update Isyerleri set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durum, m2ORacik = @buyukluk, Takasli = @takas where ilan_No = @ilanno"
                End If
                SQL_Komut.Parameters.AddWithValue("@takas", isyeri.tavanYukseklik)
                SQL_Komut.Parameters.AddWithValue("@isitma", isyeri.IsitmaID)
                Ac_IslemYap_Kapat()
                BufeVSParam(isyeri)
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID))
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update bufedugunspasineoto set Kullanim_Durumu = @kullanim,Tavan_Yuksekligi = @TavanYusekligi, Kat_Sayisi = @katSayisi, Bulundugu_Kat = @kat,Kisi_kapasitesi = @kisi,Oda_bolum_Sayisi = @odabolum where Isyeri_ID = @yerid"
                Else : SQL_Komut.CommandText = "update bufedugunspasineoto set Kullanim_Durumu = @kullanim,Tavan_Yuksekligi = @TavanYusekligi, Kat_Sayisi = @katSayisi, Bulundugu_Kat = @kat,Kisi_kapasitesi = @kisi,Oda_bolum_Sayisi = @odabolum ,Depozito = @depozito where Isyeri_ID = @yerid"
                End If
                With SQL_Komut.Parameters
                    .AddWithValue("@kisi", isyeri.kisiKapasitesi)
                    .AddWithValue("@kullanim", isyeri.kullanimDurumu)
                    .AddWithValue("@odabolum", isyeri.odaBolumSayisi)
                    .AddWithValue("@Tavanyuksekligi", isyeri.tavanYukseklik)
                    .AddWithValue("@KatSayisi", isyeri.katSayisi)
                    .AddWithValue("@kat", isyeri.bulunduguKat)
                End With
                Ac_IslemYap_Kapat()
            Case 11 'Otopark
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update Isyerleri set Bina_Yasi = @binayas, m2ORacik = @buyukluk, Krediye_Uygun = @kredi where ilan_No = @ilanno"
                Else : SQL_Komut.CommandText = "update Isyerleri set Bina_Yasi = @binayas, m2ORacik = @buyukluk where ilan_No = @ilanno"
                End If
                Ac_IslemYap_Kapat()
                BufeVSParam(isyeri)
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID))
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update bufedugunspasineoto set Kat_Sayisi = @katSayisi, Arac_Sayisi = @aracSayisi, Otopark_Turu = @otoparkTur where Isyeri_ID = @yerid"
                Else : SQL_Komut.CommandText = "update bufedugunspasineoto set Kat_Sayisi = @katSayisi, Arac_Sayisi = @aracSayisi, Otopark_Turu = @otoparkTur,Depozito = @depozito where Isyeri_ID = @yerid"
                End If
                SQL_Komut.Parameters.AddWithValue("@KatSayisi", isyeri.katSayisi)
                SQL_Komut.Parameters.AddWithValue("@aracSayisi", isyeri.aracSayisi)
                SQL_Komut.Parameters.AddWithValue("@otoparkTur", isyeri.otoparkTuru)
                Ac_IslemYap_Kapat()
            Case 6 'Dugun Salonu
                SQL_Komut.CommandText = "update Isyerleri set Bina_Yasi = @binayas, m2ORacik = @buyukluk where ilan_No = '" & ID & "'"
                Ac_IslemYap_Kapat()
                SQL_Komut.CommandText = "update set bufedugunspasineoto set Masa_Sayisi = @masaSayisi, Kisi_kapasitesi = @kisiSayisi where Isyeri_ID = @yerid"
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID))
                SQL_Komut.Parameters.AddWithValue("@masaSayisi", isyeri.masaSayisi)
                SQL_Komut.Parameters.AddWithValue("@kisiSayisi", isyeri.kisiKapasitesi)
                Ac_IslemYap_Kapat()
        End Select
    End Sub
    Public Sub DepoBinaPlazaFabrikaGuncelle(isyeri As DepoBinaPlazaFabrika, ID As String)
        EmlakDuzenle(isyeri, ID)
        With SQL_Komut.Parameters
            .AddWithValue("@ilanno", ID)
            .AddWithValue("@binayas", isyeri.BinaYasi)
            .AddWithValue("@isitma", isyeri.IsitmaID)
            .AddWithValue("@durumu", isyeri.Durum)
            .AddWithValue("@buyukluk", isyeri.Buyukluk)
            .AddWithValue("@takasli", isyeri.Takas)
            .AddWithValue("@kredi", isyeri.krediyeUygun)
        End With
        Select Case isyeri.isyeriTipi
            Case 8 'Fabrika
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update Isyerleri set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durumu, m2ORacik = @buyukluk, Takasli = @takasli, Krediye_Uygun = @kredi where ilan_No = @ilanno"
                Else : SQL_Komut.CommandText = "update Isyerleri set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durumu, m2ORacik = @buyukluk, Takasli = @takasli where ilan_No = @ilanno"
                End If
                Ac_IslemYap_Kapat()
                DepoVSParam(isyeri)
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID)) 'yanlis id gelmesin
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update DepoBinaPlazaFabrika set Kapali_Alan = @kapalialan, Bina_Adedi = @binaadet, Giris_yukseklik = @girisyukseklik, Oda_Bolum_Sayisi = @odabolum, Kat_Sayisi = @katSayisi, Zemin_Etudu = @zemin,Kullanim_Durumu = @kullanim, Tapu_Durumu = @tapu where Isyeri_ID = @yerid"
                Else : SQL_Komut.CommandText = "update DepoBinaPlazaFabrika set Kapali_Alan = @kapalialan, Bina_Adedi = @binaadet, Giris_yukseklik = @girisyukseklik, Oda_Bolum_Sayisi = @odabolum, Kat_Sayisi = @katSayisi, Zemin_Etudu = @zemin,Kullanim_Durumu = @kullanim, Tapu_Durumu = @tapu, Depozito = @depozito where Isyeri_ID = @yerid"
                End If
                SQL_Komut.Parameters.AddWithValue("@kapalialan", isyeri.KapaliAlan)
                SQL_Komut.Parameters.AddWithValue("@binaadet", isyeri.BinaAdedi)
                SQL_Komut.Parameters.AddWithValue("@girisyukseklik", isyeri.GirisYukseklik)
                SQL_Komut.Parameters.AddWithValue("@odabolum", isyeri.odaBolumSayisi)
                SQL_Komut.Parameters.AddWithValue("@katSayisi", isyeri.KatSayisi)
                SQL_Komut.Parameters.AddWithValue("@depozito", isyeri.depozitosu)
                SQL_Komut.Parameters.AddWithValue("@zemin", isyeri.ZeminEtudu)
                SQL_Komut.Parameters.AddWithValue("@kullanim", isyeri.KullanimDurumu)
                SQL_Komut.Parameters.AddWithValue("@tapu", isyeri.TapuDurumu)
                Ac_IslemYap_Kapat()
            Case 5 'Depo
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update Isyerleri set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durumu, m2ORacik = @buyukluk, Takasli = @takasli, Krediye_Uygun = @kredi where ilan_No = @ilanno"
                Else : SQL_Komut.CommandText = "update Isyerleri set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durumu, m2ORacik = @buyukluk, Takasli = @takasli where ilan_No = @ilanno"
                End If
                Ac_IslemYap_Kapat()
                DepoVSParam(isyeri)
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID))
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update DepoBinaPlazaFabrika set Giris_yukseklik = @girisyukseklik, Zemin_Etudu = @zemin, Kullanim_Durumu = @kullanim, Tapu_Durumu = @tapu where Isyeri_ID = @yerid"
                Else : SQL_Komut.CommandText = "update DepoBinaPlazaFabrika set Giris_yukseklik = @girisyukseklik, Zemin_Etudu = @zemin, Kullanim_Durumu = @kullanim, Tapu_Durumu = @tapu, Depozito = @depozito where Isyeri_ID = @yerid"
                End If
                SQL_Komut.Parameters.AddWithValue("@depozito", isyeri.depozitosu)
                SQL_Komut.Parameters.AddWithValue("@girisyukseklik", isyeri.GirisYukseklik)
                SQL_Komut.Parameters.AddWithValue("@zemin", isyeri.ZeminEtudu)
                SQL_Komut.Parameters.AddWithValue("@kullanim", isyeri.KullanimDurumu)
                SQL_Komut.Parameters.AddWithValue("@tapu", isyeri.TapuDurumu)
                Ac_IslemYap_Kapat()
            Case 10 'Komple bina
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update Isyerleri set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durumu, m2ORacik = @buyukluk, Krediye_Uygun = @kredi where ilan_No = @ilanno"
                Else : SQL_Komut.CommandText = "update Isyerleri set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durumu, m2ORacik = @buyukluk where ilan_No = @ilanno"
                End If
                Ac_IslemYap_Kapat()
                DepoVSParam(isyeri)
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID))
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "Update DepoBinaPlazaFabrika set Zemin_Etudu = @zemin, Kullanim_Durumu = @kullanim, Tapu_Durumu = @tapu, Kat_Sayisi = @katSayisi, Bina_Tipi_ID = @binaTipi where Isyeri_ID = @yerid"
                Else : SQL_Komut.CommandText = "Update DepoBinaPlazaFabrika set Zemin_Etudu = @zemin, Kullanim_Durumu = @kullanim, Tapu_Durumu = @tapu, Kat_Sayisi = @katSayisi, Bina_Tipi_ID = @binaTipi,Depozito = @depozito where Isyeri_ID = @yerid"
                End If
                SQL_Komut.Parameters.AddWithValue("@depozito", isyeri.depozitosu)
                SQL_Komut.Parameters.AddWithValue("@KatSayisi", isyeri.KatSayisi)
                SQL_Komut.Parameters.AddWithValue("@binaTipi", isyeri.BinaTipiID)
                SQL_Komut.Parameters.AddWithValue("@zemin", isyeri.ZeminEtudu)
                SQL_Komut.Parameters.AddWithValue("@kullanim", isyeri.KullanimDurumu)
                SQL_Komut.Parameters.AddWithValue("@tapu", isyeri.TapuDurumu)
                Ac_IslemYap_Kapat()
            Case 13 'Plaza
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "Update Isyerleri set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durumu, m2ORacik = @buyukluk, Krediye_Uygun = @kredi where ilan_No = @ilanno"
                Else : SQL_Komut.CommandText = "Update Isyerleri set Bina_Yasi = @binayas, Isitma_ID = @isitma, Durumu = @durumu, m2ORacik = @buyukluk where ilan_No = @ilanno"
                End If
                Ac_IslemYap_Kapat()
                DepoVSParam(isyeri)
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID))
                If isyeri.ilanSatisID = 0 Then : SQL_Komut.CommandText = "update DepoBinaPlazaFabrika set Zemin_Etudu = @zemin, Kullanim_Durumu = @kullanim, Tapu_Durumu = @tapu, Kat_Sayisi = @katSayisi, Aidat = @aidat, Bulundugu_Kat= @kat, Oda_Bolum_Sayisi = @odabolum where Isyeri_ID = @yerid"
                Else : SQL_Komut.CommandText = "update DepoBinaPlazaFabrika set Zemin_Etudu = @zemin, Kullanim_Durumu = @kullanim, Tapu_Durumu = @tapu, Kat_Sayisi = @katSayisi, Aidat = @aidat, Bulundugu_Kat= @kat, Oda_Bolum_Sayisi = @odabolum,Depozito = @depozito where Isyeri_ID = @yerid"
                End If
                SQL_Komut.Parameters.AddWithValue("@depozito", isyeri.depozitosu)
                SQL_Komut.Parameters.AddWithValue("@KatSayisi", isyeri.KatSayisi)
                SQL_Komut.Parameters.AddWithValue("@binaTipi", isyeri.BinaAdedi)
                SQL_Komut.Parameters.AddWithValue("@odabolum", isyeri.odaBolumSayisi)
                SQL_Komut.Parameters.AddWithValue("@aidat", isyeri.Aidat)
                SQL_Komut.Parameters.AddWithValue("@kat", isyeri.BulunduguKat)
                SQL_Komut.Parameters.AddWithValue("@zemin", isyeri.ZeminEtudu)
                SQL_Komut.Parameters.AddWithValue("@kullanim", isyeri.KullanimDurumu)
                SQL_Komut.Parameters.AddWithValue("@tapu", isyeri.TapuDurumu)
                Ac_IslemYap_Kapat()
        End Select
    End Sub
    Public Sub SporRadyoPazarCiftlikGuncelle(isyeri As SporRadyoPazarCiftlik, ID As String)
        EmlakDuzenle(isyeri, ID)
        SQL_Komut.Parameters.AddWithValue("@buyukluk", isyeri.Buyukluk)
        SQL_Komut.Parameters.AddWithValue("@ilanno", ID)
        Select Case isyeri.IsyeriTipi
            Case 4 'Ciftlik
                SQL_Komut.CommandText = "update Isyerleri set Durumu = @durumu, m2ORacik = @buyukluk, Krediye_Uygun = @kredi where ilan_No = @ilanno"
                SQL_Komut.Parameters.AddWithValue("@durumu", isyeri.Durum)
                SQL_Komut.Parameters.AddWithValue("@kredi", isyeri.krediyeUygun)
                Ac_IslemYap_Kapat()
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID))
                SQL_Komut.CommandText = "update SporRadyoPazarCiftlik set Kapali_Alan = @kapali where Isyeri_ID = @yerid"
                SQL_Komut.Parameters.AddWithValue("@kapali", isyeri.KapaliAlan)
                Ac_IslemYap_Kapat()
            Case 12 'Pazar
                SQL_Komut.CommandText = "Update Isyerleri set m2ORacik = @buyukluk, Takasli = @takas where ilan_No = @ilanno"
                SQL_Komut.Parameters.AddWithValue("@takas", isyeri.Takas)
                Ac_IslemYap_Kapat()
                'Sporplaza.. tablosunda degisiklik yapamaz
            Case 14 'Radyo
                SQL_Komut.CommandText = "Update Isyerleri set m2ORacik = @buyukluk, Isitma_ID = @isitma, Krediye_Uygun = @kredi, Takasli = @takas where ilan_No = @ilanno"
                SQL_Komut.Parameters.AddWithValue("@takas", isyeri.Takas)
                SQL_Komut.Parameters.AddWithValue("@isitma", isyeri.IsitmaID)
                SQL_Komut.Parameters.AddWithValue("@kredi", isyeri.krediyeUygun)
                Ac_IslemYap_Kapat()
                'Sporplaza.. tablosunda degisiklik yapamaz
            Case 17 'Spor
                SQL_Komut.CommandText = "Update Isyerleri set m2ORacik = @buyukluk, Durumu = @durumu, Bina_Yasi = @binayas, Krediye_Uygun = @kredi where ilan_No = @ilanno"
                SQL_Komut.Parameters.AddWithValue("@kredi", isyeri.krediyeUygun)
                SQL_Komut.Parameters.AddWithValue("@durumu", isyeri.Durum)
                SQL_Komut.Parameters.AddWithValue("@binayas", isyeri.BinaYasi)
                Ac_IslemYap_Kapat()
                SQL_Komut.Parameters.AddWithValue("@yerid", isyeriID(ID))
                SQL_Komut.CommandText = "update SporRadyoPazarCiftlik set SporTesis_Tipi = @sportipi, Kullanim_Durumu = @kullanim where Isyeri_ID = @yerid"
                SQL_Komut.Parameters.Add(New SqlParameter("@kullanim", SqlDbType.Bit)).Value = isyeri.KullanimDurumu
                SQL_Komut.Parameters.AddWithValue("@sportipi", isyeri.SporTesisTipi)
                Ac_IslemYap_Kapat()
        End Select
    End Sub
#End Region

#Region "Tablo Fonksiyonlari"
    Public Function KonutTablosu() As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren,E.ilan_Tur_ID,E.ilan_Resim1,E.ilan_Resim2,E.ilan_Resim3,E.ilan_Resim4,E.ilan_Resim5,E.ilan_Resim6,E.ilan_Resim7,E.ilan_Resim8,E.ilan_Video,E.Adres,E.Fiyat,E.islem_Tamam_mi,
		K.Buyukluk,K.Acik_Alan_Buyuklugu,K.Bina_Yasi,K.Kat_Sayisi,K.Banyo_Sayisi,K.Esyali,K.Kullanim_Durumu,K.Site_Icerisinde,K.Aidat,K.Krediye_Uygun,K.Takasli,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		O.Oda_Sayisi,
		Bu.Bulundugu_Kat,
		Isi.Isitma,
		Sa.Satis_Turu, Sa.Satis_Turu_ID,
		Ko.Konut_Tip
        from Emlak E, Konut K, Sehirler S, Ilceler Ilce, SemtMah M, Oda_Sayisi O,Bulundugu_Kat Bu, Isitma Isi,Satis_Turu Sa,Konut_Tip Ko
        where (E.ilan_Tur_ID = 0) and M.SemtMahId = E.Mahalle and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and K.Oda_Sayisi_ID = O.Oda_Sayisi_ID and K.Bulundugu_Kat_ID = Bu.Bulundugu_Kat_ID and K.Isitma_ID = Isi.Isitma_ID and E.Satis_Tur = Sa.Satis_Turu_ID and K.Konut_Tip_ID = Ko.Konut_Tip_ID and E.islem_Tamam_mi = 'false' and E.ilan_No = K.ilan_No" 'son şart veri tekrarını önlemek için konulmuştur
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function KonutTablosu(ilanNo As String) As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		K.Buyukluk, K.Acik_Alan_Buyuklugu, K.Bina_Yasi, K.Kat_Sayisi, K.Banyo_Sayisi, K.Esyali, K.Kullanim_Durumu, K.Site_Icerisinde, K.Aidat, K.Krediye_Uygun, K.Takasli,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		O.Oda_Sayisi,
		Bu.Bulundugu_Kat,
		Isi.Isitma,
		Sa.Satis_Turu,
		Ko.Konut_Tip_ID, Ko.Konut_Tip,
        Sa.Satis_Turu_ID 
		from Emlak E, Konut K, Sehirler S, Ilceler Ilce, SemtMah M, Oda_Sayisi O,Bulundugu_Kat Bu, Isitma Isi,Satis_Turu Sa,Konut_Tip Ko
        where (E.ilan_Tur_ID = 0) and M.SemtMahId = E.Mahalle and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and K.Oda_Sayisi_ID = O.Oda_Sayisi_ID and K.Bulundugu_Kat_ID = Bu.Bulundugu_Kat_ID and K.Isitma_ID = Isi.Isitma_ID and E.Satis_Tur = Sa.Satis_Turu_ID and K.Konut_Tip_ID = Ko.Konut_Tip_ID and K.ilan_No = '" & ilanNo & "' and E.islem_Tamam_mi = 'false' and E.ilan_No = K.ilan_No" 'son şart veri tekrarını önlemek için konulmuştur
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function ArsaTablosu() As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren,E.ilan_Tur_ID,E.ilan_Resim1,E.ilan_Resim2,E.ilan_Resim3,E.ilan_Resim4,E.ilan_Resim5,E.ilan_Resim6,E.ilan_Resim7,E.ilan_Resim8,E.ilan_Video,E.Adres,E.Fiyat,E.islem_Tamam_mi,
		A.Buyukluk, A.Parsel_No, A.Pafta_No, A.Ada_No, A.Kat_Karsiligi, A.Krediye_Uygun, A.Takasli, A.Buyukluk / E.Fiyat as metrekareFiyati,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		Sa.Satis_Turu,
		I.imar_Durumu,
		G.Gabari,
		K.Kaks,
		T.Tapu_Durumu,
        Sa.Satis_Turu_ID
		from Emlak E, Arsa A, Sehirler S, Ilceler Ilce, SemtMah M, Satis_Turu Sa, Gabari G, Kaks K, imar_Durumu I, Tapu_Durumu T
        where (E.ilan_Tur_ID = 2) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and E.Satis_Tur = Sa.Satis_Turu_ID and A.imar_Durumu_ID = I.imar_ID and A.Gabari = G.Gabari_ID and A.Kaks = K.Kaks_ID and A.Tapu_Durumu = T.Tapu_Durumu_ID and E.ilan_No = A.ilan_No" 'son şart veri tekrarını önlemek için konulmuştur
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function ArsaTablosu(ilanNo As String) As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		A.Buyukluk, A.Parsel_No, A.Pafta_No, A.Ada_No, A.Kat_Karsiligi, A.Krediye_Uygun, A.Takasli, A.Buyukluk / E.Fiyat as metrekareFiyati,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		Sa.Satis_Turu,
		I.imar_Durumu,
		G.Gabari,
		K.Kaks,
		T.Tapu_Durumu,
        Sa.Satis_Turu_ID
		from Emlak E, Arsa A, Sehirler S, Ilceler Ilce, SemtMah M, Satis_Turu Sa, Gabari G, Kaks K, imar_Durumu I, Tapu_Durumu T
        where (E.ilan_Tur_ID = 2) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and E.Satis_Tur = Sa.Satis_Turu_ID and A.imar_Durumu_ID = I.imar_ID and A.Gabari = G.Gabari_ID and A.Kaks = K.Kaks_ID and A.Tapu_Durumu = T.Tapu_Durumu_ID and A.ilan_No = '" & ilanNo & "' and E.ilan_No = A.ilan_No" 'son şart veri tekrarını önlemek için konulmuştur
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function BinaTablosu() As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren,E.ilan_Tur_ID,E.ilan_Resim1,E.ilan_Resim2,E.ilan_Resim3,E.ilan_Resim4,E.ilan_Resim5,E.ilan_Resim6,E.ilan_Resim7,E.ilan_Resim8,E.ilan_Video,E.Adres,E.Fiyat,E.islem_Tamam_mi,
		B.Bina_Yasi, B.Bir_Kattaki_Daire_Sayisi, B.Buyukluk, B.Kat_Sayisi, B.Krediye_Uygun, B.Takasli,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		Isi.Isitma,
		Sa.Satis_Turu, Sa.Satis_Turu_ID
		from Emlak E, Bina B, Sehirler S, Ilceler Ilce, SemtMah M, Isitma Isi,Satis_Turu Sa
        where (E.ilan_Tur_ID = 3) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and B.Isitma = Isi.Isitma_ID and E.Satis_Tur = Sa.Satis_Turu_ID and E.ilan_No = B.ilan_No" 'son şart veri tekrarını önlemek için konulmuştur
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function BinaTablosu(ilanNo As String) As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		B.Bina_Yasi, B.Bir_Kattaki_Daire_Sayisi, B.Buyukluk, B.Kat_Sayisi, B.Krediye_Uygun, B.Takasli,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		Isi.Isitma,
		Sa.Satis_Turu, Sa.Satis_Turu_ID
		from Emlak E, Bina B, Sehirler S, Ilceler Ilce, SemtMah M, Isitma Isi,Satis_Turu Sa
        where (E.ilan_Tur_ID = 3) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and B.Isitma = Isi.Isitma_ID and E.Satis_Tur = Sa.Satis_Turu_ID and B.ilan_No = '" & ilanNo & "' and E.ilan_No = B.ilan_No" 'son şart veri tekrarını önlemek için konulmuştur
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function DepoBinaPlazaFabrikaTablosu(ByVal iseriTipi As Integer) As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		I.Bina_Yasi, I.Durumu, I.Isitma_ID, I.Krediye_Uygun, I.m2ORacik as Buyukluk, I.Takasli,
        D.Giris_yukseklik, D.Kullanim_Durumu, D.Tapu_Durumu as Tapu_Durumu_ID, D.Zemin_Etudu, D.Depozito, D.Oda_Bolum_Sayisi, D.Kat_Sayisi, D.Kapali_Alan, D.Bina_Adedi, D.Aidat, D.Bulundugu_Kat, D.Bina_Tipi_ID,
        DE.Tapu_Durumu,
        ISY.Isyeri_Tipi,
        Isi.Isitma,
        S.SehirAdi,
        Ilce.ilceAdi,
        M.MahalleAdi,
        Sa.Satis_Turu, Sa.Satis_Turu_ID,
        ISY.Isyeri_Tipi_ID
        From Emlak E, Isyerleri I, DepoBinaPlazaFabrika D, Depo_Tapu_Durumu DE, Isyeri_Tipi ISY, Sehirler S, Ilceler Ilce, SemtMah M, Isitma Isi, Satis_Turu Sa
        Where (E.ilan_Tur_ID = 1) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and Isi.Isitma_ID = I.Isitma_ID and I.ID = D.Isyeri_ID  and D.Isyeri_Tipi = ISY.Isyeri_Tipi_ID and D.Tapu_Durumu = DE.Tapu_Durumu_ID and E.Satis_Tur = Sa.Satis_Turu_ID and E.ilan_No = I.ilan_No and D.Isyeri_Tipi = " & iseriTipi
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function DepoBinaPlazaFabrikaTablosu(ilanNo As String) As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		I.Bina_Yasi, I.Durumu, I.Isitma_ID, I.Krediye_Uygun, I.m2ORacik, I.Takasli,
        D.Giris_yukseklik, D.Kullanim_Durumu, D.Tapu_Durumu, D.Zemin_Etudu, D.Depozito, D.Oda_Bolum_Sayisi, D.Kat_Sayisi, D.Kapali_Alan, D.Bina_Adedi, D.Aidat, D.Bulundugu_Kat, D.Bina_Tipi_ID, D.Bulundugu_Kat,
        DE.Tapu_Durumu,
        ISY.Isyeri_Tipi,
        Isi.Isitma,
        S.SehirAdi,
        Ilce.ilceAdi,
        M.MahalleAdi,
        Sa.Satis_Turu, Sa.Satis_Turu_ID,
        ISY.Isyeri_Tipi_ID
        From Emlak E, Isyerleri I, DepoBinaPlazaFabrika D, Depo_Tapu_Durumu DE, Isyeri_Tipi ISY, Sehirler S, Ilceler Ilce, SemtMah M, Isitma Isi, Satis_Turu Sa
        Where (E.ilan_Tur_ID = 1) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and Isi.Isitma_ID = I.Isitma_ID and I.ID = D.Isyeri_ID and I.ilan_No = E.ilan_No and D.Isyeri_Tipi = ISY.Isyeri_Tipi_ID and D.Tapu_Durumu = DE.Tapu_Durumu_ID and E.Satis_Tur = Sa.Satis_Turu_ID and I.ilan_No = '" & ilanNo & "'"
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function AtolyeBuroDukkanImaAVMTablosu(ByVal iseriTipi As Integer) As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		I.Bina_Yasi, I.Durumu, I.Isitma_ID, I.Krediye_Uygun, I.m2ORacik as Buyukluk, I.Takasli,
		A.aidat,A.oda_bolum_sayisi,A.depozito, A.kat_Sayisi, A.Asansor_Sayisi,
		ISY.Isyeri_Tipi,
		Isi.Isitma,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		Sa.Satis_Turu, Sa.Satis_Turu_ID,
        ISY.Isyeri_Tipi_ID
		from Emlak E, Isyerleri I, AtolyeBuroDukkanImaAVM A, Isyeri_Tipi ISY, Sehirler S, Ilceler Ilce, SemtMah M, Isitma Isi, Satis_Turu Sa
        where (E.ilan_Tur_ID = 1) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and Isi.Isitma_ID = I.Isitma_ID and A.Isyeri_ID = I.ID and A.Isyeri_Tipi = isy.Isyeri_Tipi_ID and E.Satis_Tur = Sa.Satis_Turu_ID and E.ilan_No = I.ilan_No and A.Isyeri_Tipi = " & iseriTipi
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function AtolyeBuroDukkanImaAVMTablosu(ilanNo As String) As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		I.Bina_Yasi, I.Durumu, I.Isitma_ID, I.Krediye_Uygun, I.m2ORacik, I.Takasli,
		A.aidat,A.oda_bolum_sayisi,A.depozito, A.kat_Sayisi, A.Asansor_Sayisi,
		ISY.Isyeri_Tipi,
		Isi.Isitma,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		Isi.Isitma,
		Sa.Satis_Turu, Sa.Satis_Turu_ID,
        ISY.Isyeri_Tipi_ID
		from Emlak E, Isyerleri I, AtolyeBuroDukkanImaAVM A, Isyeri_Tipi ISY, Sehirler S, Ilceler Ilce, SemtMah M, Isitma Isi, Satis_Turu Sa
        where (E.ilan_Tur_ID = 1) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and Isi.Isitma_ID = I.Isitma_ID and A.Isyeri_ID = I.ID and A.Isyeri_Tipi = isy.Isyeri_Tipi_ID and E.Satis_Tur = Sa.Satis_Turu_ID and E.ilan_No = I.ilan_No and I.ilan_No = '" & ilanNo & "'"
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function BufeDugunSpaSineOtoTablosu(ByVal iseriTipi As Integer) As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		I.Bina_Yasi, I.Durumu, I.Krediye_Uygun, I.m2ORacik as Buyukluk, I.Takasli, I.Isitma_ID,
		B.Oda_bolum_Sayisi, B.Kullanim_Durumu, B.Tavan_Yuksekligi, B.Depozito, B.Masa_Sayisi, B.Kisi_kapasitesi, B.Arac_Sayisi, B.Kat_Sayisi, B.Bulundugu_Kat, B.Cinsiyet, B.Yapi_Tipi, B.Otopark_Turu,
		ISY.Isyeri_Tipi,
		Sa.Satis_Turu,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
        Sa.Satis_Turu_ID,
        ISY.Isyeri_Tipi_ID
		from Emlak E, Isyerleri I, BufeDugunSpaSineOto B, Isyeri_Tipi ISY, Satis_Turu Sa, Sehirler S, Ilceler Ilce, SemtMah M
        where (E.ilan_Tur_ID = 1) and B.Isyeri_ID = I.ID and E.islem_Tamam_mi = 'false' and I.ilan_No = E.ilan_No and isy.Isyeri_Tipi_ID = B.Isyeri_Tipi and E.Satis_Tur = Sa.Satis_Turu_ID and M.SemtMahId = E.Mahalle and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and B.Isyeri_Tipi = " & iseriTipi
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function BufeDugunSpaSineOtoTablosu(ilanNo As String) As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		I.Bina_Yasi, I.Durumu, I.Krediye_Uygun, I.m2ORacik, I.Takasli, I.Isitma_ID,
		B.Oda_bolum_Sayisi, B.Kullanim_Durumu, B.Tavan_Yuksekligi, B.Depozito, B.Masa_Sayisi, B.Kisi_kapasitesi, B.Arac_Sayisi, B.Kat_Sayisi, B.Bulundugu_Kat, B.Cinsiyet, B.Yapi_Tipi, B.Otopark_Turu,
		ISY.Isyeri_Tipi,
		Sa.Satis_Turu,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
        Sa.Satis_Turu_ID,
        ISY.Isyeri_Tipi_ID
		from Emlak E, Isyerleri I, BufeDugunSpaSineOto B, Isyeri_Tipi ISY, Satis_Turu Sa, Sehirler S, Ilceler Ilce, SemtMah M
        where (E.ilan_Tur_ID = 1) and B.Isyeri_ID = I.ID and E.islem_Tamam_mi = 'false' and I.ilan_No = E.ilan_No and isy.Isyeri_Tipi_ID = B.Isyeri_Tipi and E.Satis_Tur = Sa.Satis_Turu_ID and M.SemtMahId = E.Mahalle and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and I.ilan_No = '" & ilanNo & "'"
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function SporRadyoPazarCiftlikTablosu(ByVal iseriTipi As Integer) As DataTable
        SQL_Komut.CommandText = "Select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		I.Bina_Yasi, I.Durumu, I.Isitma_ID, I.Krediye_Uygun, I.m2ORacik as Buyukluk, I.Takasli,
		Sp.Kapali_Alan, Sp.Kullanim_Durumu, Sp.SporTesis_Tipi,
		ISY.Isyeri_Tipi,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		Sa.Satis_Turu, Sa.Satis_Turu_ID,
        ISY.Isyeri_Tipi_ID
		from Emlak E, Isyerleri I, SporRadyoPazarCiftlik Sp, Isyeri_Tipi ISY, Sehirler S, Ilceler Ilce, SemtMah M, Satis_Turu Sa
        where (E.ilan_Tur_ID = 1) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and Sp.Isyeri_Tipi = isy.Isyeri_Tipi_ID  and E.Satis_Tur = Sa.Satis_Turu_ID and Sp.Isyeri_ID = I.ID and E.ilan_No = I.ilan_No and Sp.Isyeri_Tipi = " & iseriTipi
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function SporRadyoPazarCiftlikTablosu(ilanNo As String) As DataTable
        SQL_Komut.CommandText = "Select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		I.Bina_Yasi, I.Durumu, I.Isitma_ID, I.Krediye_Uygun, I.m2ORacik, I.Takasli,
		Sp.Kapali_Alan, Sp.Kullanim_Durumu, Sp.SporTesis_Tipi,
		ISY.Isyeri_Tipi,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		Sa.Satis_Turu, Sa.Satis_Turu_ID,
        ISY.Isyeri_Tipi_ID
		from Emlak E, Isyerleri I, SporRadyoPazarCiftlik Sp, Isyeri_Tipi ISY, Sehirler S, Ilceler Ilce, SemtMah M, Satis_Turu Sa
        where (E.ilan_Tur_ID = 1) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and Sp.Isyeri_Tipi = isy.Isyeri_Tipi_ID  and E.Satis_Tur = Sa.Satis_Turu_ID and Sp.Isyeri_ID = I.ID and E.ilan_No = '" & ilanNo & "' and I.ilan_No = '" & ilanNo & "'"
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function TuristikTesisTablosu() As DataTable
        SQL_Komut.CommandText = "Select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren,E.ilan_Tur_ID, E.ilan_Resim1,E.ilan_Resim2,E.ilan_Resim3,E.ilan_Resim4,E.ilan_Resim5,E.ilan_Resim6,E.ilan_Resim7,E.ilan_Resim8,E.ilan_Video,E.Adres,E.Fiyat,E.islem_Tamam_mi,
		T.Otel_Yildiz_Sayisi, T.Apart_Otel_Apart_Sayisi, T.oda_Sayisi, T.yatak_Sayisi, T.kat_Sayisi, T.Bina_Yasi,T.Acik_Alan, T.Kapali_Alan as Buyukluk, T.Zemin_Etudu, T.Yapi_Durumu, T.Krediye_Uygun,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		Sa.Satis_Turu,
		TTT.TT_Tip,
        Sa.Satis_Turu_ID
		from Emlak E, Turistik_Tesis T, Sehirler S, Ilceler Ilce, SemtMah M, Satis_Turu Sa, TT_Tip TTT
        where (E.ilan_Tur_ID = 4) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and E.Satis_Tur = Sa.Satis_Turu_ID and T.TT_Tipi = TTT.TT_Tip_ID and E.ilan_No = T.ilan_No" 'son şart veri tekrarını önlemek için konulmuştur
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function TuristikTesisTablosu(ilanNo As String) As DataTable
        SQL_Komut.CommandText = "select E.ilan_No, E.ilan_Aciklama, E.ilan_Baslik, E.ilan_Tarihi, E.ilan_Veren, E.ilan_Tur_ID, E.ilan_Resim1, E.ilan_Resim2, E.ilan_Resim3, E.ilan_Resim4, E.ilan_Resim5, E.ilan_Resim6, E.ilan_Resim7, E.ilan_Resim8, E.ilan_Video, E.Adres, E.Fiyat, E.islem_Tamam_mi,
		T.Otel_Yildiz_Sayisi, T.Apart_Otel_Apart_Sayisi, T.oda_Sayisi, T.yatak_Sayisi, T.kat_Sayisi, T.Bina_Yasi, T.Acik_Alan, T.Kapali_Alan, T.Zemin_Etudu, T.Yapi_Durumu, T.Krediye_Uygun,
		S.SehirAdi,
		Ilce.ilceAdi,
		M.MahalleAdi,
		Sa.Satis_Turu,
		TTT.TT_Tip_ID, TTT.TT_Tip,
        Sa.Satis_Turu_ID
		from Emlak E, Turistik_Tesis T, Sehirler S, Ilceler Ilce, SemtMah M, Satis_Turu Sa, TT_Tip TTT
        where (E.ilan_Tur_ID = 4) and M.SemtMahId = E.Mahalle and E.islem_Tamam_mi = 'false' and Ilce.ilceId = M.ilceId and S.SehirId = Ilce.SehirId and E.Satis_Tur = Sa.Satis_Turu_ID and T.TT_Tipi = TTT.TT_Tip_ID and T.ilan_No = '" & ilanNo & "' and E.ilan_No = T.ilan_No" 'son şart veri tekrarını önlemek için konulmuştur
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function EmlakSahipTablosu() As DataTable
        SQL_Komut.CommandText = "select Sahip_ID, Sahip_Adi, Sahip_Cep_Tel, Sahip_Ev_Tel,Sahip_Email from Ilan_Sahipleri"
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function EmlakSahipTablosu(sahipID As String) As DataTable
        SQL_Komut.CommandText = "select Sahip_ID, Sahip_Adi, Sahip_Cep_Tel, Sahip_Ev_Tel,Sahip_Email from Ilan_Sahipleri where Sahip_ID = '" & sahipID & "'"
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function EmlakTablosu() As DataTable
        SQL_Komut.CommandText = "Select E.*,ET.Emlak_Tur, E.Satis_Tur as Satis_Turu_ID from Emlak E, Emlak_Turu ET where E.ilan_Tur_ID = Emlak_Tur_ID and E.islem_Tamam_mi = 'false' order by ilan_Tarihi desc"
        Dim da As New SqlDataAdapter(SQL_Komut)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
#End Region

End Class
