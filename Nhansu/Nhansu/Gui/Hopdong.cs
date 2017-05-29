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
    public partial class Hopdong : Form
    {
        public Hopdong()
        {
            InitializeComponent();
        }
     
        public SqlConnection getconnect()
        {
            return new SqlConnection(@"Server=DESKTOP-7HJFAVT\SQLEXPRESSTT;Database=Nhansu;Integrated Security=True");
        }
        private void Hopdong_Load(object sender, EventArgs e)
        {
            SqlConnection conn = getconnect();
            string sql = "select * from nhanvien";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbmanv.DataSource = dt;
            cbbmanv.DisplayMember = "tennv";
            cbbmanv.ValueMember = "manv";
            dgvhopdong.DataSource = Bus.Getlisthopdong();
        }
      
        private void dgvhopdong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmahd.Text = dgvhopdong.CurrentRow.Cells["mahd"].Value.ToString();
            txtloaihd.Text = dgvhopdong.CurrentRow.Cells["loaihd"].Value.ToString();
            cbbmanv.Text = dgvhopdong.CurrentRow.Cells["manv"].Value.ToString();
           
            datetungay.Text = dgvhopdong.CurrentRow.Cells["tungay"].Value.ToString();
            datedenngay.Text = dgvhopdong.CurrentRow.Cells["denngay"].Value.ToString();
        }

        //private void cbbmanv_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.txttennv.Text = cbbmanv.SelectedValue.ToString();
        //}

        private void tbs_add_Click(object sender, EventArgs e)
        {
            txtmahd.Text = string.Empty;
            txtloaihd.Text = string.Empty;
            cbbmanv.Text = string.Empty;
          
            datetungay.Value = DateTime.Now;
            datedenngay.Value = DateTime.Now;
            datengaykikethd.Value = DateTime.Now;
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            hopdong hd = new hopdong();
            hd.mahd = txtmahd.Text;
            hd.loaihd = txtloaihd.Text;
            hd.manv = cbbmanv.SelectedValue.ToString();
           
            hd.tungay = datetungay.Value;
            hd.denngay = datedenngay.Value;
            hd.ngaykikethd = datengaykikethd.Value;
            if (MessageBox.Show(string.Format("Sửa hợp đồng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(hd) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    Hopdong_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa đc sửa");
            }
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            hopdong hd = new hopdong();
            hd.mahd = txtmahd.Text;
            hd.loaihd = txtloaihd.Text;
            hd.manv = cbbmanv.SelectedValue.ToString();          
            hd.tungay = datetungay.Value;
            hd.denngay = datedenngay.Value;
            hd.ngaykikethd = datengaykikethd.Value;
            if (MessageBox.Show(string.Format("Thêm hợp đồng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(hd) > 0)
                {
                    MessageBox.Show("Đã Thêm");
                    Hopdong_Load(sender, e);
                }
                else MessageBox.Show("Mã hợp đồng đã tồn tại");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            hopdong hd = new hopdong();
            hd.mahd = txtmahd.Text;
            hd.loaihd = txtloaihd.Text;
            hd.manv = cbbmanv.SelectedValue.ToString();
           
            hd.tungay = datetungay.Value;
            hd.denngay = datedenngay.Value;
            hd.ngaykikethd = datengaykikethd.Value;
            if (MessageBox.Show(string.Format("Xóa hợp đồng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(hd) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    Hopdong_Load(sender, e);
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
            dgvhopdong.DataSource = Bus.timkiemhd(ma);
        }
        private void tbs_search_Click(object sender, EventArgs e)
        {
            hienthi(" where mahd like '%" + tstxttimkiem.Text + "'");
        }

        private void tstxttimkiem_Click(object sender, EventArgs e)
        {
            tstxttimkiem.Text = string.Empty;
        }
    }
}
