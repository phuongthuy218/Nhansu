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
    public partial class Khenthuong : Form
    {
        public Khenthuong()
        {
            InitializeComponent();
        }
        public SqlConnection getconnect()
        {
            return new SqlConnection(@"Data Source=ADMINS\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        private void Khenthuong_Load(object sender, EventArgs e)
        {
            SqlConnection conn = getconnect();
            string sql = "select * from nhanvien";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbmanv.DataSource = dt;
            cbbmanv.DisplayMember = "tennv";
            cbbmanv.ValueMember = "manv";
            dgvkhenthuong.DataSource = Bus.Getlistkhenthuong();
        }
        //private void cbbmanv_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txttennv.Text = cbbmanv.SelectedValue.ToString();
        //}
        private void dgvkhenthuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbmanv.Text = dgvkhenthuong.CurrentRow.Cells["manv"].Value.ToString();          
            txthinhthuc.Text = dgvkhenthuong.CurrentRow.Cells["hinhthuc"].Value.ToString();
            txtlydo.Text = dgvkhenthuong.CurrentRow.Cells["lydo"].Value.ToString();
            datengaykt.Text = dgvkhenthuong.CurrentRow.Cells["ngaykt"].Value.ToString();
        }

        private void tbs_add_Click(object sender, EventArgs e)
        {
            cbbmanv.Text = string.Empty;
           
            txthinhthuc.Text = string.Empty;
            txtlydo.Text = string.Empty;
            datengaykt.Value = DateTime.Now;
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (cbbmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            khenthuong kt = new khenthuong();
            kt.manv = cbbmanv.SelectedValue.ToString();

            kt.hinhthuc = txthinhthuc.Text;
            kt.lydo = txtlydo.Text;
            kt.ngaykt = datengaykt.Value;
            if (MessageBox.Show(string.Format("Sửa khen thưởng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(kt) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    Khenthuong_Load(sender, e);
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
            khenthuong kt= new khenthuong();
            kt.manv = cbbmanv.SelectedValue.ToString();
  
            kt.hinhthuc = txthinhthuc.Text;
            kt.lydo = txtlydo.Text;
            kt.ngaykt = datengaykt.Value;
            if (MessageBox.Show(string.Format("Thêm khen thưởng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(kt) > 0)
                {
                    MessageBox.Show("Đã thêm");
                    Khenthuong_Load(sender, e);
                }
                else MessageBox.Show("Mã kkhen thưởng đã tồn tại");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (cbbmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            khenthuong kt = new khenthuong();
            kt.manv = cbbmanv.SelectedValue.ToString();

            kt.hinhthuc = txthinhthuc.Text;
            kt.lydo = txtlydo.Text;
            kt.ngaykt = datengaykt.Value;
            if (MessageBox.Show(string.Format("Xóa Khen thưởng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(kt) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    Khenthuong_Load(sender, e);
                }
                else MessageBox.Show("thông tin chưa đc xóa");
            }
        }
   
        public void hienthi(string ma)
        {
            dgvkhenthuong.DataSource = Bus.timkiemkt(ma);
        }
        private void tbs_search_Click(object sender, EventArgs e)
        {
            hienthi(" where manv like '%" + tstxttimkiem.Text + "'");
        }

        private void tstxttimkiem_Click(object sender, EventArgs e)
        {
            tstxttimkiem.Text = string.Empty;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
