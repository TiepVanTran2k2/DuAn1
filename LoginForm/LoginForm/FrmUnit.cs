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
    public partial class FrmUnit : Form
    {
        BUS_units units = new BUS_units();
        public FrmUnit()
        {
            InitializeComponent();
        }
        public int id;
        private void FrmUnit_Load(object sender, EventArgs e)
        {
            resetValue();
            loadData();
        }
        // load data
        void loadData()
        {
            DataTable dt = units.getData();
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "Id";
            guna2DataGridView1.Columns[1].HeaderText = "Đơn vị tính";
        }
        // reset value
        void resetValue()
        {
            txtName.Text = "";
            btLuu.Enabled = false;
            btXoa.Enabled = false;
            btSua.Enabled = false;
        }
        // thêm units
        private void btLuu_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đơn vị tính");
            }
            else
            {
                DTO_units unit = new DTO_units(txtName.Text);
                if (units.InsertDataUnits(unit))
                {
                    loadData();
                    resetValue();
                }
                else
                {
                    MessageBox.Show("Insert thất bại");
                    resetValue();
                }
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            btLuu.Enabled = true;
            btXoa.Enabled = true;
            btSua.Enabled = true;
        }
        // sửa data units
        private void btSua_Click(object sender, EventArgs e)
        {
            {
                DTO_units unit = new DTO_units(txtName.Text, id);
                if (units.UpdateDataUnits(unit))
                {
                    MessageBox.Show("Update thành công");
                    loadData();
                    resetValue();
                }
                else
                {
                    MessageBox.Show("Tên units đã tồn tại");
                    resetValue();
                }
            }
                    }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(guna2DataGridView1.Rows.Count > 0)
            {
                txtName.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                id = int.Parse(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString());
                btXoa.Enabled = true;
                btSua.Enabled = true;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            {
                if (units.deleteDataUnit(int.Parse(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString())))
                {
                    loadData();
                    resetValue();
                }
                else
                {
                    MessageBox.Show("Không được xóa !!!");
                    resetValue();
                }
            }
                    }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            DataTable a = units.searchDataUnit(txtSearch.Text);
            guna2DataGridView1.DataSource = a;
            guna2DataGridView1.Columns[0].HeaderText = "Id";
            guna2DataGridView1.Columns[0].HeaderText = "Đơn vị tính";
        }

        private void btDanhSacch_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
