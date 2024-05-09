using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstudantesT6
{
    internal class MeuBancoDeDados
    {
        private MySqlConnection conexão = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sga_estudante_bd_t6");
    }       
}
