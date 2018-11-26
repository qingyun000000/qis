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
    public partial class UpdatePrice : Form
    {
        private PriceBLL priceBLL = new PriceBLL();
        private Price forePrice = new Price();

        public void SetForePrice(Price price)
        {
            this.forePrice = price;
        }

        public UpdatePrice()
        {
            InitializeComponent();
        }

        public delegate void UpdateUIByUpdatePrice();
        public UpdateUIByUpdatePrice updateUIByUpdatePrice;

        private void UpdatePrice_Load(object sender, EventArgs e)
        {
            oldPriceLabel.Text = forePrice.PriceNum+"   (" +forePrice.Supplier+")";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Price price = new Price();
            price.Prid = forePrice.Prid;
            price.Supplier = supplierBox.Text;
            try
            {
                price.PriceNum = Convert.ToDouble(priceNumBox.Text);
            }catch
            {
                priceWarm.Text = "价格必须为整数或者小数";
                return;
            }
            

            string year = timeYearBox.Text;
            string month = timeMonthBox.Text;
            string day = timeDayBox.Text;

            price.Time = year + "-" + month + "-" + day;

            bool result = priceBLL.Update(price);
            if (result)
            {
                updateUIByUpdatePrice();
                this.Close();
            }

        }
    }
}
