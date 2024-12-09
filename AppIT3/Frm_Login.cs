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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

       

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_name .Text == "Ahmed" && txt_password.Text == "123")
            {
                Frm_Main frm = new Frm_Main();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                txt_name.Clear();
                txt_password.Clear();
                txt_name.Focus();
            }
            else
                MessageBox.Show("المستخدم غير موجود");
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_name.Text.Trim() !=string.Empty)
                txt_password.Focus();
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_password.Text.Trim() != string.Empty)
                btn_login_Click(null, null);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                txt_password.PasswordChar = '\0';
            else
                txt_password.PasswordChar = '*';

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Frm_Main frm = new Frm_Main();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            timer1.Enabled = false;

        }
    }
}
