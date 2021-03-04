CREATE DATABASE QuanLyBangDia
USE QuanLyBangDia
CREATE TABLE BangDia
(
MaBD NVARCHAR(50),
Tenbangdia NVARCHAR(50),
Soluong int,
PRIMARY KEY (MaBD)
)
CREATE TABLE KhachHang
(
MaKH NVARCHAR(50),
MaBD NVARCHAR(50),
Hoten NVARCHAR(50),
Dienthoai NVARCHAR(50),
Soluongthue int,
Ngaythue date,
Songaythue int,
Thanhtien float,
PRIMARY KEY (MaKH)
)

INSERT INTO BangDia VALUES ('MBD01',N'Băng cát-xét',10)
INSERT INTO BangDia VALUES ('MBD02',N'Băng video',20)
INSERT INTO BangDia VALUES ('MBD03',N'Băng phim',30)
INSERT INTO BangDia VALUES ('MBD04',N'Đĩa CD',40)
INSERT INTO BangDia VALUES ('MBD05',N'Đĩa DVD',50)
INSERT INTO BangDia VALUES ('MBD06',N'Băng Ca Nhạc',60)
INSERT INTO BangDia VALUES ('MBD07',N'Đĩa Phim',70)
INSERT INTO BangDia VALUES ('MBD08',N'Băng Nấu Ăn',80)
INSERT INTO BangDia VALUES ('MBD09',N'Băng Nhà Đát',90)
INSERT INTO BangDia VALUES ('MBD10',N'Đĩa Phim Hoạt Hình',100)
SELECT *
FROM BangDia
SELECT *
FROM KhachHang
INSERT INTO KhachHang VALUES ('MKH01','MBD01',N'Bùi Văn Long','0978339458',10,'2020/1/3',5,800)
INSERT INTO KhachHang VALUES ('MKH02','MBD02',N'Cao Thị Mỹ Lệ','0978339459',20,'2020/1/4',2,100)
INSERT INTO KhachHang VALUES ('MKH03','MBD03',N'Phan Quốc Tuấn','0978339410',30,'2020/1/5',6,900)
INSERT INTO KhachHang VALUES ('MKH04','MBD04',N'Lê Văn Sinh','0978339411',40,'2020/1/6',1,100)
INSERT INTO KhachHang VALUES ('MKH05','MBD05',N'Nguyễn Mỹ Linh','0978339412',50,'2020/1/7',7,700)