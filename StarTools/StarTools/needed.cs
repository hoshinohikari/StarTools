using System;
using System.Configuration;
using System.Security;
using System.Windows.Forms;
using Sunny.UI;

namespace StarTools
{
    public partial class Needed : UITitlePage
    {
        public Needed()
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

        private void needed_Load(object sender, EventArgs e)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings["ffmpeg_file"] == null)
                {
                    AddUpdateAppSettings("ffmpeg_file", "tool\\ffmpeg\\ffmpeg.exe");
                    ffmpeg_file.Text = @"tool\ffmpeg\ffmpeg.exe";
                }
                else
                {
                    ffmpeg_file.Text = appSettings["ffmpeg_file"];
                }

                if (appSettings["NVEnc_file"] == null)
                {
                    AddUpdateAppSettings("NVEnc_file", "tool\\HardEnc\\NVEncC64.exe");
                    NVEnc_file.Text = @"tool\HardEnc\NVEncC64.exe";
                }
                else
                {
                    NVEnc_file.Text = appSettings["NVEnc_file"];
                }

                if (appSettings["QSVEnc_file"] == null)
                {
                    AddUpdateAppSettings("QSVEnc_file", "tool\\HardEnc\\QSVEncC64.exe");
                    QSVEnc_file.Text = @"tool\HardEnc\QSVEncC64.exe";
                }
                else
                {
                    QSVEnc_file.Text = appSettings["QSVEnc_file"];
                }

                if (appSettings["VCEEnc_file"] == null)
                {
                    AddUpdateAppSettings("VCEEnc_file", "tool\\HardEnc\\VCEEncC64.exe");
                    VCEEnc_file.Text = @"tool\HardEnc\VCEEncC64.exe";
                }
                else
                {
                    VCEEnc_file.Text = appSettings["VCEEnc_file"];
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine(@"Error reading app settings");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            AddUpdateAppSettings("ffmpeg_file", ffmpeg_file.Text);
            AddUpdateAppSettings("NVEnc_file", NVEnc_file.Text);
            AddUpdateAppSettings("QSVEnc_file", QSVEnc_file.Text);
            AddUpdateAppSettings("VCEEnc_file", VCEEnc_file.Text);

            MessageBox.Show(@"保存成功");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a video file",
                Filter = @"ffmpeg files|ffmpeg.exe|All files|*.*",
                Title = @"Open video file"
            };

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                ffmpeg_file.Text = openFileDialog1.FileName;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a video file",
                Filter = @"NVEnc files|NVEncC64.exe|All files|*.*",
                Title = @"Open video file"
            };

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                NVEnc_file.Text = openFileDialog1.FileName;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a video file",
                Filter = @"QSVEnc files|QSVEncC64.exe|All files|*.*",
                Title = @"Open video file"
            };

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                QSVEnc_file.Text = openFileDialog1.FileName;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a video file",
                Filter = @"VCEEnc files|VCEEncC64.exe|All files|*.*",
                Title = @"Open video file"
            };

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                VCEEnc_file.Text = openFileDialog1.FileName;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void file_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void ffmpeg_file_DragDrop(object sender, DragEventArgs e)
        {
            ffmpeg_file.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void NVEnc_file_DragDrop(object sender, DragEventArgs e)
        {
            NVEnc_file.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void VCEEnc_file_DragDrop(object sender, DragEventArgs e)
        {
            VCEEnc_file.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void QSVEnc_file_DragDrop(object sender, DragEventArgs e)
        {
            QSVEnc_file.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }
    }
}