namespace Nhansu.Gui
{
    partial class Trinhdo
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
            this.tsbhome = new System.Windows.Forms.ToolStripButton();
            this.tstxttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtimkiem = new System.Windows.Forms.ToolStripButton();
            this.tsbthoat = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvtrinhdo = new System.Windows.Forms.DataGridView();
            this.matd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbtimkiem = new System.Windows.Forms.GroupBox();
            this.txttentd = new System.Windows.Forms.TextBox();
            this.labtentd = new System.Windows.Forms.Label();
            this.labmatd = new System.Windows.Forms.Label();
            this.txtmatd = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrinhdo)).BeginInit();
            this.grbtimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbhome,
            this.tstxttimkiem,
            this.tsbtimkiem,
            this.tsbthoat});
            this.toolStrip1.Location = new System.Drawing.Point(89, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(404, 41);
            this.toolStrip1.TabIndex = 55;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbhome
            // 
            this.tsbhome.Image = global::Nhansu.Properties.Resources.www;
            this.tsbhome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbhome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbhome.Name = "tsbhome";
            this.tsbhome.Size = new System.Drawing.Size(78, 38);
            this.tsbhome.Text = "Home";
            this.tsbhome.Click += new System.EventHandler(this.tsbhome_Click);
            // 
            // tstxttimkiem
            // 
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
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox1.Controls.Add(this.dgvtrinhdo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(129, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 164);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trình độ học vấn";
            // 
            // dgvtrinhdo
            // 
            this.dgvtrinhdo.BackgroundColor = System.Drawing.Color.White;
            this.dgvtrinhdo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtrinhdo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matd,
            this.tentd});
            this.dgvtrinhdo.Location = new System.Drawing.Point(11, 21);
            this.dgvtrinhdo.Name = "dgvtrinhdo";
            this.dgvtrinhdo.Size = new System.Drawing.Size(281, 128);
            this.dgvtrinhdo.TabIndex = 7;
            this.dgvtrinhdo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtrinhdo_CellContentClick);
            // 
            // matd
            // 
            this.matd.DataPropertyName = "matd";
            this.matd.HeaderText = "Mã Trình Độ";
            this.matd.Name = "matd";
            // 
            // tentd
            // 
            this.tentd.DataPropertyName = "tentd";
            this.tentd.HeaderText = "Tên trình độ";
            this.tentd.Name = "tentd";
            // 
            // grbtimkiem
            // 
            this.grbtimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbtimkiem.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.grbtimkiem.Controls.Add(this.txttentd);
            this.grbtimkiem.Controls.Add(this.labtentd);
            this.grbtimkiem.Controls.Add(this.labmatd);
            this.grbtimkiem.Controls.Add(this.txtmatd);
            this.grbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtimkiem.Location = new System.Drawing.Point(51, 66);
            this.grbtimkiem.Name = "grbtimkiem";
            this.grbtimkiem.Size = new System.Drawing.Size(469, 52);
            this.grbtimkiem.TabIndex = 53;
            this.grbtimkiem.TabStop = false;
            this.grbtimkiem.Text = "Danh mục";
            // 
            // txttentd
            // 
            this.txttentd.Location = new System.Drawing.Point(335, 17);
            this.txttentd.Name = "txttentd";
            this.txttentd.Size = new System.Drawing.Size(128, 22);
            this.txttentd.TabIndex = 1;
            // 
            // labtentd
            // 
            this.labtentd.AutoSize = true;
            this.labtentd.ForeColor = System.Drawing.Color.Black;
            this.labtentd.Location = new System.Drawing.Point(241, 23);
            this.labtentd.Name = "labtentd";
            this.labtentd.Size = new System.Drawing.Size(91, 16);
            this.labtentd.TabIndex = 4;
            this.labtentd.Text = "Tên Trình Độ :";
            // 
            // labmatd
            // 
            this.labmatd.AutoSize = true;
            this.labmatd.ForeColor = System.Drawing.Color.Black;
            this.labmatd.Location = new System.Drawing.Point(6, 23);
            this.labmatd.Name = "labmatd";
            this.labmatd.Size = new System.Drawing.Size(86, 16);
            this.labmatd.TabIndex = 3;
            this.labmatd.Text = "Mã Trình Độ :";
            // 
            // txtmatd
            // 
            this.txtmatd.Location = new System.Drawing.Point(108, 17);
            this.txtmatd.Name = "txtmatd";
            this.txtmatd.Size = new System.Drawing.Size(92, 22);
            this.txtmatd.TabIndex = 0;
            // 
            // Trinhdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(593, 315);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbtimkiem);
            this.Name = "Trinhdo";
            this.Text = "Trinhdo";
            this.Load += new System.EventHandler(this.Trinhdo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrinhdo)).EndInit();
            this.grbtimkiem.ResumeLayout(false);
            this.grbtimkiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbhome;
        private System.Windows.Forms.ToolStripTextBox tstxttimkiem;
        private System.Windows.Forms.ToolStripButton tsbtimkiem;
        private System.Windows.Forms.ToolStripButton tsbthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvtrinhdo;
        private System.Windows.Forms.GroupBox grbtimkiem;
        private System.Windows.Forms.TextBox txttentd;
        private System.Windows.Forms.Label labtentd;
        private System.Windows.Forms.Label labmatd;
        private System.Windows.Forms.TextBox txtmatd;
        private System.Windows.Forms.DataGridViewTextBoxColumn matd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentd;
    }
}