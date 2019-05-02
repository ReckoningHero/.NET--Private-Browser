using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Extened References
using DotNetBrowser;
using DotNetBrowser.WinForms;
//using System.System.Controls.WebBrowser;
//using System.Windows.Forms.WebBrowser;
//using System.Windows.Controls;
using System.Threading;
using System.Diagnostics;//Importing Diagnostics and Threading extensions


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //private Thread cpuThread;
        private double[] cpuArray = new double[30];

        public Form1()
        {
            InitializeComponent();

            WebBrowser myBrowser = new WebBrowser();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.twinb0rnsoft.com");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( (e.KeyChar == (char)ConsoleKey.Enter))
            {
                webBrowser1.Navigate(textBox1.Text);
                //NavigateToPage();
                //button4_Click(null, null);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.bing.com");
        }

        private void liceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("License by twinb0rnsoft.com ");
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void cPUTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 win2 = new Form2();
            win2.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.bing.com");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {


        }
    }
}
