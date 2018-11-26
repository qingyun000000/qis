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
    public partial class AddCategory : Form
    {
        private CategoryBLL categoryBLL = new CategoryBLL();
        private TreeNode foreTreeNode = new TreeNode();

        public void SetForeNode(TreeNode foreTreeNode)
        {
            this.foreTreeNode = foreTreeNode;
        }

        public AddCategory()
        {
            InitializeComponent();
        }

        public delegate void UpdateUIDel();
        public UpdateUIDel update;

        private void button1_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Cname = cnameBox.Text;
            category.Cdesc = cdescBox.Text;
            Category parent = new Category();
            parent.Cid = (string)foreTreeNode.Tag;
            category.Parent = parent;

            bool result = categoryBLL.Add(category);
            if (result)
            {
                update();
                this.Close();
            }
            
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            parentNameLabel.Text = foreTreeNode.Text;
        }
    }
}
