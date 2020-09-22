namespace StarTools
{
    partial class Encode
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
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.VideoFile = new Sunny.UI.UITextBox();
            this.AssFile = new Sunny.UI.UITextBox();
            this.OutputFile = new Sunny.UI.UITextBox();
            this.AddVideoFiles = new Sunny.UI.UISymbolButton();
            this.SaveFile = new Sunny.UI.UISymbolButton();
            this.AddAssFiles = new Sunny.UI.UISymbolButton();
            this.rip = new Sunny.UI.UIButton();
            this.EncoderBox = new Sunny.UI.UIComboBox();
            this.HBox = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.WBox = new Sunny.UI.UITextBox();
            this.uiCheckBox2 = new Sunny.UI.UICheckBox();
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.HBox);
            this.PagePanel.Controls.Add(this.uiLabel5);
            this.PagePanel.Controls.Add(this.WBox);
            this.PagePanel.Controls.Add(this.uiCheckBox2);
            this.PagePanel.Controls.Add(this.uiCheckBox1);
            this.PagePanel.Controls.Add(this.EncoderBox);
            this.PagePanel.Controls.Add(this.rip);
            this.PagePanel.Controls.Add(this.AddAssFiles);
            this.PagePanel.Controls.Add(this.SaveFile);
            this.PagePanel.Controls.Add(this.AddVideoFiles);
            this.PagePanel.Controls.Add(this.AssFile);
            this.PagePanel.Controls.Add(this.OutputFile);
            this.PagePanel.Controls.Add(this.VideoFile);
            this.PagePanel.Controls.Add(this.uiLabel4);
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Size = new System.Drawing.Size(658, 378);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(26, 36);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(77, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "视频文件";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(26, 99);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(77, 23);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "字幕文件";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(40, 162);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(44, 23);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "输出";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(18, 225);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(91, 23);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "选择编码器";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VideoFile
            // 
            this.VideoFile.AllowDrop = true;
            this.VideoFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VideoFile.FillColor = System.Drawing.Color.White;
            this.VideoFile.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.VideoFile.Location = new System.Drawing.Point(110, 33);
            this.VideoFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VideoFile.Maximum = 2147483647D;
            this.VideoFile.Minimum = -2147483648D;
            this.VideoFile.Name = "VideoFile";
            this.VideoFile.Padding = new System.Windows.Forms.Padding(5);
            this.VideoFile.ReadOnly = true;
            this.VideoFile.Size = new System.Drawing.Size(494, 29);
            this.VideoFile.TabIndex = 4;
            this.VideoFile.Text = "请输入视频文件";
            this.VideoFile.Watermark = "";
            this.VideoFile.TextChanged += new System.EventHandler(this.VideoFile_TextChanged);
            this.VideoFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideoFile_DragDrop);
            this.VideoFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_DragEnter);
            // 
            // AssFile
            // 
            this.AssFile.AllowDrop = true;
            this.AssFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AssFile.FillColor = System.Drawing.Color.White;
            this.AssFile.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AssFile.Location = new System.Drawing.Point(110, 96);
            this.AssFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AssFile.Maximum = 2147483647D;
            this.AssFile.Minimum = -2147483648D;
            this.AssFile.Name = "AssFile";
            this.AssFile.Padding = new System.Windows.Forms.Padding(5);
            this.AssFile.ReadOnly = true;
            this.AssFile.Size = new System.Drawing.Size(494, 29);
            this.AssFile.TabIndex = 5;
            this.AssFile.Text = "请输入字幕文件";
            this.AssFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.AssFile_DragDrop);
            this.AssFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_DragEnter);
            // 
            // OutputFile
            // 
            this.OutputFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputFile.FillColor = System.Drawing.Color.White;
            this.OutputFile.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.OutputFile.Location = new System.Drawing.Point(110, 159);
            this.OutputFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutputFile.Maximum = 2147483647D;
            this.OutputFile.Minimum = -2147483648D;
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Padding = new System.Windows.Forms.Padding(5);
            this.OutputFile.ReadOnly = true;
            this.OutputFile.Size = new System.Drawing.Size(494, 29);
            this.OutputFile.TabIndex = 5;
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
            this.AddVideoFiles.Location = new System.Drawing.Point(611, 30);
            this.AddVideoFiles.Name = "AddVideoFiles";
            this.AddVideoFiles.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.AddVideoFiles.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.AddVideoFiles.Size = new System.Drawing.Size(35, 35);
            this.AddVideoFiles.Style = Sunny.UI.UIStyle.White;
            this.AddVideoFiles.StyleCustomMode = true;
            this.AddVideoFiles.Symbol = 61716;
            this.AddVideoFiles.TabIndex = 27;
            this.AddVideoFiles.Click += new System.EventHandler(this.AddVideoFiles_Click);
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
            this.SaveFile.Location = new System.Drawing.Point(611, 156);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.SaveFile.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.SaveFile.Size = new System.Drawing.Size(35, 35);
            this.SaveFile.Style = Sunny.UI.UIStyle.White;
            this.SaveFile.StyleCustomMode = true;
            this.SaveFile.Symbol = 61716;
            this.SaveFile.TabIndex = 29;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // AddAssFiles
            // 
            this.AddAssFiles.CircleRectWidth = 2;
            this.AddAssFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAssFiles.FillColor = System.Drawing.Color.White;
            this.AddAssFiles.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.AddAssFiles.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.AddAssFiles.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.AddAssFiles.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AddAssFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.AddAssFiles.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.AddAssFiles.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.AddAssFiles.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.AddAssFiles.IsCircle = true;
            this.AddAssFiles.Location = new System.Drawing.Point(611, 93);
            this.AddAssFiles.Name = "AddAssFiles";
            this.AddAssFiles.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.AddAssFiles.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.AddAssFiles.Size = new System.Drawing.Size(35, 35);
            this.AddAssFiles.Style = Sunny.UI.UIStyle.White;
            this.AddAssFiles.StyleCustomMode = true;
            this.AddAssFiles.Symbol = 61716;
            this.AddAssFiles.TabIndex = 30;
            this.AddAssFiles.Click += new System.EventHandler(this.AddAssFiles_Click);
            // 
            // rip
            // 
            this.rip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rip.FillColor = System.Drawing.Color.White;
            this.rip.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.rip.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.rip.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.rip.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.rip.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.rip.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.rip.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.rip.Location = new System.Drawing.Point(546, 287);
            this.rip.Name = "rip";
            this.rip.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.rip.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.rip.Size = new System.Drawing.Size(100, 35);
            this.rip.Style = Sunny.UI.UIStyle.White;
            this.rip.StyleCustomMode = true;
            this.rip.TabIndex = 31;
            this.rip.Text = "压制";
            this.rip.Click += new System.EventHandler(this.rip_Click);
            // 
            // EncoderBox
            // 
            this.EncoderBox.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.EncoderBox.FillColor = System.Drawing.Color.White;
            this.EncoderBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EncoderBox.Items.AddRange(new object[] {
            "QSVEnc（Intel显卡以及笔记本集显用）（推荐）（默认）",
            "NVEnc（nVidia显卡用）",
            "VCEEnc（AMD显卡以及笔记本集显用）"});
            this.EncoderBox.Location = new System.Drawing.Point(110, 222);
            this.EncoderBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EncoderBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.EncoderBox.Name = "EncoderBox";
            this.EncoderBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.EncoderBox.Size = new System.Drawing.Size(494, 29);
            this.EncoderBox.TabIndex = 32;
            this.EncoderBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HBox
            // 
            this.HBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HBox.FillColor = System.Drawing.Color.White;
            this.HBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.HBox.Location = new System.Drawing.Point(345, 287);
            this.HBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HBox.Maximum = 2147483647D;
            this.HBox.Minimum = -2147483648D;
            this.HBox.Name = "HBox";
            this.HBox.Padding = new System.Windows.Forms.Padding(5);
            this.HBox.Size = new System.Drawing.Size(65, 29);
            this.HBox.TabIndex = 36;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(321, 292);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(17, 23);
            this.uiLabel5.TabIndex = 37;
            this.uiLabel5.Text = "X";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WBox
            // 
            this.WBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WBox.FillColor = System.Drawing.Color.White;
            this.WBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.WBox.Location = new System.Drawing.Point(248, 287);
            this.WBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WBox.Maximum = 2147483647D;
            this.WBox.Minimum = -2147483648D;
            this.WBox.Name = "WBox";
            this.WBox.Padding = new System.Windows.Forms.Padding(5);
            this.WBox.Size = new System.Drawing.Size(65, 29);
            this.WBox.TabIndex = 35;
            // 
            // uiCheckBox2
            // 
            this.uiCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox2.Location = new System.Drawing.Point(147, 287);
            this.uiCheckBox2.Name = "uiCheckBox2";
            this.uiCheckBox2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox2.Size = new System.Drawing.Size(94, 29);
            this.uiCheckBox2.TabIndex = 34;
            this.uiCheckBox2.Text = "改变大小";
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox1.Location = new System.Drawing.Point(43, 287);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox1.Size = new System.Drawing.Size(79, 29);
            this.uiCheckBox1.TabIndex = 33;
            this.uiCheckBox1.Text = "反交错";
            // 
            // Encode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 413);
            this.Name = "Encode";
            this.Text = "编码";
            this.Load += new System.EventHandler(this.Encode_Load);
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox AssFile;
        private Sunny.UI.UITextBox OutputFile;
        private Sunny.UI.UITextBox VideoFile;
        private Sunny.UI.UISymbolButton AddAssFiles;
        private Sunny.UI.UISymbolButton SaveFile;
        private Sunny.UI.UISymbolButton AddVideoFiles;
        private Sunny.UI.UIButton rip;
        private Sunny.UI.UIComboBox EncoderBox;
        private Sunny.UI.UITextBox HBox;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox WBox;
        private Sunny.UI.UICheckBox uiCheckBox2;
        private Sunny.UI.UICheckBox uiCheckBox1;
    }
}