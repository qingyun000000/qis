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
    public partial class UpdateCategory : Form
    {
        private CategoryBLL categoryBLL = new CategoryBLL();
        private TreeNode foreTreeNode = new TreeNode();

        public void SetForeNode(TreeNode foreTreeNode)
        {
            this.foreTreeNode = foreTreeNode;
        }

        public UpdateCategory()
        {
            InitializeComponent();
        }

        public delegate void UpdateUIDel2();
        public UpdateUIDel2 updateUI;

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            oldNameLabel.Text = foreTreeNode.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Cname = cnameBox.Text;
            category.Cdesc = cdescBox.Text;
            category.Cid = (string)foreTreeNode.Tag;

            bool result = categoryBLL.Update(category);
            {
                updateUI();
                this.Close();
            }
        }
    }
}
