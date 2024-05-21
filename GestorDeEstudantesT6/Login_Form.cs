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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

            MySqlDataAdapter meuAdaptadorSql = new MySqlDataAdapter();
            DataTable minhaTabela = new DataTable();
            MySqlCommand meuComandoSql = 
                new MySqlCommand("SELECT * FROM `usuarios` WHERE `nome_de_usuario` = @usuario AND `senha` = @senha", 
                meuBancoDeDados.getConexao);

            meuComandoSql.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = 
                textBoxUsuario.Text;
            meuComandoSql.Parameters.Add("@senha", MySqlDbType.VarChar).Value = 
                textBoxSenha.Text;

            meuAdaptadorSql.SelectCommand = meuComandoSql;

            meuAdaptadorSql.Fill(minhaTabela);

            if (minhaTabela.Rows.Count > 0)
            {
                //MessageBox.Show("Existem dados!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", 
                    "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
