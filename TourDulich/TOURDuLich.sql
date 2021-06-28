CREATE DATABASE TOUR_DULICH
USE TOUR_DULICH
GO
CREATE TABLE KHACH_HANG
(
	MaKH char(20) NOT NULL,
	TenKH nvarchar(50) NULL,
	DiaChi nvarchar(50) NULL,
	GioiTinh nvarchar(3) NULL,
	SDT int NULL,
	CONSTRAINT PK_KH PRIMARY KEY (MaKH)
);

CREATE TABLE NHAN_VIEN
(
	MaNV char(20) NOT NULL,
	TenNV nvarchar(50) NULL,
	GioiTinh nvarchar(5) NULL,
    Luong int,
    ChucVu nvarchar(50),
	DiaChi nvarchar(50) NULL,
	SDT int NULL,
	NgaySinh date NULL,
	CONSTRAINT PK_NV PRIMARY KEY (MaNV)
 );

CREATE TABLE TAI_KHOAN
(
    TenDangNhap nvarchar(50) NOT NULL,
    MatKhau nvarchar(50) NULL,
	Email nvarchar(100) NULL,
    CONSTRAINT PK_TK PRIMARY KEY (TenDangNhap)
);


CREATE TABLE VE_MAY_BAY
(
	MaVe char(20) NOT NULL,
	MaKH char(20) NOT NULL,
	TenKH nvarchar(30),
	DiemKhoiHanh nvarchar(100),
	DiemDen nvarchar(100),
	NgayDi date,
	NgayVe date,
	SoHanhKhach int,
	HangGhe nvarchar(40),
	Tongtien int,
	CONSTRAINT PK_TAIKHOAN PRIMARY KEY (MaVe),
	CONSTRAINT FK_VEMB_KH FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH)
);
CREATE TABLE KS
(
  TENKS NVARCHAR(50)
  PRIMARY KEY(TENKS)
)
CREATE TABLE KHACH_SAN
(
	MaKS char(20) NOT NULL,
	TenKS nvarchar(100),
	NgayNhanPhong date NULL,
	NgayTraPhong date NULL,
	SoPhong int,
	SoNgayO int,
	KhachTrenMotPhong int,
	MaKH char(20),
	tongtien int,
	CONSTRAINT PK_KS PRIMARY KEY (MaKS),
	CONSTRAINT FK_KS_KH FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH)
);

CREATE TABLE CHITIET_CHUYENBAY
(	
	MaVe char(20) NOT NULL,
	DiemKhoiHanh nvarchar(100),
	DiemDen nvarchar(100),
	SoHanhKhach int,
	NgayDi date,
	Ngayve date,
	HangGhe	nvarchar(20),
	tongtien int,
	CONSTRAINT FK_CTCB_MB FOREIGN KEY (MaVe) REFERENCES VE_MAY_BAY(MaVe)
);

CREATE TABLE CHITIET_KHACHSAN
(
	MaKS char(20) NOT NULL,
	TenKS nvarchar(30) NOT NULL,
	NgayNhanPhong date NULL,
	NgayTraPhong date NULL,
	SoHanhKhach int,
	SoPhong int,
	tongtien int,
	CONSTRAINT FK_CTKS_KS FOREIGN KEY (MaKS) REFERENCES KHACH_SAN(MaKS)
);

CREATE TABLE SAN_BAY
(
	MaSB char(20) NOT NULL,
	TenSB nvarchar(100),
	DiaChi nvarchar(100),
	SDT int,
	CONSTRAINT PK_SB PRIMARY KEY (MaSB)
);

CREATE TABLE DUA_DOAN_SAN_BAY
(
	MaSB char(20) NOT NULL,
	TuDiaDiem nvarchar(100),
	DenDiaDiem nvarchar(100),
	NgayDon date,
	GioDoan char(50),
	MaKH char(20),
	tongtien int,
	CONSTRAINT FK_SB_KH FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH),
	CONSTRAINT FK_DDSB_SB FOREIGN KEY (MaSB) REFERENCES SAN_BAY(MaSB),
	CONSTRAINT PK_Masb PRIMARY KEY (MaSB,MaKH)	
);

CREATE TABLE THUE_XE
(
	MaXe char(20) NOT NULL,
	LoaiXe nvarchar(20),
	DiaDiemThueXe nvarchar(100),
	NgayBatDau date,
	GioBatDau date,
	NgayKetThuc date,
	GioKetThuc date,
	CONSTRAINT PK_TX PRIMARY KEY (MaXe)
);

CREATE TABLE JRPASS
(
	MaJR char(20) NOT NULL,
	TenJR nvarchar(20),
	MoTa nvarchar(100),
	GiaTien int,
	CONSTRAINT PK_JR PRIMARY KEY (MaJR)
);
CREATE TABLE TOUR
(
   MAT NCHAR(10) NOT NULL,
   TENT NVARCHAR(30) NOT NULL,
   CONSTRAINT PK_T PRIMARY KEY (MAT,TENT)
)
ALTER TABLE TOUR
ADD CONSTRAINT FK_T FOREIGN KEY(TENT) REFERENCES DATTOUR(TENT)
CREATE TABLE DATTOUR
(
   MAVET NCHAR(10) NOT NULL,
   TENT NVARCHAR(30),
   TIENT INT,
   MaKH CHAR(20),
   CONSTRAINT PK_DT PRIMARY KEY (MAVET),
   CONSTRAINT FK_DT_KH FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH)
   )
