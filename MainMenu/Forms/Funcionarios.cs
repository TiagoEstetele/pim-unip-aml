using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MainMenu.Forms
{
    public partial class Funcionarios : Form
    {
        private Form activeForm;
        private Button currentButton;
        string connectionString = "Host=pim.postgres.database.azure.com;" +
                              "Port=5432;" +
                              "Database=Teste02;" +
                              "Username=ricardinholord;" +
                              "Password=Maluco777;";
        NpgsqlConnection connection = null;
        public List<Funcionario> funcionarios = new List<Funcionario>();
        private readonly Panel panelDesktopPanel;

        public Funcionarios()
        {
            InitializeComponent();
            PreencherDataGrid();
            this.ControlBox = false;
        }
        private void PreencherDataGrid()
        {
            string strcad = "select id_funcionario as ID, nome as Nome, cpf as CPF, data_admissao as Admissao, salario_bruto as Salario, case when ativo = true then 'Sim' else 'Não' end as Ativo from funcionario order by id_funcionario";
            connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

            var reader = comando.ExecuteReader();
            while (reader.Read())
            {
                funcionarios.Add(new Funcionario
                {
                    ID = reader.GetInt64(0),
                    Nome = reader.GetString(1),
                    CPF = reader.GetString(2),
                    Admissao = reader.GetDateTime(3),
                    Salario = reader.GetDecimal(4),
                    Ativo = reader.GetString(5)
                });
            }

            dgvFuncionarios.DataSource = funcionarios;
            dgvFuncionarios.ReadOnly = true;
        }

        void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == dgvFuncionarios.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dgvFuncionarios.Columns["Perfil"].Index)
            {
                var data = (Funcionario)dgvFuncionarios.Rows[e.RowIndex].DataBoundItem;
                Perfil form = new Perfil(data.ID);
                form.ShowDialog();
            }
            if (e.ColumnIndex == dgvFuncionarios.Columns["Editar"].Index)
            {
                var data = (Funcionario)dgvFuncionarios.Rows[e.RowIndex].DataBoundItem;
                Cadastro form = new Cadastro(data.ID);
                form.ShowDialog();
            }
        }

        public class Funcionario
        {
            public long ID { get; set; }
            public string Nome { get; set; }
            public string CPF { get; set; }
            public DateTime Admissao { get; set; }
            public Decimal Salario { get; set; }
            public string Ativo { get; set; }
        }
    }
}
