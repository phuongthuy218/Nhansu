namespace Nhansu.Gui
{
    partial class Kyluat
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvkyluat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labmanv = new System.Windows.Forms.Label();
            this.datengaykl = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlydo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthinhthuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbmanv = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_add = new System.Windows.Forms.ToolStripButton();
            this.tbs_edit = new System.Windows.Forms.ToolStripButton();
            this.tbs_save = new System.Windows.Forms.ToolStripButton();
            this.tbs_delete = new System.Windows.Forms.ToolStripButton();
            this.tstxttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tbs_search = new System.Windows.Forms.ToolStripButton();
            this.tbs_exit = new System.Windows.Forms.ToolStripButton();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lydo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkyluat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox2.Controls.Add(this.dgvkyluat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 186);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin kỷ luật";
            // 
            // dgvkyluat
            // 
            this.dgvkyluat.BackgroundColor = System.Drawing.Color.White;
            this.dgvkyluat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkyluat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.ngaykl,
            this.hinhthuc,
            this.lydo});
            this.dgvkyluat.Location = new System.Drawing.Point(6, 19);
            this.dgvkyluat.Name = "dgvkyluat";
            this.dgvkyluat.Size = new System.Drawing.Size(560, 161);
            this.dgvkyluat.TabIndex = 0;
            this.dgvkyluat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkyluat_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox1.Controls.Add(this.labmanv);
            this.groupBox1.Controls.Add(this.datengaykl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtlydo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txthinhthuc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbmanv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 90);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục";
            // 
            // labmanv
            // 
            this.labmanv.AutoSize = true;
            this.labmanv.Location = new System.Drawing.Point(9, 25);
            this.labmanv.Name = "labmanv";
            this.labmanv.Size = new System.Drawing.Size(87, 16);
            this.labmanv.TabIndex = 0;
            this.labmanv.Text = "Mã nhân viên";
            // 
            // datengaykl
            // 
            this.datengaykl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaykl.Location = new System.Drawing.Point(104, 62);
            this.datengaykl.Name = "datengaykl";
            this.datengaykl.Size = new System.Drawing.Size(154, 22);
            this.datengaykl.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày kỷ luật";
            // 
            // txtlydo
            // 
            this.txtlydo.Location = new System.Drawing.Point(365, 56);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(154, 22);
            this.txtlydo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình thức";
            // 
            // txthinhthuc
            // 
            this.txthinhthuc.Location = new System.Drawing.Point(365, 11);
            this.txthinhthuc.Name = "txthinhthuc";
            this.txthinhthuc.Size = new System.Drawing.Size(154, 22);
            this.txthinhthuc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lý do";
            // 
            // cbbmanv
            // 
            this.cbbmanv.FormattingEnabled = true;
            this.cbbmanv.Location = new System.Drawing.Point(104, 17);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(154, 24);
            this.cbbmanv.TabIndex = 4;
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
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            // 
            // ngaykl
            // 
            this.ngaykl.DataPropertyName = "ngaykl";
            this.ngaykl.HeaderText = "Ngày kỷ luật";
            this.ngaykl.Name = "ngaykl";
            // 
            // hinhthuc
            // 
            this.hinhthuc.DataPropertyName = "hinhthuc";
            this.hinhthuc.HeaderText = "Hình thức";
            this.hinhthuc.Name = "hinhthuc";
            // 
            // lydo
            // 
            this.lydo.DataPropertyName = "lydo";
            this.lydo.HeaderText = "lý do";
            this.lydo.Name = "lydo";
            // 
            // Kyluat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(692, 359);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kyluat";
            this.Text = "Kyluat";
            this.Load += new System.EventHandler(this.Kyluat_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkyluat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvkyluat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labmanv;
        private System.Windows.Forms.DateTimePicker datengaykl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlydo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthinhthuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbmanv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_add;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripButton tbs_delete;
        private System.Windows.Forms.ToolStripTextBox tstxttimkiem;
        private System.Windows.Forms.ToolStripButton tbs_search;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykl;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn lydo;
    }
}