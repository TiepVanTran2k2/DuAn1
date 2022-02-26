using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_Menu
    {
        public DTO_Menu(DataRow rows)
        {
            var IdBillDetailTemp= Convert.ToInt32(rows["id_bill_detaill"].ToString());
            if (IdBillDetailTemp.ToString() != "")
                this.IdBillDetail = (int)IdBillDetailTemp;
            this.beverageName = rows["name"].ToString();
            this.quantity = (int)rows["quantity"];
            this.price = Convert.ToDouble(rows["Price"].ToString());
            this.totalPrice = Convert.ToDouble(rows["totalPrice"].ToString());
            var saleTemp = rows["sale"];
            if(saleTemp.ToString() == "")
            {
                this.sale = (int)saleTemp;
            }
            this.sale = (int)rows["sale"];
        }
        public DTO_Menu(string beverageName, int quantity, float price, float totalPrice = 0, int sale = 0)
        {
            this.beverageName = beverageName;
            this.quantity = quantity;
            this.price = price;
            this.totalPrice = totalPrice;
            this.sale = sale;
        }
        
        public int IdBillDetail { get; set; }
        public string beverageName {get;set;}
        public int quantity { get; set; }
        public double price { get; set; }
        public double totalPrice { get; set; }
        public int sale { get; set; }
    }
}
