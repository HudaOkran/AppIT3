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
    public partial class Frm_list : Form
    {
        public Frm_list()
        {
            InitializeComponent();
        }

        private void Frm_list_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 1; i <=10; i++)
            {
                listBox1.Items.Add("item "+i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox2.Items.AddRange(listBox1.Items);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
                MessageBox.Show("حدد عنصر من القائمة");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_list_Load(null, null);
        }
    }
}
