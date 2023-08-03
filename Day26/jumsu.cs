using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jumsu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int jumsu;
            String hakjum;
            if(textBox1.Text == "")
            {
                MessageBox.Show("점수를 입력하세요", "경고 1");
                goto Nagayo;
            }
            jumsu = int.Parse(textBox1.Text);
            if (jumsu > 100 || jumsu <0)
            {
                MessageBox.Show("0~100 사이 점수를 입력하세요", "경고 2");
            }
            switch ((jumsu-1) / 10)
            {
                case 9:
                    hakjum = "A";
                    break;
                case 8:
                    hakjum = "B";
                    break;
                case 7:
                    hakjum= "C";
                    break;
                case 6:
                    hakjum= "D";
                    break;
                default:
                    hakjum = "F:재수강";
                    break;  
            }
            if ((jumsu - 1) % 10 >= 5)
                textBox2.Text = hakjum + "+";
            else
                textBox2.Text = hakjum + "0";
        Nagayo: textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
        }
    }
}
