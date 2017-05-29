
create table nguoidung(
STT int identity,
tendangnhap nvarchar(50),
matkhau nvarchar(50),
)
 create table chucvu(
 macv char(10) primary key,
 tencv nvarchar(50) ,
 phucapcv int,
 hesoluong int,
 luongcoban int,
 )
 create table trinhdo(
 matd char(10) not null primary key,
 tentd nvarchar(10)
 ,)

 create table phongban(
 mapb char(10)not null primary key,
 tenpb nvarchar(50)not null,
 diachi nvarchar(50)not null,
 SDTpb char(10),
 )
 create table nhanvien(
manv char(10) not null primary key,
tennv nvarchar(50) not null,
mapb char(10) references phongban(mapb), 
macv char(10)  references chucvu(macv),
ngaysinh datetime ,
noisinh nvarchar(50),
nguyenquan nvarchar(50),
diachitamtru nvarchar(50),
gioitinh nvarchar(50),
dantoc nvarchar(50) ,
sodtnv int,
nguoilienhe nvarchar(50),
quoctich nvarchar(50) ,
ngoaingu nvarchar(50),
ngayvaolam datetime ,
soCMND int ,
soBHYT int,
soBHXH int,
matd char(10),
)
 create table luong(
 manv char(10) primary key references nhanvien(manv),
 tennv nvarchar(50),
 macv char(10) references chucvu(macv),
 luongcoban int,
 hesoluong int,
 phucapcv int ,
 tienthuong int,
 tienphat int,
 tienbaohiemyte int,
 tienbaohiemxahoi int,
 tongluong float,
)
create table ungvien(
mauv char(10) not null primary key,
tenuv nvarchar(50) not null,
ngaysinh datetime ,
noisinh nvarchar(50),
nguyenquan nvarchar(50),
diachitamtru nvarchar(50),
gioitinh nvarchar(50),
dantoc nvarchar(50) ,
sodtnv int,
nguoilienhe nvarchar(50),
quoctich nvarchar(50) ,
ngoaingu nvarchar(50),
soCMND int ,
soBHYT int,
soBHXH int,
matd char(10) references trinhdo(matd),
)

create table hopdong(
mahd char(10) not null ,
loaihd nvarchar(50) ,
manv char(10)  references nhanvien(manv),
tungay datetime ,
denngay datetime ,
ngaykikethd datetime,
 primary key (mahd,manv),
)
create table thannhan(
tentn nvarchar(50) not null,
ngaysinh datetime ,
diachi nvarchar(50),
manv char(10) primary key  references nhanvien(manv),
quanhe nvarchar(50) ,
)
create table khenthuong (
manv char(10) primary key references nhanvien(manv),
ngaykt datetime not null ,
hinhthuc nvarchar(50),
lydo nvarchar(50),

)
create table kyluat(
manv char(10) primary key references nhanvien(manv),
ngaykl datetime not null ,
hinhthuc nvarchar(50),
lydo nvarchar(50),

)
create table dieuchuyencongtac(
manv char(10) references nhanvien(manv),
tennv nvarchar(50),
mapbcu char(10) references phongban(mapb),
mapbmoi char(10) references phongban(mapb),
macvcu char(10) references chucvu(macv),
macvmoi char(10) references chucvu(macv),
tungay datetime,
lydo nvarchar(50),
ghichu nvarchar(50),
primary key(mapbcu,tungay,manv))

create table daotao(
madt char(10) not null primary key,
tendt nvarchar(50),
tungay datetime ,
denngay datetime,
diachi nvarchar(50),
soluongnv int,
ghichu nvarchar(50),
)
create table nhanviendaotao (
madt char(10) references daotao(madt),
tendt nvarchar(50),
manv char(10) references nhanvien(manv),
tennv nvarchar(50),
primary key (madt,manv )
)
