using QISDAL;
using QISModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QISBLL
{
    public class PriceBLL
    {
        private PriceDAL priceDAL = new PriceDAL();

        public List<Price> FindBySid(string sid)
        {
            return priceDAL.FindBySid(sid);
        }

        public Price Load(string prid)
        {
            return priceDAL.FindByPrid(prid);
        }

        public Boolean Add(Price price)
        {
            price.Prid = "Price" + new Random().Next(100000000, 999999999);
            price.States = true;
            return priceDAL.Add(price);
        }

        public Boolean Delete(Price price)
        {
            return priceDAL.UpdateStates(price.Prid, false);
        }

        public Boolean Update(Price price)
        {
            return priceDAL.Update(price.Prid, price.Supplier, price.PriceNum, price.Time);
        }
    }
}
