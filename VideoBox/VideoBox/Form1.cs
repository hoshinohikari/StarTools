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
            if (AssFile.Text == "")
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = false;
                p.StartInfo.RedirectStandardError = false;
                p.StartInfo.CreateNoWindow = false;

                p.Start();
                p.StandardInput.WriteLine("tool\\NVEncC64.exe --avhw -i \"" + VideoFile.Text + "\" --audio-codec 1?aac -o \"" + OutputFile.Text + "\"");
            }
            else
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = false;
                p.StartInfo.RedirectStandardError = false;
                p.StartInfo.CreateNoWindow = false;

                p.Start();
                p.StandardInput.WriteLine("tool\\NVEncC64.exe --avhw -i \"" + VideoFile.Text + "\" --audio-codec 1?aac --vpp-subburn filename=\"" +
                                          AssFile.Text+"\" -o \"" + OutputFile.Text + "\"");
            }
        }
    }
}
