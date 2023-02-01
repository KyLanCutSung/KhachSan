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
    public partial class frmBoPhan : Form
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            txtmabp.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            load_dtgrid();
        }

        DataTable tblbp;
        private void load_dtgrid()
        {
            string sql;
            sql = "select * from tblbophan";
            tblbp = Class.Functions.getdatatotable(sql);
            dgridBP.DataSource = tblbp;

            dgridBP.Columns[0].HeaderText = "Mã bộ phận";
            dgridBP.Columns[1].HeaderText = "Tên bộ phận";
            dgridBP.AllowUserToAddRows = false;
            dgridBP.EditMode = DataGridViewEditMode.EditProgrammatically;
         }

        private void dgridBP_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmabp.Focus();
                return;
            }
            if (tblbp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtmabp.Text = dgridBP.CurrentRow.Cells["mabophan"].Value.ToString();
            txttenbp.Text = dgridBP.CurrentRow.Cells["tenbophan"].Value.ToString();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset()
        {
            txtmabp.Text = "";
            txttenbp.Text = "";
            txtmabp.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            btndong.Enabled = true;

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmabp.Enabled = true;
            btnluu.Enabled = true;
            btnboqua.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            txtmabp.Focus();
            btnthem.Enabled = false;
            txtmabp.Text = "";
            txttenbp.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmabp.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã bộ phận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmabp.Focus();
                return;
            }
            if (txttenbp.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên bộ phận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenbp.Focus();
                return;
            }
            string sql;
            sql = "select mabophan from tblbophan where mabophan = N'" + txtmabp.Text.Trim() + "'";
            if (Class.Functions.checkkey(sql) == true)
            {
                MessageBox.Show("Bộ phận đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmabp.Text = "";
                txtmabp.Focus();
            }
            
            sql = "insert into tblbophan values (N'" + txtmabp.Text.Trim() + "', N'" + txttenbp.Text.Trim() + "')";
            Class.Functions.runsql(sql);
            load_dtgrid();
            reset();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tblbp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmabp.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bộ phận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmabp.Focus();
                return;
            }
            if (txttenbp.Text == "")
            {
                MessageBox.Show("Bạn chưa sửa tên bộ phận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenbp.Focus();
                return;
            }
            if (MessageBox.Show("Bạn muốn sửa thông tin bộ phận", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "update tblbophan set tenbophan = N'" + txttenbp.Text.Trim() + "' where mabophan = N'" + txtmabp.Text.Trim() + "'";
                Class.Functions.runsql(sql);
                load_dtgrid();
                reset();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tblbp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmabp.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bộ phận cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmabp.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa thông tin bộ phận?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete from tblbophan where mabophan = N'" + txtmabp.Text.Trim() + "'";
                Class.Functions.runsql(sql);
                load_dtgrid();
                reset();
            }
        }
    }
}
