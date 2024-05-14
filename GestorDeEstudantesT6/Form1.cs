using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantesT6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();


            MySqlDataAdapter MeuadaptadorSql = new MySqlDataAdapter();
            DataTable minhaTabela = new DataTable();
            DataTable maxhaTabela = new DataTable();
            MySqlCommand meuComandoSql = new MySqlCommand("SELECT * FROM `usuarios` WHERE `nome_de_usuario` = @usuario AND `senha` = @senha", meuBancoDeDados.getConexao);
            meuComandoSql.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = textBoxUsuario.Text;
            meuComandoSql.Parameters.Add("@senha", MySqlDbType.VarChar).Value = textBoxSenha.Text; 

            MeuadaptadorSql.SelectCommand = meuComandoSql;
            MeuadaptadorSql.Fill(minhaTabela);

            if (minhaTabela.Rows.Count > 0)
            {
                MessageBox.Show("Existem dados");
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos","Erro de Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
               

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
