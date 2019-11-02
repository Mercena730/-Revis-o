using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace trabalhograde
{
    public partial class Form1 : Form
    {
        OleDbCommand comando = new OleDbCommand();
        OleDbConnection conexao = new OleDbConnection();
        OleDbDataReader dr;
        OleDbDataReader dr2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbEscolaDataSet1.tbGrade'. Você pode movê-la ou removê-la conforme necessário.
            this.tbGradeTableAdapter1.Fill(this.dbEscolaDataSet1.tbGrade);
            conexao.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\Public\DbEscola.mdb;";
            comando.Connection = conexao;
            carregarcursos();
            carregardiciplinas();

        }
        private void carregarcursos()
        {

            try
            {
                string strQuery = "select Curso from tbcurso";
                comando.CommandText = strQuery;
                conexao.Open();
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cboCursos.Items.Add(dr[0].ToString());
                    }
                }
                dr.Close();
                conexao.Close();
                txtcurso.Text = cboCursos.Text;
            }
            catch (Exception e)
            {
                conexao.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void carregardiciplinas()
        {

            lbsgrade.ClearSelected();

            string strQuery = "select Disciplina from tbDisciplina";
            comando.CommandText = strQuery;
            conexao.Open();
            dr2 = comando.ExecuteReader();
            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    lbsgrade.Items.Add(dr2[0].ToString());
                }
            }
            dr2.Close();
            conexao.Close();
        }


        private void CboCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcurso.Text = (Convert.ToString(cboCursos.SelectedItem));

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Txtcurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbsgrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmat.Text = (Convert.ToString(lbsgrade.SelectedItem));
        }

        private void BntIncerir_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(txtcod.Text + "\n" + txtcurso.Text + "\n" + txtmat.Text);

            // incet de grade

            string StrNoQuery = "INSERT INTO tbGrade (código,Curso,Disciplinas) " +
                "values('" + txtcod.Text + "','" + txtcurso.Text + "','" + txtmat.Text + "')";
            comando.CommandText = StrNoQuery;
            comando.CommandType = CommandType.Text;
            conexao.Open();
           try
           {
                int i = comando.ExecuteNonQuery();
               if (i > 0)
               MessageBox.Show("Materia Adicionada Com Sucesso!");
            
           }
           catch (Exception ex)
           {
               MessageBox.Show("Erro :" + ex.ToString());
           }
           finally
           {
             conexao.Close();
           }
        }
    }

    
}
