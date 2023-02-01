using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan.Forms
{
    public partial class frmTKNhanVien : Form
    {
        public frmTKNhanVien()
        {
            InitializeComponent();
        }

        DataTable tbltknv;

        private void resetvalue ()
        {
            txtnhapmanv.Text = "";
            txtnhaptennv.Text = "";
            txtnhapmabp.Text = "";
            txtnhapmabp.Focus();
                  }
        private void frmTKNhanVien_Load(object sender, EventArgs e)
        {
            resetvalue();
            dgridTKNV.DataSource = null;
        }

        private void Load_datagrid()
        {
            dgridTKNV.Columns[0].HeaderText = "Mã nhân viên";
            dgridTKNV.Columns[1].HeaderText = "Tên nhân viên";
            dgridTKNV.Columns[2].HeaderText = "Mã bộ phận";
            dgridTKNV.Columns[3].HeaderText = "Địa chỉ";
            dgridTKNV.Columns[4].HeaderText = "Điện thoại";
            dgridTKNV.Columns[5].HeaderText = "Ngày sinh";
            dgridTKNV.Columns[6].HeaderText = "Giới Tính";
            dgridTKNV.AllowUserToAddRows = false;
            dgridTKNV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            if ((txtnhapmanv.Text == "") && (txtnhaptennv.Text == "") && (txtnhapmabp.Text == ""))
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql;
            sql = "select * from tblnhanvien where 1=1";
            if (txtnhapmabp.Text != "")
            {
                sql = sql + "and mabophan like N'%" + txtnhapmabp.Text.Trim() + "%'"; // tìm kiếm gần đúng
            }
            if (txtnhaptennv.Text != "")
            {
                sql = sql + "and tennhanvien like N'%" + txtnhaptennv.Text.Trim() + "%'"; // tìm kiếm gần đúng
            }
            if (txtnhapmanv.Text != "")
            {
                sql = sql + "and manhanvien like N'%" + txtnhapmanv.Text.Trim() + "%'"; // tìm kiếm gần đúng
            }

            tbltknv = Class.Functions.getdatatotable(sql);
            if (tbltknv.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetvalue();
            }
            else
            {
                MessageBox.Show("Có " + tbltknv.Rows.Count + " bản ghi thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgridTKNV.DataSource = tbltknv;
            Load_datagrid();
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            resetvalue();
            dgridTKNV.DataSource = null;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
