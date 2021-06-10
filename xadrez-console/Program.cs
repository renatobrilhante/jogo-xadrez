﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            try {               
                PartidaDeXadrez partida = new PartidaDeXadrez();
               
                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosisaoXadrez().toPosicao();
                   
                    bool[,] posicoePossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoePossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosisaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }  

                
                
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            }


        }
    }
}
