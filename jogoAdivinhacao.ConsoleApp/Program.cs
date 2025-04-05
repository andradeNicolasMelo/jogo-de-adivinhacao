using System.Reflection.Metadata.Ecma335;

namespace jogoAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("=================================");
                Console.WriteLine("Jogo de adivinhação");
                Console.WriteLine("=================================");

                Random geradorDeNumeros = new Random();
                int numeroSecreto = geradorDeNumeros.Next(1, 21);

                Console.Write("Digite um numero para chutar: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                while (numeroDigitado != numeroSecreto)
                {
                    if (numeroDigitado < numeroSecreto)
                    {
                        Console.WriteLine($"O numero secreto é maior que {numeroDigitado}");
                        Console.WriteLine("---------------------------------");
                    }

                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine($"O numero secreto é menor que {numeroDigitado}");
                        Console.WriteLine("---------------------------------");
                    }

                    Console.Write("Escreva o numero novamente: ");
                    numeroDigitado = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("=================================");
                Console.WriteLine("Parabens! Você acertou o numero secreto :)");
                Console.WriteLine($"O numero escrito por você foi {numeroDigitado}, e o numero secreto é {numeroSecreto}");
                Console.WriteLine("");

                Console.WriteLine("=================================");
                Console.Write("Quer jogar denovo? ");
                string sair = Console.ReadLine();
                Console.WriteLine("=================================");

                if (sair.Contains("s"))
                {
                    Console.Clear();
                    continue;
                }

                else
                {
                    break;
                }
            }
        }
    }
}
