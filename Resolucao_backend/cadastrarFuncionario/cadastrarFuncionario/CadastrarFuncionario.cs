using System;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using Form1;
using Npgsql;

namespace cadastrarFuncionario
{
    public partial class CadastrarFuncionario : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=PIM_3;Username=postgres;Password=1902;";
        NpgsqlConnection connection = null;
        private string strsql = string.Empty;
        public List<Cargo> cargoList = new List<Cargo>();
        public CadastrarFuncionario()
        {
            InitializeComponent();
            PreencherComboCargo();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PreencherComboCargo()
        {
            string strsql = "select * from cargo";

            connection = new NpgsqlConnection(connectionString);

            connection.Open();
            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(strsql, connection);
                var consulta = comando.ExecuteReader();
                while (consulta.Read())
                {
                    cargoList.Add(new Cargo
                    {
                        CargoDescricao = consulta[1].ToString(),
                        Id = int.Parse(consulta[0].ToString())
                    });
                }

                cmb_cargo.DisplayMember = "CargoDescricao";
                cmb_cargo.ValueMember = "Id";
                cmb_cargo.DropDownStyle = ComboBoxStyle.DropDownList;
                cmb_cargo.DataSource = cargoList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string strcad = "insert into dado_funcionario (nome,data_admissao,ctps,data_nascimento,banco,conta,cpf,email,ativo,endereco,id_cargo,salario_bruto,telefone) values(@nome,@data_admissao,@ctps,@data_nascimento,@banco,@conta,@cpf,@email,@ativo,@endereco,@id_cargo,@salario_bruto,@telefone); select currval('dado_funcionario_id_funcionario_seq');";
            connection = new NpgsqlConnection(connectionString);

            connection.Open();
            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

                comando.Parameters.AddWithValue("@nome", txt_nome.Text);
                comando.Parameters.AddWithValue("@data_admissao", Convert.ToDateTime(txt_admissao.Text));
                comando.Parameters.AddWithValue("@ctps", txt_ctps.Text);
                comando.Parameters.AddWithValue("@data_nascimento", Convert.ToDateTime(txt_nascimento.Text));
                comando.Parameters.AddWithValue("@banco", txt_banco.Text);
                comando.Parameters.AddWithValue("@conta", txt_conta.Text);
                comando.Parameters.AddWithValue("@cpf", txt_cpf.Text);
                comando.Parameters.AddWithValue("@email", txt_email.Text);
                comando.Parameters.AddWithValue("@ativo", cb_ativo.Checked);
                comando.Parameters.AddWithValue("@endereco", txt_endereco.Text);
                comando.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                comando.Parameters.AddWithValue("@id_cargo", int.Parse(cmb_cargo.SelectedValue.ToString()));
                comando.Parameters.AddWithValue("@salario_bruto", double.Parse(txt_salario.Text));

                comando.Prepare();
                int id_funcionario = Convert.ToInt32(comando.ExecuteScalar());

                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO");

                string strlog = "insert into login (login, senha, id_funcionario) values(@login, '123', @id_funcionario)";

                NpgsqlCommand comando2 = new NpgsqlCommand(strlog, connection);

                comando2.Parameters.AddWithValue("@login", txt_cpf.Text);
                comando2.Parameters.AddWithValue("@id_funcionario", id_funcionario);

                comando2.Prepare();
                comando2.ExecuteNonQuery();
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

        private void cck_atvio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Cargo
    {
        public string CargoDescricao { get; set; }
        public int Id { get; set; }
    }
}