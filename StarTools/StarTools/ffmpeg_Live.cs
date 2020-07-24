using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoBox
{
    public partial class ffmpeg_Live : Form
    {
        private void ffmpeg_Live_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            AudioBox.Hide();
            label7.Hide();
            label8.Show();
            AudioBox.Text = "192";
        }

        public ffmpeg_Live()
        {
            InitializeComponent();
        }

        private void OpenVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a video file",
                Filter = "All video files (*.mp4;*.mkv;*.flv;*.m2ts;*.ts)|*.mp4;*.mkv;*.flv;*.m2ts;*.ts",
                Title = "Open video file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    VideoFile.Text = openFileDialog1.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void Live_Click(object sender, EventArgs e)
        {
            if (VideoFile.Text == "")
            {
                MessageBox.Show("请放入源文件!");
                return;
            }

            if (RTMP.Text == "")
            {
                MessageBox.Show("请输入RTMP地址!");
                return;
            }

            if (LiveCode.Text == "")
            {
                MessageBox.Show("请输入直播码!");
                return;
            }

            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.RedirectStandardError = false;
            p.StartInfo.CreateNoWindow = false;

            p.Start();
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    p.StandardInput.WriteLine("tool\\ffmpeg\\ffmpeg.exe -re -i \"" + VideoFile.Text +
                                              "\" -vcodec copy -acodec copy -f flv \"" + RTMP.Text + LiveCode.Text +
                                              "\"");
                    break;
                case 1:
                    p.StandardInput.WriteLine("tool\\ffmpeg\\ffmpeg.exe -re -i \"" + VideoFile.Text +
                                              "\" -vcodec copy -acodec aac -b:a " + AudioBox.Text + "k -f flv \"" +
                                              RTMP.Text + LiveCode.Text +
                                              "\"");
                    break;
            }
        }

        private void Backout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    AudioBox.Hide();
                    label7.Hide();
                    label8.Show();
                    break;
                case 1:
                    AudioBox.Show();
                    label7.Show();
                    label8.Hide();
                    break;
            }
        }
    }
}
