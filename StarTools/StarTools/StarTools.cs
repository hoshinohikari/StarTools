using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VideoBox
{
    public partial class MainBox : Form
    {
        public MainBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OutputFile.ReadOnly = true;
            EncoderBox.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            AudioBox.Hide();
            label7.Hide();
            label8.Show();
            AudioBox.Text = "192";
            wBox.Text = "1280";
            hBox.Text = "720";
        }

        private void AddFiles1_Click(object sender, EventArgs e)
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

        private void AddFiles2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a ass file",
                Filter = "Ass files (*.ass)|*.ass",
                Title = "Open ass file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
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
        }

        private void SaveFiles_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog()
            {
                FileName = "Output",
                Filter = "Mp4 files (*.mp4)|*.mp4",
                Title = "Save a mp4 file"
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
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
        }

        private void rip_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            string cmdLine="";
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
                {
                    cmdLine = "tool\\HardEnc\\NVEncC64.exe --avhw -i \"" + VideoFile.Text +
                              "\" --audio-codec 1?aac --vpp-subburn filename=\"" +
                              AssFile.Text + "\"";
                }
                else
                {
                    switch (EncoderBox.SelectedIndex)
                    {
                        case 0:
                            cmdLine = "tool\\ffmpeg\\ffmpeg.exe -y -i \"" + VideoFile.Text +
                                      "\" -vf \"ass=" + temp +
                                      "\" -codec:a copy -codec:v rawvideo -pix_fmt yuv420p -f nut - | tool\\HardEnc\\QSVEncC64.exe --avsw -i -";
                            break;
                        case 1:
                            MessageBox.Show("Error!");
                            break;
                        case 2:
                            cmdLine = "tool\\ffmpeg\\ffmpeg.exe -y -i \"" + VideoFile.Text +
                                      "\" -vf \"ass=" + temp +
                                      "\" -codec:a copy -codec:v rawvideo -pix_fmt yuv420p -f nut - | tool\\HardEnc\\VCEEncC64.exe --avsw -i -";
                            break;
                        case 3:
                            break;
                        default:
                            MessageBox.Show("Error!");
                            break;
                    }
                }
            }
            else
            {
                switch (EncoderBox.SelectedIndex)
                {
                    case 0:
                        cmdLine = "tool\\HardEnc\\QSVEncC64.exe --avhw -i \"" + VideoFile.Text +
                                  "\"";
                        break;
                    case 1:
                        cmdLine = "tool\\HardEnc\\NVEncC64.exe --avhw -i \"" + VideoFile.Text +
                                  "\"";
                        break;
                    case 2:
                        cmdLine = "tool\\HardEnc\\VCEEncC64.exe --avhw -i \"" + VideoFile.Text +
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
                    cmdLine = cmdLine + " --audio-codec 1?aac --audio-bitrate " + AudioBox.Text;
                    break;
            }

            try
            {
                string result = appSettings["Code_rate_control_mode_selection"] ?? "Not Found";
                switch (result)
                {
                    case "1":
                        cmdLine = cmdLine + " --cqp " + appSettings["I"] + ":" + appSettings["P"] + ":" + appSettings["B"];
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

            if (appSettings["Code"] != null && appSettings["Code"] != "")
            {
                cmdLine = cmdLine + appSettings["Code"];
            }

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
            EncoderSetting f = new EncoderSetting();

            f.ShowDialog();
        }

        private void ffmpeg_Live_Click(object sender, EventArgs e)
        {
            ffmpeg_Live f = new ffmpeg_Live();

            f.ShowDialog();
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

        private void VideoFile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OutputFile.Text = VideoFile.Text.Insert(VideoFile.Text.LastIndexOf("."), "_rip");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
