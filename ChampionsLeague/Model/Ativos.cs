using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague.Model
{
    internal class Ativos
    {

        private static int codigo;
        private static string atleta;
        private static string elenco;
        private static string posicao;
        private static int gols;
        private static int assistencia;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Atleta { get => atleta; set => atleta = value; }
        public static string Elenco { get => elenco; set => elenco = value; }
        public static string Posicao { get => posicao; set => posicao = value; }
        public static int Gols { get => gols; set => gols = value; }
        public static int Assistencia { get => assistencia; set => assistencia = value; }
    }
}