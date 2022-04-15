
namespace QuanLyBanHang
{
    partial class InvoiceForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.dateNgayLHD = new System.Windows.Forms.DateTimePicker();
            this.lbNgayNH = new System.Windows.Forms.Label();
            this.lbNgayLHD = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dateNgayNH = new System.Windows.Forms.DateTimePicker();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(673, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 28);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.NgayLapHD,
            this.NgayNhanHang});
            this.dgvHoaDon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHoaDon.Location = new System.Drawing.Point(13, 161);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.Size = new System.Drawing.Size(726, 282);
            this.dgvHoaDon.TabIndex = 23;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(13, 461);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(66, 28);
            this.btnReload.TabIndex = 22;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dateNgayLHD
            // 
            this.dateNgayLHD.Location = new System.Drawing.Point(517, 11);
            this.dateNgayLHD.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateNgayLHD.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateNgayLHD.Name = "dateNgayLHD";
            this.dateNgayLHD.Size = new System.Drawing.Size(178, 20);
            this.dateNgayLHD.TabIndex = 13;
            this.dateNgayLHD.Value = new System.DateTime(2022, 4, 15, 0, 0, 0, 0);
            // 
            // lbNgayNH
            // 
            this.lbNgayNH.AutoSize = true;
            this.lbNgayNH.Location = new System.Drawing.Point(396, 62);
            this.lbNgayNH.Name = "lbNgayNH";
            this.lbNgayNH.Size = new System.Drawing.Size(86, 13);
            this.lbNgayNH.TabIndex = 10;
            this.lbNgayNH.Text = "Ngày nhận hàng";
            // 
            // lbNgayLHD
            // 
            this.lbNgayLHD.AutoSize = true;
            this.lbNgayLHD.Location = new System.Drawing.Point(396, 17);
            this.lbNgayLHD.Name = "lbNgayLHD";
            this.lbNgayLHD.Size = new System.Drawing.Size(92, 13);
            this.lbNgayLHD.TabIndex = 8;
            this.lbNgayLHD.Text = "Ngày lập hóa đơn";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(10, 62);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(65, 13);
            this.lbMaKH.TabIndex = 7;
            this.lbMaKH.Text = "Khách hàng";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(10, 107);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(56, 13);
            this.lbMaNV.TabIndex = 6;
            this.lbMaNV.Text = "Nhân viên";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Location = new System.Drawing.Point(10, 21);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(65, 13);
            this.lbMaHD.TabIndex = 5;
            this.lbMaHD.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(119, 14);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(513, 461);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(66, 28);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(413, 461);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 28);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(213, 461);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(66, 28);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(113, 461);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 28);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.cbMaNV);
            this.panel.Controls.Add(this.cbMaKH);
            this.panel.Controls.Add(this.dateNgayNH);
            this.panel.Controls.Add(this.dateNgayLHD);
            this.panel.Controls.Add(this.lbNgayNH);
            this.panel.Controls.Add(this.lbNgayLHD);
            this.panel.Controls.Add(this.lbMaKH);
            this.panel.Controls.Add(this.lbMaNV);
            this.panel.Controls.Add(this.lbMaHD);
            this.panel.Controls.Add(this.txtMaHD);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(13, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(726, 143);
            this.panel.TabIndex = 24;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(313, 461);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 28);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dateNgayNH
            // 
            this.dateNgayNH.Location = new System.Drawing.Point(517, 55);
            this.dateNgayNH.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateNgayNH.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateNgayNH.Name = "dateNgayNH";
            this.dateNgayNH.Size = new System.Drawing.Size(178, 20);
            this.dateNgayNH.TabIndex = 14;
            this.dateNgayNH.Value = new System.DateTime(2022, 4, 15, 0, 0, 0, 0);
            // 
            // cbMaKH
            // 
            this.cbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(119, 54);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(206, 21);
            this.cbMaKH.TabIndex = 15;
            // 
            // cbMaNV
            // 
            this.cbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(119, 99);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(206, 21);
            this.cbMaNV.TabIndex = 16;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.Frozen = true;
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaKH.Width = 200;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaNV.Width = 150;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Ngày lập hóa đơn";
            this.NgayLapHD.Name = "NgayLapHD";
            this.NgayLapHD.ReadOnly = true;
            this.NgayLapHD.Width = 115;
            // 
            // NgayNhanHang
            // 
            this.NgayNhanHang.DataPropertyName = "NgayNhanHang";
            this.NgayNhanHang.HeaderText = "Ngày nhận hàng";
            this.NgayNhanHang.Name = "NgayNhanHang";
            this.NgayNhanHang.ReadOnly = true;
            this.NgayNhanHang.Width = 115;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 501);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnXoa);
            this.Name = "InvoiceForm";
            this.Text = "Quản lý danh mục Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InvoiceForm_FormClosing);
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DateTimePicker dateNgayLHD;
        private System.Windows.Forms.Label lbNgayNH;
        private System.Windows.Forms.Label lbNgayLHD;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DateTimePicker dateNgayNH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanHang;
    }
}