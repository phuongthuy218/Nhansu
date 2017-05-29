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
    
    public partial class Daotao : Form
    {
  
        public Daotao()
        {
            InitializeComponent();
        }

        private void Daotao_Load(object sender, EventArgs e)
        {
            dgvdaotao.DataSource = Bus.Getlistdaotao();
        }

        private void dgvdaotao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmadt.Text = dgvdaotao.CurrentRow.Cells["madt"].Value.ToString();
            txttendt.Text = dgvdaotao.CurrentRow.Cells["tendt"].Value.ToString();
            txtdiachi.Text = dgvdaotao.CurrentRow.Cells["diachi"].Value.ToString();
            txtsonv.Text = dgvdaotao.CurrentRow.Cells["soluongnv"].Value.ToString();
            datetungay.Text = dgvdaotao.CurrentRow.Cells["tungay"].Value.ToString();
            datedenngay.Text = dgvdaotao.CurrentRow.Cells["denngay"].Value.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txtmadt.Text = string.Empty;
            txttendt.Text = string.Empty;
            txtdiachi.Text = string.Empty;
            txtsonv.Text = string.Empty;
            datetungay.Value = DateTime.Now;
            datedenngay.Value = DateTime.Now;
           
        }

        private void tsbluu_Click(object sender, EventArgs e)
        {
         
            if (txtmadt.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            daotao dt = new daotao();
            dt.madt = txtmadt.Text;
            dt.tendt = txttendt.Text;
            dt.diachi = txtdiachi.Text;
            dt.soluongnv =txtsonv.Text;
            dt.tungay = datetungay.Value;
            dt.denngay = datedenngay.Value;
            dt.ghichu = txtghichu.Text;
            if (MessageBox.Show(string.Format("Thêm đào tạo"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(dt) > 0)
                {
                   
                    MessageBox.Show("Đã thêm");
                    Daotao_Load(sender, e);
                }
                else MessageBox.Show("Mã đào tạo đã tồn tại");
            }

        }

        private void tsbxemnvdt_Click(object sender, EventArgs e)
        {
           
            Danhsachnvdt dsnv = new Danhsachnvdt();
            dsnv.Show();
        }
       
        private void tsbthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
            Trangchu tc = new Trangchu();
            tc.Show();
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Trangchu tc = new Trangchu();
            tc.ShowDialog();
            this.Hide();
        }

        public void hienthi(string ma)
        {
            dgvdaotao.DataSource = Bus.timkiemdt(ma);
        }
        private void tsbtimkiem_Click(object sender, EventArgs e)
        {
            hienthi(" where madt like '%" + tstxttimkiem.Text + "'");
        }

        private void tstxttimkiem_Click(object sender, EventArgs e)
        {
            tstxttimkiem.Text = string.Empty;
        }
    }
}
