using System.Reflection.Metadata.Ecma335;

namespace jogoAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int totalDeTentativas = 0;
                int transmissorDeQtdTentativas = 0;
                bool validadorWhile = true;
                string ganhoOuPerdeu = "";

                Console.WriteLine("=================================");
                Console.WriteLine("Jogo de adivinhação");
                Console.WriteLine("=================================");
                Console.WriteLine("Escolha a dificuldade:");
                Console.WriteLine("1 - Facil (10 Tentativas)");
                Console.WriteLine("2 - Médio (5 Tentativas)");
                Console.WriteLine("3 - Dificil (3 Tentativas)");
                Console.WriteLine("---------------------------------");


                Random geradorDeNumeros = new Random();
                int numeroSecreto = geradorDeNumeros.Next(1, 21);

                int EscolhaDeDificuldade = 0;

                Console.Write("Escolha a dificuldade usando 1, 2 ou 3: ");
                EscolhaDeDificuldade = Convert.ToInt32(Console.ReadLine());

                while (validadorWhile == true)
                {
                    if (EscolhaDeDificuldade == 1)
                    {
                        totalDeTentativas = 10;
                        transmissorDeQtdTentativas = 10;
                        validadorWhile = false;
                    }

                    else if (EscolhaDeDificuldade == 2)
                    {
                        totalDeTentativas = 5;
                        transmissorDeQtdTentativas = 5;
                        validadorWhile = false;
                    }

                    else if (EscolhaDeDificuldade == 3)
                    {
                        totalDeTentativas = 3;
                        transmissorDeQtdTentativas = 3;
                        validadorWhile = false;
                    }

                    else
                    {
                        Console.Write("Escolha a dificuldade usando 1, 2 ou 3: ");
                        EscolhaDeDificuldade = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Você tem {totalDeTentativas} tentativas");

                Console.WriteLine("---------------------------------");
                Console.Write("Tente adivinha o numero: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado == numeroSecreto)
                {
                    ganhoOuPerdeu = "acertou de primeira";
                    Console.WriteLine("=================================");
                    Console.WriteLine("Parabens! Você acertou o numero secreto");
                    Console.WriteLine("=================================");
                }

                else if (numeroDigitado != numeroSecreto)
                {
                    while (numeroDigitado != numeroSecreto && validadorWhile == false)
                    {
                        if (numeroDigitado < numeroSecreto)
                        {
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine($"O numero secreto é maior {numeroDigitado}");
                        }

                        else
                        {
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine($"O numero secreto é menor que {numeroDigitado}");
                        }

                        totalDeTentativas--;
                        Console.WriteLine($"Você errou. Restam apenas {totalDeTentativas} tentativas");
                        Console.Write($"Chute novamente? ");
                        numeroDigitado = Convert.ToInt32(Console.ReadLine());

                        if (numeroDigitado == numeroSecreto)
                        {
                            validadorWhile = true;
                            Console.WriteLine("=================================");
                            ganhoOuPerdeu = "ganhou";
                            Console.WriteLine("=================================");
                        }

                        else if (totalDeTentativas == 1)
                        {
                            validadorWhile = true;
                            Console.WriteLine("=================================");
                            ganhoOuPerdeu = "perdeu";
                            Console.WriteLine("=================================");
                        }
                    }
                }

                if (ganhoOuPerdeu == "ganhou")
                {
                    Console.WriteLine("parabens");
                }

                else if (ganhoOuPerdeu == "perdeu")
                {
                    Console.WriteLine("perdeu");
                }

                Console.WriteLine("Você deseja sair? ");
                string sair = Console.ReadLine();

                if (sair.ToUpper().Contains("S"))
                {
                    Console.WriteLine("Você saiu do código :(");
                    break;
                }

                else if (sair.ToUpper().Contains("N"))
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
