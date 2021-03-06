USE [master]
GO

/****** Object:  Database [StarWars2]    Script Date: 03/10/2020 22:27:39 ******/
CREATE DATABASE [StarWars2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StarWars2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\StarWars2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StarWars2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\StarWars2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StarWars2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [StarWars2] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [StarWars2] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [StarWars2] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [StarWars2] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [StarWars2] SET ARITHABORT OFF 
GO

ALTER DATABASE [StarWars2] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [StarWars2] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [StarWars2] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [StarWars2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [StarWars2] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [StarWars2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [StarWars2] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [StarWars2] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [StarWars2] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [StarWars2] SET  ENABLE_BROKER 
GO

ALTER DATABASE [StarWars2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [StarWars2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [StarWars2] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [StarWars2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [StarWars2] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [StarWars2] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [StarWars2] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [StarWars2] SET RECOVERY FULL 
GO

ALTER DATABASE [StarWars2] SET  MULTI_USER 
GO

ALTER DATABASE [StarWars2] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [StarWars2] SET DB_CHAINING OFF 
GO

ALTER DATABASE [StarWars2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [StarWars2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [StarWars2] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [StarWars2] SET QUERY_STORE = OFF
GO

ALTER DATABASE [StarWars2] SET  READ_WRITE 
GO
