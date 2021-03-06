USE [master]
GO
/****** Object:  Database [mascotas]    Script Date: 14/11/2017 7:28:49 ******/
CREATE DATABASE [mascotas] ON  PRIMARY 
( NAME = N'mascotas', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\mascotas.mdf' , SIZE = 2240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'mascotas_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\mascotas_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [mascotas] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mascotas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mascotas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mascotas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mascotas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mascotas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mascotas] SET ARITHABORT OFF 
GO
ALTER DATABASE [mascotas] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [mascotas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mascotas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mascotas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mascotas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mascotas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mascotas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mascotas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mascotas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mascotas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [mascotas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mascotas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mascotas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mascotas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mascotas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mascotas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mascotas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [mascotas] SET  MULTI_USER 
GO
ALTER DATABASE [mascotas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mascotas] SET DB_CHAINING OFF 
GO
USE [mascotas]
GO
/****** Object:  Table [dbo].[Mascota]    Script Date: 14/11/2017 7:28:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascota](
	[IdAnimal] [int] IDENTITY(1,1) NOT NULL,
	[Color] [nvarchar](25) NULL,
	[NombreMascota] [nvarchar](25) NULL,
	[Especie] [nvarchar](25) NULL,
	[Raza] [nvarchar](25) NULL,
	[Imagen] [nvarchar](25) NULL,
	[FechaPerdida] [datetime] NULL,
	[EstadoAnimal] [nvarchar](25) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[CodigoPersona] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 14/11/2017 7:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Nombre] [nvarchar](30) NULL,
	[Apellido] [nvarchar](30) NULL,
	[Cedula] [bigint] NULL,
	[CodigoUsuario] [bigint] IDENTITY(1,1) NOT NULL,
	[Direccion] [nvarchar](30) NULL,
	[NumeroContacto] [int] NULL,
	[clave] [nvarchar](25) NULL,
	[correo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ubicacion]    Script Date: 14/11/2017 7:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ubicacion](
	[localidad] [nvarchar](20) NULL,
	[barrio] [nvarchar](20) NULL,
	[departamente] [nvarchar](20) NULL,
	[municipio] [nvarchar](25) NULL,
	[id_ubicacion] [int] IDENTITY(1,1) NOT NULL,
	[CodigoUsuario] [bigint] NULL,
 CONSTRAINT [PK_Ubicacion] PRIMARY KEY CLUSTERED 
(
	[id_ubicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Mascota]  WITH CHECK ADD  CONSTRAINT [FK_Mascota_Persona] FOREIGN KEY([CodigoPersona])
REFERENCES [dbo].[Persona] ([CodigoUsuario])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mascota] CHECK CONSTRAINT [FK_Mascota_Persona]
GO
ALTER TABLE [dbo].[Ubicacion]  WITH CHECK ADD  CONSTRAINT [FK_Ubicacion_Persona] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[Persona] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[Ubicacion] CHECK CONSTRAINT [FK_Ubicacion_Persona]
GO
USE [master]
GO
ALTER DATABASE [mascotas] SET  READ_WRITE 
GO
