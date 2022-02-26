using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class DAL_Bill_Detail:DBConnect
    {
        public bool InsertBillDetail(DTO_Bill_Detail billdetail)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_insertBillDetail";
                cmd.Parameters.AddWithValue("idBill", billdetail.ID_Bill);
                cmd.Parameters.AddWithValue("idBeverage", billdetail.Id_Beverage);
                cmd.Parameters.AddWithValue("quantity", billdetail.Quantity);
                cmd.Parameters.AddWithValue("sale", billdetail.sale);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable GetListBillDetail(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getListBillDetail";
                cmd.Parameters.AddWithValue("IDBill", id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
