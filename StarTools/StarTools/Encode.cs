using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security;
using System.Windows.Forms;
using Sunny.UI;

namespace StarTools
{
    public partial class Encode : UITitlePage
    {
        public Encode()
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

        private void Encode_Load(object sender, EventArgs e)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                var openWith = new Dictionary<string, int>
                {
                    {"0", 0},
                    {"1", 1},
                    {"2", 2}
                };

                if (appSettings["EncoderBox_selected"] == null)
                {
                    AddUpdateAppSettings("EncoderBox_selected", "0");
                    EncoderBox.SelectedIndex = 0;
                }
                else
                {
                    EncoderBox.SelectedIndex = openWith[appSettings["EncoderBox_selected"]];
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine(@"Error reading app settings");
            }
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

        private void AddAssFiles_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a ass file",
                Filter = @"Ass files (*.ass)|*.ass",
                Title = @"Open ass file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    AssFile.Text = openFileDialog1.FileName;
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

        private void VideoFile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OutputFile.Text =
                    VideoFile.Text.Substring(0, VideoFile.Text.LastIndexOf(".", StringComparison.Ordinal)) +
                    @"_rip.mp4";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void AssFile_DragDrop(object sender, DragEventArgs e)
        {
            AssFile.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void File_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void VideoFile_DragDrop(object sender, DragEventArgs e)
        {
            VideoFile.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void rip_Click(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            var encoderWith = new Dictionary<int, string>
            {
                {0, appSettings["QSVEnc_file"]},
                {1, appSettings["NVEnc_file"]},
                {2, appSettings["VCEEnc_file"]}
            };
            var audioWith = new Dictionary<string, string>
            {
                {"0", " --audio-copy"},
                {"1", " --audio-codec aac --audio-bitrate " + appSettings["Raws_audiobit"]}
            };

            if (VideoFile.Text == @"请输入视频文件")
            {
                this.ShowErrorDialog(@"请放入源文件!");
                return;
            }

            if (OutputFile.Text == "")
            {
                this.ShowErrorDialog(@"请填写输出文件!");
                return;
            }

            AddUpdateAppSettings("EncoderBox_selected", EncoderBox.SelectedIndex.ToString());
            string cmdLine;
            string argLine;
            if (AssFile.Text != @"请输入字幕文件")
            {
                string temp;
                temp = AssFile.Text;
                temp = temp.Replace("\\", "\\\\\\\\");
                temp = temp.Insert(temp.IndexOf(":", StringComparison.Ordinal), "\\\\");
                var ffmpegWith = new Dictionary<int, string>
                {
                    {0, appSettings["QSVEnc_file"]},
                    {1, appSettings["NVEnc_file"]},
                    {2, appSettings["VCEEnc_file"]}
                };

                if (EncoderBox.SelectedIndex == 1)
                {
                    cmdLine = appSettings["NVEnc_file"];
                    argLine = " --avhw -i \"" + VideoFile.Text +
                              "\" --audio-codec aac --vpp-subburn filename=\"" +
                              AssFile.Text + "\",charcode=utf-8,shaping=complex";
                }
                else
                {
                    cmdLine = appSettings["ffmpeg_file"];
                    argLine = " -y -i \"" + VideoFile.Text +
                              "\" -vf \"ass=" + temp +
                              "\" -codec:a copy -codec:v rawvideo -pix_fmt yuv420p -f nut - | " +
                              ffmpegWith[EncoderBox.SelectedIndex] + " --avsw -i -";
                }
            }
            else
            {
                cmdLine = encoderWith[EncoderBox.SelectedIndex];
                argLine = " --avhw -i \"" + VideoFile.Text +
                          "\"";
            }

            argLine = argLine + audioWith[appSettings["Raws_audiomode"]];

            try
            {
                var bitWith = new Dictionary<string, string>
                {
                    {
                        "1",
                        " --cqp " + appSettings["I"] + ":" + appSettings["P"] + ":" +
                        appSettings["B"]
                    },
                    {"2", " --cbr " + appSettings["CBR"]},
                    {"3", " --vbr " + appSettings["VBR"]}
                };
                argLine = argLine + bitWith[appSettings["Code_rate_control_mode_selection"]];
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            if (uiCheckBox1.Checked)
                argLine = argLine + " --interlace tff --vpp-deinterlace normal";

            if (uiCheckBox2.Checked)
                argLine = argLine + " --output-res " + WBox.Text + "x" + HBox.Text;

            if (appSettings["Code"] != null && appSettings["Code"] != "") argLine = argLine + appSettings["Code"];

            argLine = argLine + " -o \"" + OutputFile.Text + "\"";

            var f = new RunRip(cmdLine, argLine);
            f.ShowDialog();
            f.Dispose();
        }
    }
}