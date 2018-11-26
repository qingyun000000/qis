using System;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace QISDAL
//数据库简单测试
{
    public class MySQLUtils
    {
        //获取数据库连接
        private static MySqlConnection GetConnection()
        {
            string constr = "server = localhost; User Id = root; password = 123; Database = qis";
            StreamReader sr = new StreamReader("constr.txt", Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null) 
            {
                constr = line.ToString();
            }
            return new MySqlConnection(constr);
        }

        //插入，更新，删除方法
        public static Boolean ExecuteNonQuery(string sql)
        {
            bool flag = false;
            MySqlConnection mycon = GetConnection();
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                flag = true;
            }
            mycmd.Dispose();
            mycon.Close();
            return flag;
        }

        //插入，更新，删除方法，带参数
        public static Boolean ExecuteNonQuery(string sql, Object[] param)
        {
            bool flag = false;
            MySqlConnection mycon = GetConnection();
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            for (int i = 0; i < param.Length; i++)
            {
                mycmd.Parameters.AddWithValue("para" + (i + 1), param[i]);
            }
            if (mycmd.ExecuteNonQuery() > 0)
            {
                flag = true;
            }
            mycmd.Dispose();
            mycon.Close();
            return flag;
        }

        //返回一个值（单行单列）
        public static Object ExecuteScalar(string sql)
        {
            MySqlConnection mycon = GetConnection();
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            Object result = mycmd.ExecuteScalar();
            mycmd.Dispose();
            mycon.Close();
            return result;
        }

        //返回一个值（单行单列），带参数
        public static Object ExecuteScalar(string sql,Object[] param)
        {
            MySqlConnection mycon = GetConnection();
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            for(int i = 0; i < param.Length; i++)
            {
                mycmd.Parameters.AddWithValue("para"+(i+1), param[i]);
            }
            Object result = mycmd.ExecuteScalar();
            mycmd.Dispose();
            mycon.Close();
            return result;
        }

        //返回Reader
        public static MySqlDataReader ExecuteReader(string sql)
        {
            MySqlConnection mycon = GetConnection();
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = mycmd.ExecuteReader(CommandBehavior.CloseConnection);
            mycmd.Dispose();
            return reader;
        }

        //返回Reader，带参数
        public static MySqlDataReader ExecuteReader(string sql, Object[] param)
        {
            MySqlConnection mycon = GetConnection();
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            for (int i = 0; i < param.Length; i++)
            {
                mycmd.Parameters.AddWithValue("para" + (i + 1), param[i]);
            }
            MySqlDataReader reader = mycmd.ExecuteReader(CommandBehavior.CloseConnection);
            mycmd.Dispose();
            return reader;
        }

    }
}