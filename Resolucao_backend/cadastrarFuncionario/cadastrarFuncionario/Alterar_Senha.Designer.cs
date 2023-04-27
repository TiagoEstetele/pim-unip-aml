namespace cadastrarFuncionario
{
    partial class Alterar_Senha
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
            lbl_subtit1 = new Label();
            lbl_titulo = new Label();
            lbl_subtit2 = new Label();
            txt_senha1 = new TextBox();
            txt_senha2 = new TextBox();
            lbl_senha1 = new Label();
            lbl_senha2 = new Label();
            btn_salvarsenha = new Button();
            SuspendLayout();
            // 
            // lbl_subtit1
            // 
            lbl_subtit1.AutoSize = true;
            lbl_subtit1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_subtit1.Location = new Point(27, 84);
            lbl_subtit1.Name = "lbl_subtit1";
            lbl_subtit1.Size = new Size(747, 30);
            lbl_subtit1.TabIndex = 1;
            lbl_subtit1.Text = "Detectamos que é seu primeiro acesso, favor realizar a alteração de senha para";
            lbl_subtit1.Click += label1_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titulo.Location = new Point(237, 20);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(326, 54);
            lbl_titulo.TabIndex = 2;
            lbl_titulo.Text = "Bem vindo a IBH!";
            // 
            // lbl_subtit2
            // 
            lbl_subtit2.AutoSize = true;
            lbl_subtit2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_subtit2.Location = new Point(237, 114);
            lbl_subtit2.Name = "lbl_subtit2";
            lbl_subtit2.Size = new Size(327, 30);
            lbl_subtit2.TabIndex = 3;
            lbl_subtit2.Text = "manter a segurança da sua conta.";
            // 
            // txt_senha1
            // 
            txt_senha1.Location = new Point(377, 256);
            txt_senha1.Name = "txt_senha1";
            txt_senha1.Size = new Size(191, 23);
            txt_senha1.TabIndex = 4;
            // 
            // txt_senha2
            // 
            txt_senha2.Location = new Point(377, 304);
            txt_senha2.Name = "txt_senha2";
            txt_senha2.Size = new Size(191, 23);
            txt_senha2.TabIndex = 5;
            // 
            // lbl_senha1
            // 
            lbl_senha1.AutoSize = true;
            lbl_senha1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_senha1.Location = new Point(285, 256);
            lbl_senha1.Name = "lbl_senha1";
            lbl_senha1.Size = new Size(86, 20);
            lbl_senha1.TabIndex = 6;
            lbl_senha1.Text = "Nova senha";
            // 
            // lbl_senha2
            // 
            lbl_senha2.AutoSize = true;
            lbl_senha2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_senha2.Location = new Point(233, 307);
            lbl_senha2.Name = "lbl_senha2";
            lbl_senha2.Size = new Size(138, 20);
            lbl_senha2.TabIndex = 7;
            lbl_senha2.Text = "Confirme sua senha";
            // 
            // btn_salvarsenha
            // 
            btn_salvarsenha.Location = new Point(713, 415);
            btn_salvarsenha.Name = "btn_salvarsenha";
            btn_salvarsenha.Size = new Size(75, 23);
            btn_salvarsenha.TabIndex = 8;
            btn_salvarsenha.Text = "Salvar";
            btn_salvarsenha.UseVisualStyleBackColor = true;
            btn_salvarsenha.Click += btn_salvarsenha_Click;
            // 
            // Alterar_Senha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_salvarsenha);
            Controls.Add(lbl_senha2);
            Controls.Add(lbl_senha1);
            Controls.Add(txt_senha2);
            Controls.Add(txt_senha1);
            Controls.Add(lbl_subtit2);
            Controls.Add(lbl_titulo);
            Controls.Add(lbl_subtit1);
            Name = "Alterar_Senha";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_subtit1;
        private Label lbl_titulo;
        private Label lbl_subtit2;
        private TextBox txt_senha1;
        private TextBox txt_senha2;
        private Label lbl_senha1;
        private Label lbl_senha2;
        private Button btn_salvarsenha;
    }
}