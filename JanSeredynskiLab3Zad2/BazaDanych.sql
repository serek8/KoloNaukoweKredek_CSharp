USE [master]
GO
/****** Object:  Database [MiniFacebook]    Script Date: 5/19/2015 11:30:51 PM ******/
CREATE DATABASE [MiniFacebook]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MiniFacebook', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\MiniFacebook.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MiniFacebook_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\MiniFacebook_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MiniFacebook] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MiniFacebook].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MiniFacebook] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MiniFacebook] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MiniFacebook] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MiniFacebook] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MiniFacebook] SET ARITHABORT OFF 
GO
ALTER DATABASE [MiniFacebook] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MiniFacebook] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MiniFacebook] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MiniFacebook] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MiniFacebook] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MiniFacebook] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MiniFacebook] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MiniFacebook] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MiniFacebook] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MiniFacebook] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MiniFacebook] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MiniFacebook] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MiniFacebook] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MiniFacebook] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MiniFacebook] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MiniFacebook] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MiniFacebook] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MiniFacebook] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MiniFacebook] SET RECOVERY FULL 
GO
ALTER DATABASE [MiniFacebook] SET  MULTI_USER 
GO
ALTER DATABASE [MiniFacebook] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MiniFacebook] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MiniFacebook] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MiniFacebook] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MiniFacebook', N'ON'
GO
USE [MiniFacebook]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Event](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Data] [date] NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EventInvitationList]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventInvitationList](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[EventID] [int] NOT NULL,
 CONSTRAINT [PK_EventInvitationList] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Friendship]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Friendship](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserFriendshipSenderID] [int] NOT NULL,
	[UserFriendshipReceiverID] [int] NOT NULL,
	[IsAccepted] [bit] NOT NULL,
 CONSTRAINT [PK_Friendship] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Group]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Group](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GroupMemberList]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupMemberList](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_GroupMemberList] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupPost]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GroupPost](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[Text] [varchar](50) NOT NULL,
 CONSTRAINT [PK_GroupPost] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Message]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserMessageSenderID] [int] NOT NULL,
	[UserMessageReceiverID] [int] NOT NULL,
	[IsRead] [int] NOT NULL,
	[Text] [text] NOT NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Post]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Post](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Text] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PostComment]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PostComment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PostID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[Text] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PostComment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PostLike]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostLike](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[PostID] [int] NOT NULL,
 CONSTRAINT [PK_PostLike] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserFrienshipReceiver]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserFrienshipReceiver](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_UserFrienshipReceiver] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserFrienshipSender]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserFrienshipSender](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_UserFrienshipSender] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserMessageReceiver]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMessageReceiver](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_UserReceiver] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserMessageSender]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMessageSender](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_UserSender] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[EventMemberUserName]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[EventMemberUserName]
AS
SELECT        TOP (100) PERCENT dbo.Event.Name AS EventName, dbo.[User].Name AS EventMemberserName, dbo.Event.Data, dbo.Event.Description
FROM            dbo.Event INNER JOIN
                         dbo.EventInvitationList ON dbo.Event.ID = dbo.EventInvitationList.EventID INNER JOIN
                         dbo.[User] ON dbo.EventInvitationList.UserID = dbo.[User].ID
ORDER BY dbo.Event.Data

