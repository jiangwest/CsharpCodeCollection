using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHookEx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MouseHookEx1 mh;

        private void Form1_Load(object sender, EventArgs e)
        {
            mh = new MouseHookEx1();    //create the instance of mouse hook 
            mh.SetHook();
            mh.MouseMoveEvent += mh_MouseMoveEvent;   
        }

        void mh_MouseMoveEvent(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            label1.Text = string.Format("当前鼠标位置为：（{0}，{1}）", x, y);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mh.UnHook();
        }

    }
}
