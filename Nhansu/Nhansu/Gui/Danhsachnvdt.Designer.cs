namespace Nhansu.Gui
{
    partial class Danhsachnvdt
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
            this.dgvnvdt = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbthoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbluu = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbmanv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butchon = new System.Windows.Forms.Button();
            this.tsbuttimkiem = new System.Windows.Forms.ToolStripButton();
            this.tstxttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.cbbmadt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttendt = new System.Windows.Forms.TextBox();
            this.madt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnvdt)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox1.Controls.Add(this.dgvnvdt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(77, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgvnvdt
            // 
            this.dgvnvdt.BackgroundColor = System.Drawing.Color.White;
            this.dgvnvdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnvdt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madt,
            this.tendt,
            this.manv,
            this.tennv});
            this.dgvnvdt.Location = new System.Drawing.Point(6, 19);
            this.dgvnvdt.Name = "dgvnvdt";
            this.dgvnvdt.Size = new System.Drawing.Size(477, 175);
            this.dgvnvdt.TabIndex = 0;
            this.dgvnvdt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnvdt_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbthoat,
            this.toolStripButton2,
            this.tsbluu,
            this.tstxttimkiem,
            this.tsbuttimkiem});
            this.toolStrip1.Location = new System.Drawing.Point(83, 13);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(434, 41);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã nhân viên";
            // 
            // cbbmanv
            // 
            this.cbbmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmanv.FormattingEnabled = true;
            this.cbbmanv.Location = new System.Drawing.Point(230, 127);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(153, 24);
            this.cbbmanv.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mã đào tạo";
            // 
            // txttennv
            // 
            this.txttennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennv.Location = new System.Drawing.Point(230, 157);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(153, 22);
            this.txttennv.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên nhân viên";
            // 
            // butchon
            // 
            this.butchon.Location = new System.Drawing.Point(389, 91);
            this.butchon.Name = "butchon";
            this.butchon.Size = new System.Drawing.Size(43, 23);
            this.butchon.TabIndex = 28;
            this.butchon.Text = "Chọn";
            this.butchon.UseVisualStyleBackColor = true;
            this.butchon.Click += new System.EventHandler(this.button1_Click);
            // 
            // tsbuttimkiem
            // 
            this.tsbuttimkiem.Image = global::Nhansu.Properties.Resources.timkiem;
            this.tsbuttimkiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbuttimkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbuttimkiem.Name = "tsbuttimkiem";
            this.tsbuttimkiem.Size = new System.Drawing.Size(112, 38);
            this.tsbuttimkiem.Text = "Tìm kiếm";
            this.tsbuttimkiem.Click += new System.EventHandler(this.tsbuttimkiem_Click);
            // 
            // tstxttimkiem
            // 
            this.tstxttimkiem.Name = "tstxttimkiem";
            this.tstxttimkiem.Size = new System.Drawing.Size(100, 41);
            this.tstxttimkiem.Click += new System.EventHandler(this.tstxttimkiem_Click);
            // 
            // cbbmadt
            // 
            this.cbbmadt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmadt.FormattingEnabled = true;
            this.cbbmadt.Location = new System.Drawing.Point(230, 55);
            this.cbbmadt.Name = "cbbmadt";
            this.cbbmadt.Size = new System.Drawing.Size(153, 24);
            this.cbbmadt.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tên đào tạo";
            // 
            // txttendt
            // 
            this.txttendt.Location = new System.Drawing.Point(230, 93);
            this.txttendt.Name = "txttendt";
            this.txttendt.Size = new System.Drawing.Size(153, 20);
            this.txttendt.TabIndex = 31;
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
            // Danhsachnvdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(658, 397);
            this.Controls.Add(this.txttendt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbmadt);
            this.Controls.Add(this.butchon);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbmanv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Danhsachnvdt";
            this.Text = "Danhsachnvdt";
            this.Load += new System.EventHandler(this.Danhsachnvdt_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnvdt)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvnvdt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbthoat;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbluu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbmanv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butchon;
        private System.Windows.Forms.ToolStripTextBox tstxttimkiem;
        private System.Windows.Forms.ToolStripButton tsbuttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn madt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendt;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.ComboBox cbbmadt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttendt;
    }
}