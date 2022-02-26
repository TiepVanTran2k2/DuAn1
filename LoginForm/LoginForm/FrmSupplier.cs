using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace RJCodeAdvance
{
    public partial class FrmSupplier : Form
    {
        public FrmSupplier()
        {
            InitializeComponent();
        }
        BUS_NhaCungCap busNCC = new BUS_NhaCungCap(); 
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string tenHang = txtSearch.Text;
            DataTable ds = busNCC.SearchNhaCungCap(tenHang);
            if (ds.Rows.Count > 0)
            {
                dgv.DataSource = ds;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ResetValue();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtTenNCC.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            btLuu.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv.CurrentRow.Cells["Id_Supplier"].Value.ToString());
            {
                if (busNCC.DeleteNhaCungCap(id))
                {
                    ResetValue();
                    loaddgv();
                }
                else
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
                   }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkTextBox())
                {
                    DTO_NhaCungCap dtoNCC = new DTO_NhaCungCap(txtTenNCC.Text, txtEmail.Text,
                        txtDiaChi.Text, Convert.ToInt32(dgv.CurrentRow.Cells["Id_Supplier"].Value.ToString()));
                    if (busNCC.UpdateNhaCungCap(dtoNCC))
                    {
                        loaddgv();
                        ResetValue();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkTextBox())
                {
                    DTO_NhaCungCap dtoNCC = new DTO_NhaCungCap(txtTenNCC.Text, txtEmail.Text, txtDiaChi.Text);
                    if (busNCC.InsertNhaCungCap(dtoNCC))
                    {
                        loaddgv();
                        ResetValue();
                    }
                    else
                    {
                        MessageBox.Show("Nhà cung cấp đã trùng email");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            ResetValue();
            loaddgv();
        }
        void ResetValue()
        {
            txtTenNCC.Enabled = false;
            txtTenNCC.Text = "";
            txtEmail.Enabled = false;
            txtEmail.Text = "";
            txtDiaChi.Enabled = false;
            txtDiaChi.Text = "";
            txtSearch.Text = "";
            btXoa.Enabled = false; ;
            btSua.Enabled = false;
            btLuu.Enabled = false;
        }
        bool checkTextBox()
        {
            if (string.IsNullOrEmpty(txtTenNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp");
                txtTenNCC.Text = "";
                txtTenNCC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email");
                txtEmail.Text = "";
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                txtTenNCC.Text = "";
                txtTenNCC.Focus();
                return false;
            }
            if (!IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Nhập sai định dạng email");
                return false;
            }
            return true;
        }

        public bool IsValid(string emailAddress)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
              @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
              @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(emailAddress))
                return (true);
            else
                return (false);
        }

        void loaddgv()
        {
            dgv.DataSource = busNCC.getSupplier();
            dgv.Columns[0].HeaderText = "Name";
            dgv.Columns[1].HeaderText = "Id_Supplier";
            dgv.Columns[2].HeaderText = "Email";
            dgv.Columns[3].HeaderText = "Address";
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 1)
                {
                    btLuu.Enabled = false;
                    btXoa.Enabled = true;
                    btSua.Enabled = true;
                    txtTenNCC.Enabled = true;
                    txtEmail.Enabled = false;
                    txtDiaChi.Enabled = true;
                    txtTenNCC.Text = dgv.CurrentRow.Cells["Name"].Value.ToString();
                    txtEmail.Text = dgv.CurrentRow.Cells["Email"].Value.ToString();
                    txtDiaChi.Text = dgv.CurrentRow.Cells["Address"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
        }

        private void btDanhSacch_Click(object sender, EventArgs e)
        {
            loaddgv();
        }
    }
}
