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
    public partial class FrmAddBeverage : Form
    {
        public int IdTable;
        DTO_QuanLyDoUong Beverage;
        public int IdEmpoyee;
        public int sale = 0;
        BUS_Bill_Detail bus_bill_detail = new BUS_Bill_Detail();
        BUS_Bill bus_bill = new BUS_Bill();
        BUS_Vouchers bus_voucher = new BUS_Vouchers();
        public FrmAddBeverage(int idTable, DTO_QuanLyDoUong beverage, int idEmployee)
        {
            InitializeComponent();
            IdTable = idTable;
            Beverage = beverage;             
            IdEmpoyee = idEmployee;
        }

        private void FrmAddBeverage_Load(object sender, EventArgs e)
        {
            label1.Text = Beverage.Price.ToString("#,###") + " VNĐ";
            lblBeverageName.Text = Beverage.Name;
            lblPrice.Text = Beverage.Price + "đ";
            ptbImg.Image = Image.FromFile(Application.StartupPath + "\\" + Beverage.Image);
            txbTongTien.Text = Beverage.Price.ToString("#,###");
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            int idbill = bus_bill.GetUncheckBill(IdTable);
            if (txbVoucher.Text.Length == 6 && sale == 0)
            {
                if (MessageBox.Show("bạn chưa xác nhận voucher, vẫn muốn tiếp tục thêm đồ uống?",
                    "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
            }

            if (idbill == -1)
            {
                bus_bill.InsertBill(IdTable, IdEmpoyee);
                DTO_Bill_Detail billDetail = new DTO_Bill_Detail();
                billDetail.ID_Bill = bus_bill.getMaxId();
                billDetail.Id_Beverage = Beverage.Id_Beverage;
                billDetail.Quantity = (int)nbSoLuong.Value;
                billDetail.sale = sale;
                bus_bill_detail.InsertBillDetail(billDetail);
            }
            else
            {
                DTO_Bill_Detail billDetail = new DTO_Bill_Detail();
                billDetail.ID_Bill = idbill;
                billDetail.Id_Beverage = Beverage.Id_Beverage;
                billDetail.Quantity = (int)nbSoLuong.Value;
                billDetail.sale = sale;
                bus_bill_detail.InsertBillDetail(billDetail);
            }

            if (sale != 0)
            {
                bus_voucher.deleteVoucher(txbVoucher.Text);
                sale = 0;
                txbVoucher.Text = "";
                nbSoLuong.Maximum = 99;
            }
            this.Close();
        }

        private void btNhap_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbVoucher.Text))
            {
                int typeVoucher = bus_voucher.getTypeVoucherById(txbVoucher.Text);
                if (typeVoucher == -1)
                {
                    MessageBox.Show("voucher này đã hết hạn");
                    txbVoucher.Text = "";
                }
                else if (typeVoucher == 0)
                {
                    MessageBox.Show("Voucher sai vui lòng kiểm tra lại");
                    txbVoucher.Text = "";
                }
                else
                {
                    MessageBox.Show($"giảm giá {typeVoucher}% đã được áp dụng");
                    txbVoucher.Enabled = false;
                    sale = typeVoucher;
                    nbSoLuong.Value = 1;
                    nbSoLuong.Maximum = 1;
                    txbTongTien.Text = (Beverage.Price * int.Parse(nbSoLuong.Value.ToString()) * (100 - sale)/100).ToString("c");
                }
            }
        }

        private void nbSoLuong_ValueChanged(object sender, EventArgs e)
        {
            txbTongTien.Text = (Beverage.Price * int.Parse(nbSoLuong.Value.ToString())).ToString("#,###");
        }
    }
}
