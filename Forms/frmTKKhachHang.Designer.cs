
namespace QuanLyKhachSan.Forms
{
    partial class frmTKKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKKhachHang));
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dgridTKKH = new System.Windows.Forms.DataGridView();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.msknhapdienthoaikh = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tenphong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridTKKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(101, 362);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(86, 35);
            this.btntimkiem.TabIndex = 2;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dgridTKKH
            // 
            this.dgridTKKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridTKKH.Location = new System.Drawing.Point(101, 230);
            this.dgridTKKH.Margin = new System.Windows.Forms.Padding(4);
            this.dgridTKKH.Name = "dgridTKKH";
            this.dgridTKKH.RowHeadersWidth = 51;
            this.dgridTKKH.Size = new System.Drawing.Size(614, 115);
            this.dgridTKKH.TabIndex = 9;
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(227, 362);
            this.btntimlai.Margin = new System.Windows.Forms.Padding(4);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(86, 35);
            this.btntimlai.TabIndex = 10;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(629, 362);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(86, 35);
            this.btndong.TabIndex = 11;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // msknhapdienthoaikh
            // 
            this.msknhapdienthoaikh.Location = new System.Drawing.Point(389, 133);
            this.msknhapdienthoaikh.Margin = new System.Windows.Forms.Padding(4);
            this.msknhapdienthoaikh.Mask = "(999) 000-0000";
            this.msknhapdienthoaikh.Name = "msknhapdienthoaikh";
            this.msknhapdienthoaikh.Size = new System.Drawing.Size(188, 22);
            this.msknhapdienthoaikh.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(211, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(390, 32);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tìm kiếm thông tin khách hàng";
            // 
            // tenphong
            // 
            this.tenphong.AutoSize = true;
            this.tenphong.Location = new System.Drawing.Point(233, 134);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(154, 17);
            this.tenphong.TabIndex = 31;
            this.tenphong.Text = "Điện thoại khách hàng:";
            // 
            // frmTKKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tenphong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.msknhapdienthoaikh);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.dgridTKKH);
            this.Controls.Add(this.btntimkiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTKKhachHang";
            this.Text = "Tìm kiếm Khách Hàng";
            this.Load += new System.EventHandler(this.frmTKKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridTKKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dgridTKKH;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.MaskedTextBox msknhapdienthoaikh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label tenphong;
    }
}