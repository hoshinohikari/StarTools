using System;
using System.Configuration;
using System.Diagnostics;
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
                        default:
                            ShowErrorDialog(@"正常情况看不到这个，出现该弹窗请带上复现方法到GitHub提issue");
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
                default:
                    ShowErrorDialog(@"正常情况看不到这个，出现该弹窗请带上复现方法到GitHub提issue");
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
            VideoFile.Text = FileDo.GetVideoFile("请输入视频文件");
        }

        private void Live_Click(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            if (VideoFile.Text == @"请输入视频文件")
            {
                ShowErrorDialog(@"请放入源文件!");
                return;
            }

            if (RTMP.Text == "")
            {
                ShowErrorDialog(@"请输入RTMP地址!");
                return;
            }

            if (LiveCode.Text == "")
            {
                ShowErrorDialog(@"请输入直播码!");
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
                default:
                    ShowErrorDialog(@"正常情况看不到这个，出现该弹窗请带上复现方法到GitHub提issue");
                    break;
            }
        }
    }
}