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
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
