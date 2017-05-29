namespace Nhansu.Gui
{
    partial class Phongban
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labtenpb = new System.Windows.Forms.Label();
            this.labmapb = new System.Windows.Forms.Label();
            this.txttenpb = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmapb = new System.Windows.Forms.TextBox();
            this.labdiachi = new System.Windows.Forms.Label();
            this.txtsdtpb = new System.Windows.Forms.TextBox();
            this.labsdtpb = new System.Windows.Forms.Label();
            this.grbpb = new System.Windows.Forms.GroupBox();
            this.dgvphongban = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mapb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenpb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTpb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbpb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphongban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox1.Controls.Add(this.labtenpb);
            this.groupBox1.Controls.Add(this.labmapb);
            this.groupBox1.Controls.Add(this.txttenpb);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtmapb);
            this.groupBox1.Controls.Add(this.labdiachi);
            this.groupBox1.Controls.Add(this.txtsdtpb);
            this.groupBox1.Controls.Add(this.labsdtpb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(151, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 128);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng ban";
            // 
            // labtenpb
            // 
            this.labtenpb.AutoSize = true;
            this.labtenpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtenpb.Location = new System.Drawing.Point(16, 86);
            this.labtenpb.Name = "labtenpb";
            this.labtenpb.Size = new System.Drawing.Size(101, 16);
            this.labtenpb.TabIndex = 1;
            this.labtenpb.Text = "Tên Phòng Ban";
            // 
            // labmapb
            // 
            this.labmapb.AutoSize = true;
            this.labmapb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmapb.Location = new System.Drawing.Point(14, 32);
            this.labmapb.Name = "labmapb";
            this.labmapb.Size = new System.Drawing.Size(96, 16);
            this.labmapb.TabIndex = 0;
            this.labmapb.Text = "Mã Phòng Ban";
            // 
            // txttenpb
            // 
            this.txttenpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenpb.Location = new System.Drawing.Point(123, 80);
            this.txttenpb.Name = "txttenpb";
            this.txttenpb.Size = new System.Drawing.Size(133, 22);
            this.txttenpb.TabIndex = 5;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(390, 74);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(122, 22);
            this.txtdiachi.TabIndex = 7;
            // 
            // txtmapb
            // 
            this.txtmapb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmapb.Location = new System.Drawing.Point(123, 26);
            this.txtmapb.Name = "txtmapb";
            this.txtmapb.Size = new System.Drawing.Size(133, 22);
            this.txtmapb.TabIndex = 4;
            // 
            // labdiachi
            // 
            this.labdiachi.AutoSize = true;
            this.labdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdiachi.Location = new System.Drawing.Point(319, 80);
            this.labdiachi.Name = "labdiachi";
            this.labdiachi.Size = new System.Drawing.Size(50, 16);
            this.labdiachi.TabIndex = 3;
            this.labdiachi.Text = "Địa Chỉ";
            // 
            // txtsdtpb
            // 
            this.txtsdtpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdtpb.Location = new System.Drawing.Point(390, 26);
            this.txtsdtpb.Name = "txtsdtpb";
            this.txtsdtpb.Size = new System.Drawing.Size(122, 22);
            this.txtsdtpb.TabIndex = 6;
            // 
            // labsdtpb
            // 
            this.labsdtpb.AutoSize = true;
            this.labsdtpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsdtpb.Location = new System.Drawing.Point(279, 32);
            this.labsdtpb.Name = "labsdtpb";
            this.labsdtpb.Size = new System.Drawing.Size(105, 16);
            this.labsdtpb.TabIndex = 2;
            this.labsdtpb.Text = "SDT Phòng Ban";
            // 
            // grbpb
            // 
            this.grbpb.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.grbpb.Controls.Add(this.dgvphongban);
            this.grbpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbpb.Location = new System.Drawing.Point(57, 217);
            this.grbpb.Name = "grbpb";
            this.grbpb.Size = new System.Drawing.Size(496, 196);
            this.grbpb.TabIndex = 35;
            this.grbpb.TabStop = false;
            this.grbpb.Text = "Phòng Ban";
            // 
            // dgvphongban
            // 
            this.dgvphongban.BackgroundColor = System.Drawing.Color.White;
            this.dgvphongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphongban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapb,
            this.tenpb,
            this.diachi,
            this.SDTpb});
            this.dgvphongban.Location = new System.Drawing.Point(6, 21);
            this.dgvphongban.Name = "dgvphongban";
            this.dgvphongban.Size = new System.Drawing.Size(479, 169);
            this.dgvphongban.TabIndex = 8;
            this.dgvphongban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphongban_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nhansu.Properties.Resources.phongban;
            this.pictureBox1.Location = new System.Drawing.Point(21, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 128);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // mapb
            // 
            this.mapb.DataPropertyName = "mapb";
            this.mapb.HeaderText = "Mã Phòng Ban";
            this.mapb.Name = "mapb";
            // 
            // tenpb
            // 
            this.tenpb.DataPropertyName = "tenpb";
            this.tenpb.HeaderText = "Tên Phòng Ban";
            this.tenpb.Name = "tenpb";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // SDTpb
            // 
            this.SDTpb.DataPropertyName = "SDTpb";
            this.SDTpb.HeaderText = "Số điện thoại";
            this.SDTpb.Name = "SDTpb";
            // 
            // Phongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(709, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbpb);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Phongban";
            this.Text = "Phongban";
            this.Load += new System.EventHandler(this.Phongban_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbpb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphongban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_add;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripButton tbs_delete;
        private System.Windows.Forms.ToolStripTextBox tstxttimkiem;
        private System.Windows.Forms.ToolStripButton tbs_search;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labtenpb;
        private System.Windows.Forms.Label labmapb;
        private System.Windows.Forms.TextBox txttenpb;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtmapb;
        private System.Windows.Forms.Label labdiachi;
        private System.Windows.Forms.TextBox txtsdtpb;
        private System.Windows.Forms.Label labsdtpb;
        private System.Windows.Forms.GroupBox grbpb;
        private System.Windows.Forms.DataGridView dgvphongban;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenpb;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTpb;
    }
}