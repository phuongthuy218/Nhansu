--                           Login
--thêm
alter proc themnd @tendangnhap nvarchar(50) ,@matkhau nvarchar(50)
as
begin
insert into nguoidung(tendangnhap,matkhau)
values(@tendangnhap,@matkhau)
end
themnd 'phuongthuy','thuy21896'

--sửa
create proc suand @STT int,@tendangnhap nvarchar(50) ,@matkhau nvarchar(50)
as
begin
update nguoidung
set tendangnhap =@tendangnhap,matkhau=@matkhau
where STT=@STT
end

--xoánd
create proc xoand   @STT int
as
begin
delete nguoidung
where STT=@STT
end           
--               CHƯC VỤ
-- thêm 
create proc themcv @macv char(10),@tencv nvarchar(50),@hesoluong int,@luongcoban int,@phucapcv int
as
begin
insert into chucvu(macv,tencv,hesoluong,luongcoban,phucapcv)
values (@macv,@tencv,@hesoluong,@luongcoban,@phucapcv)
end
--                             DANH SÁCH NV ĐÀO TẠO 
--them
alter proc themnvdt  @madt char(10),@tendt nvarchar(50),@manv char(10),@tennv nvarchar(50)
as
begin
 insert into nhanviendaotao(madt,tendt,manv,tennv)
	values(@madt,@tendt,@manv,@tennv)
	end
	themnvdt 'dt02',N'Nâng cao trình độ chuyên môn','nv03',N'Ngô Quỳnh Hương'
	drop proc themnvdt

--xem
create proc xemnvdt @madt char(10)
as
begin
select * from nhanviendaotao
where @madt=madt
end
xemnvdt 'dt01'
                          --ĐÀO TẠO
--thêm 
alter proc themdt @madt char(10),@tendt nvarchar(50),@tungay datetime,@denngay datetime,@diachi nvarchar(50),@soluongnv int,@ghichu nvarchar(50)
as
begin 
insert into daotao(madt,tendt,tungay,denngay,diachi,soluongnv,ghichu)
values(@madt,@tendt,@tungay,@denngay,@diachi,@soluongnv,@ghichu)

end
themdt 'dt06','t','2017/03/07','2017/09/09','ư','2','k'

                            --ĐIỀU CHUYỂN CÔNG TÁC
--thêm 
alter proc themdcct @manv char(10),@tennv nvarchar(50),@mapbcu char(10),@mapbmoi char(10),@macvcu char(10),@macvmoi char(10),@tungay datetime ,@lydo nvarchar(50),@ghichu nvarchar(50)
as
begin
insert into dieuchuyencongtac(manv,tennv,mapbcu,mapbmoi,macvcu,macvmoi,tungay,lydo,ghichu)
values (@manv,@tennv,@mapbcu,@mapbmoi,@macvcu,@macvmoi,@tungay,@lydo,@ghichu)
update luong set macv=@macvmoi where macv=@macvcu
update nhanvien set macv=@macvmoi,mapb=@mapbmoi where macv=@macvcu and mapb=@mapbcu
end


themdcct'nv02',N'Nguyễn Thị Thảo','pb06','pb06','cv10','cv06','2016/09/12','a'
themdcct 'nv05',N'Lê Thế Trung','pb04','null','cv04','cv04','2017/04/06',N'hh',N'g'

--sửa
alter proc suadcct @tungay datetime ,@lydo nvarchar(50),@ghichu nvarchar(50)
as
begin
update dieuchuyencongtac
set tungay=@tungay , lydo=@lydo,ghichu=@ghichu
where tungay=@tungay
end
suadcct 'nv05',N'Lê Thế Trung','pb03','','cv03','','2017/04/06',N'Vô trách nhiệm',N'Nghỉ Việc'
--xóa
create proc xoadcct @mapbcu char(10),@tungay datetime
as
begin
delete dieuchuyencongtac
where mapbcu=@mapbcu and tungay=@tungay
end
                               --HỢP ĐỒNG
--thêm
alter proc themhd @mahd char(10),@loaihd nvarchar(50),@manv char(10),@tungay datetime,@denngay datetime,@ngaykikethd datetime
as
begin
insert into hopdong(mahd,loaihd,manv,tungay,denngay,ngaykikethd)
values (@mahd,@loaihd,@manv,@tungay,@denngay,@ngaykikethd)
end
themhd'hd06','HD 5 năm','nv04','2013/09/25','2018/09/25','2013/09/20'
--sửa 
alter proc suahd @mahd char(10),@loaihd nvarchar(50),@manv char(10),@tungay datetime,@denngay datetime,@ngaykikethd datetime
as
begin
update hopdong set loaihd=@loaihd,tungay=@tungay,denngay=@denngay,ngaykikethd=@ngaykikethd
where mahd=@mahd
end
--xóa
create proc xoahd @mahd char(10)
as
begin
delete hopdong where mahd =@mahd
end
                               --KHEN THƯỞNG
