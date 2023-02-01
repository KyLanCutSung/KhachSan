
namespace QuanLyKhachSan.Forms
{
    partial class frmthuephong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datagridtk = new System.Windows.Forms.DataGridView();
            this.cobdaynha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagriddulieu = new System.Windows.Forms.DataGridView();
            this.txtmadachon = new System.Windows.Forms.TextBox();
            this.txttiendatcoc = new System.Windows.Forms.TextBox();
            this.cobmakhach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmasothue = new System.Windows.Forms.TextBox();
            this.bttdong = new System.Windows.Forms.Button();
            this.btttailai = new System.Windows.Forms.Button();
            this.bttthue = new System.Windows.Forms.Button();
            this.cobtennhanvien = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridtk)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagriddulieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.datagridtk);
            this.groupBox1.Controls.Add(this.cobdaynha);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(931, 198);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM KIẾM";
            // 
            // datagridtk
            // 
            this.datagridtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridtk.Location = new System.Drawing.Point(87, 47);
            this.datagridtk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridtk.Name = "datagridtk";
            this.datagridtk.RowHeadersWidth = 62;
            this.datagridtk.RowTemplate.Height = 28;
            this.datagridtk.Size = new System.Drawing.Size(761, 135);
            this.datagridtk.TabIndex = 1;
            this.datagridtk.Click += new System.EventHandler(this.datagridtk_Click);
            // 
            // cobdaynha
            // 
            this.cobdaynha.FormattingEnabled = true;
            this.cobdaynha.Location = new System.Drawing.Point(171, 9);
            this.cobdaynha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobdaynha.Name = "cobdaynha";
            this.cobdaynha.Size = new System.Drawing.Size(204, 30);
            this.cobdaynha.TabIndex = 0;
            this.cobdaynha.Text = "--Mã dãy nhà";
            this.cobdaynha.TextChanged += new System.EventHandler(this.cobdaynha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(293, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "HOẠT ĐỘNG THUÊ PHÒNG";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.datagriddulieu);
            this.groupBox2.Controls.Add(this.txtmadachon);
            this.groupBox2.Controls.Add(this.txttiendatcoc);
            this.groupBox2.Controls.Add(this.cobmakhach);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(40, 333);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(931, 213);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DỮ LIỆU";
            // 
            // datagriddulieu
            // 
            this.datagriddulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriddulieu.Location = new System.Drawing.Point(100, 62);
            this.datagriddulieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagriddulieu.Name = "datagriddulieu";
            this.datagriddulieu.RowHeadersWidth = 62;
            this.datagriddulieu.RowTemplate.Height = 28;
            this.datagriddulieu.Size = new System.Drawing.Size(767, 150);
            this.datagriddulieu.TabIndex = 3;
            // 
            // txtmadachon
            // 
            this.txtmadachon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmadachon.Location = new System.Drawing.Point(793, 20);
            this.txtmadachon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmadachon.Name = "txtmadachon";
            this.txtmadachon.Size = new System.Drawing.Size(133, 30);
            this.txtmadachon.TabIndex = 2;
            this.txtmadachon.Text = "Mã đã chọn";
            // 
            // txttiendatcoc
            // 
            this.txttiendatcoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiendatcoc.Location = new System.Drawing.Point(445, 22);
            this.txttiendatcoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttiendatcoc.Name = "txttiendatcoc";
            this.txttiendatcoc.Size = new System.Drawing.Size(184, 30);
            this.txttiendatcoc.TabIndex = 1;
            this.txttiendatcoc.Text = "Tiền đặt cọc";
            // 
            // cobmakhach
            // 
            this.cobmakhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobmakhach.FormattingEnabled = true;
            this.cobmakhach.Location = new System.Drawing.Point(171, 20);
            this.cobmakhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobmakhach.Name = "cobmakhach";
            this.cobmakhach.Size = new System.Drawing.Size(204, 30);
            this.cobmakhach.TabIndex = 1;
            this.cobmakhach.Text = "--Mã khách hàng";
            this.cobmakhach.TextChanged += new System.EventHandler(this.cobmakhach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã số thuê";
            // 
            // txtmasothue
            // 
            this.txtmasothue.Location = new System.Drawing.Point(164, 48);
            this.txtmasothue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmasothue.Name = "txtmasothue";
            this.txtmasothue.Size = new System.Drawing.Size(133, 22);
            this.txtmasothue.TabIndex = 21;
            // 
            // bttdong
            // 
            this.bttdong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttdong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttdong.Location = new System.Drawing.Point(620, 557);
            this.bttdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttdong.Name = "bttdong";
            this.bttdong.Size = new System.Drawing.Size(104, 53);
            this.bttdong.TabIndex = 23;
            this.bttdong.Text = "Đóng";
            this.bttdong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttdong.UseVisualStyleBackColor = true;
            this.bttdong.Click += new System.EventHandler(this.bttdong_Click);
            // 
            // btttailai
            // 
            this.btttailai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btttailai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btttailai.Location = new System.Drawing.Point(456, 557);
            this.btttailai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btttailai.Name = "btttailai";
            this.btttailai.Size = new System.Drawing.Size(104, 53);
            this.btttailai.TabIndex = 22;
            this.btttailai.Text = "Tải lại";
            this.btttailai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btttailai.UseVisualStyleBackColor = true;
            this.btttailai.Click += new System.EventHandler(this.btttailai_Click);
            // 
            // bttthue
            // 
            this.bttthue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttthue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttthue.Location = new System.Drawing.Point(298, 557);
            this.bttthue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttthue.Name = "bttthue";
            this.bttthue.Size = new System.Drawing.Size(104, 53);
            this.bttthue.TabIndex = 20;
            this.bttthue.Text = "Thuê";
            this.bttthue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttthue.UseVisualStyleBackColor = true;
            this.bttthue.Click += new System.EventHandler(this.bttthue_Click);
            // 
            // cobtennhanvien
            // 
            this.cobtennhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobtennhanvien.FormattingEnabled = true;
            this.cobtennhanvien.Location = new System.Drawing.Point(682, 295);
            this.cobtennhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobtennhanvien.Name = "cobtennhanvien";
            this.cobtennhanvien.Size = new System.Drawing.Size(204, 30);
            this.cobtennhanvien.TabIndex = 19;
            this.cobtennhanvien.Text = "--Tên nhân viên";
            // 
            // frmthuephong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmasothue);
            this.Controls.Add(this.bttdong);
            this.Controls.Add(this.btttailai);
            this.Controls.Add(this.bttthue);
            this.Controls.Add(this.cobtennhanvien);
            this.Name = "frmthuephong";
            this.Text = "frmthuephong";
            this.Load += new System.EventHandler(this.frmthuephong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridtk)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagriddulieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datagridtk;
        private System.Windows.Forms.ComboBox cobdaynha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datagriddulieu;
        private System.Windows.Forms.TextBox txtmadachon;
        private System.Windows.Forms.TextBox txttiendatcoc;
        private System.Windows.Forms.ComboBox cobmakhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmasothue;
        private System.Windows.Forms.Button bttdong;
        private System.Windows.Forms.Button btttailai;
        private System.Windows.Forms.Button bttthue;
        private System.Windows.Forms.ComboBox cobtennhanvien;
    }
}