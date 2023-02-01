
namespace QuanLyKhachSan.Forms
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtcccd = new System.Windows.Forms.TextBox();
            this.txthang = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.dgridKH = new System.Windows.Forms.DataGridView();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.mskngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tenphong = new System.Windows.Forms.Label();
            this.maphong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridKH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(260, 135);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(4);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(200, 22);
            this.txtmakh.TabIndex = 9;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(260, 163);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(200, 22);
            this.txttenkh.TabIndex = 10;
            // 
            // txtcccd
            // 
            this.txtcccd.Location = new System.Drawing.Point(260, 192);
            this.txtcccd.Margin = new System.Windows.Forms.Padding(4);
            this.txtcccd.Name = "txtcccd";
            this.txtcccd.Size = new System.Drawing.Size(200, 22);
            this.txtcccd.TabIndex = 11;
            // 
            // txthang
            // 
            this.txthang.Location = new System.Drawing.Point(260, 218);
            this.txthang.Margin = new System.Windows.Forms.Padding(4);
            this.txthang.Name = "txthang";
            this.txthang.Size = new System.Drawing.Size(200, 22);
            this.txthang.TabIndex = 12;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(634, 162);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(200, 22);
            this.txtdiachi.TabIndex = 14;
            // 
            // dgridKH
            // 
            this.dgridKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridKH.Location = new System.Drawing.Point(102, 285);
            this.dgridKH.Margin = new System.Windows.Forms.Padding(4);
            this.dgridKH.Name = "dgridKH";
            this.dgridKH.RowHeadersWidth = 51;
            this.dgridKH.Size = new System.Drawing.Size(764, 132);
            this.dgridKH.TabIndex = 16;
            this.dgridKH.Click += new System.EventHandler(this.dgridKH_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(204, 434);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(86, 35);
            this.btnsua.TabIndex = 18;
            this.btnsua.Text = "&Sửa KH";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(305, 434);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(86, 35);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.Text = "&Xóa KH";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(580, 434);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(86, 35);
            this.btnluu.TabIndex = 20;
            this.btnluu.Text = "&Lưu KH";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(682, 434);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(4);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(86, 35);
            this.btnboqua.TabIndex = 21;
            this.btnboqua.Text = "&Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(783, 434);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(86, 35);
            this.btndong.TabIndex = 22;
            this.btndong.Text = "&Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // mskngaysinh
            // 
            this.mskngaysinh.Location = new System.Drawing.Point(634, 132);
            this.mskngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.mskngaysinh.Mask = "00/00/0000";
            this.mskngaysinh.Name = "mskngaysinh";
            this.mskngaysinh.Size = new System.Drawing.Size(200, 22);
            this.mskngaysinh.TabIndex = 23;
            this.mskngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(635, 191);
            this.mskdienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(199, 22);
            this.mskdienthoai.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(345, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 32);
            this.label9.TabIndex = 43;
            this.label9.Text = "Thông tin khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Hạng KH:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "Số CCCD/CMTND:";
            // 
            // tenphong
            // 
            this.tenphong.AutoSize = true;
            this.tenphong.Location = new System.Drawing.Point(121, 163);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(106, 16);
            this.tenphong.TabIndex = 45;
            this.tenphong.Text = "Tên khách hàng:";
            // 
            // maphong
            // 
            this.maphong.AutoSize = true;
            this.maphong.Location = new System.Drawing.Point(121, 135);
            this.maphong.Name = "maphong";
            this.maphong.Size = new System.Drawing.Size(101, 16);
            this.maphong.TabIndex = 44;
            this.maphong.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Ngày sinh:";
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.them;
            this.btnthem.Location = new System.Drawing.Point(102, 434);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(86, 35);
            this.btnthem.TabIndex = 17;
            this.btnthem.TabStop = false;
            this.btnthem.Text = "&Thêm KH";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tenphong);
            this.Controls.Add(this.maphong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.mskngaysinh);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgridKH);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txthang);
            this.Controls.Add(this.txtcccd);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.txtmakh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhachHang";
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtcccd;
        private System.Windows.Forms.TextBox txthang;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.DataGridView dgridKH;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.MaskedTextBox mskngaysinh;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tenphong;
        private System.Windows.Forms.Label maphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}