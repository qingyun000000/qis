using MySql.Data.MySqlClient;
using QISModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QISDAL
{
    public class ProductDAL
    {
        private CategoryDAL categoryDAL = new CategoryDAL();

        public List<Product> FindByCid(string cid)
        {
            string sql = "select * from tb_product where cid=@para1 and states=1";
            List<Product> products = new List<Product>();
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql, new Object[] { cid }))
            {
                while (reader.Read())
                {
                    Product product = new Product();
                    product.Pid = reader["pid"] is DBNull ? "" : reader.GetString("pid");
                    product.Pname = reader["pname"] is DBNull ? "" : reader.GetString("pname");
                    product.Pdesc = reader["pdesc"] is DBNull ? "" : reader.GetString("pdesc");
                    string cid1 = reader["cid"] is DBNull ? "" : reader.GetString("cid");
                    Category category = categoryDAL.FindByCid(cid1);
                    product.Category= category;
                    product.States = reader["states"] is DBNull ? false : reader.GetBoolean("states");
                    products.Add(product);
                }

            }
            return products;
        }

        public Product FindByPid(string pid)
        {
            string sql = "select * from tb_product where pid=@para1";
            Product product = new Product();;
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql, new Object[] { pid }))
            {
                while (reader.Read())
                {
                    product.Pid = reader["pid"] is DBNull ? "" : reader.GetString("pid");
                    product.Pname = reader["pname"] is DBNull ? "" : reader.GetString("pname");
                    product.Pdesc = reader["pdesc"] is DBNull ? "" : reader.GetString("pdesc");
                    string cid1 = reader["cid"] is DBNull ? "" : reader.GetString("cid");
                    Category category = categoryDAL.FindByCid(cid1);
                    product.Category = category;
                    product.States = reader["states"] is DBNull ? false : reader.GetBoolean("states");
                }

            }
            return product;
        }

        public Boolean Add(Product product)
        {
            string sql = "insert into tb_product values(@para1, @para2, @para3, @para4, @para5)";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] { product.Pid, product.Pname, product.Pdesc, product.Category.Cid, product.States });
            return result;
        }

        public Boolean UpdateStates(string pid, bool states)
        {
            string sql = "update tb_product set states=@para1 where pid=@para2";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] { states, pid });
            return result;
        }

        public Boolean Update(string pid, string pname, string pdesc)
        {
            string sql = "update tb_product set pname=@para1, pdesc=@para2 where pid=@para3";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] { pname, pdesc, pid });
            return result;
        }

        public List<Product> FindByKeyword(string keyword)
        {
            string sql = "select * from tb_product where (cid like @para1 or pid like @para1 or pname like @para1 or pdesc like @para1) and states=1";
            List<Product> products = new List<Product>();
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql, new Object[] { "%"+keyword+"%" }))
            {
                while (reader.Read())
                {
                    Product product = new Product();
                    product.Pid = reader["pid"] is DBNull ? "" : reader.GetString("pid");
                    product.Pname = reader["pname"] is DBNull ? "" : reader.GetString("pname");
                    product.Pdesc = reader["pdesc"] is DBNull ? "" : reader.GetString("pdesc");
                    string cid1 = reader["cid"] is DBNull ? "" : reader.GetString("cid");
                    Category category = categoryDAL.FindByCid(cid1);
                    product.Category = category;
                    product.States = reader["states"] is DBNull ? false : reader.GetBoolean("states");
                    products.Add(product);
                }

            }
            return products;
        }

        public List<Product> FindByKeywordAndPid (string keyword, string pid)
        {
            string sql = "select * from tb_product where (cid like @para1 or pid like @para1 or pname like @para1 or pdesc like @para1) and pid=@para2 and states=1";
            List<Product> products = new List<Product>();
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql, new Object[] { "%" + keyword + "%", pid }))
            {
                while (reader.Read())
                {
                    Product product = new Product();
                    product.Pid = reader["pid"] is DBNull ? "" : reader.GetString("pid");
                    product.Pname = reader["pname"] is DBNull ? "" : reader.GetString("pname");
                    product.Pdesc = reader["pdesc"] is DBNull ? "" : reader.GetString("pdesc");
                    string cid1 = reader["cid"] is DBNull ? "" : reader.GetString("cid");
                    Category category = categoryDAL.FindByCid(cid1);
                    product.Category = category;
                    product.States = reader["states"] is DBNull ? false : reader.GetBoolean("states");
                    products.Add(product);
                }

            }
            return products;
        }
    }
}
