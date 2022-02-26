using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJCodeAdvance.ControlEmployees
{
    public partial class UC_employee : UserControl
    {
        public static string mail;
        public static int idEmployee;

        BUS_NhanVien busNV = new BUS_QuanLy.BUS_NhanVien();
        public UC_employee()
        {
            InitializeComponent();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmVaiTro frm = new FrmVaiTro();
            frm.ShowDialog();
        }

        private void UC_employee_Load(object sender, EventArgs e)
        {
            this.Refresh();
            ResetValue();
            ShowData_GridViewNhanVien();
            ThemVaiTro();
            Id_emloyee.Visible = false;
        }

        private void btnThemVaitro_Click(object sender, EventArgs e)
        {
            FrmVaiTro frm = new FrmVaiTro();
            frm.ShowDialog();
            this.Refresh();
            ThemVaiTro();
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = null;
            nbLuong.Text = null;
            txtDiaChi.Text = null;
            txtEmail.Text = null;
            txtEmail.Enabled = true;
            nbLuong.Enabled = true;
            txtTenNhanVien.Enabled = true;
            txtDiaChi.Enabled = true;
            cbVaiTro.Enabled = true;
            dtNgaySinh.Enabled = true;
            rbNam.Enabled = true;
            rbNu.Enabled = true;
            btnThemVaitro.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int gioitinh = 0;
            int vaitro = 0;
            vaitro = cbVaiTro.SelectedIndex + 1;
            DataTable dt = busNV.KiemTraTrungEmail();
            for (int i = 0; i < dt.Rows.Count; i++) // Mở vòng lặp để lấy từng phần tử trong CSDL
            {
                if (txtEmail.Text == dt.Rows[i]["Email"].ToString()) // Kiểm tra trùng lặp dữ liệu
                {
                    MessageBox.Show("Email này đã có rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                    return;
                }
            }

            if (rbNam.Checked)
                gioitinh = 1;
            else
                gioitinh = 0;

            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if (!IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return;
            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            else if (nbLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lương nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nbLuong.Focus();
                return;
            }

            if (rbNam.Checked == false && rbNu.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return;
            }
            if (cbVaiTro.Items.Contains(""))
            {
                MessageBox.Show("Bạn phải chọn vai trò nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return;
            }
            if (int.Parse(nbLuong.Text) >= 100000000)
            {
                MessageBox.Show("Lương quá lớn chỉ được (< 10000000)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return;
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien(vaitro, txtTenNhanVien.Text, gioitinh, txtEmail.Text, txtDiaChi.Text, dtNgaySinh.Value.ToString(), float.Parse(nbLuong.Text));
                if (busNV.InsertNhanVien(nv))
                {
                    ResetValue();
                    ShowData_GridViewNhanVien();
                    BUS_SendGmail.SendMail(txtEmail.Text, "Đăng ký tài khoản thành công", "mật khẩu mặc định của bạn là:1234");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (mail == txtEmail.Text)
            {
                MessageBox.Show("Không được xóa nhân viên đang đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return;
            }
            if (cbVaiTro.SelectedIndex == 0)
            {
                MessageBox.Show("Không được xóa nhân viên có vai trò Quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
              == DialogResult.Yes)
            {
                if (busNV.DeleteNhanVien(txtEmail.Text))
                {
                    ResetValue();
                    ShowData_GridViewNhanVien();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            int gioitinh = 0;
            int vaitro = 0;
            vaitro = cbVaiTro.SelectedIndex + 1;

            if (rbNam.Checked)
                gioitinh = 1;
            else
                gioitinh = 0;

            
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if (!IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return;
            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            else if (nbLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lương nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nbLuong.Focus();
                return;
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien(vaitro, txtTenNhanVien.Text, gioitinh, txtEmail.Text, txtDiaChi.Text, dtNgaySinh.Value.ToString(), float.Parse(nbLuong.Text),int.Parse(Id_emloyee.Text));
                if (busNV.UpdateNhanVien(nv))
                {
                    ResetValue();
                    ShowData_GridViewNhanVien();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        public void ResetValue()
        {
            txtTimKiem.Text = "Nhập tên nhân viên cần tìm";
            txtTenNhanVien.Text = null;
            nbLuong.Text = null;
            txtDiaChi.Text = null;
            txtEmail.Text = null;
            txtEmail.Enabled = false;
            nbLuong.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtDiaChi.Enabled = false;
            cbVaiTro.Enabled = false;
            dtNgaySinh.Enabled = false;
            rbNam.Enabled = false;
            rbNu.Enabled = false;
            btnThemVaitro.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        //Hiển thị dữ liệu nhân viên
        public void ShowData_GridViewNhanVien()
        {
            dgv_NhanVien.DataSource = busNV.HienThiDuLieuNhanVien();
            dgv_NhanVien.Columns[0].HeaderText = "Vai trò";
            dgv_NhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgv_NhanVien.Columns[2].HeaderText = "Giới tính";
            dgv_NhanVien.Columns[3].HeaderText = "Email";
            dgv_NhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgv_NhanVien.Columns[5].HeaderText = "Ngày sinh";
            dgv_NhanVien.Columns[6].HeaderText = "Lương";
            dgv_NhanVien.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_NhanVien.Columns[7].Visible = false;
            dgv_NhanVien.Columns[8].Visible = false;
            dgv_NhanVien.Columns[9].Visible = false;
            dgv_NhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Kiểm tra định dạng email
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

        void ThemVaiTro()
        {
            cbVaiTro.DataSource = busNV.ThemVaiTro();
            cbVaiTro.DisplayMember = "Name";
            cbVaiTro.ValueMember = "Id_role";
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            ShowData_GridViewNhanVien();
        }

        private void nbLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string name = txtTimKiem.Text;
            int id_role = cbTimKiemTheoVaiTro.SelectedIndex + 1;
            DataTable ds = busNV.SearchNhanVien(name, id_role);//Test lai di ong
            if (ds.Rows.Count > 0)
            {
                dgv_NhanVien.DataSource = ds;
                dgv_NhanVien.Columns[0].HeaderText = "Vai trò";
                dgv_NhanVien.Columns[1].HeaderText = "Tên nhân viên";
                dgv_NhanVien.Columns[2].HeaderText = "Giới tính";
                dgv_NhanVien.Columns[3].HeaderText = "Email";
                dgv_NhanVien.Columns[4].HeaderText = "Địa chỉ";
                dgv_NhanVien.Columns[5].HeaderText = "Ngày sinh";
                dgv_NhanVien.Columns[6].HeaderText = "Lương";
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimKiem.Clear();
            txtTimKiem.BackColor = Color.LightGray;
            ResetValue();
        }

        private void cbTimKiemTheoVaiTro_Click(object sender, EventArgs e)
        {
            cbTimKiemTheoVaiTro.DataSource = busNV.ThemVaiTro();
            cbTimKiemTheoVaiTro.DisplayMember = "Name";
            cbTimKiemTheoVaiTro.ValueMember = "Id_role";
        }

        private void btDanhSach_Click(object sender, EventArgs e)
        {
            ShowData_GridViewNhanVien();
        }

        private void cbTimKiemTheoVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_NhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_NhanVien.Rows.Count > 0)
            {
                try
                {
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    txtEmail.Enabled = true;
                    nbLuong.Enabled = true;
                    txtTenNhanVien.Enabled = true;
                    txtDiaChi.Enabled = true;
                    cbVaiTro.Enabled = true;
                    dtNgaySinh.Enabled = true;
                    rbNam.Enabled = true;
                    rbNu.Enabled = true;
                    btnThemVaitro.Enabled = true;
                    txtEmail.Text = dgv_NhanVien.CurrentRow.Cells["Email"].Value.ToString();
                    txtTenNhanVien.Text = dgv_NhanVien.CurrentRow.Cells["Name"].Value.ToString();
                    txtDiaChi.Text = dgv_NhanVien.CurrentRow.Cells["Address"].Value.ToString();
                    nbLuong.Text = dgv_NhanVien.CurrentRow.Cells["Salary"].Value.ToString();
                    dtNgaySinh.Text = dgv_NhanVien.CurrentRow.Cells["DayOfBirth"].Value.ToString();
                    Id_emloyee.Text = dgv_NhanVien.CurrentRow.Cells["Id_employee"].Value.ToString();
                    cbVaiTro.SelectedValue = dgv_NhanVien.CurrentRow.Cells["Id_role"].Value.ToString();
                    if (dgv_NhanVien.CurrentRow.Cells["isDelete"].Value.ToString() == "True")
                        isDelete.Text = "True";
                    else
                        isDelete.Text = "False";
                    //if (int.Parse(dgv_NhanVien.CurrentRow.Cells["Id_role"].Value.ToString()) == 1)
                    //    cbVaiTro.Text = "Quản lý";
                    //else
                    //    cbVaiTro.Text = "Nhân viên";
                    if (int.Parse(dgv_NhanVien.CurrentRow.Cells["Gender"].Value.ToString()) == 1)
                        rbNam.Checked = true;
                    else
                        rbNu.Checked = true;
                }
                catch
                {
                    ResetValue();
                    MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