CREATE TABLE HOA_DON
(
	MaHD char(20) NOT NULL,
	MaKH char(20) NOT NULL,
	SoLuongVe int NULL,
	Loaive nvarchar(30),
	NgayLap date,
	TongTien int,
	CONSTRAINT PK_HD PRIMARY KEY (MaHD),
	CONSTRAINT FK_HD_KH FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH),
);

CREATE TABLE CHITIET_HOADON
(
	MaHD char(20) NOT NULL,
	MaVe char(20) NOT NULL,
	SoLuong int NULL,
    DonGia integer NULL,
	GiamGia integer NULL,
	ThanhTien integer NULL,
	CONSTRAINT PK_CTHD PRIMARY KEY(MaHD, MaVe),
	CONSTRAINT PK_CTHD_HD FOREIGN KEY (MaHD) REFERENCES HOA_DON(MaHD),
	CONSTRAINT FK_CTHD_VEMB FOREIGN KEY (MaVe) REFERENCES VE_MAY_BAY(MaVe)
 );
 CREATE TABLE ADMIN
 (
   username nchar(10) not null,
   password nchar(20),
   primary key(username)
 )
 INSERT INTO ADMIN
 VALUES('admin','12345')
-----------------------------------------------------------------------------------------------
-----------------------------------RÀNG BUỘC TOÀN VẸN------------------------------------------

--Trong bảng khách hàng thì giới tính sẽ là nam hoặc nữ
        ALTER TABLE KHACH_HANG
        ADD CONSTRAINT CK_GioiTinh CHECK (GioiTinh = N'Nam' OR  GioiTinh =N'Nữ');

--Trong bảng hóa đơn số lượng vé phải lớn hơn 0    
        ALTER TABLE HOA_DON
		ADD CONSTRAINT CK_SoLuongVe  CHECK (SoLuongVe > 0);

--Trong bảng Vé máy bay mỗi mã vé phải có tên khách hàng riêng biệt
        ALTER TABLE VE_MAY_BAY
		ADD CONSTRAINT UNI_TenKH UNIQUE (TenKH);

--Trong bảng Khách hàng có mã khách hàng chỉ sử dụng được cho duy nhất một khách hàng
        ALTER TABLE KHACH_HANG
		ADD CONSTRAINT UNI_MaKH UNIQUE (MaKH);
-----------------------------------------------------------------------------------------------
-------------------------------------- NHẬP LIỆU ----------------------------------------------
--Bảng Khách hàng
INSERT INTO KHACH_HANG(MaKH, TenKH, DiaChi, GioiTinh, SDT) VALUES ('KH01',N'Nguyễn Thị Mai',  N'Tân Phú,  HCM', N'Nữ',093568266);
INSERT INTO KHACH_HANG(MaKH, TenKH, DiaChi, GioiTinh, SDT) VALUES ('KH02',N'Trần Văn Cảnh',   N'Tân Bình, HCM', N'Nam',096518261);
INSERT INTO KHACH_HANG(MaKH, TenKH, DiaChi, GioiTinh, SDT) VALUES ('KH03',N'Hoàng Thị An',    N'Bình Tân, HCM', N'Nữ',093345663);
INSERT INTO KHACH_HANG(MaKH, TenKH, DiaChi, GioiTinh, SDT) VALUES ('KH04',N'Trần Văn Lãm',    N'Tân Bình, HCM', N'Nam',096518261);
INSERT INTO KHACH_HANG(MaKH, TenKH, DiaChi, GioiTinh, SDT) VALUES ('KH05',N'Nguyễn Thị Kiều', N'Tân Phú,  HCM', N'Nữ',093568266);
INSERT INTO KHACH_HANG(MaKH, TenKH, DiaChi, GioiTinh, SDT) VALUES ('KH06',N'Trần Ngọc Ngân',  N'Tân Bình, HCM', N'Nữ',096518261);
INSERT INTO KHACH_HANG(MaKH, TenKH, DiaChi, GioiTinh, SDT) VALUES ('KH07',N'Nguyễn Huy Hoàng',N'Tân Phú,  HCM', N'Nam',093568266);
INSERT INTO KHACH_HANG(MaKH, TenKH, DiaChi, GioiTinh, SDT) VALUES ('KH08',N'Trần Văn Trị',    N'Tân Bình, HCM', N'Nữ',096518261);
INSERT INTO KHACH_HANG(MaKH, TenKH, DiaChi, GioiTinh, SDT) VALUES ('KH09',N'Phan Đình Phùng', N'Tân Phú,  HCM', N'Nam',093568266);
INSERT INTO KHACH_HANG(MaKH, TenKH, DiaChi, GioiTinh, SDT) VALUES ('KH10',N'Phạm Gia Hân',    N'Tân Bình, HCM', N'Nữ',096518261);
SELECT *FROM KHACH_HANG;

--Bảng nhân viên
set DATEFORMAT dmy;
  
