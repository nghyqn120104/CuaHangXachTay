
namespace CuaHangXachTay
{
    partial class FormCTDN
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
            this.components = new System.ComponentModel.Container();
            this.txtTongTienHang = new System.Windows.Forms.TextBox();
            this.txtTongSoMatHang = new System.Windows.Forms.TextBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nmrGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.cmbMatHang = new System.Windows.Forms.ComboBox();
            this.cmbLoaiHang = new System.Windows.Forms.ComboBox();
            this.txtMaDonNhap = new System.Windows.Forms.TextBox();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.lblMatHang = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblMaDonBan = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errLoi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTongTienHang
            // 
            this.txtTongTienHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienHang.Location = new System.Drawing.Point(258, 989);
            this.txtTongTienHang.Name = "txtTongTienHang";
            this.txtTongTienHang.ReadOnly = true;
            this.txtTongTienHang.Size = new System.Drawing.Size(1106, 38);
            this.txtTongTienHang.TabIndex = 37;
            // 
            // txtTongSoMatHang
            // 
            this.txtTongSoMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoMatHang.Location = new System.Drawing.Point(258, 921);
            this.txtTongSoMatHang.Name = "txtTongSoMatHang";
            this.txtTongSoMatHang.ReadOnly = true;
            this.txtTongSoMatHang.Size = new System.Drawing.Size(1106, 38);
            this.txtTongSoMatHang.TabIndex = 36;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(74, 425);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 82;
            this.dgvCTHD.RowTemplate.Height = 33;
            this.dgvCTHD.Size = new System.Drawing.Size(1412, 466);
            this.dgvCTHD.TabIndex = 35;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(679, 312);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 54);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1006, 312);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 54);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(343, 312);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 54);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(980, 237);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(384, 38);
            this.txtGhiChu.TabIndex = 31;
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrSoLuong.Location = new System.Drawing.Point(676, 235);
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(158, 38);
            this.nmrSoLuong.TabIndex = 30;
            // 
            // nmrGiaNhap
            // 
            this.nmrGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrGiaNhap.Location = new System.Drawing.Point(258, 230);
            this.nmrGiaNhap.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrGiaNhap.Name = "nmrGiaNhap";
            this.nmrGiaNhap.Size = new System.Drawing.Size(261, 38);
            this.nmrGiaNhap.TabIndex = 29;
            // 
            // cmbMatHang
            // 
            this.cmbMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMatHang.FormattingEnabled = true;
            this.cmbMatHang.Location = new System.Drawing.Point(1114, 151);
            this.cmbMatHang.Name = "cmbMatHang";
            this.cmbMatHang.Size = new System.Drawing.Size(250, 39);
            this.cmbMatHang.TabIndex = 28;
            this.cmbMatHang.SelectedIndexChanged += new System.EventHandler(this.cmbMatHang_SelectedIndexChanged_1);
            this.cmbMatHang.Click += new System.EventHandler(this.cmbMatHang_Click);
            // 
            // cmbLoaiHang
            // 
            this.cmbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiHang.FormattingEnabled = true;
            this.cmbLoaiHang.Location = new System.Drawing.Point(688, 152);
            this.cmbLoaiHang.Name = "cmbLoaiHang";
            this.cmbLoaiHang.Size = new System.Drawing.Size(250, 39);
            this.cmbLoaiHang.TabIndex = 27;
            this.cmbLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiHang_SelectedIndexChanged_1);
            this.cmbLoaiHang.Click += new System.EventHandler(this.cmbLoaiHang_Click);
            // 
            // txtMaDonNhap
            // 
            this.txtMaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonNhap.Location = new System.Drawing.Point(295, 152);
            this.txtMaDonNhap.Name = "txtMaDonNhap";
            this.txtMaDonNhap.ReadOnly = true;
            this.txtMaDonNhap.Size = new System.Drawing.Size(223, 38);
            this.txtMaDonNhap.TabIndex = 26;
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaNhap.Location = new System.Drawing.Point(126, 237);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(123, 31);
            this.lblGiaNhap.TabIndex = 25;
            this.lblGiaNhap.Text = "Giá nhập";
            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHang.Location = new System.Drawing.Point(542, 159);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(140, 31);
            this.lblLoaiHang.TabIndex = 24;
            this.lblLoaiHang.Text = "Loại hàng:";
            // 
            // lblMatHang
            // 
            this.lblMatHang.AutoSize = true;
            this.lblMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatHang.Location = new System.Drawing.Point(974, 159);
            this.lblMatHang.Name = "lblMatHang";
            this.lblMatHang.Size = new System.Drawing.Size(134, 31);
            this.lblMatHang.TabIndex = 23;
            this.lblMatHang.Text = "Mặt hàng:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(542, 237);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(128, 31);
            this.lblSoLuong.TabIndex = 22;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(863, 242);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(115, 31);
            this.lblGhiChu.TabIndex = 21;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // lblMaDonBan
            // 
            this.lblMaDonBan.AutoSize = true;
            this.lblMaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDonBan.Location = new System.Drawing.Point(126, 159);
            this.lblMaDonBan.Name = "lblMaDonBan";
            this.lblMaDonBan.Size = new System.Drawing.Size(163, 31);
            this.lblMaDonBan.TabIndex = 20;
            this.lblMaDonBan.Text = "Mã đơn bán:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(661, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 63);
            this.lblTitle.TabIndex = 38;
            // 
            // errLoi
            // 
            this.errLoi.ContainerControl = this;
            // 
            // FormCTDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 1055);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTongTienHang);
            this.Controls.Add(this.txtTongSoMatHang);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.nmrSoLuong);
            this.Controls.Add(this.nmrGiaNhap);
            this.Controls.Add(this.cmbMatHang);
            this.Controls.Add(this.cmbLoaiHang);
            this.Controls.Add(this.txtMaDonNhap);
            this.Controls.Add(this.lblGiaNhap);
            this.Controls.Add(this.lblLoaiHang);
            this.Controls.Add(this.lblMatHang);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblMaDonBan);
            this.Name = "FormCTDN";
            this.Text = "FormCTDN";
            this.Load += new System.EventHandler(this.FormCTDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongTienHang;
        private System.Windows.Forms.TextBox txtTongSoMatHang;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.NumericUpDown nmrGiaNhap;
        private System.Windows.Forms.ComboBox cmbMatHang;
        private System.Windows.Forms.ComboBox cmbLoaiHang;
        private System.Windows.Forms.TextBox txtMaDonNhap;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.Label lblMatHang;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblMaDonBan;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errLoi;
    }
}