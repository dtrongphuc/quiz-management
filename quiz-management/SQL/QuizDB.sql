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

select * from nguoiDung
insert into nguoiDung values('c','Hqz75h972DAG+3clE0Gi9sto1yVPd8XgM1x4tSb/WvZEfKgo',1,1)
CREATE TABLE Lop
(
	maKhoiLop varchar(5),
	maLopHoc INT IDENTITY,
	tenLopHoc NVARCHAR(10)

	CONSTRAINT PK_Lop
	PRIMARY KEY (maLopHoc)
)
alter table Lop add constraint FK_lop_khoiLop FOREIGN KEY(maKhoiLop) references khoiLop(maKhoiLop)
select * from boDe 
update boDe set trangThai = 0 where maBoDe =1
insert into boDe values(20,1,'K10',1800,0)


CREATE TABLE khoiLop
(
	maKhoiLop varchar(5),
	tenKhoiLop varchar(10)

	CONSTRAINT PK_khoiLop
	PRIMARY KEY (maKhoiLop)
)
select * from khoiLop



CREATE TABLE thongTin
(
	maNguoidung INT,
	tenNguoiDung NVARCHAR(50),
	ngaySinh DATE,
	maLopHoc INT
	
	CONSTRAINT PK_thongtin
	PRIMARY KEY (maNguoidung)
)
select * from thongTin
insert into thongTin(maNguoidung,tenNguoiDung,ngaySinh,maLopHoc)values('3','Thành Phú','2000-05-05',1)


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
select * from monHoc
CREATE TABLE boDe
(
	maBoDe INT IDENTITY,
	thoiGian INT,
	tongSoCau INT,
	maMon INT,
	maKhoi varchar(5),
    trangThai int

	CONSTRAINT PK_boDe
	PRIMARY KEY (maBoDe)
)
select * from boDe

ALTER TABLE dbo.boDe ADD CONSTRAINT FK_boDe_monHoc FOREIGN KEY(maMon) REFERENCES dbo.monHoc(maMonHoc)
ALTER TABLE boDe ADD CONSTRAINT FK_boDe_khoiLop FOREIGN KEY(maKhoi) REFERENCES khoiLop(maKhoiLop)


CREATE TABLE cauHoi
(
	maCauHoi INT IDENTITY,
	maMonHoc INT,
	cauHoi NVARCHAR(100),
	doKho INT,
    trangThai int,
    maKhoiLop  varchar(5)

	CONSTRAINT PK_cauHoi
	PRIMARY KEY (maCauHoi)
)
alter table cauhoi alter column cauHoi nvarchar(300)
alter table cauHoi add constraint df_trangthai default 1 for trangThai
alter table cauHoi add constraint FK_cauHoi_monHoc foreign key(maMonHoc) references monHoc(maMonHoc)
alter table cauHoi add constraint FK_cauHoi_khoiLop foreign key(maKhoiLop) references khoiLop(maKhoiLop)
select * from cauHoi

CREATE TABLE cTBoDe
(
	maBoDe INT,
	maCauHoi INT

	CONSTRAINT PK_cTBoDe
	PRIMARY KEY (maBoDe,maCauHoi)
)

ALTER TABLE dbo.cTBoDe ADD CONSTRAINT FK_cTBoDe_boDe FOREIGN KEY(maBoDe) REFERENCES dbo.boDe (maBoDe) on Delete Cascade
ALTER TABLE  dbo.cTBoDe ADD CONSTRAINT FK_ctBoDe_cauHoi FOREIGN KEY (maCauHoi) REFERENCES dbo.cauHoi(maCauHoi) on Delete Cascade

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
alter table ketQua add constraint df_cauchualam default 0 for chuaLam;
alter table ketQua add constraint df_cau default 0 for cauDung;
alter table ketQua add constraint df_causai default 0 for cauSai;
alter table ketQua add constraint df_ngaylam default getdate() for ngayLam;

update ketQua set trangThai=0 where maKetQua=2
select * from ketQua
ALTER TABLE dbo.ketQua ADD CONSTRAINT FK_ketQua_nguoiDung FOREIGN KEY(maNguoiDung) REFERENCES dbo.nguoiDung(maNguoiDung)
ALTER TABLE  dbo.ketQua ADD CONSTRAINT FK_ketQua_boDe FOREIGN KEY(maBoDe) REFERENCES dbo.boDe(maBoDe)

insert into ketQua
values(1, 1, null, null, null, null, null, null, null)
go

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
    maLichThi INT,
	maNguoiDung INT,
	maMonHoc INT,
	ngayThi DATE,
    maBoDe INT,

	CONSTRAINT PK_lichThi
	PRIMARY KEY(maNguoiDung,maBoDe,ngayThi,maLichThi)
)
select * from lichThi
alter table lichThi add constraint FK_lichThi_boDe foreign key (maBoDe) references boDe(maBoDe)
alter table lichThi add constraint FK_lichThi_nguoiDung foreign key (maNguoiDung) references nguoiDung(maNguoiDung) on Delete Cascade
alter table lichThi add constraint FK_lichThi_monHoc foreign key (maMonHoc) references monHoc(maMonHoc)

create table kyThiThu
(
    maKyThiThu int,
    maNguoiDung INT,
    maMonHoc INT,
    ngayThi Date,
    ngayKT date,
    maBoDe INT,
    maKhoiLop varchar(5)

    constraint PL_kyThiThu
    primary key (maKyThiThu,maNguoiDung,maBoDe)
)
alter table kyThiThu add constraint FK_kyThiThu_boDe foreign key (maBoDe) references boDe(maBoDe)
alter table kyThiThu add constraint FK_kyThiThu_KhoiLop foreign key (maKhoiLop) references khoiLop(maKhoiLop)
alter table kyThiThu add constraint FK_kyThiThu_monHoc foreign key (maMonHoc) references monHoc(maMonHoc)
alter table kyThiThu add constraint FK_kyThiThu_nguoiDung foreign key (maNguoiDung) references nguoiDung(maNguoiDung) on Delete Cascade

select * from kyThiThu


CREATE TABLE luyenTap
(
	maNguoiDung INT,
	soCauDung INT,
	soCauSai INT,
	ngay date,

	constraint PK_luyenTap
	primary key(maNguoiDung,soCauDung,soCauSai,ngay)
)

ALTER TABLE  dbo.luyenTap ADD CONSTRAINT FK_luyenTap_nguoiDung FOREIGN KEY(maNguoiDung) REFERENCES dbo.nguoiDung(maNguoiDung) on Delete Cascade

CREATE TABLE dongGop
(
	maDongGop INT IDENTITY,
	maNguoiDung INT,
	maMonHoc INT,
	trangthai INT,
	ngay DATE,
	cauHoi NVARCHAR(100),
	maKhoiLop varchar(5)

	CONSTRAINT PK_dongGop
	PRIMARY KEY (maDongGop)
)


ALTER TABLE dongGop ADD CONSTRAINT FK_dongGop_khoiLop FOREIGN KEY(maKhoiLop) REFERENCES khoiLop(maKhoiLop)
ALTER TABLE dbo.dongGop ADD CONSTRAINT FK_dongGop_nguoiDung FOREIGN KEY(maNguoiDung) REFERENCES dbo.nguoiDung(maNguoiDung) on Delete Cascade
ALTER TABLE  dbo.dongGop ADD CONSTRAINT FK_dongGop_monHoc FOREIGN KEY(maMonHoc) REFERENCES dbo.monHoc (maMonHoc)
select * from dongGop

CREATE TABLE cTDongGop
(
    maDongGop INT,
	cauTraLoi NVARCHAR(100),
	dapAn INT,

	CONSTRAINT PK_cTDongGop
	PRIMARY KEY(maDongGop,cauTraLoi)
)

ALTER TABLE dbo.cTDongGop ADD CONSTRAINT FK_cTDongGop_dongGop FOREIGN KEY(maDongGop) REFERENCES dbo.dongGop(maDongGop) on Delete Cascade

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

