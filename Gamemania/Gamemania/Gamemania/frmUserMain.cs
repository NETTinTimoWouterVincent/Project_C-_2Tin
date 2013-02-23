using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamemania
{
    public partial class frmUserMain : Form
    {
        MdiClient mdi = null;
        public frmUserMain()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    mdi = (MdiClient)c;
                    break;
                }
            }
            LoadThemeIni();
            /*btnAllGames.Click += new EventHandler(btnAllGames_Click);
            btnAllConsoles.Click += new EventHandler(btnAllConsoles_Click);
            btnAllAccessories.Click += new EventHandler(btnAllAccessories_Click);*/
        }

        //Zilver/zwart thema voor ribbon inladen
        private void LoadThemeIni()
        {
            string content = System.IO.File.ReadAllText(".\\ribbontheme.ini");
            ((RibbonProfessionalRenderer)RibbonMain.Renderer).ColorTable.ReadThemeIniFile(content);
            RibbonMain.Refresh();
        }

        //methode om mdi children te openen via ribbon (forms in het hoofdformulier openen)
        private void LoadForm(object form)
        {
            foreach (Form f in mdi.MdiChildren)
            {
                f.Close();
            }
            if (form == null)
                return;
            ((Form)form).MdiParent = this;
            ((Form)form).Show();
        }     
         
        private void btnAllGames_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserGames());
        }

        private void btnPS3Games_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserGames());
        }

        private void btnXboxGames_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserGames());
        }

        private void btnWiiGames_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserGames());
        }

        private void btnAllConsoles_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserConsoles());
        }

        private void btnPS3Consoles_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserConsoles());
        }

        private void btnXboxConsole_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserConsoles());
        }

        private void btnWiiConsole_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserConsoles());
        }

        private void btnFps_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserGenres());
        }

        private void btnRpg_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserGenres());
        }

        private void btnRts_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserGenres());
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserGenres());
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserGenres());
        }

    }
}
