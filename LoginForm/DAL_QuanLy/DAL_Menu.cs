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
    public class DAL_Menu:DBConnect
    {
        public DataTable getListMenu(int id_table)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getListMenu";
                cmd.Parameters.AddWithValue("Id_table", id_table);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable getListMenuNotVnd(int id_table)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getListMenuNotVnd";
                cmd.Parameters.AddWithValue("Id_table", id_table);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool changeQuantity(int IdBillDetail,int quantity)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "changeQuantityBillDetail";
                cmd.Parameters.AddWithValue("idBillDetail", IdBillDetail);
                cmd.Parameters.AddWithValue("quantity", quantity);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool DeleteBillDetail(int IdBillDetail)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteBillDetail";
                cmd.Parameters.AddWithValue("idBillDetail", IdBillDetail);
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
