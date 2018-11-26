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
    public partial class mainFrame : Form
    {
        private CategoryBLL categoryBLL = new CategoryBLL();
        private ProductBLL productBLL = new ProductBLL();
        private SpecBLL specBLL = new SpecBLL();
        private PriceBLL priceBLL = new PriceBLL();

        private TreeNode foreTreeNode = new TreeNode();
        private Product foreProduct = new Product();
        private Spec foreSpec = new Spec();

        public mainFrame()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void mainFrame_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            LoadTreeView();
            LoadProductList();
            LoadSpecList();
            LoadPriceList();
        }

        private void LoadTreeView()
        {
            categoryview.Nodes.Clear();
            List<Category> categorys = categoryBLL.FindAll();
            TreeNode mainNode = new TreeNode();
            foreach (Category category in categorys)
            {
                TreeNode node = new TreeNode();
                node.Text = category.Cname;
                node.Tag = category.Cid;
                if (category.Parent == null)
                {
                    //添加根节点
                    mainNode = node;
                    categoryview.Nodes.Add(mainNode);
                }
            }
            if (categoryview.Nodes != null)
            {
                foreach (TreeNode child in categoryview.Nodes)
                {
                    AddChildNodes(child, categorys);
                }
            }
        }

        private void AddChildNodes(TreeNode node, List<Category> categorys)
        {
            foreach (Category category in categorys)
            {
                if(category.Parent != null)
                {
                    if (category.Parent.Cid.Equals(node.Tag))
                    {
                        TreeNode child = new TreeNode();
                        child.Text = category.Cname;
                        child.Tag = category.Cid;
                        node.Nodes.Add(child);
                    }
                }
                
                
            }
            if (node.Nodes.Count > 0)
            {
                foreach(TreeNode child in node.Nodes)
                {
                    AddChildNodes(child, categorys);
                }
            }
        }

        private void categoryview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            warmLabel.ForeColor = Color.Green;
            warmLabel.Text = "选中了分类:  " + categoryview.SelectedNode.Text;
            foreTreeNode = categoryview.SelectedNode;

            LoadProductList();
        }

        private void LoadProductList()
        {
            List<Product> products = productBLL.FindByCid((string)foreTreeNode.Tag);
            updateProductList(products);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = productList.SelectedItems[0];
                foreProduct = productBLL.Load((string)lvi.Tag);
                LoadSpecList();
            }
        }

        private void LoadSpecList()
        {
            List<Spec> specs = specBLL.FindByPid(foreProduct.Pid);
            updatespecList(specs);
        }

        private void specList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (specList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = specList.SelectedItems[0];
                foreSpec = specBLL.Load((string)lvi.Tag);
                ShowSpec();
                LoadPriceList();
            }
        }

        private void ShowSpec()
        {
            Spec spec = foreSpec;
            cnameLabel.Text = spec.Product.Category.Cname;
            pnameLabel.Text = spec.Product.Pname;
            snameLabel.Text = spec.Sname;
            sdescLabel.Text = spec.Sdesc;
            unitLabel.Text = spec.Unit;
        }

        private void LoadPriceList()
        {
            List<Price> prices = priceBLL.FindBySid(foreSpec.Sid);
            priceList.Items.Clear();
            int i = 1;
            double total = 0;
            double minPrice = 99999999999999;
            double maxPrice = -1;
            foreach (Price price in prices)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Tag = price.Prid;

                lvi.Text = i + "";
                i++;

                double priceNum = price.PriceNum;
                total = total +priceNum;
                if(priceNum < minPrice)
                {
                    minPrice = priceNum;
                }
                if (priceNum > maxPrice)
                {
                    maxPrice = priceNum;
                }

                lvi.SubItems.Add(price.Supplier);

                lvi.SubItems.Add(priceNum+"");

                lvi.SubItems.Add(price.Time);

                priceList.Items.Add(lvi);
            }

            totalPriceNum.Text = (i-1)+"";
            averageLabel.Text = (total /(i-1)) + "";
            minLabel.Text = minPrice + "";
            if (minPrice == 99999999999999)
            {
                minLabel.Text = "NaN";
            }
            maxLabel.Text = maxPrice + "";
            if (maxPrice == -1)
            {
                maxLabel.Text = "NaN";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string keyword = keywordBox.Text;
            loadProductListByKey(keyword);
            LoadSpecListByKey(keyword);
        }

        private void loadProductListByKey(string keyword)
        {
            List<Product> products = productBLL.FindByKeywords(keyword);
            updateProductList(products);
        }

        private void updateProductList(List<Product> products)
        {
            productList.Items.Clear();
            int i = 1;
            foreach (Product product in products)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Tag = product.Pid;

                lvi.Text = i + "";
                i++;

                lvi.SubItems.Add(product.Category.Cname);

                lvi.SubItems.Add(product.Pname);

                lvi.SubItems.Add(product.Pdesc);

                productList.Items.Add(lvi);
            }
        }

        private void LoadSpecListByKey(string keyword)
        {
            List<Spec> specs = specBLL.FindByKeywords(keyword);
            updatespecList(specs);
        }

        private void updatespecList(List<Spec> specs)
        {
            specList.Items.Clear();
            int i = 1;
            foreach (Spec spec in specs)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Tag = spec.Sid;

                lvi.Text = i + "";
                i++;

                lvi.SubItems.Add(spec.Product.Pname);

                lvi.SubItems.Add(spec.Sname);

                lvi.SubItems.Add(spec.Unit);

                lvi.SubItems.Add(spec.Sdesc);

                specList.Items.Add(lvi);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> pids = new List<string>();
            int count = productList.Items.Count;
            string keyword = keywordBox.Text;
            if (count > 0)
            {
                for(int i =0; i < count; i++)
                {
                    ListViewItem item = productList.Items[i];
                    pids.Add((string)item.Tag);
                }
                updateProductList(productBLL.FindByKeywordsAndPids(keyword, pids));
            }
            
            int count2 = specList.Items.Count;
            if (count2 > 0)
            {
                List<string> sids = new List<string>();
                for (int i = 0; i < count2; i++)
                {
                    ListViewItem item = specList.Items[i];
                    sids.Add((string)item.Tag);
                }
                updatespecList(specBLL.FindByKeywordsAndSids(keyword, sids));
            }

        }
    }
}
