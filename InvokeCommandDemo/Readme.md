## How does C# invoke other `.exe` or `.bat` command

to facilate programing, I design a simple function `excuteCommand` for C#

- Kernel function

```csharp
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
```				

## Usage

- in *command*: input the command your want to execute, e.g., `gradle.bat`
  - Notice: in most time, you should specify the all path of executable/batch file.
- in *argument*: you input argument, e.g., `-version`. So you will executed `gradle.bat -version` commmand
- then click *executed* button, the output of executing processing will be display in *Result* textbox

