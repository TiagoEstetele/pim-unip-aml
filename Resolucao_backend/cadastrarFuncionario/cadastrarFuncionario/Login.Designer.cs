namespace cadastrarFuncionario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_user = new Label();
            lbl_titulo = new Label();
            txt_user = new TextBox();
            lbl_senha = new Label();
            txt_senha = new TextBox();
            btn_entrar = new Button();
            cb_mostrarsenha = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_user.Location = new Point(12, 67);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(77, 25);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "Usuário";
            lbl_user.Click += lbl_user_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = SystemColors.ControlDark;
            lbl_titulo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titulo.Location = new Point(23, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(214, 37);
            lbl_titulo.TabIndex = 1;
            lbl_titulo.Text = "Sistema de login";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(12, 95);
            txt_user.Margin = new Padding(3, 3, 5, 5);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(236, 23);
            txt_user.TabIndex = 2;
            txt_user.Text = "123.123.123-12";
            txt_user.TextChanged += txt_user_TextChanged;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_senha.Location = new Point(12, 142);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(64, 25);
            lbl_senha.TabIndex = 3;
            lbl_senha.Text = "Senha";
            lbl_senha.Click += lbl_senha_Click;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(12, 170);
            txt_senha.Margin = new Padding(3, 3, 5, 5);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(236, 23);
            txt_senha.TabIndex = 4;
            txt_senha.Text = "12345";
            txt_senha.TextChanged += textBox1_TextChanged;
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = SystemColors.ControlLightLight;
            btn_entrar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_entrar.Location = new Point(58, 250);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(145, 50);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // cb_mostrarsenha
            // 
            cb_mostrarsenha.AutoSize = true;
            cb_mostrarsenha.Location = new Point(147, 206);
            cb_mostrarsenha.Name = "cb_mostrarsenha";
            cb_mostrarsenha.Size = new Size(101, 19);
            cb_mostrarsenha.TabIndex = 7;
            cb_mostrarsenha.Text = "Mostrar senha";
            cb_mostrarsenha.TextAlign = ContentAlignment.MiddleCenter;
            cb_mostrarsenha.UseVisualStyleBackColor = true;
            cb_mostrarsenha.CheckedChanged += cb_mostrarsenha_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(58, 306);
            button1.Name = "button1";
            button1.Size = new Size(145, 50);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_cadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(260, 363);
            Controls.Add(button1);
            Controls.Add(cb_mostrarsenha);
            Controls.Add(btn_entrar);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_user);
            Controls.Add(lbl_titulo);
            Controls.Add(lbl_user);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_user;
        private Label lbl_titulo;
        private TextBox txt_user;
        private Label lbl_senha;
        private TextBox txt_senha;
        private Button btn_entrar;
        private CheckBox cb_mostrarsenha;
        private Button button1;
    }
}