namespace cadastrarFuncionario
{
    partial class ControlePonto
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
            bater_ponto = new Button();
            data_entrada = new TextBox();
            data_saida = new TextBox();
            total_horas = new TextBox();
            SuspendLayout();
            // 
            // bater_ponto
            // 
            bater_ponto.Location = new Point(334, 355);
            bater_ponto.Name = "bater_ponto";
            bater_ponto.Size = new Size(107, 23);
            bater_ponto.TabIndex = 0;
            bater_ponto.Text = "Bater ponto";
            bater_ponto.UseVisualStyleBackColor = true;
            bater_ponto.Click += hora_atual_Click;
            // 
            // data_entrada
            // 
            data_entrada.Location = new Point(301, 101);
            data_entrada.Name = "data_entrada";
            data_entrada.Size = new Size(168, 23);
            data_entrada.TabIndex = 1;
            // 
            // data_saida
            // 
            data_saida.Location = new Point(301, 181);
            data_saida.Name = "data_saida";
            data_saida.Size = new Size(168, 23);
            data_saida.TabIndex = 2;
            // 
            // total_horas
            // 
            total_horas.Location = new Point(301, 265);
            total_horas.Name = "total_horas";
            total_horas.Size = new Size(168, 23);
            total_horas.TabIndex = 3;
            // 
            // ControlePonto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(total_horas);
            Controls.Add(data_saida);
            Controls.Add(data_entrada);
            Controls.Add(bater_ponto);
            Name = "ControlePonto";
            Text = "ControlePonto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bater_ponto;
        private TextBox data_entrada;
        private TextBox data_saida;
        private TextBox total_horas;
    }
}