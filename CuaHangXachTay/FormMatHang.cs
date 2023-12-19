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
    public partial class FormMatHang : Form
    {
        DataProvider dataProvider = new DataProvider();
        private string MaLoai;
        private string MaLoaiHang;

        public FormMatHang()
        {
            InitializeComponent();
        }

        private void cmbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox loaiHang = sender as ComboBox;
            MaLoai = loaiHang.SelectedValue.ToString();
        }

        private void cmbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox timKiem = sender as ComboBox;
            MaLoaiHang = timKiem.SelectedValue.ToString();
        }

        private void ThanhTimKiem()
        {
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder("select * from tblLoaiHang");
            dt = dataProvider.execQuery(qry.ToString());
            cmbTimKiem.DisplayMember = "sTenLoaiHang";
            cmbTimKiem.ValueMember = "sMaLoaiHang";
            cmbTimKiem.DataSource = dt;
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

        private void FormMatHang_Load(object sender, EventArgs e)
        {
            ChonLoaiHang();
            CapNhatBangMatHang();
            ThanhTimKiem();
        }

        private void CapNhatBangMatHang()
        {
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder("select sMaHang[Mã hàng],sTenLoaiHang[Loại hàng]");
            qry.Append(",sTenHang[Tên mặt hàng]");
            qry.Append(",fGiaBan[Giá bán]");
            qry.Append(",fGiaNhap[Giá nhập]");
            qry.Append(" from tblMatHang,tblLoaiHang ");
            qry.Append(" where tblLoaiHang.sMaLoaiHang=tblMatHang.sMaLoaiHang");
            dt = dataProvider.execQuery(qry.ToString());
            dgvMatHang.DataSource = dt;
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;

            if (rowID < 0)
            {
                rowID = 0;
            }

            if (rowID == dgvMatHang.Rows.Count - 1)
            {
                rowID -= 1;
            }

            DataGridViewRow row = dgvMatHang.Rows[rowID];
            txtMaHang.Text = row.Cells[0].Value.ToString();
            cmbLoaiHang.Text = row.Cells[1].Value.ToString();
            txtMatHang.Text = row.Cells[2].Value.ToString();
            nmrGiaBan.Value = Convert.ToInt32(row.Cells[3].Value);
            nmrGiaNhap.Value = Convert.ToInt32(row.Cells[4].Value);
        }

        private void cmbTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder("select sMaHang[Mã hàng],sTenLoaiHang[Loại hàng]");
            qry.Append(",sTenHang[Tên mặt hàng]");
            qry.Append(",fGiaBan[Giá bán]");
            qry.Append(",fGiaNhap[Giá nhập]");
            qry.Append(" from tblMatHang,tblLoaiHang ");
            qry.Append(" where tblLoaiHang.sMaLoaiHang=tblMatHang.sMaLoaiHang");
            qry.Append(" and sTenLoaiHang= N'"+cmbTimKiem.Text+"'");
            dt = dataProvider.execQuery(qry.ToString());
            dgvMatHang.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaHang, "");
            errLoi.SetError(txtMatHang,"");
            errLoi.SetError(nmrGiaNhap, "");
            errLoi.SetError(nmrGiaBan, "");

            if (txtMaHang.Text == "")
            {
                errLoi.SetError(txtMaHang, "Mã hàng đang để trống");
                return;
            }

            if (txtMatHang.Text == "")
            {
                errLoi.SetError(txtMatHang, "Mặt hàng để trống");
                return;
            }

            if (nmrGiaBan.Value == 0)
            {
                errLoi.SetError(nmrGiaBan, "Chưa lập giá bán");
                return;
            }

            if (nmrGiaNhap.Value == 0)
            {
                errLoi.SetError(nmrGiaNhap, "Chưa lập giá nhập");
                return;
            }

            DataTable testMaHang = new DataTable();
            StringBuilder ktraMaHang = new StringBuilder("select * from tblMatHang where sMaHang= '" + txtMaHang.Text + "'");
            testMaHang = dataProvider.execQuery(ktraMaHang.ToString());
            if (testMaHang.Rows.Count > 0)
            {
                errLoi.SetError(txtMaHang, "Mã hàng này đã tồn tại");
                return;
            }

            DataTable testMatHang = new DataTable();
            StringBuilder ktraMatHang = new StringBuilder("select * from tblMatHang where sTenHang= N'" + txtMatHang.Text + "'");
            testMatHang = dataProvider.execQuery(ktraMatHang.ToString());

            if (testMatHang.Rows.Count > 0)
            {
                errLoi.SetError(txtMatHang, "Mặt hàng này đã tồn tại");
                return;
            }
            else
            {
                StringBuilder qry = new StringBuilder("exec ThemMatHang");
                qry.Append(" @MaHang= '" + txtMaHang.Text + "'");
                qry.Append(",@TenHang= N'" + txtMatHang.Text + "'");
                qry.Append(",@MaLoaiHang= " + MaLoai);
                qry.Append(",@GiaNhap= " + nmrGiaNhap.Value);
                qry.Append(",@GiaBan= " + nmrGiaBan.Value);
                int kq = dataProvider.execNonQuery(qry.ToString());
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CapNhatBangMatHang();
                }
                else
                {
                    MessageBox.Show("Không thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaHang, "");
            errLoi.SetError(txtMatHang, "");
            errLoi.SetError(nmrGiaNhap, "");
            errLoi.SetError(nmrGiaBan, "");

            if (txtMaHang.Text == "")
            {
                errLoi.SetError(txtMaHang, "Mã hàng đang để trống");
                return;
            }

            if (txtMatHang.Text == "")
            {
                errLoi.SetError(txtMatHang, "Mặt hàng để trống");
                return;
            }

            if (nmrGiaBan.Value == 0)
            {
                errLoi.SetError(nmrGiaBan, "Chưa lập giá bán");
                return;
            }

            if (nmrGiaNhap.Value == 0)
            {
                errLoi.SetError(nmrGiaNhap, "Chưa lập giá nhập");
                return;
            }

            StringBuilder qry = new StringBuilder("exec SuaMatHang");
            qry.Append(" @MaHang= '" + txtMaHang.Text + "'");
            qry.Append(",@TenHang= N'" + txtMatHang.Text + "'");
            qry.Append(",@GiaBan= " + nmrGiaBan.Value);
            qry.Append(",@GiaNhap= " + nmrGiaNhap.Value);
            int kq = dataProvider.execNonQuery(qry.ToString());
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CapNhatBangMatHang();
            }
            else
            {
                MessageBox.Show("Không sửa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaHang, "");
            if (txtMaHang.Text == "")
            {
                errLoi.SetError(txtMaHang, "Mã hàng đang để trống");
                return;
            }

            StringBuilder qry = new StringBuilder("exec XoaMatHang");
            qry.Append(" @MaHang= '" + txtMaHang.Text + "'");
            int kq = dataProvider.execNonQuery(qry.ToString());
            if (kq > 0)
            {
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CapNhatBangMatHang();
            }
            else
            {
                MessageBox.Show("Không xoá được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLoaiHang_Click(object sender, EventArgs e)
        {
            HienThiMaHangHoa(cmbLoaiHang.Text);
        }

        private void HienThiMaHangHoa(string text)
        {
            StringBuilder qry = new StringBuilder("select sMaLoaiHang from tblLoaiHang where sMaLoaiHang=N'" + MaLoai + "'");
            string maHang = (string)dataProvider.execScaler(qry.ToString());
            txtMaHang.Text = maHang;
        }
    }
}
