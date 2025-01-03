USE [WellApps]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 14.05.2024 16:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_ad] [nvarchar](20) NULL,
	[sifre] [nvarchar](40) NULL,
	[eposta] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullaniciAjanda]    Script Date: 14.05.2024 16:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullaniciAjanda](
	[KullaniciAjandaID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[KullaniciAjandaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Olaylar]    Script Date: 14.05.2024 16:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Olaylar](
	[OlayID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAjandaID] [int] NULL,
	[TarihSaat] [datetime] NULL,
	[OlayAdi] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[OlayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[telefonrehberi]    Script Date: 14.05.2024 16:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[telefonrehberi](
	[isim] [nvarchar](50) NULL,
	[soyisim] [nvarchar](50) NULL,
	[telefon_no] [nvarchar](20) NULL,
	[kullanici_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ucaksavasi]    Script Date: 14.05.2024 16:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ucaksavasi](
	[enyuksekskor] [int] NULL,
	[KullaniciId] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KullaniciAjanda]  WITH CHECK ADD  CONSTRAINT [FK_KullaniciAjanda_Kullanici] FOREIGN KEY([KullaniciID])
REFERENCES [dbo].[Kullanici] ([id])
GO
ALTER TABLE [dbo].[KullaniciAjanda] CHECK CONSTRAINT [FK_KullaniciAjanda_Kullanici]
GO
ALTER TABLE [dbo].[Olaylar]  WITH CHECK ADD  CONSTRAINT [FK_Olaylar_KullaniciAjanda] FOREIGN KEY([KullaniciAjandaID])
REFERENCES [dbo].[KullaniciAjanda] ([KullaniciAjandaID])
GO
ALTER TABLE [dbo].[Olaylar] CHECK CONSTRAINT [FK_Olaylar_KullaniciAjanda]
GO
