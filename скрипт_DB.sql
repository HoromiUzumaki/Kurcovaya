USE [master]
GO
/****** Object:  Database [Students_absences]    Script Date: 20.12.2024 2:46:05 ******/
CREATE DATABASE [Students_absences]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Students_absences', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Students_absences.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Students_absences_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Students_absences_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Students_absences] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Students_absences].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Students_absences] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Students_absences] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Students_absences] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Students_absences] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Students_absences] SET ARITHABORT OFF 
GO
ALTER DATABASE [Students_absences] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Students_absences] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Students_absences] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Students_absences] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Students_absences] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Students_absences] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Students_absences] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Students_absences] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Students_absences] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Students_absences] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Students_absences] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Students_absences] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Students_absences] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Students_absences] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Students_absences] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Students_absences] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Students_absences] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Students_absences] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Students_absences] SET  MULTI_USER 
GO
ALTER DATABASE [Students_absences] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Students_absences] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Students_absences] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Students_absences] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Students_absences] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Students_absences] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Students_absences] SET QUERY_STORE = OFF
GO
USE [Students_absences]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 20.12.2024 2:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[Id_attendence] [int] NOT NULL,
	[Id_student] [int] NULL,
	[Subject] [int] NULL,
	[Date] [datetime] NULL,
	[Reason] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED 
(
	[Id_attendence] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 20.12.2024 2:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id_group] [int] NOT NULL,
	[Group_Name] [varchar](50) NULL,
	[Specialization] [int] NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Id_group] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialization]    Script Date: 20.12.2024 2:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialization](
	[Id_specialization] [int] NOT NULL,
	[Number_Specialization] [varchar](50) NULL,
	[Specialization_Name] [varchar](150) NULL,
	[Description] [varchar](150) NULL,
 CONSTRAINT [PK_Specialization] PRIMARY KEY CLUSTERED 
(
	[Id_specialization] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 20.12.2024 2:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id_student] [int] NOT NULL,
	[Surname] [varchar](100) NULL,
	[Name] [varchar](100) NULL,
	[Middle_Name] [varchar](100) NULL,
	[Group] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id_student] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 20.12.2024 2:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Id_subject] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Id_subject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 20.12.2024 2:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id_user] [int] NOT NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Id_student] [int] NULL,
	[Type_User] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_type]    Script Date: 20.12.2024 2:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_type](
	[Id_types] [int] NOT NULL,
	[Type_Name] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_User_type] PRIMARY KEY CLUSTERED 
