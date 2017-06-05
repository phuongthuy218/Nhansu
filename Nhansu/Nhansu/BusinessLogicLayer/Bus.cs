using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Nhansu.DataAccessLayer;
using Nhansu.ValueOjbect;

namespace Nhansu.BusinessLogicLayer
{
    class Bus
    {
        //người dùng
        public static DataTable Getlistnguoidung()
        {
            return Dao.Getlistnguoidung();
        }
        public static  int InsertProfile(quanlinguoidung ql)
        {
            return Dao.InsertProfile(ql);
        }
        public static int UpdateProfile(quanlinguoidung ql)
        {
            return Dao.UpdateProfile(ql);
        }
        public static int DeleteProfile(quanlinguoidung ql)
        {
            return Dao.DeleteProfile(ql);
        }
        //chức vụ
        public static DataTable Getlistchucvu()
        {
            return Dao.Getlistchucvu();
        }
        public static int InsertProfile(chucvu cv)
        {
            return Dao.InsertProfile(cv);
        }
        public static DataTable timkiemcv(string ma)
        {
            return Dao.timkiemcv(ma);
        }
        //danh sách nv đào tạo
        public static DataTable Getlistdanhsachnvdt()
        {
            return Dao.Getlistdanhsachnvdt();
        }
        public static int InsertProfile(nhanviendaotao nvdt)
        {
            return Dao.InsertProfile(nvdt);

        }
        public static DataTable timkiemnvdt(string ma)
        {
            return Dao.timkiemnvdt(ma);
        }        
        //đào tạo
        public static DataTable Getlistdaotao()
        {
            return Dao.Getlistdaotao();
        }
        public static int InsertProfile(daotao dt)
        {
            return Dao.InsertProfile(dt);
        }
        public static DataTable timkiemdt(string ma)
        {
            return Dao.timkiemdt(ma);
        }

        //điều chuyển công tác
        public static DataTable Getlistdieuchuyencongtac()
        {
            return Dao.Getlistdieuchuyencongtac();
        }
        public static int InsertProfile (dieuchuyencongtac dcct)
        {
            return Dao.InsertProfile(dcct);
        }
        public static int UpdateProfile(dieuchuyencongtac dcct)
        {
            return Dao.UpdateProfile(dcct);
        }
        public static int DeleteProfile(dieuchuyencongtac dcct)
        {
            return Dao.DeleteProfile(dcct);
        }
        public static DataTable timkiemdcct(string ma)
        {
            return Dao.timkiemdcct(ma);
        }
        //hợp đồng 
        public static DataTable Getlisthopdong()
        {
            return Dao.Getlisthopdong();
        }
        public static int InsertProfile(hopdong hd)
        {
            return Dao.InsertProfile(hd);
        }
        public static int UpdateProfile(hopdong hd)
        {
            return Dao.UpdateProfile(hd);
        }
        public static int DeleteProfile(hopdong hd)
        {
            return Dao.DeleteProfile(hd);
        }
        public static DataTable timkiemhd(string ma)
        {
            return Dao.timkiemhd(ma);
        }
        //kỷ luật
        public static DataTable Getlistkyluat()
        {
            return Dao.Getlistkyluat();
        }
        public static int InsertProfile(kyluat kl)
        {
            return Dao.InsertProfile(kl);
        }
        public static int UpdateProfile(kyluat kl)
        {
            return Dao.UpdateProfile(kl);
        }
        public static int DeleteProfile(kyluat kl)
        {
            return Dao.DeleteProfile(kl);
        }
        public static DataTable timkiemkl(string ma)
        {
            return Dao.timkiemkl(ma);
        }
        //khen thưởng
        public static DataTable Getlistkhenthuong()
        {
            return Dao.Getlistkhenthuong();
        }
        public static int InsertProfile(khenthuong kt)
        {
            return Dao.InsertProfile(kt);
        }
        public static int UpdateProfile(khenthuong kt)
        {
            return Dao.UpdateProfile(kt);
        }
        public static int DeleteProfile(khenthuong kt)
        {
            return Dao.DeleteProfile(kt);
        }
        public static DataTable timkiemkt(string ma)
        {
            return Dao.timkiemkt(ma);
        }
        //luong
        public static DataTable Getlistluong()
        {
            return Dao.Getlistluong();
        }
        public static int InsertProfile(luong l)
        {
            return Dao.InsertProfile(l);
        }
        public static int UpdateProfile(luong l)
        {
            return Dao.UpdateProfile(l);
        }
        public static int DeleteProfile(luong l)
        {
            return Dao.DeleteProfile(l);
        }
        public static DataTable timkiemluong(string ma)
        {
            return Dao.timkiemluong(ma);
        }
        //nhân viên
        #region
        public static DataTable Getlistnhanvien()
        {
            return Dao.Getlistnhanvien();
        }
        public static int InsertProfile(nhanvien nv,ungvien uv)
        {
            return Dao.InsertProfile(nv,uv);
        }
        public static int UpdateProfile(nhanvien nv)
        {
            return Dao.UpdateProfile(nv);
        }
        public static int DeleteProfile(nhanvien nv)
        {
            return Dao.DeleteProfile(nv);
        }
        public static DataTable timkiemnv(string ten)
        {
            return Dao.timkiemnv(ten);
        }
        public static DataTable timkiemtheopb(string mapb)
        {
            return Dao.timkiemtheopb(mapb);
        }
        public static DataTable timkiemtheocv(string macv)
        {
            return Dao.timkiemtheocv(macv);
        }
        #endregion
        //phòng ban
        public static DataTable Getlistphongban()
        {
            return Dao.Getlistphongban();
        }
        public static int InsertProfile(phongban pb)
        {
            return Dao.InsertProfile(pb);
        }
        public static int UpdateProfile(phongban pb)
        {
            return Dao.UpdateProfile(pb);
        }
        public static int DeleteProfile(phongban pb)
        {
            return Dao.DeleteProfile(pb);
        }
        public static DataTable timkiempb(string ma)
        {
            return Dao.timkiempb(ma);
        }
        //thân nhân 
        public static DataTable Getlistthannhan()
        {
            return Dao.Getlistthannhan();
        }
        public static int InsertProfile(thannhan tn)
        {
            return Dao.InsertProfile(tn);
        }
        public static int DeleteProfile(thannhan tn)
        {
            return Dao.DeleteProfile(tn);
        }
        public static DataTable timkiemtn(string ten)
        {
            return Dao.timkiemtn(ten);
        }
        //trình độ
        public static DataTable Getlisttrinhdo()
        {
            return Dao.Getlisttrinhdo();
        }
        public static DataTable timkiemtd(string ma)
        {
            return Dao.timkiemtd(ma);
        }
        //ứng viên
        public static DataTable Getlistungvien()
        {
            return Dao.Getlistungvien();
        }
        public static int InsertProfile(ungvien uv)
        {
            return Dao.InsertProfile(uv);
        }
        public static int UpdateProfile(ungvien uv)
        {
            return Dao.UpdateProfile(uv);
        }
        public static int DeleteProfile(ungvien uv)
        {
            return Dao.DeleteProfile(uv);
        }
        public static DataTable timkiemuv(string ten)
        {
            return Dao.timkiemuv(ten);
        }
      
    }
}
