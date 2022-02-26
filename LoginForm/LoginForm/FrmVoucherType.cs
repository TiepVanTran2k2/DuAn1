using BUS_QuanLy;
using DTO_QuanLy;
using RJCodeAdvance.ControlVouchers;
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
    public partial class FrmVoucherType : Form
    {
        public FrmVoucherType(UC_Voucher frm1)
        {
            InitializeComponent();
        }
        BUS_LoaiVoucher typeVouchers = new BUS_LoaiVoucher();
        public delegate void UpdateDelegate(Object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        // bt lưu
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            int so;
            bool result = int.TryParse(txtSale.Text, out so);
            if (txtSale.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khuyến mãi");
            }
            else
            {
                if (result)
                {
                    if (int.Parse(txtSale.Text) >= 10 && int.Parse(txtSale.Text) <= 100)
                    {
                        DTO_LoaiVoucher typevouchers = new DTO_LoaiVoucher(float.Parse(txtSale.Text));
                        if (typeVouchers.InsertTypeVoucher(typevouchers))
                        {
                            LoadData();
                            resetValue();
                        }
                        else
                        {
                            MessageBox.Show("Đã có khuyến mãi: " + txtSale.Text + "%");
                            resetValue();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sale từ 10% --> 100%");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập Sale bằng số");
                }
            }

            insert();
        }
        public string id;
        // click datagribview
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows.Count > 1)
            {
                txtSale.Enabled = true;
                id = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtSale.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();

                guna2Button3.Enabled = true;
                guna2Button4.Enabled = true;
                guna2Button5.Enabled = false;
            }
        }

        private void VoucherType_Load(object sender, EventArgs e)
        {
            resetValue();
            LoadData();
        }
        void LoadData()
        {
            guna2DataGridView1.DataSource = typeVouchers.getData();
            guna2DataGridView1.Columns[1].HeaderText = "Khuyến mãi";
        }
        // reset form
        void resetValue()
        {
            guna2Button3.Enabled = false;
            guna2Button4.Enabled = false;
            guna2Button5.Enabled = false;
            txtSale.Enabled = false;
            txtSale.Text = null;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            guna2Button3.Enabled = false;
            guna2Button4.Enabled = false;
            guna2Button5.Enabled = true;
            txtSale.Enabled = true;
            txtSale.Text = null;
        }
        //xóa
        private void guna2Button3_Click(object sender, EventArgs e)
        {
         
                if (typeVouchers.DeleteDataTypeVoucher(int.Parse(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString())))
                {
                    resetValue();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                        insert();
        }
        //sửa
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            int so;
            bool result = int.TryParse(txtSale.Text, out so);
                   if (txtSale.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập Sale");
                }
                else
                {
                    if (result)
                    {
                        if (int.Parse(txtSale.Text) >= 10 && int.Parse(txtSale.Text) <= 100)
                        {
                            DTO_LoaiVoucher typeVoucher = new DTO_LoaiVoucher(int.Parse(id), float.Parse(txtSale.Text));
                            if (typeVouchers.UpdateDataTypeVoucher(typeVoucher))
                            {
                                resetValue();
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Đã có loại voucher: " + txtSale.Text + "%");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sale từ 10% --> 100%");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập Sale bằng số");
                    }
                }
                       insert();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dttypeVoucher = typeVouchers.SearchDataTypeVoucher(float.Parse(txtSearch.Text));
            if (dttypeVoucher.Rows.Count > 0)
            {
                guna2DataGridView1.DataSource = dttypeVoucher;
                guna2DataGridView1.Columns[0].HeaderText = "ID";
                guna2DataGridView1.Columns[1].HeaderText = "Khuyến mãi";
            }
            else
            {
                MessageBox.Show("Không tìm thấy voucher: " + txtSearch.Text + "%");
            }
        }
    }
}
