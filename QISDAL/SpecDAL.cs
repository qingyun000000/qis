using MySql.Data.MySqlClient;
using QISModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QISDAL
{
    public class SpecDAL
    {
        ProductDAL productDAL = new ProductDAL();

        public List<Spec> FindByPid(string pid)
        {
            string sql = "select * from tb_spec where pid=@para1 and states=1";
            List<Spec> specs = new List<Spec>();
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql, new Object[] { pid }))
            {
                while (reader.Read())
                {
                    Spec spec = new Spec();
                    spec.Sid = reader["sid"] is DBNull ? "" : reader.GetString("sid");
                    spec.Sname = reader["sname"] is DBNull ? "" : reader.GetString("sname");
                    spec.Sdesc = reader["sdesc"] is DBNull ? "" : reader.GetString("sdesc");
                    spec.Unit = reader["unit"] is DBNull ? "" : reader.GetString("unit");
                    string pid1 = reader["pid"] is DBNull ? "" : reader.GetString("pid");
                    Product product = productDAL.FindByPid(pid1);
                    spec.Product = product;
                    spec.States = reader["states"] is DBNull ? false : reader.GetBoolean("states");
                    specs.Add(spec);
                }

            }
            return specs;
        }

        public Spec FindBySid(string sid)
        {
            string sql = "select * from tb_spec where sid=@para1 ";
            Spec spec = new Spec();
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql, new Object[] { sid }))
            {
                while (reader.Read())
                {
                    spec.Sid = reader["sid"] is DBNull ? "" : reader.GetString("sid");
                    spec.Sname = reader["sname"] is DBNull ? "" : reader.GetString("sname");
                    spec.Sdesc = reader["sdesc"] is DBNull ? "" : reader.GetString("sdesc");
                    spec.Unit = reader["unit"] is DBNull ? "" : reader.GetString("unit");
                    string pid1 = reader["pid"] is DBNull ? "" : reader.GetString("pid");
                    Product product = productDAL.FindByPid(pid1);
                    spec.Product = product;
                    spec.States = reader["states"] is DBNull ? false : reader.GetBoolean("states");
                }

            }
            return spec;
        }

        public Boolean Add(Spec spec)
        {
            string sql = "insert into tb_spec values(@para1, @para2, @para3, @para4, @para5, @para6)";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] { spec.Sid, spec.Sname, spec.Sdesc, spec.Unit, spec.Product.Pid, spec.States });
            return result;
        }

        public Boolean UpdateStates(string sid, bool states)
        {
            string sql = "update tb_spec set states=@para1 where sid=@para2";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] { states, sid });
            return result;
        }

        public Boolean Update(string sid, string sname, string sdesc, string unit)
        {
            string sql = "update tb_spec set sname=@para1, sdesc=@para2, unit=@para3 where sid=@para4";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] { sname, sdesc, unit, sid });
            return result;
        }

        public List<Spec> FindByKeyword(string keyword)
        {
            string sql = "select * from tb_spec where (pid like @para1 or sid like @para1 or sname like @para1 or sdesc like @para1) and states=1";
            List<Spec> specs = new List<Spec>();
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql, new Object[] { "%" + keyword + "%"}))
            {
                while (reader.Read())
                {
                    Spec spec = new Spec();
                    spec.Sid = reader["sid"] is DBNull ? "" : reader.GetString("sid");
                    spec.Sname = reader["sname"] is DBNull ? "" : reader.GetString("sname");
                    spec.Sdesc = reader["sdesc"] is DBNull ? "" : reader.GetString("sdesc");
                    spec.Unit = reader["unit"] is DBNull ? "" : reader.GetString("unit");
                    string pid1 = reader["pid"] is DBNull ? "" : reader.GetString("pid");
                    Product product = productDAL.FindByPid(pid1);
                    spec.Product = product;
                    spec.States = reader["states"] is DBNull ? false : reader.GetBoolean("states");
                    specs.Add(spec);
                }

            }
            return specs;
        }

        public List<Spec> FindByKeywordAndSid(string keyword, string sid)
        {
            string sql = "select * from tb_spec where (pid like @para1 or sid like @para1 or sname like @para1 or sdesc like @para1 or unit like @para1) and sid=@para2 and states=1";
            List<Spec> specs = new List<Spec>();
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql, new Object[] { "%" + keyword + "%", sid}))
            {
                while (reader.Read())
                {
                    Spec spec = new Spec();
                    spec.Sid = reader["sid"] is DBNull ? "" : reader.GetString("sid");
                    spec.Sname = reader["sname"] is DBNull ? "" : reader.GetString("sname");
                    spec.Sdesc = reader["sdesc"] is DBNull ? "" : reader.GetString("sdesc");
                    spec.Unit = reader["unit"] is DBNull ? "" : reader.GetString("unit");
                    string pid1 = reader["pid"] is DBNull ? "" : reader.GetString("pid");
                    Product product = productDAL.FindByPid(pid1);
                    spec.Product = product;
                    spec.States = reader["states"] is DBNull ? false : reader.GetBoolean("states");
                    specs.Add(spec);
                }

            }
            return specs;
        }
    }
}
