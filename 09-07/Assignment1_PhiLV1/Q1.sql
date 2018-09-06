USE BanHang
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='KhachHang')
BEGIN
     drop table DonHang
END
GO
--Create table KhachHang--
CREATE TABLE KhachHang(
	MaKH			int IDENTITY(1,1) PRIMARY KEY
,	TenKH			nvarchar(50) NOT NULL
,	PhoneNo			Date		NOT NULL
,	GhiChu			nvarchar(max)
	
)
GO


USE BanHang
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='SanPham')
BEGIN
     drop table SanPham
END
GO
--Create table KhachHang--
CREATE TABLE SanPham(
	MaSP			int IDENTITY(1,1) PRIMARY KEY
,	TenSP			nvarchar(50) NOT NULL
,	DonGia			Date		NOT NULL
)
GO

USE BanHang
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='DonHang')
BEGIN
     drop table DonHang
END
GO
--Create table DonHang--
CREATE TABLE DonHang(
	MaDH			int IDENTITY(1,1) PRIMARY KEY
,	NgayDH			Date NOT NULL
,	MaSP			int	NOT NULL
,	SoLuong			int	NOT NULL
,	MaKH			int
	FOREIGN KEY (MaSP) REFERENCES SanPham (MaSP)
,	FOREIGN KEY (MaKH) REFERENCES KhachHang (MaKH)
)
GO



CREATE VIEW view_ThongTin AS
	SELECT h.TenKH, d.NgayDH,s.TenSP, d.SoLuong, d.SoLuong*s.DonGia as ThanhTien
	from SanPham s,KhachHang h, DonHang d
	Where d.MaKH = h.MaKH AND d.MaSP = s.MaSP
		
		
