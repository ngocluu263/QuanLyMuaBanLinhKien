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

        //Select query
        public DataTable GetDataTable(string sqlCommand)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, conn);
            conn.Open();
            adapter.Fill(table);
            conn.Close();
            return table;
        }

        //Proceduce
        public DataTable GetDataTable(string procName, SqlParameter[] para)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandText = procName;
            command.CommandType = CommandType.StoredProcedure;
            if(para != null)
            {
                command.Parameters.AddRange(para);
            }
            command.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            conn.Open();
            adapter.Fill(table);
            conn.Close();
            return table;
        }

        //Insert, update...
        public int ExecuteSql(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            int row = command.ExecuteNonQuery();
            conn.Close();
            return row;
        }

        //
        public int ExecuteSql(string procName, SqlParameter[] para)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = procName;
            command.CommandType = CommandType.StoredProcedure;
            if (para != null)
            {
                command.Parameters.AddRange(para);
            }
            command.Connection = conn;
            conn.Open();
            int row = command.ExecuteNonQuery();
            conn.Close();
            return row;
        }
    }
}
