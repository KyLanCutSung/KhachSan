
namespace QuanLyKhachSan.Forms
{
    partial class frmTimPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimPhong));
            this.txtnhapmaphong = new System.Windows.Forms.TextBox();
            this.dtgridTP = new System.Windows.Forms.DataGridView();
            this.btndong = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.maphong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenphong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridTP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnhapmaphong
            // 
            this.txtnhapmaphong.Location = new System.Drawing.Point(365, 106);
            this.txtnhapmaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtnhapmaphong.Name = "txtnhapmaphong";
            this.txtnhapmaphong.Size = new System.Drawing.Size(156, 22);
            this.txtnhapmaphong.TabIndex = 2;
            // 
            // dtgridTP
            // 
            this.dtgridTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridTP.Location = new System.Drawing.Point(88, 192);
            this.dtgridTP.Margin = new System.Windows.Forms.Padding(4);
            this.dtgridTP.Name = "dtgridTP";
            this.dtgridTP.RowHeadersWidth = 51;
            this.dtgridTP.Size = new System.Drawing.Size(614, 115);
            this.dtgridTP.TabIndex = 3;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(616, 328);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(86, 35);
            this.btndong.TabIndex = 10;
            this.btndong.Text = "&Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(190, 328);
            this.btntimlai.Margin = new System.Windows.Forms.Padding(4);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(86, 35);
            this.btntimlai.TabIndex = 9;
            this.btntimlai.Text = "&Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(85, 328);
            this.btntim.Margin = new System.Windows.Forms.Padding(4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(86, 35);
            this.btntim.TabIndex = 8;
            this.btntim.Text = "&Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(245, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 32);
            this.label12.TabIndex = 28;
            this.label12.Text = "Tìm kiếm thông tin phòng";
            // 
            // maphong
            // 
            this.maphong.AutoSize = true;
            this.maphong.Location = new System.Drawing.Point(288, 109);
            this.maphong.Name = "maphong";
            this.maphong.Size = new System.Drawing.Size(70, 16);
            this.maphong.TabIndex = 29;
            this.maphong.Text = "Mã phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên phòng:";
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(365, 136);
            this.txttenphong.Margin = new System.Windows.Forms.Padding(4);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(156, 22);
            this.txttenphong.TabIndex = 34;
            // 
            // frmTimPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttenphong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maphong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.dtgridTP);
            this.Controls.Add(this.txtnhapmaphong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimPhong";
            this.Text = "Tìm phòng";
            this.Load += new System.EventHandler(this.frmTimPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnhapmaphong;
        private System.Windows.Forms.DataGridView dtgridTP;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label maphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenphong;
    }
}