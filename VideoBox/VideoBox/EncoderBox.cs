using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void EncoderSetting_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = new List<string>(File.ReadAllLines(@"setting\EncoderSetting.cfg"));
                string temp;

                if (lines.Count >= 1)
                {
                    temp = !string.IsNullOrWhiteSpace(lines[0]) && lines[0].Length >= 32
                        ? lines[0].Substring(0, 32)
                        : lines[0];
                    if (temp == "Code_rate_control_mode_selection")
                    {
                        switch (lines[0][33])
                        {
                            case '1':
                                radioButton1.Checked = true;
                                break;
                            case '2':
                                radioButton2.Checked = true;
                                break;
                            case '3':
                                radioButton3.Checked = true;
                                break;
                        }
                    }
                    temp = !string.IsNullOrWhiteSpace(lines[1]) && lines[1].Length >= 5
                        ? lines[1].Substring(0, 5)
                        : lines[1];
                    if (temp == "I:P:B")
                    {
                        int x, y;
                        x = lines[1].IndexOf(":", 6);
                        IBox.Text = lines[1].Substring(6, x - 6);
                        y = lines[1].IndexOf(":", x);
                        x = lines[1].IndexOf(":", y + 1);
                        PBox.Text = lines[1].Substring(y + 1, x - y - 1);
                        y = lines[1].IndexOf(":", x);
                        x = lines[1].IndexOf(";", y);
                        BBox.Text = lines[1].Substring(y + 1, x - y - 1);
                        y = lines[1].IndexOf("=", x);
                        x = lines[1].IndexOf(";", y);
                        CBRBox.Text = lines[1].Substring(y + 1, x - y - 1);
                        y = lines[1].IndexOf("=", x);
                        x = lines[1].IndexOf(";", y);
                        VBRBox.Text = lines[1].Substring(y + 1, x - y - 1);
                    }
                    else
                    {
                        IBox.Text = "24";
                        PBox.Text = "26";
                        BBox.Text = "27";
                        CBRBox.Text = "3000";
                        VBRBox.Text = "3000";
                    }
                }
                else
                {
                    IBox.Text = "24";
                    PBox.Text = "26";
                    BBox.Text = "27";
                    CBRBox.Text = "3000";
                    VBRBox.Text = "3000";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("请删除文件夹setting下EncoderSetting.cfg文件");
            }
        }

        private void Backout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>(File.ReadAllLines(@"setting\EncoderSetting.cfg"));

            if (lines.Count == 0)
                lines.Insert(0, "Code_rate_control_mode_selection=1;");
            string temp = !string.IsNullOrWhiteSpace(lines[0]) && lines[0].Length >= 32
                ? lines[0].Substring(0, 32)
                : lines[0];
            if (temp == "Code_rate_control_mode_selection")
            {
                lines.RemoveAt(0);
                if (radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
                {
                    lines.Insert(0, "Code_rate_control_mode_selection=1;");
                }
                else if (!radioButton1.Checked && radioButton2.Checked && !radioButton3.Checked)
                    lines.Insert(0, "Code_rate_control_mode_selection=2;");
                else if (!radioButton1.Checked && !radioButton2.Checked && radioButton3.Checked)
                    lines.Insert(0, "Code_rate_control_mode_selection=3;");
                else
                    MessageBox.Show("你他妈选不选");
            }
            else
                lines.Insert(0, "Code_rate_control_mode_selection=1;");

            if (lines.Count == 1)
                lines.Insert(1, "I:P:B=24:26:27;CBR=3000;VBR=3000;");
            temp = !string.IsNullOrWhiteSpace(lines[1]) && lines[1].Length >= 32
                ? lines[1].Substring(0, 5)
                : lines[1];
            if (temp == "I:P:B")
            {
                lines.RemoveAt(1);
                lines.Insert(1,
                    "I:P:B=" + IBox.Text + ":" + PBox.Text + ":" + BBox.Text + ";CBR=" + CBRBox.Text + ";VBR=" +
                    VBRBox.Text + ";");
            }

            File.WriteAllLines(@"setting\EncoderSetting.cfg", lines.ToArray());

            MessageBox.Show("保存成功");
            Close();
        }
    }
}
