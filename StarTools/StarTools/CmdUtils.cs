﻿using System;
using System.Diagnostics;
using System.Management;

namespace StarTools
{
    internal class CmdUtils
    {
        private Process _cmd;
        private string _exe;

        public void SendCmd(RipCmd cmdoom, string shell, string arg)
        {
            shell = shell + arg;
            _cmd = new Process();
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "",
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };
            _cmd.StartInfo = startInfo;

            if (_cmd.Start())
            {
                _exe = "";
                _cmd.StandardInput.WriteLine(shell);
                var log = _cmd.StandardError.ReadLine();
                updateLog(cmdoom, log);
                log = "";
                do
                {
                    var logm = _cmd.StandardError.ReadLine();
                    if (logm == null) break;
                    updateLog(cmdoom, logm + "\n");
                    log += logm;
                } while (true);

                _cmd.Close();
                _cmd = null;
            }
        }

        //TODO: 函数功能分离，创建其他页面使用的窗口
        private void updateLog(RipCmd cmd, string log)
        {
            void Set()
            {
                if (_exe == "") _exe = log.Substring(0, 5) == "ffmpe" ? "ffmpe" : "enc";
                cmd.uiRichTextBox1.AppendText(log);
                cmd.uiRichTextBox1.ScrollToCaret();
                try
                {
                    if (log.Length <= 11) return;
                    if (log.Substring(0, 11) == "encode time")
                        cmd.uiProcessBar1.Value = 100;
                    else
                        switch (_exe)
                        {
                            case "enc":
                                cmd.uiProcessBar1.Value = (int) float.Parse(log.Substring(
                                    log.IndexOf("[", StringComparison.Ordinal) + 1,
                                    log.IndexOf("%", StringComparison.Ordinal) -
                                    log.IndexOf("[", StringComparison.Ordinal) - 1));
                                break;
                            case "ffmpe":
                                //TODO: ffmpeg管道模式下的进度条实现
                                break;
                        }
                }
                catch
                {
                    // ignored
                }
            }

            cmd.Invoke((UpdateLog) Set);
        }

        public void CloseCmd()
        {
            _cmd.KillProcessTree();
            _cmd.Close();
        }

        private delegate void UpdateLog();
    }

    public static class ProcessEx
    {
        public static void KillProcessTree(this Process parent)
        {
            var searcher =
                new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + parent.Id);
            var moc = searcher.Get();
            foreach (var o in moc)
            {
                var mo = (ManagementObject) o;
                var childProcess = Process.GetProcessById(Convert.ToInt32(mo["ProcessID"]));
                childProcess.KillProcessTree();
            }

            try
            {
                if (parent.Id != Process.GetCurrentProcess().Id) parent.Kill();
            }
            catch
            {
                // ignored
            }
        }
    }
}