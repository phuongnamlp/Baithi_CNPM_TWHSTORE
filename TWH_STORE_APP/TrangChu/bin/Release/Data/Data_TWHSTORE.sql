USE [master]
GO
/****** Object:  Database [TWH_STORE]    Script Date: 10/29/2021 2:40:11 PM ******/
CREATE DATABASE [TWH_STORE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TWH_STORE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.PHUONGNAMSQL\MSSQL\DATA\TWH_STORE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TWH_STORE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.PHUONGNAMSQL\MSSQL\DATA\TWH_STORE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TWH_STORE] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TWH_STORE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TWH_STORE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TWH_STORE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TWH_STORE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TWH_STORE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TWH_STORE] SET ARITHABORT OFF 
GO
ALTER DATABASE [TWH_STORE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TWH_STORE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TWH_STORE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TWH_STORE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TWH_STORE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TWH_STORE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TWH_STORE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TWH_STORE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TWH_STORE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TWH_STORE] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TWH_STORE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TWH_STORE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TWH_STORE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TWH_STORE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TWH_STORE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TWH_STORE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TWH_STORE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TWH_STORE] SET RECOVERY FULL 
GO
ALTER DATABASE [TWH_STORE] SET  MULTI_USER 
GO
ALTER DATABASE [TWH_STORE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TWH_STORE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TWH_STORE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TWH_STORE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TWH_STORE] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TWH_STORE] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TWH_STORE', N'ON'
GO
ALTER DATABASE [TWH_STORE] SET QUERY_STORE = OFF
GO
USE [TWH_STORE]
GO
/****** Object:  Table [dbo].[BANGLUONG]    Script Date: 10/29/2021 2:40:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGLUONG](
	[MABANGLUONG] [varchar](10) NOT NULL,
	[MANV] [varchar](10) NOT NULL,
	[TENNV] [nvarchar](50) NULL,
	[TongNgayLam] [int] NULL,
	[TongNgayVang] [int] NULL,
	[TIENLUONG] [money] NULL,
	[LUONGTHUONG] [money] NULL,
	[TONGLUONG] [money] NULL,
 CONSTRAINT [PK_BANGLUONG] PRIMARY KEY CLUSTERED 
(
	[MABANGLUONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHSACH_NVL]    Script Date: 10/29/2021 2:40:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHSACH_NVL](
	[MANVL] [varchar](10) NOT NULL,
	[TENNVL] [nvarchar](50) NULL,
	[LOAI] [nvarchar](10) NULL,
	[NGAYSX] [datetime] NULL,
	[NGAYHH] [datetime] NULL,
 CONSTRAINT [PK_DANHSACH_NVL] PRIMARY KEY CLUSTERED 
(
	[MANVL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHSACHCANNHAP_NVL]    Script Date: 10/29/2021 2:40:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHSACHCANNHAP_NVL](
	[IDLOAI] [int] NOT NULL,
	[MANVL] [varchar](10) NOT NULL,
	[LOAIHANG] [nvarchar](50) NOT NULL,
	[SOLUONG] [int] NULL,
	[MANCC] [varchar](10) NOT NULL,
 CONSTRAINT [PK_DANHSACHCANNHAP_NVL] PRIMARY KEY CLUSTERED 
(
	[IDLOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10/29/2021 2:40:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SOBAN] [char](5) NOT NULL,
	[TENMON] [nvarchar](100) NOT NULL,
	[GIATIEN] [int] NOT NULL,
	[TRANGTHAI] [nvarchar](20) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIDICHVU]    Script Date: 10/29/2021 2:40:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIDICHVU](
	[MAPHIEUDV] [varchar](10) NOT NULL,
	[NOIDUNG] [nvarchar](100) NOT NULL,
	[CHIPHI] [int] NOT NULL,
 CONSTRAINT [PK_PHIDICHVU] PRIMARY KEY CLUSTERED 
(
	[MAPHIEUDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIPHATSINH]    Script Date: 10/29/2021 2:40:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIPHATSINH](
	[MAPHIEU] [varchar](10) NOT NULL,
	[NOIDUNG] [nvarchar](100) NULL,
	[CHIPHI] [int] NULL,
 CONSTRAINT [PK_PHIPHATSINH] PRIMARY KEY CLUSTERED 
(
	[MAPHIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUYEN]    Script Date: 10/29/2021 2:40:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYEN](
	[IDQUYEN] [int] NOT NULL,
	[TENQUYEN] [varchar](10) NOT NULL,
 CONSTRAINT [PK_QUYEN] PRIMARY KEY CLUSTERED 
(
	[IDQUYEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 10/29/2021 2:40:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MAMON] [char](10) NOT NULL,
	[NAME] [nvarchar](100) NOT NULL,
	[GIA] [int] NOT NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MAMON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTIN_NHACUNGCAP]    Script Date: 10/29/2021 2:40:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTIN_NHACUNGCAP](
	[MANCC] [varchar](10) NOT NULL,
	[TENNCC] [nvarchar](50) NULL,
	[SDT] [varchar](13) NULL,
	[EMAIL] [varchar](30) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[LOAIHANG] [nvarchar](50) NULL,
 CONSTRAINT [PK_THONGTIN_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTIN_NHANVIEN]    Script Date: 10/29/2021 2:40:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTIN_NHANVIEN](
	[MANV] [varchar](10) NOT NULL,
	[TENNV] [nvarchar](50) NULL,
	[GIOITINH] [nvarchar](10) NULL,
	[NGAYSINH] [datetime] NULL,
	[SDT] [varchar](13) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[CHUCVU] [nvarchar](20) NULL,
 CONSTRAINT [PK_THONGTIN_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 10/29/2021 2:40:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[TAIKHOAN] [varchar](10) NOT NULL,
	[MATKHAU] [varchar](10) NOT NULL,
	[MANV] [varchar](10) NOT NULL,
	[IDQUYEN] [int] NOT NULL,
 CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED 
(
	[TAIKHOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BANGLUONG] ([MABANGLUONG], [MANV], [TENNV], [TongNgayLam], [TongNgayVang], [TIENLUONG], [LUONGTHUONG], [TONGLUONG]) VALUES (N'BL1', N'NV1', N'Trần Văn Quyền', 24, 7, 4800000.0000, 1000000.0000, 5800000.0000)
INSERT [dbo].[BANGLUONG] ([MABANGLUONG], [MANV], [TENNV], [TongNgayLam], [TongNgayVang], [TIENLUONG], [LUONGTHUONG], [TONGLUONG]) VALUES (N'BL2', N'NV2', N'Bùi Trần Gia Khang', 21, 10, 4200000.0000, 750000.0000, 4950000.0000)
INSERT [dbo].[BANGLUONG] ([MABANGLUONG], [MANV], [TENNV], [TongNgayLam], [TongNgayVang], [TIENLUONG], [LUONGTHUONG], [TONGLUONG]) VALUES (N'BL3', N'NV3', N'Nguyễn Anh Đức', 19, 12, 3800000.0000, 800000.0000, 4600000.0000)
INSERT [dbo].[BANGLUONG] ([MABANGLUONG], [MANV], [TENNV], [TongNgayLam], [TongNgayVang], [TIENLUONG], [LUONGTHUONG], [TONGLUONG]) VALUES (N'BL4', N'NV4', N'Lê Phạm Phương Nam', 17, 14, 3400000.0000, 1500000.0000, 4900000.0000)
GO
INSERT [dbo].[DANHSACH_NVL] ([MANVL], [TENNVL], [LOAI], [NGAYSX], [NGAYHH]) VALUES (N'NVL1', N'Bột Pha Chế', N'Bột', CAST(N'2020-10-20T00:00:00.000' AS DateTime), CAST(N'2021-10-20T00:00:00.000' AS DateTime))
INSERT [dbo].[DANHSACH_NVL] ([MANVL], [TENNVL], [LOAI], [NGAYSX], [NGAYHH]) VALUES (N'NVL2', N'Sữa Pha Chế', N'Sữa', CAST(N'2020-10-20T00:00:00.000' AS DateTime), CAST(N'2021-10-20T00:00:00.000' AS DateTime))
INSERT [dbo].[DANHSACH_NVL] ([MANVL], [TENNVL], [LOAI], [NGAYSX], [NGAYHH]) VALUES (N'NVL3', N'Hương Liệu', N'Hương', CAST(N'2020-10-20T00:00:00.000' AS DateTime), CAST(N'2021-10-20T00:00:00.000' AS DateTime))
INSERT [dbo].[DANHSACH_NVL] ([MANVL], [TENNVL], [LOAI], [NGAYSX], [NGAYHH]) VALUES (N'NVL4', N'Cafe', N'Hạt', CAST(N'2021-09-13T22:04:00.000' AS DateTime), CAST(N'2021-10-27T22:04:00.000' AS DateTime))
GO
INSERT [dbo].[DANHSACHCANNHAP_NVL] ([IDLOAI], [MANVL], [LOAIHANG], [SOLUONG], [MANCC]) VALUES (1, N'NVL1', N'Bột', 10, N'1')
INSERT [dbo].[DANHSACHCANNHAP_NVL] ([IDLOAI], [MANVL], [LOAIHANG], [SOLUONG], [MANCC]) VALUES (2, N'NVL2', N'Sữa', 20, N'2')
INSERT [dbo].[DANHSACHCANNHAP_NVL] ([IDLOAI], [MANVL], [LOAIHANG], [SOLUONG], [MANCC]) VALUES (3, N'NVL3', N'Hương', 300, N'3')
INSERT [dbo].[DANHSACHCANNHAP_NVL] ([IDLOAI], [MANVL], [LOAIHANG], [SOLUONG], [MANCC]) VALUES (4, N'NVL4', N'Hạt', 3000, N'2')
GO
INSERT [dbo].[PHIDICHVU] ([MAPHIEUDV], [NOIDUNG], [CHIPHI]) VALUES (N'DV1', N'Vận Chuyển', 150000)
INSERT [dbo].[PHIDICHVU] ([MAPHIEUDV], [NOIDUNG], [CHIPHI]) VALUES (N'DV2', N'Giao Hàng', 200000)
INSERT [dbo].[PHIDICHVU] ([MAPHIEUDV], [NOIDUNG], [CHIPHI]) VALUES (N'DV3', N'Sửa Chữa', 250000)
INSERT [dbo].[PHIDICHVU] ([MAPHIEUDV], [NOIDUNG], [CHIPHI]) VALUES (N'DV4', N'Xịt Côn Trùng', 300000)
GO
INSERT [dbo].[PHIPHATSINH] ([MAPHIEU], [NOIDUNG], [CHIPHI]) VALUES (N'J6', N'Bong bóng', 150000)
INSERT [dbo].[PHIPHATSINH] ([MAPHIEU], [NOIDUNG], [CHIPHI]) VALUES (N'K1', N'Đền bù', 1000000)
INSERT [dbo].[PHIPHATSINH] ([MAPHIEU], [NOIDUNG], [CHIPHI]) VALUES (N'K2', N'Mua nguyên vật liệu', 2000000)
INSERT [dbo].[PHIPHATSINH] ([MAPHIEU], [NOIDUNG], [CHIPHI]) VALUES (N'K3', N'Nội thất', 5000000)
INSERT [dbo].[PHIPHATSINH] ([MAPHIEU], [NOIDUNG], [CHIPHI]) VALUES (N'K4', N'Viện phí', 2000000)
INSERT [dbo].[PHIPHATSINH] ([MAPHIEU], [NOIDUNG], [CHIPHI]) VALUES (N'K5', N'Tổ chức Event', 2000000)
GO
INSERT [dbo].[QUYEN] ([IDQUYEN], [TENQUYEN]) VALUES (0, N'USER')
INSERT [dbo].[QUYEN] ([IDQUYEN], [TENQUYEN]) VALUES (1, N'ADMIN')
GO
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M1        ', N'Sting', 15000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M10       ', N'Sinh tố Việt Quốc', 30000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M11       ', N'Cafe đá', 12000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M12       ', N'Cafe sữa', 15000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M13       ', N'Cafe Bạc Xỉu', 20000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M14       ', N'Trà Đào', 25000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M15       ', N'Trà Đào Cam Xã', 25000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M16       ', N'Trà Vải', 25000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M2        ', N'Pepsi', 15000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M3        ', N'Redbull', 20000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M4        ', N'Number1', 15000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M5        ', N'Cocacola', 15000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M6        ', N'Mirinda', 15000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M7        ', N'Sinh tố Dâu', 30000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M8        ', N'Sinh tố Bơ', 30000)
INSERT [dbo].[SANPHAM] ([MAMON], [NAME], [GIA]) VALUES (N'M9        ', N'Sinh tố Mãng Cầu', 30000)
GO
INSERT [dbo].[THONGTIN_NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [EMAIL], [DIACHI], [LOAIHANG]) VALUES (N'1', N'P-Taste', N'789838858', N'ptaste@gmail.com', N'Phố 1', N'Bột')
INSERT [dbo].[THONGTIN_NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [EMAIL], [DIACHI], [LOAIHANG]) VALUES (N'2', N'Công ty TNHH Đầu Tư Sản Xuất Tam Long', N'2.838.120.333', N'tamlong@gmail.com', N'Phố 2', N'Sữa')
INSERT [dbo].[THONGTIN_NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [EMAIL], [DIACHI], [LOAIHANG]) VALUES (N'3', N'Nguyên Liệu Nguyên An', N'2873036878', N'nguyenlieuphachesi@gmail.com', N'Phố 3', N'Hương')
GO
INSERT [dbo].[THONGTIN_NHANVIEN] ([MANV], [TENNV], [GIOITINH], [NGAYSINH], [SDT], [DIACHI], [CHUCVU]) VALUES (N'NV1', N'Trần Văn Quyền', N'Nam', CAST(N'2021-10-27T15:25:04.093' AS DateTime), N'011111111', N'Đồng Nai', N'Quản Lý')
INSERT [dbo].[THONGTIN_NHANVIEN] ([MANV], [TENNV], [GIOITINH], [NGAYSINH], [SDT], [DIACHI], [CHUCVU]) VALUES (N'NV2', N'Bùi Trần Gia Khang', N'Nam', CAST(N'2021-10-27T15:28:09.130' AS DateTime), N'022222222', N'Tây Ninh', N'Thu Ngân ')
INSERT [dbo].[THONGTIN_NHANVIEN] ([MANV], [TENNV], [GIOITINH], [NGAYSINH], [SDT], [DIACHI], [CHUCVU]) VALUES (N'NV3', N'Nguyễn Anh Đức', N'Nam', CAST(N'2021-10-27T15:28:09.130' AS DateTime), N'033333333', N'Khánh Hòa', N'Quản Lý Kho')
INSERT [dbo].[THONGTIN_NHANVIEN] ([MANV], [TENNV], [GIOITINH], [NGAYSINH], [SDT], [DIACHI], [CHUCVU]) VALUES (N'NV4', N'Lê Phạm Phương Nam', N'Nam', CAST(N'2021-10-27T15:28:09.130' AS DateTime), N'044444444', N'Hồ Chí Minh', N'Phục Vụ')
INSERT [dbo].[THONGTIN_NHANVIEN] ([MANV], [TENNV], [GIOITINH], [NGAYSINH], [SDT], [DIACHI], [CHUCVU]) VALUES (N'NV5', N'Nguyễn Thị A', N'Nữ', CAST(N'2000-07-18T15:47:09.000' AS DateTime), N'0908436335', N'Nhơn Trạch', N'Phục Vụ')
GO
INSERT [dbo].[USERS] ([TAIKHOAN], [MATKHAU], [MANV], [IDQUYEN]) VALUES (N'bophankho', N'123', N'NV3', 0)
INSERT [dbo].[USERS] ([TAIKHOAN], [MATKHAU], [MANV], [IDQUYEN]) VALUES (N'phucvu', N'123', N'NV4', 0)
INSERT [dbo].[USERS] ([TAIKHOAN], [MATKHAU], [MANV], [IDQUYEN]) VALUES (N'phucvu1', N'123', N'NV5', 0)
INSERT [dbo].[USERS] ([TAIKHOAN], [MATKHAU], [MANV], [IDQUYEN]) VALUES (N'quanly', N'quanly', N'NV1', 1)
INSERT [dbo].[USERS] ([TAIKHOAN], [MATKHAU], [MANV], [IDQUYEN]) VALUES (N'thungan', N'123', N'NV2', 0)
GO
ALTER TABLE [dbo].[BANGLUONG]  WITH CHECK ADD  CONSTRAINT [FK_BANGLUONG_THONGTIN_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[THONGTIN_NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[BANGLUONG] CHECK CONSTRAINT [FK_BANGLUONG_THONGTIN_NHANVIEN]
GO
ALTER TABLE [dbo].[DANHSACHCANNHAP_NVL]  WITH CHECK ADD  CONSTRAINT [FK_DANHSACHCANNHAP_NVL_DANHSACH_NVL] FOREIGN KEY([MANVL])
REFERENCES [dbo].[DANHSACH_NVL] ([MANVL])
GO
ALTER TABLE [dbo].[DANHSACHCANNHAP_NVL] CHECK CONSTRAINT [FK_DANHSACHCANNHAP_NVL_DANHSACH_NVL]
GO
ALTER TABLE [dbo].[DANHSACHCANNHAP_NVL]  WITH CHECK ADD  CONSTRAINT [FK_DANHSACHCANNHAP_NVL_THONGTIN_NHACUNGCAP] FOREIGN KEY([MANCC])
REFERENCES [dbo].[THONGTIN_NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[DANHSACHCANNHAP_NVL] CHECK CONSTRAINT [FK_DANHSACHCANNHAP_NVL_THONGTIN_NHACUNGCAP]
GO
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD  CONSTRAINT [FK_USERS_QUYEN] FOREIGN KEY([IDQUYEN])
REFERENCES [dbo].[QUYEN] ([IDQUYEN])
GO
ALTER TABLE [dbo].[USERS] CHECK CONSTRAINT [FK_USERS_QUYEN]
GO
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD  CONSTRAINT [FK_USERS_THONGTIN_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[THONGTIN_NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[USERS] CHECK CONSTRAINT [FK_USERS_THONGTIN_NHANVIEN]
GO
USE [master]
GO
ALTER DATABASE [TWH_STORE] SET  READ_WRITE 
GO
