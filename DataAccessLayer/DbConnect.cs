using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DbConnect
    {
        private SqlConnection conn;

        public DbConnect()
        {
            conn = new SqlConnection();
        }

        public DataTable GetDataTable(string sqlCommand)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, conn);
            conn.Open();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable GetDataTable(string procName, SqlParameter[] para)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandText = procName;
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            conn.Open();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
    }
}
