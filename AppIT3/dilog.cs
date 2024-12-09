using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppIT3
{
    public partial class dilog : Form
    {
        public dilog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "open file";
            ofd.Filter = "all image| *.Jpg;*.PNG;*.bmb";
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdf = new SaveFileDialog();
            sdf.Title = "save as";
            sdf.Filter = "text documents(.txt)|*,txt|word documents(.docx)|*,.docx";
            if (sdf.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sdf.FileName, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                this.BackColor = cd.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                textBox1.Font = fd.Font;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // FolderBrowserDialog fbd = new FolderBrowserDialog();
            //if()
            //textBox1.Text
        }

        private void dilog_Load(object sender, EventArgs e)
        {

        }
    }
}
