using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormasGeometricas.Classes
{
    public class Jogador
    {
        private string nome;
        private PictureBox avatar;
        private List<Jogo> fasesJogo = new List<Jogo>();
        private int image;

        public string Nome { get => nome; set => nome = value; }
        public PictureBox Avatar { get => avatar; set => avatar = value; }
        public int Image { get => image; set => image = value; }
        internal List<Jogo> FasesJogo { get => fasesJogo; set => fasesJogo = value; }
    }
}
