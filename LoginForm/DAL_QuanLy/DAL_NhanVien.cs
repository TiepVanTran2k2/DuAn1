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
    public class DAL_NhanVien : DBConnect
    {
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LOGIN";
                cmd.Parameters.AddWithValue("EMAIL", nv.email);
                cmd.Parameters.AddWithValue("PASSWORD", nv.password);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FORGOT_PASSWORD";
                cmd.Parameters.AddWithValue("EMAIL", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool NhanVienDoiMatKhau(string email,string oldPassword,string newPassword)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CHANGE_PASSWORD";
                cmd.Parameters.AddWithValue("EMAIL", email);
                cmd.Parameters.AddWithValue("@OLDPASS", oldPassword);
                cmd.Parameters.AddWithValue("@NEWPASS", newPassword);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool TaoMatKhauMoi(string email, string np)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CREATE_NEW_PASS";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("Password", np);
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable GetNhanVien()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GETNHANVIEN";
                cmd.Connection = _conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return dtNV;
            }
            finally
            {
                //Đóng kết nối
                _conn.Close();
            }
        }
        public string GetNameNhanVienById(int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select name from employees where id_employee = "+id;
                cmd.Connection = _conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return (string)dtNV.Rows[0][0];
            }
            finally
            {
                //Đóng kết nối
                _conn.Close();
            }
        }
        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "INSERT_DATA_TO_EMPLOYEE";
                cmd.Parameters.AddWithValue("Id_role", nv.ID_Role);
                cmd.Parameters.AddWithValue("Gender", nv.GenDer);
                cmd.Parameters.AddWithValue("Email", nv.email);
                cmd.Parameters.AddWithValue("Address", nv.address);
                cmd.Parameters.AddWithValue("DayOfBirth", nv.dayOfBirth);
                cmd.Parameters.AddWithValue("Name", nv.name);
                cmd.Parameters.AddWithValue("Salary", nv.salary);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UPDATE_DATA_TO_EMPLOYEE";
                cmd.Parameters.AddWithValue("Id_role", nv.ID_Role);
                cmd.Parameters.AddWithValue("@Id_employee", nv.id_employee);
                cmd.Parameters.AddWithValue("Gender", nv.GenDer);
                cmd.Parameters.AddWithValue("Email", nv.email);
                cmd.Parameters.AddWithValue("Address", nv.address);
                cmd.Parameters.AddWithValue("DayOfBirth", nv.dayOfBirth);
                cmd.Parameters.AddWithValue("Name", nv.name);
                cmd.Parameters.AddWithValue("Salary", nv.salary);
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

        public bool DeleteNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DELETE_DATA_FROM_EMPLOYEE";
                cmd.Parameters.AddWithValue("Email", email);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable SearchNhanVien(string name,int id_role)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SEARCH_EMPLOYEE";
                cmd.Parameters.AddWithValue("Name", name);
                cmd.Parameters.AddWithValue("Id_role", id_role);
                cmd.Connection = _conn;
                DataTable dtEmployee = new DataTable();
                dtEmployee.Load(cmd.ExecuteReader());
                return dtEmployee;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable ThemVaiTro()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "INSERT_VAITRO";
                DataTable dtVT = new DataTable();
                dtVT.Load(cmd.ExecuteReader());
                return dtVT;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable KiemTraTrungEmail()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CHECK_EXIST_EMAIL";
                DataTable dtEmail = new DataTable();
                dtEmail.Load(cmd.ExecuteReader());
                return dtEmail;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable KiemTraTrungEmailTheoID(string email,int id_employee)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CHECK_EXIST_EMAIL_BY_ID";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id_employee", id_employee);
                DataTable dtEmail = new DataTable();
                dtEmail.Load(cmd.ExecuteReader());
                return dtEmail;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable IsDelete()
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "IS_DELETE";
            DataTable dtIsDelete = new DataTable();
            dtIsDelete.Load(cmd.ExecuteReader());
            return dtIsDelete;
        }
        public DataTable VaiTroNhanVien(string email)
        {
            //use stored procedure
            try
            {
                // Kết nối
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayVaiTroNV";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Connection = _conn;
                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;
            }
            finally
            {
                // Đóng kết nối
                _conn.Close();

            }
        }
        public DataTable LayId_EMP(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayId_EMP";
                cmd.Parameters.AddWithValue("@email", email);
                DataTable dtemP = new DataTable();
                dtemP.Load(cmd.ExecuteReader());
                return dtemP;
            }

            finally
            {
                _conn.Close();
            }
        }
    }
}
