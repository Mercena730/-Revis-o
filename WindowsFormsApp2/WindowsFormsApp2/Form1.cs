using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (txtFrase.TextLength > 0)
            {
                lblTexto.Text = lblTexto.Text + "\n" + txtFrase.Text;       }
            
        }
    }
}
