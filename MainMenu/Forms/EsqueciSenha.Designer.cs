using System.Globalization;
using System.Collections;


namespace MainMenu.Forms
{
    partial class EsqueciSenha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnVerificar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblData = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelVerificao = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTrocarSenha = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblConfirmeNovaSenha = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textbox_confirma = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textbox_nova = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelVerificao.SuspendLayout();
            this.panelTrocarSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label8);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnMinimaze);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(42)))), ((int)(((byte)(212)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(56)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(42)))), ((int)(((byte)(212)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(73)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(417, 451);
            this.guna2CustomGradientPanel1.TabIndex = 1006;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(83, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "para efetuar a troca de senha.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Confirme os dados conforme o cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(82, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Esqueceu a senha ?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MainMenu.Properties.Resources.hominho_senha_esqueci;
            this.pictureBox2.Location = new System.Drawing.Point(45, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(328, 330);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimaze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnMinimaze.Location = new System.Drawing.Point(399, -74);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(30, 30);
            this.btnMinimaze.TabIndex = 32;
            this.btnMinimaze.Text = "-";
            this.btnMinimaze.UseVisualStyleBackColor = true;
            // 
            // lblCPF
            // 
            this.lblCPF.BackColor = System.Drawing.Color.White;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(56)))));
            this.lblCPF.Location = new System.Drawing.Point(64, 82);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(230, 21);
            this.lblCPF.TabIndex = 1015;
            this.lblCPF.Text = "CPF";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panel1.Location = new System.Drawing.Point(29, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 1);
            this.panel1.TabIndex = 1011;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::MainMenu.Properties.Resources.icons8_usuário_64__3_;
            this.pictureBox7.Image = global::MainMenu.Properties.Resources.icons8_usuário_64__3_;
            this.pictureBox7.Location = new System.Drawing.Point(29, 93);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 31);
            this.pictureBox7.TabIndex = 1010;
            this.pictureBox7.TabStop = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerificar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(42)))), ((int)(((byte)(212)))));
            this.btnVerificar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(20)))), ((int)(((byte)(118)))));
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(40)))), ((int)(((byte)(201)))));
            this.btnVerificar.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(90)))));
            this.btnVerificar.Location = new System.Drawing.Point(54, 235);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(218, 47);
            this.btnVerificar.TabIndex = 1022;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.White;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(56)))));
            this.lblData.Location = new System.Drawing.Point(62, 148);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(230, 21);
            this.lblData.TabIndex = 1026;
            this.lblData.Text = "Data de nascimento";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panel4.Location = new System.Drawing.Point(29, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 1);
            this.panel4.TabIndex = 1025;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::MainMenu.Properties.Resources.icons8_usuário_64__3_;
            this.pictureBox3.Image = global::MainMenu.Properties.Resources.icons8_usuário_64__3_;
            this.pictureBox3.Location = new System.Drawing.Point(29, 159);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.TabIndex = 1024;
            this.pictureBox3.TabStop = false;
            // 
            // panelVerificao
            // 
            this.panelVerificao.Controls.Add(this.txtData);
            this.panelVerificao.Controls.Add(this.txtCPF);
            this.panelVerificao.Controls.Add(this.label3);
            this.panelVerificao.Controls.Add(this.pictureBox7);
            this.panelVerificao.Controls.Add(this.lblData);
            this.panelVerificao.Controls.Add(this.panel4);
            this.panelVerificao.Controls.Add(this.panel1);
            this.panelVerificao.Controls.Add(this.lblCPF);
            this.panelVerificao.Controls.Add(this.pictureBox3);
            this.panelVerificao.Controls.Add(this.btnVerificar);
            this.panelVerificao.Location = new System.Drawing.Point(450, 55);
            this.panelVerificao.Name = "panelVerificao";
            this.panelVerificao.Size = new System.Drawing.Size(326, 297);
            this.panelVerificao.TabIndex = 1027;
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(56)))));
            this.txtData.Location = new System.Drawing.Point(65, 169);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(224, 19);
            this.txtData.TabIndex = 1029;
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(56)))));
            this.txtCPF.Location = new System.Drawing.Point(67, 102);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(224, 19);
            this.txtCPF.TabIndex = 1028;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(24, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 26);
            this.label3.TabIndex = 1027;
            this.label3.Text = "Confirme os dados abaixo";
            // 
            // panelTrocarSenha
            // 
            this.panelTrocarSenha.Controls.Add(this.label5);
            this.panelTrocarSenha.Controls.Add(this.btnSignIn);
            this.panelTrocarSenha.Controls.Add(this.lblConfirmeNovaSenha);
            this.panelTrocarSenha.Controls.Add(this.panel3);
            this.panelTrocarSenha.Controls.Add(this.textbox_confirma);
            this.panelTrocarSenha.Controls.Add(this.pictureBox1);
            this.panelTrocarSenha.Controls.Add(this.panel2);
            this.panelTrocarSenha.Controls.Add(this.textbox_nova);
            this.panelTrocarSenha.Controls.Add(this.pictureBox4);
            this.panelTrocarSenha.Controls.Add(this.lblNovaSenha);
            this.panelTrocarSenha.Location = new System.Drawing.Point(450, 55);
            this.panelTrocarSenha.Name = "panelTrocarSenha";
            this.panelTrocarSenha.Size = new System.Drawing.Size(326, 297);
            this.panelTrocarSenha.TabIndex = 1028;
            this.panelTrocarSenha.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(52, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 26);
            this.label5.TabIndex = 1038;
            this.label5.Text = "Confirme nova senha";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(42)))), ((int)(((byte)(212)))));
            this.btnSignIn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(20)))), ((int)(((byte)(118)))));
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(40)))), ((int)(((byte)(201)))));
            this.btnSignIn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(90)))));
            this.btnSignIn.Location = new System.Drawing.Point(54, 236);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(218, 47);
            this.btnSignIn.TabIndex = 1037;
            this.btnSignIn.Text = "Confirmar";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblConfirmeNovaSenha
            // 
            this.lblConfirmeNovaSenha.BackColor = System.Drawing.Color.White;
            this.lblConfirmeNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmeNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(56)))));
            this.lblConfirmeNovaSenha.Location = new System.Drawing.Point(57, 147);
            this.lblConfirmeNovaSenha.Name = "lblConfirmeNovaSenha";
            this.lblConfirmeNovaSenha.Size = new System.Drawing.Size(230, 21);
            this.lblConfirmeNovaSenha.TabIndex = 1036;
            this.lblConfirmeNovaSenha.Text = "Confirme Senha";
            this.lblConfirmeNovaSenha.Visible = false;
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.BackColor = System.Drawing.Color.White;
            this.lblNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(56)))));
            this.lblNovaSenha.Location = new System.Drawing.Point(57, 70);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(230, 21);
            this.lblNovaSenha.TabIndex = 1035;
            this.lblNovaSenha.Text = "Nova Senha";
            this.lblNovaSenha.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panel3.Location = new System.Drawing.Point(24, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 1);
            this.panel3.TabIndex = 1034;
            // 
            // textbox_confirma
            // 
            this.textbox_confirma.BackColor = System.Drawing.Color.White;
            this.textbox_confirma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_confirma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(56)))));
            this.textbox_confirma.Location = new System.Drawing.Point(60, 168);
            this.textbox_confirma.Name = "textbox_confirma";
            this.textbox_confirma.Size = new System.Drawing.Size(242, 19);
            this.textbox_confirma.TabIndex = 1033;
            this.textbox_confirma.Text = "Confirme Senha";
            this.textbox_confirma.Click += new System.EventHandler(this.textbox_confirma_Click);
            this.textbox_confirma.TextChanged += new System.EventHandler(this.textbox_confirma_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MainMenu.Properties.Resources.icons8_usuário_64__3_;
            this.pictureBox1.Image = global::MainMenu.Properties.Resources.icons8_senha_50__1_;
            this.pictureBox1.Location = new System.Drawing.Point(24, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 1032;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panel2.Location = new System.Drawing.Point(24, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 1);
            this.panel2.TabIndex = 1031;
            // 
            // textbox_nova
            // 
            this.textbox_nova.BackColor = System.Drawing.Color.White;
            this.textbox_nova.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_nova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_nova.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(56)))));
            this.textbox_nova.Location = new System.Drawing.Point(61, 91);
            this.textbox_nova.Name = "textbox_nova";
            this.textbox_nova.Size = new System.Drawing.Size(242, 19);
            this.textbox_nova.TabIndex = 1030;
            this.textbox_nova.Text = "Nova Senha";
            this.textbox_nova.Click += new System.EventHandler(this.textbox_nova_Click);
            this.textbox_nova.TextChanged += new System.EventHandler(this.textbox_nova_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::MainMenu.Properties.Resources.icons8_usuário_64__3_;
            this.pictureBox4.Image = global::MainMenu.Properties.Resources.icons8_senha_50__1_;
            this.pictureBox4.Location = new System.Drawing.Point(24, 83);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 31);
            this.pictureBox4.TabIndex = 1029;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.button1.Location = new System.Drawing.Point(734, -13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 50);
            this.button1.TabIndex = 1029;
            this.button1.TabStop = false;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(103)))), ((int)(((byte)(101)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnClose.Location = new System.Drawing.Point(770, -13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 50);
            this.btnClose.TabIndex = 1030;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.panelVerificao);
            this.Controls.Add(this.panelTrocarSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EsqueciSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EsqueciSenha";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelVerificao.ResumeLayout(false);
            this.panelVerificao.PerformLayout();
            this.panelTrocarSenha.ResumeLayout(false);
            this.panelTrocarSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnVerificar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelVerificao;
        private System.Windows.Forms.Panel panelTrocarSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnSignIn;
        private System.Windows.Forms.Label lblConfirmeNovaSenha;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textbox_confirma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textbox_nova;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtData;
    }
}