using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                    cmdLine = "tool\\NVEnc\\NVEncC64.exe --avhw -i \"" + VideoFile.Text +
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
                                      "\" -codec:a copy -codec:v rawvideo -pix_fmt yuv420p -f nut - | tool\\QSVEnc\\QSVEncC64.exe --avsw -i - --audio-codec 1?aac";
                            break;
                        case 1:
                            MessageBox.Show("Error!");
                            break;
                        case 2:
                            cmdLine = "tool\\ffmpeg\\ffmpeg.exe -y -i \"" + VideoFile.Text +
                                      "\" -vf \"ass=" + temp +
                                      "\" -codec:a copy -codec:v rawvideo -pix_fmt yuv420p -f nut - | tool\\VCEEnc\\VCEEncC64.exe --avsw -i - --audio-codec 1?aac";
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
                        cmdLine = "tool\\QSVEnc\\QSVEncC64.exe --avhw -i \"" + VideoFile.Text +
                                  "\" --audio-codec 1?aac";
                        break;
                    case 1:
                        cmdLine = "tool\\NVEnc\\NVEncC64.exe --avhw -i \"" + VideoFile.Text +
                                  "\" --audio-codec 1?aac";
                        break;
                    case 2:
                        cmdLine = "tool\\VCEEnc\\VCEEncC64.exe --avhw -i \"" + VideoFile.Text +
                                  "\" --audio-codec 1?aac";
                        break;
                    case 3:
                        break;
                    default:
                        MessageBox.Show("Error!");
                        break;
                }
            }

            try
            {
                List<string> lines = new List<string>(File.ReadAllLines(@"setting\EncoderSetting.cfg"));

                if (lines.Count >= 1)
                {
                    string temp = !string.IsNullOrWhiteSpace(lines[0]) && lines[0].Length >= 32
                        ? lines[0].Substring(0, 32)
                        : lines[0];
                    if (temp == "Code_rate_control_mode_selection")
                    {
                        switch (lines[0][33])
                        {
                            case '1':
                                cmdLine = cmdLine + " --cqp " +
                                          lines[1].Substring(lines[1].IndexOf("=") + 1,
                                              lines[1].IndexOf(";") - lines[1].IndexOf("=") - 1);
                                break;
                            case '2':
                                cmdLine = cmdLine + " --cbr " +
                                          lines[1].Substring(lines[1].IndexOf("=", 15) + 1,
                                              lines[1].IndexOf(";", 21) - lines[1].IndexOf("=", 15) - 1);
                                break;
                            case '3':
                                cmdLine = cmdLine + " --vbr " +
                                          lines[1].Substring(lines[1].IndexOf("=", 24) + 1,
                                              lines[1].IndexOf(";", 30) - lines[1].IndexOf("=", 24) - 1);
                                break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
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
    }
}
