namespace VideoBox
{
    partial class MainBox
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
            this.label4 = new System.Windows.Forms.Label();
            this.EncoderBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.hBox = new System.Windows.Forms.TextBox();
            this.wBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.rip.Location = new System.Drawing.Point(153, 254);
            this.rip.Name = "rip";
            this.rip.Size = new System.Drawing.Size(75, 21);
            this.rip.TabIndex = 9;
            this.rip.Text = "压制";
            this.rip.UseVisualStyleBackColor = true;
            this.rip.Click += new System.EventHandler(this.rip_Click);
            // 
            // Backout
            // 
            this.Backout.Location = new System.Drawing.Point(437, 254);
            this.Backout.Name = "Backout";
            this.Backout.Size = new System.Drawing.Size(75, 21);
            this.Backout.TabIndex = 10;
            this.Backout.Text = "退出";
            this.Backout.UseVisualStyleBackColor = true;
            this.Backout.Click += new System.EventHandler(this.Backout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "选择编码器";
            // 
            // EncoderBox
            // 
            this.EncoderBox.FormattingEnabled = true;
            this.EncoderBox.Items.AddRange(new object[] {
            "QSVEnc（Intel显卡以及笔记本集显用）（推荐）（默认）",
            "NVEnc（nVidia显卡用）",
            "VCEEnc（AMD显卡以及笔记本集显用）"});
            this.EncoderBox.Location = new System.Drawing.Point(105, 172);
            this.EncoderBox.Name = "EncoderBox";
            this.EncoderBox.Size = new System.Drawing.Size(420, 20);
            this.EncoderBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "编码器设置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(105, 216);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "硬件反交错";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(216, 216);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "硬件缩放";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // hBox
            // 
            this.hBox.Location = new System.Drawing.Point(369, 214);
            this.hBox.Name = "hBox";
            this.hBox.Size = new System.Drawing.Size(52, 21);
            this.hBox.TabIndex = 16;
            // 
            // wBox
            // 
            this.wBox.Location = new System.Drawing.Point(294, 214);
            this.wBox.Name = "wBox";
            this.wBox.Size = new System.Drawing.Size(52, 21);
            this.wBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "X";
            // 
            // MainBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 292);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wBox);
            this.Controls.Add(this.hBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EncoderBox);
            this.Controls.Add(this.label4);
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
            this.Name = "MainBox";
            this.Text = "MainBox";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EncoderBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox hBox;
        private System.Windows.Forms.TextBox wBox;
        private System.Windows.Forms.Label label5;
    }
}

