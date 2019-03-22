using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



//CefSharp Imported
using CefSharp;
using CefSharp.WinForms;
using System.Runtime.InteropServices;
using System.IO;

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
    public partial class Browser : Form
    {
        //private Thread cpuThread;
        private double[] cpuArray = new double[30];



        //ChromiumWebBrowser declared as public
        public ChromiumWebBrowser chromeBrowser;


        public Browser()
        {
            InitializeComponent();

            // At the initial, start Chrome

            InitializeChromium();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chromeBrowser.ShowDevTools();
        }

        //ChromiumWebBrowser
        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            // Initialize Cef with the imported settings
            //Cef.Initialize(settings);



            chromeBrowser = new ChromiumWebBrowser("www.twinb0rnsoft.com");
            {
     

                // Make the broswer fill the form
                chromeBrowser.Dock = DockStyle.Fill;
                chromeBrowser.Size = new Size(1920, 1080);
            };
            // Add the broswer to the Form
            this.panel2.Controls.Add(chromeBrowser);


            // Allow the use of local resources in the browser
            BrowserSettings browserSettings = new BrowserSettings();
            browserSettings.FileAccessFromFileUrls = CefState.Enabled;
            browserSettings.UniversalAccessFromFileUrls = CefState.Enabled;
            chromeBrowser.BrowserSettings = browserSettings;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("www.twinb0rnsoft.com");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // webBrowser1.Navigate(textBox1.Text);
        }

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)ConsoleKey.Enter))
            {
                // webBrowser1.Navigate(textBox1.Text);
                //NavigateToPage();
                //button4_Click(null, null);
            }
        }



        private void cPUTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 win2 = new Form2();
            win2.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }


        //Menu Tabs
        private void cPUTestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 win2 = new Form2();
            win2.Show();


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("License by twinb0rnsoft.com ");
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            chromeBrowser.Back();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            chromeBrowser.Forward();
        }

        private void duckDuckGoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://duckduckgo.com/");
        }

        private void googleChromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://www.google.com/");
        }
    }

}