namespace Nhansu.Gui
{
    partial class Hopdong
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
            this.datengaykikethd = new System.Windows.Forms.DateTimePicker();
            this.cbbmanv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labmanv = new System.Windows.Forms.Label();
            this.labdenngay = new System.Windows.Forms.Label();
            this.datedenngay = new System.Windows.Forms.DateTimePicker();
            this.grbhienthi1 = new System.Windows.Forms.GroupBox();
            this.labmahd = new System.Windows.Forms.Label();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.labtungay = new System.Windows.Forms.Label();
            this.datetungay = new System.Windows.Forms.DateTimePicker();
            this.labloaihd = new System.Windows.Forms.Label();
            this.txtloaihd = new System.Windows.Forms.TextBox();
            this.grbhienthi = new System.Windows.Forms.GroupBox();
            this.dgvhopdong = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_add = new System.Windows.Forms.ToolStripButton();
            this.tbs_edit = new System.Windows.Forms.ToolStripButton();
            this.tbs_save = new System.Windows.Forms.ToolStripButton();
            this.tbs_delete = new System.Windows.Forms.ToolStripButton();
            this.tstxttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tbs_search = new System.Windows.Forms.ToolStripButton();
            this.tbs_exit = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaihd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tungay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykikethd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grbhienthi1.SuspendLayout();
            this.grbhienthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhopdong)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.datengaykikethd);
            this.groupBox1.Controls.Add(this.cbbmanv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labmanv);
            this.groupBox1.Controls.Add(this.labdenngay);
            this.groupBox1.Controls.Add(this.datedenngay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(364, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 136);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // datengaykikethd
            // 
            this.datengaykikethd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaykikethd.Location = new System.Drawing.Point(129, 89);
            this.datengaykikethd.Name = "datengaykikethd";
            this.datengaykikethd.Size = new System.Drawing.Size(199, 22);
            this.datengaykikethd.TabIndex = 13;
            // 
            // cbbmanv
            // 
            this.cbbmanv.DisplayMember = "manv";
            this.cbbmanv.FormattingEnabled = true;
            this.cbbmanv.Location = new System.Drawing.Point(128, 31);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(200, 24);
            this.cbbmanv.TabIndex = 24;
            this.cbbmanv.ValueMember = "tennv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ngày kí kết HD";
            // 
            // labmanv
            // 
            this.labmanv.AutoSize = true;
            this.labmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmanv.Location = new System.Drawing.Point(21, 36);
            this.labmanv.Name = "labmanv";
            this.labmanv.Size = new System.Drawing.Size(92, 16);
            this.labmanv.TabIndex = 19;
            this.labmanv.Text = "Mã Nhân Viên";
            // 
            // labdenngay
            // 
            this.labdenngay.AutoSize = true;
            this.labdenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdenngay.Location = new System.Drawing.Point(45, 67);
            this.labdenngay.Name = "labdenngay";
            this.labdenngay.Size = new System.Drawing.Size(68, 16);
            this.labdenngay.TabIndex = 7;
            this.labdenngay.Text = "Đến Ngày";
            // 
            // datedenngay
            // 
            this.datedenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedenngay.Location = new System.Drawing.Point(129, 62);
            this.datedenngay.Name = "datedenngay";
            this.datedenngay.Size = new System.Drawing.Size(199, 22);
            this.datedenngay.TabIndex = 11;
            // 
            // grbhienthi1
            // 
            this.grbhienthi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbhienthi1.Controls.Add(this.labmahd);
            this.grbhienthi1.Controls.Add(this.txtmahd);
            this.grbhienthi1.Controls.Add(this.labtungay);
            this.grbhienthi1.Controls.Add(this.datetungay);
            this.grbhienthi1.Controls.Add(this.labloaihd);
            this.grbhienthi1.Controls.Add(this.txtloaihd);
            this.grbhienthi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbhienthi1.Location = new System.Drawing.Point(21, 61);
            this.grbhienthi1.Name = "grbhienthi1";
            this.grbhienthi1.Size = new System.Drawing.Size(337, 136);
            this.grbhienthi1.TabIndex = 35;
            this.grbhienthi1.TabStop = false;
            this.grbhienthi1.Text = "Thông tin hợp đồng";
            // 
            // labmahd
            // 
            this.labmahd.AutoSize = true;
            this.labmahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmahd.Location = new System.Drawing.Point(17, 43);
            this.labmahd.Name = "labmahd";
            this.labmahd.Size = new System.Drawing.Size(91, 16);
            this.labmahd.TabIndex = 0;
            this.labmahd.Text = "Mã Hợp Đồng";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(119, 36);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(200, 22);
            this.txtmahd.TabIndex = 5;
            // 
            // labtungay
            // 
            this.labtungay.AutoSize = true;
            this.labtungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtungay.Location = new System.Drawing.Point(46, 97);
            this.labtungay.Name = "labtungay";
            this.labtungay.Size = new System.Drawing.Size(60, 16);
            this.labtungay.TabIndex = 4;
            this.labtungay.Text = "Từ Ngày";
            // 
            // datetungay
            // 
            this.datetungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetungay.Location = new System.Drawing.Point(120, 92);
            this.datetungay.Name = "datetungay";
            this.datetungay.Size = new System.Drawing.Size(199, 22);
            this.datetungay.TabIndex = 10;
            // 
            // labloaihd
            // 
            this.labloaihd.AutoSize = true;
            this.labloaihd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labloaihd.Location = new System.Drawing.Point(10, 70);
            this.labloaihd.Name = "labloaihd";
            this.labloaihd.Size = new System.Drawing.Size(98, 16);
            this.labloaihd.TabIndex = 1;
            this.labloaihd.Text = "Loại Hợp Đồng";
            // 
            // txtloaihd
            // 
            this.txtloaihd.Location = new System.Drawing.Point(119, 64);
            this.txtloaihd.Name = "txtloaihd";
            this.txtloaihd.Size = new System.Drawing.Size(200, 22);
            this.txtloaihd.TabIndex = 6;
            // 
            // grbhienthi
            // 
            this.grbhienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbhienthi.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.grbhienthi.Controls.Add(this.dgvhopdong);
            this.grbhienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbhienthi.Location = new System.Drawing.Point(12, 203);
            this.grbhienthi.Name = "grbhienthi";
            this.grbhienthi.Size = new System.Drawing.Size(764, 236);
            this.grbhienthi.TabIndex = 34;
            this.grbhienthi.TabStop = false;
            this.grbhienthi.Text = "Danh sách hợp đồng";
            // 
            // dgvhopdong
            // 
            this.dgvhopdong.BackgroundColor = System.Drawing.Color.White;
            this.dgvhopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhopdong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.loaihd,
            this.manv,
            this.tungay,
            this.denngay,
            this.ngaykikethd});
            this.dgvhopdong.Location = new System.Drawing.Point(6, 20);
            this.dgvhopdong.Name = "dgvhopdong";
            this.dgvhopdong.Size = new System.Drawing.Size(750, 210);
            this.dgvhopdong.TabIndex = 13;
            this.dgvhopdong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhopdong_CellContentClick);
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
            this.toolStrip1.Location = new System.Drawing.Point(21, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(682, 41);
            this.toolStrip1.TabIndex = 33;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nhansu.Properties.Resources.Icon001;
            this.pictureBox1.Location = new System.Drawing.Point(707, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "mahd";
            this.mahd.HeaderText = "Mã Hợp đồng";
            this.mahd.Name = "mahd";
            // 
            // loaihd
            // 
            this.loaihd.DataPropertyName = "loaihd";
            this.loaihd.HeaderText = "Loại hợp đồng";
            this.loaihd.Name = "loaihd";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã Nhân viên";
            this.manv.Name = "manv";
            // 
            // tungay
            // 
            this.tungay.DataPropertyName = "tungay";
            this.tungay.HeaderText = "Từ ngày";
            this.tungay.Name = "tungay";
            // 
            // denngay
            // 
            this.denngay.DataPropertyName = "denngay";
            this.denngay.HeaderText = "Đến ngày";
            this.denngay.Name = "denngay";
            // 
            // ngaykikethd
            // 
            this.ngaykikethd.DataPropertyName = "ngaykikethd";
            this.ngaykikethd.HeaderText = "Ngày kí kết hợp đồng";
            this.ngaykikethd.Name = "ngaykikethd";
            // 
            // Hopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(812, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbhienthi1);
            this.Controls.Add(this.grbhienthi);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Hopdong";
            this.Text = "Hopdong";
            this.Load += new System.EventHandler(this.Hopdong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbhienthi1.ResumeLayout(false);
            this.grbhienthi1.PerformLayout();
            this.grbhienthi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhopdong)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbmanv;
        private System.Windows.Forms.Label labmanv;
        private System.Windows.Forms.GroupBox grbhienthi1;
        private System.Windows.Forms.Label labdenngay;
        private System.Windows.Forms.DateTimePicker datedenngay;
        private System.Windows.Forms.Label labmahd;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label labtungay;
        private System.Windows.Forms.DateTimePicker datetungay;
        private System.Windows.Forms.Label labloaihd;
        private System.Windows.Forms.TextBox txtloaihd;
        private System.Windows.Forms.GroupBox grbhienthi;
        private System.Windows.Forms.DataGridView dgvhopdong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_add;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripButton tbs_delete;
        private System.Windows.Forms.ToolStripTextBox tstxttimkiem;
        private System.Windows.Forms.ToolStripButton tbs_search;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker datengaykikethd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaihd;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tungay;
        private System.Windows.Forms.DataGridViewTextBoxColumn denngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykikethd;
    }
}