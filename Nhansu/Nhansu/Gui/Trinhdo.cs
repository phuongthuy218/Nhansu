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
    public partial class Trinhdo : Form
    {
        public Trinhdo()
        {
            InitializeComponent();
        }

        private void Trinhdo_Load(object sender, EventArgs e)
        {
            dgvtrinhdo.DataSource = Bus.Getlisttrinhdo();
        }

        private void dgvtrinhdo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatd.Text = dgvtrinhdo.CurrentRow.Cells["matd"].Value.ToString();
            txttentd.Text = dgvtrinhdo.CurrentRow.Cells["tentd"].Value.ToString();
        }
        public void hienthi(string ma)
        {
            dgvtrinhdo.DataSource = Bus.timkiemtd(ma);
        }
        private void tsbtimkiem_Click(object sender, EventArgs e)
        {
            hienthi(" where matd like '%" + tstxttimkiem.Text + "'");
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

        private void tsbhome_Click(object sender, EventArgs e)
        {
            Trangchu tc = new Trangchu();
            tc.Show();
            this.Close();
        }

        private void tstxttimkiem_Click(object sender, EventArgs e)
        {
            tstxttimkiem.Text = string.Empty;
        }
    }
}
