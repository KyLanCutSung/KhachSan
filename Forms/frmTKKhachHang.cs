using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class frmTKKhachHang : Form
    {
        public frmTKKhachHang()
        {
            InitializeComponent();
        }

        private void frmTKKhachHang_Load(object sender, EventArgs e)
        {
            resetvalue();
            dgridTKKH.DataSource = null;
        }

        private void resetvalue()
        {

            msknhapdienthoaikh.Text = "";

            msknhapdienthoaikh.Focus();
        }

        private void Load_datagrid()
        {
            dgridTKKH.Columns[0].HeaderText = "Mã khách";
            dgridTKKH.Columns[1].HeaderText = "Tên khách";
            dgridTKKH.Columns[2].HeaderText = "Địa chỉ";
            dgridTKKH.Columns[3].HeaderText = "Điện thoại";
            dgridTKKH.Columns[4].HeaderText = "Hạng";
            dgridTKKH.Columns[5].HeaderText = "Ngày sinh";
            dgridTKKH.Columns[6].HeaderText = "Số CCCD";
            dgridTKKH.AllowUserToAddRows = false;
            dgridTKKH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (msknhapdienthoaikh.Text == "(   )   -    ")
            {
                MessageBox.Show("Hãy điền điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql;
            sql = "select * from tblkhachhang where 1=1";
          
            if (msknhapdienthoaikh.Text != "")
            {
                sql = sql + "and dienthoaikh like N'%" + msknhapdienthoaikh.Text + "%'";
            }

            DataTable tbltkkh;
            tbltkkh = Class.Functions.getdatatotable(sql);
            if (tbltkkh.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetvalue();
            }
            else
            {
                MessageBox.Show("Có " + tbltkkh.Rows.Count + " bản ghi thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgridTKKH.DataSource = tbltkkh;
            Load_datagrid();
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            resetvalue();
            dgridTKKH.DataSource = null;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
