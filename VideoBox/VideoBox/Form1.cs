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

namespace VideoBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OutputFile.ReadOnly = true;
            AssFile.ReadOnly = true;
            AssFile.Text = "目前仅支持NVEnc";
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
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.RedirectStandardError = false;
            p.StartInfo.CreateNoWindow = false;

            switch (EncoderBox.SelectedIndex)
            {
                case 0:
                    p.Start();
                    p.StandardInput.WriteLine("tool\\QSVEnc\\QSVEncC64.exe --avhw -i \"" + VideoFile.Text + "\" --audio-codec 1?aac -o \"" + OutputFile.Text + "\"");
                    break;
                case 1:
                    if (AssFile.Text == "")
                    {
                        p.Start();
                        p.StandardInput.WriteLine("tool\\NVEnc\\NVEncC64.exe --avhw -i \"" + VideoFile.Text + "\" --audio-codec 1?aac -o \"" + OutputFile.Text + "\"");
                    }
                    else
                    {
                        p.Start();
                        p.StandardInput.WriteLine("tool\\NVEnc\\NVEncC64.exe --avhw -i \"" + VideoFile.Text + "\" --audio-codec 1?aac --vpp-subburn filename=\"" +
                                                  AssFile.Text + "\" -o \"" + OutputFile.Text + "\"");
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    MessageBox.Show("Error!");
                    break;
            }
        }

        private void Backout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EncoderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EncoderBox.SelectedIndex)
            {
                case 0:
                    AssFile.ReadOnly = true;
                    AssFile.Text = "目前仅支持NVEnc";
                    break;
                case 1:
                    AssFile.ReadOnly = false;
                    AssFile.Text = "";
                    break;
                case 2:
                    AssFile.ReadOnly = true;
                    AssFile.Text = "目前仅支持NVEnc";
                    break;
                case 3:
                    AssFile.ReadOnly = true;
                    AssFile.Text = "目前仅支持NVEnc";
                    break;
                default:
                    MessageBox.Show("Error!");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            f.ShowDialog();
        }
    }
}
