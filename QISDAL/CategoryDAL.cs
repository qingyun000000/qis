using MySql.Data.MySqlClient;
using QISModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QISDAL
{
    public class CategoryDAL
    {
        public List<Category> FindAll()
        {
            string sql = "select * from tb_Category where states=1";
            List<Category> Categorys = new List<Category>();
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    Category Category = new Category();
                    Category.Cid = reader["cid"] is DBNull?"":reader.GetString("cid");
                    Category.Cname = reader["cname"] is DBNull?"":reader.GetString("cname");
                    Category.Cdesc = reader["cdesc"] is DBNull?"":reader.GetString("cdesc");
                    string parentid = reader["parent"] is DBNull? "MainCategory":reader.GetString("parent");
                    if(!parentid.Equals("MainCategory"))
                    {
                        Category parent = new Category();
                        parent.Cid = parentid;
                        Category.Parent = parent;
                    }
                    Category.States = reader["states"] is DBNull?false:reader.GetBoolean("states");

                    Categorys.Add(Category);
                }
                    
            }
            return Categorys;

        }

        public Category FindByCid(string cid)
        {
            string sql = "select * from tb_Category where cid=@para1";
            Category Category = new Category();
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql, new Object[] { cid }))
            {
                while (reader.Read())
                {
                    Category.Cid = reader["cid"] is DBNull ? "" : reader.GetString("cid");
                    Category.Cname = reader["cname"] is DBNull ? "" : reader.GetString("cname");
                    Category.Cdesc = reader["cdesc"] is DBNull ? "" : reader.GetString("cdesc");
                    string parentid = reader["parent"] is DBNull ? "MainCategory" : reader.GetString("parent");
                    if (!parentid.Equals("MainCategory"))
                    {
                        Category parent = new Category();
                        parent.Cid = parentid;
                        Category.Parent = parent;
                    }
                    Category.States = reader["states"] is DBNull ? false : reader.GetBoolean("states");
                }

            }
            return Category;
        }

        public Boolean  Add(Category Category)
        {
            string sql = "insert into tb_Category values(@para1, @para2, @para3, @para4, @para5)";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] { Category.Cid, Category.Cname, Category.Cdesc, Category.Parent.Cid, Category.States });
            return result;
        }

        public Boolean UpdateStates(string cid, bool states)
        {
            string sql = "update tb_Category set states=@para1 where cid=@para2";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] {states, cid});
            return result;
        }

        public Boolean Update(string cid, string cname, string cdesc)
        {
            string sql = "update tb_Category set cname=@para1, cdesc=@para2 where cid=@para3";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] { cname, cdesc, cid });
            return result;
        }

    }
}
