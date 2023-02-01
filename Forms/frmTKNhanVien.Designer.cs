
namespace QuanLyKhachSan.Forms
{
    partial class frmTKNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKNhanVien));
            this.txtnhapmanv = new System.Windows.Forms.TextBox();
            this.dgridTKNV = new System.Windows.Forms.DataGridView();
            this.btntim = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.txtnhaptennv = new System.Windows.Forms.TextBox();
            this.txtnhapmabp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tenphong = new System.Windows.Forms.Label();
            this.maphong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridTKNV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnhapmanv
            // 
            this.txtnhapmanv.Location = new System.Drawing.Point(354, 109);
            this.txtnhapmanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnhapmanv.Name = "txtnhapmanv";
            this.txtnhapmanv.Size = new System.Drawing.Size(191, 22);
            this.txtnhapmanv.TabIndex = 1;
            // 
            // dgridTKNV
            // 
            this.dgridTKNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridTKNV.Location = new System.Drawing.Point(90, 226);
            this.dgridTKNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgridTKNV.Name = "dgridTKNV";
            this.dgridTKNV.RowHeadersWidth = 51;
            this.dgridTKNV.Size = new System.Drawing.Size(614, 115);
            this.dgridTKNV.TabIndex = 2;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(90, 362);
            this.btntim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(86, 35);
            this.btntim.TabIndex = 3;
            this.btntim.Text = "&Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(200, 362);
            this.btntimlai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(86, 35);
            this.btntimlai.TabIndex = 5;
            this.btntimlai.Text = "&Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(618, 362);
            this.btndong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(86, 35);
            this.btndong.TabIndex = 7;
            this.btndong.Text = "&Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // txtnhaptennv
            // 
            this.txtnhaptennv.Location = new System.Drawing.Point(354, 139);
            this.txtnhaptennv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnhaptennv.Name = "txtnhaptennv";
            this.txtnhaptennv.Size = new System.Drawing.Size(191, 22);
            this.txtnhaptennv.TabIndex = 10;
            // 
            // txtnhapmabp
            // 
            this.txtnhapmabp.Location = new System.Drawing.Point(354, 169);
            this.txtnhapmabp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnhapmabp.Name = "txtnhapmabp";
            this.txtnhapmabp.Size = new System.Drawing.Size(191, 22);
            this.txtnhapmabp.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(216, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(368, 32);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tìm kiếm thông tin nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã bộ phận:";
            // 
            // tenphong
            // 
            this.tenphong.AutoSize = true;
            this.tenphong.Location = new System.Drawing.Point(237, 139);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(94, 16);
            this.tenphong.TabIndex = 34;
            this.tenphong.Text = "Tên nhân viên:";
            // 
            // maphong
            // 
            this.maphong.AutoSize = true;
            this.maphong.Location = new System.Drawing.Point(237, 111);
            this.maphong.Name = "maphong";
            this.maphong.Size = new System.Drawing.Size(89, 16);
            this.maphong.TabIndex = 33;
            this.maphong.Text = "Mã nhân viên:";
            // 
            // frmTKNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tenphong);
            this.Controls.Add(this.maphong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtnhapmabp);
            this.Controls.Add(this.txtnhaptennv);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.dgridTKNV);
            this.Controls.Add(this.txtnhapmanv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTKNhanVien";
            this.Text = "Tìm kiếm Nhân Viên";
            this.Load += new System.EventHandler(this.frmTKNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridTKNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnhapmanv;
        private System.Windows.Forms.DataGridView dgridTKNV;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.TextBox txtnhaptennv;
        private System.Windows.Forms.TextBox txtnhapmabp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tenphong;
        private System.Windows.Forms.Label maphong;
    }
}