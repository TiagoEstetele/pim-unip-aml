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
using static MainMenu.Forms.Cadastro;

namespace MainMenu.Forms
{
    public partial class EsqueciSenha : Form
    {
        public long identify;
        public string nomeF;
        NpgsqlConnection conec;
        public EsqueciSenha()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCPF_Click(object sender, EventArgs e)
        {
            try
            {
                txtCPF.SelectionStart = txtCPF.TextLength;
            }
            catch { }
            if (txtCPF.Text == "CPF")
            {
                txtCPF.Clear();
            }
        }

        private void txtData_Click(object sender, EventArgs e)
        {
            try
            {
                txtData.SelectionStart = txtData.TextLength;
            }
            catch { }
            if (txtData.Text == "Data de nascimento")
            {
                txtData.Clear();
            }
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string postgres_source = "Host=pim.postgres.database.azure.com;" +
                                         "Port=5432;" +
                                         "Database=Teste02;" +
                                         "Username=ricardinholord;" +
                                         "Password=Maluco777;";

            conec = new NpgsqlConnection(postgres_source);

            string sql_verific = "select id_funcionario as id, id_cargo as idc, cpf as CPF, data_nascimento as DATAN from funcionario where cpf = @CPF and data_nascimento = @DATAN";

            NpgsqlCommand comando = new NpgsqlCommand(sql_verific, conec);
            conec.Open();

            comando.Parameters.AddWithValue("@CPF", NpgsqlTypes.NpgsqlDbType.Varchar, txtCPF.Text);
            comando.Parameters.AddWithValue("@DATAN", NpgsqlTypes.NpgsqlDbType.Date, DateTime.Parse(txtData.Text));

            NpgsqlDataReader reader = comando.ExecuteReader();
            string identif = txtCPF.Text;

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    Int64 identify = Convert.ToInt64(reader[0]);
                    Int64 id_cargo = Convert.ToInt64(reader[1]);

                    if (txtCPF.Text == "" || txtData.Text == "")
                    {
                        MessageBox.Show("Favor preencher os campos corretamente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        panelVerificao.Visible = false;
                        panelTrocarSenha.Visible = true;
                    }
                }
            }
            else
                MessageBox.Show("Os dados não conferem, favor verificar.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string Sql_NovaSenha = "update login set senha = @senha_nova where login = @identif";

                NpgsqlCommand comando = new NpgsqlCommand(Sql_NovaSenha, conec);
                conec.Open();

                comando.Parameters.AddWithValue("@senha_nova", textbox_confirma.Text);
                comando.Parameters.AddWithValue("@identif", txtCPF.Text);

                var executou = comando.ExecuteNonQuery();

                if (executou == 1)
                {
                    MessageBox.Show("Sucesso! Você será redirecionado para a tela de login para prosseguir com o acesso assim que pressionar 'ok'", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    new FormLogin().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha não alterada, verifique", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { }
            finally { conec.Close(); }
        }
    }
}
