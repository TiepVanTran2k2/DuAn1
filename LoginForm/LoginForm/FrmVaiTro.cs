using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJCodeAdvance
{
    public partial class FrmVaiTro : Form
    {
        BUS_Role busRoles = new BUS_QuanLy.BUS_Role();
        public FrmVaiTro()
        {
            InitializeComponent();
        }
        private void FrmVaiTro_Load(object sender, EventArgs e)
        {
            ResetValue();
            ShowData_GridViewVaiTro();
            
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            txtVaiTro.Text = null;
            txtVaiTro.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtVaiTro.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVaiTro.Focus();
                return;
            }
            else
            {
                DTO_Role roles = new DTO_Role(txtVaiTro.Text);
                if (busRoles.InsertRoleNhanVien(roles))
                {
                    ResetValue();
                    ShowData_GridViewVaiTro();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(id_role.Text);
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
                {
                    if (busRoles.DeleteRoleNhanVien(id))
                    {
                        ResetValue();
                        ShowData_GridViewVaiTro();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                else
                {
                    ResetValue();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtVaiTro.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVaiTro.Focus();
                return;
            }
            else
            {
                DTO_Role rs = new DTO_Role(int.Parse(id_role.Text), txtVaiTro.Text);
                if (busRoles.UpdateRoleNhanVien(rs))
                {
                    ResetValue();
                    ShowData_GridViewVaiTro();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {

            string name = txtTimKiem.Text;
            DataTable ds = busRoles.SearchRoleNhanVien(name);
            if (ds.Rows.Count > 0)
            {
                dgv_VaiTro.DataSource = ds;
                dgv_VaiTro.Columns[0].HeaderText = "Id vai trò";
                dgv_VaiTro.Columns[1].HeaderText = "Tên vai trò";
            }
            else
            {
                MessageBox.Show("Không tìm thấy vai trò nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimKiem.Text = "Nhập tên vai trò cần tìm";
            txtTimKiem.BackColor = Color.LightGray;
            ResetValue();
        }

        private void dgv_VaiTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_VaiTro.Rows.Count > 1)
            {
                try
                {
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    txtVaiTro.Enabled = true;
                    txtVaiTro.Text = dgv_VaiTro.CurrentRow.Cells["Name"].Value.ToString();
                    id_role.Text = dgv_VaiTro.CurrentRow.Cells["Id_role"].Value.ToString();

                }
                catch
                {
                    ResetValue();
                    MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void ResetValue()
        {
            txtVaiTro.Text = null;
            txtVaiTro.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
        }

        public void ShowData_GridViewVaiTro()
        {
            dgv_VaiTro.DataSource = busRoles.HienThiDuLieuRoles();
            dgv_VaiTro.Columns[0].HeaderText = "Id vai trò";
            dgv_VaiTro.Columns[1].HeaderText = "Tên vai trò";
        }
    }
}
