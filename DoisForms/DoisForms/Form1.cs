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
    public partial class frmOrigem : Form
    {
        public frmOrigem()
        {
            InitializeComponent();
        }

        private void BtnAbrirDestino_Click(object sender, EventArgs e)
        {
            frmDestino frmD = new frmDestino(this);
            frmD.Show();
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            frmCopia frmC = new frmCopia(txtTexto.Text);
            frmC.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] elementos = { "Nome", "Email", "Telefone" };
            System.IO.File.WriteAllLines(@"C:\Users\Public\Log\logarray.txt", elementos);

            string frase = "Isto é um teste de log";
            System.IO.File.WriteAllText(@"C:\Users\Public\log\logfrase.txt", frase);

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Public\log\logtexto.txt"))
            {
                foreach (string item in elementos)
                {
                    if (!item.Contains("Email"))
                    {
                        file.WriteLine(item);
                    }
                }
            }

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Public\log\logarray.txt", true))
            {
                file.WriteLine("Cidade");
            }
        }
    }
}
