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
    public partial class radio_frm : Form
    {
        public radio_frm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton red = (RadioButton)sender;
            if (red.Checked == true)
                pictureBox1.Image = Image.FromFile(red.Tag + ".PNG");

        }
    }
}
