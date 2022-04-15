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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private readonly string strConnect = "Data Source=DESKTOP-I9NU0H3; Initial Catalog=QuanLyBanHang; Integrated Security=True";
        SqlConnection conn = null;
        
        SqlDataAdapter daHoaDon = null;
        DataTable dtHoaDon = null;

        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;

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
                // KhachHang
                daKhachHang = new SqlDataAdapter("select MaKH, TenCty from KhachHang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);

                (dgvHoaDon.Columns["MaKH"] as DataGridViewComboBoxColumn).DataSource = dtKhachHang;
                (dgvHoaDon.Columns["MaKH"] as DataGridViewComboBoxColumn).DisplayMember = "TenCty";
                (dgvHoaDon.Columns["MaKH"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";

                // NhanVien
                daNhanVien = new SqlDataAdapter("select MaNV, Ho+' '+Ten as HoTen from NhanVien", conn);
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                daNhanVien.Fill(dtNhanVien);

                (dgvHoaDon.Columns["MaNV"] as DataGridViewComboBoxColumn).DataSource = dtNhanVien;
                (dgvHoaDon.Columns["MaNV"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";
                (dgvHoaDon.Columns["MaNV"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";

                // HoaDon
                daHoaDon = new SqlDataAdapter("select * from HoaDon", conn);
                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
                daHoaDon.Fill(dtHoaDon);

                dgvHoaDon.DataSource = dtHoaDon;

                // Xoa trong cac doi tuong trong panel
                this.txtMaHD.ResetText();
                if (this.cbMaKH.DataSource != null) this.cbMaKH.SelectedIndex = 0;
                if (this.cbMaNV.DataSource != null) this.cbMaNV.SelectedIndex = 0;


                EnablePanel(false);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không thể kết nối đến bảng HoaDon", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void InvoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtKhachHang.Dispose();
            dtKhachHang = null;
            dtNhanVien.Dispose();
            dtNhanVien = null;
            dtHoaDon.Dispose();
            dtHoaDon = null;
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

            this.txtMaHD.ResetText();
            this.txtMaHD.Enabled = true;

            EnablePanel(true);

            // Dua DL len comboBox panel
            this.cbMaKH.DataSource = dtKhachHang;
            this.cbMaKH.DisplayMember = "TenCty";
            this.cbMaKH.ValueMember = "MaKH";

            this.cbMaNV.DataSource = dtNhanVien;
            this.cbMaNV.DisplayMember = "HoTen";
            this.cbMaNV.ValueMember = "MaNV";

            // Dua con tro chuot den MaKH
            this.txtMaHD.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Them = false;

            this.cbMaKH.DataSource = dtKhachHang;
            this.cbMaKH.DisplayMember = "TenCty";
            this.cbMaKH.ValueMember = "MaKH";

            this.cbMaNV.DataSource = dtNhanVien;
            this.cbMaNV.DisplayMember = "HoTen";
            this.cbMaNV.ValueMember = "MaNV";

            int i = dgvHoaDon.CurrentCell.RowIndex;
            this.txtMaHD.Text = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
            this.cbMaKH.SelectedValue = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
            this.cbMaNV.SelectedValue = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
            this.dateNgayLHD.Value = Convert.ToDateTime(dgvHoaDon.Rows[i].Cells[3].Value.ToString());
            this.dateNgayNH.Value = Convert.ToDateTime(dgvHoaDon.Rows[i].Cells[4].Value.ToString());

            this.txtMaHD.Enabled = false;

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
                int i = dgvHoaDon.CurrentCell.RowIndex;
                // Lay ra MaHD
                string strMaHD = dgvHoaDon.Rows[i].Cells[0].Value.ToString();

                // Viet cau truy van SQL
                cmd.CommandText = System.String.Concat("Delete From HoaDon Where MaHD='" + strMaHD + "'");
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
                    this.txtMaHD.Text == ""
                )
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                conn.Open();

                String dateLHD = this.dateNgayLHD.Value.ToString("yyyy-MM-dd");
                String dateNH = this.dateNgayNH.Value.ToString("yyyy-MM-dd");

                if (this.Them)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = System.String.Concat("Insert into HoaDon Values (" + "'" +
                                this.txtMaHD.Text.ToString() + "', '" +
                                this.cbMaKH.SelectedValue.ToString() + "', '" +
                                this.cbMaNV.SelectedValue.ToString() + "', '" +
                                dateLHD + "', '" +
                                dateNH + "')"
                            );
                        cmd.CommandType = CommandType.Text;
                        // System.Console.WriteLine(cmd.CommandText);
                        cmd.ExecuteNonQuery();

                        Form frm = new AddInvoiceDetailForm();
                        frm.Text = this.txtMaHD.Text.ToString();
                        frm.ShowDialog();

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

                        int i = dgvHoaDon.CurrentCell.RowIndex;

                        string strMaHD = dgvHoaDon.Rows[i].Cells[0].Value.ToString();

                        cmd.CommandText = System.String.Concat("Update HoaDon set " +
                                "MaKH='" + this.cbMaKH.SelectedValue.ToString() +
                                "', MaNV='" + this.cbMaNV.SelectedValue.ToString() +
                                "', NgayLapHD='" + dateLHD +
                                "', NgayNhanHang='" + dateNH +
                                "' Where MaHD='" + strMaHD + "'"
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
            this.txtMaHD.ResetText();
            if (this.cbMaKH.DataSource != null) this.cbMaKH.SelectedIndex = 0;
            if (this.cbMaNV.DataSource != null) this.cbMaNV.SelectedIndex = 0;

            EnablePanel(false);
        }
    }
}
