using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            
            if (lstOrigem.SelectedItems.Count > 0)
            {
                lstDestino.Items.Add(lstOrigem.SelectedItem);
                lstOrigem.Items.RemoveAt(lstOrigem.SelectedIndex);
            }
            
        }

        private void LstOrigem_Click(object sender, EventArgs e)
        {
            txtAuxiliar.Text = lstOrigem.SelectedItem.ToString();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (lstDestino.SelectedItems.Count > 0)
            {
                lstOrigem.Items.Add(lstDestino.SelectedItem);
                lstDestino.Items.RemoveAt(lstDestino.SelectedIndex);
            }
            
        }
    }
}
