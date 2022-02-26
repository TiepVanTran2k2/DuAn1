using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_TypesOfBeverage
    {
        private int iD_Type;
        private string name;
        public DTO_TypesOfBeverage()
        { }
        public DTO_TypesOfBeverage(string name)
        {
            this.name = name;
        }

        public DTO_TypesOfBeverage(int iD_Type, string name)
        {
            this.iD_Type = iD_Type;
            this.name = name;
        }

        public DTO_TypesOfBeverage(DataRow rows)
        {
            this.iD_Type = (int)rows["id_type"];
            this.name = rows["name"].ToString();
        }

        public int ID_Type { get => iD_Type; set => iD_Type = value; }
        public string Name { get => name; set => name = value; }
    }
}
