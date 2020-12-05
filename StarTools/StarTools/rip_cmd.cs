using System.Threading;
using Sunny.UI;

namespace StarTools
{
    public partial class RipCmd : UITitlePage
    {
        private static Thread _thread;
        private static readonly CmdUtils Cmd = new CmdUtils();
        private readonly string _arg;
        private readonly string _line;

        public RipCmd(string cmdLine, string argLine)
        {
            InitializeComponent();
            _line = cmdLine;
            _arg = argLine;
            _thread = new Thread(Init_cmd) {IsBackground = true};
            _thread.Start();
        }

        public static void StopCmd()
        {
            Cmd.CloseCmd();
            _thread.Abort();
        }

        private void Init_cmd()
        {
            Cmd.SendCmd(this, _line, _arg);
        }
    }
}