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
    public partial class Ungvien : Form
    {
        public Ungvien()
        {
            InitializeComponent();
        }
        public void commo()
        {
            cbbmatd.DisplayMember = "tentd";
            cbbmatd.ValueMember = "matd";
            cbbmatd.DataSource = Bus.Getlisttrinhdo();

        }
        private void Ungvien_Load(object sender, EventArgs e)
        {
            dgvungvien.DataSource = Bus.Getlistungvien();
            commo();
        }
        string[] ns;
        string[] nq;
        string[] dctt;
        private void dgvungvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmauv.Text = dgvungvien.CurrentRow.Cells["mauv"].Value.ToString();
            txttenuv.Text = dgvungvien.CurrentRow.Cells["tenuv"].Value.ToString();
            datengaysinh.Text = dgvungvien.CurrentRow.Cells["ngaysinh"].Value.ToString();
            ns = dgvungvien.CurrentRow.Cells["noisinh"].Value.ToString().Split(',');
            cbbtinhns.Text = ns[0];
            cbbhuyenns.Text = ns[1];
            cbbxans.Text = ns[2];
            nq = dgvungvien.CurrentRow.Cells["nguyenquan"].Value.ToString().Split(',');
            cbbtinhnq.Text = nq[0];
            cbbhuyennq.Text = nq[1];
            cbbxanq.Text = nq[2];
            dctt = dgvungvien.CurrentRow.Cells["diachitamtru"].Value.ToString().Split(',');
            cbbtinhdc.Text = dctt[0];
            cbbhuyendc.Text = dctt[1];
            cbbxadc.Text = dctt[2];           
            cbbgioitinh.Text = dgvungvien.CurrentRow.Cells["gioitinh"].Value.ToString();
            txtdantoc.Text = dgvungvien.CurrentRow.Cells["dantoc"].Value.ToString();
            txtsdt.Text = dgvungvien.CurrentRow.Cells["sodtuv"].Value.ToString();
            txtnguoilienhe.Text = dgvungvien.CurrentRow.Cells["nguoilienhe"].Value.ToString();
            txtquoctich.Text = dgvungvien.CurrentRow.Cells["quoctich"].Value.ToString();
            cbbngoaingu.Text = dgvungvien.CurrentRow.Cells["ngoaingu"].Value.ToString();
            txtsocmnd.Text = dgvungvien.CurrentRow.Cells["soCMND"].Value.ToString();
            txtsobhyt.Text = dgvungvien.CurrentRow.Cells["soBHYT"].Value.ToString();
            txtsobhxh.Text = dgvungvien.CurrentRow.Cells["soBHXH"].Value.ToString();
            cbbmatd.Text = dgvungvien.CurrentRow.Cells["matd"].Value.ToString();
        }

        private void tbs_add_Click(object sender, EventArgs e)
        {
            txtmauv.Text = string.Empty;
            txttenuv.Text = string.Empty;
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
            txtnguoilienhe.Text = string.Empty;
            txtquoctich.Text = string.Empty;
            cbbngoaingu.Text = string.Empty;
            txtsocmnd.Text = string.Empty;
            txtsobhyt.Text = string.Empty;
            txtsobhxh.Text = string.Empty;
            cbbmatd.Text = string.Empty;
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (txtmauv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            ungvien uv = new ungvien();
            uv.mauv = txtmauv.Text;
            uv.tenuv = txttenuv.Text;
            uv.ngaysinh = datengaysinh.Value;
            uv.noisinh = cbbtinhns.Text + "," + cbbhuyenns.Text + "," + cbbxans.Text;
            uv.nguyenquan = cbbtinhnq.Text + "," + cbbhuyennq.Text + "," + cbbxanq.Text;
            uv.diachitamtru = cbbtinhdc.Text + "," + cbbhuyendc.Text + "," + cbbxadc.Text;
            uv.gioitinh = cbbgioitinh.Text;
            uv.dantoc = txtdantoc.Text;
            uv.sodtuv = txtsdt.Text;
            uv.nguoilienhe = txtnguoilienhe.Text;
            uv.quoctich = txtquoctich.Text;
            uv.ngoaingu = cbbngoaingu.Text;
            uv.soCMND = txtsocmnd.Text;
            uv.soBHYT = txtsobhyt.Text;
            uv.soBHXH = txtsobhxh.Text;
            uv.matd = cbbmatd.SelectedValue.ToString();


            if (MessageBox.Show(string.Format("Sửa ứng viên"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(uv) > 0)
                {
                    MessageBox.Show("Đã sửa");
                    Ungvien_Load(sender, e);
                }
            
            else MessageBox.Show("Thông tin chưa được sửa");
        }
        }
        private void tbs_save_Click(object sender, EventArgs e)
        {
            if (txtmauv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            ungvien uv = new ungvien();
            uv.mauv = txtmauv.Text;
            uv.tenuv = txttenuv.Text;
            uv.ngaysinh = datengaysinh.Value;
            uv.noisinh = cbbtinhns.Text
                + "," + cbbhuyenns.Text + "," + cbbxans.Text;
            uv.nguyenquan = cbbtinhnq.Text
            + "," + cbbhuyennq.Text + "," + cbbxanq.Text;
            uv.diachitamtru = cbbtinhdc.Text
            + "," + cbbhuyendc.Text + "," + cbbxadc.Text;
            uv.gioitinh = cbbgioitinh.Text;
            uv.dantoc = txtdantoc.Text;
            uv.sodtuv = txtsdt.Text;
            uv.nguoilienhe = txtnguoilienhe.Text;
            uv.quoctich = txtquoctich.Text;
            uv.ngoaingu = cbbngoaingu.Text;
            uv.soCMND = txtsocmnd.Text;
            uv.soBHYT = txtsobhyt.Text;
            uv.soBHXH = txtsobhxh.Text;
            uv.matd = cbbmatd.SelectedValue.ToString();


            if (MessageBox.Show(string.Format("Thêm ứng viên"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(uv) > 0)
                {
                    MessageBox.Show("Đã Thêm");
                    Ungvien_Load(sender, e);
                }
                else MessageBox.Show("Đã bị trùng");
            }
        }
        

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (txtmauv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            ungvien uv = new ungvien();
            uv.mauv = txtmauv.Text;
            uv.tenuv = txttenuv.Text;
            uv.ngaysinh = datengaysinh.Value;
            uv.noisinh = cbbtinhns.Text + "," + cbbhuyenns.Text + "," + cbbxans.Text;
            uv.nguyenquan = cbbtinhnq.Text + "," + cbbhuyennq.Text + "," + cbbxanq.Text;
            uv.diachitamtru = cbbtinhdc.Text + "," + cbbhuyendc.Text + "," + cbbxadc.Text;
            uv.gioitinh = cbbgioitinh.Text;
            uv.dantoc = txtdantoc.Text;
            uv.sodtuv = txtsdt.Text;
            uv.nguoilienhe = txtnguoilienhe.Text;
            uv.quoctich = txtquoctich.Text;
            uv.ngoaingu = cbbngoaingu.Text;
            uv.soCMND = txtsocmnd.Text;
            uv.soBHYT = txtsobhyt.Text;
            uv.soBHXH = txtsobhxh.Text;
            uv.matd = cbbmatd.SelectedValue.ToString();


            if (MessageBox.Show(string.Format("Xóa ứng viên"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(uv) > 0)
                {
                    MessageBox.Show("Đã Xóa");
                    Ungvien_Load(sender, e);
                }

                else MessageBox.Show("Thông tin chưa được Xóa");
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
        public void hienthi(string ten)
        {
            dgvungvien.DataSource = Bus.timkiemuv(ten);
        }
        private void tbs_search_Click(object sender, EventArgs e)
        {
            hienthi(" where tenuv like N'%" + txttimkiem.Text + "%'");
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = string.Empty;
        }

        private void cbbtinhns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtinhns.SelectedIndex == 0)
            {
                cbbhuyenns.Items.Add("Trùng khánh");//0
                cbbhuyenns.Items.Add("Hà quảng");
                cbbhuyenns.Items.Add("Bảo lâm");//2
                cbbhuyenns.Items.Add("Hạ lang");
                cbbhuyenns.Items.Add("Hòa an");//4
                cbbhuyenns.Items.Add("Nguyên bình");
            }
            else if (cbbtinhns.SelectedIndex == 1)
            {
                cbbhuyenns.Items.Clear();
                cbbhuyenns.Items.Add("Phủ lý");//6
                cbbhuyenns.Items.Add("Bình lục");
                cbbhuyenns.Items.Add("Duy tiên");//8
                cbbhuyenns.Items.Add("Kim bảng");
                cbbhuyenns.Items.Add("Lý nhân");
                cbbhuyenns.Items.Add("Thanh liêm");//11
            }
            else if (cbbtinhns.SelectedIndex == 2)
            {
                cbbhuyenns.Items.Clear();
                cbbhuyenns.Items.Add("Hồng lĩnh");//12
                cbbhuyenns.Items.Add("Nghi Xuân");//13
                cbbhuyenns.Items.Add("Đức Thọ");//14
                cbbhuyenns.Items.Add("Hương sơn");//15
                cbbhuyenns.Items.Add("Hương khê");//16
                cbbhuyenns.Items.Add("Vũ Quang");
                cbbhuyenns.Items.Add("Can lộc");//18
                cbbhuyenns.Items.Add("Lộc hà");
                cbbhuyenns.Items.Add("Thạch hà");
                cbbhuyenns.Items.Add("Cẩm xuyên");//21
                cbbhuyenns.Items.Add("Kỳ anh");
            }
            else if (cbbtinhns.SelectedIndex == 3)
            {
                cbbhuyenns.Items.Clear();
                cbbhuyenns.Items.Add("Chí Linh");
                cbbhuyenns.Items.Add("Bình giang");
                cbbhuyenns.Items.Add("Cẩm giàng");//25
                cbbhuyenns.Items.Add("Gia lộc");
                cbbhuyenns.Items.Add("Kim thành");
                cbbhuyenns.Items.Add("Kinh môn");
                cbbhuyenns.Items.Add("Nam sách");
                cbbhuyenns.Items.Add("Ninh giang");//30
                cbbhuyenns.Items.Add("Thanh hà");//31
                cbbhuyenns.Items.Add("Thanh miện");
                cbbhuyenns.Items.Add("tứ kì");//33
            }
            else if (cbbtinhns.SelectedIndex == 4)
            {
                cbbhuyenns.Items.Add("Vinh");//34
                cbbhuyenns.Items.Add("Thanh chương");//35
                cbbhuyenns.Items.Add("Đô lương");//36
                cbbhuyenns.Items.Add("Anh sơn");//37
                cbbhuyenns.Items.Add("Nam đàn");//38
                cbbhuyenns.Items.Add("Nghĩa đàn");//39
                cbbhuyenns.Items.Add("Con cuông");//40
                cbbhuyenns.Items.Add("Tân kỳ");//41
                cbbhuyenns.Items.Add("Yên thành");//42
                cbbhuyenns.Items.Add("Tương dương");//43
            }
            else if (cbbtinhns.SelectedIndex == 5)
            {
                cbbhuyenns.Items.Clear();
                cbbhuyenns.Items.Add("Gia liễu");
                cbbhuyenns.Items.Add("Hoa lư");//45
                cbbhuyenns.Items.Add("KIm sơn");
                cbbhuyenns.Items.Add("Yên khánh");
                cbbhuyenns.Items.Add("Yên mô");
                cbbhuyenns.Items.Add("Kim sơn");//49
            }
            else if (cbbtinhns.SelectedIndex == 6)
            {
                cbbhuyenns.Items.Clear();
                cbbhuyenns.Items.Add("Đông hưng");//50
                cbbhuyenns.Items.Add("Hưng hà");//51
                cbbhuyenns.Items.Add("Kiến xương");//52
                cbbhuyenns.Items.Add("Thái thụy");
                cbbhuyenns.Items.Add("Tiền hải");//54
                cbbhuyenns.Items.Add("Vũ thư");
            }
            else if (cbbtinhns.SelectedIndex == 8)
            {
                cbbhuyenns.Items.Clear();
                cbbhuyenns.Items.Add("Phong điền");//56
                cbbhuyenns.Items.Add("Quảng điền");
                cbbhuyenns.Items.Add("Hương trà");//58
                cbbhuyenns.Items.Add("Phú vang");
                cbbhuyenns.Items.Add("HƯơng thủy");
                cbbhuyenns.Items.Add("Nam đông");//61
                cbbhuyenns.Items.Add("A lưới");
            }

            else if (cbbtinhns.SelectedIndex == 9)
            {
                cbbhuyenns.Items.Add("Hải châu");
                cbbhuyenns.Items.Add("Thanh khê");//64
                cbbhuyenns.Items.Add("Sơn trà");
                cbbhuyenns.Items.Add("Hương sơn");//66
                cbbhuyenns.Items.Add("Liên chiểu");
                cbbhuyenns.Items.Add("Cẩm lệ");//68
                cbbhuyenns.Items.Add("Hyện đảo hoàng sa");//69

            }
            else if (cbbtinhns.SelectedIndex == 11)
            {
                cbbhuyenns.Items.Add("Ba đình");//70
                cbbhuyenns.Items.Add("Hoàn kiếm");
                cbbhuyenns.Items.Add("Hai bà trưng");
                cbbhuyenns.Items.Add("Dốngđa");
                cbbhuyenns.Items.Add("Tây hồ");
                cbbhuyenns.Items.Add("Cầu giấy");//75
                cbbhuyenns.Items.Add("Thanh xuân");
                cbbhuyenns.Items.Add("Hoàng mai");
                cbbhuyenns.Items.Add("Long biên");
                cbbhuyenns.Items.Add("Bắc Từ liêm");//79
                cbbhuyenns.Items.Add("Thanh trì");
                cbbhuyenns.Items.Add("Gia lâm");//81
                cbbhuyenns.Items.Add("Đông anh");
                cbbhuyenns.Items.Add("Nam Từ liêm");
                cbbhuyenns.Items.Add("Huyện ba vì");
                cbbhuyenns.Items.Add("Huyện đông anh");
                cbbhuyenns.Items.Add("HUyện phúc thọ");
                cbbhuyenns.Items.Add("HUyện thạch thất");
                cbbhuyenns.Items.Add("Huyện chương");
            }
        }
        private void cbbhuyenns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbhuyenns.Text == "Thanh chương")
            { 
                cbbxans.Items.Clear();
            cbbxans.Items.Add("Thanh Lĩnh");
            cbbxans.Items.Add("Thanh đồng");
            cbbxans.Items.Add("Thanh văn");
            cbbxans.Items.Add("Thanh hưng");
            cbbxans.Items.Add("Thanh Khê");
            cbbxans.Items.Add("Thanh chi");
            cbbxans.Items.Add("Thanh Mai");
            cbbxans.Items.Add("Thanh Khai");
            cbbxans.Items.Add("Thanh Mỹ");
            cbbxans.Items.Add("Thanh Tường");
        }
            if (cbbhuyenns.Text=="Nghi Xuân")
            {
                cbbxans.Items.Clear();
                cbbxans.Items.Add("Xuân hải");
                cbbxans.Items.Add("Xuân Mĩ");
                cbbxans.Items.Add("Xuân Song");
                cbbxans.Items.Add("Xuân Hoa");
                cbbxans.Items.Add("Xuân Thành");
                cbbxans.Items.Add("Xuân Hội");
            }

            if (cbbhuyenns.Text == "Bắc Từ liêm")
            {
                cbbxans.Items.Clear();
                cbbxans.Items.Add("Ngõ 1,Phạm Văn Đồng");
                cbbxans.Items.Add("Ngõ 2,Phạm Văn Đồng");
                cbbxans.Items.Add("Ngõ 3 Phạm Văn Đồng");
                cbbxans.Items.Add("Ngõ 4,Phạm Văn Đồng");
                cbbxans.Items.Add("Ngõ 5,Phạm Văn Đồng");
                cbbxans.Items.Add("Ngõ 6,Phạm Văn Đồng");
                cbbxans.Items.Add("Ngõ 7,Phạm Văn Đồng");
                cbbxans.Items.Add("Ngõ 1,Trần cung");

            }
        }

        private void cbbtinhnq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtinhnq.SelectedIndex==0 )
            {
                cbbhuyennq.Items.Clear();
                cbbhuyennq.Items.Add("Trùng khánh");//1
                cbbhuyennq.Items.Add("Hà quảng");
                cbbhuyennq.Items.Add("Bảo lâm");//3
                cbbhuyennq.Items.Add("Hạ lang");
                cbbhuyennq.Items.Add("Hòa an");//5
                cbbhuyennq.Items.Add("Nguyên bình");
            }
            else if (cbbtinhnq.SelectedIndex == 1)
            {
                cbbhuyennq.Items.Clear();
                cbbhuyennq.Items.Add("Phủ lý");//7
                cbbhuyennq.Items.Add("Bình lục");
                cbbhuyennq.Items.Add("Duy tiên");//9
                cbbhuyennq.Items.Add("Kim bảng");
                cbbhuyennq.Items.Add("Lý nhân");
                cbbhuyennq.Items.Add("Thanh liêm");//12
            }
            else if (cbbtinhnq.SelectedIndex == 2)
            {
                cbbhuyennq.Items.Clear();
                cbbhuyennq.Items.Add("Hồng lĩnh");//13
                cbbhuyennq.Items.Add("Nghi Xuân");//14
                cbbhuyennq.Items.Add("Đức Thọ");//15
                cbbhuyennq.Items.Add("Hương sơn");//16
                cbbhuyennq.Items.Add("Hương khê");//17
                cbbhuyennq.Items.Add("Vũ Quang");
                cbbhuyennq.Items.Add("Can lộc");//19
                cbbhuyennq.Items.Add("Lộc hà");
                cbbhuyennq.Items.Add("Thạch hà");
                cbbhuyennq.Items.Add("Cẩm xuyên");//22
                cbbhuyennq.Items.Add("Kỳ anh");
            }
            else if (cbbtinhnq.SelectedIndex == 3)
            {
                cbbhuyennq.Items.Clear();
                cbbhuyennq.Items.Add("Chí Linh");
                cbbhuyennq.Items.Add("Bình giang");
                cbbhuyennq.Items.Add("Cẩm giàng");//26
                cbbhuyennq.Items.Add("Gia lộc");
                cbbhuyennq.Items.Add("Kim thành");
                cbbhuyennq.Items.Add("Kinh môn");
                cbbhuyennq.Items.Add("Nam sách");
                cbbhuyennq.Items.Add("Ninh giang");//31
                cbbhuyennq.Items.Add("Thanh hà");//32
                cbbhuyennq.Items.Add("Thanh miện");
                cbbhuyennq.Items.Add("tứ kì");//34
            }
            else if (cbbtinhnq.SelectedIndex == 4)
            {
                cbbhuyennq.Items.Clear();
                cbbhuyennq.Items.Add("Vinh");//35
                cbbhuyennq.Items.Add("Thanh chương");//36
                cbbhuyennq.Items.Add("Đô lương");//37
                cbbhuyennq.Items.Add("Anh sơn");//38
                cbbhuyennq.Items.Add("Nam đàn");//39
                cbbhuyennq.Items.Add("Nghĩa đàn");//40
                cbbhuyennq.Items.Add("Con cuông");//41
                cbbhuyennq.Items.Add("Tân kỳ");//42
                cbbhuyennq.Items.Add("Yên thành");//43
                cbbhuyennq.Items.Add("Tương dương");//44
            }
            else if (cbbtinhnq.SelectedIndex == 5)
            {
                cbbhuyennq.Items.Clear();
                cbbhuyennq.Items.Add("Gia liễu");
                cbbhuyennq.Items.Add("Hoa lư");//46
                cbbhuyennq.Items.Add("KIm sơn");
                cbbhuyennq.Items.Add("Yên khánh");
                cbbhuyennq.Items.Add("Yên mô");
                cbbhuyennq.Items.Add("Kim sơn");//50
            }
            else if (cbbtinhnq.SelectedIndex == 6)
            {
                cbbhuyennq.Items.Clear();
                cbbhuyennq.Items.Add("Đông hưng");//51
                cbbhuyennq.Items.Add("Hưng hà");//52
                cbbhuyennq.Items.Add("Kiến xương");//53
                cbbhuyennq.Items.Add("Thái thụy");
                cbbhuyennq.Items.Add("Tiền hải");//55
                cbbhuyennq.Items.Add("Vũ thư");
            }
            else if (cbbtinhnq.SelectedIndex == 8)
            {
                cbbhuyennq.Items.Clear();
                cbbhuyennq.Items.Add("Phong điền");//57
                cbbhuyennq.Items.Add("Quảng điền");
                cbbhuyennq.Items.Add("Hương trà");//59
                cbbhuyennq.Items.Add("Phú vang");
                cbbhuyennq.Items.Add("HƯơng thủy");
                cbbhuyennq.Items.Add("Nam đông");//62
                cbbhuyennq.Items.Add("A lưới");
            }

            else if (cbbtinhnq.SelectedIndex == 9)
            {
                cbbhuyennq.Items.Clear();
                cbbhuyennq.Items.Add("Hải châu");
                cbbhuyennq.Items.Add("Thanh khê");//65
                cbbhuyennq.Items.Add("Sơn trà");
                cbbhuyennq.Items.Add("Hương sơn");//67
                cbbhuyennq.Items.Add("Liên chiểu");
                cbbhuyennq.Items.Add("Cẩm lệ");//69
                cbbhuyennq.Items.Add("Hyện đảo hoàng sa");//70

            }
            else if (cbbtinhnq.SelectedIndex == 11)
            {
                cbbhuyennq.Items.Clear();
                cbbhuyennq.Items.Add("Ba đình");//71
                cbbhuyennq.Items.Add("Hoàn kiếm");
                cbbhuyennq.Items.Add("Hai bà trưng");
                cbbhuyennq.Items.Add("Dốngđa");
                cbbhuyennq.Items.Add("Tây hồ");
                cbbhuyennq.Items.Add("Cầu giấy");//76
                cbbhuyennq.Items.Add("Thanh xuân");
                cbbhuyennq.Items.Add("Hoàng mai");
                cbbhuyennq.Items.Add("Long biên");
                cbbhuyennq.Items.Add("Bắc Từ liêm");//80
                cbbhuyennq.Items.Add("Thanh trì");
                cbbhuyennq.Items.Add("Gia lâm");//82
                cbbhuyennq.Items.Add("Đông anh");
                cbbhuyennq.Items.Add("Nam Từ liêm");
                cbbhuyennq.Items.Add("Huyện ba vì");
                cbbhuyennq.Items.Add("Huyện đông anh");
                cbbhuyennq.Items.Add("HUyện phúc thọ");
                cbbhuyennq.Items.Add("HUyện thạch thất");
                cbbhuyennq.Items.Add("Huyện chương");
            }
        
    }

        private void cbbhuyennq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbhuyennq.Text == "Thanh chương")


            {
                cbbxanq.Items.Clear();
                cbbxanq.Items.Add("Thanh Lĩnh");
                cbbxanq.Items.Add("Thanh đồng");
                cbbxanq.Items.Add("Thanh văn");
                cbbxanq.Items.Add("Thanh hưng");
                cbbxanq.Items.Add("Thanh Khê");
                cbbxanq.Items.Add("Thanh chi");
                cbbxanq.Items.Add("Thanh Mai");
                cbbxanq.Items.Add("Thanh Khai");
                cbbxanq.Items.Add("Thanh Mỹ");
                cbbxanq.Items.Add("Thanh Tường");
            }

            if (cbbhuyennq.Text=="Bắc Từ liêm")
            {
                cbbxanq.Items.Clear();
                cbbxanq.Items.Add("Ngõ 1 Phạm Văn Đồng");
                cbbxanq.Items.Add("Ngõ 2 Phạm Văn Đồng");
                cbbxanq.Items.Add("Ngõ 3 Phạm Văn Đồng");
                cbbxanq.Items.Add("Ngõ 4 Phạm Văn Đồng");
                cbbxanq.Items.Add("Ngõ 5 Phạm Văn Đồng");
                cbbxanq.Items.Add("Ngõ 6 Phạm Văn Đồng");
                cbbxanq.Items.Add("Ngõ 7 Phạm Văn Đồng");
                cbbxanq.Items.Add("Ngõ 1 Trần cung");

            }
           
            if (cbbhuyennq.Text == "Nghi Xuân")
            {
                cbbxanq.Items.Clear();
                cbbxanq.Items.Add("Xuân hải");
                cbbxanq.Items.Add("Xuân Mĩ");
                cbbxanq.Items.Add("Xuân Song");
                cbbxanq.Items.Add("Xuân Hoa");
                cbbxanq.Items.Add("Xuân Thành");
                cbbxanq.Items.Add("Xuân Hội");
            }

          
        }

        private void cbbtinhdc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtinhdc.SelectedIndex == 0)
            {
                cbbhuyendc.Items.Add("Trùng khánh");//1
                cbbhuyendc.Items.Add("Hà quảng");
                cbbhuyendc.Items.Add("Bảo lâm");//3
                cbbhuyendc.Items.Add("Hạ lang");
                cbbhuyendc.Items.Add("Hòa an");//5
                cbbhuyendc.Items.Add("Nguyên bình");
            }

            else if (cbbtinhdc.SelectedIndex == 1)
            {
                cbbhuyendc.Items.Clear();
                cbbhuyendc.Items.Add("Phủ lý");//7
                cbbhuyendc.Items.Add("Bình lục");
                cbbhuyendc.Items.Add("Duy tiên");//9
                cbbhuyendc.Items.Add("Kim bảng");
                cbbhuyendc.Items.Add("Lý nhân");
                cbbhuyendc.Items.Add("Thanh liêm");//12
            }
            else if (cbbtinhdc.SelectedIndex == 2)
            {
                cbbhuyendc.Items.Clear();
                cbbhuyendc.Items.Add("Hồng lĩnh");//13
                cbbhuyendc.Items.Add("Nghi Xuân");//14
                cbbhuyendc.Items.Add("Đức Thọ");//15
                cbbhuyendc.Items.Add("Hương sơn");//16
                cbbhuyendc.Items.Add("Hương khê");//17
                cbbhuyendc.Items.Add("Vũ Quang");
                cbbhuyendc.Items.Add("Can lộc");//19
                cbbhuyendc.Items.Add("Lộc hà");
                cbbhuyendc.Items.Add("Thạch hà");
                cbbhuyendc.Items.Add("Cẩm xuyên");//22
                cbbhuyendc.Items.Add("Kỳ anh");
            }
            else if (cbbtinhdc.SelectedIndex == 3)
            {
                cbbhuyendc.Items.Clear();
                cbbhuyendc.Items.Add("Chí Linh");
                cbbhuyendc.Items.Add("Bình giang");
                cbbhuyendc.Items.Add("Cẩm giàng");//26
                cbbhuyendc.Items.Add("Gia lộc");
                cbbhuyendc.Items.Add("Kim thành");
                cbbhuyendc.Items.Add("Kinh môn");
                cbbhuyendc.Items.Add("Nam sách");
                cbbhuyendc.Items.Add("Ninh giang");//31
                cbbhuyendc.Items.Add("Thanh hà");//32
                cbbhuyendc.Items.Add("Thanh miện");
                cbbhuyendc.Items.Add("tứ kì");//34
            }
            else if (cbbtinhdc.SelectedIndex == 4)
            {
                cbbhuyendc.Items.Clear();
                cbbhuyendc.Items.Add("Vinh");//35
                cbbhuyendc.Items.Add("Thanh chương");//36
                cbbhuyendc.Items.Add("Đô lương");//37
                cbbhuyendc.Items.Add("Anh sơn");//38
                cbbhuyendc.Items.Add("Nam đàn");//39
                cbbhuyendc.Items.Add("Nghĩa đàn");//40
                cbbhuyendc.Items.Add("Con cuông");//41
                cbbhuyendc.Items.Add("Tân kỳ");//42
                cbbhuyendc.Items.Add("Yên thành");//43
                cbbhuyendc.Items.Add("Tương dương");//44
            }
            else if (cbbtinhdc.SelectedIndex == 5)
            {
                cbbhuyendc.Items.Clear();
                cbbhuyendc.Items.Add("Gia liễu");
                cbbhuyendc.Items.Add("Hoa lư");//46
                cbbhuyendc.Items.Add("KIm sơn");
                cbbhuyendc.Items.Add("Yên khánh");
                cbbhuyendc.Items.Add("Yên mô");
                cbbhuyendc.Items.Add("Kim sơn");//50
            }
            else if (cbbtinhdc.SelectedIndex == 6)
            {
                cbbhuyendc.Items.Clear();
                cbbhuyendc.Items.Add("Đông hưng");//51
                cbbhuyendc.Items.Add("Hưng hà");//52
                cbbhuyendc.Items.Add("Kiến xương");//53
                cbbhuyendc.Items.Add("Thái thụy");
                cbbhuyendc.Items.Add("Tiền hải");//55
                cbbhuyendc.Items.Add("Vũ thư");
            }
            else if (cbbtinhdc.SelectedIndex == 8)
            {
                cbbhuyendc.Items.Clear();
                cbbhuyendc.Items.Add("Phong điền");//57
                cbbhuyendc.Items.Add("Quảng điền");
                cbbhuyendc.Items.Add("Hương trà");//59
                cbbhuyendc.Items.Add("Phú vang");
                cbbhuyendc.Items.Add("HƯơng thủy");
                cbbhuyendc.Items.Add("Nam đông");//62
                cbbhuyendc.Items.Add("A lưới");
            }

            else if (cbbtinhdc.SelectedIndex == 9)
            {
                cbbhuyendc.Items.Clear();
                cbbhuyendc.Items.Add("Hải châu");
                cbbhuyendc.Items.Add("Thanh khê");//65
                cbbhuyendc.Items.Add("Sơn trà");
                cbbhuyendc.Items.Add("Hương sơn");//67
                cbbhuyendc.Items.Add("Liên chiểu");
                cbbhuyendc.Items.Add("Cẩm lệ");//69
                cbbhuyendc.Items.Add("Hyện đảo hoàng sa");//70

            }
            else if (cbbtinhdc.SelectedIndex == 11)
            {
                cbbhuyendc.Items.Clear();
                cbbhuyendc.Items.Add("Ba đình");//71
                cbbhuyendc.Items.Add("Hoàn kiếm");
                cbbhuyendc.Items.Add("Hai bà trưng");
                cbbhuyendc.Items.Add("Dốngđa");
                cbbhuyendc.Items.Add("Tây hồ");
                cbbhuyendc.Items.Add("Cầu giấy");//76
                cbbhuyendc.Items.Add("Thanh xuân");
                cbbhuyendc.Items.Add("Hoàng mai");
                cbbhuyendc.Items.Add("Long biên");
                cbbhuyendc.Items.Add("Bắc Từ liêm");//80
                cbbhuyendc.Items.Add("Thanh trì");
                cbbhuyendc.Items.Add("Gia lâm");//82
                cbbhuyendc.Items.Add("Đông anh");
                cbbhuyendc.Items.Add("Nam Từ liêm");
                cbbhuyendc.Items.Add("Huyện ba vì");
                cbbhuyendc.Items.Add("Huyện đông anh");
                cbbhuyendc.Items.Add("HUyện phúc thọ");
                cbbhuyendc.Items.Add("HUyện thạch thất");
                cbbhuyendc.Items.Add("Huyện chương");
            }
        
    }

        private void cbbhuyendc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbhuyendc.Text=="Thanh chương")
            {
                cbbxadc.Items.Clear();
                cbbxadc.Items.Add("Thanh Lĩnh");
                cbbxadc.Items.Add("Thanh đồng");
                cbbxadc.Items.Add("Thanh văn");
                cbbxadc.Items.Add("Thanh hưng");
                cbbxadc.Items.Add("Thanh Khê");
                cbbxadc.Items.Add("Thanh chi");
                cbbxadc.Items.Add("Thanh Mai");
                cbbxadc.Items.Add("Thanh Khai");
                cbbxadc.Items.Add("Thanh Mỹ");
                cbbxadc.Items.Add("Thanh Tường");
            }

            if (cbbhuyendc.Text == "Bắc Từ liêm")
            {
                cbbxadc.Items.Clear();
                cbbxadc.Items.Add("Ngõ 1 Phạm Văn Đồng");
                cbbxadc.Items.Add("Ngõ 2 Phạm Văn Đồng");
                cbbxadc.Items.Add("Ngõ 3 Phạm Văn Đồng");
                cbbxadc.Items.Add("Ngõ 4 Phạm Văn Đồng");
                cbbxadc.Items.Add("Ngõ 5 Phạm Văn Đồng");
                cbbxadc.Items.Add("Ngõ 6 Phạm Văn Đồng");
                cbbxadc.Items.Add("Ngõ 7 Phạm Văn Đồng");
                cbbxadc.Items.Add("Ngõ 1 Trần cung");

            }

            if (cbbhuyendc.Text == "Nghi Xuân")
            {
                cbbxadc.Items.Clear();
                cbbxadc.Items.Add("Xuân hải");
                cbbxadc.Items.Add("Xuân Mĩ");
                cbbxadc.Items.Add("Xuân Song");
                cbbxadc.Items.Add("Xuân Hoa");
                cbbxadc.Items.Add("Xuân Thành");
                cbbxadc.Items.Add("Xuân Hội");
            }
        }
    }
   
}
