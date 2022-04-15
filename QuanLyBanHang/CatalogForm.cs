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
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        string strConnectionString = "Data Source=DESKTOP-I9NU0H3; Initial Catalog=QuanLyBanHang; Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daTable = null;
        DataTable dtTable = null;

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectionString);

                int catalogIndex = Convert.ToInt32(this.Text);
                switch (catalogIndex)
                {
                    case 1:
                        lbDanhMuc.Text = "Danh Mục Thành Phố";
                        this.Text = "Danh Mục Thành Phố";
                        daTable = new SqlDataAdapter("Select * from ThanhPho", conn);
                        break;
                    case 2:
                        lbDanhMuc.Text = "Danh Mục Khách Hàng";
                        this.Text = "Danh Mục Khách Hàng";
                        daTable = new SqlDataAdapter("Select * from KhachHang", conn);
                        break;
                    case 3:
                        lbDanhMuc.Text = "Danh Mục Nhân Viên";
                        this.Text = "Danh Mục Nhân Viên";
                        daTable = new SqlDataAdapter("Select * from NhanVien", conn);
                        break;
                    case 4:
                        lbDanhMuc.Text = "Danh Mục Sản Phẩm";
                        this.Text = "Danh Mục Sản Phẩm";
                        daTable = new SqlDataAdapter("Select * from SanPham", conn);
                        break;
                    case 5:
                        lbDanhMuc.Text = "Danh Mục Hóa Đơn";
                        this.Text = "Danh Mục Hóa Đơn";
                        daTable = new SqlDataAdapter("Select * from HoaDon", conn);
                        break;
                    case 6:
                        lbDanhMuc.Text = "Danh Mục Chi Tiết Hóa Đơn";
                        this.Text = "Danh Mục Chi Tiết Hóa Đơn";
                        daTable = new SqlDataAdapter("Select * from ChiTietHoaDon", conn);
                        break;
                    default:
                        break;
                }

                dtTable = new DataTable();
                dtTable.Clear();
                daTable.Fill(dtTable);

                dgvDanhMuc.DataSource = dtTable;
                dgvDanhMuc.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi khi truy cập CSDL!", "Lỗi");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtTable.Dispose();
            dtTable = null;
            conn = null;
        }
    }
}
