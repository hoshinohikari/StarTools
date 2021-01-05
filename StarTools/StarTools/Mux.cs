using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Sunny.UI;

namespace StarTools
{
    public partial class Mux : UITitlePage
    {
        public Mux()
        {
            InitializeComponent();
        }

        private void AddVideoFiles_Click(object sender, EventArgs e)
        {
            VideoFile.Text = FileDo.GetVideoFile("请输入视频文件");
        }

        private void mkvAddVideoFiles_Click(object sender, EventArgs e)
        {
            mkvVideoFile.Text = FileDo.GetVideoFile("请输入视频文件");
        }

        private void mp4AudioAdd_Click(object sender, EventArgs e)
        {
            foreach (var i in FileDo.GetAudioFiles()) AudioList.Items.Add(i);
        }

        private void mkvAudioAdd_Click(object sender, EventArgs e)
        {
            foreach (var i in FileDo.GetAudioFiles()) mkvAudioList.Items.Add(i);
        }

        private void mkvOthersAdd_Click(object sender, EventArgs e)
        {
            foreach (var i in FileDo.GetAudioFiles()) mkvOthersList.Items.Add(i);
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            OutputFile.Text = FileDo.GetSaveFiles("mp4");
        }

        private void mkvSaveFile_Click(object sender, EventArgs e)
        {
            mkvOutputFile.Text = FileDo.GetSaveFiles("mkv");
        }

        private void VideoFile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OutputFile.Text =
                    VideoFile.Text.Substring(0, VideoFile.Text.LastIndexOf(".", StringComparison.Ordinal)) +
                    @"_mux.mp4";
                AudioList.Items.Clear();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void mkvVideoFile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mkvOutputFile.Text =
                    mkvVideoFile.Text.Substring(0, mkvVideoFile.Text.LastIndexOf(".", StringComparison.Ordinal)) +
                    @"_mux.mkv";
                mkvAudioList.Items.Clear();
                mkvOthersList.Items.Clear();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void File_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void VideoFile_DragDrop(object sender, DragEventArgs e)
        {
            VideoFile.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void mkvVideoFile_DragDrop(object sender, DragEventArgs e)
        {
            mkvVideoFile.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void AudioList_DragDrop(object sender, DragEventArgs e)
        {
            var fileNames = (string[]) e.Data.GetData(DataFormats.FileDrop);
            foreach (var t in fileNames)
                AudioList.Items.Add(t);
        }

        private void mkvAudioList_DragDrop(object sender, DragEventArgs e)
        {
            var fileNames = (string[]) e.Data.GetData(DataFormats.FileDrop);
            foreach (var t in fileNames)
                mkvAudioList.Items.Add(t);
        }

        private void mkvOthersList_DragDrop(object sender, DragEventArgs e)
        {
            var fileNames = (string[]) e.Data.GetData(DataFormats.FileDrop);
            foreach (var t in fileNames)
                mkvOthersList.Items.Add(t);
        }

        private void mp4AudioDel_Click(object sender, EventArgs e)
        {
            if (AudioList.SelectedIndex != -1)
                AudioList.Items.RemoveAt(AudioList.SelectedIndex);
        }

        private void mkvAudioDel_Click(object sender, EventArgs e)
        {
            if (mkvAudioList.SelectedIndex != -1)
                mkvAudioList.Items.RemoveAt(mkvAudioList.SelectedIndex);
        }

        private void mkvOthersDel_Click(object sender, EventArgs e)
        {
            if (mkvOthersList.SelectedIndex != -1)
                mkvOthersList.Items.RemoveAt(mkvOthersList.SelectedIndex);
        }

        private void mp4mux_Click(object sender, EventArgs e)
        {
            if (OutputFile.Text == "")
            {
                this.ShowErrorDialog(@"请填写输出文件!");
                return;
            }

            var appSettings = ConfigurationManager.AppSettings;
            var cmdLine = appSettings["MP4Box_file"] + " -add \"" + VideoFile.Text + "\"";
            cmdLine = AudioList.Items.Cast<object>().Aggregate(cmdLine, (current, i) => current + (" -add \"" + i + "\""));
            cmdLine += " -new \"" + OutputFile.Text + "\"";
            File.Delete(OutputFile.Text);
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
            p.StandardInput.WriteLine(cmdLine);
        }

        private void mkvmux_Click(object sender, EventArgs e)
        {
            var index = 0;
            var tem = "";
            if (mkvOutputFile.Text == "")
            {
                this.ShowErrorDialog(@"请填写输出文件!");
                return;
            }

            var appSettings = ConfigurationManager.AppSettings;
            var cmdLine = appSettings["mkvmerge_file"] + " -o \"" + mkvOutputFile.Text + "\"";
            cmdLine += " \"" + mkvVideoFile.Text + "\"";
            //cmdLine = mkvAudioList.Items.Cast<object>().Aggregate(cmdLine, (current, i) => current + (" \"" + i + "\""));
            foreach (var i in mkvAudioList.Items)
            {
                tem = i.ToString().Substring(i.ToString().LastIndexOf('\\') + 1,
                    i.ToString().LastIndexOf('.') - i.ToString().LastIndexOf('\\') - 1);
                cmdLine += " --track-name 0:\"" + tem + "\" \"" + i + "\"";
            }
            cmdLine = mkvOthersList.Items.Cast<object>().Aggregate(cmdLine, (current, i) => current + (" --attach-file \"" + i + "\""));
            File.Delete(mkvOutputFile.Text);
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
            p.StandardInput.WriteLine(cmdLine);
        }
    }
}