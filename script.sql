USE [master]
GO
/****** Object:  Database [WepDB]    Script Date: 19.09.2020 21:31:36 ******/
CREATE DATABASE [WepDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WepDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\WepDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WepDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\WepDB_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [WepDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WepDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WepDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WepDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WepDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WepDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WepDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [WepDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WepDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WepDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WepDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WepDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WepDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WepDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WepDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WepDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WepDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WepDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WepDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WepDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WepDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WepDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WepDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [WepDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WepDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WepDB] SET  MULTI_USER 
GO
ALTER DATABASE [WepDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WepDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WepDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WepDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WepDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WepDB] SET QUERY_STORE = OFF
GO
USE [WepDB]
GO
/****** Object:  Table [dbo].[Variables]    Script Date: 19.09.2020 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Variables](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VId] [nvarchar](max) NULL,
	[Rowid] [int] NOT NULL,
	[Avalue] [nvarchar](max) NULL,
	[AddressOut] [int] NOT NULL,
	[AddressIn] [int] NOT NULL,
	[Bvalue] [nvarchar](max) NULL,
	[Bit_position] [nvarchar](max) NULL,
	[Buttonpath] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Decimal] [bit] NOT NULL,
	[Defaultvalue] [int] NOT NULL,
	[Delay] [float] NOT NULL,
	[Delta] [float] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Dimension] [int] NOT NULL,
	[Frequency] [int] NOT NULL,
	[Functioncode] [nvarchar](max) NULL,
	[Grpcategory] [int] NOT NULL,
	[Idgroup] [int] NOT NULL,
	[Idhsvariable] [int] NOT NULL,
	[Idvarmdl] [nvarchar](max) NULL,
	[Idvariable] [nvarchar](max) NULL,
	[Imageoff] [nvarchar](max) NULL,
	[Imageon] [nvarchar](max) NULL,
	[Inserttime] [nvarchar](max) NULL,
	[Isactive] [bit] NOT NULL,
	[Iscancelled] [bit] NOT NULL,
	[Ishaccp] [bit] NOT NULL,
	[Islogic] [bit] NOT NULL,
	[Isonchange] [bit] NOT NULL,
	[Lastupdate] [nvarchar](max) NULL,
	[Length] [int] NOT NULL,
	[Maximum] [nvarchar](max) NULL,
	[Measureunit] [nvarchar](max) NULL,
	[Minimum] [nvarchar](max) NULL,
	[Priority] [int] NOT NULL,
	[ReadWrite] [int] NOT NULL,
	[Signed] [bit] NOT NULL,
	[ToDisplay] [nvarchar](max) NULL,
	[Type] [int] NOT NULL,
	[Varencoding] [nvarchar](max) NULL,
	[DetailId] [nvarchar](max) NULL,
	[DeviceModel] [nvarchar](max) NULL,
 CONSTRAINT [PK_Variables] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [WepDB] SET  READ_WRITE 
GO
