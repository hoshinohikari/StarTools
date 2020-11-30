namespace StarTools
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.AudioMode = new Sunny.UI.UIComboBox();
            this.AudioBox = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.Live = new Sunny.UI.UIButton();
            this.AddVideoFiles = new Sunny.UI.UISymbolButton();
            this.RTMP = new Sunny.UI.UITextBox();
            this.LiveCode = new Sunny.UI.UITextBox();
            this.VideoFile = new Sunny.UI.UITextBox();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.AddVideoFiles);
            this.PagePanel.Controls.Add(this.RTMP);
            this.PagePanel.Controls.Add(this.LiveCode);
            this.PagePanel.Controls.Add(this.VideoFile);
            this.PagePanel.Controls.Add(this.Live);
            this.PagePanel.Controls.Add(this.uiLabel7);
            this.PagePanel.Controls.Add(this.uiLabel8);
            this.PagePanel.Controls.Add(this.AudioMode);
            this.PagePanel.Controls.Add(this.AudioBox);
            this.PagePanel.Controls.Add(this.uiLabel6);
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Size = new System.Drawing.Size(658, 378);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(12, 23);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "视频文件";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(12, 86);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "rtmp地址";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(12, 149);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "直播码";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(268, 205);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(204, 23);
            this.uiLabel7.TabIndex = 39;
            this.uiLabel7.Text = "如报错请选择压制音频模式";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(350, 205);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(52, 23);
            this.uiLabel8.TabIndex = 41;
            this.uiLabel8.Text = "kbps";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AudioMode
            // 
            this.AudioMode.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.AudioMode.FillColor = System.Drawing.Color.White;
            this.AudioMode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AudioMode.Items.AddRange(new object[] {
            "复制音频",
            "压制音频"});
            this.AudioMode.Location = new System.Drawing.Point(166, 202);
            this.AudioMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AudioMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.AudioMode.Name = "AudioMode";
            this.AudioMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.AudioMode.Size = new System.Drawing.Size(95, 29);
            this.AudioMode.TabIndex = 38;
            this.AudioMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.AudioMode.SelectedIndexChanged += new System.EventHandler(this.AudioMode_SelectedIndexChanged);
            // 
            // AudioBox
            // 
            this.AudioBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AudioBox.FillColor = System.Drawing.Color.White;
            this.AudioBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AudioBox.Location = new System.Drawing.Point(269, 202);
            this.AudioBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AudioBox.Maximum = 2147483647D;
            this.AudioBox.Minimum = -2147483648D;
            this.AudioBox.Name = "AudioBox";
            this.AudioBox.Padding = new System.Windows.Forms.Padding(5);
            this.AudioBox.Size = new System.Drawing.Size(74, 29);
            this.AudioBox.TabIndex = 40;
            this.AudioBox.TextChanged += new System.EventHandler(this.AudioBox_TextChanged);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(81, 205);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(79, 23);
            this.uiLabel6.TabIndex = 37;
            this.uiLabel6.Text = "音频模式";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Live
            // 
            this.Live.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Live.FillColor = System.Drawing.Color.White;
            this.Live.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Live.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Live.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Live.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Live.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.Live.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.Live.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.Live.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.Live.Location = new System.Drawing.Point(269, 286);
            this.Live.Name = "Live";
            this.Live.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.Live.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.Live.Size = new System.Drawing.Size(100, 35);
            this.Live.Style = Sunny.UI.UIStyle.White;
            this.Live.StyleCustomMode = true;
            this.Live.TabIndex = 42;
            this.Live.Text = "推流";
            this.Live.Click += new System.EventHandler(this.Live_Click);
            // 
            // AddVideoFiles
            // 
            this.AddVideoFiles.CircleRectWidth = 2;
            this.AddVideoFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddVideoFiles.FillColor = System.Drawing.Color.White;
            this.AddVideoFiles.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.AddVideoFiles.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.AddVideoFiles.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.AddVideoFiles.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AddVideoFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.AddVideoFiles.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.AddVideoFiles.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.AddVideoFiles.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.AddVideoFiles.IsCircle = true;
            this.AddVideoFiles.Location = new System.Drawing.Point(616, 17);
            this.AddVideoFiles.Name = "AddVideoFiles";
            this.AddVideoFiles.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.AddVideoFiles.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.AddVideoFiles.Size = new System.Drawing.Size(35, 35);
            this.AddVideoFiles.Style = Sunny.UI.UIStyle.White;
            this.AddVideoFiles.StyleCustomMode = true;
            this.AddVideoFiles.Symbol = 61716;
            this.AddVideoFiles.TabIndex = 46;
            this.AddVideoFiles.Click += new System.EventHandler(this.AddVideoFiles_Click);
            // 
            // RTMP
            // 
            this.RTMP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTMP.FillColor = System.Drawing.Color.White;
            this.RTMP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RTMP.Location = new System.Drawing.Point(115, 83);
            this.RTMP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RTMP.Maximum = 2147483647D;
            this.RTMP.Minimum = -2147483648D;
            this.RTMP.Name = "RTMP";
            this.RTMP.Padding = new System.Windows.Forms.Padding(5);
            this.RTMP.Size = new System.Drawing.Size(494, 29);
            this.RTMP.TabIndex = 44;
            this.RTMP.Watermark = "请输入";
            // 
            // LiveCode
            // 
            this.LiveCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LiveCode.FillColor = System.Drawing.Color.White;
            this.LiveCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LiveCode.Location = new System.Drawing.Point(115, 146);
            this.LiveCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LiveCode.Maximum = 2147483647D;
            this.LiveCode.Minimum = -2147483648D;
            this.LiveCode.Name = "LiveCode";
            this.LiveCode.Padding = new System.Windows.Forms.Padding(5);
            this.LiveCode.Size = new System.Drawing.Size(494, 29);
            this.LiveCode.TabIndex = 45;
            this.LiveCode.Watermark = "请输入";
            // 
            // VideoFile
            // 
            this.VideoFile.AllowDrop = true;
            this.VideoFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VideoFile.FillColor = System.Drawing.Color.White;
            this.VideoFile.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.VideoFile.Location = new System.Drawing.Point(115, 20);
            this.VideoFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VideoFile.Maximum = 2147483647D;
            this.VideoFile.Minimum = -2147483648D;
            this.VideoFile.Name = "VideoFile";
            this.VideoFile.Padding = new System.Windows.Forms.Padding(5);
            this.VideoFile.ReadOnly = true;
            this.VideoFile.Size = new System.Drawing.Size(494, 29);
            this.VideoFile.TabIndex = 43;
            this.VideoFile.Text = "请输入视频文件";
            this.VideoFile.Watermark = "";
            this.VideoFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideoFile_DragDrop);
            this.VideoFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.VideoFile_DragEnter);
            // 
            // ffmpeg_Live
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 413);
            this.Name = "ffmpeg_Live";
            this.Text = "直播推流";
            this.Load += new System.EventHandler(this.ffmpeg_Live_Load);
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIComboBox AudioMode;
        private Sunny.UI.UITextBox AudioBox;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIButton Live;
        private Sunny.UI.UISymbolButton AddVideoFiles;
        private Sunny.UI.UITextBox RTMP;
        private Sunny.UI.UITextBox LiveCode;
        private Sunny.UI.UITextBox VideoFile;
    }
}