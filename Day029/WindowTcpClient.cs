using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private NetworkStream stream;
        private TcpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes(textBox1.Text);
            stream.Write(data, 0, data.Length);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string serverip = "127.0.0.1";
            int port = 13000;
            client = new TcpClient(serverip, port);
            stream = client.GetStream();
        }
       
    }
}
