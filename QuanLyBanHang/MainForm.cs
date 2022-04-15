using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void frmLogin()
        {
            Form loginFrm = new LoginForm();
            loginFrm.ShowDialog();
        }

        private void XemDanhMuc(int index)
        {
            Form frm = new CatalogForm();
            frm.Text = index.ToString();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            frmLogin();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ans == DialogResult.OK) Application.Exit();
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }

        private void invoiceDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void cityManaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form cityFrm = new CityForm();
            cityFrm.ShowDialog();
        }

        private void customerManaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form customerFrm = new CustomerForm();
            customerFrm.ShowDialog();
        }

        private void staffManaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form staffFrm = new StaffForm();
            staffFrm.ShowDialog();
        }

        private void productManaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form productFrm = new ProductForm();
            productFrm.ShowDialog();
        }

        private void invoiceManaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form invoiceFrm = new InvoiceForm();
            invoiceFrm.ShowDialog();
        }

        private void invoiceDetailManaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form invoiceDetailFrm = new InvoiceDetailForm();
            invoiceDetailFrm.ShowDialog();
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form changePassFrm = new ChangePassForm();
            changePassFrm.ShowDialog();
        }
    }
}
