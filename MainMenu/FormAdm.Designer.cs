namespace MainMenu
{
    partial class FormAdm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdm));
            this.sidebar = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTittleBar = new System.Windows.Forms.Panel();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelTittle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureImageSeta = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.HomeContainer.SuspendLayout();
            this.panelTittleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageSeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.sidebar.Controls.Add(this.panelLogo);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(220, 1080);
            this.sidebar.MinimumSize = new System.Drawing.Size(60, 1080);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(60, 1080);
            this.sidebar.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panelLogo.Controls.Add(this.HomeContainer);
            this.panelLogo.Controls.Add(this.button2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.menuButton);
            this.panelLogo.Controls.Add(this.button1);
            this.panelLogo.Controls.Add(this.btnLogout);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(60, 541);
            this.panelLogo.TabIndex = 0;
            // 
            // HomeContainer
            // 
            this.HomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.HomeContainer.Controls.Add(this.pictureImageSeta);
            this.HomeContainer.Controls.Add(this.button3);
            this.HomeContainer.Controls.Add(this.btnFuncionarios);
            this.HomeContainer.Controls.Add(this.btnCadastrar);
            this.HomeContainer.Location = new System.Drawing.Point(1, 83);
            this.HomeContainer.MaximumSize = new System.Drawing.Size(220, 171);
            this.HomeContainer.MinimumSize = new System.Drawing.Size(220, 61);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(220, 61);
            this.HomeContainer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // panelTittleBar
            // 
            this.panelTittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panelTittleBar.Controls.Add(this.btnMinimaze);
            this.panelTittleBar.Controls.Add(this.btnClose);
            this.panelTittleBar.Controls.Add(this.labelTittle);
            this.panelTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleBar.Location = new System.Drawing.Point(60, 0);
            this.panelTittleBar.Name = "panelTittleBar";
            this.panelTittleBar.Size = new System.Drawing.Size(1018, 80);
            this.panelTittleBar.TabIndex = 1;
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimaze.ForeColor = System.Drawing.Color.White;
            this.btnMinimaze.Location = new System.Drawing.Point(948, 3);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(30, 30);
            this.btnMinimaze.TabIndex = 5;
            this.btnMinimaze.Text = "-";
            this.btnMinimaze.UseVisualStyleBackColor = true;
            this.btnMinimaze.Click += new System.EventHandler(this.btnMinimaze_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(985, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelTittle
            // 
            this.labelTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.Color.White;
            this.labelTittle.Location = new System.Drawing.Point(471, 28);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(72, 30);
            this.labelTittle.TabIndex = 2;
            this.labelTittle.Text = "HOME";
            this.labelTittle.UseCompatibleTextRendering = true;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.White;
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(60, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1018, 532);
            this.panelDesktopPanel.TabIndex = 2;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 10;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureImageSeta
            // 
            this.pictureImageSeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.pictureImageSeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureImageSeta.Image = global::MainMenu.Properties.Resources.seta_baixo1;
            this.pictureImageSeta.Location = new System.Drawing.Point(114, 25);
            this.pictureImageSeta.Name = "pictureImageSeta";
            this.pictureImageSeta.Size = new System.Drawing.Size(22, 23);
            this.pictureImageSeta.TabIndex = 10;
            this.pictureImageSeta.TabStop = false;
            this.pictureImageSeta.Click += new System.EventHandler(this.pictureImageSeta_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = global::MainMenu.Properties.Resources.home_48px1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 64);
            this.button3.TabIndex = 4;
            this.button3.Text = "             Home";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.btnFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFuncionarios.Image = global::MainMenu.Properties.Resources.male_female_user_group_48px;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.Location = new System.Drawing.Point(0, 61);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(220, 46);
            this.btnFuncionarios.TabIndex = 6;
            this.btnFuncionarios.Text = "             Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrar.Image = global::MainMenu.Properties.Resources.add_user_male_48px;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 113);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(220, 46);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "             Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::MainMenu.Properties.Resources.help_48px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "             Help";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::MainMenu.Properties.Resources.menu_branco;
            this.menuButton.Location = new System.Drawing.Point(7, 12);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(50, 50);
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::MainMenu.Properties.Resources.info_48px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "             About";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Image = global::MainMenu.Properties.Resources.logout_48px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1, 261);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(217, 61);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "             Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // FormAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 612);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTittleBar);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAdm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.HomeContainer.ResumeLayout(false);
            this.panelTittleBar.ResumeLayout(false);
            this.panelTittleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageSeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTittleBar;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureImageSeta;
    }
}

