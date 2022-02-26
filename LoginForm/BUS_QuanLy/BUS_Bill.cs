using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class BUS_Bill
    {
        DAL_Bill dal_bill = new DAL_Bill();
        public DataTable priceAfterUpdate(int id)
        {
            return dal_bill.priceAfterUpdate(id);
        }
        public bool updateInputBill(int id, float sum)
        {
            return dal_bill.updateInputBill(id, sum);
        }
        public int getMaxId()
        {
            return dal_bill.getMaxId();
        }
        public DataTable getbill(int id)
        {
            return dal_bill.getbill(id);
        }
        public bool addCustomer(int idCustomer, int idBill)
        {
            return dal_bill.addCustomer(idCustomer, idBill);
        }
        public bool CheckOut(int id)
        {
           return dal_bill.CheckOut(id);
        }
        public bool InsertBill(int idTable , int IdEmployee)
        {
            return dal_bill.InsertBill(idTable, IdEmployee);
        }

        public int GetUncheckBill(int id)
        {
            return dal_bill.GetUncheckBill(id);
        }

        public double getSumPrice(int id_table)
        {
            return dal_bill.getSumPrice(id_table);
        }


        public double getTotalPriceBill(int idBill)
        {
            return dal_bill.getTotalPriceBill(idBill);
        }
        public DataTable getBillDoUong()
        {
            return dal_bill.getbillDoUong();
        }
        public DataTable getBillNL()
        {
            return dal_bill.getbillNL();
        }
        public DataTable getBillDetailDoUong(int id)
        {
            return dal_bill.getbillDetailDoUong(id);
        }public DataTable getBillDetailNL(int id)
        {
            return dal_bill.getbillDetailNL(id);
        }
        public bool DeleteBillsDoUong(int id)
        {
            return dal_bill.DeleteBillsDoUong(id);
        }public bool DeleteBillsNL(int id)
        {
            return dal_bill.DeleteBillsNL(id);
        }public bool DeleteBillsDetailNL(int id)
        {
            return dal_bill.DeleteBillsDetailNL(id);
        }public bool DeleteBillsDetailDoUong(int id)
        {
            return dal_bill.DeleteBillsDetailDoUong(id);
        }public bool UpdateBillsDetailDoUong(DTO_Bill_Detail du)
        {
            return dal_bill.UpdateBillsDetailDoUong(du);
        }public bool UpdateBillsDetailNL(int quantity, int id)
        {
            return dal_bill.UpdateBillsDetailNL(quantity,id);
        }
        public DataTable BillsDetailSearch(string name, string col)
        {
            return dal_bill.BillsDetailSearch(name, col);
        }
        public DataTable InputBillsDetailSearch(string name, string col)
        {
            return dal_bill.InputBillsDetailSearch(name, col);
        } public DataTable getNameDetailDoUong(int id)
        {
            return dal_bill.getNameDetailDoUong(id);
        }
        public DataTable getNameDetailNL(int id)
        {
            return dal_bill.getNameDetailNL(id);
        }
    }
}
