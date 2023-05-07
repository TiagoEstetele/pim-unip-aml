using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private bool tempoPassou = false;

        private async void Hello_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@".\Resources\som.wav");
            tempoInicio.Start();
            player.Play();
            await Task.Delay(4000); // espera 5 segundos
            tempoPassou = true;
            tempoInicio.Stop();

            if (tempoPassou)
            {
                this.Hide();
                new FormLogin().ShowDialog(); 
            }
        }

        private void Hello_Shown(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;
        }
    }
}
