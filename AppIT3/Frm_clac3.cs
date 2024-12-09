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
    public partial class Frm_clac3 : Form
    {
        public Frm_clac3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            result.Text = (int.Parse(num1.Text) + int.Parse(num2.Text)).ToString();
        }

        private void but_sum_Click(object sender, EventArgs e)
        {

        }

        private void Frm_clac3_Load(object sender, EventArgs e)
        {
            //result.Enabled = false;
            result.ReadOnly = true;
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void but_dev_Click(object sender, EventArgs e)
        {
            result.Text = (int.Parse(num1.Text) / int.Parse(num2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void but_sub_Click(object sender, EventArgs e)
        {
            result.Text = (int.Parse(num1.Text) - int.Parse(num2.Text)).ToString();
        }

        private void but_mult_Click(object sender, EventArgs e)
        {
            result.Text = (int.Parse(num1.Text) * int.Parse(num2.Text)).ToString();
        }

        private void but_equ_Click(object sender, EventArgs e)
        {
            true{
                switch
            }
        }
    }
}
