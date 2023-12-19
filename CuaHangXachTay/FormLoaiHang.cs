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
    public partial class FormLoaiHang : Form
    {
        DataProvider dataProvider = new DataProvider();
        public FormLoaiHang()
        {
            InitializeComponent();
        }

        // Thêm loại hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaLoaiHang, "");
            errLoi.SetError(txtLoaiHang, "");
            if (txtMaLoaiHang.Text == "")
            {
                errLoi.SetError(txtMaLoaiHang, "Mã loại hàng đang để trống");
                return;
            }

            DataTable ktraMaHang = new DataTable();
            StringBuilder testMaHang = new StringBuilder("select * from tblLoaiHang where sMaLoaiHang= '" + txtMaLoaiHang.Text + "'");
            ktraMaHang = dataProvider.execQuery(testMaHang.ToString());
            if(ktraMaHang.Rows.Count > 0)
            {
                errLoi.SetError(txtMaLoaiHang, "Mã hàng này đã tồn tại");
                return;
            }

            DataTable ktraMatHang = new DataTable();
            StringBuilder testMatHang = new StringBuilder("select * from tblLoaiHang where sTenLoaiHang= N'" + txtLoaiHang.Text + "'");
            ktraMatHang = dataProvider.execQuery(testMatHang.ToString());
            if(ktraMatHang.Rows.Count > 0)
            {
                errLoi.SetError(txtLoaiHang, "Mặt hàng này đã tồn tại");
                return;
            }

            StringBuilder qry = new StringBuilder("exec ThemLoaiHang");
            qry.Append(" @MaLoaiHang= '" + txtMaLoaiHang.Text + "'");
            qry.Append(",@TenLoaiHang= N'" + txtLoaiHang.Text + "'");
            int kq = dataProvider.execNonQuery(qry.ToString());
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CapNhatLoaiHang();
            }
            else
            {
                MessageBox.Show("Không thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cập nhật lại bảng loại hàng
        private void CapNhatLoaiHang()
        {
            StringBuilder qry = new StringBuilder("select sMaLoaiHang[Mã loại hàng],sTenLoaiHang[Loại hàng] from tblLoaiHang");
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery(qry.ToString());
            dgvLoaiHang.DataSource = dt;
        }

        private void FormLoaiHang_Load(object sender, EventArgs e)
        {
            CapNhatLoaiHang();
        }

        // Sửa loại hàng
        private void btnSua_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaLoaiHang, "");
            if (txtMaLoaiHang.Text == "")
            {
                errLoi.SetError(txtMaLoaiHang, "Mã loại hàng đang để trống");
                return;
            }
            StringBuilder qry = new StringBuilder("exec SuaLoaiHang");
            qry.Append(" @MaLoaiHang= '" + txtMaLoaiHang.Text + "'");
            qry.Append(",@TenLoaiHang= N'" + txtLoaiHang.Text + "'");
            int kq = dataProvider.execNonQuery(qry.ToString());
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CapNhatLoaiHang();
            }
            else
            {
                MessageBox.Show("Không sửa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Khi bấm vào, toàn bộ thông tin của loại hàng sẽ được chèn lên thành phần trong form
        private void dgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;

            if (rowID < 0)
            {
                rowID = 0;
            }

            if(rowID== dgvLoaiHang.Rows.Count - 1)
            {
                rowID -= 1;
            }

            DataGridViewRow row = dgvLoaiHang.Rows[rowID];
            txtMaLoaiHang.Text = row.Cells[0].Value.ToString();
            txtLoaiHang.Text = row.Cells[1].Value.ToString();
        }

        // Xoá mặt hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtMaLoaiHang, "");
            if (txtMaLoaiHang.Text == "")
            {
                errLoi.SetError(txtMaLoaiHang, "Mã loại hàng đang để trống");
                return;
            }
            StringBuilder qry = new StringBuilder("exec XoaLoaiHang");
            qry.Append(" @MaLoaiHang= '" + txtMaLoaiHang.Text + "'");
            int kq = dataProvider.execNonQuery(qry.ToString());
            if (kq > 0)
            {
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CapNhatLoaiHang();
            }
            else
            {
                MessageBox.Show("Không xoá được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
