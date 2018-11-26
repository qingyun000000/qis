using QISBLL;
using QISModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QISUI
{
    public partial class AddPrice : Form
    {
        private PriceBLL priceBLL = new PriceBLL();
        private Spec foreSpec = new Spec();

        public void SetForeSpec(Spec spec)
        {
            this.foreSpec = spec;
        }

        public AddPrice()
        {
            InitializeComponent();
        }

        public delegate void UpdateUIByAddPrice();
        public UpdateUIByAddPrice updateUIByAddPrice;

        private void AddPrice_Load(object sender, EventArgs e)
        {
            specLabel.Text = foreSpec.Sname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Price price = new Price();
            price.Spec = foreSpec;
            price.Supplier = supplierBox.Text;
            try
            {
                price.PriceNum = Convert.ToDouble(priceNumBox.Text);
            }
            catch
            {
                priceWarm.Text = "价格必须为整数或者小数";
                return;
            }

            string year = timeYearBox.Text;
            string month = timeMonthBox.Text;
            string day = timeDayBox.Text;

            price.Time = year+"-"+ month + "-" + day;

            bool result = priceBLL.Add(price);
            if (result)
            {
                updateUIByAddPrice();
                this.Close();
            }

        }
    }
}
