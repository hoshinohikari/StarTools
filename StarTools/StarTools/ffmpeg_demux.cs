using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace StarTools
{
    public partial class ffmpeg_demux : Form
    {
        private string track_num, track_kinds;

        public ffmpeg_demux()
        {
            InitializeComponent();
        }

        private void OpenVideo_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a video file",
                Filter = "All video files (*.mp4;*.mkv;*.flv;*.m2ts;*.ts)|*.mp4;*.mkv;*.flv;*.m2ts;*.ts",
                Title = "Open video file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
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

        private void VideoFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void VideoFile_DragDrop(object sender, DragEventArgs e)
        {
            VideoFile.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void VideoFile_TextChanged(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            Rawslist.Items.Clear();
            var p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(appSettings["ffmpeg_file"] + " -i \"" + VideoFile.Text + "\"");
            p.StandardInput.AutoFlush = true;
            p.StandardInput.WriteLine("exit");
            //p.StandardInput.WriteLine("exit");
            var reader = p.StandardError;
            var curLine = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                if (!string.IsNullOrEmpty(curLine))
                    if (curLine.Contains("Stream #") && curLine[curLine.IndexOf("Stream #") - 2] == ' ')
                        Rawslist.Items.Add(curLine);
                curLine = reader.ReadLine();
            }

            reader.Close();
            p.WaitForExit();
            p.Close();
        }

        private void SaveFiles_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog()
            {
                FileName = "Output",
                Filter = "Mp4 files (*.mp4)|*.mp4",
                Title = "Save a mp4 file"
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    var filePath = saveFileDialog1.FileName;
                    OutputFile.Text = filePath;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
        }

        private void Rawslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            var openWith = new Dictionary<string, string>();
            openWith.Add("h26", ".h264");
            openWith.Add("aac", ".m4a");
            openWith.Add("ass", ".ass");
            openWith.Add("ala", ".m4a");
            openWith.Add("mp3", ".mp3");
            openWith.Add("pcm", ".wav");
            openWith.Add("fla", ".flac");
            openWith.Add("hev", ".hevc");
            if (Rawslist.SelectedIndex != -1)
            {
                track_num = Rawslist.SelectedItem.ToString()
                    .Substring(Rawslist.SelectedItem.ToString().IndexOf("Stream #") + 8, 3);
                track_kinds = Rawslist.SelectedItem.ToString()
                    .Substring(Rawslist.SelectedItem.ToString().IndexOf(":", 22) + 2, 3);
                OutputFile.Text = VideoFile.Text.Substring(0, VideoFile.Text.LastIndexOf(".")) + "_demux_" +
                                  Rawslist.SelectedIndex +
                                  openWith[track_kinds];
            }
        }

        private void demux_Click(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            File.Delete(OutputFile.Text);
            var p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.RedirectStandardError = false;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            p.StandardInput.WriteLine(appSettings["ffmpeg_file"] + " -i \"" + VideoFile.Text + "\" -map " + track_num +
                                      " -codec copy \"" +
                                      OutputFile.Text + "\"");
        }

        private void Backout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
