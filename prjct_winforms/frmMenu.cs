using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjct_winforms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsiCalculadora_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void msiAbrirCalculadora_Click(object sender, EventArgs e)
        {
            //instanciando frmCalculadora
            frmCalculadora objcalc = new frmCalculadora();
            //definir parente
            objcalc.MdiParent = this;
            //mostrar o form
            objcalc.Show();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.No)
            {

            }
        }
    }
}
