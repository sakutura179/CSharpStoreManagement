
namespace QuanLyBanHang
{
    partial class StaffForm
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lbNgayNV = new System.Windows.Forms.Label();
            this.lbHo = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.chkNu = new System.Windows.Forms.CheckBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dateNgayNV = new System.Windows.Forms.DateTimePicker();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NgayNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(513, 461);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(66, 28);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(413, 461);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 28);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(213, 461);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(66, 28);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(113, 461);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 28);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(557, 21);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lbDienThoai.TabIndex = 9;
            this.lbDienThoai.Text = "Điện thoại";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.dateNgayNV);
            this.panel.Controls.Add(this.txtDiaChi);
            this.panel.Controls.Add(this.chkNu);
            this.panel.Controls.Add(this.lbDiaChi);
            this.panel.Controls.Add(this.lbDienThoai);
            this.panel.Controls.Add(this.lbNgayNV);
            this.panel.Controls.Add(this.lbHo);
            this.panel.Controls.Add(this.lbTen);
            this.panel.Controls.Add(this.lbMaNV);
            this.panel.Controls.Add(this.txtDienThoai);
            this.panel.Controls.Add(this.txtMaNV);
            this.panel.Controls.Add(this.txtHo);
            this.panel.Controls.Add(this.txtTen);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(13, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(793, 143);
            this.panel.TabIndex = 15;
            // 
            // lbNgayNV
            // 
            this.lbNgayNV.AutoSize = true;
            this.lbNgayNV.Location = new System.Drawing.Point(260, 63);
            this.lbNgayNV.Name = "lbNgayNV";
            this.lbNgayNV.Size = new System.Drawing.Size(82, 13);
            this.lbNgayNV.TabIndex = 8;
            this.lbNgayNV.Text = "Ngày nhận việc";
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Location = new System.Drawing.Point(10, 62);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(65, 13);
            this.lbHo.TabIndex = 7;
            this.lbHo.Text = "Họ và họ lót";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(10, 107);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(26, 13);
            this.lbTen.TabIndex = 6;
            this.lbTen.Text = "Tên";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(10, 21);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(40, 13);
            this.lbMaNV.TabIndex = 5;
            this.lbMaNV.Text = "Mã NV";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(634, 18);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(120, 20);
            this.txtDienThoai.TabIndex = 4;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(85, 14);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(85, 59);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(157, 20);
            this.txtHo.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(85, 100);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(157, 20);
            this.txtTen.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(313, 461);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 28);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(740, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 28);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(13, 461);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(66, 28);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Ho,
            this.Ten,
            this.Nu,
            this.NgayNV,
            this.DiaChi,
            this.DienThoai});
            this.dgvNhanVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNhanVien.Location = new System.Drawing.Point(13, 161);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.Size = new System.Drawing.Size(793, 282);
            this.dgvNhanVien.TabIndex = 14;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(260, 107);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lbDiaChi.TabIndex = 10;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Location = new System.Drawing.Point(263, 14);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(40, 17);
            this.chkNu.TabIndex = 11;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(358, 100);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(396, 20);
            this.txtDiaChi.TabIndex = 12;
            // 
            // dateNgayNV
            // 
            this.dateNgayNV.Location = new System.Drawing.Point(358, 57);
            this.dateNgayNV.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateNgayNV.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateNgayNV.Name = "dateNgayNV";
            this.dateNgayNV.Size = new System.Drawing.Size(178, 20);
            this.dateNgayNV.TabIndex = 13;
            this.dateNgayNV.Value = new System.DateTime(2022, 4, 12, 8, 41, 8, 0);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.Frozen = true;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // Ho
            // 
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ và chữ lót";
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Nu
            // 
            this.Nu.DataPropertyName = "Nu";
            this.Nu.HeaderText = "Nữ";
            this.Nu.Name = "Nu";
            this.Nu.ReadOnly = true;
            this.Nu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Nu.Width = 50;
            // 
            // NgayNV
            // 
            this.NgayNV.DataPropertyName = "NgayNV";
            this.NgayNV.HeaderText = "Ngày nhận việc";
            this.NgayNV.Name = "NgayNV";
            this.NgayNV.ReadOnly = true;
            this.NgayNV.Width = 200;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 200;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 501);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvNhanVien);
            this.Name = "StaffForm";
            this.Text = "Quản lý danh mục Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffForm_FormClosing);
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DateTimePicker dateNgayNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.CheckBox chkNu;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbNgayNV;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
    }
}