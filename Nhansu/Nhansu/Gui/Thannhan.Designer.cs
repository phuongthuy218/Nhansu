namespace Nhansu.Gui
{
    partial class Thannhan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbtinhdc = new System.Windows.Forms.ComboBox();
            this.cbbhuyendc = new System.Windows.Forms.ComboBox();
            this.cbbxadc = new System.Windows.Forms.ComboBox();
            this.txtquanhe = new System.Windows.Forms.TextBox();
            this.labquanhe = new System.Windows.Forms.Label();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.labngaysinh = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labmanv = new System.Windows.Forms.Label();
            this.cbbmanv = new System.Windows.Forms.ComboBox();
            this.labtentn = new System.Windows.Forms.Label();
            this.txttentn = new System.Windows.Forms.TextBox();
            this.grbthannhan = new System.Windows.Forms.GroupBox();
            this.dgvthannhan = new System.Windows.Forms.DataGridView();
            this.tentn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstxttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtimkiem = new System.Windows.Forms.ToolStripButton();
            this.tsbthoat = new System.Windows.Forms.ToolStripButton();
            this.tsbthem = new System.Windows.Forms.ToolStripButton();
            this.tsbxoa = new System.Windows.Forms.ToolStripButton();
            this.tsbluu = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.grbthannhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthannhan)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox1.Controls.Add(this.cbbtinhdc);
            this.groupBox1.Controls.Add(this.cbbhuyendc);
            this.groupBox1.Controls.Add(this.cbbxadc);
            this.groupBox1.Controls.Add(this.txtquanhe);
            this.groupBox1.Controls.Add(this.labquanhe);
            this.groupBox1.Controls.Add(this.datengaysinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labngaysinh);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.labmanv);
            this.groupBox1.Controls.Add(this.cbbmanv);
            this.groupBox1.Controls.Add(this.labtentn);
            this.groupBox1.Controls.Add(this.txttentn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 138);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thân nhân";
            // 
            // cbbtinhdc
            // 
            this.cbbtinhdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbtinhdc.FormattingEnabled = true;
            this.cbbtinhdc.Items.AddRange(new object[] {
            "Cao Bằng",
            "Hà Nam",
            "Hà Tĩnh",
            "Hải Dương",
            "Nghệ An",
            "Ninh Bình",
            "Thái Bình",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM",
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang\t",
            "Hậu Giang",
            "Hưng Yên",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Nguyên",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            "Phú Yên",
            "Long An",
            "Ninh Thuận",
            "Phú Thọ"});
            this.cbbtinhdc.Location = new System.Drawing.Point(258, 108);
            this.cbbtinhdc.Name = "cbbtinhdc";
            this.cbbtinhdc.Size = new System.Drawing.Size(113, 24);
            this.cbbtinhdc.TabIndex = 24;
            this.cbbtinhdc.SelectedIndexChanged += new System.EventHandler(this.cbbtinhdc_SelectedIndexChanged);
            // 
            // cbbhuyendc
            // 
            this.cbbhuyendc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbhuyendc.FormattingEnabled = true;
            this.cbbhuyendc.Location = new System.Drawing.Point(368, 108);
            this.cbbhuyendc.Name = "cbbhuyendc";
            this.cbbhuyendc.Size = new System.Drawing.Size(113, 24);
            this.cbbhuyendc.TabIndex = 23;
            this.cbbhuyendc.SelectedIndexChanged += new System.EventHandler(this.cbbhuyendc_SelectedIndexChanged);
            // 
            // cbbxadc
            // 
            this.cbbxadc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxadc.FormattingEnabled = true;
            this.cbbxadc.Location = new System.Drawing.Point(473, 108);
            this.cbbxadc.Name = "cbbxadc";
            this.cbbxadc.Size = new System.Drawing.Size(115, 24);
            this.cbbxadc.TabIndex = 22;
            // 
            // txtquanhe
            // 
            this.txtquanhe.Location = new System.Drawing.Point(368, 21);
            this.txtquanhe.Name = "txtquanhe";
            this.txtquanhe.Size = new System.Drawing.Size(140, 22);
            this.txtquanhe.TabIndex = 13;
            // 
            // labquanhe
            // 
            this.labquanhe.AutoSize = true;
            this.labquanhe.Location = new System.Drawing.Point(295, 27);
            this.labquanhe.Name = "labquanhe";
            this.labquanhe.Size = new System.Drawing.Size(61, 16);
            this.labquanhe.TabIndex = 4;
            this.labquanhe.Text = "Quan Hệ";
            // 
            // datengaysinh
            // 
            this.datengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh.Location = new System.Drawing.Point(368, 54);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(140, 22);
            this.datengaysinh.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Địa chỉ";
            // 
            // labngaysinh
            // 
            this.labngaysinh.AutoSize = true;
            this.labngaysinh.Location = new System.Drawing.Point(286, 59);
            this.labngaysinh.Name = "labngaysinh";
            this.labngaysinh.Size = new System.Drawing.Size(70, 16);
            this.labngaysinh.TabIndex = 1;
            this.labngaysinh.Text = "Ngày Sinh";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(488, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 16);
            this.label17.TabIndex = 21;
            this.label17.Text = "Xã(phường)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(271, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Tỉnh(thành phố)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(377, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Huyện(quận)";
            // 
            // labmanv
            // 
            this.labmanv.AutoSize = true;
            this.labmanv.Location = new System.Drawing.Point(18, 47);
            this.labmanv.Name = "labmanv";
            this.labmanv.Size = new System.Drawing.Size(92, 16);
            this.labmanv.TabIndex = 3;
            this.labmanv.Text = "Mã Nhân Viên";
            // 
            // cbbmanv
            // 
            this.cbbmanv.FormattingEnabled = true;
            this.cbbmanv.Location = new System.Drawing.Point(116, 39);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(130, 24);
            this.cbbmanv.TabIndex = 8;
            // 
            // labtentn
            // 
            this.labtentn.AutoSize = true;
            this.labtentn.Location = new System.Drawing.Point(4, 87);
            this.labtentn.Name = "labtentn";
            this.labtentn.Size = new System.Drawing.Size(101, 16);
            this.labtentn.TabIndex = 0;
            this.labtentn.Text = "Tên Thân Nhân";
            // 
            // txttentn
            // 
            this.txttentn.Location = new System.Drawing.Point(113, 81);
            this.txttentn.Name = "txttentn";
            this.txttentn.Size = new System.Drawing.Size(145, 22);
            this.txttentn.TabIndex = 5;
            // 
            // grbthannhan
            // 
            this.grbthannhan.BackColor = System.Drawing.Color.SeaShell;
            this.grbthannhan.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.grbthannhan.Controls.Add(this.dgvthannhan);
            this.grbthannhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbthannhan.Location = new System.Drawing.Point(51, 207);
            this.grbthannhan.Name = "grbthannhan";
            this.grbthannhan.Size = new System.Drawing.Size(589, 195);
            this.grbthannhan.TabIndex = 20;
            this.grbthannhan.TabStop = false;
            this.grbthannhan.Text = "Thân nhân";
            // 
            // dgvthannhan
            // 
            this.dgvthannhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvthannhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthannhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tentn,
            this.ngaysinh,
            this.diachi,
            this.manv,
            this.quanhe});
            this.dgvthannhan.Location = new System.Drawing.Point(6, 18);
            this.dgvthannhan.Name = "dgvthannhan";
            this.dgvthannhan.Size = new System.Drawing.Size(577, 169);
            this.dgvthannhan.TabIndex = 10;
            this.dgvthannhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvthannhan_CellContentClick);
            // 
            // tentn
            // 
            this.tentn.DataPropertyName = "tentn";
            this.tentn.HeaderText = "Tên thân nhân";
            this.tentn.Name = "tentn";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.Name = "manv";
            // 
            // quanhe
            // 
            this.quanhe.DataPropertyName = "quanhe";
            this.quanhe.HeaderText = "Quan hệ";
            this.quanhe.Name = "quanhe";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxttimkiem,
            this.tsbtimkiem,
            this.tsbthoat,
            this.tsbthem,
            this.tsbxoa,
            this.tsbluu});
            this.toolStrip1.Location = new System.Drawing.Point(46, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(559, 41);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstxttimkiem
            // 
            this.tstxttimkiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstxttimkiem.Name = "tstxttimkiem";
            this.tstxttimkiem.Size = new System.Drawing.Size(150, 41);
            this.tstxttimkiem.Click += new System.EventHandler(this.tstxttimkiem_Click);
            // 
            // tsbtimkiem
            // 
            this.tsbtimkiem.Image = global::Nhansu.Properties.Resources.timkiem;
            this.tsbtimkiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtimkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtimkiem.Name = "tsbtimkiem";
            this.tsbtimkiem.Size = new System.Drawing.Size(95, 38);
            this.tsbtimkiem.Text = "Search";
            this.tsbtimkiem.Click += new System.EventHandler(this.tsbtimkiem_Click);
            // 
            // tsbthoat
            // 
            this.tsbthoat.Image = global::Nhansu.Properties.Resources.tao_icon_shutdown_hoac_restart_ngoai_desktop_1;
            this.tsbthoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthoat.Name = "tsbthoat";
            this.tsbthoat.Size = new System.Drawing.Size(67, 38);
            this.tsbthoat.Text = "Exit";
            this.tsbthoat.Click += new System.EventHandler(this.tsbthoat_Click);
            // 
            // tsbthem
            // 
            this.tsbthem.Image = global::Nhansu.Properties.Resources.add1;
            this.tsbthem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthem.Name = "tsbthem";
            this.tsbthem.Size = new System.Drawing.Size(68, 38);
            this.tsbthem.Text = "Add";
            this.tsbthem.Click += new System.EventHandler(this.tsbthem_Click);
            // 
            // tsbxoa
            // 
            this.tsbxoa.Image = global::Nhansu.Properties.Resources.blue_delete_button_png_29;
            this.tsbxoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbxoa.Name = "tsbxoa";
            this.tsbxoa.Size = new System.Drawing.Size(92, 38);
            this.tsbxoa.Text = "Delete";
            this.tsbxoa.Click += new System.EventHandler(this.tsbxoa_Click);
            // 
            // tsbluu
            // 
            this.tsbluu.Image = global::Nhansu.Properties.Resources.e;
            this.tsbluu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbluu.Name = "tsbluu";
            this.tsbluu.Size = new System.Drawing.Size(73, 38);
            this.tsbluu.Text = "Save";
            this.tsbluu.Click += new System.EventHandler(this.tsbluu_Click);
            // 
            // Thannhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(762, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbthannhan);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Thannhan";
            this.Text = "Thannhan";
            this.Load += new System.EventHandler(this.Thannhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbthannhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthannhan)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labmanv;
        private System.Windows.Forms.ComboBox cbbmanv;
        private System.Windows.Forms.DateTimePicker datengaysinh;
        private System.Windows.Forms.Label labtentn;
        private System.Windows.Forms.TextBox txttentn;
        private System.Windows.Forms.Label labngaysinh;
        private System.Windows.Forms.GroupBox grbthannhan;
        private System.Windows.Forms.DataGridView dgvthannhan;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tstxttimkiem;
        private System.Windows.Forms.ToolStripButton tsbtimkiem;
        private System.Windows.Forms.ToolStripButton tsbthoat;
        private System.Windows.Forms.ToolStripButton tsbthem;
        private System.Windows.Forms.ToolStripButton tsbxoa;
        private System.Windows.Forms.ToolStripButton tsbluu;
        private System.Windows.Forms.TextBox txtquanhe;
        private System.Windows.Forms.Label labquanhe;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbtinhdc;
        private System.Windows.Forms.ComboBox cbbhuyendc;
        private System.Windows.Forms.ComboBox cbbxadc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanhe;
    }
}