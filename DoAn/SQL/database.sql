USE [master]
GO
/****** Object:  Database [QLXEMAY]    Script Date: 04/01/2022 9:01:06 PM ******/
CREATE DATABASE [QLXEMAY]
GO
ALTER DATABASE [QLXEMAY] SET COMPATIBILITY_LEVEL = 150
GO

ALTER DATABASE [QLXEMAY] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLXEMAY] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLXEMAY] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLXEMAY] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLXEMAY] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLXEMAY] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLXEMAY] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLXEMAY] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLXEMAY] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLXEMAY] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLXEMAY] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLXEMAY] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLXEMAY] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLXEMAY] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLXEMAY] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLXEMAY] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLXEMAY] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLXEMAY] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLXEMAY] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLXEMAY] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLXEMAY] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLXEMAY] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLXEMAY] SET RECOVERY FULL 
GO
ALTER DATABASE [QLXEMAY] SET  MULTI_USER 
GO
ALTER DATABASE [QLXEMAY] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLXEMAY] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLXEMAY] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLXEMAY] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLXEMAY] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLXEMAY] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLXEMAY', N'ON'
GO
ALTER DATABASE [QLXEMAY] SET QUERY_STORE = OFF
GO
USE [QLXEMAY]
GO
/****** Object:  Table [dbo].[tb_CHITIETHOADON]    Script Date: 04/01/2022 9:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CHITIETHOADON](
	[MAHD] [char](5) NOT NULL,
	[MAXE] [char](5) NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [numeric](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_HOADON]    Script Date: 04/01/2022 9:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HOADON](
	[MAHD] [char](5) NOT NULL,
	[NGAYLAP] [datetime] NULL,
	[MAKH] [char](5) NOT NULL,
	[MANV] [char](4) NOT NULL,
 CONSTRAINT [PK_tb_HOADON] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_KHACHHANG]    Script Date: 04/01/2022 9:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_KHACHHANG](
	[MAKH] [char](5) NOT NULL,
	[TENKH] [nvarchar](30) NULL,
	[SDT] [nvarchar](11) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[DISABLE] [bit] NULL,
 CONSTRAINT [PK_tb_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_LOAIXE]    Script Date: 04/01/2022 9:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_LOAIXE](
	[MALOAI] [char](5) NOT NULL,
	[TENLOAIXE] [nvarchar](15) NULL,
	[DISABLE] [bit] NULL,
 CONSTRAINT [PK_tb_LOAIXE] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_NHACUNGCAP]    Script Date: 04/01/2022 9:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NHACUNGCAP](
	[MANCC] [char](5) NOT NULL,
	[TENNCC] [nvarchar](30) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[SDT] [nvarchar](11) NULL,
	[DISABLE] [bit] NULL,
 CONSTRAINT [PK_tb_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_NHANVIEN]    Script Date: 04/01/2022 9:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NHANVIEN](
	[MANV] [char](4) NOT NULL,
	[TENNV] [nvarchar](30) NULL,
	[GIOITINH] [nvarchar](3) NULL,
	[NGAYSINH] [datetime] NULL,
	[DIACHI] [nvarchar](50) NULL,
	[CMND] [nvarchar](15) NULL,
	[SDT] [nvarchar](11) NULL,
	[CHUCVU] [nvarchar](20) NULL,
	[USERNAME] [nvarchar](10) NULL,
	[PASSWORD] [nvarchar](10) NULL,
	[DISABLE] [bit] NULL,
 CONSTRAINT [PK_tb_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_XEMAY]    Script Date: 04/01/2022 9:01:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_XEMAY](
	[MAXE] [char](5) NOT NULL,
	[TENXE] [nvarchar](20) NULL,
	[GIABAN] [money] NULL,
	[MAUSAC] [nvarchar](20) NULL,
	[DUNGTICH] [nvarchar](5) NULL,
	[TINHTRANG] [nvarchar](3) NULL,
	[MALOAI] [char](5) NOT NULL,
	[MANCC] [char](5) NOT NULL,
	[DISABLE] [bit] NULL,
 CONSTRAINT [PK_tb_XEMAY] PRIMARY KEY CLUSTERED 
(
	[MAXE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tb_CHITIETHOADON] ([MAHD], [MAXE], [SOLUONG], [DONGIA]) VALUES (N'HD001', N'XE015', 1, CAST(49900000 AS Numeric(18, 0)))
INSERT [dbo].[tb_CHITIETHOADON] ([MAHD], [MAXE], [SOLUONG], [DONGIA]) VALUES (N'HD002', N'XE012', 1, CAST(82000000 AS Numeric(18, 0)))
INSERT [dbo].[tb_CHITIETHOADON] ([MAHD], [MAXE], [SOLUONG], [DONGIA]) VALUES (N'HD003', N'XE005', 1, CAST(46090000 AS Numeric(18, 0)))
GO
INSERT [dbo].[tb_HOADON] ([MAHD], [NGAYLAP], [MAKH], [MANV]) VALUES (N'HD001', CAST(N'2021-12-26T00:00:00.000' AS DateTime), N'KH003', N'NV04')
INSERT [dbo].[tb_HOADON] ([MAHD], [NGAYLAP], [MAKH], [MANV]) VALUES (N'HD002', CAST(N'2021-12-27T00:00:00.000' AS DateTime), N'KH002', N'NV04')
INSERT [dbo].[tb_HOADON] ([MAHD], [NGAYLAP], [MAKH], [MANV]) VALUES (N'HD003', CAST(N'2021-12-28T00:00:00.000' AS DateTime), N'KH001', N'NV04')
GO
INSERT [dbo].[tb_KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [DISABLE]) VALUES (N'KH001', N'Nguyễn Trần Vũ Đại Dương', N'0909999000', N'Thành phố Hồ Chí Minh', 0)
INSERT [dbo].[tb_KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [DISABLE]) VALUES (N'KH002', N'Trần Đức Trọng', N'0369963321', N'Bình Dương', 0)
INSERT [dbo].[tb_KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [DISABLE]) VALUES (N'KH003', N'Đoàn Công Sơn', N'0123321147', N'Bình Phước', 0)
GO
INSERT [dbo].[tb_LOAIXE] ([MALOAI], [TENLOAIXE], [DISABLE]) VALUES (N'ML001', N'Xe số', 0)
INSERT [dbo].[tb_LOAIXE] ([MALOAI], [TENLOAIXE], [DISABLE]) VALUES (N'ML002', N'Xe tay ga', 0)
INSERT [dbo].[tb_LOAIXE] ([MALOAI], [TENLOAIXE], [DISABLE]) VALUES (N'ML003', N'Xe côn', 0)
GO
INSERT [dbo].[tb_NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT], [DISABLE]) VALUES (N'NCC01', N'Công ty Yamaha', N'Thành phố Hồ Chí Minh', N'0123456789', 0)
INSERT [dbo].[tb_NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT], [DISABLE]) VALUES (N'NCC02', N'Công ty SYM', N'Quảng Nam', N'0147258369', 0)
INSERT [dbo].[tb_NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT], [DISABLE]) VALUES (N'NCC03', N'Công ty Honda', N'Quảng Ngãi', N'0987654321', 0)
INSERT [dbo].[tb_NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT], [DISABLE]) VALUES (N'NCC04', N'Công ty Suzuki', N'Quảng Trị', N'0369258147', 0)
GO
INSERT [dbo].[tb_NHANVIEN] ([MANV], [TENNV], [GIOITINH], [NGAYSINH], [DIACHI], [CMND], [SDT], [CHUCVU], [USERNAME], [PASSWORD], [DISABLE]) VALUES (N'NV01', N'Bùi Lâm Viễn', N'Nam', CAST(N'2001-01-01T00:00:00.000' AS DateTime), N'Quảng Nam', N'123456789', N'0909090909', N'Tư vấn', N'vien', N'1911065458', 0)
INSERT [dbo].[tb_NHANVIEN] ([MANV], [TENNV], [GIOITINH], [NGAYSINH], [DIACHI], [CMND], [SDT], [CHUCVU], [USERNAME], [PASSWORD], [DISABLE]) VALUES (N'NV02', N'Đặng Duy Mạnh', N'Nam', CAST(N'2001-01-02T00:00:00.000' AS DateTime), N'Quảng Ngãi', N'321654987', N'0585858585', N'Quản lý', N'manh', N'1911066211', 0)
INSERT [dbo].[tb_NHANVIEN] ([MANV], [TENNV], [GIOITINH], [NGAYSINH], [DIACHI], [CMND], [SDT], [CHUCVU], [USERNAME], [PASSWORD], [DISABLE]) VALUES (N'NV03', N'Cao Nguyễn Duy Anh', N'Nam', CAST(N'2001-01-03T00:00:00.000' AS DateTime), N'Thành Phố Hồ Chí Minh', N'987654321', N'0323232323', N'Tư vấn', N'anh', N'1911065968', 0)
INSERT [dbo].[tb_NHANVIEN] ([MANV], [TENNV], [GIOITINH], [NGAYSINH], [DIACHI], [CMND], [SDT], [CHUCVU], [USERNAME], [PASSWORD], [DISABLE]) VALUES (N'NV04', N'Nguyễn Đức Hậu', N'Nam', CAST(N'2001-01-04T00:00:00.000' AS DateTime), N'Đồng Nai', N'147258369', N'0373737373', N'Bán hàng', N'hau', N'1911066071', 0)
GO
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE001', N'Sirius', 20340000.0000, N'Đen', N'110', N'Mới', N'ML001', N'NCC01', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE002', N'Wave Alpha', 17890000.0000, N'Đỏ', N'110', N'Mới', N'ML002', N'NCC03', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE003', N'Exciter', 49290000.0000, N'Đen', N'150', N'Mới', N'ML003', N'NCC01', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE004', N'Air Blade', 55490000.0000, N'Đen Bạc', N'150', N'Mới', N'ML002', N'NCC03', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE005', N'Winner X', 46090000.0000, N'Đen', N'150', N'Mới', N'ML003', N'NCC03', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE006', N'Vision', 30290000.0000, N'Trắng Đen Bạc', N'110', N'Mới', N'ML002', N'NCC03', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE007', N'Future', 30290000.0000, N'Đỏ Đen', N'125', N'Mới', N'ML001', N'NCC03', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE008', N'Vario', 54400000.0000, N'Đen Nhám', N'125', N'Mới', N'ML002', N'NCC03', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE009', N'SH', 101100000.0000, N'Xám Đen', N'150', N'Mới', N'ML002', N'NCC03', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE010', N'Dream', 18990000.0000, N'Đen Trắng', N'125', N'Mới', N'ML001', N'NCC03', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE011', N'Jupiter', 30200000.0000, N'Đen', N'114', N'Mới', N'ML001', N'NCC01', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE012', N'CBR', 82000000.0000, N'Đen Đỏ', N'150', N'Mới', N'ML003', N'NCC03', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE013', N'Raider', 49190000.0000, N'Đen Mờ', N'150', N'Mới', N'ML003', N'NCC04', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE014', N'R15', 70000000.0000, N'Đen', N'155', N'Mới', N'ML003', N'NCC01', 0)
INSERT [dbo].[tb_XEMAY] ([MAXE], [TENXE], [GIABAN], [MAUSAC], [DUNGTICH], [TINHTRANG], [MALOAI], [MANCC], [DISABLE]) VALUES (N'XE015', N'SYM Star SR 170', 49900000.0000, N'Xanh Đen Bạc', N'175', N'Mới', N'ML003', N'NCC02', 0)
GO
ALTER TABLE [dbo].[tb_XEMAY]  WITH CHECK ADD  CONSTRAINT [FK_tb_XEMAY_tb_XEMAY] FOREIGN KEY([MAXE])
REFERENCES [dbo].[tb_XEMAY] ([MAXE])
GO
ALTER TABLE [dbo].[tb_XEMAY] CHECK CONSTRAINT [FK_tb_XEMAY_tb_XEMAY]
GO
USE [master]
GO
ALTER DATABASE [QLXEMAY] SET  READ_WRITE 
GO
