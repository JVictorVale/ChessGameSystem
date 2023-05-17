using System;
using Chess.Exceptions;
using Chess.Xadrez;
using Tabuleiro;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            
            Console.WriteLine(pos);
            
            Console.WriteLine(pos.ToPosicao());
            
            Console.ReadLine();
        }
    }
}