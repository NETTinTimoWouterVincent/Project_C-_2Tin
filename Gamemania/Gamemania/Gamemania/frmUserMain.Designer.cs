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
            this.RibbonMain = new System.Windows.Forms.Ribbon();
            this.tabAll = new System.Windows.Forms.RibbonTab();
            this.tabGames = new System.Windows.Forms.RibbonTab();
            this.tabConsoles = new System.Windows.Forms.RibbonTab();
            this.tabAccessories = new System.Windows.Forms.RibbonTab();
            this.btnAllGames = new System.Windows.Forms.RibbonPanel();
            this.btnAllConsoles = new System.Windows.Forms.RibbonPanel();
            this.btnAllAccessories = new System.Windows.Forms.RibbonPanel();
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
            this.RibbonMain.OrbDropDown.Size = new System.Drawing.Size(527, 447);
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
            this.RibbonMain.Size = new System.Drawing.Size(600, 115);
            this.RibbonMain.TabIndex = 0;
            this.RibbonMain.Tabs.Add(this.tabAll);
            this.RibbonMain.Tabs.Add(this.tabGames);
            this.RibbonMain.Tabs.Add(this.tabConsoles);
            this.RibbonMain.Tabs.Add(this.tabAccessories);
            this.RibbonMain.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.RibbonMain.TabSpacing = 6;
            this.RibbonMain.Text = "ribbon1";
            // 
            // tabAll
            // 
            this.tabAll.Tag = null;
            this.tabAll.Text = "All";
            this.tabAll.ToolTip = null;
            this.tabAll.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.tabAll.ToolTipImage = null;
            this.tabAll.ToolTipTitle = null;
            this.tabAll.Value = null;
            // 
            // tabGames
            // 
            this.tabGames.Panels.Add(this.btnAllGames);
            this.tabGames.Tag = null;
            this.tabGames.Text = "Games";
            this.tabGames.ToolTip = null;
            this.tabGames.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.tabGames.ToolTipImage = null;
            this.tabGames.ToolTipTitle = null;
            this.tabGames.Value = null;
            // 
            // tabConsoles
            // 
            this.tabConsoles.Panels.Add(this.btnAllConsoles);
            this.tabConsoles.Tag = null;
            this.tabConsoles.Text = "Consoles";
            this.tabConsoles.ToolTip = null;
            this.tabConsoles.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.tabConsoles.ToolTipImage = null;
            this.tabConsoles.ToolTipTitle = null;
            this.tabConsoles.Value = null;
            // 
            // tabAccessories
            // 
            this.tabAccessories.Panels.Add(this.btnAllAccessories);
            this.tabAccessories.Tag = null;
            this.tabAccessories.Text = "Accessories";
            this.tabAccessories.ToolTip = null;
            this.tabAccessories.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.tabAccessories.ToolTipImage = null;
            this.tabAccessories.ToolTipTitle = null;
            this.tabAccessories.Value = null;
            // 
            // btnAllGames
            // 
            this.btnAllGames.Tag = null;
            this.btnAllGames.Text = "click test";
            this.btnAllGames.Click += new System.EventHandler(this.btnAllGames_Click);
            // 
            // btnAllConsoles
            // 
            this.btnAllConsoles.Tag = null;
            this.btnAllConsoles.Text = "clicktest";
            this.btnAllConsoles.Click += new System.EventHandler(this.btnAllConsoles_Click);
            // 
            // btnAllAccessories
            // 
            this.btnAllAccessories.Tag = null;
            this.btnAllAccessories.Text = "All Accessories";
            this.btnAllAccessories.Click += new System.EventHandler(this.btnAllAccessories_Click);
            // 
            // frmUserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 451);
            this.Controls.Add(this.RibbonMain);
            this.IsMdiContainer = true;
            this.Name = "frmUserMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon RibbonMain;
        private System.Windows.Forms.RibbonTab tabAll;
        private System.Windows.Forms.RibbonTab tabGames;
        private System.Windows.Forms.RibbonTab tabConsoles;
        private System.Windows.Forms.RibbonTab tabAccessories;
        private System.Windows.Forms.RibbonPanel btnAllGames;
        private System.Windows.Forms.RibbonPanel btnAllConsoles;
        private System.Windows.Forms.RibbonPanel btnAllAccessories;
    }
}