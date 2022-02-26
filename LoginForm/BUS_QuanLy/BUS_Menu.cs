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
    public class BUS_Menu
    {
        DAL_Menu dal = new DAL_Menu();
        public List<DTO_Menu> listMenu(int id)
        {
            List<DTO_Menu> list = new List<DTO_Menu>();
            DataTable dt = dal.getListMenuNotVnd(id);
            foreach(DataRow row in dt.Rows)
            {
                DTO_Menu menu = new DTO_Menu(row);
                list.Add(menu);
            }
            return list;
        }
        public DataTable getListMenu(int id_table)
        {
            return dal.getListMenu(id_table); 
        }
        public bool changeQuantity(int IdBillDetail, int quantity)
        {
            return dal.changeQuantity(IdBillDetail, quantity);
        }
        public bool DeleteBillDetail(int IdBillDetail)
        {
            return dal.DeleteBillDetail(IdBillDetail);
        }
    }
}
