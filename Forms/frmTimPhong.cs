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
    public partial class frmTimPhong : Form
    {
        public frmTimPhong()
        {
            InitializeComponent();
        }

        private void frmTimPhong_Load(object sender, EventArgs e)
        {
            reset();
            dtgridTP.DataSource = null;
        }
        private void reset()
        {
            txtnhapmaphong.Text = "";
            txtnhapmaphong.Focus();
        }

        private void load_datagrid()
        {
            dtgridTP.Columns[0].HeaderText = "Mã phòng";
            dtgridTP.Columns[1].HeaderText = "Tên phòng";
            dtgridTP.Columns[2].HeaderText = "Mã nhà";
            dtgridTP.Columns[3].HeaderText = "Mã loại phòng";
            dtgridTP.Columns[4].HeaderText = "Mã giường";
            dtgridTP.Columns[5].HeaderText = "Đơn giá ngày";
            dtgridTP.Columns[6].HeaderText = "Tình trạng";
            dtgridTP.Columns[7].HeaderText = "Ghi chú";
            dtgridTP.AllowUserToAddRows = false;
            dtgridTP.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if ((txtnhapmaphong.Text == "") && (txttenphong.Text ==""))
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql;
            sql = "select * from tblphong where 1=1";
            if ((txtnhapmaphong.Text != "") && (txttenphong.Text == ""))
            {
                sql = sql + "and MaPhong like N'%" + txtnhapmaphong.Text.Trim() + "%'";
            }
            if (txttenphong.Text != "")
            {
                sql = sql + "and TenPhong like N'%" + txttenphong.Text.Trim() + "%'"; // tìm kiếm gần đúng
            }

            DataTable tbltp;
            tbltp = Class.Functions.getdatatotable(sql);
            if (tbltp.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            else
            {
                MessageBox.Show("Có " + tbltp.Rows.Count + " bản ghi thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dtgridTP.DataSource = tbltp;
            load_datagrid();
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            reset();
            dtgridTP.DataSource = null;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
