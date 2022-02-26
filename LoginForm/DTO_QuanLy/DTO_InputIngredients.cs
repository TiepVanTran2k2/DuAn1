using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_InputIngredients
    {
        private int id_billDetail;
        private string quantity;
        private int id_units;
        private int id_ingredient;
        private int id_bill;
        private string nameunit;
        private string nametype;
        private string date;
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public string NameType
        {
            get
            {
                return nametype;
            }
            set
            {
                nametype = value;
            }
        }
        public string NameUint
        {
            get
            {
                return nameunit;
            }
            set
            {
                nameunit = value;
            }
        }
        public int Id_BillDetail
        {
            get
            {
                return id_billDetail;
            }
            set
            {
                id_billDetail = value;
            }
        }
        public string Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public int Id_Units
        {
            get
            {
                return id_units;
            }
            set
            {
                id_units = value;
            }
        }
        public int Id_Ingredients
        {
            get
            {
                return id_ingredient;
            }
            set
            {
                id_ingredient = value;
            }
        }
        public int Id_Bill
        {
            get
            {
                return id_bill;
            }
            set
            {
                id_bill = value;
            }
        }
        //public DTO_InputIngredients(int id_billDetail, string quantity, int id_units, int id_ingredient, int id_bill)
        //{
        //    this.id_billDetail = id_billDetail;
        //    this.quantity = quantity;
        //    this.id_units = id_units;
        //    this.id_ingredient = id_ingredient;
        //    this.id_bill = id_bill;
        //}
        //public DTO_InputIngredients(string quantity, int id_units, int id_ingredient, int id_bill)
        //{
        //    this.quantity = quantity;
        //    this.id_units = id_units;
        //    this.id_ingredient = id_ingredient;
        //    this.id_bill = id_bill;
        //}
        public DTO_InputIngredients(string quantity, string nametype, string date)
        {
            this.quantity = quantity;
            this.nametype = nametype;
            this.date = date;
        }
    }
}
