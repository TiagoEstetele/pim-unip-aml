using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu.Forms
{
    public partial class Ponto : Form
    {
        public Ponto()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = DateTime.Now.ToString("T");
        }

        private void Ponto_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
