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
CREATE TABLE Lop
(
	maKhoiLop varchar(5),
	maLopHoc INT IDENTITY,
	tenLopHoc NVARCHAR(10)

	CONSTRAINT PK_Lop
	PRIMARY KEY (maLopHoc)
)
alter table Lop add constraint FK_lop_khoiLop FOREIGN KEY(maKhoiLop) references khoiLop(maKhoiLop)
select * from Lop


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
insert into thongTin(maNguoidung,tenNguoiDung,ngaySinh,maLopHoc)values('3','Nguyễn Hiếu Nghĩa','2000-01-10',1)


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
	maKhoi varchar(5)

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
alter table ketQua add kyThi int;
alter table ketQua add kyThi int;
select * from cTKetQua

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
select * from thongTin