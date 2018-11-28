using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleSystem
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuDentist_Click(object sender, EventArgs e)
        {
            frmCadDentist frm = new frmCadDentist();
            frm.ShowDialog();
        }

        private void menuAgDentists_Click(object sender, EventArgs e)
        {
            frmConDentist frm = new frmConDentist();
            frm.ShowDialog();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
