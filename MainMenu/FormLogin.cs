using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainMenu
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximaze_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textbox_login_Click(object sender, EventArgs e)
        {
            textbox_login.Clear();
            panel1.ForeColor = Color.FromArgb(35, 35, 54);
            textbox_login.ForeColor = Color.FromArgb(35, 35, 54);
        }

        private void textbox_password_Click(object sender, EventArgs e)
        {
            textbox_password.Clear();
            textbox_password.PasswordChar = '●';
            textbox_password.Font = new Font("Montserrat Medium", 12);
            panel2.ForeColor = Color.FromArgb(35, 35, 54);
            textbox_password.ForeColor = Color.FromArgb(35, 35, 54);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void textbox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordBtn.Checked)
            {
                textbox_password.PasswordChar = '\0';
            }
            else
            {
                textbox_password.PasswordChar = '●';
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
