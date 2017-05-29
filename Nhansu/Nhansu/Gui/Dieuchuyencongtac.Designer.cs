namespace Nhansu.Gui
{
    partial class Dieuchuyencongtac
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butchon = new System.Windows.Forms.Button();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbmanv = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtpbcu = new System.Windows.Forms.TextBox();
            this.txtcvcu = new System.Windows.Forms.TextBox();
            this.datetungay = new System.Windows.Forms.DateTimePicker();
            this.txtlydo = new System.Windows.Forms.TextBox();
            this.cbbcvmoi = new System.Windows.Forms.ComboBox();
            this.cbbpbmoi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvdieuchuyen = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapbcu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapbmoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macvcu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macvmoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tungay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lydo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_add = new System.Windows.Forms.ToolStripButton();
            this.tbs_edit = new System.Windows.Forms.ToolStripButton();
            this.tbs_save = new System.Windows.Forms.ToolStripButton();
            this.tbs_delete = new System.Windows.Forms.ToolStripButton();
            this.tstxttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tbs_search = new System.Windows.Forms.ToolStripButton();
            this.tbs_exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdieuchuyen)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox1.Controls.Add(this.butchon);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbmanv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân viên";
            // 
            // butchon
            // 
            this.butchon.Location = new System.Drawing.Point(218, 18);
            this.butchon.Name = "butchon";
            this.butchon.Size = new System.Drawing.Size(60, 23);
            this.butchon.TabIndex = 14;
            this.butchon.Text = "Chọn";
            this.butchon.UseVisualStyleBackColor = true;
            this.butchon.Click += new System.EventHandler(this.butchon_Click);
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(103, 52);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(138, 22);
            this.txttennv.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên nhân viên";
            // 
            // cbbmanv
            // 
            this.cbbmanv.FormattingEnabled = true;
            this.cbbmanv.Location = new System.Drawing.Point(103, 18);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(109, 24);
            this.cbbmanv.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtpbcu);
            this.groupBox2.Controls.Add(this.txtcvcu);
            this.groupBox2.Controls.Add(this.datetungay);
            this.groupBox2.Controls.Add(this.txtlydo);
            this.groupBox2.Controls.Add(this.cbbcvmoi);
            this.groupBox2.Controls.Add(this.cbbpbmoi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục thay đổi";
            // 
            // txtpbcu
            // 
            this.txtpbcu.Location = new System.Drawing.Point(103, 26);
            this.txtpbcu.Name = "txtpbcu";
            this.txtpbcu.Size = new System.Drawing.Size(138, 22);
            this.txtpbcu.TabIndex = 13;
            // 
            // txtcvcu
            // 
            this.txtcvcu.Location = new System.Drawing.Point(103, 86);
            this.txtcvcu.Name = "txtcvcu";
            this.txtcvcu.Size = new System.Drawing.Size(138, 22);
            this.txtcvcu.TabIndex = 12;
            // 
            // datetungay
            // 
            this.datetungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetungay.Location = new System.Drawing.Point(103, 147);
            this.datetungay.Name = "datetungay";
            this.datetungay.Size = new System.Drawing.Size(138, 22);
            this.datetungay.TabIndex = 1;
            // 
            // txtlydo
            // 
            this.txtlydo.Location = new System.Drawing.Point(103, 175);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(138, 22);
            this.txtlydo.TabIndex = 11;
            // 
            // cbbcvmoi
            // 
            this.cbbcvmoi.FormattingEnabled = true;
            this.cbbcvmoi.Location = new System.Drawing.Point(103, 116);
            this.cbbcvmoi.Name = "cbbcvmoi";
            this.cbbcvmoi.Size = new System.Drawing.Size(138, 24);
            this.cbbcvmoi.TabIndex = 9;
            // 
            // cbbpbmoi
            // 
            this.cbbpbmoi.FormattingEnabled = true;
            this.cbbpbmoi.Location = new System.Drawing.Point(103, 53);
            this.cbbpbmoi.Name = "cbbpbmoi";
            this.cbbpbmoi.Size = new System.Drawing.Size(138, 24);
            this.cbbpbmoi.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Lý do";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Từ ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Chức vụ mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chức vụ cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phòng ban mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phòng ban cũ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox3.Controls.Add(this.dgvdieuchuyen);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(299, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 252);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // dgvdieuchuyen
            // 
            this.dgvdieuchuyen.BackgroundColor = System.Drawing.Color.White;
            this.dgvdieuchuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdieuchuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.mapbcu,
            this.mapbmoi,
            this.macvcu,
            this.macvmoi,
            this.tungay,
            this.lydo,
            this.ghichu});
            this.dgvdieuchuyen.Location = new System.Drawing.Point(6, 18);
            this.dgvdieuchuyen.Name = "dgvdieuchuyen";
            this.dgvdieuchuyen.Size = new System.Drawing.Size(370, 221);
            this.dgvdieuchuyen.TabIndex = 0;
            this.dgvdieuchuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdieuchuyen_CellContentClick);
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
            // mapbcu
            // 
            this.mapbcu.DataPropertyName = "mapbcu";
            this.mapbcu.HeaderText = "Phòng ban cũ";
            this.mapbcu.Name = "mapbcu";
            // 
            // mapbmoi
            // 
            this.mapbmoi.DataPropertyName = "mapbmoi";
            this.mapbmoi.HeaderText = "Phòng ban mới";
            this.mapbmoi.Name = "mapbmoi";
            // 
            // macvcu
            // 
            this.macvcu.DataPropertyName = "macvcu";
            this.macvcu.HeaderText = "Chức vụ cũ";
            this.macvcu.Name = "macvcu";
            // 
            // macvmoi
            // 
            this.macvmoi.DataPropertyName = "macvmoi";
            this.macvmoi.HeaderText = "Chức vụ mới";
            this.macvmoi.Name = "macvmoi";
            // 
            // tungay
            // 
            this.tungay.DataPropertyName = "tungay";
            this.tungay.HeaderText = "Từ ngày";
            this.tungay.Name = "tungay";
            // 
            // lydo
            // 
            this.lydo.DataPropertyName = "lydo";
            this.lydo.HeaderText = "Lý do";
            this.lydo.Name = "lydo";
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
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
            this.toolStrip1.Size = new System.Drawing.Size(682, 41);
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
            this.tstxttimkiem.Size = new System.Drawing.Size(150, 41);
            this.tstxttimkiem.Click += new System.EventHandler(this.tstxttimkiem_Click);
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox4.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox4.Controls.Add(this.txtghichu);
            this.groupBox4.Location = new System.Drawing.Point(299, 323);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 62);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ghi chú";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(6, 19);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(370, 37);
            this.txtghichu.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Xem chức vụ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Xem phòng ban";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dieuchuyencongtac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(698, 397);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dieuchuyencongtac";
            this.Text = "Dieuchuyencongtac";
            this.Load += new System.EventHandler(this.Dieuchuyencongtac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdieuchuyen)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbmanv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtlydo;
        private System.Windows.Forms.ComboBox cbbcvmoi;
        private System.Windows.Forms.ComboBox cbbpbmoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvdieuchuyen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_add;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripButton tbs_delete;
        private System.Windows.Forms.ToolStripTextBox tstxttimkiem;
        private System.Windows.Forms.ToolStripButton tbs_search;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.DateTimePicker datetungay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Button butchon;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpbcu;
        private System.Windows.Forms.TextBox txtcvcu;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapbcu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapbmoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn macvcu;
        private System.Windows.Forms.DataGridViewTextBoxColumn macvmoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tungay;
        private System.Windows.Forms.DataGridViewTextBoxColumn lydo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}