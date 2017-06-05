namespace Nhansu.Gui
{
    partial class huongdan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(huongdan));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbhome = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lsbhuongdan = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbhome,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(116, 7);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(182, 36);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbhome
            // 
            this.tsbhome.Image = ((System.Drawing.Image)(resources.GetObject("tsbhome.Image")));
            this.tsbhome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbhome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbhome.Name = "tsbhome";
            this.tsbhome.Size = new System.Drawing.Size(95, 33);
            this.tsbhome.Text = "Home";
            this.tsbhome.Click += new System.EventHandler(this.tsbhome_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Nhansu.Properties.Resources.tao_icon_shutdown_hoac_restart_ngoai_desktop_1;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(75, 33);
            this.toolStripButton1.Text = "Exit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lsbhuongdan
            // 
            this.lsbhuongdan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsbhuongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbhuongdan.ForeColor = System.Drawing.Color.Black;
            this.lsbhuongdan.FormattingEnabled = true;
            this.lsbhuongdan.ItemHeight = 20;
            this.lsbhuongdan.Items.AddRange(new object[] {
            "     Phần mềm quản lý nhân sự là phần mềm dùng để",
            " quản lý nhân viên trong công ty",
            "                       Hướng dẫn sử dụng phần mềm",
            "        1.Đăng nhập",
            "-Nhập tên và mật khẩu của người người cần đăng nhập",
            "-Đăng nhập thành công và sử dụng",
            "        2.Quản lý thông tin nhân viên",
            "-Thêm,sửa ,xóa thông tin nhân viên",
            "-Xem thông tin thân nhân của nhân viên",
            "-Xem thông tin về khen thưởng kỷ luật của nhân viên",
            "-Thêm,sửa,xóa thông tin điều chuyển công tác",
            "         3.Quản lý nghiệp vụ",
            "-thêm các loại đào tạo",
            "-Xem trình độ học vấn phổ biến trong công ty",
            "-Xem ",
            "         4.Quản lý lương",
            "-Xem Lương nhân viên",
            "-Xem chức vụ nhân viên",
            "-Thêm sửa xóa phòng ban công ty",
            "         5.Quản lý hợp đồng lao động",
            "-Thêm,Sửa,xóa hợp đồng của nhân viên trong công ty",
            "         6.Quản lý người dùng",
            "-Thêm sửa xóa người dùng đăng nhập vào công ty"});
            this.lsbhuongdan.Location = new System.Drawing.Point(38, 63);
            this.lsbhuongdan.Name = "lsbhuongdan";
            this.lsbhuongdan.Size = new System.Drawing.Size(416, 364);
            this.lsbhuongdan.TabIndex = 2;
            // 
            // huongdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(493, 447);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lsbhuongdan);
            this.Name = "huongdan";
            this.Text = "huongdan";
            this.Load += new System.EventHandler(this.huongdan_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbhome;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ListBox lsbhuongdan;
    }
}