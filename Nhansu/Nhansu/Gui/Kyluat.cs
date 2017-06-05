using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Nhansu.BusinessLogicLayer;
using Nhansu.DataAccessLayer;
using Nhansu.ValueOjbect;
using System.Windows.Forms;

namespace Nhansu.Gui
{
    public partial class Kyluat : Form
    {
        public Kyluat()
        {
            InitializeComponent();
        }
        public SqlConnection getconnect()
        {
            return new SqlConnection(@"Data Source=ADMINS\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        private void Kyluat_Load(object sender, EventArgs e)
        {
            SqlConnection conn = getconnect();
            string sql = "select * from nhanvien";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbmanv.DataSource = dt;
            cbbmanv.DisplayMember = "tennv";
            cbbmanv.ValueMember = "manv";
            dgvkyluat.DataSource = Bus.Getlistkyluat();
        }

        private void dgvkyluat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbmanv.Text = dgvkyluat.CurrentRow.Cells["manv"].Value.ToString();      
            txthinhthuc.Text = dgvkyluat.CurrentRow.Cells["hinhthuc"].Value.ToString();
            txtlydo.Text = dgvkyluat.CurrentRow.Cells["lydo"].Value.ToString();
            datengaykl.Text = dgvkyluat.CurrentRow.Cells["ngaykl"].Value.ToString();
        }

        private void tbs_add_Click(object sender, EventArgs e)
        {
            cbbmanv.Text = string.Empty;        
            txthinhthuc.Text = string.Empty;
            txtlydo.Text = string.Empty;
            datengaykl.Value = DateTime.Now;
           
        }

  
        private void tbs_save_Click(object sender, EventArgs e)
        {
            if (cbbmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            kyluat kl = new kyluat();
            kl.manv = cbbmanv.SelectedValue.ToString();
         
            kl.hinhthuc=txthinhthuc.Text;
            kl.lydo=txtlydo.Text;
            kl.ngaykl=datengaykl.Value;
            if (MessageBox.Show(string.Format("Thêm Kỷ luật"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(kl) > 0)
                {
                    MessageBox.Show("Đã thêm");
                    Kyluat_Load(sender, e);
                }
                else MessageBox.Show("Mã kỷ luật đã tồn tại");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (cbbmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            kyluat kl = new kyluat();
            kl.manv = cbbmanv.SelectedValue.ToString();
        
            kl.hinhthuc = txthinhthuc.Text;
            kl.lydo = txtlydo.Text;
            kl.ngaykl = datengaykl.Value;
            if (MessageBox.Show(string.Format("Xóa Kỷ luật"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(kl) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    Kyluat_Load(sender, e);
                }
                else MessageBox.Show("thông tin chưa đc xóa");
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
            dgvkyluat.DataSource = Bus.timkiemkl(ma);
        }
        private void tbs_search_Click(object sender, EventArgs e)
        {
            hienthi(" where manv like '%" + tstxttimkiem.Text + "'");
        }

        private void tstxttimkiem_Click(object sender, EventArgs e)
        {
            tstxttimkiem.Text = string.Empty;
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (cbbmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            kyluat kl = new kyluat();
            kl.manv = cbbmanv.SelectedValue.ToString();
          
            kl.hinhthuc = txthinhthuc.Text;
            kl.lydo = txtlydo.Text;
            kl.ngaykl = datengaykl.Value;
            if (MessageBox.Show(string.Format("Sửa Kỷ luật"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(kl) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    Kyluat_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa đc sửa");
            }
        }

        //private void cbbmanv_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txttennv.Text = cbbmanv.SelectedValue.ToString();
        //}
    }
}