GO
/****** Object:  View [dbo].[UserFriendship]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UserFriendship]
AS
SELECT        TOP (100) PERCENT dbo.[User].Name, User_1.Name AS Expr1
FROM            dbo.Friendship INNER JOIN
                         dbo.UserFrienshipReceiver ON dbo.Friendship.UserFriendshipReceiverID = dbo.UserFrienshipReceiver.ID INNER JOIN
                         dbo.UserFrienshipSender ON dbo.Friendship.UserFriendshipSenderID = dbo.UserFrienshipSender.ID INNER JOIN
                         dbo.[User] ON dbo.UserFrienshipSender.UserID = dbo.[User].ID INNER JOIN
                         dbo.[User] AS User_1 ON dbo.UserFrienshipReceiver.UserID = User_1.ID
ORDER BY dbo.[User].Name

GO
/****** Object:  View [dbo].[UserGroupMember]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UserGroupMember]
AS
SELECT        TOP (100) PERCENT dbo.[Group].Name AS GroupName, dbo.[User].Name AS UserName
FROM            dbo.[Group] INNER JOIN
                         dbo.GroupMemberList ON dbo.[Group].ID = dbo.GroupMemberList.GroupID INNER JOIN
                         dbo.[User] ON dbo.GroupMemberList.UserID = dbo.[User].ID

GO
/****** Object:  View [dbo].[UserLike]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UserLike]
AS
SELECT        dbo.PostLike.PostID, dbo.[User].Name AS UserName
FROM            dbo.PostLike INNER JOIN
                         dbo.[User] ON dbo.PostLike.UserID = dbo.[User].ID

GO
/****** Object:  View [dbo].[UserPost]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UserPost]
AS
SELECT        dbo.Post.Text AS PostText, dbo.[User].Name AS UserName, dbo.Post.ID AS PostID
FROM            dbo.Post INNER JOIN
                         dbo.[User] ON dbo.Post.UserID = dbo.[User].ID

GO
/****** Object:  View [dbo].[UserPostComment]    Script Date: 5/19/2015 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UserPostComment]
AS
SELECT        TOP (100) PERCENT dbo.[User].Name AS UserNameAuthor, dbo.Post.Text AS PostText, UserPostComment_1.Name AS PostCommentUserName, dbo.PostComment.Text AS PostCommentText
FROM            dbo.[User] INNER JOIN
                         dbo.Post ON dbo.[User].ID = dbo.Post.UserID INNER JOIN
                         dbo.PostComment ON dbo.Post.ID = dbo.PostComment.PostID INNER JOIN
                         dbo.[User] AS UserPostComment_1 ON dbo.PostComment.UserID = UserPostComment_1.ID
GROUP BY dbo.[User].Name, dbo.Post.Text, UserPostComment_1.Name, dbo.PostComment.Text

GO
SET IDENTITY_INSERT [dbo].[Event] ON 

INSERT [dbo].[Event] ([ID], [UserID], [Name], [Data], [Description]) VALUES (1, 9, N'Gra w planszowki', CAST(0xF8390B00 AS Date), N'Zaprasz do mnie na gre w planszówki')
INSERT [dbo].[Event] ([ID], [UserID], [Name], [Data], [Description]) VALUES (2, 12, N'Urodziny', CAST(0xF8390B00 AS Date), N'Wpdanijcie na moje urodzinki')
SET IDENTITY_INSERT [dbo].[Event] OFF
SET IDENTITY_INSERT [dbo].[EventInvitationList] ON 

INSERT [dbo].[EventInvitationList] ([ID], [UserID], [EventID]) VALUES (1, 13, 1)
INSERT [dbo].[EventInvitationList] ([ID], [UserID], [EventID]) VALUES (2, 14, 1)
INSERT [dbo].[EventInvitationList] ([ID], [UserID], [EventID]) VALUES (3, 9, 1)
INSERT [dbo].[EventInvitationList] ([ID], [UserID], [EventID]) VALUES (4, 9, 2)
INSERT [dbo].[EventInvitationList] ([ID], [UserID], [EventID]) VALUES (5, 13, 2)
INSERT [dbo].[EventInvitationList] ([ID], [UserID], [EventID]) VALUES (6, 15, 2)
SET IDENTITY_INSERT [dbo].[EventInvitationList] OFF
SET IDENTITY_INSERT [dbo].[Friendship] ON 

INSERT [dbo].[Friendship] ([ID], [UserFriendshipSenderID], [UserFriendshipReceiverID], [IsAccepted]) VALUES (1, 1, 1, 1)
INSERT [dbo].[Friendship] ([ID], [UserFriendshipSenderID], [UserFriendshipReceiverID], [IsAccepted]) VALUES (2, 2, 2, 0)
INSERT [dbo].[Friendship] ([ID], [UserFriendshipSenderID], [UserFriendshipReceiverID], [IsAccepted]) VALUES (3, 3, 3, 1)
SET IDENTITY_INSERT [dbo].[Friendship] OFF
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([ID], [Name]) VALUES (2, N'Kolo naukowe KREDEK')
INSERT [dbo].[Group] ([ID], [Name]) VALUES (1, N'Koszykówka')
SET IDENTITY_INSERT [dbo].[Group] OFF
SET IDENTITY_INSERT [dbo].[GroupMemberList] ON 

INSERT [dbo].[GroupMemberList] ([ID], [GroupID], [UserID]) VALUES (1, 1, 9)
INSERT [dbo].[GroupMemberList] ([ID], [GroupID], [UserID]) VALUES (3, 2, 9)
INSERT [dbo].[GroupMemberList] ([ID], [GroupID], [UserID]) VALUES (4, 2, 10)
INSERT [dbo].[GroupMemberList] ([ID], [GroupID], [UserID]) VALUES (5, 2, 11)
INSERT [dbo].[GroupMemberList] ([ID], [GroupID], [UserID]) VALUES (6, 1, 10)
INSERT [dbo].[GroupMemberList] ([ID], [GroupID], [UserID]) VALUES (7, 2, 14)
INSERT [dbo].[GroupMemberList] ([ID], [GroupID], [UserID]) VALUES (8, 2, 15)
INSERT [dbo].[GroupMemberList] ([ID], [GroupID], [UserID]) VALUES (9, 1, 13)
SET IDENTITY_INSERT [dbo].[GroupMemberList] OFF
SET IDENTITY_INSERT [dbo].[GroupPost] ON 

INSERT [dbo].[GroupPost] ([ID], [GroupID], [UserID], [Text]) VALUES (1, 2, 9, N'Jaka jest praca domowa na nastepne zajecia ?')
INSERT [dbo].[GroupPost] ([ID], [GroupID], [UserID], [Text]) VALUES (2, 2, 10, N'Trzeba zrobic baze danych w MS Management Studio ?')
INSERT [dbo].[GroupPost] ([ID], [GroupID], [UserID], [Text]) VALUES (3, 2, 9, N'Dzieki')
INSERT [dbo].[GroupPost] ([ID], [GroupID], [UserID], [Text]) VALUES (4, 1, 13, N'Idziemy dzisiaj na orlik ?')
INSERT [dbo].[GroupPost] ([ID], [GroupID], [UserID], [Text]) VALUES (5, 1, 10, N'Ja bede na pewno')
INSERT [dbo].[GroupPost] ([ID], [GroupID], [UserID], [Text]) VALUES (6, 1, 14, N'Ja tez')
INSERT [dbo].[GroupPost] ([ID], [GroupID], [UserID], [Text]) VALUES (7, 1, 13, N'Super to widzimy sie na boisku')
SET IDENTITY_INSERT [dbo].[GroupPost] OFF
SET IDENTITY_INSERT [dbo].[Message] ON 

INSERT [dbo].[Message] ([ID], [UserMessageSenderID], [UserMessageReceiverID], [IsRead], [Text]) VALUES (1, 1, 1, 1, N'Hej, co robisz ?')
INSERT [dbo].[Message] ([ID], [UserMessageSenderID], [UserMessageReceiverID], [IsRead], [Text]) VALUES (2, 2, 2, 1, N'Masz pozyczyc lutownice ?')
INSERT [dbo].[Message] ([ID], [UserMessageSenderID], [UserMessageReceiverID], [IsRead], [Text]) VALUES (3, 3, 3, 0, N'Pozmywaj w koncu te naycznia !')
SET IDENTITY_INSERT [dbo].[Message] OFF
SET IDENTITY_INSERT [dbo].[Post] ON 

INSERT [dbo].[Post] ([ID], [UserID], [Text]) VALUES (7, 9, N'Jaki samochód polecacie ?')
INSERT [dbo].[Post] ([ID], [UserID], [Text]) VALUES (9, 10, N'Ktos moze polecic mi dobra restauracje ?')
INSERT [dbo].[Post] ([ID], [UserID], [Text]) VALUES (33, 14, N'Kto jest we Wroclawiu ? ')
SET IDENTITY_INSERT [dbo].[Post] OFF
SET IDENTITY_INSERT [dbo].[PostComment] ON 

INSERT [dbo].[PostComment] ([ID], [PostID], [UserID], [Text]) VALUES (9, 7, 10, N'Ostatnio ludzie bardzo polecja Audi')
INSERT [dbo].[PostComment] ([ID], [PostID], [UserID], [Text]) VALUES (10, 7, 11, N'Ja slyszalam, ze Audi ostatnio jesdnak zle stoi. W')
INSERT [dbo].[PostComment] ([ID], [PostID], [UserID], [Text]) VALUES (11, 7, 10, N'Dzieki')
INSERT [dbo].[PostComment] ([ID], [PostID], [UserID], [Text]) VALUES (14, 9, 13, N'Na rynku jest bardzo fajna burgerownia, polecam')
INSERT [dbo].[PostComment] ([ID], [PostID], [UserID], [Text]) VALUES (15, 9, 15, N'Smacznie jest tez w Kebabie Nynek')
SET IDENTITY_INSERT [dbo].[PostComment] OFF
SET IDENTITY_INSERT [dbo].[PostLike] ON 

INSERT [dbo].[PostLike] ([ID], [UserID], [PostID]) VALUES (7, 10, 7)
INSERT [dbo].[PostLike] ([ID], [UserID], [PostID]) VALUES (8, 11, 7)
INSERT [dbo].[PostLike] ([ID], [UserID], [PostID]) VALUES (9, 10, 9)
SET IDENTITY_INSERT [dbo].[PostLike] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Name], [Password], [Mail]) VALUES (9, N'Jan Kowalski', N'kowalski', N'kowalski@wp.pl')
INSERT [dbo].[User] ([ID], [Name], [Password], [Mail]) VALUES (10, N'Jan Brzechwa', N'brzechwa', N'brzechwa@wp.pl')
INSERT [dbo].[User] ([ID], [Name], [Password], [Mail]) VALUES (11, N'Anna Brzechwa', N'brzechwa', N'brzechwa@wp.pl')
INSERT [dbo].[User] ([ID], [Name], [Password], [Mail]) VALUES (12, N'Tomasz Skrzynia', N'skrzynia', N'skrzynia@wp.pl')
INSERT [dbo].[User] ([ID], [Name], [Password], [Mail]) VALUES (13, N'Gabrysia Mysz', N'mysz', N'mysz@wp.pl')
INSERT [dbo].[User] ([ID], [Name], [Password], [Mail]) VALUES (14, N'Jan Seredynski', N'serek', N'serek8@gmail.com')
INSERT [dbo].[User] ([ID], [Name], [Password], [Mail]) VALUES (15, N'Wioletta Olas', N'asd', N'wioletta@wp.pl')
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[UserFrienshipReceiver] ON 

INSERT [dbo].[UserFrienshipReceiver] ([ID], [UserID]) VALUES (1, 13)
INSERT [dbo].[UserFrienshipReceiver] ([ID], [UserID]) VALUES (2, 14)
INSERT [dbo].[UserFrienshipReceiver] ([ID], [UserID]) VALUES (3, 15)
SET IDENTITY_INSERT [dbo].[UserFrienshipReceiver] OFF
SET IDENTITY_INSERT [dbo].[UserFrienshipSender] ON 

INSERT [dbo].[UserFrienshipSender] ([ID], [UserID]) VALUES (1, 9)
INSERT [dbo].[UserFrienshipSender] ([ID], [UserID]) VALUES (2, 10)
INSERT [dbo].[UserFrienshipSender] ([ID], [UserID]) VALUES (3, 11)
SET IDENTITY_INSERT [dbo].[UserFrienshipSender] OFF
SET IDENTITY_INSERT [dbo].[UserMessageReceiver] ON 

INSERT [dbo].[UserMessageReceiver] ([ID], [UserID]) VALUES (1, 15)
INSERT [dbo].[UserMessageReceiver] ([ID], [UserID]) VALUES (2, 11)
INSERT [dbo].[UserMessageReceiver] ([ID], [UserID]) VALUES (3, 14)
SET IDENTITY_INSERT [dbo].[UserMessageReceiver] OFF
SET IDENTITY_INSERT [dbo].[UserMessageSender] ON 

INSERT [dbo].[UserMessageSender] ([ID], [UserID]) VALUES (1, 9)
INSERT [dbo].[UserMessageSender] ([ID], [UserID]) VALUES (2, 10)
INSERT [dbo].[UserMessageSender] ([ID], [UserID]) VALUES (3, 12)
SET IDENTITY_INSERT [dbo].[UserMessageSender] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_Event_Name]    Script Date: 5/19/2015 11:30:51 PM ******/
ALTER TABLE [dbo].[Event] ADD  CONSTRAINT [UK_Event_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_Group_Name]    Script Date: 5/19/2015 11:30:51 PM ******/
ALTER TABLE [dbo].[Group] ADD  CONSTRAINT [UK_Group_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_User_Name]    Script Date: 5/19/2015 11:30:51 PM ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [UK_User_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Friendship] ADD  CONSTRAINT [DF_Friendship_isAccepted]  DEFAULT ((0)) FOR [IsAccepted]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_User]
GO
ALTER TABLE [dbo].[EventInvitationList]  WITH CHECK ADD  CONSTRAINT [FK_EventInvitationList_Event1] FOREIGN KEY([EventID])
REFERENCES [dbo].[Event] ([ID])
GO
ALTER TABLE [dbo].[EventInvitationList] CHECK CONSTRAINT [FK_EventInvitationList_Event1]
GO
ALTER TABLE [dbo].[EventInvitationList]  WITH CHECK ADD  CONSTRAINT [FK_EventInvitationList_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[EventInvitationList] CHECK CONSTRAINT [FK_EventInvitationList_User]
GO
ALTER TABLE [dbo].[Friendship]  WITH CHECK ADD  CONSTRAINT [FK_Friendship_UserFrienshipReceiver] FOREIGN KEY([UserFriendshipReceiverID])
REFERENCES [dbo].[UserFrienshipReceiver] ([ID])
GO
ALTER TABLE [dbo].[Friendship] CHECK CONSTRAINT [FK_Friendship_UserFrienshipReceiver]
GO
ALTER TABLE [dbo].[Friendship]  WITH CHECK ADD  CONSTRAINT [FK_Friendship_UserFrienshipSender] FOREIGN KEY([UserFriendshipSenderID])
REFERENCES [dbo].[UserFrienshipSender] ([ID])
GO
ALTER TABLE [dbo].[Friendship] CHECK CONSTRAINT [FK_Friendship_UserFrienshipSender]
GO
ALTER TABLE [dbo].[GroupMemberList]  WITH CHECK ADD  CONSTRAINT [FK_GroupMemberList_Group] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Group] ([ID])
GO
ALTER TABLE [dbo].[GroupMemberList] CHECK CONSTRAINT [FK_GroupMemberList_Group]
GO
ALTER TABLE [dbo].[GroupMemberList]  WITH CHECK ADD  CONSTRAINT [FK_GroupMemberList_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[GroupMemberList] CHECK CONSTRAINT [FK_GroupMemberList_User]
GO
ALTER TABLE [dbo].[GroupPost]  WITH CHECK ADD  CONSTRAINT [FK_GroupPost_Group] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Group] ([ID])
GO
ALTER TABLE [dbo].[GroupPost] CHECK CONSTRAINT [FK_GroupPost_Group]
GO
ALTER TABLE [dbo].[GroupPost]  WITH CHECK ADD  CONSTRAINT [FK_GroupPost_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[GroupPost] CHECK CONSTRAINT [FK_GroupPost_User]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_UserMessageReceiver] FOREIGN KEY([UserMessageReceiverID])
REFERENCES [dbo].[UserMessageReceiver] ([ID])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_UserMessageReceiver]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_UserMessageSender] FOREIGN KEY([UserMessageSenderID])
REFERENCES [dbo].[UserMessageSender] ([ID])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_UserMessageSender]
GO
ALTER TABLE [dbo].[Post]  WITH CHECK ADD  CONSTRAINT [FK_Post_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Post] CHECK CONSTRAINT [FK_Post_User]
GO
ALTER TABLE [dbo].[PostComment]  WITH CHECK ADD  CONSTRAINT [FK_PostComment_Post] FOREIGN KEY([PostID])
REFERENCES [dbo].[Post] ([ID])
GO
ALTER TABLE [dbo].[PostComment] CHECK CONSTRAINT [FK_PostComment_Post]
GO
ALTER TABLE [dbo].[PostComment]  WITH CHECK ADD  CONSTRAINT [FK_PostComment_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[PostComment] CHECK CONSTRAINT [FK_PostComment_User]
GO
ALTER TABLE [dbo].[PostLike]  WITH CHECK ADD  CONSTRAINT [FK_PostLike_Post] FOREIGN KEY([PostID])
REFERENCES [dbo].[Post] ([ID])
GO
ALTER TABLE [dbo].[PostLike] CHECK CONSTRAINT [FK_PostLike_Post]
GO
ALTER TABLE [dbo].[PostLike]  WITH CHECK ADD  CONSTRAINT [FK_PostLike_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[PostLike] CHECK CONSTRAINT [FK_PostLike_User]
GO
ALTER TABLE [dbo].[UserFrienshipReceiver]  WITH CHECK ADD  CONSTRAINT [FK_UserFrienshipReceiver_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserFrienshipReceiver] CHECK CONSTRAINT [FK_UserFrienshipReceiver_User]
GO
ALTER TABLE [dbo].[UserFrienshipSender]  WITH CHECK ADD  CONSTRAINT [FK_UserFrienshipSender_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserFrienshipSender] CHECK CONSTRAINT [FK_UserFrienshipSender_User]
GO
ALTER TABLE [dbo].[UserMessageReceiver]  WITH CHECK ADD  CONSTRAINT [FK_UserMessageReceiver_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserMessageReceiver] CHECK CONSTRAINT [FK_UserMessageReceiver_User]
GO
ALTER TABLE [dbo].[UserMessageSender]  WITH CHECK ADD  CONSTRAINT [FK_UserMessageSender_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserMessageSender] CHECK CONSTRAINT [FK_UserMessageSender_User]
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
         Begin Table = "Event"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "EventInvitationList"
            Begin Extent = 
               Top = 127
               Left = 249
               Bottom = 240
               Right = 419
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User"
            Begin Extent = 
               Top = 41
               Left = 587
               Bottom = 171
               Right = 757
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'EventMemberUserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'EventMemberUserName'
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
         Begin Table = "Friendship"
            Begin Extent = 
               Top = 2
               Left = 20
               Bottom = 132
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User"
            Begin Extent = 
               Top = 24
               Left = 699
               Bottom = 154
               Right = 869
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UserFrienshipReceiver"
            Begin Extent = 
               Top = 188
               Left = 306
               Bottom = 284
               Right = 476
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UserFrienshipSender"
            Begin Extent = 
               Top = 24
               Left = 391
               Bottom = 120
               Right = 561
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User_1"
            Begin Extent = 
               Top = 187
               Left = 631
               Bottom = 317
               Right = 801
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
    ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserFriendship'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'     Alias = 900
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserFriendship'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserFriendship'
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
         Begin Table = "Group"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "GroupMemberList"
            Begin Extent = 
               Top = 46
               Left = 330
               Bottom = 159
               Right = 500
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User"
            Begin Extent = 
               Top = 145
               Left = 38
               Bottom = 288
               Right = 233
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
         Width = 1725
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserGroupMember'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserGroupMember'
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
         Begin Table = "PostLike"
            Begin Extent = 
               Top = 31
               Left = 75
               Bottom = 144
               Right = 245
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User"
            Begin Extent = 
               Top = 24
               Left = 476
               Bottom = 154
               Right = 646
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserLike'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserLike'
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
         Begin Table = "Post"
            Begin Extent = 
               Top = 37
               Left = 71
               Bottom = 150
               Right = 241
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User"
            Begin Extent = 
               Top = 20
               Left = 471
               Bottom = 150
               Right = 641
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserPost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserPost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[45] 4[24] 2[5] 3) )"
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
         Begin Table = "User"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Post"
            Begin Extent = 
               Top = 0
               Left = 519
               Bottom = 113
               Right = 689
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PostComment"
            Begin Extent = 
               Top = 180
               Left = 42
               Bottom = 331
               Right = 251
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UserPostComment_1"
            Begin Extent = 
               Top = 224
               Left = 490
               Bottom = 354
               Right = 660
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
         Width = 2250
         Width = 2580
         Width = 2085
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 2040
         Alias = 2460
         Table = 2145
         Output = 840
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserPostComment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserPostComment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UserPostComment'
GO
USE [master]
GO
ALTER DATABASE [MiniFacebook] SET  READ_WRITE 
GO
