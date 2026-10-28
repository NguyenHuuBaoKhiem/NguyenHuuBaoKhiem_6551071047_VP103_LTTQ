USE DuLieu;
GO
CREATE TABLE dbo.CongViec(
	MaSach nvarchar(15) Primary Key,
	TenSach nText not null,
	GiaTien nvarchar(12) not null
);
Go

Insert into dbo.CongViec (MaSach, TenSach, GiaTien) Values
(N'S000',N'Test', 10);
select * from CongViec