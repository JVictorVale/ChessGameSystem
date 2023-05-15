using System;
using static Tabuleiro.Tabuleiro;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);
            
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}