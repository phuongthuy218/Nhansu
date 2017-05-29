namespace Nhansu.Gui
{
    partial class Chucvu
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
            this.grbchucvu = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthesoluong = new System.Windows.Forms.TextBox();
            this.txtphucap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmacv = new System.Windows.Forms.TextBox();
            this.labmacvu = new System.Windows.Forms.Label();
            this.labtencvu = new System.Windows.Forms.Label();
            this.txttencv = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstxttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtimkiem = new System.Windows.Forms.ToolStripButton();
            this.tsbthoat = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvchucvu = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtluongcoban = new System.Windows.Forms.TextBox();
            this.macv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucapcv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcoban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.grbchucvu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchucvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbchucvu
            // 
            this.grbchucvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbchucvu.Controls.Add(this.label3);
            this.grbchucvu.Controls.Add(this.txtluongcoban);
            this.grbchucvu.Controls.Add(this.label2);
            this.grbchucvu.Controls.Add(this.txthesoluong);
            this.grbchucvu.Controls.Add(this.txtphucap);
            this.grbchucvu.Controls.Add(this.label1);
            this.grbchucvu.Controls.Add(this.txtmacv);
            this.grbchucvu.Controls.Add(this.labmacvu);
            this.grbchucvu.Controls.Add(this.labtencvu);
            this.grbchucvu.Controls.Add(this.txttencv);
            this.grbchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbchucvu.Location = new System.Drawing.Point(123, 63);
            this.grbchucvu.Name = "grbchucvu";
            this.grbchucvu.Size = new System.Drawing.Size(345, 145);
            this.grbchucvu.TabIndex = 18;
            this.grbchucvu.TabStop = false;
            this.grbchucvu.Text = "Thông tin chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hệ số lương";
            // 
            // txthesoluong
            // 
            this.txthesoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthesoluong.Location = new System.Drawing.Point(164, 94);
            this.txthesoluong.Name = "txthesoluong";
            this.txthesoluong.Size = new System.Drawing.Size(163, 22);
            this.txthesoluong.TabIndex = 9;
            // 
            // txtphucap
            // 
            this.txtphucap.Location = new System.Drawing.Point(164, 66);
            this.txtphucap.Name = "txtphucap";
            this.txtphucap.Size = new System.Drawing.Size(163, 22);
            this.txtphucap.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phụ cấp chức vụ";
            // 
            // txtmacv
            // 
            this.txtmacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmacv.Location = new System.Drawing.Point(164, 12);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.Size = new System.Drawing.Size(163, 22);
            this.txtmacv.TabIndex = 4;
            // 
            // labmacvu
            // 
            this.labmacvu.AutoSize = true;
            this.labmacvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmacvu.Location = new System.Drawing.Point(42, 18);
            this.labmacvu.Name = "labmacvu";
            this.labmacvu.Size = new System.Drawing.Size(82, 16);
            this.labmacvu.TabIndex = 0;
            this.labmacvu.Text = "Mã  Chức Vụ";
            // 
            // labtencvu
            // 
            this.labtencvu.AutoSize = true;
            this.labtencvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtencvu.Location = new System.Drawing.Point(42, 44);
            this.labtencvu.Name = "labtencvu";
            this.labtencvu.Size = new System.Drawing.Size(84, 16);
            this.labtencvu.TabIndex = 1;
            this.labtencvu.Text = "Tên Chức Vụ";
            // 
            // txttencv
            // 
            this.txttencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttencv.Location = new System.Drawing.Point(164, 40);
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(163, 22);
            this.txttencv.TabIndex = 5;
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
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(72, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(498, 41);
            this.toolStrip1.TabIndex = 17;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox1.Controls.Add(this.dgvchucvu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 160);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức vụ";
            // 
            // dgvchucvu
            // 
            this.dgvchucvu.BackgroundColor = System.Drawing.Color.White;
            this.dgvchucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchucvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macv,
            this.tencv,
            this.phucapcv,
            this.hesoluong,
            this.luongcoban});
            this.dgvchucvu.Location = new System.Drawing.Point(9, 21);
            this.dgvchucvu.Name = "dgvchucvu";
            this.dgvchucvu.Size = new System.Drawing.Size(548, 133);
            this.dgvchucvu.TabIndex = 8;
            this.dgvchucvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchucvu_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nhansu.Properties.Resources.ThaiSan;
            this.pictureBox1.Location = new System.Drawing.Point(5, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lương cơ bản";
            // 
            // txtluongcoban
            // 
            this.txtluongcoban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtluongcoban.Location = new System.Drawing.Point(164, 120);
            this.txtluongcoban.Name = "txtluongcoban";
            this.txtluongcoban.Size = new System.Drawing.Size(163, 22);
            this.txtluongcoban.TabIndex = 11;
            // 
            // macv
            // 
            this.macv.DataPropertyName = "macv";
            this.macv.HeaderText = "Mã Chức Vụ";
            this.macv.Name = "macv";
            // 
            // tencv
            // 
            this.tencv.DataPropertyName = "tencv";
            this.tencv.HeaderText = "Tên Chức Vụ";
            this.tencv.Name = "tencv";
            // 
            // phucapcv
            // 
            this.phucapcv.DataPropertyName = "phucapcv";
            this.phucapcv.HeaderText = "Phụ cấp chức vụ";
            this.phucapcv.Name = "phucapcv";
            // 
            // hesoluong
            // 
            this.hesoluong.DataPropertyName = "hesoluong";
            this.hesoluong.HeaderText = "Hệ số lương";
            this.hesoluong.Name = "hesoluong";
            // 
            // luongcoban
            // 
            this.luongcoban.DataPropertyName = "luongcoban";
            this.luongcoban.HeaderText = "Lương cơ bản";
            this.luongcoban.Name = "luongcoban";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Nhansu.Properties.Resources.add1;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 38);
            this.toolStripButton1.Text = "Add";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Nhansu.Properties.Resources.e;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(73, 38);
            this.toolStripButton2.Text = "Save";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(605, 395);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbchucvu);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chucvu";
            this.Text = "Chucvu";
            this.Load += new System.EventHandler(this.Chucvu_Load);
            this.grbchucvu.ResumeLayout(false);
            this.grbchucvu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchucvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbchucvu;
        private System.Windows.Forms.TextBox txtphucap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmacv;
        private System.Windows.Forms.Label labmacvu;
        private System.Windows.Forms.Label labtencvu;
        private System.Windows.Forms.TextBox txttencv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tstxttimkiem;
        private System.Windows.Forms.ToolStripButton tsbtimkiem;
        private System.Windows.Forms.ToolStripButton tsbthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvchucvu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthesoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtluongcoban;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn macv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencv;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucapcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcoban;
    }
}