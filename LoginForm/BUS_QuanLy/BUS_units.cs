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
    public class BUS_units
    {
        DAL_units units = new DAL_units();

        public DataTable searchDataUnit(string unit)
        {
            return units.searchDataUnit(unit);
        }
        public DataTable getData()
        {
            return units.getData();
        }
        public bool InsertDataUnits(DTO_units unit)
        {
            return units.InsertDataUnits(unit);
        }
        public bool UpdateDataUnits(DTO_units unit)
        {
            return units.UpdateDataUnits(unit);
        }
        public bool deleteDataUnit(int id)
        {
            return units.deleteDataUnit(id);
        }
    }
}
