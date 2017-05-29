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
    public partial class Dieuchuyencongtac : Form
    {
        public Dieuchuyencongtac()
        {
            InitializeComponent();
        }
        public SqlConnection getconnect()
        {
            return new SqlConnection(@"Server=DESKTOP-7HJFAVT\SQLEXPRESSTT;Database=Nhansu;Integrated Security=True");
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
        public void comboo()
        {
            
            cbbpbmoi.DisplayMember = "tenpb";
            cbbpbmoi.ValueMember = "mapb";
            cbbpbmoi.DataSource = Bus.Getlistphongban();
            
            cbbcvmoi.DisplayMember = "tencv";
            cbbcvmoi.ValueMember = "macv";
            cbbcvmoi.DataSource = Bus.Getlistchucvu();
        }
        private void Dieuchuyencongtac_Load(object sender, EventArgs e)
        {
            SqlConnection conn = getconnect();
            string sql = "select * from nhanvien";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbmanv.DataSource = dt;
            cbbmanv.DisplayMember = "manv";
            cbbmanv.ValueMember = "tennv";
            dgvdieuchuyen.DataSource = Bus.Getlistdieuchuyencongtac();
            comboo();
        }

        private void tbs_add_Click(object sender, EventArgs e)
        {
            cbbmanv.Text = string.Empty;
            txttennv.Text = string.Empty;
            txtpbcu.Text = string.Empty;
            cbbpbmoi.Text = string.Empty;
            txtcvcu.Text = string.Empty;
            cbbcvmoi.Text = string.Empty;
            datetungay.Value = DateTime.Now;
            txtlydo.Text = string.Empty;
            txtghichu.Text = string.Empty;

        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (txtpbcu.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            dieuchuyencongtac dcct = new dieuchuyencongtac();
            dcct.manv = cbbmanv.Text;
            dcct.tennv = txttennv.Text;
            dcct.mapbcu = txtpbcu.Text;
            dcct.mapbmoi = cbbpbmoi.SelectedValue.ToString();
            dcct.macvcu = txtcvcu.Text;
            dcct.macvmoi = cbbcvmoi.SelectedValue.ToString();
            dcct.tungay = datetungay.Value;
            dcct.lydo = txtlydo.Text;
            dcct.ghichu = txtlydo.Text;
            if (MessageBox.Show(string.Format("Sửa Điều chuyển công tác"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(dcct) > 0)
                {
                    MessageBox.Show("Đã sửa");
                   Dieuchuyencongtac_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa đc sửa");
            }
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {
            if (txtpbcu.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            dieuchuyencongtac dcct = new dieuchuyencongtac();
            dcct.manv = cbbmanv.Text;
            dcct.tennv = txttennv.Text;
            dcct.mapbcu = txtpbcu.Text;
            dcct.mapbmoi = cbbpbmoi.SelectedValue.ToString();
            dcct.macvcu = txtcvcu.Text;
            dcct.macvmoi = cbbcvmoi.SelectedValue.ToString();
            dcct.tungay = datetungay.Value;
            dcct.lydo = txtlydo.Text;
            dcct.ghichu = txtlydo.Text;
            if (MessageBox.Show(string.Format("Thêm Điều chuyển công tác"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(dcct) > 0)
                {
                    MessageBox.Show("Đã Thêm");
                    Dieuchuyencongtac_Load(sender, e);
                }
                else MessageBox.Show("Lỗi");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (txtpbcu.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            dieuchuyencongtac dcct = new dieuchuyencongtac();
            dcct.manv = cbbmanv.Text;
            dcct.tennv = txttennv.Text;
            dcct.mapbcu = txtpbcu.Text;
            dcct.mapbmoi = cbbpbmoi.SelectedValue.ToString();
            dcct.macvcu = txtcvcu.Text;
            dcct.macvmoi = cbbcvmoi.SelectedValue.ToString();
            dcct.tungay = datetungay.Value;
            dcct.lydo = txtlydo.Text;
            dcct.ghichu = txtlydo.Text;
            if (MessageBox.Show(string.Format("Xóa Điều chuyển công tác"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(dcct) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    Dieuchuyencongtac_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa đc xóa");
            }
        }
        public void hienthi(string ma)
        {
            dgvdieuchuyen.DataSource = Bus.timkiemdcct(ma);
        }
        private void tbs_search_Click(object sender, EventArgs e)
        {
            hienthi(" where manv like '%" + tstxttimkiem.Text + "'");
        }

        private void dgvdieuchuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbmanv.Text = dgvdieuchuyen.CurrentRow.Cells["manv"].Value.ToString();
            txttennv.Text = dgvdieuchuyen.CurrentRow.Cells["tennv"].Value.ToString();
             txtpbcu.Text = dgvdieuchuyen.CurrentRow.Cells["mapbcu"].Value.ToString();
            cbbpbmoi.Text = dgvdieuchuyen.CurrentRow.Cells["mapbmoi"].Value.ToString();
            cbbcvmoi.Text = dgvdieuchuyen.CurrentRow.Cells["macvmoi"].Value.ToString();
            txtcvcu.Text = dgvdieuchuyen.CurrentRow.Cells["macvcu"].Value.ToString();
            datetungay.Text = dgvdieuchuyen.CurrentRow.Cells["tungay"].Value.ToString();
            txtlydo.Text = dgvdieuchuyen.CurrentRow.Cells["lydo"].Value.ToString();
            txtghichu.Text = dgvdieuchuyen.CurrentRow.Cells["ghichu"].Value.ToString();
        }

        private void tstxttimkiem_Click(object sender, EventArgs e)
        {
            tstxttimkiem.Text = string.Empty;
        }

        private void butchon_Click(object sender, EventArgs e)
        {
            txttennv.Text = DataAccessLayer.DataProvider.GetValues("select tennv from nhanvien where manv ='" + cbbmanv.Text + "'");
            txtpbcu.Text = DataAccessLayer.DataProvider.GetValues("select mapb from nhanvien where manv ='" + cbbmanv.Text + "'");
            txtcvcu.Text = DataAccessLayer.DataProvider.GetValues("select macv from nhanvien where manv ='" + cbbmanv.Text + "'");
           // txttenpb.Text = DataAccessLayer.DataProvider.GetValues("select tenpb from where mapb ='" + cbbpbmoi.Text + "'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Phongban pb = new Phongban();
            pb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chucvu cv = new Chucvu();
            cv.Show();
        }

        //private void cbbmanv_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txttennv.Text = cbbmanv.SelectedValue.ToString();

        //}
    }
}
