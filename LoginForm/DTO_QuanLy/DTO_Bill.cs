using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_Bill
    {
        public DTO_Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int idEmployee, int? idCustomer, int idTable, int status)
        {
            Id = id;
            DateCheckIn = dateCheckIn;
            DateCheckOut = dateCheckOut;
            IdEmployee = idEmployee;
            IdCustomer = idCustomer;
            IdTable = idTable;
            this.status = status;
        }

        public DTO_Bill(DataRow rows )
        {
            this.Id = (int)rows["ID_Bill"];
            this.IdTable = (int)rows["Id_Table"];
            var IdCustomerTemp = rows["Id_Customer"]; 
            if(IdCustomerTemp.ToString() != "")
                this.IdCustomer = (int)IdCustomerTemp;
            this.IdEmployee = (int)rows["Id_Employee"];
            this.DateCheckIn = (DateTime?)rows["DateCheckIn"];
            var DateCheckOutTemp = rows["DateCheckOut"];
            if(DateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime)DateCheckOutTemp;
            this.status = (int)rows["status"];
        }

        public int Id { get; set; }
        public DateTime? DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int IdEmployee {get;set;}
        public int? IdCustomer { get; set; }
        public int IdTable { get; set; }
        public int status { get; set; }
    }
}
