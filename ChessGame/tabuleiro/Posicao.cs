
namespace tabuleiro
{
    public class Posicao
    {
        /* Técnica  de orientação a objeto aplicadas na camada de posição 
         * Encapsulamentos
         * Construtores
         * Palavra this (autoreferência)
         * Sobreposição(ToString)       
         */
        public int linha { get; set; }
        public int coluna { get; set;  }

        public Posicao (int linha, int coluna )
        {
            this.linha = linha;
            this.coluna= coluna;

        } 

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }
        
        public override string ToString()
        {
            return linha
                + ", "
                + coluna;

        }

    }
}
