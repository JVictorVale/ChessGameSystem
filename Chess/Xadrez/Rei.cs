using Tabuleiro;

namespace Chess.Xadrez
{

    public class Rei : Peca
    {
        public Rei(Tabuleiro.Tabuleiro tab, Cor cor) : base(tab,cor)
        {
            
        }

        public override string ToString()
        {
            return "R";
        }
    }
}