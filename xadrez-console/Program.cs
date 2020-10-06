using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)  {

                    try {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.WriteLine("Turno:" + partida.turno);
                    Console.WriteLine("Aguardando jogada:" + partida.jogadorAtual);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                    partida.validarPosicaoDeOrigem(origem);

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.realizaJogada(origem, destino);
                    }

                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }

            catch (TabuleiroException e)
            {
            Console.WriteLine(e.Message);
            }

    Console.ReadLine();
        }
    }
}

/*
 try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));


                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
 */
