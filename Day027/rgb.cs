using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rgb
{
    public partial class Form1 : Form
    {
        private int R, G, B;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(R, G, B);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            R = trackBar1.Value;
            panel1.Invalidate();
        }
       
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            G = trackBar2.Value;
            panel1.Invalidate();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            B = trackBar3.Value;
            panel1.Invalidate();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
