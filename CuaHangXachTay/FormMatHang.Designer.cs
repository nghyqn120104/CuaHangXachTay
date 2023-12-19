
namespace CuaHangXachTay
{
    partial class FormMatHang
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
            this.lblMaHang = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblMatHang = new System.Windows.Forms.Label();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtMatHang = new System.Windows.Forms.TextBox();
            this.nmrGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.nmrGiaBan = new System.Windows.Forms.NumericUpDown();
            this.cmbLoaiHang = new System.Windows.Forms.ComboBox();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.cmbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.errLoi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHang.Location = new System.Drawing.Point(181, 43);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(126, 31);
            this.lblMaHang.TabIndex = 0;
            this.lblMaHang.Text = "Mã hàng:";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaNhap.Location = new System.Drawing.Point(566, 43);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(131, 31);
            this.lblGiaNhap.TabIndex = 1;
            this.lblGiaNhap.Text = "Giá nhập:";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.Location = new System.Drawing.Point(956, 46);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(116, 31);
            this.lblGiaBan.TabIndex = 2;
            this.lblGiaBan.Text = "Giá bán:";
            // 
            // lblMatHang
            // 
            this.lblMatHang.AutoSize = true;
            this.lblMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatHang.Location = new System.Drawing.Point(763, 142);
            this.lblMatHang.Name = "lblMatHang";
            this.lblMatHang.Size = new System.Drawing.Size(134, 31);
            this.lblMatHang.TabIndex = 4;
            this.lblMatHang.Text = "Mặt hàng:";
            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHang.Location = new System.Drawing.Point(282, 142);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(140, 31);
            this.lblLoaiHang.TabIndex = 5;
            this.lblLoaiHang.Text = "Loại hàng:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(313, 36);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(224, 38);
            this.txtMaHang.TabIndex = 6;
            // 
            // txtMatHang
            // 
            this.txtMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatHang.Location = new System.Drawing.Point(903, 140);
            this.txtMatHang.Name = "txtMatHang";
            this.txtMatHang.Size = new System.Drawing.Size(402, 38);
            this.txtMatHang.TabIndex = 7;
            // 
            // nmrGiaNhap
            // 
            this.nmrGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrGiaNhap.Location = new System.Drawing.Point(703, 37);
            this.nmrGiaNhap.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrGiaNhap.Name = "nmrGiaNhap";
            this.nmrGiaNhap.Size = new System.Drawing.Size(227, 38);
            this.nmrGiaNhap.TabIndex = 8;
            // 
            // nmrGiaBan
            // 
            this.nmrGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrGiaBan.Location = new System.Drawing.Point(1078, 36);
            this.nmrGiaBan.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmrGiaBan.Name = "nmrGiaBan";
            this.nmrGiaBan.Size = new System.Drawing.Size(227, 38);
            this.nmrGiaBan.TabIndex = 9;
            // 
            // cmbLoaiHang
            // 
            this.cmbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiHang.FormattingEnabled = true;
            this.cmbLoaiHang.Location = new System.Drawing.Point(428, 142);
            this.cmbLoaiHang.Name = "cmbLoaiHang";
            this.cmbLoaiHang.Size = new System.Drawing.Size(298, 39);
            this.cmbLoaiHang.TabIndex = 10;
            this.cmbLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiHang_SelectedIndexChanged);
            this.cmbLoaiHang.Click += new System.EventHandler(this.cmbLoaiHang_Click);
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Location = new System.Drawing.Point(187, 355);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.RowHeadersWidth = 82;
            this.dgvMatHang.RowTemplate.Height = 33;
            this.dgvMatHang.Size = new System.Drawing.Size(1118, 558);
            this.dgvMatHang.TabIndex = 11;
            this.dgvMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatHang_CellClick);
            // 
            // cmbTimKiem
            // 
            this.cmbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimKiem.FormattingEnabled = true;
            this.cmbTimKiem.Location = new System.Drawing.Point(598, 286);
            this.cmbTimKiem.Name = "cmbTimKiem";
            this.cmbTimKiem.Size = new System.Drawing.Size(261, 39);
            this.cmbTimKiem.TabIndex = 12;
            this.cmbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cmbTimKiem_SelectedIndexChanged);
            this.cmbTimKiem.Click += new System.EventHandler(this.cmbTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(371, 216);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 46);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(962, 216);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 46);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(655, 216);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 46);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // errLoi
            // 
            this.errLoi.ContainerControl = this;
            // 
            // FormMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 938);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbTimKiem);
            this.Controls.Add(this.dgvMatHang);
            this.Controls.Add(this.cmbLoaiHang);
            this.Controls.Add(this.nmrGiaBan);
            this.Controls.Add(this.nmrGiaNhap);
            this.Controls.Add(this.txtMatHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.lblLoaiHang);
            this.Controls.Add(this.lblMatHang);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblGiaNhap);
            this.Controls.Add(this.lblMaHang);
            this.Name = "FormMatHang";
            this.Text = "FormMatHang";
            this.Load += new System.EventHandler(this.FormMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblMatHang;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtMatHang;
        private System.Windows.Forms.NumericUpDown nmrGiaNhap;
        private System.Windows.Forms.NumericUpDown nmrGiaBan;
        private System.Windows.Forms.ComboBox cmbLoaiHang;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.ComboBox cmbTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ErrorProvider errLoi;
    }
}