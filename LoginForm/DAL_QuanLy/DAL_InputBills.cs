using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class DAL_InputBills : DBConnect
    {
        public bool insertBillIngredient(DTO_InputBills bills)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "insertBillIngredient";
                cmd.Parameters.AddWithValue("dayCheck", bills.DateCheckIn);
                cmd.Parameters.AddWithValue("mail", bills.Email);
                cmd.Parameters.AddWithValue("sumprice", bills.SumPrice);
               if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
