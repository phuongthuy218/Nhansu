using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Nhansu.ValueOjbect;
using Nhansu.BusinessLogicLayer;

namespace Nhansu.DataAccessLayer
{
    class Dao
    {
      //quản lý người dùng
      public static DataTable Getlistnguoidung()
        {
            return DataProvider.GetData("select * from nguoidung");
        }
        public static int InsertProfile(quanlinguoidung ql)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@tendangnhap",ql.tendangnhap),
            new SqlParameter("@matkhau",ql.matkhau),
            };
            return DataProvider.ExcuteNonQuerry("themnd", para);
        }
        public static int UpdateProfile(quanlinguoidung ql)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@STT",ql.STT),
                new SqlParameter("@tendangnhap",ql.tendangnhap),
            new SqlParameter("@matkhau",ql.matkhau),
            };
            return DataProvider.ExcuteNonQuerry("suand", para);
        }

        public static int DeleteProfile(quanlinguoidung ql)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("STT",ql.STT),
                
            };
            return DataProvider.ExcuteNonQuerry("xoand", para);
        }
       
        //chức vụ
        public static DataTable Getlistchucvu()
        {
            return DataProvider.GetData("select * from chucvu");
        }
        public static int InsertProfile(chucvu cv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macv",cv.macv),
                new SqlParameter("@tencv",cv.tencv),
                new SqlParameter("@phucapcv",cv.phucapcv),
                new SqlParameter("@hesoluong",cv.hesoluong),
                new SqlParameter("@luongcoban",cv.luongcoban),
            };
            return DataProvider.ExcuteNonQuerry("themcv", para);
        }
        public static DataTable timkiemcv(string ma)
        {
            return DataProvider.GetData("select * from chucvu" + ma);
        }
        //danh sách nhân viên đào tạo
        public static DataTable Getlistdanhsachnvdt()
        {
            return DataProvider.GetData("select * from nhanviendaotao ");
        }
        public static int InsertProfile(nhanviendaotao nvdt)
        {
            SqlParameter[] para = new SqlParameter[]
            { 
                new SqlParameter("@madt",nvdt.madt),
                new SqlParameter("@tendt",nvdt.tendt),
                new SqlParameter("@manv",nvdt.manv),
                new SqlParameter("@tennv",nvdt.tennv)
            };
            return DataProvider.ExcuteNonQuerry("themnvdt", para);
        }
        public static DataTable timkiemnvdt (string ma)
        {
            return DataProvider.GetData("select * from nhanviendaotao" + ma);
        }
        
        //đào tạo
        public static DataTable Getlistdaotao()
        {
            return DataProvider.GetData("select * from daotao ");
        }
        public static int InsertProfile(daotao dt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
             new SqlParameter("@madt", dt.madt),
            new SqlParameter("@tendt", dt.tendt),
            new SqlParameter("@tungay", dt.tungay),
            new SqlParameter("@denngay", dt.denngay),
            new SqlParameter("@diachi", dt.diachi),
            new SqlParameter("@soluongnv", dt.soluongnv),
            new SqlParameter("@ghichu",dt.ghichu),
        };
            return DataProvider.ExcuteNonQuerry("themdt", para);
        }
        public static DataTable timkiemdt(string ma)
        {
            return DataProvider.GetData("select * from daotao" + ma);
        }
        //Điều chuyển công tác
        public static DataTable Getlistdieuchuyencongtac()
        {
            return DataProvider.GetData("select * from dieuchuyencongtac");
        }
        public static int InsertProfile(dieuchuyencongtac dcct)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", dcct.manv),        
                new SqlParameter("@tennv",dcct.tennv)     , 
                new SqlParameter("@mapbcu",dcct.mapbcu),
                new SqlParameter("@mapbmoi",dcct.mapbmoi),
                new SqlParameter("@macvcu",dcct.macvcu),
                new SqlParameter("@macvmoi",dcct.macvmoi),
                new SqlParameter("@tungay",dcct.tungay),
                new SqlParameter("@lydo",dcct.lydo),
                new SqlParameter("@ghichu",dcct.ghichu),
            };
            return DataProvider.ExcuteNonQuerry("themdcct", para);
        }
        public static int UpdateProfile(dieuchuyencongtac dcct)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@tungay",dcct.tungay),
                new SqlParameter("@lydo",dcct.lydo),
                new SqlParameter("@ghichu",dcct.ghichu),
            };
            return DataProvider.ExcuteNonQuerry("suadcct", para);
        }
        public static int DeleteProfile(dieuchuyencongtac dcct)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapbcu",dcct.mapbcu),
                new SqlParameter("@tungay",dcct.tungay),
            };
            return DataProvider.ExcuteNonQuerry("xoadcct", para);
        }
        public static DataTable timkiemdcct(string ma)
        {
            return DataProvider.GetData("select * from dieuchuyencongtac" + ma);
        }
        //hợp đồng
        public static DataTable Getlisthopdong()
            {
            return DataProvider.GetData("select * from hopdong");
        }
        public static int InsertProfile(hopdong hd)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mahd",hd.mahd),
                new SqlParameter("@loaihd",hd.loaihd),
                new SqlParameter("@manv",hd.manv),            
                new SqlParameter("@tungay",hd.tungay),
                new SqlParameter("@denngay",hd.denngay),
                new SqlParameter("@ngaykikethd",hd.ngaykikethd),
            };
            return DataProvider.ExcuteNonQuerry("themhd", para);
         }
        public static int UpdateProfile(hopdong hd)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mahd",hd.mahd),
                new SqlParameter("@loaihd",hd.loaihd),
                new SqlParameter("@manv",hd.manv),     
                new SqlParameter("@tungay",hd.tungay),
                new SqlParameter("@denngay",hd.denngay),
                new SqlParameter("@ngaykikethd",hd.ngaykikethd),
            };
            return DataProvider.ExcuteNonQuerry("suahd", para);
        }
        public static int DeleteProfile(hopdong hd)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mahd",hd.mahd),
            };
            return DataProvider.ExcuteNonQuerry("xoahd", para);
        }
        public static DataTable timkiemhd(string ma)
        {
            return DataProvider.GetData("select * from hopdong " + ma);
        }
        //Kỷ luật
        public static DataTable Getlistkyluat()
        {
            return DataProvider.GetData("select * from kyluat");
        }
        public static int InsertProfile(kyluat kl)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv",kl.manv),       
                new SqlParameter("@ngaykl",kl.ngaykl),
                new SqlParameter("@hinhthuc",kl.hinhthuc),
                new SqlParameter("@lydo",kl.lydo),
            };
            return DataProvider.ExcuteNonQuerry("themkl", para);
        }
        public static int UpdateProfile(kyluat kl)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@manv",kl.manv),             
                new SqlParameter("@ngaykl",kl.ngaykl),
                new SqlParameter("@hinhthuc",kl.hinhthuc),
                new SqlParameter("@lydo",kl.lydo),
            };
            return DataProvider.ExcuteNonQuerry("suakl", para);
        }
        public static int DeleteProfile(kyluat kl)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@manv",kl.manv),
            };
            return DataProvider.ExcuteNonQuerry("xoakl", para);
        }
        public static DataTable timkiemkl(string ma)
        {
            return DataProvider.GetData("select * from kyluat" + ma);
        }
        //Khen thưởng
        public static DataTable Getlistkhenthuong()
        {
            return DataProvider.GetData("select * from khenthuong");
        }
        public static int InsertProfile(khenthuong kt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv",kt.manv),              
                new SqlParameter("@ngaykt",kt.ngaykt),
                new SqlParameter("@hinhthuc",kt.hinhthuc),
                new SqlParameter("@lydo",kt.lydo),
            };
            return DataProvider.ExcuteNonQuerry("themkt", para);
        }
        public static int UpdateProfile(khenthuong kt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@manv",kt.manv),               
                new SqlParameter("@ngaykt",kt.ngaykt),
                new SqlParameter("@hinhthuc",kt.hinhthuc),
                new SqlParameter("@lydo",kt.lydo),
            };
            return DataProvider.ExcuteNonQuerry("suakt", para);
        }
        public static int DeleteProfile(khenthuong kt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@manv",kt.manv),
            };
            return DataProvider.ExcuteNonQuerry("xoakt", para);
        }
        public static DataTable timkiemkt(string ma)
        {
            return DataProvider.GetData("select * from khenthuong" + ma);
        }
        //luong
        public static DataTable Getlistluong()
        {
            return DataProvider.GetData("select * from luong");
        }
        public static int InsertProfile(luong l)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", l.manv), 
                new SqlParameter("@tennv",l.tennv),            
                new SqlParameter("@macv",l.macv),                
                new SqlParameter("@luongcoban",l.luongcoban),
                new SqlParameter("@hesoluong",l.hesoluong),
                new SqlParameter("@phucapcv",l.phucapcv),
                new SqlParameter("@tienthuong",l.tienthuong),
                new SqlParameter("@tienphat",l.tienphat),
                new SqlParameter("@tienbaohiemyte",l.tienbaohiemyte),
                new SqlParameter("@tienbaohiemxahoi",l.tongluong),
                new SqlParameter("@tongluong",l.tongluong),
            };
            return DataProvider.ExcuteNonQuerry("themluong", para);
        }
        public static int UpdateProfile(luong l)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", l.manv),
                new SqlParameter("@tennv",l.tennv),
                new SqlParameter("@macv",l.macv),              
                new SqlParameter("@luongcoban",l.luongcoban),
                new SqlParameter("@hesoluong",l.hesoluong),
                new SqlParameter("@phucapcv",l.phucapcv),
                new SqlParameter("@tienthuong",l.tienthuong),
                new SqlParameter("@tienphat",l.tienphat),
                new SqlParameter("@tienbaohiemyte",l.tienbaohiemyte),
                new SqlParameter("@tienbaohiemxahoi",l.tienbaohiemxahoi),
                new SqlParameter("@tongluong",l.tongluong),
            };
            return DataProvider.ExcuteNonQuerry("sualuong", para);
        }
        public static int DeleteProfile(luong l)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@manv",l.manv),
            };
            return DataProvider.ExcuteNonQuerry("xoaluong", para);
        }
        public static DataTable timkiemluong(string thang)
        {
            return DataProvider.GetData("select * from luong" + thang);
        }
        //nhân viên
        public static DataTable Getlistnhanvien()
        {
            return DataProvider.GetData("select * from nhanvien");
        }
        public static int InsertProfile(nhanvien nv,ungvien uv)
        {
            SqlParameter[] para = new SqlParameter[]
            {                new SqlParameter("@manv", nv.manv),
                new SqlParameter("@mauv", uv.mauv),
                new SqlParameter("@mapb",nv.mapb),
                new SqlParameter("@macv",nv.macv),
                new SqlParameter("@ngayvaolam",nv.ngayvaolam),
               
            };
            return DataProvider.ExcuteNonQuerry("themnv", para);
        }
        public static int UpdateProfile(nhanvien nv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", nv.manv),
                new SqlParameter("@tennv", nv.tennv),
                new SqlParameter("@mapb",nv.mapb),
                new SqlParameter("@macv",nv.macv),
                new SqlParameter("@ngaysinh",nv.ngaysinh),
                 new SqlParameter("@noisinh",nv.noisinh),
                new SqlParameter("@nguyenquan",nv.nguyenquan),
                new SqlParameter("@diachitamtru",nv.diachitamtru),
                new SqlParameter("@gioitinh",nv.gioitinh),
                new SqlParameter("@dantoc",nv.dantoc),
                new SqlParameter("@sodtnv",nv.sodtnv),
                new SqlParameter("@nguoilienhe",nv.nguoilienhe),
                new SqlParameter("@quoctich",nv.quoctich),
                new SqlParameter("@ngoaingu",nv.ngoaingu),
                new SqlParameter("@ngayvaolam",nv.ngayvaolam),
                new SqlParameter("@soCMND",nv.soCMND),
                new SqlParameter("@soBHYT",nv.soBHYT),
                new SqlParameter("@soBHXH",nv.soBHXH),
                new SqlParameter("@matd",nv.matd),
            };
            return DataProvider.ExcuteNonQuerry("suanv", para);
        }
        public static int DeleteProfile(nhanvien nv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@manv",nv.manv),
            };
            return DataProvider.ExcuteNonQuerry("xoanv", para);
        }
        public static DataTable timkiemnv(string ten)
        {
            return DataProvider.GetData("select * from nhanvien" + ten);
        }
        public static DataTable timkiemtheopb (string mapb)
        {
            return DataProvider.GetData("select * from nhanvien" + mapb);
        }
        public static DataTable timkiemtheocv (string macv)
        {
            return DataProvider.GetData("select * from nhanvien" + macv);
        }
        //phòng ban
        public static DataTable Getlistphongban()
        {
            return DataProvider.GetData("select * from phongban");
        }
        public static int InsertProfile(phongban pb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapb",pb.mapb),
                new SqlParameter("@tenpb",pb.tenpb),
                new SqlParameter("@diachi",pb.diachi),
                new SqlParameter("@SDTpb",pb.SDTpb),
            };
            return DataProvider.ExcuteNonQuerry("thempb", para);
        }
        public static int UpdateProfile(phongban pb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@mapb",pb.mapb),
                new SqlParameter("@tenpb",pb.tenpb),
                new SqlParameter("@diachi",pb.diachi),
                new SqlParameter("@SDTpb",pb.SDTpb),
            };
            return DataProvider.ExcuteNonQuerry("suapb", para);
        }
        public static int DeleteProfile(phongban pb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@mapb",pb.mapb),
            };
            return DataProvider.ExcuteNonQuerry("xoapb", para);
        }
        public static DataTable timkiempb(string ma)
        {
            return DataProvider.GetData("select * from phongban" + ma);
        }
        //Thân nhân 
        public static DataTable Getlistthannhan()
        {
            return DataProvider.GetData("select * from thannhan");
        }
        public static int InsertProfile(thannhan tn)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@tentn",tn.tentn),
                new SqlParameter("@ngaysinh",tn.ngaysinh),
                new SqlParameter("@diachi",tn.diachi),
                new SqlParameter("@manv",tn.manv),           
                new SqlParameter("@quanhe",tn.quanhe),
            };
            return DataProvider.ExcuteNonQuerry("themtn", para);
        }
        public static int DeleteProfile(thannhan tn)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv",tn.manv),
            };
            return DataProvider.ExcuteNonQuerry("xoatn", para);
        }
        public static DataTable timkiemtn(string ten)
        {
            return DataProvider.GetData("select * from thannnhan" + ten);
        }
        //Trình độ
        public static DataTable Getlisttrinhdo()
        {
            return DataProvider.GetData("select * from trinhdo");
        }
        public static DataTable timkiemtd(string ma)
        {
            return DataProvider.GetData("select * from trinhdo" + ma);
        }
        //Ứng viên
        public static DataTable Getlistungvien()
        {
            return DataProvider.GetData("select * from ungvien");
        }
        public static int InsertProfile(ungvien uv)
        {
           
               SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mauv", uv.mauv),
                new SqlParameter("@tenuv", uv.tenuv),
                new SqlParameter("@ngaysinh",uv.ngaysinh),
                new SqlParameter("@noisinh",uv.noisinh),
                new SqlParameter("@nguyenquan",uv.nguyenquan),
                new SqlParameter("@diachitamtru",uv.diachitamtru),
                new SqlParameter("@gioitinh",uv.gioitinh),
                new SqlParameter("@dantoc",uv.dantoc),
                new SqlParameter("@sodtuv",uv.sodtuv),
                new SqlParameter("@nguoilienhe",uv.nguoilienhe),
                new SqlParameter("@quoctich",uv.quoctich),
                new SqlParameter("@ngoaingu",uv.ngoaingu),
                new SqlParameter("@soCMND",uv.soCMND),
                new SqlParameter("@soBHYT",uv.soBHYT),
                new SqlParameter("@soBHXH",uv.soBHXH),
                new SqlParameter("@matd",uv.matd)
            };
            return DataProvider.ExcuteNonQuerry("themuv", para);
        }
        public static int UpdateProfile(ungvien uv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mauv", uv.mauv),
                new SqlParameter("@tenuv", uv.tenuv),
                new SqlParameter("@ngaysinh",uv.ngaysinh),
                new SqlParameter("@noisinh",uv.noisinh),
                new SqlParameter("@nguyenquan",uv.nguyenquan),
                new SqlParameter("@diachitamtru",uv.diachitamtru),
                new SqlParameter("@gioitinh",uv.gioitinh),
                new SqlParameter("@dantoc",uv.dantoc),
                new SqlParameter("@sodtuv",uv.sodtuv),
                new SqlParameter("@nguoilienhe",uv.nguoilienhe),
                new SqlParameter("@quoctich",uv.quoctich),
                new SqlParameter("@ngoaingu",uv.ngoaingu),
                new SqlParameter("@soCMND",uv.soCMND),
                new SqlParameter("@soBHYT",uv.soBHYT),
                new SqlParameter("@soBHXH",uv.soBHXH),
                new SqlParameter("@matd",uv.matd),
            };
            return DataProvider.ExcuteNonQuerry("suauv", para);
        }
        public static int DeleteProfile(ungvien uv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@mauv",uv.mauv),
            };
            return DataProvider.ExcuteNonQuerry("xoauv", para);
        }
        public static DataTable timkiemuv(string ten)
        {
            return DataProvider.GetData("select * from ungvien" + ten);
        }

    }
}