INSERT INTO dbo.cauHoi
(
    maMonHoc,
    cauHoi,
    doKho
)
VALUES
(   1,   -- maMonHoc - int
    N'Xương hóa thạch của loài vượn cổ được tìm thấy ở đâu?', -- cauHoi - nvarchar(100)
    1    -- doKho - int
    ),
	(
		 1,   -- maMonHoc - int
		N'Di cốt của người tối cổ được tìm thấy ở đâu?', -- cauHoi - nvarchar(100)
		1    -- doKho - int
	),
	(
		 1,   -- maMonHoc - int
		N'Người tối cổ có bước tiến hóa hơn về cấu tạo cơ thể so với loài vượn cổ ở điểm nào?', -- cauHoi - nvarchar(100)
		1    -- doKho - int
	),
	(
		 1,   -- maMonHoc - int
		N'Trong quá trình tiến hóa từ vượn thành người. Người tối cổ được đánh giá', -- cauHoi - nvarchar(100)
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

SELECT * FROM kyThiThu

--INSERT INTO kyThiThu(maKyThiThu,maNguoiDung,maMonHoc,ngayThi,ngayKT,maBoDe,maKhoiLop)
--VALUES (1,1,1,GETDATE)
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

INSERT INTO dbo.dapAn
(
    maCauHoi,
    maCauTraloi,
    cauTraLoi,
    dapAn
)
VALUES
(   2,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'Đông Phi, Tây Á, Bắc Á.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
(   2,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'Đông Phi, Tây Á, Đông Nan Á.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   2,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'Đông Phi, Việt Nam, Trung Quốc.', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   2,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'Tây Á, Trung Á, Bắc Mĩ.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   3,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'Đông Phi, Trung Quốc, Bắc Âu.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   3,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'Đông Phi, Tây Á, Bắc Âu.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   3,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'Đông Phi, Inội dungonexia, Đông Nam Á.', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   3,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'Tây Á, Trung Quốc, Bắc Âu.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   4,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'Hộp sọ lớn hơn, đã hình thành trung tâm phát tiếng nói trong não.', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   4,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'Đã đi, đứng bằng hai chân, đôi bàn tay được giải phóng.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   4,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'Trán thấp và bợt ra sau, u mày nổi cao.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   4,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'Đã loại bỏ hết dấu tích vượn trên cơ thể.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   5,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'Vẫn chưa thoát thai khỏi loài vượn.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   5,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'Là những chủ nhân đầu tiên trong lịch sử loài người.', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   5,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'Là bước chuyển tiếp từ vượn thành người.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   5,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'Là những con người thông minh.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    )
GO

INSERT INTO dbo.cTBoDe
(
    maBoDe,
    maCauHoi
)
VALUES
(   1, -- maBoDe - int
    2  -- maCauHoi - int
    ),
    (   1, -- maBoDe - int
    3  -- maCauHoi - int
    ),
    (   1, -- maBoDe - int
    4  -- maCauHoi - int
    ),
    (   1, -- maBoDe - int
    5  -- maCauHoi - int
    )
GO


insert into ketQua(maNguoiDung,MaBoDe,CauDung,TrangThai,ThoiGian,diem)
values (1,1,1,1,60,10)
go
insert into cTKetQua(maKetQua,maCauHoi,maCauTraLoi,thoiGian)
values(1,1,4,60)
go

insert into lichThi (maNguoiDung,maMonHoc,ngayThi)
values (1,1,getdate())
go
select * from nguoiDung
select * from thongtin
select * from lop
update thongtin set maLopHoc = 1

---bắt đầu từ đây
--select * from khoiLop
--select * from monHoc
--select * from CauHoi
INSERT INTO dbo.monHoc
(
    tenMonHoc
)
VALUES (N'Hóa Học'), (N'Tiếng Anh')
GO
insert into dbo.khoiLop values ('K11', 11), ('K12', 12)
INSERT INTO dbo.Lop
(
    maKhoiLop,
    tenLopHoc
)
VALUES
(   'K11', -- maKhoiLop - varchar(5)
    N'11A1' -- tenLopHoc - nvarchar(10)
    )
GO

--select * from db.cauHoi
INSERT INTO dbo.cauHoi
(
    maMonHoc,
    cauHoi,
    doKho,
	maKhoiLop
)
VALUES(   2,   -- maMonHoc - int
    N'Công thức phân tử của Strien là?', -- cauHoi - nvarchar(100)
    1,
	'K11'
    ),
	(   2,   -- maMonHoc - int
    N'Công thức phân tử của toluen là?', -- cauHoi - nvarchar(100)
    1 ,
	'K11'   -- doKho - int
    ),
	(
		 2,   -- maMonHoc - int
		N'Số đồng phân Hiđrocacbon thơm ưng với công thức C8H10 là?', -- cauHoi - nvarchar(100)
		1 ,
	'K11'   -- doKho - int
	),
	(
		 2,   -- maMonHoc - int
		N'Benzen tác dụng với Br2 theo tỷ lệ mol 1 : 1 (có mặt bột Fe), thu được sẩn phẩm hữu cơ là?', -- cauHoi - nvarchar(100)
		1 ,
	'K11'   -- doKho - int
	),
	(
		 2,   -- maMonHoc - int
		N'Nhóm A bao gồm các nguyên tố?', -- cauHoi - nvarchar(100)
		1 ,
	'K12'   -- doKho - int
	),
	(
		 2,   -- maMonHoc - int
		N'Cho nguyên tố có kí hiệu là 12X. Vị trí của X trong bảng tuần hoàn?', -- cauHoi - nvarchar(100)
		1 ,
	'K12'   -- doKho - int
	),
	(
		 2,   -- maMonHoc - int
		N'Bán kính nguyên tử các nguyên tố: Na, Li, Be, B. Xếp theo chiều tăng dần là?', -- cauHoi - nvarchar(100)
		1 ,
	'K12'   -- doKho - int
	),
	(
		 3,   -- maMonHoc - int
		N'Scientists hope that this new drug will be a major breakthrough in the fight against AIDS.?', -- cauHoi - nvarchar(100)
		1 ,
	'K11'   -- doKho - int
	),
	(
		 3,   -- maMonHoc - int
		N'If we have solar panels on our roofs, we will be able to generate our own electricity.', -- cauHoi - nvarchar(100)
		1 ,
	'K11'   -- doKho - int
	),
	(
		 3,   -- maMonHoc - int
		N' There is a real mix of people in Brighton. It has a verycosmopolitan feel to it.', -- cauHoi - nvarchar(100)
		1 ,
	'K11'   -- doKho - int
	)
GO
--select * from DapAn
INSERT INTO dbo.dapAn
(
    maCauHoi,
    maCauTraloi,
    cauTraLoi,
    dapAn
)
VALUES
(   6,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'C6H6', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
(   6,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'C7H8', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   6,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'C8H8', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   6,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'C8H10', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
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
(   7,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'C6H6', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
(   7,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'C7H8', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   7,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'C8H8', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   7,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'C8H10', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   8,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'4', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   8,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'2', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   8,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'3', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   8,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'5', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   9,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'C6H6Br2', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   9,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'C6H6Br6', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   9,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'C6H5Br', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   9,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'C6H6Br44', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   10,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'Nguyên tố s', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   10,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'Nguyên tố p', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   10,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'Nguyên tố d và nguyên tố f.', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   10,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'Nguyên tố s và nguyên tố p', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),

	--11
	(   11,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'Nhóm IIA, chu kì 3', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   11,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'Nhóm IA, chu kì 3', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   11,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'Nhóm IIIA, chu kì 2', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   11,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'Nhóm IA, chu kì 2', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),

	--12
	(   12,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'B < Be < Li < Na', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   12,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'Na < Li < Be < B', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   12,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'Li < Be < B < Na', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   12,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'Be < Li < Na < B', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),

	--13
	(   13,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'new cure', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   13,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'important therapy', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   13,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'sudden remedy', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   13,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'dramatic development', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),

	--14
	(   14,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'afford', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   14,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'produce', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   14,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'manufacture', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   14,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'light', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	
	--15
	(   15,   -- maCauHoi - int
    1,   -- maCauTraloi - int
    N'busy', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   15,   -- maCauHoi - int
    2,   -- maCauTraloi - int
    N'hectic', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    ),
	(   15,   -- maCauHoi - int
    3,   -- maCauTraloi - int
    N'multi-cultural', -- cauTraLoi - nvarchar(100)
    1    -- dapAn - int
    ),
	(   15,   -- maCauHoi - int
    4,   -- maCauTraloi - int
    N'diversified', -- cauTraLoi - nvarchar(100)
    0    -- dapAn - int
    )
GO

INSERT INTO boDe 
values 
(
    2,
    2, 
    'K11',
    10
)
insert into cTBoDe values (2, 7), (2, 6)
select * from cTBoDe
select * from boDe
INSERT INTO dbo.boDe
(
    thoiGian,
    tongSoCau,
    maMon,
    maKhoi
)
VALUES
(   30, -- thoiGian - INT
    3,         -- tongSoCau - int
    2,         -- maMon - int
    'K11'         -- maKhoi - varchar(5)
    )
GO
insert into cTBoDe values (3, 7), (3, 6), (3, 8)

--insert đóng góp
insert into dongGop values 
(
    1, --ma ng dung
    2, -- ma mon hoc
    0, -- trang thai 0 chua duyêt, 1 la đã duyệt
    getdate(),
    N'Câu hỏi là gì???',
    'K11'
), 
(
    1, --ma ng dung
    2, -- ma mon hoc
    0, -- trang thai 0 chua duyêt, 1 la đã duyệt
    getdate(),
    N'Gió bắt đầu từ đâu??',
    'K11'
)
select * from cTDongGop
insert into cTDongGop values ( 1, N'trả lời 1', 0), ( 1, N'trả lời 2', 1), ( 1, N'trả lời 3', 0), ( 1, N'trả lời 4', 0),
                             ( 2, N'trả lời 1', 1), ( 2, N'trả lời 2', 0), ( 2, N'trả lời 3', 0), ( 2, N'trả lời 4', 0) 
                             
insert into nguoiDung values ('b', 'NW5hmDQ+PyC/HJ1oS9ENKd+L63PHQxhyAjLf6eK1NW+NaY5r', 2, 1)
insert into thongTin values (2, N'Nguyễn Hiếu Nghĩa', '2000-10-20', null)
select * from boDe
update cauHoi set trangThai = 0 where maCauHoi = 14 or maCauHoi = 15
insert into kyThiThu values (1, 1, 1, '2020-10-10', '2020-12-12', 1, 'K10')

--------------START--------------------
insert into monHoc values (N'Vật Lý')
select * from cauHoi
--vật lý
--khoi 10
insert into cauHoi values 
--khoi 10
(4, N'Trong trường hợp nào dưới đây có thể coi một đoàn tàu như một chất điểm?', 2, 1, 'K10'),--16
(4, N'Trong các ví dụ dưới đây, trường hợp nào vật chuyển động được coi như là chất điểm?', 1, 1, 'K10'),--17
(4, N'Khi chọn Trái Đất làm vật mốc thì câu nói nào sau đây đúng?', 1, 1, 'K10'),--18
(4, N' Trong trường hợp nào dưới đây quỹ đạo của vật là đường thẳng?', 3, 1, 'K10'),--19
(4, N'Trường hợp nào dưới đây có thể coi vật là chất điểm ?', 1, 1, 'K10'),--20
(4, N'Cho hai lực đồng quy có độ lớn bằng 5 N và 8 N. Độ lớn của hợp lực có thể là', 2, 1, 'K10'),--23
(4, N'Một vật không có trục quay cố định, khi chịu tác dụng của một ngẫu lực thì vật sẽ', 1, 1, 'K10'),--24
--khối 11insert into cauHoi values 
(4, N'Chọn đáp án đúng. Khi một điện tích q = -2C di chuyển từ điểm M đến điểm N trong điện trường thì lực điện sinh công -6J. Hỏi hiệu điện thế UMN bằng bao nhiêu?', 1, 1, 'K11'),--25
(4, N'Biết điện thế tại điểm M trong điện trường là 24V. Electron có điện tích e = -1,6.10-19 C đặt tại điểm M có thế năng là:', 3, 1, 'K11'),--26
(4, N'Điện tích q chuyển động từ M đến N trong một điện trường đều, công của lực điện càng nhỏ nếu ', 1, 1, 'K11'),--27
(4, N'Để chế tạo lăng kính phản xạ toàn phần đặt trong không khí thì phải chọn thủy tinh để chiết suất là', 1, 1, 'K11'),--28
(4, N'Lăng kính có góc ở đỉnh là 60o. Chùm tia song song qua lăng kính có độ lệch cực tiểu là Dmin = 42o. Tìm chiết suất của lăng kính.', 1, 1, 'K11'),--29
(4, N'Trong các chất sau đây: I. Dung dịch muối NaCl; II. Sứ; III. Nước nguyên chất; IV. Than chì. Những chất điện dẫn là:', 2, 1, 'K11'),--30
(4, N'Hai điện tích dương q1, q2 có cùng một độ lớn được đặt tại hai điểm A, B thì ta thấy hệ ba điện tích này nằm cân bằng trong chân không. Bỏ qua trọng lượng của ba điện tích. Chọn kết luận đúng', 1, 1, 'K11'),--31
--khối 12
(4, N'Một con lắc đơn mà quả cầu có khối lượng 0,5kg dao động nhỏ với chu kỳ 0,4π (s) tại nơi có gia tốc rơi tự do g = 10 m/s2. Biết li độ góc cực đại là 0,15 rad. Tính cơ năng dao động.  ', 1, 1, 'K12'),--32
(4, N'Biểu thức cường độ dòng điện trong đoạn mạch xoay chiều là i = 2cos100πt (A). Tần số của dòng điện là bao nhiêu?', 3, 1, 'K12'),--33
(4, N'Khi đặt điện áp có biểu thức u = U0.cos(ωt - π/3) V vào hai đầu một đoạn mạch thì cường độ dòng điện chạy trong mạch đó có biểu thức i = I0cos(ωt - π/6) A. Hệ số công suất của mạch là:', 1, 1, 'K12'),--34
(4, N'Năng lượng nghỉ của 5 μg vật chất bằng', 1, 1, 'K12'),--35
(4, N'Chọn phát biểu đúng về hiện tượng quang điện trong:', 1, 1, 'K12'),--36
(4, N'Hạt nhân nguyên tử được cấu tạo từ:', 1, 1, 'K12'),--21
(4, N'Trong một mạch dao động điện từ LC với L = 25 mH và C = 1,6 µF. đang có dao động điện từ. Ở thời điểm t, cường độ dòng điện trong mạch có độ lớn bằng 6,93 mA và điện tích trên tụ điện bằng 0,8 µC. Năng lượng của mạch dao động bằng:', 1, 1, 'K12')--22

select * from dapAn
--dap an
--khối 10.
insert into dapAn values 
(16, 1, N'Đoàn tàu lúc khởi hành.', 0),
(16, 2, N'Đoàn tàu đang qua cầu.', 0),
(16, 3, N'Đoàn tàu đang chạy trên một đoạn đường vòng.', 0),
(16, 4, N'Đoàn tàu đang chạy trên đường Hà Nội -Vinh.', 1),
(17, 1, N'Mặt Trăng quay quanh Trái Đất.', 1),
(17, 2, N'Đoàn tàu chuyển động trong sân ga.', 0),
(17, 3, N'Em bé trượt từ đỉnh đến chân cầu trượt.', 0),
(17, 4, N'Chuyển động tự quay của Trái Đất quanh trục.', 0),
(18, 1, N'Trái Đất quay quanh Mặt Trời.', 0),
(18, 2, N'Mặt Trời quay quanh Trái Đất.', 1),
(18, 3, N'Mặt Trời đứng yên còn Trái Đất chuyển động.', 0),
(18, 4, N'Cả Mặt Trời và Trái Đất đều chuyển động.', 0),
(19, 1, N' Chuyển động của vệ tinh nhân tạo của Trái Đất.', 0),
(19, 2, N'Chuyển động của con thoi trong rãnh khung cửi.', 1),
(19, 3, N'Chuyển động của đầu kim đồng hồ.', 0),
(19, 4, N' Chuyển động của một vật được ném theo phương nằm ngang.', 0),
(20, 1, N' Trái Đất trong chuyển động tự quay quanh mình nó.', 0),
(20, 2, N'Hai hòn bi lúc va chạm với nhau.', 0),
(20, 3, N'Người nhảy cầu lúc đang rơi xuống nước.', 0),
(20, 4, N'Giọt nước mưa lúc đang rơi.', 1),
(21, 1, N'1 N.', 0),
(21, 2, N'12 N.', 1),
(21, 3, N'2 N.', 0),
(21, 4, N'15 N.', 0),
(22, 1, N'chuyển động tịnh tiến.', 0),
(22, 2, N'chuyển động quay.', 1),
(22, 3, N'vừa quay, vừa tịnh tiến.', 0),
(22, 4, N'nằm cân bằng.', 0),
--khối 11
(23, 1, N'+12V', 0),
(23, 2, N'-12V', 0),
(23, 3, N'+3V', 1),
(23, 4, N'-3V', 0),
(24, 1, N'3,84.10-18 J', 0),
(24, 2, N'-3,84.10-18 J', 1),
(24, 3, N'1,5.1020 J', 0),
(24, 4, N'-1,5.1020 J', 0),
(25, 1, N'Đường đi từ M đến N càng dài', 0),
(25, 2, N'Đường đi từ M đến N càng ngắn', 0),
(25, 3, N'Hiệu điện thế UMN càng nhỏ', 1),
(25, 4, N'Hiệu điện thế UMN càng lớn', 0),
(26, 1, N'n > √2', 1),
(26, 2, N'n > √3', 0),
(26, 3, N'n > 1,5', 0),
(26, 4, N'√3 > n > √2', 0),
(27, 1, N'1,2', 0),
(27, 2, N'2,5', 0),
(27, 3, N'1,55', 1),
(27, 4, N'3,21', 0),
(28, 1, N'I và II', 0),
(28, 2, N'II và IV', 0),
(28, 3, N'I và IV', 1),
(28, 4, N'II và III.', 0),
(29, 1, N'qo là điện tích dương', 0),
(29, 2, N'qo là điện tích âm', 1),
(29, 3, N'qo có thể là điên tích âm có thể là điện tích dương', 0),
(29, 4, N'qo phải bằng 0', 0),
--khối 12
(30, 1, N'30 mJ', 0),
(30, 2, N'4 mJ', 0),
(30, 3, N'22,5 mJ', 1),
(30, 4, N'25 mJ', 0),
(31, 1, N'rad/s.', 0),
(31, 2, N'100 Hz.', 0),
(31, 3, N'rad/s.', 0),
(31, 4, N'50 Hz.', 1),
(32, 1, N'0,5√3', 1),
(32, 2, N'0,5', 0),
(32, 3, N'0,5√2', 0),
(32, 4, N'0,75', 0),
(33, 1, N'125 kW.h', 1),
(33, 2, N'1250 kW.h', 0),
(33, 3, N'12,5 kW.h ', 0),
(33, 4, N'1,25 kW.h', 0),
(34, 1, N'Các proton ', 0),
(34, 2, N'Các nơtron', 0),
(34, 3, N'Các electron', 0),
(34, 4, N'Các nuclon', 1),
(35, 1, N'Có bước sóng giới hạn nhỏ hơn bước sóng giới hạn của hiện tượng quang điện ngoài.', 0),
(35, 2, N'Ánh sáng kích thích phải là ánh sáng tử ngoại.', 0),
(35, 3, N'Có thể xảy ra khi được chiếu bằng bức xạ hồng ngoại.', 1),
(35, 4, N'Có thể xảy ra đối với cả kim loại.', 0),
(36, 1, N' 0,6 mJ.', 0),
(36, 2, N'800 nJ.', 1),
(36, 3, N'1,2 mJ.', 0),
(36, 4, N'0,8 mJ.', 0)

-------------tiếng anh ----------------------
select * from cauHoi
insert into cauHoi values
--khối 10
(3, N'The workers/ stopped/ work/ take/ a rest/ because/ they/ felt/ tired.', 1, 1, 'K10'),
(3, N'Napoleon/ attack/ the/ West Indian island/ of/ Santo Domingo/ 1801.', 1, 1, 'K10'),
(3, N' This exit door can __________ in case of emergency.', 2, 1, 'K10'),
(3, N'More progress in gender equality will be made ___________ the Vietnamese government.', 2, 1, 'K10'),
(3, N'Each mediocre book we read means one less great book that we would otherwise have a chance ____________.', 1, 1, 'K10'),
(3, N'Men are traditional decision-makers _________ bread-winners.', 1, 1, 'K10'),
(3, N'I think women should continue __________ a career.', 1, 1, 'K10'),
-- khối 11
(3, N'“Were you chosen for the team?” “No, I’m too small – the ____________ height required is six foot two.”', 1, 1, 'K11'),
(3, N'My parents had always planned to open a restaurant, but it ________ to nothing.', 1, 1, 'K11'),
(3, N'I will see you again. We are all looking forward _______ again.', 2, 1, 'K11'),
(3, N'I usually ______ to school by bus.', 3, 1, 'K11'),
(3, N'Tom always _____ breakfast before going to work.', 1, 1, 'K11'),
(3, N'John is studying hard. He doesn’t want to fail the exam.', 2, 1, 'K11'),
(3, N'Jimmy can go out when he ____ for the exam.', 1, 1, 'K11'),
--khối 12
(3, N'A football match is divided_________ 2 rounds.', 3, 1, 'K12'),
(3, N'In a football team, defender takes the task of______________ opponents from scoring.', 1, 1, 'K12'),
(3, N'In water polo, a player ______________ after committing five personal fouls.', 2, 1, 'K12'),
(3, N'Many people don’t fancy playing parachute due to____________.', 2, 1, 'K12'),
(3, N'The Age of Enlightenment refers ___________ the time of the guiding intellectual movement.', 1, 1, 'K12'),
(3, N'I don’t think that men are ________ leaders than women.', 1, 1, 'K12'),
(3, N'Traditionally, men are not only considered decision-makers _________ also bread-winners.', 1, 1, 'K12')

insert into dapAn values
-- khối 10
(37, 1, N'The workers stopped work to take a rest because they felt tired.', 0),
(37, 2, N'The workers stopped to working take a rest because they felt tired.', 0),
(37, 3, N'The workers stopped working to take a rest because they felt tired.', 1),
(37, 4, N'The workers stopped to work taking a rest because they felt tired.', 0),
(38, 1, N'Napoleon attacks the West Indian island of Santo Domingo in 1801.', 0),
(38, 2, N' Napoleon attacking the West Indian island of Santo Domingo on 1801.', 0),
(38, 3, N'Napoleon attacked the West Indian island of Santo Domingo in 1801.', 1),
(38, 4, N'Napoleon attack the West Indian island of Santo Domingo on 1801.', 0),
(39, 1, N'be opened', 1),
(39, 2, N'open', 0),
(39, 3, N'to open', 0),
(39, 4, N'is opened', 0),
(40, 1, N'in', 0),
(40, 2, N'for', 0),
(40, 3, N'by', 1),
(40, 4, N'of', 0),
(41, 1, N'to read them', 0),
(41, 2, N'read', 0),
(41, 3, N'reading', 0),
(41, 4, N'to read', 1),
(42, 1, N'and', 1),
(42, 2, N'but', 0),
(42, 3, N'yet', 0),
(42, 4, N'or', 0),
(43, 1, N'pursue', 0),
(43, 2, N'pursues', 0),
(43, 3, N'pursued', 0),
(43, 4, N'pursuing', 1),
--khối 11
(44, 1, N'maximum', 0),
(44, 2, N'tallest', 0),
(44, 3, N'minimum', 1),
(44, 4, N'smallest', 0),
(45, 1, N'got', 0),
(45, 2, N'resulted', 0),
(45, 3, N'went', 1),
(45, 4, N'came', 0),
(46, 1, N'to see you', 0),
(46, 2, N'for seeing you', 0),
(46, 3, N'to seeing you', 1),
(46, 4, N'seeing you', 0),
(47, 1, N'go', 1),
(47, 2, N'goes', 0),
(47, 3, N'going', 0),
(47, 4, N'gone', 0),
(48, 1, N'have', 0),
(48, 2, N'had', 0),
(48, 3, N'has', 1),
(48, 4, N'is having', 0),
(49, 1, N'John is studying hard in Oder not to fail the next exam', 1),
(49, 2, N'John is studying hard in Oder that he not fail the next exam', 0),
(49, 3, N'John is studying hard so as to fail the next exam', 0),
(49, 4, N'John is studying hard in Oder to not to fail the next exam', 0),
(50, 1, N'has been studying', 0),
(50, 2, N'has been studied', 0),
(50, 3, N'has studied ', 1),
(50, 4, N'studied', 0),
--khối 12
(51, 1, N'in', 0),
(51, 2, N'on', 0),
(51, 3, N'up', 0),
(51, 4, N'into', 1),
(52, 1, N'prevent', 0),
(52, 2, N'being prevented', 0),
(52, 3, N'preventing', 1),
(52, 4, N'to prevent', 0),
(53, 1, N'ejects', 0),
(53, 2, N'is ejected', 1),
(53, 3, N'eject', 0),
(53, 4, N'will eject', 0),
(54, 1, N'It is very dangerous.', 0),
(54, 2, N'It’s dangerous.', 0),
(54, 3, N'Its danger', 1),
(54, 4, N'They are afraid of some dangerous.', 0),
(55, 1, N'in', 0),
(55, 2, N'to', 1),
(55, 3, N'for', 0),
(55, 4, N'with', 0),
(56, 1, N'good', 0),
(56, 2, N'gooder', 0),
(56, 3, N'better', 1),
(56, 4, N'well', 0),
(57, 1, N'and', 0),
(57, 2, N'but', 1),
(57, 3, N'yet', 0),
(57, 4, N'or', 0)


--insert into cauHoi values 
----khoi 10 -- mon sử
----(1, N'Những nước nào tham gia Hội nghị Ianta ?', 1, 1, 'K10'),--58
----(1, N'Kế hoạch 5 năm khôi phục kinh tế sau chiến tranh ở Liên Xô diễn ra trong khoảng thời gian nào ?', 2, 1, 'K10'),--59
----(1, N'Trong số các nước sau, nước nào không thuộc khu vực Đông Bắc Á ?', 3, 1, 'K10'),--60
----(1, N'Từ 1945 đến 1950, Mĩ là:', 4, 1, 'K10'),--61
----(1, N'Đặc điểm của quan hệ quốc tế sau Chiến tranh thế giới thứ II là:', 5, 1, 'K10'),--62
----(1, N'Yếu tố thúc đẩy sự bùng nổ cuộc cách mạng khoa học - kỹ thuật ở giữa thế kỷ XX ?', 6, 1, 'K10'),--63
----(1, N'Chương trình khai thác thuộc địa Việt Nam lần thứ hai của thực dân Pháp diễn ra trong hoàn cảnh nào ?', 7, 1, 'K10'),--64
----(1, N'Mâu thuẫn cơ bản trong xã Hội Việt Nam trong thời kì khủng hoảng kinh tế (1929 - 1933)?', 8, 1, 'K10'),--65
----(1, N'Điền thêm từ còn thiếu trong câu nói sau của Bác Hồ : "Giặc đói, giặc dốt là ... của giặc ngoại xâm" .', 8, 1, 'K10'),--66
----(1, N'Ngày 10/10/1954, sự kiện quan trọng nào đã xảy ra :', 9, 1, 'K10')--67
--(1, N'Một trong những nội dung quan trọng của Hội nghị Ianta là: ', 2, 1, 'K10'),--68
--(1, N'Dấu hiệu nào chứng tỏ sau Chiến tranh thế giới thứ II, Mĩ là một trung tâm kinh tế - tài chính lớn nhất thế giới ?', 4, 1, 'K10'),--69
--(1, N'Nước khởi đầu cuộc cách mạng khoa học - kĩ thuật lần thứ hai là:', 6, 1, 'K10'),--70
--(1, N'Từ năm 1951 đến năm 1956, Tổng bí thư Đảng Cộng sản Việt Nam là ai?', 8, 1, 'K10'),--71
--(1, N'Tính chất của nền kinh tế Miền Nam sau khi giải phóng?', 4, 1, 'K10'),--72

----khoi 11
--(1, N'Từ đầu thế kỉ XIX đến trước năm 1868, đặc điểm bao trùm của nền kinh tế Nhật Bản là gì?', 1, 1, 'K11'),--73
--(1, N'Ý nào không phản ánh đúng nét mới của nền kinh tế Nhật Bản từ đầu thế kỉ XIX đến trước năm 1868?', 2, 1, 'K11'),--74
--(1, N'Sự kiện lịch sử thế giới nổi bật vào năm 1914 là', 4, 1, 'K11'),--75
--(1, N'Trong bối cảnh lịch sử từ giữa thế kỉ XVI đến cuối thế kỉ XVIII được gọi là', 8, 1, 'K11'),--76
--(1, N'Sau Chiến tranh thế giới thứ nhất, các nước tư bản đã tổ chức Hội nghị hòa bình tại đâu, vào thời gian nào?', 7, 1, 'K11'),--77
--(1, N'Những nước giành được nhiều quyền lợi trong trật tự thế giới mới sau Chiến tranh thế giới thứ nhất là', 5, 1, 'K11'),--78
--(1, N'Đường lối đấu tranh của M. Ganđi trong những năm 30 của thế kỉ XX là', 3, 1, 'K11'),--79
--(1, N'Quá trình phát xít hóa bộ máy nhà nước ở Nhật Bản diễn ra thông qua quá trình nào?', 3, 1, 'K11'),--80
--(1, N'Chiến tranh tg thứ hai bùng nổ do mâu thuẫn giữa?', 3, 1, 'K11'),--81
--(1, N'Việc Mĩ ném hai quả bom nguyên tử xuống lãnh thổ Nhật Bản là hành động?', 3, 1, 'K11'),--82
--(1, N'Hệ quả quan trọng nhất của Chiến tranh tg thứ hai là?', 3, 1, 'K11'),--83
--(1, N'Vì sao cuối thế kỉ XVIII, thực dân Pháp không thực hiện được ý đồ xâm lược Việt Nam?', 10, 1, 'K11'),--84
--(1, N'Thực dân Pháp đánh chiếm thành Hà Nội lần thứ hai vào năm nào, lúc đó ai là Tổng đốc thành Hà Nội?', 8, 1, 'K11'),--85
--(1, N'Mục tiêu của phong trào cần vương thế kỉ XIX ở Việt Nam là?', 7, 1, 'K11'),--86
--(1, N'Hưởng ứng phong trào cần vương, cuộc khởi nghĩa nào dưới đây nổ ra đầu tiên?', 8, 1, 'K11'),--87

----khoi 12
--(1, N'Ý nào sau đây không phù hợp với loài vượn cổ trong quá trình tiến hóa thành người ?', 1, 1, 'K12'),--88
--(1, N'Xương hóa thạch của loài vượn cổ được tìm thấy ở đâu ?', 1, 1, 'K12'),--89
--(1, N'Di cốt của người tối cổ được tìm thấy ở đâu ?', 1, 1, 'K12'),--90
--(1, N'Đến thế kỉ VII, Ấn Độ bị chia rẽ thành ?', 2, 1, 'K12'),--91
--(1, N'Sự phân biệt chia rẽ ở Ấn Độ vào thế kỉ VII không chứng tỏ ?', 4, 1, 'K12'),--92
--(1, N'Điểm nổi bật của Ấn Độ từ thế kỉ VII đến thế kỉ XII là gì ?', 4, 1, 'K12'),--93
--(1, N'Nguyên nhân chính khiến Ấn Độ bị người Hồi giáo xâm chiếm là ?', 4, 1, 'K12')--94
--(1, N'Hoạt động kinh tế phổ biến của cư dân Phù Nam là ?', 4, 1, 'K12'),--95
--(1, N'Điểm giống trong đời sống kinh tế của cư dân Văn Lang - Âu Lạc và Champa, Phù Nam là ?', 4, 1, 'K12'),--96
--(1, N'Nhà nước Âu Lạc là ?', 5, 1, 'K12'),--97
--(1, N'So với Anh, việc xuất khẩu tư bản của Pháp có điểm khác là ?', 5, 1, 'K12'),--98
--(1, N'Các tổ chức độc quyền ở Đức được hình thành dưới hình thức ?', 5, 1, 'K12'),--99
--(1, N'Người đặt nền tảng cho việc tìm kiếm năng lượng hạt nhân ?', 5, 1, 'K12'),--100
--(1, N'Học thuyết Tiến hóa là do nhà bác học nào nêu ra ?', 8, 1, 'K12'),--101
--(1, N'Việc sử dụng động cơ đốt trong đã tạo ra khả năng phát triển ngành nào ?', 9, 1, 'K12')--102


--insert into cauHoi values 
----monhoa 10
----(2, N'Nguyên tử vàng có 79 electron ở vỏ nguyên tử. Điện tích hạt nhân của nguyên tử vàng là ?', 1, 1, 'K10'),--103
----(2, N'Một nguyên tử có 12 proton và 12 nơtron trong hạt nhân. Điện tích của ion tạo thành khi nguyên tử này bị mất 2 electron là ?', 2, 1, 'K10'),--104
----(2, N'Trong nguyên tử, loại hạt nào có khối lượng không đáng kể so với các hạt còn lại ?', 2, 1, 'K10'),--105
----(2, N'Tinh thể nào sau đây là tinh thể nguyên tử ?', 2, 1, 'K10'),--106
----(2, N'Khẳng định nào sau đây sai: ', 5, 1, 'K10'),--107
----(2, N'Cấu trúc của tinh thể phân tử nước đá thuộc loại cấu trúc nào: ', 5, 1, 'K10'),--108
----(2, N'Iot, băng phiến dễ hòa tan tỏng các dung môi nào dưới đây: ', 7, 1, 'K10'),--109
----(2, N'Khi cho đá vào cốc nước ta thấy đá nổi lên là do: ', 8, 1, 'K10'),--110
----(2, N'Trong công nghiệp, người ta điều chế oxi bằng cách: ', 5, 1, 'K10'),--111
----(2, N'Để phản ứng vừa đủ với 100 ml dung dịch BaCl2 2M cần 500 ml dung dịch Na2SO4 a (mol/l). Giá trị của a là: ', 9, 1, 'K10'),--112
----(2, N'Chọn cấu hình electron không đúng: ', 5, 1, 'K10'),--113
----(2, N'Trong nguyên tử, electron hóa trị là các electron: ', 3, 1, 'K10'),--114
----(2, N'Cấu hình electron của nguyên tử nguyên tố X có dạng [Ne]3s23p3. Phát biểu nào sau đây là sai? ', 4, 1, 'K10'),--115
----(2, N'Hóa trị và số oxi hóa của N trong phân tử NH4Cl lần lượt là ', 7, 1, 'K10'),--116
----(2, N'Trong hợp chất cộng hóa trị, hóa trị của một nguyên tố: ', 4, 1, 'K10')--117

----khoi 11
----(2, N'Các chất dẫn điện là: ', 1, 1, 'K11'),--118
----(2, N'Trong dung dịch axit nitric (bỏ qua sự phân li của H2O) có những phần tử nào ? ', 2, 1, 'K11'),--119
----(2, N'Chất nào sau đây không dẫn điện được ? ', 3, 1, 'K11'),--120
----(2, N'Quặng nào sau đây chứa CaCO3  ? ', 4, 1, 'K11'),--121
----(2, N'CO không khử được các oxit trong nhóm nào sau đây  ? ', 5, 1, 'K11'),--122
----(2, N'Nhóm nào sau đây gồm các muối không bị nhiệt phân  ? ', 6, 1, 'K11'),--123
----(2, N'Công thức tổng quát của ankan là  ? ', 8, 1, 'K11'),--124
----(2, N'Số đồng phân cấu tạo ứng với công thức phân tử C5H12 là  ? ', 8, 1, 'K11'),--125
----(2, N'Ankan (CH3)2CHCH2C(CH3)3 có tên gọi là  ? ', 8, 1, 'K11'),--126
----(2, N'Ankan X có công thức phân tử C6H14. Clo hóa X, thu được 4 sản phẩm dẫn xuất monoclo. Tên gọi của X là  ? ', 8, 1, 'K11'),--127
----(2, N'Ankan X có chứa 82,76% cacbon theo khối lượng. Số nguyên tử hiđro trong một phân tử X là  ? ', 9, 1, 'K11'),--128
----(2, N'Ankan X có chứa 14 nguyên tử hiđrô trong phân tử. Số nguyên tử cacbon trong một phân tử X là  ? ', 9, 1, 'K11'),--129
----(2, N'Dãy đồng đẳng benzen có công thức chung là  ? ', 6, 1, 'K11'),--130
----(2, N'Công thức phân tử của Strien là  ', 5, 1, 'K11'),--131
----(2, N'Công thức phân tử của toluen là  ', 5, 1, 'K11  ')--132
--(2, N'Ứng với công thức C4H8O2 có bao nhiêu este là đồng phân của nhau ?  ', 1, 1, 'K12'),--133
--(2, N'Este có mùi dứa là  ', 1, 1, 'K12'),--134
--(2, N'Đun nóng este HCOOCH3 với một lượng vừa đủ dung dịch NaOH, sản phẩm thu được là  ', 2, 1, 'K12'),--135
--(2, N'Este nào sau đây khi phản ứng với dung dịch NaOH dư, đun nóng không tạo ra hai muối ?  ', 2, 1, 'K12'),--136
--(2, N'Xà phòng hoá chất nào sau đây thu được glixerol ?  ', 3, 1, 'K12'),--137
--(2, N'Phát biểu nào sau đây không đúng  ?  ', 4, 1, 'K12'),--138
--(2, N'Đốt cháy hoàn toàn 0,9 gam một loại gluxit X thu được 1,32 gam CO2 và 0,54 gam H2O. X là chất nào trong số các chất sau ? ', 5, 1, 'K12'),--139
--(2, N'Lượng glucozơ cần dùng để tạo ra 1,82 gam sobitol vói hiệu suất 80% là ? ', 5, 1, 'K12'),--140
--(2, N'Cho a gam glucozơ phản ứng với dung dịch AgNO3/NH3 tạo thành a gam Ag. Phần trăm của glucozơ tham gia phản ứng là ? ', 6, 1, 'K12'),--141
--(2, N'Phát biểu nào sau đây không đúng: ', 4, 1, 'K12'),--142
--(2, N'Để chứng minh trong phân tử của glucozơ có nhiều nhóm hiđroxyl, người ta cho dung dịch glucozơ phản ứng với: ', 4, 1, 'K12'),--143
--(2, N'Phát biểu nào sau đây là sai ? ', 4, 1, 'K12'),--144
--(2, N'Xét 2 nguyên tố ở vị trí 19 và 29 trong bảng tuần hoàn. Kết luận nào sau đây là sai  ? ', 2, 1, 'K12'),--145
--(2, N'Kim loại M phản ứng với oxi để tạo thành oxit. Khối lượng oxi đã phản ứng bằng 40% khối lượng kim loại đã dùng. Kim loại M là ', 7, 1, 'K12'),--146
--(2, N'Nhóm A bao gồm các nguyên tố: ', 1, 1, 'K12')--147
--insert into dapAn values
--(133,1,N'isoamyl axetat.',0),
--(133,2,N'etyl butirat.',0),
--(133,3,N'etyl axetat.',1),
--(133,4,N'geranyl axctat.',0),
--(134,1,N'2.',0),
--(134,2,N'3.',1),
--(134,3,N'4.',0),
--(134,4,N'5.',0),
--(135,1,N'CH3COONa và C2H5OH.',0),
--(135,2,N'HCOONa và CH3OH..',1),
--(135,3,N'HCOONa và C2H5OH.',0),
--(135,4,N'CH3COONa và CH3OH.',0),
--(136,1,N'C6H5COOC6H5 (phenyl benzoat).',0),
--(136,2,N'CH3COO-[CH2]2-OOCCH2CH3.',0),
--(136,3,N'CH3OOC-COOCH3.',1),
--(136,4,N'CH3COOC6H5 (phenyl axetat).',0),
--(137,1,N'tristearin .',1),
--(137,2,N'metyl axetat.',0),
--(137,3,N'metyl fomat.',0),
--(137,4,N'benzyl axetat.',0),
--(138,1,N'Triolein có khả năng tham gia phản ứng cộng hiđro khi đun. nóng có xúc tác Ni .',0),
--(138,2,N'Các chất béo thường không tan trong nước và nhẹ hơn nước.',0),
--(138,3,N'Chất béo bị thuỷ phân khi đun nóng trong dung dịch kiềm.',0),
--(138,4,N'Chất béo là trieste của etylen glicol với các axit béo.',1),
--(139,1,N'glucozơ .',1),
--(139,2,N'saccarozơ.',0),
--(139,3,N'tinh bột.',0),
--(139,4,N'xenlulozơ.',0),
--(140,1,N'2,25 gam .',1),
--(140,2,N'1,80 gam.',0),
--(140,3,N'1,82 gam.',0),
--(140,4,N'1,44 gam..',0),
--(141,1,N'83,33% .',1),
--(141,2,N'41,66%.',0),
--(141,3,N'75,00%',0),
--(141,4,N'37,50%.',0),
--(142,1,N'Glucozơ tác dụng được với nước brom .',0),
--(142,2,N'Khi glucozơ tác dụng với CH3COOH (dư) cho este 5 chức.',0),
--(142,3,N'Glucozơ tồn tại ở dạng mạch hở và dạng mạch vòng',0),
--(142,4,N'Ở dạng mạch hở, glucozơ có 5 nhóm OH kề nhau.',1),
--(143,1,N'Kim loại Na .',0),
--(143,2,N'Cu(OH)2 ở nhiệt độ thường',1),
--(143,3,N'AgNO3 (hoặc Ag2O) trong dung dịch NH3, đun nóng',0),
--(143,4,N'Cu(OH)2 trong NaOH, đun nóng',0),
--(144,1,N'Trong một chu kì, khi điện tích hạt nhân tăng thì tính kim loại tăng dần .',1),
--(144,2,N'Trong một nhóm theo chiều tăng dần của điện tích hạt nhân, tính kim loại tăng',0),
--(144,3,N'Kim loại có độ âm điện bé hơn phi kim trong cùng chu kì.',0),
--(144,4,N'Đa số các kim loại đều có cấu tạo tinh thể',0),
--(145,1,N'Hai nguyên tố này cùng là kim loại .',0),
--(145,2,N'Hai nguyên tố này thuộc cùng một chu’kì.',0),
--(145,3,N'Hai nguyên tố này có cùng số e lớp ngoài cùng ở trạng thái cơ bản.',0),
--(145,4,N'Hai nguyên tố này cùng là nguyên tố s.',1),
--(146,1,N'Na .',0),
--(146,2,N'Ca.',1),
--(146,3,N'Fa.',0),
--(146,4,N'AL',0),
--(147,1,N'Nguyên tố s .',0),
--(147,2,N'Nguyên tố p.',0),
--(147,3,N'Nguyên tố d và nguyên tố f.',0),
--(147,4,N'Nguyên tố s và nguyên tố p',1)
--(118,1,N'KCL nóng chảy, dung dịch NaOH, dung dịch HNO3.',1),
--(118,2,N'dung dịch glucozơ , dung dịch ancol etylic , glixerol.',0),
--(118,3,N'KCL rắn khan, NaOH rắn khan, kim cương.',0),
--(118,4,N'Khí HCL, khí NO, khí O3.',0),
--(119,1,N'H+, NO3-.',0),
--(119,2,N'H+, NO3-, H2O.',1),
--(119,3,N'H+, NO3-, HNO3.',0),
--(119,4,N'H+, NO3-, HNO3, H2O.',0),
--(120,1,N'KCl rắn, khan.',1),
--(120,2,N'CaCl2 nóng chảy.',0),
--(120,3,N'NaOH nóng chảy.',0),
--(120,4,N'NaOH nóng chảy.',0),
--(121,1,N'dolomit.',0),
--(121,2,N'cacnalit.',1),
--(121,3,N'pirit.',0),
--(121,4,N'xiderit.',0),
--(122,1,N'Fe2O3, MgO.',0),
--(122,2,N'MgO, Al2O3.',1),
--(122,3,N'Fe2O3, CuO.',0),
--(122,4,N' ZnO, Fe2O3,.',0),
--(123,1,N'CaCO3 + HCl.',0),
--(123,2,N' CaCO3 (to cao).',1),
--(123,3,N'C + O2 (to cao)',0),
--(123,4,N' CO + O2 (to cao).',0),
--(124,1,N'CnHn+2.',0),
--(124,2,N'CnH2n+2.',1),
--(124,3,N'CnH2n ',0),
--(124,4,N'CnH2n-2.',0),
--(125,1,N'6.',0),
--(125,2,N'4.',0),
--(125,3,N'5 ',0),
--(125,4,N'3.',1),
--(126,1,N'2,2,4-trimetylpentan.',1),
--(126,2,N'2,2,4,4-tetrametybutan.',0),
--(126,3,N'2,4,4-trimetylpentan ',0),
--(126,4,N'2,4,4,4-tetrametylbutan.',0),
--(127,1,N'2,2-đimetylbutan.',0),
--(127,2,N'3- metylpentan.',1),
--(127,3,N'hexan ',0),
--(127,4,N'2,3- đimetylbutan.',0),
--(128,1,N'6',0),
--(128,2,N'5.',1),
--(128,3,N'10 ',0),
--(128,4,N'12.',0),
--(129,1,N'4',0),
--(129,2,N'5.',1),
--(129,3,N'6 ',0),
--(129,4,N'7',0),
--(130,1,N'CnH2n+2',0),
--(130,2,N'CnH2n-2.',1),
--(130,3,N'CnH2n-4 ',0),
--(130,4,N'CnH2n-6',0),
--(131,1,N'C6H6',0),
--(131,2,N'C7H8.',0),
--(131,3,N'C8H8 ',1),
--(131,4,N'C8H10',0),
--(132,1,N'C6H6',0),
--(132,2,N'C7H8.',1),
--(132,3,N'C8H8 ',0),
--(132,4,N'C8H10',0)
--(103,1,N'+79.',0),
--(103,2,N'-79.',0),
--(103,3,N'1,26.10-17.',0),
--(103,4,N'+1,26.10-17 C.',1),
--(104,1,N'2+.',0),
--(104,2,N'12+.',0),
--(104,3,N'24+.',0),
--(104,4,N'10+.',1),
--(105,1,N'proton',0),
--(105,2,N'nơtron',0),
--(105,3,N'electron',1),
--(105,4,N'nơtron và electron',0),
--(106,1,N'Iot',0),
--(106,2,N'Băng phiến',0),
--(106,3,N'Nước đá',1),
--(106,4,N'Kim cương',0),
--(107,1,N'Lực tương tác giữa các phân tử trong tinh thể phân tử rất yếu',0),
--(107,2,N'Cấu tạo tinh thể thường mềm',0),
--(107,3,N'Tinh thể phân tử có nhiệt độ nóng chảy thấp, dễ bay hơi',0),
--(107,4,N'Trong tinh thể phân tử, liên kết giữa các phân tử là liên kết cộng hóa trị',1),
--(108,1,N'Tứ diện',1),
--(108,2,N'Chữ V',0),
--(108,3,N'Thẳng',0),
--(108,4,N'Bát diện',0),
--(109,1,N'Benzen, ancol, hexan',0),
--(109,2,N'Nước, toluen, benzen',0),
--(109,3,N'Benzen, toluen, hexan',1),
--(109,4,N'Toluen, benzen, ancol',0),
--(110,1,N'Nước đá có cấu trúc rỗng nên nước đã có tỉ khối nhỏ hơn khi nước ở trạng thái lỏng',1),
--(110,2,N'Nước đá là chất rắn',0),
--(110,3,N'Nước đá đang trong quá trình tan',0),
--(110,4,N'Nước đá có nhiệt độ thấp hơn nhiệt độ nước thường',0),
--(111,1,N'nhiệt phân KMnO4',1),
--(111,2,N'nhiệt phân Cu(NO3)2',0),
--(111,3,N'nhiệt phân KClO3 có xúc tác MnO2',0),
--(111,4,N'chưng cất phân đoạn không khí lỏng',0),
--(112,1,N'0,1',1),
--(112,2,N'0,4',0),
--(112,3,N'0,5',0),
--(112,4,N'0,2',0),
--(113,1,N'1s2/2s2/2p5.',1),
--(113,2,N'1s2/2s2/2p6/3s2.',0),
--(113,3,N'1s2/2s2/2p6/3s2/3p5.',0),
--(113,4,N'1s2/2s2/2p6/3s2/3p3/4s2',0),
--(114,1,N'độc thân.',1),
--(114,2,N'ở phân lớp ngoài cùng.',0),
--(114,3,N'ở obitan ngoài cùng.',0),
--(114,4,N' tham gia tạo liên kết hóa học.',0),
--(115,1,N'X ở ô số 15 trong bảng tuần hoàn.',0),
--(115,2,N'X là một phi kim.',0),
--(115,3,N'Nguyên tử của nguyên tố X có 9 electron p.',0),
--(115,4,N'Nguyên tử của nguyên tố X có 3 phân lớp electron.',1),
--(116,1,N'4 và -3.',1),
--(116,2,N'3 và +5',0),
--(116,3,N'5 và +5',0),
--(116,4,N'3 và -3',0),
--(117,1,N'Bằng số liên kết của nguyên tử nguyên tố đó tạo ra được với các nguyên tử khác trong phân tử và được gọi là cộng hóa trị của nguyên tố đó',1),
--(117,2,N'Bằng số liên kết của nguyên tử nguyên tố đó trong phân tử và được gọi là điện hóa trị của nguyên tố đó',0),
--(117,3,N'Bằng số electron liên kết với nguyên tử của nguyên tố khác trong phân tử',0),
--(117,4,N'Bằng số liên kết của nguyên tử nguyên tố đó với nguyên tử gần nhất',0)
--(95,1,N'Quý tộc, địa chủ, nông dân',0),
--(95,2,N'Quý tộc, bình dân, nô lệ.',1),
--(95,3,N'Quý tộc, tăng lữ, nông dân, nô tì.',0),
--(95,4,N'Thủ lĩnh quân sự, quý tộc tăng lữ, bình dân, nô tì.',0),
--(96,1,N'Làm nông nghiệp trồng lúa, kết hợp với một số nghề thủ công',1),
--(96,2,N'Chăn nuôi rất phát triển.',0),
--(96,3,N'Đẩy mạnh giao lưu buôn bán với bên ngoài.',0),
--(96,4,N'Nghề khai thác lâm thổ sản khá phát triển.',0),
--(97,1,N'Sự kế tục nhưng mở rộng hơn về lãnh thổ và hoàn chỉnh hơn về tổ chức so với nước Văn Lang',1),
--(97,2,N'Một nhà nước riêng biệt, không có điểm gì chung so với nhà nước Văn Lang.',0),
--(97,3,N'Sự thu hẹp của nhà nước Văn Lang.',0),
--(97,4,N'Một nhà nước của tộc người không phải là người Việt.',0),
--(98,1,N'Chú trọng xuất khẩu sang các thuộc địa',0),
--(98,2,N'Chỉ chú trọng cho vay với lãi xuất nặng.',1),
--(98,3,N'Chỉ chú trọng cho Nga vay.',0),
--(98,4,N'Bị Đức, Mĩ cạnh tranh gay gắt.',0),
--(99,1,N'Tơrớt',0),
--(99,2,N'Cácten.',0),
--(99,3,N'Xanhđica.',0),
--(99,4,N'Cácten và Xanhđica.',1),
--(100,1,N'Maicơn Pharađây',0),
--(100,2,N'Pie Quyri và Mari Quyri.',1),
--(100,3,N'Rơnghen.',0),
--(100,4,N'Jun.',0),
--(101,1,N'Đácuyn',1),
--(101,2,N'Lômônôxốp.',0),
--(101,3,N'Pápl.',0),
--(101,4,N'Lenxơ.',0),
--(102,1,N'Chế tạo ô tô',1),
--(102,2,N'Chế tạo máy bay.',0),
--(102,3,N'Khai thác mỏ.',0),
--(102,4,N'Giao thông vận tải.',0)
--(88,1,N'Sống cách đây 6 triệu năm',0),
--(88,2,N'Có thể đứng và đi bằng 2 chân.',0),
--(88,3,N'Tay được dung để cầm nắm.',0),
--(88,4,N'Chia thành các chủng tộc lớn.',1),
--(89,1,N'Đông Phi, Tây Á, Bắc Á.',0),
--(89,2,N'Đông Phi, Tây Á, Đông Nan Á.',0),
--(89,3,N'Đông Phi, Việt Nam, Trung Quốc.',1),
--(89,4,N'Tây Á, Trung Á, Bắc Mĩ.',0),
--(90,1,N'Đông Phi, Trung Quốc, Bắc Âu.',0),
--(90,2,N'Đông Phi, Tây Á, Bắc Âu.',0),
--(90,3,N'Đông Phi, Inội dungonexia, Đông Nam Á.',1),
--(90,4,N'Tây Á, Trung Quốc, Bắc Âu.',0),
--(91,1,N'Hai nước.',0),
--(91,2,N'Ba nước.',0),
--(91,3,N'Bốn nước.',0),
--(91,4,N'Sáu nước.',1),
--(92,1,N'Tình trạng khủng hoảng, suy thoái của Ấn Độ.',1),
--(92,2,N'Sự phát triển tự cường của các vùng địa phương.',0),
--(92,3,N'Sự phát triển của các vùng xa hơn.',0),
--(92,4,N'Văn hóa truyền thống Ấn Độ được truyền bá, phát triển rộng trên toàn lãnh thổ và ảnh hưởng ra bên ngoài.',0),
--(93,1,N'Văn hóa truyền thống Ấn Độ phát triển rộng ra toàn lãnh thổ.',0),
--(93,2,N'Văn hóa truyền thống Ấn Độ được phổ biến tích cực ra bên ngoài.',0),
--(93,3,N'Là thời kì văn hóa truyền thống Ấn Độ phát triển rộng khắp đất nước và có ảnh hưởng ra bên ngoài.',1),
--(93,4,N'Đất nước bị phân tán nhưng vẫn phát triển cường thịnh.',0),
--(94,1,N'Ấn Độ bị chia rẽ và phân tán thành nhiều quốc gia.',0),
--(94,2,N'Người dân Ấn Độ phần lớn đạo Hồi.',0),
--(94,3,N'Trình độ kinh tế, quân sự của Ấn Độ kém phát triển hơn.',1),
--(94,4,N'Địa hình Ấn Độ bị chia rẽ, cô lập với bên ngoài.',0),
--(73,1,N'Nông nghiệp lạc hậu',1),
--(73,2,N'Công nghiệp phát triển',0),
--(73,3,N'Thương mại hàng hóa.',0),
--(73,4,N'Sản xuất quy mô lớn.',0),
--(74,1,N'Công trường thủ công xuất hiện ngày càng nhiều',0),
--(74,2,N'Kinh tế hàng hóa phát triển mạnh',0),
--(74,3,N'Tư bản nước ngoài đầu tư nhiều ở Nhật Bản.',1),
--(74,4,N'Những mầm mống kinh tế tư bản chủ nghĩa phát triển.',0),
--(75,1,N'Hội nghị Vescxai được khai mạc tại Pháp',0),
--(75,2,N'Hội nghị Oasinhtơn được tổ chức tại Mĩ',0),
--(75,3,N'Cách mạng tháng Mười Nga bùng nổ.',0),
--(75,4,N'Chiến tranh thế giới thứ nhất bùng nổ.',1),
--(76,1,N'buổi đầu thời cận đại',1),
--(76,2,N'kết thúc thời cận đại',0),
--(76,3,N'trung kì thời cận đại.',0),
--(76,4,N'buổi đầu thời hiện đại.',0),
--(77,1,N'Pari ( 1919-1920) và Luân Đôn (1920 – 1921)',0),
--(77,2,N'Vécxai (1919 – 1920) và Oasinhtơn (1921-1922)',1),
--(77,3,N'Luân Đôn (1919 – 1920) và Oasinhtơn (1921 – 1922).',0),
--(77,4,N'Oasinhtơn (1919 – 1920) và Vécxai (1921 – 1922).',0),
--(78,1,N'Liên Xô, Anh, Pháp, Mĩ ',0),
--(78,2,N'Anh, Pháp, Mĩ, Nhật Bản',1),
--(78,3,N'Anh, Đức, Mĩ, Nhật Bản',0),
--(78,4,N'Italia, Pháp, Mĩ, Nhật Bản',0),
--(79,1,N'Đấu tranh bạo lực, bất hợp tác với thực dân Anh ',0),
--(79,2,N'Đấu tranh bạo lực, hợp tác với thực dân Anh',0),
--(79,3,N'Đấu tranh hòa bình, bất hợp tác với thực dân Anh',1),
--(79,4,N'Đấu tranh hòa bình, hợp tác với thực dân Anh',0),
--(80,1,N'Chuyển từ chế độ dân chủ đại nghị sang chuyên chế độc tài ',0),
--(80,2,N'Thay thế nền dân chủ đại nghị bằng việc quân phiệt hóa bộ máy nhà nước',0),
--(80,3,N'Đảo chính lật đổ chế độ quân chủ lập hiến, thiết lập chế độ quân phiệt',0),
--(80,4,N'Quân phiệt hóa bộ máy nhá nước và tiến hành chiến tranh xâm lược thuộc địa',1),
--(81,1,N'Các nước đế quốc với nhau ',0),
--(81,2,N'Các nước phát xít với các nước tư bản dân chủ',0),
--(81,3,N'Các nước phát xít với Liên Xô',0),
--(81,4,N'Các nước đế quốc với nhau và giữa các nước đế quốc với Liên Xô',1),
--(82,1,N'Cần thiết và có ý nghĩa quyết định kết thúc chiến tranh ',0),
--(82,2,N'Không cần thiết vì quân phiệt Nhật Bản đã liên tiếp thua trận và đứng trước sự sụp đổ',0),
--(82,3,N'Góp phần kết thúc chiến tranh',1),
--(82,4,N'Không cần thiết vì quân phiệt Nhật đã đầu hàng',0),
--(83,1,N'Dẫn đến những thay đổi căn bản trong tình hình tg ',1),
--(83,2,N'Hình thành trật tự tg hai cực',0),
--(83,3,N'Làm sụp đổ hệ thống Vécxai – Oasinhtơn',0),
--(83,4,N'Tiêu diệt hoàn toàn chủ nghĩa phát xít',0),
--(84,1,N'Vì chúng chưa chuẩn bị đầy đủ các điều kiện cho cuộc chiến tranh xâm lược ',0),
--(84,2,N'Vì triều đại phong kiến Việt Nam còn mạnh',0),
--(84,3,N'Vì chúng chưa có thế lực nội ứng ở Việt Nam.',0),
--(84,4,N'Vì những diễn biến chính trị năm 1789 và điều kiện khó khăn về kinh tế tài chính.',1),
--(85,1,N'Năm 1883, Tổng đốc thành Hà Nội là Nguyễn Tri Phương ',0),
--(85,2,N'Năm 1882, Tổng đốc thành Hà Nội là Hoàng Diệu.',1),
--(85,3,N'Năm 1885, Tổng đốc thành Hà Nội là Tôn Thất thuyết.',0),
--(85,4,N'Năm 1884, Tổng đốc thành Hà Nội là Lưu Vĩnh Phúc.',0),
--(86,1,N'phò vua, cứu nước ',1),
--(86,2,N'giải phóng dân tộc.',0),
--(86,3,N'chống triều đình Huế.',0),
--(86,4,N'chống các thế lực phản động ở các địa phương.',0),
--(87,1,N'Khởi nghĩa Hùng Lĩnh ',0),
--(87,2,N'Khởi nghĩa Hương Khê.',0),
--(87,3,N'Khởi nghĩa Ba Đình.',0),
--(87,4,N'Khởi nghĩa Bãi Sậy.',1),
--(68,1,N'Đàm phán, kí kết các hiệp ước với các nước phát xít bại trận',0),
--(68,2,N'Các nước thắng trận thoả thuận việc phân chia Đức thành hai nước Đông Đức và Tây Đức',0),
--(68,3,N'Ba nước phe Đồng minh bàn bạc, thoả thuận khu vực đóng quân tại các nước nhằm giải giáp quân đội phát xít; phân chia phạm vi ảnh hưởng ở châu Âu và châu Á.',1),
--(68,4,N'Các nước phát xít Đức, Italia kí văn kiện đầu hàng phe Đồng minh vô điều kiện.',0),
--(69,1,N'Sản lượng công nghiệp Mĩ nửa sau những năm 40 chiếm gần 40% tổng sản lượng công nghiệp toàn thế giới.',0),
--(69,2,N'Kinh tế Mĩ chiếm gần 40% tổng sản phẩm kinh tế thế giới.',1),
--(69,3,N'Sản lượng công nghiệp Mĩ nửa sau những năm 40 chiếm hơn 60% tổng sản lượng công nghiệp toàn thế giới.',0),
--(69,4,N'Kinh tế Mĩ chiếm hơn 50% tổng sản phẩm kinh tế thế giới.',0),
--(70,1,N'Anh',0),
--(70,2,N'Nhật.',1),
--(70,3,N'Mĩ',0),
--(70,4,N'Liên Xô',0),
--(71,1,N'Nguyễn Văn Cừ',0),
--(71,2,N'Hồ Chí Minh.',0),
--(71,3,N'Trường Trinh.',0),
--(71,4,N'Lê Duẩn.',1),
--(72,1,N'Kinh tế xã hội chù nghĩa',0),
--(72,2,N'Kinh tế Tư bản chủ nghĩa.',0),
--(72,3,N'Kinh tế nông nghiệp, sản xuất nhỏ và phân tán, phát triển không cân đối.',1),
--(72,4,N'Kinh tế công nghiệp tiên tiến.',0)
--(58,1,N'Anh - Pháp - Mĩ.',0)
--(58,2,N'Anh - Mĩ - Liên Xô.',1),
--(58,3,N'Anh - Pháp - Mĩ.',0),
--(58,4,N'Mĩ - Liên Xô - Trung Quốc.',0)
--(59,1,N'1945 – 1949.',0),
--(59,2,N'1946- 1950.',1),
--(59,3,N'1947-1951.',0),
--(59,4,N'1945- 1951.',0)
--(60,1,N'Trung Quốc, Nhật Bản.',0),
--(60,2,N'Hàn Quốc, Đài Loan.',1),
--(60,3,N'Cộng hòa dân chủ nhân dân Triều Tiên, Nhật Bản.',0),
--(60,4,N'Ápganixtan, Nêpan.',0)
--(61,1,N'Trung tâm kinh tế - tài chính của thế giới.',1),
--(61,2,N'Nước đầu tiên phóng thành công vệ tinh nhân tạo bay vào quỹ đạo trái đất.',0),
--(61,3,N'Một trong 3 trung tâm kinh tế - tài chính lớn của thế giới.',0),
--(61,4,N'Trung tâm kinh tế - tài chính của châu Mĩ.',0)
--(62,1,N'Có sự phân tuyến triệt để, mâu thuẫn sâu sắc giữa các nước Tư bản chủ nghĩa.',0),
--(62,2,N'Diễn ra sự đối đẩu quyết liệt giữa các đế quốc lớn nhằm tranh giành thị trường và phạm vi ảnh hưởng.',0),
--(62,3,N'Các nước tư bản thắng trận đang xác lập vai trò lãnh đạo thế giới, nô dịch các nước bại trận.',0),
--(62,4,N'Có sự đối đầu căng thẳng, mâu thuẫn sâu sắc giữa hai phe Tư bản chủ nghĩa và Xã hội chủ nghĩa.',1)
--(63,1,N'Cải tiến công cụ lao động là một yêu cầu thường xuyên của con người để nâng cao chất lượng cuộc sống.',0),
--(63,2,N'Nhân loại đang cần nỗ lực để giải quyết những vấn đề toàn cầu như sự cạn kiệt của nguồn tài nguyên, bùng nổ dân số, ô nhiễm môi trường.',0),
--(63,3,N'Sự phát triển của khoa học - kỹ thuật cuối thế kỷ XIX đầu thế kỷ XX.',0),
--(63,4,N'Tất cả các ý trên.',1)

--(64,1,N'Thực dân Pháp đang gặp nhiều khó khăn, trong khi cuộc chiến tranh thế giới đang bước vào giai đoạn quyết định.',0),
--(64,2,N'Kinh tế ổn định nhưng chính trị bất ổn. Phong trào phản đối chiến tranh, đòi cải thiện điều kiện sống của công nhân và nhân dân lao động Pháp lên cao.',0),
--(64,3,N'Pháp đang lâm vào cuộc khủng hoảng kinh tế nặng nề nhất trong lịch sử - "khủng hoảng thừa".',0),
--(64,4,N'Chiến tranh đã để lại hậu quả rất nặng nề, nền kinh tế Pháp đang gặp khó khăn ; Pháp trở thành con nợ lớn của Mĩ.',1),
--(65,1,N'Vô sản với tư sản.',0),
--(65,2,N'Vô sản với tư sản, nông dân với địa chủ phong kiến.',0),
--(65,3,N'Nhân dân Việt Nam với thực dân Pháp, vô sản với tư sản".',0),
--(65,4,N'Dân tộc Việt Nam với thực dân Pháp, nông dân với địa chủ phong kiến.',1),
--(66,1,N'Bạn.',0),
--(66,2,N'Tay sai.',0),
--(66,3,N'Đồng minh".',1),
--(66,4,N'Anh em.',0),
--(67,1,N'Miền Bắc hoàn toàn giải phóng.',0),
--(67,2,N'Trung ương Đảng và Chính phủ trở về Thủ đô.',0),
--(67,3,N'Quân ta tiến vào tiếp quản Thủ đô".',1),
--(67,4,N'Tên lính Pháp cuối cùng rút khỏi Việt Nam.',0)









select * from monHoc
select * from boDe
select * from cTBoDe
select * from dapAn
select * from cauHoi
