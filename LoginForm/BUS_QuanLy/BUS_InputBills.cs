using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class BUS_InputBills
    {
        DAL_InputBills bills = new DAL_InputBills();
        public bool insertBillIngredient(DTO_InputBills bill)
        {
            return bills.insertBillIngredient(bill);
        }
    }
}
