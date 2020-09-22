namespace StarTools
{
    partial class ffmpeg_demux
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
            this.AddVideoFiles = new Sunny.UI.UISymbolButton();
            this.VideoFile = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SaveFile = new Sunny.UI.UISymbolButton();
            this.OutputFile = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.Rawslist = new Sunny.UI.UIListBox();
            this.demux = new Sunny.UI.UIButton();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.demux);
            this.PagePanel.Controls.Add(this.Rawslist);
            this.PagePanel.Controls.Add(this.SaveFile);
            this.PagePanel.Controls.Add(this.OutputFile);
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.AddVideoFiles);
            this.PagePanel.Controls.Add(this.VideoFile);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Size = new System.Drawing.Size(658, 378);
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
            this.AddVideoFiles.TabIndex = 49;
            this.AddVideoFiles.Click += new System.EventHandler(this.AddVideoFiles_Click);
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
            this.VideoFile.TabIndex = 48;
            this.VideoFile.Text = "请输入视频文件";
            this.VideoFile.Watermark = "";
            this.VideoFile.TextChanged += new System.EventHandler(this.VideoFile_TextChanged);
            this.VideoFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideoFile_DragDrop);
            this.VideoFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.VideoFile_DragEnter);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(12, 23);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 47;
            this.uiLabel1.Text = "视频文件";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveFile
            // 
            this.SaveFile.CircleRectWidth = 2;
            this.SaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveFile.FillColor = System.Drawing.Color.White;
            this.SaveFile.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.SaveFile.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.SaveFile.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.SaveFile.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.SaveFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.SaveFile.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.SaveFile.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.SaveFile.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.SaveFile.IsCircle = true;
            this.SaveFile.Location = new System.Drawing.Point(616, 244);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.SaveFile.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.SaveFile.Size = new System.Drawing.Size(35, 35);
            this.SaveFile.Style = Sunny.UI.UIStyle.White;
            this.SaveFile.StyleCustomMode = true;
            this.SaveFile.Symbol = 61716;
            this.SaveFile.TabIndex = 52;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // OutputFile
            // 
            this.OutputFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputFile.FillColor = System.Drawing.Color.White;
            this.OutputFile.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.OutputFile.Location = new System.Drawing.Point(115, 247);
            this.OutputFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutputFile.Maximum = 2147483647D;
            this.OutputFile.Minimum = -2147483648D;
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Padding = new System.Windows.Forms.Padding(5);
            this.OutputFile.ReadOnly = true;
            this.OutputFile.Size = new System.Drawing.Size(494, 29);
            this.OutputFile.TabIndex = 51;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(45, 250);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(44, 23);
            this.uiLabel3.TabIndex = 50;
            this.uiLabel3.Text = "输出";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rawslist
            // 
            this.Rawslist.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Rawslist.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Rawslist.Location = new System.Drawing.Point(49, 57);
            this.Rawslist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rawslist.Name = "Rawslist";
            this.Rawslist.Padding = new System.Windows.Forms.Padding(2);
            this.Rawslist.Size = new System.Drawing.Size(560, 180);
            this.Rawslist.TabIndex = 53;
            this.Rawslist.Text = "uiListBox1";
            this.Rawslist.ItemClick += new System.EventHandler(this.Rawslist_ItemClick);
            // 
            // demux
            // 
            this.demux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.demux.FillColor = System.Drawing.Color.White;
            this.demux.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.demux.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.demux.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.demux.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.demux.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.demux.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.demux.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.demux.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.demux.Location = new System.Drawing.Point(270, 284);
            this.demux.Name = "demux";
            this.demux.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.demux.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.demux.Size = new System.Drawing.Size(100, 35);
            this.demux.Style = Sunny.UI.UIStyle.White;
            this.demux.StyleCustomMode = true;
            this.demux.TabIndex = 54;
            this.demux.Text = "分离";
            this.demux.Click += new System.EventHandler(this.demux_Click);
            // 
            // ffmpeg_demux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 413);
            this.Name = "ffmpeg_demux";
            this.Text = "解封装";
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton AddVideoFiles;
        private Sunny.UI.UITextBox VideoFile;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIListBox Rawslist;
        private Sunny.UI.UISymbolButton SaveFile;
        private Sunny.UI.UITextBox OutputFile;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton demux;
    }
}