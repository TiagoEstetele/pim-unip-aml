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

namespace MainMenu
{
    public partial class TrocarSenha : Form
    {
        public long identify;
        NpgsqlConnection conec;
        string cpf;
        long cargo;
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
                }
                else if (textbox_nova.Text == string.Empty && textbox_confirma.Text == string.Empty)
                {
                    MessageBox.Show("Favor preencher os campos corretamente.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("A senha foi alterada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (cargo > 1)
                    {
                        new FormFuncionario(identify).Show();
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
                    MessageBox.Show("A senha não foi alterada, favor verificar!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { }
            finally { conec.Close(); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
