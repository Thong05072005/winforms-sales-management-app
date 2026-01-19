USE [DoAnQLBanLaptop]
GO

CREATE TABLE [dbo].[sanpham](
    [MaSP] [varchar](50) NOT NULL,
    [TenSP] [nvarchar](50) NULL,
    [GiaSP] [float] NULL,
    [SoLuongCon] [int] NULL,
    [Anh] [varchar](200) NULL,
    [MaNCC] [varchar](50) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaSP] ASC)
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[NhaCungCap](
    [MaNCC] [varchar](50) NOT NULL,
    [DiaChi] [nvarchar](50) NULL,
    [Phone] [char](10) NULL,
    [Email] [varchar](50) NULL,
    [TenNCC] [nvarchar](50) NULL,
    [TrangThai] [int] NULL,
    PRIMARY KEY CLUSTERED ([MaNCC] ASC)
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[KhachHang](
    [MaKH] [varchar](50) NOT NULL,
    [HoTenKH] [nvarchar](50) NULL,
    [NamSinh] [datetime] NULL,
    [GioiTinh] [nvarchar](3) NULL,
    [DiaChi] [nvarchar](50) NULL,
    [DienThoai] [char](10) NULL,
    [Email] [varchar](50) NULL,
    PRIMARY KEY CLUSTERED ([MaKH] ASC)
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[NhanVien](
    [MaNV] [varchar](50) NOT NULL,
    [HoTenNV] [nvarchar](50) NULL,
    [NamSinh] [datetime] NULL,
    [GioiTinh] [nvarchar](3) NULL,
    [DiaChi] [nvarchar](50) NULL,
    [DienThoai] [char](10) NULL,
    [GhiChu] [nvarchar](200) NULL,
    [LoaiNV] [int] NULL,
    [Email] [varchar](50) NULL,
    [TrangThai] [int] NULL,
    [TenTK] [varchar](50) NULL,
    [MatKhau] [varchar](50) NULL,
    PRIMARY KEY CLUSTERED ([MaNV] ASC)
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HoaDonBan](
    [MaHDB] [int] IDENTITY(1,1) NOT NULL,
    [MaKH] [varchar](50) NULL,
    [NgLapHD] [datetime] NULL,
    [TongTienBan] [float] NULL,
    [GhiChu] [nvarchar](200) NULL,
    [MaNVB] [varchar](50) NULL,
    PRIMARY KEY CLUSTERED ([MaHDB] ASC)
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CTHDB](
    [MaSP] [varchar](50) NOT NULL,
    [MaHDB] [int] NOT NULL,
    [SoLuongBan] [int] NULL,
    [ThanhTien] [float] NULL,
    PRIMARY KEY CLUSTERED ([MaSP] ASC, [MaHDB] ASC)
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HoaDonNhap](
    [MaHDN] [int] NOT NULL,
    [MaNCC] [varchar](50) NULL,
    [MaNVN] [varchar](50) NULL,
    [NgayLapHD] [datetime] NULL,
    [TongTienNhap] [float] NULL,
    [GhiChu] [nvarchar](200) NULL,
    PRIMARY KEY CLUSTERED ([MaHDN] ASC)
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CTHDN](
    [MaSP] [varchar](50) NOT NULL,
    [MaHDN] [int] NOT NULL,
    [GiaNhap] [float] NULL,
    [TongTienNhap] [float] NULL,
    [SoLuongNhap] [int] NULL,
    PRIMARY KEY CLUSTERED ([MaSP] ASC, [MaHDN] ASC)
) ON [PRIMARY]
GO

-- Phần FOREIGN KEY và CHECK (sửa tham chiếu MaSP cho đúng)
ALTER TABLE [dbo].[CTHDB] WITH CHECK ADD CONSTRAINT [fk_cthdb_hdb] FOREIGN KEY([MaHDB])
REFERENCES [dbo].[HoaDonBan] ([MaHDB])
GO
ALTER TABLE [dbo].[CTHDB] CHECK CONSTRAINT [fk_cthdb_hdb]
GO
ALTER TABLE [dbo].[CTHDB] WITH CHECK ADD CONSTRAINT [fk_cthdb_sp] FOREIGN KEY([MaSP])
REFERENCES [dbo].[sanpham] ([MaSP])
GO
ALTER TABLE [dbo].[CTHDB] CHECK CONSTRAINT [fk_cthdb_sp]
GO

ALTER TABLE [dbo].[cthdn] WITH CHECK ADD CONSTRAINT [fk_cthdn_hdn] FOREIGN KEY([MaHDN])
REFERENCES [dbo].[HoaDonNhap] ([MaHDN])
GO
ALTER TABLE [dbo].[cthdn] CHECK CONSTRAINT [fk_cthdn_hdn]
GO
ALTER TABLE [dbo].[cthdn] WITH CHECK ADD CONSTRAINT [fk_cthdn_sp] FOREIGN KEY([MaSP])
REFERENCES [dbo].[sanpham] ([MaSP])
GO
ALTER TABLE [dbo].[cthdn] CHECK CONSTRAINT [fk_cthdn_sp]
GO

ALTER TABLE [dbo].[HoaDonBan] WITH CHECK ADD CONSTRAINT [fk_hdb_kh] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBan] CHECK CONSTRAINT [fk_hdb_kh]
GO

ALTER TABLE [dbo].[HoaDonBan] WITH CHECK ADD CONSTRAINT [fk_hdb_nv] FOREIGN KEY([MaNVB])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBan] CHECK CONSTRAINT [fk_hdb_nv]
GO

ALTER TABLE [dbo].[HoaDonNhap] WITH CHECK ADD CONSTRAINT [fk_hdn_ncc] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [fk_hdn_ncc]
GO

ALTER TABLE [dbo].[HoaDonNhap] WITH CHECK ADD CONSTRAINT [fk_hdn_nv] FOREIGN KEY([MaNVN])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [fk_hdn_nv]
GO

ALTER TABLE [dbo].[HoaDonBan] WITH CHECK ADD CHECK (([TongTienBan] >= 0))
GO
ALTER TABLE [dbo].[HoaDonNhap] WITH CHECK ADD CHECK (([TongTienNhap] >= 0))
GO
ALTER TABLE [dbo].[KhachHang] WITH CHECK ADD CHECK (([GioiTinh] = N'Nam' OR [GioiTinh] = N'Nữ'))
GO
ALTER TABLE [dbo].[NhanVien] WITH CHECK ADD CHECK (([GioiTinh] = N'Nam' OR [GioiTinh] = N'Nữ'))
GO
ALTER TABLE [dbo].[NhanVien] WITH CHECK ADD CHECK (([LoaiNV] = 1 OR [LoaiNV] = 2))
GO
ALTER TABLE [dbo].[sanpham] WITH CHECK ADD CHECK (([GiaSP] >= 0))
GO
ALTER TABLE [dbo].[sanpham] WITH CHECK ADD CHECK (([SoLuongCon] >= 0))
GO
ALTER TABLE [dbo].[sanpham] WITH CHECK 
ADD CONSTRAINT [fk_sanpham_ncc] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO