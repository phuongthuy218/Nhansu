using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhansu.Gui
{
    public partial class huongdan : Form
    {
        public huongdan()
        {
            InitializeComponent();
        }

        private void huongdan_Load(object sender, EventArgs e)
        {
            //txthuongdan.Text = "Phần mềm quản lý nhân sự là phần mềm dùng để quản lý nhân viên trong công ty\n\nHướng dẫn sử dụng\n\n1.Đăng nhập\n\n- Nhập tên và mật khẩu của người người cần đăng nhập\n\n- Đăng nhập thành công và sử dụng\n\n2.Quản lý thông tin nhân viên\n\n- Thêm,sửa ,xóa thông tin nhân viên\n\n- Xem thông tin thân nhân của nhân viên\n\n- Xem thông tin về khen thưởng kỷ luật của nhân viên\n\n- Thêm,sửa,xóa thông tin điều chuyển công tác\n\n-Then sửa xóa ứng viên vào công ty\n\n3.Quản lý nghiệp vụ\n\n- Xem,thêm sửa xóa các phòng ban trong công tyy\n\n- Xem trình độ học vấn phổ biến trong công ty\n\n- Xem,thêm đào tạo trong công ty\n\n4.Quản lý lương\n\n- Xem bậc lương của nhân viên có\n\n5.Quản lý hợp đồng lao động\n\n- Thêm,Sửa,xóa hợp đồng của nhân viên trong công ty\n\n6.Quản lý người dùng\n\n-Thêm sửa xóa ngừi dùng đăng nhập công ty";
        }

        private void tsbhome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn về trang chủ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
            Trangchu tc = new Trangchu();
            tc.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
            Trangchu tc = new Trangchu();
            tc.Show();
            this.Hide();
        }
    }
}
