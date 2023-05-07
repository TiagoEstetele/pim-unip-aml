using MainMenu.Forms;
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
using static MainMenu.Forms.Funcionarios;

namespace MainMenu
{
    public partial class Perfil : Form
    {
        string connectionString = "Host=pim.postgres.database.azure.com;" +
                                    "Port=5432;" +
                                    "Database=Teste02;" +
                                    "Username=ricardinholord;" +
                                    "Password=Maluco777;";
        NpgsqlConnection connection = null;
        public List<RelatorioHoras> Horas = new List<RelatorioHoras>();
        public long idfun;
        public Perfil(long idfun)
        {
            this.idfun = idfun;
            InitializeComponent();
            PreencherPerfil(idfun);
            PreencherRelatorioDeHoras(idfun);
        }

        private void PreencherPerfil(long idfun)
        {
            string strcad = "select * from funcionario where id_funcionario=@idfun";
            string cargo;
            string id;
            connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);
            comando.Parameters.AddWithValue("@idfun", idfun);

            try
            {
                NpgsqlDataReader dr = comando.ExecuteReader();

                dr.Read();

                txtNome.Text = Convert.ToString(dr["Nome"]);
                txtAdmissao.Text = Convert.ToString(dr["data_admissao"]);
                txtCTPS.Text = Convert.ToString(dr["ctps"]);
                txtCPF.Text = Convert.ToString(dr["cpf"]);
                id = Convert.ToString(dr["id_funcionario"]);
                lblID.Text = "#" + id;
                cargo = Convert.ToString(dr["id_cargo"]);
                if (cargo == "1")
                lblCargo.Text = "Departamento Pessoal";
                if (cargo == "2")
                lblCargo.Text = "Analista De Sistemas";
                if (cargo == "3")
                lblCargo.Text = "Estagiario";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void PreencherRelatorioDeHoras(long idfun)
        {
            string strcad = "select id_funcionario as ID, data_entrada as Entrada, data_saida as Saida, mes as Mes from controle_de_horas where id_funcionario = @idfun order by id";
            connection = new NpgsqlConnection(connectionString);

            connection.Open();
            NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

            comando.Parameters.AddWithValue("@idfun", idfun);

            var reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Horas.Add(new RelatorioHoras
                {
                    Entrada = reader.GetDateTime(1),
                    Saida = reader.GetDateTime(2),
                    Mes = reader.GetInt32(3),
                });
            }

            dgvRelatorioHoras.DataSource = Horas;
            dgvRelatorioHoras.ReadOnly = true;
            dgvRelatorioHoras.Columns[0].Width = 200;
            dgvRelatorioHoras.Columns[1].Width = 189;
            dgvRelatorioHoras.Columns[2].Width = 50;
        }
        public class RelatorioHoras
        {
            public DateTime Entrada { get; set; }
            public DateTime Saida { get; set; }
            public int Mes { get; set; }
        }
    }
}
