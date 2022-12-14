USE [THOITRANG]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 28/12/2021 2:27:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [char](10) NOT NULL,
	[MaSP] [char](10) NOT NULL,
	[SLMua] [int] NOT NULL,
	[KhuyenMai] [int] NOT NULL,
	[ThanhTien] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_CTMaHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieu] [char](10) NOT NULL,
	[MaSP] [char](10) NOT NULL,
	[GiaGoc] [decimal](18, 0) NOT NULL,
	[SLNhap] [int] NOT NULL,
	[ThanhTien] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_CTMaPhieu] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [char](10) NOT NULL,
	[MaKH] [char](8) NOT NULL,
	[MaNVLap] [char](10) NOT NULL,
	[MaQua] [char](10) NULL,
	[NgayLap] [date] NOT NULL,
	[TongTien] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_MaHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoiVien]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoiVien](
	[MaHV] [char](4) NOT NULL,
	[LoaiHV] [nvarchar](20) NOT NULL,
	[GiamGia] [int] NOT NULL,
 CONSTRAINT [PK_Hoi_vien] PRIMARY KEY CLUSTERED 
(
	[MaHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](8) NOT NULL,
	[MaHV] [char](4) NULL,
	[TenKH] [nvarchar](30) NOT NULL,
	[SDTKH] [char](10) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MaKH] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoai] [char](10) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MaLoai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [char](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MaNCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[HoTenNV] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[SDTNV] [char](20) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MaNV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaQuyen] [char](10) NOT NULL,
	[TenQuyen] [nvarchar](50) NOT NULL,
	[ChiTietQuyen] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MaQuyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieu] [char](10) NOT NULL,
	[MaNCC] [char](10) NOT NULL,
	[MaNVLap] [char](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[Tongtien] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_MaPhieu] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuaTang]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuaTang](
	[MaQua] [char](10) NOT NULL,
	[TenQua] [nvarchar](50) NOT NULL,
	[SLQua] [int] NOT NULL,
 CONSTRAINT [PK_QuaTang] PRIMARY KEY CLUSTERED 
(
	[MaQua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [char](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[MaLoai] [char](10) NOT NULL,
	[GiaBan] [decimal](18, 0) NULL,
	[SLTon] [int] NOT NULL,
	[ChatLieu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MaSP] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [char](15) NOT NULL,
	[MatKhau] [char](10) NOT NULL,
	[MaNV] [char](10) NOT NULL,
	[MaQuyen] [char](10) NOT NULL,
 CONSTRAINT [PK_TenTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_HD]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_SanPhamHD] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_SanPhamHD]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_Phieu] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuNhap] ([MaPhieu])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_Phieu]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_San_Pham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_Phieu_San_Pham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Khachhang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_Khachhang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Nhanvien] FOREIGN KEY([MaNVLap])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_Nhanvien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Quatang] FOREIGN KEY([MaQua])
