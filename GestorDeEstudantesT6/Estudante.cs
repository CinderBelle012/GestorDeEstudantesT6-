using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstudantesT6
{
    internal class Estudante
    {
        MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados(); 

        public bool inserirEstudante(string nome,string sobrenome,DateTime nascimento, string telefone, string genero, string endereco,MemoryStream foto)

        {
            MySqlCommand comando = new MySqlCommand("", meuBancoDeDados.getConexao);
        }
        

        
    }
}
