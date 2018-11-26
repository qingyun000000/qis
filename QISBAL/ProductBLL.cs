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
    public class ProductBLL
    {
        private ProductDAL productDAL = new ProductDAL();
        private SpecBLL specBLL = new SpecBLL();

        public List<Product> FindByCid(string cid)
        {
            return productDAL.FindByCid(cid);
        }

        public List<Product> FindByKeywords(string keywords)
        {
            List<Product> products = new List<Product>();
            string[] keywordList = Regex.Split(keywords, "\\s+", RegexOptions.IgnoreCase);
            foreach(string keyword in keywordList)
            {
                products.AddRange(productDAL.FindByKeyword(keyword));
            }
            return products;
        }

        public List<Product> FindByKeywordsAndPids(string keywords, List<string> pids)
        {
            List<Product> products = new List<Product>();
            string[] keywordList = Regex.Split(keywords, "\\s+", RegexOptions.IgnoreCase);
            foreach(string pid in pids)
            {
                foreach (string keyword in keywordList)
                {
                    products.AddRange(productDAL.FindByKeywordAndPid(keyword, pid));
                }
            }
            
            return products;
        }

        public Product Load(string pid)
        {
            return productDAL.FindByPid(pid);
        }

        public Boolean Add(Product product)
        {
            product.Pid = "Product"+ new Random().Next(100000000, 999999999);
            product.States = true;
            return productDAL.Add(product);
        }

        public Boolean Delete(Product product)
        {
            List<Spec> specs = specBLL.FindByPid(product.Pid);
            foreach(Spec spec in specs)
            {
                specBLL.Delete(spec);
            }
            return productDAL.UpdateStates(product.Pid, false);
        }

        public Boolean Update(Product product)
        {
            return productDAL.Update(product.Pid, product.Pname, product.Pdesc);
        }
    }
}
