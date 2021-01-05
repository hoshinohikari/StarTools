using System.Collections.Generic;
using System.Security;
using System.Windows.Forms;

namespace StarTools
{
    internal static class FileDo
    {
        public static string GetVideoFile(string initText)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a video file",
                Filter =
                    @"files (*.mp4;*.mkv;*.flv;*.m2ts;*.ts;*.264;*.h264;*.hevc)|*.mp4;*.mkv;*.flv;*.m2ts;*.ts;*.264;*.h264;*.hevc|All files (*.*)|*.*",
                Title = @"Open video file"
            };
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return initText;
            try
            {
                return openFileDialog1.FileName;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                $"Details:\n\n{ex.StackTrace}");
                return initText;
            }
        }

        public static IEnumerable<string> GetAudioFiles()
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a audio file",
                Filter =
                    @"Audio files (*.m4a)|*.m4a|All files (*.*)|*.*",
                Title = @"Open audio file",
                Multiselect = true
            };
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return null;
            try
            {
                return openFileDialog1.FileNames;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                $"Details:\n\n{ex.StackTrace}");
                return null;
            }
        }

        public static string GetAssFile(string initText)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                FileName = "Select a ass file",
                Filter = @"Ass files (*.ass)|*.ass|All files (*.*)|*.*",
                Title = @"Open ass file"
            };
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return initText;
            try
            {
                return openFileDialog1.FileName;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                $"Details:\n\n{ex.StackTrace}");
                return initText;
            }
        }

        public static string GetSaveFiles(string filekinds)
        {
            var saveFileDialog1 = new SaveFileDialog
            {
                FileName = "Output",
                Filter = filekinds + @" files (*." + filekinds + @")|*." + filekinds + @"|All files (*.*)|*.*",
                Title = @"Save a " + filekinds + @" file"
            };

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return "";
            try
            {
                var filePath = saveFileDialog1.FileName;
                return filePath;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                $"Details:\n\n{ex.StackTrace}");
                return "";
            }
        }
    }
}