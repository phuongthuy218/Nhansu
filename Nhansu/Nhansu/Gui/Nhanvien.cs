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
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }
        public void comboboxxx()
        {
            cbbmacvu.DisplayMember = "tencv";
            cbbmacvu.ValueMember = "macv";
            cbbmacvu.DataSource = Bus.Getlistchucvu();
            cbbmapb.DisplayMember = "tenpb";
            cbbmapb.ValueMember = "mapb";
            cbbmapb.DataSource = Bus.Getlistphongban();         
            cbbmauv.DisplayMember = "mauv";
            cbbmauv.ValueMember = "tenuv";
            cbbmauv.DataSource = Bus.Getlistungvien();
            

        }
        private void Nhanvien_Load(object sender, EventArgs e)
        {
            dgvnhanvien.DataSource = Bus.Getlistnhanvien();
            comboboxxx();
        }
        string [] ns;
        string[] nq;
        string[] dctt;
        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dgvnhanvien.CurrentRow.Cells["manv"].Value.ToString();
            txttennv.Text = dgvnhanvien.CurrentRow.Cells["tennv"].Value.ToString();
            cbbmapb.Text = dgvnhanvien.CurrentRow.Cells["mapb"].Value.ToString();
            cbbmacvu.Text = dgvnhanvien.CurrentRow.Cells["macv"].Value.ToString();
            ns= dgvnhanvien.CurrentRow.Cells["noisinh"].Value.ToString().Split(',');
            cbbtinhns.Text = ns[0];
            cbbhuyenns.Text = ns[1];
            cbbxans.Text = ns[2];
            nq = dgvnhanvien.CurrentRow.Cells["nguyenquan"].Value.ToString().Split(',');
            cbbtinhnq.Text = nq[0];
            cbbhuyennq.Text = nq[1];
            cbbxanq.Text = nq[2];
            dctt = dgvnhanvien.CurrentRow.Cells["diachitamtru"].Value.ToString().Split(',');
            cbbtinhdc.Text = dctt[0];
            cbbhuyendc.Text = dctt[1];
            cbbxadc.Text = dctt[2];
            datengaysinh.Text = dgvnhanvien.CurrentRow.Cells["ngaysinh"].Value.ToString();
            cbbgioitinh.Text = dgvnhanvien.CurrentRow.Cells["gioitinh"].Value.ToString();
            txtsdt.Text = dgvnhanvien.CurrentRow.Cells["sodtnv"].Value.ToString();
            txtnguoiliehe.Text = dgvnhanvien.CurrentRow.Cells["nguoilienhe"].Value.ToString();
            txtquoctich.Text = dgvnhanvien.CurrentRow.Cells["quoctich"].Value.ToString();
            cbbngoaingu.Text = dgvnhanvien.CurrentRow.Cells["ngoaingu"].Value.ToString();
            datengayvaolam.Text = dgvnhanvien.CurrentRow.Cells["ngayvaolam"].Value.ToString();
            txtsocmnd.Text = dgvnhanvien.CurrentRow.Cells["soCMND"].Value.ToString();
            txtsobhyt.Text = dgvnhanvien.CurrentRow.Cells["soBHYT"].Value.ToString();
            txtsobhxh.Text = dgvnhanvien.CurrentRow.Cells["soBHXH"].Value.ToString();
            txtmatd.Text = dgvnhanvien.CurrentRow.Cells["matd"].Value.ToString();
        }

        private void tbs_add_Click(object sender, EventArgs e)
        {
            txtmanv.Text = string.Empty;
            txttennv.Text = string.Empty;
            cbbmapb.Text = string.Empty;
            cbbmacvu.Text = string.Empty;
            datengaysinh.Value = DateTime.Now;
            cbbtinhns.Text = string.Empty;
            cbbhuyenns.Text = string.Empty;
            cbbxans.Text = string.Empty;
            cbbtinhnq.Text = string.Empty;
            cbbhuyennq.Text = string.Empty;
            cbbxanq.Text = string.Empty;
            cbbtinhdc.Text = string.Empty;
            cbbhuyendc.Text = string.Empty;
            cbbxadc.Text = string.Empty;
            cbbgioitinh.Text = string.Empty;
            txtdantoc.Text = string.Empty;
            txtsdt.Text = string.Empty;
            txtnguoiliehe.Text = string.Empty;
            cbbngoaingu.Text = string.Empty;
            datengayvaolam.Value = DateTime.Now;
            txtsocmnd.Text = string.Empty;
            txtsobhyt.Text = string.Empty;
            txtsobhxh.Text = string.Empty;
            txtmatd.Text = string.Empty;
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            nhanvien nv = new nhanvien();
            nv.manv = txtmanv.Text;
            nv.tennv = txttennv.Text;
            nv.mapb = cbbmapb.SelectedValue.ToString();
            nv.macv = cbbmacvu.SelectedValue.ToString();
            nv.ngaysinh = datengaysinh.Value;
            nv.noisinh = cbbtinhns.Text + "," + cbbhuyenns.Text + "," + cbbxans.Text;
            nv.nguyenquan = cbbtinhnq.Text + "," + cbbhuyennq.Text + "," + cbbxanq.Text;
            nv.diachitamtru = cbbtinhdc.Text + "," + cbbhuyendc.Text + "," + cbbxadc.Text;
            nv.gioitinh = cbbgioitinh.Text;
            nv.dantoc = txtdantoc.Text;
            nv.sodtnv = txtsdt.Text;
            nv.nguoilienhe = txtnguoiliehe.Text;
            nv.quoctich = txtquoctich.Text;
            nv.ngoaingu = cbbngoaingu.Text;
            nv.ngayvaolam = datengayvaolam.Value;
            nv.soCMND = txtsocmnd.Text;
            nv.soBHYT = txtsobhyt.Text;
            nv.soBHXH = txtsobhxh.Text;
            nv.matd = txtmatd.Text;


            if (MessageBox.Show(string.Format("Sửa nhân viên"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(nv) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    Nhanvien_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }
        ungvien uv = new ungvien();
        private void tbs_save_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            nhanvien nv = new nhanvien();
            nv.manv = txtmanv.Text;
            nv.mapb = cbbmapb.SelectedValue.ToString();
            nv.macv = cbbmacvu.SelectedValue.ToString();
            nv.ngayvaolam = datengayvaolam.Value;           
            uv.mauv = cbbmauv.Text;

            if (MessageBox.Show(string.Format("Thêm nhân viên"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(nv,uv) > 0)
                {
                    MessageBox.Show("Đã Thêm thành công!Mời bạn chuyển đến để thêm hợp đồng cho nhân viên này:))");
                    Nhanvien_Load(sender, e);

                    Hopdong hd = new Hopdong();
                    hd.Show();
                }
                else MessageBox.Show("Mã nhân viên đã tồn tại");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            nhanvien nv = new nhanvien();
            nv.manv = txtmanv.Text;
            nv.tennv = txttennv.Text;
            nv.mapb = cbbmapb.SelectedValue.ToString();
            nv.macv = cbbmacvu.SelectedValue.ToString();
            nv.ngaysinh = datengaysinh.Value;
            nv.noisinh = cbbtinhns.Text + "," + cbbhuyenns.Text + "," + cbbxans.Text;
            nv.nguyenquan = cbbtinhnq.Text + "," + cbbhuyennq.Text + "," + cbbxanq.Text;
            nv.diachitamtru = cbbtinhdc.Text + "," + cbbhuyendc.Text + "," + cbbxadc.Text;
            nv.gioitinh = cbbgioitinh.Text;
            nv.dantoc = txtdantoc.Text;
            nv.sodtnv = txtsdt.Text;
            nv.nguoilienhe = txtnguoiliehe.Text;
            nv.quoctich = txtquoctich.Text;
            nv.ngoaingu = cbbngoaingu.Text;
            nv.ngayvaolam = datengayvaolam.Value;
            nv.soCMND = txtsocmnd.Text;
            nv.soBHYT = txtsobhyt.Text;
            nv.soBHXH = txtsobhxh.Text;
            nv.matd = txtmatd.Text;


            if (MessageBox.Show(string.Format("Xóa nhân viên"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(nv) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    Nhanvien_Load(sender, e);
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
            Trangchu tc = new Trangchu();
            tc.Show();
            this.Hide();
           
        }
        public void hienthi(string ten)
        {
            dgvnhanvien.DataSource = Bus.timkiemnv(ten);
        }
        private void tbs_search_Click(object sender, EventArgs e)
        {
            hienthi(" where tennv like N'%" + tstxttimkiem.Text + "%'");
        }

       
        private void cbbtinhns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbtinhns.SelectedIndex ==0)
            {
                cbbhuyenns.Items.Add("Thanh chương");
                cbbhuyenns.Items.Add("Đô  lương");
            }
            else
            {
                cbbhuyenns.Items.Clear();
                cbbhuyenns.Items.Add("Cầu giấy");
            }
        }

        private void cbbhuyenns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbhuyenns.SelectedIndex ==0)
            {
                cbbxans.Items.Add("Thg");
                cbbxans.Items.Add("Đôg");
            }
            else
            {
                cbbxans.Items.Clear();
                cbbxans.Items.Add("Cầu giy");
            }
        }

        //private void tstxttimkiem_Click(object sender, EventArgs e)
        //{
        //    tstxttimkiem.Text = string.Empty;
        //}

        private void cbbtinhnq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtinhns.SelectedIndex == 0)
            {
                cbbhuyenns.Items.Add("Thanh chương");
                cbbhuyenns.Items.Add("Đô  lương");
            }
            else
            {
                cbbhuyenns.Items.Clear();
                cbbhuyenns.Items.Add("Cầu giấy");
            }
        }

        private void cbbhuyennq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbhuyenns.SelectedIndex == 0)
            {
                cbbxans.Items.Add("Thg");
                cbbxans.Items.Add("Đôg");
            }
            else
            {
                cbbxans.Items.Clear();
                cbbxans.Items.Add("Cầu giy");
            }
        }

        private void cbbtinhdc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtinhns.SelectedIndex == 0)
            {
                cbbhuyenns.Items.Add("Thanh chương");
                cbbhuyenns.Items.Add("Đô  lương");
            }
            else
            {
                cbbhuyenns.Items.Clear();
                cbbhuyenns.Items.Add("Cầu giấy");
            }
        }

        private void cbbhuyendc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbhuyenns.SelectedIndex == 0)
            {
                cbbxans.Items.Add("Thg");
                cbbxans.Items.Add("Đôg");
            }
            else
            {
                cbbxans.Items.Clear();
                cbbxans.Items.Add("Cầu giy");
            }
        }
        
        
        public void comboopb ()
        {
            cbbmapb.DisplayMember = "tenpb";
            cbbmapb.ValueMember = "mapb";
            cbbmapb.DataSource = Bus.Getlistphongban();
        }
        public void combocv()
        {
            cbbmacvu.DisplayMember = "tencv";
            cbbmacvu.ValueMember = "macv";
            cbbmacvu.DataSource = Bus.Getlistchucvu();
        }
        private void txtmauv_TextChanged(object sender, EventArgs e)
        {

        }
        public void hienthipb(string mapb)
        {
            comboopb();
            dgvnhanvien.DataSource = Bus.timkiemtheopb(mapb);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            hienthipb(" where mapb like N'%" + cbbmapb.SelectedValue.ToString()+ "%'");
        }
        public void hienthicv(string macv)
        {
            combocv();
            dgvnhanvien.DataSource = Bus.timkiemtheocv(macv);
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            hienthicv(" where macv like N'%" + cbbmacvu.SelectedValue.ToString() + "%'");
        }
    }

       
    }
    

