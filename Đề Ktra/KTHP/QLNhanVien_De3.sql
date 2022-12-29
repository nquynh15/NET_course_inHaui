﻿CREATE DATABASE QLNhanVien
GO
USE QLNhanVien
GO

DROP TABLE NhanVien
CREATE TABLE NhanVien1
(
MaNV char(10) PRIMARY KEY,
HoTen nvarchar(30),
NgaySinh Date,
SoTienBan int,
)
GO
INSERT INTO NhanVien1 VALUES('NV001', N'Nguyễn Ngọc','10/20/2000',2130000)
INSERT INTO NhanVien1 VALUES('NV002', N'Phạm Bình','12/09/1999',3240000)
INSERT INTO NhanVien1 VALUES('NV003', N'Trần Hà','08/18/2001',2400000)
GO

DROP DATABASE QLNhanVien

SELECT * FROM NhanVien1
