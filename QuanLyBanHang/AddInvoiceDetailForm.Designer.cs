
namespace QuanLyBanHang
{
    partial class AddInvoiceDetailForm
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
            this.btnThem = new System.Windows.Forms.Button();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbSL = new System.Windows.Forms.Label();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(428, 57);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 28);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Trở Về";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(339, 57);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 28);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Location = new System.Drawing.Point(28, 20);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(65, 13);
            this.lbMaHD.TabIndex = 0;
            this.lbMaHD.Text = "Mã hóa đơn";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Location = new System.Drawing.Point(280, 20);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(55, 13);
            this.lbMaSP.TabIndex = 1;
            this.lbMaSP.Text = "Sản phẩm";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(115, 62);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(28, 65);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(49, 13);
            this.lbSL.TabIndex = 4;
            this.lbSL.Text = "Số lượng";
            // 
            // cbMaHD
            // 
            this.cbMaHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(115, 17);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(121, 21);
            this.cbMaHD.TabIndex = 5;
            // 
            // cbMaSP
            // 
            this.cbMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(373, 17);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(121, 21);
            this.cbMaSP.TabIndex = 6;
            // 
            // AddInvoiceDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 111);
            this.Controls.Add(this.cbMaSP);
            this.Controls.Add(this.lbMaSP);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.cbMaHD);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbMaHD);
            this.Name = "AddInvoiceDetailForm";
            this.Text = "Thêm Chi Tiết Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddInvoiceDetailForm_FormClosing);
            this.Load += new System.EventHandler(this.AddInvoiceDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.ComboBox cbMaHD;
        private System.Windows.Forms.ComboBox cbMaSP;
    }
}