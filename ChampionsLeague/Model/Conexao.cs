using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emerson.csrodrigues1\source\repos\ChampionsLeague\ChampionsLeague\Dados\bdJogadores.mdf;Integrated Security=True";
        }
    }
}
