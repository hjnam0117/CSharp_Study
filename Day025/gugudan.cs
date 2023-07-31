using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gugudan_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dan, i, iTab;
            textBox2.Text = "";
            for(dan = 2; dan <= 9; dan+=4)
            {
                for(i=1; i<=9; i++)
                {
                    for(iTab=0; iTab<=3; iTab++)
                    {
                        textBox2.Text = textBox2.Text + (dan+iTab) + " X " + i + " = ";
                        textBox2.Text = textBox2.Text + ((dan + iTab) * i) + "       ";
                    }
                    textBox2.Text = textBox2.Text + Environment.NewLine;
                }
                textBox2.Text = textBox2.Text + Environment.NewLine;
            }
        }
    }
}
