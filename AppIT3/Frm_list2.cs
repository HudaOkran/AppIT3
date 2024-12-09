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
    public partial class Frm_list2 : Form
    {
        public Frm_list2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1.Text.Trim() != string.Empty)
                button1_Click(null, null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() !=string.Empty)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
            listBox1.Items.Insert(i, textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void Frm_list2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                textBox1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
