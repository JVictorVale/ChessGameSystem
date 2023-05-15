using System;
using static Tabuleiro.Tabuleiro;
using Chess.Xadrez;
using Tabuleiro;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);
            
            tab.ColocarPeca(new Torre(tab,Cor.Preta), new Posicao(0,0));
            tab.ColocarPeca(new Torre(tab,Cor.Preta), new Posicao(1,3));
            tab.ColocarPeca(new Rei(tab,Cor.Preta), new Posicao(2,4));
            
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}