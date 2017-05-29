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
    public partial class Phongban : Form
    {
        public Phongban()
        {
            InitializeComponent();
        }

        private void dgvphongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmapb.Text = dgvphongban.CurrentRow.Cells["mapb"].Value.ToString();
            txttenpb.Text = dgvphongban.CurrentRow.Cells["tenpb"].Value.ToString();
            txtdiachi.Text = dgvphongban.CurrentRow.Cells["diachi"].Value.ToString();
            txtsdtpb.Text = dgvphongban.CurrentRow.Cells["SDTpb"].Value.ToString();
        }

        private void Phongban_Load(object sender, EventArgs e)
        {
            dgvphongban.DataSource = Bus.Getlistphongban();
        }

        private void tbs_add_Click(object sender, EventArgs e)
        {
            txtmapb.Text = string.Empty;
            txttenpb.Text = string.Empty;
            txtdiachi.Text = string.Empty;
            txtsdtpb.Text = string.Empty;
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (txtmapb.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            phongban pb = new phongban();
            pb.mapb = txtmapb.Text;
            pb.tenpb = txttenpb.Text;
            pb.diachi = txtdiachi.Text;
            pb.SDTpb = txtsdtpb.Text;
            if (MessageBox.Show(string.Format("Sửa phòng ban"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(pb) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    Phongban_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa đc sửa");
            }
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {
            if (txtmapb.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            phongban pb = new phongban();
            pb.mapb = txtmapb.Text;
            pb.tenpb = txttenpb.Text;
            pb.diachi = txtdiachi.Text;
            pb.SDTpb = txtsdtpb.Text;
            if (MessageBox.Show(string.Format("Thêm phòng ban"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(pb) > 0)
                {
                    MessageBox.Show("Đã thêm");
                    Phongban_Load(sender, e);
                }
                else MessageBox.Show("Mã phòng ban đã tốn tại");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (txtmapb.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            phongban pb = new phongban();
            pb.mapb = txtmapb.Text;
            pb.tenpb = txttenpb.Text;
            pb.diachi = txtdiachi.Text;
            pb.SDTpb = txtsdtpb.Text;
            if (MessageBox.Show(string.Format("Xóa phòng ban"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(pb) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    Phongban_Load(sender, e);
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
            dgvphongban.DataSource = Bus.timkiempb(ma);
        }
        private void tbs_search_Click(object sender, EventArgs e)
        {
            hienthi(" where mapb like '%" + tstxttimkiem.Text + "'");
        
    }

        private void tstxttimkiem_Click(object sender, EventArgs e)
        {
            tstxttimkiem.Text = string.Empty;
        }
    }
}
