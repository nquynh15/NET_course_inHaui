USE MASTER
GO
IF DB_ID('QLBanHang') IS NOT NULL
	DROP DATABASE QLBanHang
GO

CREATE DATABASE QLBanHang
GO
USE QLBanHang
GO
--DROP TABLE LoaiSanPham

CREATE TABLE LoaiSanPham
(
MaLoai char(10) PRIMARY KEY ,
TenLoai nvarchar(30),
)
INSERT INTO LoaiSanPham VALUES('LSP001', N'Máy tính')
INSERT INTO LoaiSanPham VALUES('LSP002', N'Điện thoại')
INSERT INTO LoaiSanPham VALUES('LSP003', N'Máy chiếu')

--DROP TABLE SanPham
CREATE TABLE SanPham
(
MaSP char(10) PRIMARY KEY,
TenSP nvarchar(30),
MaLoai char(10),
CONSTRAINT FK_LSP_SP FOREIGN KEY(MaLoai)
	REFERENCES LoaiSanPham(MaLoai),
SoLuongCo int,
DonGia float,
)
INSERT INTO SanPham VALUES('SP001', N'HP Insprison', 'LSP001', 18, 7000000)
INSERT INTO SanPham VALUES('SP002', N'SamSung Z22', 'LSP003', 6, 7000000)
INSERT INTO SanPham VALUES('SP003', N'Panisonic Gen10th', 'LSP002', 14, 7000000)

CREATE TABLE HoaDonChiTiet
(
MaHD char(10) PRIMARY KEY,
MaSP char(10),
CONSTRAINT FK_SP_HD FOREIGN KEY(MaSP)
	REFERENCES SanPham(MaSP),
NgayBan Date,
SoLuongMua int,
)

INSERT INTO HoaDonChiTiet VALUES('HD001', 'SP001','08/08/2022', 7)
INSERT INTO HoaDonChiTiet VALUES('HD002', 'SP003', '03/02/2021' , 6)
INSERT INTO HoaDonChiTiet VALUES('HD003', 'SP002', '10/20/2020', 8)

SELECT * FROM LoaiSanPham
SELECT * FROM SanPham
SELECT * FROM HoaDonChiTiet


--SELECT sp.MaSp, TenSp, TenLoai, SoLuongMua, DonGia * SoLuongMua  AS N'Tổng tiền'
--							FROM SanPham sp
--INNER JOIN LoaiSanPham lsp ON sp.MaLoai = lsp.MaLoai
--INNER JOIN HoaDonChiTiet hd ON sp.MaSp = hd.MaSp