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

namespace cadastrarFuncionario
{
    public partial class ControlePonto : Form
    {
        NpgsqlConnection conec;
        long idfun;
        public ControlePonto(long id_funcionario)
        {
            idfun = id_funcionario;
            InitializeComponent();
        }

        private void hora_atual_Click(object sender, EventArgs e)
        {
            string postgres_source = "host=localhost;port=5432;database=ibh_pim;username=postgres;password=admin";
            conec = new NpgsqlConnection(postgres_source);
            string sql_hora = "insert into controle_de_horas (id_funcionario, data_movimento)" +
                              " values (@idfun, @data_mov)";

            NpgsqlCommand comando = new NpgsqlCommand(sql_hora, conec);
            conec.Open();

            comando.Parameters.AddWithValue("@idfun", idfun);
            comando.Parameters.AddWithValue("@data_mov", DateTime.Now);

            comando.ExecuteNonQuery();
        }
    }
}
