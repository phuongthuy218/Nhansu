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
    public partial class Chucvu : Form
    {
        public Chucvu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Chucvu_Load(object sender, EventArgs e)
        {
            dgvchucvu.DataSource = Bus.Getlistchucvu();
        }

        private void dgvchucvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmacv.Text = dgvchucvu.CurrentRow.Cells["macvu"].Value.ToString();
            txttencv.Text = dgvchucvu.CurrentRow.Cells["tencvu"].Value.ToString();
            txtphucap.Text = dgvchucvu.CurrentRow.Cells["phucapcv"].Value.ToString();
            txthesoluong.Text = dgvchucvu.CurrentRow.Cells["hesoluong"].Value.ToString();
            txtluongcoban.Text = dgvchucvu.CurrentRow.Cells["luongcoban"].Value.ToString();
        }
        public void hienthi(string ma)
        {
            dgvchucvu.DataSource = Bus.timkiemcv(ma);
        }

        private void tsbtimkiem_Click(object sender, EventArgs e)
        {
            hienthi(" where macv like '%" + tstxttimkiem.Text + "'");
        }
        private void tstxttimkiem_Click(object sender, EventArgs e)
        {
          tstxttimkiem.Text = string.Empty;
         }

        private void tsbthoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Dispose();
            }
            Trangchu tc = new Trangchu();
            tc.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtmacv.Text = string.Empty;
            txttencv.Text = string.Empty;
            txthesoluong.Text = string.Empty;
            txtphucap.Text = string.Empty;
            txtluongcoban.Text = string.Empty;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtmacv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            chucvu cv = new chucvu();
            cv.macv = txtmacv.Text;
            cv.tencv = txtmacv.Text;
            cv.phucapcv = txtphucap.Text;
            cv.hesoluong = txthesoluong.Text;
            cv.luongcoban = txtluongcoban.Text;

           
            if (MessageBox.Show(string.Format("Thêm chức vụ"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(cv) > 0)
                {
                    MessageBox.Show("Đã Thêm");
                    Chucvu_Load(sender, e);
                }
                else MessageBox.Show("đã bị trùng");
            }
        }
    }
}
