
namespace CuaHangXachTay
{
    partial class FormTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuQuanLy = new System.Windows.Forms.MenuStrip();
            this.ToolQLHH = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolQLLH = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolQLMH = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolQLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolQLDN = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolQLDX = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTaiKhoanDangNhap = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cmbLoaiHang = new System.Windows.Forms.ComboBox();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.mnuQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnuQuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolQLHH,
            this.ToolQLHD,
            this.ToolExit});
            this.mnuQuanLy.Location = new System.Drawing.Point(0, 0);
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(1835, 40);
            this.mnuQuanLy.TabIndex = 0;
            this.mnuQuanLy.Text = "menuStrip1";
            // 
            // ToolQLHH
            // 
            this.ToolQLHH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolQLLH,
            this.ToolQLMH});
            this.ToolQLHH.Name = "ToolQLHH";
            this.ToolQLHH.Size = new System.Drawing.Size(226, 36);
            this.ToolQLHH.Text = "Quản lý hàng hoá";
            // 
            // ToolQLLH
            // 
            this.ToolQLLH.Name = "ToolQLLH";
            this.ToolQLLH.Size = new System.Drawing.Size(253, 44);
            this.ToolQLLH.Text = "Loại hàng";
            this.ToolQLLH.Click += new System.EventHandler(this.ToolQLLH_Click);
            // 
            // ToolQLMH
            // 
            this.ToolQLMH.Name = "ToolQLMH";
            this.ToolQLMH.Size = new System.Drawing.Size(253, 44);
            this.ToolQLMH.Text = "Mặt hàng";
            this.ToolQLMH.Click += new System.EventHandler(this.ToolQLMH_Click);
            // 
            // ToolQLHD
            // 
            this.ToolQLHD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolQLDN,
            this.ToolQLDX});
            this.ToolQLHD.Name = "ToolQLHD";
            this.ToolQLHD.Size = new System.Drawing.Size(214, 36);
            this.ToolQLHD.Text = "Quản lý hoá đơn";
            // 
            // ToolQLDN
            // 
            this.ToolQLDN.Name = "ToolQLDN";
            this.ToolQLDN.Size = new System.Drawing.Size(255, 44);
            this.ToolQLDN.Text = "Đơn nhập";
            this.ToolQLDN.Click += new System.EventHandler(this.ToolQLDN_Click);
            // 
            // ToolQLDX
            // 
            this.ToolQLDX.Name = "ToolQLDX";
            this.ToolQLDX.Size = new System.Drawing.Size(255, 44);
            this.ToolQLDX.Text = "Đơn bán";
            this.ToolQLDX.Click += new System.EventHandler(this.ToolQLDX_Click);
            // 
            // ToolExit
            // 
            this.ToolExit.Name = "ToolExit";
            this.ToolExit.Size = new System.Drawing.Size(96, 36);
            this.ToolExit.Text = "Thoát";
            this.ToolExit.Click += new System.EventHandler(this.ToolExit_Click);
            // 
            // lblTaiKhoanDangNhap
            // 
            this.lblTaiKhoanDangNhap.AutoSize = true;
            this.lblTaiKhoanDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoanDangNhap.Location = new System.Drawing.Point(271, 108);
            this.lblTaiKhoanDangNhap.Name = "lblTaiKhoanDangNhap";
            this.lblTaiKhoanDangNhap.Size = new System.Drawing.Size(267, 31);
            this.lblTaiKhoanDangNhap.TabIndex = 1;
            this.lblTaiKhoanDangNhap.Text = "Tài khoản đăng nhập";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(277, 169);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(261, 38);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbLoaiHang
            // 
            this.cmbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiHang.FormattingEnabled = true;
            this.cmbLoaiHang.Location = new System.Drawing.Point(215, 234);
            this.cmbLoaiHang.Name = "cmbLoaiHang";
            this.cmbLoaiHang.Size = new System.Drawing.Size(383, 39);
            this.cmbLoaiHang.TabIndex = 4;
            this.cmbLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiHang_SelectedIndexChanged);
            this.cmbLoaiHang.Click += new System.EventHandler(this.cmbLoaiHang_Click);
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Location = new System.Drawing.Point(12, 307);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.RowHeadersWidth = 82;
            this.dgvMatHang.RowTemplate.Height = 33;
            this.dgvMatHang.Size = new System.Drawing.Size(745, 424);
            this.dgvMatHang.TabIndex = 5;
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 1138);
            this.Controls.Add(this.dgvMatHang);
            this.Controls.Add(this.cmbLoaiHang);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblTaiKhoanDangNhap);
            this.Controls.Add(this.mnuQuanLy);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuQuanLy;
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.mnuQuanLy.ResumeLayout(false);
            this.mnuQuanLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem ToolQLHH;
        private System.Windows.Forms.ToolStripMenuItem ToolQLHD;
        private System.Windows.Forms.ToolStripMenuItem ToolQLDN;
        private System.Windows.Forms.ToolStripMenuItem ToolQLDX;
        private System.Windows.Forms.ToolStripMenuItem ToolExit;
        private System.Windows.Forms.Label lblTaiKhoanDangNhap;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ToolStripMenuItem ToolQLLH;
        private System.Windows.Forms.ToolStripMenuItem ToolQLMH;
        private System.Windows.Forms.ComboBox cmbLoaiHang;
        private System.Windows.Forms.DataGridView dgvMatHang;
    }
}