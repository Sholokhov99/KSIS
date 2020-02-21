using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Source
{
    public class Terminal
    {
        private static async void ExecutionTerminal(String argument)
        {
            await Task.Run(() =>
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = @"cmd.exe",
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = argument,
                    }
                };
                process.Start();
            });
        }

        public static void OffPc() => ExecutionTerminal(@"shutdown /f /s /t 0");
        public static void Reboot() => ExecutionTerminal(@"shutdown /r /t 0");
        public static void SleepMode() => ExecutionTerminal(@"shutdown /f /h");
        public static void ChangeUser() => ExecutionTerminal(@"logoff");
    }
}
