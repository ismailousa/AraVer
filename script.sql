USE [master]
GO
/****** Object:  Database [AraVer]    Script Date: 02-Mar-17 1:06:19 AM ******/
CREATE DATABASE [AraVer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AraVer', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AraVer.mdf' , SIZE = 151552KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AraVer_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AraVer_log.ldf' , SIZE = 63424KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AraVer] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AraVer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AraVer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AraVer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AraVer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AraVer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AraVer] SET ARITHABORT OFF 
GO
ALTER DATABASE [AraVer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AraVer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AraVer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AraVer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AraVer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AraVer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AraVer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AraVer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AraVer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AraVer] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AraVer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AraVer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AraVer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AraVer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AraVer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AraVer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AraVer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AraVer] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AraVer] SET  MULTI_USER 
GO
ALTER DATABASE [AraVer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AraVer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AraVer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AraVer] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AraVer] SET DELAYED_DURABILITY = DISABLED 
GO
USE [AraVer]
GO
/****** Object:  Table [dbo].[Arsa]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Arsa](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[ilan_No] [char](11) NOT NULL,
	[imar_Durumu_ID] [tinyint] NOT NULL,
	[Buyukluk] [smallint] NOT NULL,
	[Ada_No] [int] NULL,
	[Parsel_No] [int] NULL,
	[Pafta_No] [int] NULL,
	[Kaks] [tinyint] NULL,
	[Gabari] [tinyint] NULL,
	[Tapu_Durumu] [tinyint] NULL,
	[Krediye_Uygun] [bit] NULL,
	[Takasli] [bit] NULL,
	[Kat_Karsiligi] [bit] NULL,
 CONSTRAINT [PK_Arsa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AtolyeBuroDukkanImaAVM]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AtolyeBuroDukkanImaAVM](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[Isyeri_ID] [int] NOT NULL,
	[Isyeri_Tipi] [tinyint] NOT NULL,
	[aidat] [smallint] NULL,
	[oda_bolum_sayisi] [smallint] NULL,
	[depozito] [bit] NULL,
	[kat_Sayisi] [tinyint] NULL,
	[Asansor_Sayisi] [tinyint] NULL,
 CONSTRAINT [PK_AtolyeBuroDukkanImaAVM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bina]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bina](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[ilan_No] [char](11) NOT NULL,
	[Kat_Sayisi] [tinyint] NOT NULL,
	[Bir_Kattaki_Daire_Sayisi] [tinyint] NOT NULL,
	[Isitma] [tinyint] NOT NULL,
	[Buyukluk] [smallint] NOT NULL,
	[Bina_Yasi] [tinyint] NOT NULL,
	[Krediye_Uygun] [bit] NOT NULL,
	[Takasli] [bit] NOT NULL,
 CONSTRAINT [PK_Bina] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bina_Tipi]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bina_Tipi](
	[Bina_Tipi_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Bina_Tipi] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_Bina_Tipi] PRIMARY KEY CLUSTERED 
(
	[Bina_Tipi_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BufeDugunSpaSineOto]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BufeDugunSpaSineOto](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[Isyeri_ID] [int] NOT NULL,
	[Isyeri_Tipi] [tinyint] NOT NULL,
	[Oda_bolum_Sayisi] [smallint] NULL,
	[Kullanim_Durumu] [bit] NULL,
	[Tavan_Yuksekligi] [tinyint] NULL,
	[Depozito] [bit] NULL,
	[Masa_Sayisi] [smallint] NULL,
	[Kisi_kapasitesi] [int] NULL,
	[Arac_Sayisi] [int] NULL,
	[Kat_Sayisi] [tinyint] NULL,
	[Otopark_Turu] [tinyint] NULL,
	[Bulundugu_Kat] [tinyint] NULL,
	[Cinsiyet] [tinyint] NULL,
	[Yapi_Tipi] [tinyint] NULL,
 CONSTRAINT [PK_BufeDugunSpaSineOto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bulundugu_Kat]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bulundugu_Kat](
	[Bulundugu_Kat_ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Bulundugu_Kat] [nvarchar](12) NULL,
 CONSTRAINT [PK_Bulubdugu_Kat] PRIMARY KEY CLUSTERED 
(
	[Bulundugu_Kat_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cinsiyet]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cinsiyet](
	[Cinsiyet_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Cinsiyet] [varchar](6) NOT NULL,
 CONSTRAINT [PK_Cinsiyet] PRIMARY KEY CLUSTERED 
(
	[Cinsiyet_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Depo_Tapu_Durumu]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Depo_Tapu_Durumu](
	[Tapu_Durumu_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Tapu_Durumu] [nvarchar](19) NOT NULL,
 CONSTRAINT [PK_Tapu_Durumu_1] PRIMARY KEY CLUSTERED 
(
	[Tapu_Durumu_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DepoBinaPlazaFabrika]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepoBinaPlazaFabrika](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[Isyeri_ID] [int] NOT NULL,
	[Isyeri_Tipi] [tinyint] NOT NULL,
	[Giris_yukseklik] [tinyint] NULL,
	[Kullanim_Durumu] [bit] NOT NULL,
	[Tapu_Durumu] [tinyint] NOT NULL,
	[Zemin_Etudu] [bit] NOT NULL,
	[Depozito] [bit] NULL,
	[Oda_Bolum_Sayisi] [smallint] NULL,
	[Kat_Sayisi] [tinyint] NULL,
	[Kapali_Alan] [smallint] NULL,
	[Bina_Adedi] [tinyint] NULL,
	[Aidat] [smallint] NULL,
	[Bulundugu_Kat] [tinyint] NULL,
	[Bina_Tipi_ID] [tinyint] NULL,
 CONSTRAINT [PK_DepoBinaPlazaFabrika] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Emlak]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Emlak](
	[ilan_No] [char](11) NOT NULL,
	[ilan_Aciklama] [nvarchar](200) NULL,
	[Ilan_Baslik] [nvarchar](64) NOT NULL,
	[ilan_Tarihi] [date] NOT NULL,
	[ilan_Veren] [int] NOT NULL,
	[ilan_Tur_ID] [tinyint] NOT NULL,
	[Satis_Tur] [tinyint] NOT NULL,
	[ilan_Resim1] [image] NULL,
	[ilan_Resim2] [image] NULL,
	[ilan_Resim3] [image] NULL,
	[ilan_Resim4] [image] NULL,
	[ilan_Resim5] [image] NULL,
	[ilan_Resim6] [image] NULL,
	[ilan_Resim7] [image] NULL,
	[ilan_Resim8] [image] NULL,
	[ilan_Video] [nvarchar](max) NULL,
	[Mahalle] [int] NOT NULL,
	[Adres] [nvarchar](50) NOT NULL,
	[Fiyat] [int] NOT NULL,
	[islem_Tamam_mi] [bit] NOT NULL,
 CONSTRAINT [PK_Emlak] PRIMARY KEY CLUSTERED 
(
	[ilan_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Emlak_Turu]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emlak_Turu](
	[Emlak_Tur_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Emlak_Tur] [nvarchar](14) NOT NULL,
 CONSTRAINT [PK_Emlak_Turu] PRIMARY KEY CLUSTERED 
(
	[Emlak_Tur_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Gabari]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gabari](
	[Gabari_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Gabari] [varchar](7) NOT NULL,
 CONSTRAINT [PK_Gabari] PRIMARY KEY CLUSTERED 
(
	[Gabari_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ilan_Sahipleri]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ilan_Sahipleri](
	[Sahip_ID] [int] IDENTITY(0,1) NOT NULL,
	[Sahip_Adi] [nvarchar](30) NOT NULL,
	[Sahip_Cep_Tel] [char](10) NOT NULL,
	[Sahip_Ev_Tel] [char](10) NULL,
	[Sahip_Email] [nvarchar](45) NULL,
 CONSTRAINT [PK_Ilan_Sahipleri] PRIMARY KEY CLUSTERED 
(
	[Sahip_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ilceler]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilceler](
	[ilceId] [smallint] NOT NULL,
	[SehirId] [tinyint] NOT NULL,
	[ilceAdi] [nvarchar](18) NOT NULL,
 CONSTRAINT [PK_Ilceler] PRIMARY KEY CLUSTERED 
(
	[ilceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[imar_Durumu]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imar_Durumu](
	[imar_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[imar_Durumu] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_imar_Durumu] PRIMARY KEY CLUSTERED 
(
	[imar_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Isitma]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Isitma](
	[Isitma_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Isitma] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Isitma] PRIMARY KEY CLUSTERED 
(
	[Isitma_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Isyeri_Gruplari]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Isyeri_Gruplari](
	[Isyeri_Grup_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Isyeri_Grubu] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Isyeri_Gruplari] PRIMARY KEY CLUSTERED 
(
	[Isyeri_Grup_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Isyeri_Tipi]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Isyeri_Tipi](
	[Isyeri_Tipi_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Isyeri_Tipi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Isyeri_Tipi] PRIMARY KEY CLUSTERED 
(
	[Isyeri_Tipi_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Isyerleri]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Isyerleri](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[ilan_No] [char](11) NOT NULL,
	[Isyeri_Grubu] [tinyint] NOT NULL,
	[Bina_Yasi] [tinyint] NULL,
	[Isitma_ID] [tinyint] NULL,
	[Durumu] [nvarchar](10) NULL,
	[Krediye_Uygun] [bit] NULL,
	[m2ORacik] [int] NOT NULL,
	[Takasli] [bit] NULL,
 CONSTRAINT [PK_Isyerleri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kaks]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kaks](
	[Kaks_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Kaks] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Kaks] PRIMARY KEY CLUSTERED 
(
	[Kaks_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Konut]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Konut](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[ilan_No] [char](11) NOT NULL,
	[Konut_Tip_ID] [tinyint] NOT NULL,
	[Buyukluk] [smallint] NOT NULL,
	[Acik_Alan_Buyuklugu] [int] NULL,
	[Bina_Yasi] [tinyint] NOT NULL,
	[Oda_Sayisi_ID] [tinyint] NOT NULL,
	[Bulundugu_Kat_ID] [tinyint] NOT NULL,
	[Kat_Sayisi] [tinyint] NOT NULL,
	[Isitma_ID] [tinyint] NOT NULL,
	[Banyo_Sayisi] [tinyint] NOT NULL,
	[Esyali] [bit] NOT NULL,
	[Kullanim_Durumu] [bit] NOT NULL,
	[Site_Icerisinde] [bit] NOT NULL,
	[Aidat] [smallint] NOT NULL,
	[Krediye_Uygun] [bit] NOT NULL,
	[Takasli] [bit] NOT NULL,
 CONSTRAINT [PK_Konut] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Konut_Tip]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Konut_Tip](
	[Konut_Tip_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Konut_Tip] [nvarchar](14) NOT NULL,
 CONSTRAINT [PK_Konut_Tip] PRIMARY KEY CLUSTERED 
(
	[Konut_Tip_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oda_Sayisi]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Oda_Sayisi](
	[Oda_Sayisi_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Oda_Sayisi] [char](3) NOT NULL,
 CONSTRAINT [PK_Oda_Sayisi] PRIMARY KEY CLUSTERED 
(
	[Oda_Sayisi_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Otopark_Turu]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Otopark_Turu](
	[Otopark_Tur_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Otopark_Turu] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK_Otopark_Turu] PRIMARY KEY CLUSTERED 
(
	[Otopark_Tur_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Satis_Turu]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satis_Turu](
	[Satis_Turu_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Satis_Turu] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Satis_Turu] PRIMARY KEY CLUSTERED 
(
	[Satis_Turu_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sehirler]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sehirler](
	[SehirId] [tinyint] IDENTITY(0,1) NOT NULL,
	[SehirAdi] [nvarchar](15) NOT NULL,
	[PlakaNo] [tinyint] NOT NULL,
 CONSTRAINT [PK_Sehirler] PRIMARY KEY CLUSTERED 
(
	[SehirId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SemtMah]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SemtMah](
	[SemtMahId] [int] NOT NULL,
	[SemtAdi] [nvarchar](30) NOT NULL,
	[MahalleAdi] [nvarchar](40) NOT NULL,
	[ilceId] [smallint] NOT NULL,
 CONSTRAINT [PK_SemtMah] PRIMARY KEY CLUSTERED 
(
	[SemtMahId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SporRadyoPazarCiftlik]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SporRadyoPazarCiftlik](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[Isyeri_ID] [int] NOT NULL,
	[Isyeri_tipi] [tinyint] NOT NULL,
	[Kapali_Alan] [smallint] NULL,
	[Kullanim_Durumu] [bit] NULL,
	[SporTesis_Tipi] [tinyint] NULL,
 CONSTRAINT [PK_SporRadyoPazarCiftlik] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SporTesis_Turu]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SporTesis_Turu](
	[Tesis_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Tesis_Turu] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_SporTesis_Turu] PRIMARY KEY CLUSTERED 
(
	[Tesis_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tapu_Durumu]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tapu_Durumu](
	[Tapu_Durumu_ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Tapu_Durumu] [nvarchar](16) NOT NULL,
 CONSTRAINT [PK_Tapu_Durumu] PRIMARY KEY CLUSTERED 
(
	[Tapu_Durumu_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TT_Tip]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TT_Tip](
	[TT_Tip_ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[TT_Tip] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_TT_Tip] PRIMARY KEY CLUSTERED 
(
	[TT_Tip_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Turistik_Tesis]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Turistik_Tesis](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[ilan_NO] [char](11) NOT NULL,
	[TT_Tipi] [tinyint] NOT NULL,
	[Otel_Yildiz_Sayisi] [tinyint] NULL,
	[Apart_Otel_Apart_Sayisi] [smallint] NULL,
	[oda_Sayisi] [smallint] NULL,
	[yatak_Sayisi] [smallint] NULL,
	[kat_Sayisi] [tinyint] NULL,
	[Bina_Yasi] [tinyint] NULL,
	[Acik_Alan] [int] NULL,
	[Kapali_Alan] [int] NULL,
	[Zemin_Etudu] [bit] NULL,
	[Yapi_Durumu] [bit] NULL,
	[Krediye_Uygun] [bit] NULL,
	[Mocamp_Toplam_Arazi] [smallint] NULL,
	[Plaj_Buyukluk] [smallint] NULL,
	[Plaj_Kapasite] [smallint] NULL,
 CONSTRAINT [PK_Turistik_Tesis] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Yapi_Tipi]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yapi_Tipi](
	[ID] [tinyint] IDENTITY(0,1) NOT NULL,
	[Yapi_Tipi] [nvarchar](9) NOT NULL,
 CONSTRAINT [PK_Yapi_Tipi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Arsa]  WITH CHECK ADD  CONSTRAINT [FK_Arsa_Emlak] FOREIGN KEY([ilan_No])
REFERENCES [dbo].[Emlak] ([ilan_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Arsa] CHECK CONSTRAINT [FK_Arsa_Emlak]
GO
ALTER TABLE [dbo].[Arsa]  WITH CHECK ADD  CONSTRAINT [FK_Arsa_Gabari] FOREIGN KEY([Gabari])
REFERENCES [dbo].[Gabari] ([Gabari_ID])
GO
ALTER TABLE [dbo].[Arsa] CHECK CONSTRAINT [FK_Arsa_Gabari]
GO
ALTER TABLE [dbo].[Arsa]  WITH CHECK ADD  CONSTRAINT [FK_Arsa_imar_Durumu] FOREIGN KEY([imar_Durumu_ID])
REFERENCES [dbo].[imar_Durumu] ([imar_ID])
GO
ALTER TABLE [dbo].[Arsa] CHECK CONSTRAINT [FK_Arsa_imar_Durumu]
GO
ALTER TABLE [dbo].[Arsa]  WITH CHECK ADD  CONSTRAINT [FK_Arsa_Kaks] FOREIGN KEY([Kaks])
REFERENCES [dbo].[Kaks] ([Kaks_ID])
GO
ALTER TABLE [dbo].[Arsa] CHECK CONSTRAINT [FK_Arsa_Kaks]
GO
ALTER TABLE [dbo].[Arsa]  WITH CHECK ADD  CONSTRAINT [FK_Arsa_Tapu_Durumu] FOREIGN KEY([Tapu_Durumu])
REFERENCES [dbo].[Tapu_Durumu] ([Tapu_Durumu_ID])
GO
ALTER TABLE [dbo].[Arsa] CHECK CONSTRAINT [FK_Arsa_Tapu_Durumu]
GO
ALTER TABLE [dbo].[AtolyeBuroDukkanImaAVM]  WITH CHECK ADD  CONSTRAINT [FK_AtolyeBuroDukkanImaAVM_Isyeri_Tipi] FOREIGN KEY([Isyeri_Tipi])
REFERENCES [dbo].[Isyeri_Tipi] ([Isyeri_Tipi_ID])
GO
ALTER TABLE [dbo].[AtolyeBuroDukkanImaAVM] CHECK CONSTRAINT [FK_AtolyeBuroDukkanImaAVM_Isyeri_Tipi]
GO
ALTER TABLE [dbo].[AtolyeBuroDukkanImaAVM]  WITH CHECK ADD  CONSTRAINT [FK_AtolyeBuroDukkanImaAVM_Isyerleri] FOREIGN KEY([Isyeri_ID])
REFERENCES [dbo].[Isyerleri] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AtolyeBuroDukkanImaAVM] CHECK CONSTRAINT [FK_AtolyeBuroDukkanImaAVM_Isyerleri]
GO
ALTER TABLE [dbo].[Bina]  WITH CHECK ADD  CONSTRAINT [FK_Bina_Emlak] FOREIGN KEY([ilan_No])
REFERENCES [dbo].[Emlak] ([ilan_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bina] CHECK CONSTRAINT [FK_Bina_Emlak]
GO
ALTER TABLE [dbo].[Bina]  WITH CHECK ADD  CONSTRAINT [FK_Bina_Isitma] FOREIGN KEY([Isitma])
REFERENCES [dbo].[Isitma] ([Isitma_ID])
GO
ALTER TABLE [dbo].[Bina] CHECK CONSTRAINT [FK_Bina_Isitma]
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto]  WITH CHECK ADD  CONSTRAINT [FK_BufeDugunSpaSineOto_Bulundugu_Kat] FOREIGN KEY([Bulundugu_Kat])
REFERENCES [dbo].[Bulundugu_Kat] ([Bulundugu_Kat_ID])
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto] CHECK CONSTRAINT [FK_BufeDugunSpaSineOto_Bulundugu_Kat]
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto]  WITH CHECK ADD  CONSTRAINT [FK_BufeDugunSpaSineOto_Cinsiyet] FOREIGN KEY([Cinsiyet])
REFERENCES [dbo].[Cinsiyet] ([Cinsiyet_ID])
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto] CHECK CONSTRAINT [FK_BufeDugunSpaSineOto_Cinsiyet]
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto]  WITH CHECK ADD  CONSTRAINT [FK_BufeDugunSpaSineOto_Isyeri_Tipi] FOREIGN KEY([Isyeri_Tipi])
REFERENCES [dbo].[Isyeri_Tipi] ([Isyeri_Tipi_ID])
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto] CHECK CONSTRAINT [FK_BufeDugunSpaSineOto_Isyeri_Tipi]
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto]  WITH CHECK ADD  CONSTRAINT [FK_BufeDugunSpaSineOto_Isyerleri] FOREIGN KEY([Isyeri_ID])
REFERENCES [dbo].[Isyerleri] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto] CHECK CONSTRAINT [FK_BufeDugunSpaSineOto_Isyerleri]
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto]  WITH CHECK ADD  CONSTRAINT [FK_BufeDugunSpaSineOto_Otopark_Turu] FOREIGN KEY([Otopark_Turu])
REFERENCES [dbo].[Otopark_Turu] ([Otopark_Tur_ID])
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto] CHECK CONSTRAINT [FK_BufeDugunSpaSineOto_Otopark_Turu]
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto]  WITH CHECK ADD  CONSTRAINT [FK_BufeDugunSpaSineOto_Yapi_Tipi] FOREIGN KEY([Yapi_Tipi])
REFERENCES [dbo].[Yapi_Tipi] ([ID])
GO
ALTER TABLE [dbo].[BufeDugunSpaSineOto] CHECK CONSTRAINT [FK_BufeDugunSpaSineOto_Yapi_Tipi]
GO
ALTER TABLE [dbo].[DepoBinaPlazaFabrika]  WITH CHECK ADD  CONSTRAINT [FK_DepoBinaPlazaFabrika_Bina_Tipi] FOREIGN KEY([Bina_Tipi_ID])
REFERENCES [dbo].[Bina_Tipi] ([Bina_Tipi_ID])
GO
ALTER TABLE [dbo].[DepoBinaPlazaFabrika] CHECK CONSTRAINT [FK_DepoBinaPlazaFabrika_Bina_Tipi]
GO
ALTER TABLE [dbo].[DepoBinaPlazaFabrika]  WITH CHECK ADD  CONSTRAINT [FK_DepoBinaPlazaFabrika_Bulundugu_Kat] FOREIGN KEY([Bulundugu_Kat])
REFERENCES [dbo].[Bulundugu_Kat] ([Bulundugu_Kat_ID])
GO
ALTER TABLE [dbo].[DepoBinaPlazaFabrika] CHECK CONSTRAINT [FK_DepoBinaPlazaFabrika_Bulundugu_Kat]
GO
ALTER TABLE [dbo].[DepoBinaPlazaFabrika]  WITH CHECK ADD  CONSTRAINT [FK_DepoBinaPlazaFabrika_Depo_Tapu_Durumu] FOREIGN KEY([Tapu_Durumu])
REFERENCES [dbo].[Depo_Tapu_Durumu] ([Tapu_Durumu_ID])
GO
ALTER TABLE [dbo].[DepoBinaPlazaFabrika] CHECK CONSTRAINT [FK_DepoBinaPlazaFabrika_Depo_Tapu_Durumu]
GO
ALTER TABLE [dbo].[DepoBinaPlazaFabrika]  WITH CHECK ADD  CONSTRAINT [FK_DepoBinaPlazaFabrika_Isyeri_Tipi] FOREIGN KEY([Isyeri_Tipi])
REFERENCES [dbo].[Isyeri_Tipi] ([Isyeri_Tipi_ID])
GO
ALTER TABLE [dbo].[DepoBinaPlazaFabrika] CHECK CONSTRAINT [FK_DepoBinaPlazaFabrika_Isyeri_Tipi]
GO
ALTER TABLE [dbo].[DepoBinaPlazaFabrika]  WITH CHECK ADD  CONSTRAINT [FK_DepoBinaPlazaFabrika_Isyerleri] FOREIGN KEY([Isyeri_ID])
REFERENCES [dbo].[Isyerleri] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DepoBinaPlazaFabrika] CHECK CONSTRAINT [FK_DepoBinaPlazaFabrika_Isyerleri]
GO
ALTER TABLE [dbo].[Emlak]  WITH CHECK ADD  CONSTRAINT [FK_Emlak_Emlak_Turu] FOREIGN KEY([ilan_Tur_ID])
REFERENCES [dbo].[Emlak_Turu] ([Emlak_Tur_ID])
GO
ALTER TABLE [dbo].[Emlak] CHECK CONSTRAINT [FK_Emlak_Emlak_Turu]
GO
ALTER TABLE [dbo].[Emlak]  WITH CHECK ADD  CONSTRAINT [FK_Emlak_Ilan_Sahipleri] FOREIGN KEY([ilan_Veren])
REFERENCES [dbo].[Ilan_Sahipleri] ([Sahip_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Emlak] CHECK CONSTRAINT [FK_Emlak_Ilan_Sahipleri]
GO
ALTER TABLE [dbo].[Emlak]  WITH CHECK ADD  CONSTRAINT [FK_Emlak_Satis_Turu] FOREIGN KEY([Satis_Tur])
REFERENCES [dbo].[Satis_Turu] ([Satis_Turu_ID])
GO
ALTER TABLE [dbo].[Emlak] CHECK CONSTRAINT [FK_Emlak_Satis_Turu]
GO
ALTER TABLE [dbo].[Emlak]  WITH CHECK ADD  CONSTRAINT [FK_Emlak_SemtMah] FOREIGN KEY([Mahalle])
REFERENCES [dbo].[SemtMah] ([SemtMahId])
GO
ALTER TABLE [dbo].[Emlak] CHECK CONSTRAINT [FK_Emlak_SemtMah]
GO
ALTER TABLE [dbo].[Ilceler]  WITH CHECK ADD  CONSTRAINT [FK_Ilceler_Sehirler] FOREIGN KEY([SehirId])
REFERENCES [dbo].[Sehirler] ([SehirId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ilceler] CHECK CONSTRAINT [FK_Ilceler_Sehirler]
GO
ALTER TABLE [dbo].[Isyerleri]  WITH CHECK ADD  CONSTRAINT [FK_Isyerleri_Emlak] FOREIGN KEY([ilan_No])
REFERENCES [dbo].[Emlak] ([ilan_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Isyerleri] CHECK CONSTRAINT [FK_Isyerleri_Emlak]
GO
ALTER TABLE [dbo].[Isyerleri]  WITH CHECK ADD  CONSTRAINT [FK_Isyerleri_Isitma] FOREIGN KEY([Isitma_ID])
REFERENCES [dbo].[Isitma] ([Isitma_ID])
GO
ALTER TABLE [dbo].[Isyerleri] CHECK CONSTRAINT [FK_Isyerleri_Isitma]
GO
ALTER TABLE [dbo].[Isyerleri]  WITH CHECK ADD  CONSTRAINT [FK_Isyerleri_Isyeri_Gruplari] FOREIGN KEY([Isyeri_Grubu])
REFERENCES [dbo].[Isyeri_Gruplari] ([Isyeri_Grup_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Isyerleri] CHECK CONSTRAINT [FK_Isyerleri_Isyeri_Gruplari]
GO
ALTER TABLE [dbo].[Konut]  WITH CHECK ADD  CONSTRAINT [FK_Konut_Bulundugu_Kat] FOREIGN KEY([Bulundugu_Kat_ID])
REFERENCES [dbo].[Bulundugu_Kat] ([Bulundugu_Kat_ID])
GO
ALTER TABLE [dbo].[Konut] CHECK CONSTRAINT [FK_Konut_Bulundugu_Kat]
GO
ALTER TABLE [dbo].[Konut]  WITH CHECK ADD  CONSTRAINT [FK_Konut_Emlak] FOREIGN KEY([ilan_No])
REFERENCES [dbo].[Emlak] ([ilan_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Konut] CHECK CONSTRAINT [FK_Konut_Emlak]
GO
ALTER TABLE [dbo].[Konut]  WITH CHECK ADD  CONSTRAINT [FK_Konut_Isitma] FOREIGN KEY([Isitma_ID])
REFERENCES [dbo].[Isitma] ([Isitma_ID])
GO
ALTER TABLE [dbo].[Konut] CHECK CONSTRAINT [FK_Konut_Isitma]
GO
ALTER TABLE [dbo].[Konut]  WITH CHECK ADD  CONSTRAINT [FK_Konut_Konut_Tip] FOREIGN KEY([Konut_Tip_ID])
REFERENCES [dbo].[Konut_Tip] ([Konut_Tip_ID])
GO
ALTER TABLE [dbo].[Konut] CHECK CONSTRAINT [FK_Konut_Konut_Tip]
GO
ALTER TABLE [dbo].[Konut]  WITH CHECK ADD  CONSTRAINT [FK_Konut_Oda_Sayisi] FOREIGN KEY([Oda_Sayisi_ID])
REFERENCES [dbo].[Oda_Sayisi] ([Oda_Sayisi_ID])
GO
ALTER TABLE [dbo].[Konut] CHECK CONSTRAINT [FK_Konut_Oda_Sayisi]
GO
ALTER TABLE [dbo].[SemtMah]  WITH CHECK ADD  CONSTRAINT [FK_SemtMah_Ilceler] FOREIGN KEY([ilceId])
REFERENCES [dbo].[Ilceler] ([ilceId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SemtMah] CHECK CONSTRAINT [FK_SemtMah_Ilceler]
GO
ALTER TABLE [dbo].[SporRadyoPazarCiftlik]  WITH CHECK ADD  CONSTRAINT [FK_SporRadyoPazarCiftlik_Isyeri_Tipi] FOREIGN KEY([Isyeri_tipi])
REFERENCES [dbo].[Isyeri_Tipi] ([Isyeri_Tipi_ID])
GO
ALTER TABLE [dbo].[SporRadyoPazarCiftlik] CHECK CONSTRAINT [FK_SporRadyoPazarCiftlik_Isyeri_Tipi]
GO
ALTER TABLE [dbo].[SporRadyoPazarCiftlik]  WITH CHECK ADD  CONSTRAINT [FK_SporRadyoPazarCiftlik_Isyerleri] FOREIGN KEY([Isyeri_ID])
REFERENCES [dbo].[Isyerleri] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SporRadyoPazarCiftlik] CHECK CONSTRAINT [FK_SporRadyoPazarCiftlik_Isyerleri]
GO
ALTER TABLE [dbo].[SporRadyoPazarCiftlik]  WITH CHECK ADD  CONSTRAINT [FK_SporRadyoPazarCiftlik_SporTesis_Turu] FOREIGN KEY([SporTesis_Tipi])
REFERENCES [dbo].[SporTesis_Turu] ([Tesis_ID])
GO
ALTER TABLE [dbo].[SporRadyoPazarCiftlik] CHECK CONSTRAINT [FK_SporRadyoPazarCiftlik_SporTesis_Turu]
GO
ALTER TABLE [dbo].[Turistik_Tesis]  WITH CHECK ADD  CONSTRAINT [FK_Turistik_Tesis_Emlak] FOREIGN KEY([ilan_NO])
REFERENCES [dbo].[Emlak] ([ilan_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Turistik_Tesis] CHECK CONSTRAINT [FK_Turistik_Tesis_Emlak]
GO
ALTER TABLE [dbo].[Turistik_Tesis]  WITH CHECK ADD  CONSTRAINT [FK_Turistik_Tesis_TT_Tip] FOREIGN KEY([TT_Tipi])
REFERENCES [dbo].[TT_Tip] ([TT_Tip_ID])
GO
ALTER TABLE [dbo].[Turistik_Tesis] CHECK CONSTRAINT [FK_Turistik_Tesis_TT_Tip]
GO
/****** Object:  StoredProcedure [dbo].[deney]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deney]
as
begin
	declare @id int;
	declare @ad nvarchar(30);
	declare Sehir cursor for select SehirId, SehirAdi from Sehirler;
	open sehir
	Fetch next from sehir into @id, @ad
	While @@FETCH_STATUS = 0
	BEgin
		If (@id > 20 and @id < 50)
		 insert into test values(@id, @ad)
		fetch next from sehir into @id, @ad
	end
	close sehir
end
GO
/****** Object:  StoredProcedure [dbo].[sil]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sil]
as
begin
	truncate table test
end
GO
/****** Object:  StoredProcedure [dbo].[tablosil]    Script Date: 02-Mar-17 1:06:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[tablosil]
@ad varchar(15)
as
begin
	set nocount on
	declare @sql nvarchar(MAX)
	set @sql = 'drop table ' + @ad
	exec sp_executesql @sql
end
GO
USE [master]
GO
ALTER DATABASE [AraVer] SET  READ_WRITE 
GO
