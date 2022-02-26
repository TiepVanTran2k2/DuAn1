using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_Beverage
    {
        DAL_QuanLyDoUong quanLyDoUong = new DAL_QuanLyDoUong();
        public List<DTO_QuanLyDoUong> listBeverageType(int id)
        {
            DataTable dt = quanLyDoUong.getBeverage(id);
            List<DTO_QuanLyDoUong> listBeverage = new List<DTO_QuanLyDoUong>();

            foreach (DataRow row in dt.Rows)
            {
                DTO_QuanLyDoUong beverageType = new DTO_QuanLyDoUong(row);
                listBeverage.Add(beverageType);
            }
            return listBeverage;
        }
        public List<DTO_QuanLyDoUong> listBeverage()
        {
            DataTable dt = quanLyDoUong.getBeverage();
            List<DTO_QuanLyDoUong> listBeverage = new List<DTO_QuanLyDoUong>();

            foreach (DataRow row in dt.Rows)
            {
                DTO_QuanLyDoUong beverageType = new DTO_QuanLyDoUong(row);
                listBeverage.Add(beverageType);
            }
            return listBeverage;
        }
        public bool InsertDoUong(DTO_QuanLyDoUong ql)
        {
            return quanLyDoUong.InsertDoUong(ql);
        }
        public bool UpdateDoUong(DTO_QuanLyDoUong ql)
        {
            return quanLyDoUong.UpdateDoUong(ql);
        }
        public bool DeleteDoUong(int id)
        {
            return quanLyDoUong.DeleteDoUong(id);
        }
        public DataTable SearchDoUong(string name,string col)
        {
            return quanLyDoUong.SearchDoUong(name, col);
        }
        public DataTable getBeverage()
        {
            return quanLyDoUong.getBeverage();
        }
        public DataTable getBeverageType()
        {
            return quanLyDoUong.getBeverageType();
        }
    }
}
