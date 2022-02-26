using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_InputBills
    {
        private string dateCheckin;
        private string email;
        private float sumprice;
        public string DateCheckIn
        {
            get
            {
                return dateCheckin;
            }
            set
            {
                dateCheckin = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public float SumPrice
        {
            get
            {
                return sumprice;
            }
            set
            {
                sumprice = value;
            }
        }
        public DTO_InputBills(string datetime, string id, float sumprice)
        {
            this.dateCheckin = datetime;
            this.email = id;
            this.sumprice = sumprice;
        }
    }
}