--thêm
alter proc themkt @manv char(10),@ngaykt datetime,@hinhthuc nvarchar(50),@lydo nvarchar(50)
as
begin
insert into khenthuong(manv,ngaykt,hinhthuc,lydo)
values (@manv,@ngaykt,@hinhthuc,@lydo)
end
--sửa
alter proc suakt @manv char(10),@ngaykt datetime,@hinhthuc nvarchar(50),@lydo nvarchar(50)
as
begin
update khenthuong set hinhthuc=@hinhthuc,lydo=@lydo,ngaykt=@ngaykt
where manv=@manv
end
--xóa
alter proc xoakt @manv char(10)
as
begin
delete khenthuong where manv=@manv
end
                                 --KỶ LUẬT
--thêm
alter proc themkl @manv char(10),@ngaykl datetime,@hinhthuc nvarchar(50),@lydo nvarchar(50)
as
begin
insert into kyluat(manv,ngaykl,hinhthuc,lydo)
values (@manv,@ngaykl,@hinhthuc,@lydo)
end
--sửa
alter proc suakl @manv char(10),@ngaykl datetime,@hinhthuc nvarchar(50),@lydo nvarchar(50)
as
begin
update kyluat set hinhthuc=@hinhthuc,lydo=@lydo,ngaykl=@ngaykl
where manv=@manv
end
--xóa
alter proc xoakl @manv char(10)
as
begin
delete kyluat where manv=@manv
end
                            --LƯƠNG
--thêm
alter proc themluong @manv char(10),@tennv nvarchar(50),@macv char(10),@luongcoban int,@hesoluong float,@phucapcv int,@tienthuong int,@tienphat int,@tienbaohiemyte int,@tienbaohiemxahoi int,@tongluong int
as
begin
insert into luong(manv,tennv,macv,luongcoban,hesoluong,phucapcv,tienthuong,tienphat,tienbaohiemyte,tienbaohiemxahoi,tongluong)
values (@manv,@tennv,@macv,@luongcoban,@hesoluong,@phucapcv,@tienthuong,@tienphat,@tienbaohiemyte,@tienbaohiemxahoi,@tongluong)
end
themluong 'nv01',null,'cv01',null,null,null,null,null,null,null,null
--sửa
alter proc sualuong @manv char(10),@tennv nvarchar(50),@macv char(10),@luongcoban int,@hesoluong float,@phucapcv int,@tienthuong int,@tienphat int,@tienbaohiemyte int,@tienbaohiemxahoi int,@tongluong int
as
begin
update luong set tienthuong=@tienthuong,tienphat=@tienphat,tongluong=@tongluong
where manv=@manv 
end

--xóa
create proc xoaluong @manv char(10)
as
begin
delete luong where manv=@manv
end
                             --NHÂN VIÊN
--thêm
alter proc themnv @manv char(10),@mauv char(10),@mapb char(10),@macv char(10),@ngayvaolam datetime
as
begin
declare @tennv nvarchar(50),@ngaysinh datetime,@noisinh nvarchar(50),@nguyenquan nvarchar(50),@diachitamtru nvarchar(50),@gioitinh nvarchar(50),@dantoc nvarchar(50),@sodtnv int,@nguoilienhe nvarchar(50),@quoctich nvarchar(50),@ngoaingu nvarchar(50),@soCMND int,@soBHYT int,@soBHXH int,@matd char(10)

select @tennv=tenuv,@ngaysinh=ngaysinh,@noisinh=noisinh,@nguyenquan=nguyenquan,@diachitamtru=diachitamtru,@gioitinh=gioitinh,@dantoc=dantoc,@sodtnv=sodtuv,@nguoilienhe=nguoilienhe,@quoctich=quoctich,@ngoaingu=ngoaingu,@soCMND=soCMND,@soBHYT=soBHYT,@soBHXH=soBHXH,@matd=matd from ungvien where mauv=@mauv
insert into nhanvien values(@manv,@tennv,@mapb,@macv,@ngaysinh,@noisinh,@nguyenquan,@diachitamtru,@gioitinh,@dantoc,@sodtnv,@nguoilienhe,@quoctich,@ngoaingu,@ngayvaolam,@soCMND,@soBHYT,@soBHXH,@matd)
delete ungvien where mauv=@mauv
end
drop proc themnv
themnv 'nv09','uv01','pb04','cv05','2017/05/31'
--sửa
alter proc suanv @manv char(10),@tennv nvarchar(50),@mapb char(10),@macv char(10),@ngaysinh datetime,@noisinh nvarchar(50),@nguyenquan nvarchar(50),@diachitamtru nvarchar(50),@gioitinh nvarchar(50),@dantoc nvarchar(50),@sodtnv int,@nguoilienhe nvarchar(50),@quoctich nvarchar(50),@ngoaingu nvarchar(50),@ngayvaolam datetime,@soCMND int,@soBHYT int,@soBHXH int,@matd char(10)
as
begin 
update nhanvien set nguoilienhe=@nguoilienhe,sodtnv=@sodtnv
where manv=@manv
end
--xóa
alter proc xoanv @manv char(10)
as
begin
if not exists(select manv from nhanvien where manv=@manv)
	print'Khong ton tai nhan vien'
