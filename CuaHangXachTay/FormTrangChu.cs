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
    public partial class FormTrangChu : Form
    {
        DataProvider dataProvider = new DataProvider();
        private string MaLoai;

        public FormTrangChu(string tkdn)
        {
            InitializeComponent();
            txtUser.Text = tkdn;
        }

        private void ToolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolQLLH_Click(object sender, EventArgs e)
        {
            FormLoaiHang loaiHang = new FormLoaiHang();
            loaiHang.MdiParent = this;
            loaiHang.Show();
        }

        private void ToolQLMH_Click(object sender, EventArgs e)
        {
            FormMatHang matHang = new FormMatHang();
            matHang.MdiParent = this;
            matHang.Show();
        }

        private void cmbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox loaiHang = sender as ComboBox;
            MaLoai = loaiHang.SelectedValue.ToString();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            HienMatHang();
            HienLoaiHang();
        }

        private void HienLoaiHang()
        {
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder("select * from tblLoaiHang");
            dt = dataProvider.execQuery(qry.ToString());
            cmbLoaiHang.DisplayMember = "sTenLoaiHang";
            cmbLoaiHang.ValueMember = "sMaLoaiHang";
            cmbLoaiHang.DataSource = dt;
        }

        private void HienMatHang()
        {
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder("select sTenLoaiHang[Loại hàng]");
            qry.Append(",sTenHang[Mặt hàng]");
            qry.Append(",fGiaBan[Giá bán]");
            qry.Append(" from tblMatHang,tblLoaiHang");
            qry.Append(" where tblLoaiHang.sMaLoaiHang=tblMatHang.sMaLoaiHang");
            dt = dataProvider.execQuery(qry.ToString());
            dgvMatHang.DataSource = dt;
        }

        private void cmbLoaiHang_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //StringBuilder qry = new StringBuilder("select sTenLoaiHang[Loại hàng]");
            //qry.Append(",sTenHang[Mặt hàng]");
            //qry.Append(",fGiaBan[Giá bán]");
            //qry.Append(" from tblMatHang,tblLoaiHang");
            //qry.Append(" where tblLoaiHang.sMaLoaiHang=tblMatHang.sMaLoaiHang");
            //qry.Append(" and sTenLoaiHang= N'" + cmbLoaiHang.Text + "'");
            //dt = dataProvider.execQuery(qry.ToString());
            //dgvMatHang.DataSource = dt;

            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder("exec TimKiemTheoLoaiHang");
            qry.Append(" @MaLoaiHang= " + MaLoai);
            dt=dataProvider.execQuery(qry.ToString());
            dgvMatHang.DataSource = dt;
        }

        private void ToolQLDX_Click(object sender, EventArgs e)
        {
            FormQuanLyDonBan quanLyDonBan = new FormQuanLyDonBan();
            quanLyDonBan.MdiParent = this;
            quanLyDonBan.Show();
        }

        private void ToolQLDN_Click(object sender, EventArgs e)
        {
            FormQuanLyDonNhap quanLyDonNhap = new FormQuanLyDonNhap();
            quanLyDonNhap.MdiParent = this;
            quanLyDonNhap.Show();
        }
    }
}
