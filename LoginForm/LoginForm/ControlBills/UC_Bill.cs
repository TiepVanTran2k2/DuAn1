using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;
using System.Collections;


namespace RJCodeAdvance.ControlBills
{
    public partial class UC_Bill : UserControl
    {
        BUS_Bill BUS_Bill = new BUS_Bill();
        public UC_Bill()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Hashtable hash;
        BindingSource bindingSource;

        public void UC_Bill_Load(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            btnXoaBillsDetail.Enabled = false;
            btSua.Enabled = false;
            if (rdoDoUong.Checked == true)
            {
                loadDGVDoUong();
                label2.Text = "Tên đồ uống";
            }
            else
            {
                loadDGVNL();
                label2.Text = "Tên nguyên liệu";
            }
            hash = new Hashtable();
            hash.Add("Id_Employee", "Tên nhân viên");
            hash.Add("Id_table", "Tên bàn");
            hash.Add("DateCheckOut", "Ngày xuất hoá đơn");

            dgvBillsDetail.Refresh();
            bindingSource = new BindingSource(hash,null);
            
            

        }
        //load dgv cua do uong
        void loadDGVDoUong()
        {
            dgvBill.DataSource = BUS_Bill.getBillDoUong();
            dgvBill.Columns[0].HeaderText = "Tên nhân viên";
            dgvBill.Columns[1].HeaderText = "Tên bàn";
            dgvBill.Columns[2].HeaderText = "Ngày xuất hoá đơn";
            dgvBill.Columns[3].HeaderText = "Id_bill";
            dgvBill.Columns[3].Visible = false;
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //load dgv cua nguyen lieu
        void loadDGVNL()
        {
            dgvBill.DataSource = BUS_Bill.getBillNL();
            dgvBill.Columns[0].HeaderText = "Tên nhân viên";
            dgvBill.Columns[1].HeaderText = "Ngày nhập hoá đơn";
            dgvBill.Columns[2].HeaderText = "Tổng giá";
            dgvBill.Columns[3].HeaderText = "ID_Bill";
            dgvBill.Columns[3].Visible = false;
            dgvBill.Columns[4].Visible = false;
            dgvBill.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //load dgv cua do uong nhung detail
        void loadBillDetail(int id)
        {
            dgvBillsDetail.DataSource = BUS_Bill.getBillDetailDoUong(id);
            dgvBillsDetail.Columns[0].HeaderText = "Tên đồ uống";
            dgvBillsDetail.Columns[1].HeaderText = "Số lượng";
            dgvBillsDetail.Columns[2].HeaderText = "Id_bill_detaill";
            dgvBillsDetail.Columns[4].HeaderText = "Total";
            dgvBillsDetail.Columns[2].Visible = true ;
            dgvBillsDetail.Columns[3].Visible = false;
            dgvBillsDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvBillsDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //load dgv cua nguyen lieu nhung detail
        void loadBillDetailNL(int id)
        {
            dgvBillsDetail.DataSource = BUS_Bill.getBillDetailNL(id);
            dgvBillsDetail.Columns[0].HeaderText = "Tên nguyên liệu";
            dgvBillsDetail.Columns[1].HeaderText = "Số lượng";
            dgvBillsDetail.Columns[2].HeaderText = "Id_BillDetaill";
            dgvBillsDetail.Columns[3].HeaderText = "Đơn giá";
            dgvBillsDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBillsDetail.Columns[4].HeaderText = "Tổng tiền";
            dgvBillsDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBillsDetail.Columns[2].Visible = false;
            dgvBillsDetail.Columns[5].Visible = false;
            dgvBillsDetail.Columns[6].Visible = false;
            dgvBillsDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void rdoDoUong_Click(object sender, EventArgs e)
        {

        }

        private void rdoDoUong_CheckedChanged(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            btnXoaBillsDetail.Enabled = false;
            btSua.Enabled = false;

            loadDGVDoUong();
            dgvBillsDetail.Refresh();
            bindingSource = new BindingSource(hash, null);
            
            label2.Text = "Tên đồ uống";
            txtDoUong.Text = null;
            nbSoLuong.Value = 1;
            dgvBillsDetail.DataSource = null;
        }

        private void rdoNguyenLieu_CheckedChanged(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            btnXoaBillsDetail.Enabled = false;
            btSua.Enabled = false;

            loadDGVNL();
            dgvBillsDetail.Refresh();
            Hashtable h2 = new Hashtable();
            h2.Add("ID_employee", "Tên nhân viên");
            h2.Add("SumPrice", "Tổng giá");
            h2.Add("DateCheckIn", "Ngày nhập hoá đơn");
            dgvBillsDetail.Refresh();
            BindingSource b2 = new BindingSource(h2, null);
            

            label2.Text = "Tên nguyên liệu";
            txtDoUong.Text = null;
            nbSoLuong.Value = 1;

            dgvBillsDetail.DataSource = null;
        }
        //click vao dgv
        int idInputBill = 0;
        float sum = 0;
        int id = 0;
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btXoa.Enabled = true;
            btSua.Enabled = false;
            try
            {
                if (dgvBill.Rows.Count > 0 )
                {
                    if (rdoDoUong.Checked == true)
                    {
                        id = int.Parse(dgvBill.CurrentRow.Cells["Id_bill"].Value.ToString());
                        loadBillDetail(id);
                        txtDoUong.Text = dgvBill.CurrentRow.Cells[0].Value.ToString();
                    }
                    else
                    {
                        idInputBill = int.Parse(dgvBill.CurrentRow.Cells["ID_Bill"].Value.ToString());
                        sum = float.Parse(dgvBill.CurrentRow.Cells[2].Value.ToString());
                        loadBillDetailNL(idInputBill);
                        txtDoUong.Text = dgvBill.CurrentRow.Cells[0].Value.ToString();
                    }
                    btXoa.Enabled = true;
                    btSua.Enabled = true;
                    nbSoLuong.Value = 1;
                    txtDoUong.Text = null;
                }
                else
                {
                    MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //click nut xoa
        private void btXoa_Click_1(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            btnXoaBillsDetail.Enabled = false;
            btSua.Enabled = false;
            try
            {
                if (rdoDoUong.Checked == true)
                {
                    int id = Convert.ToInt32(dgvBill.CurrentRow.Cells["Id_bill"].Value.ToString());
                        if (BUS_Bill.DeleteBillsDoUong(id))
                        {
                            if (rdoDoUong.Checked == true)
                            {
                                loadDGVDoUong();
                            }
                            else
                            {
                                loadDGVNL();
                            }
                            loadBillDetail(id);
                        }
                        else
                        {
                            MessageBox.Show("Xoá không thành công");
                        }
                    
                }
                else
                {
                    int id2 = int.Parse(dgvBill.CurrentRow.Cells["ID_Bill"].Value.ToString());
                        if (BUS_Bill.DeleteBillsNL(id2))
                        {
                            loadDGVNL();
                            loadBillDetailNL(id2);
                        }
                        else
                        {
                            MessageBox.Show("Xoá không thành công");
                        }
                    
                }
                nbSoLuong.Value = 1;
                txtDoUong.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //click nut xoa nhung ben detail
        private void btnXoaBillsDetail_Click_1(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            btnXoaBillsDetail.Enabled = false;
            btSua.Enabled = false;
            try
            {

                if (rdoDoUong.Checked == true)
                {
                    int id = Convert.ToInt32(dgvBillsDetail.CurrentRow.Cells["Id_bill_detaill"].Value.ToString());

                    int id1 = Convert.ToInt32(dgvBill.CurrentRow.Cells["Id_bill"].Value.ToString());
                    float price = float.Parse(dgvBillsDetail.CurrentRow.Cells[3].Value.ToString());
                    if (BUS_Bill.DeleteBillsDetailDoUong(id))
                        {

                        priceDoUong = priceDoUong - price;
                        if(priceDoUong == 0)
                        {
                            BUS_Bill.DeleteBillsDoUong(id1);
                            dgvBillsDetail.DataSource = null;

                            if (rdoDoUong.Checked == true)
                            {
                                loadDGVDoUong();
                            }
                            else
                            {
                                loadDGVNL();
                            }
                        }


                        loadBillDetail(id1);
                        }
                    
                }
                else
                {
                    int idtemp = int.Parse(dgvBill.CurrentRow.Cells["ID_Bill"].Value.ToString());

                    int id2 = Convert.ToInt32(dgvBillsDetail.CurrentRow.Cells["Id_BillDetaill"].Value.ToString());
                    float b = float.Parse(dgvBill.CurrentRow.Cells[4].Value.ToString()) - float.Parse(dgvBillsDetail.CurrentRow.Cells[6].Value.ToString());
                    if(b <= 0)
                    {
                        BUS_Bill.DeleteBillsNL(idInputBill);
                        dgvBillsDetail.DataSource = null;
                    }
                    BUS_Bill.updateInputBill(idInputBill, b);
                    loadDGVNL();
                    if (BUS_Bill.DeleteBillsDetailNL(id2))
                    {
                        loadBillDetailNL(idtemp);
                        txtDoUong.ResetText();
                    }
                }
                nbSoLuong.Value = 1;
                txtDoUong.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //click nut sua
        private void btSua_Click_1(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            btnXoaBillsDetail.Enabled = false;
            btSua.Enabled = false;
            try
            {
                if (rdoDoUong.Checked == true)
                {
                    
                    DTO_Bill_Detail dto = new DTO_Bill_Detail(Convert.ToInt32(dgvBillsDetail.CurrentRow.Cells["Id_bill_detaill"].Value.ToString()), Convert.ToInt32(nbSoLuong.Text));
                    if (BUS_Bill.UpdateBillsDetailDoUong(dto))
                    {
                        int idtemp = int.Parse(dgvBill.CurrentRow.Cells["Id_bill"].Value.ToString());
                        loadBillDetail(idtemp);

                    }

                }
                else
                {

                    int id2 = Convert.ToInt32(dgvBillsDetail.CurrentRow.Cells["Id_BillDetaill"].Value.ToString());
                    if (BUS_Bill.UpdateBillsDetailNL(Convert.ToInt32(nbSoLuong.Text), id2))
                    {
                        int idtemp = int.Parse(dgvBill.CurrentRow.Cells["ID_Bill"].Value.ToString());
                        loadBillDetailNL(idtemp);
                        DataTable a = (DataTable)dgvBillsDetail.DataSource;
                        float b = 0;
                        foreach(DataRow item in a.Rows)
                        {
                            b += float.Parse(item[6].ToString());
                        }
                        BUS_Bill.updateInputBill(idtemp, b);
                        loadDGVNL();
                        //MessageBox.Show("" + dgvBillsDetail.CurrentRow.Cells[6].Value.ToString());
                        //MessageBox.Show("" + sumprice);
                        //MessageBox.Show("" + idInputBill);
                        //float sum = f(dgvBillsDetail.CurrentRow.Cells[6].Value.ToString());
                        //if()
                    }

                }
                nbSoLuong.Value = 1;
                txtDoUong.Text = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //click nut tim kiem
        
        //thay vi click nut tim kiem thi minh an enter cho nhanh
        private void txtSearchDoUong_KeyDown(object sender, KeyEventArgs e)
        {
        }
        //click vao dgv nhung ben detail
        float donGia = 0;
        float sumprice = 0;
        float priceDoUong = 0;
        private void dgvBillsDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btSua.Enabled = true;
            btnXoaBillsDetail.Enabled = true;
            try
            {
                if (dgvBill.Rows.Count > 0 || dgvBillsDetail.Rows.Count > 0)
                {
                    if (rdoDoUong.Checked == true)
                    {
                        priceDoUong = 0;
                        txtDoUong.Text = dgvBillsDetail.CurrentRow.Cells[0].Value.ToString();
                        nbSoLuong.Value = decimal.Parse(dgvBillsDetail.CurrentRow.Cells[1].Value.ToString());
                        donGia = float.Parse(dgvBillsDetail.CurrentRow.Cells[2].Value.ToString());

                        for(int i = 0; i < dgvBillsDetail.Rows.Count - 1; i++)
                        {
                            priceDoUong += float.Parse(dgvBillsDetail.Rows[i].Cells[3].Value.ToString());
                        }
                    }
                    else
                    {
                        txtDoUong.Text = dgvBillsDetail.CurrentRow.Cells[0].Value.ToString();
                        nbSoLuong.Value = decimal.Parse(dgvBillsDetail.CurrentRow.Cells[1].Value.ToString());
                        sumprice = float.Parse(dgvBillsDetail.CurrentRow.Cells[6].Value.ToString());
                    }
                    btXoa.Enabled = true;
                    btSua.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //khong biet la gi nhung tren mang chi vay la click vao header khong dc
        private void dgvBill_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        //chon cai combobox se doi placeholder cua txt search cho vui
        private void cbbFilterCol_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if(label8.ForeColor == Color.FromArgb(0, 118, 212))
            {
                label8.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else if(label8.ForeColor == Color.FromArgb(255, 0, 0))
            {
                label8.ForeColor = Color.FromArgb(124, 252, 0);
            }else if(label8.ForeColor == Color.FromArgb(124, 252, 0))
            {
                label8.ForeColor = Color.FromArgb(0, 118, 212);
            }
        }

    }
}