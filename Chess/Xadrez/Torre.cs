using Tabuleiro;

namespace Chess.Xadrez
{

    public class Torre : Peca
    {
        public Torre(Tabuleiro.Tabuleiro tab, Cor cor) : base(tab,cor)
        {
            
        }

        public override string ToString()
        {
            return "T";
        }
    }
}