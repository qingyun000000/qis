namespace QISUI
{
    partial class UpdateProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oldPnameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pdescBox = new System.Windows.Forms.TextBox();
            this.pnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oldPnameLabel
            // 
            this.oldPnameLabel.AutoSize = true;
            this.oldPnameLabel.Location = new System.Drawing.Point(91, 27);
            this.oldPnameLabel.Name = "oldPnameLabel";
            this.oldPnameLabel.Size = new System.Drawing.Size(0, 12);
            this.oldPnameLabel.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "原产品名";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pdescBox
            // 
            this.pdescBox.Location = new System.Drawing.Point(93, 101);
            this.pdescBox.Multiline = true;
            this.pdescBox.Name = "pdescBox";
            this.pdescBox.Size = new System.Drawing.Size(194, 83);
            this.pdescBox.TabIndex = 17;
            // 
            // pnameBox
            // 
            this.pnameBox.Location = new System.Drawing.Point(93, 63);
            this.pnameBox.Name = "pnameBox";
            this.pnameBox.Size = new System.Drawing.Size(194, 21);
            this.pnameBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "产品描述";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "产 品 名";
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 254);
            this.Controls.Add(this.oldPnameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pdescBox);
            this.Controls.Add(this.pnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProduct";
            this.Text = "updateProduct";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldPnameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pdescBox;
        private System.Windows.Forms.TextBox pnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}