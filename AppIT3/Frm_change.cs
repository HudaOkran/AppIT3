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
    public partial class Frm_change : Form
    {
       
        char[] c;
        
        public Frm_change()
        {
            InitializeComponent();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            c = textBox1.Text.ToCharArray();
            
            for (int i = 0; i < c.Length; i++)
            {
                MessageBox.Show(c[i].ToString());
            }
          
        }
    }
}
