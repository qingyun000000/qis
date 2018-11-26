using QISDAL;
using QISModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QISBLL
{
    public class SpecBLL
    {
        private SpecDAL specDAL = new SpecDAL();
        private PriceBLL priceBLL = new PriceBLL();

        public List<Spec> FindByPid(string pid)
        {
            return specDAL.FindByPid(pid);
        }

        public List<Spec> FindByKeywords(string keywords)
        {
            List<Spec> specs = new List<Spec>();
            string[] keywordList = Regex.Split(keywords, "\\s+", RegexOptions.IgnoreCase);
            foreach (string keyword in keywordList)
            {
                specs.AddRange(specDAL.FindByKeyword(keyword));
            }
            return specs;
        }

        public List<Spec> FindByKeywordsAndSids(string keywords, List<string> sids)
        {
            List<Spec> specs = new List<Spec>();
            string[] keywordList = Regex.Split(keywords, "\\s+", RegexOptions.IgnoreCase);
            foreach(string sid in sids)
            {
                foreach (string keyword in keywordList)
                {
                    specs.AddRange(specDAL.FindByKeywordAndSid(keyword, sid));
                }
            }
            return specs;
        }

        public Spec Load(string sid)
        {
            return specDAL.FindBySid(sid);
        }

        public Boolean Add(Spec spec)
        {
            spec.Sid = "Spec" + new Random().Next(100000000, 999999999);
            spec.States = true;
            return specDAL.Add(spec);
        }

        public Boolean Delete(Spec spec)
        {
            List<Price> prices = priceBLL.FindBySid(spec.Sid);
            foreach (Price price in prices)
            {
                priceBLL.Delete(price);
            }
            return specDAL.UpdateStates(spec.Sid, false);
        }

        public Boolean Update(Spec spec)
        {
            return specDAL.Update(spec.Sid, spec.Sname, spec.Sdesc, spec.Unit);
        }
    }
}
