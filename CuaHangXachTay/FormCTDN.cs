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
    public partial class FormCTDN : Form
    {
        DataProvider dataProvider = new DataProvider();
        private string MaLoaiHang, MaHang;
        public FormCTDN(string maDonNhap)
        {
            InitializeComponent();
            HienDuLieuTongQuat(maDonNhap);
        }

        private void HienDuLieuTongQuat(string maDonNhap)
        {
            lblTitle.Text = "Chi tiết hoá đơn " + maDonNhap;
            txtMaDonNhap.Text = maDonNhap;
            HienThiDuLieuCTDB(maDonNhap);
            HienThiTongSoMatHang(maDonNhap);
            HienThiTongTienHoaDon(maDonNhap);
        }

        private void HienThiTongTienHoaDon(string maDonNhap)
        {
            StringBuilder query = new StringBuilder("select sum(iSoLuong*fGiaNhap)");
            query.Append(" from tblCTDN ");
            query.Append(" where sMaDonNhap = '" + maDonNhap + "'");
            object tongTienHoaDon = dataProvider.execScaler(query.ToString());
            if (tongTienHoaDon == DBNull.Value)
            {
                txtTongTienHang.Text = "Tổng số tiền hoá đơn là: 0";
            }
            else
            {
                tongTienHoaDon = Convert.ToInt32(dataProvider.execScaler(query.ToString()));
                txtTongTienHang.Text = "Tổng số tiền hoá đơn là: " + tongTienHoaDon;
            }
        }

        private void HienThiTongSoMatHang(string maDonNhap)
        {
            StringBuilder query = new StringBuilder("select count(*) from tblCTDN where sMaDonNhap = '" + maDonNhap + "'");
            int tongSoMatHang = Convert.ToInt32(dataProvider.execScaler(query.ToString()));
            txtTongSoMatHang.Text = "Tổng số lượng mặt hàng trong hoá đơn là: " + tongSoMatHang;
        }

        private void HienThiTienMatHang(string maHang)
        {
            StringBuilder qry = new StringBuilder("select fGiaNhap from tblMatHang where sTenHang=N'" + maHang + "'");
            int tienMatHang = Convert.ToInt32(dataProvider.execScaler(qry.ToString()));
            nmrGiaNhap.Value = tienMatHang;
        }

        private void ChonMatHang()
        {
            if (cmbLoaiHang.Text == "")
            {
                DataTable dt = new DataTable();
                StringBuilder qry = new StringBuilder("select * from tblMatHang");
                dt = dataProvider.execQuery(qry.ToString());
                cmbMatHang.DisplayMember = "sTenHang";
                cmbMatHang.ValueMember = "sMaHang";
                cmbMatHang.DataSource = dt;
            }
            else
            {
                DataTable dta = new DataTable();
                StringBuilder query = new StringBuilder("select * from tblMatHang,tblLoaihang");
                query.Append(" where tblLoaiHang.sMaLoaiHang=tblMatHang.sMaLoaiHang");
                query.Append(" and sTenLoaiHang= N'" + cmbLoaiHang.Text + "'");
                dta = dataProvider.execQuery(query.ToString());
                cmbMatHang.DisplayMember = "sTenHang";
                cmbMatHang.ValueMember = "sMaHang";
                cmbMatHang.DataSource = dta;
            }
        }

        private void ChonLoaiHang()
        {
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder("select * from tblLoaiHang");
            dt = dataProvider.execQuery(qry.ToString());
            cmbLoaiHang.DisplayMember = "sTenLoaiHang";
            cmbLoaiHang.ValueMember = "sMaLoaiHang";
            cmbLoaiHang.DataSource = dt;
        }

        private void HienThiDuLieuCTDB(string maDonNhap)
        {
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder("select sMaDonNhap[Mã đơn nhập]");
            qry.Append(",sTenHang[Mặt hàng],sTenLoaiHang[Loại hàng],tblCTDN.fGiaNhap[Giá bán],iSoLuong[Số lượng],sGhiChu[Ghi chú]");
            qry.Append(" from tblCTDN,tblMatHang,tblLoaiHang");
            qry.Append(" where tblCTDN.sMaHang=tblMatHang.sMaHang and tblLoaiHang.sMaLoaiHang=tblMatHang.sMaLoaiHang and tblLoaiHang.sMaLoaiHang=tblCTDN.sMaLoaiHang and sMaDonNhap='" + maDonNhap + "'");
            dt = dataProvider.execQuery(qry.ToString());
            dgvCTHD.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonNhap, "");
            errLoi.SetError(cmbLoaiHang, "");
            errLoi.SetError(cmbMatHang, "");
            errLoi.SetError(nmrGiaNhap, "");
            errLoi.SetError(nmrSoLuong, "");

            if (txtMaDonNhap.Text == "")
            {
                errLoi.SetError(txtMaDonNhap, "Mã đơn bán để chống");
                return;
            }

            if (cmbMatHang.Text == "")
            {
                errLoi.SetError(cmbMatHang, "Mặt hàng để trống");
                return;
            }

            if (cmbLoaiHang.Text == "")
            {
                errLoi.SetError(cmbLoaiHang, "Loại hàng để trống");
                return;
            }

            if (nmrGiaNhap.Value == 0)
            {
                errLoi.SetError(nmrGiaNhap, "Chưa có giá bán");
                return;
            }

            if (nmrSoLuong.Value == 0)
            {
                errLoi.SetError(nmrSoLuong, "Chưa nhập số lượng");
                return;
            }

            DataTable dt = new DataTable();
            StringBuilder ktraTrungLap = new StringBuilder("select * from tblCTDN where sMaDonNhap='" + txtMaDonNhap.Text + "' and sMaHang='" + MaHang + "'");
            dt = dataProvider.execQuery(ktraTrungLap.ToString());
            if (dt.Rows.Count > 0)
            {
                errLoi.SetError(cmbMatHang, "Mặt hàng này đã tồn tại trong đơn");
                return;
            }
            else
            {
                StringBuilder qry = new StringBuilder("exec ThemCTDN");
                qry.Append(" @MaDonNhap= '" + txtMaDonNhap.Text + "'");
                qry.Append(",@MaHang= " + MaHang);
                qry.Append(",@MaLoaiHang= " + MaLoaiHang);
                qry.Append(",@GiaNhap= " + nmrGiaNhap.Value);
                qry.Append(",@SoLuong= " + nmrSoLuong.Value);
                qry.Append(",@GhiChu=N'" + txtGhiChu.Text + "'");
                int kq = dataProvider.execNonQuery(qry.ToString());
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    HienDuLieuTongQuat(txtMaDonNhap.Text);
                }
                else
                {
                    MessageBox.Show("Không thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonNhap, "");
            errLoi.SetError(cmbLoaiHang, "");
            errLoi.SetError(cmbMatHang, "");
            errLoi.SetError(nmrGiaNhap, "");
            errLoi.SetError(nmrSoLuong, "");

            if (txtMaDonNhap.Text == "")
            {
                errLoi.SetError(txtMaDonNhap, "Mã đơn bán để chống");
                return;
            }

            if (cmbMatHang.Text == "")
            {
                errLoi.SetError(cmbMatHang, "Mặt hàng để trống");
                return;
            }

            if (nmrGiaNhap.Value == 0)
            {
                errLoi.SetError(nmrGiaNhap, "Chưa có giá bán");
                return;
            }

            if (nmrSoLuong.Value == 0)
            {
                errLoi.SetError(nmrSoLuong, "Chưa nhập số lượng");
                return;
            }

            StringBuilder qry = new StringBuilder("exec SuaCTDN");
            qry.Append(" @MaDonNhap= '" + txtMaDonNhap.Text + "'");
            qry.Append(",@MaHang= " + MaHang);
            qry.Append(",@GiaNhap= " + nmrGiaNhap.Value);
            qry.Append(",@SoLuong= " + nmrSoLuong.Value);
            qry.Append(",@GhiChu=N'" + txtGhiChu.Text + "'");
            int kq = dataProvider.execNonQuery(qry.ToString());
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                HienDuLieuTongQuat(txtMaDonNhap.Text);
            }
            else
            {
                MessageBox.Show("Không sửa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonNhap, "");
            errLoi.SetError(cmbMatHang, "");
            if (txtMaDonNhap.Text == "")
            {
                errLoi.SetError(txtMaDonNhap, "Mã đơn bán để chống");
                return;
            }

            if (cmbMatHang.Text == "")
            {
                errLoi.SetError(cmbMatHang, "Mặt hàng để trống");
                return;
            }

            StringBuilder qry = new StringBuilder("exec XoaCTDN");
            qry.Append(" @MaDonNhap= '" + txtMaDonNhap.Text + "'");
            qry.Append(",@MaHang= " + MaHang);
            int kq = dataProvider.execNonQuery(qry.ToString());
            if (kq > 0)
            {
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                HienDuLieuTongQuat(txtMaDonNhap.Text);
            }
            else
            {
                MessageBox.Show("Không xoá được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0)
            {
                rowID = 0;
            }

            if (rowID == dgvCTHD.Rows.Count - 1)
            {
                rowID -= 1;
            }

            DataGridViewRow row = dgvCTHD.Rows[rowID];
            txtMaDonNhap.Text = row.Cells[0].Value.ToString();
            cmbMatHang.Text = row.Cells[1].Value.ToString();
            cmbLoaiHang.Text = row.Cells[2].Value.ToString();
            nmrGiaNhap.Value = Convert.ToInt32(row.Cells[3].Value);
            nmrSoLuong.Value = Convert.ToInt32(row.Cells[4].Value);
            txtGhiChu.Text = row.Cells[5].Value.ToString();
        }

        private void cmbMatHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox matHang = sender as ComboBox;
            if (matHang.SelectedValue != null)
            {
                MaHang = matHang.SelectedValue.ToString();
            }
        }

        private void FormCTDN_Load(object sender, EventArgs e)
        {
            ChonLoaiHang();
        }

        private void cmbLoaiHang_Click(object sender, EventArgs e)
        {
            ChonMatHang();
        }

        private void cmbMatHang_Click(object sender, EventArgs e)
        {
            HienThiTienMatHang(cmbMatHang.Text);
        }

        private void cmbLoaiHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox loaiHang = sender as ComboBox;
            if (loaiHang.SelectedValue != null)
            {
                MaLoaiHang = loaiHang.SelectedValue.ToString();
            }
        }
      
    }
}
