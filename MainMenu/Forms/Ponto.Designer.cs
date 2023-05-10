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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hora_entrada = new System.Windows.Forms.TextBox();
            this.total_horas = new System.Windows.Forms.TextBox();
            this.hora_saida = new System.Windows.Forms.TextBox();
            this.btnBater = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.total_horas2 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTextWelcome = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(413, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bater ponto";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.lblStatus.Location = new System.Drawing.Point(53, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 29);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Location = new System.Drawing.Point(420, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 55);
            this.panel1.TabIndex = 2;
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
            // hora_entrada
            // 
            this.hora_entrada.BackColor = System.Drawing.Color.White;
            this.hora_entrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hora_entrada.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hora_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_entrada.Location = new System.Drawing.Point(278, 259);
            this.hora_entrada.Name = "hora_entrada";
            this.hora_entrada.ReadOnly = true;
            this.hora_entrada.Size = new System.Drawing.Size(210, 24);
            this.hora_entrada.TabIndex = 4;
            // 
            // total_horas
            // 
            this.total_horas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_horas.Location = new System.Drawing.Point(203, 326);
            this.total_horas.Name = "total_horas";
            this.total_horas.Size = new System.Drawing.Size(613, 24);
            this.total_horas.TabIndex = 5;
            // 
            // hora_saida
            // 
            this.hora_saida.BackColor = System.Drawing.Color.White;
            this.hora_saida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hora_saida.Cursor = System.Windows.Forms.Cursors.Default;
            this.hora_saida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_saida.Location = new System.Drawing.Point(585, 265);
            this.hora_saida.Name = "hora_saida";
            this.hora_saida.ReadOnly = true;
            this.hora_saida.Size = new System.Drawing.Size(210, 24);
            this.hora_saida.TabIndex = 6;
            this.hora_saida.TextChanged += new System.EventHandler(this.hora_saida_TextChanged);
            // 
            // btnBater
            // 
            this.btnBater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBater.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBater.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBater.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBater.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBater.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnBater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBater.ForeColor = System.Drawing.Color.White;
            this.btnBater.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.btnBater.Location = new System.Drawing.Point(395, 407);
            this.btnBater.Name = "btnBater";
            this.btnBater.Size = new System.Drawing.Size(232, 64);
            this.btnBater.TabIndex = 8;
            this.btnBater.Text = "REGISTRAR PONTO";
            this.btnBater.Click += new System.EventHandler(this.btnBater_Click_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.btnBater;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(278, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Entrou";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panel2.Location = new System.Drawing.Point(223, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 1);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panel3.Location = new System.Drawing.Point(530, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 1);
            this.panel3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(585, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Saiu";
            // 
            // total_horas2
            // 
            this.total_horas2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_horas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_horas2.Location = new System.Drawing.Point(348, 358);
            this.total_horas2.Name = "total_horas2";
            this.total_horas2.Size = new System.Drawing.Size(323, 24);
            this.total_horas2.TabIndex = 16;
            this.total_horas2.TextChanged += new System.EventHandler(this.total_horas2_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnClose.Location = new System.Drawing.Point(971, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 32);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTextWelcome
            // 
            this.lblTextWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.lblTextWelcome.Location = new System.Drawing.Point(357, 141);
            this.lblTextWelcome.Name = "lblTextWelcome";
            this.lblTextWelcome.Size = new System.Drawing.Size(405, 49);
            this.lblTextWelcome.TabIndex = 19;
            this.lblTextWelcome.Click += new System.EventHandler(this.lblTextWelcome_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MainMenu.Properties.Resources.team_skin_type_7_48px;
            this.pictureBox4.Location = new System.Drawing.Point(298, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 49);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MainMenu.Properties.Resources.saida_48px;
            this.pictureBox3.Location = new System.Drawing.Point(530, 239);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MainMenu.Properties.Resources.entrada_48px;
            this.pictureBox2.Location = new System.Drawing.Point(223, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Ponto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 532);
            this.Controls.Add(this.lblTextWelcome);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.total_horas2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBater);
            this.Controls.Add(this.hora_saida);
            this.Controls.Add(this.total_horas);
            this.Controls.Add(this.hora_entrada);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ponto";
            this.Text = "Ponto";
            this.Load += new System.EventHandler(this.Ponto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox hora_entrada;
        private System.Windows.Forms.TextBox total_horas;
        private System.Windows.Forms.TextBox hora_saida;
        private Guna.UI2.WinForms.Guna2TileButton btnBater;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox total_horas2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTextWelcome;
    }
}