namespace Nhansu.Gui
{
    partial class Login
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
            this.labpass = new System.Windows.Forms.Label();
            this.cbxhienthipass = new System.Windows.Forms.CheckBox();
            this.labusername = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.butthoat = new System.Windows.Forms.Button();
            this.butdangnhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Nhansu.Properties.Resources.afsadfdafdfaf;
            this.groupBox1.Controls.Add(this.labpass);
            this.groupBox1.Controls.Add(this.cbxhienthipass);
            this.groupBox1.Controls.Add(this.labusername);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 109);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // labpass
            // 
            this.labpass.AutoSize = true;
            this.labpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpass.Location = new System.Drawing.Point(57, 54);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(63, 16);
            this.labpass.TabIndex = 1;
            this.labpass.Text = "Mật Khẩu";
            // 
            // cbxhienthipass
            // 
            this.cbxhienthipass.AutoSize = true;
            this.cbxhienthipass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxhienthipass.Location = new System.Drawing.Point(129, 76);
            this.cbxhienthipass.Name = "cbxhienthipass";
            this.cbxhienthipass.Size = new System.Drawing.Size(128, 20);
            this.cbxhienthipass.TabIndex = 8;
            this.cbxhienthipass.Text = "Hiển thị mật khẩu";
            this.cbxhienthipass.UseVisualStyleBackColor = true;
            this.cbxhienthipass.CheckedChanged += new System.EventHandler(this.cbxhienthipass_CheckedChanged);
            // 
            // labusername
            // 
            this.labusername.AutoSize = true;
            this.labusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labusername.Location = new System.Drawing.Point(57, 25);
            this.labusername.Name = "labusername";
            this.labusername.Size = new System.Drawing.Size(103, 16);
            this.labusername.TabIndex = 0;
            this.labusername.Text = "Tên Đăng Nhập";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(207, 50);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(137, 22);
            this.txtpass.TabIndex = 3;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(207, 19);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(137, 22);
            this.txtusername.TabIndex = 2;
            // 
            // butthoat
            // 
            this.butthoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthoat.Image = global::Nhansu.Properties.Resources.tao_icon_shutdown_hoac_restart_ngoai_desktop_1;
            this.butthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butthoat.Location = new System.Drawing.Point(261, 249);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(111, 37);
            this.butthoat.TabIndex = 12;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = false;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butdangnhap
            // 
            this.butdangnhap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdangnhap.Image = global::Nhansu.Properties.Resources.QLNhanvien;
            this.butdangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butdangnhap.Location = new System.Drawing.Point(36, 249);
            this.butdangnhap.Name = "butdangnhap";
            this.butdangnhap.Size = new System.Drawing.Size(112, 37);
            this.butdangnhap.TabIndex = 11;
            this.butdangnhap.Text = "      Đăng Nhập";
            this.butdangnhap.UseVisualStyleBackColor = false;
            this.butdangnhap.Click += new System.EventHandler(this.butdangnhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nhansu.Properties.Resources.đăng_nahapj2;
            this.pictureBox1.Location = new System.Drawing.Point(35, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 102);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhansu.Properties.Resources.chechunag;
            this.ClientSize = new System.Drawing.Size(480, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butdangnhap);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labpass;
        private System.Windows.Forms.CheckBox cbxhienthipass;
        private System.Windows.Forms.Label labusername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butdangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}