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
            btnAllGames.Click += new EventHandler(btnAllGames_Click);
            btnAllConsoles.Click += new EventHandler(btnAllConsoles_Click);
            btnAllAccessories.Click += new EventHandler(btnAllAccessories_Click);
        }
        private void LoadThemeIni()
        {
            string content = System.IO.File.ReadAllText("C:\\Users\\Vincent\\Documents\\GitHub\\Project_C-_2Tin\\Gamemania\\ribbontheme.ini");
            ((RibbonProfessionalRenderer)RibbonMain.Renderer).ColorTable.ReadThemeIniFile(content);
            RibbonMain.Refresh();
        }

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

        private void btnAllAccessories_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserAccessories());
        }

        private void btnAllGames_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserGames());
        }

        private void btnAllConsoles_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUserConsoles());
        }
    }
}
