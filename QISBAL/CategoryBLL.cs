using QISDAL;
using QISModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QISBLL
{
    public class CategoryBLL
    {
        private CategoryDAL categoryDAL = new CategoryDAL();

        public List<Category> FindAll()
        {
            return categoryDAL.FindAll();
        }

        public Category Load(string cid)
        {
            return categoryDAL.FindByCid(cid);
        }

        public Boolean Add(Category category)
        {
            category.Cid = "Category"+ new Random().Next(100000000, 999999999);
            category.States = true;
            return categoryDAL.Add(category);
        }

        public Boolean Delete(Category category)
        {
            return categoryDAL.UpdateStates(category.Cid, false);
        }

        public Boolean Update(Category category)
        {
            return categoryDAL.Update(category.Cid, category.Cname, category.Cdesc);
        }
    }
}
