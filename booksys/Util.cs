using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace booksys
{
    public class DButil
    {
        private static String info = "server=DESKTOP-Q1CLEU8\\SQLEXPRESS;user id=sa;password=666;database=booksys";
        private static SqlCommand sqlCmd;
        private static SqlConnection conn;
        private static SqlDataReader reader;
        // 获取连接
        public static SqlConnection getSqlConnection()
        {
            conn = new SqlConnection(info);
            conn.Open();
            return conn;
        }

        // 关闭连接
        public static void close()
        {
            if (reader != null)
            {
                try
                {
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            if (conn != null)
            {
                try
                {
                    conn.Close();
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
        }

        // 支持增删改
        public static int update(String sql, params SqlParameter[] sqlParams)
        {
            SqlConnection conn = getSqlConnection();
            sqlCmd = new SqlCommand(sql, conn);
            sqlCmd.Parameters.AddRange(sqlParams);
            int i = sqlCmd.ExecuteNonQuery();
            sqlCmd.Parameters.Clear();
            return i;
        }

        // 支持增删改
        public static int update(SqlConnection conn, String sql, params SqlParameter[] sqlParams)
        {
            sqlCmd = new SqlCommand(sql, conn);
            sqlCmd.Parameters.AddRange(sqlParams);
            int i = sqlCmd.ExecuteNonQuery();
            sqlCmd.Parameters.Clear();
            return i;
        }
        // 支持查询
        public static SqlDataReader query(String sql, params SqlParameter[] sqlParams)
        {
            SqlConnection conn = getSqlConnection();
            sqlCmd = new SqlCommand(sql, conn);
            sqlCmd.Parameters.AddRange(sqlParams);
            reader = sqlCmd.ExecuteReader();
            sqlCmd.Parameters.Clear();
            return reader;
        }
        public static SqlDataReader query(SqlConnection conn, String sql, params SqlParameter[] sqlParams)
        {
            sqlCmd = new SqlCommand(sql, conn);
            sqlCmd.Parameters.AddRange(sqlParams);
            reader = sqlCmd.ExecuteReader();
            sqlCmd.Parameters.Clear();
            return reader;
        }

        public static int queryScalar(String sql, params SqlParameter[] sqlParams) {
            SqlConnection conn = getSqlConnection();
            sqlCmd = new SqlCommand(sql, conn);
            sqlCmd.Parameters.AddRange(sqlParams);
            int i = Convert.ToInt32(sqlCmd.ExecuteScalar());
            sqlCmd.Parameters.Clear();
            return i;
        }

        public static int queryScalar(SqlConnection conn, String sql, params SqlParameter[] sqlParams)
        {
            sqlCmd = new SqlCommand(sql, conn);
            sqlCmd.Parameters.AddRange(sqlParams);
            int i = Convert.ToInt32(sqlCmd.ExecuteScalar());
            sqlCmd.Parameters.Clear();
            return i;
        }
    }
}
