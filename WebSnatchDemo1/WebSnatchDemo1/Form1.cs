using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;   

namespace WebSnatchDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSnatch_Click(object sender, EventArgs e)
        {
            byte[] buf = new byte[38192];   //存储请求返回来的结果
            //实例化HttpWebRequest对象
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(txtURL.Text);
            HttpWebResponse resp = (HttpWebResponse) req.GetResponse();

            Stream resStream = resp.GetResponseStream();
            int count = resStream.Read(buf, 0, buf.Length);

            //节转换成字符串，这里采用默认(Default)编码方式
            txtWebPage.Text = Encoding.Default.GetString(buf, 0,count);

            resStream.Close();   
        }
    }
}
