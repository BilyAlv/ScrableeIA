using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pSC10
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDEPTO frm = new frmDEPTO();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // cierra toda la aplicacion
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura frm = new frmFactura();
            frm.Show();
        }
    }
}
