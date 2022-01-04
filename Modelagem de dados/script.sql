USE [master]
GO
/****** Object:  Database [ViajamarDb]    Script Date: 03/01/2022 23:04:41 ******/
CREATE DATABASE [ViajamarDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ViajamarDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVERDEV2019\MSSQL\DATA\ViajamarDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ViajamarDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVERDEV2019\MSSQL\DATA\ViajamarDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ViajamarDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ViajamarDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ViajamarDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ViajamarDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ViajamarDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ViajamarDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ViajamarDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ViajamarDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ViajamarDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ViajamarDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ViajamarDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ViajamarDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ViajamarDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ViajamarDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ViajamarDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ViajamarDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ViajamarDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ViajamarDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ViajamarDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ViajamarDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ViajamarDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ViajamarDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ViajamarDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ViajamarDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ViajamarDb] SET RECOVERY FULL 
GO
ALTER DATABASE [ViajamarDb] SET  MULTI_USER 
GO
ALTER DATABASE [ViajamarDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ViajamarDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ViajamarDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ViajamarDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ViajamarDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ViajamarDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ViajamarDb', N'ON'
GO
ALTER DATABASE [ViajamarDb] SET QUERY_STORE = OFF
GO
USE [ViajamarDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 03/01/2022 23:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[atendimento]    Script Date: 03/01/2022 23:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[atendimento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](max) NOT NULL,
	[telefone] [int] NOT NULL,
	[email] [nvarchar](max) NOT NULL,
	[mensagem] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_atendimento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 03/01/2022 23:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](max) NULL,
	[CPF] [int] NOT NULL,
	[telefone] [int] NOT NULL,
	[email] [nvarchar](max) NULL,
	[nascimento] [datetime2](7) NOT NULL,
	[Comprasid] [int] NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compras]    Script Date: 03/01/2022 23:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compras](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCompra] [int] NOT NULL,
	[idComprador] [int] NOT NULL,
	[Ida] [datetime2](7) NOT NULL,
	[Volta] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_compras] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[destinos]    Script Date: 03/01/2022 23:04:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[destinos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[local] [nvarchar](max) NOT NULL,
	[quantidade] [int] NOT NULL,
 CONSTRAINT [PK_destinos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_clientes_Comprasid]    Script Date: 03/01/2022 23:04:42 ******/
CREATE NONCLUSTERED INDEX [IX_clientes_Comprasid] ON [dbo].[clientes]
(
	[Comprasid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_compras_Comprasid] FOREIGN KEY([Comprasid])
REFERENCES [dbo].[compras] ([id])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_compras_Comprasid]
GO
USE [master]
GO
ALTER DATABASE [ViajamarDb] SET  READ_WRITE 
GO
