create database QLNS
go

use QLNS
set dateformat DMY
go

create table HOADON
(
	MAHOADON char(7) primary key not null,
	TENKHACHHANG nvarchar(50),
	NGAYLAP datetime,
	TONGTIEN decimal(10, 2) 
)

create table CHITIETHOADON
(
	MAHOADON char(7) not null,
	MASACH char(7),
	SOLUONG int,
	GIATIEN int,
	THANHTIEN int
)


create table LOAISACH
(
	MALOAISACH char(7) primary key not null,
	TENLOAISACH nvarchar(30) 
)
go

create table NHAXUATBAN
(
	MANXB char(7) primary key not null,
	TENNHAXUATBAN nvarchar(50)
)
go

create table SACH
(
	MASACH char(7) primary key not null,
	SOLUONG int,
	TENSACH nvarchar(100),
	MATG char(7) not null,
	MALOAISACH char(7),
	GIABAN int,
	GIANHAP int,
	LANTAIBAN int,
	MANXB char(7),
	NAMXUATBAN int
)
go

create table TACGIA
(
    MATG char(7) primary key not null,
	TENTG nvarchar(40),
)
go

create table TAIKHOAN
(
    USERNAME varchar(20) primary key not null,
	PASS_WORD varchar(100)
)
go
INSERT INTO TAIKHOAN VALUES ('admin', 'admin');
Select * from TAIKHOAN Where USERNAME = 'admin' and PASS_WORD = 'admin'

CREATE PROC USP_Login
@username nvarchar(20), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM TAIKHOAN WHERE USERNAME = @username AND PASS_WORD = @password
END
GO



--Thêm khóa ngoại
alter table CHITIETHOADON add constraint FK_CHITIETHOADON_HOADON foreign key(MAHOADON) references HOADON(MAHOADON)
alter table CHITIETHOADON add constraint FK_CHITIETHOADON_SACH foreign key(MASACH) references SACH(MASACH)
alter table SACH add constraint FK_SACH_LOAISACH foreign key(MALOAISACH) references LOAISACH(MALOAISACH)
alter table SACH add constraint FK_SACH_TACGIA foreign key(MATG) references TACGIA(MATG)
alter table SACH add constraint FK_SACH_NHAXUATBAN foreign key(MANXB) references NHAXUATBAN(MANXB)

INSERT INTO TACGIA (MATG, TENTG)
VALUES
('TG001', N'Nguyễn Nhật Ánh'),
('TG002', N'J.K. Rowling'),
('TG003', N'George Orwell'),
('TG004', N'Haruki Murakami'),
('TG005', N'Yuval Noah Harari');

INSERT INTO NHAXUATBAN (MANXB, TENNHAXUATBAN)
VALUES
('NXB001', N'Kim Đồng'),
('NXB002', N'Trẻ'),
('NXB003', N'Giáo Dục'),
('NXB004', N'Hội Nhà Văn'),
('NXB005', N'Lao Động');

INSERT INTO LOAISACH (MALOAISACH, TENLOAISACH)
VALUES
('LS001', N'Tiểu thuyết'),
('LS002', N'Khoa học'),
('LS003', N'Lịch sử'),
('LS004', N'Công nghệ'),
('LS005', N'Nghệ thuật');

INSERT INTO SACH (MASACH, SOLUONG, TENSACH, MATG, MALOAISACH, GIABAN, GIANHAP, LANTAIBAN, MANXB, NAMXUATBAN)
VALUES
('S001', 10, 'Harry Potter', 'TG002', 'LS001', 200000, 150000, 5, 'NXB002', 1997),
('S002', 10, '1984', 'TG003', 'LS003', 180000, 140000, 3, 'NXB003', 1949),
('S003', 10, 'Kafka on the Shore', 'TG004', 'LS001', 220000, 180000, 2, 'NXB001', 2002),
('S004',  10,'Sapiens', 'TG005', 'LS003', 250000, 200000, 4, 'NXB005', 2011),
('S005', 10, 'Mat Biec', 'TG001', 'LS001', 150000, 120000, 6, 'NXB004', 1990);


