using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Threading;
using System.Diagnostics;//Importing Diagnostics and Threading extensions


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Thread cpuThread;
        private double[] cpuArray = new double[30];



        public Form1()
        {
            InitializeComponent();
        }
        
        private void getPerformaceCounters()
        {
            var cpuPerCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

            while(true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerCounter.NextValue(), 0);

                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

                if(cpuChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(1000);
            }
        }

        private void UpdateCpuChart()
        {
            cpuChart.Series["Performance"].Points.Clear();

            for(int i = 0; i < cpuArray.Length - 1; ++i)
            {
                cpuChart.Series["Performance"].Points.AddY(cpuArray[i]);
            }


        }



        private void button1_Click(object sender, EventArgs e)
        {
            cpuThread = new Thread(new ThreadStart(this.getPerformaceCounters));
            cpuThread.IsBackground = true;
            cpuThread.Start();
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
                //webBrowser1.Navigate(textBox1.Text);
                //NavigateToPage();
                button4_Click(null, null);
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
    }
}
