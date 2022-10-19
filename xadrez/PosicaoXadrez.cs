﻿using tabuleiro;

namespace xadrez
{
    internal class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        public Posicao toPosicao()
        {
            //Usando a tabela ASCII como logica para subtrair os valores da coluna.
            return new Posicao(8-linha, coluna -'a');
        }
        public override string ToString()
        {
            return ""+ coluna+linha;
        }
    }
}
