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

namespace MainMenu.Forms
{
    public partial class Ponto : Form
    {
        public long identify;
        long idfun;
        DateTime entrada, saida;
        NpgsqlConnection conec;
        TimeSpan total;
        public Ponto(long identify)
        {
            this.identify = identify;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = DateTime.Now.ToString("T");
        }

        private void Ponto_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFuncionario form = new FormFuncionario(identify);
            form.Show();
        }

        private void btnBater_Click(object sender, EventArgs e)
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
                }
                else
                {
                    hora_entrada.Text = DateTime.Now.ToString();
                    entrada = DateTime.Parse(hora_entrada.Text);
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
                    total_horas.Text = $"Sua carga horária de hoje foi de {horas} hora(s) e {minutos} minuto(s), em adição, {horaExtra} hora(s) extras.";

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
