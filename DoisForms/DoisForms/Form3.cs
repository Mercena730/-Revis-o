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
    public partial class frmCopia : Form
    {
        public frmCopia(string texto)
        {
            InitializeComponent();
            txtCopia.Text = texto;
        }

        private void FrmCopia_Load(object sender, EventArgs e)
        {

        }
    }
}
