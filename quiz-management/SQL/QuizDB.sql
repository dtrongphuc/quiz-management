CREATE TABLE nguoiDung
(
	maNguoiDung INT IDENTITY,
	tenTaiKhoan VARCHAR(100) UNIQUE,
	matKhau VARCHAR(max),
	phanQuyen INT,
	TrangThai INT
	
	CONSTRAINT PK_nguoiDung
	PRIMARY KEY (maNguoiDung)
)

CREATE TABLE Lop
(
	maKhoiLop varchar(5),
	maLopHoc INT IDENTITY,
	tenLopHoc NVARCHAR(10)

	CONSTRAINT PK_Lop
	PRIMARY KEY (maLopHoc)
)
alter table Lop add constraint FK_lop_khoiLop FOREIGN KEY(maKhoiLop) references khoiLop(maKhoiLop)



CREATE TABLE khoiLop
(
	maKhoiLop varchar(5),
	tenKhoiLop varchar(10)

	CONSTRAINT PK_khoiLop
	PRIMARY KEY (maKhoiLop)
)




CREATE TABLE thongTin
(
	maNguoidung INT,
	tenNguoiDung NVARCHAR(50),
	ngaySinh DATE,
	maLopHoc INT
	
	CONSTRAINT PK_thongtin
	PRIMARY KEY (maNguoidung)
)

ALTER TABLE thongTin
ADD CONSTRAINT df_maLopHoc
DEFAULT NUll FOR maLopHoc;

ALTER TABLE thongtin ADD CONSTRAINT FK_thongtin_lop FOREIGN KEY(maLopHoc) REFERENCES lop(maLopHoc)
ALTER TABLE dbo.thongTin ADD CONSTRAINT FK_thongtin_nguoidung FOREIGN KEY(maNguoidung) REFERENCES dbo.nguoiDung(maNguoidung)

CREATE TABLE monHoc
(
	maMonHoc INT IDENTITY,
	tenMonHoc NVARCHAR(20)

	CONSTRAINT PK_monHoc
	PRIMARY KEY(maMonHoc)
)

CREATE TABLE boDe
(
	maBoDe INT IDENTITY,
	thoiGian INT,
	tongSoCau INT,
	maMon INT,
	maKhoi varchar(5)

	CONSTRAINT PK_boDe
	PRIMARY KEY (maBoDe)
)

ALTER TABLE dbo.boDe ADD CONSTRAINT FK_boDe_monHoc FOREIGN KEY(maMon) REFERENCES dbo.monHoc(maMonHoc)
ALTER TABLE boDe ADD CONSTRAINT FK_boDe_khoiLop FOREIGN KEY(maKhoi) REFERENCES khoiLop(maKhoiLop)


CREATE TABLE cauHoi
(
	maCauHoi INT IDENTITY,
	maMonHoc INT,
	cauHoi NVARCHAR(100),
	doKho INT

	CONSTRAINT PK_cauHoi
	PRIMARY KEY (maCauHoi)
)

CREATE TABLE cTBoDe
(
	maBoDe INT,
	maCauHoi INT

	CONSTRAINT PK_cTBoDe
	PRIMARY KEY (maBoDe,maCauHoi)
)

ALTER TABLE dbo.cTBoDe ADD CONSTRAINT FK_cTBoDe_boDe FOREIGN KEY(maBoDe) REFERENCES dbo.boDe (maBoDe)
ALTER TABLE  dbo.cTBoDe ADD CONSTRAINT FK_ctBoDe_cauHoi FOREIGN KEY (maCauHoi) REFERENCES dbo.cauHoi(maCauHoi)

CREATE TABLE dapAn
(
	maCauHoi INT,
	maCauTraloi INT,
	cauTraLoi NVARCHAR(100),
	dapAn INT,
	 
	CONSTRAINT PK_dapAn
	PRIMARY KEY (maCauHoi,maCauTraLoi)
)


ALTER TABLE dbo.dapAn ADD CONSTRAINT FK_dapan_cauHoi FOREIGN KEY (maCauHoi) REFERENCES dbo.cauHoi (maCauHoi)

CREATE TABLE ketQua
(
	maKetQua INT IDENTITY,
	maNguoiDung INT,
	maBoDe INT,
	cauDung INT,
	cauSai INT,
	chuaLam INT,
	ngayLam DATE,
	trangThai INT,
	thoiGian INT,
	diem FLOAT
    
	CONSTRAINT PK_ketQua
	PRIMARY KEY (maKetQua)
)

ALTER TABLE dbo.ketQua ADD CONSTRAINT FK_ketQua_nguoiDung FOREIGN KEY(maNguoiDung) REFERENCES dbo.nguoiDung(maNguoiDung)
ALTER TABLE  dbo.ketQua ADD CONSTRAINT FK_ketQua_boDe FOREIGN KEY(maBoDe) REFERENCES dbo.boDe(maBoDe)

