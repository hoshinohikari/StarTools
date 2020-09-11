namespace StarTools
{
    partial class needed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(needed));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ffmpeg_file = new System.Windows.Forms.TextBox();
            this.NVEnc_file = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.QSVEnc_file = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.VCEEnc_file = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Backout = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ffmpeg";
            // 
            // ffmpeg_file
            // 
            this.ffmpeg_file.AllowDrop = true;
            this.ffmpeg_file.Location = new System.Drawing.Point(59, 12);
            this.ffmpeg_file.Name = "ffmpeg_file";
            this.ffmpeg_file.Size = new System.Drawing.Size(433, 21);
            this.ffmpeg_file.TabIndex = 2;
            this.ffmpeg_file.DragDrop += new System.Windows.Forms.DragEventHandler(this.ffmpeg_file_DragDrop);
            this.ffmpeg_file.DragEnter += new System.Windows.Forms.DragEventHandler(this.file_DragEnter);
            // 
            // NVEnc_file
            // 
            this.NVEnc_file.AllowDrop = true;
            this.NVEnc_file.Location = new System.Drawing.Point(59, 50);
            this.NVEnc_file.Name = "NVEnc_file";
            this.NVEnc_file.Size = new System.Drawing.Size(433, 21);
            this.NVEnc_file.TabIndex = 5;
            this.NVEnc_file.DragDrop += new System.Windows.Forms.DragEventHandler(this.NVEnc_file_DragDrop);
            this.NVEnc_file.DragEnter += new System.Windows.Forms.DragEventHandler(this.file_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "NVEnc";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "浏览";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QSVEnc_file
            // 
            this.QSVEnc_file.AllowDrop = true;
            this.QSVEnc_file.Location = new System.Drawing.Point(59, 87);
            this.QSVEnc_file.Name = "QSVEnc_file";
            this.QSVEnc_file.Size = new System.Drawing.Size(433, 21);
            this.QSVEnc_file.TabIndex = 8;
            this.QSVEnc_file.DragDrop += new System.Windows.Forms.DragEventHandler(this.QSVEnc_file_DragDrop);
            this.QSVEnc_file.DragEnter += new System.Windows.Forms.DragEventHandler(this.file_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "QSVEnc";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(498, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "浏览";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VCEEnc_file
            // 
            this.VCEEnc_file.AllowDrop = true;
            this.VCEEnc_file.Location = new System.Drawing.Point(59, 124);
            this.VCEEnc_file.Name = "VCEEnc_file";
            this.VCEEnc_file.Size = new System.Drawing.Size(433, 21);
            this.VCEEnc_file.TabIndex = 11;
            this.VCEEnc_file.DragDrop += new System.Windows.Forms.DragEventHandler(this.VCEEnc_file_DragDrop);
            this.VCEEnc_file.DragEnter += new System.Windows.Forms.DragEventHandler(this.file_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "VCEEnc";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(498, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "浏览";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Backout
            // 
            this.Backout.Location = new System.Drawing.Point(355, 166);
            this.Backout.Name = "Backout";
            this.Backout.Size = new System.Drawing.Size(75, 21);
            this.Backout.TabIndex = 21;
            this.Backout.Text = "取消";
            this.Backout.UseVisualStyleBackColor = true;
            this.Backout.Click += new System.EventHandler(this.Backout_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(144, 166);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 21);
            this.Save.TabIndex = 20;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // needed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 206);
            this.Controls.Add(this.Backout);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.VCEEnc_file);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.QSVEnc_file);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NVEnc_file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ffmpeg_file);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "needed";
            this.Text = "依赖管理器";
            this.Load += new System.EventHandler(this.needed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ffmpeg_file;
        private System.Windows.Forms.TextBox NVEnc_file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox QSVEnc_file;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox VCEEnc_file;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Backout;
        private System.Windows.Forms.Button Save;
    }
}