else
update dieuchuyencongtac set manv=null where manv=@manv
delete nhanvien where manv=@manv
delete luong where manv=@manv
delete khenthuong where manv=@manv
delete kyluat where manv=@manv
delete nhanviendaotao where manv=@manv
delete hopdong where manv=@manv
delete thannhan where manv=@manv
end
                                     --PHÒNG  BAN
--thêm 
create proc thempb @mapb char(10),@tenpb nvarchar(50),@diachi nvarchar(50),@SDTpb char(10)
as 
begin
insert into  phongban(mapb,tenpb,diachi,SDTpb)
values(@mapb,@tenpb,@diachi,@SDTpb)
end
--sửa
create proc suapb @mapb char(10),@tenpb nvarchar(50),@diachi nvarchar(50),@SDTpb char(10)
as
begin 
update phongban set diachi=@diachi
where mapb=@mapb
end
--xóa
create proc xoapb @mapb char(10)
as
begin
if not exists(select mapb from phongban where mapb=@mapb) 
   print'Khong ton tai nhan vien'
else
update nhanvien set mapb= null where mapb=@mapb
delete phongban where mapb=@mapb
end 
                               --THÂN NHÂN 
--thêm
alter proc themtn @tentn nvarchar(50),@ngaysinh datetime,@diachi nvarchar(50),@manv char(10),@quanhe nvarchar(50)
as
begin
insert into thannhan(tentn,ngaysinh,diachi,manv,quanhe)
values (@tentn,@ngaysinh,@diachi,@manv,@quanhe)
end
themtn 'hy','1997/12/12',N'Nghệ An,Thanh Chương,Thanh Lĩnh','nv07','bố'
--xóa
create proc xoatn @manv char(10)
as
begin
delete thannhan where manv=@manv
end
                                  --ỨNG VIÊN
--thêm 
alter proc themuv @mauv char(10),@tenuv nvarchar(50),@ngaysinh datetime,@noisinh nvarchar(50),@nguyenquan nvarchar(50),@diachitamtru nvarchar(50),@gioitinh nvarchar(50),@dantoc nvarchar(50),@sodtuv int,@nguoilienhe nvarchar(50),@quoctich nvarchar(50),@ngoaingu nvarchar(50),@soCMND int,@soBHYT int,@soBHXH int,@matd char(10)
as
begin
insert into ungvien(mauv,tenuv,ngaysinh,noisinh,nguyenquan,diachitamtru,gioitinh,dantoc,sodtuv,nguoilienhe,quoctich,ngoaingu,soCMND,soBHYT,soBHXH,matd)
values (@mauv,@tenuv,@ngaysinh,@noisinh,@nguyenquan,@diachitamtru,@gioitinh,@dantoc,@sodtuv,@nguoilienhe,@quoctich,@ngoaingu,@soCMND,@soBHYT,@soBHXH,@matd)
end
themuv'uv01','t','1990/02/03','a,b,n','a,b,c','r,p,o','nữ','f','36','w','r','k','3','7','8','td02'
--sửa
alter proc suauv @mauv char(10),@tenuv nvarchar(50),@ngaysinh datetime,@noisinh nvarchar(50),@nguyenquan nvarchar(50),@diachitamtru nvarchar(50),@gioitinh nvarchar(50),@dantoc nvarchar(50),@sodtuv int,@nguoilienhe nvarchar(50),@quoctich nvarchar(50),@ngoaingu nvarchar(50),@soCMND int,@soBHYT int,@soBHXH int,@matd char(50)
as
begin
update ungvien set sodtuv =@sodtuv,nguoilienhe=@nguoilienhe
where mauv=@mauv
end
--xóa
create proc xoauv @mauv char(10)
as
begin
delete ungvien where mauv=@mauv
end

