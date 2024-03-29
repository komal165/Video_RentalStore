USE [master]
GO
/****** Object:  Database [RentingStore]    Script Date: 1/10/2019 10:38:03 PM ******/
CREATE DATABASE [RentingStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentingStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RentingStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentingStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RentingStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RentingStore] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentingStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentingStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentingStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentingStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentingStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentingStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentingStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentingStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentingStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentingStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentingStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentingStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentingStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentingStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentingStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentingStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentingStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentingStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentingStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentingStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentingStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentingStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentingStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentingStore] SET RECOVERY FULL 
GO
ALTER DATABASE [RentingStore] SET  MULTI_USER 
GO
ALTER DATABASE [RentingStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentingStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentingStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentingStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RentingStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RentingStore] SET QUERY_STORE = OFF
GO
USE [RentingStore]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 1/10/2019 10:38:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address] [text] NOT NULL,
	[PhoneNumber] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[CustView]    Script Date: 1/10/2019 10:38:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CustView]
	AS SELECT * FROM [Customers]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 1/10/2019 10:38:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[MovieTitle] [varchar](100) NOT NULL,
	[MovieReleaseDate] [datetime] NOT NULL,
	[MovieRatings] [int] NOT NULL,
	[MovieCopies] [int] NOT NULL,
	[MovieRentingCost] [varchar](50) NOT NULL,
	[MovieGenre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MovView]    Script Date: 1/10/2019 10:38:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MovView]
	AS SELECT * FROM [Movies]
GO
/****** Object:  Table [dbo].[Rented]    Script Date: 1/10/2019 10:38:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rented](
	[RentalID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[MovieID] [int] NOT NULL,
	[RentFrom] [datetime] NOT NULL,
	[RentTill] [datetime] NOT NULL,
 CONSTRAINT [PK_Rented] PRIMARY KEY CLUSTERED 
(
	[RentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[RentalsView]    Script Date: 1/10/2019 10:38:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[RentalsView]
	AS SELECT * FROM [Rented]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [PhoneNumber]) VALUES (1, N'komal', N'sarpal', N'auckland', N'0123456789')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [PhoneNumber]) VALUES (2, N'JATINDER', N'SINGH', N'EAST TAMAKI', N'0123456789')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Address], [PhoneNumber]) VALUES (3, N'JASHAN', N'VIRK', N'PAPATOETOE', N'0123456789')
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [MovieTitle], [MovieReleaseDate], [MovieRatings], [MovieCopies], [MovieRentingCost], [MovieGenre]) VALUES (2, N'shilpa', CAST(N'2019-09-30T11:23:26.307' AS DateTime), 0, 4, N'10', N'Action')
INSERT [dbo].[Movies] ([MovieID], [MovieTitle], [MovieReleaseDate], [MovieRatings], [MovieCopies], [MovieRentingCost], [MovieGenre]) VALUES (3, N'DEADPOOL', CAST(N'2017-10-01T22:30:02.000' AS DateTime), 9, 1, N'5.0', N'Action')
INSERT [dbo].[Movies] ([MovieID], [MovieTitle], [MovieReleaseDate], [MovieRatings], [MovieCopies], [MovieRentingCost], [MovieGenre]) VALUES (4, N'EVIL DEAD', CAST(N'2014-02-18T22:30:54.000' AS DateTime), 7, 1, N'2.0', N'Action')
SET IDENTITY_INSERT [dbo].[Movies] OFF
SET IDENTITY_INSERT [dbo].[Rented] ON 

INSERT [dbo].[Rented] ([RentalID], [CustomerID], [MovieID], [RentFrom], [RentTill]) VALUES (2, 1, 2, CAST(N'2019-10-01T18:23:19.567' AS DateTime), CAST(N'2019-10-23T18:23:19.000' AS DateTime))
INSERT [dbo].[Rented] ([RentalID], [CustomerID], [MovieID], [RentFrom], [RentTill]) VALUES (3, 2, 3, CAST(N'2019-10-01T22:30:02.277' AS DateTime), CAST(N'2019-10-24T22:30:02.000' AS DateTime))
INSERT [dbo].[Rented] ([RentalID], [CustomerID], [MovieID], [RentFrom], [RentTill]) VALUES (4, 3, 4, CAST(N'2019-10-01T22:30:02.277' AS DateTime), CAST(N'2019-10-31T22:30:02.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Rented] OFF
ALTER TABLE [dbo].[Rented]  WITH CHECK ADD  CONSTRAINT [FK_Rented_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Rented] CHECK CONSTRAINT [FK_Rented_Customers]
GO
ALTER TABLE [dbo].[Rented]  WITH CHECK ADD  CONSTRAINT [FK_Rented_Movies] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([MovieID])
GO
ALTER TABLE [dbo].[Rented] CHECK CONSTRAINT [FK_Rented_Movies]
GO
/****** Object:  StoredProcedure [dbo].[CustomersProcedure]    Script Date: 1/10/2019 10:38:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomersProcedure]
AS
	SELECT * FROM [dbo].[Customers]
GO;
GO
/****** Object:  StoredProcedure [dbo].[MovieProcedure]    Script Date: 1/10/2019 10:38:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MovieProcedure]
AS
	SELECT * FROM [dbo].[Movies]
	GO;
GO
/****** Object:  StoredProcedure [dbo].[RentalProcedure]    Script Date: 1/10/2019 10:38:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RentalProcedure]
AS
	SELECT * FROM [dbo].[Rented]
GO;
GO
USE [master]
GO
ALTER DATABASE [RentingStore] SET  READ_WRITE 
GO
