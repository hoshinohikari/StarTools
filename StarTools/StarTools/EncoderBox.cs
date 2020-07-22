using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoBox
{
    public partial class EncoderSetting : Form
    {

        public EncoderSetting()
        {
            InitializeComponent();
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        private void EncoderSetting_Load(object sender, EventArgs e)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings["Code_rate_control_mode_selection"] ?? "Not Found";
                switch (result)
                {
                    case "1":
                        radioButton1.Checked = true;
                        break;
                    case "2":
                        radioButton2.Checked = true;
                        break;
                    case "3":
                        radioButton3.Checked = true;
                        break;
                    case "Not Found":
                        AddUpdateAppSettings("Code_rate_control_mode_selection", "1");
                        radioButton1.Checked = true;
                        break;
                    default:
                        break;
                }

                if (appSettings["I"] == null)
                    AddUpdateAppSettings("I", "24");
                IBox.Text = appSettings["I"];

                if (appSettings["P"] == null)
                    AddUpdateAppSettings("P", "26");
                PBox.Text= appSettings["P"];

                if (appSettings["B"] == null)
                    AddUpdateAppSettings("B", "27");
                BBox.Text = appSettings["B"];

                if (appSettings["CBR"] == null)
                    AddUpdateAppSettings("CBR", "3000");
                CBRBox.Text = appSettings["CBR"];

                if (appSettings["VBR"] == null)
                    AddUpdateAppSettings("VBR", "3000");
                VBRBox.Text = appSettings["VBR"];
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }

            if (radioButton1.Checked)
                FinBox.Text = " --cqp " + IBox.Text + ":" + PBox.Text + ":" + BBox.Text;
            if (radioButton2.Checked)
                FinBox.Text = " --cbr " + CBRBox.Text;
            if (radioButton3.Checked)
                FinBox.Text = " --vbr " + VBRBox.Text;
            if (codeBox.Text != "")
                FinBox.Text = FinBox.Text + " " + codeBox.Text;
        }

        private void Backout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
                AddUpdateAppSettings("Code_rate_control_mode_selection", "1");
            else if (!radioButton1.Checked && radioButton2.Checked && !radioButton3.Checked)
                AddUpdateAppSettings("Code_rate_control_mode_selection", "2");
            else if (!radioButton1.Checked && !radioButton2.Checked && radioButton3.Checked)
                AddUpdateAppSettings("Code_rate_control_mode_selection", "3");
            else
                MessageBox.Show("你他妈选不选");

            AddUpdateAppSettings("I", IBox.Text);
            AddUpdateAppSettings("P", PBox.Text);
            AddUpdateAppSettings("B", BBox.Text);
            AddUpdateAppSettings("CBR", CBRBox.Text);
            AddUpdateAppSettings("VBR", VBRBox.Text);
            AddUpdateAppSettings("Code", codeBox.Text);

            MessageBox.Show("保存成功");
            Close();
        }

        private void Box_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                FinBox.Text = " --cqp " + IBox.Text + ":" + PBox.Text + ":" + BBox.Text;
            if (radioButton2.Checked)
                FinBox.Text = " --cbr " + CBRBox.Text;
            if (radioButton3.Checked)
                FinBox.Text = " --vbr " + VBRBox.Text;
            if (codeBox.Text != "")
                FinBox.Text = FinBox.Text + " " + codeBox.Text;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                FinBox.Text = " --cqp " + IBox.Text + ":" + PBox.Text + ":" + BBox.Text;
            if (radioButton2.Checked)
                FinBox.Text = " --cbr " + CBRBox.Text;
            if (radioButton3.Checked)
                FinBox.Text = " --vbr " + VBRBox.Text;
            if (codeBox.Text != "")
                FinBox.Text = FinBox.Text + " " + codeBox.Text;
        }
    }
}
