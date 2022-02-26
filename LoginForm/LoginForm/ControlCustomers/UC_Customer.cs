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

namespace RJCodeAdvance.ControlCustomers
{
    public partial class UC_Customer : UserControl
    {
        public UC_Customer()
        {
            InitializeComponent();
            nbDiemTT.Maximum = 999999;
            nbDiemTT.Enabled = false;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = customer.SearchCustomer(txtsearch.Text);
            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Tên khách hàng";
            dgv.Columns[1].HeaderText = "Email";
            dgv.Columns[2].HeaderText = "Giới tính";
            dgv.Columns[3].HeaderText = "Mã khách hàng";
            dgv.Columns[4].HeaderText = "Điểm tích lũy";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FrmTable frm = new FrmTable();

            frm.ShowDialog();
        }
        BUS_Customer customer = new BUS_Customer();
        private void UC_Customer_Load(object sender, EventArgs e)
        {
            restValue();
            loadData();
        }
        void restValue()
        {
            txtName.Enabled = false;
            txbEmail.Enabled = false;
            nbDiemTT.ResetText();
            txtName.Text = "";
            txbEmail.Text = "";
            btSua.Enabled = false;
            rbNam.Enabled = false;
            rbNu.Enabled = false;
        }
        void loadData()
        {
            dgv.DataSource = customer.getData();
            dgv.Columns[0].HeaderText = "Tên khách hàng";
            dgv.Columns[1].HeaderText = "Email";
            dgv.Columns[2].HeaderText = "Giới tính";
            dgv.Columns[3].HeaderText = "Mã khách hàng";
            dgv.Columns[4].HeaderText = "Điểm tích lũy";
        }
        public string id;
        string gender;
        //datagridview click
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                txtName.Enabled = true;
                txbEmail.Enabled = true;
                btSua.Enabled = true;
                rbNam.Enabled = true;
                rbNu.Enabled = true;
                txtName.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                txbEmail.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                id = dgv.CurrentRow.Cells[3].Value.ToString();
                nbDiemTT.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                gender = dgv.CurrentRow.Cells[2].Value.ToString();
                if (gender == "Nam")
                {
                    rbNam.Checked = true;
                }
                if (gender == "Nữ")
                {
                    rbNu.Checked = true;
                }
            }
        }
        // sửa
        private void btSua_Click(object sender, EventArgs e)
        {
            if (rbNam.Checked)
            {
                gender = "Nam";
            }
            if (rbNu.Checked)
            {
                gender = "Nữ";
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    DTO_Customer Customers = new DTO_Customer(txtName.Text, txbEmail.Text, gender, int.Parse(nbDiemTT.Value.ToString()), int.Parse(id));
                    if (customer.UpdateCustomer(Customers))
                    {
                        loadData();
                        restValue();
                    }
                    else
                    {
                        MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                          }
        }

        private void btDanhSach_Click(object sender, EventArgs e)
        {
            loadData();
            
        }
    }
}
