using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiClipboardDeluxePro.Utils
{
    class Beautifier
    {
        private System.Diagnostics.Process proc;
        public StringBuilder sb1 = new StringBuilder();
        public EventHandler handler;
        string jsString = "";

        public Beautifier(string jsstring) {
            jsString = jsstring;
            string path = Environment.GetEnvironmentVariable("PATH");
            var npmPath = path.Split(';').Where(p => p.Contains("npm")).First();
            string cmdName = "js-beautify.cmd";
            string fileName = System.IO.Path.Combine(npmPath, cmdName);

            proc = new System.Diagnostics.Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.EnableRaisingEvents = true;
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.Arguments = "-";
            proc.OutputDataReceived += Proc_OutputDataReceived;
        }



        private void Proc_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            sb1.AppendLine(e.Data);
        }

        public void StartProcess()
        {
            proc.Exited += handler;
            proc.Start();
            proc.StandardInput.WriteLine(jsString);
            proc.StandardInput.Close();
            //proc.WaitForExit();
            proc.BeginOutputReadLine();
        }




    }
}
