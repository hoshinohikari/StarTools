namespace StarTools
{
    partial class StarTools
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("压制");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("工具");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("高级");
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.Size = new System.Drawing.Size(250, 413);
            // 
            // Header
            // 
            treeNode1.Name = "节点0";
            treeNode1.Text = "压制";
            treeNode2.Name = "节点0";
            treeNode2.Text = "工具";
            treeNode3.Name = "节点1";
            treeNode3.Text = "高级";
            this.Header.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.Header.Size = new System.Drawing.Size(908, 110);
            this.Header.MenuItemClick += new Sunny.UI.UINavBar.OnMenuItemClick(this.Header_MenuItemClick);
            // 
            // StarTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 558);
            this.Name = "StarTools";
            this.Text = "StarTools";
            this.Load += new System.EventHandler(this.StarTools_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}