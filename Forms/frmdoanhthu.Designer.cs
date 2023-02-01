
namespace QuanLyKhachSan.Forms
{
    partial class frmdoanhthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdoanhthu));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTailai = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.dgridDoanhthu = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNam);
            this.groupBox1.Controls.Add(this.cboThang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(247, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(298, 123);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(104, 68);
            this.cboNam.Margin = new System.Windows.Forms.Padding(4);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(146, 24);
            this.cboNam.TabIndex = 14;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(104, 36);
            this.cboThang.Margin = new System.Windows.Forms.Padding(4);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(146, 24);
            this.cboThang.TabIndex = 13;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(494, 329);
            this.txtTong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(215, 22);
            this.txtTong.TabIndex = 20;
            this.txtTong.TextChanged += new System.EventHandler(this.txtTong_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tổng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(622, 374);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 35);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(312, 374);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(86, 35);
            this.btnIn.TabIndex = 17;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTailai
            // 
            this.btnTailai.Location = new System.Drawing.Point(204, 374);
            this.btnTailai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTailai.Name = "btnTailai";
            this.btnTailai.Size = new System.Drawing.Size(86, 35);
            this.btnTailai.TabIndex = 16;
            this.btnTailai.Text = "Tải lại";
            this.btnTailai.UseVisualStyleBackColor = true;
            this.btnTailai.Click += new System.EventHandler(this.btnTailai_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(95, 374);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(86, 35);
            this.btnThongke.TabIndex = 15;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // dgridDoanhthu
            // 
            this.dgridDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDoanhthu.Location = new System.Drawing.Point(95, 206);
            this.dgridDoanhthu.Margin = new System.Windows.Forms.Padding(4);
            this.dgridDoanhthu.Name = "dgridDoanhthu";
            this.dgridDoanhthu.RowHeadersWidth = 51;
            this.dgridDoanhthu.Size = new System.Drawing.Size(614, 115);
            this.dgridDoanhthu.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(335, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 32);
            this.label9.TabIndex = 44;
            this.label9.Text = "Doanh thu";
            // 
            // frmdoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTailai);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.dgridDoanhthu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdoanhthu";
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.frmdoanhthu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDoanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTailai;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.DataGridView dgridDoanhthu;
        private System.Windows.Forms.Label label9;
    }
}