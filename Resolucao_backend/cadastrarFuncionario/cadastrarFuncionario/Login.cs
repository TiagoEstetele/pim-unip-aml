using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using cadastrarFuncionario;
using Form1;
using Npgsql;

namespace cadastrarFuncionario
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conec;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lbl_user_Click(object sender, EventArgs e)
        {
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                string postgres_source = "host=localhost;port=5432;database=PIM_3;username=postgres;password=1902";
                conec = new NpgsqlConnection(postgres_source);
                string sql_login = "select d.id_cargo, d.ativo, d.id_funcionario from login l inner join dado_funcionario d on d.id_funcionario = l.id_funcionario where l.login= @login and l.senha= @senha";

                NpgsqlCommand comando = new NpgsqlCommand(sql_login, conec);
                conec.Open();

                comando.Parameters.AddWithValue("@login", txt_user.Text);
                comando.Parameters.AddWithValue("@senha", txt_senha.Text);

                NpgsqlDataReader reader = comando.ExecuteReader();
                string identif = txt_user.Text;


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Int64 id_cargo = Convert.ToInt64(reader[0]);
                        bool ativo = Convert.ToBoolean(reader[1]);
                        Int64 id_funcionario = Convert.ToInt64(reader[2]);

                        if (ativo)
                        {
                            if (txt_senha.Text == "123")
                            {
                                new Alterar_Senha(identif, id_cargo).Show();
                                new ControlePonto(id_funcionario);
                                this.Hide();
                            }
                            else if ((txt_user.Text == "admin" && txt_senha.Text == "admin") || id_cargo == 1)
                            {
                                new DP().Show();
                                this.Hide();
                            }
                            else
                            {
                                new Funcionario(id_funcionario).Show();
                                this.Hide();
                            }
                        }
                        else
                            MessageBox.Show("Usuário inativo, favor entrar em contato com seu superior", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Usuário ou senha inválidos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void cb_mostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrarsenha.Checked)
            {
                txt_senha.PasswordChar = '\0';
            }
            else
            {
                txt_senha.PasswordChar = '*';
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            new CadastrarFuncionario().Show();
            this.Hide();
        }
    }
}