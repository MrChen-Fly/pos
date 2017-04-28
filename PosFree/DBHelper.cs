using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace PosFree
{
    class DBHelper
    {
        private DBHelper() { }

        private static SQLiteConnection connection;  
        public static SQLiteConnection Connection  
        {  
            get  
            {  
                string connectionString = "Data Source=Pos.db;Version=3;";
                if (!File.Exists("Pos.db"))
                {
                    SQLiteConnection.CreateFile("Pos.db");
                }
                if (connection == null)  
                {  
                    connection = new SQLiteConnection(connectionString);  
                    connection.Open();  
                }  
                else if (connection.State == System.Data.ConnectionState.Closed)  
                {  
                    connection.Open();  
                }  
                else if (connection.State == System.Data.ConnectionState.Broken)  
                {  
                    connection.Close();  
                    connection.Open();  
                }  
                return connection;  
            }  
        }  
  
  
        public static int ExecuteCommand(string safeSql)  
        {  
            SQLiteCommand cmd = new SQLiteCommand(safeSql, Connection);  
            int result = cmd.ExecuteNonQuery();  
            return result;  
        }  
  
        public static int ExecuteCommand(string sql, params SQLiteParameter[] values)  
        {  
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);  
            cmd.Parameters.AddRange(values);  
            return cmd.ExecuteNonQuery();  
        }  
  
        public static int GetScalar(string safeSql)  
        {  
            SQLiteCommand cmd = new SQLiteCommand(safeSql, Connection);  
            int result = Convert.ToInt32(cmd.ExecuteScalar());  
            return result;  
        }  
  
        public static int GetScalar(string sql, params SQLiteParameter[] values)  
        {  
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);  
            cmd.Parameters.AddRange(values);  
            int result = Convert.ToInt32(cmd.ExecuteScalar());  
            return result;  
        }  
  
        public static SQLiteDataReader GetReader(string safeSql)  
        {  
            SQLiteCommand cmd = new SQLiteCommand(safeSql, Connection);  
            SQLiteDataReader reader = cmd.ExecuteReader();  
            return reader;  
        }  
  
        public static SQLiteDataReader GetReader(string sql, params SQLiteParameter[] values)  
        {  
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);  
            cmd.Parameters.AddRange(values);  
            SQLiteDataReader reader = cmd.ExecuteReader();  
            return reader;  
        }  
  
        public static DataTable GetDataSet(string safeSql)  
        {  
            DataSet ds = new DataSet();  
            SQLiteCommand cmd = new SQLiteCommand(safeSql, Connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);  
            da.Fill(ds);  
            return ds.Tables[0];  
        }  
  
        public static DataTable GetDataSet(string sql, params SQLiteParameter[] values)  
        {  
            DataSet ds = new DataSet();  
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);  
            cmd.Parameters.AddRange(values);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);  
            da.Fill(ds);  
            return ds.Tables[0];  
        }  
    }
}
