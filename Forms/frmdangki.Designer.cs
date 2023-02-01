
namespace QuanLyKhachSan.Forms
{
    partial class frmdangki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangki));
            this.btndangki = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblxacnhanmk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtxacnhanmk = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndangki
            // 
            this.btndangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangki.Location = new System.Drawing.Point(177, 395);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(125, 34);
            this.btndangki.TabIndex = 28;
            this.btndangki.Text = "Đăng ký";
            this.btndangki.UseVisualStyleBackColor = true;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email:";
            // 
            // lblxacnhanmk
            // 
            this.lblxacnhanmk.AutoSize = true;
            this.lblxacnhanmk.Location = new System.Drawing.Point(47, 305);
            this.lblxacnhanmk.Name = "lblxacnhanmk";
            this.lblxacnhanmk.Size = new System.Drawing.Size(122, 16);
            this.lblxacnhanmk.TabIndex = 26;
            this.lblxacnhanmk.Text = "Xác nhận mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(187, 342);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 22);
            this.txtemail.TabIndex = 23;
            // 
            // txtxacnhanmk
            // 
            this.txtxacnhanmk.Location = new System.Drawing.Point(187, 302);
            this.txtxacnhanmk.Name = "txtxacnhanmk";
            this.txtxacnhanmk.PasswordChar = '*';
            this.txtxacnhanmk.Size = new System.Drawing.Size(200, 22);
            this.txtxacnhanmk.TabIndex = 22;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(187, 259);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(200, 22);
            this.txtmatkhau.TabIndex = 21;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(187, 218);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(200, 22);
            this.txttendangnhap.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.user_icons;
            this.pictureBox1.Location = new System.Drawing.Point(143, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmdangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblxacnhanmk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtxacnhanmk);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdangki";
            this.Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblxacnhanmk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtxacnhanmk;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}