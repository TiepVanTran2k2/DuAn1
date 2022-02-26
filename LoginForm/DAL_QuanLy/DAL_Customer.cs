using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QuanLy
{
    public class DAL_Customer : DBConnect
    {
        public AutoCompleteStringCollection autoEmail()
        {

            AutoCompleteStringCollection autoEmail = new AutoCompleteStringCollection();
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandText = "select email from customers";
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                autoEmail.Add(sdr.GetString(0));
            }
            _conn.Close();
            return autoEmail;
        }
        public bool UpdateCustomerAfterSendVoucher(DTO_Customer vouchers)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateCustomerAfterSendVoucher";
                cmd.Parameters.AddWithValue("email", vouchers.Email);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public int getMaxIdCustomer()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getMaxIdCustomer";
                return Convert.ToInt16(cmd.ExecuteScalar());                
            }
            finally
            {
                _conn.Close();
            }
        }
        public int getIdCustomer(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getIdCustomer";
                cmd.Parameters.AddWithValue("email", email);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                if(dt.Rows.Count > 0)
                {
                    return Convert.ToInt16(dt.Rows[0][0].ToString());
                }
                return 0;
            }
            finally
            {
                _conn.Close();
            }
        } 
        public DataTable getData()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetCustomers";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool CreateCustomer(DTO_Customer customer)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CreateCustomer";
                cmd.Parameters.AddWithValue("Email", customer.Email);
                cmd.Parameters.AddWithValue("Gender", customer.Gender);
                cmd.Parameters.AddWithValue("name", customer.Name);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool UpdateCustomer(DTO_Customer customer)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CustomerUpdate";
                cmd.Parameters.AddWithValue("Email", customer.Email);
                cmd.Parameters.AddWithValue("Gender", customer.Gender);
                cmd.Parameters.AddWithValue("idCustomers", customer.Id);
                cmd.Parameters.AddWithValue("reward", customer.Reward);
                cmd.Parameters.AddWithValue("name", customer.Name);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable FindCustomerByEmail(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_FindCustomerById";
                cmd.Parameters.AddWithValue("Email", email);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable SearchCustomer(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_CustomerSearch";
                cmd.Parameters.AddWithValue("Email", email);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }

        public int getRewardCustomer(int idCustomer)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getRewardCustomer";
                cmd.Parameters.AddWithValue("id_cutomer", idCustomer);
                return Convert.ToInt16(cmd.ExecuteScalar());                 
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool ChangeReward(int idCustomer, int point)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ChangeReward";
                cmd.Parameters.AddWithValue("id_Customer", idCustomer);
                cmd.Parameters.AddWithValue("Point", point);
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
