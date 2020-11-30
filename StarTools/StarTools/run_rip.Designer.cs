namespace StarTools
{
    partial class RunRip
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("压制进度");
            this.SuspendLayout();
            // 
            // Header
            // 
            treeNode1.Name = "节点0";
            treeNode1.Text = "压制进度";
            this.Header.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            // 
            // run_rip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "RunRip";
            this.Text = "run_rip";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.run_rip_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
    }
}