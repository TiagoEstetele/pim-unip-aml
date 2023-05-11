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
            string strcad = "select id_funcionario as ID, nome as Nome, cpf as CPF, data_admissao as Admissao, salario_bruto as Salario, case when ativo = true then 'Sim' else 'Não' end as Ativo from funcionario where ativo = true";
            if (txtBuscar.Text.Trim().Length > 0)
            {
                strcad += " and lower(nome) like @Nome";
            }
            strcad += " order by id_funcionario";

            connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

            if (txtBuscar.Text.Trim().Length > 0)
            {
                comando.Parameters.AddWithValue("@Nome", "%" + txtBuscar.Text.ToLower() + "%");
            }

            var reader = comando.ExecuteReader();
            funcionarios.Clear();
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

            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.Rows.Clear();
            dgvFuncionarios.DataSource = funcionarios;
            dgvFuncionarios.ReadOnly = true;
            dgvFuncionarios.Refresh();
            dgvFuncionarios.Columns[1].Width = 50;
            dgvFuncionarios.Columns[2].Width = 50;
            dgvFuncionarios.Columns[3].Width = 180;
            dgvFuncionarios.Columns[4].Width = 180;
            dgvFuncionarios.Columns[5].Width = 100;
            dgvFuncionarios.Columns[6].Width = 100;
            dgvFuncionarios.Columns[7].Width = 147;


            connection.Close();
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
                PreencherDataGrid();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PreencherDataGrid();
            //string strcad = "select id_funcionario as ID, nome as Nome, cpf as CPF, data_admissao as Admissao, salario_bruto as Salario, case when ativo = true then 'Sim' else 'Não' end as Ativo from funcionario where ativo = true and id_funcionario=@idfun";

            //connection = new NpgsqlConnection(connectionString);

            //connection.Open();

            //NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

            //comando.Parameters.AddWithValue("@idfun", Convert.ToInt64(txtBuscar.Text));
            //comando.ExecuteNonQuery();

            //var reader = comando.ExecuteReader();
            //while (reader.Read())
            //{
            //    funcionarios.Add(new Funcionario
            //    {
            //        ID = reader.GetInt64(0),
            //        Nome = reader.GetString(1),
            //        CPF = reader.GetString(2),
            //        Admissao = reader.GetDateTime(3),
            //        Salario = reader.GetDecimal(4),
            //        Ativo = reader.GetString(5)
            //    });
            //}

            //dgvFuncionarios.DataSource = funcionarios;
            //dgvFuncionarios.ReadOnly = true;

            //connection.Close();
        }

      

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            PreencherDataGrid();
        }
    }
}
