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
using Microsoft.Office.Interop.Word;
using MainMenu.Forms.alertBoxPrincipal;

namespace MainMenu
{
    public partial class ConsultaFolha : Form
    {
        string connectionString = "Host=pim.postgres.database.azure.com;" +
                                  "Port=5432;" +
                                  "Database=Teste02;" +
                                  "Username=ricardinholord;" +
                                  "Password=Maluco777;";
        long idfun;
        string nome, endereco, telefone, Salario;
        long idCargo1;
        decimal HoraExtra;
        NpgsqlConnection connection;
        decimal IRRF, INSS, Falta, PINSS, FaltaDia, SalarioLiquido, SalarioRecebido, Descontos, DescontosE;

        public ConsultaFolha(long idfun, long idCargo1, string nome, string endereco, string telefone)
        {

            string strcad = "select salario_bruto, id_cargo, endereco, nome, telefone from funcionario where id_funcionario=@idfun";
            connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

            comando.Parameters.AddWithValue("@idfun", idfun);


            this.idfun = idfun;

            NpgsqlDataReader dr = comando.ExecuteReader();
            dr.Read();
            idCargo1 = Convert.ToInt32(dr[1]);
            this.endereco = Convert.ToString(dr[2]);
            this.nome = Convert.ToString(dr[3]);
            this.telefone = Convert.ToString(dr[4]);

            Salario = ConsultarSalario(idfun, idCargo1);

            //IRRF = CalcularoIRRF(salario);
            //INSS = CalculoINSS(salario);
            //FaltaDia = PagamentoDia(salario);
            //Falta = PagamentoFalta(idfun, salario, idCargo1);
            //PINSS = CalculoPorcentagemINSS(salario);
            //SalarioLiquido = CalculoSalarioLiquido(idfun, salario);
            //Descontos = Falta + IRRF + INSS;
            //DescontosE = Falta;
            //SalarioRecebido = SalarioLiquido - Descontos;

            InitializeComponent();
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

        private string ConsultarSalario(long idfun, long idCargo1)
        {
            string Salario;
            this.idCargo1 = idCargo1;

            string strcad = "select salario_bruto from funcionario where id_funcionario=@idfun";
            connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

            comando.Parameters.AddWithValue("@idfun", idfun);

            NpgsqlDataReader dr = comando.ExecuteReader();
            dr.Read();

            Salario = Convert.ToString(dr["salario_bruto"]);

            return Salario;
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

        private void btnIr_Click(object sender, EventArgs e)
        {
            string path = @".\Documentos";

            try
            {
                System.Diagnostics.Process.Start("explorer.exe", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a pasta: " + ex.Message);
            }
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConsultaFolha_Load(object sender, EventArgs e)
        {
        }

        private void CreateWordDocument(object filename, object SaveAs)
        {

            string Salario;
            Salario = ConsultarSalario(idfun, idCargo1);
            decimal SalarioLiquidoEst = (Decimal.Parse(Salario) - Falta);
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            var fileInfo = new FileInfo((string)filename);
            filename = (object)fileInfo.FullName;

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

                    if (idCargo1 == 1 || idCargo1 == 2)
                    {
                        this.FindAndReplace(wordApp, "<nome>", nome);
                        this.FindAndReplace(wordApp, "<endereco>", endereco);
                        this.FindAndReplace(wordApp, "<telefone>", telefone);
                        this.FindAndReplace(wordApp, "<desconto1>", INSS.ToString("N2"));
                        this.FindAndReplace(wordApp, "<desconto2>", IRRF.ToString("N2"));
                        this.FindAndReplace(wordApp, "<desconto3>", Falta.ToString("N2"));
                        this.FindAndReplace(wordApp, "<fixoIrrf>", IRRF.ToString("N2"));
                        this.FindAndReplace(wordApp, "<porcInss>", PINSS.ToString("N2"));
                        this.FindAndReplace(wordApp, "<fixoFaltas>", FaltaDia.ToString("N2"));
                        this.FindAndReplace(wordApp, "<acresc1>", Salario);
                        this.FindAndReplace(wordApp, "<acresc2>", HoraExtra);
                        this.FindAndReplace(wordApp, "<salaLiquid>", (SalarioLiquido + HoraExtra).ToString("N2"));
                        this.FindAndReplace(wordApp, "<salaRecebido>", SalarioRecebido.ToString("N2"));
                        this.FindAndReplace(wordApp, "<descontTotal>", Descontos);
                    }
                    else
                        this.FindAndReplace(wordApp, "<nome>", nome);
                    this.FindAndReplace(wordApp, "<endereco>", endereco);
                    this.FindAndReplace(wordApp, "<telefone>", telefone);
                    this.FindAndReplace(wordApp, "<fixoFaltas>", FaltaDia.ToString("N2"));
                    this.FindAndReplace(wordApp, "<desconto3>", Falta.ToString("N2"));
                    this.FindAndReplace(wordApp, "<acresc1>", Salario);
                    this.FindAndReplace(wordApp, "<descontTotal>", DescontosE);
                    this.FindAndReplace(wordApp, "<salaLiquido>", SalarioLiquidoEst.ToString("N2"));
                }
                else
                {
                    MessageBox.Show("Folha de modelo não foi detectada, favor verificar.");
                    return; // retornar sem salvar o documento
                }

                var directoryInfo = new DirectoryInfo(@".\Documentos");
                SaveAs = (object)$"{directoryInfo.FullName}\\{SaveAs.ToString().Split('\\')[2]}";
                //save as
                myWordDoc.SaveAs2(ref SaveAs, WdSaveFormat.wdFormatPDF, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing);

                object SaveChanges = WdSaveOptions.wdDoNotSaveChanges;

                myWordDoc.Close(ref SaveChanges, ref missing, ref missing);
                //myWordDoc.ExportAsFixedFormat(SaveAs.ToString(), WdExportFormat.wdExportFormatPDF, false, WdExportOptimizeFor.wdExportOptimizeForOnScreen, WdExportRange.wdExportAllDocument, 1, 1, WdExportItem.wdExportDocumentContent, true, true, WdExportCreateBookmarks.wdExportCreateHeadingBookmarks, true, true, false, ref missing);

                wordApp.Quit();
                MessageBox.Show("O arquivo foi criado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDownload_Click_1(object sender, EventArgs e)
        {

            int Mes = cmbMes.SelectedIndex + 1;

            IRRF = CalcularoIRRF(Salario);
            INSS = CalculoINSS(Salario);
            FaltaDia = PagamentoDia(Salario);
            Falta = PagamentoFalta(idfun, Salario, idCargo1, Mes);
            if (Falta == -1)
            {
                MessageBox.Show("Não encontramos horas trabalhadas nesse mes");
                return;
            }
            PINSS = CalculoPorcentagemINSS(Salario);
            SalarioLiquido = CalculoSalarioLiquido(idfun, Salario);
            Descontos = Falta + IRRF + INSS;
            DescontosE = Falta;
            SalarioRecebido = SalarioLiquido - Descontos;

            string Extrato = idfun.ToString();
            long Modif = DateTime.Now.Ticks;

            if (!Directory.Exists(@".\Documentos"))
            {
                Directory.CreateDirectory(@".\Documentos");
            }

            if (idCargo1 == 1 || idCargo1 == 2)
            {
                CreateWordDocument(@".\Resources\Funcionario.docx", $@".\Documentos\{Extrato} {Modif}.pdf");
            }
            else
                CreateWordDocument(@".\Resources\Estagiario.docx", $@".\Documentos\{Extrato} {Modif}.pdf");

            string path = @".\Documentos";

            try
            {
                System.Diagnostics.Process.Start("explorer.exe", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a pasta: " + ex.Message);
            }
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }
        private decimal CalcularoIRRF(string Salario)
        {
            decimal salarioDecimal = decimal.Parse(Salario);

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

        private decimal CalculoINSS(string Salario)
        {
            decimal salarioDecimal = decimal.Parse(Salario);
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

        private decimal CalculoPorcentagemINSS(string Salario)
        {
            decimal salarioDecimal = decimal.Parse(Salario);
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

        private decimal PagamentoFalta(long idfun, string Salario, long idCargo1, int Mes)
        {
            decimal Falta, horas;
            decimal PagamentoTotal;

            decimal salarioDecimal = decimal.Parse(Salario);
            decimal salarioBruto = decimal.Parse(Salario);

            if (idCargo1 <= 2)
            {
                salarioDecimal = salarioDecimal / 160;
            }
            else
            {
                salarioDecimal = salarioDecimal / 120;
            }


            string strcad = "select id_funcionario, sum(horas_total) as trabalho from controle_de_horas where id_funcionario=@id and mes=@mes group by id_funcionario";
            connection = new NpgsqlConnection(connectionString);

            connection.Open();

            NpgsqlCommand comando = new NpgsqlCommand(strcad, connection);

            comando.Parameters.AddWithValue("@id", idfun);
            comando.Parameters.AddWithValue("@mes", Mes);

            NpgsqlDataReader dr = comando.ExecuteReader();
            dr.Read();

            if (dr.HasRows == false)
            {
                return -1;
            }

            horas = Convert.ToDecimal(dr["trabalho"]);

            connection.Close();

            PagamentoTotal = horas * salarioDecimal;

            if (horas <= 160)
            {
                Falta = salarioBruto - PagamentoTotal;
                HoraExtra = 0;
            }
            else
            {
                Falta = salarioBruto - PagamentoTotal;
                HoraExtra = Falta * -1;
                Falta = 0;
            }


            return Falta;
        }

        private decimal PagamentoDia(string Salario)
        {
            decimal FaltaDia;
            decimal PagamentoTotal;

            decimal salarioDecimal = decimal.Parse(Salario);

            if (idCargo1 <= 2)
            {
                salarioDecimal = salarioDecimal / 160;
                FaltaDia = salarioDecimal * 8;
            }
            else
            {
                salarioDecimal = salarioDecimal / 120;
                FaltaDia = salarioDecimal * 6;
            }

            return FaltaDia;
        }

        private decimal CalculoSalarioLiquido(long idfun, string Salario)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            int mes = (date.Month);
            string horas;
            decimal SalarioLiquido;
            decimal PagamentoTotal;

            decimal salarioDecimal = decimal.Parse(Salario);
            decimal salarioBruto = decimal.Parse(Salario);

            if (idCargo1 <= 2)
            {
                salarioDecimal = salarioDecimal / 160;
            }
            else
            {
                salarioDecimal = salarioDecimal / 120;
            }

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