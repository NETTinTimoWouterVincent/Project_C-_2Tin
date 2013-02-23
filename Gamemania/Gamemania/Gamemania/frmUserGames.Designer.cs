namespace Gamemania
{
    partial class frmUserGames
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
            this.lstGames = new System.Windows.Forms.ListBox();
            this.lblGames = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtOntwikkelaar = new System.Windows.Forms.TextBox();
            this.txtUitgever = new System.Windows.Forms.TextBox();
            this.txtRelease = new System.Windows.Forms.TextBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblOntwikkelaar = new System.Windows.Forms.Label();
            this.lblUitgever = new System.Windows.Forms.Label();
            this.lblRelease = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.lblConsole = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblVoorraad = new System.Windows.Forms.Label();
            this.picGames = new System.Windows.Forms.PictureBox();
            this.btnKopen = new System.Windows.Forms.Button();
            this.btnSite = new System.Windows.Forms.Button();
            this.lblInformatie = new System.Windows.Forms.Label();
            this.txtInformatie = new System.Windows.Forms.TextBox();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGames)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGames
            // 
            this.lstGames.FormattingEnabled = true;
            this.lstGames.Location = new System.Drawing.Point(23, 86);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(247, 316);
            this.lstGames.TabIndex = 0;
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGames.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.Location = new System.Drawing.Point(16, 32);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(103, 37);
            this.lblGames.TabIndex = 1000;
            this.lblGames.Text = "Games";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(418, 86);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 1001;
            // 
            // txtOntwikkelaar
            // 
            this.txtOntwikkelaar.Location = new System.Drawing.Point(418, 116);
            this.txtOntwikkelaar.Name = "txtOntwikkelaar";
            this.txtOntwikkelaar.Size = new System.Drawing.Size(100, 20);
            this.txtOntwikkelaar.TabIndex = 1002;
            // 
            // txtUitgever
            // 
            this.txtUitgever.Location = new System.Drawing.Point(418, 146);
            this.txtUitgever.Name = "txtUitgever";
            this.txtUitgever.Size = new System.Drawing.Size(100, 20);
            this.txtUitgever.TabIndex = 1003;
            // 
            // txtRelease
            // 
            this.txtRelease.Location = new System.Drawing.Point(418, 176);
            this.txtRelease.Name = "txtRelease";
            this.txtRelease.Size = new System.Drawing.Size(100, 20);
            this.txtRelease.TabIndex = 1004;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(314, 89);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(33, 17);
            this.lblTitel.TabIndex = 1005;
            this.lblTitel.Text = "Titel";
            // 
            // lblOntwikkelaar
            // 
            this.lblOntwikkelaar.AutoSize = true;
            this.lblOntwikkelaar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOntwikkelaar.Location = new System.Drawing.Point(314, 119);
            this.lblOntwikkelaar.Name = "lblOntwikkelaar";
            this.lblOntwikkelaar.Size = new System.Drawing.Size(87, 17);
            this.lblOntwikkelaar.TabIndex = 1006;
            this.lblOntwikkelaar.Text = "Ontwikkelaar";
            // 
            // lblUitgever
            // 
            this.lblUitgever.AutoSize = true;
            this.lblUitgever.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUitgever.Location = new System.Drawing.Point(314, 149);
            this.lblUitgever.Name = "lblUitgever";
            this.lblUitgever.Size = new System.Drawing.Size(59, 17);
            this.lblUitgever.TabIndex = 1007;
            this.lblUitgever.Text = "Uitgever";
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelease.Location = new System.Drawing.Point(314, 179);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(97, 17);
            this.lblRelease.TabIndex = 1008;
            this.lblRelease.Text = "Release datum";
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(418, 206);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(100, 20);
            this.txtConsole.TabIndex = 1009;
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsole.Location = new System.Drawing.Point(314, 209);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(56, 17);
            this.lblConsole.TabIndex = 1010;
            this.lblConsole.Text = "Console";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1011;
            // 
            // lblVoorraad
            // 
            this.lblVoorraad.AutoSize = true;
            this.lblVoorraad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoorraad.Location = new System.Drawing.Point(314, 239);
            this.lblVoorraad.Name = "lblVoorraad";
            this.lblVoorraad.Size = new System.Drawing.Size(63, 17);
            this.lblVoorraad.TabIndex = 1012;
            this.lblVoorraad.Text = "Voorraad";
            // 
            // picGames
            // 
            this.picGames.Location = new System.Drawing.Point(572, 86);
            this.picGames.Name = "picGames";
            this.picGames.Size = new System.Drawing.Size(155, 170);
            this.picGames.TabIndex = 1013;
            this.picGames.TabStop = false;
            // 
            // btnKopen
            // 
            this.btnKopen.Location = new System.Drawing.Point(572, 338);
            this.btnKopen.Name = "btnKopen";
            this.btnKopen.Size = new System.Drawing.Size(155, 38);
            this.btnKopen.TabIndex = 1036;
            this.btnKopen.Text = "Kopen";
            this.btnKopen.UseVisualStyleBackColor = true;
            // 
            // btnSite
            // 
            this.btnSite.Location = new System.Drawing.Point(572, 290);
            this.btnSite.Name = "btnSite";
            this.btnSite.Size = new System.Drawing.Size(155, 37);
            this.btnSite.TabIndex = 1035;
            this.btnSite.Text = "Website";
            this.btnSite.UseVisualStyleBackColor = true;
            // 
            // lblInformatie
            // 
            this.lblInformatie.AutoSize = true;
            this.lblInformatie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformatie.Location = new System.Drawing.Point(314, 270);
            this.lblInformatie.Name = "lblInformatie";
            this.lblInformatie.Size = new System.Drawing.Size(105, 17);
            this.lblInformatie.TabIndex = 1038;
            this.lblInformatie.Text = "Meer informatie";
            // 
            // txtInformatie
            // 
            this.txtInformatie.Location = new System.Drawing.Point(317, 290);
            this.txtInformatie.Multiline = true;
            this.txtInformatie.Name = "txtInformatie";
            this.txtInformatie.Size = new System.Drawing.Size(201, 112);
            this.txtInformatie.TabIndex = 1037;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijs.Location = new System.Drawing.Point(565, 382);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(33, 17);
            this.lblPrijs.TabIndex = 1040;
            this.lblPrijs.Text = "Prijs";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(602, 382);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 20);
            this.textBox3.TabIndex = 1039;
            // 
            // frmUserGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 473);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblInformatie);
            this.Controls.Add(this.txtInformatie);
            this.Controls.Add(this.btnKopen);
            this.Controls.Add(this.btnSite);
            this.Controls.Add(this.picGames);
            this.Controls.Add(this.lblVoorraad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblConsole);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lblRelease);
            this.Controls.Add(this.lblUitgever);
            this.Controls.Add(this.lblOntwikkelaar);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.txtRelease);
            this.Controls.Add(this.txtUitgever);
            this.Controls.Add(this.txtOntwikkelaar);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.lstGames);
            this.Name = "frmUserGames";
            this.Text = "frmUserGames";
            ((System.ComponentModel.ISupportInitialize)(this.picGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtOntwikkelaar;
        private System.Windows.Forms.TextBox txtUitgever;
        private System.Windows.Forms.TextBox txtRelease;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblOntwikkelaar;
        private System.Windows.Forms.Label lblUitgever;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblVoorraad;
        private System.Windows.Forms.PictureBox picGames;
        private System.Windows.Forms.Button btnKopen;
        private System.Windows.Forms.Button btnSite;
        private System.Windows.Forms.Label lblInformatie;
        private System.Windows.Forms.TextBox txtInformatie;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.TextBox textBox3;

    }
}