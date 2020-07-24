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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBox));
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ffmpeg常用功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ffmpeg_Live = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AudioBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VideoFile
            // 
            this.VideoFile.Location = new System.Drawing.Point(108, 41);
            this.VideoFile.Name = "VideoFile";
            this.VideoFile.Size = new System.Drawing.Size(420, 21);
            this.VideoFile.TabIndex = 0;
            this.VideoFile.TextChanged += new System.EventHandler(this.VideoFile_TextChanged);
            // 
            // AddFiles1
            // 
            this.AddFiles1.Location = new System.Drawing.Point(534, 41);
            this.AddFiles1.Name = "AddFiles1";
            this.AddFiles1.Size = new System.Drawing.Size(75, 21);
            this.AddFiles1.TabIndex = 1;
            this.AddFiles1.Text = "打开";
            this.AddFiles1.UseVisualStyleBackColor = true;
            this.AddFiles1.Click += new System.EventHandler(this.AddFiles1_Click);
            // 
            // AddFiles2
            // 
            this.AddFiles2.Location = new System.Drawing.Point(534, 81);
            this.AddFiles2.Name = "AddFiles2";
            this.AddFiles2.Size = new System.Drawing.Size(75, 21);
            this.AddFiles2.TabIndex = 3;
            this.AddFiles2.Text = "打开";
            this.AddFiles2.UseVisualStyleBackColor = true;
            this.AddFiles2.Click += new System.EventHandler(this.AddFiles2_Click);
            // 
            // AssFile
            // 
            this.AssFile.Location = new System.Drawing.Point(108, 81);
            this.AssFile.Name = "AssFile";
            this.AssFile.Size = new System.Drawing.Size(420, 21);
            this.AssFile.TabIndex = 2;
            // 
            // SaveFiles
            // 
            this.SaveFiles.Location = new System.Drawing.Point(534, 121);
            this.SaveFiles.Name = "SaveFiles";
            this.SaveFiles.Size = new System.Drawing.Size(75, 21);
            this.SaveFiles.TabIndex = 5;
            this.SaveFiles.Text = "保存";
            this.SaveFiles.UseVisualStyleBackColor = true;
            this.SaveFiles.Click += new System.EventHandler(this.SaveFiles_Click);
            // 
            // OutputFile
            // 
            this.OutputFile.Location = new System.Drawing.Point(108, 121);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(420, 21);
            this.OutputFile.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "视频文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "字幕文件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "输出";
            // 
            // rip
            // 
            this.rip.Location = new System.Drawing.Point(152, 283);
            this.rip.Name = "rip";
            this.rip.Size = new System.Drawing.Size(75, 21);
            this.rip.TabIndex = 9;
            this.rip.Text = "压制";
            this.rip.UseVisualStyleBackColor = true;
            this.rip.Click += new System.EventHandler(this.rip_Click);
            // 
            // Backout
            // 
            this.Backout.Location = new System.Drawing.Point(436, 283);
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
            this.label4.Location = new System.Drawing.Point(37, 167);
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
            this.EncoderBox.Location = new System.Drawing.Point(108, 164);
            this.EncoderBox.Name = "EncoderBox";
            this.EncoderBox.Size = new System.Drawing.Size(420, 20);
            this.EncoderBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 164);
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
            this.checkBox1.Location = new System.Drawing.Point(108, 208);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "硬件反交错";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(219, 208);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "硬件缩放";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // hBox
            // 
            this.hBox.Location = new System.Drawing.Point(372, 206);
            this.hBox.Name = "hBox";
            this.hBox.Size = new System.Drawing.Size(52, 21);
            this.hBox.TabIndex = 16;
            // 
            // wBox
            // 
            this.wBox.Location = new System.Drawing.Point(297, 206);
            this.wBox.Name = "wBox";
            this.wBox.Size = new System.Drawing.Size(52, 21);
            this.wBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "X";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ffmpeg常用功能ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 25);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ffmpeg常用功能ToolStripMenuItem
            // 
            this.ffmpeg常用功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ffmpeg_Live});
            this.ffmpeg常用功能ToolStripMenuItem.Name = "ffmpeg常用功能ToolStripMenuItem";
            this.ffmpeg常用功能ToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.ffmpeg常用功能ToolStripMenuItem.Text = "ffmpeg常用功能";
            // 
            // ffmpeg_Live
            // 
            this.ffmpeg_Live.Name = "ffmpeg_Live";
            this.ffmpeg_Live.Size = new System.Drawing.Size(180, 22);
            this.ffmpeg_Live.Text = "ffmpeg直播";
            this.ffmpeg_Live.Click += new System.EventHandler(this.ffmpeg_Live_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "音频模式";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "复制音频",
            "压制音频"});
            this.comboBox1.Location = new System.Drawing.Point(165, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 20);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AudioBox
            // 
            this.AudioBox.Location = new System.Drawing.Point(272, 240);
            this.AudioBox.Name = "AudioBox";
            this.AudioBox.Size = new System.Drawing.Size(52, 21);
            this.AudioBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "kbps";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "如报错请选择压制音频模式";
            // 
            // MainBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 332);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AudioBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainBox";
            this.Text = "StarTools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ffmpeg常用功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ffmpeg_Live;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox AudioBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

