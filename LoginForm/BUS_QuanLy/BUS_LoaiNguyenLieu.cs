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
    public class BUS_LoaiNguyenLieu
    {
        DAL_LoaiNguyenLieu quanlyLoaiNguyenLieu = new DAL_LoaiNguyenLieu();
        public List<DTO_LoaiNguyenLieu> listIngredientType()
        {
            DataTable dt = quanlyLoaiNguyenLieu.getTypeOfIngredient();
            List<DTO_LoaiNguyenLieu> getTypeOfIngredient = new List<DTO_LoaiNguyenLieu>();

            foreach (DataRow row in dt.Rows)
            {
                DTO_LoaiNguyenLieu beverageType = new DTO_LoaiNguyenLieu(row);
                getTypeOfIngredient.Add(beverageType);
            }
            return getTypeOfIngredient;
        }
        public DataTable getTypeOfIngredient()
        {
            return quanlyLoaiNguyenLieu.getTypeOfIngredient();
        }
        public bool InsertLoaiNguyenLieu(DTO_LoaiNguyenLieu lnl)
        {
            return quanlyLoaiNguyenLieu.InsertLoaiNguyenLieu(lnl);
        }
        public bool UpdateLoaiNguyenLieu(DTO_LoaiNguyenLieu lnl)
        {
            return quanlyLoaiNguyenLieu.UpdateLoaiNguyenLieu(lnl);
        }
        public bool DeleteLoaiNguyenLieu(int id_Type)
        {
            return quanlyLoaiNguyenLieu.DeleteLoaiNguyenLieu(id_Type);
        }
        public DataTable SearchLoaiNguyenLieu(string name)
        {
            return quanlyLoaiNguyenLieu.SearchLoaiNguyenLieu(name);
        }
    }
}
