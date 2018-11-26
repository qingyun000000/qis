namespace QISUI
{
    partial class mainFrame
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.keywordBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.ListView();
            this.ProductNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pdesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.categoryview = new System.Windows.Forms.TreeView();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cnameLabel = new System.Windows.Forms.Label();
            this.pnameLabel = new System.Windows.Forms.Label();
            this.snameLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.priceList = new System.Windows.Forms.ListView();
            this.priceNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.supplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.averageLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalPriceNum = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.specList = new System.Windows.Forms.ListView();
            this.specNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pname1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sdesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.warmLabel = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.sdescLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "分类搜索";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(640, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "报价管理";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // keywordBox
            // 
            this.keywordBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keywordBox.Location = new System.Drawing.Point(321, 47);
            this.keywordBox.Name = "keywordBox";
            this.keywordBox.Size = new System.Drawing.Size(203, 30);
            this.keywordBox.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(530, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "搜索全部";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // productList
            // 
            this.productList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductNo,
            this.cname,
            this.pname,
            this.pdesc});
            this.productList.FullRowSelect = true;
            this.productList.Location = new System.Drawing.Point(168, 84);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(610, 153);
            this.productList.TabIndex = 7;
            this.productList.UseCompatibleStateImageBehavior = false;
            this.productList.View = System.Windows.Forms.View.Details;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // ProductNo
            // 
            this.ProductNo.Text = "序号";
            this.ProductNo.Width = 40;
            // 
            // cname
            // 
            this.cname.Text = "产品分类";
            this.cname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cname.Width = 142;
            // 
            // pname
            // 
            this.pname.Text = "产品名称";
            this.pname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pname.Width = 150;
            // 
            // pdesc
            // 
            this.pdesc.Text = "产品描述";
            this.pdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pdesc.Width = 280;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(168, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "关键字搜索";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // categoryview
            // 
            this.categoryview.Location = new System.Drawing.Point(12, 83);
            this.categoryview.Name = "categoryview";
            this.categoryview.Size = new System.Drawing.Size(150, 526);
            this.categoryview.TabIndex = 8;
            this.categoryview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.categoryview_AfterSelect);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.Purple;
            this.button5.Location = new System.Drawing.Point(653, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 30);
            this.button5.TabIndex = 9;
            this.button5.Text = "结果中搜索";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "产品分类:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "产品名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "规    格:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "单    位:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "描    述:";
            // 
            // cnameLabel
            // 
            this.cnameLabel.AutoSize = true;
            this.cnameLabel.Location = new System.Drawing.Point(281, 363);
            this.cnameLabel.Name = "cnameLabel";
            this.cnameLabel.Size = new System.Drawing.Size(0, 12);
            this.cnameLabel.TabIndex = 16;
            // 
            // pnameLabel
            // 
            this.pnameLabel.AutoSize = true;
            this.pnameLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnameLabel.Location = new System.Drawing.Point(552, 363);
            this.pnameLabel.Name = "pnameLabel";
            this.pnameLabel.Size = new System.Drawing.Size(0, 12);
            this.pnameLabel.TabIndex = 17;
            // 
            // snameLabel
            // 
            this.snameLabel.AutoSize = true;
            this.snameLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.snameLabel.Location = new System.Drawing.Point(281, 388);
            this.snameLabel.Name = "snameLabel";
            this.snameLabel.Size = new System.Drawing.Size(0, 12);
            this.snameLabel.TabIndex = 18;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(552, 388);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(0, 12);
            this.unitLabel.TabIndex = 20;
            // 
            // priceList
            // 
            this.priceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.priceNo,
            this.supplier,
            this.priceNum,
            this.time});
            this.priceList.Location = new System.Drawing.Point(168, 472);
            this.priceList.Name = "priceList";
            this.priceList.Size = new System.Drawing.Size(356, 137);
            this.priceList.TabIndex = 21;
            this.priceList.UseCompatibleStateImageBehavior = false;
            this.priceList.View = System.Windows.Forms.View.Details;
            // 
            // priceNo
            // 
            this.priceNo.Text = "序号";
            this.priceNo.Width = 40;
            // 
            // supplier
            // 
            this.supplier.Text = "供应商";
            this.supplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.supplier.Width = 100;
            // 
            // priceNum
            // 
            this.priceNum.Text = "价格";
            this.priceNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceNum.Width = 100;
            // 
            // time
            // 
            this.time.Text = "报价时间";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.Width = 120;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.averageLabel.ForeColor = System.Drawing.Color.Red;
            this.averageLabel.Location = new System.Drawing.Point(605, 509);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(0, 16);
            this.averageLabel.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(558, 513);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "平均价";
            // 
            // totalPriceNum
            // 
            this.totalPriceNum.AutoSize = true;
            this.totalPriceNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalPriceNum.ForeColor = System.Drawing.Color.Blue;
            this.totalPriceNum.Location = new System.Drawing.Point(605, 477);
            this.totalPriceNum.Name = "totalPriceNum";
            this.totalPriceNum.Size = new System.Drawing.Size(0, 16);
            this.totalPriceNum.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(558, 481);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 24;
            this.label14.Text = "报价数";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minLabel.Location = new System.Drawing.Point(605, 543);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(0, 16);
            this.minLabel.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(558, 547);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 26;
            this.label16.Text = "最低价";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxLabel.ForeColor = System.Drawing.Color.Maroon;
            this.maxLabel.Location = new System.Drawing.Point(605, 578);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(0, 16);
            this.maxLabel.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(558, 582);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 28;
            this.label18.Text = "最高价";
            // 
            // specList
            // 
            this.specList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.specNo,
            this.pname1,
            this.sname,
            this.unit,
            this.sdesc});
            this.specList.FullRowSelect = true;
            this.specList.Location = new System.Drawing.Point(168, 243);
            this.specList.Name = "specList";
            this.specList.Size = new System.Drawing.Size(610, 117);
            this.specList.TabIndex = 30;
            this.specList.UseCompatibleStateImageBehavior = false;
            this.specList.View = System.Windows.Forms.View.Details;
            this.specList.SelectedIndexChanged += new System.EventHandler(this.specList_SelectedIndexChanged);
            // 
            // specNo
            // 
            this.specNo.Text = "序号";
            this.specNo.Width = 40;
            // 
            // pname1
            // 
            this.pname1.Text = "产品名称";
            this.pname1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pname1.Width = 150;
            // 
            // sname
            // 
            this.sname.Text = "规格名";
            this.sname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sname.Width = 150;
            // 
            // unit
            // 
            this.unit.Text = "单位";
            this.unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sdesc
            // 
            this.sdesc.Text = "规格描述";
            this.sdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sdesc.Width = 250;
            // 
            // warmLabel
            // 
            this.warmLabel.AutoSize = true;
            this.warmLabel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warmLabel.Location = new System.Drawing.Point(12, 15);
            this.warmLabel.Name = "warmLabel";
            this.warmLabel.Size = new System.Drawing.Size(0, 21);
            this.warmLabel.TabIndex = 31;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Location = new System.Drawing.Point(496, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 30);
            this.button6.TabIndex = 32;
            this.button6.Text = "刷新数据";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // sdescLabel
            // 
            this.sdescLabel.BackColor = System.Drawing.SystemColors.Control;
            this.sdescLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sdescLabel.Enabled = false;
            this.sdescLabel.Location = new System.Drawing.Point(283, 419);
            this.sdescLabel.Multiline = true;
            this.sdescLabel.Name = "sdescLabel";
            this.sdescLabel.Size = new System.Drawing.Size(453, 47);
            this.sdescLabel.TabIndex = 33;
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.sdescLabel);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.warmLabel);
            this.Controls.Add(this.specList);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.totalPriceNum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.priceList);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.snameLabel);
            this.Controls.Add(this.pnameLabel);
            this.Controls.Add(this.cnameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.categoryview);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.keywordBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "mainFrame";
            this.Text = "物料报价查询系统";
            this.Load += new System.EventHandler(this.mainFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox keywordBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView productList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView categoryview;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cnameLabel;
        private System.Windows.Forms.Label pnameLabel;
        private System.Windows.Forms.Label snameLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.ListView priceList;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalPriceNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListView specList;
        private System.Windows.Forms.Label warmLabel;
        private System.Windows.Forms.ColumnHeader cname;
        private System.Windows.Forms.ColumnHeader pname;
        private System.Windows.Forms.ColumnHeader pdesc;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ColumnHeader ProductNo;
        private System.Windows.Forms.ColumnHeader specNo;
        private System.Windows.Forms.ColumnHeader pname1;
        private System.Windows.Forms.ColumnHeader sname;
        private System.Windows.Forms.ColumnHeader unit;
        private System.Windows.Forms.ColumnHeader sdesc;
        private System.Windows.Forms.TextBox sdescLabel;
        private System.Windows.Forms.ColumnHeader priceNo;
        private System.Windows.Forms.ColumnHeader supplier;
        private System.Windows.Forms.ColumnHeader priceNum;
        private System.Windows.Forms.ColumnHeader time;
    }
}

