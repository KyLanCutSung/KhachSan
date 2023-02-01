
namespace QuanLyKhachSan.Forms
{
    partial class frmThanhToanPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToanPhong));
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.txtTienphong = new System.Windows.Forms.TextBox();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            this.txtMasothue = new System.Windows.Forms.TextBox();
            this.cboManhanvien = new System.Windows.Forms.ComboBox();
            this.txtCantra = new System.Windows.Forms.TextBox();
            this.txtTiendichvu = new System.Windows.Forms.TextBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTailai = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.dgridThanhtoan = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tenphong = new System.Windows.Forms.Label();
            this.maphong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridThanhtoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Location = new System.Drawing.Point(302, 183);
            this.txtTenkhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(160, 22);
            this.txtTenkhach.TabIndex = 48;
            // 
            // txtTienphong
            // 
            this.txtTienphong.Location = new System.Drawing.Point(302, 213);
            this.txtTienphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienphong.Name = "txtTienphong";
            this.txtTienphong.Size = new System.Drawing.Size(160, 22);
            this.txtTienphong.TabIndex = 47;
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(302, 153);
            this.txtMakhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(160, 22);
            this.txtMakhach.TabIndex = 46;
            this.txtMakhach.TextChanged += new System.EventHandler(this.txtMakhach_TextChanged);
            // 
            // txtMasothue
            // 
            this.txtMasothue.Location = new System.Drawing.Point(302, 124);
            this.txtMasothue.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasothue.Name = "txtMasothue";
            this.txtMasothue.Size = new System.Drawing.Size(160, 22);
            this.txtMasothue.TabIndex = 45;
            // 
            // cboManhanvien
            // 
            this.cboManhanvien.FormattingEnabled = true;
            this.cboManhanvien.Location = new System.Drawing.Point(615, 122);
            this.cboManhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.cboManhanvien.Name = "cboManhanvien";
            this.cboManhanvien.Size = new System.Drawing.Size(160, 24);
            this.cboManhanvien.TabIndex = 44;
            // 
            // txtCantra
            // 
            this.txtCantra.Location = new System.Drawing.Point(615, 215);
            this.txtCantra.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantra.Name = "txtCantra";
            this.txtCantra.Size = new System.Drawing.Size(160, 22);
            this.txtCantra.TabIndex = 43;
            // 
            // txtTiendichvu
            // 
            this.txtTiendichvu.Location = new System.Drawing.Point(615, 185);
            this.txtTiendichvu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiendichvu.Name = "txtTiendichvu";
            this.txtTiendichvu.Size = new System.Drawing.Size(160, 22);
            this.txtTiendichvu.TabIndex = 42;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(615, 154);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(160, 22);
            this.txtMaphong.TabIndex = 41;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(767, 466);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 35);
            this.btnDong.TabIndex = 40;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTailai
            // 
            this.btnTailai.Location = new System.Drawing.Point(673, 466);
            this.btnTailai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTailai.Name = "btnTailai";
            this.btnTailai.Size = new System.Drawing.Size(86, 35);
            this.btnTailai.TabIndex = 39;
            this.btnTailai.Text = "Tải lại";
            this.btnTailai.UseVisualStyleBackColor = true;
            this.btnTailai.Click += new System.EventHandler(this.btnTailai_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(233, 466);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(86, 35);
            this.btnIn.TabIndex = 38;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.Location = new System.Drawing.Point(126, 466);
            this.btnTinhtien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(86, 35);
            this.btnTinhtien.TabIndex = 37;
            this.btnTinhtien.Text = "Tính tiền";
            this.btnTinhtien.UseVisualStyleBackColor = true;
            this.btnTinhtien.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // dgridThanhtoan
            // 
            this.dgridThanhtoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridThanhtoan.Location = new System.Drawing.Point(126, 297);
            this.dgridThanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.dgridThanhtoan.Name = "dgridThanhtoan";
            this.dgridThanhtoan.RowHeadersWidth = 51;
            this.dgridThanhtoan.Size = new System.Drawing.Size(727, 134);
            this.dgridThanhtoan.TabIndex = 36;
            this.dgridThanhtoan.Click += new System.EventHandler(this.dgridThanhtoan_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(364, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 32);
            this.label12.TabIndex = 49;
            this.label12.Text = "Thanh toán phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tiền phòng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Tên khách hàng:";
            // 
            // tenphong
            // 
            this.tenphong.AutoSize = true;
            this.tenphong.Location = new System.Drawing.Point(186, 153);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(109, 17);
            this.tenphong.TabIndex = 51;
            this.tenphong.Text = "Mã khách hàng:";
            // 
            // maphong
            // 
            this.maphong.AutoSize = true;
            this.maphong.Location = new System.Drawing.Point(186, 125);
            this.maphong.Name = "maphong";
            this.maphong.Size = new System.Drawing.Size(82, 17);
            this.maphong.TabIndex = 50;
            this.maphong.Text = "Mã số thuế:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Cần trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tiền dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Mã phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Mã nhân viên:";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnthanhtoan.Location = new System.Drawing.Point(352, 466);
            this.btnthanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(130, 35);
            this.btnthanhtoan.TabIndex = 58;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // frmThanhToanPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 549);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tenphong);
            this.Controls.Add(this.maphong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTenkhach);
            this.Controls.Add(this.txtTienphong);
            this.Controls.Add(this.txtMakhach);
            this.Controls.Add(this.txtMasothue);
            this.Controls.Add(this.cboManhanvien);
            this.Controls.Add(this.txtCantra);
            this.Controls.Add(this.txtTiendichvu);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTailai);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTinhtien);
            this.Controls.Add(this.dgridThanhtoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThanhToanPhong";
            this.Text = "Thanh toán phòng";
            this.Load += new System.EventHandler(this.frmThanhToanPhong_Load);
            this.Leave += new System.EventHandler(this.frmThanhToanPhong_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgridThanhtoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.TextBox txtTienphong;
        private System.Windows.Forms.TextBox txtMakhach;
        private System.Windows.Forms.TextBox txtMasothue;
        private System.Windows.Forms.ComboBox cboManhanvien;
        private System.Windows.Forms.TextBox txtCantra;
        private System.Windows.Forms.TextBox txtTiendichvu;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTailai;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.DataGridView dgridThanhtoan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tenphong;
        private System.Windows.Forms.Label maphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnthanhtoan;
    }
}