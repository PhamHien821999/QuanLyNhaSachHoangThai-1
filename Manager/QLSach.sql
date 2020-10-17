use master 
go
if(exists(select * from sysdatabases where name ='NhaSach'))
Drop database NhaSach

create database NhaSach
go

use NhaSach
go

create table TaiKhoan
( 
       TenTK nvarchar(100) not null primary key,
	   MatKhau nvarchar(50) not null,
	   LoaiTaiKhoan nvarchar(20) not null ,
)
go

create table NhanVien
(
      MaNV nvarchar(10) not null primary key,
	  TenNV nvarchar(100) not null,
	  GioiTinh nvarchar(5) not null,
	  NgaySinh date,
	  DiaChi nvarchar(10) not null,
	  SDT nvarchar(12) ,
)
go

create table KhachHang
(
     MaKH nvarchar(10) not null primary key,
	 TenKH nvarchar(100) not null,
	 GioiTinh nvarchar(5),
	 DiaChi nvarchar(100),
	 SDT nvarchar(12),
)
go
create table TacGia
(
     MaTG nvarchar(10) not null primary key,
	 TenTG nvarchar(100) not null,
)
go
create table TheLoai
(
     MaTL nvarchar(10) not null primary key,
	 TenTL nvarchar(100) not null,
)
go
create table NhaCungCap
(
     MaNCC nvarchar(10) not null primary key,
	 TenNCC nvarchar(100) not null,
	 DiaChi nvarchar(100) not null,
	 SDT nvarchar(12),
)

Create table Sach
(
    MaSach nvarchar(10) not null primary key,
	TenSach nvarchar(100),
	MaTL nvarchar(10) not null,
	foreign key (MaTL) references TheLoai(MaTL) on delete cascade on update cascade,
	MaTG nvarchar(10) not null,
	foreign key (MaTG) references TacGia(MaTG) on delete cascade on update cascade,
	DonGiaBan float DEFAULT 0 ,
	SoLuongCo int DEFAULT 0,
)
go

create table PhieuNhap
(
    SoPhieu nvarchar(10) not null primary key,
	MaNV nvarchar(10) not null,
	NgayLap date,
	MaNCC nvarchar(10) not null 
	Foreign key(MaNCC) references NhaCungCap(MaNCC) on delete cascade on update cascade,
	Foreign key(MaNV) references NhanVien(MaNV) on delete cascade on update cascade,
)
go

create table ChiTietPhieuNhap
( 
    SoPhieu nvarchar(10) not null,
	Foreign key(SoPhieu) references PhieuNhap(SoPhieu) on delete cascade on update cascade, 
	MaSach nvarchar(10) not null,
	Foreign key(MaSach) references Sach(MaSach) ,
	primary key(SoPhieu,MaSach),
	SoLuongNhap int DEFAULT 0 not null ,
	donGiaNhap float DEFAULT 0,
)
go

create table HoaDon
(
    SoHD nvarchar(10) not null primary key,
	NgayLap date,
	MaKH nvarchar(10) not null,
	Foreign key(MaKH) references KhachHang(MaKH) on update cascade on delete cascade,
	MaNV nvarchar(10) not null,
	Foreign key(MaNV) references NhanVien(MaNV) on update cascade on delete cascade,
)
go

create table ChiTietHoaDon
(
    SoHD nvarchar(10) not null,
    Foreign key(SoHD) references HoaDon(SoHD) on update cascade on delete cascade,
	MaSach nvarchar(10) not null,
	Foreign key(MaSach) references Sach(MaSach) on update cascade on delete cascade,
	primary key(SoHD, MaSach),
	SoLuongBan int DEFAULT 0 ,
	DonGiaBan float DEFAULT 0,
)
go

-- insert du lieu
-- Table TaiKhoan
insert into TaiKhoan values('Admin1','123456',N'Quản Lý')
insert into TaiKhoan values('NhanVien1','123456',N'Nhân Viên')
go

--insert table NhanVien
insert into NhanVien values('NV001',N'Phạm Ngọc Thảo',N'Nữ','01/04/1998',N'Hà Nội','0971156123')
insert into NhanVien values('NV002',N'Nguyễn Thảo My',N'Nữ','01/04/1999',N'Hải Phòng','097134556')
insert into NhanVien values('NV003',N'Trần Hải Đăng',N'Nam','01/04/1997',N'Thái Bình','0971156146')
go
--insert tbale KhachHang
insert into KhachHang values('KH001',N'Phạm Thị Hiền',N'Nữ','Hải Phòng','03367845677')
insert into KhachHang values('KH002',N'Phạm Ngọc Phuong',N'Nữ','Hà Nội','03367845688')
insert into KhachHang values('KH003',N'Jone Son',N'Nam','Hà Nội','03367845699')
go
--insert table TacGia
insert into TacGia values('TG01',N'Phạm Ngọc Ánh')
insert into TacGia values('TG02',N'Dale Carnegie')
insert into TacGia values('TG03',N'Xiu-Ying Wei')
insert into TacGia values('TG04',N'TS.David J.Lieberman')
go
--insert table TheLoai
insert into TheLoai values('TL01',N'Khoa Học Viễn Tưởng')
insert into TheLoai values('TL02',N'Kinh tế-Kinh Doanh')
insert into TheLoai values('TL03',N'Kĩ Năng')
insert into TheLoai values('TL04',N'Ngoại Ngữ')
insert into TheLoai values('TL05',N'Công Nghệ Thông Tin')
go
--insert tbale NhaCungCap
insert into NhaCungCap values('NCC001',N'Nhà xuất bản công thương','Tp.Hồ Chí Minh','033145123')
insert into NhaCungCap values('NCC002',N'Nhà xuất bản thế giới-Nhã Nam','Tp.Hồ Chí Minh','0334567684')
insert into NhaCungCap values('NCC003',N'Nhà xuất bản Thành phố Hồ Chí Minh','Tp.Hồ Chí Minh','190014512345')
insert into NhaCungCap values('NCC004',N'Nhà xuất bản Hà nội','Hà Nội','1900145123')
go
--insert into Sach
insert into Sach values('S0001',N'Harvard bốn rưỡi sáng','TL03','TG03',119000,100)
insert into Sach values('S0002',N'Đọc Vị Bất Kỳ Ai','TL03','TG04',89000,100)
insert into Sach values('S0003',N'Đắc Nhân Tâm','TL03','TG02',76000,100)
select * from Sach
go

