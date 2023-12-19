
namespace CuaHangXachTay
{
    partial class FormCTDB
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
            this.lblMaDonBan = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMatHang = new System.Windows.Forms.Label();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDonBan = new System.Windows.Forms.TextBox();
            this.cmbLoaiHang = new System.Windows.Forms.ComboBox();
            this.cmbMatHang = new System.Windows.Forms.ComboBox();
            this.nmrGiaBan = new System.Windows.Forms.NumericUpDown();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.errLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTongSoMatHang = new System.Windows.Forms.TextBox();
            this.txtTongTienHang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaDonBan
            // 
            this.lblMaDonBan.AutoSize = true;
            this.lblMaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDonBan.Location = new System.Drawing.Point(95, 157);
            this.lblMaDonBan.Name = "lblMaDonBan";
            this.lblMaDonBan.Size = new System.Drawing.Size(163, 31);
            this.lblMaDonBan.TabIndex = 0;
            this.lblMaDonBan.Text = "Mã đơn bán:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(832, 240);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(115, 31);
            this.lblGhiChu.TabIndex = 1;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(511, 235);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(128, 31);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblMatHang
            // 
            this.lblMatHang.AutoSize = true;
            this.lblMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatHang.Location = new System.Drawing.Point(943, 157);
            this.lblMatHang.Name = "lblMatHang";
            this.lblMatHang.Size = new System.Drawing.Size(134, 31);
            this.lblMatHang.TabIndex = 3;
            this.lblMatHang.Text = "Mặt hàng:";
            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHang.Location = new System.Drawing.Point(511, 157);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(140, 31);
            this.lblLoaiHang.TabIndex = 4;
            this.lblLoaiHang.Text = "Loại hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá bán:";
            // 
            // txtMaDonBan
            // 
            this.txtMaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonBan.Location = new System.Drawing.Point(264, 150);
            this.txtMaDonBan.Name = "txtMaDonBan";
            this.txtMaDonBan.ReadOnly = true;
            this.txtMaDonBan.Size = new System.Drawing.Size(223, 38);
            this.txtMaDonBan.TabIndex = 6;
            // 
            // cmbLoaiHang
            // 
            this.cmbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiHang.FormattingEnabled = true;
            this.cmbLoaiHang.Location = new System.Drawing.Point(657, 150);
            this.cmbLoaiHang.Name = "cmbLoaiHang";
            this.cmbLoaiHang.Size = new System.Drawing.Size(250, 39);
            this.cmbLoaiHang.TabIndex = 7;
            this.cmbLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiHang_SelectedIndexChanged);
            this.cmbLoaiHang.Click += new System.EventHandler(this.cmbLoaiHang_Click);
            // 
            // cmbMatHang
            // 
            this.cmbMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMatHang.FormattingEnabled = true;
            this.cmbMatHang.Location = new System.Drawing.Point(1083, 149);
            this.cmbMatHang.Name = "cmbMatHang";
            this.cmbMatHang.Size = new System.Drawing.Size(250, 39);
            this.cmbMatHang.TabIndex = 8;
            this.cmbMatHang.SelectedIndexChanged += new System.EventHandler(this.cmbMatHang_SelectedIndexChanged);
            this.cmbMatHang.Click += new System.EventHandler(this.cmbMatHang_Click);
            // 
            // nmrGiaBan
            // 
            this.nmrGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrGiaBan.Location = new System.Drawing.Point(227, 228);
            this.nmrGiaBan.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrGiaBan.Name = "nmrGiaBan";
            this.nmrGiaBan.Size = new System.Drawing.Size(261, 38);
            this.nmrGiaBan.TabIndex = 9;
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrSoLuong.Location = new System.Drawing.Point(645, 233);
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(158, 38);
            this.nmrSoLuong.TabIndex = 10;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(949, 235);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(384, 38);
            this.txtGhiChu.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(312, 310);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 54);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(975, 310);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 54);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(648, 310);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 54);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(43, 423);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 82;
            this.dgvCTHD.RowTemplate.Height = 33;
            this.dgvCTHD.Size = new System.Drawing.Size(1412, 466);
            this.dgvCTHD.TabIndex = 15;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            // 
            // errLoi
            // 
            this.errLoi.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(669, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 63);
            this.lblTitle.TabIndex = 17;
            // 
            // txtTongSoMatHang
            // 
            this.txtTongSoMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoMatHang.Location = new System.Drawing.Point(227, 919);
            this.txtTongSoMatHang.Name = "txtTongSoMatHang";
            this.txtTongSoMatHang.ReadOnly = true;
            this.txtTongSoMatHang.Size = new System.Drawing.Size(1106, 38);
            this.txtTongSoMatHang.TabIndex = 18;
            // 
            // txtTongTienHang
            // 
            this.txtTongTienHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienHang.Location = new System.Drawing.Point(227, 987);
            this.txtTongTienHang.Name = "txtTongTienHang";
            this.txtTongTienHang.ReadOnly = true;
            this.txtTongTienHang.Size = new System.Drawing.Size(1106, 38);
            this.txtTongTienHang.TabIndex = 19;
            // 
            // FormCTDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 1055);
            this.Controls.Add(this.txtTongTienHang);
            this.Controls.Add(this.txtTongSoMatHang);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.nmrSoLuong);
            this.Controls.Add(this.nmrGiaBan);
            this.Controls.Add(this.cmbMatHang);
            this.Controls.Add(this.cmbLoaiHang);
            this.Controls.Add(this.txtMaDonBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLoaiHang);
            this.Controls.Add(this.lblMatHang);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblMaDonBan);
            this.Name = "FormCTDB";
            this.Text = "FormCTDB";
            this.Load += new System.EventHandler(this.FormCTDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaDonBan;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblMatHang;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDonBan;
        private System.Windows.Forms.ComboBox cmbLoaiHang;
        private System.Windows.Forms.ComboBox cmbMatHang;
        private System.Windows.Forms.NumericUpDown nmrGiaBan;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.ErrorProvider errLoi;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTongTienHang;
        private System.Windows.Forms.TextBox txtTongSoMatHang;
    }
}