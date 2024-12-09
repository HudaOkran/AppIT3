using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppIT3
{
    public partial class frm_timer : Form
    {
        int r = 0;
        int g = 0;
        int b = 0;
        Random f = new Random();
        public frm_timer()
        {
            InitializeComponent();
        }
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(r, g, b);
            r = f.Next(0, 255);
            g = f.Next(0, 255);
            b = f.Next(0, 255);
            pictureBox1.Image = Image.FromFile(i + ".PNG");
            i++;
            if (i == 7)
                i = 1;
            
        }

        private void frm_timer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
