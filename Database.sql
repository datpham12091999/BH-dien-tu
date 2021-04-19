USE [master]
GO
/****** Object:  Database [BanHangDienTu]    Script Date: 4/18/2021 2:02:43 PM ******/
CREATE DATABASE [BanHangDienTu] ON  PRIMARY 
( NAME = N'BanHangDienTu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BanHangDienTu.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BanHangDienTu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BanHangDienTu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BanHangDienTu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BanHangDienTu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BanHangDienTu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BanHangDienTu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BanHangDienTu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BanHangDienTu] SET ARITHABORT OFF 
GO
ALTER DATABASE [BanHangDienTu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BanHangDienTu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BanHangDienTu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BanHangDienTu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BanHangDienTu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BanHangDienTu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BanHangDienTu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BanHangDienTu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BanHangDienTu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BanHangDienTu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BanHangDienTu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BanHangDienTu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BanHangDienTu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BanHangDienTu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BanHangDienTu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BanHangDienTu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BanHangDienTu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BanHangDienTu] SET RECOVERY FULL 
GO
ALTER DATABASE [BanHangDienTu] SET  MULTI_USER 
GO
ALTER DATABASE [BanHangDienTu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BanHangDienTu] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BanHangDienTu', N'ON'
GO
USE [BanHangDienTu]
GO
/****** Object:  UserDefinedFunction [dbo].[LayDiaChi]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[LayDiaChi] ( @MaDH nvarchar(50) )
returns nvarchar(50)
begin
declare @DiaChi nvarchar(50)
set @DiaChi = ( select DiaChiGiaoHang
			  from DonHang
			  where MaDonHang = @MaDH
			  )
return @Diachi
end
GO
/****** Object:  UserDefinedFunction [dbo].[LayMaDH]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Function [dbo].[LayMaDH] ( @MaDH nvarchar(50) )
returns nvarchar(8)
begin
declare @MaDH1 nvarchar(8)
set @MaDH1 = ( select MaDonHang
			  from DonHang
			  where MaDonHang = @MaDH
			  )
return @MaDH1
end
GO
/****** Object:  UserDefinedFunction [dbo].[LayNgayDatHang]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[LayNgayDatHang] ( @MaDH nvarchar(8))
returns Date
begin
declare @NgayDH date
set @NgayDH = ( select NgayMuaHang
			  from DonHang
			  where MaDonHang = @MaDH
			  )
return @NgayDH
end
GO
/****** Object:  UserDefinedFunction [dbo].[LayQuanHuyen]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[LayQuanHuyen] ( @MaDH nvarchar(50) )
returns nvarchar(50)
begin
declare @DiaChi nvarchar(50)
set @DiaChi = ( select [Quan/Huyen]
			  from DonHang
			  where MaDonHang = @MaDH
			  )
return @Diachi
end
GO
/****** Object:  UserDefinedFunction [dbo].[LayTinh]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[LayTinh] ( @MaDH nvarchar(50) )
returns nvarchar(50)
begin
declare @DiaChi nvarchar(50)
set @DiaChi = ( select [Tinh/ThanhPho]
			  from DonHang
			  where MaDonHang = @MaDH
			  )
return @Diachi
end
GO
/****** Object:  UserDefinedFunction [dbo].[TimGiaBan]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Function [dbo].[TimGiaBan] ( @ma int )
returns int
AS
BEGIN
Declare @GiaSP int;
Set @GiaSP =  ( Select GiaBan
from SanPham
where MaSP = @ma);
Return @GiaSP
END;
GO
/****** Object:  UserDefinedFunction [dbo].[TimSPtrung]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  Function  [dbo].[TimSPtrung] (  @tensp nvarchar(50))
returns int
begin
declare @kq int
if  Exists ( select [Số Lượng]
              from DSGH
			  where TenSP = @tensp)
			 set @kq = 1
else
			set @kq = 0
return @kq
end
GO
/****** Object:  UserDefinedFunction [dbo].[TimTenSP]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create Function [dbo].[TimTenSP] ( @ma int )
returns VarChar(50)
AS
BEGIN
Declare @TenSP VarChar (50);
Set @TenSP =  ( Select TenSP
from SanPham
where MaSP = @ma);
Return @TenSP
END;
GO
/****** Object:  Table [dbo].[CTDH]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDH](
	[MaDonHang] [nchar](8) NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[Gia] [int] NULL,
	[SoLuong] [int] NULL,
	[KhuyenMai] [real] NULL,
 CONSTRAINT [PK_CTDH] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[MaKhachHang] [int] NOT NULL,
	[DangNhap] [nchar](50) NOT NULL,
	[MatKhau] [nchar](255) NOT NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC,
	[DangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [nchar](8) NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[NgayMuaHang] [date] NOT NULL,
	[ThanhTienDonHang] [int] NOT NULL,
	[DiaChiGiaoHang] [nvarchar](50) NULL,
	[Tinh/ThanhPho] [nvarchar](50) NULL,
	[Quan/Huyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DSGH]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSGH](
	[TenSP] [nvarchar](50) NOT NULL,
	[GiaBan] [int] NULL,
	[Số Lượng] [int] NULL,
 CONSTRAINT [PK_DSGH] PRIMARY KEY CLUSTERED 
(
	[TenSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoTroKhachHang]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoTroKhachHang](
	[MaPhieuHoTro] [int] IDENTITY(1,1) NOT NULL,
	[HoTenKH] [nvarchar](50) NOT NULL,
	[SĐT] [nchar](10) NOT NULL,
	[NgayGio] [datetime] NOT NULL,
	[DichVu] [nvarchar](50) NOT NULL,
	[LoiNhan] [nvarchar](max) NOT NULL,
	[TinhTrang] [nchar](10) NOT NULL,
 CONSTRAINT [PK_HoTroKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieuHoTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[Email] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[NgaySinh] [date] NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoaiSP] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSP] [nvarchar](50) NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiSP] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[SoDienThoai] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanHuyen]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanHuyen](
	[MaQuanHuyen] [int] NOT NULL,
	[MaTinh] [int] NOT NULL,
	[TenQuanHuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_QuanHuyen] PRIMARY KEY CLUSTERED 
(
	[MaQuanHuyen] ASC,
	[MaTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[LoaiSP] [int] NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [int] NULL,
	[GiaBan] [int] NULL,
	[ConHang] [bit] NULL,
	[HinhAnhSP] [image] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuaChua]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuaChua](
	[MaDonSuaChua] [int] IDENTITY(1,1) NOT NULL,
	[TenSPSuaChua] [nchar](50) NOT NULL,
	[NgayDatLich] [date] NOT NULL,
	[MoTaTinhTrang] [text] NOT NULL,
	[Diachi] [nchar](50) NOT NULL,
	[SDT] [nchar](10) NOT NULL,
 CONSTRAINT [PK_DatLichSuaChua] PRIMARY KEY CLUSTERED 
(
	[MaDonSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tinh]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tinh](
	[MaTinh] [int] NOT NULL,
	[TenTinh] [nchar](100) NULL,
 CONSTRAINT [PK_Tinh] PRIMARY KEY CLUSTERED 
(
	[MaTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TKNhanVien]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TKNhanVien](
	[MaNV] [int] NOT NULL,
	[TenTK] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TKNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_DonHang] FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_DonHang]
GO
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_SanPham]
GO
ALTER TABLE [dbo].[DangNhap]  WITH CHECK ADD  CONSTRAINT [FK_DangNhap_KhachHang1] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[DangNhap] CHECK CONSTRAINT [FK_DangNhap_KhachHang1]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_KhachHang]
GO
ALTER TABLE [dbo].[QuanHuyen]  WITH CHECK ADD  CONSTRAINT [FK_QuanHuyen_Tinh1] FOREIGN KEY([MaTinh])
REFERENCES [dbo].[Tinh] ([MaTinh])
GO
ALTER TABLE [dbo].[QuanHuyen] CHECK CONSTRAINT [FK_QuanHuyen_Tinh1]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSP] FOREIGN KEY([LoaiSP])
REFERENCES [dbo].[LoaiSP] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSP]
GO
ALTER TABLE [dbo].[TKNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_TKNhanVien_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[TKNhanVien] CHECK CONSTRAINT [FK_TKNhanVien_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[DemSoSP]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[DemSoSP] 
as
declare  @kq int 
Set @kq = (Select COUNT(MaSP) 
FROM SanPham)
Return @kq
GO
/****** Object:  StoredProcedure [dbo].[KTDangNhap]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[KTDangNhap] (@tendangnhap varchar(50) , @matkhau varchar(50))
as
declare @kq int
begin
if Exists ( select * from DangNhap 
where DangNhap  = @tendangnhap and MatKhau = @matkhau)
   set @kq =1 
   else if not exists ( select * from DangNhap
where DangNhap= @tendangnhap )
   set @kq =2
   else if not exists (select * from DangNhap
   where MatKhau = @matkhau)
   set @kq =3
   else
   set @kq = -1
end
return @kq
GO
/****** Object:  StoredProcedure [dbo].[KTDangNhapNV]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[KTDangNhapNV] (@tendangnhap varchar(50) , @matkhau varchar(50))
as
declare @kq int
begin
if Exists ( select * from TKNhanVien
where TenTK  = @tendangnhap and MatKhau = @matkhau)
   set @kq =1 
   else if not exists ( select * from TKNhanVien
where TenTK= @tendangnhap )
   set @kq =2
   else if not exists (select * from TKNhanVien
   where MatKhau = @matkhau)
   set @kq =3
   else
   set @kq = -1
end
return @kq
GO
/****** Object:  StoredProcedure [dbo].[LayMaKhachHang]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[LayMaKhachHang] ( @tenKh nvarchar(50) , @SDT nvarchar(50))
as
declare @MaKH int
begin
set @MaKH = ( select MaKhachHang
			  from KhachHang
			  where HoTen = @tenKh and SDT = @SDT
			  )
return @MaKH
end
GO
/****** Object:  StoredProcedure [dbo].[LayMaSanPham]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[LayMaSanPham] ( @tensp nvarchar(50))
as
declare @MaSP int
begin
set @MaSP = ( select MaSP
			  from SanPham
			  where TenSP = @tensp
			  )
return @MaSP
end
GO
/****** Object:  StoredProcedure [dbo].[LayMaTinh]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[LayMaTinh] (@tinh nvarchar(50))
as
declare @Matinh int
begin
set @Matinh =
(select MaTinh from Tinh
Where TenTinh = @tinh)
return @Matinh
end
GO
/****** Object:  StoredProcedure [dbo].[LaySoLuongSP]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[LaySoLuongSP] ( @masp int )
as
declare @SL int
begin
set @SL = ( select SoLuong
            from SanPham
			where MaSP = @masp
			)
return @SL
end
GO
/****** Object:  StoredProcedure [dbo].[LayThanhTien]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[LayThanhTien] ( @MaDH nvarchar(8))
as
declare @ThanhTien int
begin
set @ThanhTien = ( select ThanhTienDonHang
			  from DonHang
			  where MaDonHang = @MaDH
			  )
return @ThanhTien
end
GO
/****** Object:  StoredProcedure [dbo].[TimKH]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[TimKH] ( @TenKH nvarchar(50) , @SDT nvarchar(50))
as
declare @kq int
begin
if Exists ( select HoTen
            from KhachHang
			where HoTen = @TenKH and SDT = @SDT)
			set @kq = 1
else
	       set @kq = 0
return @kq;
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemSanPham]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[TimKiemSanPham] ( @TenSP nvarchar(50))
as
begin
Select TenSP , GiaBan ,MaSP
From  SanPham
where TenSP like '%' +@TenSP+ '%'
end
GO
/****** Object:  StoredProcedure [dbo].[TimLinhKien]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[TimLinhKien] (@name nvarchar(50))
as
declare @soluong int
begin
set @soluong =( select COUNT(MaSP)
              from SanPham
              Where TenSP like '%' +@name+ '%')
return @soluong
end
GO
/****** Object:  StoredProcedure [dbo].[TimMaDH]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[TimMaDH] ( @MaDH nvarchar(100))
as
declare @kq int
begin
if exists ( select ThanhTienDonHang
            from DonHang
			where MaDonHang = @MaDH
		)
			set @kq = 1;
else
set @kq = 0
return @kq
end
GO
/****** Object:  StoredProcedure [dbo].[TimMaDHTrung]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[TimMaDHTrung] ( @MaDonHang nvarchar(8))
as
declare @kq int
begin 
if exists ( select MaDonHang
            from DonHang
			where MaDonHang = @MaDonHang)
			set @kq = 1
else
set @kq = 0
return @kq;
end
GO
/****** Object:  StoredProcedure [dbo].[TimMaSP]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[TimMaSP] ( @tenSP nvarchar(50))
as
declare @ma int
begin
set @ma = ( Select MaSP
        from SanPham
		where TenSP = @tenSP)
return @ma

end
GO
/****** Object:  StoredProcedure [dbo].[TimTaiKhoan]    Script Date: 4/18/2021 2:02:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[TimTaiKhoan] (  @tentk nvarchar(50))
as
declare @kq int
begin
if exists ( select DangNhap
            from DangNhap
			where DangNhap = @tentk
			)
			set @kq =1;
else 
set @kq = 0;
return @kq;
end
GO
USE [master]
GO
ALTER DATABASE [BanHangDienTu] SET  READ_WRITE 
GO
