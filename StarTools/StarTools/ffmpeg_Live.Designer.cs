namespace VideoBox
{
    partial class ffmpeg_Live
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ffmpeg_Live));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VideoFile = new System.Windows.Forms.TextBox();
            this.LiveCode = new System.Windows.Forms.TextBox();
            this.RTMP = new System.Windows.Forms.TextBox();
            this.Backout = new System.Windows.Forms.Button();
            this.Live = new System.Windows.Forms.Button();
            this.OpenVideo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AudioBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "视频文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "你的直播码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "你的rtmp地址";
            // 
            // VideoFile
            // 
            this.VideoFile.AllowDrop = true;
            this.VideoFile.Location = new System.Drawing.Point(104, 42);
            this.VideoFile.Name = "VideoFile";
            this.VideoFile.Size = new System.Drawing.Size(339, 21);
            this.VideoFile.TabIndex = 10;
            this.VideoFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideoFile_DragDrop);
            this.VideoFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.VideoFile_DragEnter);
            // 
            // LiveCode
            // 
            this.LiveCode.Location = new System.Drawing.Point(104, 116);
            this.LiveCode.Name = "LiveCode";
            this.LiveCode.Size = new System.Drawing.Size(420, 21);
            this.LiveCode.TabIndex = 11;
            // 
            // RTMP
            // 
            this.RTMP.Location = new System.Drawing.Point(104, 78);
            this.RTMP.Name = "RTMP";
            this.RTMP.Size = new System.Drawing.Size(420, 21);
            this.RTMP.TabIndex = 12;
            // 
            // Backout
            // 
            this.Backout.Location = new System.Drawing.Point(380, 206);
            this.Backout.Name = "Backout";
            this.Backout.Size = new System.Drawing.Size(75, 21);
            this.Backout.TabIndex = 14;
            this.Backout.Text = "退出";
            this.Backout.UseVisualStyleBackColor = true;
            this.Backout.Click += new System.EventHandler(this.Backout_Click);
            // 
            // Live
            // 
            this.Live.Location = new System.Drawing.Point(96, 206);
            this.Live.Name = "Live";
            this.Live.Size = new System.Drawing.Size(75, 21);
            this.Live.TabIndex = 13;
            this.Live.Text = "推流";
            this.Live.UseVisualStyleBackColor = true;
            this.Live.Click += new System.EventHandler(this.Live_Click);
            // 
            // OpenVideo
            // 
            this.OpenVideo.Location = new System.Drawing.Point(449, 42);
            this.OpenVideo.Name = "OpenVideo";
            this.OpenVideo.Size = new System.Drawing.Size(75, 21);
            this.OpenVideo.TabIndex = 15;
            this.OpenVideo.Text = "打开";
            this.OpenVideo.UseVisualStyleBackColor = true;
            this.OpenVideo.Click += new System.EventHandler(this.OpenVideo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "如报错请选择压制音频模式";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "kbps";
            // 
            // AudioBox
            // 
            this.AudioBox.Location = new System.Drawing.Point(268, 158);
            this.AudioBox.Name = "AudioBox";
            this.AudioBox.Size = new System.Drawing.Size(52, 21);
            this.AudioBox.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "复制音频",
            "压制音频"});
            this.comboBox1.Location = new System.Drawing.Point(161, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 20);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "音频模式";
            // 
            // ffmpeg_Live
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 260);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AudioBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OpenVideo);
            this.Controls.Add(this.Backout);
            this.Controls.Add(this.Live);
            this.Controls.Add(this.RTMP);
            this.Controls.Add(this.LiveCode);
            this.Controls.Add(this.VideoFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ffmpeg_Live";
            this.Text = "FFmpeg_live";
            this.Load += new System.EventHandler(this.ffmpeg_Live_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VideoFile;
        private System.Windows.Forms.TextBox LiveCode;
        private System.Windows.Forms.TextBox RTMP;
        private System.Windows.Forms.Button Backout;
        private System.Windows.Forms.Button Live;
        private System.Windows.Forms.Button OpenVideo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AudioBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}