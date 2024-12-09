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
    public partial class Frm_Calc : Form
    {
        char op ;
        public Frm_Calc()
        {
            InitializeComponent();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            op = '+';
        }

        private void Frm_Calc_Load(object sender, EventArgs e)
        {
            //result.Enabled = false;
            result.ReadOnly = true;
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            op = '*';
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            op = '-';
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            op = '/';
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            result.Clear();
            op = '@';
            num1.Focus();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                switch (op)
                {
                    case '+':
                        result.Text = (int.Parse(num1.Text) + int.Parse(num2.Text)).ToString();
                        break;
                    case '-':
                        result.Text = (int.Parse(num1.Text) - int.Parse(num2.Text)).ToString();
                        break;
                    case '*':
                        result.Text = (int.Parse(num1.Text) * int.Parse(num2.Text)).ToString();
                        break;
                    case '/':
                        result.Text = (int.Parse(num1.Text)/ int.Parse(num2.Text)).ToString();
                        break;
                    default:
                        MessageBox.Show("choose operation");
                        break;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
