namespace QuanLyKhachSan.Forms
{
    partial class frmPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgvthongtincacphongkhachsan = new System.Windows.Forms.DataGridView();
            this.cbbmaloaigiuong = new System.Windows.Forms.ComboBox();
            this.cbbmaloaiphong = new System.Windows.Forms.ComboBox();
            this.cbbmadaynha = new System.Windows.Forms.ComboBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.txtdongiangay = new System.Windows.Forms.TextBox();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tenphong = new System.Windows.Forms.Label();
            this.maphong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtincacphongkhachsan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(623, 372);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(86, 35);
            this.btnthoat.TabIndex = 47;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(522, 372);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(86, 35);
            this.btnboqua.TabIndex = 46;
            this.btnboqua.Text = "Hủy";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(420, 372);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(86, 35);
            this.btnluu.TabIndex = 45;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(298, 372);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(86, 35);
            this.btnxoa.TabIndex = 44;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(197, 372);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(86, 35);
            this.btnsua.TabIndex = 43;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnthem.Location = new System.Drawing.Point(95, 372);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(86, 35);
            this.btnthem.TabIndex = 42;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvthongtincacphongkhachsan
            // 
            this.dgvthongtincacphongkhachsan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongtincacphongkhachsan.Location = new System.Drawing.Point(95, 240);
            this.dgvthongtincacphongkhachsan.Name = "dgvthongtincacphongkhachsan";
            this.dgvthongtincacphongkhachsan.RowHeadersWidth = 51;
            this.dgvthongtincacphongkhachsan.RowTemplate.Height = 24;
            this.dgvthongtincacphongkhachsan.Size = new System.Drawing.Size(614, 115);
            this.dgvthongtincacphongkhachsan.TabIndex = 41;
            this.dgvthongtincacphongkhachsan.Click += new System.EventHandler(this.dgvthongtincacphongkhachsan_Click);
            // 
            // cbbmaloaigiuong
            // 
            this.cbbmaloaigiuong.FormattingEnabled = true;
            this.cbbmaloaigiuong.Location = new System.Drawing.Point(572, 165);
            this.cbbmaloaigiuong.Name = "cbbmaloaigiuong";
            this.cbbmaloaigiuong.Size = new System.Drawing.Size(137, 24);
            this.cbbmaloaigiuong.TabIndex = 40;
            // 
            // cbbmaloaiphong
            // 
            this.cbbmaloaiphong.FormattingEnabled = true;
            this.cbbmaloaiphong.Location = new System.Drawing.Point(572, 137);
            this.cbbmaloaiphong.Name = "cbbmaloaiphong";
            this.cbbmaloaiphong.Size = new System.Drawing.Size(137, 24);
            this.cbbmaloaiphong.TabIndex = 39;
            // 
            // cbbmadaynha
            // 
            this.cbbmadaynha.FormattingEnabled = true;
            this.cbbmadaynha.Location = new System.Drawing.Point(572, 107);
            this.cbbmadaynha.Name = "cbbmadaynha";
            this.cbbmadaynha.Size = new System.Drawing.Size(137, 24);
            this.cbbmadaynha.TabIndex = 38;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(542, 197);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(167, 22);
            this.txtghichu.TabIndex = 37;
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(235, 193);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(137, 22);
            this.txttinhtrang.TabIndex = 36;
            // 
            // txtdongiangay
            // 
            this.txtdongiangay.Location = new System.Drawing.Point(235, 165);
            this.txtdongiangay.Name = "txtdongiangay";
            this.txtdongiangay.Size = new System.Drawing.Size(137, 22);
            this.txtdongiangay.TabIndex = 35;
            this.txtdongiangay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongiangay_KeyPress);
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(235, 137);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(137, 22);
            this.txttenphong.TabIndex = 34;
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(235, 109);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(137, 22);
            this.txtmaphong.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ghi chú:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Mã loại gường:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Mã loại phòng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Mã dãy nhà:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Đơn giá ngày:";
            // 
            // tenphong
            // 
            this.tenphong.AutoSize = true;
            this.tenphong.Location = new System.Drawing.Point(92, 139);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(75, 16);
            this.tenphong.TabIndex = 26;
            this.tenphong.Text = "Tên phòng:";
            // 
            // maphong
            // 
            this.maphong.AutoSize = true;
            this.maphong.Location = new System.Drawing.Point(92, 111);
            this.maphong.Name = "maphong";
            this.maphong.Size = new System.Drawing.Size(70, 16);
            this.maphong.TabIndex = 25;
            this.maphong.Text = "Mã phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thông tin các phòng";
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvthongtincacphongkhachsan);
            this.Controls.Add(this.cbbmaloaigiuong);
            this.Controls.Add(this.cbbmaloaiphong);
            this.Controls.Add(this.cbbmadaynha);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.txttinhtrang);
            this.Controls.Add(this.txtdongiangay);
            this.Controls.Add(this.txttenphong);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tenphong);
            this.Controls.Add(this.maphong);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhong";
            this.Text = "Thông tin các phòng";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtincacphongkhachsan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgvthongtincacphongkhachsan;
        private System.Windows.Forms.ComboBox cbbmaloaigiuong;
        private System.Windows.Forms.ComboBox cbbmaloaiphong;
        private System.Windows.Forms.ComboBox cbbmadaynha;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.TextBox txtdongiangay;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tenphong;
        private System.Windows.Forms.Label maphong;
        private System.Windows.Forms.Label label1;
    }
}