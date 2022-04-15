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
    public partial class InvoiceDetailForm : Form
    {
        public InvoiceDetailForm()
        {
            InitializeComponent();
        }

        private readonly string strConnect = "Data Source=DESKTOP-I9NU0H3; Initial Catalog=QuanLyBanHang; Integrated Security=True";
        SqlConnection conn = null;

        SqlDataAdapter daChiTietHD = null;
        DataTable dtChiTietHD = null;

        SqlDataAdapter daHoaDon = null;
        DataTable dtHoaDon = null;

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

                daHoaDon = new SqlDataAdapter("select MaHD from HoaDon", conn);
                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
                daHoaDon.Fill(dtHoaDon);

                (dgvChiTietHD.Columns["MaHD"] as DataGridViewComboBoxColumn).DataSource = dtHoaDon;
                (dgvChiTietHD.Columns["MaHD"] as DataGridViewComboBoxColumn).DisplayMember = "MaHD";
                (dgvChiTietHD.Columns["MaHD"] as DataGridViewComboBoxColumn).ValueMember = "MaHD";

                daSanPham = new SqlDataAdapter("select MaSP, TenSP from SanPham", conn);
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                daSanPham.Fill(dtSanPham);

                (dgvChiTietHD.Columns["MaSP"] as DataGridViewComboBoxColumn).DataSource = dtSanPham;
                (dgvChiTietHD.Columns["MaSP"] as DataGridViewComboBoxColumn).DisplayMember = "TenSP";
                (dgvChiTietHD.Columns["MaSP"] as DataGridViewComboBoxColumn).ValueMember = "MaSP";

                // ChiTietHD
                daChiTietHD = new SqlDataAdapter("select * from ChiTietHoaDon", conn);
                dtChiTietHD = new DataTable();
                dtChiTietHD.Clear();
                daChiTietHD.Fill(dtChiTietHD);

                dgvChiTietHD.DataSource = dtChiTietHD;

                // Xoa trong cac doi tuong trong panel
                if (this.cbMaHD.DataSource != null) this.cbMaHD.SelectedIndex = 0;
                if (this.cbMaSP.DataSource != null) this.cbMaSP.SelectedIndex = 0;
                this.txtSoLuong.ResetText();

                EnablePanel(false);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không thể kết nối đến bảng ChiTietHoaDon", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InvoiceDetailForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void InvoiceDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtHoaDon.Dispose();
            dtHoaDon = null;
            dtSanPham.Dispose();
            dtSanPham = null;
            dtChiTietHD.Dispose();
            dtChiTietHD = null;
            conn = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Them = true;

            // Dua DL len comboBox panel
            this.cbMaHD.DataSource = dtHoaDon;
            this.cbMaHD.DisplayMember = "MaHD";
            this.cbMaHD.ValueMember = "MaHD";

            this.cbMaSP.DataSource = dtSanPham;
            this.cbMaSP.DisplayMember = "TenSP";
            this.cbMaSP.ValueMember = "MaSP";

            this.txtSoLuong.ResetText();

            this.cbMaHD.Enabled = true;
            this.cbMaSP.Enabled = true;

            EnablePanel(true);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Them = false;

            this.cbMaHD.DataSource = dtHoaDon;
            this.cbMaHD.DisplayMember = "MaHD";
            this.cbMaHD.ValueMember = "MaHD";

            this.cbMaSP.DataSource = dtSanPham;
            this.cbMaSP.DisplayMember = "TenSP";
            this.cbMaSP.ValueMember = "MaSP";


            int i = dgvChiTietHD.CurrentCell.RowIndex;
            this.cbMaHD.SelectedValue = dgvChiTietHD.Rows[i].Cells[0].Value.ToString();
            this.cbMaSP.SelectedValue = dgvChiTietHD.Rows[i].Cells[1].Value.ToString();
            this.txtSoLuong.Text = dgvChiTietHD.Rows[i].Cells[2].Value.ToString();

            this.cbMaHD.Enabled = false;
            this.cbMaSP.Enabled = false;

            EnablePanel(true);
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
                int i = dgvChiTietHD.CurrentCell.RowIndex;

                string strMaHD = dgvChiTietHD.Rows[i].Cells[0].Value.ToString();
                string strMaSP = dgvChiTietHD.Rows[i].Cells[1].Value.ToString();

                // Viet cau truy van SQL
                cmd.CommandText = System.String.Concat("Delete From ChiTietHoaDon Where " +
                                                       "MaHD='" + strMaHD + "' And MaSP='" + strMaSP + "'");
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (this.cbMaHD.DataSource != null) this.cbMaHD.SelectedIndex = 0;
            if (this.cbMaSP.DataSource != null) this.cbMaSP.SelectedIndex = 0;
            this.txtSoLuong.ResetText();

            EnablePanel(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (
                    this.txtSoLuong.Text == ""
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
                }
                else
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        int i = dgvChiTietHD.CurrentCell.RowIndex;

                        string strMaHD = dgvChiTietHD.Rows[i].Cells[0].Value.ToString();
                        string strMaSP = dgvChiTietHD.Rows[i].Cells[1].Value.ToString();

                        cmd.CommandText = System.String.Concat("Update ChiTietHoaDon set " +
                                "SoLuong=" + this.txtSoLuong.Text.ToString() +
                                " Where MaHD='" + strMaHD + "' And MaSP='" + strMaSP + "'"
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
    }
}
