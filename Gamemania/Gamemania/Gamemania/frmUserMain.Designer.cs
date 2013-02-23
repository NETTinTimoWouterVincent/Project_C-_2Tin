namespace Gamemania
{
    partial class frmUserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserMain));
            this.RibbonMain = new System.Windows.Forms.Ribbon();
            this.tabGenres = new System.Windows.Forms.RibbonTab();
            this.pnlFps = new System.Windows.Forms.RibbonPanel();
            this.btnFps = new System.Windows.Forms.RibbonButton();
            this.pnlRpg = new System.Windows.Forms.RibbonPanel();
            this.btnRpg = new System.Windows.Forms.RibbonButton();
            this.pnlRts = new System.Windows.Forms.RibbonPanel();
            this.btnRts = new System.Windows.Forms.RibbonButton();
            this.pnlAction = new System.Windows.Forms.RibbonPanel();
            this.btnAction = new System.Windows.Forms.RibbonButton();
            this.pnlRacing = new System.Windows.Forms.RibbonPanel();
            this.btnRace = new System.Windows.Forms.RibbonButton();
            this.tabGames = new System.Windows.Forms.RibbonTab();
            this.pnlGames = new System.Windows.Forms.RibbonPanel();
            this.btnAllGames = new System.Windows.Forms.RibbonButton();
            this.btnPS3Games = new System.Windows.Forms.RibbonButton();
            this.btnXboxGames = new System.Windows.Forms.RibbonButton();
            this.btnWiiGames = new System.Windows.Forms.RibbonButton();
            this.tabConsoles = new System.Windows.Forms.RibbonTab();
            this.pnlAllConsoles = new System.Windows.Forms.RibbonPanel();
            this.btnAllConsoles = new System.Windows.Forms.RibbonButton();
            this.btnPS3Consoles = new System.Windows.Forms.RibbonButton();
            this.btnXboxConsole = new System.Windows.Forms.RibbonButton();
            this.btnWiiConsole = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // RibbonMain
            // 
            this.RibbonMain.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.RibbonMain.Location = new System.Drawing.Point(0, 0);
            this.RibbonMain.Minimized = false;
            this.RibbonMain.Name = "RibbonMain";
            // 
            // 
            // 
            this.RibbonMain.OrbDropDown.BorderRoundness = 8;
            this.RibbonMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.RibbonMain.OrbDropDown.Name = "";
            this.RibbonMain.OrbDropDown.RecentItemsCaption = null;
            this.RibbonMain.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.RibbonMain.OrbDropDown.TabIndex = 0;
            this.RibbonMain.OrbImage = null;
            this.RibbonMain.OrbText = null;
            // 
            // 
            // 
            this.RibbonMain.QuickAcessToolbar.AltKey = null;
            this.RibbonMain.QuickAcessToolbar.CheckedGroup = null;
            this.RibbonMain.QuickAcessToolbar.Image = null;
            this.RibbonMain.QuickAcessToolbar.ShowFlashImage = false;
            this.RibbonMain.QuickAcessToolbar.Tag = null;
            this.RibbonMain.QuickAcessToolbar.Text = null;
            this.RibbonMain.QuickAcessToolbar.ToolTip = null;
            this.RibbonMain.QuickAcessToolbar.ToolTipTitle = null;
            this.RibbonMain.QuickAcessToolbar.Value = null;
            this.RibbonMain.Size = new System.Drawing.Size(951, 166);
            this.RibbonMain.TabIndex = 0;
            this.RibbonMain.Tabs.Add(this.tabGenres);
            this.RibbonMain.Tabs.Add(this.tabGames);
            this.RibbonMain.Tabs.Add(this.tabConsoles);
            this.RibbonMain.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.RibbonMain.TabSpacing = 6;
            this.RibbonMain.Text = "ribbon1";
            // 
            // tabGenres
            // 
            this.tabGenres.Panels.Add(this.pnlFps);
            this.tabGenres.Panels.Add(this.pnlRpg);
            this.tabGenres.Panels.Add(this.pnlRts);
            this.tabGenres.Panels.Add(this.pnlAction);
            this.tabGenres.Panels.Add(this.pnlRacing);
            this.tabGenres.Tag = null;
            this.tabGenres.Text = "Genres";
            this.tabGenres.ToolTip = null;
            this.tabGenres.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.tabGenres.ToolTipImage = null;
            this.tabGenres.ToolTipTitle = null;
            this.tabGenres.Value = null;
            // 
            // pnlFps
            // 
            this.pnlFps.Items.Add(this.btnFps);
            this.pnlFps.Tag = null;
            this.pnlFps.Text = "";
            // 
            // btnFps
            // 
            this.btnFps.AltKey = null;
            this.btnFps.CheckedGroup = null;
            this.btnFps.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnFps.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnFps.Image = ((System.Drawing.Image)(resources.GetObject("btnFps.Image")));
            this.btnFps.ShowFlashImage = false;
            this.btnFps.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnFps.SmallImage")));
            this.btnFps.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnFps.Tag = null;
            this.btnFps.Text = "Shooter";
            this.btnFps.ToolTip = null;
            this.btnFps.ToolTipTitle = null;
            this.btnFps.Value = null;
            this.btnFps.Click += new System.EventHandler(this.btnFps_Click);
            // 
            // pnlRpg
            // 
            this.pnlRpg.Items.Add(this.btnRpg);
            this.pnlRpg.Tag = null;
            this.pnlRpg.Text = "";
            // 
            // btnRpg
            // 
            this.btnRpg.AltKey = null;
            this.btnRpg.CheckedGroup = null;
            this.btnRpg.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnRpg.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnRpg.Image = ((System.Drawing.Image)(resources.GetObject("btnRpg.Image")));
            this.btnRpg.ShowFlashImage = false;
            this.btnRpg.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRpg.SmallImage")));
            this.btnRpg.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnRpg.Tag = null;
            this.btnRpg.Text = "RPG";
            this.btnRpg.ToolTip = null;
            this.btnRpg.ToolTipTitle = null;
            this.btnRpg.Value = null;
            this.btnRpg.Click += new System.EventHandler(this.btnRpg_Click);
            // 
            // pnlRts
            // 
            this.pnlRts.Items.Add(this.btnRts);
            this.pnlRts.Tag = null;
            this.pnlRts.Text = "";
            // 
            // btnRts
            // 
            this.btnRts.AltKey = null;
            this.btnRts.CheckedGroup = null;
            this.btnRts.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnRts.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnRts.Image = ((System.Drawing.Image)(resources.GetObject("btnRts.Image")));
            this.btnRts.ShowFlashImage = false;
            this.btnRts.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRts.SmallImage")));
            this.btnRts.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnRts.Tag = null;
            this.btnRts.Text = "Strategy";
            this.btnRts.ToolTip = null;
            this.btnRts.ToolTipTitle = null;
            this.btnRts.Value = null;
            this.btnRts.Click += new System.EventHandler(this.btnRts_Click);
            // 
            // pnlAction
            // 
            this.pnlAction.Items.Add(this.btnAction);
            this.pnlAction.Tag = null;
            this.pnlAction.Text = "";
            // 
            // btnAction
            // 
            this.btnAction.AltKey = null;
            this.btnAction.CheckedGroup = null;
            this.btnAction.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnAction.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnAction.Image = ((System.Drawing.Image)(resources.GetObject("btnAction.Image")));
            this.btnAction.ShowFlashImage = false;
            this.btnAction.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAction.SmallImage")));
            this.btnAction.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnAction.Tag = null;
            this.btnAction.Text = "Action";
            this.btnAction.ToolTip = null;
            this.btnAction.ToolTipTitle = null;
            this.btnAction.Value = null;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // pnlRacing
            // 
            this.pnlRacing.Items.Add(this.btnRace);
            this.pnlRacing.Tag = null;
            this.pnlRacing.Text = "";
            // 
            // btnRace
            // 
            this.btnRace.AltKey = null;
            this.btnRace.CheckedGroup = null;
            this.btnRace.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnRace.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnRace.Image = ((System.Drawing.Image)(resources.GetObject("btnRace.Image")));
            this.btnRace.ShowFlashImage = false;
            this.btnRace.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRace.SmallImage")));
            this.btnRace.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnRace.Tag = null;
            this.btnRace.Text = "Race";
            this.btnRace.ToolTip = null;
            this.btnRace.ToolTipTitle = null;
            this.btnRace.Value = null;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // tabGames
            // 
            this.tabGames.Panels.Add(this.pnlGames);
            this.tabGames.Tag = null;
            this.tabGames.Text = "Games";
            this.tabGames.ToolTip = null;
            this.tabGames.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.tabGames.ToolTipImage = null;
            this.tabGames.ToolTipTitle = null;
            this.tabGames.Value = null;
            // 
            // pnlGames
            // 
            this.pnlGames.Items.Add(this.btnAllGames);
            this.pnlGames.Items.Add(this.btnPS3Games);
            this.pnlGames.Items.Add(this.btnXboxGames);
            this.pnlGames.Items.Add(this.btnWiiGames);
            this.pnlGames.Tag = null;
            this.pnlGames.Text = "";
            // 
            // btnAllGames
            // 
            this.btnAllGames.AltKey = null;
            this.btnAllGames.CheckedGroup = null;
            this.btnAllGames.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnAllGames.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnAllGames.Image = ((System.Drawing.Image)(resources.GetObject("btnAllGames.Image")));
            this.btnAllGames.ShowFlashImage = false;
            this.btnAllGames.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAllGames.SmallImage")));
            this.btnAllGames.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnAllGames.Tag = null;
            this.btnAllGames.Text = "Alle";
            this.btnAllGames.ToolTip = null;
            this.btnAllGames.ToolTipTitle = null;
            this.btnAllGames.Value = null;
            this.btnAllGames.Click += new System.EventHandler(this.btnAllGames_Click);
            // 
            // btnPS3Games
            // 
            this.btnPS3Games.AltKey = null;
            this.btnPS3Games.CheckedGroup = null;
            this.btnPS3Games.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnPS3Games.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnPS3Games.Image = ((System.Drawing.Image)(resources.GetObject("btnPS3Games.Image")));
            this.btnPS3Games.ShowFlashImage = false;
            this.btnPS3Games.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPS3Games.SmallImage")));
            this.btnPS3Games.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnPS3Games.Tag = null;
            this.btnPS3Games.Text = "PS3";
            this.btnPS3Games.ToolTip = null;
            this.btnPS3Games.ToolTipTitle = null;
            this.btnPS3Games.Value = null;
            this.btnPS3Games.Click += new System.EventHandler(this.btnPS3Games_Click);
            // 
            // btnXboxGames
            // 
            this.btnXboxGames.AltKey = null;
            this.btnXboxGames.CheckedGroup = null;
            this.btnXboxGames.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnXboxGames.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnXboxGames.Image = ((System.Drawing.Image)(resources.GetObject("btnXboxGames.Image")));
            this.btnXboxGames.ShowFlashImage = false;
            this.btnXboxGames.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnXboxGames.SmallImage")));
            this.btnXboxGames.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnXboxGames.Tag = null;
            this.btnXboxGames.Text = "Xbox";
            this.btnXboxGames.ToolTip = null;
            this.btnXboxGames.ToolTipTitle = null;
            this.btnXboxGames.Value = null;
            this.btnXboxGames.Click += new System.EventHandler(this.btnXboxGames_Click);
            // 
            // btnWiiGames
            // 
            this.btnWiiGames.AltKey = null;
            this.btnWiiGames.CheckedGroup = null;
            this.btnWiiGames.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnWiiGames.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnWiiGames.Image = ((System.Drawing.Image)(resources.GetObject("btnWiiGames.Image")));
            this.btnWiiGames.ShowFlashImage = false;
            this.btnWiiGames.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnWiiGames.SmallImage")));
            this.btnWiiGames.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnWiiGames.Tag = null;
            this.btnWiiGames.Text = "Wii";
            this.btnWiiGames.ToolTip = null;
            this.btnWiiGames.ToolTipTitle = null;
            this.btnWiiGames.Value = null;
            this.btnWiiGames.Click += new System.EventHandler(this.btnWiiGames_Click);
            // 
            // tabConsoles
            // 
            this.tabConsoles.Panels.Add(this.pnlAllConsoles);
            this.tabConsoles.Tag = null;
            this.tabConsoles.Text = "Consoles";
            this.tabConsoles.ToolTip = null;
            this.tabConsoles.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.tabConsoles.ToolTipImage = null;
            this.tabConsoles.ToolTipTitle = null;
            this.tabConsoles.Value = null;
            // 
            // pnlAllConsoles
            // 
            this.pnlAllConsoles.Items.Add(this.btnAllConsoles);
            this.pnlAllConsoles.Items.Add(this.btnPS3Consoles);
            this.pnlAllConsoles.Items.Add(this.btnXboxConsole);
            this.pnlAllConsoles.Items.Add(this.btnWiiConsole);
            this.pnlAllConsoles.Tag = null;
            this.pnlAllConsoles.Text = "";
            // 
            // btnAllConsoles
            // 
            this.btnAllConsoles.AltKey = null;
            this.btnAllConsoles.CheckedGroup = null;
            this.btnAllConsoles.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnAllConsoles.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnAllConsoles.Image = ((System.Drawing.Image)(resources.GetObject("btnAllConsoles.Image")));
            this.btnAllConsoles.ShowFlashImage = false;
            this.btnAllConsoles.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAllConsoles.SmallImage")));
            this.btnAllConsoles.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnAllConsoles.Tag = null;
            this.btnAllConsoles.Text = "Alle";
            this.btnAllConsoles.ToolTip = null;
            this.btnAllConsoles.ToolTipTitle = null;
            this.btnAllConsoles.Value = null;
            this.btnAllConsoles.Click += new System.EventHandler(this.btnAllConsoles_Click);
            // 
            // btnPS3Consoles
            // 
            this.btnPS3Consoles.AltKey = null;
            this.btnPS3Consoles.CheckedGroup = null;
            this.btnPS3Consoles.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnPS3Consoles.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnPS3Consoles.Image = ((System.Drawing.Image)(resources.GetObject("btnPS3Consoles.Image")));
            this.btnPS3Consoles.ShowFlashImage = false;
            this.btnPS3Consoles.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPS3Consoles.SmallImage")));
            this.btnPS3Consoles.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnPS3Consoles.Tag = null;
            this.btnPS3Consoles.Text = "PS3";
            this.btnPS3Consoles.ToolTip = null;
            this.btnPS3Consoles.ToolTipTitle = null;
            this.btnPS3Consoles.Value = null;
            this.btnPS3Consoles.Click += new System.EventHandler(this.btnPS3Consoles_Click);
            // 
            // btnXboxConsole
            // 
            this.btnXboxConsole.AltKey = null;
            this.btnXboxConsole.CheckedGroup = null;
            this.btnXboxConsole.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnXboxConsole.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnXboxConsole.Image = ((System.Drawing.Image)(resources.GetObject("btnXboxConsole.Image")));
            this.btnXboxConsole.ShowFlashImage = false;
            this.btnXboxConsole.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnXboxConsole.SmallImage")));
            this.btnXboxConsole.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnXboxConsole.Tag = null;
            this.btnXboxConsole.Text = "Xbox";
            this.btnXboxConsole.ToolTip = null;
            this.btnXboxConsole.ToolTipTitle = null;
            this.btnXboxConsole.Value = null;
            this.btnXboxConsole.Click += new System.EventHandler(this.btnXboxConsole_Click);
            // 
            // btnWiiConsole
            // 
            this.btnWiiConsole.AltKey = null;
            this.btnWiiConsole.CheckedGroup = null;
            this.btnWiiConsole.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.btnWiiConsole.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.btnWiiConsole.Image = ((System.Drawing.Image)(resources.GetObject("btnWiiConsole.Image")));
            this.btnWiiConsole.ShowFlashImage = false;
            this.btnWiiConsole.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnWiiConsole.SmallImage")));
            this.btnWiiConsole.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.btnWiiConsole.Tag = null;
            this.btnWiiConsole.Text = "Wii";
            this.btnWiiConsole.ToolTip = null;
            this.btnWiiConsole.ToolTipTitle = null;
            this.btnWiiConsole.Value = null;
            this.btnWiiConsole.Click += new System.EventHandler(this.btnWiiConsole_Click);
            // 
            // frmUserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 675);
            this.Controls.Add(this.RibbonMain);
            this.IsMdiContainer = true;
            this.Name = "frmUserMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon RibbonMain;
        private System.Windows.Forms.RibbonTab tabGenres;
        private System.Windows.Forms.RibbonTab tabGames;
        private System.Windows.Forms.RibbonTab tabConsoles;
        private System.Windows.Forms.RibbonPanel pnlAllConsoles;
        private System.Windows.Forms.RibbonPanel pnlGames;
        private System.Windows.Forms.RibbonButton btnAllGames;
        private System.Windows.Forms.RibbonButton btnPS3Games;
        private System.Windows.Forms.RibbonButton btnXboxGames;
        private System.Windows.Forms.RibbonButton btnWiiGames;
        private System.Windows.Forms.RibbonButton btnAllConsoles;
        private System.Windows.Forms.RibbonButton btnPS3Consoles;
        private System.Windows.Forms.RibbonButton btnXboxConsole;
        private System.Windows.Forms.RibbonButton btnWiiConsole;
        private System.Windows.Forms.RibbonPanel pnlFps;
        private System.Windows.Forms.RibbonButton btnFps;
        private System.Windows.Forms.RibbonPanel pnlRpg;
        private System.Windows.Forms.RibbonButton btnRpg;
        private System.Windows.Forms.RibbonPanel pnlRts;
        private System.Windows.Forms.RibbonButton btnRts;
        private System.Windows.Forms.RibbonPanel pnlAction;
        private System.Windows.Forms.RibbonButton btnAction;
        private System.Windows.Forms.RibbonPanel pnlRacing;
        private System.Windows.Forms.RibbonButton btnRace;
    }
}