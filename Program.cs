using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            PartidaDeXadrez partida = new PartidaDeXadrez();
            try
            {
                while(!partida.Terminada)
                {

                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab);


                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.Turno);
                        Console.WriteLine("Aquardando jogada: " + partida.JogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossivel = partida.Tab.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossivel);


                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }
            }
            catch(TabuleiroException e)
            {

                Console.WriteLine(e.Message);
            }

        }
    }
}