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
    /// <summary>
    /// thành công: bill id
    /// thất bại:-1
    /// </summary>
    public class DAL_Bill:DBConnect
    {
        public DataTable getbill(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from bills where id_bill = " + id;
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable getbillDoUong()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_GetBillsDoUongToday";
                cmd.Connection = _conn;
                DataTable dtDoUong = new DataTable();
                dtDoUong.Load(cmd.ExecuteReader());
                return dtDoUong;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable getbillNL()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_GetBillsNguyenLieuToday";
                cmd.Connection = _conn;
                DataTable dtDoUong = new DataTable();
                dtDoUong.Load(cmd.ExecuteReader());
                return dtDoUong;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable getbillDetailDoUong(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetBillsDetailDoUong";
                cmd.Parameters.AddWithValue("id_bill", id);
                DataTable dtDoUong = new DataTable();
                dtDoUong.Load(cmd.ExecuteReader());
                return dtDoUong;
            }
            finally
            {
                _conn.Close();
            }
           
        }
        public DataTable getbillDetailNL(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetBillsDetailNL";
                cmd.Parameters.AddWithValue("id_bill", id);
                DataTable dtDoUong = new DataTable();
                dtDoUong.Load(cmd.ExecuteReader());
                return dtDoUong;
            }
            finally
            {
                _conn.Close();
            }

        }
        public int getMaxId()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getMaxID";
                return Convert.ToInt16(cmd.ExecuteScalar());              
            }
            catch
            {
                return 1;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool addCustomer(int idCustomer, int idBill)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "addCustomer";
                cmd.Parameters.AddWithValue("idBill", idBill);
                cmd.Parameters.AddWithValue("idcus", idCustomer);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public double  getTotalPriceBill(int idBill)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getTotalPriceBill";
                cmd.Parameters.AddWithValue("idBill", idBill);
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool CheckOut(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "checkOut";
                cmd.Parameters.AddWithValue("idBill", id);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool InsertBill(int idtable, int idEmployee)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_insertBill";
                cmd.Parameters.AddWithValue("idtable", idtable);
                cmd.Parameters.AddWithValue("idemployee", idEmployee);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public int GetUncheckBill(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getUncheckBill";
                cmd.Parameters.AddWithValue("ID_table", id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                if(dt.Rows.Count >0)
                {
                    DTO_Bill bill = new DTO_Bill(dt.Rows[0]);
                    return bill.Id;
                }
                else
                {
                    return -1;
                }
            }
            finally
            {
                _conn.Close();
            }
        }

        public double getSumPrice(int id_table)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getSumprice";
                cmd.Parameters.AddWithValue("ID_table", id_table);
                return Convert.ToDouble(cmd.ExecuteScalar());      
            }
            catch
            {
                return 0;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool DeleteBillsDoUong(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_BillDeleteDoUong";
                cmd.Parameters.AddWithValue("@id_bill", id);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DeleteBillsNL(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_BillDeleteNL";
                cmd.Parameters.AddWithValue("@id_bill", id);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }public bool DeleteBillsDetailNL(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_BillsDetailDeleteNL";
                cmd.Parameters.AddWithValue("@id_bill", id);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DeleteBillsDetailDoUong(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_BillsDetailDeleteDoUong";
                cmd.Parameters.AddWithValue("@id_bill", id);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool UpdateBillsDetailDoUong(DTO_Bill_Detail du)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateBillsDetailDoUong";
                cmd.Parameters.AddWithValue("quantity", du.Quantity);
                cmd.Parameters.AddWithValue("id_bill", du.ID_Bill);
                cmd.Connection = _conn;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool UpdateBillsDetailNL(int quantity, int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateBillsDetailNL";
                cmd.Parameters.AddWithValue("quantity", quantity);
                cmd.Parameters.AddWithValue("id_bill", id);
                cmd.Connection = _conn;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable BillsDetailSearch(string name, string col)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_BillsDetailSearch";
                cmd.Parameters.AddWithValue("Name", name);
                cmd.Parameters.AddWithValue("col", col);
                cmd.Connection = _conn;
                DataTable dtDoUong = new DataTable();
                dtDoUong.Load(cmd.ExecuteReader());
                return dtDoUong;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable InputBillsDetailSearch(string name, string col)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InputBillsDetailSearch";
                cmd.Parameters.AddWithValue("Name", name);
                cmd.Parameters.AddWithValue("col", col);
                cmd.Connection = _conn;
                DataTable dtDoUong = new DataTable();
                dtDoUong.Load(cmd.ExecuteReader());
                return dtDoUong;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable getNameDetailDoUong(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Name from beverages where id_beverage = " + id;
                DataTable dtDoUong = new DataTable();
                dtDoUong.Load(cmd.ExecuteReader());
                return dtDoUong;
            }
            finally
            {
                _conn.Close();
            }

        }
        public DataTable getNameDetailNL(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select [Name] from Ingredients where Id_ingredient = "+id;
                DataTable dtDoUong = new DataTable();
                dtDoUong.Load(cmd.ExecuteReader());
                return dtDoUong;
            }
            finally
            {
                _conn.Close();
            }

        }
        public bool updateInputBill(int id, float sum)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateInputBill";
                cmd.Parameters.AddWithValue("sumPrice", sum);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Connection = _conn;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable priceAfterUpdate(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "priceAfterUpdate";
                cmd.Parameters.AddWithValue("id", id);
                DataTable dtDoUong = new DataTable();
                dtDoUong.Load(cmd.ExecuteReader());
                return dtDoUong;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
