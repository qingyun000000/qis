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
    public partial class AddProduct : Form
    {
        private ProductBLL productBLL = new ProductBLL();
        private TreeNode foreTreeNode = new TreeNode();

        public void SetForeNode(TreeNode foreTreeNode)
        {
            this.foreTreeNode = foreTreeNode;
        }


        public AddProduct()
        {
            InitializeComponent();
        }

        public delegate void UpdateUIByAddProduct();
        public UpdateUIByAddProduct updateUIByAddProduct;

        private void AddProduct_Load(object sender, EventArgs e)
        {
            categoryLabel.Text = foreTreeNode.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Pname = pnameBox.Text;
            product.Pdesc = pdescBox.Text;
            string cid = (string)foreTreeNode.Tag;
            Category category = new Category();
            category.Cid = cid;
            product.Category = category;

            bool result = productBLL.Add(product);
            {
                updateUIByAddProduct();
                this.Close();
            }
        }
    }
}
