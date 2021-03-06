USE [master]
GO
/****** Object:  Database [QLCHH]    Script Date: 1/6/2017 2:44:26 AM ******/
CREATE DATABASE [QLCHH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLCHH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLCHH.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLCHH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLCHH_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLCHH] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCHH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCHH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCHH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCHH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCHH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCHH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCHH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLCHH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCHH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCHH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCHH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCHH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCHH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCHH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCHH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCHH] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLCHH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCHH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCHH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCHH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCHH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCHH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCHH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCHH] SET RECOVERY FULL 
GO
ALTER DATABASE [QLCHH] SET  MULTI_USER 
GO
ALTER DATABASE [QLCHH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCHH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLCHH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLCHH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLCHH] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLCHH', N'ON'
GO
USE [QLCHH]
GO
/****** Object:  Table [dbo].[BaoCaoCongNoKH]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[BaoCaoDoanhThu]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[BaoCaoTonKho]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[CT_DonDatHang]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[CT_DonNhapHang]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[CT_HoaDonBanHang]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[CT_HoaDonNhapHang]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[CT_PhieuGiaoHang]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[DonNhapHang]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[HoaDonNhapHang]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[PhieuChi]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[PhieuGiaoHang]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: 1/6/2017 2:44:27 AM ******/
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
/****** Object:  Table [dbo].[ThamSo]    Script Date: 1/6/2017 2:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamSo](
	[TenThamSo] [nvarchar](20) NULL,
	[GiaTri] [int] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DDH001', CAST(N'2016-12-20' AS Date), N'NV001', N'KH001', 600000, CAST(N'2016-12-20' AS Date), N'')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DDH002', CAST(N'2016-11-28' AS Date), N'NV002', N'KH002', 678008, CAST(N'2016-11-28' AS Date), NULL)
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DDH003', CAST(N'2016-05-12' AS Date), N'NV005', N'KH003', 800000, CAST(N'2016-05-12' AS Date), N'Kèm thư')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DDH004', CAST(N'2016-05-07' AS Date), N'NV009', N'KH004', 1500000, CAST(N'2016-05-07' AS Date), NULL)
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DDH005', CAST(N'2016-03-15' AS Date), N'NV010', N'KH005', 1150000, CAST(N'2016-03-15' AS Date), N'Còn nợ')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DDH006', CAST(N'2016-07-28' AS Date), N'NV008', N'KH006', 540000, CAST(N'2016-07-28' AS Date), NULL)
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DDH007', CAST(N'2016-08-20' AS Date), N'NV008', N'KH007', 630000, CAST(N'2016-08-20' AS Date), NULL)
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DDH008', CAST(N'2016-02-05' AS Date), N'NV001', N'KH006', 680000, CAST(N'2016-02-05' AS Date), N'Đặt hộ')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DDH009', CAST(N'2016-11-19' AS Date), N'NV007', N'KH003', 230000, CAST(N'2016-11-19' AS Date), NULL)
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLap], [MaNV], [MaKH], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DDH010', CAST(N'2016-01-20' AS Date), N'NV007', N'KH010', 430000, CAST(N'2016-01-20' AS Date), NULL)
INSERT [dbo].[DonNhapHang] ([MaDNH], [NgayLap], [MaNV], [MaNCC], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DNH001', CAST(N'2016-07-20' AS Date), N'NV001', N'NCC001', 5000000, CAST(N'2016-07-20' AS Date), NULL)
INSERT [dbo].[DonNhapHang] ([MaDNH], [NgayLap], [MaNV], [MaNCC], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DNH002', CAST(N'2016-03-25' AS Date), N'NV009', N'NCC001', 4500000, CAST(N'2016-03-25' AS Date), NULL)
INSERT [dbo].[DonNhapHang] ([MaDNH], [NgayLap], [MaNV], [MaNCC], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DNH003', CAST(N'2016-01-15' AS Date), N'NV008', N'NCC009', 2800000, CAST(N'2016-01-15' AS Date), NULL)
INSERT [dbo].[DonNhapHang] ([MaDNH], [NgayLap], [MaNV], [MaNCC], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DNH004', CAST(N'2016-04-21' AS Date), N'NV010', N'NCC010', 20000000, CAST(N'2016-04-21' AS Date), NULL)
INSERT [dbo].[DonNhapHang] ([MaDNH], [NgayLap], [MaNV], [MaNCC], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DNH005', CAST(N'2016-02-20' AS Date), N'NV005', N'NCC004', 4000000, CAST(N'2016-02-20' AS Date), NULL)
INSERT [dbo].[DonNhapHang] ([MaDNH], [NgayLap], [MaNV], [MaNCC], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DNH006', CAST(N'2016-12-15' AS Date), N'NV003', N'NCC005', 1450000, CAST(N'2016-12-15' AS Date), NULL)
INSERT [dbo].[DonNhapHang] ([MaDNH], [NgayLap], [MaNV], [MaNCC], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DNH007', CAST(N'2016-10-10' AS Date), N'NV005', N'NCC006', 3400000, CAST(N'2016-10-10' AS Date), NULL)
INSERT [dbo].[DonNhapHang] ([MaDNH], [NgayLap], [MaNV], [MaNCC], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DNH008', CAST(N'2016-03-30' AS Date), N'NV002', N'NCC002', 9800000, CAST(N'2016-03-30' AS Date), NULL)
INSERT [dbo].[DonNhapHang] ([MaDNH], [NgayLap], [MaNV], [MaNCC], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DNH009', CAST(N'2016-08-31' AS Date), N'NV002', N'NCC001', 2500000, CAST(N'2016-08-31' AS Date), NULL)
INSERT [dbo].[DonNhapHang] ([MaDNH], [NgayLap], [MaNV], [MaNCC], [TongTien], [NgayGiaoDuKien], [GhiChu]) VALUES (N'DNH010', CAST(N'2016-09-01' AS Date), N'NV001', N'NCC010', 7300000, NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD001', CAST(N'2016-07-01' AS Date), N'NV001', N'Kh001', 450000, NULL)
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD002', CAST(N'2016-03-15' AS Date), N'NV009', N'Kh004', 380000, NULL)
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD003', CAST(N'2016-08-20' AS Date), N'NV010', N'KH009', 90000, NULL)
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD004', CAST(N'2016-01-12' AS Date), N'NV006', N'KH010', 250000, NULL)
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD005', CAST(N'2016-09-05' AS Date), N'NV007', N'KH008', 470000, NULL)
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD006', CAST(N'2016-11-19' AS Date), N'NV005', N'KH002', 1250000, NULL)
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD007', CAST(N'2016-12-09' AS Date), N'NV005', N'KH007', 1900000, NULL)
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD008', CAST(N'2016-09-25' AS Date), N'NV003', N'KH003', 700000, NULL)
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD009', CAST(N'2016-03-20' AS Date), N'NV004', N'KH006', 680000, NULL)
INSERT [dbo].[HoaDonBanHang] ([MaHD], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu]) VALUES (N'HD010', CAST(N'2016-04-29' AS Date), N'NV002', N'KH005', 75000, NULL)
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD001', CAST(N'2016-06-20' AS Date), N'NV001', N'NCC001', 5000000, N'đủ')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD002', CAST(N'2016-04-12' AS Date), N'NV002', N'NCC010', 4500000, N'đủ')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD003', CAST(N'2016-03-19' AS Date), N'NV010', N'NCC009', 2500000, N'đủ')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD004', CAST(N'2016-01-30' AS Date), N'NV007', N'NCC009', 4000000, N'đủ')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD005', CAST(N'2016-11-25' AS Date), N'NV008', N'NCC001', 1800000, N'đủ')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD006', CAST(N'2016-03-20' AS Date), N'NV005', N'NCC004', 2700000, N'đủ')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD007', CAST(N'2016-12-01' AS Date), N'NV007', N'NCC003', 4300000, N'đủ ')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD008', CAST(N'2016-03-06' AS Date), N'NV005', N'NCC003', 3800000, N'đủ')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD009', CAST(N'2016-07-20' AS Date), N'NV005', N'NCC010', 20000000, N'còn nợ')
INSERT [dbo].[HoaDonNhapHang] ([MaHD], [NgayLap], [MaNV], [MaNCC], [TongTien], [GhiChu]) VALUES (N'HD010', CAST(N'2016-03-17' AS Date), N'NV008', N'NCC007', 980000, N'đủ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH001', N'Lê Thanh Thủy', N'Thủ Đức', N'0913561684', N'Nữ', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH002', N'Hà Văn Dũng', N'Quận 1', N'0927523253', N'Nam', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH003', N'Đặng Thành Duy', N'Quận 2', N'0908124421', N'Nam', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH004', N'Trần Anh Tú', N'Bình Dương', N'0909124214', N'Thường đến xem', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH005', N'Bùi Quang Hà', N'Dầu Tiếng', N'01612421444', N'Mua định kì', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH006', N'Nguyễn Thành Nam', N'Quận 5', N'0919123785', N'Vãng lai', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH007', N'Nguyễn Xuân Toản', N'Quận 10', N'0907124124', N'Khó tính', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH008', N'Nguyễn Đăng Kế Thiện', N'Đà Nẵng', N'0967121241', N'Phải giao hàng', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH009', N'Nguyễn Mỹ Dung', N'Hà Nội', N'0919122144', N'Giao hàng nhiều lần', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DiaChi], [SoDT], [GhiChu], [IsActive]) VALUES (N'KH010', N'Nguyễn Hà Phương', N'Quận 9', N'0912121567', N'Thường xuyên ghé ', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC001', N'Công ty TNHH Hoa Anh Đào', N'HCM', N'0919575672', N'Gần cửa hàng', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC002', N'Dalat Farm', N'Đà Lạt', N'0843567812', N'Hoa tươi, đẹp', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC003', N'Lavendor', N'Pháp', N'0510237214', N'Chất lượng tốt', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC004', N'Hoa Tươi Đà Lạt', N'Đà lạt', N'0735635341', N'Giá rẻ', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC005', N'Phong Linh'' Farm', N'Cần Thơ', N'0384643354', N'Đa dạng', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC006', N'Hoa Tươi Bình Dương', N'Bình Dương', N'0543265541', N'Giao hàng nhanh', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC007', N'Như Ý Farm', N'Đà Nẵng', N'0593249238', N'Dịch vụ tốt', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC008', N'Cửa hàng Hoa Nghệ Thuật', N'Vũng tàu', N'0253463124', N'Đa dạng', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC009', N'Công ty TNHH Một thành viên', N'Hà Nội', N'0114024023', N'Dịch vụ chuyên nghiệp', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [Ten], [DiaChi], [SoDT], [GhiChu], [isACtive]) VALUES (N'NCC010', N'Love Flowers Shop', N'USA', N'0249502854', N'Chất lượng tốt', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV001', N'Hà Văn Dũng', 1994, 0, N'01683245384', N'dunghavan47@gmail.com', N'nhaphang', N'123456', N'NH', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV002', N'Phan Nhật Đăng', 1995, 0, N'0983453232', N'pnd@gmail.com', N'quanlykho', N'123456', N'QLK', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV003', N'Thanh Thủy Lê', 1995, 1, N'0934523564', N'thanhthuy@gmail.com', N'ketoan', N'123456', N'KT', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV004', N'Huỳnh Vân Thảo', 1993, 1, N'0909121244', N'vanthao@gmail.com', N'banhang', N'123456', N'BH', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV005', N'Lê Kim Ngân', 1995, 1, N'0937124157', N'ngan95@gmail.com', N'admin', N'123456', N'AD', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV006', N'Thái Hoàng Huy', 1995, 0, N'0937986446', N'hoanghuy@gmail.com', N'full', N'123456', N'FULL', 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV007', N'Đặng Thành Duy', 1995, 0, N'0919776999', N'thanhduy.uit@gmail.com', N'thanhduyuit', N'123456', N'FULL', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV008', N'Nguyễn Văn Hậu', 1996, 0, N'01685495845', N'haunv95@gmail.com', N'haunv', N'123456', N'NH', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV009', N'Hà Anh Tuấn', 1997, 0, N'0974677543', N'Tuanha@gmail.com', N'tuanha', N'123456', N'QLK', 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NamSinh], [GioiTinh], [SoDT], [Email], [Username], [Password], [MaLoaiNV], [IsActive]) VALUES (N'NV010', N'Nguyễn Quốc Lâm', 1990, 0, N'0976856443', N'quoclam@gmail.com', N'lamnq', N'123456', N'BH', 1)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC001', CAST(N'2016-03-20' AS Date), N'NV001', N'NCC002', 5000000, 5000000)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC002', CAST(N'2016-07-22' AS Date), N'NV002', N'NCC005', 4500000, 4500000)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC003', CAST(N'2016-01-04' AS Date), N'NV009', N'NCC006', 7000000, 7000000)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC004', CAST(N'2016-09-30' AS Date), N'NV010', N'NCC001', 1500000, 1500000)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC005', CAST(N'2016-04-15' AS Date), N'NV007', N'NCC008', 800000, 800000)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC006', CAST(N'2016-01-20' AS Date), N'NV005', N'NCC007', 950000, 950000)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC007', CAST(N'2016-11-29' AS Date), N'NV005', N'NCC006', 3000000, 3000000)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC008', CAST(N'2016-08-15' AS Date), N'NV006', N'NCC007', 20000000, 10000000)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC009', CAST(N'2016-12-25' AS Date), N'NV008', N'NCC005', 2500000, 2500000)
INSERT [dbo].[PhieuChi] ([MaPC], [NgayLap], [MaNV], [MaNCC], [SoTienNo], [SoTienChi]) VALUES (N'PC010', CAST(N'2016-01-01' AS Date), N'NV002', N'NCC010', 5500000, 5500000)
INSERT [dbo].[PhieuGiaoHang] ([MaPGH], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu], [MaDDH]) VALUES (N'PGH001', CAST(N'2017-01-05' AS Date), N'NV001', N'KH001', 500000, N'gọi cho khách trước khi giao', N'DDH006')
INSERT [dbo].[PhieuGiaoHang] ([MaPGH], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu], [MaDDH]) VALUES (N'PGH002', CAST(N'2016-12-05' AS Date), N'NV002', N'KH010', 800000, N'Chiều 5h', N'DDH007')
INSERT [dbo].[PhieuGiaoHang] ([MaPGH], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu], [MaDDH]) VALUES (N'PGH003', CAST(N'2016-10-25' AS Date), N'NV010', N'Kh009', 150000, N'Giờ nghỉ trưa', N'DDH010')
INSERT [dbo].[PhieuGiaoHang] ([MaPGH], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu], [MaDDH]) VALUES (N'PGH004', CAST(N'2016-08-12' AS Date), N'NV006', N'KH004', 270000, N'Kèm thiệp chúc mừng', N'DDH002')
INSERT [dbo].[PhieuGiaoHang] ([MaPGH], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu], [MaDDH]) VALUES (N'PGH005', CAST(N'2016-12-08' AS Date), N'NV006', N'KH003', 1125000, N'Dấu tên người gửi', N'DDH008')
INSERT [dbo].[PhieuGiaoHang] ([MaPGH], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu], [MaDDH]) VALUES (N'PGH006', CAST(N'2016-02-29' AS Date), N'NV005', N'KH007', 1450000, N'Lầu 5', N'DDH009')
INSERT [dbo].[PhieuGiaoHang] ([MaPGH], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu], [MaDDH]) VALUES (N'PGH007', CAST(N'2016-07-31' AS Date), N'NV002', N'KH001', 700000, N'Gọi vào số 0921421434', N'DDH001')
INSERT [dbo].[PhieuGiaoHang] ([MaPGH], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu], [MaDDH]) VALUES (N'PGH008', CAST(N'2016-05-21' AS Date), N'NV007', N'KH006', 980000, N'Cuối hẻm', N'DDH003')
INSERT [dbo].[PhieuGiaoHang] ([MaPGH], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu], [MaDDH]) VALUES (N'PGH009', CAST(N'2016-01-05' AS Date), N'NV009', N'KH008', 100000, N'Giao lúc sáng sớm trước giờ hành chính', N'DDH004')
INSERT [dbo].[PhieuGiaoHang] ([MaPGH], [NgayLap], [MaNV], [MaKH], [TongTien], [GhiChu], [MaDDH]) VALUES (N'PGH010', CAST(N'2016-09-05' AS Date), N'NV009', N'KH005', 430000, N'Nhận được cuộc gọi hãy giao', NULL)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT001', CAST(N'2016-11-20' AS Date), N'NV001', N'KH002', 400000, 200000)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT002', CAST(N'2016-12-31' AS Date), N'NV001', N'KH002', 0, 0)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT003', CAST(N'2016-12-01' AS Date), N'NV002', N'KH001', 0, 0)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT004', CAST(N'2016-01-13' AS Date), N'NV006', N'KH002', 0, 0)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT005', CAST(N'2016-07-01' AS Date), N'NV009', N'KH002', 0, 0)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT006', CAST(N'2016-08-15' AS Date), N'NV007', N'KH002', 0, 0)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT007', CAST(N'2016-07-12' AS Date), N'NV007', N'KH010', 500000, 300000)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT008', CAST(N'2016-02-03' AS Date), N'NV004', N'KH009', 650000, 500000)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT009', CAST(N'2016-03-03' AS Date), N'NV003', N'KH005', 0, 0)
INSERT [dbo].[PhieuThu] ([MaPT], [NgayLap], [MaNV], [MaKH], [SoTienNo], [SoTienThu]) VALUES (N'PT010', CAST(N'2016-09-02' AS Date), N'NV008', N'KH008', 0, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP001', N'Hoa Hồng Đỏ', N'Bông', 12000, N'Trang trí', N'HHD', 150, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP002', N'Hoa Mai', N'Cành', 200000, N'Trang trí', N'HM', 50, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP003', N'Hoa Cúc', N'Bông', 90000, N'Cúng kiến', N'HC', 75, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP004', N'Hoa Sen', N'Chậu', 100000, N'Trồng ngoài ao', N'HS', 90, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP005', N'Hoa Hồng Trắng', N'Bó', 200000, N'Viếng thăm', N'HHT', 200, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP006', N'Hoa Lan', N'Chậu', 500000, N'Trang trí, trồng', N'HL', 300, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP007', N'Hoa Bằng Lăng', N'Bông', 15000, N'Trang trí', N'HBL', 50, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP008', N'Hoa Đào', N'Cành', 150000, N'Chưng tết', N'HD', 40, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP009', N'Hoa Cát Tường', N'Bông', 63000, N'Kết thằng lẵng hoa', N'HCT', 35, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP010', N'Hoa Anh Thảo', N'Cành', 34000, N'Trang trí', N'HAT', 70, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP011', N'Hoa Bò Cạp Vàng', N'Cành', 230000, N'Trang trí', N'HBCV', 65, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP012', N'Hoa Dâm Bụt', N'Cành', 27000, N'Trồng', N'HDB', 80, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP013', N'Hoa Cẩm Chướng', N'Bông', 54000, N'Kết lẵng', N'HCC', 50, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP014', N'Hoa Cẩm Tú Cầu', N'Bông', 84000, N'Trồng ,trang trí', N'HCTC', 45, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP015', N'Hoa Dạ Lan', N'Bông', 34000, N'Chưng', N'HDL', 40, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP016', N'Hoa Dạ Lý Hương', N'Bông', 23000, N'Trang trí', N'HDLH', 60, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP017', N'Hoa Dành Dành', N'Chậu', 210000, N'Viếng thăm', N'HDD', 65, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP018', N'Hoa Diên Vĩ', N'Cành', 78000, N'Chúc mừng', N'HDV', 75, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP019', N'Hoa Đổ Quyên', N'Cành', 110000, N'Trồng', N'HDQ', 70, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP020', N'Hoa Hải Đường', N'Cành', 178000, N'Trang trí', N'HHD1', 30, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP021', N'Hoa Huệ', N'Bông', 47000, N'Trang trí', N'HH', 170, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [DonGia], [GhiChu], [MaLoaiSP], [SoLuong], [isActive]) VALUES (N'SP022', N'Hoa Tulip', N'Bông', 62000, N'Trang trí', N'HT', 110, 1)
USE [master]
GO
ALTER DATABASE [QLCHH] SET  READ_WRITE 
GO
