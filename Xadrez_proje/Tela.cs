using tabuleiro;
namespace Xadrez_proje
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)

        {
            /*os fors servem para criação das linhas e colunas do tabuleiro, a seguinte logica é aplicada:
             * se a posicao i,j estiverem nulas de peças, então sobrepoõe com um traço, se não, coloca uma peça e um espaço
            */
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Tela.imprimirPEca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(" a b c d e f g h");
        }
        public static void imprimirPEca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;

            }
        }
    }
}
