﻿using System;
using tabuleiro;
using xadrez;

namespace Xadrez_proje
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 5));


                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 5));

                Tela.imprimirTabuleiro(tab);


            }catch(TabuleiroException ex) 
            { Console.WriteLine(ex.Message); }


            Console.ReadLine();
        }
    }
}