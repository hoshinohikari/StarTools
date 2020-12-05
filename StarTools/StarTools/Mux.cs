using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Security;
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
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a video file",
                Filter =
                    @"All video files (*.mp4;*.mkv;*.flv;*.m2ts;*.ts;*.264;*.h264;*.hevc)|*.mp4;*.mkv;*.flv;*.m2ts;*.ts;*.264;*.h264;*.hevc",
                Title = @"Open video file"
            };

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
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

        private void mkvAddVideoFiles_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a video file",
                Filter =
                    @"All video files (*.mp4;*.mkv;*.flv;*.m2ts;*.ts;*.264;*.h264;*.hevc)|*.mp4;*.mkv;*.flv;*.m2ts;*.ts;*.264;*.h264;*.hevc",
                Title = @"Open video file"
            };

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                mkvVideoFile.Text = openFileDialog1.FileName;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void mp4AudioAdd_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a audio file",
                Filter = @"Audio files (*.m4a)|*.m4a",
                Title = @"Open audio file",
                Multiselect = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    foreach (var i in openFileDialog1.FileNames) AudioList.Items.Add(i);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
        }

        private void mkvAudioAdd_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a audio file",
                Filter = @"Audio files (*.m4a)|*.m4a",
                Title = @"Open audio file",
                Multiselect = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    foreach (var i in openFileDialog1.FileNames) mkvAudioList.Items.Add(i);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
        }

        private void mkvOthersAdd_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a audio file",
                Filter = @"Audio files (*.m4a)|*.m4a",
                Title = @"Open audio file",
                Multiselect = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    foreach (var i in openFileDialog1.FileNames) mkvOthersList.Items.Add(i);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
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

        private void mkvSaveFile_Click(object sender, EventArgs e)
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
                    mkvOutputFile.Text = filePath;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
        }

        private void VideoFile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OutputFile.Text =
                    VideoFile.Text.Substring(0, VideoFile.Text.LastIndexOf(".", StringComparison.Ordinal)) +
                    @"_mux.mp4";
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
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
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
            foreach (var i in AudioList.Items) cmdLine += " -add \"" + i + "\"";
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

        private void VideoFile_DragDrop(object sender, DragEventArgs e)
        {
            VideoFile.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void File_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void AudioList_DragDrop(object sender, DragEventArgs e)
        {
            var fileNames = (string[]) e.Data.GetData(DataFormats.FileDrop);
            foreach (var t in fileNames)
                AudioList.Items.Add(t);
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

        private void mkvVideoFile_DragDrop(object sender, DragEventArgs e)
        {
            mkvVideoFile.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
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

        private void mkvmux_Click(object sender, EventArgs e)
        {
            if (OutputFile.Text == "")
            {
                this.ShowErrorDialog(@"请填写输出文件!");
                return;
            }

            var appSettings = ConfigurationManager.AppSettings;
            var cmdLine = appSettings["mkvmerge_file"] + " -o \"" + mkvOutputFile.Text + "\"";
            foreach (var i in mkvAudioList.Items) cmdLine += " \"" + i + "\"";
            foreach (var i in mkvOthersList.Items) cmdLine += " --attach-file \"" + i + "\"";
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
    }
}