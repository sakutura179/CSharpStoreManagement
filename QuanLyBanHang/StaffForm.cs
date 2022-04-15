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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private readonly string strConnect = "Data Source=DESKTOP-I9NU0H3; Initial Catalog=QuanLyBanHang; Integrated Security=True";
        SqlConnection conn = null;
        // Table NhanVien
        SqlDataAdapter daNhanVien = null;
        DataTable dtNhanVien = null;

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
                daNhanVien = new SqlDataAdapter("select * from NhanVien", conn);
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                daNhanVien.Fill(dtNhanVien);

                dgvNhanVien.DataSource = dtNhanVien;

                // Xoa trong cac doi tuong trong panel
                this.txtMaNV.ResetText();
                this.txtHo.ResetText();
                this.txtTen.ResetText();
                this.chkNu.Checked = false;
                this.txtDiaChi.ResetText();
                this.txtDienThoai.ResetText();

                EnablePanel(false);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không thể kết nối đến bảng NhanVien", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtNhanVien.Dispose();
            dtNhanVien = null;
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

            this.txtMaNV.ResetText();
            this.txtHo.ResetText();
            this.txtTen.ResetText();
            this.chkNu.Checked = false;
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();

            this.txtMaNV.Enabled = true;

            EnablePanel(true);

            this.txtMaNV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Them = false;

            int i = dgvNhanVien.CurrentCell.RowIndex;
            this.txtMaNV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            this.txtHo.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            this.txtTen.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            this.chkNu.Checked = Convert.ToBoolean(dgvNhanVien.Rows[i].Cells[3].Value);
            this.dateNgayNV.Value = Convert.ToDateTime(dgvNhanVien.Rows[i].Cells[4].Value.ToString());
            this.txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            this.txtDienThoai.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();

            this.txtMaNV.Enabled = false;

            EnablePanel(true);

            this.txtHo.Focus();
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
                int i = dgvNhanVien.CurrentCell.RowIndex;
                // Lay ra MaNV
                string strMaNV = dgvNhanVien.Rows[i].Cells[0].Value.ToString();

                // Viet cau truy van SQL
                cmd.CommandText = System.String.Concat("Delete From NhanVien Where MaNV='" + strMaNV + "'");
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (
                    this.txtMaNV.Text == "" ||
                    this.txtHo.Text == "" || 
                    this.txtTen.Text == "" || 
                    this.txtDiaChi.Text == "" || 
                    this.txtDienThoai.Text == ""
                )
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                conn.Open();

                int gender = this.chkNu.Checked ? 1 : 0;
                String dateNV = this.dateNgayNV.Value.ToString("yyyy-MM-dd");

                if (this.Them)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = System.String.Concat("Insert into NhanVien Values (" + "'" +
                                this.txtMaNV.Text.ToString() + "', N'" +
                                this.txtHo.Text.ToString() + "', N'" +
                                this.txtTen.Text.ToString() + "', " +
                                gender + ", '" +
                                dateNV + "', N'" +
                                this.txtDiaChi.Text.ToString() + "', '" +
                                this.txtDienThoai.Text.ToString() + "', NULL)"
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

                        int i = dgvNhanVien.CurrentCell.RowIndex;

                        string strMaNV = dgvNhanVien.Rows[i].Cells[0].Value.ToString();

                        cmd.CommandText = System.String.Concat("Update NhanVien set " +
                                "Ho=N'" + this.txtHo.Text.ToString() + 
                                "', Ten=N'" +  this.txtTen.Text.ToString() + 
                                "', Nu=" + gender + 
                                ", NgayNV='" + dateNV + 
                                "', DiaChi=N'" + this.txtDiaChi.Text.ToString() +
                                "', DienThoai='" + this.txtDienThoai.Text.ToString() +
                                "', Hinh=NULL Where MaNV='" + strMaNV + "'"
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaNV.ResetText();
            this.txtHo.ResetText();
            this.txtTen.ResetText();
            this.chkNu.Checked = false;
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();

            EnablePanel(false);
        }
    }
}
