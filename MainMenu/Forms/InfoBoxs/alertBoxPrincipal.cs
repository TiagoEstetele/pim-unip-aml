using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu.Forms.alertBoxPrincipal
{
    public partial class alertBoxPrincipal : Form
    {
        public alertBoxPrincipal()
        {
            InitializeComponent();
        }
        public Color BackColorAlertBox
        {
            get {return this.BackColor;}
            set {this.BackColor = value;}
        }
        public Color ColorAlertBox
        {
            get { return linAlertBox.BackColor;}
            set { linAlertBox.BackColor = lblTitleAlertBox.ForeColor = lblTextAlertBox.ForeColor = value; }
        }

        public Image IconeColorAlertBox
        {
            get { return picAlertBox.Image; }
            set { picAlertBox.Image = value; }
        }

        public string TitleAlertBox
        {
            get { return lblTitleAlertBox.Text; }
            set { lblTitleAlertBox.Text = value; }
        }

        public string TextAlertBox
        {
            get { return lblTextAlertBox.Text; }
            set { lblTextAlertBox.Text = value; }
        }

        private void PositionAlertBox()
        {
            int xPos = 1116; int yPos = 742;
            this.Location = new Point(xPos, yPos);
        }

        private void timerAnimasion_Tick(object sender, EventArgs e)
        {
            linAlertBox.Width = linAlertBox.Width + 2;
            if (linAlertBox.Width >= 400)
               this.Close();
        }

        private void alertBox_Load(object sender, EventArgs e)
        {
            PositionAlertBox();
            for (int i = 0; i < 400; i++)            
                timerAnimasion.Start();
        }
    }
}
