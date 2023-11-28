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
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();



                    partida.ExecutaMovimento(origem, destino);
                }

                
            }
            catch (TabuleiroException ex)
            { Console.WriteLine(ex.Message); }


            Console.ReadLine();
        }
    }
}