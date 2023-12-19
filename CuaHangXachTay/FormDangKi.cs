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
    public partial class FormDangKi : Form
    {
        DataProvider dataProvider = new DataProvider();
        public FormDangKi()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtTenDangNhap, "");
            errLoi.SetError(txtHoTen, "");
            errLoi.SetError(txtMatKhau, "");
            errLoi.SetError(txtXacNhanMK, "");

            if (txtTenDangNhap.Text == "")
            {
                errLoi.SetError(txtTenDangNhap, "Bạn chưa nhập tên đăng nhập");
                return;
            }

            if (txtHoTen.Text == "")
            {
                errLoi.SetError(txtHoTen, "Bạn chưa nhập họ tên");
                return;
            }

            if (txtMatKhau.Text == "")
            {
                errLoi.SetError(txtMatKhau, "Hãy nhập mật khẩu");
                return;
            }

            if (txtXacNhanMK.Text == "")
            {
                errLoi.SetError(txtXacNhanMK, "Hãy xác nhận mật khẩu");
                return;
            }

            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select * from tblDangKi where");
            query.Append(" sTenDangNhap= '" + txtTenDangNhap.Text + "'");
            dt = dataProvider.execQuery(query.ToString());
            if (dt.Rows.Count > 0)
            {
                errLoi.SetError(txtTenDangNhap, "Tài khoản này đã tồn tại");
                return;
            }
            else
            {
                bool areEqual = txtMatKhau.Text.Equals(txtXacNhanMK.Text);

                if (areEqual)
                {
                    StringBuilder qry = new StringBuilder("exec Tao_Tai_Khoan");
                    qry.Append(" @TenDangNhap= '" + txtTenDangNhap.Text + "'");
                    qry.Append(",@AdMin= N'" + txtHoTen.Text + "'");
                    qry.Append(",@MatKhau= '" + txtMatKhau.Text + "'");
                    qry.Append(",@XacNhanMK= '" + txtXacNhanMK.Text + "'");

                    int kq = dataProvider.execNonQuery(qry.ToString());
                    if (kq > 0)
                    {
                        MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        FormDangNhap dangNhap = new FormDangNhap();
                        dangNhap.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng kí thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errLoi.SetError(txtXacNhanMK, "Mật khẩu của bạn không khớp nhau");
                    return;
                }
            }

        }
    }
}
