
namespace CuaHangXachTay
{
    partial class FormQuanLyDonNhap
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
            this.dgvQLDN = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXemchiTiet = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgaylapHD = new System.Windows.Forms.DateTimePicker();
            this.txtTenNguoiNhap = new System.Windows.Forms.TextBox();
            this.txtMaDonNhap = new System.Windows.Forms.TextBox();
            this.lblNgayLapHoaDon = new System.Windows.Forms.Label();
            this.lblNguoiNhap = new System.Windows.Forms.Label();
            this.lblMaDonBan = new System.Windows.Forms.Label();
            this.errLoi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLDN
            // 
            this.dgvQLDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLDN.Location = new System.Drawing.Point(111, 341);
            this.dgvQLDN.Name = "dgvQLDN";
            this.dgvQLDN.RowHeadersWidth = 82;
            this.dgvQLDN.RowTemplate.Height = 33;
            this.dgvQLDN.Size = new System.Drawing.Size(883, 488);
            this.dgvQLDN.TabIndex = 21;
            this.dgvQLDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLDN_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1114, 82);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 47);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(908, 186);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 47);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXemchiTiet
            // 
            this.btnXemchiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemchiTiet.Location = new System.Drawing.Point(1085, 182);
            this.btnXemchiTiet.Name = "btnXemchiTiet";
            this.btnXemchiTiet.Size = new System.Drawing.Size(188, 47);
            this.btnXemchiTiet.TabIndex = 18;
            this.btnXemchiTiet.Text = "Xem chi tiết";
            this.btnXemchiTiet.UseVisualStyleBackColor = true;
            this.btnXemchiTiet.Click += new System.EventHandler(this.btnXemchiTiet_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(908, 82);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 47);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // dtpNgaylapHD
            // 
            this.dtpNgaylapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaylapHD.Location = new System.Drawing.Point(351, 109);
            this.dtpNgaylapHD.Name = "dtpNgaylapHD";
            this.dtpNgaylapHD.Size = new System.Drawing.Size(452, 38);
            this.dtpNgaylapHD.TabIndex = 16;
            // 
            // txtTenNguoiNhap
            // 
            this.txtTenNguoiNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiNhap.Location = new System.Drawing.Point(351, 191);
            this.txtTenNguoiNhap.Name = "txtTenNguoiNhap";
            this.txtTenNguoiNhap.Size = new System.Drawing.Size(452, 38);
            this.txtTenNguoiNhap.TabIndex = 15;
            // 
            // txtMaDonNhap
            // 
            this.txtMaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonNhap.Location = new System.Drawing.Point(351, 37);
            this.txtMaDonNhap.Name = "txtMaDonNhap";
            this.txtMaDonNhap.Size = new System.Drawing.Size(452, 38);
            this.txtMaDonNhap.TabIndex = 14;
            // 
            // lblNgayLapHoaDon
            // 
            this.lblNgayLapHoaDon.AutoSize = true;
            this.lblNgayLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLapHoaDon.Location = new System.Drawing.Point(119, 110);
            this.lblNgayLapHoaDon.Name = "lblNgayLapHoaDon";
            this.lblNgayLapHoaDon.Size = new System.Drawing.Size(240, 31);
            this.lblNgayLapHoaDon.TabIndex = 13;
            this.lblNgayLapHoaDon.Text = "Ngày lập hoá đơn: ";
            // 
            // lblNguoiNhap
            // 
            this.lblNguoiNhap.AutoSize = true;
            this.lblNguoiNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiNhap.Location = new System.Drawing.Point(119, 194);
            this.lblNguoiNhap.Name = "lblNguoiNhap";
            this.lblNguoiNhap.Size = new System.Drawing.Size(209, 31);
            this.lblNguoiNhap.TabIndex = 12;
            this.lblNguoiNhap.Text = "Tên người nhập:";
            // 
            // lblMaDonBan
            // 
            this.lblMaDonBan.AutoSize = true;
            this.lblMaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDonBan.Location = new System.Drawing.Point(119, 37);
            this.lblMaDonBan.Name = "lblMaDonBan";
            this.lblMaDonBan.Size = new System.Drawing.Size(185, 31);
            this.lblMaDonBan.TabIndex = 11;
            this.lblMaDonBan.Text = "Mã đơn nhập: ";
            // 
            // errLoi
            // 
            this.errLoi.ContainerControl = this;
            // 
            // FormQuanLyDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 1010);
            this.Controls.Add(this.dgvQLDN);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXemchiTiet);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgaylapHD);
            this.Controls.Add(this.txtTenNguoiNhap);
            this.Controls.Add(this.txtMaDonNhap);
            this.Controls.Add(this.lblNgayLapHoaDon);
            this.Controls.Add(this.lblNguoiNhap);
            this.Controls.Add(this.lblMaDonBan);
            this.Name = "FormQuanLyDonNhap";
            this.Text = "FormQuanLyDonNhap";
            this.Load += new System.EventHandler(this.FormQuanLyDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLDN;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXemchiTiet;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgaylapHD;
        private System.Windows.Forms.TextBox txtTenNguoiNhap;
        private System.Windows.Forms.TextBox txtMaDonNhap;
        private System.Windows.Forms.Label lblNgayLapHoaDon;
        private System.Windows.Forms.Label lblNguoiNhap;
        private System.Windows.Forms.Label lblMaDonBan;
        private System.Windows.Forms.ErrorProvider errLoi;
    }
}