using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Windows.Forms;
using Sunny.UI;

namespace StarTools
{
    public partial class ffmpeg_demux : UITitlePage
    {
        private string _trackNum, _trackKinds;

        public ffmpeg_demux()
        {
            InitializeComponent();
        }

        private void AddVideoFiles_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a video file",
                Filter = @"All video files (*.mp4;*.mkv;*.flv;*.m2ts;*.ts)|*.mp4;*.mkv;*.flv;*.m2ts;*.ts",
                Title = @"Open video file"
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
            var reader = p.StandardError;
            var curLine = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                if (!string.IsNullOrEmpty(curLine))
                    if (curLine.Contains("Stream #") &&
                        curLine[curLine.IndexOf("Stream #", StringComparison.Ordinal) - 2] == ' ')
                        Rawslist.Items.Add(curLine);
                curLine = reader.ReadLine();
            }

            reader.Close();
            p.WaitForExit();
            p.Close();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog
            {
                FileName = "Output",
                Filter = @"Mp4 files (*.mp4)|*.mp4",
                Title = @"Save a mp4 file"
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
            p.StandardInput.WriteLine(appSettings["ffmpeg_file"] + " -i \"" + VideoFile.Text + "\" -map " + _trackNum +
                                      " -codec copy \"" +
                                      OutputFile.Text + "\"");
        }

        private void Rawslist_ItemClick(object sender, EventArgs e)
        {
            var index = 0;
            var j = 0;
            var openWith = new Dictionary<string, string>
            {
                {"h26", ".h264"},
                {"aac", ".m4a"},
                {"ass", ".ass"},
                {"ala", ".m4a"},
                {"mp3", ".mp3"},
                {"pcm", ".wav"},
                {"fla", ".flac"},
                {"hev", ".hevc"}
                //TODO: 开放设置，可以手动选择
            };
            if (Rawslist.SelectedIndex != -1)
            {
                _trackNum = Rawslist.SelectedItem.ToString()
                    .Substring(Rawslist.SelectedItem.ToString().IndexOf("Stream #", StringComparison.Ordinal) + 8, 3);
                while (true)
                {
                    index = Rawslist.SelectedItem.ToString().IndexOf(":", index, StringComparison.Ordinal);
                    if (j == 2)
                        break;
                    index = Rawslist.SelectedItem.ToString().IndexOf(":", index + 1, StringComparison.Ordinal);

                    j++;
                }

                _trackKinds = Rawslist.SelectedItem.ToString().Substring(index + 2, 3);
                OutputFile.Text =
                    VideoFile.Text.Substring(0, VideoFile.Text.LastIndexOf(".", StringComparison.Ordinal)) +
                    @"_demux_" +
                    Rawslist.SelectedIndex +
                    openWith[_trackKinds];
            }
        }
    }
}