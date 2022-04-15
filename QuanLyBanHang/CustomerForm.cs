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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private readonly string strConnect = "Data Source=DESKTOP-I9NU0H3; Initial Catalog=QuanLyBanHang; Integrated Security=True";
        SqlConnection conn = null;
        // Table KhachHang
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;
        // Table ThanhPho
        SqlDataAdapter daThanhPho = null;
        DataTable dtThanhPho = null;

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
                // ThanhPho
                daThanhPho = new SqlDataAdapter("select * from ThanhPho", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);
                // Dua DL thanh pho vao dgv
                (dgvKhachHang.Columns["ThanhPho"] as DataGridViewComboBoxColumn).DataSource = dtThanhPho;
                (dgvKhachHang.Columns["ThanhPho"] as DataGridViewComboBoxColumn).DisplayMember = "TenThanhPho";
                (dgvKhachHang.Columns["ThanhPho"] as DataGridViewComboBoxColumn).ValueMember = "ThanhPho";

                // KhachHang
                daKhachHang = new SqlDataAdapter("select * from KhachHang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);

                dgvKhachHang.DataSource = dtKhachHang;

                // Xoa trong cac doi tuong trong panel
                this.txtMaKH.ResetText();
                this.txtTenCty.ResetText();
                this.txtDiaChi.ResetText();
                this.txtDienThoai.ResetText();

                EnablePanel(false);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không thể kết nối đến bảng KhacHang", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtKhachHang.Dispose();
            dtKhachHang = null;
            dtThanhPho.Dispose();
            dtThanhPho = null;
            conn = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Them = true;

            this.txtMaKH.ResetText();
            this.txtTenCty.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtMaKH.Enabled = true;

            EnablePanel(true);

            // Dua DL len comboBox panel
            this.cbThanhPho.DataSource = dtThanhPho;
            this.cbThanhPho.DisplayMember = "TenThanhPho";
            this.cbThanhPho.ValueMember = "ThanhPho";

            // Dua con tro chuot den MaKH
            this.txtMaKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Them = false;

            this.cbThanhPho.DataSource = dtThanhPho;
            this.cbThanhPho.DisplayMember = "TenThanhPho";
            this.cbThanhPho.ValueMember = "ThanhPho";


            int i = dgvKhachHang.CurrentCell.RowIndex;
            this.txtMaKH.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            this.txtTenCty.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            this.txtDiaChi.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            this.cbThanhPho.SelectedValue = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
            this.txtDienThoai.Text = dgvKhachHang.Rows[i].Cells[4].Value.ToString();

            this.txtMaKH.Enabled = false;

            EnablePanel(true);

            this.txtTenCty.Focus();
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
                int i = dgvKhachHang.CurrentCell.RowIndex;
                // Lay ra MaKH
                string strMaKH = dgvKhachHang.Rows[i].Cells[0].Value.ToString();

                // Viet cau truy van SQL
                cmd.CommandText = System.String.Concat("Delete From KhachHang Where MaKH='" + strMaKH + "'");
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
            if (this.txtMaKH.Text == "" || this.txtTenCty.Text == "" || this.txtDiaChi.Text == "" || this.txtDienThoai.Text == "")
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

                        cmd.CommandText = System.String.Concat("Insert into KhachHang Values (" + 
                                "'" + this.txtMaKH.Text.ToString() + 
                                "', N'" + this.txtTenCty.Text.ToString() + 
                                "', N'" + this.txtDiaChi.Text.ToString() + 
                                "', N'" + this.cbThanhPho.SelectedValue.ToString() + 
                                "', '" + this.txtDienThoai.Text.ToString() + "')"
                            );
                        cmd.CommandType = CommandType.Text;
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

                        int i = dgvKhachHang.CurrentCell.RowIndex;

                        string strMaKH = dgvKhachHang.Rows[i].Cells[0].Value.ToString();

                        cmd.CommandText = System.String.Concat("Update KhachHang set " +
                                "TenCty=N'" + this.txtTenCty.Text.ToString() + 
                                "', DiaChi=N'" + this.txtDiaChi.Text.ToString() + 
                                "', ThanhPho=N'" + this.cbThanhPho.SelectedValue.ToString() + 
                                "', DienThoai='" + this.txtDienThoai.Text.ToString() + 
                                "' Where MaKH='" +  strMaKH + "'"
                            );

                        cmd.CommandType = CommandType.Text;
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
                this.cbThanhPho.SelectedIndex = 0;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaKH.ResetText();
            this.txtTenCty.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();

            EnablePanel(false);

            this.cbThanhPho.SelectedIndex = 0;
        }
    }
}
