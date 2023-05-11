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
using MainMenu.Forms.alertBoxCadastro;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Word;

namespace MainMenu.Forms
{
    public partial class Cadastro : Form
    {
        private readonly long? IdFuncionario = null;

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
            PreencherComboSexo();
        }
        public Cadastro(long idFuncionario)
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
            lblNome.Visible = true;
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
                txtNome.SelectionStart = txtEndereco.TextLength;
            }
            catch { }
            if (txtNome.Text == "Nome")
            {
                txtNome.Clear();
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmail.SelectionStart = txtEndereco.TextLength;
            }
            catch { }
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmail.Visible = true;
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
                txtTelefone.SelectionStart = txtEndereco.TextLength;
            }
            catch { }
            if (txtTelefone.Text == "Telefone")
            {
                txtTelefone.Clear();
            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            lblTelefone.Visible = true;
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
                txtEndereco.SelectionStart = txtEndereco.TextLength;
            }
            catch { }
            if (txtEndereco.Text == "Endereço")
            {
                txtEndereco.Clear();
            }
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            lblEndereco.Visible = true;
            try
            {
                txtEndereco.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            lblSalario.Visible = true;
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
                txtSalario.SelectionStart = txtSalario.TextLength;
            }
            catch { }
            if (txtSalario.Text == "Salário")
            {
                txtSalario.Clear();
            }
        }

        private void txtBanco_TextChanged(object sender, EventArgs e)
        {
            lblBanco.Visible = true;
            try
            {
                txtAgencia.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtBanco_Click(object sender, EventArgs e)
        {
            try
            {
                txtAgencia.SelectionStart = txtAgencia.TextLength;
            }
            catch { }
            if (txtAgencia.Text == "Agência")
            {
                txtAgencia.Clear();
            }
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
                txtConta.SelectionStart = txtConta.TextLength;
            }
            catch { }
            if (txtConta.Text == "Conta")
            {
                txtConta.Clear();
            }
        }

        private void txtCTPS_TextChanged(object sender, EventArgs e)
        {
            lblCTPS.Visible = true;
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
                txtCTPS.SelectionStart = txtCTPS.TextLength;
            }
            catch { }
            if (txtCTPS.Text == "CTPS")
            {
                txtCTPS.Clear();
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            bool nome = Regex.IsMatch(txtNome.Text, @"^[a-zA-ZÀ-ÿ\sçÇ]+$");
            bool banco = Regex.IsMatch(txtAgencia.Text, @"^\d+$");
            bool conta = Regex.IsMatch(txtConta.Text, @"\d+-");
            bool cpf = Regex.IsMatch(txtCPF.Text, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
            bool email = Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            bool telefone = Regex.IsMatch(txtTelefone.Text, @"^\(\s*\d{2}\s*\)\s*\d{5}-\d{4}$");

            if (txtNome.Text == string.Empty || txtNome.Text == "Nome" || nome == false) { MessageBox.Show("Favor preencher campo de nome corretamente."); return; }
            else if (txtAdmissao.Text == string.Empty || txtAdmissao.Text == "  /  /" || txtAdmissao.Text.Length < 10) { MessageBox.Show("Favor preencher campo de admissão corretamente."); return; }
            else if (txtCTPS.Text == string.Empty || txtCTPS.Text == "CTPS" || txtCTPS.Text == "       .   -" || txtCTPS.Text.Length < 13) { MessageBox.Show("Favor preencher campo de CTPS corretamente."); return; }
            else if (txtDataNascimento.Text == string.Empty || txtDataNascimento.Text == "  /  /" || DateTime.Parse(txtDataNascimento.Text) > DateTime.Parse(txtAdmissao.Text) || txtDataNascimento.Text.Length < 10) { MessageBox.Show("Favor preencher campo de data de nascimento corretamente."); return; }
            else if (txtAgencia.Text == string.Empty || txtAgencia.Text == "Agência" || txtAgencia.Text.Length != 4 || banco == false) { MessageBox.Show("Favor preencher campo de agência corretamente."); return; }
            else if (txtConta.Text == string.Empty || conta == false || txtConta.Text == "Conta" || txtConta.Text.Length < 7) { MessageBox.Show("Favor preencher campo de conta corretamente."); return; }
            else if (txtCPF.Text == string.Empty || cpf == false || txtCPF.Text == "   .   .   -" || txtCPF.Text.Length < 14) { MessageBox.Show("Favor preencher campo de CPF corretamente."); return; }
            else if (txtEmail.Text == string.Empty || email == false || txtCPF.Text == "Email") { MessageBox.Show("Favor preencher campo de email corretamente."); return; }
            else if (txtEndereco.Text == string.Empty || txtEndereco.Text == "Endereço") { MessageBox.Show("Favor preencher campo de endereço corretamente."); return; }
            else if (txtTelefone.Text == string.Empty || telefone == false || txtTelefone.Text == "(  )      -") { MessageBox.Show("Favor preencher campo de telefone corretamente."); return; }
            else if (txtSalario.Text == string.Empty || txtSalario.Text == "Salário") { MessageBox.Show("Favor preencher campo de salário corretamente."); return; }
            else if (comboCargo.Text == string.Empty || comboCargo.Text == "Cargo") { MessageBox.Show("Favor preencher campo de cargo corretamente."); return; }
            //else if (txtNomeSocial.Text == string.Empty || txtNomeSocial ) { }
            //else if (comboGenero.Text == string.Empty) { }

            DateTime Data1 = DateTime.Parse(txtDataNascimento.Text);
            DateTime Data2 = DateTime.Parse(txtAdmissao.Text);

            int Result = DateTime.Compare(Data1, Data2);

            if (Result > 0)
            {
                MessageBox.Show("A DATA DE NASCIMENTO NÃO PODE SER MAIOR QUE A DE ADMISSÃO");
                return;
            }

            if (IdFuncionario == null)
            {
                string strcad = "insert into funcionario (nome,data_admissao,ctps,data_nascimento,banco,conta,cpf,email,ativo,endereco,id_cargo,salario_bruto,telefone,genero) values(@nome,@data_admissao,@ctps,@data_nascimento,@banco,@conta,@cpf,@email,@ativo,@endereco,@id_cargo,@salario_bruto,@telefone,@genero); select currval('funcionario_id_funcionario_seq');";
                connection = new NpgsqlConnection(connectionString);

                connection.Open();
                try
                {
                    NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

                    comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@data_admissao", Convert.ToDateTime(txtAdmissao.Text));
                    comando.Parameters.AddWithValue("@ctps", txtCTPS.Text);
                    comando.Parameters.AddWithValue("@data_nascimento", Convert.ToDateTime(txtDataNascimento.Text));
                    comando.Parameters.AddWithValue("@banco", txtAgencia.Text);
                    comando.Parameters.AddWithValue("@conta", txtConta.Text);
                    comando.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    comando.Parameters.AddWithValue("@email", txtEmail.Text);
                    comando.Parameters.AddWithValue("@ativo", btnAtivo.Checked);
                    comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    comando.Parameters.AddWithValue("@id_cargo", int.Parse(comboCargo.SelectedValue.ToString()));
                    comando.Parameters.AddWithValue("@salario_bruto", double.Parse(txtSalario.Text));
                    comando.Parameters.AddWithValue("@genero", comboSexo.SelectedItem.ToString());

                    comando.Prepare();
                    int id_funcionario = Convert.ToInt32(comando.ExecuteScalar());

                    MessageBox.Show("CADASTRO EFETUADO COM SUCESSO");

                    string strlog = "insert into login (login, senha, id_funcionario) values(@login, '123', @id_funcionario)";

                    NpgsqlCommand comando2 = new NpgsqlCommand(strlog, connection);

                    comando2.Parameters.AddWithValue("@login", txtCPF.Text);
                    comando2.Parameters.AddWithValue("@id_funcionario", id_funcionario);

                    comando2.Prepare();
                    comando2.ExecuteNonQuery();

                    this.Close();
                }
                catch (NpgsqlException ex)
                {
                    string exc = ex.Message;
                    if (exc.Contains("23505"))
                    {
                        if (exc.Contains("funcionario_cpf_key"))
                        {
                            MessageBox.Show("CPF já registrado!");
                        }
                        else if (exc.Contains("funcionario_email_key"))
                        {
                            MessageBox.Show("E-mail já registrado!");
                        }
                        else
                        {
                            MessageBox.Show("Erro: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                finally
                {
                    connection.Close();
                }
                this.Close();
            }
            else
            {
                string strcad = "UPDATE funcionario SET nome=@nome, data_admissao=@data_admissao, ctps=@ctps, data_nascimento=@data_nascimento, banco=@banco, conta=@conta, cpf=@cpf, email=@email, ativo=@ativo, endereco=@endereco, id_cargo=@id_cargo, salario_bruto=@salario_bruto, telefone=@telefone, genero=@genero WHERE id_funcionario=@id_funcionario";
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
                    comando.Parameters.AddWithValue("@banco", txtAgencia.Text);
                    comando.Parameters.AddWithValue("@conta", txtConta.Text);
                    comando.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    comando.Parameters.AddWithValue("@email", txtEmail.Text);
                    comando.Parameters.AddWithValue("@ativo", btnAtivo.Checked);
                    comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    comando.Parameters.AddWithValue("@id_cargo", int.Parse(comboCargo.SelectedValue.ToString()));
                    comando.Parameters.AddWithValue("@salario_bruto", double.Parse(txtSalario.Text));
                    comando.Parameters.AddWithValue("@id_funcionario", IdFuncionario);
                    comando.Parameters.AddWithValue("@genero", comboSexo.SelectedItem.ToString());

                    comando.Prepare();
                    int id_funcionario = Convert.ToInt32(comando.ExecuteScalar());

                    MessageBox.Show("O FUNCIONARIO FOI ATUALIZADO");

                    string strlog = "update login set login=@login where id_funcionario=@id_funcionario";

                    NpgsqlCommand comando2 = new NpgsqlCommand(strlog, connection);

                    comando2.Parameters.AddWithValue("@login", txtCPF.Text);
                    comando2.Parameters.AddWithValue("@id_funcionario", IdFuncionario);

                    comando2.Prepare();
                    comando2.ExecuteNonQuery();

                    this.Close();
                }
                catch (NpgsqlException ex)
                {
                    string exc = ex.Message;
                    if (exc.Contains("23505"))
                    {
                        if (exc.Contains("funcionario_cpf_key"))
                        {
                            MessageBox.Show("CPF já registrado!");
                        }
                        else if (exc.Contains("funcionario_email_key"))
                        {
                            MessageBox.Show("E-mail já registrado!");
                        }
                        else
                        {
                            MessageBox.Show("Erro: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                finally
                {
                    connection.Close();
                }
            }

        }
        private void Buscar(long id)
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
                txtAgencia.Text = Convert.ToString(dr["banco"]);
                txtConta.Text = Convert.ToString(dr["conta"]);
                txtCPF.Text = Convert.ToString(dr["cpf"]);
                txtEmail.Text = Convert.ToString(dr["email"]);
                btnAtivo.Checked = Convert.ToBoolean(dr["ativo"]);
                txtEndereco.Text = Convert.ToString(dr["endereco"]);
                txtTelefone.Text = Convert.ToString(dr["telefone"]);
                comboCargo.SelectedValue = Convert.ToInt32(dr["id_cargo"]);
                txtSalario.Text = Convert.ToString(dr["salario_bruto"]);
                comboSexo.SelectedItem = Convert.ToString(dr["genero"]);

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

        private void PreencherComboSexo()
        {
            comboSexo.SelectedIndex = 0;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAgencia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
