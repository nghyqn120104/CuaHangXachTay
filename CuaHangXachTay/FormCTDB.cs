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
    public partial class FormCTDB : Form
    {
        DataProvider dataProvider = new DataProvider();
        private string MaLoaiHang, MaHang;

        public FormCTDB(string maDonBan)
        {
            InitializeComponent();
            HienDuLieuTongQuat(maDonBan);
        }

        private void HienDuLieuTongQuat(string maDonBan)
        {
            lblTitle.Text = "Chi tiết hoá đơn " + maDonBan;
            txtMaDonBan.Text = maDonBan;
            HienThiDuLieuCTDB(maDonBan);
            HienThiTongSoMatHang(maDonBan);
            HienThiTongTienHoaDon(maDonBan);
        }

        private void HienThiTongTienHoaDon(string maDonBan)
        {
            StringBuilder query = new StringBuilder("select sum(iSoLuong*fGiaBan)");
            query.Append(" from tblCTDB ");
            query.Append(" where sMaDonBan = '" + maDonBan + "'");
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

        private void HienThiTongSoMatHang(string maDonBan)
        {
            StringBuilder query = new StringBuilder("select count(*) from tblCTDB where sMaDonBan = '" + maDonBan + "'");
            int tongSoMatHang = Convert.ToInt32(dataProvider.execScaler(query.ToString()));
            txtTongSoMatHang.Text = "Tổng số lượng mặt hàng trong hoá đơn là: " + tongSoMatHang;
        }

        private void cmbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox loaiHang = sender as ComboBox;
            if (loaiHang.SelectedValue != null)
            {
                MaLoaiHang = loaiHang.SelectedValue.ToString();
            }
        }

        private void cmbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox matHang = sender as ComboBox;
            if (matHang.SelectedValue != null)
            {
                MaHang = matHang.SelectedValue.ToString();
            }
        }

        private void FormCTDB_Load(object sender, EventArgs e)
        {
            ChonLoaiHang();
        }

        private void HienThiTienMatHang(string maHang)
        {
            StringBuilder qry = new StringBuilder("select fGiaBan from tblMatHang where sTenHang=N'" + maHang + "'");
            int tienMatHang = Convert.ToInt32(dataProvider.execScaler(qry.ToString()));
            nmrGiaBan.Value = tienMatHang;
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

        private void cmbLoaiHang_Click(object sender, EventArgs e)
        {
            ChonMatHang();
        }
        private void HienThiDuLieuCTDB(string maDonBan)
        {
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder("select sMaDonBan[Mã đơn bán]");
            qry.Append(",sTenHang[Mặt hàng],sTenLoaiHang[Loại hàng],tblCTDB.fGiaban[Giá bán],iSoLuong[Số lượng],sGhiChu[Ghi chú]");
            qry.Append(" from tblCTDB,tblMatHang,tblLoaiHang");
            qry.Append(" where tblCTDB.sMaHang=tblMatHang.sMaHang and tblLoaiHang.sMaLoaiHang=tblMatHang.sMaLoaiHang and tblLoaiHang.sMaLoaiHang=tblCTDB.sMaLoaiHang and sMaDonBan='"+ maDonBan + "'");
            dt = dataProvider.execQuery(qry.ToString());
            dgvCTHD.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonBan, "");
            errLoi.SetError(cmbLoaiHang, "");
            errLoi.SetError(cmbMatHang, "");
            errLoi.SetError(nmrGiaBan, "");
            errLoi.SetError(nmrSoLuong, "");

            if (txtMaDonBan.Text == "")
            {
                errLoi.SetError(txtMaDonBan, "Mã đơn bán để chống");
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

            if (nmrGiaBan.Value == 0)
            {
                errLoi.SetError(nmrGiaBan, "Chưa có giá bán");
                return;
            }

            if (nmrSoLuong.Value == 0)
            {
                errLoi.SetError(nmrSoLuong, "Chưa nhập số lượng");
                return;
            }

            DataTable dt = new DataTable();
            StringBuilder ktraTrungLap = new StringBuilder("select * from tblCTDB where sMaDonBan='" + txtMaDonBan.Text + "' and sMaHang='" + MaHang + "'");
            dt = dataProvider.execQuery(ktraTrungLap.ToString());
            if (dt.Rows.Count > 0)
            {
                errLoi.SetError(cmbMatHang, "Mặt hàng này đã tồn tại trong đơn");
                return;
            }
            else
            {
                StringBuilder qry = new StringBuilder("exec ThemCTDB");
                qry.Append(" @MaDonBan= '" + txtMaDonBan.Text + "'");
                qry.Append(",@MaHang= " + MaHang);
                qry.Append(",@MaLoaiHang= " + MaLoaiHang);
                qry.Append(",@GiaBan= " + nmrGiaBan.Value);
                qry.Append(",@SoLuong= " + nmrSoLuong.Value);
                qry.Append(",@GhiChu=N'" + txtGhiChu.Text + "'");
                int kq = dataProvider.execNonQuery(qry.ToString());
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    HienDuLieuTongQuat(txtMaDonBan.Text);
                }
                else
                {
                    MessageBox.Show("Không thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonBan, "");
            errLoi.SetError(cmbLoaiHang, "");
            errLoi.SetError(cmbMatHang, "");
            errLoi.SetError(nmrGiaBan, "");
            errLoi.SetError(nmrSoLuong, "");

            if (txtMaDonBan.Text == "")
            {
                errLoi.SetError(txtMaDonBan, "Mã đơn bán để chống");
                return;
            }

            if (cmbMatHang.Text == "")
            {
                errLoi.SetError(cmbMatHang, "Mặt hàng để trống");
                return;
            }

            if (nmrGiaBan.Value == 0)
            {
                errLoi.SetError(nmrGiaBan, "Chưa có giá bán");
                return;
            }

            if (nmrSoLuong.Value == 0)
            {
                errLoi.SetError(nmrSoLuong, "Chưa nhập số lượng");
                return;
            }

            StringBuilder qry = new StringBuilder("exec SuaCTDB");
            qry.Append(" @MaDonBan= '" + txtMaDonBan.Text + "'");
            qry.Append(",@MaHang= " + MaHang);
            qry.Append(",@GiaBan= " + nmrGiaBan.Value);
            qry.Append(",@SoLuong= " + nmrSoLuong.Value);
            qry.Append(",@GhiChu=N'" + txtGhiChu.Text + "'");
            int kq = dataProvider.execNonQuery(qry.ToString());
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                HienDuLieuTongQuat(txtMaDonBan.Text);
            }
            else
            {
                MessageBox.Show("Không sửa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaDonBan, "");
            errLoi.SetError(cmbMatHang, "");
            if (txtMaDonBan.Text == "")
            {
                errLoi.SetError(txtMaDonBan, "Mã đơn bán để chống");
                return;
            }

            if (cmbMatHang.Text == "")
            {
                errLoi.SetError(cmbMatHang, "Mặt hàng để trống");
                return;
            }

            StringBuilder qry = new StringBuilder("exec XoaCTDB");
            qry.Append(" @MaDonBan= '" + txtMaDonBan.Text + "'");
            qry.Append(",@MaHang= " + MaHang);
            int kq = dataProvider.execNonQuery(qry.ToString());
            if (kq > 0)
            {
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                HienDuLieuTongQuat(txtMaDonBan.Text);
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

            if(rowID== dgvCTHD.Rows.Count - 1)
            {
                rowID -= 1;
            }

            DataGridViewRow row = dgvCTHD.Rows[rowID];
            txtMaDonBan.Text = row.Cells[0].Value.ToString();
            cmbMatHang.Text = row.Cells[1].Value.ToString();
            cmbLoaiHang.Text = row.Cells[2].Value.ToString();
            nmrGiaBan.Value = Convert.ToInt32(row.Cells[3].Value);
            nmrSoLuong.Value = Convert.ToInt32(row.Cells[4].Value);
            txtGhiChu.Text = row.Cells[5].Value.ToString();
        }

        private void cmbMatHang_Click(object sender, EventArgs e)
        {
            HienThiTienMatHang(cmbMatHang.Text);
        }


    }
}
