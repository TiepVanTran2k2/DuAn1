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
    public class BUS_InputIngredients
    {
        DAL_InputIngredients input = new DAL_InputIngredients();
        public DataTable getTypeIngredientForInputBillDetail()
        {
            return input.getTypeIngredientForInputBillDetail();
        }
        public DataTable getNameIngredientForInputBillDetail(int id)
        {
            return input.getNameIngredientForInputBillDetail(id);
        }
        public DataTable PriceInputBill(int id, int number)
        {
            return input.PriceInputBill(id, number);
        }
        public bool insertBillDetailIngredient(DTO_InputIngredients dTO_Input)
        {
            return input.insertBillDetailIngredient(dTO_Input);
        }
    }
}