REFERENCES [dbo].[QuaTang] ([MaQua])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_Quatang]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_HoiVien] FOREIGN KEY([MaHV])
REFERENCES [dbo].[HoiVien] ([MaHV])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_HoiVien]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_Phieu_NCC]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_NV] FOREIGN KEY([MaNVLap])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_Phieu_NV]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSanPham] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_Quyen_Nhan_Vien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_Quyen_Nhan_Vien]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_Quyen_Tai_Khoan] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[PhanQuyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_Quyen_Tai_Khoan]
GO
/****** Object:  StoredProcedure [dbo].[suaKhachHang]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[suaKhachHang]
@MaKH char(10),
@MaThe char(10),
@TenKH nvarchar(50),
@SDTKH char(10),
@DiaChi nvarchar(Max)
as
begin
     update KhachHang set MaHV = @MaThe, TenKH = @TenKH, SDTKH = @SDTKH, DiaChi = @DiaChi where MaKH = @MaKH
end
GO
/****** Object:  StoredProcedure [dbo].[suaLoai]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[suaLoai]
@MaLoai char(10),
@TenLoai nvarchar(50)
as
begin
     update LoaiSanPham set TenLoai = @TenLoai where MaLoai = @MaLoai
end
GO
/****** Object:  StoredProcedure [dbo].[suaNCC]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- sửa nhà cung cấp
Create Proc [dbo].[suaNCC]
@MaNCC char(10),
@TenNCC nvarchar(50)
as
begin
     update NhaCungCap set TenNCC = @TenNCC where MaNCC = @MaNCC
end
GO
/****** Object:  StoredProcedure [dbo].[suaNhanVien]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[suaNhanVien]
@MaNV char(10),
@HoTenNV nvarchar(50),
@ChucVu nvarchar(50),
@NgaySinh date,
@GioiTinh nvarchar(5),
@SDTNV char(20),
@DiaChi nvarchar(MAX)
as
begin
     update NhanVien set HoTenNV = @HoTenNV, ChucVu = @ChucVu, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SDTNV = @SDTNV, DiaChi = @DiaChi where MaNV = @MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[suaPhieuNhap]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- sửa phiếu nhập
Create Proc [dbo].[suaPhieuNhap]
@MaPhieu char(10),
@TongTien decimal
as
begin
     update PhieuNhap set Tongtien = @TongTien where MaPhieu = @MaPhieu
end
GO
/****** Object:  StoredProcedure [dbo].[suaSanPham]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[suaSanPham]
@MaSP char(10),
@TenSP nvarchar(50),
@MaLoai char(10),
@GiaBan decimal,
@SLTon int,
@ChatLieu nvarchar(50)
as
begin
     update SanPham set TenSP = @TenSP, MaLoai = @MaLoai, GiaBan = @GiaBan, SLTon = @SLTon, ChatLieu = @ChatLieu where MaSP = @MaSP
end
GO
/****** Object:  StoredProcedure [dbo].[suaTaiKhoan]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[suaTaiKhoan]
@TenTaiKhoan char(50),
@MatKhau char(50),
@MaNV char(10),
@MaQuyen char(10)
as
begin
     update TaiKhoan set MatKhau = @MatKhau, MaQuyen = @MaQuyen where TenTaiKhoan = @TenTaiKhoan and MaNV = @MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[themCTHD]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[themCTHD]
@MaHD char(10),
@MaSP char(10),
@SLMua int,
@KhuyenMai int,
@ThanhTien decimal
as
begin
     insert into ChiTietHoaDon values (@MaHD, @MaSP, @SLMua, @KhuyenMai, @ThanhTien)
end
GO
/****** Object:  StoredProcedure [dbo].[themCTPN]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[themCTPN]
@MaPhieu char(10),
@MaSP char(10),
@GiaGoc decimal,
@SLNhap int,
@ThanhTien decimal
as
begin
     insert into ChiTietPhieuNhap values (@MaPhieu, @MaSP, @GiaGoc, @SLNhap, @ThanhTien)
end
GO
/****** Object:  StoredProcedure [dbo].[themHoaDon]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[themHoaDon]
@MaHD char(10),
@MaKH char(10),
@MaNVLap char(10),
@MaQua char(10),
@NgayLap date,
@TongTien decimal
as
begin
     insert into HoaDon values (@MaHD, @MaKH, @MaNVLap, @MaQua, @NgayLap, @TongTien)
end
GO
/****** Object:  StoredProcedure [dbo].[themKhachHang]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[themKhachHang]
@MaKH char(10),
@MaThe char(10),
@TenKH nvarchar(50),
@SDTKH char(10),
@DiaChi nvarchar(Max)
as
begin
     insert into KhachHang values (@MaKH, @MaThe, @TenKH, @SDTKH, @DiaChi)
end
GO
/****** Object:  StoredProcedure [dbo].[themLoai]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[themLoai]
@MaLoai char(10),
@TenLoai nvarchar(50)
as
begin
     insert into LoaiSanPham values (@MaLoai, @TenLoai)
end
GO
/****** Object:  StoredProcedure [dbo].[themNCC]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- thêm nhà cung cấp
Create Proc [dbo].[themNCC]
@MaNCC char(10),
@TenNCC nvarchar(50)
as
begin
     insert into NhaCungCap values (@MaNCC, @TenNCC)
end
GO
/****** Object:  StoredProcedure [dbo].[themNhanVien]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[themNhanVien]
@MaNV char(10),
@HoTenNV nvarchar(50),
@ChucVu nvarchar(50),
@NgaySinh date,
@GioiTinh nvarchar(5),
@SDTNV char(20),
@DiaChi nvarchar(MAX)
as
begin
     insert into NhanVien values (@MaNV, @HoTenNV, @ChucVu, @NgaySinh, @GioiTinh, @SDTNV, @DiaChi)
end
GO
/****** Object:  StoredProcedure [dbo].[themPhieuNhap]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- thêm phiếu nhập
Create Proc [dbo].[themPhieuNhap]
@MaPhieu char(10),
@MaNCC char(10),
@MaNVLap char(10),
@NgayLap date,
@TongTien decimal
as
begin
     insert into PhieuNhap values (@MaPhieu, @MaNCC, @MaNVLap, @NgayLap, @TongTien)
end
GO
/****** Object:  StoredProcedure [dbo].[themSanPham]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[themSanPham]
@MaSP char(10),
@TenSP nvarchar(50),
@MaLoai char(10),
@GiaBan decimal,
@SLTon int,
@ChatLieu nvarchar(50)
as
begin
     insert into SanPham values (@MaSP, @TenSP, @MaLoai, @GiaBan, @SLTon, @ChatLieu)
end
GO
/****** Object:  StoredProcedure [dbo].[themTaiKhoan]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[themTaiKhoan]
@TenTaiKhoan char(50),
@MatKhau char(50),
@MaNV char(10),
@MaQuyen char(10)
as
begin
     insert into TaiKhoan values (@TenTaiKhoan, @MatKhau, @MaNV, @MaQuyen)
end
GO
/****** Object:  StoredProcedure [dbo].[xoaKhachHang]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[xoaKhachHang]
@MaKH char(10)
as
begin
     delete from KhachHang where MaKH = @MaKH
end
GO
/****** Object:  StoredProcedure [dbo].[xoaLoai]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[xoaLoai]
@MaLoai char(10)
as
begin
     delete from LoaiSanPham where MaLoai = @MaLoai
end
GO
/****** Object:  StoredProcedure [dbo].[xoaNCC]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- xóa loại sản phẩm
Create Proc [dbo].[xoaNCC]
@MaNCC char(10)
as
begin
     delete from NhaCungCap where MaNCC = @MaNCC
end
GO
/****** Object:  StoredProcedure [dbo].[xoaNhanVien]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[xoaNhanVien]
@MaNV char(10)
as
begin
     delete from NhanVien where MaNV = @MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[xoaSanPham]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[xoaSanPham]
@MaSP char(10)
as
begin
     delete from SanPham where MaSP = @MaSP
end
GO
/****** Object:  StoredProcedure [dbo].[xoaTaiKhoan]    Script Date: 28/12/2021 2:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[xoaTaiKhoan]
@TenTaiKhoan char(50)
as
begin
     delete from TaiKhoan where TenTaiKhoan = @TenTaiKhoan
end
GO
