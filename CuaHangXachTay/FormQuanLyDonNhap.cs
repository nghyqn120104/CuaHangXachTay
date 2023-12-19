using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangXachTay
{
    public partial class FormQuanLyDonNhap : Form
    {
        DataProvider dataProvider = new DataProvider();
        public FormQuanLyDonNhap()
        {
            InitializeComponent();
        }

        private void CapNhatBangHoaDon()
        {
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder("select sMaDonNhap[Mã đơn nhập]");
            qry.Append(",dNgayNhap[Ngày lập hoá đơn]");
            qry.Append(",sNguoiNhap[Người nhập]");
            qry.Append(" from tblDonNhap");
            dt = dataProvider.execQuery(qry.ToString());
            dgvQLDN.DataSource = dt;
        }

        private void dgvQLDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;

            if (rowID < 0)
            {
                rowID = 0;
            }

            if (rowID == dgvQLDN.Rows.Count - 1)
            {
                rowID -= 1;
            }

            DataGridViewRow row = dgvQLDN.Rows[rowID];
            txtMaDonNhap.Text = row.Cells[0].Value.ToString();
            dtpNgaylapHD.Value = DateTime.Parse(row.Cells[1].Value.ToString());
            txtTenNguoiNhap.Text = row.Cells[2].Value.ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonNhap, "");
            errLoi.SetError(dtpNgaylapHD, "");
            errLoi.SetError(txtTenNguoiNhap, "");

            DateTime dtnow = DateTime.Now;

            if (txtMaDonNhap.Text == "")
            {
                errLoi.SetError(txtMaDonNhap, "Chưa nhập mã đơn bán");
                return;
            }

            if (dtpNgaylapHD.Value > dtnow)
            {
                errLoi.SetError(dtpNgaylapHD, "Ngày lập không được lớn hơn ngày hiện tại");
                return;
            }

            if (txtTenNguoiNhap.Text == "")
            {
                errLoi.SetError(txtTenNguoiNhap, "Chưa có tên khách hàng");
                return;
            }

            DataTable dt = new DataTable();
            StringBuilder ktraTrungMaDB = new StringBuilder("select * from tblDonNhap where sMaDonNhap='" + txtMaDonNhap.Text + "'");
            dt = dataProvider.execQuery(ktraTrungMaDB.ToString());
            if (dt.Rows.Count > 0)
            {
                errLoi.SetError(txtMaDonNhap, "Đơn hàng này đã tồn tại");
                return;
            }
            else
            {
                StringBuilder qry = new StringBuilder("exec ThemDonNhap");
                qry.Append(" @MaDonNhap= '" + txtMaDonNhap.Text + "'");
                qry.Append(",@NgayLapHD= '" + dtpNgaylapHD.Value + "'");
                qry.Append(",@TenNguoiNhap= N'" + txtTenNguoiNhap.Text + "'");
                int kq = dataProvider.execNonQuery(qry.ToString());
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CapNhatBangHoaDon();
                }
                else
                {
                    MessageBox.Show("Không thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonNhap, "");
            errLoi.SetError(dtpNgaylapHD, "");
            errLoi.SetError(txtTenNguoiNhap, "");

            DateTime dtnow = DateTime.Now;

            if (txtMaDonNhap.Text == "")
            {
                errLoi.SetError(txtMaDonNhap, "Chưa nhập mã đơn bán");
                return;
            }

            if (dtpNgaylapHD.Value > dtnow)
            {
                errLoi.SetError(dtpNgaylapHD, "Ngày lập không được lớn hơn ngày hiện tại");
                return;
            }

            if (txtTenNguoiNhap.Text == "")
            {
                errLoi.SetError(txtTenNguoiNhap, "Chưa có tên khách hàng");
                return;
            }
            else
            {
                StringBuilder qry = new StringBuilder("exec SuaDonNhap");
                qry.Append(" @MaDonNhap= '" + txtMaDonNhap.Text + "'");
                qry.Append(",@NgayLapHD= '" + dtpNgaylapHD.Value + "'");
                qry.Append(",@TennguoiNhap= N'" + txtTenNguoiNhap.Text + "'");
                int kq = dataProvider.execNonQuery(qry.ToString());
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CapNhatBangHoaDon();
                }
                else
                {
                    MessageBox.Show("Không sửa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonNhap, "");

            if (txtMaDonNhap.Text == "")
            {
                errLoi.SetError(txtMaDonNhap, "Chưa nhập mã đơn bán");
                return;
            }
            else
            {
                StringBuilder qry = new StringBuilder("exec XoaDonNhap");
                qry.Append(" @MaDonNhap='" + txtMaDonNhap.Text + "'");
                int kq = dataProvider.execNonQuery(qry.ToString());
                if (kq > 0)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CapNhatBangHoaDon();
                }
                else
                {
                    MessageBox.Show("Không xoá được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnXemchiTiet_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonNhap, "");
            if (txtMaDonNhap.Text == "")
            {
                errLoi.SetError(txtMaDonNhap, "Chưa nhập mã đơn bán");
                return;
            }
            else
            {
                FormCTDN ctdn = new FormCTDN(txtMaDonNhap.Text);
                ctdn.ShowDialog();
            }
        }

        private void FormQuanLyDonNhap_Load(object sender, EventArgs e)
        {
            CapNhatBangHoaDon();
        }
    }
}
