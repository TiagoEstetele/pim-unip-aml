using Npgsql;
using NpgsqlTypes;
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
using MainMenu.Forms.InfoBoxs;
using Microsoft.Office.Interop.Word;

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
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            if (txtData.Text == "Data de Nascimento")
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

            if (txtCPF.Text == "   .   .   -" || txtCPF.Text.Length < 14 || txtData.Text == "  /  /" || txtCPF.Text.Length < 10)
            {
                AlertBoxArtan(Color.LightPink, Color.DarkRed, "Error", "Favor preencher os campos corretamente!", Properties.Resources.close_48px);
                return;
            }
            else
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql_verific, conec);
                conec.Open();

                comando.Parameters.AddWithValue("@CPF", NpgsqlTypes.NpgsqlDbType.Varchar, txtCPF.Text);
                comando.Parameters.AddWithValue("@DATAN", DateTime.Parse(txtData.Text));

                NpgsqlDataReader reader = comando.ExecuteReader();
                string identif = txtCPF.Text;

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Int64 identify = Convert.ToInt64(reader[0]);
                        Int64 id_cargo = Convert.ToInt64(reader[1]);

                        panelVerificao.Visible = false;
                        panelTrocarSenha.Visible = true;
                    }
                }
                else
                    AlertBoxArtan(Color.LightPink, Color.DarkRed, "Error", "Os dados não conferem, favor verificar.", Properties.Resources.close_48px);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbox_nova.Text != textbox_confirma.Text)
                {
                    AlertBoxArtan(Color.LightPink, Color.DarkRed, "Error", "As senhas não coincidem.", Properties.Resources.close_48px);
                    return;
                }
                else if (textbox_nova.Text == string.Empty && textbox_confirma.Text == string.Empty)
                {
                    AlertBoxArtan(Color.LightPink, Color.DarkRed, "Error", "Favor preencher os campos.", Properties.Resources.close_48px);
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
                    AlertBoxArtan(Color.LightGreen, Color.SeaGreen, "Successo", "Senha alterada com sucesso!", Properties.Resources.ok_48px);
                    new FormLogin().Show();
                    this.Close();
                }
                else
                {
                    AlertBoxArtan(Color.LightPink, Color.DarkRed, "Error", "Senha não alterada, verifique.", Properties.Resources.close_48px);
                }
            }
            catch (Exception ex) { }
            finally { conec.Close(); }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            lblCPF.Visible = true;
            try
            {
                lblCPF.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");
            }
            catch { }
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            lblData.Visible = true;
            try
            {
                txtData.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");
            }
            catch { }
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignIn.PerformClick();
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignIn.PerformClick();
            }
        }

        private void textbox_nova_TextChanged(object sender, EventArgs e)
        {
            lblNovaSenha.Visible = true;
            try
            {
                textbox_nova.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");
            }
            catch { }
        }

        private void textbox_nova_Click(object sender, EventArgs e)
        {
            try
            {
                textbox_nova.SelectionStart = textbox_nova.TextLength;
            }
            catch { }
            if (textbox_nova.Text == "Nova Senha")
            {
                textbox_nova.Clear();
            }
        }

        private void textbox_confirma_TextChanged(object sender, EventArgs e)
        {
            lblConfirmeNovaSenha.Visible = true;
            try
            {
                textbox_confirma.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");
            }
            catch { }
        }

        private void textbox_confirma_Click(object sender, EventArgs e)
        {
            try
            {
                textbox_confirma.SelectionStart = textbox_confirma.TextLength;
            }
            catch { }
            if (textbox_confirma.Text == "Confirme Senha")
            {
                textbox_confirma.Clear();
            }
        }
    }
}
