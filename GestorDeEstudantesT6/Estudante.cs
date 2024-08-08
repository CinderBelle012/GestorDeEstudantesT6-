using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstudantesT6
{
    internal class Estudante
    {
        MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

        public bool inserirEstudante(string nome, string sobrenome,
            DateTime nascimento, string telefone, string genero,
            string endereco, MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes`(`nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto`) VALUES (@nome,@sobrenome,@nascimento,@genero,@telefone,@endereco,@foto)", meuBancoDeDados.getConexao);

            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nascimento", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@genero", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@endereco", MySqlDbType.Text).Value = endereco;
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto.ToArray();


            meuBancoDeDados.abrirConexao();

            if (comando.ExecuteNonQuery() == 1)
            {
                meuBancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                meuBancoDeDados.fecharConexao();
                return false;
            }
            
        }

        public bool atualizarEstudante(int id, string nome, string sobrenome,
            DateTime nascimento, string telefone, string genero, string endereco,
            MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("UPDATE `estudantes` SET `nome`=@nome,`sobrenome`=@sobrenome,`nascimento`=@nascimento,`genero`=@genero,`telefone`=@telefone,`endereco`=@endereco,`foto`=@foto WHERE `id`=@id", meuBancoDeDados.getConexao);

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nascimento", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@genero", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@endereco", MySqlDbType.Text).Value = endereco;
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto.ToArray();

            meuBancoDeDados.abrirConexao();

            if (comando.ExecuteNonQuery() == 1)
            {
                meuBancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                meuBancoDeDados.fecharConexao();
                return false;
            }
        }

        public bool apagarEstudante(int id)
        {
            MySqlCommand comando = new MySqlCommand(
                "DELETE FROM `estudantes` WHERE `id`=@id", 
                meuBancoDeDados.getConexao);

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            meuBancoDeDados.abrirConexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                meuBancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                meuBancoDeDados.fecharConexao();
                return false;
            }
        }

        public DataTable getEstudantes(MySqlCommand comando)
        {
            comando.Connection = meuBancoDeDados.getConexao;

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);

            return tabela;
        }
    }
}
