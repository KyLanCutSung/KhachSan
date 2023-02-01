using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
namespace QuanLyKhachSan.Forms
{
    public partial class frmThanhToanPhong : Form
    {
        public frmThanhToanPhong()
        {
            InitializeComponent();
        }

        private void frmThanhToanPhong_Leave(object sender, EventArgs e)
        {

        }

        private void frmThanhToanPhong_Load(object sender, EventArgs e)
        {
            txtCantra.Enabled = false;
            txtTienphong.Enabled = false;
            txtTiendichvu.Enabled = false;
            txtMaphong.Enabled = false;
            cboManhanvien.Enabled = false;
            txtMasothue.Enabled = false;
            btnTailai.Enabled = false;
            btnTinhtien.Enabled = true;
            load_datagrid();
            Class.Functions.fillcombo("select manhanvien, tennhanvien from tblnhanvien", cboManhanvien, "tennhanvien", "manhanvvien");
            cboManhanvien.SelectedIndex = -1;
            txtTenkhach.Enabled = false;
        }
        DataTable tbl;
        private void load_datagrid()
        {
            string sql;
            sql = "Select tblthuephong.masothue, tblthuephong.maphong, tblthuephong.makhachhang, tblthuephong.ngayden, tbltraphong.ngaytraphong, tblthuephong.tiendatcoc from tblthuephong, tbltraphong where tblthuephong.masothue = tblthuephong.masothue";
            tbl = Class.Functions.getdatatotable(sql);

        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            string sql1, sql2, tiendv, masothue;
            double tinhtien, cantra;
            masothue = "select masothue from tblthuephong where makhachhang =N'" + txtMakhach.Text + "'";
            string ngt;
            ngt = "Update tbltraphong set ngaytraphong = CAST(GETDATE() AS DATE) where masothue =N'" + masothue + "'";
            sql1 = "select a.masothue, a.maphong, a.makhachhang, a.ngayden,CAST(GETDATE() AS DATE) ,a.tiendatcoc from tblthuephong a, tbltraphong b where a.masothue = b.masothue and a.makhachhang = N'" + txtMakhach.Text + "'";
            tbl = Class.Functions.getdatatotable(sql1);
            dgridThanhtoan.DataSource = tbl;
            dgridThanhtoan.Columns[0].HeaderText = "Mã số thuê";
            dgridThanhtoan.Columns[1].HeaderText = "Mã phòng";
            dgridThanhtoan.Columns[2].HeaderText = "Mã khách hàng";
            dgridThanhtoan.Columns[3].HeaderText = "Ngày đến";
            dgridThanhtoan.Columns[4].HeaderText = "Ngày trả phòng";
            dgridThanhtoan.Columns[5].HeaderText = "Tiền đặt cọc";
            if (dgridThanhtoan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql1 = "select a.dongiangay from tblphong a, tblthuephong b where a.maphong = b.maphong and b.makhachhang = N'" + txtMakhach.Text + "'";
            tbl = Class.Functions.getdatatotable(sql1);
            tinhtien = Convert.ToDouble(Class.Functions.getfilevalue(sql1));
            string ngayden, ngaytraphong;
            ngayden = "select ngayden from tblthuephong where makhachhang = N'" + txtMakhach.Text + "'";
            ngaytraphong = "select a.ngaytraphong from tbltraphong a, tblthuephong b where a.masothue = b.masothue and b.makhachhang = N'" + txtMakhach.Text + "'";
            tiendv = "select sum(tongtien) from tblhoadonthuedv a where makhachhang = N'" + txtMakhach.Text + "'";
            string sqldate = "SELECT DATEDIFF(day, (SELECT NgayDen FROM tblThuePhong WHERE Makhachhang =N'" + txtMakhach.Text + "'),CAST(GETDATE() AS DATE))";
            double tongsongay = Convert.ToDouble(Class.Functions.getfilevalue(sqldate));
            //string sql = "select datediff(day,a.ngayden,CAST(GETDATE() AS DATE)) from tblthuephong a, tbltraphong b where a.masothue = b.masothue and a.makhachhang = N'" + txtmakh.Text + "'";
            //int tongsongay = Convert.ToInt32(Class.Function.docdulieu(sql));
            if (tongsongay == 0)
            {
                txtTienphong.Text = Convert.ToString(tinhtien);
                sql2 = "Select tiendatcoc from tblthuephong where makhachhang = N'" + txtMakhach.Text + "'";
                cantra = tinhtien - Convert.ToDouble(Class.Functions.getfilevalue(sql2)) + Convert.ToDouble(Class.Functions.getfilevalue(tiendv));
                txtCantra.Text = Convert.ToString(cantra);
            }
            else
            {
                txtTienphong.Text = Convert.ToString(tinhtien * tongsongay);
                sql2 = "Select tiendatcoc from tblthuephong where makhachhang = N'" + txtMakhach.Text + "'";
                cantra = tinhtien * tongsongay - Convert.ToDouble(Class.Functions.getfilevalue(sql2)) + Convert.ToDouble(Class.Functions.getfilevalue(tiendv));
                txtCantra.Text = Convert.ToString(cantra);
            }
            btnTinhtien.Enabled = false;
            btnTailai.Enabled = true;
            string ten, ma1, ma2, ma3;
            ten = "select tenkhachhang from tblkhachhang a, tblthuephong b where a.makhachhang = N'" + txtMakhach.Text + "'";
            txtTenkhach.Text = Class.Functions.getfilevalue(ten);
            ma1 = "select makhachhang from tblthuephong  where makhachhang = N'" + txtMakhach.Text + "'";
            txtMakhach.Text = Class.Functions.getfilevalue(ma1);
            ma2 = "select maphong from tblthuephong where makhachhang = N'" + txtMakhach.Text + "'";
            txtMaphong.Text = Class.Functions.getfilevalue(ma2);
            txtTiendichvu.Text = Class.Functions.getfilevalue(tiendv);
            ma3 = "select masothue from tblthuephong where makhachhang =N'" + txtMakhach.Text + "'";
            txtMasothue.Text = Class.Functions.getfilevalue(ma3);
            cboManhanvien.Enabled = true;
            txtMakhach.Enabled = true;
            if (dgridThanhtoan.Rows.Count == 0)
            {
                MessageBox.Show("Không có data!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMakhach.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã khách", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhach.Focus();
                return;
            }
        }
        private void reset_values()
        {
            cboManhanvien.Text = "";
            txtMasothue.Clear();
            txtCantra.Clear();
            txtTienphong.Clear();
            txtMaphong.Text = "";
            txtTenkhach.Text = "";
            txtTiendichvu.Text = "";
            txtMakhach.Text = "";
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            reset_values();
            btnTailai.Enabled = false;
            btnTinhtien.Enabled = true;
            dgridThanhtoan.DataSource = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN TRẢ PHÒNG";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "select a.masothue,a.maphong,a.makhachhang,a.ngayden,b.ngaytraphong,b.cantra,b.manhanvien from tblthuephong  a,tbltraphong  b where a.masothue=b.masothue and a.makhachhang=N'" + txtMakhach.Text.Trim() + "'";
            tblThongtinHD = Class.Functions.getdatatotable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã số thuê:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Ngày thuê:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Ngày trả:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Mã nhân viên:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][6].ToString();
            tblThongtinHD.Rows[0][6].ToString();
            //lấy tt phòng
            string tiendv = "select sum(tongtien) from tblhoadonthuedv where makhachhang = N'" + txtMakhach.Text + "'";
            sql = "select a.maphong,d.dongiangay,a.tiendatcoc,c.tongtien from tblthuephong  a, tbltraphong  b,tblhoadonthuedv  c, tblphong d where a.masothue=b.masothue and a.makhachhang=c.makhachhang and a.maphong = d.maphong and a.makhachhang=N'" + txtMakhach.Text + "'";
            tblThongtinHang = Class.Functions.getdatatotable(sql);
            string sqldate = "SELECT DATEDIFF(day, (SELECT NgayDen FROM tblThuePhong WHERE Makhachhang =N'" + txtMakhach.Text + "'),CAST(GETDATE() AS DATE))";
            double tt = Convert.ToDouble(Class.Functions.getfilevalue(sqldate));
            string sql11 = "select a.dongiangay from tblphong a, tblthuephong b where a.maphong = b.maphong and b.makhachhang = N'" + txtMakhach.Text + "'";
            double tinhtien = Convert.ToDouble(Class.Functions.getfilevalue(sql11));
            string sql3 = "Select tiendatcoc from tblthuephong where makhachhang = N'" + txtMakhach.Text + "'";
            double cantra = tinhtien * tt - Convert.ToDouble(Class.Functions.getfilevalue(sql3)) + Convert.ToDouble(Class.Functions.getfilevalue(tiendv));
            txtCantra.Text = Convert.ToString(cantra);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Mã phòng";
            exRange.Range["C11:C11"].Value = "Đơn giá ngày";
            exRange.Range["D11:D11"].Value = "Tiền đặt cọc";
            exRange.Range["E11:E11"].Value = "Tiền dịch vụ";
            //exRange.Range["F11:F11"].Value = "Thành tiền";
            exRange.Range["E16:E16"].Value = cantra;
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            //exRange.Value2 = tblThongtinHD.Rows[0][5].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            //exRange.Range["A1:F1"].Value = "Bằng chữ: " + Class.Function.chuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            //exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["D1:F1"].MergeCells = true;
            exRange.Range["D1:F1"].Font.Italic = true;
            exRange.Range["D1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D1:F1"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();

            exSheet.Name = "Báo cáo";
            exApp.Visible = true;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            //exSheet.Name = "Hóa đơn nhập";
            //exApp.Visible = true;
        }

        private void dgridThanhtoan_Click(object sender, EventArgs e)
        {

            if (dgridThanhtoan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtMakhach_TextChanged(object sender, EventArgs e)
        {
            if (txtMakhach.Text == "")
            {
                cboManhanvien.SelectedIndex = -1;
                txtMaphong.Text = "";
                txtMasothue.Text = "";
                txtTenkhach.Text = "";
                txtTiendichvu.Text = "";
            }
            else
            {
                string sql;
                sql = "select masothue from tblthuephong where makhachhang=N'" + txtMakhach.Text.Trim() + "'";
                txtMasothue.Text = Class.Functions.getfilevalue(sql);
                sql = "select tenkhachhang from tblkhachhang where makhachhang=N'" + txtMakhach.Text.Trim() + "'";
                txtTenkhach.Text = Class.Functions.getfilevalue(sql);
                sql = "select tongtien from tblhoadonthuedv where makhachhang=N'" + txtMakhach.Text.Trim() + "'";
                txtTiendichvu.Text = Class.Functions.getfilevalue(sql);
                sql = "select a.dongiangay from tblphong as a, tblthuephong as b where a.maphong=b.maphong and b.makhachhang=N'" + txtMakhach.Text.Trim() + "'";
                txtTienphong.Text = Class.Functions.getfilevalue(sql);
                sql = "select maphong from tblthuephong where makhachhang=N'" + txtMakhach.Text.Trim() + "'";
                txtMaphong.Text = Class.Functions.getfilevalue(sql);
                cboManhanvien.Enabled = true;
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (cboManhanvien.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn nhân viên thực hiện thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTienphong.Text == "")
            {
                MessageBox.Show("Chưa thực hiện tính tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Đồng ý thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql, manv, map, masothue, sql1;
                double sotiencantra, sotienthue;
                manv = cboManhanvien.SelectedValue.ToString();
                masothue = txtMasothue.Text;
                map = txtMaphong.Text;
                sql = "Select tiendatcoc from tblthuephong where makhachhang =N'" + txtMakhach.Text + "' and masothue=N'" + txtMasothue.Text.Trim() + "'";
                sql1 = "select sum(tongtien) from tblhoadonthuedv a, tblthuephong b where a.makhachhang = b.makhachhang and b.masothue = N'" + masothue + "'";
                sotienthue = Convert.ToDouble(txtTienphong.Text);
                sotiencantra = sotienthue - Convert.ToDouble(Class.Functions.getfilevalue(sql)) + Convert.ToDouble(Class.Functions.getfilevalue(sql1));
                sql = "Update tbltraphong set ngaytraphong = '" + Class.Functions.vcovertDateTime("CAST(GETDATE() AS DATE)") + "',MaNhanVien=N'" + manv + "',TienThuePhong=N'" + sotienthue + "',CanTra=N'" + sotiencantra + "' where masothue ='" + masothue + "'";
                Class.Functions.runsql(sql);
                sql = "Update tblphong set tinhtrang = N'Trống' WHERE maphong ='" + map + "'";
                Class.Functions.runsql(sql);
                sql = "Update tblthuephong set tinhtrang = N'Trống' where masothue ='" + masothue + "'";
                Class.Functions.runsql(sql);
                load_datagrid();
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
