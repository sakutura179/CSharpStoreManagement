
namespace QuanLyBanHang
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityManaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffManaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productManaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceManaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceDetailManaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.xemDanhMụcToolStripMenuItem,
            this.quảnLýDanhMụcĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.changePassToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Đăng xuất";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // changePassToolStripMenuItem
            // 
            this.changePassToolStripMenuItem.Name = "changePassToolStripMenuItem";
            this.changePassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePassToolStripMenuItem.Text = "Đổi mật khẩu";
            this.changePassToolStripMenuItem.Click += new System.EventHandler(this.changePassToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Thoát";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // xemDanhMụcToolStripMenuItem
            // 
            this.xemDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cityToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.productToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.invoiceDetailToolStripMenuItem});
            this.xemDanhMụcToolStripMenuItem.Name = "xemDanhMụcToolStripMenuItem";
            this.xemDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.xemDanhMụcToolStripMenuItem.Text = "Xem danh mục";
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cityToolStripMenuItem.Text = "Danh mục Thành Phố";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.customerToolStripMenuItem.Text = "Danh mục Khách Hàng";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.staffToolStripMenuItem.Text = "Danh mục Nhân Viên";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.productToolStripMenuItem.Text = "Danh mục Sản Phẩm";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.invoiceToolStripMenuItem.Text = "Danh mục Hóa Đơn";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // invoiceDetailToolStripMenuItem
            // 
            this.invoiceDetailToolStripMenuItem.Name = "invoiceDetailToolStripMenuItem";
            this.invoiceDetailToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.invoiceDetailToolStripMenuItem.Text = "Danh mục Chi Tiết Hóa Đơn";
            this.invoiceDetailToolStripMenuItem.Click += new System.EventHandler(this.invoiceDetailToolStripMenuItem_Click);
            // 
            // quảnLýDanhMụcĐơnToolStripMenuItem
            // 
            this.quảnLýDanhMụcĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cityManaToolStripMenuItem1,
            this.customerManaToolStripMenuItem1,
            this.staffManaToolStripMenuItem1,
            this.productManaToolStripMenuItem1,
            this.invoiceManaToolStripMenuItem1,
            this.invoiceDetailManaToolStripMenuItem1});
            this.quảnLýDanhMụcĐơnToolStripMenuItem.Name = "quảnLýDanhMụcĐơnToolStripMenuItem";
            this.quảnLýDanhMụcĐơnToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quảnLýDanhMụcĐơnToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // cityManaToolStripMenuItem1
            // 
            this.cityManaToolStripMenuItem1.Name = "cityManaToolStripMenuItem1";
            this.cityManaToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.cityManaToolStripMenuItem1.Text = "Danh mục Thành Phố";
            this.cityManaToolStripMenuItem1.Click += new System.EventHandler(this.cityManaToolStripMenuItem1_Click);
            // 
            // customerManaToolStripMenuItem1
            // 
            this.customerManaToolStripMenuItem1.Name = "customerManaToolStripMenuItem1";
            this.customerManaToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.customerManaToolStripMenuItem1.Text = "Danh mục Khách Hàng";
            this.customerManaToolStripMenuItem1.Click += new System.EventHandler(this.customerManaToolStripMenuItem1_Click);
            // 
            // staffManaToolStripMenuItem1
            // 
            this.staffManaToolStripMenuItem1.Name = "staffManaToolStripMenuItem1";
            this.staffManaToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.staffManaToolStripMenuItem1.Text = "Danh mục Nhân Viên";
            this.staffManaToolStripMenuItem1.Click += new System.EventHandler(this.staffManaToolStripMenuItem1_Click);
            // 
            // productManaToolStripMenuItem1
            // 
            this.productManaToolStripMenuItem1.Name = "productManaToolStripMenuItem1";
            this.productManaToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.productManaToolStripMenuItem1.Text = "Danh mục Sản Phẩm";
            this.productManaToolStripMenuItem1.Click += new System.EventHandler(this.productManaToolStripMenuItem1_Click);
            // 
            // invoiceManaToolStripMenuItem1
            // 
            this.invoiceManaToolStripMenuItem1.Name = "invoiceManaToolStripMenuItem1";
            this.invoiceManaToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.invoiceManaToolStripMenuItem1.Text = "Danh mục Hóa Đơn";
            this.invoiceManaToolStripMenuItem1.Click += new System.EventHandler(this.invoiceManaToolStripMenuItem1_Click);
            // 
            // invoiceDetailManaToolStripMenuItem1
            // 
            this.invoiceDetailManaToolStripMenuItem1.Name = "invoiceDetailManaToolStripMenuItem1";
            this.invoiceDetailManaToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.invoiceDetailManaToolStripMenuItem1.Text = "Danh mục Chi Tiết Hóa Đơn";
            this.invoiceDetailManaToolStripMenuItem1.Click += new System.EventHandler(this.invoiceDetailManaToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần mềm Quản Lý Bán Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(18, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(632, 66);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chào mừng quay trở lại";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 222);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityManaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerManaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staffManaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productManaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem invoiceManaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem invoiceDetailManaToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

