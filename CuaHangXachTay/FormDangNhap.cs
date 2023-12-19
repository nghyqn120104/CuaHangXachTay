using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangXachTay
{
    public partial class FormDangNhap : Form
    {

        private string adMin;
        DataProvider dataProvider = new DataProvider();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            FormDangKi dangKi = new FormDangKi();
            dangKi.ShowDialog();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            errLoi.SetError(txtTenDangNhap, "");
            errLoi.SetError(txtMatKhau, "");

            if (txtTenDangNhap.Text == "")
            {
                errLoi.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống");
                return;
            }

            if (txtMatKhau.Text == "")
            {
                errLoi.SetError(txtMatKhau, "Chưa nhập mật khẩu");
                return;
            }

            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select * from tblDangKi where");
            query.Append(" sTenDangNhap= '" + txtTenDangNhap.Text + "'");
            query.Append(" and sMatKhau= '" + txtMatKhau.Text + "'");
            dt = dataProvider.execQuery(query.ToString());
            if(dt.Rows.Count > 0)
            {
                adMin = dt.Rows[0]["sAdMin"].ToString();
                FormTrangChu trangChu = new FormTrangChu(adMin);
                trangChu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
