using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_NguyenLieu
    {
        private int id_Ingredient;
        private string name;
        private int id_Supplier;
        private int id_Type;
        private float price;
        private int mass;
        private int id_Unit;
        private string images;
        public DTO_NguyenLieu(System.Data.DataRow row)
        {
            this.name = row["Name"].ToString();
            this.price = (float)(double)row["Price"];
            this.images = row["images"].ToString();
            this.id_Type = int.Parse(row["Id_type"].ToString());
        }
        public DTO_NguyenLieu(string name)
        {
            this.name = name;
        }
        public DTO_NguyenLieu(string name, int id_Supplier, int id_Type, float price, int mass, int id_Unit, string images)
        {
            this.name = name;
            this.id_Supplier = id_Supplier;
            this.id_Type = id_Type;
            this.price = price;
            this.mass = mass;
            this.id_Unit = id_Unit;
            this.images = images;
        }
        public DTO_NguyenLieu(string name, int id_Supplier, int id_Type, float price, int mass, int id_Unit, int id_Ingredient, string images)
        {
            this.name = name;
            this.id_Supplier = id_Supplier;
            this.id_Type = id_Type;
            this.price = price;
            this.mass = mass;
            this.id_Unit = id_Unit;
            this.id_Ingredient = id_Ingredient;
            this.images = images;
        }
        public int Id_Ingredient { get => id_Ingredient; set => id_Ingredient = value; }
        public string Name { get => name; set => name = value; }
        public string Images { get => images; set => images = value; }
        public int Id_Supplier { get => id_Supplier; set => id_Supplier = value; }
        public int Id_Type { get => id_Type; set => id_Type = value; }
        public float Price { get => price; set => price = value; }
        public int Mass { get => mass; set => mass = value; }
        public int Id_Unit { get => id_Unit; set => id_Unit = value; }
    }
}
