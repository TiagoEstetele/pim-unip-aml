namespace MainMenu.Forms.InfoBoxs
{
    partial class alertBox
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
            this.lblTitleAlertBox = new System.Windows.Forms.Label();
            this.lblTextAlertBox = new System.Windows.Forms.Label();
            this.linAlertBox = new System.Windows.Forms.Panel();
            this.timerAnimasion = new System.Windows.Forms.Timer(this.components);
            this.picAlertBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAlertBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleAlertBox
            // 
            this.lblTitleAlertBox.AutoSize = true;
            this.lblTitleAlertBox.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAlertBox.Location = new System.Drawing.Point(66, 13);
            this.lblTitleAlertBox.Name = "lblTitleAlertBox";
            this.lblTitleAlertBox.Size = new System.Drawing.Size(154, 29);
            this.lblTitleAlertBox.TabIndex = 1;
            this.lblTitleAlertBox.Text = "AlertTextBox";
            // 
            // lblTextAlertBox
            // 
            this.lblTextAlertBox.AutoSize = true;
            this.lblTextAlertBox.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextAlertBox.Location = new System.Drawing.Point(69, 42);
            this.lblTextAlertBox.Name = "lblTextAlertBox";
            this.lblTextAlertBox.Size = new System.Drawing.Size(149, 22);
            this.lblTextAlertBox.TabIndex = 2;
            this.lblTextAlertBox.Text = "TextAlertTextBox";
            // 
            // linAlertBox
            // 
            this.linAlertBox.BackColor = System.Drawing.Color.Black;
            this.linAlertBox.Location = new System.Drawing.Point(0, 74);
            this.linAlertBox.Name = "linAlertBox";
            this.linAlertBox.Size = new System.Drawing.Size(5, 6);
            this.linAlertBox.TabIndex = 3;
            // 
            // timerAnimasion
            // 
            this.timerAnimasion.Interval = 10;
            this.timerAnimasion.Tick += new System.EventHandler(this.timerAnimasion_Tick);
            // 
            // picAlertBox
            // 
            this.picAlertBox.Location = new System.Drawing.Point(12, 15);
            this.picAlertBox.Name = "picAlertBox";
            this.picAlertBox.Size = new System.Drawing.Size(100, 50);
            this.picAlertBox.TabIndex = 0;
            this.picAlertBox.TabStop = false;
            // 
            // alertBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 80);
            this.Controls.Add(this.linAlertBox);
            this.Controls.Add(this.lblTextAlertBox);
            this.Controls.Add(this.lblTitleAlertBox);
            this.Controls.Add(this.picAlertBox);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alertBox";
            this.Text = "alertBox";
            this.Load += new System.EventHandler(this.alertBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlertBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlertBox;
        private System.Windows.Forms.Label lblTitleAlertBox;
        private System.Windows.Forms.Label lblTextAlertBox;
        private System.Windows.Forms.Panel linAlertBox;
        private System.Windows.Forms.Timer timerAnimasion;
    }
}