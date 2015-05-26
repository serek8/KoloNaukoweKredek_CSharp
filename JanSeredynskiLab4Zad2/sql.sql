USE [master]
GO
/****** Object:  Database [GamePokemon]    Script Date: 5/26/2015 3:58:16 AM ******/
CREATE DATABASE [GamePokemon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GamePokemon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\GamePokemon.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GamePokemon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\GamePokemon_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GamePokemon] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GamePokemon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GamePokemon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GamePokemon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GamePokemon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GamePokemon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GamePokemon] SET ARITHABORT OFF 
GO
ALTER DATABASE [GamePokemon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GamePokemon] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [GamePokemon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GamePokemon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GamePokemon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GamePokemon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GamePokemon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GamePokemon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GamePokemon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GamePokemon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GamePokemon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GamePokemon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GamePokemon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GamePokemon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GamePokemon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GamePokemon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GamePokemon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GamePokemon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GamePokemon] SET RECOVERY FULL 
GO
ALTER DATABASE [GamePokemon] SET  MULTI_USER 
GO
ALTER DATABASE [GamePokemon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GamePokemon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GamePokemon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GamePokemon] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'GamePokemon', N'ON'
GO
USE [GamePokemon]
GO
/****** Object:  Table [dbo].[FightBonus]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FightBonus](
	[PokemonTypeAgressorID] [int] NOT NULL,
	[PokemonTypeDefenderID] [int] NOT NULL,
	[BonusRate] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FightResult]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FightResult](
	[FightID] [int] IDENTITY(1,1) NOT NULL,
	[UserAgressorID] [int] NOT NULL,
	[UserDefenderID] [int] NOT NULL,
	[PokemonAgressor1ID] [int] NOT NULL,
	[PokemonAgressor2ID] [int] NOT NULL,
	[PokemonAgressor3ID] [int] NOT NULL,
	[PokemonDefender1ID] [int] NOT NULL,
	[PokemonDefender2ID] [int] NOT NULL,
	[PokemonDefender3ID] [int] NOT NULL,
	[Result] [int] NULL,
	[ResultDescription] [varchar](50) NULL,
	[ResultDate] [date] NULL,
 CONSTRAINT [PK_FightResult] PRIMARY KEY CLUSTERED 
(
	[FightID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pokemon]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pokemon](
	[PokemonID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[PokemonTypeID] [int] NOT NULL,
	[DamageRate] [int] NOT NULL,
	[HitPoint] [int] NOT NULL,
	[Cost] [int] NOT NULL,
 CONSTRAINT [PK_Pokemon] PRIMARY KEY CLUSTERED 
(
	[PokemonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PokemonType]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PokemonType](
	[PokemonTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PokemonType] PRIMARY KEY CLUSTERED 
(
	[PokemonTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PokemonTypeAgressor]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PokemonTypeAgressor](
	[PokemonTypeAgressorID] [int] IDENTITY(1,1) NOT NULL,
	[PokemonTypeID] [int] NOT NULL,
 CONSTRAINT [PK_PokemonTypeAgressor] PRIMARY KEY CLUSTERED 
(
	[PokemonTypeAgressorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PokemonTypeDefender]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PokemonTypeDefender](
	[PokemonTypeDefenderID] [int] IDENTITY(1,1) NOT NULL,
	[PokemonTypeID] [int] NOT NULL,
 CONSTRAINT [PK_PokemonTypeDefender] PRIMARY KEY CLUSTERED 
(
	[PokemonTypeDefenderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Money] [int] NOT NULL,
	[Point] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserPokemonList]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPokemonList](
	[PokemonListID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[PokemonID] [int] NOT NULL,
 CONSTRAINT [PK_UserPokemonList] PRIMARY KEY CLUSTERED 
(
	[PokemonListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_FightBonus_PokemonType]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_FightBonus_PokemonType]
AS
SELECT        dbo.PokemonType.PokemonTypeID AS IDPokemonTypeAgressor, dbo.PokemonType.Name AS PokemonTypeNameAgressor, dbo.FightBonus.BonusRate, PokemonType_1.Name AS PokemonTypeNameDefender, 
                         PokemonType_1.PokemonTypeID AS IDPokemonTypeDefender
FROM            dbo.PokemonTypeDefender INNER JOIN
                         dbo.PokemonType AS PokemonType_1 ON dbo.PokemonTypeDefender.PokemonTypeID = PokemonType_1.PokemonTypeID INNER JOIN
                         dbo.PokemonType INNER JOIN
                         dbo.PokemonTypeAgressor ON dbo.PokemonType.PokemonTypeID = dbo.PokemonTypeAgressor.PokemonTypeID INNER JOIN
                         dbo.FightBonus ON dbo.PokemonTypeAgressor.PokemonTypeAgressorID = dbo.FightBonus.PokemonTypeAgressorID ON 
                         dbo.PokemonTypeDefender.PokemonTypeDefenderID = dbo.FightBonus.PokemonTypeDefenderID

GO
/****** Object:  View [dbo].[View_Pokemon_User_PokemonView]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Pokemon_User_PokemonView]
AS
SELECT        dbo.UserPokemonList.UserID, dbo.Pokemon.Name
FROM            dbo.Pokemon INNER JOIN
                         dbo.UserPokemonList ON dbo.Pokemon.PokemonID = dbo.UserPokemonList.PokemonID

GO
/****** Object:  View [dbo].[View_PokemonType_Pokemon]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_PokemonType_Pokemon]
AS
SELECT        dbo.PokemonType.Name AS PokemonTypeName, dbo.Pokemon.PokemonTypeID, dbo.Pokemon.DamageRate, dbo.Pokemon.HitPoint, dbo.Pokemon.Name AS PokemonName, dbo.Pokemon.Cost
FROM            dbo.PokemonType INNER JOIN
                         dbo.Pokemon ON dbo.PokemonType.PokemonTypeID = dbo.Pokemon.PokemonTypeID

GO
/****** Object:  View [dbo].[View_User_PokemonList]    Script Date: 5/26/2015 3:58:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_User_PokemonList]
AS
SELECT        dbo.UserPokemonList.UserID, dbo.Pokemon.Name, dbo.Pokemon.DamageRate, dbo.Pokemon.HitPoint, dbo.Pokemon.Cost
FROM            dbo.Pokemon INNER JOIN
                         dbo.UserPokemonList ON dbo.Pokemon.PokemonID = dbo.UserPokemonList.PokemonID

GO
INSERT [dbo].[FightBonus] ([PokemonTypeAgressorID], [PokemonTypeDefenderID], [BonusRate]) VALUES (4, 3, 10)
INSERT [dbo].[FightBonus] ([PokemonTypeAgressorID], [PokemonTypeDefenderID], [BonusRate]) VALUES (2, 4, 11)
INSERT [dbo].[FightBonus] ([PokemonTypeAgressorID], [PokemonTypeDefenderID], [BonusRate]) VALUES (3, 1, 8)
INSERT [dbo].[FightBonus] ([PokemonTypeAgressorID], [PokemonTypeDefenderID], [BonusRate]) VALUES (2, 6, 3)
INSERT [dbo].[FightBonus] ([PokemonTypeAgressorID], [PokemonTypeDefenderID], [BonusRate]) VALUES (6, 3, 5)
INSERT [dbo].[FightBonus] ([PokemonTypeAgressorID], [PokemonTypeDefenderID], [BonusRate]) VALUES (3, 7, 9)
INSERT [dbo].[FightBonus] ([PokemonTypeAgressorID], [PokemonTypeDefenderID], [BonusRate]) VALUES (5, 4, 6)
SET IDENTITY_INSERT [dbo].[FightResult] ON 

INSERT [dbo].[FightResult] ([FightID], [UserAgressorID], [UserDefenderID], [PokemonAgressor1ID], [PokemonAgressor2ID], [PokemonAgressor3ID], [PokemonDefender1ID], [PokemonDefender2ID], [PokemonDefender3ID], [Result], [ResultDescription], [ResultDate]) VALUES (15, 2, 1, 1, 5, 2, 0, 0, 0, 0, N'Mecz zakonczono remisem', NULL)
INSERT [dbo].[FightResult] ([FightID], [UserAgressorID], [UserDefenderID], [PokemonAgressor1ID], [PokemonAgressor2ID], [PokemonAgressor3ID], [PokemonDefender1ID], [PokemonDefender2ID], [PokemonDefender3ID], [Result], [ResultDescription], [ResultDate]) VALUES (16, 1, 2, 1, 2, 3, 0, 0, 0, 2, N'Mecz wygral janek', NULL)
INSERT [dbo].[FightResult] ([FightID], [UserAgressorID], [UserDefenderID], [PokemonAgressor1ID], [PokemonAgressor2ID], [PokemonAgressor3ID], [PokemonDefender1ID], [PokemonDefender2ID], [PokemonDefender3ID], [Result], [ResultDescription], [ResultDate]) VALUES (17, 1, 2, 2, 1, 3, 0, 0, 0, 2, N'Mecz wygral janek', NULL)
SET IDENTITY_INSERT [dbo].[FightResult] OFF
SET IDENTITY_INSERT [dbo].[Pokemon] ON 

INSERT [dbo].[Pokemon] ([PokemonID], [Name], [PokemonTypeID], [DamageRate], [HitPoint], [Cost]) VALUES (1, N'Pikatchu', 9, 6, 40, 100)
INSERT [dbo].[Pokemon] ([PokemonID], [Name], [PokemonTypeID], [DamageRate], [HitPoint], [Cost]) VALUES (2, N'Bellsprout', 5, 8, 45, 80)
INSERT [dbo].[Pokemon] ([PokemonID], [Name], [PokemonTypeID], [DamageRate], [HitPoint], [Cost]) VALUES (3, N'Bulbasaur', 10, 10, 50, 100)
INSERT [dbo].[Pokemon] ([PokemonID], [Name], [PokemonTypeID], [DamageRate], [HitPoint], [Cost]) VALUES (4, N'Caterpie', 5, 10, 40, 38)
INSERT [dbo].[Pokemon] ([PokemonID], [Name], [PokemonTypeID], [DamageRate], [HitPoint], [Cost]) VALUES (5, N'Chalizard', 8, 14, 60, 250)
INSERT [dbo].[Pokemon] ([PokemonID], [Name], [PokemonTypeID], [DamageRate], [HitPoint], [Cost]) VALUES (6, N'Horsea', 7, 4, 40, 70)
INSERT [dbo].[Pokemon] ([PokemonID], [Name], [PokemonTypeID], [DamageRate], [HitPoint], [Cost]) VALUES (7, N'Koffing', 11, 12, 80, 200)
INSERT [dbo].[Pokemon] ([PokemonID], [Name], [PokemonTypeID], [DamageRate], [HitPoint], [Cost]) VALUES (8, N'Marovak', 10, 14, 70, 200)
INSERT [dbo].[Pokemon] ([PokemonID], [Name], [PokemonTypeID], [DamageRate], [HitPoint], [Cost]) VALUES (9, N'Squirtle', 7, 6, 48, 50)
INSERT [dbo].[Pokemon] ([PokemonID], [Name], [PokemonTypeID], [DamageRate], [HitPoint], [Cost]) VALUES (10, N'Vulpix', 8, 8, 40, 50)
SET IDENTITY_INSERT [dbo].[Pokemon] OFF
SET IDENTITY_INSERT [dbo].[PokemonType] ON 

INSERT [dbo].[PokemonType] ([PokemonTypeID], [Name]) VALUES (9, N'elektrycznosc')
INSERT [dbo].[PokemonType] ([PokemonTypeID], [Name]) VALUES (8, N'ogien')
INSERT [dbo].[PokemonType] ([PokemonTypeID], [Name]) VALUES (5, N'roslina')
INSERT [dbo].[PokemonType] ([PokemonTypeID], [Name]) VALUES (11, N'trucizna')
INSERT [dbo].[PokemonType] ([PokemonTypeID], [Name]) VALUES (7, N'woda')
INSERT [dbo].[PokemonType] ([PokemonTypeID], [Name]) VALUES (10, N'ziemia')
SET IDENTITY_INSERT [dbo].[PokemonType] OFF
SET IDENTITY_INSERT [dbo].[PokemonTypeAgressor] ON 

INSERT [dbo].[PokemonTypeAgressor] ([PokemonTypeAgressorID], [PokemonTypeID]) VALUES (1, 5)
INSERT [dbo].[PokemonTypeAgressor] ([PokemonTypeAgressorID], [PokemonTypeID]) VALUES (2, 7)
INSERT [dbo].[PokemonTypeAgressor] ([PokemonTypeAgressorID], [PokemonTypeID]) VALUES (3, 8)
INSERT [dbo].[PokemonTypeAgressor] ([PokemonTypeAgressorID], [PokemonTypeID]) VALUES (4, 9)
INSERT [dbo].[PokemonTypeAgressor] ([PokemonTypeAgressorID], [PokemonTypeID]) VALUES (5, 10)
INSERT [dbo].[PokemonTypeAgressor] ([PokemonTypeAgressorID], [PokemonTypeID]) VALUES (6, 11)
SET IDENTITY_INSERT [dbo].[PokemonTypeAgressor] OFF
SET IDENTITY_INSERT [dbo].[PokemonTypeDefender] ON 

INSERT [dbo].[PokemonTypeDefender] ([PokemonTypeDefenderID], [PokemonTypeID]) VALUES (1, 5)
INSERT [dbo].[PokemonTypeDefender] ([PokemonTypeDefenderID], [PokemonTypeID]) VALUES (3, 7)
INSERT [dbo].[PokemonTypeDefender] ([PokemonTypeDefenderID], [PokemonTypeID]) VALUES (4, 8)
INSERT [dbo].[PokemonTypeDefender] ([PokemonTypeDefenderID], [PokemonTypeID]) VALUES (5, 9)
INSERT [dbo].[PokemonTypeDefender] ([PokemonTypeDefenderID], [PokemonTypeID]) VALUES (6, 10)
INSERT [dbo].[PokemonTypeDefender] ([PokemonTypeDefenderID], [PokemonTypeID]) VALUES (7, 11)
SET IDENTITY_INSERT [dbo].[PokemonTypeDefender] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [Name], [Password], [Money], [Point]) VALUES (1, N'test1', N'testH', 212, 0)
INSERT [dbo].[User] ([UserID], [Name], [Password], [Money], [Point]) VALUES (2, N'janek', N'janek', 280, 0)
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[UserPokemonList] ON 

INSERT [dbo].[UserPokemonList] ([PokemonListID], [UserID], [PokemonID]) VALUES (1, 2, 3)
INSERT [dbo].[UserPokemonList] ([PokemonListID], [UserID], [PokemonID]) VALUES (2, 2, 1)
INSERT [dbo].[UserPokemonList] ([PokemonListID], [UserID], [PokemonID]) VALUES (3, 2, 10)
INSERT [dbo].[UserPokemonList] ([PokemonListID], [UserID], [PokemonID]) VALUES (4, 2, 10)
INSERT [dbo].[UserPokemonList] ([PokemonListID], [UserID], [PokemonID]) VALUES (5, 2, 6)
INSERT [dbo].[UserPokemonList] ([PokemonListID], [UserID], [PokemonID]) VALUES (6, 1, 4)
INSERT [dbo].[UserPokemonList] ([PokemonListID], [UserID], [PokemonID]) VALUES (7, 1, 8)
INSERT [dbo].[UserPokemonList] ([PokemonListID], [UserID], [PokemonID]) VALUES (8, 1, 10)
SET IDENTITY_INSERT [dbo].[UserPokemonList] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_Pokemon_Name]    Script Date: 5/26/2015 3:58:16 AM ******/
ALTER TABLE [dbo].[Pokemon] ADD  CONSTRAINT [UK_Pokemon_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_PokemonType_Name]    Script Date: 5/26/2015 3:58:16 AM ******/
ALTER TABLE [dbo].[PokemonType] ADD  CONSTRAINT [UK_PokemonType_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UK_PokemonTypeAgressorIDPokemonType]    Script Date: 5/26/2015 3:58:16 AM ******/
ALTER TABLE [dbo].[PokemonTypeAgressor] ADD  CONSTRAINT [UK_PokemonTypeAgressorIDPokemonType] UNIQUE NONCLUSTERED 
(
	[PokemonTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UK_PokemonTypeDefenderIDPokemonType]    Script Date: 5/26/2015 3:58:16 AM ******/
ALTER TABLE [dbo].[PokemonTypeDefender] ADD  CONSTRAINT [UK_PokemonTypeDefenderIDPokemonType] UNIQUE NONCLUSTERED 
(
	[PokemonTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UK_User_Name]    Script Date: 5/26/2015 3:58:16 AM ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [UK_User_Name] UNIQUE NONCLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FightResult] ADD  CONSTRAINT [DF_FightResult_Result]  DEFAULT (NULL) FOR [Result]
GO
ALTER TABLE [dbo].[FightBonus]  WITH CHECK ADD  CONSTRAINT [FK_FightBonus_PokemonTypeAgressor] FOREIGN KEY([PokemonTypeAgressorID])
REFERENCES [dbo].[PokemonTypeAgressor] ([PokemonTypeAgressorID])
GO
ALTER TABLE [dbo].[FightBonus] CHECK CONSTRAINT [FK_FightBonus_PokemonTypeAgressor]
GO
ALTER TABLE [dbo].[FightBonus]  WITH CHECK ADD  CONSTRAINT [FK_FightBonus_PokemonTypeDefender] FOREIGN KEY([PokemonTypeDefenderID])
REFERENCES [dbo].[PokemonTypeDefender] ([PokemonTypeDefenderID])
GO
ALTER TABLE [dbo].[FightBonus] CHECK CONSTRAINT [FK_FightBonus_PokemonTypeDefender]
GO
ALTER TABLE [dbo].[Pokemon]  WITH CHECK ADD  CONSTRAINT [FK_Pokemon_PokemonType] FOREIGN KEY([PokemonTypeID])
REFERENCES [dbo].[PokemonType] ([PokemonTypeID])
GO
ALTER TABLE [dbo].[Pokemon] CHECK CONSTRAINT [FK_Pokemon_PokemonType]
GO
ALTER TABLE [dbo].[PokemonTypeAgressor]  WITH CHECK ADD  CONSTRAINT [FK_PokemonTypeAgressor_PokemonType] FOREIGN KEY([PokemonTypeID])
REFERENCES [dbo].[PokemonType] ([PokemonTypeID])
GO
ALTER TABLE [dbo].[PokemonTypeAgressor] CHECK CONSTRAINT [FK_PokemonTypeAgressor_PokemonType]
GO
ALTER TABLE [dbo].[PokemonTypeDefender]  WITH CHECK ADD  CONSTRAINT [FK_PokemonTypeDefender_PokemonType] FOREIGN KEY([PokemonTypeID])
REFERENCES [dbo].[PokemonType] ([PokemonTypeID])
GO
ALTER TABLE [dbo].[PokemonTypeDefender] CHECK CONSTRAINT [FK_PokemonTypeDefender_PokemonType]
GO
ALTER TABLE [dbo].[UserPokemonList]  WITH CHECK ADD  CONSTRAINT [FK_UserPokemonList_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[UserPokemonList] CHECK CONSTRAINT [FK_UserPokemonList_User]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PokemonType"
            Begin Extent = 
               Top = 29
               Left = 33
               Bottom = 142
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PokemonTypeAgressor"
            Begin Extent = 
               Top = 29
               Left = 358
               Bottom = 125
               Right = 581
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PokemonTypeDefender"
            Begin Extent = 
               Top = 190
               Left = 429
               Bottom = 286
               Right = 654
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PokemonType_1"
            Begin Extent = 
               Top = 202
               Left = 123
               Bottom = 300
               Right = 321
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FightBonus"
            Begin Extent = 
               Top = 25
               Left = 769
               Bottom = 138
               Right = 994
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 2895
         Width = 2355
         Width = 2670
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_FightBonus_PokemonType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' = 3780
         Alias = 3360
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_FightBonus_PokemonType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_FightBonus_PokemonType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Pokemon"
            Begin Extent = 
               Top = 46
               Left = 539
               Bottom = 222
               Right = 772
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UserPokemonList"
            Begin Extent = 
               Top = 39
               Left = 152
               Bottom = 170
               Right = 345
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Pokemon_User_PokemonView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Pokemon_User_PokemonView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PokemonType"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 160
               Right = 259
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pokemon"
            Begin Extent = 
               Top = 91
               Left = 381
               Bottom = 286
               Right = 658
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 2055
         Table = 1995
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PokemonType_Pokemon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PokemonType_Pokemon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Pokemon"
            Begin Extent = 
               Top = 46
               Left = 539
               Bottom = 222
               Right = 772
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UserPokemonList"
            Begin Extent = 
               Top = 39
               Left = 152
               Bottom = 170
               Right = 345
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_User_PokemonList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_User_PokemonList'
GO
USE [master]
GO
ALTER DATABASE [GamePokemon] SET  READ_WRITE 
GO
