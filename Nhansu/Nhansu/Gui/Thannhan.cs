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
    public partial class Thannhan : Form
    {
        public Thannhan()
        {
            InitializeComponent();
        }
        public SqlConnection getconnect()
        {
            return new SqlConnection( @"Data Source=ADMINS\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        }
        private void Thannhan_Load(object sender, EventArgs e)
        {
            SqlConnection conn = getconnect();
            string sql = "select * from nhanvien";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbmanv.DataSource = dt;
            cbbmanv.DisplayMember = "manv";
            cbbmanv.ValueMember = "tennv";
            dgvthannhan.DataSource = Bus.Getlistthannhan();
        }
       
        string[] dctt;
        private void dgvthannhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttentn.Text = dgvthannhan.CurrentRow.Cells["tentn"].Value.ToString();
            datengaysinh.Text = dgvthannhan.CurrentRow.Cells["ngaysinh"].Value.ToString();
            dctt = dgvthannhan.CurrentRow.Cells["diachi"].Value.ToString().Split(',');
            cbbtinhdc.Text = dctt[0];
            cbbhuyendc.Text =dctt[1];
            cbbxadc.Text = dctt[2];
            cbbmanv.Text = dgvthannhan.CurrentRow.Cells["manv"].Value.ToString();
            cbbquanhe.Text = dgvthannhan.CurrentRow.Cells["quanhe"].Value.ToString();
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            txttentn.Text = string.Empty;
            datengaysinh.Value = DateTime.Now;
            cbbtinhdc.Text = string.Empty;
            cbbhuyendc.Text = string.Empty;
            cbbxadc.Text = string.Empty;
            cbbmanv.Text = string.Empty;     
            cbbquanhe.Text = string.Empty;
        }

        private void tsbluu_Click(object sender, EventArgs e)
        {
            if (cbbmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            thannhan tn = new thannhan();
            tn.tentn = txttentn.Text;
            tn.ngaysinh = datengaysinh.Value;
            tn.diachi = cbbtinhdc.Text + "," + cbbhuyendc.Text + "," + cbbxadc.Text;
            tn.manv = cbbmanv.Text;
      
            tn.quanhe = cbbquanhe.Text;
            if (MessageBox.Show(string.Format("Thêm thân nhân"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(tn) > 0)
                {
                    MessageBox.Show("Đã Thêm");
                    Thannhan_Load(sender, e);
                }
                else MessageBox.Show("đã bị trùng");
            }
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            if (cbbmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            thannhan tn = new thannhan();
            tn.tentn = txttentn.Text;
            tn.ngaysinh = datengaysinh.Value;
            tn.diachi = cbbtinhdc.Text + "," + cbbhuyendc.Text + "," + cbbxadc.Text;
            tn.manv = cbbmanv.Text;
        
            tn.quanhe = cbbquanhe.Text;
            if (MessageBox.Show(string.Format("Xóa thân nhân"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(tn) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    Thannhan_Load(sender, e);
                }
                else MessageBox.Show("thông tin chưa được xóa");
            }
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
        public void hienthi(string ten)
        {
            dgvthannhan.DataSource = Bus.timkiemtn(ten);
        }
        private void tsbtimkiem_Click(object sender, EventArgs e)
        {
            hienthi(" where tentn like N'%" + tstxttimkiem.Text + "%'");
        }

        private void tstxttimkiem_Click(object sender, EventArgs e)
        {
            tstxttimkiem.Text = string.Empty;
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
            if (cbbhuyendc.SelectedIndex == 1)

           
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
    }
    }

