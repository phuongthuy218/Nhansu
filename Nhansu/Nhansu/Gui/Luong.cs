using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Nhansu.BusinessLogicLayer;
using Nhansu.DataAccessLayer;
using Nhansu.ValueOjbect;

namespace Nhansu.Gui
{
    public partial class Luong : Form
    {
        public Luong()
        {
            InitializeComponent();
        }
        
        
        private void Luong_Load(object sender, EventArgs e)
        {
           
        
            dgvluong.DataSource = Bus.Getlistluong();
            
            Comboboxht();
           
        }


     

        private void Comboboxht()
        {
            try
            {
                cbbmanv.DisplayMember = "manv";
                cbbmanv.ValueMember = "tennv";
                cbbmanv.DataSource = Bus.Getlistnhanvien();
              
                //cbbmacv.DisplayMember = "macv";
                //cbbmacv.ValueMember = "tencv";
                //cbbmacv.DataSource = Bus.Getlistchucvu();


            }
            catch (Exception)
            {
                return;
            }

        }
      

        private void dgvluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            cbbmanv.Text = dgvluong.CurrentRow.Cells["manv"].Value.ToString();
            txttennv.Text = dgvluong.CurrentRow.Cells["tennv"].Value.ToString();    
            cbbmacv.Text = dgvluong.CurrentRow.Cells["macv"].Value.ToString();          
            txthesoluong.Text = dgvluong.CurrentRow.Cells["hesoluong"].Value.ToString();
            txtphucapcv.Text = dgvluong.CurrentRow.Cells["phucapcv"].Value.ToString();
            txtluongcoban.Text = dgvluong.CurrentRow.Cells["luongcoban"].Value.ToString();          
            txttienthuong.Text = dgvluong.CurrentRow.Cells["tienthuong"].Value.ToString();
            txttienphat.Text = dgvluong.CurrentRow.Cells["tienphat"].Value.ToString();
            txttienBHYT.Text = dgvluong.CurrentRow.Cells["tienbaohiemyte"].Value.ToString();
            txttienBHXH.Text = dgvluong.CurrentRow.Cells["tienbaohiemxahoi"].Value.ToString();
            txttongluong.Text = dgvluong.CurrentRow.Cells["tongluong"].Value.ToString();

        }

