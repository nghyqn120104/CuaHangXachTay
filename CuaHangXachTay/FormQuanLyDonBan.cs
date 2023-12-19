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
    public partial class FormQuanLyDonBan : Form
    {
        DataProvider dataProvider = new DataProvider();
        public FormQuanLyDonBan()
        {
            InitializeComponent();
        }

        private void CapNhatBangHoaDon()
        {
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder("select sMaDonBan[Mã đơn bán]");
            qry.Append(",dNgayban[Ngày lập hoá đơn]");
            qry.Append(",sTenKhachHang[Tên khách hàng]");
            qry.Append(" from tblDonBan");
            dt = dataProvider.execQuery(qry.ToString());
            dgvQLDB.DataSource = dt;
        }

        private void FormQuanLyDonBan_Load(object sender, EventArgs e)
        {
            CapNhatBangHoaDon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonBan, "");
            errLoi.SetError(dtpNgaylapHD, "");
            errLoi.SetError(txtTenKhachHang, "");

            DateTime dtnow = DateTime.Now;

            if (txtMaDonBan.Text == "")
            {
                errLoi.SetError(txtMaDonBan, "Chưa nhập mã đơn bán");
                return;
            }

            if (dtpNgaylapHD.Value > dtnow)
            {
                errLoi.SetError(dtpNgaylapHD, "Ngày lập không được lớn hơn ngày hiện tại");
                return;
            }

            if (txtTenKhachHang.Text == "")
            {
                errLoi.SetError(txtTenKhachHang, "Chưa có tên khách hàng");
                return;
            }

            DataTable dt = new DataTable();
            StringBuilder ktraTrungMaDB = new StringBuilder("select * from tblDonBan where sMaDonBan='" + txtMaDonBan.Text + "'");
            dt = dataProvider.execQuery(ktraTrungMaDB.ToString());
            if (dt.Rows.Count > 0)
            {
                errLoi.SetError(txtMaDonBan, "Đơn hàng này đã tồn tại");
                return;
            }
            else
            {
                StringBuilder qry = new StringBuilder("exec ThemDonBan");
                qry.Append(" @MaDonBan= '" + txtMaDonBan.Text + "'");
                qry.Append(",@NgayLapHD= '" + dtpNgaylapHD.Value + "'");
                qry.Append(",@TenKhachHang= N'" + txtTenKhachHang.Text + "'");
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
            errLoi.SetError(txtMaDonBan, "");
            errLoi.SetError(dtpNgaylapHD, "");
            errLoi.SetError(txtTenKhachHang, "");

            DateTime dtnow = DateTime.Now;

            if (txtMaDonBan.Text == "")
            {
                errLoi.SetError(txtMaDonBan, "Chưa nhập mã đơn bán");
                return;
            }

            if (dtpNgaylapHD.Value > dtnow)
            {
                errLoi.SetError(dtpNgaylapHD, "Ngày lập không được lớn hơn ngày hiện tại");
                return;
            }

            if (txtTenKhachHang.Text == "")
            {
                errLoi.SetError(txtTenKhachHang, "Chưa có tên khách hàng");
                return;
            }
            else
            {
                StringBuilder qry = new StringBuilder("exec SuaDonBan");
                qry.Append(" @MaDonBan= '" + txtMaDonBan.Text + "'");
                qry.Append(",@NgayLapHD= '" + dtpNgaylapHD.Value + "'");
                qry.Append(",@TenKhachHang= N'" + txtTenKhachHang.Text + "'");
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
            errLoi.SetError(txtMaDonBan, "");

            if (txtMaDonBan.Text == "")
            {
                errLoi.SetError(txtMaDonBan, "Chưa nhập mã đơn bán");
                return;
            }
            else
            {
                StringBuilder qry = new StringBuilder("exec XoaDonBan");
                qry.Append(" @MaDonBan= '" + txtMaDonBan.Text + "'");
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

        private void dgvQLDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;

            if(rowID < 0)
            {
                rowID = 0;
            }

            if (rowID == dgvQLDB.Rows.Count - 1)
            {
                rowID -= 1;
            }

            DataGridViewRow row = dgvQLDB.Rows[rowID];
            txtMaDonBan.Text = row.Cells[0].Value.ToString();
            dtpNgaylapHD.Value = DateTime.Parse(row.Cells[1].Value.ToString());
            txtTenKhachHang.Text = row.Cells[2].Value.ToString();
        }

        private void btnXemchiTiet_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonBan, "");
            if (txtMaDonBan.Text == "")
            {
                errLoi.SetError(txtMaDonBan, "Chưa nhập mã đơn bán");
                return;
            }
            else
            {
                FormCTDB ctdb = new FormCTDB(txtMaDonBan.Text);
                ctdb.ShowDialog();
            }

        }
    }
}
