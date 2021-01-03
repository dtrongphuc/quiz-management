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

