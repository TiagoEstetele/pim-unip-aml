using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;
using NpgsqlTypes;
using MainMenu.Forms.InfoBoxs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using MainMenu.Forms;

namespace MainMenu
{
    public partial class FormLogin : Form
    {
        public long identify;
        public string nome;
        NpgsqlConnection conec;

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
            try
            {
                textbox_login.SelectionStart = textbox_login.TextLength;
            }
            catch { }
            if (textbox_login.Text == "CPF")
            {
                textbox_login.Clear();
            }
        }

        private void textbox_password_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void textbox_password_TextChanged(object sender, EventArgs e)
        {
            lblPassword.Visible = true;
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
        
        void AlertBoxArtan(Color backColor, Color color, string title, string text, Image icon)
        {
            alertBox alertBox = new alertBox();
            alertBox.BackColor = backColor;
            alertBox.ColorAlertBox = color;
            alertBox.TitleAlertBox = title;
            alertBox.TextAlertBox = text;
            alertBox.IconeColorAlertBox = icon;
            alertBox.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
           
        }

        private void textbox_login_TextChanged(object sender, EventArgs e)
        {
            lblCPF.Visible = true;
            try
            {
                lblCPF.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");
            }
            catch { }
        }

        private void textbox_password_Click_1(object sender, EventArgs e)
        {
            try
            {
                textbox_password.SelectionStart = textbox_password.TextLength;
            }
            catch { }
            if (textbox_password.Text == "Password")
            {
                textbox_password.Clear();
            }
        }

        private void textbox_password_TextChanged_1(object sender, EventArgs e)
        {
            lblPassword.Visible = true;
            textbox_password.PasswordChar = '●';
            textbox_password.Font = new Font("Montserrat Medium", 12);
            panel2.ForeColor = Color.FromArgb(35, 35, 54);
            textbox_password.ForeColor = Color.FromArgb(35, 35, 54);
            try
            {
                textbox_password.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");
            }
            catch { }
        }

        private void textbox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Ativa o botão
                btnSignIn.PerformClick();
            }
        }

        private void textbox_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignIn.PerformClick();
            }
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string postgres_source = "Host=pim.postgres.database.azure.com;" +
                                         "Port=5432;" +
                                         "Database=Teste02;" +
                                         "Username=ricardinholord;" +
                                         "Password=Maluco777;";

                conec = new NpgsqlConnection(postgres_source);
                string sql_login = "select d.id_cargo, d.ativo, d.id_funcionario, d.nome from login l inner join funcionario d on d.id_funcionario = l.id_funcionario where l.login= @login and l.senha= @senha";

                NpgsqlCommand comando = new NpgsqlCommand(sql_login, conec);
                conec.Open();

                comando.Parameters.AddWithValue("@login", textbox_login.Text);
                comando.Parameters.AddWithValue("@senha", textbox_password.Text);

                NpgsqlDataReader reader = comando.ExecuteReader();
                string identif = textbox_login.Text;


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Int64 id_cargo = Convert.ToInt64(reader[0]);
                        bool ativo = Convert.ToBoolean(reader[1]);
                        Int64 identify = Convert.ToInt64(reader[2]);
                        string nome = Convert.ToString(reader[3]);

                        if (ativo)
                        {
                            if (textbox_password.Text == "123")
                            {
                                new TrocarSenha(identif, id_cargo, identify).Show();
                                this.Hide();
                            }
                            else if ((textbox_login.Text == "admin" && textbox_password.Text == "admin") || id_cargo == 1)
                            {
                                new FormAdm().Show();
                                this.Hide();
                            }
                            else
                            {
                                new FormFuncionario(identify, nome).Show();
                                this.Hide();
                            }
                        }
                        else
                            MessageBox.Show("Usuário inativo, favor entrar em contato com seu superior", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    AlertBoxArtan(Color.LightPink, Color.DarkRed, "Error", "Usuário ou senha inválidos", Properties.Resources.close_48px);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conec.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new EsqueciSenha().Show();
        }
    }
}
