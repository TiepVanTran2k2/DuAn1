using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    class DataProvider : DBConnect
    {
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();

            using(_conn)
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                if(parameters != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
            }
            return data;
        }
    }
}
