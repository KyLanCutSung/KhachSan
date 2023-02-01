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
using COMExel = Microsoft.Office.Interop.Excel;

namespace QuanLyKhachSan.Forms
{
    public partial class frmThanhtoandv : Form
    {
        public frmThanhtoandv()
        {
            InitializeComponent();
        }

        private void frmThanhtoandv_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
            txtTenKH.ReadOnly = true;
            txtTong.ReadOnly = true;
            txtTenDV.ReadOnly = true;
            txtDongia.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            loadchitiethd();
            string sql;
            sql = "select makhachhang,tenkhachhang from tblkhachhang";
            Class.Functions.fillcombo(sql, cboMaKH, "makhachhang", "makhachhang");
            cboMaKH.SelectedIndex = -1;
            sql = "select madichvu,tendichvu from tbldichvu";
            Class.Functions.fillcombo(sql, cboMaDV, "madichvu", "tendichvu");
            cboMaDV.SelectedIndex = -1;
            txtTong.Text = "0";
            loadchitiethd();
        }
        private void resetvalue1()
        {
            cboMaKH.SelectedIndex = -1;
            txtTenKH.Text = "";
        }
        private void resetvalue2()
        {
            cboMaDV.SelectedIndex = -1;
            txtDongia.Text = "";
            txtSoluong.Text = "";
            txtTenDV.Text = "";
            txtThanhtien.Text = "";
        }
        DataTable tbhddv;
        private void loadchitiethd()
        {
            string sql;
            sql = "select a.madichvu,a.tendichvu,a.dongia, b.soluong, b.thanhtien from tbldichvu as a,tblchitiethddv as b where a.madichvu=b.madichvu and maHD=N'" + txtMaHD.Text.Trim() + "'";
            tbhddv = Class.Functions.getdatatotable(sql);
            dgridDichvu.DataSource = tbhddv;
            dgridDichvu.Columns[0].HeaderText = "Mã dịch vụ";
            dgridDichvu.Columns[1].HeaderText = "Tên dịch vụ";
            dgridDichvu.Columns[2].HeaderText = "Đơn giá";
            dgridDichvu.Columns[3].HeaderText = "Số lượng";
            dgridDichvu.Columns[4].HeaderText = "Thành tiền";
        }