INSERT INTO NHAN_VIEN (MaNV, TenNV, GioiTinh, Luong, ChucVu, DiaChi, SDT, NgaySinh)  VALUES ('NV01',N'Nguyễn Hoàng Anh Thư',N'Nữ',5500000,N'Nhân viên',N'Tân Phú, TPHCM',0927352718,'12-09-1998');
INSERT INTO NHAN_VIEN (MaNV, TenNV, GioiTinh, Luong, ChucVu, DiaChi, SDT, NgaySinh)  VALUES ('NV02',N'Nguyễn Hoàng Nam',N'Nam',1500000,N'Quản lý',N'Tân Bình, TPHCM',0927352718,'19-12-1997');
INSERT INTO NHAN_VIEN (MaNV, TenNV, GioiTinh, Luong, ChucVu, DiaChi, SDT, NgaySinh)  VALUES ('NV03',N'Lê Ngọc Mai',N'Nữ',7500000,N'Nhân viên',N'Thủ Đức, TPHCM',0927352718,'22-08-1997');
INSERT INTO NHAN_VIEN (MaNV, TenNV, GioiTinh, Luong, ChucVu, DiaChi, SDT, NgaySinh)  VALUES ('NV04',N'Hoàng Thùy Dung',N'Nữ',8500000,N'Nhân viên',N'Bình Chánh, TPHCM',0927352718,'25-06-2000');
INSERT INTO NHAN_VIEN (MaNV, TenNV, GioiTinh, Luong, ChucVu, DiaChi, SDT, NgaySinh)  VALUES ('NV05',N'Trần Hùng Hưng',N'Nam',9000000,N'Nhân viên',N'Quận 1, TPHCM',0927352718,'12-06-1997');
INSERT INTO NHAN_VIEN (MaNV, TenNV, GioiTinh, Luong, ChucVu, DiaChi, SDT, NgaySinh)  VALUES ('NV06',N'Nguyễn Hoàng Anh Ngọc',N'Nữ',7500000,N'Nhân viên',N'Tân Bình, TPHCM',0927352718,'29-07-1999');
INSERT INTO NHAN_VIEN (MaNV, TenNV, GioiTinh, Luong, ChucVu, DiaChi, SDT, NgaySinh)  VALUES ('NV07',N'Nguyễn An Tính',N'Nam',6500000,N'Nhân viên',N'Phú Nhu?n, TPHCM',0927352718,'28-12-1996');
INSERT INTO NHAN_VIEN (MaNV, TenNV, GioiTinh, Luong, ChucVu, DiaChi, SDT, NgaySinh)  VALUES ('NV08',N'Lê Thị Hoàng Anh',N'Nữ',5500000,N'Nhân viên',N'Thủ Đức, TPHCM',0927352718,'22-10-1999');
INSERT INTO NHAN_VIEN (MaNV, TenNV, GioiTinh, Luong, ChucVu, DiaChi, SDT, NgaySinh)  VALUES ('NV09',N'Hoàng Mai Anh',N'Nữ',7000000,N'Nhân viên',N'Bình Chánh, TPHCM',0927352718,'27-02-2001');
INSERT INTO NHAN_VIEN (MaNV, TenNV, GioiTinh, Luong, ChucVu, DiaChi, SDT, NgaySinh)  VALUES ('NV10',N'Trần Thanh Dũng',N'Nam',6500000,N'Nhân viên',N'Quận 1, TPHCM',0927352718,'12-05-1996');
SELECT *FROM NHAN_VIEN;

