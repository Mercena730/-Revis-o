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
namespace _09._08._2019
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
            // TODO: esta linha de código carrega dados na tabela 'tbdbDataSet2.Grade'. Você pode movê-la ou removê-la conforme necessário.
            this.gradeTableAdapter.Fill(this.tbdbDataSet2.Grade);

            conexao.ConnectionString =@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\users\public\Tbdb.mdb";
            comando.Connection = conexao;
            carregarcurso();
            carregardiscilina();

        }
        private void carregarcurso()
        {
            try
            {
                string strQuery = "select NomeCurso from CURSOS";
                comando.CommandText = strQuery;
                conexao.Open();
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CURSO.Items.Add(dr[0].ToString());
                    }
                }
                dr.Close();
                conexao.Close();
            }
            catch (Exception E)
            {
                conexao.Close();
                MessageBox.Show(E.Message.ToString());
            }

        }
        private void carregardiscilina()
        {
            try
            {
                string strQuery = "select NomeDisciplina from DISCIPLINA";
                comando.CommandText = strQuery;
                conexao.Open();
                dr2 = comando.ExecuteReader();
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        DISCIPLINA.Items.Add(dr2[0].ToString());
                    }
                }
                dr2.Close();
                conexao.Close();

            }
            catch (Exception E)
            {
                conexao.Close();
                MessageBox.Show(E.Message.ToString());
            }
        }

        private void Bntincert_Click(object sender, EventArgs e)
        {
            string strQuery = "INSERT INTO Grade (CódigoCurso,CódigoDisciplina)" +
                "valures('"+ Convert.ToString(CURSO.SelectedItem) + "','"+ Convert.ToString(DISCIPLINA.SelectedItem) +"')";
            comando.CommandType = CommandType.Text;
            conexao.Open();
            try
            {
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
    }

    
}