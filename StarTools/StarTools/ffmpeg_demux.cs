using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
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
            VideoFile.Text = FileDo.GetVideoFile("请输入视频文件");
        }

        private void VideoFile_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void VideoFile_DragDrop(object sender, DragEventArgs e)
        {
            VideoFile.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void VideoFile_TextChanged(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            Rawslist.Items.Clear();
            var p = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };
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
            OutputFile.Text = FileDo.GetSaveFiles("mp4");
        }

        private void demux_Click(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            if (File.Exists(OutputFile.Text))
                if (Page.ShowAskDialog("文件已存在，确认覆盖？"))
                    File.Delete(OutputFile.Text);
                else
                    return;
            var p = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    CreateNoWindow = false
                }
            };
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
            if (Rawslist.SelectedIndex == -1) return;
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