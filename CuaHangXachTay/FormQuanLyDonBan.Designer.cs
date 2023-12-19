
namespace CuaHangXachTay
{
    partial class FormQuanLyDonBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNgayLapHoaDon = new System.Windows.Forms.Label();
            this.txtMaDonBan = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.dtpNgaylapHD = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXemchiTiet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvQLDB = new System.Windows.Forms.DataGridView();
            this.errLoi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaDonBan
            // 
            this.lblMaDonBan.AutoSize = true;
            this.lblMaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDonBan.Location = new System.Drawing.Point(64, 37);
            this.lblMaDonBan.Name = "lblMaDonBan";
            this.lblMaDonBan.Size = new System.Drawing.Size(170, 31);
            this.lblMaDonBan.TabIndex = 0;
            this.lblMaDonBan.Text = "Mã đơn bán: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách hàng:";
            // 
            // lblNgayLapHoaDon
            // 
            this.lblNgayLapHoaDon.AutoSize = true;
            this.lblNgayLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLapHoaDon.Location = new System.Drawing.Point(64, 110);
            this.lblNgayLapHoaDon.Name = "lblNgayLapHoaDon";
            this.lblNgayLapHoaDon.Size = new System.Drawing.Size(240, 31);
            this.lblNgayLapHoaDon.TabIndex = 2;
            this.lblNgayLapHoaDon.Text = "Ngày lập hoá đơn: ";
            // 
            // txtMaDonBan
            // 
            this.txtMaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonBan.Location = new System.Drawing.Point(296, 37);
            this.txtMaDonBan.Name = "txtMaDonBan";
            this.txtMaDonBan.Size = new System.Drawing.Size(452, 38);
            this.txtMaDonBan.TabIndex = 3;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(296, 191);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(452, 38);
            this.txtTenKhachHang.TabIndex = 4;
            // 
            // dtpNgaylapHD
            // 
            this.dtpNgaylapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaylapHD.Location = new System.Drawing.Point(296, 109);
            this.dtpNgaylapHD.Name = "dtpNgaylapHD";
            this.dtpNgaylapHD.Size = new System.Drawing.Size(452, 38);
            this.dtpNgaylapHD.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(853, 82);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 47);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXemchiTiet
            // 
            this.btnXemchiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemchiTiet.Location = new System.Drawing.Point(1030, 182);
            this.btnXemchiTiet.Name = "btnXemchiTiet";
            this.btnXemchiTiet.Size = new System.Drawing.Size(188, 47);
            this.btnXemchiTiet.TabIndex = 7;
            this.btnXemchiTiet.Text = "Xem chi tiết";
            this.btnXemchiTiet.UseVisualStyleBackColor = true;
            this.btnXemchiTiet.Click += new System.EventHandler(this.btnXemchiTiet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(853, 186);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 47);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1059, 82);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 47);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvQLDB
            // 
            this.dgvQLDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLDB.Location = new System.Drawing.Point(70, 295);
            this.dgvQLDB.Name = "dgvQLDB";
            this.dgvQLDB.RowHeadersWidth = 82;
            this.dgvQLDB.RowTemplate.Height = 33;
            this.dgvQLDB.Size = new System.Drawing.Size(898, 488);
            this.dgvQLDB.TabIndex = 10;
            this.dgvQLDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLDB_CellClick);
            // 
            // errLoi
            // 
            this.errLoi.ContainerControl = this;
            // 
            // FormQuanLyDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 826);
            this.Controls.Add(this.dgvQLDB);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXemchiTiet);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgaylapHD);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtMaDonBan);
            this.Controls.Add(this.lblNgayLapHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaDonBan);
            this.Name = "FormQuanLyDonBan";
            this.Text = "FormQuanLyDonBan";
            this.Load += new System.EventHandler(this.FormQuanLyDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaDonBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNgayLapHoaDon;
        private System.Windows.Forms.TextBox txtMaDonBan;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgaylapHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXemchiTiet;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvQLDB;
        private System.Windows.Forms.ErrorProvider errLoi;
    }
}