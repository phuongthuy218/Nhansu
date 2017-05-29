using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhansu.BusinessLogicLayer;
using Nhansu.DataAccessLayer;
using Nhansu.ValueOjbect;
namespace Nhansu.Gui
{
    public partial class Quanlynguoidung : Form
    {
        public Quanlynguoidung()
        {
            InitializeComponent();
        }

        private void Quanlynguoidung_Load(object sender, EventArgs e)
        {
            dgvnguoidung.DataSource = Bus.Getlistnguoidung();
        }

        private void dgvnguoidung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtstt.Text = dgvnguoidung.CurrentRow.Cells["STT"].Value.ToString();
            txtten.Text = dgvnguoidung.CurrentRow.Cells["tendangnhap"].Value.ToString();
            txtpass.Text = dgvnguoidung.CurrentRow.Cells["matkhau"].Value.ToString();
        }

        private void tbs_add_Click(object sender, EventArgs e)
        {
            txtten.Text=string.Empty;
            txtpass.Text = string.Empty;
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            quanlinguoidung qlng = new quanlinguoidung();
            qlng.STT = txtstt.Text;
            qlng.tendangnhap = txtten.Text;
            qlng.matkhau = txtpass.Text;
            if (MessageBox.Show(string.Format("Sửa người dùng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(qlng) > 0)
                {

                    MessageBox.Show("Đã Sửa");
                    Quanlynguoidung_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            quanlinguoidung qlng = new quanlinguoidung();
            qlng.tendangnhap = txtten.Text;
            qlng.matkhau = txtpass.Text;
            if (MessageBox.Show(string.Format("Thêm người dùng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(qlng) > 0)
                {

                    MessageBox.Show("Đã thêm");
                    Quanlynguoidung_Load(sender, e);
                }
                else MessageBox.Show("Tên người dùng đã tồn tại");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            quanlinguoidung qlng = new quanlinguoidung();
            qlng.STT = txtstt.Text;
            qlng.tendangnhap = txtten.Text;
            qlng.matkhau = txtpass.Text;
            if (MessageBox.Show(string.Format("xóa người dùng"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(qlng) > 0)
                {

                    MessageBox.Show("Đã xóa");
                    Quanlynguoidung_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được xóa");
            }

        }

      
        private void tbs_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
            this.Close();
        }

       
    }
}
