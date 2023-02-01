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
    public partial class frmdaynha : Form
    {
        DataTable tbdn;
        public frmdaynha()
        {
            InitializeComponent();
        }

        private void frmdaynha_Load(object sender, EventArgs e)
        {
            txtmaday.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            load_datagrid();
        }
        private void load_datagrid()
        {
            string sql;
            sql = "select *from tbldaynha";
            tbdn = Class.Functions.getdatatotable(sql);
            datagriddaynha.DataSource = tbdn;
            datagriddaynha.Columns[0].HeaderText = "Mã dãy nhà";
            datagriddaynha.Columns[1].HeaderText = "Tên dãy nhà";
        }
        private void resetvalue()
        {
            txtmaday.Text = "";
            txttenday.Text = "";
        }

        private void datagriddaynha_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (datagriddaynha.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để chọn", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtmaday.Text = datagriddaynha.CurrentRow.Cells["madaynha"].Value.ToString();
                txttenday.Text = datagriddaynha.CurrentRow.Cells["tendaynha"].Value.ToString();
                btnsua.Enabled = true;
                btnboqua.Enabled = true;
                btnxoa.Enabled = true;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnsua.Enabled = false;
            txtmaday.Enabled = true;
            txtmaday.Focus();
            resetvalue();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmaday.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng xóa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Ban có muốn xóa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                string sql;
                sql = "delete from tbldaynha where madaynha=N'" + txtmaday.Text.Trim() + "'";
                Class.Functions.runsql(sql);
                load_datagrid();
                resetvalue();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmaday.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng sửa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql;
            sql = "update tbldaynha set tendaynha=N'" + txttenday.Text.Trim() + "' where madaynha=N'" + txtmaday.Text.Trim() + "'";
            Class.Functions.runsql(sql);
            load_datagrid();
            resetvalue();
            btnboqua.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmaday.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã dãy nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaday.Focus();
                return;
            }
            if (txttenday.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên dãy nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenday.Focus();
                return;
            }
            string sql;
            sql = "select madaynha from tbldaynha where madaynha=N'" + txtmaday.Text.Trim() + "'";
            if (Class.Functions.checkkey(sql) == true)
            {
                MessageBox.Show("Mã này bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaday.Text = "";
                txtmaday.Focus();
                return;
            }
            else
            {
                sql = "insert into tbldaynha(madaynha,tendaynha) values(N'" + txtmaday.Text.Trim() + "',N'" + txttenday.Text.Trim() + "')";
                Class.Functions.runsql(sql);
                load_datagrid();
                resetvalue();
                btnthem.Enabled = true;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnboqua.Enabled = false;
                btnluu.Enabled = false;
                txtmaday.Enabled = false;
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            txtmaday.Enabled = false;
            btnluu.Enabled = false;
            resetvalue();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
