namespace MainMenu.Forms
{
    partial class Ponto
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBater = new System.Windows.Forms.Button();
            this.hora_entrada = new System.Windows.Forms.TextBox();
            this.total_horas = new System.Windows.Forms.TextBox();
            this.hora_saida = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bater ponto";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.lblStatus.Location = new System.Drawing.Point(53, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 33);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainMenu.Properties.Resources.clock_48px;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 55);
            this.panel1.TabIndex = 2;
            // 
            // btnBater
            // 
            this.btnBater.Location = new System.Drawing.Point(426, 370);
            this.btnBater.Name = "btnBater";
            this.btnBater.Size = new System.Drawing.Size(75, 23);
            this.btnBater.TabIndex = 3;
            this.btnBater.Text = "Bater";
            this.btnBater.UseVisualStyleBackColor = true;
            this.btnBater.Click += new System.EventHandler(this.btnBater_Click);
            // 
            // hora_entrada
            // 
            this.hora_entrada.Location = new System.Drawing.Point(295, 110);
            this.hora_entrada.Name = "hora_entrada";
            this.hora_entrada.Size = new System.Drawing.Size(210, 20);
            this.hora_entrada.TabIndex = 4;
            // 
            // total_horas
            // 
            this.total_horas.Location = new System.Drawing.Point(225, 222);
            this.total_horas.Name = "total_horas";
            this.total_horas.Size = new System.Drawing.Size(351, 20);
            this.total_horas.TabIndex = 5;
            // 
            // hora_saida
            // 
            this.hora_saida.Location = new System.Drawing.Point(295, 165);
            this.hora_saida.Name = "hora_saida";
            this.hora_saida.Size = new System.Drawing.Size(210, 20);
            this.hora_saida.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ponto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hora_saida);
            this.Controls.Add(this.total_horas);
            this.Controls.Add(this.hora_entrada);
            this.Controls.Add(this.btnBater);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ponto";
            this.Text = "Ponto";
            this.Load += new System.EventHandler(this.Ponto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBater;
        private System.Windows.Forms.TextBox hora_entrada;
        private System.Windows.Forms.TextBox total_horas;
        private System.Windows.Forms.TextBox hora_saida;
        private System.Windows.Forms.Button button1;
    }
}