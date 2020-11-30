using System.Windows.Forms;
using Sunny.UI;

namespace StarTools
{
    public partial class RunRip : UIHeaderMainFrame
    {
        public RunRip(string cmdLine, string argLine)
        {
            InitializeComponent();

            //设置关联
            Header.TabControl = MainTabControl;

            //增加页面到Main
            AddPage(new RipCmd(cmdLine, argLine), 1001);

            //设置Header节点索引
            Header.SetNodePageIndex(Header.Nodes[0], 1001);

            //显示默认界面
            Header.SelectedIndex = 0;
        }

        private void run_rip_FormClosing(object sender, FormClosingEventArgs e)
        {
            var r = MainTabControl.TabPages[0].Controls[0] as RipCmd;
            if (r != null && r.uiProcessBar1.Value != 100)
            {
                if (this.ShowAskDialog("转换未完成，确认要退出吗"))
                    RipCmd.StopCmd();
                else
                    e.Cancel = true;
            }
            else
            {
                RipCmd.StopCmd();
            }
        }
    }
}