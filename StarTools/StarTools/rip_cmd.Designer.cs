namespace StarTools
{
    partial class RipCmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RipCmd));
            this.uiProcessBar1 = new Sunny.UI.UIProcessBar();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiRichTextBox1);
            this.PagePanel.Controls.Add(this.uiProcessBar1);
            this.PagePanel.Size = new System.Drawing.Size(800, 270);
            // 
            // uiProcessBar1
            // 
            this.uiProcessBar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiProcessBar1.Location = new System.Drawing.Point(13, 229);
            this.uiProcessBar1.MinimumSize = new System.Drawing.Size(70, 23);
            this.uiProcessBar1.Name = "uiProcessBar1";
            this.uiProcessBar1.ShowValue = false;
            this.uiProcessBar1.Size = new System.Drawing.Size(774, 29);
            this.uiProcessBar1.TabIndex = 25;
            this.uiProcessBar1.Text = "0.0%";
            // 
            // uiRichTextBox1
            // 
            this.uiRichTextBox1.AutoWordSelection = true;
            this.uiRichTextBox1.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRichTextBox1.Location = new System.Drawing.Point(13, 8);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox1.Size = new System.Drawing.Size(774, 213);
            this.uiRichTextBox1.TabIndex = 26;
            // 
            // RipCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RipCmd";
            this.Text = "rip_cmd";
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Sunny.UI.UIProcessBar uiProcessBar1;
        public Sunny.UI.UIRichTextBox uiRichTextBox1;
    }
}