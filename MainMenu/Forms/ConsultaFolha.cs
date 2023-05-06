using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using System.IO;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace MainMenu
{
    public partial class ConsultaFolha : Form
    {
        string connectionString = "Host=pim.postgres.database.azure.com;" +
                                  "Port=5432;" +
                                  "Database=Teste02;" +
                                  "Username=ricardinholord;" +
                                  "Password=Maluco777;";
        long nomeExtrato;
        long idfun;
        NpgsqlConnection connection;
        decimal IRRF, INSS, Falta, PINSS, FaltaDia, SalarioLiquido, SalarioRecebido, Descontos;

        public ConsultaFolha(long idfun)
        {
            string salario;
            this.idfun = idfun;

            salario = ConsultarSalario(idfun);

            IRRF = CalcularoIRRF(salario);
            INSS = CalculoINSS(salario);
            FaltaDia = PagamentoDia(salario);
            Falta = PagamentoFalta(idfun, salario);
            PINSS = CalculoPorcentagemINSS(salario);
            SalarioLiquido = CalculoSalarioLiquido(idfun, salario);
            Descontos = Falta + IRRF + INSS;
            SalarioRecebido = SalarioLiquido - Descontos;

            InitializeComponent();
        }

        private string ConsultarSalario(long idfun)
        {
            string salario;

            string strcad = "select salario_bruto from funcionario where id_funcionario=@idfun";
            connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

            comando.Parameters.AddWithValue("@idfun", idfun);

            NpgsqlDataReader dr = comando.ExecuteReader();
            dr.Read();

            salario = Convert.ToString(dr["salario_bruto"]);

            return salario;
        }

        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        private void CreateWordDocument(object filename, object SaveAs)
        {
            string salario;
            salario = ConsultarSalario(idfun);

            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            try
            {
                if (File.Exists((string)filename))
                {
                    object readOnly = false;
                    object isVisible = false;
                    wordApp.Visible = false;

                    myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);

                    myWordDoc.Activate();

                    //find and replace
                    this.FindAndReplace(wordApp, "<nome>", txtNome.Text);
                    this.FindAndReplace(wordApp, "<desconto1>", INSS.ToString("N2"));
                    this.FindAndReplace(wordApp, "<desconto2>", IRRF.ToString("N2"));
                    this.FindAndReplace(wordApp, "<desconto3>", Falta.ToString("N2"));
                    this.FindAndReplace(wordApp, "<fixoIrrf>", IRRF.ToString("N2"));
                    this.FindAndReplace(wordApp, "<porcInss>", PINSS.ToString("N2"));
                    this.FindAndReplace(wordApp, "<fixoFaltas>", FaltaDia.ToString("N2"));
                    this.FindAndReplace(wordApp, "<salaBruto>", salario);
                    this.FindAndReplace(wordApp, "<salaLiquid>", SalarioLiquido.ToString("N2"));
                    this.FindAndReplace(wordApp, "<salaRecebido>", SalarioRecebido.ToString("N2"));
                }
                else
                {
                    MessageBox.Show("File not found!");
                    return; // retornar sem salvar o documento
                }

                //save as
                myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing);

                myWordDoc.Close();
                wordApp.Quit();
                MessageBox.Show("File Created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            nomeExtrato = idfun;
            CreateWordDocument(@"C:\temp.docx", $@"C:\Users\tiago\{nomeExtrato} {DateTime.Now.Millisecond}.docx");
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }
        private decimal CalcularoIRRF(string salario)
        {
            decimal salarioDecimal = decimal.Parse(salario);

            if (salarioDecimal < 2112.01M)
                return 0;
            else if (salarioDecimal >= 2112.01M && salarioDecimal <= 2826.65M)
                return 158.40M;
            else if (salarioDecimal >= 2826.66M && salarioDecimal <= 3751.05M)
                return 370.40M;
            else if (salarioDecimal >= 3751.05M && salarioDecimal <= 4664.68M)
                return 651.73M;
            else
                return 884.96M;
        }

        private decimal CalculoINSS(string salario)
        {
            decimal salarioDecimal = decimal.Parse(salario);
            decimal? porcentagemDesconto = null;
            decimal? valorDesconto = null;

            if (salarioDecimal <= 1302)
                porcentagemDesconto = 7.5M;
            else if (salarioDecimal >= 1302.01M && salarioDecimal <= 2571.29M)
                porcentagemDesconto = 9;
            else if (salarioDecimal >= 2571.30M && salarioDecimal <= 3856.94M)
                porcentagemDesconto = 12;
            else if (salarioDecimal >= 3856.95M && salarioDecimal <= 7507.49M)
                porcentagemDesconto = 14;
            else
                valorDesconto = 877.24M;

            if (porcentagemDesconto.HasValue)
                valorDesconto = (porcentagemDesconto / 100) * salarioDecimal;

            return valorDesconto.Value;
        }

        private decimal CalculoPorcentagemINSS(string salario)
        {
            decimal salarioDecimal = decimal.Parse(salario);
            decimal porcentagemDesconto;

            if (salarioDecimal <= 1302)
                porcentagemDesconto = 7.5M;
            else if (salarioDecimal >= 1302.01M && salarioDecimal <= 2571.29M)
                porcentagemDesconto = 9;
            else if (salarioDecimal >= 2571.30M && salarioDecimal <= 3856.94M)
                porcentagemDesconto = 12;
            else if (salarioDecimal >= 3856.95M && salarioDecimal <= 7507.49M)
                porcentagemDesconto = 14;
            else
                porcentagemDesconto = 877.24M;

            return porcentagemDesconto;
        }

        private decimal PagamentoFalta(long idfun, string salario)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            int mes = (date.Month);
            string horas;
            decimal Falta;
            decimal PagamentoTotal;

            decimal salarioDecimal = decimal.Parse(salario);
            decimal salarioBruto = decimal.Parse(salario);

            salarioDecimal = salarioDecimal / 220;

            string strcad = "select id_funcionario, sum(horas_total) as trabalho from controle_de_horas where id_funcionario=@id and mes=@mes group by id_funcionario";
            connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

            comando.Parameters.AddWithValue("@id", idfun);
            comando.Parameters.AddWithValue("@mes", mes);

            NpgsqlDataReader dr = comando.ExecuteReader();
            dr.Read();

            horas = Convert.ToString(dr["trabalho"]);

            connection.Close();

            PagamentoTotal = decimal.Parse(horas) * salarioDecimal;
            Falta = salarioBruto - PagamentoTotal;

            return Falta;
        }

        private decimal PagamentoDia(string salario)
        {
            decimal FaltaDia;
            decimal PagamentoTotal;

            decimal salarioDecimal = decimal.Parse(salario);

            salarioDecimal = salarioDecimal / 220;
            FaltaDia = salarioDecimal * 8;

            return FaltaDia;
        }

        private decimal CalculoSalarioLiquido(long idfun, string salario)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            int mes = (date.Month);
            string horas;
            decimal SalarioLiquido;
            decimal PagamentoTotal;

            decimal salarioDecimal = decimal.Parse(salario);
            decimal salarioBruto = decimal.Parse(salario);

            salarioDecimal = salarioDecimal / 220;

            string strcad = "select id_funcionario, sum(horas_total) as trabalho from controle_de_horas where id_funcionario=@id and mes=@mes group by id_funcionario";
            connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

            comando.Parameters.AddWithValue("@id", idfun);
            comando.Parameters.AddWithValue("@mes", mes);

            NpgsqlDataReader dr = comando.ExecuteReader();
            dr.Read();

            horas = Convert.ToString(dr["trabalho"]);

            connection.Close();

            SalarioLiquido = decimal.Parse(horas) * salarioDecimal;

            return SalarioLiquido;
        }
    }
}
