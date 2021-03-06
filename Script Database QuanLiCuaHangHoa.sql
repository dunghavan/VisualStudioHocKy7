USE [master]
GO
/****** Object:  Database [QuanLiCuaHangHoa]    Script Date: 1/5/2017 1:46:35 AM ******/
CREATE DATABASE [QuanLiCuaHangHoa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiCuaHangHoa2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLiCuaHangHoa2.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiCuaHangHoa2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLiCuaHangHoa2_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiCuaHangHoa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLiCuaHangHoa', N'ON'
GO
USE [QuanLiCuaHangHoa]
GO
/****** Object:  Table [dbo].[BaoCaoCongNoKH]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BaoCaoCongNoKH](
	[NgayLap] [date] NOT NULL,
	[MaKH] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NULL,
	[NoKyDau] [int] NULL,
	[PhatSinh] [int] NULL,
	[NoKyCuoi] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK__BaoCaoCo__979D8448858A8142] PRIMARY KEY CLUSTERED 
(
	[NgayLap] ASC,
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BaoCaoDoanhThu]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BaoCaoDoanhThu](
	[NgayLap] [date] NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[TongChi] [int] NULL,
	[PhatSinh] [int] NULL,
	[TongThu] [int] NULL,
	[LoiNhuan] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[NgayLap] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BaoCaoTonKho]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BaoCaoTonKho](
	[NgayLap] [date] NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SLTonKyDau] [int] NULL,
	[SLNhap] [int] NULL,
	[SLXuat] [int] NULL,
	[SLPhatSinh] [int] NULL,
	[SLTonCuoiKy] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[NgayLap] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_DonDatHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_DonDatHang](
	[MaDDH] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_DonNhapHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_DonNhapHang](
	[MaDNH] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDNH] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_HoaDonBanHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_HoaDonBanHang](
	[MaHD] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_HoaDonNhapHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_HoaDonNhapHang](
	[MaHD] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[Soluong] [int] NULL,
	[ThanhTien] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PhieuGiaoHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PhieuGiaoHang](
	[MaPGH] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPGH] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[MaDDH] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[MaNV] [varchar](10) NULL,
	[MaKH] [varchar](10) NULL,
	[TongTien] [int] NULL,
	[NgayGiaoDuKien] [date] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonNhapHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonNhapHang](
	[MaDNH] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[MaNV] [varchar](10) NULL,
	[MaNCC] [varchar](10) NULL,
	[TongTien] [int] NULL,
	[NgayGiaoDuKien] [date] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[MaHD] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[MaNV] [varchar](10) NULL,
	[MaKH] [varchar](10) NULL,
	[TongTien] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonNhapHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonNhapHang](
	[MaHD] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[MaNV] [varchar](10) NULL,
	[MaNCC] [varchar](10) NULL,
	[TongTien] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDT] [varchar](15) NULL,
	[GhiChu] [nvarchar](100) NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK__KhachHan__2725CF1E593DC9C6] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDT] [varchar](15) NULL,
	[GhiChu] [nvarchar](100) NULL,
	[isACtive] [bit] NULL,
 CONSTRAINT [PK__NhaCungC__3A185DEB883209F0] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NamSinh] [int] NULL,
	[GioiTinh] [bit] NULL,
	[SoDT] [varchar](15) NULL,
	[Email] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[MaLoaiNV] [varchar](20) NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuChi]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuChi](
	[MaPC] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[MaNV] [varchar](10) NULL,
	[MaNCC] [varchar](10) NULL,
	[SoTienNo] [int] NULL,
	[SoTienChi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuGiaoHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuGiaoHang](
	[MaPGH] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[MaNV] [varchar](10) NULL,
	[MaKH] [varchar](10) NULL,
	[TongTien] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
	[MaDDH] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPGH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuThu](
	[MaPT] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[MaNV] [varchar](10) NULL,
	[MaKH] [varchar](10) NULL,
	[SoTienNo] [int] NULL,
	[SoTienThu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [varchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[DonVi] [nvarchar](20) NULL,
	[DonGia] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
	[MaLoaiSP] [varchar](20) NULL,
	[SoLuong] [int] NULL,
	[isActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThamSo]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamSo](
	[TenThamSo] [nvarchar](20) NULL,
	[GiaTri] [int] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[BaoCaoCongNoKH] ([NgayLap], [MaKH], [MaNV], [NoKyDau], [PhatSinh], [NoKyCuoi], [GhiChu]) VALUES (CAST(N'2016-08-16' AS Date), N'KH003', N'NV001', 0, 0, 0, N'new')
INSERT [dbo].[BaoCaoCongNoKH] ([NgayLap], [MaKH], [MaNV], [NoKyDau], [PhatSinh], [NoKyCuoi], [GhiChu]) VALUES (CAST(N'2016-10-13' AS Date), N'KH005', N'NV001', 0, 0, 45000, N'Test giao diện')
INSERT [dbo].[BaoCaoCongNoKH] ([NgayLap], [MaKH], [MaNV], [NoKyDau], [PhatSinh], [NoKyCuoi], [GhiChu]) VALUES (CAST(N'2016-11-10' AS Date), N'KH003', N'NV001', 0, 0, 9000, N'')
INSERT [dbo].[BaoCaoCongNoKH] ([NgayLap], [MaKH], [MaNV], [NoKyDau], [PhatSinh], [NoKyCuoi], [GhiChu]) VALUES (CAST(N'2016-11-15' AS Date), N'KH004', N'NV001', 0, 0, 10000, N'')
INSERT [dbo].[BaoCaoCongNoKH] ([NgayLap], [MaKH], [MaNV], [NoKyDau], [PhatSinh], [NoKyCuoi], [GhiChu]) VALUES (CAST(N'2016-11-15' AS Date), N'KH005', N'NV001', 0, 0, 0, N'')
INSERT [dbo].[BaoCaoCongNoKH] ([NgayLap], [MaKH], [MaNV], [NoKyDau], [PhatSinh], [NoKyCuoi], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'KH001', N'NV001', 0, 2000, 2000, N'Auto All')
INSERT [dbo].[BaoCaoCongNoKH] ([NgayLap], [MaKH], [MaNV], [NoKyDau], [PhatSinh], [NoKyCuoi], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'KH002', N'NV001', 0, 114880, 114880, N'')
INSERT [dbo].[BaoCaoCongNoKH] ([NgayLap], [MaKH], [MaNV], [NoKyDau], [PhatSinh], [NoKyCuoi], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'KH003', N'NV001', 111, 220, 3446, N'Mới lập')
INSERT [dbo].[BaoCaoCongNoKH] ([NgayLap], [MaKH], [MaNV], [NoKyDau], [PhatSinh], [NoKyCuoi], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'KH004', N'NV001', 0, 0, 0, N'Ghi chú')
INSERT [dbo].[BaoCaoCongNoKH] ([NgayLap], [MaKH], [MaNV], [NoKyDau], [PhatSinh], [NoKyCuoi], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'KH005', N'NV001', 12, 23, 340, N'Khách quen')
INSERT [dbo].[BaoCaoDoanhThu] ([NgayLap], [MaSP], [TongChi], [PhatSinh], [TongThu], [LoiNhuan], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'SP001', 600, 0, 90, 0, N'')
INSERT [dbo].[BaoCaoDoanhThu] ([NgayLap], [MaSP], [TongChi], [PhatSinh], [TongThu], [LoiNhuan], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'SP002', 0, 200, 300, 500, N'')
INSERT [dbo].[BaoCaoDoanhThu] ([NgayLap], [MaSP], [TongChi], [PhatSinh], [TongThu], [LoiNhuan], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'SP003', 0, -900, 0, -900, N'')
INSERT [dbo].[BaoCaoTonKho] ([NgayLap], [MaSP], [SLTonKyDau], [SLNhap], [SLXuat], [SLPhatSinh], [SLTonCuoiKy], [GhiChu]) VALUES (CAST(N'2016-11-30' AS Date), N'SP001', 100, 500, 300, -200, 250, N'Test')
INSERT [dbo].[BaoCaoTonKho] ([NgayLap], [MaSP], [SLTonKyDau], [SLNhap], [SLXuat], [SLPhatSinh], [SLTonCuoiKy], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'SP001', 250, 30, 60, 6000, 220, N'tăng lên 6000')
INSERT [dbo].[BaoCaoTonKho] ([NgayLap], [MaSP], [SLTonKyDau], [SLNhap], [SLXuat], [SLPhatSinh], [SLTonCuoiKy], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'SP002', 0, 0, 30, 5000, 20, N'Edit')
INSERT [dbo].[BaoCaoTonKho] ([NgayLap], [MaSP], [SLTonKyDau], [SLNhap], [SLXuat], [SLPhatSinh], [SLTonCuoiKy], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'SP003', 0, 0, 0, 1000, 100, N'Ghi chú')
INSERT [dbo].[BaoCaoTonKho] ([NgayLap], [MaSP], [SLTonKyDau], [SLNhap], [SLXuat], [SLPhatSinh], [SLTonCuoiKy], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'SP004', 0, 0, 0, 2000, 200, N'')
INSERT [dbo].[BaoCaoTonKho] ([NgayLap], [MaSP], [SLTonKyDau], [SLNhap], [SLXuat], [SLPhatSinh], [SLTonCuoiKy], [GhiChu]) VALUES (CAST(N'2016-12-10' AS Date), N'SP005', 0, 0, 0, 3009, 300, N'4')
INSERT [dbo].[CT_DonDatHang] ([MaDDH], [MaSP], [SoLuong], [ThanhTien], [GhiChu]) VALUES (N'1', N'SP001', 100, 1200000, N'')
INSERT [dbo].[CT_HoaDonBanHang] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [GhiChu]) VALUES (N'HD001', N'SP001', 10, 100, N'Test')
INSERT [dbo].[CT_HoaDonBanHang] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [GhiChu]) VALUES (N'HD001', N'SP002', 10, 100, N'2')
INSERT [dbo].[CT_HoaDonBanHang] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [GhiChu]) VALUES (N'HD002', N'SP001', 50, 500, N'2')
INSERT [dbo].[CT_HoaDonBanHang] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [GhiChu]) VALUES (N'HD002', N'SP002', 20, 200, N'2')
INSERT [dbo].[CT_HoaDonBanHang] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [GhiChu]) VALUES (N'HD004', N'SP002', 10, 100, N'1')
INSERT [dbo].[CT_HoaDonNhapHang] ([MaHD], [MaSP], [Soluong], [ThanhTien], [GhiChu]) VALUES (N'HD001', N'SP001', 10, 100, NULL)
INSERT [dbo].[CT_HoaDonNhapHang] ([MaHD], [MaSP], [Soluong], [ThanhTien], [GhiChu]) VALUES (N'HD002', N'SP001', 20, 200, NULL)
INSERT [dbo].[CT_HoaDonNhapHang] ([MaHD], [MaSP], [Soluong], [ThanhTien], [GhiChu]) VALUES (N'HD003', N'SP001', 30, 300, NULL)
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'1', CAST(N'2017-01-03' AS Date), N'NV001', N'KH001', 0, CAST(N'2017-01-03' AS Date), N'')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'5', CAST(N'2017-01-03' AS Date), N'NV001', N'KH001', 0, CAST(N'2017-01-03' AS Date), N'')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'8', CAST(N'2017-01-03' AS Date), N'NV001', N'KH001', 0, CAST(N'2017-01-03' AS Date), N'')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DDH01', CAST(N'2017-01-03' AS Date), N'nhanvien1', N'KH001', 0, CAST(N'2017-01-03' AS Date), N'')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'dh001', CAST(N'2017-01-03' AS Date), N'NV001', N'KH001', 0, CAST(N'2017-01-03' AS Date), N'')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'dh001111', CAST(N'2017-01-03' AS Date), N'NV001', N'KH001', 0, CAST(N'2017-01-03' AS Date), N'')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'f', CAST(N'2017-01-03' AS Date), N'NV001', N'KH001', 0, CAST(N'2017-01-03' AS Date), N'')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'g', CAST(N'2017-01-03' AS Date), N'NV001', N'KH001', 0, CAST(N'2017-01-03' AS Date), N'')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'j', CAST(N'2017-01-03' AS Date), N'NV001', N'KH001', 0, CAST(N'2017-01-03' AS Date), N'')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N't', CAST(N'2017-01-03' AS Date), N'NV001', N'KH001', 0, CAST(N'2017-01-03' AS Date), N'')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'v', CAST(N'2017-01-03' AS Date), N'NV001', N'KH001', 0, CAST(N'2017-01-03' AS Date), N'')
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'aa', CAST(N'2017-01-04' AS Date), N'nhanvien1', N'KH001', 0, N'')
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD001', CAST(N'2016-12-08' AS Date), N'NV001', N'KH001', 120000, N'Test')
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD002', CAST(N'2016-12-05' AS Date), N'NV003', N'KH002', 23000, N'T')
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD003', CAST(N'2016-12-08' AS Date), N'NV003', N'KH005', 40000, N'q')
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD004', CAST(N'2016-11-09' AS Date), N'NV001', N'KH002', 3000, N'q')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD001', CAST(N'2016-12-09' AS Date), N'NV001', N'NCC01', 100000, N'lần 1')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD002', CAST(N'2016-12-04' AS Date), N'NV002', N'NCC01', 200000, N'lần 2')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD003', CAST(N'2016-11-03' AS Date), N'NV003', N'NCC02', 23, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH001', N'Lê Thanh Thủy', N'Thủ Đức', N'13561684', N'Nữ', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH002', N'Nguyễn Văn A', N'Quận 1', N'523253', N'', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH003', N'Nguyên Văn B', N'Quận 2', N'4356346', N'Chưa trả tiền', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH004', N'Dũng', N'Bình Dương', N'16842342', N'chưa mua hoa', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH005', N'Duy', N'Dầu Tiếng', N'982353645', N's', NULL)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC000', N'Tên', N'HCM', N'09575672', N'Ghi chú', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC01', N'Hoa Tươi', N'HCM', N'0985345234', N'Các loại hoa tươi', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC02', N'Cửa Hàng 1', N'Quận 9', N'073563534', N'', 0)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC03', N'Nhà cung cấp ABC', N'Quận Bình Thạnh', N'038464335', NULL, NULL)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC04', N'Nhà cung cấp mới', N'Quận 2', N'054326554', N'', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC05', N'XYZ', N'Quận ', N'0593249238', NULL, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'nhanvien1', N'Trần Anh', 1996, 0, N'01234864984', N'trananh@gmaill.com', N'banhang', N'123456', N'BH', 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV001', N'Hà Văn Dũng', 1994, 0, N'01683245384', N'dunghavan47@gmail.com', N'dunghavan', N'123456', N'FULL', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV002', N'Phan Nhật Đăng', 1995, 1, N'0983453232', N'pnd@gmail.com', N'nhaphang', N'123456', N'NH', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV003', N'Thanh Thủy Lê', 1995, 0, N'0934523564', N'thanhthuy@gmail.com', N'ketoan', N'123456', N'KT', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV004', N'Quang Trung', 1996, 1, N'0123456798', N'quangtrung@gmail.com', N'quanlykho', N'123456', N'QLK', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV009', N'Test', 1995, 1, N'00002222', N'dung@gmail.com', N'admin', N'123456', N'AD', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV0099', N'Thái Hoàng Huy', 1995, 1, N'09618616313', N'hoanghuy@gmail.com', N'thaihoanghuy', N'123456', N'KT', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV99', N'Dũng hà', 1996, 0, N'016854958', N'hadung@gmail.com', N'dung123', N'dunghavan123', N'QLK', 0)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC001', CAST(N'2016-12-10' AS Date), N'NV001', N'NCC02', 10, 100)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC002', CAST(N'2016-12-10' AS Date), N'NV001', N'NCC01', 2000, 2000)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC003', CAST(N'2016-12-10' AS Date), N'NV001', N'NCC04', 300, 300)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC009', CAST(N'2016-12-10' AS Date), N'NV001', N'NCC04', 0, 500000)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'6', CAST(N'2016-12-10' AS Date), N'NV001', N'KH002', 10000, 5000)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'a', CAST(N'2016-12-10' AS Date), N'NV001', N'KH002', 52000, 1000)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'pp', CAST(N'2016-12-10' AS Date), N'NV001', N'KH001', 10000, 7000)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PR', CAST(N'2016-12-10' AS Date), N'NV001', N'KH002', 0, 0)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT', CAST(N'2016-12-10' AS Date), N'NV001', N'KH002', 0, 998)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT0', CAST(N'2016-12-10' AS Date), N'NV001', N'KH002', 2000, 2122)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT001', CAST(N'2016-07-25' AS Date), N'NV001', N'KH001', 10000, 9000)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT002', CAST(N'2016-05-23' AS Date), N'NV002', N'KH003', 20000, 2343)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT0023', CAST(N'2016-12-10' AS Date), N'NV001', N'KH001', 3000, 6000)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT003', CAST(N'2016-12-10' AS Date), N'NV001', N'KH001', 30000, 28000)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT004', CAST(N'2016-12-10' AS Date), N'NV004', N'KH004', 40000, 656342)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT09', CAST(N'2016-12-10' AS Date), N'NV001', N'KH003', 50000, 2)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT092', CAST(N'2016-12-10' AS Date), N'NV001', N'KH003', 60000, 4325)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT12', CAST(N'2016-12-10' AS Date), N'NV001', N'KH002', 70000, 0)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT5', CAST(N'2016-12-10' AS Date), N'NV001', N'KH002', 800, 10800)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP001', N'Hoa Hồng', N'bông', 12000, N'Loại mới', N'H', 0, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP002', N'Hoa Lan', N'bông', 10000, N'Lan loại 1', N'L', NULL, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP003', N'Hoa Cúc', N'chậu', 90000, N'Cúc vàng', N'HoaCuc', 200, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP004', N'Hoa Sen', N'Bông', 100000, N'sen tím', N'S', NULL, 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP005', N'Hoa Hồng', N'Bó', 200000, N'Loại mới', N'HB', 1000, 0)
INSERT [dbo].[ThamSo] ([TenThamSo], [GiaTri]) VALUES (N'SLTonToiThieu', 23)
INSERT [dbo].[ThamSo] ([TenThamSo], [GiaTri]) VALUES (N'SoTienNoToiDa', 26)
INSERT [dbo].[ThamSo] ([TenThamSo], [GiaTri]) VALUES (N'ChietKhau', 43)
ALTER TABLE [dbo].[BaoCaoCongNoKH]  WITH CHECK ADD  CONSTRAINT [FK__BaoCaoCong__MaKH__4BAC3F29] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[BaoCaoCongNoKH] CHECK CONSTRAINT [FK__BaoCaoCong__MaKH__4BAC3F29]
GO
ALTER TABLE [dbo].[BaoCaoDoanhThu]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[BaoCaoTonKho]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CT_DonDatHang]  WITH CHECK ADD FOREIGN KEY([MaDDH])
REFERENCES [dbo].[DonDatHang] ([MaDDH])
GO
ALTER TABLE [dbo].[CT_DonDatHang]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CT_DonNhapHang]  WITH CHECK ADD FOREIGN KEY([MaDNH])
REFERENCES [dbo].[DonNhapHang] ([MaDNH])
GO
ALTER TABLE [dbo].[CT_DonNhapHang]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CT_HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonBanHang] ([MaHD])
GO
ALTER TABLE [dbo].[CT_HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CT_HoaDonNhapHang]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonNhapHang] ([MaHD])
GO
ALTER TABLE [dbo].[CT_HoaDonNhapHang]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CT_PhieuGiaoHang]  WITH CHECK ADD FOREIGN KEY([MaPGH])
REFERENCES [dbo].[PhieuGiaoHang] ([MaPGH])
GO
ALTER TABLE [dbo].[CT_PhieuGiaoHang]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK__DonDatHan__GhiCh__182C9B23] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK__DonDatHan__GhiCh__182C9B23]
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DonNhapHang]  WITH CHECK ADD  CONSTRAINT [FK__DonNhapHa__MaNCC__300424B4] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[DonNhapHang] CHECK CONSTRAINT [FK__DonNhapHa__MaNCC__300424B4]
GO
ALTER TABLE [dbo].[DonNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK__HoaDonBanH__MaKH__286302EC] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK__HoaDonBanH__MaKH__286302EC]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonNhapHang]  WITH CHECK ADD  CONSTRAINT [FK__HoaDonNha__MaNCC__37A5467C] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HoaDonNhapHang] CHECK CONSTRAINT [FK__HoaDonNha__MaNCC__37A5467C]
GO
ALTER TABLE [dbo].[HoaDonNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuChi]  WITH CHECK ADD  CONSTRAINT [FK__PhieuChi__MaNCC__4316F928] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuChi] CHECK CONSTRAINT [FK__PhieuChi__MaNCC__4316F928]
GO
ALTER TABLE [dbo].[PhieuChi]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK__PhieuGiaoH__MaKH__20C1E124] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuGiaoHang] CHECK CONSTRAINT [FK__PhieuGiaoH__MaKH__20C1E124]
GO
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [FK__PhieuThu__MaKH__3F466844] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [FK__PhieuThu__MaKH__3F466844]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
/****** Object:  StoredProcedure [dbo].[BCCONGNOKH_Del]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCCONGNOKH_Del]
	(
		@ngayLap VARCHAR(10),
		@maKH VARCHAR(10)
	)
AS
BEGIN
	DELETE FROM BaoCaoCongNoKH WHERE 
		(CONVERT(VARCHAR(10), NgayLap, 120) = @ngayLap)
		AND MaKH = @maKH
END


GO
/****** Object:  StoredProcedure [dbo].[BCCONGNOKH_getAll]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[BCCONGNOKH_getAll]

AS
BEGIN
	SELECT * FROM BaoCaoCongNoKH
END


GO
/****** Object:  StoredProcedure [dbo].[BCCONGNOKH_getBaoCao]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCCONGNOKH_getBaoCao]
	(
		@maKH VARCHAR(10),
		@ngayLap VARCHAR(10)
	)
AS
BEGIN
	SELECT * FROM BaoCaoCongNoKH B
	WHERE @maKH = B.MaKH
	AND (CONVERT(VARCHAR(10), B.NgayLap, 120) = @ngayLap)
END


GO
/****** Object:  StoredProcedure [dbo].[BCCONGNOKH_getNoKyCuoi]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCCONGNOKH_getNoKyCuoi]
(
	@maKH VARCHAR(10),
	@month INT,
	@year INT
)
AS
BEGIN
	SELECT NoKyCuoi FROM BaoCaoCongNoKH
	WHERE MONTH(NgayLap) = @month 
			AND YEAR(NgayLap) = @year
			AND MaKH = @maKH
END

GO
/****** Object:  StoredProcedure [dbo].[BCCONGNOKH_Insert]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCCONGNOKH_Insert]
	(
		@ngayLap VARCHAR(10),
		@maKH VARCHAR(10),
		@maNV VARCHAR(10),
		@noKyDau INT,
		@phatSinh INT,
		@noKyCuoi INT,
		@ghiChu NVARCHAR(100)
	)
AS
BEGIN
	INSERT INTO BaoCaoCongNoKH VALUES
	(
		@ngayLap,
		@maKH,
		@maNV,
		@noKyDau,
		@phatSinh,
		@noKyCuoi,
		@ghiChu
	)
END


GO
/****** Object:  StoredProcedure [dbo].[BCCONGNOKH_Update]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCCONGNOKH_Update]
	(
		@ngayLap VARCHAR(10),
		@maKH VARCHAR(10),
		@maNV VARCHAR(10),
		@noKyDau INT,
		@phatSinh INT,
		@noKyCuoi INT,
		@ghiChu NVARCHAR(100)
	)
AS
BEGIN
	UPDATE BaoCaoCongNoKH SET
		MaNV = @maNV,
		NoKyDau = @noKyDau,
		PhatSinh = @phatSinh,
		NoKyCuoi = @noKyCuoi,
		GhiChu = @ghiChu
		WHERE 
		(CONVERT(VARCHAR(10), NgayLap, 120) = @ngayLap)
		AND MaKH = @maKH
END


GO
/****** Object:  StoredProcedure [dbo].[BCDOANHTHU_Del]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCDOANHTHU_Del]
	(
		@ngayLap VARCHAR(10),
		@maSP VARCHAR(10)
	)
AS
BEGIN
	DELETE FROM BaoCaoDoanhThu WHERE 
		(CONVERT(VARCHAR(10), NgayLap, 120) = @ngayLap)
		AND MaSP = @maSP
END


GO
/****** Object:  StoredProcedure [dbo].[BCDOANHTHU_getAll]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[BCDOANHTHU_getAll]

AS
BEGIN
	SELECT * FROM BaoCaoDoanhThu
END


GO
/****** Object:  StoredProcedure [dbo].[BCDOANHTHU_getTongChi]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BCDOANHTHU_getTongChi]
(
	@maSP VARCHAR(10),
	@month INT,
	@year INT
)
AS
BEGIN
	SELECT SUM(CT.ThanhTien) AS TONGCHI FROM CT_HoaDonNhapHang CT, HoaDonNhapHang HD
	WHERE MaSP = @maSP AND CT.MaHD = HD.MaHD AND MONTH(HD.NgayLap) = @month AND YEAR(HD.NgayLap) = @year
END
GO
/****** Object:  StoredProcedure [dbo].[BCDOANHTHU_getTongChi_TongThu]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCDOANHTHU_getTongChi_TongThu]
	(
		@maSP VARCHAR(10),
		@month INT,
		@year INT
	)
AS
BEGIN
	DECLARE @TongChi INT, @TongThu INT
	DECLARE @Table TABLE (TongChi INT, TongThu INT)
	EXEC @TongChi = BCDOANHTHU_getTongChi @maSP, @month, @year
	EXEC @TongThu = BCDOANHTHU_getTongThu @maSP, @month, @year
	INSERT INTO @Table VALUES(@TongChi, @TongThu)
	SELECT * FROM @Table
END
GO
/****** Object:  StoredProcedure [dbo].[BCDOANHTHU_getTongThu]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BCDOANHTHU_getTongThu]
(
	@maSP VARCHAR(10),
	@month INT,
	@year INT
)
AS
BEGIN
	SELECT SUM(CT.ThanhTien) AS TONGTHU FROM CT_HoaDonBanHang CT, HoaDonBanHang HD
	WHERE MaSP = @maSP AND CT.MaHD = HD.MaHD AND MONTH(HD.NgayLap) = @month AND YEAR(HD.NgayLap) = @year
END

GO
/****** Object:  StoredProcedure [dbo].[BCDOANHTHU_Insert]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCDOANHTHU_Insert]
	(
		@ngayLap VARCHAR(10),
		@maSP VARCHAR(10),
		@tongChi INT,
		@phatSinh INT,
		@tongThu INT,
		@loiNhuan INT,
		@ghiChu NVARCHAR(100)
	)
AS
BEGIN
	INSERT INTO BaoCaoDoanhThu VALUES
	(
		@ngayLap,
		@maSP,
		@tongChi,
		@phatSinh,
		@tongThu,
		@loiNhuan,
		@ghiChu
	)
END


GO
/****** Object:  StoredProcedure [dbo].[BCDOANHTHU_Update]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCDOANHTHU_Update]
	(
		@ngayLap VARCHAR(10),
		@maSP VARCHAR(10),
		@tongChi INT,
		@phatSinh INT,
		@tongThu INT,
		@loiNhuan INT,
		@ghiChu NVARCHAR(100)
	)
AS
BEGIN
	UPDATE BaoCaoDoanhThu SET
		TongChi = @tongChi,
		PhatSinh = @phatSinh,
		TongThu = @tongThu,
		LoiNhuan = @loiNhuan,
		GhiChu = @ghiChu
		WHERE 
		(CONVERT(VARCHAR(10), NgayLap, 120) = @ngayLap)
		AND MaSP = @maSP
END


GO
/****** Object:  StoredProcedure [dbo].[BCDOANHTHU_Update2]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCDOANHTHU_Update2]
	(
		@ngayLap VARCHAR(10),
		@maSP VARCHAR(10),
		@phatSinh INT,
		@loiNhuan INT,
		@ghiChu NVARCHAR(100)
	)
AS
BEGIN
	UPDATE BaoCaoDoanhThu SET
		PhatSinh = @phatSinh,
		LoiNhuan = @loiNhuan,
		GhiChu = @ghiChu
		WHERE 
		(CONVERT(VARCHAR(10), NgayLap, 120) = @ngayLap)
		AND MaSP = @maSP
END


GO
/****** Object:  StoredProcedure [dbo].[BCTONKHO_Del]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCTONKHO_Del]
	(
		@ngayLap VARCHAR(10),
		@maSP VARCHAR(10)
	)
AS
BEGIN
	DELETE FROM BaoCaoTonKho WHERE 
		(CONVERT(VARCHAR(10), NgayLap, 120) = @ngayLap)
		AND MaSP = @maSP
END


GO
/****** Object:  StoredProcedure [dbo].[BCTONKHO_getAll]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[BCTONKHO_getAll]

AS
BEGIN
	SELECT * FROM BaoCaoTonKho
END

GO
/****** Object:  StoredProcedure [dbo].[BCTONKHO_getSLNhap]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BCTONKHO_getSLNhap]
(
	@maSP VARCHAR(10),
	@month INT,
	@year INT
)
AS
BEGIN
	SELECT SUM(CT.SoLuong) FROM CT_HoaDonNhapHang CT, HoaDonNhapHang HD
	WHERE MaSP = @maSP AND CT.MaHD = HD.MaHD AND MONTH(HD.NgayLap) = @month AND YEAR(HD.NgayLap) = @year
END

GO
/****** Object:  StoredProcedure [dbo].[BCTONKHO_getSLTonKyCuoi]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BCTONKHO_getSLTonKyCuoi]
(
	@maSP VARCHAR(10),
	@month INT,
	@year INT
)
AS
BEGIN
	SELECT SLTonCuoiKy FROM BaoCaoTonKho
	WHERE MaSP = @maSP AND MONTH(NgayLap) = @month AND YEAR(NgayLap) = @year
END

GO
/****** Object:  StoredProcedure [dbo].[BCTONKHO_getSLXuat]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BCTONKHO_getSLXuat]
(
	@maSP VARCHAR(10),
	@month INT,
	@year INT
)
AS
BEGIN
	SELECT SUM(CT.SoLuong) FROM CT_HoaDonBanHang CT, HoaDonBanHang HD
	WHERE MaSP = @maSP AND CT.MaHD = HD.MaHD AND MONTH(HD.NgayLap) = @month AND YEAR(HD.NgayLap) = @year
END

GO
/****** Object:  StoredProcedure [dbo].[BCTONKHO_Insert]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCTONKHO_Insert]
	(
		@ngayLap VARCHAR(10),
		@maSP VARCHAR(10),
		@slTonKyDau INT,
		@slNhap INT,
		@slXuat INT,
		@slPhatSinh INT,
		@slTonCuoiKy INT,
		@ghiChu NVARCHAR(100)
	)
AS
BEGIN
	INSERT INTO BaoCaoTonKho VALUES
	(
		@ngayLap,
		@maSP,
		@slTonKyDau,
		@slNhap,
		@slXuat,
		@slPhatSinh,
		@slTonCuoiKy,
		@ghiChu
	)
END


GO
/****** Object:  StoredProcedure [dbo].[BCTONKHO_Update]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCTONKHO_Update]
	(
		@ngayLap VARCHAR(10),
		@maSP VARCHAR(10),
		@slTonKyDau INT,
		@slNhap INT,
		@slXuat INT,
		@slPhatSinh INT,
		@slTonCuoiKy INT,
		@ghiChu NVARCHAR(100)
	)
AS
BEGIN
	UPDATE BaoCaoTonKho SET
		SLTonKyDau = @slTonKyDau,
		SLNhap = @slNhap,
		SLXuat = @slXuat,
		SLPhatSinh = @slPhatSinh,
		GhiChu = @ghiChu
		WHERE 
		(CONVERT(VARCHAR(10), NgayLap, 120) = @ngayLap)
		AND MaSP = @maSP
END


GO
/****** Object:  StoredProcedure [dbo].[CONGNO_LAYCONGNO]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CONGNO_LAYCONGNO]
(
	@MAKH VARCHAR (10)
	
)

AS
BEGIN
	
	SELECT a.NoKyCuoi
	FROM BaoCaoCongNoKH A, KhachHang B
	WHERE A.MaKH = B.MaKH
	
END

GO
/****** Object:  StoredProcedure [dbo].[CT_DONDATHANG_DELETE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[CT_DONDATHANG_DELETE]
	 (
		@MaDDH varchar(10),
		@MASP VARCHAR(10)
	 )
	 AS
	 BEGIN
		DELETE FROM CT_DONDATHANG WHERE MaDDH=@MaDDH AND MaSP = @MASP

	 END


GO
/****** Object:  StoredProcedure [dbo].[ct_dondathang_deletetheomaddh]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ct_dondathang_deletetheomaddh]
	 (
		@MaDDH varchar(10)
		
	 )
	 AS
	 BEGIN
		DELETE FROM CT_DONDATHANG WHERE MaDDH=@MaDDH 

	 END

GO
/****** Object:  StoredProcedure [dbo].[CT_DONDATHANG_INSERT]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_DONDATHANG_INSERT]
  (
	@MaDDH varchar(10),
	@MASP VARCHAR (10),

	@SOLUONG INT,
	@THANHTIEN INT,
	@GHICHU NVARCHAR(100)
	) 

	AS
	BEGIN
		
		Insert into CT_DonDatHang(MaDDH,MaSP,SoLuong, ThanhTien, GhiChu) values( @MaDDH, @MASP, @SOLUONG, @THANHTIEN, @GHICHU)
	END


GO
/****** Object:  StoredProcedure [dbo].[ct_dondathang_ktmasp]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ct_dondathang_ktmasp]
	 @masp varchar(10),
	 @maddh varchar(10)
	 as
	 begin
		select MaSP
		from CT_DonDatHang
		where MaSP=@masp and MaDDH=@maddh
	 end

GO
/****** Object:  StoredProcedure [dbo].[CT_DONDATHANG_LAYDS]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_DONDATHANG_LAYDS]

AS
BEGIN
	SELECT A.MaDDH, b.MaSP,b.TenSP, C.SoLuong, b.DonGia, c.ThanhTien
	FROM DONDATHANG A, SANPHAM B, CT_DonDatHang C
	WHERE A.MaDDH = C.MaDDH AND C.MaSP= B.MaSP
END

GO
/****** Object:  StoredProcedure [dbo].[ct_dondathang_laydstheomaddh]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ct_dondathang_laydstheomaddh]
 @maddh nvarchar(10)
 AS
BEGIN
	SELECT A.MaDDH,b.MaSP, B.TenSP, C.SoLuong, b.DonGia, c.ThanhTien
	FROM DONDATHANG A, SANPHAM B, CT_DonDatHang C
	WHERE A.MaDDH = C.MaDDH AND C.MaSP= B.MaSP and a.MaDDH =@maddh
END

GO
/****** Object:  StoredProcedure [dbo].[CT_DONDATHANG_LAYSL_THEOMASP]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CT_DONDATHANG_LAYSL_THEOMASP]
(
	@MASP VARCHAR (10),
	@maddh varchar(10)
	
)

AS
BEGIN
	
	SELECT a.SoLuong
	FROM CT_DonDatHang a
	WHERE a.MaDDH=@maddh and a.MaSP=@MASP
	
END

GO
/****** Object:  StoredProcedure [dbo].[CT_DONDATHANG_TIMKIEM]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_DONDATHANG_TIMKIEM]
(
	@MaDDH varchar(10),
	@MASP VARCHAR (10),

	@SOLUONG INT,
	@THANHTIEN INT,
	@GHICHU NVARCHAR(100)
)
AS
 BEGIN

	if(@MaDDH is not null and @MaDDH <> '')
	begin
	SELECT * from CT_DonDatHang where MaDDH like '%'+@MaDDH+ '%'
	end
	
	if(@MASP is not null and @MASP <> '')
	begin
	SELECT * from CT_DonDatHang where MaSP like '%' + @MASP + '%'
	end
	if(@SOLUONG is not null and @SOLUONG <> '')
	begin
	SELECT * from CT_DonDatHang where @SOLUONG like '%' + @SOLUONG + '%'
	end
	if(@THANHTIEN is not null and @THANHTIEN <> '')
	begin
	SELECT * from CT_DonDatHang where @THANHTIEN like '%' + @THANHTIEN + '%'
	end
	--if(@sdt is not null and @sdt <> '')
	--begin
	-- * from KHACHHANG where SODT like '%' + @sdt + '%'
	--end
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[CT_DONDATHANG_UPDATE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_DONDATHANG_UPDATE]
  (
	@MaDDH varchar(10),
	@MASP VARCHAR (10),

	@SOLUONG INT,
	@THANHTIEN INT
	

	)
	AS
	BEGIN
		UPDATE CT_DonDatHang SET  SoLuong =@SOLUONG, ThanhTien = @THANHTIEN
		WHERE MaDDH = @MaDDH AND MaSP = @MASP
	END


GO
/****** Object:  StoredProcedure [dbo].[CT_HOADON_DELETE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_HOADON_DELETE]
	 (
		@MaHD varchar(10),
		@MASP VARCHAR(10)

	 )
	 AS
	 BEGIN
		DELETE FROM CT_HoaDonBanHang WHERE MaHD=@MaHD AND MaSP = @MASP

	 END

GO
/****** Object:  StoredProcedure [dbo].[ct_hoadon_deletetheomahd]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ct_hoadon_deletetheomahd]
	 (
		@Mahd varchar(10)
		
	 )
	 AS
	 BEGIN
		DELETE FROM CT_HoaDonBanHang WHERE MaHD=@Mahd

	 END

GO
/****** Object:  StoredProcedure [dbo].[CT_HOADON_INSERT]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_HOADON_INSERT]
  (
	@MaHD varchar(10),
	@MASP VARCHAR (10),

	@SOLUONG INT,
	@THANHTIEN INT,
	@GHICHU NVARCHAR(100)
	) 

	AS
	BEGIN
	
		Insert into CT_HoaDonBanHang(MaHD,MaSP,SoLuong, ThanhTien, GhiChu) values( @MaHD, @MASP, @SOLUONG, @THANHTIEN, @GHICHU)
	END

GO
/****** Object:  StoredProcedure [dbo].[CT_HOADON_LAYDS]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_HOADON_LAYDS]

AS
BEGIN
	SELECT A.MaHD, c.MaSP, c.TenSP, c.DonGia,b.SoLuong, B.ThanhTien
	FROM HoaDonBanHang A, CT_HoaDonBanHang B, SanPham C
	WHERE A.MaHD = B.MaHD AND B.MaSP = C.MaSP
END

GO
/****** Object:  StoredProcedure [dbo].[ct_hoadon_laydstheohd]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ct_hoadon_laydstheohd]
 @mahd nvarchar(10)
 AS
BEGIN
	SELECT A.MaHD,b.MaSP, B.TenSP, C.SoLuong, b.DonGia, c.ThanhTien
	FROM HoaDonBanHang A, SANPHAM b, CT_HoaDonBanHang c
	WHERE a.MaHD = c.MaHD AND C.MaSP= B.MaSP and a.MaHD=@mahd
END


GO
/****** Object:  StoredProcedure [dbo].[CT_HOADON_TIMKIEM]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_HOADON_TIMKIEM]
(
	@MaHD varchar(10),
	@MASP VARCHAR (10),

	@SOLUONG INT,
	@THANHTIEN INT,
	@GHICHU NVARCHAR(100)
)
AS
 BEGIN

	if(@MaHD is not null and @MaHD <> '')
	begin
	SELECT * from CT_HoaDonBanHang where MaHD like '%'+@MaHD+ '%'
	end
	
	if(@MASP is not null and @MASP <> '')
	begin
	SELECT * from CT_HoaDonBanHang where MaSP like '%' + @MASP + '%'
	end
	if(@SOLUONG is not null and @SOLUONG <> '')
	begin
	SELECT * from CT_HoaDonBanHang where @SOLUONG like '%' + @SOLUONG + '%'
	end
	if(@THANHTIEN is not null and @THANHTIEN <> '')
	begin
	SELECT * from CT_HoaDonBanHang where @THANHTIEN like '%' + @THANHTIEN + '%'
	end
	--if(@sdt is not null and @sdt <> '')
	--begin
	-- * from KHACHHANG where SODT like '%' + @sdt + '%'
	--end
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[CT_HOADON_UPDATE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_HOADON_UPDATE]
  (
	@MaHD varchar(10),
	@MASP VARCHAR (10),
	
	@SOLUONG INT,
	@THANHTIEN INT,
	@GHICHU NVARCHAR(100)

	)
	AS
	BEGIN
		UPDATE CT_HoaDonBanHang SET MaHD = @MaHD, MaSP = @MASP, SoLuong =@SOLUONG, ThanhTien = @THANHTIEN, GhiChu = @GHICHU
		WHERE MaHD = @MaHD AND MaSP = @MASP
	END

GO
/****** Object:  StoredProcedure [dbo].[CT_HOADONBANHANG_getTongTienByNgayLap]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_HOADONBANHANG_getTongTienByNgayLap]
(
	@month int,
	@year int
)
AS
BEGIN
	SELECT MaSP, SUM(ThanhTien) AS TongTien FROM CT_HoaDonBanHang CT, HoaDonBanHang HD
	WHERE CT.MaHD = HD.MaHD AND MONTH(HD.NgayLap) = @month AND YEAR(HD.NgayLap) = @year
	GROUP BY MaSP
END

GO
/****** Object:  StoredProcedure [dbo].[ct_hoadonsi_layds]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ct_hoadonsi_layds]
@maddh nvarchar(10)
as
begin
	SELECT c.MaSP, b.TenSP, C.SoLuong, b.DonGia, c.ThanhTien
	FROM DONDATHANG A, SANPHAM B, CT_DonDatHang C
	WHERE A.MaDDH = C.MaDDH AND C.MaSP= B.MaSP and a.MaDDH =@maddh
end

GO
/****** Object:  StoredProcedure [dbo].[CT_PHIEUGIAOHANG_DELETE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_PHIEUGIAOHANG_DELETE]
	 (
		@MaPGH varchar(10),
		@MASP VARCHAR(10)
	 )
	 AS
	 BEGIN
		DELETE FROM CT_PhieuGiaoHang WHERE MaPGH=@MaPGH AND MaSP = @MASP

	 END

GO
/****** Object:  StoredProcedure [dbo].[ct_phieugiaohang_deletetheomapgh]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[ct_phieugiaohang_deletetheomapgh]
	 (
		@Mapgh varchar(10)
		
	 )
	 AS
	 BEGIN
		DELETE FROM CT_PhieuGiaoHang WHERE MaPGH=@Mapgh

	 END

GO
/****** Object:  StoredProcedure [dbo].[CT_PHIEUGIAOHANG_INSERT]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_PHIEUGIAOHANG_INSERT]
  (
	@MaPGH varchar(10),
	@MASP VARCHAR (10),

	@SOLUONG INT,
	@THANHTIEN INT,
	@GHICHU NVARCHAR(100)
	) 

	AS
	BEGIN
		
		Insert into CT_PhieuGiaoHang(MaPGH,MaSP,SoLuong, ThanhTien, GhiChu) values( @MaPGH, @MASP, @SOLUONG, @THANHTIEN, @GHICHU)
	END


GO
/****** Object:  StoredProcedure [dbo].[ct_phieugiaohang_ktsldagiao]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ct_phieugiaohang_ktsldagiao]
  (
	@maddh varchar(10),
	@masp varchar (10)  
	)
	as
	begin
		select sum(a.SoLuong)
  from CT_PhieuGiaoHang a, PhieuGiaoHang b
  where a.MaPGH=b.MaPGH and b.MaDDH=@maddh and a.MaSP=@masp
	end

GO
/****** Object:  StoredProcedure [dbo].[CT_PHIEUGIAOHANG_LAYDS]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_PHIEUGIAOHANG_LAYDS]

AS
BEGIN
	SELECT A.MaPGH, b.MaSP,c.TenSP, B.SoLuong, c.DonGia,b.ThanhTien
	FROM PhieuGiaoHang A, CT_PhieuGiaoHang B, SanPham C
	WHERE A.MaPGH = B.MaPGH AND B.MaSP = C.MaSP
END

GO
/****** Object:  StoredProcedure [dbo].[ct_phieugiaohang_laydstheomapgh]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ct_phieugiaohang_laydstheomapgh]
(
@mapgh nvarchar(10)
)
 AS
BEGIN
	SELECT a.MaPGH,b.MaSP, B.TenSP, C.SoLuong, b.DonGia, c.ThanhTien
	FROM  PhieuGiaoHang A, SANPHAM B, CT_PhieuGiaoHang C
	WHERE A.MaPGH = c.MaPGH AND C.MaSP= B.MaSP and a.MaPGH=@mapgh
END

GO
/****** Object:  StoredProcedure [dbo].[ct_phieugiaohang_laysl_theomasp]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ct_phieugiaohang_laysl_theomasp]
(
	@MASP VARCHAR (10),
	@mapgh varchar(10)
	
)

AS
BEGIN
	
	SELECT a.SoLuong
	FROM CT_PhieuGiaoHang a
	WHERE a.MaPGH=@mapgh and a.MaSP=@MASP
	
END

GO
/****** Object:  StoredProcedure [dbo].[CT_PHIEUGIAOHANG_TIMKIEM]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_PHIEUGIAOHANG_TIMKIEM]
(
	@MaPGH varchar(10),
	@MASP VARCHAR (10),

	@SOLUONG INT,
	@THANHTIEN INT,
	@GHICHU NVARCHAR(100)
)
AS
 BEGIN

	if(@MaPGH is not null and @MaPGH <> '')
	begin
	SELECT * from CT_PhieuGiaoHang where MaPGH like '%'+@MaPGH+ '%'
	end
	
	if(@MASP is not null and @MASP <> '')
	begin
	SELECT * from CT_PhieuGiaoHang where MaSP like '%' + @MASP + '%'
	end
	if(@SOLUONG is not null and @SOLUONG <> '')
	begin
	SELECT * from CT_PhieuGiaoHang where @SOLUONG like '%' + @SOLUONG + '%'
	end
	if(@THANHTIEN is not null and @THANHTIEN <> '')
	begin
	SELECT * from CT_PhieuGiaoHang where @THANHTIEN like '%' + @THANHTIEN + '%'
	end
	--if(@sdt is not null and @sdt <> '')
	--begin
	-- * from KHACHHANG where SODT like '%' + @sdt + '%'
	--end
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[CT_PHIEUGIAOHANG_UPDATE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_PHIEUGIAOHANG_UPDATE]
  (
	@MaPGH varchar(10),
	@MASP VARCHAR (10),

	@SOLUONG INT,
	@THANHTIEN INT,
	@GHICHU NVARCHAR(100)

	)
	AS
	BEGIN
		UPDATE CT_PhieuGiaoHang SET MaPGH = @MaPGH, MaSP = @MASP, SoLuong =@SOLUONG, ThanhTien = @THANHTIEN, GhiChu = @GHICHU
		WHERE MAPGH = @MaPGH AND MaSP = @MASP
	END

GO
/****** Object:  StoredProcedure [dbo].[DONDATHANG_DELETE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	 CREATE PROCEDURE [dbo].[DONDATHANG_DELETE]
	 (
		@MaDDH varchar(10)
	 )
	 AS
	 BEGIN
		DELETE FROM DONDATHANG WHERE MaDDH=@MaDDH

	 END

GO
/****** Object:  StoredProcedure [dbo].[DONDATHANG_INSERT]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DONDATHANG_INSERT]
  (
	
	@MaDDH varchar(10),
	@NgayLap date,
	@MaNV varchar(10),
	@MaKH varchar (10),
	@TongTien int,
	@NgayGiaoDuKien date,
	@GhiChu nvarchar(100)

	) 

	AS
	BEGIN
		Insert into DonDatHang(MaDDH,NgayLap,MaNV,MaKH,TongTien, NgayGiaoDuKien, GhiChu) values(@MaDDH,  @NgayLap, @MaNV, @MaKH, @TongTien, @NgayGiaoDuKien, @GhiChu)
	END


GO
/****** Object:  StoredProcedure [dbo].[dondathang_ktmaDDH]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[dondathang_ktmaDDH]
@maddh varchar (10)
as
begin
	select MaDDH
	from DonDatHang
	where MaDDH =@maddh
end

GO
/****** Object:  StoredProcedure [dbo].[DONDATHANG_LAYDS]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DONDATHANG_LAYDS]

AS
BEGIN
	SELECT A.MaDDH, B.HoTen AS TenNV, C.HoTen, A.TongTien, A.NgayLap, a.NgayGiaoDuKien
	FROM DONDATHANG A, NHANVIEN B, KHACHHANG C
	WHERE A.MaNV=B.MaNV AND A.MaKH=C.MaKH
END

GO
/****** Object:  StoredProcedure [dbo].[DONDATHANG_LAYDSmaddh]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[DONDATHANG_LAYDSmaddh]

AS
BEGIN
	SELECT MaDDH
	FROM DONDATHANG 
	
END

GO
/****** Object:  StoredProcedure [dbo].[DONDATHANG_TIMKIEM]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DONDATHANG_TIMKIEM]
(
	@MaDDH varchar(10),
	@NgayLap date,
	@MaNV varchar(10),
	@MaKH varchar (10),
	@TongTien int,
	@NgayGiaoDuKien date,
	@GhiChu nvarchar(100)
)
AS
 BEGIN

	if(@MaDDH is not null and @MaDDH <> '')
	begin
	SELECT * from DonDatHang where MaDDH like '%'+@MaDDH+ '%'
	end
	
	if(@MaNV is not null and @MaNV <> '')
	begin
	SELECT * from DonDatHang where MaNV like '%' + @MaNV + '%'
	end
	if(@MaKH is not null and @MaKH <> '')
	begin
	SELECT * from DonDatHang where @MaKH like '%' + @MaKH + '%'
	end
	--if(@sdt is not null and @sdt <> '')
	--begin
	-- * from KHACHHANG where SODT like '%' + @sdt + '%'
	--end
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[DONDATHANG_UPDATE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DONDATHANG_UPDATE]
  (
	@MaDDH varchar(10),
	@NgayLap date,
	@MaNV varchar(10),
	@MaKH varchar (10),
	@TongTien int,
	@NgayGiaoDuKien date,
	@GhiChu nvarchar(100)

	)
	AS
	BEGIN
		UPDATE DonDatHang SET DonDatHang.NgayLap = @NgayLap, MaNV=@MaNV, MaKH=@MaKH, TongTien=@TongTien, NgayGiaoDuKien=@NgayGiaoDuKien, GhiChu=@GhiChu
		WHERE MaDDH=@MaDDH
	END


GO
/****** Object:  StoredProcedure [dbo].[DONDATHANG_UPDATETONGTIEN]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DONDATHANG_UPDATETONGTIEN]
@MADDH NVARCHAR (10),
@TONGTIEN INT
AS
BEGIN
UPDATE DonDatHang SET TongTien = @TONGTIEN WHERE MaDDH=@MADDH
END

GO
/****** Object:  StoredProcedure [dbo].[DONNHAPHANG_Del]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DONNHAPHANG_Del]
	(
		@maDNH VARCHAR(10)
	)
AS
BEGIN
	DELETE FROM DonNhapHang
	WHERE @maDNH LIKE DonNhapHang.MaDNH
END




GO
/****** Object:  StoredProcedure [dbo].[DonNhapHang_getAll]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
Create PROCEDURE [dbo].[DonNhapHang_getAll]

AS
BEGIN
	SELECT * FROM DonNhapHang
END


GO
/****** Object:  StoredProcedure [dbo].[DonNhapHang_getDonNhapHang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[DonNhapHang_getDonNhapHang]
	(
		@maDNH VARCHAR(10)
	)
AS
BEGIN
	SELECT * FROM DonNhapHang
	WHERE @maDNH = MaDNH
END




GO
/****** Object:  StoredProcedure [dbo].[DonNhapHang_Insert]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[DonNhapHang_Insert]
	(
		@maDNH VARCHAR(10),
		@NgayLap NVARCHAR(50),
		@maNV varchar,
		@maNCC varchar,
		@tongTien int,
		@ngayGiaoDuKien date,
		@ghiChu NVARCHAR(100)
	
	)
AS
BEGIN
	INSERT INTO DonNhapHang VALUES(@maDNH, @NgayLap, @maNV,
								@maNCC, @tongTien, @ngayGiaoDuKien, @ghiChu)
END



GO
/****** Object:  StoredProcedure [dbo].[DonNhapHang_Update]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[DonNhapHang_Update]
	(
		@maDNH VARCHAR(10),
		@NgayLap NVARCHAR(50),
		@maNV varchar,
		@maNCC varchar,
		@tongTien int,
		@ngayGiaoDuKien date,
		@ghiChu NVARCHAR(100)
	)
AS
BEGIN
	UPDATE DonNhapHang
	SET MaDNH = @maDNH,
		NgayLap= @NgayLap,
		MaNV = @maNV,
		MaNCC = @maNCC,
		TongTien = @tongTien,
		NgayGiaoDuKien = @ngayGiaoDuKien,
		GhiChu = @ghiChu
		
	WHERE @maDNH = MaDNH
END




GO
/****** Object:  StoredProcedure [dbo].[HOADON_DELETE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[HOADON_DELETE]
	 (
		@MaHD varchar(10)
	 )
	 AS
	 BEGIN
		DELETE FROM HoaDonBanHang WHERE MaHD=@MaHD

	 END


GO
/****** Object:  StoredProcedure [dbo].[HOADON_INSERT]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADON_INSERT]
  (
	@MaHD varchar(10),
	@NgayLap date,
	@MaNV varchar(10),
	@MaKH varchar (10),
	@TongTien int,
	
	@GhiChu nvarchar(100)

	) 

	AS
	BEGIN
		
		Insert into HoaDonBanHang(MaHD,NgayLap,MaNV,MaKH,TongTien, GhiChu) values( @MaHD, @NgayLap, @MaNV, @MaKH, @TongTien, @GhiChu)
	END

GO
/****** Object:  StoredProcedure [dbo].[hoadon_ktmaHD]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[hoadon_ktmaHD]
@mahd varchar (10)
as
begin
	select MaHD
	from HoaDonBanHang
	where MaHD=@mahd
end

GO
/****** Object:  StoredProcedure [dbo].[HOADON_LAYDS]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADON_LAYDS]

AS
BEGIN
	SELECT A.MaHD, A.NgayLap, B.HoTen, C.HoTen, A.TongTien
	FROM HoaDonBanHang A, NHANVIEN B, KHACHHANG C
	WHERE A.MaNV=B.MaNV AND A.MaKH=C.MaKH
END

GO
/****** Object:  StoredProcedure [dbo].[HOADON_UPDATE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADON_UPDATE]
  (
	@MaHD varchar(10),
	@NgayLap date,
	@MaNV varchar(10),
	@MaKH varchar (10),
	@TongTien int,
	@GhiChu nvarchar(100)

	)
	AS
	BEGIN
		UPDATE HoaDonBanHang SET NgayLap = @NgayLap, MaNV=@MaNV, MaKH=@MaKH, TongTien=@TongTien, GhiChu=@GhiChu
		WHERE MaHD =@MaHD
	END

GO
/****** Object:  StoredProcedure [dbo].[hoadon_update_tongtien]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[hoadon_update_tongtien]
@mahd NVARCHAR (10),
@TONGTIEN INT
AS
BEGIN
UPDATE HoaDonBanHang SET TongTien = @TONGTIEN WHERE Mahd=@mahd
END

GO
/****** Object:  StoredProcedure [dbo].[hoadonsi_laythongtintheomaddh]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[hoadonsi_laythongtintheomaddh]
@maddh varchar(10)
as
begin
	SELECT A.MaDDH,b.MaSP, B.TenSP, C.SoLuong, b.DonGia, c.ThanhTien
	FROM DONDATHANG A, SANPHAM B, CT_DonDatHang C
	WHERE A.MaDDH = C.MaDDH AND C.MaSP= B.MaSP and a.MaDDH =@maddh
end


	

GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_DELETE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[KHACHHANG_DELETE]
	 (
		@MaKH varchar(10)
	 )
	 AS
	 BEGIN
		UPDATE KhachHang
		SET IsActive = 0
		WHERE MAKH=@MaKH

	 END


GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_INSERT]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHACHHANG_INSERT]
  (
	@MaKH varchar(10),
	@HoTen nvarchar(50),
	@DiaChi nvarchar(50),
	@SoDT int,
	@GhiChu nvarchar(100)

	) 

	AS
	BEGIN
		
		Insert into KHACHHANG(MaKH,HoTen,DiaChi,SoDT,GhiChu) values( @MaKH, @HoTen, @Diachi , @SoDT,@GhiChu)
			
	END
GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_LAYDS]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KHACHHANG_LAYDS]
 AS
SELECT * FROM KHACHHANG

GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_LAYTHONGTIN]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[KHACHHANG_LAYTHONGTIN]
@MAKH VARCHAR(10)
AS
BEGIN
	SELECT MaKH, HoTen, DiaChi, SoDT, GhiChu, IsActive
	FROM KhachHang
	WHERE MaKH=@MAKH
END
GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_TIMKIEM]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KHACHHANG_TIMKIEM]
@TuKhoa varchar(100)
 AS

 BEGIN
	SELECT * from KHACHHANG where (MAKH like '%'+ @TuKhoa+ '%')
							or	(HoTen like '%'+ @TuKhoa+ '%')
							or	(DiaChi like '%'+ @TuKhoa+ '%')
							or	(SODT like '%'+ @TuKhoa+ '%')
							or	(GhiChu like '%'+ @TuKhoa+ '%')
END

GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_TIMKIEM2]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KHACHHANG_TIMKIEM2]
(
	@MaKH varchar(10),
	@HoTen nvarchar(50),
	@DiaChi nvarchar(50),
	@SoDT int,
	@GhiChu nvarchar(100)
)
AS
 BEGIN

	if(@makh is not null and @makh <> '')
	begin
	SELECT * from KHACHHANG where MAKH like '%'+@makh+ '%'
	end
	if(@HoTen is not null and @HoTen <> '')
	begin
	SELECT * from KHACHHANG where HoTen like '%' + @HoTen + '%'
	end
	if(@diachi is not null and @diachi <> '')
	begin
	SELECT * from KHACHHANG where DIACHI like '%' + @diachi + '%'
	end
	if(@SoDT is not null and @SoDT <> '')
	begin
	SELECT * from KHACHHANG where SoDT like '%' + @SoDT + '%'
	end
	--if(@sdt is not null and @sdt <> '')
	--begin
	-- * from KHACHHANG where SODT like '%' + @sdt + '%'
	--end
	
	
END


GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_UPDATE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KHACHHANG_UPDATE]
  (
	@MaKH varchar(10),
	@HoTen nvarchar(50),
	@DiaChi nvarchar(50),
	@SoDT int,
	@GhiChu nvarchar(100),
	@isActive bit
	)
	AS
	BEGIN
		UPDATE KHACHHANG SET KHACHHANG.HoTen = @HoTen, KHACHHANG.DiaChi = @DiaChi, KHACHHANG.SoDT = @SoDT, KHACHHANG.GhiChu = @GhiChu,
								IsActive = @isActive
								WHERE KHACHHANG.MaKH = @MaKH
	END

GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_DELETE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROCEDURE [dbo].[NHACUNGCAP_DELETE]
	 (
		@MaNCC varchar(10)
	 )
	 AS
	 BEGIN
		Update NhaCungCap 
		set isActive = 0
		Where NhaCungCap.MaNCC = @MaNCC
	 END



GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_getAll]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
create PROCEDURE [dbo].[NHACUNGCAP_getAll]

AS
BEGIN
	SELECT * FROM NhaCungCap
END




GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_getNCC]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[NHACUNGCAP_getNCC]
	(
		@maNCC VARCHAR(10)
	)
AS
BEGIN
	SELECT * FROM NhaCungCap
	WHERE @maNCC = MaNCC
END




GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_Insert]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NHACUNGCAP_Insert]
	(
		@maNCC VARCHAR(10),
		@ten NVARCHAR(50),
		@diaChi NVARCHAR(50),
		@soDT VARCHAR(15),
		@ghiChu nvarchar(100),
		@isActive bit
		)
AS
BEGIN
	INSERT INTO NhaCungCap VALUES(@maNCC, @ten, @diaChi,
								@soDT, @ghiChu,@isActive)
END





GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_Search]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
CREATE PROCEDURE [dbo].[NHACUNGCAP_Search]
	(
	

		@maNCC VARCHAR(10)='',
		@tenNCC NVARCHAR(50)=''

	)
AS
BEGIN
	select * from NhaCungCap
	WHERE (MaNCC LIKE '%'+ @maNCC + '%' OR @maNCC IS NULL or @maNCC = '')
		AND (Ten LIKE '%' + @tenNCC + '%' or @tenNCC is null or @tenNCC = '')
		
END





GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_Update]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
Create PROCEDURE [dbo].[NHACUNGCAP_Update]
	(
		@maNCC VARCHAR(10),
		@ten NVARCHAR(50),
		@diaChi nvarchar(50),
		@soDT VARCHAR(15),
		@ghiChu nvarchar(100),
		@isActive bit
	)
AS
BEGIN
	UPDATE NhaCungCap
	SET 
		Ten= @ten,
		DiaChi = @diaChi,
		SoDT = @soDT,
		GhiChu = @ghiChu,
		isActive = @isActive
		
	WHERE @maNCC = MaNCC
END




GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Del]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NHANVIEN_Del]
	(
		@maNhanVien VARCHAR(10)
	)
AS
BEGIN
	UPDATE NHANVIEN SET IsActive = 0
	WHERE @maNhanVien LIKE NhanVien.MaNV
END


GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_getAll]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
create PROCEDURE [dbo].[NHANVIEN_getAll]

AS
BEGIN
	SELECT * FROM NhanVien
END


GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_getNhanVien]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NHANVIEN_getNhanVien]
	(
		@maNhanVien VARCHAR(10)
	)
AS
BEGIN
	SELECT * FROM NhanVien
	WHERE @maNhanVien = MaNV
END


GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Insert]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NHANVIEN_Insert]
	(
		@maNhanVien VARCHAR(10),
		@hoTen NVARCHAR(50),
		@namSinh INT,
		@gioiTinh BIT,
		@soDT VARCHAR(15),
		@email VARCHAR(50),
		@username VARCHAR(50),
		@password VARCHAR(50),
		@maLoaiNV VARCHAR(20),
		@isActive BIT
	)
AS
BEGIN
	INSERT INTO NhanVien VALUES(@maNhanVien, @hoTen, @namSinh,
								@gioiTinh, @soDT, @email, @username, @password, @maLoaiNV, @isActive)
END


GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Search]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[NHANVIEN_Search]
	(
		@maNhanVien VARCHAR(10) = '',
		@hoTen NVARCHAR(50) = '',
		@namSinh INT = 0,
		@maLoaiNV VARCHAR(20) = ''
	)
AS
BEGIN
	select * from NHANVIEN
	WHERE (MaNV LIKE '%'+ @maNhanVien + '%' OR @maNhanVien IS NULL or @maNhanVien = '')
		AND (HoTen LIKE '%' + @hoTen + '%' or @hoTen is null or @hoTen = '')
		AND (NamSinh = @namSinh or @namSinh = 0)
		AND (MaLoaiNV LIKE @maLoaiNV or @maLoaiNV is null or @maLoaiNV = '')
END


GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Update]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[NHANVIEN_Update]
	(
		@maNhanVien VARCHAR(10),
		@hoTen NVARCHAR(50),
		@namSinh INT,
		@gioiTinh BIT,
		@soDT VARCHAR(15),
		@email VARCHAR(50),
		@username VARCHAR(50),
		@password VARCHAR(50),
		@maLoaiNV VARCHAR(20),
		@isActive BIT
	)
AS
BEGIN
	UPDATE NHANVIEN
	SET HoTen = @hoTen,
		NamSinh= @namSinh,
		GioiTinh = @gioiTinh,
		SoDT = @soDT,
		Email = @email,
		Username = @username,
		[Password] = @password,
		MaLoaiNV = @maLoaiNV,
		IsActive = @isActive
	WHERE @maNhanVien = MaNV
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUCHI_Del]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PHIEUCHI_Del]
	(
		@MaPC VARCHAR(10)
	)
AS
BEGIN
	DELETE FROM PhieuChi
	WHERE @MaPC LIKE PhieuChi.MaPC
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUCHI_getAll]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[PHIEUCHI_getAll]

AS
BEGIN
	SELECT * FROM PhieuChi
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUCHI_getPhieuThu]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PHIEUCHI_getPhieuThu]
	(
		@MaPC VARCHAR(10)
	)
AS
BEGIN
	SELECT * FROM PhieuChi
	WHERE @MaPC = MaPC
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUCHI_Insert]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PHIEUCHI_Insert]
	(
		@MaPC VARCHAR(10),
		@NgayLap VARCHAR(10),
		@MaNV VARCHAR(10),
		@MaNCC VARCHAR(10),
		@SoTienNo int,
		@SoTienChi int
	)
AS
BEGIN
	INSERT INTO PhieuChi VALUES(@MaPC, @NgayLap, @MaNV,
								@MaNCC, @SoTienNo, @SoTienChi)
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUCHI_Search]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[PHIEUCHI_Search]
	(
		@MaPC VARCHAR(10) = '',
		@NgayLap VARCHAR(10) = ''
	)
AS
BEGIN
	select * from PhieuChi
	WHERE (MaPC LIKE '%'+ @MaPC + '%' OR @MaPC IS NULL or @MaPC = '')
		AND (CONVERT(VARCHAR(10), PhieuChi.NgayLap, 120) = @NgayLap OR @NgayLap is null OR @NgayLap = '')
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUCHI_Update]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[PHIEUCHI_Update]
	(
		@MaPC VARCHAR(10),
		@NgayLap datetime,
		@MaNV VARCHAR(10),
		@MaNCC VARCHAR(10),
		@SoTienNo int,
		@SoTienChi int
	)
AS
BEGIN
	UPDATE PhieuChi
	SET NgayLap = @NgayLap,
		MaNV= @MaNV,
		MaNCC = @MaNCC,
		SoTienNo = @SoTienNo,
		SoTienChi = @SoTienChi
	WHERE @MaPC = MaPC
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUGIAOHANG_DELETE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PHIEUGIAOHANG_DELETE]
	 (
		@MaPGH varchar(10)
	 )
	 AS
	 BEGIN
		DELETE FROM PhieuGiaoHang WHERE MaPGH=@MaPGH

	 END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUGIAOHANG_INSERT]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 CREATE PROCEDURE [dbo].[PHIEUGIAOHANG_INSERT]
  (
	@MaPGH varchar(10),
	@NgayLap date,
	@MaNV varchar(10),
	@MaKH varchar (10),
	@TongTien int,
	
	@GhiChu nvarchar(100),
	@MADDH VARCHAR(10)
	) 

	AS
	BEGIN
		

		
		Insert into PhieuGiaoHang(MaPGH,NgayLap,MaNV,MaKH,TongTien, GhiChu, MaDDH) values( @MaPGH, @NgayLap, @MaNV, @MaKH, @TongTien, @GhiChu,@MADDH )
	END

GO
/****** Object:  StoredProcedure [dbo].[phieugiaohang_ktmaPGH]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[phieugiaohang_ktmaPGH]
@mapgh varchar (10)
as
begin
	select MaPGH
	from PhieuGiaoHang
	where MaPGH=@mapgh
end

GO
/****** Object:  StoredProcedure [dbo].[phieugiaohang_ktsoluong_ddh]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[phieugiaohang_ktsoluong_ddh]
@maddh varchar(10),
@masp varchar(10)
as
begin
	select a.SoLuong
	from CT_DonDatHang a
	where a.MaDDH=@maddh and a.MaSP=@masp
end

GO
/****** Object:  StoredProcedure [dbo].[PHIEUGIAOHANG_LAYDS]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PHIEUGIAOHANG_LAYDS]

AS
BEGIN
	SELECT A.MaPGH,A.MaDDH, B.HoTen, C.HoTen, A.NgayLap, A.TongTien 
	FROM PhieuGiaoHang A, NHANVIEN B, KHACHHANG C, DonDatHang D
	WHERE A.MaNV=B.MaNV AND A.MaKH=C.MaKH AND D.MaDDH=A.MaDDH
END

GO
/****** Object:  StoredProcedure [dbo].[PHIEUGIAOHANG_TIMKIEM]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PHIEUGIAOHANG_TIMKIEM]
(
	@MaPGH varchar(10),
	@NgayLap date,
	@MaNV varchar(10),
	@MaKH varchar (10),
	@TongTien int,
	
	@GhiChu nvarchar(100),
	@MADDH VARCHAR(10)
)
AS
 BEGIN

	if(@MaPGH is not null and @MaPGH <> '')
	begin
	SELECT * from PhieuGiaoHang where MaPGH like '%'+@MaPGH+ '%'
	end
	
	if(@MaNV is not null and @MaNV <> '')
	begin
	SELECT * from PhieuGiaoHang where MaNV like '%' + @MaNV + '%'
	end
	if(@MaKH is not null and @MaKH <> '')
	begin
	SELECT * from PhieuGiaoHang where @MaKH like '%' + @MaKH + '%'
	end
	if(@MADDH is not null and @MADDH <> '')
	begin
	SELECT * from PhieuGiaoHang where @MADDH like '%' + @MADDH + '%'
	end
	--if(@sdt is not null and @sdt <> '')
	--begin
	-- * from KHACHHANG where SODT like '%' + @sdt + '%'
	--end
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[PHIEUGIAOHANG_UPDATE]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PHIEUGIAOHANG_UPDATE]
  (
	@MaPGH varchar(10),
	@NgayLap date,
	@MaNV varchar(10),
	@MaKH varchar (10),
	@TongTien int,
	@GhiChu nvarchar(100),
	@MADDH VARCHAR(10)

	)
	AS
	BEGIN
		UPDATE PhieuGiaoHang SET NgayLap = @NgayLap, MaNV=@MaNV, MaKH=@MaKH, TongTien=@TongTien, GhiChu=@GhiChu, MaPGH=@MaPGH
		WHERE MaPGH =@MaPGH
	END



GO
/****** Object:  StoredProcedure [dbo].[phieugiaohang_updatetongtien]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[phieugiaohang_updatetongtien]
@mapgh NVARCHAR (10),
@tongtien INT
AS
BEGIN
UPDATE PhieuGiaoHang SET TongTien = @TONGTIEN WHERE MaPGH=@mapgh
END

GO
/****** Object:  StoredProcedure [dbo].[PHIEUTHU_Del]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[PHIEUTHU_Del]
	(
		@MaPT VARCHAR(10)
	)
AS
BEGIN
	DELETE FROM PhieuThu
	WHERE @MaPT LIKE PhieuThu.MaPT
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUTHU_getAll]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
create PROCEDURE [dbo].[PHIEUTHU_getAll]

AS
BEGIN
	SELECT * FROM PhieuThu
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUTHU_getPhieuThu]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PHIEUTHU_getPhieuThu]
	(
		@MaPT VARCHAR(10)
	)
AS
BEGIN
	SELECT * FROM PhieuThu
	WHERE @MaPT = MaPT
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUTHU_Insert]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PHIEUTHU_Insert]
	(
		@MaPT VARCHAR(10),
		@NgayLap VARCHAR(10),
		@MaNV VARCHAR(10),
		@MaKH VARCHAR(10),
		@SoTienNo int,
		@SoTienThu int
	)
AS
BEGIN
	INSERT INTO PhieuThu VALUES(@MaPT, @NgayLap, @MaNV,
								@MaKH, @SoTienNo, @SoTienThu)
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUTHU_Search]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[PHIEUTHU_Search]
	(
		@MaPT VARCHAR(10) = '',
		@NgayLap VARCHAR(10) = ''
	)
AS
BEGIN
	select * from PhieuThu
	WHERE (MaPT LIKE '%'+ @MaPT + '%' OR @MaPT IS NULL or @MaPT = '')
		AND (CONVERT(VARCHAR(10), PhieuThu.NgayLap, 120) = @NgayLap OR @NgayLap is null OR @NgayLap = '')
END


GO
/****** Object:  StoredProcedure [dbo].[PHIEUTHU_TongTienNo]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PHIEUTHU_TongTienNo]
(
	@maKH VARCHAR(10)
)
AS
BEGIN
	SELECT SUM(SoTienNo) - SUM(SoTienThu) FROM PhieuThu P WHERE P.MaKH = @maKH
	GROUP BY (P.MaKH)
END

GO
/****** Object:  StoredProcedure [dbo].[PHIEUTHU_TongTienNoTrongThang]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PHIEUTHU_TongTienNoTrongThang]
(
	@maKH VARCHAR(10),
	@month INT,
	@year INT
)
AS
BEGIN
	SELECT SUM(SoTienNo) - SUM(SoTienThu) FROM PhieuThu P WHERE P.MaKH = @maKH
																AND MONTH(P.NgayLap) = @month
																AND YEAR(P.NgayLap) = @year
	GROUP BY (P.MaKH)
END

GO
/****** Object:  StoredProcedure [dbo].[PHIEUTHU_Update]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[PHIEUTHU_Update]
	(
		@MaPT VARCHAR(10),
		@NgayLap datetime,
		@MaNV VARCHAR(10),
		@MaKH VARCHAR(10),
		@SoTienNo int,
		@SoTienThu int
	)
AS
BEGIN
	UPDATE PhieuThu
	SET NgayLap = @NgayLap,
		MaNV= @MaNV,
		MaKH = @MaKH,
		SoTienNo = @SoTienNo,
		SoTienThu = @SoTienThu
	WHERE @MaPT = MaPT
END


GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_Del]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[SANPHAM_Del]
	(
		@maSanPham VARCHAR(10)
	)
AS
BEGIN
	Update SanPham 
		set isActive = 0
		Where SanPham.MaSP = @maSanPham
END




GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_getAll]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
create PROCEDURE [dbo].[SANPHAM_getAll]

AS
BEGIN
	SELECT * FROM SanPham
END

GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_getSANPHAM]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SANPHAM_getSANPHAM]
	(
		@maSANPHAM VARCHAR(10)
	)
AS
BEGIN
	SELECT * FROM SanPham
	WHERE @maSANPHAM = MaSP
END




GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_Insert]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[SANPHAM_Insert]
	(
		@maSanPham VARCHAR(10),
		@tenSP NVARCHAR(50),
		@donVi NVARCHAR(20),
		@donGia INT,
		@ghiChu NVARCHAR(100),
		@maLoaiSP VARCHAR(20),
		@soLuong int,
		@isActive bit
	)
AS
BEGIN
	INSERT INTO SanPham VALUES(@maSanPham, @tenSP, @donVi,
								@donGia, @ghiChu, @maLoaiSP,@soLuong, @isActive)
END


GO
/****** Object:  StoredProcedure [dbo].[sanpham_ktsoluong]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sanpham_ktsoluong]
  (
	@masp varchar(10)


	)
	AS
	BEGIN
		select SoLuong
		from SanPham
		where SanPham.MaSP=@masp
	END

GO
/****** Object:  StoredProcedure [dbo].[sanpham_layds]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sanpham_layds]
 as
 select SanPham.MaSP, SanPham.TenSP, SanPham.DonVi, SanPham.DonGia, SanPham.soluong from SanPham

GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_Search]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[SANPHAM_Search]
	(
	

		@maSanPham VARCHAR(10)='',
		@tenSP NVARCHAR(50)='',
		@maLoaiSP VARCHAR(20)=''
	)
AS
BEGIN
	select * from SanPham
	WHERE (MaSP LIKE '%'+ @maSanPham + '%' OR @maSanPham IS NULL or @maSanPham = '')
		AND (TenSP LIKE '%' + @tenSP + '%' or @tenSP is null or @tenSP = '')
		AND (MaLoaiSP LIKE @maLoaiSP or @maLoaiSP is null or @maLoaiSP = '')
END




GO
/****** Object:  StoredProcedure [dbo].[sanpham_theoddh]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sanpham_theoddh]
(
@maddh nvarchar(10)
)
 AS
BEGIN
	select a.MaSP, a.TenSP, a.DonVi, a.DonGia, c.SoLuong
	from SanPham a,   CT_DonDatHang c
	where  a.MaSP=c.MaSP and c.MaDDH=@maddh
END

GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_Update]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SANPHAM_Update]
	(
		@maSanPham VARCHAR(10),
		@TenSP NVARCHAR(50),
		@donVi NVARCHAR(20),
		@donGia INT,
		@ghiChu NVARCHAR(100),
		@maLoaiSP VARCHAR(20),
		@soLuong int,
		@isActive bit
	)
AS
BEGIN
	UPDATE SanPham
	SET 
		TenSP= @TenSP,
		DonVi = @donVi,
		DonGia = @donGia,
		GhiChu = @ghiChu,
		MaLoaiSP= @maLoaiSP,
		SoLuong =@soLuong,
		isActive = @isActive
	WHERE @maSanPham = MaSP
END




GO
/****** Object:  StoredProcedure [dbo].[sanpham_update_soluong]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sanpham_update_soluong]
(
	@masp varchar(10),
	@soluong int
)
as
begin
	update SanPham
	set SoLuong=@soluong
	where MaSP =@masp
end

GO
/****** Object:  StoredProcedure [dbo].[THAMSO_getAll]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[THAMSO_getAll]

AS
BEGIN
	SELECT * FROM ThamSo
END


GO
/****** Object:  StoredProcedure [dbo].[THAMSO_Update]    Script Date: 1/5/2017 1:46:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[THAMSO_Update]
	(
		@tenThamSo NVARCHAR(20),
		@giaTri INT
	)
AS
BEGIN
	UPDATE ThamSo SET
	GiaTri = @giaTri
	WHERE TenThamSo = @tenThamSo
END


GO
USE [master]
GO
ALTER DATABASE [QuanLiCuaHangHoa] SET  READ_WRITE 
GO
