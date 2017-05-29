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
    public partial class Danhsachnvdt : Form
    {
        
        
        public Danhsachnvdt()
        {
            InitializeComponent();
        }
       
        private void Danhsachnvdt_Load(object sender, EventArgs e)
        {
            cbbmadt.DisplayMember = "madt";
            cbbmadt.ValueMember = "madt";
            cbbmadt.DataSource = Bus.Getlistdaotao();
            cbbmanv.DisplayMember = "manv";
            cbbmanv.ValueMember = "manv";
            cbbmanv.DataSource = Bus.Getlistnhanvien();
            dgvnvdt.DataSource = Bus.Getlistdanhsachnvdt();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            cbbmadt.Text = string.Empty;
            txttendt.Text = string.Empty;           
            cbbmanv.Text = string.Empty;
            txttennv.Text = string.Empty;
            
        }

        private void tsbluu_Click(object sender, EventArgs e)
        {
            
            if (cbbmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            nhanviendaotao nvdt= new nhanviendaotao();
            nvdt.madt = cbbmadt.Text;
            nvdt.tendt = txttendt.Text;        
            nvdt.manv = cbbmanv.Text;
            nvdt.tennv = txttennv.Text;
            if (MessageBox.Show(string.Format("Thêm nhân viên đào tạo"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(nvdt) > 0)
                {
                    MessageBox.Show("Đã thêm");
                    Danhsachnvdt_Load(sender, e);
                }
                else MessageBox.Show("Mã nhân viên đã tồn tại");
            }
        }

        private void tsbthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void dgvnvdt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttendt.Text = dgvnvdt.CurrentRow.Cells["tendt"].Value.ToString();
            txttennv.Text = dgvnvdt.CurrentRow.Cells["tennv"].Value.ToString();
            cbbmanv.Text = dgvnvdt.CurrentRow.Cells["manv"].Value.ToString();
            cbbmadt.Text = dgvnvdt.CurrentRow.Cells["madt"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txttennv.Text = DataAccessLayer.DataProvider.GetValues("select tennv from nhanvien where manv='" + cbbmanv.Text + "'");
            txttendt.Text = DataAccessLayer.DataProvider.GetValues("select tendt from daotao where madt='" + cbbmadt.Text + "'");
        }
        public void hienthi(string ma)
        {
            dgvnvdt.DataSource = Bus.timkiemnvdt(ma);
        }
        private void tsbuttimkiem_Click(object sender, EventArgs e)
        {

            hienthi(" where madt like '%" + tstxttimkiem.Text + "'");

        }

        private void tstxttimkiem_Click(object sender, EventArgs e)
        {
            tstxttimkiem.Text = string.Empty;
        }

        //private void cbbmanv_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txttennv.Text = cbbmanv.SelectedValue.ToString();
        //}
    }
}
