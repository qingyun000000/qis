using MySql.Data.MySqlClient;
using QISModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QISDAL
{
    public class PriceDAL
    {
        SpecDAL SpecDAL = new SpecDAL();

        public List<Price> FindBySid(string sid)
        {
            string sql = "select * from tb_price where sid=@para1 and states=1";
            List<Price> prices = new List<Price>();
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql, new Object[] { sid }))
            {
                while (reader.Read())
                {
                    Price price = new Price();
                    price.Prid = reader["prid"] is DBNull ? "" : reader.GetString("prid");
                    string sid1 = reader["sid"] is DBNull ? "" : reader.GetString("sid");
                    Spec spec = SpecDAL.FindBySid(sid1);
                    price.Spec = spec;
                    price.Supplier = reader["supplier"] is DBNull ? "" : reader.GetString("supplier");
                    price.PriceNum = reader["priceNum"] is DBNull ? -9999: reader.GetDouble("priceNum");
                    price.Time = reader["time"] is DBNull ? "" : reader.GetString("time");
                    price.States = reader["states"] is DBNull ? false : reader.GetBoolean("states");
                    prices.Add(price);
                }

            }
            return prices;
        }

        public Price FindByPrid(string prid)
        {
            string sql = "select * from tb_price where prid=@para1";
            Price price = new Price();
            using (MySqlDataReader reader = MySQLUtils.ExecuteReader(sql, new Object[] { prid }))
            {
                while (reader.Read())
                {
                    price.Prid = reader["prid"] is DBNull ? "" : reader.GetString("prid");
                    string sid1 = reader["sid"] is DBNull ? "" : reader.GetString("sid");
                    Spec spec = SpecDAL.FindBySid(sid1);
                    price.Spec = spec;
                    price.Supplier = reader["supplier"] is DBNull ? "" : reader.GetString("supplier");
                    price.PriceNum = reader["priceNum"] is DBNull ? -9999 : reader.GetDouble("priceNum");
                    price.Time = reader["time"] is DBNull ? "" : reader.GetString("time");
                    price.States = reader["states"] is DBNull ? false : reader.GetBoolean("states");
                }

            }
            return price;
        }

        public Boolean Add(Price price)
        {
            string sql = "insert into tb_price values(@para1, @para2, @para3, @para4, @para5, @para6)";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] {price.Prid, price.Spec.Sid, price.Supplier, price.PriceNum, price.Time, price.States});
            return result;
        }

        public Boolean UpdateStates(string prid, bool states)
        {
            string sql = "update tb_price set states=@para1 where prid=@para2";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] { states, prid });
            return result;
        }

        public Boolean Update(string prid, string supplier, double priceNum, string time)
        {
            string sql = "update tb_price set supplier=@para1, priceNum=@para2, time=@para3 where prid=@para4";
            bool result = MySQLUtils.ExecuteNonQuery(sql, new Object[] { supplier, priceNum, time, prid });
            return result;
        }
    }
}
