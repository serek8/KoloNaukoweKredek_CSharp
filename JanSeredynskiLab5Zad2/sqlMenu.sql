USE [master]
GO
/****** Object:  Database [PizzaMenu]    Script Date: 6/2/2015 3:43:19 AM ******/
CREATE DATABASE [PizzaMenu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PizzaMenu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\PizzaMenu.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PizzaMenu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\PizzaMenu_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PizzaMenu] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PizzaMenu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PizzaMenu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PizzaMenu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PizzaMenu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PizzaMenu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PizzaMenu] SET ARITHABORT OFF 
GO
ALTER DATABASE [PizzaMenu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PizzaMenu] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [PizzaMenu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PizzaMenu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PizzaMenu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PizzaMenu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PizzaMenu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PizzaMenu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PizzaMenu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PizzaMenu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PizzaMenu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PizzaMenu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PizzaMenu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PizzaMenu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PizzaMenu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PizzaMenu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PizzaMenu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PizzaMenu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PizzaMenu] SET RECOVERY FULL 
GO
ALTER DATABASE [PizzaMenu] SET  MULTI_USER 
GO
ALTER DATABASE [PizzaMenu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PizzaMenu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PizzaMenu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PizzaMenu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PizzaMenu', N'ON'
GO
USE [PizzaMenu]
GO
/****** Object:  Table [dbo].[Pizza]    Script Date: 6/2/2015 3:43:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pizza](
	[PizzaMenuID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Ingredient] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Pizza] PRIMARY KEY CLUSTERED 
(
	[PizzaMenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Pizza] ON 

INSERT [dbo].[Pizza] ([PizzaMenuID], [Name], [Ingredient], [Price]) VALUES (2, N'Fungi', N'pieczarki, sos pomidorowy, ser', 18)
INSERT [dbo].[Pizza] ([PizzaMenuID], [Name], [Ingredient], [Price]) VALUES (3, N'CAPRICIOSA', N' szynka, pieczarki, sos pomidorowy, ser', 22)
INSERT [dbo].[Pizza] ([PizzaMenuID], [Name], [Ingredient], [Price]) VALUES (6, N'PEPERONI  ', N'peperoni, cebula, sos pomidorowy, ser', 24)
INSERT [dbo].[Pizza] ([PizzaMenuID], [Name], [Ingredient], [Price]) VALUES (8, N'HAWAJSKA', N'szynka, ananas, sos pomidorowy, ser', 27)
INSERT [dbo].[Pizza] ([PizzaMenuID], [Name], [Ingredient], [Price]) VALUES (9, N'BARBADOS ', N' Kurczak, ananas, sos Jalapeño, ser', 27)
INSERT [dbo].[Pizza] ([PizzaMenuID], [Name], [Ingredient], [Price]) VALUES (17, N'NEAPOLITANA', N'peperoni, oliwki czarne, papryka Jalapeno, ser', 30)
INSERT [dbo].[Pizza] ([PizzaMenuID], [Name], [Ingredient], [Price]) VALUES (19, N'CARBONARA', N'bekon, cebula, pieczarki, ekstra ser', 37)
SET IDENTITY_INSERT [dbo].[Pizza] OFF
USE [master]
GO
ALTER DATABASE [PizzaMenu] SET  READ_WRITE 
GO
