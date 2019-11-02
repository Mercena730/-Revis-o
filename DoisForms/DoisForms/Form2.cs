using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoisForms
{
    public partial class frmDestino : Form
    {
        frmOrigem frmO;
        public frmDestino(frmOrigem frm1)
        {
            InitializeComponent();

            frmO = frm1;
            txtDestino.Text = frmO.txtOrigem.Text;
        }

        private void FrmDestino_Load(object sender, EventArgs e)
        {

        }

        private void BtnAlterarOrigem_Click(object sender, EventArgs e)
        {
            frmO.txtOrigem.Text = txtDestino.Text;
        }

        private void TxtDestino_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
