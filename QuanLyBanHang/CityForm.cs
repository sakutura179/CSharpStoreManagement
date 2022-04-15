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
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();
        }

        string strConnectionString = "Data Source=DESKTOP-I9NU0H3; Initial Catalog=QuanLyBanHang; Integrated Security=True";
        SqlConnection conn = null;
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
                conn = new SqlConnection(strConnectionString);
                daThanhPho = new SqlDataAdapter("SELECT * FROM THANHPHO", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);

                dgvThanhPho.DataSource = dtThanhPho;

                dgvThanhPho.AutoResizeColumns();

                this.txtCity.ResetText();
                this.txtCityName.ResetText();

                EnablePanel(false);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không thể kết nối đến bảng ThanhPho", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CityForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtThanhPho.Dispose();
            dtThanhPho = null;
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
            Them = true;

            this.txtCity.ResetText();
            this.txtCityName.ResetText();
            this.txtCity.Enabled = true;

            EnablePanel(true);

            this.txtCity.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;


            int i = dgvThanhPho.CurrentCell.RowIndex;

            this.txtCity.Text = dgvThanhPho.Rows[i].Cells[0].Value.ToString();
            this.txtCityName.Text = dgvThanhPho.Rows[i].Cells[1].Value.ToString();

            this.txtCity.Enabled = false;

            EnablePanel(true);

            this.txtCityName.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                int i = dgvThanhPho.CurrentCell.RowIndex;

                string strTHANHPHO = dgvThanhPho.Rows[i].Cells[0].Value.ToString();

                cmd.CommandText = System.String.Concat("Delete From ThanhPho Where ThanhPho = '" + strTHANHPHO + "'");
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

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

            this.txtCity.ResetText();
            this.txtCityName.ResetText();

            EnablePanel(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.txtCity.Text == "" || this.txtCityName.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                conn.Open();
                // Them DL
                if (Them)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = System.String.Concat("Insert Into ThanhPho Values('" +
                                this.txtCity.Text.ToString() + "', N'" +
                                this.txtCityName.Text.ToString() + "')"
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

                // Sua DL
                if (!Them)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        int i = dgvThanhPho.CurrentCell.RowIndex;

                        string strTHANHPHO = dgvThanhPho.Rows[i].Cells[0].Value.ToString();

                        cmd.CommandText = System.String.Concat("Update ThanhPho Set TenThanhPho = N'" +
                                this.txtCityName.Text.ToString() +
                                "' Where ThanhPho = '" +
                                strTHANHPHO + "'"
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
            }
        }
    }
}
