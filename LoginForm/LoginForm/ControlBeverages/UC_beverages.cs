using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;
using DAL_QuanLy;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Collections;

namespace RJCodeAdvance.ControlBeverages
{
    public partial class UC_Beverages2 : Form
    {
        public UC_Beverages2()
        {
            InitializeComponent();
        }
        private void F2_UpdateEventHandler(object sender, FrmTypeOfBeverage.UpdateEventArgs args)
        {
            cbDoUong.DataSource = busBe.getBeverageType();
            cbDoUong.DisplayMember = "Name";
            cbDoUong.ValueMember = "id_type";
        }
        private void UC_Beverages2_Load(object sender, EventArgs e)
        {
            ResetValue();
            loadComBoBox();
            loadComBoBoxSearch();
            loadDGV();
            cbbFilterCol.SelectedIndex = 4;
            
        }
        Hashtable hash;
        BindingSource bindingSource;
        void loadComBoBoxSearch()
        {
            cbbFilterCol.DataSource = null;
            cbbFilterCol.Items.Clear();
            hash = new Hashtable();
            hash.Add("Name", "Tên đồ uống");
            hash.Add("Price", "Giá");
            hash.Add("Id_type", "ID loại đồ uống");
            hash.Add("Id_beverage", "ID đồ uống");
            hash.Add("all", "Tất cả");
            bindingSource = new BindingSource(hash, null);
            cbbFilterCol.DataSource = bindingSource;
            cbbFilterCol.ValueMember = "Key";
            cbbFilterCol.DisplayMember = "Value";
        }
        BUS_Beverage busBe = new BUS_Beverage();
        void ResetValue()
        {
            picHinh.Image = default;
            txtTenDoUong.Enabled = false;
            txtTenDoUong.Text = "";
            cbDoUong.Enabled = false;
            cbDoUong.Text = "";
            nbGia.Enabled = false;
            nbGia.Text = "";
            txtHinh.Enabled = false;
            txtHinh.Text = "";
            ptbOpen.Enabled = false;
            txtSearchDoUong.Text = "";
            btXoa.Enabled = false; ;
            btSua.Enabled = false;
            btLuu.Enabled = false;
        }
        bool checkTextBox()
        {
            if (string.IsNullOrEmpty(txtTenDoUong.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                txtTenDoUong.Text = "";
                txtTenDoUong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(nbGia.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                nbGia.Text = "";
                nbGia.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbDoUong.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                cbDoUong.Text = "";
                cbDoUong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbDoUong.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                cbDoUong.Text = "";
                cbDoUong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHinh.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                txtHinh.Text = "";
                txtHinh.Focus();
                return false;
            }
            return true;
        }
        void loadDGV()
        {
            dgvBeverage.DataSource = busBe.getBeverage();
            dgvBeverage.Columns[0].HeaderText = "Tên đồ uống";
            dgvBeverage.Columns[1].HeaderText = "Giá";
            dgvBeverage.Columns[2].HeaderText = "ID loại";
            dgvBeverage.Columns[3].HeaderText = "ID đồ uống";
            dgvBeverage.Columns[4].HeaderText = "Đường dẫn hình";
            dgvBeverage.Columns[5].Visible = false;
            dgvBeverage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void loadComBoBox()
        {
            cbDoUong.DataSource = busBe.getBeverageType();
            cbDoUong.DisplayMember = "Name";
            cbDoUong.ValueMember = "id_type";
            //cbDoUong.AutoCompleteSource = AutoCompleteSource.ListItems;
            //cbDoUong.AutoCompleteMode = AutoCompleteMode.Suggest;
        }


        private void btThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtTenDoUong.Enabled = true;
            cbDoUong.Enabled = true;
            nbGia.Enabled = true;
            txtHinh.Enabled = true;
            btLuu.Enabled = true;
            ptbOpen.Enabled = true;
            picHinh.Image = default;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvBeverage.CurrentRow.Cells[3].Value.ToString());
            if (MessageBox.Show("Bạn có chắc muốn xoá dữ liệu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busBe.DeleteDoUong(id))
                {
                    ResetValue();
                    loadDGV();
                }
                else
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
            else
            {
                ResetValue();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkTextBox())
                {

                    DTO_QuanLyDoUong dtoBe = new DTO_QuanLyDoUong(txtTenDoUong.Text,
                        float.Parse(nbGia.Text), Convert.ToInt32(cbDoUong.SelectedValue), "Images\\" + fileName);
                    if (busBe.InsertDoUong(dtoBe))
                    {
                        string path = @"Images";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        if (txtHinh.Text != checkUrlImage)
                        {
                            File.Copy(fileAddress, fileSavePath, true);//copy file hinh
                        }

                        loadDGV();
                    }
                }
            }
            catch
            {
            }
        }

       
        string checkUrlImage;// kiểm tra hình khi cập nhật
        string fileName;//tên file
        string fileSavePath;//url store image
        string fileAddress ;// url load images

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkTextBox())
                {
                    DTO_QuanLyDoUong dtoBe = new DTO_QuanLyDoUong(txtTenDoUong.Text,
                        float.Parse(nbGia.Text), Convert.ToInt32(cbDoUong.SelectedValue),
                        Convert.ToInt32(dgvBeverage.CurrentRow.Cells[3].Value.ToString()), "Images\\" + fileName);
                    if (busBe.UpdateDoUong(dtoBe))
                    {
						string path = @"Images";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        if (txtHinh.Text != checkUrlImage)
                        {
                            File.Copy(fileAddress, fileSavePath, true);//copy file hinh
                        }
                        loadDGV();
                        ResetValue();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }



        private void dgvBeverage_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBeverage.Rows.Count > 1)
                {
                    btLuu.Enabled = false;
                    btXoa.Enabled = true;
                    btSua.Enabled = true;
                    txtTenDoUong.Enabled = true;
                    cbDoUong.Enabled = true;
                    nbGia.Enabled = true;
                    txtHinh.Enabled = true;
                    ptbOpen.Enabled = true;
                    txtTenDoUong.Text = dgvBeverage.CurrentRow.Cells[0].Value.ToString();
                    nbGia.Text = dgvBeverage.CurrentRow.Cells[1].Value.ToString();
                    cbDoUong.SelectedValue = dgvBeverage.CurrentRow.Cells[2].Value.ToString();
                    txtHinh.Text = dgvBeverage.CurrentRow.Cells[4].Value.ToString();
                    checkUrlImage = txtHinh.Text;
                    fileName = Path.GetFileName(dgvBeverage.CurrentRow.Cells[4].Value.ToString());
                    if (File.Exists(dgvBeverage.CurrentRow.Cells[4].Value.ToString()))
                    {
                        picHinh.Image = Image.FromFile(dgvBeverage.CurrentRow.Cells[4].Value.ToString());
                    }
                    else
                    {
                        picHinh.Image = default;
                    }

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

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string tenHang = txtSearchDoUong.Text;
            string tenCot = cbbFilterCol.SelectedValue.ToString();
            DataTable ds = busBe.SearchDoUong(tenHang,tenCot);
            if (ds.Rows.Count > 0)
            {
                dgvBeverage.DataSource = ds;
                dgvBeverage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ResetValue();
        }

        private void bntLoaiDoUong_Click(object sender, EventArgs e)
        {
            FrmTypeOfBeverage frm = new FrmTypeOfBeverage(this);
            frm.UpdateEventHandler += F2_UpdateEventHandler;
            frm.ShowDialog();
        }

        private void cbDoUong_Click(object sender, EventArgs e)
        {
            loadComBoBox();
        }

        private void btDanhSach_Click(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void txtSearchDoUong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btTimKiem_Click(sender, e);
            }

        }

        private void btDanhSach_Click_1(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void cbbFilterCol_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (cbbFilterCol.SelectedIndex == 0)
            {
                txtSearchDoUong.PlaceholderText = "Nhập tên đồ uống cần tìm";
            }
            if (cbbFilterCol.SelectedIndex == 1)
            {
                txtSearchDoUong.PlaceholderText = "Nhập ID loại đồ uống cần tìm";
            }
            if (cbbFilterCol.SelectedIndex == 2)
            {
                txtSearchDoUong.PlaceholderText = "Nhập ID đồ uống cần tìm";
            }
            if (cbbFilterCol.SelectedIndex == 3)
            {
                txtSearchDoUong.PlaceholderText = "Nhập giá đồ uống cần tìm";
            }
            if (cbbFilterCol.SelectedIndex == 4)
            {
                txtSearchDoUong.PlaceholderText = "Tìm kiếm tất cả các cột";
            }
        }

        private void ptbOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|.bmp|JPEG(*.jpg)|*.jpg|GIF(*.fig)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                picHinh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = "Images\\" + fileName;//combine with file name
                txtHinh.Text = "Images\\" + fileName;
            }
        }
    }
}
