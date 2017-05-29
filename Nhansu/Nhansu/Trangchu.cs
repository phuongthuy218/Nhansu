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
using Nhansu.Gui;
using Nhansu.ValueOjbect;

namespace Nhansu
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void mãTrìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trinhdo td = new Trinhdo();
            td.Show();
            this.Hide();
        }

        private void phòngBanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Phongban pb = new Phongban();
            pb.Show();
            this.Hide();
        }

        //private void ứngViênToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Ungvien uv = new Ungvien();
        //    uv.Show();
        //    this.Hide();
        //}

        private void đàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daotao dt = new Daotao();
            dt.Show();
            this.Hide();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luong l = new Luong();
            l.Show();
            this.Hide();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chucvu cv = new Chucvu();
            cv.Show();
            this.Hide();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.Show();
            this.Hide();
        }

        private void thânNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thannhan tn = new Thannhan();
            tn.Show();
            this.Hide();
        }

        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khenthuong kt = new Khenthuong();
            kt.Show();
            this.Hide();
        }

        private void kỷLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kyluat kl = new Kyluat();
            kl.Show();
            this.Hide();
        }

        //private void nhânViênĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            
        //}

        private void điềuChuyểnCôngTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dieuchuyencongtac dc = new Dieuchuyencongtac();
            dc.Show();
            this.Hide();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hopdong hd = new Hopdong();
            hd.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quanlynghiepvu_Click(object sender, EventArgs e)
        {

        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlynguoidung qlnd = new Quanlynguoidung();
            qlnd.Show();
            this.Hide();
        }

        private void ứngViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ungvien uv = new Ungvien();
            uv.Show();
            this.Hide();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            huongdan hd = new huongdan();
            hd.Show();
            this.Hide();
        }
    }
}
