using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace winHexDump
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string selectFileName = ""; //所选择的文件路径名
        private textForm srcForm, destForm;

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            //1. create a new form
            srcForm = new textForm();
            srcForm.MdiParent = this;   //设置主窗口

            //2. open the file
            OpenFileDialog openFileDlg = new OpenFileDialog();

            openFileDlg.InitialDirectory = selectFileName;
            openFileDlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                selectFileName = openFileDlg.FileName;
                //srcForm.Text = selectFileName;
            }

            //3. load file into childForm and show it
            srcForm.RichTxtBox = File.ReadAllText(selectFileName);
            srcForm.Show();

            //4. now it can hex dump
            dumpToolStripMenuItem1.Enabled = true;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// 将所选文本转换为Hex格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dumpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string hexText = "";
            destForm = new textForm();
            destForm.MdiParent = this;

            //输出 string 中的每个字符的十六进制值
            char[] values = srcForm.RichTxtBox.ToCharArray();
            foreach (char letter in values){
                // Get the integral value of the character.
                int value = Convert.ToInt32(letter);
                // Convert the decimal value to a hexadecimal value in string form.
                hexText += String.Format("{0:X2} ", value);            
            }

            destForm.RichTxtBox = hexText;
            destForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dumpToolStripMenuItem1.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //应用程序关闭 -> aware for multi-thread
        }
    }
}
