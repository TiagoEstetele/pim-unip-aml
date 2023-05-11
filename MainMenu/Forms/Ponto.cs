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
using MainMenu.Forms.alertBoxPrincipal;
using System.Configuration;
using System.Runtime.Caching;

namespace MainMenu.Forms
{
    public partial class Ponto : Form
    {
        public long identify;
        public string nomeF;
        int horas, minutos, horaExtra;
        string nome;
        long idfun;
        DateTime entrada, saida;
        string entradaCache, saidaCache;
        NpgsqlConnection conec;
        TimeSpan total;
        MemoryCache cache = MemoryCache.Default;
        public Ponto(long identify, string nomeF, DateTime entrada)
        {
            this.entrada = entrada;
            this.nomeF = nomeF;
            this.identify = identify;
            InitializeComponent();
            lblTextWelcome.Text = $"Bem vindo {nomeF}!";
            hora_entrada.Text = cache.Get($"{identify}{identify}") as string;
            hora_saida.Text = cache.Get($"{identify}{identify}{identify}") as string;
            total_horas.Text = $"Sua carga horária de hoje foi de {horas} hora(s) e {minutos} minuto(s)";
            total_horas2.Text = $"em adição, {horaExtra} hora(s) extras.";
        }

        private void Ponto_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormFuncionario form = new FormFuncionario(identify, nomeF, entrada);
            form.Show();
        }

        void AlertBoxArtan(Color backColor, Color color, string title, string text, Image icon)
        {
            AlertBoxPrincipal alertBox = new AlertBoxPrincipal();
            alertBox.BackColor = backColor;
            alertBox.ColorAlertBox = color;
            alertBox.TitleAlertBox = title;
            alertBox.TextAlertBox = text;
            alertBox.IconeColorAlertBox = icon;
            alertBox.ShowDialog();
        }

        private void lblTextWelcome_Click(object sender, EventArgs e)
        {

        }

        private void hora_saida_TextChanged(object sender, EventArgs e)
        {
            btnBater.Text = "Bom descanso!";
            btnBater.Enabled = false;
            total_horas.Visible = true;
            total_horas2.Visible = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblStatus.Text = DateTime.Now.ToString("T");
        }

        private void total_horas2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBater_Click_1(object sender, EventArgs e)
        {
            try
            {
                double totalhoras = 0;
                int horas;
                int minutos;
                int segundos;
                int horaExtra;
                DateTime date = new DateTime();
                int mes = 0;

                string postgres_source = "Host=bancoaml.postgres.database.azure.com;" +
                                         "Port=5432;" +
                                         "Database=Banco_AML;" +
                                         "Username=ADM_AML;" +
                                         "Password=Banco2023;";

                conec = new NpgsqlConnection(postgres_source);
                string sql_hora = "insert into controle_de_horas (id_funcionario, data_entrada, data_saida, mes, horas_total)" +
                                  " values (@idfun, @data_ent, @data_sai, @mes, @horas_total)";

                NpgsqlCommand comando = new NpgsqlCommand(sql_hora, conec);
                conec.Open();

                if (hora_entrada.Text != "")
                {
                    date = DateTime.Now;
                    mes = (date.Month);
                    hora_saida.Text = DateTime.Now.ToString();
                    cache.Add($"{identify}{identify}{identify}", hora_saida.Text, DateTimeOffset.Now.AddMinutes(3600));
                    saida = DateTime.Parse(hora_saida.Text);
                    entradaCache = cache.Get($"{identify}{identify}") as string;

                    comando.Parameters.AddWithValue("@idfun", identify);
                    comando.Parameters.AddWithValue("@data_ent", DateTime.Parse(entradaCache)); //1231
                    comando.Parameters.AddWithValue("@data_sai", saida);
                    comando.Parameters.AddWithValue("@mes", mes);
                    comando.Parameters.AddWithValue("@horas_total", totalhoras);

                    saidaCache = cache.Get($"{identify}{identify}{identify}") as string;

                    comando.ExecuteNonQuery();
                    conec.Close();
                    AlertBoxArtan(Color.LightGreen, Color.SeaGreen, "Successo", "Hora de saída cadastrada!", Properties.Resources.ok_48px);
                }
                else if (hora_entrada.Text == "")
                {
                    hora_entrada.Text = DateTime.Now.ToString();
                    cache.Add($"{identify}{identify}", hora_entrada.Text, DateTimeOffset.Now.AddMinutes(3600));
                    entrada = DateTime.Parse(hora_entrada.Text);
                    entradaCache = cache.Get($"{identify}{identify}") as string;
                    AlertBoxArtan(Color.LightGreen, Color.SeaGreen, "Successo", "Hora de entrada cadastrada", Properties.Resources.ok_48px);
                }

                total = saida - DateTime.Parse(hora_entrada.Text);

                horas = total.Hours;
                minutos = total.Minutes;
                double minutosconv = minutos / 60;
                totalhoras = horas + minutosconv;
                segundos = total.Seconds;
                horaExtra = 0;

                if (horas > 8)
                {
                    horaExtra = horas % 8;
                }
            }
            catch (Exception ex) { }
            finally { }
        }
    }
}
