using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QISModel
{
    public class Category
    {
        public string Cid
        {
            get;
            set;
        }
        public string Cname
        {
            get;
            set;
        }
        public string Cdesc
        {
            get;
            set;
        }
        public Category Parent
        {
            get;
            set;
        }
        public Boolean States
        {
            get;
            set;
        }
    }
}