--Tài khoản
INSERT INTO TAI_KHOAN VALUES('duynguyen',N'12345','thaoduy.ck@gmail.com')
INSERT INTO TAI_KHOAN VALUES(N'duy2807',N'12345',N'thaoduy.dk@gmail.com')
SELECT *FROM TAI_KHOAN 
--Vé máy bay
SET DATEFORMAT DMY
INSERT INTO VE_MAY_BAY(MaVe, MaKH, TenKH, DiemKhoiHanh, DiemDen, NgayDi,NgayVe, SoHanhKhach, HangGhe,Tongtien) 
VALUES ('MV0','KH01', N'Nguyễn Thị Mai',	 N'Hồ Chí Minh', N'Hà Nội', '13/03/2020','14/03/2020',1, N'Phổ Thông',10000000);
INSERT INTO VE_MAY_BAY(MaVe, MaKH, TenKH, DiemKhoiHanh, DiemDen, NgayDi,NgayVe, SoHanhKhach, HangGhe,Tongtien) 
VALUES ('MV1','KH02', N'Trần Văn Cảnh',		 N'Hồ Chí Minh', N'Hà Nội', '13/03/2020','14/03/2020', 1, N'Thương Gia',13000000);
INSERT INTO VE_MAY_BAY(MaVe, MaKH, TenKH, DiemKhoiHanh, DiemDen, NgayDi,NgayVe, SoHanhKhach, HangGhe,Tongtien) 
VALUES ('MV2','KH03', N'Hoàng Thị An',		 N'Hồ Chí Minh', N'Hà Nội', '13/03/2020','14/03/2020', 1, N'Hạng Nhất',9000000);
INSERT INTO VE_MAY_BAY(MaVe, MaKH, TenKH, DiemKhoiHanh, DiemDen, NgayDi,NgayVe, SoHanhKhach, HangGhe,Tongtien) 
VALUES ('MV3','KH04', N'Trần Văn Lãm',		 N'Hồ Chí Minh', N'Hà Nội', '13/03/2020','14/03/2020', 1, N'Đặc Biệt',8000000);
INSERT INTO VE_MAY_BAY(MaVe, MaKH, TenKH, DiemKhoiHanh, DiemDen, NgayDi,NgayVe, SoHanhKhach, HangGhe,Tongtien) 
VALUES ('MV4','KH05', N'Nguyễn Thị Kiều',	 N'Hồ Chí Minh', N'Hà Nội', '13/03/2020','14/03/2020', 1, N'Phổ Thông',7000000);
INSERT INTO VE_MAY_BAY(MaVe, MaKH, TenKH, DiemKhoiHanh, DiemDen, NgayDi,NgayVe, SoHanhKhach, HangGhe,Tongtien) 
VALUES ('MV5','KH06', N'Trần Ngọc Ngân',	 N'Hồ Chí Minh', N'Hà Nội', '13/03/2020','14/03/2020', 1, N'Thương Gia',6000000);
INSERT INTO VE_MAY_BAY(MaVe, MaKH, TenKH, DiemKhoiHanh, DiemDen, NgayDi,NgayVe, SoHanhKhach, HangGhe,Tongtien) 
VALUES ('MV6','KH07', N'Nguyễn Huy Hoàng',	 N'Hồ Chí Minh', N'Hà Nội', '13/03/2020','14/03/2020', 1, N'Hạng Nhất',8000000);
INSERT INTO VE_MAY_BAY(MaVe, MaKH, TenKH, DiemKhoiHanh, DiemDen, NgayDi,NgayVe, SoHanhKhach, HangGhe,Tongtien) 
VALUES ('MV7','KH08', N'Trần Văn Trị',		 N'Hồ Chí Minh', N'Hà Nội', '13/03/2020','14/03/2020', 1, N'Đặc Biệt',6000000);
INSERT INTO VE_MAY_BAY(MaVe, MaKH, TenKH, DiemKhoiHanh, DiemDen, NgayDi,NgayVe, SoHanhKhach, HangGhe,Tongtien) 
VALUES ('MV8','KH09', N'Phan Đình Phùng',	 N'Hồ Chí Minh', N'Hà Nội', '13/03/2020','14/03/2020', 1, N'Phổ Thông',8000000);
INSERT INTO VE_MAY_BAY(MaVe, MaKH, TenKH, DiemKhoiHanh, DiemDen, NgayDi,NgayVe, SoHanhKhach, HangGhe,Tongtien) 
VALUES ('MV9','KH10',N'Phạm Gia Hân'        ,N'Hồ Chí Minh', N'Hà Nội', '13/03/2020','14/03/2020', 1, N'Phổ Thông',4000000);
SELECT*FROM VE_MAY_BAY
--Khách sạn
INSERT INTO KHACH_SAN(MaKS, TenKS, NgayNhanPhong, NgayTraPhong,SoPhong, SoNgayO, KhachTrenMotPhong,MaKH,tongtien) VALUES ('KS0',N'Thiên Ân',   '12/03/2020', '12/04/2020','1001',10, 1,'KH01',3000000);
INSERT INTO KHACH_SAN(MaKS, TenKS, NgayNhanPhong, NgayTraPhong,SoPhong, SoNgayO, KhachTrenMotPhong,MaKH,tongtien) VALUES ('KS1',N'Hồng Đức',   '12/03/2020', '12/04/2020','1002',10, 1,'KH02',3000000);
INSERT INTO KHACH_SAN(MaKS, TenKS, NgayNhanPhong, NgayTraPhong,SoPhong, SoNgayO, KhachTrenMotPhong,MaKH,tongtien) VALUES ('KS2',N'Hoàng Nam',  '12/03/2020', '12/04/2020','1003',10, 1,'KH03',3000000);
INSERT INTO KHACH_SAN(MaKS, TenKS, NgayNhanPhong, NgayTraPhong,SoPhong,SoNgayO, KhachTrenMotPhong,MaKH,tongtien) VALUES ('KS3',N'Vũ Hạnh',    '12/03/2020', '12/04/2020','1004',10, 1,'KH04',3000000);
INSERT INTO KHACH_SAN(MaKS, TenKS, NgayNhanPhong, NgayTraPhong,SoPhong, SoNgayO, KhachTrenMotPhong,MaKH,tongtien) VALUES ('KS4',N'Nhật Hàn',   '12/03/2020', '12/04/2020','1005',10, 1,'KH05',3000000);
INSERT INTO KHACH_SAN(MaKS, TenKS, NgayNhanPhong, NgayTraPhong,SoPhong, SoNgayO, KhachTrenMotPhong,MaKH,tongtien) VALUES ('KS5',N'Minh Trung', '12/03/2020', '12/04/2020','1006',10, 1,'KH06',3000000);
INSERT INTO KHACH_SAN(MaKS, TenKS, NgayNhanPhong, NgayTraPhong,SoPhong, SoNgayO, KhachTrenMotPhong,MaKH,tongtien) VALUES ('KS6',N'Đại Sơn',    '12/03/2020', '12/04/2020','1007',10, 1,'KH07',3000000);
INSERT INTO KHACH_SAN(MaKS, TenKS, NgayNhanPhong, NgayTraPhong,SoPhong, SoNgayO, KhachTrenMotPhong,MaKH,tongtien) VALUES ('KS7',N'Hành Ca',    '12/03/2020', '12/04/2020','1008',10, 1,'KH08',3000000);
INSERT INTO KHACH_SAN(MaKS, TenKS, NgayNhanPhong, NgayTraPhong,SoPhong, SoNgayO, KhachTrenMotPhong,MaKH,tongtien) VALUES ('KS8',N'Lộc Nam',    '12/03/2020', '12/04/2020','1009',10, 1,'KH09',3000000);
INSERT INTO KHACH_SAN(MaKS, TenKS, NgayNhanPhong, NgayTraPhong,SoPhong, SoNgayO, KhachTrenMotPhong,MaKH,tongtien) VALUES ('KS9',N'Hoàng Nhiên','12/03/2020', '12/04/2020','1010',10, 1,'KH10',3000000);
SELECT*FROM KHACH_SAN
--Chi tiết chuyến bay
INSERT INTO CHITIET_CHUYENBAY(MaVe, DiemKhoiHanh, DiemDen, SoHanhKhach, NgayDi, HangGhe) VALUES('MV01', N'HCM', N'HÀ NỘI', 1, '13/03/2020', N'PHỔ THÔNG')
INSERT INTO CHITIET_CHUYENBAY(MaVe, DiemKhoiHanh, DiemDen, SoHanhKhach, NgayDi, HangGhe) VALUES('MV02', N'HCM', N'HÀ NỘI', 1, '13/03/2020', N'PHỔ THÔNG')
INSERT INTO CHITIET_CHUYENBAY(MaVe, DiemKhoiHanh, DiemDen, SoHanhKhach, NgayDi, HangGhe) VALUES('MV03', N'HCM', N'HÀ NỘI', 1, '13/03/2020', N'PHỔ THÔNG')
INSERT INTO CHITIET_CHUYENBAY(MaVe, DiemKhoiHanh, DiemDen, SoHanhKhach, NgayDi, HangGhe) VALUES('MV04', N'HCM', N'HÀ NỘI', 1, '13/03/2020', N'PHỔ THÔNG')
INSERT INTO CHITIET_CHUYENBAY(MaVe, DiemKhoiHanh, DiemDen, SoHanhKhach, NgayDi, HangGhe) VALUES('MV05', N'HCM', N'HÀ NỘI', 1, '13/03/2020', N'PHỔ THÔNG')
INSERT INTO CHITIET_CHUYENBAY(MaVe, DiemKhoiHanh, DiemDen, SoHanhKhach, NgayDi, HangGhe) VALUES('MV06', N'HCM', N'HÀ NỘI', 1, '13/03/2020', N'PHỔ THÔNG')
INSERT INTO CHITIET_CHUYENBAY(MaVe, DiemKhoiHanh, DiemDen, SoHanhKhach, NgayDi, HangGhe) VALUES('MV07', N'HCM', N'HÀ NỘI', 1, '13/03/2020', N'PHỔ THÔNG')
INSERT INTO CHITIET_CHUYENBAY(MaVe, DiemKhoiHanh, DiemDen, SoHanhKhach, NgayDi, HangGhe) VALUES('MV08', N'HCM', N'HÀ NỘI', 1, '13/03/2020', N'PHỔ THÔNG')
INSERT INTO CHITIET_CHUYENBAY(MaVe, DiemKhoiHanh, DiemDen, SoHanhKhach, NgayDi, HangGhe) VALUES('MV09', N'HCM', N'HÀ NỘI', 1, '13/03/2020', N'PHỔ THÔNG')
INSERT INTO CHITIET_CHUYENBAY(MaVe, DiemKhoiHanh, DiemDen, SoHanhKhach, NgayDi, HangGhe) VALUES('MV10', N'HCM', N'HÀ NỘI', 1, '13/03/2020', N'PHỔ THÔNG')
SELECT*FROM CHITIET_CHUYENBAY
--Chi tiết khách sạn
INSERT INTO CHITIET_KHACHSAN(MaKS, NgayNhanPhong, NgayTraPhong, SoHanhKhach, SoPhong) VALUES('KS01','12/03/2020', '12/04/2020', 2, 1001);
INSERT INTO CHITIET_KHACHSAN(MaKS, NgayNhanPhong, NgayTraPhong, SoHanhKhach, SoPhong) VALUES('KS02','12/03/2020', '12/04/2020', 2, 1002);
INSERT INTO CHITIET_KHACHSAN(MaKS, NgayNhanPhong, NgayTraPhong, SoHanhKhach, SoPhong) VALUES('KS03','12/03/2020', '12/04/2020', 2, 1003);
INSERT INTO CHITIET_KHACHSAN(MaKS, NgayNhanPhong, NgayTraPhong, SoHanhKhach, SoPhong) VALUES('KS04','12/03/2020', '12/04/2020', 2, 1004);
INSERT INTO CHITIET_KHACHSAN(MaKS, NgayNhanPhong, NgayTraPhong, SoHanhKhach, SoPhong) VALUES('KS05','12/03/2020', '12/04/2020', 2, 1005);
INSERT INTO CHITIET_KHACHSAN(MaKS, NgayNhanPhong, NgayTraPhong, SoHanhKhach, SoPhong) VALUES('KS06','12/03/2020', '12/04/2020', 2, 1006);
INSERT INTO CHITIET_KHACHSAN(MaKS, NgayNhanPhong, NgayTraPhong, SoHanhKhach, SoPhong) VALUES('KS07','12/03/2020', '12/04/2020', 2, 1007);
INSERT INTO CHITIET_KHACHSAN(MaKS, NgayNhanPhong, NgayTraPhong, SoHanhKhach, SoPhong) VALUES('KS08','12/03/2020', '12/04/2020', 2, 1008);
INSERT INTO CHITIET_KHACHSAN(MaKS, NgayNhanPhong, NgayTraPhong, SoHanhKhach, SoPhong) VALUES('KS09','12/03/2020', '12/04/2020', 2, 1009);
INSERT INTO CHITIET_KHACHSAN(MaKS, NgayNhanPhong, NgayTraPhong, SoHanhKhach, SoPhong) VALUES('KS10','12/03/2020', '12/04/2020', 2, 1000);
SELECT*FROM CHITIET_KHACHSAN
--sân bay
INSERT INTO SAN_BAY(MaSB, TenSB, DiaChi, SDT) VALUES('SB01',N'Nội bài',N'Hà Nội',		  098364636);
INSERT INTO SAN_BAY(MaSB, TenSB, DiaChi, SDT) VALUES('SB02',N'Đà Nẵng',N'Đà Nẵng',		  098364636);
INSERT INTO SAN_BAY(MaSB, TenSB, DiaChi, SDT) VALUES('SB03',N'Tân Sơn Nhất',N'HCM',		  098565433);
INSERT INTO SAN_BAY(MaSB, TenSB, DiaChi, SDT) VALUES('SB04',N'Phú Bài',N'Huế',			  086554333);
INSERT INTO SAN_BAY(MaSB, TenSB, DiaChi, SDT) VALUES('SB05',N'Phú Quốc',N'Kiêng Giang',   083434766);
INSERT INTO SAN_BAY(MaSB, TenSB, DiaChi, SDT) VALUES('SB06',N'Cần Thơ',N'Cần Thơ',	      091346576);
INSERT INTO SAN_BAY(MaSB, TenSB, DiaChi, SDT) VALUES('SB07',N'Điện biên Phủ',N'Điện Biên',098343654);
INSERT INTO SAN_BAY(MaSB, TenSB, DiaChi, SDT) VALUES('SB08',N'Vinh',N'Nghệ An',			  098361110);
INSERT INTO SAN_BAY(MaSB, TenSB, DiaChi, SDT) VALUES('SB09',N'Thọ Xuân',N'Thanh Hóa',	  098364090);
INSERT INTO SAN_BAY(MaSB, TenSB, DiaChi, SDT) VALUES('SB10',N'Cam Ranh',N'Khánh Hoà',	  064543235);
SELECT*FROM SAN_BAY
--Đưa đoán sân bay
INSERT INTO DUA_DOAN_SAN_BAY(MaSB, TuDiaDiem, DenDiaDiem, NgayDon, GioDoan,MaKH,tongtien) VALUES('SB01',N'Nội bài',N'Hà Nội','12/03/2020','12:30:AM','KH01',7000000)
INSERT INTO DUA_DOAN_SAN_BAY(MaSB, TuDiaDiem, DenDiaDiem, NgayDon, GioDoan,MaKH,tongtien) VALUES('SB02',N'Đà Nẵng',N'KHÁCH SẠN','12/03/2020','8:30:PM','KH02',7000000)
INSERT INTO DUA_DOAN_SAN_BAY(MaSB, TuDiaDiem, DenDiaDiem, NgayDon, GioDoan,MaKH,tongtien) VALUES('SB03',N'Tân Sơn Nhất',N'KHÁCH SẠN','12/03/2020','10:30:AM','KH03',7000000)
INSERT INTO DUA_DOAN_SAN_BAY(MaSB, TuDiaDiem, DenDiaDiem, NgayDon, GioDoan,MaKH,tongtien) VALUES('SB04',N'Phú Bài',N'KHÁCH SẠN','12/03/2020','9:30:PM','KH04',7000000)
INSERT INTO DUA_DOAN_SAN_BAY(MaSB, TuDiaDiem, DenDiaDiem, NgayDon, GioDoan,MaKH,tongtien) VALUES('SB05',N'Phú Quốc',N'KHÁCH SẠN','12/03/2020','6:30:AM','KH05',7000000)
INSERT INTO DUA_DOAN_SAN_BAY(MaSB, TuDiaDiem, DenDiaDiem, NgayDon, GioDoan,MaKH,tongtien) VALUES('SB06',N'Cần Thơ',N'KHÁCH SẠN','12/03/2020','17:30:AM','KH06',7000000)
INSERT INTO DUA_DOAN_SAN_BAY(MaSB, TuDiaDiem, DenDiaDiem, NgayDon, GioDoan,MaKH,tongtien) VALUES('SB07',N'Điện biên Phủ',N'KHÁCH SẠN','12/03/2020','5:30:AM','KH07',7000000)
INSERT INTO DUA_DOAN_SAN_BAY(MaSB, TuDiaDiem, DenDiaDiem, NgayDon, GioDoan,MaKH,tongtien) VALUES('SB08',N'Vinh',N'KHÁCH SẠN','12/03/2020','6:30:PM','KH08',7000000)
INSERT INTO DUA_DOAN_SAN_BAY(MaSB, TuDiaDiem, DenDiaDiem, NgayDon, GioDoan,MaKH,tongtien) VALUES('SB09',N'Thọ Xuân',N'KHÁCH SẠN','12/03/2020','11:30:PM','KH09',7000000)
INSERT INTO DUA_DOAN_SAN_BAY(MaSB, TuDiaDiem, DenDiaDiem, NgayDon, GioDoan,MaKH,tongtien) VALUES('SB10',N'Cam Ranh',N'KHÁCH SẠN','12/03/2020','8:30:PM','KH10',7000000)
SELECT*FROM DUA_DOAN_SAN_BAY
--Thuê xe
INSERT INTO THUE_XE(MaXe, LoaiXe, DiaDiemThueXe, NgayBatDau, GioBatDau, NgayKetThuc, GioKetThuc) VALUES('MX01',N'Tự Lái',    N'HCM','14/03/2020',NULL,'13/04/2020',NULL)
INSERT INTO THUE_XE(MaXe, LoaiXe, DiaDiemThueXe, NgayBatDau, GioBatDau, NgayKetThuc, GioKetThuc) VALUES('MX02',N'Có Tài Xế', N'HCM','23/03/2020',NULL,'13/04/2020',NULL)
INSERT INTO THUE_XE(MaXe, LoaiXe, DiaDiemThueXe, NgayBatDau, GioBatDau, NgayKetThuc, GioKetThuc) VALUES('MX03',N'Tự Lái',    N'HCM','12/03/2020',NULL,'13/04/2020',NULL)
INSERT INTO THUE_XE(MaXe, LoaiXe, DiaDiemThueXe, NgayBatDau, GioBatDau, NgayKetThuc, GioKetThuc) VALUES('MX04',N'Có Tài Xế', N'HCM','09/03/2020',NULL,'13/04/2020',NULL)
INSERT INTO THUE_XE(MaXe, LoaiXe, DiaDiemThueXe, NgayBatDau, GioBatDau, NgayKetThuc, GioKetThuc) VALUES('MX05',N'Tự Lái',    N'HCM','04/03/2020',NULL,'13/04/2020',NULL)
INSERT INTO THUE_XE(MaXe, LoaiXe, DiaDiemThueXe, NgayBatDau, GioBatDau, NgayKetThuc, GioKetThuc) VALUES('MX06',N'Có Tài Xế', N'HCM','26/03/2020',NULL,'13/04/2020',NULL)
INSERT INTO THUE_XE(MaXe, LoaiXe, DiaDiemThueXe, NgayBatDau, GioBatDau, NgayKetThuc, GioKetThuc) VALUES('MX07',N'Tự Lái',    N'HCM','08/03/2020',NULL,'13/04/2020',NULL)
INSERT INTO THUE_XE(MaXe, LoaiXe, DiaDiemThueXe, NgayBatDau, GioBatDau, NgayKetThuc, GioKetThuc) VALUES('MX08',N'Có Tài Xế', N'HCM','19/03/2020',NULL,'13/04/2020',NULL)
INSERT INTO THUE_XE(MaXe, LoaiXe, DiaDiemThueXe, NgayBatDau, GioBatDau, NgayKetThuc, GioKetThuc) VALUES('MX09',N'Tự Lái',    N'HCM','20/03/2020',NULL,'13/04/2020',NULL)
INSERT INTO THUE_XE(MaXe, LoaiXe, DiaDiemThueXe, NgayBatDau, GioBatDau, NgayKetThuc, GioKetThuc) VALUES('MX10',N'Có Tài Xế', N'HCM','22/03/2020',NULL,'13/04/2020',NULL)
SELECT*FROM THUE_XE
--JRPASS
INSERT INTO JRPASS (MaJR, TenJR, MoTa, GiaTien) VALUES('JR01',N'Roro1' ,N'HCRTCYNRU',200000)
INSERT INTO JRPASS (MaJR, TenJR, MoTa, GiaTien) VALUES('JR02',N'Roro2' ,N'HCRTCYNRU',200000)
INSERT INTO JRPASS (MaJR, TenJR, MoTa, GiaTien) VALUES('JR03',N'Roro3' ,N'HCRTCYNRU',200000)
INSERT INTO JRPASS (MaJR, TenJR, MoTa, GiaTien) VALUES('JR04',N'Roro4' ,N'HCRTCYNRU',200000)
INSERT INTO JRPASS (MaJR, TenJR, MoTa, GiaTien) VALUES('JR05',N'Roro5' ,N'HCRTCYNRU',200000)
INSERT INTO JRPASS (MaJR, TenJR, MoTa, GiaTien) VALUES('JR06',N'Roro6' ,N'HCRTCYNRU',200000)
INSERT INTO JRPASS (MaJR, TenJR, MoTa, GiaTien) VALUES('JR07',N'Roro7' ,N'HCRTCYNRU',200000)
INSERT INTO JRPASS (MaJR, TenJR, MoTa, GiaTien) VALUES('JR08',N'Roro8' ,N'HCRTCYNRU',200000)
INSERT INTO JRPASS (MaJR, TenJR, MoTa, GiaTien) VALUES('JR09',N'Roro9' ,N'HCRTCYNRU',200000)
INSERT INTO JRPASS (MaJR, TenJR, MoTa, GiaTien) VALUES('JR10',N'Roro10',N'HCRTCYNRU',200000)
SELECT*FROM JRPASS
--Hóa đơn
INSERT INTO HOA_DON (MaHD, MaKH, SoLuongVe, NgayLap, TongTien) VALUES('HD01', 'KH01', 1, '12/02/2020',NULL)
INSERT INTO HOA_DON (MaHD, MaKH, SoLuongVe, NgayLap, TongTien) VALUES('HD02', 'KH02', 2, '16/02/2020',NULL)
INSERT INTO HOA_DON (MaHD, MaKH, SoLuongVe, NgayLap, TongTien) VALUES('HD03', 'KH03', 3, '13/02/2020',NULL)
INSERT INTO HOA_DON (MaHD, MaKH, SoLuongVe, NgayLap, TongTien) VALUES('HD04', 'KH04', 4, '11/02/2020',NULL)
INSERT INTO HOA_DON (MaHD, MaKH, SoLuongVe, NgayLap, TongTien) VALUES('HD05', 'KH05', 3, '10/02/2020',NULL)
INSERT INTO HOA_DON (MaHD, MaKH, SoLuongVe, NgayLap, TongTien) VALUES('HD06', 'KH06', 2, '27/02/2020',NULL)
INSERT INTO HOA_DON (MaHD, MaKH, SoLuongVe, NgayLap, TongTien) VALUES('HD07', 'KH07', 1, '09/02/2020',NULL)
INSERT INTO HOA_DON (MaHD, MaKH, SoLuongVe, NgayLap, TongTien) VALUES('HD08', 'KH08', 2, '17/02/2020',NULL)
INSERT INTO HOA_DON (MaHD, MaKH, SoLuongVe, NgayLap, TongTien) VALUES('HD09', 'KH09', 1, '02/02/2020',NULL)
INSERT INTO HOA_DON (MaHD, MaKH, SoLuongVe, NgayLap, TongTien) VALUES('HD10', 'KH10', 2, '01/02/2020',NULL)
SELECT*FROM HOA_DON
--Chi tiết hóa đơn 
INSERT INTO CHITIET_HOADON (MaHD, MaVe, SoLuong, DonGia, GiamGia, ThanhTien) VALUES ('HD01', 'MV01', 1, 490000, NULL, NULL);
INSERT INTO CHITIET_HOADON (MaHD, MaVe, SoLuong, DonGia, GiamGia, ThanhTien) VALUES ('HD02', 'MV02', 2, 10000 ,  NULL, NULL);
INSERT INTO CHITIET_HOADON (MaHD, MaVe, SoLuong, DonGia, GiamGia, ThanhTien) VALUES ('HD03', 'MV03', 3, 100000, NULL, NULL);
INSERT INTO CHITIET_HOADON (MaHD, MaVe, SoLuong, DonGia, GiamGia, ThanhTien) VALUES ('HD04', 'MV04', 4, 15000,  NULL, NULL);
INSERT INTO CHITIET_HOADON (MaHD, MaVe, SoLuong, DonGia, GiamGia, ThanhTien) VALUES ('HD05', 'MV05', 3, 29000,  NULL, NULL);
INSERT INTO CHITIET_HOADON (MaHD, MaVe, SoLuong, DonGia, GiamGia, ThanhTien) VALUES ('HD06', 'MV06', 2, 125000, NULL, NULL);
INSERT INTO CHITIET_HOADON (MaHD, MaVe, SoLuong, DonGia, GiamGia, ThanhTien) VALUES ('HD07', 'MV07', 1, 100000, NULL, NULL);
INSERT INTO CHITIET_HOADON (MaHD, MaVe, SoLuong, DonGia, GiamGia, ThanhTien) VALUES ('HD08', 'MV08', 2, 15000,  NULL, NULL);
INSERT INTO CHITIET_HOADON (MaHD, MaVe, SoLuong, DonGia, GiamGia, ThanhTien) VALUES ('HD09', 'MV09', 1, 15000,  NULL, NULL);
INSERT INTO CHITIET_HOADON (MaHD, MaVe, SoLuong, DonGia, GiamGia, ThanhTien) VALUES ('HD10', 'MV10', 2, 29000,  NULL, NULL);
SELECT*FROM CHITIET_HOADON
------TOUR-------
INSERT INTO TOUR
VALUES('CDH',N'CỐ ĐÔ HUẾ'),
('TCBD',N'TAM CÔC-BÍCH ĐỘNG'),
('VHL',N'VỊNH HẠ LONG'),
('LKD',N'LĂNG KHẢI ĐỊNH'),
('PCHA',N'PHỐ CỔ HỘI AN'),
('LM',N'LANDMARK'),
('PQ',N'PHÚ QUỐC'),
('DDCC',N'ĐỊA ĐẠO CỦ CHI')
INSERT INTO KS
VALUES(N'Thiên Ân'),
(N'Hồng Đức'),
(N'Hoàng Nam'),
(N'Vũ Hạnh'),
(N'Nhật Hàn'),
(N'Minh Trung'),
(N'Đại Sơn'),
(N'Hành Ca'),
(N'Lộc Nam'),
(N'Hoàng Nhiên')
------------TRIGGER----------------------