CREATE TABLE cTKetQua
(
    maKetQua INT,
	maCauHoi INT,
	maCauTraLoi INT,
	thoiGian INT

	CONSTRAINT PK_cTKetQua
	PRIMARY KEY (maKetQua,maCauHoi,maCauTraLoi)
)

ALTER TABLE dbo.cTKetQua ADD CONSTRAINT FK_cTKetQua_ketQua FOREIGN KEY (maKetQua) REFERENCES dbo.ketQua(maKetQua)
ALTER TABLE  dbo.cTKetQua ADD CONSTRAINT FK_cTKetQua_cauHoi FOREIGN KEY (maCauHoi) REFERENCES dbo.cauHoi(maCauHoi)
ALTER TABLE  dbo.cTKetQua ADD CONSTRAINT FK_cTKetQua_dapAn FOREIGN KEY (maCauHoi,maCauTraLoi) REFERENCES dbo.dapAn(maCauHoi,maCauTraloi)

CREATE TABLE lichThi
(
	maNguoiDung INT,
	maMonHoc INT,
	ngayThi DATE

	CONSTRAINT PK_lichThi
	PRIMARY KEY(maNguoiDung,maMonHoc,ngayThi)
)

CREATE TABLE luyenTap
(
	maNguoiDung INT,
	soCauDung INT,
	soCauSai INT,
	ngay date
)
ALTER TABLE  dbo.luyenTap ADD CONSTRAINT FK_luyenTap_nguoiDung FOREIGN KEY(maNguoiDung) REFERENCES dbo.nguoiDung(maNguoiDung)

CREATE TABLE dongGop
(
	maDongGop INT IDENTITY,
	maNguoiDung INT,
	maMonHoc INT,
	trangthai INT,
	ngay DATE,
	cauHoi NVARCHAR(100)

	CONSTRAINT PK_dongGop
	PRIMARY KEY (maDongGop)
)

ALTER TABLE dbo.dongGop ADD CONSTRAINT FK_dongGop_nguoiDung FOREIGN KEY(maNguoiDung) REFERENCES dbo.nguoiDung(maNguoiDung)
ALTER TABLE  dbo.dongGop ADD CONSTRAINT FK_dongGop_monHoc FOREIGN KEY(maMonHoc) REFERENCES dbo.monHoc (maMonHoc)

CREATE TABLE cTDongGop
(
    maDongGop INT,
	cauTraLoi NVARCHAR(100),
	dapAn INT
)

ALTER TABLE dbo.cTDongGop ADD CONSTRAINT FK_cTDongGop_dongGop FOREIGN KEY(maDongGop) REFERENCES dbo.dongGop(maDongGop)

INSERT INTO dbo.monHoc
(
    tenMonHoc
)
VALUES
(N'Lịch Sử' -- tenMonHoc - nvarchar(20)
    )
	GO

INSERT INTO dbo.Lop
(
    maKhoiLop,
    tenLopHoc
)
VALUES
(   'K10', -- maKhoiLop - varchar(5)
    N'10A1' -- tenLopHoc - nvarchar(10)
    )
GO

INSERT INTO dbo.khoiLop
(
    maKhoiLop,
    tenKhoiLop
)
VALUES
(   'K10', -- maKhoiLop - varchar(5)
    '10'  -- tenKhoiLop - varchar(10)
    )
GO

INSERT INTO dbo.boDe
(
    thoiGian,
    tongSoCau,
    maMon,
    maKhoi
)
VALUES
(   30, -- thoiGian - INT
    20,         -- tongSoCau - int
    1,         -- maMon - int
    'K10'         -- maKhoi - varchar(5)
    )
GO

INSERT INTO dbo.cauHoi
(
    maMonHoc,
    cauHoi,
    doKho
)
VALUES
(   1,   -- maMonHoc - int
    N'Ý nào sau đây không phù hợp với loài vượn cổ trong quá trình tiến hóa thành người ?', -- cauHoi - nvarchar(100)
    1    -- doKho - int
    )
GO

INSERT INTO dbo.cTBoDe
(
    maBoDe,
    maCauHoi
)
VALUES
(   2, -- maBoDe - int
    1  -- maCauHoi - int
    )
GO

INSERT INTO dbo.dapAn
(
    maCauHoi,
    maCauTraloi,
    cauTraLoi,
    dapAn
)
VALUES
(   1,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'Sống cách đây 6 triệu năm.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
(   1,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'Có thể đứng và đi bằng 2 chân.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   1,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'Tay được dung để cầm nắm.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   1,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'Chia thành các chủng tộc lớn.', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    )
GO

select * from nguoiDung
select * from thongtin
select * from lop
update thongtin set maLopHoc = 1