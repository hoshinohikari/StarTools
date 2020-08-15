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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ffmpeg_demux));
            this.OpenVideo = new System.Windows.Forms.Button();
            this.VideoFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Rawslist = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveFiles = new System.Windows.Forms.Button();
            this.OutputFile = new System.Windows.Forms.TextBox();
            this.Backout = new System.Windows.Forms.Button();
            this.demux = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenVideo
            // 
            this.OpenVideo.Location = new System.Drawing.Point(437, 25);
            this.OpenVideo.Name = "OpenVideo";
            this.OpenVideo.Size = new System.Drawing.Size(75, 21);
            this.OpenVideo.TabIndex = 18;
            this.OpenVideo.Text = "打开";
            this.OpenVideo.UseVisualStyleBackColor = true;
            this.OpenVideo.Click += new System.EventHandler(this.OpenVideo_Click);
            // 
            // VideoFile
            // 
            this.VideoFile.AllowDrop = true;
            this.VideoFile.Location = new System.Drawing.Point(92, 25);
            this.VideoFile.Name = "VideoFile";
            this.VideoFile.ReadOnly = true;
            this.VideoFile.Size = new System.Drawing.Size(339, 21);
            this.VideoFile.TabIndex = 17;
            this.VideoFile.TextChanged += new System.EventHandler(this.VideoFile_TextChanged);
            this.VideoFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideoFile_DragDrop);
            this.VideoFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.VideoFile_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "视频文件";
            // 
            // Rawslist
            // 
            this.Rawslist.FormattingEnabled = true;
            this.Rawslist.ItemHeight = 12;
            this.Rawslist.Location = new System.Drawing.Point(35, 52);
            this.Rawslist.Name = "Rawslist";
            this.Rawslist.Size = new System.Drawing.Size(477, 88);
            this.Rawslist.TabIndex = 19;
            this.Rawslist.SelectedIndexChanged += new System.EventHandler(this.Rawslist_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "输出";
            // 
            // SaveFiles
            // 
            this.SaveFiles.Location = new System.Drawing.Point(437, 145);
            this.SaveFiles.Name = "SaveFiles";
            this.SaveFiles.Size = new System.Drawing.Size(75, 21);
            this.SaveFiles.TabIndex = 21;
            this.SaveFiles.Text = "保存";
            this.SaveFiles.UseVisualStyleBackColor = true;
            this.SaveFiles.Click += new System.EventHandler(this.SaveFiles_Click);
            // 
            // OutputFile
            // 
            this.OutputFile.Location = new System.Drawing.Point(92, 146);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(339, 21);
            this.OutputFile.TabIndex = 20;
            // 
            // Backout
            // 
            this.Backout.Location = new System.Drawing.Point(376, 190);
            this.Backout.Name = "Backout";
            this.Backout.Size = new System.Drawing.Size(75, 21);
            this.Backout.TabIndex = 24;
            this.Backout.Text = "退出";
            this.Backout.UseVisualStyleBackColor = true;
            this.Backout.Click += new System.EventHandler(this.Backout_Click);
            // 
            // demux
            // 
            this.demux.Location = new System.Drawing.Point(92, 190);
            this.demux.Name = "demux";
            this.demux.Size = new System.Drawing.Size(75, 21);
            this.demux.TabIndex = 23;
            this.demux.Text = "分离";
            this.demux.UseVisualStyleBackColor = true;
            this.demux.Click += new System.EventHandler(this.demux_Click);
            // 
            // ffmpeg_demux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 242);
            this.Controls.Add(this.Backout);
            this.Controls.Add(this.demux);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveFiles);
            this.Controls.Add(this.OutputFile);
            this.Controls.Add(this.Rawslist);
            this.Controls.Add(this.OpenVideo);
            this.Controls.Add(this.VideoFile);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ffmpeg_demux";
            this.Text = "ffmpeg_demux";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenVideo;
        private System.Windows.Forms.TextBox VideoFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Rawslist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveFiles;
        private System.Windows.Forms.TextBox OutputFile;
        private System.Windows.Forms.Button Backout;
        private System.Windows.Forms.Button demux;
    }
}