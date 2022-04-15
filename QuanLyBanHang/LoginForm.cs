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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == Globals.USERNAME && this.txtPass.Text == Globals.PASSWORD)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu", "Thông báo");
                this.txtUsername.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ans == DialogResult.OK) Application.Exit();
        }
    }
}
