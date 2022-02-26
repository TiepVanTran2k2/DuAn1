using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QuanLy
{
    public class BUS_Customer
    {
        DAL_Customer Customer = new DAL_Customer();

        public AutoCompleteStringCollection autoEmail()
        {
            return Customer.autoEmail();
        }
        public DTO_Customer FindCustomerByEmail(string email)
        {
            DataTable data = Customer.FindCustomerByEmail(email);
            if(data.Rows.Count > 0)
            {
                DTO_Customer cus = new DTO_Customer(data.Rows[0]);
                return cus;
            }
            return null;
        }
        public bool ChangeReward(int idCustomer, int point)
        {
            return Customer.ChangeReward(idCustomer, point);
        }

        public int getRewardCustomer(int idCustomer)
        {
            return Customer.getRewardCustomer(idCustomer);
        }
        public int getMaxIdCustomer()
        {
            return Customer.getMaxIdCustomer();
        }

        public int getIdCustomer(string email)
        {
            return Customer.getIdCustomer(email);
        }
        public bool CreateCustomer(DTO_Customer customer)
        {
            return Customer.CreateCustomer(customer);
        }
        public bool UpdateCustomerAfterSendVoucher(DTO_Customer voucher)
        {
            return Customer.UpdateCustomerAfterSendVoucher(voucher);
        }
        public DataTable getData()
        {
            return Customer.getData();
        }
        public bool UpdateCustomer(DTO_Customer customer)
        {
            return Customer.UpdateCustomer(customer);
        }
        public DataTable SearchCustomer(string email)
        {
            return Customer.SearchCustomer(email);
        }
    }
}
