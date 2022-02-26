using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class DAL_Static : DBConnect
    {
        public DataTable getDataBillDetail()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getBillsDetail";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // lấy tổng tiền tất cả bill khi load form
        public DataTable getPrice()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadPriceBillsDetail";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // thống kê danh sách theo ngày tháng
        public DataTable getDataBillDetailDate(string DayStar, string DayEnd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadBillInDayOfWeek";
                cmd.Parameters.AddWithValue("dayStar", DayStar);
                cmd.Parameters.AddWithValue("dayEnd", DayEnd);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        //Thống kê tiền hóa đơn theo ngày tháng
        public DataTable SumPriceDateTime(string DayStar, string DayEnd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SumPriceDateTime";
                cmd.Parameters.AddWithValue("dayStar", DayStar);
                cmd.Parameters.AddWithValue("dayEnd", DayEnd);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // thống kê danh sách theo tuần
        public DataTable getDataBillDetailDayOfWeek(string DayStar, string DayEnd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadBillInDayOfWeek";
                cmd.Parameters.AddWithValue("dayStar", DayStar);
                cmd.Parameters.AddWithValue("dayEnd", DayEnd);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // danh sách tất cả các bill nhập nguyên liệu
        public DataTable getAllBillInput()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getBillInput";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // Tổng tiền của tất cả các bill nhập nguyên liệu
        public DataTable getSumPriceBillInput()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getPriceBillInput";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // danh sács bill nhập nguyện liệu trong khoảng thời gian
        public DataTable getBillInputBetween(string dayStar, string dayEnd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getBillInputInBetween";
                cmd.Parameters.AddWithValue("dayStar", dayStar);
                cmd.Parameters.AddWithValue("dayEnd", dayEnd);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // tổng tiền bill nhập nguyên liệu trong khoảng thời gian
        public DataTable SumPriceBillInputBetween(string dayStar, string dayEnd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getSumPriceInBetween";
                cmd.Parameters.AddWithValue("dayStar", dayStar);
                cmd.Parameters.AddWithValue("dayEnd", dayEnd);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // thống kê nhân viên, số tiền , số lượng hóa đơn
        public DataTable StaticEmployee()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "StaticDataEmployee";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // thống kê khách hàng, tổng tiền mua 
        public DataTable StaticCustomer()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "StaticCustomer";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // thống kê hóa đơn nhân viên theo tuần
        public DataTable StaticEmployeeWeek()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "StaticEmployeeWeek";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // tổng thể nhân viên theo năm
        public DataTable StaticEmployeeYears()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "StaticEmployeeYears";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // Thống kê hóa đơn khách hàng theo tuần
        public DataTable StaticCustomerWeek(string dayStar, string dayEnd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "StaticCustomerWeek";
                cmd.Parameters.AddWithValue("dayStar", dayStar);
                cmd.Parameters.AddWithValue("dayEnd", dayEnd);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        //Thống kê tổng thể hóa đơn theo tháng
        public DataTable StaticOverAllBillsMonth()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "StaticOverAllBillsMonth";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        //thống kê tổng thể theo năm
        public DataTable StaticOverAllBillsYears()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "StaticOverAllBillsYears";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // thống kê tổng thể hóa đơn theo ngày
        public DataTable StaticOverAllDate(string dayStar, string dayEnd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "StaticOverAllDate";
                cmd.Parameters.AddWithValue("dayStar", dayStar);
                cmd.Parameters.AddWithValue("dayEnd", dayEnd);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // tổng thể khách hàng theo năm
        public DataTable StaticCustomerYears()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "StaticCustomerYears";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        // tổng thể khách hàng theo tháng
        public DataTable StaticCustomerMonth()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "StaticCustomerMonth";
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
