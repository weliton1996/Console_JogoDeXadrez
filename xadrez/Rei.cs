

using tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            tab.peca(1, 5);
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
