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
    public partial class UpdateProduct : Form
    {
        private ProductBLL productBLL = new ProductBLL();

        private Product foreProduct = new Product();

        public void SetForeProduct(Product product)
        {
            foreProduct = product;
        }

        public UpdateProduct()
        {
            InitializeComponent();
        }

        public delegate void UpdateUIByUpdateProduct();
        public UpdateUIByUpdateProduct updateUIByUpdateProduct;

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            oldPnameLabel.Text = foreProduct.Pname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Pname = pnameBox.Text;
            product.Pdesc = pdescBox.Text;
            product.Pid = foreProduct.Pid;

            bool result = productBLL.Update(product);
            {
                updateUIByUpdateProduct();
                this.Close();
            }
        }
    }
}
