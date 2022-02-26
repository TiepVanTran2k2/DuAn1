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

namespace RJCodeAdvance.ControlVouchers
{
    public partial class UC_Voucher : UserControl
    {
        public UC_Voucher()
        {
            InitializeComponent();
        }
        public static string mail;
        public string id;
        BUS_Vouchers vouchers = new BUS_Vouchers();
        private void F2_UpdateEventHandler(object sender, FrmVoucherType.UpdateEventArgs args)
        {
            cbSale.DataSource = vouchers.getSale();
            cbSale.DisplayMember = "Sale";
            cbSale.ValueMember = "ID_Type";

            cbSearch.DataSource = vouchers.getSale();
            cbSearch.DisplayMember = "Sale";
            cbSearch.ValueMember = "ID_Type";
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmVoucherType frm = new FrmVoucherType(this);
            frm.UpdateEventHandler += F2_UpdateEventHandler;
            frm.ShowDialog();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            guna2Button5.Enabled = true;
            guna2Button1.Enabled = true;
            cbSale.Enabled = true;
            dayStart.Enabled = true;
            dayEnd.Enabled = true;
        }

        private void UC_Voucher_Load(object sender, EventArgs e)
        {
            loadData();
            txtSoLuong.DataSource = vouchers.getData();
            txtSoLuong.Columns[4].Visible = false;
            ResetValue();
        }
        void ResetValue()
        {
            cbSale.Enabled = false;
            dayStart.Enabled = false;
            dayEnd.Enabled = false;
            btThem.Enabled = true;
        }
        // load data
        void loadData()
        {
            txtSoLuong.DataSource = vouchers.getData();
            txtSoLuong.Columns[0].HeaderText = "Mã voucher";
            txtSoLuong.Columns[1].HeaderText = "Ngày bắt đầu";
            txtSoLuong.Columns[2].HeaderText = "Ngày kết thúc";
            txtSoLuong.Columns[3].HeaderText = "Khuyến mãi";
            txtSoLuong.Columns[4].HeaderText = "Ghi chú";

            cbSale.DisplayMember = "Sale";
            cbSale.ValueMember = "ID_Type";
            cbSale.DataSource = vouchers.getSale();

            cbSearch.DataSource = vouchers.getSale();
            cbSearch.DisplayMember = "Sale";
            cbSearch.ValueMember = "ID_Type";
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtSoLuong.Rows.Count > 0)
            {
                guna2Button1.Enabled = true;
                guna2Button3.Enabled = true;
                guna2Button5.Enabled = false;
                btThem.Enabled = true;
                dayStart.Text = txtSoLuong.CurrentRow.Cells[1].Value.ToString();
                dayEnd.Text = txtSoLuong.CurrentRow.Cells[2].Value.ToString();
                cbSale.SelectedValue = txtSoLuong.CurrentRow.Cells[5].Value.ToString();
                string status = txtSoLuong.CurrentRow.Cells[4].Value.ToString();
                id = txtSoLuong.CurrentRow.Cells[0].Value.ToString();
                int value = int.Parse(cbSale.SelectedValue.ToString());

                DataTable counts = vouchers.getCountSaleVoucher(value);
                guna2TextBox1.Text = ""+ counts.Rows[0][0].ToString();
                txtThem.ResetText();
                if(int.Parse(status) == 1)
                {
                    rdDung.Checked = true;
                }
                else
                {
                    rdChua.Checked = true;
                }
            }

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (txtThem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng voucher muốn thêm");
            }
            else
            {
                int id = int.Parse(cbSale.SelectedValue.ToString());
                int number = int.Parse(txtThem.Text);
                do
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(2, false));
                    builder.Append(RandomString(1, true));
                    builder.Append(RandomString(1, false));
                    builder.Append(RandomString(2, true));
                    string id_vouchers = builder.ToString();
                    DTO_Vouchers voucher = new DTO_Vouchers(id_vouchers, dayStart.Text, dayEnd.Text, mail, id, 0);
                    if (vouchers.InsertDatevoucher(voucher))
                    {
                        loadData();
                        number = number - 1;
                    }
                    else
                    {
                        continue;
                    }
                } while (number > 0);
                ResetValue();
            }
        }
        // tạo mã voucher ngẫu nhiên
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa khuyến mãi "+cbSale.Text+"% Ngày tạo: "+dayStart.Text+" Ngày hết: "+dayEnd.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (vouchers.deleteVoucher(int.Parse(cbSale.SelectedValue.ToString()), dayStart.Text, dayEnd.Text))
                {
                    MessageBox.Show("Delete thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Delete không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            loadData();
            cbSale.ResetText();
            cbSearch.ResetText();
            txtSoLuong.ResetText();
            txtThem.ResetText();
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btTimKiem_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(cbSearch.SelectedValue.ToString());
            DataTable voucher = vouchers.searchDataVoucher(id);
            if (voucher.Rows.Count > 0)
            {
                txtSoLuong.DataSource = voucher;
                txtSoLuong.Columns[0].HeaderText = "Mã voucher";
                txtSoLuong.Columns[1].HeaderText = "Ngày bắt đầu";
                txtSoLuong.Columns[2].HeaderText = "Ngày kết thúc";
                txtSoLuong.Columns[3].HeaderText = "Khuyến mãi";
                DataTable number = vouchers.getCountSaleVoucher(id);
                txtSoLuong.Text = number.Rows[0][0].ToString();
                txtThem.ResetText();
            }
            else
            {
                MessageBox.Show("Chưa có khuyến mãi " + cbSearch.Text + "%");
                loadData();
            }
            DataTable counts = vouchers.getCountSaleVoucher(id);
            txtSoLuong.Text = counts.Rows[0][0].ToString();
        }
    }
}
