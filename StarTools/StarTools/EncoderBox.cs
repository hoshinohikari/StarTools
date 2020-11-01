using System;
using System.Configuration;
using System.Windows.Forms;
using Sunny.UI;

namespace StarTools
{
    public partial class EncoderBox : UITitlePage
    {
        public EncoderBox()
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

        private void EncoderBox_Load(object sender, EventArgs e)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                var result = appSettings["Code_rate_control_mode_selection"] ?? "Not Found";
                switch (result)
                {
                    case "1":
                        uiRadioButton1.Checked = true;
                        break;
                    case "2":
                        uiRadioButton2.Checked = true;
                        break;
                    case "3":
                        uiRadioButton3.Checked = true;
                        break;
                    case "Not Found":
                        AddUpdateAppSettings("Code_rate_control_mode_selection", "1");
                        uiRadioButton1.Checked = true;
                        break;
                }

                if (appSettings["Raws_audiomode"] == null)
                {
                    AddUpdateAppSettings("Raws_audiomode", "0");
                    AudioMode.SelectedIndex = 0;
                }
                else
                {
                    switch (appSettings["Raws_audiomode"])
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
                    }
                }

                if (appSettings["Raws_audiobit"] == null)
                {
                    AddUpdateAppSettings("Raws_audiobit", "192");
                    AudioBox.Text = @"192";
                }
                else
                {
                    AudioBox.Text = appSettings["Raws_audiobit"];
                }

                if (appSettings["I"] == null)
                {
                    AddUpdateAppSettings("I", "24");
                    IBox.Text = @"24";
                }
                else
                {
                    IBox.Text = appSettings["I"];
                }

                if (appSettings["P"] == null)
                {
                    AddUpdateAppSettings("P", "26");
                    PBox.Text = @"26";
                }
                else
                {
                    PBox.Text = appSettings["P"];
                }

                if (appSettings["B"] == null)
                {
                    AddUpdateAppSettings("B", "27");
                    BBox.Text = @"27";
                }
                else
                {
                    BBox.Text = appSettings["B"];
                }

                if (appSettings["CBR"] == null)
                {
                    AddUpdateAppSettings("CBR", "3000");
                    CBRBox.Text = @"3000";
                }
                else
                {
                    CBRBox.Text = appSettings["CBR"];
                }

                if (appSettings["VBR"] == null)
                {
                    AddUpdateAppSettings("VBR", "3000");
                    VBRBox.Text = @"3000";
                }
                else
                {
                    VBRBox.Text = appSettings["VBR"];
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine(@"Error reading app settings");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (uiRadioButton1.Checked && !uiRadioButton2.Checked && !uiRadioButton3.Checked)
                AddUpdateAppSettings("Code_rate_control_mode_selection", "1");
            else if (!uiRadioButton1.Checked && uiRadioButton2.Checked && !uiRadioButton3.Checked)
                AddUpdateAppSettings("Code_rate_control_mode_selection", "2");
            else if (!uiRadioButton1.Checked && !uiRadioButton2.Checked && uiRadioButton3.Checked)
                AddUpdateAppSettings("Code_rate_control_mode_selection", "3");
            else
                MessageBox.Show(@"正常情况看不到这个，出现该弹窗请带上复现方法到GitHub提issue");

            AddUpdateAppSettings("I", IBox.Text);
            AddUpdateAppSettings("P", PBox.Text);
            AddUpdateAppSettings("B", BBox.Text);
            AddUpdateAppSettings("CBR", CBRBox.Text);
            AddUpdateAppSettings("VBR", VBRBox.Text);
            AddUpdateAppSettings("Raws_audiobit", AudioBox.Text);

            UIMessageTip.ShowOk("保存成功");
        }

        private void AudioMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AudioMode.SelectedIndex)
            {
                case 0:
                    AddUpdateAppSettings("Raws_audiomode", "0");
                    AudioBox.Hide();
                    uiLabel8.Hide();
                    uiLabel7.Show();
                    break;
                case 1:
                    AddUpdateAppSettings("Raws_audiomode", "1");
                    AudioBox.Show();
                    uiLabel8.Show();
                    uiLabel7.Hide();
                    break;
            }
        }
    }
}