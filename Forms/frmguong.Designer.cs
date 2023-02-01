namespace QuanLyKhachSan.Forms
{
    partial class frmguong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmguong));
            this.label2 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridViewGiuong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttengiuong = new System.Windows.Forms.TextBox();
            this.txtmagiuong = new System.Windows.Forms.TextBox();
            this.tenphong = new System.Windows.Forms.Label();
            this.maphong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Danh sách";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(623, 371);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(86, 35);
            this.btndong.TabIndex = 50;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(522, 371);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(86, 35);
            this.btnboqua.TabIndex = 49;
            this.btnboqua.Text = "Hủy";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(420, 371);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(86, 35);
            this.btnluu.TabIndex = 48;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(298, 371);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(86, 35);
            this.btnxoa.TabIndex = 47;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(197, 371);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(86, 35);
            this.btnsua.TabIndex = 46;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(95, 371);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(86, 35);
            this.btnthem.TabIndex = 45;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dataGridViewGiuong
            // 
            this.dataGridViewGiuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiuong.Location = new System.Drawing.Point(95, 239);
            this.dataGridViewGiuong.Name = "dataGridViewGiuong";
            this.dataGridViewGiuong.RowHeadersWidth = 51;
            this.dataGridViewGiuong.RowTemplate.Height = 24;
            this.dataGridViewGiuong.Size = new System.Drawing.Size(614, 115);
            this.dataGridViewGiuong.TabIndex = 44;
            this.dataGridViewGiuong.Click += new System.EventHandler(this.dataGridViewGiuong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttengiuong);
            this.groupBox1.Controls.Add(this.txtmagiuong);
            this.groupBox1.Controls.Add(this.tenphong);
            this.groupBox1.Controls.Add(this.maphong);
            this.groupBox1.Location = new System.Drawing.Point(131, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 100);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txttengiuong
            // 
            this.txttengiuong.Location = new System.Drawing.Point(264, 53);
            this.txttengiuong.Name = "txttengiuong";
            this.txttengiuong.Size = new System.Drawing.Size(137, 22);
            this.txttengiuong.TabIndex = 14;
            // 
            // txtmagiuong
            // 
            this.txtmagiuong.Location = new System.Drawing.Point(264, 25);
            this.txtmagiuong.Name = "txtmagiuong";
            this.txtmagiuong.Size = new System.Drawing.Size(137, 22);
            this.txtmagiuong.TabIndex = 13;
            // 
            // tenphong
            // 
            this.tenphong.AutoSize = true;
            this.tenphong.Location = new System.Drawing.Point(121, 55);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(75, 16);
            this.tenphong.TabIndex = 12;
            this.tenphong.Text = "Tên gường:";
            // 
            // maphong
            // 
            this.maphong.AutoSize = true;
            this.maphong.Location = new System.Drawing.Point(121, 27);
            this.maphong.Name = "maphong";
            this.maphong.Size = new System.Drawing.Size(70, 16);
            this.maphong.TabIndex = 11;
            this.maphong.Text = "Mã gường:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Thông tin loại gường";
            // 
            // frmguong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridViewGiuong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmguong";
            this.Text = "Thông tin loại gường";
            this.Load += new System.EventHandler(this.frmguong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridViewGiuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttengiuong;
        private System.Windows.Forms.TextBox txtmagiuong;
        private System.Windows.Forms.Label tenphong;
        private System.Windows.Forms.Label maphong;
        private System.Windows.Forms.Label label1;
    }
}