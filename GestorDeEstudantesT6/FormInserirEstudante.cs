using Mysqlx.Expect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT6
{
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            //exibe uma janela para procurar a imagem 
            OpenFileDialog selecionarImagem = new OpenFileDialog();
            selecionarImagem.Filter = "Selecione a foto (*.jpg; png;*.gif)| *.jpg;|*.png;*gif";
           if (selecionarImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUsuario.Image = Image.FromFile(selecionarImagem.FileName);   
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool Verificar()
        {
            if((textBoxNome.Text.Trim() == "") ||
              (textBoxSobrenome.Text.Trim() == "") ||
              (textBoxTelefone.Text.Trim() == "") ||
              (textBoxEndereço.Text.Trim() == "") ||
              (pictureBoxUsuario.Image == null))
              {
                return false;   
              }
            else
            {
                return true;
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //Cria um estudante 
            Estudante estudnte = new Estudante();
            //Variáveis auxiliares.

            String nome = textBoxNome.Text; 
            String spbrenome = textBoxSobrenome.Text; 
            DateTime nascimento = dateTimePickerNascimento.Value
            String telefone = textBoxTelefone.Text;
            string endereço = textBoxEndereço.Text;
            string genero = "Femenino";
        }
    }
    }
    
