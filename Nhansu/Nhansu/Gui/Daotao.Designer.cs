namespace Nhansu.Gui
{
    partial class Daotao
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdaotao = new System.Windows.Forms.DataGridView();
            this.madt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tungay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txtsonv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datedenngay = new System.Windows.Forms.DateTimePicker();
            this.datetungay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttendt = new System.Windows.Forms.TextBox();
            this.txtmadt = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tstxttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtimkiem = new System.Windows.Forms.ToolStripButton();
            this.tsbthoat = new System.Windows.Forms.ToolStripButton();
            this.tsbxemnvdt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbluu = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdaotao)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đào tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đào tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox1.Controls.Add(this.dgvdaotao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đào tạo";
            // 
            // dgvdaotao
            // 
            this.dgvdaotao.BackgroundColor = System.Drawing.Color.White;
            this.dgvdaotao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdaotao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madt,
            this.tendt,
            this.tungay,
            this.denngay,
            this.diachi,
            this.soluongnv});
            this.dgvdaotao.Location = new System.Drawing.Point(6, 19);
            this.dgvdaotao.Name = "dgvdaotao";
            this.dgvdaotao.Size = new System.Drawing.Size(582, 158);
            this.dgvdaotao.TabIndex = 0;
            this.dgvdaotao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdaotao_CellContentClick);
            // 
            // madt
            // 
            this.madt.DataPropertyName = "madt";
            this.madt.HeaderText = "Mã đào tạo";
            this.madt.Name = "madt";
            // 
            // tendt
            // 
            this.tendt.DataPropertyName = "tendt";
            this.tendt.HeaderText = "Tên đào tạo";
            this.tendt.Name = "tendt";
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
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // soluongnv
            // 
            this.soluongnv.DataPropertyName = "soluongnv";
            this.soluongnv.HeaderText = "Số lượng nv";
            this.soluongnv.Name = "soluongnv";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtghichu);
            this.groupBox2.Controls.Add(this.txtsonv);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.datedenngay);
            this.groupBox2.Controls.Add(this.datetungay);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.txttendt);
            this.groupBox2.Controls.Add(this.txtmadt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 113);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ghi chú";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(554, 16);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(139, 91);
            this.txtghichu.TabIndex = 13;
            // 
            // txtsonv
            // 
            this.txtsonv.Location = new System.Drawing.Point(328, 79);
            this.txtsonv.Name = "txtsonv";
            this.txtsonv.Size = new System.Drawing.Size(141, 22);
            this.txtsonv.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số nv";
            // 
            // datedenngay
            // 
            this.datedenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedenngay.Location = new System.Drawing.Point(328, 48);
            this.datedenngay.Name = "datedenngay";
            this.datedenngay.Size = new System.Drawing.Size(141, 22);
            this.datedenngay.TabIndex = 10;
            // 
            // datetungay
            // 
            this.datetungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetungay.Location = new System.Drawing.Point(328, 16);
            this.datetungay.Name = "datetungay";
            this.datetungay.Size = new System.Drawing.Size(141, 22);
            this.datetungay.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đến ngày";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(88, 79);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(138, 22);
            this.txtdiachi.TabIndex = 7;
            // 
            // txttendt
            // 
            this.txttendt.Location = new System.Drawing.Point(88, 48);
            this.txttendt.Name = "txttendt";
            this.txttendt.Size = new System.Drawing.Size(138, 22);
            this.txttendt.TabIndex = 5;
            // 
            // txtmadt
            // 
            this.txtmadt.Location = new System.Drawing.Point(88, 16);
            this.txtmadt.Name = "txtmadt";
            this.txtmadt.Size = new System.Drawing.Size(138, 22);
            this.txtmadt.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tstxttimkiem,
            this.tsbtimkiem,
            this.tsbthoat,
            this.tsbxemnvdt,
            this.toolStripButton2,
            this.tsbluu});
            this.toolStrip1.Location = new System.Drawing.Point(9, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(710, 41);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Nhansu.Properties.Resources.www;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 38);
            this.toolStripButton1.Text = "Home";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // tsbxemnvdt
            // 
            this.tsbxemnvdt.Image = global::Nhansu.Properties.Resources.xem;
            this.tsbxemnvdt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbxemnvdt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbxemnvdt.Name = "tsbxemnvdt";
            this.tsbxemnvdt.Size = new System.Drawing.Size(165, 38);
            this.tsbxemnvdt.Text = "Danh sách NVĐT";
            this.tsbxemnvdt.Click += new System.EventHandler(this.tsbxemnvdt_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Nhansu.Properties.Resources.add1;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(68, 38);
            this.toolStripButton2.Text = "Add";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            // Daotao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(723, 370);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Daotao";
            this.Text = "Daotao";
            this.Load += new System.EventHandler(this.Daotao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdaotao)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdaotao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttendt;
        private System.Windows.Forms.TextBox txtmadt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tstxttimkiem;
        private System.Windows.Forms.ToolStripButton tsbtimkiem;
        private System.Windows.Forms.ToolStripButton tsbthoat;
        private System.Windows.Forms.ToolStripButton tsbxemnvdt;
        private System.Windows.Forms.DateTimePicker datedenngay;
        private System.Windows.Forms.DateTimePicker datetungay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbluu;
        private System.Windows.Forms.TextBox txtsonv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn madt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tungay;
        private System.Windows.Forms.DataGridViewTextBoxColumn denngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongnv;
    }
}