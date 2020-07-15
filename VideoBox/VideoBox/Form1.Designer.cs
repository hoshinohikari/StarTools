namespace VideoBox
{
    partial class Form1
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
            this.VideoFile = new System.Windows.Forms.TextBox();
            this.AddFiles1 = new System.Windows.Forms.Button();
            this.AddFiles2 = new System.Windows.Forms.Button();
            this.AssFile = new System.Windows.Forms.TextBox();
            this.SaveFiles = new System.Windows.Forms.Button();
            this.OutputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rip = new System.Windows.Forms.Button();
            this.Backout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VideoFile
            // 
            this.VideoFile.Location = new System.Drawing.Point(105, 49);
            this.VideoFile.Name = "VideoFile";
            this.VideoFile.Size = new System.Drawing.Size(420, 21);
            this.VideoFile.TabIndex = 0;
            // 
            // AddFiles1
            // 
            this.AddFiles1.Location = new System.Drawing.Point(531, 49);
            this.AddFiles1.Name = "AddFiles1";
            this.AddFiles1.Size = new System.Drawing.Size(75, 21);
            this.AddFiles1.TabIndex = 1;
            this.AddFiles1.Text = "打开";
            this.AddFiles1.UseVisualStyleBackColor = true;
            this.AddFiles1.Click += new System.EventHandler(this.AddFiles1_Click);
            // 
            // AddFiles2
            // 
            this.AddFiles2.Location = new System.Drawing.Point(531, 89);
            this.AddFiles2.Name = "AddFiles2";
            this.AddFiles2.Size = new System.Drawing.Size(75, 21);
            this.AddFiles2.TabIndex = 3;
            this.AddFiles2.Text = "打开";
            this.AddFiles2.UseVisualStyleBackColor = true;
            this.AddFiles2.Click += new System.EventHandler(this.AddFiles2_Click);
            // 
            // AssFile
            // 
            this.AssFile.Location = new System.Drawing.Point(105, 89);
            this.AssFile.Name = "AssFile";
            this.AssFile.Size = new System.Drawing.Size(420, 21);
            this.AssFile.TabIndex = 2;
            // 
            // SaveFiles
            // 
            this.SaveFiles.Location = new System.Drawing.Point(531, 129);
            this.SaveFiles.Name = "SaveFiles";
            this.SaveFiles.Size = new System.Drawing.Size(75, 21);
            this.SaveFiles.TabIndex = 5;
            this.SaveFiles.Text = "保存";
            this.SaveFiles.UseVisualStyleBackColor = true;
            this.SaveFiles.Click += new System.EventHandler(this.SaveFiles_Click);
            // 
            // OutputFile
            // 
            this.OutputFile.Location = new System.Drawing.Point(105, 129);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(420, 21);
            this.OutputFile.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "视频文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "字幕文件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "输出";
            // 
            // rip
            // 
            this.rip.Location = new System.Drawing.Point(148, 188);
            this.rip.Name = "rip";
            this.rip.Size = new System.Drawing.Size(75, 21);
            this.rip.TabIndex = 9;
            this.rip.Text = "压制";
            this.rip.UseVisualStyleBackColor = true;
            this.rip.Click += new System.EventHandler(this.rip_Click);
            // 
            // Backout
            // 
            this.Backout.Location = new System.Drawing.Point(432, 188);
            this.Backout.Name = "Backout";
            this.Backout.Size = new System.Drawing.Size(75, 21);
            this.Backout.TabIndex = 10;
            this.Backout.Text = "退出";
            this.Backout.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 249);
            this.Controls.Add(this.Backout);
            this.Controls.Add(this.rip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveFiles);
            this.Controls.Add(this.OutputFile);
            this.Controls.Add(this.AddFiles2);
            this.Controls.Add(this.AssFile);
            this.Controls.Add(this.AddFiles1);
            this.Controls.Add(this.VideoFile);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VideoFile;
        private System.Windows.Forms.Button AddFiles1;
        private System.Windows.Forms.Button AddFiles2;
        private System.Windows.Forms.TextBox AssFile;
        private System.Windows.Forms.Button SaveFiles;
        private System.Windows.Forms.TextBox OutputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rip;
        private System.Windows.Forms.Button Backout;
    }
}

