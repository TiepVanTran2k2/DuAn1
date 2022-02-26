using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;
using RJCodeAdvance.ControlBeverages;

namespace RJCodeAdvance.ControlIngredient
{
    public partial class UC_ingredient : Form
    {
        public UC_ingredient()
        {
            InitializeComponent();
            btThemDonVi.Enabled = false;
        }
        BUS_NguyenLieu busIg = new BUS_NguyenLieu();
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmIngredientType frm = new FrmIngredientType();
            frm.ShowDialog();
            loadComBoBox();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmSupplier frm = new FrmSupplier();
            frm.ShowDialog();
            loadComBoBox();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtTenIngredient.Enabled = true;
            cbLoaiIngredient.Enabled = true;
            cbNhaCC.Enabled = true;
            txtGia.Enabled = true;
            guna2NumericUpDown1.Enabled = true;
            cbDVT.Enabled = true;
            btLuu.Enabled = true;
            btThemNL.Enabled = true;
            btThemNCC.Enabled = true;
            btThemDonVi.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv.CurrentRow.Cells["Id_Ingredient"].Value.ToString());
                if (busIg.DeleteNguyenLieu(id))
                {
                    ResetValue();
                    loaddgv();
                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Xoá không thành công");
                }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkTextBox())
                {
                    DTO_NguyenLieu dtoBe = new DTO_NguyenLieu(txtTenIngredient.Text, Convert.ToInt32(cbNhaCC.SelectedValue),
                        Convert.ToInt32(cbLoaiIngredient.SelectedValue), float.Parse(txtGia.Text),
                        int.Parse(guna2NumericUpDown1.Value.ToString()), Convert.ToInt32(cbDVT.SelectedValue),
                        int.Parse(dgv.CurrentRow.Cells[0].Value.ToString()),
                         "Images\\" + fileName);
                    if (busIg.UpdateNguyenLieu(dtoBe))
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
                        loaddgv();
                        ResetValue();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkTextBox())
                {
                    DTO_NguyenLieu dtoBe = new DTO_NguyenLieu(txtTenIngredient.Text, Convert.ToInt32(cbNhaCC.SelectedValue),
                            Convert.ToInt32(cbLoaiIngredient.SelectedValue), float.Parse(txtGia.Text),
                            int.Parse(guna2NumericUpDown1.Value.ToString()), Convert.ToInt32(cbDVT.SelectedValue),
                            "Images\\" + fileName);
                    if (busIg.InsertNguyenLieu(dtoBe))
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
                        loaddgv();
                        ResetValue();
                    }
                }
            }
            catch
            {

            }
                   
        }


        private void UC_ingredient_Load(object sender, EventArgs e)
        {
            ResetValue();
            loadComBoBox();
            txtHinh.Enabled = false;
            loaddgv();
        }
        void ResetValue()
        {
            txtTenIngredient.Enabled = false;
            txtTenIngredient.Text = "";
            cbLoaiIngredient.Enabled = false;
            txtGia.Enabled = false;
            txtGia.Value = 1;
            cbNhaCC.Enabled = false;
            guna2NumericUpDown1.Enabled = false;
            guna2NumericUpDown1.Value = 1;
            cbDVT.Enabled = false;
            txtSearch.Text = "";
            btXoa.Enabled = false; ;
            btSua.Enabled = false;
            btLuu.Enabled = false;
        }
        bool checkTextBox()
        {
            if (string.IsNullOrEmpty(txtTenIngredient.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                txtTenIngredient.Text = "";
                txtTenIngredient.Focus();
                return false;
            }

            if(txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá");
                return false;
            }
            float price;
            bool result = float.TryParse(txtGia.Text, out price);
            if (!result)
            {
                MessageBox.Show("vui lòng nhập giá nguyên liệu bằng số");
                return false;
            }
            if (float.Parse(txtGia.Text) < 10000 || float.Parse(txtGia.Text) > 5000000)
            {
                MessageBox.Show("Giá nguyên liệu từ 10,000 vnđ --> 5,000,000 vnđ");
                return false;
            }


            if (string.IsNullOrEmpty(txtHinh.Text))
            {
                MessageBox.Show("Vui lòng chọn ảnh cho nguyên liệu");
                return false;
            }
            if (string.IsNullOrEmpty(cbLoaiIngredient.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                cbLoaiIngredient.Text = "";
                cbLoaiIngredient.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbNhaCC.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                cbNhaCC.Text = "";
                cbNhaCC.Focus();
                return false;
            }
            if (int.Parse(guna2NumericUpDown1.Value.ToString()) <= 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                guna2NumericUpDown1.Value = 0;
                guna2NumericUpDown1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbDVT.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                cbDVT.Text = "";
                cbDVT.Focus();
                return false;
            }
            return true;
        }
        void loaddgv()
        {
            dgv.DataSource = busIg.getIngredient();
            dgv.Columns[0].HeaderText = "Id_Ingredient";
            dgv.Columns[1].HeaderText = "Name";
            dgv.Columns[2].HeaderText = "Supplier";
            dgv.Columns[3].HeaderText = "Type";
            dgv.Columns[4].HeaderText = "Mass";
            dgv.Columns[5].HeaderText = "Unit";
            dgv.Columns[6].HeaderText = "Images";
            dgv.Columns[7].HeaderText = "Price";
            dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[8].Visible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void loadComBoBox()
        {
            cbLoaiIngredient.DataSource = busIg.getIngredientType();
            cbLoaiIngredient.DisplayMember = "Name";
            cbLoaiIngredient.ValueMember = "Id_type";

            cbNhaCC.DataSource = busIg.getSupplier();
            cbNhaCC.DisplayMember = "Name";
            cbNhaCC.ValueMember = "Id_supplier";

            cbDVT.DisplayMember = "Name";
            cbDVT.ValueMember = "ID_unit";
            cbDVT.DataSource = busIg.getNameUnits();
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
                    txtTenIngredient.Enabled = true;
                    cbLoaiIngredient.Enabled = true;
                    cbNhaCC.Enabled = true;
                    txtGia.Enabled = true;
                    cbDVT.Enabled = true;
                    guna2NumericUpDown1.Enabled = true;
                    txtTenIngredient.Text = dgv.CurrentRow.Cells["Name"].Value.ToString();
                    txtGia.Text = dgv.CurrentRow.Cells["Price"].Value.ToString();
                    cbLoaiIngredient.SelectedValue = dgv.CurrentRow.Cells[3].Value.ToString();
                    cbNhaCC.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
                    cbDVT.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells[5].Value.ToString());
                    guna2NumericUpDown1.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                    txtHinh.Text = dgv.CurrentRow.Cells["Images"].Value.ToString();
                    checkUrlImage = txtHinh.Text;
                    fileName = Path.GetFileName(dgv.CurrentRow.Cells["Images"].Value.ToString());
                    if (File.Exists(dgv.CurrentRow.Cells["Images"].Value.ToString()))
                    {
                        picHinh.Image = Image.FromFile(dgv.CurrentRow.Cells["Images"].Value.ToString());
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

        private void btThemDonVi_Click(object sender, EventArgs e)
        {
            FrmUnit frm = new FrmUnit();
            frm.ShowDialog();
            loadComBoBox();
        }


        private void btTimKiem_Click_1(object sender, EventArgs e)
        {
            string tenHang = txtSearch.Text;
            DataTable ds = busIg.SearchNguyenLieu(tenHang);
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
        // lấy đường dẫn hình
        string checkUrlImage;// kiểm tra hình khi cập nhật
        string fileName;//tên file
        string fileSavePath;//url store image
        string fileAddress;// url load images

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void ptbOpen_Click_1(object sender, EventArgs e)
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

        private void cbLoaiIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btDanhSach_Click(object sender, EventArgs e)
        {
            loaddgv();
        }
    }
}