--insert into HoaDon
insert into HoaDon values('HD001','2020-04-02','KH001','NV001')
insert into HoaDon values('HD002','2020-04-02','KH002','NV001')
insert into HoaDon values('HD003','2020-04-02','KH003','NV001')
go
select * from HoaDon
go

--insert table ChiTietHoaDon
insert into ChiTietHoaDon values('HD001','S0001',2,130000)
insert into ChiTietHoaDon values('HD001','S0002',1,100000)
insert into ChiTietHoaDon values('HD001','S0003',1,80000)
go
select * from ChiTietHoaDon
go

--insert table PhieuNhap
insert into PhieuNhap values('PN001','NV001','2020-04-02','NCC001')
insert into PhieuNhap values('PN002','NV003','2020-05-02','NCC002')
insert into PhieuNhap values('PN003','NV002','2020-03-02','NCC001')

go

--insert table ChiTietPhieuNhap
insert into ChiTietPhieuNhap values('PN003','S0003',1,60000)
insert into ChiTietPhieuNhap values('PN003','S0001',1,100000)
insert into ChiTietPhieuNhap values('PN001','S0002',1,80000)
insert into ChiTietPhieuNhap values('PN002','S0003',1,60000)

select Sum(DonGiaBan*SoLuongBan) As'TongTien' 
from ChiTietHoaDon
go




-- Cập nhật tài khoản đăng nhập
Create procedure sp_UpdatePassWord
(
      @TenTK nvarchar(100),
	  @MatKhau nvarchar(50) 
)
As
     begin 
	      Update TaiKhoan set MatKhau = @MatKhau
		  Where TenTK = @TenTK
	 End
go
--Xóa tài khoản đăng nhập
Create procedure sp_deleteTaiKhoan
(
      @TenTK nvarchar(100)
)
As
     begin 
	      delete from TaiKhoan 
		  Where TenTK = @TenTK
	 End
go

--Kiểm tra tài khoản 
Create procedure sp_CheckTaiKhoan
(
      @TenTK nvarchar(100),
	  @MatKhau nvarchar(50)
)
As
     begin 
	      select * from TaiKhoan 
		  Where TenTK = @TenTK and MatKhau = @MatKhau
	 End
go

delete from HoaDon
go

select * from Sach
select * from ChiTietHoaDon
select * from HoaDon

select * from ChiTietPhieuNhap
--phieu nhap
select SoPhieu, TenSach, ct.SoLuongNhap, ct.donGiaNhap, (ct.SoLuongNhap*ct.donGiaNhap) as 'ThanhTien'
from ChiTietPhieuNhap ct 
inner join Sach s on ct.MaSach = s.MaSach where SoPhieu='PN001'
--tìm kiếm sách
select * from TacGia
select * from TheLoai
select * from Sach
go
--Tim kiem

   select s.MaSach,s.TenSach, tl.TenTL, tg.TenTG, DonGiaBan, SoLuongCo from Sach s 
   inner join TacGia tg on s.MaTG = tg.MaTG 
   inner join TheLoai tl on tl.MaTL = s.MaTL 
   where s.MaSach ='' or s.TenSach like N''or tg.TenTG like N'Phạm Ngọc Ánh'

--Update so luong bán
Update Sach set SoLuongCo=1 where Masach ='S0001'
select * from ChiTietHoaDon
select * from Sach
SELECT*FROM KhachHang
select * from TaiKhoan
-- TÌM KIẾM Khách hàng
select * from KhachHang
where TenKH like N'%Phạm Thị%' or SDT = '03367845677'

ư
insert into NhanVien(MaNV, TenNV, GioiTinh, NgaySinh, DiaChi, SDT) values('123', N'ngọc', N'nữ','10/10/2010',N'Bắc Ninh' ,'093847756')

select * from HoaDon

select * from ChiTietHoaDon

select Sum (ct.DonGiaBan*ct.SoLuongBan) as'tongtien'
from HoaDon hd
inner join ChiTietHoaDon ct 
on hd.SoHD = ct.SoHD
where hd.NgayLap between '04/15/2020' and '05/15/2020'