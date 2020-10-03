

namespace tabuleiro
{
    abstract class Peca
    {
       public Posicao posicao { get; set; }
        public Cor cor  { get; protected set; }
        public int qteMovimento { get; protected set; }
        public Tabuleiro tab   { get; protected set; }

        public Peca ( Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimento = 0;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimento++;
        }

        public abstract bool[,] movimentosPossiveis();
        
    }
}
