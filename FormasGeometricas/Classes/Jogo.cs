using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Classes
{
    public class Jogo
    {
        private int acertos;
        private int erros;
        private string tempo;

        public int Acertos { get => acertos; set => acertos = value; }
        public int Erros { get => erros; set => erros = value; }
        public string Tempo { get => tempo; set => tempo = value; }
    }
}
