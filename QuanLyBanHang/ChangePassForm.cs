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
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.txtOldPass.Text == Globals.PASSWORD)
            {
                Globals.PASSWORD = this.txtNewPass.Text;
                MessageBox.Show("Đã đổi mật khẩu thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Không đúng mật khẩu", "Thông báo");
                this.txtOldPass.Focus();
            }
        }
    }
}
