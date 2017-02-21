using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinHookEx1
{
    class MouseHookEx1
    {
        private Point point;

        //委托+事件（把钩到的消息封装为事件，由调用者处理）
        public delegate void MouseMoveHandler(object sender, MouseEventArgs e);
        public event MouseMoveHandler MouseMoveEvent;


        private Point Point
        {
            get { return point; }
            set
            {
                if (point != value)
                {
                    point = value;
                    if (MouseMoveEvent != null)
                    {
                        var e = new MouseEventArgs(MouseButtons.None, 0, point.X, point.Y, 0);
                        MouseMoveEvent(this, e);
                    }
                }
            }
        }

        private int hHook;
        //idHook 钩子类型
        private const int idHookType = 14; //表示为全局钩子监听鼠标消息
        public Win32HookAPI.HookProc hProc;
        
        /// <summary>
        /// default constructor 
        /// </summary>
        public MouseHookEx1() { this.Point = new Point(); }

        /// <summary>
        /// to set the hook function
        /// </summary>
        /// <returns></returns>
        public int SetHook()
        {
            //delegate?
            hProc = new Win32HookAPI.HookProc(MouseHookProc);
            //set the hook function as hProc，即钩子函数的地址指针
            hHook = Win32HookAPI.SetWindowsHookEx(idHookType, hProc, IntPtr.Zero, 0);
            return hHook;
        }

        /// <summary>
        /// uninstall hook function
        /// </summary>
        public void UnHook()
        {
            Win32HookAPI.UnhookWindowsHookEx(hHook);
        }

        /// <summary>
        /// Hook function to minitor mouse action
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        private int MouseHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            //将数据从非托管内存块封送到新分配的指定类型的托管对象
            Win32HookAPI.MouseHookStruct MyMouseHookStruct = 
                (Win32HookAPI.MouseHookStruct) Marshal.PtrToStructure(lParam, typeof(Win32HookAPI.MouseHookStruct));
            if (nCode < 0)
            {
                return Win32HookAPI.CallNextHookEx(hHook, nCode, wParam, lParam);
            }
            else
            {
                this.Point = new Point(MyMouseHookStruct.pt.x, MyMouseHookStruct.pt.y);
                return Win32HookAPI.CallNextHookEx(hHook, nCode, wParam, lParam);
            }
        }
    
    }
}
