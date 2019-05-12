USE [master]
GO
/****** Object:  Database [Shifa-Hospital-Management-System]    Script Date: 5/12/2019 5:49:29 AM ******/
CREATE DATABASE [Shifa-Hospital-Management-System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HMS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HMS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shifa-Hospital-Management-System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET  MULTI_USER 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET QUERY_STORE = OFF
GO
USE [Shifa-Hospital-Management-System]
GO
/****** Object:  Table [dbo].[BedAllotment]    Script Date: 5/12/2019 5:49:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BedAllotment](
	[Patient_Email] [varchar](50) NOT NULL,
	[Bed_Category] [int] NOT NULL,
	[Bed_No] [int] NOT NULL,
	[Allotment_Date] [datetime] NOT NULL,
	[Discharge_Date] [datetime] NOT NULL,
	[Notes] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BedCategory]    Script Date: 5/12/2019 5:49:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BedCategory](
	[BedCategory_Id] [int] NOT NULL,
	[BedCategory_Name] [varchar](50) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_BedCategory] PRIMARY KEY CLUSTERED 
(
	[BedCategory_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Beds]    Script Date: 5/12/2019 5:49:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beds](
	[Bed_No] [int] NOT NULL,
	[Bed_Category] [int] NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Beds] PRIMARY KEY CLUSTERED 
(
	[Bed_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 5/12/2019 5:49:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Picture] [image] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenseCategory]    Script Date: 5/12/2019 5:49:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenseCategory](
	[ExpenseCategory_Id] [int] NOT NULL,
	[ExpenseCategory_Name] [varchar](50) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ExpenseCategory] PRIMARY KEY CLUSTERED 
(
	[ExpenseCategory_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 5/12/2019 5:49:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[Expense_Id] [int] NOT NULL,
	[Expense_Category] [int] NOT NULL,
	[Amount] [float] NOT NULL,
 CONSTRAINT [PK_Expense] PRIMARY KEY CLUSTERED 
(
	[Expense_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabTest]    Script Date: 5/12/2019 5:49:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTest](
	[LabTest_Id] [int] NOT NULL,
	[LabTest_Name] [varchar](50) NOT NULL,
	[Unit] [varchar](50) NOT NULL,
	[Reference_Range] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[LabCategory_Id] [int] NOT NULL,
 CONSTRAINT [PK_LabTest] PRIMARY KEY CLUSTERED 
(
	[LabTest_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabTestCategory]    Script Date: 5/12/2019 5:49:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTestCategory](
	[LabCategory_Id] [int] NOT NULL,
	[LabCategory_Name] [varchar](50) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LabCategory] PRIMARY KEY CLUSTERED 
(
	[LabCategory_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 5/12/2019 5:49:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine](
	[Medicine_Id] [int] NOT NULL,
	[Medicine_Name] [varchar](50) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[MedicineCategory_Id] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicineCategory]    Script Date: 5/12/2019 5:49:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicineCategory](
	[MedicienCategory_Id] [int] NOT NULL,
	[MedicienCategory_Name] [varchar](max) NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_MedicineCategory] PRIMARY KEY CLUSTERED 
(
	[MedicienCategory_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 5/12/2019 5:49:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[BloodGroup] [varchar](50) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Picture] [image] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientCheckUp]    Script Date: 5/12/2019 5:49:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientCheckUp](
	[PatientCheckup_Id] [int] NOT NULL,
	[Patient_Email] [varchar](50) NOT NULL,
	[Doctor_Email] [varchar](50) NOT NULL,
	[Symptoms] [varchar](max) NOT NULL,
	[Diagnosis] [varchar](max) NOT NULL,
 CONSTRAINT [PK_PatientCheckUp] PRIMARY KEY CLUSTERED 
(
	[PatientCheckup_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientTest]    Script Date: 5/12/2019 5:49:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientTest](
	[Patient_Email] [varchar](50) NOT NULL,
	[Doctor_Email] [varchar](50) NOT NULL,
	[TestDate] [datetime] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[Payment_Status] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 5/12/2019 5:49:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Patient_Email] [varchar](50) NOT NULL,
	[Consulting_Charges] [float] NOT NULL,
	[X-Ray_Charges] [float] NOT NULL,
	[BloodReport_Charges] [float] NOT NULL,
	[Extra_Charges] [float] NOT NULL,
	[Medicine_Charges] [float] NOT NULL,
	[Payment_Date] [datetime] NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[Patient_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentCategory]    Script Date: 5/12/2019 5:49:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentCategory](
	[PaymentCategory_Id] [int] NOT NULL,
	[PaymentCategory_Name] [varchar](max) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PaymentCategory] PRIMARY KEY CLUSTERED 
(
	[PaymentCategory_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prescription]    Script Date: 5/12/2019 5:49:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescription](
	[Medicine_Name] [varchar](50) NOT NULL,
	[No_Of_Days] [int] NOT NULL,
	[Timing] [varchar](50) NOT NULL,
	[Before_Meal] [varchar](50) NOT NULL,
	[Extra_Note] [varchar](max) NOT NULL,
	[CheckUp_Id] [int] NOT NULL,
	[CheckUp_Date] [date] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/12/2019 5:49:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Picture] [image] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[BedAllotment]  WITH CHECK ADD  CONSTRAINT [FK_BedAllotment_BedCategory] FOREIGN KEY([Bed_Category])
REFERENCES [dbo].[BedCategory] ([BedCategory_Id])
GO
ALTER TABLE [dbo].[BedAllotment] CHECK CONSTRAINT [FK_BedAllotment_BedCategory]
GO
ALTER TABLE [dbo].[BedAllotment]  WITH CHECK ADD  CONSTRAINT [FK_BedAllotment_Beds] FOREIGN KEY([Bed_No])
REFERENCES [dbo].[Beds] ([Bed_No])
GO
ALTER TABLE [dbo].[BedAllotment] CHECK CONSTRAINT [FK_BedAllotment_Beds]
GO
ALTER TABLE [dbo].[BedAllotment]  WITH CHECK ADD  CONSTRAINT [FK_BedAllotment_Patient] FOREIGN KEY([Patient_Email])
REFERENCES [dbo].[Patient] ([Email])
GO
ALTER TABLE [dbo].[BedAllotment] CHECK CONSTRAINT [FK_BedAllotment_Patient]
GO
ALTER TABLE [dbo].[Beds]  WITH CHECK ADD  CONSTRAINT [FK_Beds_BedCategory] FOREIGN KEY([Bed_Category])
REFERENCES [dbo].[BedCategory] ([BedCategory_Id])
GO
ALTER TABLE [dbo].[Beds] CHECK CONSTRAINT [FK_Beds_BedCategory]
GO
ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD  CONSTRAINT [FK_Expense_ExpenseCategory] FOREIGN KEY([Expense_Category])
REFERENCES [dbo].[ExpenseCategory] ([ExpenseCategory_Id])
GO
ALTER TABLE [dbo].[Expenses] CHECK CONSTRAINT [FK_Expense_ExpenseCategory]
GO
ALTER TABLE [dbo].[LabTest]  WITH CHECK ADD  CONSTRAINT [FK_LabTest_LabCategory] FOREIGN KEY([LabCategory_Id])
REFERENCES [dbo].[LabTestCategory] ([LabCategory_Id])
GO
ALTER TABLE [dbo].[LabTest] CHECK CONSTRAINT [FK_LabTest_LabCategory]
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_MedicineCategory] FOREIGN KEY([MedicineCategory_Id])
REFERENCES [dbo].[MedicineCategory] ([MedicienCategory_Id])
GO
ALTER TABLE [dbo].[Medicine] CHECK CONSTRAINT [FK_Medicine_MedicineCategory]
GO
ALTER TABLE [dbo].[PatientCheckUp]  WITH CHECK ADD  CONSTRAINT [FK_PatientCheckUp_Doctor] FOREIGN KEY([Doctor_Email])
REFERENCES [dbo].[Doctor] ([Email])
GO
ALTER TABLE [dbo].[PatientCheckUp] CHECK CONSTRAINT [FK_PatientCheckUp_Doctor]
GO
ALTER TABLE [dbo].[PatientCheckUp]  WITH CHECK ADD  CONSTRAINT [FK_PatientCheckUp_Patient] FOREIGN KEY([Patient_Email])
REFERENCES [dbo].[Patient] ([Email])
GO
ALTER TABLE [dbo].[PatientCheckUp] CHECK CONSTRAINT [FK_PatientCheckUp_Patient]
GO
ALTER TABLE [dbo].[PatientTest]  WITH CHECK ADD  CONSTRAINT [FK_PatientTest_Doctor] FOREIGN KEY([Doctor_Email])
REFERENCES [dbo].[Doctor] ([Email])
GO
ALTER TABLE [dbo].[PatientTest] CHECK CONSTRAINT [FK_PatientTest_Doctor]
GO
ALTER TABLE [dbo].[PatientTest]  WITH CHECK ADD  CONSTRAINT [FK_PatientTest_Patient] FOREIGN KEY([Patient_Email])
REFERENCES [dbo].[Patient] ([Email])
GO
ALTER TABLE [dbo].[PatientTest] CHECK CONSTRAINT [FK_PatientTest_Patient]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Patient] FOREIGN KEY([Patient_Email])
REFERENCES [dbo].[Patient] ([Email])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Patient]
GO
ALTER TABLE [dbo].[Prescription]  WITH CHECK ADD  CONSTRAINT [FK_Prescription_PatientCheckUp] FOREIGN KEY([CheckUp_Id])
REFERENCES [dbo].[PatientCheckUp] ([PatientCheckup_Id])
GO
ALTER TABLE [dbo].[Prescription] CHECK CONSTRAINT [FK_Prescription_PatientCheckUp]
GO
USE [master]
GO
ALTER DATABASE [Shifa-Hospital-Management-System] SET  READ_WRITE 
GO