        private void tbs_add_Click(object sender, EventArgs e)
        {
            cbbmanv.Text = string.Empty;
            txttennv.Text = string.Empty;
            cbbmacv.Text = string.Empty;               
            txthesoluong.Text = string.Empty;
            txtphucapcv.Text = string.Empty;
            txtluongcoban.Text = string.Empty;       
            txttienthuong.Text = string.Empty;
            txttienphat.Text = string.Empty;
            txttienBHYT.Text = string.Empty;
            txttienBHXH.Text = string.Empty;
            txttongluong.Text = string.Empty;
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (cbbmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            luong l = new luong();
            l.manv = cbbmanv.Text;
            l.tennv = txttennv.Text;
            l.macv = cbbmacv.Text;         
            l.hesoluong = int.Parse(txthesoluong.Text.ToString());
            l.phucapcv = int.Parse(txtphucapcv.Text.ToString());
            l.luongcoban = int.Parse(txtluongcoban.Text.ToString());
            l.tienthuong = int.Parse(txttienthuong.Text.ToString());
            l.tienphat = int.Parse(txttienphat.Text.ToString());
            l.tienbaohiemyte = int.Parse(txttienBHYT.Text.ToString());
            l.tienbaohiemxahoi = int.Parse(txttienBHXH.Text.ToString());
            l.tongluong = int.Parse(txttongluong.Text.ToString());
            if (MessageBox.Show(string.Format("Sửa lương"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(l) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    Luong_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa đc sửa");
            }
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {
            if (cbbmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            luong l = new luong();
            l.manv = cbbmanv.Text;
            l.tennv = txttennv.Text;
            l.macv = cbbmacv.Text;
            l.hesoluong =int.Parse(txthesoluong.Text.ToString());
            l.phucapcv = int.Parse(txtphucapcv.Text.ToString());
            l.luongcoban = int.Parse(txtluongcoban.Text.ToString());
            l.tienthuong = int.Parse(txttienthuong.Text.ToString());
            l.tienphat = int.Parse(txttienphat.Text.ToString());
            l.tienbaohiemyte = int.Parse(txttienBHYT.Text.ToString());
            l.tienbaohiemxahoi = int.Parse(txttienBHXH.Text.ToString());
            l.tongluong = int.Parse(txttongluong.Text.ToString());
            if (MessageBox.Show(string.Format("Thêm lương"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(l) > 0)
                {
                    MessageBox.Show("Đã Thêm");
                    Luong_Load(sender, e);
                }
                else MessageBox.Show("Nhân viên đã có");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (cbbmanv.Text == "")
            {

                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            luong l = new luong();
            l.manv = cbbmanv.Text;
            l.tennv = txttennv.Text;
            l.macv = cbbmacv.Text;       
            l.hesoluong = int.Parse(txthesoluong.Text.ToString());
            l.phucapcv = int.Parse(txtphucapcv.Text.ToString());
            l.luongcoban = int.Parse(txtluongcoban.Text.ToString());
            l.tienthuong = int.Parse(txttienthuong.Text.ToString());
            l.tienphat = int.Parse(txttienphat.Text.ToString());
            l.tienbaohiemyte = int.Parse(txttienBHYT.Text.ToString());
            l.tienbaohiemxahoi = int.Parse(txttienBHXH.Text.ToString());
            l.tongluong = int.Parse(txttongluong.Text.ToString());
            if (MessageBox.Show(string.Format("Xóa lương"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(l) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    Luong_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa đc xóa");
            }
        }

        private void tbs_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
            Trangchu tc = new Trangchu();
            tc.Show();
            this.Close();
        }
        public void hienthi(string ma)
        {
            dgvluong.DataSource = Bus.timkiemluong(ma);
        }
        private void tbs_search_Click(object sender, EventArgs e)
        {
            hienthi(" where manv like '%" +tstxttimkiem.Text + "'");
        
    }

        private void tstxttimkiem_Click(object sender, EventArgs e)
        {
            tstxttimkiem.Text = string.Empty;
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            int hesoluong;
            int phucapcv;
            int luongcoban;
            int tienthuong;
            int tienphat;
            int tienbaohiemyte;
            int tienbaohiemxahoi;
            hesoluong = Convert.ToInt32(txthesoluong.Text);
            phucapcv = Convert.ToInt32(txtphucapcv.Text);
            luongcoban = Convert.ToInt32(txtluongcoban.Text);
            tienthuong = Convert.ToInt32(txttienthuong.Text);
            tienphat = Convert.ToInt32(txttienphat.Text);
            tienbaohiemyte = Convert.ToInt32(txttienBHYT.Text);
            tienbaohiemxahoi = Convert.ToInt32(txttienBHXH.Text);
            int tien;
            tien = (hesoluong * luongcoban + phucapcv + tienthuong) - (tienphat + tienbaohiemyte + tienbaohiemxahoi);
            txttongluong.Text = tien.ToString();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            cbbmacv.Text = DataAccessLayer.DataProvider.GetValues("select macv from nhanvien where manv='" + cbbmanv.Text + "'");
            txthesoluong.Text = DataAccessLayer.DataProvider.GetValues("select hesoluong from chucvu where macv='" + cbbmacv.Text + "'");
            txtphucapcv.Text= DataAccessLayer.DataProvider.GetValues("select phucapcv from chucvu where macv='" + cbbmacv.Text + "'");
            txttennv.Text = DataAccessLayer.DataProvider.GetValues("select tennv from nhanvien where manv='" + cbbmanv.Text + "'");
            txtluongcoban.Text = DataAccessLayer.DataProvider.GetValues("select luongcoban from chucvu where macv ='" + cbbmacv.Text + "'");
        }

        private void butsangkhenthuong_Click(object sender, EventArgs e)
        {
            Khenthuong kt = new Khenthuong();
            kt.Show();
        }

        private void butkyluat_Click(object sender, EventArgs e)
        {
            Kyluat kl = new Kyluat();
            kl.Show();
        }

        //private void cbbmacv_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        ////private void cbbmacv_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txthesoluong.Text = cbbmacv.SelectedValue.ToString();
        //    //    SqlConnection conn = getconnect();
        //    //    string sql = "select phucapcv,hesoluong from chucvu";
        //    //    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        //    //    DataTable dt = new DataTable();
        //    //    da.Fill(dt);
        //    //    this.txtphucapcv.DataBindings.Clear();
        //    //    this.txthesoluong.DataBindings.Clear();
        //    //   this.txtphucapcv.DataBindings.Add("text", dt, "phucapcv");
        //    //    this.txthesoluong.DataBindings.Add("text",dt, "hesoluong");
        //    //}
        //}
        ////private void cbbmacv_ValueMemberChanged(object sender, EventArgs e)
        //{
        //    txthesoluong.Text = cbbmacv.SelectedValue.ToString();
        //}

        //private void cbbmacv_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txthesoluong.Text = cbbmacv.SelectedValue.ToString();
        //}
    }
}
