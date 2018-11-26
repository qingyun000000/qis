using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QISModel
{
    public class Product
    {
        public string Pid
        {
            get;
            set;
        }
        public string Pname
        {
            get;
            set;
        }
        public string Pdesc
        {
            get;
            set;
        }
        public Category Category
        {
            get;
            set;
        }
        public bool States
        {
            get;
            set;
        }
    }
}
