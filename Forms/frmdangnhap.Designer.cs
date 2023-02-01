
namespace QuanLyKhachSan.Forms
{
    partial class frmdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangnhap));
            this.linklbldangki = new System.Windows.Forms.LinkLabel();
            this.linklblquenmatkhau = new System.Windows.Forms.LinkLabel();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linklbldangki
            // 
            this.linklbldangki.AutoSize = true;
            this.linklbldangki.Location = new System.Drawing.Point(302, 358);
            this.linklbldangki.Name = "linklbldangki";
            this.linklbldangki.Size = new System.Drawing.Size(113, 16);
            this.linklbldangki.TabIndex = 19;
            this.linklbldangki.TabStop = true;
            this.linklbldangki.Text = "Đăng ký tài khoản";
            this.linklbldangki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbldangki_LinkClicked);
            // 
            // linklblquenmatkhau
            // 
            this.linklblquenmatkhau.AutoSize = true;
            this.linklblquenmatkhau.Location = new System.Drawing.Point(73, 358);
            this.linklblquenmatkhau.Name = "linklblquenmatkhau";
            this.linklblquenmatkhau.Size = new System.Drawing.Size(96, 16);
            this.linklblquenmatkhau.TabIndex = 20;
            this.linklblquenmatkhau.TabStop = true;
            this.linklblquenmatkhau.Text = "Quên mật khẩu";
            this.linklblquenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblquenmatkhau_LinkClicked);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(162, 298);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(200, 22);
            this.txtmatkhau.TabIndex = 18;
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(162, 233);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(200, 22);
            this.txttaikhoan.TabIndex = 16;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyKhachSan.Properties.Resources.png_clipart_password_computer_icons_user_the_plain_style_miscellaneous_area;
            this.pictureBox3.Location = new System.Drawing.Point(92, 289);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::QuanLyKhachSan.Properties.Resources.kisspng_computer_icons_google_account_icon_design_login_5afc02dab4a218_0950785215264652427399;
            this.pictureBox2.Location = new System.Drawing.Point(92, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.user_icons;
            this.pictureBox1.Location = new System.Drawing.Point(146, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(182, 394);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(125, 37);
            this.btndangnhap.TabIndex = 21;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.linklbldangki);
            this.Controls.Add(this.linklblquenmatkhau);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdangnhap";
            this.Text = "Đăng nhập tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linklbldangki;
        private System.Windows.Forms.LinkLabel linklblquenmatkhau;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndangnhap;
    }
}