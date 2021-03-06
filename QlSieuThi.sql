USE [QLBanHangSieuThi]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[machucvu] [int] IDENTITY(1,1) NOT NULL,
	[tenchucvu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[machucvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[mahh] [int] IDENTITY(1,1) NOT NULL,
	[tenhh] [nvarchar](50) NULL,
	[gianhap] [float] NULL CONSTRAINT [DF_HangHoa_gianhap]  DEFAULT ((0)),
	[giaban] [float] NULL CONSTRAINT [DF_HangHoa_giaban]  DEFAULT ((0)),
	[ngaysx] [datetime] NULL CONSTRAINT [DF_HangHoa_ngaysx]  DEFAULT (getdate()),
	[hansd] [datetime] NULL CONSTRAINT [DF_HangHoa_hansd]  DEFAULT (getdate()),
	[tinhtrang] [nvarchar](100) NULL,
	[soluong] [int] NULL CONSTRAINT [DF_HangHoa_soluong]  DEFAULT ((0)),
	[makho] [int] NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[mahh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[mahoadon] [int] IDENTITY(1,1) NOT NULL,
	[makh] [int] NULL,
	[mahh] [int] NULL,
	[soluong] [int] NULL CONSTRAINT [DF_HoaDon_soluong]  DEFAULT ((0)),
	[ngayxuat] [datetime] NULL CONSTRAINT [DF_HoaDon_ngayxuat]  DEFAULT (getdate()),
	[tongtien] [float] NULL CONSTRAINT [DF_HoaDon_tongtien]  DEFAULT ((0)),
	[dathanhtoan] [int] NULL CONSTRAINT [DF_HoaDon_dathanhtoan]  DEFAULT ((0)),
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[makh] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [datetime] NULL CONSTRAINT [DF_KhachHang_ngaysinh]  DEFAULT (getdate()),
	[gioitinh] [nvarchar](10) NULL,
	[diachi] [nvarchar](100) NULL,
	[lienhe] [nchar](20) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kho]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[makho] [int] IDENTITY(1,1) NOT NULL,
	[tenkho] [nvarchar](50) NULL,
	[diadiem] [nvarchar](100) NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[makho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[mancc] [int] IDENTITY(1,1) NOT NULL,
	[tenncc] [nvarchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
	[lienhe] [nchar](20) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[manv] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](10) NULL,
	[ngaysinh] [datetime] NULL CONSTRAINT [DF_NhanVien_ngaysinh]  DEFAULT (getdate()),
	[diachi] [nvarchar](100) NULL,
	[lienhe] [nchar](20) NULL,
	[luong] [float] NULL CONSTRAINT [DF_NhanVien_luong]  DEFAULT ((0)),
	[machucvu] [int] NULL,
	[makho] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[maphieu] [int] IDENTITY(1,1) NOT NULL,
	[mancc] [int] NULL,
	[mahh] [int] NULL,
	[soluong] [int] NULL CONSTRAINT [DF_PhieuNhap_soluong]  DEFAULT ((0)),
	[ngaynhap] [datetime] NULL CONSTRAINT [DF_PhieuNhap_ngaynhap]  DEFAULT (getdate()),
	[diadiem] [nvarchar](100) NULL,
	[tonggia] [float] NULL CONSTRAINT [DF_PhieuNhap_tonggia]  DEFAULT ((0)),
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maphieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([machucvu], [tenchucvu]) VALUES (1, N'Giám đốc')
INSERT [dbo].[ChucVu] ([machucvu], [tenchucvu]) VALUES (2, N'Kế toán')
INSERT [dbo].[ChucVu] ([machucvu], [tenchucvu]) VALUES (3, N'Thu ngân')
INSERT [dbo].[ChucVu] ([machucvu], [tenchucvu]) VALUES (4, N'Tiếp thị')
INSERT [dbo].[ChucVu] ([machucvu], [tenchucvu]) VALUES (5, N'Quản lý')
INSERT [dbo].[ChucVu] ([machucvu], [tenchucvu]) VALUES (6, N'Bảo vệ')
INSERT [dbo].[ChucVu] ([machucvu], [tenchucvu]) VALUES (7, N'Vận chuyển')
INSERT [dbo].[ChucVu] ([machucvu], [tenchucvu]) VALUES (8, N'Chăm sóc khách hàng')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (1, N'Kem Celano', 15000, 20000, CAST(N'2017-05-16 06:48:50.190' AS DateTime), CAST(N'2017-05-16 06:48:50.183' AS DateTime), N'Tốt', 80, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (2, N'Nitri Boost', 10000, 0, CAST(N'2017-05-16 07:15:00.823' AS DateTime), CAST(N'2017-05-16 07:15:00.813' AS DateTime), N'Tốt', 90, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (3, N'Bim Bim Oscar', 5000, 0, CAST(N'2017-05-16 07:15:00.823' AS DateTime), CAST(N'2017-05-16 07:15:00.813' AS DateTime), N'Tốt', 80, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (4, N'Nitri Boost', 10000, 0, CAST(N'2017-05-16 07:15:00.823' AS DateTime), CAST(N'2017-05-16 07:15:00.813' AS DateTime), N'Tốt', 100, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (5, N'Bim Bim Oscar', 5000, 0, CAST(N'2017-05-16 07:15:00.823' AS DateTime), CAST(N'2017-05-16 07:15:00.813' AS DateTime), N'Tốt', 90, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (6, N'Bim Bim Oisi', 5000, 0, CAST(N'2017-05-16 07:15:00.823' AS DateTime), CAST(N'2017-05-16 07:15:00.813' AS DateTime), N'Tốt', 80, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (7, N'Nitri Boost', 10000, 0, CAST(N'2017-05-16 07:15:00.823' AS DateTime), CAST(N'2017-05-16 07:15:00.813' AS DateTime), N'Tốt', 100, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (8, N'Bim Bim Oscar', 5000, 0, CAST(N'2017-05-16 07:15:00.823' AS DateTime), CAST(N'2017-05-16 07:15:00.813' AS DateTime), N'Tốt', 100, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (9, N'Bim Bim Oisi', 5000, 0, CAST(N'2017-05-16 07:15:00.823' AS DateTime), CAST(N'2017-05-16 07:15:00.813' AS DateTime), N'Tốt', 100, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (10, N'Trái cây', 90000, 0, CAST(N'2017-05-16 07:19:30.890' AS DateTime), CAST(N'2017-05-16 07:19:30.877' AS DateTime), N'Tốt', 100, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (11, N'Áo thun Alan Walker', 120000, 0, CAST(N'2017-05-16 12:42:00.960' AS DateTime), CAST(N'2017-05-16 12:42:00.960' AS DateTime), N'Tốt', 10, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (12, N'Áo thun Young Division', 100000, 0, CAST(N'2017-05-16 12:42:00.960' AS DateTime), CAST(N'2017-05-16 12:42:00.960' AS DateTime), N'Tốt', 10, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (13, N'Mèo', 60000, 0, CAST(N'2017-05-16 12:45:59.867' AS DateTime), CAST(N'2017-05-16 12:45:59.867' AS DateTime), N'Mèo', 20, 2)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (14, N'Mèo Mèo', 70000, 0, CAST(N'2017-05-16 12:45:59.867' AS DateTime), CAST(N'2017-05-16 12:45:59.867' AS DateTime), N'Mèo Mèo', 20, 2)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (15, N'Măm măm', 12000, 0, CAST(N'2017-05-16 12:49:45.957' AS DateTime), CAST(N'2017-05-16 12:49:45.957' AS DateTime), N'Hỏng', 100, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (16, N'Comfort', 1500, 0, CAST(N'2017-05-16 12:51:01.967' AS DateTime), CAST(N'2017-05-16 12:51:01.967' AS DateTime), N'Tốt', 100, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (17, N'Danny', 1500, 0, CAST(N'2017-05-16 12:52:05.073' AS DateTime), CAST(N'2017-05-16 12:52:05.073' AS DateTime), N'Hỏng', 100, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (18, N'Cocacola', 6500, 0, CAST(N'2017-05-16 12:53:12.703' AS DateTime), CAST(N'2017-05-16 12:53:12.697' AS DateTime), N'Tốt', 100, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (19, N'Pepsi', 6500, 0, CAST(N'2017-05-16 12:53:12.703' AS DateTime), CAST(N'2017-05-16 12:53:12.697' AS DateTime), N'Tốt', 100, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (20, N'IPhone 7', 19000000, 21000000, CAST(N'2017-05-16 13:45:16.403' AS DateTime), CAST(N'2017-05-16 13:45:16.400' AS DateTime), N'Tot', 10, 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [gianhap], [giaban], [ngaysx], [hansd], [tinhtrang], [soluong], [makho]) VALUES (21, N'Monkey', 120, 1200, CAST(N'2017-05-17 05:23:05.190' AS DateTime), CAST(N'2017-05-17 05:23:05.190' AS DateTime), N'Good', 100, 1)
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([mahoadon], [makh], [mahh], [soluong], [ngayxuat], [tongtien], [dathanhtoan]) VALUES (1, 1, 1, 10, CAST(N'2017-05-16 16:14:05.053' AS DateTime), 20000, 1)
INSERT [dbo].[HoaDon] ([mahoadon], [makh], [mahh], [soluong], [ngayxuat], [tongtien], [dathanhtoan]) VALUES (2, 1, 1, 10, CAST(N'2017-05-16 16:16:01.420' AS DateTime), 20000, 1)
INSERT [dbo].[HoaDon] ([mahoadon], [makh], [mahh], [soluong], [ngayxuat], [tongtien], [dathanhtoan]) VALUES (3, 1, 2, 10, CAST(N'2017-05-16 16:26:12.513' AS DateTime), 0, 1)
INSERT [dbo].[HoaDon] ([mahoadon], [makh], [mahh], [soluong], [ngayxuat], [tongtien], [dathanhtoan]) VALUES (4, 1, 3, 10, CAST(N'2017-05-16 16:26:12.513' AS DateTime), 0, 1)
INSERT [dbo].[HoaDon] ([mahoadon], [makh], [mahh], [soluong], [ngayxuat], [tongtien], [dathanhtoan]) VALUES (5, 1, 3, 10, CAST(N'2017-05-16 16:29:52.160' AS DateTime), 0, 1)
INSERT [dbo].[HoaDon] ([mahoadon], [makh], [mahh], [soluong], [ngayxuat], [tongtien], [dathanhtoan]) VALUES (6, 1, 6, 20, CAST(N'2017-05-16 16:29:52.160' AS DateTime), 0, 1)
INSERT [dbo].[HoaDon] ([mahoadon], [makh], [mahh], [soluong], [ngayxuat], [tongtien], [dathanhtoan]) VALUES (7, 1, 5, 10, CAST(N'2017-05-17 05:22:45.550' AS DateTime), 0, 1)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([makh], [hoten], [ngaysinh], [gioitinh], [diachi], [lienhe]) VALUES (1, N'Pusheen', CAST(N'2017-07-08 00:00:00.000' AS DateTime), N'Nữ', N'Ở nhà', N'0962374650          ')
INSERT [dbo].[KhachHang] ([makh], [hoten], [ngaysinh], [gioitinh], [diachi], [lienhe]) VALUES (2, N'Stormy', CAST(N'2017-06-08 00:00:00.000' AS DateTime), N'Nữ', N'Ở nhà', N'0962374650          ')
INSERT [dbo].[KhachHang] ([makh], [hoten], [ngaysinh], [gioitinh], [diachi], [lienhe]) VALUES (4, N'Lê Quỳnh', CAST(N'2017-05-17 04:12:19.437' AS DateTime), N'Nữ', N'Ở nhà', N'01875657755         ')
INSERT [dbo].[KhachHang] ([makh], [hoten], [ngaysinh], [gioitinh], [diachi], [lienhe]) VALUES (5, N'Đỗ Hưng', CAST(N'2017-05-17 04:13:55.590' AS DateTime), N'Nam', N'Hà Nội', N'0962374650          ')
INSERT [dbo].[KhachHang] ([makh], [hoten], [ngaysinh], [gioitinh], [diachi], [lienhe]) VALUES (6, N'Someone', CAST(N'2017-05-17 05:22:23.970' AS DateTime), N'Nam', N'Somewhere', N'0123                ')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[Kho] ON 

INSERT [dbo].[Kho] ([makho], [tenkho], [diadiem]) VALUES (1, N'Kho1', N'Ha Noi')
INSERT [dbo].[Kho] ([makho], [tenkho], [diadiem]) VALUES (2, N'Kho2', N'Ha Noi')
SET IDENTITY_INSERT [dbo].[Kho] OFF
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([mancc], [tenncc], [diachi], [lienhe]) VALUES (1, N'Pusheen', N'Ha Noi', N'0962374650          ')
INSERT [dbo].[NhaCungCap] ([mancc], [tenncc], [diachi], [lienhe]) VALUES (2, N'Stormy', N'Ha Noi', N'0962374650          ')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([manv], [hoten], [gioitinh], [ngaysinh], [diachi], [lienhe], [luong], [machucvu], [makho]) VALUES (1, N'Pusheen', N'Nữ', CAST(N'2017-07-08 00:00:00.000' AS DateTime), N'Ở nhà', N'0962374650          ', 30000000, 1, 1)
INSERT [dbo].[NhanVien] ([manv], [hoten], [gioitinh], [ngaysinh], [diachi], [lienhe], [luong], [machucvu], [makho]) VALUES (2, N'Stormy', N'Nữ', CAST(N'2017-05-17 05:24:51.227' AS DateTime), N'Ở nhà', N'09633               ', 12000000, 2, 1)
INSERT [dbo].[NhanVien] ([manv], [hoten], [gioitinh], [ngaysinh], [diachi], [lienhe], [luong], [machucvu], [makho]) VALUES (4, N'Lê Quỳnh', N'Nữ', CAST(N'2017-05-18 05:27:25.000' AS DateTime), N'Ở nhà', N'01875657755         ', 120000000, 1, 1)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON 

INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (1, 1, 1, 14, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Hà Nội', 1500000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (2, 1, 2, 25, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Hà Nội', 1000000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (3, 1, 3, 74, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Hà Nội', 500000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (4, 1, 4, 35, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Hà Nội', 1000000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (5, 1, 5, 86, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Hà Nội', 500000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (6, 1, 6, 25, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Hà Nội', 500000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (7, 1, 7, 63, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Hà Nội', 1000000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (8, 1, 8, 73, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Hà Nội', 500000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (9, 1, 9, 42, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Hà Nội', 500000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (10, 2, 10, 74, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Ở nhà', 9000000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (11, 2, 11, 43, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'At Home', 1200000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (12, 2, 12, 86, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'At Home', 1000000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (13, 1, 13, 32, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Hà Nội', 1200000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (14, 1, 14, 46, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Hà Nội', 1400000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (15, 1, 15, 8, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Ở nhà', 1200000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (16, 1, 16, 35, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Ở nhà', 150000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (17, 1, 17, 15, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Ở nhà', 150000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (18, 1, 18, 63, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Ở nhà', 650000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (19, 1, 19, 44, CAST(N'2017-05-16 13:23:15.693' AS DateTime), N'Ở nhà', 650000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (20, 2, 20, 10, CAST(N'2017-05-16 13:45:16.363' AS DateTime), N'Meo', 1900000)
INSERT [dbo].[PhieuNhap] ([maphieu], [mancc], [mahh], [soluong], [ngaynhap], [diadiem], [tonggia]) VALUES (21, 1, 21, 100, CAST(N'2017-05-17 05:23:05.173' AS DateTime), N'Ha Noi', 12000)
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_Kho] FOREIGN KEY([makho])
REFERENCES [dbo].[Kho] ([makho])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_Kho]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_HangHoa] FOREIGN KEY([mahh])
REFERENCES [dbo].[HangHoa] ([mahh])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_HangHoa]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([makh])
REFERENCES [dbo].[KhachHang] ([makh])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([machucvu])
REFERENCES [dbo].[ChucVu] ([machucvu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Kho] FOREIGN KEY([makho])
REFERENCES [dbo].[Kho] ([makho])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Kho]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_HangHoa] FOREIGN KEY([mahh])
REFERENCES [dbo].[HangHoa] ([mahh])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_HangHoa]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([mancc])
REFERENCES [dbo].[NhaCungCap] ([mancc])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_nhap]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_hh_nhap]
@tenhh nvarchar(50), @gianhap float, @ngaysx datetime, @hansd datetime,
@tinhtrang nvarchar(100), @soluong int, @makho int, @ngaynhap datetime,
@mancc int, @diadiem nvarchar(100), @tonggia float
as begin
	insert into hanghoa (tenhh, gianhap, ngaysx, hansd, tinhtrang, soluong, makho)
		values (@tenhh, @gianhap, @ngaysx, @hansd, @tinhtrang, @soluong, @makho)

	declare @mahh int
	select top 1 @mahh=mahh from hanghoa order by mahh desc
	insert into phieunhap (mancc, mahh, soluong, ngaynhap, diadiem, tonggia) 
	values (@mancc, @mahh, @soluong, @ngaynhap, @diadiem, @tonggia)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_sua]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_hh_sua]
@mahh int, @tenhh nvarchar(50), @gianhap float, @giaban float, @ngaysx datetime,
@hansd datetime, @tinhtrang nvarchar(100), @soluong int, @ngaynhap datetime, 
@makho int, @mancc int
as begin
	if exists (select * from hanghoa where mahh=@mahh)
	begin
		update hanghoa set tenhh=@tenhh, gianhap=@gianhap, giaban=@giaban,
		ngaysx=@ngaysx, hansd=@hansd, tinhtrang=@tinhtrang, soluong=@soluong,
		makho=@makho where mahh=@mahh

		update phieunhap set ngaynhap=@ngaynhap, mancc=@mancc where mahh=@mahh
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_thongkenhap]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_hh_thongkenhap]
as begin
	select top 3 cast(ngaynhap as date) ngay, sum(soluong) soluong 
	from phieunhap group by cast(ngaynhap as date)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_thongkexuat]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_hh_thongkexuat]
as begin
	select top 3 cast(ngayxuat as date) ngay, sum(soluong) soluong
	 from hoadon group by cast(ngayxuat as date)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_timkiem]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_hh_timkiem]
@value nvarchar(100)
as begin
	select A.mahh,a.tenhh, a.gianhap, a.giaban, c.ngaynhap,
		a.soluong, a.ngaysx, a.hansd, a.tinhtrang, b.tenkho from hanghoa A
	inner join kho B on a.makho=b.makho 
	inner join phieunhap C on a.mahh=c.mahh
	where cast(a.mahh as varchar) like '%'+@value+'%' or a.tenhh like '%'+@value+'%'
		or cast(a.gianhap as varchar) like '%'+@value+'%' or cast(a.giaban as varchar) like '%'+@value+'%'
		or cast(day(c.ngaynhap) as varchar) like '%'+@value+'%' or cast(a.soluong as varchar) like '%'+@value+'%'
		or cast(a.ngaysx as varchar) like '%'+@value+'%' or cast(a.hansd as varchar) like '%'+@value+'%'
		or cast(a.tinhtrang as varchar) like '%'+@value+'%' or cast(b.tenkho as nvarchar) like '%'+@value+'%'
		or cast(month(c.ngaynhap) as varchar) like '%'+@value+'%' 
		or cast(year(c.ngaynhap) as varchar) like '%'+@value+'%' 
		or cast(year(a.hansd) as varchar) like '%'+@value+'%' 
		or cast(year(a.ngaysx) as varchar) like '%'+@value+'%' 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_xem]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_hh_xem]
as begin
	select A.mahh,a.tenhh, a.gianhap, a.giaban, c.ngaynhap,a.soluong, 
	a.ngaysx, a.hansd, a.tinhtrang,a.makho,c.mancc from hanghoa A
	inner join phieunhap C on a.mahh=c.mahh
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_xuat]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_hh_xuat]
@mahh int, @makh int, @soluong int,  
@ngayxuat datetime, @tongtien float, @dathanhtoan int
as begin
	if exists(select * from hoadon where makh=@makh and mahh=@mahh and ngayxuat=@ngayxuat)
	begin 
		update hoadon set soluong=soluong+@soluong where makh=@makh and mahh=@mahh and ngayxuat=@ngayxuat
	end
	else begin
		insert into hoadon (makh, mahh, soluong, ngayxuat, tongtien, dathanhtoan)
		values (@makh, @mahh, @soluong, @ngayxuat, @tongtien, @dathanhtoan)
	end

	update hanghoa set soluong = soluong-@soluong where mahh=@mahh
end
GO
/****** Object:  StoredProcedure [dbo].[sp_kh_timkiem]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_kh_timkiem]
@value nvarchar(100)
as begin
	select * from khachhang where cast(makh as varchar) like '%'+@value+'%'
	or hoten like '%'+@value+'%' or diachi like '%'+@value+'%'
	or gioitinh like '%'+@value+'%' or lienhe like '%'+@value+'%'
	or cast(day(ngaysinh) as varchar) like '%'+@value+'%' 
	or cast(month(ngaysinh) as varchar) like '%'+@value+'%'
	or cast(year(ngaysinh) as varchar) like '%'+@value+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_nv_timkiem]    Script Date: 5/17/2017 8:14:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_nv_timkiem]
@value nvarchar(100)
as begin
	select A.* from nhanvien A 
	inner join Kho C on a.makho=C.makho
	inner join chucvu B on a.machucvu=B.machucvu
	where cast(manv as varchar) like '%'+@value+'%'
	or hoten like '%'+@value+'%' or gioitinh  like '%'+@value+'%'
	or diachi like '%'+@value+'%' or lienhe like '%'+@value+'%'
	or cast(luong as varchar) like '%'+@value+'%'
	or cast(A.makho as varchar) like '%'+@value+'%'
	or c.tenkho like '%'+@value+'%' or b.tenchucvu like '%'+@value+'%'
	or cast(A.machucvu as varchar) like '%'+@value+'%'
	or cast(day(ngaysinh) as varchar) like '%'+@value+'%'
	or cast(month(ngaysinh) as varchar) like '%'+@value+'%'
	or cast(year(ngaysinh) as varchar) like '%'+@value+'%'
end
GO
