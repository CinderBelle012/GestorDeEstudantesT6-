using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT6
{
    public partial class FormListaDeEstudantes : Form
    {
        public FormListaDeEstudantes()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormListaDeEstudantes_Load(object sender, EventArgs e)
        {
            // Preenche a tabela com as informações do banco de dados:
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`"); // Comando para selecionar os dados da tabela estudantes.
            dataGridViewListaDeEstudantes.ReadOnly = true; // Define a tabela como sendo "somente leitura"
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn(); // Cria a coluna que irá receber as fotos.
            dataGridViewListaDeEstudantes.RowTemplate.Height = 80; // Definir a altura máxima das linhas da tabela em 80 pixels.
            dataGridViewListaDeEstudantes.DataSource = estudante.getEstudantes(comando); // Define a fonte de dados da tabela (de onde virão os dados).
            colunaDeFotos = (DataGridViewImageColumn) dataGridViewListaDeEstudantes.Columns[7]; // Determina QUEM será a coluna de fotos.
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch; // Estica as imagens na coluna de fotos.
            dataGridViewListaDeEstudantes.AllowUserToAddRows = false;
        }

        private void dataGridViewListaDeEstudantes_DoubleClick(object sender, EventArgs e)
        {
            // Abre as informações do aluno selecionado em uma nova janela.
            FormAtualizarApagarAlunos formAtualizarApagarAlunos = 
                new FormAtualizarApagarAlunos();
            formAtualizarApagarAlunos.textBoxId.Text = 
                dataGridViewListaDeEstudantes.CurrentRow.Cells[0].Value.ToString();
            formAtualizarApagarAlunos.textBoxNome.Text =
                dataGridViewListaDeEstudantes.CurrentRow.Cells[1].Value.ToString();
            formAtualizarApagarAlunos.textBoxSobrenome.Text =
                dataGridViewListaDeEstudantes.CurrentRow.Cells[2].Value.ToString();

            formAtualizarApagarAlunos.dateTimePickerNascimento.Value =
                (DateTime) dataGridViewListaDeEstudantes.CurrentRow.Cells[3].Value;

            if (dataGridViewListaDeEstudantes.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            {
                formAtualizarApagarAlunos.radioButtonFeminino.Checked = true;   
            }
            else
            {
                formAtualizarApagarAlunos.radioButtonMasculino.Checked = true;
            }

            formAtualizarApagarAlunos.textBoxTelefone.Text =
                dataGridViewListaDeEstudantes.CurrentRow.Cells[5].Value.ToString();
            formAtualizarApagarAlunos.textBoxEndereco.Text =
                dataGridViewListaDeEstudantes.CurrentRow.Cells[6].Value.ToString();

            // A foto do aluno:
            byte[] imagem;
            imagem = 
                (byte[])dataGridViewListaDeEstudantes.CurrentRow.Cells[7].Value;
            
            MemoryStream foto = new MemoryStream(imagem);

            formAtualizarApagarAlunos.pictureBoxFoto.Image =
                Image.FromStream(foto);

            formAtualizarApagarAlunos.Show();
        }








        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            // Atualiza a lista de alunos.
        }

        private void dataGridViewListaDeEstudantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
