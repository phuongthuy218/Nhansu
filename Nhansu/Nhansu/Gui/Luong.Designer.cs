namespace Nhansu.Gui
{
    partial class Luong
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_add = new System.Windows.Forms.ToolStripButton();
            this.tbs_edit = new System.Windows.Forms.ToolStripButton();
            this.tbs_save = new System.Windows.Forms.ToolStripButton();
            this.tbs_delete = new System.Windows.Forms.ToolStripButton();
            this.tstxttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tbs_search = new System.Windows.Forms.ToolStripButton();
            this.tbs_exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbmanv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnchon = new System.Windows.Forms.Button();
            this.cbbmacv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbhienthi = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txttongluong = new System.Windows.Forms.TextBox();
            this.txttienBHXH = new System.Windows.Forms.TextBox();
            this.txttienBHYT = new System.Windows.Forms.TextBox();
            this.txttienphat = new System.Windows.Forms.TextBox();
            this.txttienthuong = new System.Windows.Forms.TextBox();
            this.txtphucapcv = new System.Windows.Forms.TextBox();
            this.txthesoluong = new System.Windows.Forms.TextBox();
            this.txtluongcoban = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvluong = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcoban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucapcv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienthuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienbaohiemyte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienbaohiemxahoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butsangkhenthuong = new System.Windows.Forms.Button();
            this.butkyluat = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbhienthi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvluong)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbs_add,
            this.tbs_edit,
            this.tbs_save,
            this.tbs_delete,
            this.tstxttimkiem,
            this.tbs_search,
            this.tbs_exit});
            this.toolStrip1.Location = new System.Drawing.Point(9, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(632, 41);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbs_add
            // 
            this.tbs_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbs_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbs_add.Image = global::Nhansu.Properties.Resources.add1;
            this.tbs_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_add.Name = "tbs_add";
            this.tbs_add.Size = new System.Drawing.Size(76, 38);
            this.tbs_add.Text = "Add";
            this.tbs_add.Click += new System.EventHandler(this.tbs_add_Click);
            // 
            // tbs_edit
            // 
            this.tbs_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbs_edit.Image = global::Nhansu.Properties.Resources.Edit_icon;
            this.tbs_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_edit.Name = "tbs_edit";
            this.tbs_edit.Size = new System.Drawing.Size(75, 38);
            this.tbs_edit.Text = "Edit";
            this.tbs_edit.Click += new System.EventHandler(this.tbs_edit_Click);
            // 
            // tbs_save
            // 
            this.tbs_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbs_save.Image = global::Nhansu.Properties.Resources.e;
            this.tbs_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_save.Name = "tbs_save";
            this.tbs_save.Size = new System.Drawing.Size(81, 38);
            this.tbs_save.Text = "Save";
            this.tbs_save.Click += new System.EventHandler(this.tbs_save_Click);
            // 
            // tbs_delete
            // 
            this.tbs_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbs_delete.Image = global::Nhansu.Properties.Resources.blue_delete_button_png_29;
            this.tbs_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_delete.Name = "tbs_delete";
            this.tbs_delete.Size = new System.Drawing.Size(104, 38);
            this.tbs_delete.Text = "Delete";
            this.tbs_delete.Click += new System.EventHandler(this.tbs_delete_Click);
            // 
            // tstxttimkiem
            // 
            this.tstxttimkiem.Name = "tstxttimkiem";
            this.tstxttimkiem.Size = new System.Drawing.Size(100, 41);
            // 
            // tbs_search
            // 
            this.tbs_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbs_search.Image = global::Nhansu.Properties.Resources.timkiem;
            this.tbs_search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_search.Name = "tbs_search";
            this.tbs_search.Size = new System.Drawing.Size(107, 38);
            this.tbs_search.Text = "Search";
            this.tbs_search.Click += new System.EventHandler(this.tbs_search_Click);
            // 
            // tbs_exit
            // 
            this.tbs_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbs_exit.Image = global::Nhansu.Properties.Resources.tao_icon_shutdown_hoac_restart_ngoai_desktop_1;
            this.tbs_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_exit.Name = "tbs_exit";
            this.tbs_exit.Size = new System.Drawing.Size(75, 38);
            this.tbs_exit.Text = "Exit";
            this.tbs_exit.Click += new System.EventHandler(this.tbs_exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox2.Controls.Add(this.txttennv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbmanv);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 113);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(115, 69);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(158, 22);
            this.txttennv.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên nhân viên";
            // 
            // cbbmanv
            // 
            this.cbbmanv.FormattingEnabled = true;
            this.cbbmanv.Location = new System.Drawing.Point(115, 18);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(154, 24);
            this.cbbmanv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // btnchon
            // 
            this.btnchon.Location = new System.Drawing.Point(280, 11);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(50, 23);
            this.btnchon.TabIndex = 38;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // cbbmacv
            // 
            this.cbbmacv.FormattingEnabled = true;
            this.cbbmacv.Location = new System.Drawing.Point(120, 10);
            this.cbbmacv.Name = "cbbmacv";
            this.cbbmacv.Size = new System.Drawing.Size(154, 24);
            this.cbbmacv.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chức vụ";
            // 
            // grbhienthi
            // 
            this.grbhienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbhienthi.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.grbhienthi.Controls.Add(this.butkyluat);
            this.grbhienthi.Controls.Add(this.butsangkhenthuong);
            this.grbhienthi.Controls.Add(this.btnchon);
            this.grbhienthi.Controls.Add(this.button1);
            this.grbhienthi.Controls.Add(this.cbbmacv);
            this.grbhienthi.Controls.Add(this.label4);
            this.grbhienthi.Controls.Add(this.txttongluong);
            this.grbhienthi.Controls.Add(this.txttienBHXH);
            this.grbhienthi.Controls.Add(this.txttienBHYT);
            this.grbhienthi.Controls.Add(this.txttienphat);
            this.grbhienthi.Controls.Add(this.txttienthuong);
            this.grbhienthi.Controls.Add(this.txtphucapcv);
            this.grbhienthi.Controls.Add(this.txthesoluong);
            this.grbhienthi.Controls.Add(this.txtluongcoban);
            this.grbhienthi.Controls.Add(this.label12);
            this.grbhienthi.Controls.Add(this.label11);
            this.grbhienthi.Controls.Add(this.label10);
            this.grbhienthi.Controls.Add(this.label9);
            this.grbhienthi.Controls.Add(this.label8);
            this.grbhienthi.Controls.Add(this.label7);
            this.grbhienthi.Controls.Add(this.label6);
            this.grbhienthi.Controls.Add(this.label5);
            this.grbhienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbhienthi.Location = new System.Drawing.Point(9, 188);
            this.grbhienthi.Name = "grbhienthi";
            this.grbhienthi.Size = new System.Drawing.Size(349, 304);
            this.grbhienthi.TabIndex = 36;
            this.grbhienthi.TabStop = false;
            this.grbhienthi.Text = "Thông tin lương";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tiền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttongluong
            // 
            this.txttongluong.Location = new System.Drawing.Point(120, 235);
            this.txttongluong.Name = "txttongluong";
            this.txttongluong.Size = new System.Drawing.Size(154, 22);
            this.txttongluong.TabIndex = 15;
            // 
            // txttienBHXH
            // 
            this.txttienBHXH.Location = new System.Drawing.Point(119, 206);
            this.txttienBHXH.Name = "txttienBHXH";
            this.txttienBHXH.Size = new System.Drawing.Size(154, 22);
            this.txttienBHXH.TabIndex = 14;
            // 
            // txttienBHYT
            // 
            this.txttienBHYT.Location = new System.Drawing.Point(119, 178);
            this.txttienBHYT.Name = "txttienBHYT";
            this.txttienBHYT.Size = new System.Drawing.Size(154, 22);
            this.txttienBHYT.TabIndex = 13;
            // 
            // txttienphat
            // 
            this.txttienphat.Location = new System.Drawing.Point(119, 150);
            this.txttienphat.Name = "txttienphat";
            this.txttienphat.Size = new System.Drawing.Size(154, 22);
            this.txttienphat.TabIndex = 12;
            // 
            // txttienthuong
            // 
            this.txttienthuong.Location = new System.Drawing.Point(119, 122);
            this.txttienthuong.Name = "txttienthuong";
            this.txttienthuong.Size = new System.Drawing.Size(154, 22);
            this.txttienthuong.TabIndex = 11;
            // 
            // txtphucapcv
            // 
            this.txtphucapcv.Location = new System.Drawing.Point(119, 94);
            this.txtphucapcv.Name = "txtphucapcv";
            this.txtphucapcv.Size = new System.Drawing.Size(154, 22);
            this.txtphucapcv.TabIndex = 10;
            // 
            // txthesoluong
            // 
            this.txthesoluong.Location = new System.Drawing.Point(119, 66);
            this.txthesoluong.Name = "txthesoluong";
            this.txthesoluong.Size = new System.Drawing.Size(154, 22);
            this.txthesoluong.TabIndex = 9;
            // 
            // txtluongcoban
            // 
            this.txtluongcoban.Location = new System.Drawing.Point(119, 40);
            this.txtluongcoban.Name = "txtluongcoban";
            this.txtluongcoban.Size = new System.Drawing.Size(154, 22);
            this.txtluongcoban.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "TỔNG LƯƠNG";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tiền BHXH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tiền BHYT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tiền phạt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tiền thưởng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phụ cấp chức vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "hệ số lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lương cơ bản";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox1.Controls.Add(this.dgvluong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(364, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 423);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển Thị Lương";
            // 
            // dgvluong
            // 
            this.dgvluong.BackgroundColor = System.Drawing.Color.White;
            this.dgvluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvluong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.macv,
            this.luongcoban,
            this.hesoluong,
            this.phucapcv,
            this.tienthuong,
            this.tienphat,
            this.tienbaohiemyte,
            this.tienbaohiemxahoi,
            this.tongluong});
            this.dgvluong.Location = new System.Drawing.Point(6, 20);
            this.dgvluong.Name = "dgvluong";
            this.dgvluong.Size = new System.Drawing.Size(348, 390);
            this.dgvluong.TabIndex = 12;
            this.dgvluong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvluong_CellContentClick);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.Name = "tennv";
            // 
            // macv
            // 
            this.macv.DataPropertyName = "macv";
            this.macv.HeaderText = "Mã chức vụ";
            this.macv.Name = "macv";
            // 
            // luongcoban
            // 
            this.luongcoban.DataPropertyName = "luongcoban";
            this.luongcoban.HeaderText = "Lương cơ bản";
            this.luongcoban.Name = "luongcoban";
            // 
            // hesoluong
            // 
            this.hesoluong.DataPropertyName = "hesoluong";
            this.hesoluong.HeaderText = "Hệ số lương";
            this.hesoluong.Name = "hesoluong";
            // 
            // phucapcv
            // 
            this.phucapcv.DataPropertyName = "phucapcv";
            this.phucapcv.HeaderText = "Phụ cấp";
            this.phucapcv.Name = "phucapcv";
            // 
            // tienthuong
            // 
            this.tienthuong.DataPropertyName = "tienthuong";
            this.tienthuong.HeaderText = "Tiền thưởng";
            this.tienthuong.Name = "tienthuong";
            // 
            // tienphat
            // 
            this.tienphat.DataPropertyName = "tienphat";
            this.tienphat.HeaderText = "Tiền phạt";
            this.tienphat.Name = "tienphat";
            // 
            // tienbaohiemyte
            // 
            this.tienbaohiemyte.DataPropertyName = "tienbaohiemyte";
            this.tienbaohiemyte.HeaderText = "Tiền bảo hiểm y tế";
            this.tienbaohiemyte.Name = "tienbaohiemyte";
            // 
            // tienbaohiemxahoi
            // 
            this.tienbaohiemxahoi.DataPropertyName = "tienbaohiemxahoi";
            this.tienbaohiemxahoi.HeaderText = "Tiền bảo hiểm xã hội";
            this.tienbaohiemxahoi.Name = "tienbaohiemxahoi";
            // 
            // tongluong
            // 
            this.tongluong.DataPropertyName = "tongluong";
            this.tongluong.HeaderText = "Tổng lương";
            this.tongluong.Name = "tongluong";
            // 
            // butsangkhenthuong
            // 
            this.butsangkhenthuong.Location = new System.Drawing.Point(87, 268);
            this.butsangkhenthuong.Name = "butsangkhenthuong";
            this.butsangkhenthuong.Size = new System.Drawing.Size(106, 23);
            this.butsangkhenthuong.TabIndex = 39;
            this.butsangkhenthuong.Text = "Khen thưởng";
            this.butsangkhenthuong.UseVisualStyleBackColor = true;
            this.butsangkhenthuong.Click += new System.EventHandler(this.butsangkhenthuong_Click);
            // 
            // butkyluat
            // 
            this.butkyluat.Location = new System.Drawing.Point(213, 268);
            this.butkyluat.Name = "butkyluat";
            this.butkyluat.Size = new System.Drawing.Size(102, 23);
            this.butkyluat.TabIndex = 40;
            this.butkyluat.Text = "Kỷ luật";
            this.butkyluat.UseVisualStyleBackColor = true;
            this.butkyluat.Click += new System.EventHandler(this.butkyluat_Click);
            // 
            // Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(725, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbhienthi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Luong";
            this.Text = "Luong";
            this.Load += new System.EventHandler(this.Luong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbhienthi.ResumeLayout(false);
            this.grbhienthi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_add;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripButton tbs_delete;
        private System.Windows.Forms.ToolStripButton tbs_search;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbmanv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbhienthi;
        private System.Windows.Forms.TextBox txttongluong;
        private System.Windows.Forms.TextBox txttienBHXH;
        private System.Windows.Forms.TextBox txttienBHYT;
        private System.Windows.Forms.TextBox txttienphat;
        private System.Windows.Forms.TextBox txttienthuong;
        private System.Windows.Forms.TextBox txthesoluong;
        private System.Windows.Forms.TextBox txtluongcoban;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvluong;
        private System.Windows.Forms.ToolStripTextBox tstxttimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbmacv;
        private System.Windows.Forms.TextBox txtphucapcv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn macv;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcoban;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucapcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienthuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienbaohiemyte;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienbaohiemxahoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongluong;
        private System.Windows.Forms.Button butkyluat;
        private System.Windows.Forms.Button butsangkhenthuong;
    }
}