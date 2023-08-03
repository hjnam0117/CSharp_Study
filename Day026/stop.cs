using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stop
{
    public partial class Form1 : Form
    {
        private int cnt = 1;
        CancellationTokenSource cts;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*t1 = new Thread(() =>
            {
                while (true)
                {a
                    try
                    {
                        Invoke((Action)(() => label1.Text = cnt++ + ""));
                        Thread.Sleep(1000);
                    } catch(Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        break;
                    }
                }
                
            });

            t1.Start(); */
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            var task = Task.Run(async () =>
            {
                while (true)
                {
                    Invoke((Action)(() => label1.Text = (cnt++).ToString()));
                    await Task.Delay(1000);
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }
                }
            }); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
