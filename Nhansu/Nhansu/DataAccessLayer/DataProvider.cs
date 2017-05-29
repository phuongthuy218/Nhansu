﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Nhansu.DataAccessLayer
{
    class DataProvider
    {
        private static SqlConnection conn;
       
            public static SqlConnection Connect()
            {
                try
                {
                    string sql = @"Server=DESKTOP-7HJFAVT\SQLEXPRESSTT;Database=Nhansu;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(sql);
                    conn.Open();
                    return conn;

                }
                catch (SqlException)
                {
                    return null;
                }
            }
        
        public static DataTable GetData(string proc)
        {
            try
            {
                conn = Connect();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(proc, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }
        }
        public static string GetValues(string sql)
        {
            try
            {
                string temp=null;
                conn = Connect();
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader sqldr = cmd.ExecuteReader();
                while (sqldr.Read())
                    temp = sqldr[0].ToString();
                conn.Close();
                return temp;
            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }

        }
        public static int ExcuteNonQuerry(string proc, SqlParameter[] para)
        {
            try
            {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);

                int val = cmd.ExecuteNonQuery();
                conn.Close();
                return val;
            }
            catch (SqlException)
            {
                return 0;
            }

        }
     
    }
}
