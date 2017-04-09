using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            String strCommand = @"cmd.exe";
            String strExecuteFileName = txtExecute.Text;
            String strArg = txtArgument.Text;

            String strOutput = excuteCommand(strCommand, strExecuteFileName, strArg);

            //txtResult.Text = "";//设置运行的命令行文件问ping.exe文件，这个文件系统会自己找到
            txtResult.Text = strOutput;            
        }

        /// <summary>
        /// to exexute other executable or batch file
        /// </summary>
        /// <param name="strCommand">cmd.exe, which invoke Dos command windows</param>
        /// <param name="strExecuteFileName">to be executed file, including .exe or .bat file</param>
        /// <param name="strArg">the argument</param>
        /// <returns>the output of executed file</returns>
        private String excuteCommand(string strCommand, string strExecuteFileName, string strArg)
        {
            ProcessStartInfo start = new ProcessStartInfo(strCommand);
            String strExecute = String.Format("{0} {1}",strExecuteFileName,strArg);

            start.CreateNoWindow = true;//不显示dos命令行窗口
            start.RedirectStandardOutput = true;//
            start.RedirectStandardInput = true;//
            start.UseShellExecute = false;//是否指定操作系统外壳进程启动程序

            Process p = Process.Start(start);

            p.StandardInput.WriteLine(strExecute);     //执行command + argument工作
            p.StandardInput.AutoFlush = true;
            p.StandardInput.WriteLine("exit"); //退出
            
            StreamReader streamOutput = p.StandardOutput;//截取输出流

            String strOutput = streamOutput.ReadToEnd();

            p.WaitForExit();//等待程序执行完退出进程
            p.Close();//关闭进程
            streamOutput.Close();//关闭流

            return strOutput;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
