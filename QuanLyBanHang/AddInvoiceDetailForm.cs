using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public partial class AddInvoiceDetailForm : Form
    {
        public AddInvoiceDetailForm()
        {
            InitializeComponent();
        }

        private readonly string strConnect = "Data Source=DESKTOP-I9NU0H3; Initial Catalog=QuanLyBanHang; Integrated Security=True";
        SqlConnection conn = null;

        SqlDataAdapter daHoaDon = null;
        DataTable dtHoaDon = null;

        SqlDataAdapter daSanPham = null;
        DataTable dtSanPham = null;

        String maHD;

        private void LoadData()
        {
            // Dua DL len comboBox panel
            this.cbMaHD.DataSource = dtHoaDon;
            this.cbMaHD.DisplayMember = "MaHD";
            this.cbMaHD.ValueMember = "MaHD";

            this.cbMaSP.DataSource = dtSanPham;
            this.cbMaSP.DisplayMember = "TenSP";
            this.cbMaSP.ValueMember = "MaSP";

            this.cbMaHD.SelectedValue = maHD;
            if (this.cbMaSP.DataSource != null) this.cbMaSP.SelectedIndex = 0;
            this.cbMaHD.Enabled = false;
            this.txtSoLuong.ResetText();
        }

        private void AddInvoiceDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn = null;
        }

        private void AddInvoiceDetailForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnect);

                daHoaDon = new SqlDataAdapter("select MaHD from HoaDon", conn);
                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
                daHoaDon.Fill(dtHoaDon);

                daSanPham = new SqlDataAdapter("select MaSP, TenSP from SanPham", conn);
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                daSanPham.Fill(dtSanPham);

                maHD = this.Text.ToString();
                this.Text = "Thêm Chi Tiết Sản Phẩm";
                LoadData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không thể kết nối đến CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (
                    this.txtSoLuong.Text == ""
                )
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = System.String.Concat("Insert into ChiTietHoaDon Values (" + "'" +
                            this.cbMaHD.SelectedValue.ToString() + "', '" +
                            this.cbMaSP.SelectedValue.ToString() + "', '" +
                            this.txtSoLuong.Text.ToString() + "')"
                        );
                    cmd.CommandType = CommandType.Text;
                    // System.Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã thêm thành công", "Thông báo");
                    LoadData();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
        }
    }
}
