using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_Bill_Detail
    {
        public DTO_Bill_Detail() { }
        public DTO_Bill_Detail(int iD_Bill_Detail, int iD_Bill, int id_Beverage, int quantity)
        {
            ID_Bill_Detail = iD_Bill_Detail;
            ID_Bill = iD_Bill;
            Id_Beverage = id_Beverage;
            Quantity = quantity;
        }

        public DTO_Bill_Detail(int iD_Bill_Detail, int iD_Bill, int id_Beverage, int quantity, int Sale)
        {
            ID_Bill_Detail = iD_Bill_Detail;
            ID_Bill = iD_Bill;
            Id_Beverage = id_Beverage;
            Quantity = quantity;
            sale = Sale;
        }

        public DTO_Bill_Detail(DataRow rows)
        {
            this.ID_Bill_Detail = (int)rows["id_bill_detaill"];
            this.ID_Bill = (int)rows["id_bill"];
            this.Id_Beverage = (int)rows["id_beverage"];
            this.Quantity = (int)rows["Quantity"];
            var saleTemp = rows["sale"];
            if (saleTemp.ToString() == "")
            {
                this.sale = (int)saleTemp;
            }
            this.sale = (int)rows["sale"];
        }

        public DTO_Bill_Detail(int iD_Bill, int quantity)
        {
            ID_Bill = iD_Bill;
            Quantity = quantity;
        }

        public int ID_Bill_Detail { get; set; } 
        public int ID_Bill { get; set; }
        public int Id_Beverage { get; set; }
        public int Quantity { get; set; }
        public int sale { get; set; }
        public int totalPrice { get; set; }
    }
}
