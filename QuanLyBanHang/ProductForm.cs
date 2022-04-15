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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private readonly string strConnect = "Data Source=DESKTOP-I9NU0H3; Initial Catalog=QuanLyBanHang; Integrated Security=True";
        SqlConnection conn = null;
        // Table SanPham
        SqlDataAdapter daSanPham = null;
        DataTable dtSanPham = null;

        bool Them;

        private void EnablePanel(bool enable)
        {
            this.btnLuu.Enabled = enable;
            this.btnHuy.Enabled = enable;
            this.panel.Enabled = enable;

            this.btnThem.Enabled = !enable;
            this.btnSua.Enabled = !enable;
            this.btnXoa.Enabled = !enable;
            this.btnExit.Enabled = !enable;
        }

        private void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnect);
                daSanPham = new SqlDataAdapter("select * from SanPham", conn);
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                daSanPham.Fill(dtSanPham);

                dgvSanPham.DataSource = dtSanPham;

                // Xoa trong cac doi tuong trong panel
                this.txtMaSP.ResetText();
                this.txtTenSP.ResetText();
                this.txtDonViTinh.ResetText();
                this.txtDonGia.ResetText();

                EnablePanel(false);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không thể kết nối đến bảng SanPham", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtSanPham.Dispose();
            dtSanPham = null;
            conn = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Them = true;

            this.txtMaSP.ResetText();
            this.txtTenSP.ResetText();
            this.txtDonViTinh.ResetText();
            this.txtDonGia.ResetText();

            this.txtMaSP.Enabled = true;

            EnablePanel(true);

            this.txtMaSP.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Them = false;

            int i = dgvSanPham.CurrentCell.RowIndex;
            this.txtMaSP.Text = dgvSanPham.Rows[i].Cells[0].Value.ToString();
            this.txtTenSP.Text = dgvSanPham.Rows[i].Cells[1].Value.ToString();
            this.txtDonViTinh.Text = dgvSanPham.Rows[i].Cells[2].Value.ToString();
            this.txtDonGia.Text = dgvSanPham.Rows[i].Cells[3].Value.ToString();

            this.txtMaSP.Enabled = false;

            EnablePanel(true);

            this.txtTenSP.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaSP.ResetText();
            this.txtTenSP.ResetText();
            this.txtDonViTinh.ResetText();
            this.txtDonGia.ResetText();

            EnablePanel(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (
                    this.txtMaSP.Text == "" ||
                    this.txtTenSP.Text == "" ||
                    this.txtDonViTinh.Text == "" ||
                    this.txtDonGia.Text == ""
                )
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                conn.Open();
                if (this.Them)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = System.String.Concat("Insert into SanPham Values (" + "'" +
                                this.txtMaSP.Text.ToString() + "', N'" +
                                this.txtTenSP.Text.ToString() + "', N'" +
                                this.txtDonViTinh.Text.ToString() + "', " +
                                this.txtDonGia.Text.ToString() + ", NULL)"
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
                }
                else
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        int i = dgvSanPham.CurrentCell.RowIndex;

                        string strMaSP = dgvSanPham.Rows[i].Cells[0].Value.ToString();

                        cmd.CommandText = System.String.Concat("Update SanPham set " +
                                "TenSP=N'" + this.txtTenSP.Text.ToString() +
                                "', DonViTinh=N'" + this.txtDonViTinh.Text.ToString() +
                                "', DonGia=" + this.txtDonGia.Text.ToString() +
                                ", Hinh=NULL Where MaSP='" + strMaSP + "'"
                            );

                        cmd.CommandType = CommandType.Text;
                        // System.Console.WriteLine(cmd.CommandText);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đã sửa thành công", "Thông báo");
                        LoadData();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Lỗi khi sửa dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                // Lay ra thu tu record hien hanh
                int i = dgvSanPham.CurrentCell.RowIndex;
                // Lay ra MaSP
                string strMaSP = dgvSanPham.Rows[i].Cells[0].Value.ToString();

                // Viet cau truy van SQL
                cmd.CommandText = System.String.Concat("Delete From SanPham Where MaSP='" + strMaSP + "'");
                cmd.CommandType = CommandType.Text;

                // Thuc hien cau lenh SQL
                cmd.ExecuteNonQuery();
                // Cap nhat lai DataTable
                MessageBox.Show("Đã xóa thành công", "Thông báo");
                LoadData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không thể xóa dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
