using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form1;
using Npgsql;
using NpgsqlTypes;

namespace cadastrarFuncionario
{
    public partial class Alterar_Senha : Form
    {
        NpgsqlConnection conec;
        string cpf;
        long cargo;
        public Alterar_Senha(string identif, long id_cargo)
        {
            cpf = identif;
            cargo = id_cargo;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvarsenha_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_senha1.Text != txt_senha2.Text)
                {
                    MessageBox.Show("As senhas não coincidem", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                string Postgres_Source = "host=localhost;port=5432;database=ibh_pim;username=postgres;password=admin";
                conec = new NpgsqlConnection(Postgres_Source);
                string Sql_NovaSenha = "update login set senha = @senha_nova where senha = '123' and login = @identif";
                
                NpgsqlCommand comando = new NpgsqlCommand(Sql_NovaSenha, conec);
                conec.Open();

                comando.Parameters.AddWithValue("@senha_nova", txt_senha2.Text);
                comando.Parameters.AddWithValue("@identif", cpf);

                var executou = comando.ExecuteNonQuery();
                
                if (executou == 1)
                {
                    MessageBox.Show("A senha foi alterada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (cargo > 1)
                    {
                        new Form1().Show();
                        this.Hide();
                    }
                    else
                    {
                        new DP().Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("A senha não foi alterada, favor verificar!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { }
            finally {  conec.Close(); }
        }
    }
}
