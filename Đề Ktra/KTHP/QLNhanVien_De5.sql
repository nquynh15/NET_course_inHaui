CREATE DATABASE QLNhanVien_De5
GO
USE QLNhanVien_De5
GO

--DROP TABLE NhanVien
CREATE TABLE NhanVien2
(
MaNV char(10) PRIMARY KEY,
HoTen nvarchar(30),
NgayTuyenDung Date,
SoNgayLamViec int,
GioiTinh nvarchar(10),
)
GO
INSERT INTO NhanVien2 VALUES('NV001', N'Nguyễn Ngọc','10/20/2020',20, N'Nữ')
INSERT INTO NhanVien2 VALUES('NV002', N'Phạm Bình','12/09/2021',28, N'Nam')
INSERT INTO NhanVien2 VALUES('NV003', N'Trần Hà','08/18/2020',26, N'Nữ')
GO

DROP DATABASE QLNhanVien

SELECT * FROM NhanVien2
