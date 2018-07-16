using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JsonBeauty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void btnBeautify_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                var sendMsg = txtMsg.Text;
                webKitBrowser1.StringByEvaluatingJavaScriptFromString("beautify('" + txtMsg.Text + "')");
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var reqUrl = "file:///" + Application.StartupPath + "\\req.html";
            reqUrl = reqUrl.Replace("\\", "/").Replace(" ", "%20");
            webKitBrowser1.Navigate(reqUrl);
        }
    }
}
