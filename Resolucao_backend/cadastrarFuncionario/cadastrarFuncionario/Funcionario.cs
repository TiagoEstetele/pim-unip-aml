using cadastrarFuncionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Funcionario : Form
    {
        long idfun;
        public Funcionario(long id_funcionario)
        {
            InitializeComponent();
            idfun = id_funcionario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ControlePonto(idfun).Show();

        }
    }
}
