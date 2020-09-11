using StarTools;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Security;
using System.Windows.Forms;

namespace VideoBox
{
    public partial class MainBox : Form
    {
        public MainBox()
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
                Console.WriteLine("Error writing app settings");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings["EncoderBox_selected"] == null)
                {
                    AddUpdateAppSettings("EncoderBox_selected", "0");
                    EncoderBox.SelectedIndex = 0;
                }
                else
                {
                    switch (appSettings["EncoderBox_selected"])
                    {
                        case "0":
                            EncoderBox.SelectedIndex = 0;
                            break;
                        case "1":
                            EncoderBox.SelectedIndex = 1;
                            break;
                        case "2":
                            EncoderBox.SelectedIndex = 2;
                            break;
                    }
                }

                if (appSettings["Raws_audiomode"] == null)
                {
                    AddUpdateAppSettings("Raws_audiomode", "0");
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    switch (appSettings["Raws_audiomode"])
                    {
                        case "0":
                            comboBox1.SelectedIndex = 0;
                            AudioBox.Hide();
                            label7.Hide();
                            label8.Show();
                            break;
                        case "1":
                            comboBox1.SelectedIndex = 1;
                            AudioBox.Show();
                            label7.Show();
                            label8.Hide();
                            break;
                    }
                }

                if (appSettings["Raws_audiobit"] == null)
                {
                    AddUpdateAppSettings("Raws_audiobit", "192");
                    AudioBox.Text = "192";
                }
                else
                {
                    AudioBox.Text = appSettings["Raws_audiobit"];
                }

                if (appSettings["ffmpeg_file"] == null)
                    AddUpdateAppSettings("ffmpeg_file", "tool\\ffmpeg\\ffmpeg.exe");

                if (appSettings["NVEnc_file"] == null)
                    AddUpdateAppSettings("NVEnc_file", "tool\\HardEnc\\NVEncC64.exe");

                if (appSettings["QSVEnc_file"] == null)
                    AddUpdateAppSettings("QSVEnc_file", "tool\\HardEnc\\QSVEncC64.exe");

                if (appSettings["VCEEnc_file"] == null)
                    AddUpdateAppSettings("VCEEnc_file", "tool\\HardEnc\\VCEEncC64.exe");

                wBox.Text = "1280";
                hBox.Text = "720";
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        private void AddFiles1_Click(object sender, EventArgs e)
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

        private void AddFiles2_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a ass file",
                Filter = "Ass files (*.ass)|*.ass",
                Title = "Open ass file"
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

