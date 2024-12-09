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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("هل تريد الخروج من البرنامج", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //    return;
            //}
            Application.Exit();

        }

        private void برنامجالالةالحاسبةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Calc frm = new Frm_Calc();
            this.Hide();
            frm.ShowDialog();
            this.Show();

        }

        private void قراءةنصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_change frm = new Frm_change();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CheckBox frm = new Frm_CheckBox();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void radiobtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_radio frm = new Frm_radio();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void checkRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_cherad frm = new Frm_cherad();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void listboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_list frm = new Frm_list();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void listbox2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_list2 frm = new Frm_list2();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void comboboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_combox frm = new Frm_combox();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_timer frm = new frm_timer();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
