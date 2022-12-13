USE [master]
GO

/****** Object:  Database [Hoja10]    Script Date: 31/05/2022 12:55:44 ******/
CREATE DATABASE [Hoja10]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hoja10', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hoja10.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hoja10_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hoja10_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hoja10].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Hoja10] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Hoja10] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Hoja10] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Hoja10] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Hoja10] SET ARITHABORT OFF 
GO

ALTER DATABASE [Hoja10] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Hoja10] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Hoja10] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Hoja10] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Hoja10] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Hoja10] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Hoja10] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Hoja10] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Hoja10] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Hoja10] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Hoja10] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Hoja10] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Hoja10] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Hoja10] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Hoja10] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Hoja10] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Hoja10] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Hoja10] SET RECOVERY FULL 
GO

ALTER DATABASE [Hoja10] SET  MULTI_USER 
GO

ALTER DATABASE [Hoja10] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Hoja10] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Hoja10] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Hoja10] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Hoja10] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Hoja10] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Hoja10] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Hoja10] SET  READ_WRITE 
GO

