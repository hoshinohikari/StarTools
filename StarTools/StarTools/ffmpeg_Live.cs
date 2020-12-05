using System;
using System.Configuration;
using System.Diagnostics;
using System.Security;
using System.Windows.Forms;
using Sunny.UI;

namespace StarTools
{
    public partial class ffmpeg_Live : UITitlePage
    {
        public ffmpeg_Live()
        {
            InitializeComponent();
        }

        private static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                    settings.Add(key, value);
                else
                    settings[key].Value = value;
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine(@"Error writing app settings");
            }
        }

        private void ffmpeg_Live_Load(object sender, EventArgs e)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                if (appSettings["Live_audiomode"] == null)
                {
                    AddUpdateAppSettings("Live_audiomode", "0");
                    AudioMode.SelectedIndex = 0;
                }
                else
                {
                    switch (appSettings["Live_audiomode"])
                    {
                        case "0":
                            AudioMode.SelectedIndex = 0;
                            AudioBox.Hide();
                            uiLabel8.Hide();
                            uiLabel7.Show();
                            break;
                        case "1":
                            AudioMode.SelectedIndex = 1;
                            AudioBox.Show();
                            uiLabel8.Show();
                            uiLabel7.Hide();
                            break;
                    }
                }

                if (appSettings["Live_audiobit"] == null)
                {
                    AddUpdateAppSettings("Live_audiobit", "192");
                    AudioBox.Text = @"192";
                }
                else
                {
                    AudioBox.Text = appSettings["Live_audiobit"];
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine(@"Error reading app settings");
            }
        }

        private void AudioMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AudioMode.SelectedIndex)
            {
                case 0:
                    AddUpdateAppSettings("Live_audiomode", "0");
                    AudioBox.Hide();
                    uiLabel8.Hide();
                    uiLabel7.Show();
                    break;
                case 1:
                    AddUpdateAppSettings("Live_audiomode", "1");
                    AudioBox.Show();
                    uiLabel8.Show();
                    uiLabel7.Hide();
                    break;
            }
        }

        private void AudioBox_TextChanged(object sender, EventArgs e)
        {
            AddUpdateAppSettings("Live_audiobit", AudioBox.Text);
        }

        private void VideoFile_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void VideoFile_DragDrop(object sender, DragEventArgs e)
        {
            VideoFile.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
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

        private void Live_Click(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            if (VideoFile.Text == @"请输入视频文件")
            {
                this.ShowErrorDialog(@"请放入源文件!");
                return;
            }

            if (RTMP.Text == "")
            {
                this.ShowErrorDialog(@"请输入RTMP地址!");
                return;
            }

            if (LiveCode.Text == "")
            {
                this.ShowErrorDialog(@"请输入直播码!");
                return;
            }

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
            switch (AudioMode.SelectedIndex)
            {
                case 0:
                    p.StandardInput.WriteLine(appSettings["ffmpeg_file"] + " -re -i \"" + VideoFile.Text +
                                              "\" -vcodec copy -acodec copy -f flv -flvflags no_duration_filesize \"" +
                                              RTMP.Text + LiveCode.Text +
                                              "\"");
                    break;
                case 1:
                    p.StandardInput.WriteLine(appSettings["ffmpeg_file"] + " -re -i \"" + VideoFile.Text +
                                              "\" -vcodec copy -acodec aac -b:a " + AudioBox.Text +
                                              "k -f flv -flvflags no_duration_filesize \"" +
                                              RTMP.Text + LiveCode.Text +
                                              "\"");
                    break;
            }
        }
    }
}