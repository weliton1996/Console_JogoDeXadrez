using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            
            Tela.ImprimirTabuleiro(tab);
            
            Console.WriteLine();

        }
    }
}