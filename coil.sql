USE [master]
GO
/****** Object:  Database [Coil]    Script Date: 17.12.2021 19:48:11 ******/
CREATE DATABASE [Coil]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Coil', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Coil.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Coil_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Coil_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Coil] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Coil].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Coil] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Coil] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Coil] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Coil] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Coil] SET ARITHABORT OFF 
GO
ALTER DATABASE [Coil] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Coil] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Coil] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Coil] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Coil] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Coil] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Coil] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Coil] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Coil] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Coil] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Coil] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Coil] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Coil] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Coil] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Coil] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Coil] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Coil] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Coil] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Coil] SET  MULTI_USER 
GO
ALTER DATABASE [Coil] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Coil] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Coil] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Coil] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Coil] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Coil] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Coil', N'ON'
GO
ALTER DATABASE [Coil] SET QUERY_STORE = OFF
GO
USE [Coil]
GO
/****** Object:  Table [dbo].[Coil]    Script Date: 17.12.2021 19:48:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coil](
	[RuloKodu] [nvarchar](10) NOT NULL,
	[Genişlik(mm)] [nvarchar](10) NOT NULL,
	[Çap(mm)] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CoilSA]    Script Date: 17.12.2021 19:48:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoilSA](
	[RuloKodu] [nvarchar](10) NOT NULL,
	[SAKod] [nvarchar](50) NULL,
	[Genişlik(mm)] [nvarchar](50) NULL,
	[Çap(mm)] [nvarchar](50) NULL,
	[KoordinatX] [nvarchar](50) NULL,
	[KoordinatY] [nvarchar](50) NULL,
	[PcrName] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stok_Alanı_Ölçü]    Script Date: 17.12.2021 19:48:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stok_Alanı_Ölçü](
	[SAKod] [nvarchar](10) NOT NULL,
	[Genişlik(mm)] [nvarchar](10) NOT NULL,
	[Çap(mm)] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'15.Coil', N'800', N'700')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'16.Coil', N'800', N'700')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'2.Coil', N'1200', N'1230')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'1.Coil', N'1200', N'1230')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'3.Coil', N'1200', N'1230')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'4.Coil', N'1200', N'1230')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'5.Coil', N'900', N'980')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'6.Coil', N'800', N'980')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'7.Coil', N'800', N'960')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'8.Coil', N'900', N'980')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'9.Coil', N'600', N'700')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'10.Coil', N'700', N'800')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'11.Coil', N'600', N'700')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'12.Coil', N'600', N'700')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'13.Coil', N'700', N'800')
INSERT [dbo].[Coil] ([RuloKodu], [Genişlik(mm)], [Çap(mm)]) VALUES (N'14.Coil', N'700', N'850')
GO
INSERT [dbo].[CoilSA] ([RuloKodu], [SAKod], [Genişlik(mm)], [Çap(mm)], [KoordinatX], [KoordinatY], [PcrName]) VALUES (N'5.Coil', N'B1', N'900', N'980', N'361', N'306', N'pcb1')
GO
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'A1', N'1215', N'1215')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'A2', N'1215', N'1215')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'A3', N'1215', N'1215')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'A4', N'1215', N'1215')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'B1', N'940', N'940')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'B2', N'940', N'940')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'B3', N'940', N'940')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'B4', N'940', N'940')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'C1', N'750', N'750')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'C2', N'750', N'750')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'C3', N'750', N'750')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'C4', N'750', N'750')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'D1', N'772', N'772')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'D2', N'772', N'772')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'D3', N'772', N'772')
INSERT [dbo].[Stok_Alanı_Ölçü] ([SAKod], [Genişlik(mm)], [Çap(mm)]) VALUES (N'D4', N'772', N'772')
GO
USE [master]
GO
ALTER DATABASE [Coil] SET  READ_WRITE 
GO
