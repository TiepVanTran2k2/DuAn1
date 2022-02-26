using DAL_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class BUS_Static
    {
        DAL_Static dAL_Static = new DAL_Static();
        public DataTable getDataBillDetail()
        {
            return dAL_Static.getDataBillDetail();
        }
        public DataTable getPrice()
        {
            return dAL_Static.getPrice();
        }
        public DataTable getDataBillDetailDate(string DayStar, string DayEnd)
        {
            return dAL_Static.getDataBillDetailDate(DayStar, DayEnd);
        }
        public DataTable SumPriceDateTime(string DayStar, string DayEnd)
        {
            return dAL_Static.SumPriceDateTime(DayStar, DayEnd);
        }
        public DataTable getDataBillDetailDayOfWeek(string DayStar, string DayEnd)
        {
            return dAL_Static.getDataBillDetailDayOfWeek(DayStar, DayEnd);
        }
        public DataTable getAllBillInput()
        {
            return dAL_Static.getAllBillInput();
        }
        public DataTable getSumPriceBillInput()
        {
            return dAL_Static.getSumPriceBillInput();
        }
        public DataTable getBillInputBetween(string dayStar, string dayEnd)
        {
            return dAL_Static.getBillInputBetween(dayStar, dayEnd);
        }
        public DataTable SumPriceBillInputBetween(string dayStar, string dayEnd)
        {
            return dAL_Static.SumPriceBillInputBetween(dayStar, dayEnd);
        }
        public DataTable StaticEmployee()
        {
            return dAL_Static.StaticEmployee();
        }
        public DataTable StaticCustomer()
        {
            return dAL_Static.StaticCustomer();
        }
        public DataTable StaticEmployeeWeek()
        {
            return dAL_Static.StaticEmployeeWeek();
        }
        public DataTable StaticCustomerWeek(string dayStar, string dayEnd)
        {
            return dAL_Static.StaticCustomerWeek(dayStar, dayEnd);
        }
        public DataTable StaticOverAllBillsMonth()
        {
            return dAL_Static.StaticOverAllBillsMonth();
        }
        public DataTable StaticOverAllBillsYears()
        {
            return dAL_Static.StaticOverAllBillsYears();
        }
        public DataTable StaticOverAllDate(string dayStar, string dayEnd)
        {
            return dAL_Static.StaticOverAllDate(dayStar, dayEnd);
        }
        public DataTable StaticEmployeeYears()
        {
            return dAL_Static.StaticEmployeeYears();
        }
        public DataTable StaticCustomerYears()
        {
            return dAL_Static.StaticCustomerYears();
        }
        public DataTable StaticCustomerMonth()
        {
            return dAL_Static.StaticCustomerMonth();
        }
    }
}
