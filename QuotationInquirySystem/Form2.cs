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
using static QISUI.AddCategory;
using static QISUI.UpdateCategory;

namespace QISUI
{
    public partial class Form2 : Form
    {
        private CategoryBLL categoryBLL = new CategoryBLL();
        private ProductBLL productBLL = new ProductBLL();
        private SpecBLL specBLL = new SpecBLL();
        private PriceBLL priceBLL = new PriceBLL();

        private TreeNode foreTreeNode = new TreeNode();
        private Product foreProduct = new Product();
        private Spec foreSpec = new Spec();

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateUI();


        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(foreTreeNode.Tag != null)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("删除分类后，不会关联删除产品和规格，但无法通过分类进行查找。\r\n确认删除分类？", "删除分类", messButton);
                if(dr == DialogResult.OK)
                {
                    Category category = new Category();
                    category.Cid = (string)foreTreeNode.Tag;
                    bool result = categoryBLL.Delete(category);
                    if (result)
                    {
                        UpdateUI();
                    }
                }
                
            }
            
        }


        

        private void button9_Click(object sender, EventArgs e)
        {
            AddCategory add = new AddCategory();
            add.SetForeNode(foreTreeNode);
            add.update += new UpdateUIDel(UpdateUI);
            add.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            UpdateCategory update = new UpdateCategory();
            update.SetForeNode(foreTreeNode);
            update.updateUI += new UpdateUIDel2(UpdateUI);
            update.Show();
        }

        private void UpdateUI()
        {
            LoadTreeView();
            LoadProductList();
            LoadSpecList();
            LoadPriceList();

            button19.Enabled = false;
            button11.Enabled = false;
            button9.Enabled = false;
            button1.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button17.Enabled = false;
            button13.Enabled = false;
            button15.Enabled = false;
            button18.Enabled = false;
            button3.Enabled = false;
            button7.Enabled = false;
            button16.Enabled = false;
            button6.Enabled = false;
            button14.Enabled = false;
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
                if (category.Parent != null)
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
                foreach (TreeNode child in node.Nodes)
                {
                    AddChildNodes(child, categorys);
                }
            }
        }

        private void categoryview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreTreeNode = categoryview.SelectedNode;
            warmLabel.Text = foreTreeNode.Text;
            LoadProductList();

            button1.Enabled = true;
            button9.Enabled = true;
            button11.Enabled = true;
            button19.Enabled = true;

            button10.Enabled = false;
            button12.Enabled = false;
            button17.Enabled = false;
            button13.Enabled = false;
            button15.Enabled = false;
            button18.Enabled = false;
            button3.Enabled = false;
            button7.Enabled = false;
            button16.Enabled = false;
            button6.Enabled = false;
            button14.Enabled = false;
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
            button10.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;

            button19.Enabled = false;
            button11.Enabled = false;
            button9.Enabled = false;
            button1.Enabled = false;
            button17.Enabled = false;
            button15.Enabled = false;
            button18.Enabled = false;
            button3.Enabled = false;
            button7.Enabled = false;
            button16.Enabled = false;
            button6.Enabled = false;
            button14.Enabled = false;
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

                button17.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;

                button19.Enabled = false;
                button11.Enabled = false;
                button9.Enabled = false;
                button1.Enabled = false;
                button10.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button18.Enabled = false;
                button3.Enabled = false;
                button7.Enabled = false;
                button6.Enabled = false;
                button14.Enabled = false;
            }
        }

        private void ShowSpec()
        {
            Spec spec = foreSpec;
            snameLabel.Text = spec.Sname;
            sdescLabel.Text = spec.Sdesc;
            unitLabel.Text = spec.Unit;
        }

        private void LoadPriceList()
        {
            List<Price> prices = priceBLL.FindBySid(foreSpec.Sid);
            priceList.Items.Clear();
            int i = 1;
            foreach (Price price in prices)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Tag = price.Prid;

                lvi.Text = i + "";
                i++;

                double priceNum = price.PriceNum;

                lvi.SubItems.Add(price.Supplier);

                lvi.SubItems.Add(priceNum + "");

                lvi.SubItems.Add(price.Time);

                priceList.Items.Add(lvi);
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
                for (int i = 0; i < count; i++)
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

        private void button15_Click(object sender, EventArgs e)
        {
            snameLabel.Enabled = true;
            sdescLabel.Enabled = true;
            unitLabel.Enabled = true;
            button7.Enabled = true;
            button3.Enabled = true;

            button17.Enabled = false;
            button16.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            snameLabel.Text = "";
            sdescLabel.Text = "";
            unitLabel.Text = "";
            snameLabel.Enabled = false;
            sdescLabel.Enabled = false;
            unitLabel.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            snameLabel.Enabled = true;
            sdescLabel.Enabled = true;
            unitLabel.Enabled = true;
            button18.Enabled = true;
            button7.Enabled = true;
            button13.Enabled = false;

            button10.Enabled = false;
            button12.Enabled = false;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (priceList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = priceList.SelectedItems[0];
                string prid = (string)lvi.Tag;
                if(prid != null)
                {
                    Price price = new Price();
                    price.Prid = prid;
                    bool result = priceBLL.Delete(price);
                    if (result)
                    {
                        specList_SelectedIndexChanged(sender, e);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.SetForeNode(foreTreeNode);
            add.updateUIByAddProduct += new AddProduct.UpdateUIByAddProduct(UpdateUI);
            add.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (productList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = productList.SelectedItems[0];
                if (lvi != null)
                {
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show("删除产品后，会关联删除规格和报价，请谨慎删除。\r\n确认删除产品？", "删除产品", messButton);
                    if (dr == DialogResult.OK)
                    {
                        Product product = new Product();
                        product.Pid = (string)lvi.Tag;
                        bool result = productBLL.Delete(product);
                        if (result)
                        {
                            UpdateUI();
                        }
                    }

                }
             }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (productList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = productList.SelectedItems[0];
                if (lvi != null)
                {
                    UpdateProduct update = new UpdateProduct();

                    string pid = (string)lvi.Tag;
                    update.SetForeProduct(productBLL.Load(pid));
                    update.updateUIByUpdateProduct += new UpdateProduct.UpdateUIByUpdateProduct(UpdateUI);
                    update.Show();
                }
                    
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (specList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = specList.SelectedItems[0];
                if (lvi != null)
                {
                    string sid = (string)lvi.Tag;
                    Spec spec = new Spec();
                    spec.Sid = sid;
                    spec.Sname = snameLabel.Text;
                    spec.Sdesc = sdescLabel.Text;
                    spec.Unit = unitLabel.Text;

                    bool result = specBLL.Update(spec);
                    if (result)
                    {
                        UpdateUI();
                    }
                    button3.Enabled = false;

                    button7.Enabled = false;
                    snameLabel.Enabled = false;
                    sdescLabel.Enabled = false;
                    unitLabel.Enabled = false;
                }

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (productList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = productList.SelectedItems[0];
                if (lvi != null)
                {
                    string pid = (string)lvi.Tag;
                    Spec spec = new Spec();
                    spec.Product = productBLL.Load(pid);
                    spec.Sname = snameLabel.Text;
                    spec.Sdesc = sdescLabel.Text;
                    spec.Unit = unitLabel.Text;

                    bool result = specBLL.Add(spec);
                    if (result)
                    {
                        UpdateUI();
                    }

                    button18.Enabled = false;

                    button7.Enabled = false;
                    snameLabel.Enabled = false;
                    sdescLabel.Enabled = false;
                    unitLabel.Enabled = false;
                }
                    
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (productList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = specList.SelectedItems[0];
                if (lvi != null)
                {
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show("删除规格后，会关联删除报价，请谨慎删除。\r\n确认删除规格？", "删除规格", messButton);
                    if (dr == DialogResult.OK)
                    {
                        Spec spec = new Spec();
                        spec.Sid = (string)lvi.Tag;
                        bool result = specBLL.Delete(spec);
                        if (result)
                        {
                            UpdateUI();
                        }
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (specList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = specList.SelectedItems[0];
                if (lvi != null)
                {
                    AddPrice add = new AddPrice();

                    string sid = (string)lvi.Tag;
                    add.SetForeSpec(specBLL.Load(sid));

                    add.updateUIByAddPrice += new AddPrice.UpdateUIByAddPrice(UpdateUI);
                    add.Show();
                }
            }    
        }

        private void priceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button14.Enabled = true;

            button19.Enabled = false;
            button11.Enabled = false;
            button9.Enabled = false;
            button1.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            button17.Enabled = false;
            button13.Enabled = false;
            button15.Enabled = false;
            button18.Enabled = false;
            button3.Enabled = false;
            button7.Enabled = false;
            button16.Enabled = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (priceList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = priceList.SelectedItems[0];
                if (lvi != null)
                {
                    UpdatePrice update = new UpdatePrice();

                    string prid = (string)lvi.Tag;
                    update.SetForePrice(priceBLL.Load(prid));

                    update.updateUIByUpdatePrice += new UpdatePrice.UpdateUIByUpdatePrice(UpdateUI);
                    update.Show();
                }
            }
        }
    }
}
