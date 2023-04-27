namespace cadastrarFuncionario
{
    partial class CadastrarFuncionario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txt_nome = new TextBox();
            txt_ctps = new TextBox();
            txt_admissao = new MaskedTextBox();
            txt_nascimento = new MaskedTextBox();
            txt_banco = new TextBox();
            txt_conta = new TextBox();
            txt_cpf = new TextBox();
            txt_email = new TextBox();
            txt_endereco = new TextBox();
            cb_ativo = new CheckBox();
            btn_salvar = new Button();
            txt_salario = new TextBox();
            label11 = new Label();
            cmb_cargo = new ComboBox();
            txt_telefone = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 19);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Data de Admissão";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 19);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "CTPS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(582, 19);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 124);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Banco";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 124);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Conta";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(396, 124);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 6;
            label7.Text = "CPF";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(582, 124);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 7;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 225);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 8;
            label9.Text = "Endereço";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(211, 225);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 9;
            label10.Text = "Cargo";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(23, 37);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(140, 23);
            txt_nome.TabIndex = 11;
            // 
            // txt_ctps
            // 
            txt_ctps.Location = new Point(396, 37);
            txt_ctps.Name = "txt_ctps";
            txt_ctps.Size = new Size(140, 23);
            txt_ctps.TabIndex = 13;
            // 
            // txt_admissao
            // 
            txt_admissao.Location = new Point(211, 37);
            txt_admissao.Mask = "00/00/0000";
            txt_admissao.Name = "txt_admissao";
            txt_admissao.Size = new Size(140, 23);
            txt_admissao.TabIndex = 15;
            // 
            // txt_nascimento
            // 
            txt_nascimento.Location = new Point(582, 37);
            txt_nascimento.Mask = "00/00/0000";
            txt_nascimento.Name = "txt_nascimento";
            txt_nascimento.Size = new Size(140, 23);
            txt_nascimento.TabIndex = 16;
            // 
            // txt_banco
            // 
            txt_banco.Location = new Point(23, 142);
            txt_banco.Name = "txt_banco";
            txt_banco.Size = new Size(140, 23);
            txt_banco.TabIndex = 17;
            // 
            // txt_conta
            // 
            txt_conta.Location = new Point(211, 142);
            txt_conta.Name = "txt_conta";
            txt_conta.Size = new Size(140, 23);
            txt_conta.TabIndex = 18;
            // 
            // txt_cpf
            // 
            txt_cpf.Location = new Point(396, 142);
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(140, 23);
            txt_cpf.TabIndex = 19;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(582, 142);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(140, 23);
            txt_email.TabIndex = 20;
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(23, 243);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(140, 23);
            txt_endereco.TabIndex = 21;
            // 
            // cb_ativo
            // 
            cb_ativo.AutoSize = true;
            cb_ativo.Location = new Point(23, 309);
            cb_ativo.Name = "cb_ativo";
            cb_ativo.Size = new Size(54, 19);
            cb_ativo.TabIndex = 24;
            cb_ativo.Text = "Ativo";
            cb_ativo.UseVisualStyleBackColor = true;
            cb_ativo.CheckedChanged += cck_atvio_CheckedChanged;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(647, 306);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 25;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txt_salario
            // 
            txt_salario.Location = new Point(396, 243);
            txt_salario.Name = "txt_salario";
            txt_salario.Size = new Size(140, 23);
            txt_salario.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(396, 225);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 26;
            label11.Text = "Salario";
            // 
            // cmb_cargo
            // 
            cmb_cargo.FormattingEnabled = true;
            cmb_cargo.Location = new Point(211, 243);
            cmb_cargo.Name = "cmb_cargo";
            cmb_cargo.Size = new Size(140, 23);
            cmb_cargo.TabIndex = 28;
            cmb_cargo.SelectedIndexChanged += cmb_cargo_SelectedIndexChanged;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(582, 243);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(140, 23);
            txt_telefone.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(582, 225);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 29;
            label12.Text = "Telefone";
            // 
            // CadastrarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 384);
            Controls.Add(txt_telefone);
            Controls.Add(label12);
            Controls.Add(cmb_cargo);
            Controls.Add(txt_salario);
            Controls.Add(label11);
            Controls.Add(btn_salvar);
            Controls.Add(cb_ativo);
            Controls.Add(txt_endereco);
            Controls.Add(txt_email);
            Controls.Add(txt_cpf);
            Controls.Add(txt_conta);
            Controls.Add(txt_banco);
            Controls.Add(txt_nascimento);
            Controls.Add(txt_admissao);
            Controls.Add(txt_ctps);
            Controls.Add(txt_nome);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastrarFuncionario";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txt_nome;
        private TextBox txt_ctps;
        private MaskedTextBox txt_admissao;
        private MaskedTextBox txt_nascimento;
        private TextBox txt_banco;
        private TextBox txt_conta;
        private TextBox txt_cpf;
        private TextBox txt_email;
        private TextBox txt_endereco;
        private CheckBox cb_ativo;
        private Button btn_salvar;
        private TextBox txt_salario;
        private Label label11;
        private ComboBox cmb_cargo;
        private TextBox txt_telefone;
        private Label label12;
    }
}