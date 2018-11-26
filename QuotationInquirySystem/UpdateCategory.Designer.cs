namespace QISUI
{
    partial class UpdateCategory
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
            this.oldNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cdescBox = new System.Windows.Forms.TextBox();
            this.cnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oldNameLabel
            // 
            this.oldNameLabel.AutoSize = true;
            this.oldNameLabel.Location = new System.Drawing.Point(101, 16);
            this.oldNameLabel.Name = "oldNameLabel";
            this.oldNameLabel.Size = new System.Drawing.Size(0, 12);
            this.oldNameLabel.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "原分类名";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cdescBox
            // 
            this.cdescBox.Location = new System.Drawing.Point(103, 90);
            this.cdescBox.Multiline = true;
            this.cdescBox.Name = "cdescBox";
            this.cdescBox.Size = new System.Drawing.Size(194, 83);
            this.cdescBox.TabIndex = 10;
            // 
            // cnameBox
            // 
            this.cnameBox.Location = new System.Drawing.Point(103, 52);
            this.cnameBox.Name = "cnameBox";
            this.cnameBox.Size = new System.Drawing.Size(194, 21);
            this.cnameBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "分类描述";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "新分类名";
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 246);
            this.Controls.Add(this.oldNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cdescBox);
            this.Controls.Add(this.cnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateCategory";
            this.Text = "UpdateCategory";
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cdescBox;
        private System.Windows.Forms.TextBox cnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}