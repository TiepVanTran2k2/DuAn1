using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_units
    {
        private string name;
        private int id;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public DTO_units(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public DTO_units(string name)
        {
            this.name = name;
        }
    }
}
