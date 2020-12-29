using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Threading;

namespace PedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pedra Papel Tesoura");
            bool NovoJogo = true;
            Random r = new Random();

            do
            {
            Start:
                Console.WriteLine("\nEscolha:\nPedra\nPapel\nTesoura");
                string s = Console.ReadLine();
                string jogador = s.ToLower();


                int num = r.Next(1, 4);
                string jogadaComputador = "";

                switch (num)
                {
                    case 1:
                        jogadaComputador = "pedra";
                        break;
                    case 2:
                        jogadaComputador = "papel";
                        break;
                    case 3:
                        jogadaComputador = "tesoura";
                        break;
                    default:
                        break;
                }

                if ((jogador == "pedra" && num == 1) || (jogador == "papel" && num == 2) || (jogador == "tesoura" && num == 3))
                {
                    Console.WriteLine($"\nEscolheste {jogador} e o computador escolheu {jogadaComputador}\n\nResultado\n\nEmpate\n");
                }

                else if ((jogador == "pedra" && num == 2) || (jogador == "papel" && num == 3) || (jogador == "tesoura" && num == 1))
                {
                    Console.WriteLine($"\nEscolheste {jogador} e o computador escolheu {jogadaComputador}\n\nResultado\n\nDerrota\n");
                }

                else if ((jogador == "pedra" && num == 3) || (jogador == "papel" && num == 1) || (jogador == "tesoura" && num == 2))
                {
                    Console.WriteLine($"\nEscolheste {jogador} e o computador escolheu {jogadaComputador}\n\nResultado\n\nVitória\n");
                }

                else
                {
                    Console.WriteLine("Palavra Inválida");
                    goto Start;
                }

                Console.WriteLine("Novo jogo?\n(s)Sim\n(n)Não");
                char repetir = char.Parse(Console.ReadLine());
                if (repetir == 'n' || repetir == 'N') NovoJogo = false;

            } while (NovoJogo == true);

        }
    }
}
