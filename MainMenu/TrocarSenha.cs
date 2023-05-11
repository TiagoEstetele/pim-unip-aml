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

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textbox_nova.Text != textbox_confirma.Text)
                {
                    AlertBoxArtan(Color.LightGoldenrodYellow, Color.Goldenrod, "Aviso", "As senhas não coincidem.", Properties.Resources.box_important_48px);

                    return;
                }
                else if (textbox_nova.Text == string.Empty && textbox_confirma.Text == string.Empty)
                {
                    AlertBoxArtan(Color.LightGoldenrodYellow, Color.Goldenrod, "Aviso", "Favor preencher os campos corretamente.", Properties.Resources.box_important_48px);

                    return;
                }

                string Postgres_Source = "Host=bancoaml.postgres.database.azure.com;" +
                                         "Port=5432;" +
                                         "Database=Banco_AML;" +
                                         "Username=ADM_AML;" +
                                         "Password=Banco2023;";
                conec = new NpgsqlConnection(Postgres_Source);
                string Sql_NovaSenha = "update login set senha = @senha_nova where senha = '123' and login = @identif";

                NpgsqlCommand comando = new NpgsqlCommand(Sql_NovaSenha, conec);
                conec.Open();

                comando.Parameters.AddWithValue("@senha_nova", textbox_confirma.Text);
                comando.Parameters.AddWithValue("@identif", cpf);

                var executou = comando.ExecuteNonQuery();

                if (executou == 1)
                {
                    AlertBoxArtan(Color.LightGreen, Color.SeaGreen, "Success", "A senha foi alterada!", Properties.Resources.ok_48px);


                    if (cargo > 1)
                    {
                        new FormFuncionario(identify, nomeF, entrada).Show();
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
            finally {
                if (conec != null)
                {
                    conec.Close();
                }
             }
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