        private void cboMaDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaDV_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMaDV.Text == "")
            {
                txtTenDV.Text = "";
                txtDongia.Text = "";

            }
            else
            {
                sql = "select tendichvu from tbldichvu where madichvu='" + cboMaDV.SelectedValue + "'";
                txtTenDV.Text = Class.Functions.getfilevalue(sql);
                sql = "select dongia from tbldichvu where madichvu='" + cboMaDV.SelectedValue + "'";
                txtDongia.Text = Class.Functions.getfilevalue(sql);
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = Class.Functions.sinhma("HD");
            txtNgaythue.Text = DateTime.Now.ToShortDateString();
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            resetvalue1();
            resetvalue2();
            txtTong.Text = "0";
            dgridDichvu.DataSource = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, tien, tong;
            //luu thong tin vao hoa don thue dich vu
            txtTong.Text = txtThanhtien.Text;
            sql = "select maHD from tblhoadonthuedv where maHD=N'" + txtMaHD.Text.Trim() + "'";
            if (Class.Functions.checkkey(sql) == false)
            {
                if (cboMaKH.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sql = "insert into tblhoadonthuedv(maHD,makhachhang,ngayban,tongtien) values (N'" + txtMaHD.Text.Trim() + "',N'" + cboMaKH.SelectedValue + "','" + txtNgaythue.Text.Trim() + "','" + txtTong.Text.Trim() + "')";
                Class.Functions.runsql(sql);
            }
            txtTong.Text = Class.Functions.getfilevalue("select tongtien from tblhoadonthuedv where maHD=N'" + txtMaHD.Text.Trim() + "'");
            //luu thong tin vao bang chi tiet
            if (cboMaDV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoluong.Focus();
                return;
            }

            sql = "select madichvu from tblchitiethddv where maHD=N'" + txtMaHD.Text.Trim() + "' and madichvu='" + cboMaDV.SelectedValue + "'";
            if (Class.Functions.checkkey(sql) == true)
            {
                MessageBox.Show("Mã dịch vụ đã có");
                resetvalue2();
                return;
            }
            sql = "insert into tblchitiethddv(maHD,madichvu,soluong,dongia,thanhtien) values(N'" + txtMaHD.Text.Trim() + "',N'" + cboMaDV.SelectedValue + "','" + txtSoluong.Text.Trim() + "','" + txtDongia.Text.Trim() + "','" + txtThanhtien.Text.Trim() + "')";
            Class.Functions.runsql(sql);
            loadchitiethd();
            //cap nhat tong tien                      
            tien = "select SUM(thanhtien) from tblchitiethddv where maHD=N'" + txtMaHD.Text.Trim() + "'";
            tong = Class.Functions.getfilevalue(tien);
            sql = "update tblhoadonthuedv set tongtien=N'" + Convert.ToString(tong) + "' where maHD=N'" + txtMaHD.Text.Trim() + "'";
            Class.Functions.runsql(sql);
            txtTong.Text = tong.ToString();
            resetvalue2();
            btnHuy.Enabled = true;

            btnThem.Enabled = true;
        }
        private void delete(string mahd, string madv)
        {
            string sql;
            sql = "delete tblchitiethddv where maHD=N'" + mahd + "' and madichvu=N'" + madv + "'";
            Class.Functions.runsql(sql);
        }
        private void update(string mahoadon, double thanhtien)
        {
            double tong, tong2;
            string sql;
            sql = "select tongtien from tblhoadonthuedv where maHD=N'" + mahoadon + "'";
            tong = Convert.ToDouble(Class.Functions.getfilevalue(sql));
            tong2 = tong - thanhtien;
            sql = "update tblhoadonthuedv set tongtien=" + tong2 + " where maHD=N'" + mahoadon + "'";
            Class.Functions.runsql(sql);
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có muốn xóa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                            System.Windows.Forms.DialogResult.Yes)
            {
                string[] madichvu = new string[20];
                string sql;
                int n = 0;
                sql = "select madichvu from tblchitiethddv where maHD=N'" + txtMaHD.Text.Trim() + "'";
                SqlCommand a = new SqlCommand(sql, Class.Functions.conn);
                SqlDataReader b = a.ExecuteReader();
                while (b.Read())
                {
                    madichvu[n] = b.GetString(0).ToString();
                    n = n + 1;
                }
                b.Close();
                //xoa ds cac mat hang
                for (int i = 0; i <= n - 1; i++)
                {
                    delete(txtMaHD.Text, madichvu[i]);
                }
                //xoa hoa don
                sql = "delete tblhoadonthuedv where maHD=N'" + txtMaHD.Text + "'";
                Class.Functions.runsql(sql);
                resetvalue1();
                resetvalue2();
                loadchitiethd();
                btnHuy.Enabled = false;
            }
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            double sl, tt;
            if (txtSoluong.Text == "")
            {
                sl = 0;
            }
            else
            {
                sl = Convert.ToDouble(txtSoluong.Text);
                tt = sl * Convert.ToDouble(txtDongia.Text);
                txtThanhtien.Text = tt.ToString();
            }
        }

        private void dgridDichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgridDichvu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgridDichvu.Rows.Count == 0)
            {
                MessageBox.Show("Không có data");
                return;
            }
            if (MessageBox.Show("Ban có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                string ma;
                ma = dgridDichvu.CurrentRow.Cells["madichvu"].Value.ToString();
                delete(txtMaHD.Text, ma);
                //cap nhat tong tien
                double tt;
                tt = Convert.ToDouble(dgridDichvu.CurrentRow.Cells["thanhtien"].Value.ToString());
                update(txtMaHD.Text, tt);
                loadchitiethd();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
           /* //khoi dong excel
            COMExel.Application exApp = new COMExel.Application();
            COMExel.Workbook exBook;
            COMExel.Worksheet exSheet;
            COMExel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tbthongtinhd, tbthongtindv;
            exBook = exApp.Workbooks.Add(COMExel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            //dinh dang chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN THUÊ DỊCH VỤ";
            // bieu dien thong tin chung cua hoa don thue
            sql = "select a.maHD,a.ngayban,a.tongtien,b.tenkhachhang,b.diachi,b.dienthoai from tblhoadonthuedv as a, tblkhachhang as b where a.maHD=N'" + txtMaHD.Text + "' and a.makhachhang=b.makhachhang";
            tbthongtinhd = Class.Functions.getdatatotable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tbthongtinhd.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tbthongtinhd.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tbthongtinhd.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tbthongtinhd.Rows[0][5].ToString();
            tbthongtinhd.Rows[0][5].ToString();
            //lay thong tin dich vu
            sql = "select a.tendichvu,b.soluong,a.dongia,b.thanhtien from tblchitiethddv as b, tbldichvu as a where b.maHD=N'" + txtMaHD.Text + "' and a.madichvu=b.madichvu";
            tbthongtindv = Class.Functions.getdatatotable(sql);
            //tao dong tieu de bang
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên dịch vụ";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Thành tiền";
            for (hang = 0; hang <= tbthongtindv.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tbthongtindv.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tbthongtindv.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tbthongtinhd.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Class.Functions.chuyenSoSangChu(tbthongtinhd.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tbthongtinhd.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
            resetvalue1();
            resetvalue2();*/
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Ban co muon thoat?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cboMaKH_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMaKH.Text == "")
            {
                txtTenKH.Text = "";
            }
            else
            {
                sql = "select tenkhachhang from tblkhachhang where makhachhang='" + cboMaKH.SelectedValue + "'";
                txtTenKH.Text = Class.Functions.getfilevalue(sql);
            }
        }
    }
}
