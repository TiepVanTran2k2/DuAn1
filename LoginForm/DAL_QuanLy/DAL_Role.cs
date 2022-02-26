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
    public class DAL_Role : DBConnect
    {
        public bool InsertRoleNhanVien(DTO_Role ro)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "INSERT_DATA_TO_ROLES";
                cmd.Parameters.AddWithValue("Name", ro.name);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool UpdateRoleNhanVien(DTO_Role ro)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UPDATE_DATA_TO_ROLES";
                cmd.Parameters.AddWithValue("@id_role", ro.ID_Role);
                cmd.Parameters.AddWithValue("@name", ro.name);
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
        public bool DeleteRoleNhanVien(int id_role)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DELETE_DATA_FROM_ROLES";
                cmd.Parameters.AddWithValue("@id_role", id_role);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable GetRoles()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GET_ROLES";
                cmd.Connection = _conn;
                DataTable dtR = new DataTable();
                dtR.Load(cmd.ExecuteReader());
                return dtR;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable SearchRoleNhanVien(string name)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SEARCH_ROLES";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Connection = _conn;
                DataTable dtRoles = new DataTable();
                dtRoles.Load(cmd.ExecuteReader());
                return dtRoles;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
