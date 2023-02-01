
namespace QuanLyKhachSan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiGườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dãyNhàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBophan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDichvu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNghiepvu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuedichvu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDTT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutkNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.thuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhmuc,
            this.mnuNghiepvu,
            this.mnuTimkiem,
            this.mnuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1186, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPhong,
            this.mnuKhachhang,
            this.mnuNhanvien,
            this.mnuBophan,
            this.mnuDichvu});
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhmuc.Text = "Danh Mục";
            // 
            // mnuPhong
            // 
            this.mnuPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiPhòngToolStripMenuItem,
            this.loạiGườngToolStripMenuItem,
            this.dãyNhàToolStripMenuItem});
            this.mnuPhong.Name = "mnuPhong";
            this.mnuPhong.Size = new System.Drawing.Size(169, 26);
            this.mnuPhong.Text = "Phòng";
            this.mnuPhong.Click += new System.EventHandler(this.mnuPhong_Click);
            // 
            // loạiPhòngToolStripMenuItem
            // 
            this.loạiPhòngToolStripMenuItem.Name = "loạiPhòngToolStripMenuItem";
            this.loạiPhòngToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.loạiPhòngToolStripMenuItem.Text = "Loại phòng";
            this.loạiPhòngToolStripMenuItem.Click += new System.EventHandler(this.loạiPhòngToolStripMenuItem_Click);
            // 
            // loạiGườngToolStripMenuItem
            // 
            this.loạiGườngToolStripMenuItem.Name = "loạiGườngToolStripMenuItem";
            this.loạiGườngToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.loạiGườngToolStripMenuItem.Text = "Loại gường";
            this.loạiGườngToolStripMenuItem.Click += new System.EventHandler(this.loạiGườngToolStripMenuItem_Click);
            // 
            // dãyNhàToolStripMenuItem
            // 
            this.dãyNhàToolStripMenuItem.Name = "dãyNhàToolStripMenuItem";
            this.dãyNhàToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.dãyNhàToolStripMenuItem.Text = "Dãy nhà";
            this.dãyNhàToolStripMenuItem.Click += new System.EventHandler(this.dãyNhàToolStripMenuItem_Click);
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(169, 26);
            this.mnuKhachhang.Text = "Khách hàng";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click);
            // 
            // mnuNhanvien
            // 
            this.mnuNhanvien.Name = "mnuNhanvien";
            this.mnuNhanvien.Size = new System.Drawing.Size(169, 26);
            this.mnuNhanvien.Text = "Nhân viên";
            this.mnuNhanvien.Click += new System.EventHandler(this.mnuNhanvien_Click);
            // 
            // mnuBophan
            // 
            this.mnuBophan.Name = "mnuBophan";
            this.mnuBophan.Size = new System.Drawing.Size(169, 26);
            this.mnuBophan.Text = "Bộ phận";
            this.mnuBophan.Click += new System.EventHandler(this.mnuBophan_Click);
            // 
            // mnuDichvu
            // 
            this.mnuDichvu.Name = "mnuDichvu";
            this.mnuDichvu.Size = new System.Drawing.Size(169, 26);
            this.mnuDichvu.Text = "Dịch vụ";
            this.mnuDichvu.Click += new System.EventHandler(this.mnuDichvu_Click);
            // 
            // mnuNghiepvu
            // 
            this.mnuNghiepvu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThuedichvu,
            this.mnuHDTT,
            this.mnuHDN,
            this.thuêPhòngToolStripMenuItem});
            this.mnuNghiepvu.Name = "mnuNghiepvu";
            this.mnuNghiepvu.Size = new System.Drawing.Size(91, 24);
            this.mnuNghiepvu.Text = "Nghiệp vụ";
            // 
            // mnuThuedichvu
            // 
            this.mnuThuedichvu.Name = "mnuThuedichvu";
            this.mnuThuedichvu.Size = new System.Drawing.Size(236, 26);
            this.mnuThuedichvu.Text = "Thanh toán dịch vụ";
            this.mnuThuedichvu.Click += new System.EventHandler(this.mnuThuedichvu_Click);
            // 
            // mnuHDTT
            // 
            this.mnuHDTT.Name = "mnuHDTT";
            this.mnuHDTT.Size = new System.Drawing.Size(236, 26);
            this.mnuHDTT.Text = "HĐ thanh toán phòng";
            this.mnuHDTT.Click += new System.EventHandler(this.mnuHDTT_Click);
            // 
            // mnuHDN
            // 
            this.mnuHDN.Name = "mnuHDN";
            this.mnuHDN.Size = new System.Drawing.Size(236, 26);
            this.mnuHDN.Text = "Doanh thu khách sạn";
            this.mnuHDN.Click += new System.EventHandler(this.mnuHDN_Click);
            // 
            // mnuTimkiem
            // 
            this.mnuTimkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutkNhanVien,
            this.mnuTKKH,
            this.mnuTimPhong});
            this.mnuTimkiem.Image = global::QuanLyKhachSan.Properties.Resources.magnifyingglass_23798;
            this.mnuTimkiem.Name = "mnuTimkiem";
            this.mnuTimkiem.Size = new System.Drawing.Size(106, 24);
            this.mnuTimkiem.Text = "Tìm Kiếm";
            // 
            // mnutkNhanVien
            // 
            this.mnutkNhanVien.Name = "mnutkNhanVien";
            this.mnutkNhanVien.Size = new System.Drawing.Size(196, 26);
            this.mnutkNhanVien.Text = "Tìm nhân viên";
            this.mnutkNhanVien.Click += new System.EventHandler(this.mnutkNhanVien_Click);
            // 
            // mnuTKKH
            // 
            this.mnuTKKH.Name = "mnuTKKH";
            this.mnuTKKH.Size = new System.Drawing.Size(196, 26);
            this.mnuTKKH.Text = "Tìm khách hàng";
            this.mnuTKKH.Click += new System.EventHandler(this.mnuTKKH_Click);
            // 
            // mnuTimPhong
            // 
            this.mnuTimPhong.Name = "mnuTimPhong";
            this.mnuTimPhong.Size = new System.Drawing.Size(196, 26);
            this.mnuTimPhong.Text = "Tìm phòng";
            this.mnuTimPhong.Click += new System.EventHandler(this.mnuTimPhong_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(61, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Location = new System.Drawing.Point(851, 768);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(219, 50);
            this.button7.TabIndex = 14;
            this.button7.Text = "ĐĂNG XUẤT";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.a;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(626, 768);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 50);
            this.button6.TabIndex = 13;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Untitled_6;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(421, 707);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(649, 55);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Untitled_5;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(859, 576);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 125);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Untitled_4;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(637, 576);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 125);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Untitled_3;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(410, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 125);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.i;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(92, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 196);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thuêPhòngToolStripMenuItem
            // 
            this.thuêPhòngToolStripMenuItem.Name = "thuêPhòngToolStripMenuItem";
            this.thuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.thuêPhòngToolStripMenuItem.Text = "thuê phòng";
            this.thuêPhòngToolStripMenuItem.Click += new System.EventHandler(this.thuêPhòngToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.home32;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 928);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý khách sạn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnuBophan;
        private System.Windows.Forms.ToolStripMenuItem mnuDichvu;
        private System.Windows.Forms.ToolStripMenuItem mnuNghiepvu;
        private System.Windows.Forms.ToolStripMenuItem mnuThuedichvu;
        private System.Windows.Forms.ToolStripMenuItem mnuHDTT;
        private System.Windows.Forms.ToolStripMenuItem mnuHDN;
        private System.Windows.Forms.ToolStripMenuItem mnuTimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnutkNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTKKH;
        private System.Windows.Forms.ToolStripMenuItem mnuTimPhong;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem loạiPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiGườngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dãyNhàToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuêPhòngToolStripMenuItem;
    }
}

