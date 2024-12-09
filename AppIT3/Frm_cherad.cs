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
    public partial class Frm_cherad : Form
    {
        public Frm_cherad()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()!=string.Empty)
            {
                panel1.Enabled = true;
                panel2.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                textBox1.ForeColor = Color.Red;
            if (radioButton2.Checked == true)
                textBox1.ForeColor = Color.Blue;
            if (radioButton3.Checked == true)
                textBox1.ForeColor = Color.Green;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold|FontStyle.Italic|FontStyle.Underline);
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold|FontStyle.Italic);
        }
    }
}
