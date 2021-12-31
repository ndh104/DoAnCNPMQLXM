/*
Created		25/12/2021
Modified		31/12/2021
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/
Create database QUANLYXEMAY
GO
Use QUANLYXEMAY
GO
Create table [HOADON]
(
	[MAHD] Char(5) NOT NULL,
	[TENHD] Nvarchar(20) NULL,
	[NGAYLAPHD] Datetime NULL,
	[MAKH] Char(5) NOT NULL,
	[MANV] Char(4) NOT NULL,
Primary Key ([MAHD])
) 
go

Create table [LOAIXE]
(
	[MALOAI] Char(5) NOT NULL,
	[TENLOAIXE] Nvarchar(15) NULL,
Primary Key ([MALOAI])
) 
go

Create table [XEMAY]
(
	[MAXE] Char(5) NOT NULL,
	[TENXE] Nvarchar(20) NULL,
	[GIABAN] Money NULL,
	[MAUSAC] Nvarchar(15) NULL,
	[DUNGTICH] Char(6) NULL,
	[TINHTRANG] Nvarchar(3) NULL,
	[MALOAI] Char(5) NOT NULL,
	[MANCC] Char(5) NOT NULL,
Primary Key ([MAXE])
) 
go

Create table [NHACUNGCAP]
(
	[MANCC] Char(5) NOT NULL,
	[TENNCC] Nvarchar(30) NULL,
	[DIACHI] Nvarchar(50) NULL,
	[SDT] Nvarchar(11) NULL,
Primary Key ([MANCC])
) 
go

Create table [KHACHHANG]
(
	[MAKH] Char(5) NOT NULL,
	[TENKH] Nvarchar(30) NULL,
	[SDT] Nvarchar(11) NULL,
	[DIACHI] Nvarchar(50) NULL,
	[NGAYSINH] Datetime NULL,
Primary Key ([MAKH])
) 
go

Create table [CHITIETHOADON]
(
	[MAHD] Char(5) NOT NULL,
	[MAXE] Char(5) NOT NULL,
	[SOLUONG] Integer NULL,
	[DONGIA] Numeric(18,0) NULL,
Primary Key ([MAHD],[MAXE])
) 
go

Create table [NHANVIEN]
(
	[MANV] Char(4) NOT NULL,
	[TENNV] Nvarchar(30) NULL,
	[GIOITINH] Nvarchar(3) NULL,
	[NGAYSINH] Datetime NULL,
	[DIACHI] Nvarchar(50) NULL,
	[CMND] Nvarchar(15) NULL,
	[SDT] Nvarchar(11) NULL,
	[CHUCVU] Nvarchar(20) NULL,
	[USERNAME] Nvarchar(10) NULL,
	[PASSWORD] Nvarchar(10) NULL,
Primary Key ([MANV])
) 
go


Alter table [CHITIETHOADON] add  foreign key([MAHD]) references [HOADON] ([MAHD])  on update no action on delete no action 
go
Alter table [XEMAY] add  foreign key([MALOAI]) references [LOAIXE] ([MALOAI])  on update no action on delete no action 
go
Alter table [CHITIETHOADON] add  foreign key([MAXE]) references [XEMAY] ([MAXE])  on update no action on delete no action 
go
Alter table [XEMAY] add  foreign key([MANCC]) references [NHACUNGCAP] ([MANCC])  on update no action on delete no action 
go
Alter table [HOADON] add  foreign key([MAKH]) references [KHACHHANG] ([MAKH])  on update no action on delete no action 
go
Alter table [HOADON] add  foreign key([MANV]) references [NHANVIEN] ([MANV])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


