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

namespace MainMenu.Forms
{
    public partial class Ponto : Form
    {
        public long identify;
        public string nomeF;
        long idfun;
        DateTime entrada, saida;
        NpgsqlConnection conec;
        TimeSpan total;
        public Ponto(long identify, string nomeF)
        {
            this.nomeF = nomeF;
            this.identify = identify;
            InitializeComponent();
            lblTextWelcome.Text = $"Bem vindo {nomeF}!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = DateTime.Now.ToString("T");
        }

        private void Ponto_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormFuncionario form = new FormFuncionario(identify, nomeF);
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

        private void total_horas2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBater_Click_1(object sender, EventArgs e)
        {
            try
            {
                int horas;
                int minutos;
                int segundos;
                int horaExtra;
                DateTime date = new DateTime();
                int mes = 0;

                string postgres_source = "Host=pim.postgres.database.azure.com;" +
                                         "Port=5432;" +
                                         "Database=Teste02;" +
                                         "Username=ricardinholord;" +
                                         "Password=Maluco777;";

                conec = new NpgsqlConnection(postgres_source);
                string sql_hora = "insert into controle_de_horas (id_funcionario, data_entrada, data_saida, mes, horas_total)" +
                                  " values (@idfun, @data_ent, @data_sai, @mes, @horas_total)";

                NpgsqlCommand comando = new NpgsqlCommand(sql_hora, conec);
                conec.Open();

                if (hora_entrada.Text != "")
                {
                    hora_saida.Text = DateTime.Now.ToString();
                    saida = DateTime.Parse(hora_saida.Text);
                    date = DateTime.Now;
                    mes = (date.Month);
                    AlertBoxArtan(Color.LightGreen, Color.SeaGreen, "Successo", "Hora de saída cadastrada!", Properties.Resources.ok_48px);
                }
                else
                {
                    hora_entrada.Text = DateTime.Now.ToString();
                    entrada = DateTime.Parse(hora_entrada.Text);
                    AlertBoxArtan(Color.LightGreen, Color.SeaGreen, "Successo", "Hora de entrada cadastrada", Properties.Resources.ok_48px);
                }

                total = saida - entrada;

                horas = total.Hours;
                minutos = total.Minutes;
                double minutosconv = minutos / 60;
                double totalhoras = horas + minutosconv;
                segundos = total.Seconds;
                horaExtra = 0;



                if (horas > 8)
                {
                    horaExtra = horas % 8;
                }

                if (hora_entrada.Text != "" && hora_saida.Text != "")
                {
                    total_horas.Text = $"Sua carga horária de hoje foi de {horas} hora(s) e {minutos} minuto(s)";
                    total_horas2.Text = $"em adição, {horaExtra} hora(s) extras.";
                   

                    comando.Parameters.AddWithValue("@idfun", identify);
                    comando.Parameters.AddWithValue("@data_ent", entrada);
                    comando.Parameters.AddWithValue("@data_sai", saida);
                    comando.Parameters.AddWithValue("@mes", mes);
                    comando.Parameters.AddWithValue("@horas_total", totalhoras);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { }
            finally { conec.Close(); }
        }
    }
}
