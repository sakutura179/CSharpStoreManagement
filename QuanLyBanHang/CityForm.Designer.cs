
namespace QuanLyBanHang
{
    partial class CityForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCityName = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.dgvThanhPho = new System.Windows.Forms.DataGridView();
            this.ThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.txtCityName);
            this.panel.Controls.Add(this.txtCity);
            this.panel.Controls.Add(this.lbCityName);
            this.panel.Controls.Add(this.lbCity);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(292, 88);
            this.panel.TabIndex = 0;
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(120, 47);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(149, 20);
            this.txtCityName.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(120, 10);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(149, 20);
            this.txtCity.TabIndex = 2;
            // 
            // lbCityName
            // 
            this.lbCityName.AutoSize = true;
            this.lbCityName.Location = new System.Drawing.Point(15, 50);
            this.lbCityName.Name = "lbCityName";
            this.lbCityName.Size = new System.Drawing.Size(82, 13);
            this.lbCityName.TabIndex = 1;
            this.lbCityName.Text = "Tên Thành Phố";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(15, 13);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(60, 13);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "Thành Phố";
            // 
            // dgvThanhPho
            // 
            this.dgvThanhPho.AllowUserToAddRows = false;
            this.dgvThanhPho.AllowUserToDeleteRows = false;
            this.dgvThanhPho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhPho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhPho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThanhPho,
            this.TenThanhPho});
            this.dgvThanhPho.Location = new System.Drawing.Point(12, 106);
            this.dgvThanhPho.Name = "dgvThanhPho";
            this.dgvThanhPho.Size = new System.Drawing.Size(292, 185);
            this.dgvThanhPho.TabIndex = 1;
            // 
            // ThanhPho
            // 
            this.ThanhPho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ThanhPho.DataPropertyName = "ThanhPho";
            this.ThanhPho.Frozen = true;
            this.ThanhPho.HeaderText = "Mã thành phố";
            this.ThanhPho.Name = "ThanhPho";
            this.ThanhPho.Width = 125;
            // 
            // TenThanhPho
            // 
            this.TenThanhPho.DataPropertyName = "TenThanhPho";
            this.TenThanhPho.HeaderText = "Tên thành phố";
            this.TenThanhPho.Name = "TenThanhPho";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 297);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(116, 297);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(219, 297);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(13, 326);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(116, 326);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(219, 326);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(85, 23);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(291, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Trở Về";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 388);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvThanhPho);
            this.Controls.Add(this.panel);
            this.Name = "CityForm";
            this.Text = "Quản lý danh mục Thành Phố";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CityForm_FormClosing);
            this.Load += new System.EventHandler(this.CityForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCityName;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.DataGridView dgvThanhPho;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThanhPho;
    }
}