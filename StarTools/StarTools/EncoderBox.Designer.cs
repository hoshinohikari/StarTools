namespace StarTools
{
    partial class EncoderBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncoderBox));
            this.uiRadioButtonGroup1 = new Sunny.UI.UIRadioButtonGroup();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.VBRBox = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.CBRBox = new Sunny.UI.UITextBox();
            this.BBox = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.PBox = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.IBox = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiRadioButton3 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton2 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton1 = new Sunny.UI.UIRadioButton();
            this.Save = new Sunny.UI.UIButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.AudioMode = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.AudioBox = new Sunny.UI.UITextBox();
            this.PagePanel.SuspendLayout();
            this.uiRadioButtonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiLabel7);
            this.PagePanel.Controls.Add(this.uiLabel8);
            this.PagePanel.Controls.Add(this.AudioMode);
            this.PagePanel.Controls.Add(this.AudioBox);
            this.PagePanel.Controls.Add(this.uiLabel6);
            this.PagePanel.Controls.Add(this.Save);
            this.PagePanel.Controls.Add(this.uiRadioButtonGroup1);
            this.PagePanel.Size = new System.Drawing.Size(658, 378);
            // 
            // uiRadioButtonGroup1
            // 
            this.uiRadioButtonGroup1.Controls.Add(this.uiLabel5);
            this.uiRadioButtonGroup1.Controls.Add(this.VBRBox);
            this.uiRadioButtonGroup1.Controls.Add(this.uiLabel4);
            this.uiRadioButtonGroup1.Controls.Add(this.CBRBox);
            this.uiRadioButtonGroup1.Controls.Add(this.BBox);
            this.uiRadioButtonGroup1.Controls.Add(this.uiLabel3);
            this.uiRadioButtonGroup1.Controls.Add(this.PBox);
            this.uiRadioButtonGroup1.Controls.Add(this.uiLabel2);
            this.uiRadioButtonGroup1.Controls.Add(this.IBox);
            this.uiRadioButtonGroup1.Controls.Add(this.uiLabel1);
            this.uiRadioButtonGroup1.Controls.Add(this.uiRadioButton3);
            this.uiRadioButtonGroup1.Controls.Add(this.uiRadioButton2);
            this.uiRadioButtonGroup1.Controls.Add(this.uiRadioButton1);
            this.uiRadioButtonGroup1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButtonGroup1.Location = new System.Drawing.Point(13, 8);
            this.uiRadioButtonGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup1.Name = "uiRadioButtonGroup1";
            this.uiRadioButtonGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup1.Size = new System.Drawing.Size(632, 264);
            this.uiRadioButtonGroup1.TabIndex = 0;
            this.uiRadioButtonGroup1.Text = "码率控制";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(125, 225);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(52, 23);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "kbps";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VBRBox
            // 
            this.VBRBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VBRBox.FillColor = System.Drawing.Color.White;
            this.VBRBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.VBRBox.Location = new System.Drawing.Point(44, 219);
            this.VBRBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VBRBox.Maximum = 2147483647D;
            this.VBRBox.Minimum = -2147483648D;
            this.VBRBox.Name = "VBRBox";
            this.VBRBox.Padding = new System.Windows.Forms.Padding(5);
            this.VBRBox.Size = new System.Drawing.Size(74, 29);
            this.VBRBox.TabIndex = 8;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(125, 151);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(52, 23);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "kbps";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBRBox
            // 
            this.CBRBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CBRBox.FillColor = System.Drawing.Color.White;
            this.CBRBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CBRBox.Location = new System.Drawing.Point(44, 145);
            this.CBRBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBRBox.Maximum = 2147483647D;
            this.CBRBox.Minimum = -2147483648D;
            this.CBRBox.Name = "CBRBox";
            this.CBRBox.Padding = new System.Windows.Forms.Padding(5);
            this.CBRBox.Size = new System.Drawing.Size(74, 29);
            this.CBRBox.TabIndex = 5;
            // 
            // BBox
            // 
            this.BBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BBox.FillColor = System.Drawing.Color.White;
            this.BBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.BBox.Location = new System.Drawing.Point(206, 71);
            this.BBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BBox.Maximum = 2147483647D;
            this.BBox.Minimum = -2147483648D;
            this.BBox.Name = "BBox";
            this.BBox.Padding = new System.Windows.Forms.Padding(5);
            this.BBox.Size = new System.Drawing.Size(44, 29);
            this.BBox.TabIndex = 6;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(181, 78);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(18, 23);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "B";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PBox
            // 
            this.PBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PBox.FillColor = System.Drawing.Color.White;
            this.PBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.PBox.Location = new System.Drawing.Point(125, 71);
            this.PBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PBox.Maximum = 2147483647D;
            this.PBox.Minimum = -2147483648D;
            this.PBox.Name = "PBox";
            this.PBox.Padding = new System.Windows.Forms.Padding(5);
            this.PBox.Size = new System.Drawing.Size(44, 29);
            this.PBox.TabIndex = 6;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(100, 78);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(18, 23);
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "P";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IBox
            // 
            this.IBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IBox.FillColor = System.Drawing.Color.White;
            this.IBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.IBox.Location = new System.Drawing.Point(44, 71);
            this.IBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IBox.Maximum = 2147483647D;
            this.IBox.Minimum = -2147483648D;
            this.IBox.Name = "IBox";
            this.IBox.Padding = new System.Windows.Forms.Padding(5);
            this.IBox.Size = new System.Drawing.Size(44, 29);
            this.IBox.TabIndex = 4;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(19, 78);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(18, 23);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "I";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiRadioButton3
            // 
            this.uiRadioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButton3.Location = new System.Drawing.Point(19, 177);
            this.uiRadioButton3.Name = "uiRadioButton3";
            this.uiRadioButton3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton3.Size = new System.Drawing.Size(150, 29);
            this.uiRadioButton3.TabIndex = 2;
            this.uiRadioButton3.Text = "vbr(可变比特率)";
            // 
            // uiRadioButton2
            // 
            this.uiRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButton2.Location = new System.Drawing.Point(19, 108);
            this.uiRadioButton2.Name = "uiRadioButton2";
            this.uiRadioButton2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton2.Size = new System.Drawing.Size(158, 29);
            this.uiRadioButton2.TabIndex = 1;
            this.uiRadioButton2.Text = "cbr(固定比特率)";
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRadioButton1.Location = new System.Drawing.Point(19, 36);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton1.Size = new System.Drawing.Size(610, 35);
            this.uiRadioButton1.TabIndex = 0;
            this.uiRadioButton1.Text = "cqp(默认模式，设置值越高文件越小，后面的值越低动态越不容易模糊)";
            // 
            // Save
            // 
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FillColor = System.Drawing.Color.White;
            this.Save.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Save.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Save.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Save.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.Save.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.Save.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.Save.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.Save.Location = new System.Drawing.Point(542, 309);
            this.Save.Name = "Save";
            this.Save.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.Save.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.Save.Size = new System.Drawing.Size(100, 35);
            this.Save.Style = Sunny.UI.UIStyle.White;
            this.Save.StyleCustomMode = true;
            this.Save.TabIndex = 32;
            this.Save.Text = "保存";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(32, 312);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(79, 23);
            this.uiLabel6.TabIndex = 10;
            this.uiLabel6.Text = "音频模式";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AudioMode
            // 
            this.AudioMode.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.AudioMode.FillColor = System.Drawing.Color.White;
            this.AudioMode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AudioMode.Items.AddRange(new object[] {
            "复制音频",
            "压制音频"});
            this.AudioMode.Location = new System.Drawing.Point(117, 309);
            this.AudioMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AudioMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.AudioMode.Name = "AudioMode";
            this.AudioMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.AudioMode.Size = new System.Drawing.Size(95, 29);
            this.AudioMode.TabIndex = 33;
            this.AudioMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.AudioMode.SelectedIndexChanged += new System.EventHandler(this.AudioMode_SelectedIndexChanged);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(219, 312);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(204, 23);
            this.uiLabel7.TabIndex = 34;
            this.uiLabel7.Text = "如报错请选择压制音频模式";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(301, 312);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(52, 23);
            this.uiLabel8.TabIndex = 36;
            this.uiLabel8.Text = "kbps";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AudioBox
            // 
            this.AudioBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AudioBox.FillColor = System.Drawing.Color.White;
            this.AudioBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AudioBox.Location = new System.Drawing.Point(220, 309);
            this.AudioBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AudioBox.Maximum = 2147483647D;
            this.AudioBox.Minimum = -2147483648D;
            this.AudioBox.Name = "AudioBox";
            this.AudioBox.Padding = new System.Windows.Forms.Padding(5);
            this.AudioBox.Size = new System.Drawing.Size(74, 29);
            this.AudioBox.TabIndex = 35;
            // 
            // EncoderBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 413);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncoderBox";
            this.Text = "码率控制";
            this.Load += new System.EventHandler(this.EncoderBox_Load);
            this.PagePanel.ResumeLayout(false);
            this.uiRadioButtonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup1;
        private Sunny.UI.UIRadioButton uiRadioButton3;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox BBox;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox PBox;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox IBox;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox CBRBox;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox VBRBox;
        private Sunny.UI.UIButton Save;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox AudioMode;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox AudioBox;
    }
}