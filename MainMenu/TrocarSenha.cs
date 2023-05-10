using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainMenu.Forms.InfoBoxs;

namespace MainMenu
{
    public partial class TrocarSenha : Form
    {
        public long identify;
        public string nomeF;
        NpgsqlConnection conec;
        string cpf;
        long cargo;
        DateTime entrada;
        public TrocarSenha(string identif, long id_cargo, long identify)
        {
            cpf = identif;
            cargo = id_cargo;
            InitializeComponent();
            this.identify = identify;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbox_nova.Text != textbox_confirma.Text)
                {
                    MessageBox.Show("As senhas não coincidem.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (textbox_nova.Text == string.Empty && textbox_confirma.Text == string.Empty)
                {
                    MessageBox.Show("Favor preencher os campos corretamente.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string Postgres_Source = "Host=pim.postgres.database.azure.com;" +
                                         "Port=5432;" +
                                         "Database=Teste02;" +
                                         "Username=ricardinholord;" +
                                         "Password=Maluco777;";
                conec = new NpgsqlConnection(Postgres_Source);
                string Sql_NovaSenha = "update login set senha = @senha_nova where senha = '123' and login = @identif";

                NpgsqlCommand comando = new NpgsqlCommand(Sql_NovaSenha, conec);
                conec.Open();

                comando.Parameters.AddWithValue("@senha_nova", textbox_confirma.Text);
                comando.Parameters.AddWithValue("@identif", cpf);

                var executou = comando.ExecuteNonQuery();

                if (executou == 1)
                {
                    MessageBox.Show("Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (cargo > 1)
                    {
                        new FormFuncionario(identify,nomeF, entrada).Show();
                        this.Hide();
                    }
                    else
                    {
                        new FormAdm().Show();
                        this.Hide();
                    }
                }
                else
                {
                    AlertBoxArtan(Color.LightGoldenrodYellow, Color.Goldenrod, "Aviso", "Senha não alterada, verifique", Properties.Resources.box_important_48px);
                }
            }
            catch (Exception ex) { }
            finally { conec.Close(); }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textbox_nova_TextChanged(object sender, EventArgs e)
        {
            lblNovaSenha.Visible = true;
        }

        private void textbox_confirma_TextChanged(object sender, EventArgs e)
        {
            lblConfirmeNovaSenha.Visible = true;
        }
    }
}
