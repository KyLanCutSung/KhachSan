
namespace QuanLyKhachSan.Forms
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.dgridNV = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tenphong = new System.Windows.Forms.Label();
            this.maphong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.cbomabp = new System.Windows.Forms.ComboBox();
            this.chknam = new System.Windows.Forms.CheckBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.mskngaysinh = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridNV
            // 
            this.dgridNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridNV.Location = new System.Drawing.Point(102, 285);
            this.dgridNV.Margin = new System.Windows.Forms.Padding(4);
            this.dgridNV.Name = "dgridNV";
            this.dgridNV.RowHeadersWidth = 51;
            this.dgridNV.Size = new System.Drawing.Size(764, 132);
            this.dgridNV.TabIndex = 8;
            this.dgridNV.Click += new System.EventHandler(this.dgridNV_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(102, 434);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(86, 35);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "&Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(204, 434);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(86, 35);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "&Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(305, 434);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(86, 35);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(580, 434);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(86, 35);
            this.btnluu.TabIndex = 3;
            this.btnluu.Text = "&Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(682, 434);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(4);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(86, 35);
            this.btnboqua.TabIndex = 4;
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
            this.btndong.TabIndex = 5;
            this.btndong.Text = "&Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(357, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "Thông tin nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Giới tính:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 50;
            this.label10.Text = "Tên bộ phận:";
            // 
            // tenphong
            // 
            this.tenphong.AutoSize = true;
            this.tenphong.Location = new System.Drawing.Point(137, 156);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(94, 16);
            this.tenphong.TabIndex = 49;
            this.tenphong.Text = "Tên nhân viên:";
            // 
            // maphong
            // 
            this.maphong.AutoSize = true;
            this.maphong.Location = new System.Drawing.Point(137, 128);
            this.maphong.Name = "maphong";
            this.maphong.Size = new System.Drawing.Size(89, 16);
            this.maphong.TabIndex = 48;
            this.maphong.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(252, 125);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(200, 22);
            this.txtmanv.TabIndex = 8;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(252, 153);
            this.txttennv.Margin = new System.Windows.Forms.Padding(4);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(200, 22);
            this.txttennv.TabIndex = 9;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(595, 122);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(200, 22);
            this.txtdiachi.TabIndex = 12;
            // 
            // cbomabp
            // 
            this.cbomabp.FormattingEnabled = true;
            this.cbomabp.Location = new System.Drawing.Point(252, 182);
            this.cbomabp.Margin = new System.Windows.Forms.Padding(4);
            this.cbomabp.Name = "cbomabp";
            this.cbomabp.Size = new System.Drawing.Size(200, 24);
            this.cbomabp.TabIndex = 15;
            // 
            // chknam
            // 
            this.chknam.AutoSize = true;
            this.chknam.Location = new System.Drawing.Point(252, 214);
            this.chknam.Margin = new System.Windows.Forms.Padding(4);
            this.chknam.Name = "chknam";
            this.chknam.Size = new System.Drawing.Size(58, 20);
            this.chknam.TabIndex = 16;
            this.chknam.Text = "Nam";
            this.chknam.UseVisualStyleBackColor = true;
            this.chknam.CheckedChanged += new System.EventHandler(this.chknam_CheckedChanged);
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(595, 152);
            this.mskdienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(200, 22);
            this.mskdienthoai.TabIndex = 17;
            // 
            // mskngaysinh
            // 
            this.mskngaysinh.Location = new System.Drawing.Point(595, 182);
            this.mskngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.mskngaysinh.Mask = "00/00/0000";
            this.mskngaysinh.Name = "mskngaysinh";
            this.mskngaysinh.Size = new System.Drawing.Size(200, 22);
            this.mskngaysinh.TabIndex = 18;
            this.mskngaysinh.ValidatingType = typeof(System.DateTime);
            this.mskngaysinh.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskngaysinh_MaskInputRejected);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgridNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mskngaysinh);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.chknam);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbomabp);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.tenphong);
            this.Controls.Add(this.maphong);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmanv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.DataGridView dgridNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tenphong;
        private System.Windows.Forms.Label maphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.ComboBox cbomabp;
        private System.Windows.Forms.CheckBox chknam;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.MaskedTextBox mskngaysinh;
    }
}