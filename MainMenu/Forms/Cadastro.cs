using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MainMenu.Forms
{
    public partial class Cadastro : Form
    {
        private readonly int? IdFuncionario = null;

        string connectionString = "Host=pim.postgres.database.azure.com;" +
                                    "Port=5432;" +
                                    "Database=Teste02;" +
                                    "Username=ricardinholord;" +
                                    "Password=Maluco777;";
        NpgsqlConnection connection = null;
        private string strsql = string.Empty;
        public List<Cargo> cargoList = new List<Cargo>();
        public Cadastro()
        {
            InitializeComponent();
            PreencherComboCargo();
        }
        public Cadastro(int idFuncionario)
        {

            IdFuncionario = idFuncionario;
            InitializeComponent();
            PreencherComboCargo();
            Buscar(idFuncionario);
            PreencherLabel();
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

                comboCargo.DisplayMember = "CargoDescricao";
                comboCargo.ValueMember = "Id";
                comboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
                comboCargo.DataSource = cargoList;
                //comboCargo.SelectedItem = cargoList.FirstOrDefault(x => x.Id = );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }
        public class Cargo
        {
            public string CargoDescricao { get; set; }
            public int Id { get; set; }
        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDataNascimento.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtDataNascimento_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtDataNascimento.SelectAll();
            }
            catch { }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtCPF.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtCPF_Click(object sender, EventArgs e)
        {
            try
            {
                txtCPF.SelectAll();
            }
            catch { }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtNome.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.SelectAll();
            }
            catch { }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmail.SelectAll();
            }
            catch { }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {
            try
            {
                txtTelefone.SelectAll();
            }
            catch { }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTelefone.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtEndereco_Click(object sender, EventArgs e)
        {
            try
            {
                txtTelefone.SelectAll();

            }
            catch { }
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtEndereco.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSalario.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtSalario_Click(object sender, EventArgs e)
        {
            try
            {
                txtSalario.SelectAll();

            }
            catch { }
        }

        private void txtBanco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtBanco.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtBanco_Click(object sender, EventArgs e)
        {
            try
            {
                txtBanco.SelectAll();

            }
            catch { }
        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtConta.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtConta_Click(object sender, EventArgs e)
        {
            try
            {
                txtConta.SelectAll();

            }
            catch { }
        }

        private void txtCTPS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtCTPS.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtCTPS_Click(object sender, EventArgs e)
        {
            try
            {
                txtCTPS.SelectAll();

            }
            catch { }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IdFuncionario == null)
            {
                string strcad = "insert into funcionario (nome,data_admissao,ctps,data_nascimento,banco,conta,cpf,email,ativo,endereco,id_cargo,salario_bruto,telefone) values(@nome,@data_admissao,@ctps,@data_nascimento,@banco,@conta,@cpf,@email,@ativo,@endereco,@id_cargo,@salario_bruto,@telefone); select currval('funcionario_id_funcionario_seq');";
                connection = new NpgsqlConnection(connectionString);

                connection.Open();
                try
                {
                    NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

                    comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@data_admissao", Convert.ToDateTime(txtAdmissao.Text));
                    comando.Parameters.AddWithValue("@ctps", txtCTPS.Text);
                    comando.Parameters.AddWithValue("@data_nascimento", Convert.ToDateTime(txtDataNascimento.Text));
                    comando.Parameters.AddWithValue("@banco", txtBanco.Text);
                    comando.Parameters.AddWithValue("@conta", txtConta.Text);
                    comando.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    comando.Parameters.AddWithValue("@email", txtEmail.Text);
                    comando.Parameters.AddWithValue("@ativo", btnAtivo.Checked);
                    comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    comando.Parameters.AddWithValue("@id_cargo", int.Parse(comboCargo.SelectedValue.ToString()));
                    comando.Parameters.AddWithValue("@salario_bruto", double.Parse(txtSalario.Text));

                    comando.Prepare();
                    int id_funcionario = Convert.ToInt32(comando.ExecuteScalar());

                    MessageBox.Show("CADASTRO EFETUADO COM SUCESSO");

                    string strlog = "insert into login (login, senha, id_funcionario) values(@login, '123', @id_funcionario)";

                    NpgsqlCommand comando2 = new NpgsqlCommand(strlog, connection);

                    comando2.Parameters.AddWithValue("@login", txtCPF.Text);
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
            else
            {
                string strcad = "UPDATE funcionario SET nome=@nome, data_admissao=@data_admissao, ctps=@ctps, data_nascimento=@data_nascimento, banco=@banco, conta=@conta, cpf=@cpf, email=@email, ativo=@ativo, endereco=@endereco, id_cargo=@id_cargo, salario_bruto=@salario_bruto, telefone=@telefone WHERE id_funcionario=@id_funcionario";
                ;
                connection = new NpgsqlConnection(connectionString);

                connection.Open();
                try
                {
                    NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

                    comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@data_admissao", Convert.ToDateTime(txtAdmissao.Text));
                    comando.Parameters.AddWithValue("@ctps", txtCTPS.Text);
                    comando.Parameters.AddWithValue("@data_nascimento", Convert.ToDateTime(txtDataNascimento.Text));
                    comando.Parameters.AddWithValue("@banco", txtBanco.Text);
                    comando.Parameters.AddWithValue("@conta", txtConta.Text);
                    comando.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    comando.Parameters.AddWithValue("@email", txtEmail.Text);
                    comando.Parameters.AddWithValue("@ativo", btnAtivo.Checked);
                    comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    comando.Parameters.AddWithValue("@id_cargo", int.Parse(comboCargo.SelectedValue.ToString()));
                    comando.Parameters.AddWithValue("@salario_bruto", double.Parse(txtSalario.Text));
                    comando.Parameters.AddWithValue("@id_funcionario", IdFuncionario);

                    comando.Prepare();
                    int id_funcionario = Convert.ToInt32(comando.ExecuteScalar());

                    MessageBox.Show("O FUNCIONARIO FOI ATUALIZADO");

                    string strlog = "update login set login=@login where id_funcionario=@id_funcionario";

                    NpgsqlCommand comando2 = new NpgsqlCommand(strlog, connection);

                    comando2.Parameters.AddWithValue("@login", txtCPF.Text);
                    comando2.Parameters.AddWithValue("@id_funcionario", IdFuncionario);

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

        }
        private void Buscar(int id)
        {
            string strcad = "select * from funcionario where id_funcionario=@buscar";
            connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);
            comando.Parameters.AddWithValue("@buscar", id);

            try
            {
                //if (txt_buscar.Text == string.Empty)
                //{
                //    MessageBox.Show("Você não digitou um nome");
                //}
                NpgsqlDataReader dr = comando.ExecuteReader();

                dr.Read();

                if (dr.HasRows == false)
                {
                    throw new Exception("Este nome não está cadastrado");
                }

                txtNome.Text = Convert.ToString(dr["Nome"]);
                txtAdmissao.Text = Convert.ToString(dr["data_admissao"]);
                txtCTPS.Text = Convert.ToString(dr["ctps"]);
                txtDataNascimento.Text = Convert.ToString(dr["data_nascimento"]);
                txtBanco.Text = Convert.ToString(dr["banco"]);
                txtConta.Text = Convert.ToString(dr["conta"]);
                txtCPF.Text = Convert.ToString(dr["cpf"]);
                txtEmail.Text = Convert.ToString(dr["email"]);
                btnAtivo.Checked = Convert.ToBoolean(dr["ativo"]);
                txtEndereco.Text = Convert.ToString(dr["endereco"]);
                txtTelefone.Text = Convert.ToString(dr["telefone"]);
                comboCargo.SelectedValue = Convert.ToInt32(dr["id_cargo"]);
                txtSalario.Text = Convert.ToString(dr["salario_bruto"]);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblText_Click(object sender, EventArgs e)
        {
        }
        private void PreencherLabel()
        {
            lblText.Text = "Editar Funcionario";
            pictureBoxDinamic.Image = Properties.Resources.edit_48px;
        }
    }
}
