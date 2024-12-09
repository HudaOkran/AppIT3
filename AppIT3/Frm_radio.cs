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
    public partial class Frm_radio : Form
    {
        public Frm_radio()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad =(RadioButton) sender;
            if (rad.Checked == true)
            pictureBox1.Image = Image.FromFile(rad.Tag+".JPG");
        }
    }
}