(
	[Id_types] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (1, 1, 1, CAST(N'2023-03-15T10:30:00.000' AS DateTime), N'У (Уважительная)', NULL)
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (2, 2, 2, CAST(N'2023-07-28T18:15:45.000' AS DateTime), N'У (Уважительная)', NULL)
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (3, 3, 3, CAST(N'2024-08-31T12:00:00.000' AS DateTime), N'Н (неуважительная)', NULL)
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (4, 4, 5, CAST(N'2024-08-28T13:00:00.000' AS DateTime), N'Н (неуважительная)', NULL)
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (5, 1, 9, CAST(N'2024-08-31T12:50:00.000' AS DateTime), N'У (Уважительная)', NULL)
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (11, 3, 2, CAST(N'2024-12-15T00:00:00.000' AS DateTime), N'Н (неуважительная)', NULL)
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (12, 3, 3, CAST(N'2024-10-28T00:00:00.000' AS DateTime), N'Н (неуважительная)', NULL)
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (33, 7, 3, CAST(N'2024-12-06T00:00:00.000' AS DateTime), N'У (Уважительная)', NULL)
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (34, 3, 6, CAST(N'2024-12-05T00:00:00.000' AS DateTime), N'Н (неуважительная)', NULL)
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (43, 7, 5, CAST(N'2024-11-02T00:00:00.000' AS DateTime), N'У (Уважительная)', NULL)
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (77, 3, 5, CAST(N'2024-12-04T00:00:00.000' AS DateTime), N'Н (неуважительная)', NULL)
INSERT [dbo].[Attendance] ([Id_attendence], [Id_student], [Subject], [Date], [Reason], [Description]) VALUES (85, 5, 1, CAST(N'2024-10-30T00:00:00.000' AS DateTime), N'Н (неуважительная)', NULL)
GO
INSERT [dbo].[Group] ([Id_group], [Group_Name], [Specialization]) VALUES (20, N'С-1', 2)
INSERT [dbo].[Group] ([Id_group], [Group_Name], [Specialization]) VALUES (21, N'П-1', 1)
GO
INSERT [dbo].[Specialization] ([Id_specialization], [Number_Specialization], [Specialization_Name], [Description]) VALUES (1, N'09.02.07', N'Информационные системы и программирование', NULL)
INSERT [dbo].[Specialization] ([Id_specialization], [Number_Specialization], [Specialization_Name], [Description]) VALUES (2, N'44.02.03', N'Педагогика 
дополнительного
образования
', NULL)
INSERT [dbo].[Specialization] ([Id_specialization], [Number_Specialization], [Specialization_Name], [Description]) VALUES (3, N'40.02.04 ', N'Юриспруденция', NULL)
INSERT [dbo].[Specialization] ([Id_specialization], [Number_Specialization], [Specialization_Name], [Description]) VALUES (4, N'44.02.01', N'Дошкольное образование', NULL)
INSERT [dbo].[Specialization] ([Id_specialization], [Number_Specialization], [Specialization_Name], [Description]) VALUES (5, N'49.02.01', N'Физическая культура', NULL)
GO
INSERT [dbo].[Student] ([Id_student], [Surname], [Name], [Middle_Name], [Group]) VALUES (1, N'Кротова', N'Ксения', N'Николаевна', 21)
INSERT [dbo].[Student] ([Id_student], [Surname], [Name], [Middle_Name], [Group]) VALUES (2, N'Коротких', N'Наталья', N'Михайловна', 21)
INSERT [dbo].[Student] ([Id_student], [Surname], [Name], [Middle_Name], [Group]) VALUES (3, N'Шишкин', N'Иван', N'Иванович', 21)
INSERT [dbo].[Student] ([Id_student], [Surname], [Name], [Middle_Name], [Group]) VALUES (4, N'Кедров', N'Андрей', N'Васильевич', 20)
INSERT [dbo].[Student] ([Id_student], [Surname], [Name], [Middle_Name], [Group]) VALUES (5, N'Михеева', N'Александра', N'Сергеевна', 20)
INSERT [dbo].[Student] ([Id_student], [Surname], [Name], [Middle_Name], [Group]) VALUES (6, N'Чупраков', N'Сергей', N'Александрович', 20)
INSERT [dbo].[Student] ([Id_student], [Surname], [Name], [Middle_Name], [Group]) VALUES (7, N'Ашихмин', N'Максим', N'Денисович', 20)
GO
INSERT [dbo].[Subject] ([Id_subject], [Name]) VALUES (1, N'Поддержка и тестирование программных модулей')
INSERT [dbo].[Subject] ([Id_subject], [Name]) VALUES (2, N'Эффективное поведение на рынке труда')
INSERT [dbo].[Subject] ([Id_subject], [Name]) VALUES (3, N'Иностранный язык в профессиональной деятельности')
INSERT [dbo].[Subject] ([Id_subject], [Name]) VALUES (4, N'Основы предпринимательства')
INSERT [dbo].[Subject] ([Id_subject], [Name]) VALUES (5, N'Теоретические и прикладные аспекты методической работы педагога дополнительного образования')
INSERT [dbo].[Subject] ([Id_subject], [Name]) VALUES (6, N'Основы предпринимательства')
INSERT [dbo].[Subject] ([Id_subject], [Name]) VALUES (7, N'Основы философии')
INSERT [dbo].[Subject] ([Id_subject], [Name]) VALUES (8, N'Системное программирование')
INSERT [dbo].[Subject] ([Id_subject], [Name]) VALUES (9, N'Разработка мобильных приложений')
INSERT [dbo].[Subject] ([Id_subject], [Name]) VALUES (10, N'Менеджмент в профессиональной деятельности')
GO
INSERT [dbo].[User] ([Id_user], [Login], [Password], [Id_student], [Type_User]) VALUES (2, N'Teacher', N'Teacher', NULL, 2)
INSERT [dbo].[User] ([Id_user], [Login], [Password], [Id_student], [Type_User]) VALUES (3, N'Krotova', N'Krotik18', 1, 3)
INSERT [dbo].[User] ([Id_user], [Login], [Password], [Id_student], [Type_User]) VALUES (5, N'Ashikhmin', N'Ashikhmin', 7, 3)
INSERT [dbo].[User] ([Id_user], [Login], [Password], [Id_student], [Type_User]) VALUES (6, N'Admin', N'Admin', NULL, 1)
GO
INSERT [dbo].[User_type] ([Id_types], [Type_Name], [Description]) VALUES (1, N'Admin', N'Администратор')
INSERT [dbo].[User_type] ([Id_types], [Type_Name], [Description]) VALUES (2, N'Teacher', N'Преподаватель')
INSERT [dbo].[User_type] ([Id_types], [Type_Name], [Description]) VALUES (3, N'Student', N'Студент')
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Student] FOREIGN KEY([Id_student])
REFERENCES [dbo].[Student] ([Id_student])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Student]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Subject] FOREIGN KEY([Subject])
REFERENCES [dbo].[Subject] ([Id_subject])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Subject]
GO
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_Specialization] FOREIGN KEY([Specialization])
REFERENCES [dbo].[Specialization] ([Id_specialization])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_Specialization]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Group] FOREIGN KEY([Group])
REFERENCES [dbo].[Group] ([Id_group])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Group]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Student] FOREIGN KEY([Id_student])
REFERENCES [dbo].[Student] ([Id_student])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Student]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_User_type] FOREIGN KEY([Type_User])
REFERENCES [dbo].[User_type] ([Id_types])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_User_type]
GO
USE [master]
GO
ALTER DATABASE [Students_absences] SET  READ_WRITE 
GO
