using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurProject
{
    public partial class MapNav : Form
    {
        const int MAXN = 100;
        public float[] dataX = new float[MAXN];
        public float[] dataY = new float[MAXN];

        public MapNav()
        {
            InitializeComponent();
        }

        private void MapNav_Load(object sender, EventArgs e)
        {
            try
            {
                //webBrowser1.Url = new Uri(Path.Combine(Application.StartupPath, "XiDian.html"));
                webBrowser1.Url = new Uri(Path.Combine(Application.StartupPath, "XiDian.htm"));
                //webBrowser1.Width = this.Size.Width;
                //webBrowser1.Height = this.Size.Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string myData = "";
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("drawPolyLine");
            
            myData= webBrowser1.Document.InvokeScript("get_dataX").ToString();
            string[] str = myData.Split('|');
            for (int i = 0; i < str.Length; i++)
                dataX[i] = float.Parse(str[i]);

            myData = webBrowser1.Document.InvokeScript("get_dataY").ToString();
            str = myData.Split('|');
            for (int i = 0; i < str.Length; i++)
                dataY[i] = float.Parse(str[i]);
            //webBrowser1.Document.GetElementById("dataX").
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("clearAll");
        }
    }
}
