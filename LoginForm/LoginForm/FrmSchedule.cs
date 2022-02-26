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
    public partial class FrmSchedule : Form
    {
        public FrmSchedule()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string id;
        public static string mail;
        BUS_LichLamViec schedules = new BUS_LichLamViec();
        private void F2_UpdateEventHandler(object sender, FrmShift.UpdateEventArgs args)
        {
            cbCaLam.DataSource = schedules.getDataId();
            cbCaLam.DisplayMember = "name";
            cbCaLam.ValueMember = "Id_shift";
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmShift frm = new FrmShift(this);
            frm.UpdateEventHandler += F2_UpdateEventHandler;
            frm.ShowDialog();
        }
        // load form
        public static int a = 0;
        private void FrmSchedule2_Load(object sender, EventArgs e)
        {
            resetForm();
            loadData();
        }
        // load data
        void loadData()
        {
            guna2DataGridView1.DataSource = schedules.getData();
            guna2DataGridView1.Columns[0].HeaderText = "ID";
            guna2DataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            guna2DataGridView1.Columns[2].HeaderText = "Ngày làm";
            guna2DataGridView1.Columns[3].HeaderText = "ca";

            cbTenNhanVien.DataSource = schedules.getDataName();
            cbTenNhanVien.DisplayMember = "Name";
            cbTenNhanVien.ValueMember = "Id_employee";

            cbCaLam.DataSource = schedules.getDataId();
            cbCaLam.DisplayMember = "name";
            cbCaLam.ValueMember = "Id_shift";

            //cbSearch.DataSource = schedules.getDataName();
            //cbSearch.DisplayMember = "Name";
            //cbSearch.ValueMember = "Id_employee";
        }
        // reset form
        void resetForm()
        {

            btXoa.Enabled = false;
            btSua.Enabled = false;
            btLuu.Enabled = false;

            cbCaLam.Enabled = false;
            cbTenNhanVien.Enabled = false;

            t2.Checked = false;
            t3.Checked = false;
            t4.Checked = false;
            t5.Checked = false;
            t6.Checked = false;
            t7.Checked = false;
            cn.Checked = false;
            if (a == 1)
            {
                btThem.Enabled = true;
            }
            else
            {
                btThem.Enabled = false;
            }
        }
        // lưu lịch 
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string day = "0";
            if (t2.Checked)
            {
                day += "2";
            }
            if (t3.Checked)
            {
                day += "3";
            }
            if (t4.Checked)
            {
                day += "4";
            }
            if (t5.Checked)
            {
                day += "5";
            }
            if (t6.Checked)
            {
                day += "6";
            }
            if (t7.Checked)
            {
                day += "7";
            }
            if (cn.Checked)
            {
                day += "8";
            }

            if (int.Parse(day) < 2)
            {
                MessageBox.Show("Vui lòng chọn ngày làm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                DTO_LichLamViec schedule = new DTO_LichLamViec(int.Parse(cbTenNhanVien.SelectedValue.ToString()), int.Parse(cbCaLam.SelectedValue.ToString()), int.Parse(day));
                if (schedules.InsertSchedule(schedule))
                {
                    loadData();
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Nhân viên đã có lịch vào ngày thứ " + day + " ca " + cbCaLam.SelectedValue.ToString());
                }
            }
        }
        //thêm
        private void btThem_Click(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btLuu.Enabled = true;
            btThemCa.Enabled = true;

            cbCaLam.Enabled = true;
            cbTenNhanVien.Enabled = true;
            t2.Checked = false;
            t3.Checked = false;
            t4.Checked = false;
            t5.Checked = false;
            t6.Checked = false;
            t7.Checked = false;
            cn.Checked = false;
        }
        // click datagridview
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t2.Checked = t3.Checked = t4.Checked = t5.Checked = t6.Checked = t7.Checked = cn.Checked = false;
            if (guna2DataGridView1.Rows.Count > 1)
            {
                if (a == 1)
                {
                    btThem.Enabled = true;
                    btLuu.Enabled = false;
                    btXoa.Enabled = true;
                    btSua.Enabled = true;
                    cbCaLam.Enabled = true;
                }
                else
                {
                    btThem.Enabled = false;
                    btLuu.Enabled = false;
                    btXoa.Enabled = false;
                    btSua.Enabled = false;
                }

                label1.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbTenNhanVien.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                cbCaLam.SelectedValue = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                cbCaLam.BorderRadius = 16;
                cbTenNhanVien.BorderRadius = 15;
                string day = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (day.Contains("2"))
                {
                    t2.Checked = true;
                }
                if (day.Contains("3"))
                {
                    t3.Checked = true;
                }
                if (day.Contains("4"))
                {
                    t4.Checked = true;
                }
                if (day.Contains("5"))
                {
                    t5.Checked = true;
                }
                if (day.Contains("6"))
                {
                    t6.Checked = true;
                }
                if (day.Contains("7"))
                {
                    t7.Checked = true;
                }
                if (day.Contains("8"))
                {
                    cn.Checked = true;
                }

            }
        }
        // xóa
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string day = "";
            if (t2.Checked)
            {
                day += "2";
            }
            if (t3.Checked)
            {
                day += "3";
            }
            if (t4.Checked)
            {
                day += "4";
            }
            if (t5.Checked)
            {
                day += "5";
            }
            if (t6.Checked)
            {
                day += "6";
            }
            if (t7.Checked)
            {
                day += "7";
            }
            if (cn.Checked)
            {
                day += "8";
            }
                if (schedules.DeleteDataSchedule(int.Parse(cbCaLam.SelectedValue.ToString()), int.Parse(cbTenNhanVien.SelectedValue.ToString()), int.Parse(day)))
                {
                    resetForm();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
        }
        // sửa
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string day = "";
            if (t2.Checked)
            {
                day += "2";
            }
            if (t3.Checked)
            {
                day += "3";
            }
            if (t4.Checked)
            {
                day += "4";
            }
            if (t5.Checked)
            {
                day += "5";
            }
            if (t6.Checked)
            {
                day += "6";
            }
            if (t7.Checked)
            {
                day += "7";
            }
            if (cn.Checked)
            {
                day += "8";
            }
            DTO_LichLamViec schedule = new DTO_LichLamViec(int.Parse(label1.Text), int.Parse(cbTenNhanVien.SelectedValue.ToString()), int.Parse(cbCaLam.SelectedValue.ToString()), int.Parse(day));

                if (schedules.UpdateSchedule(schedule))
                {
                    resetForm();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
             }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string name = txtNhaptennv.Text;
            DataTable schedule = schedules.searchSchedules(name);
            if (schedule.Rows.Count > 0)
            {
                guna2DataGridView1.DataSource = schedule;
                guna2DataGridView1.Columns[0].HeaderText = "ID";
                guna2DataGridView1.Columns[1].HeaderText = "Tên nhân viên";
                guna2DataGridView1.Columns[2].HeaderText = "Ngày làm";
                guna2DataGridView1.Columns[3].HeaderText = "ca";
            }
            else
            {
                MessageBox.Show("Không tìm thấy lịch làm nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDanhSacch_Click(object sender, EventArgs e)
        {
            loadData();
            txtNhaptennv.Text = "";
        }

        private void cbTenNhanVien_EnabledChanged(object sender, EventArgs e)
        {
            //cbTenNhanVien.FillColor = Color.White;
        }
    }
}
