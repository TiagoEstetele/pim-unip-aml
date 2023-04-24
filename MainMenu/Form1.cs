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
    public partial class Form1 : Form
    {
        //Fields
        bool sidebarExpand;
        bool homeCollapse;
        private Form activeForm;
        private Button currentButton;
        
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_DragOver(object sender, DragEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                
                }
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //if sidebar is expand, minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();

            if (sidebar.Width <= 60)
            {
                menuButton.Image = Image.FromFile("C:\\Users\\tiago\\OneDrive\\Documentos\\Windows Forms Projetos\\MainMenu\\MainMenu\\Resources\\close_48px.png");
            }
            else
            {
                menuButton.Image = Image.FromFile("C:\\Users\\tiago\\OneDrive\\Documentos\\Windows Forms Projetos\\MainMenu\\MainMenu\\Resources\\menu-branco.png");
            }
        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapse)
            {
                HomeContainer.Height += 10;
                if (HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    homeCollapse = false;
                    HomeTimer.Stop();
                }
            } else
                {
                    HomeContainer.Height -= 10;
                    if (HomeContainer.Height == HomeContainer.MinimumSize.Height)
                    {
                        homeCollapse = true;
                        HomeTimer.Stop();
                    }
                }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTittle.Text = childForm.Text;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Cadastro(), sender);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Deletar(), sender);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Editar(), sender);
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.informacoes(), sender);
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Ponto(), sender);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }
    }
}

