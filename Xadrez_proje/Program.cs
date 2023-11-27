using System;
using tabuleiro;

namespace Xadrez_proje
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3, 4);

            Console.WriteLine(P);

            Console.ReadLine();
        }
    }
}