        private void rip_Click(object sender, EventArgs e)
        {
            var p = new Process();
            var cmdLine = "";
            var appSettings = ConfigurationManager.AppSettings;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.RedirectStandardError = false;
            p.StartInfo.CreateNoWindow = false;

            if (VideoFile.Text == "")
            {
                MessageBox.Show("请放入源文件!");
                return;
            }

            if (OutputFile.Text == "")
            {
                MessageBox.Show("请填写输出文件!");
                return;
            }

            if (AssFile.Text != "")
            {
                string temp;
                temp = AssFile.Text;
                temp = temp.Replace("\\", "\\\\\\\\");
                temp = temp.Insert(temp.IndexOf(":"), "\\\\");
                if (EncoderBox.SelectedIndex == 1)
                    cmdLine = appSettings["NVEnc_file"] + " --avhw -i \"" + VideoFile.Text +
                              "\" --audio-codec aac --vpp-subburn filename=\"" +
                              AssFile.Text + "\"";
                else
                    switch (EncoderBox.SelectedIndex)
                    {
                        case 0:
                            cmdLine = appSettings["ffmpeg_file"] + " -y -i \"" + VideoFile.Text +
                                      "\" -vf \"ass=" + temp +
                                      "\" -codec:a copy -codec:v rawvideo -pix_fmt yuv420p -f nut - | " +
                                      appSettings["QSVEnc_file"] + " --avsw -i -";
                            break;
                        case 1:
                            MessageBox.Show("Error!");
                            break;
                        case 2:
                            cmdLine = appSettings["ffmpeg_file"] + " -y -i \"" + VideoFile.Text +
                                      "\" -vf \"ass=" + temp +
                                      "\" -codec:a copy -codec:v rawvideo -pix_fmt yuv420p -f nut - | " +
                                      appSettings["VCEEnc_file"] + " --avsw -i -";
                            break;
                        case 3:
                            break;
                        default:
                            MessageBox.Show("Error!");
                            break;
                    }
            }
            else
            {
                switch (EncoderBox.SelectedIndex)
                {
                    case 0:
                        cmdLine = appSettings["QSVEnc_file"] + " --avhw -i \"" + VideoFile.Text +
                                  "\"";
                        break;
                    case 1:
                        cmdLine = appSettings["NVEnc_file"] + " --avhw -i \"" + VideoFile.Text +
                                  "\"";
                        break;
                    case 2:
                        cmdLine = appSettings["VCEEnc_file"] + " --avhw -i \"" + VideoFile.Text +
                                  "\"";
                        break;
                    case 3:
                        break;
                    default:
                        MessageBox.Show("Error!");
                        break;
                }
            }

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    cmdLine = cmdLine + " --audio-copy";
                    break;
                case 1:
                    cmdLine = cmdLine + " --audio-codec aac --audio-bitrate " + AudioBox.Text;
                    break;
            }

            try
            {
                var result = appSettings["Code_rate_control_mode_selection"] ?? "Not Found";
                switch (result)
                {
                    case "1":
                        cmdLine = cmdLine + " --cqp " + appSettings["I"] + ":" + appSettings["P"] + ":" +
                                  appSettings["B"];
                        break;
                    case "2":
                        cmdLine = cmdLine + " --cbr " + appSettings["CBR"];
                        break;
                    case "3":
                        cmdLine = cmdLine + " --vbr " + appSettings["VBR"];
                        break;
                    case "Not Found":
                        MessageBox.Show("设置出现问题，请重新进入编码器设置并保存");
                        break;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            if (checkBox1.Checked)
                cmdLine = cmdLine + " --interlace tff --vpp-deinterlace normal";

            if (checkBox2.Checked)
                cmdLine = cmdLine + " --output-res " + wBox.Text + "x" + hBox.Text;

            if (appSettings["Code"] != null && appSettings["Code"] != "") cmdLine = cmdLine + appSettings["Code"];

            cmdLine = cmdLine + " -o \"" + OutputFile.Text + "\"";

            p.Start();
            p.StandardInput.WriteLine(cmdLine);
        }

        private void Backout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new EncoderSetting();

            f.ShowDialog();
        }

        private void ffmpeg_Live_Click(object sender, EventArgs e)
        {
            var f = new ffmpeg_Live();

            f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    AddUpdateAppSettings("Raws_audiomode", "0");
                    AudioBox.Hide();
                    label7.Hide();
                    label8.Show();
                    break;
                case 1:
                    AddUpdateAppSettings("Raws_audiomode", "1");
                    AudioBox.Show();
                    label7.Show();
                    label8.Hide();
                    break;
            }
        }

        private void VideoFile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OutputFile.Text = VideoFile.Text.Substring(0, VideoFile.Text.LastIndexOf(".")) + "_rip.mp4";
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

        private void AssFile_DragEnter(object sender, DragEventArgs e)
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

        private void VideoFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ffmpegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ffmpeg_demux();
            f.ShowDialog();
        }

        private void needed_Click(object sender, EventArgs e)
        {
            var f = new needed();
            f.ShowDialog();
        }

        private void EncoderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                AddUpdateAppSettings("EncoderBox_selected", EncoderBox.SelectedIndex.ToString());
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        private void AudioBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                AddUpdateAppSettings("Raws_audiobit", AudioBox.Text);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }
    }
}
