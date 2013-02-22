namespace Gamemania
{
    partial class frmUserConsoles
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVoorraad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblProducent = new System.Windows.Forms.Label();
            this.lblConsole = new System.Windows.Forms.Label();
            this.txtRelease = new System.Windows.Forms.TextBox();
            this.txtProducent = new System.Windows.Forms.TextBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.lblConsoles = new System.Windows.Forms.Label();
            this.lstConsoles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(307, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 137);
            this.pictureBox1.TabIndex = 1028;
            this.pictureBox1.TabStop = false;
            // 
            // lblVoorraad
            // 
            this.lblVoorraad.AutoSize = true;
            this.lblVoorraad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoorraad.Location = new System.Drawing.Point(304, 329);
            this.lblVoorraad.Name = "lblVoorraad";
            this.lblVoorraad.Size = new System.Drawing.Size(63, 17);
            this.lblVoorraad.TabIndex = 1027;
            this.lblVoorraad.Text = "Voorraad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1026;
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelease.Location = new System.Drawing.Point(304, 299);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(97, 17);
            this.lblRelease.TabIndex = 1023;
            this.lblRelease.Text = "Release datum";
            // 
            // lblProducent
            // 
            this.lblProducent.AutoSize = true;
            this.lblProducent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducent.Location = new System.Drawing.Point(304, 272);
            this.lblProducent.Name = "lblProducent";
            this.lblProducent.Size = new System.Drawing.Size(71, 17);
            this.lblProducent.TabIndex = 1021;
            this.lblProducent.Text = "Producent";
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsole.Location = new System.Drawing.Point(304, 242);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(56, 17);
            this.lblConsole.TabIndex = 1020;
            this.lblConsole.Text = "Console";
            // 
            // txtRelease
            // 
            this.txtRelease.Location = new System.Drawing.Point(408, 299);
            this.txtRelease.Name = "txtRelease";
            this.txtRelease.Size = new System.Drawing.Size(100, 20);
            this.txtRelease.TabIndex = 1019;
            // 
            // txtProducent
            // 
            this.txtProducent.Location = new System.Drawing.Point(408, 269);
            this.txtProducent.Name = "txtProducent";
            this.txtProducent.Size = new System.Drawing.Size(100, 20);
            this.txtProducent.TabIndex = 1017;
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(408, 239);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(100, 20);
            this.txtConsole.TabIndex = 1016;
            // 
            // lblConsoles
            // 
            this.lblConsoles.AutoSize = true;
            this.lblConsoles.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblConsoles.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsoles.Location = new System.Drawing.Point(16, 32);
            this.lblConsoles.Name = "lblConsoles";
            this.lblConsoles.Size = new System.Drawing.Size(131, 37);
            this.lblConsoles.TabIndex = 1015;
            this.lblConsoles.Text = "Consoles";
            // 
            // lstConsoles
            // 
            this.lstConsoles.FormattingEnabled = true;
            this.lstConsoles.Location = new System.Drawing.Point(23, 86);
            this.lstConsoles.Name = "lstConsoles";
            this.lstConsoles.Size = new System.Drawing.Size(247, 264);
            this.lstConsoles.TabIndex = 1014;
            // 
            // frmUserConsoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVoorraad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRelease);
            this.Controls.Add(this.lblProducent);
            this.Controls.Add(this.lblConsole);
            this.Controls.Add(this.txtRelease);
            this.Controls.Add(this.txtProducent);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lblConsoles);
            this.Controls.Add(this.lstConsoles);
            this.Name = "frmUserConsoles";
            this.Text = "frmUserConsoles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVoorraad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.Label lblProducent;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.TextBox txtRelease;
        private System.Windows.Forms.TextBox txtProducent;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label lblConsoles;
        private System.Windows.Forms.ListBox lstConsoles;

    }
}