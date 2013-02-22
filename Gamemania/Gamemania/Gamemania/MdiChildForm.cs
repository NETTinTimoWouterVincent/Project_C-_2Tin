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
    public partial class MdiChildForm : Form
    {
        public MdiChildForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.MdiChildForm_Load);
        }

        private void MdiChildForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }
    }
}
