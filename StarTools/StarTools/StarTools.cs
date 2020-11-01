using System;
using System.Configuration;
using Sunny.UI;

namespace StarTools
{
    public partial class StarTools : UIHeaderAsideMainFrame
    {
        public StarTools()
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

        private void StarTools_Load(object sender, EventArgs e)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings["ffmpeg_file"] == null)
                    AddUpdateAppSettings("ffmpeg_file", "tool\\ffmpeg\\ffmpeg.exe");

                if (appSettings["NVEnc_file"] == null)
                    AddUpdateAppSettings("NVEnc_file", "tool\\HardEnc\\NVEncC64.exe");

                if (appSettings["QSVEnc_file"] == null)
                    AddUpdateAppSettings("QSVEnc_file", "tool\\HardEnc\\QSVEncC64.exe");

                if (appSettings["VCEEnc_file"] == null)
                    AddUpdateAppSettings("VCEEnc_file", "tool\\HardEnc\\VCEEncC64.exe");

                if (appSettings["Code_rate_control_mode_selection"] == null)
                    AddUpdateAppSettings("Code_rate_control_mode_selection", "1");

                if (appSettings["I"] == null)
                    AddUpdateAppSettings("I", "24");

                if (appSettings["P"] == null)
                    AddUpdateAppSettings("P", "26");

                if (appSettings["B"] == null)
                    AddUpdateAppSettings("B", "27");
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine(@"Error reading app settings");
            }

            Aside.Nodes.Clear();
            Aside.CreateNode(AddPage(new About()), 61451, 24);
            Aside.SelectFirst();
        }

        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            //TODO: 增加新功能
            switch (menuIndex)
            {
                case 0:
                    Aside.Nodes.Clear();
                    Aside.CreateNode(AddPage(new Encode()), 61451, 24);
                    Aside.CreateNode(AddPage(new EncoderBox()), 61451, 24);
                    Aside.SelectFirst();
                    break;
                case 1:
                    Aside.Nodes.Clear();
                    Aside.CreateNode(AddPage(new ffmpeg_Live()), 61451, 24);
                    Aside.CreateNode(AddPage(new ffmpeg_demux()), 61451, 24);
                    Aside.SelectFirst();
                    break;
                case 2:
                    Aside.Nodes.Clear();
                    Aside.CreateNode(AddPage(new Needed()), 61451, 24);
                    Aside.SelectFirst();
                    break;
            }
        }
    }
}