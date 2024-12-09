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
    public partial class Frm_combox : Form
    {
        string[] a = { "الكمبيوتر", "الشبكة", "سلة المحذوفات" };
        string[] y = { "تعز", "حجة", "صنعاء" };
        string[] t = { "انقره", "اسطنبول", "غتاهيه", "بنغازية" };
        string[] m = { "مصر", "اسكندريه" };
        string[] s = { "الرياض", "جدة", "مكة" };
        public Frm_combox()
        {
            InitializeComponent();
        }

        private void Frm_combox_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(a);
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                pictureBox1.Image = Image.FromFile(comboBox1.SelectedIndex + 1 + ".JPG");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            switch (comboBox2.Text)
            {
                case "اليمن":
                    comboBox3.Items.AddRange(y);
                    break;
                case "تركيا":
                    comboBox3.Items.AddRange(t);
                    break;
                case "مصر":
                    comboBox3.Items.AddRange(m);
                    break;
                case "السعودية":
                    comboBox3.Items.AddRange(s);
                    break;
                default:
                    break;
                
            }
        }
    }
}
