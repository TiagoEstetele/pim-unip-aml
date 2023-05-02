using MainMenu.Forms.InfoBoxs;
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
    public partial class FormAdm : Form
    {
        //Fields
        public long identify;
        long id_funcionario;
        bool sidebarExpand;
        bool homeCollapse;
        private Form activeForm;
        private Button currentButton;
        
        public FormAdm()
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

        private void menuButton_Click_1(object sender, EventArgs e)
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

        private void btnFuncionarios_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Funcionarios(), sender);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        void AlertBoxArtan(Color backColor, Color color, string title, string text, Image icon)
        {
            alertBox alertBox = new alertBox();
            alertBox.BackColor = backColor;
            alertBox.ColorAlertBox = color;
            alertBox.TitleAlertBox = title;
            alertBox.TextAlertBox = text;
            alertBox.IconeColorAlertBox = icon;
            alertBox.ShowDialog();
        }
        private void btnSuccess_Click(object sender, EventArgs e)
        {
            AlertBoxArtan(Color.LightGreen, Color.SeaGreen, "Success", "Operation Completed Succesfully.", Properties.Resources.ok_48px);
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            AlertBoxArtan(Color.LightGoldenrodYellow, Color.Goldenrod, "Warning", "Are you confident in the operation ?", Properties.Resources.box_important_48px);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            AlertBoxArtan(Color.LightPink, Color.DarkRed, "Error", "Operation encountered problem !!", Properties.Resources.close_48px);
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            AlertBoxArtan(Color.LightBlue, Color.DodgerBlue, "Information", "Operation is in progress.", Properties.Resources.info_48px);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Color minhaCorPersonalizada = Color.FromArgb(44, 44, 64);
            pictureImageSeta.BackColor = minhaCorPersonalizada;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Color minhaCorPersonalizada = Color.FromArgb(34, 34, 54); 
            pictureImageSeta.BackColor = minhaCorPersonalizada;
        }

        private void pictureImageSeta_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }
    }
}

