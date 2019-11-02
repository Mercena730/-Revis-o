using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
                txtCPF.Text = "00000000000";
        }

        private void TxtCPF_MouseClick(object sender, MouseEventArgs e)
        {
            txtCPF.Clear();
        }

        private void TxtCPF_Leave(object sender, EventArgs e)
        {
            if ((txtCPF.Text == "00000000000") || (txtCPF.TextLength == 0))
            {
                FrmPrincipal_Load(sender, e);
            }
        }

        private void TxtCidade_TextChanged(object sender, EventArgs e)
        {
            if (txtCidade.TextLength  > 0)
            {
                cmbUF.Enabled = true;
            }
            else
            {
                cmbUF.Enabled = false;
            }
        }

        private void TxtCidade_Leave(object sender, EventArgs e)
        {
            TxtCidade_TextChanged(sender, e);
        }

        private void ChkImigrante_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImigrante.Checked)
            {
                txtEndereco.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                cmbUF.Enabled = false;
            }
            else
            {
                txtEndereco.Enabled = true;
                txtBairro.Enabled = true;
                txtCidade.Enabled = true;
                cmbUF.Enabled = true;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CPF: " + txtCPF.Text + 
                "\nNome: " + txtNome.Text +
                "\nEndereço: " + txtEndereco.Text +
                "\nBairro: " + txtBairro.Text +
                "\nCidade: " + txtCidade.Text, 
                "Confirmação");
        }
    }
}
