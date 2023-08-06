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



namespace FormsAppQuiz001

{

    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();

        }



        private void textBox1_TextChanged(object sender, EventArgs e)

        {



        }



        private void Form1_Load(object sender, EventArgs e)

        {

            textBox1.Text = "C:\Users\LG\Documents\zzz.txt";

        }



        private void button1_Click(object sender, EventArgs e)

        {

            using (Stream sr = new FileStream(textBox1.Text, FileMode.Open))

            {

                StreamReader reader = new StreamReader(sr,Encoding.UTF8);

                string txt = reader.ReadToEnd();

                textBox2.Text = txt;

            }

        }

    }

}
