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


                //========================
                //Escolha da dificuldade

                Console.WriteLine("nivel de dificuldade");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1 - Fácil (10 Tentativas)");
                Console.WriteLine("2 - Normal (5 tentativas)");
                Console.WriteLine("3 - Dificil (3 Tentativas)");
                Console.WriteLine("---------------------------------");

                Console.Write("Digite a sua escolha: ");
                string escolhaDeDificuldade = Console.ReadLine();


                //Tratativa do total de tentativas
                int totalDeTentativas = 0;

                if (escolhaDeDificuldade == "1")
                {
                    totalDeTentativas = 10;
                }

                else if (escolhaDeDificuldade == "2")
                {
                    totalDeTentativas = 5;
                }

                else
                {
                    totalDeTentativas = 3;
                }


                //Gerador de numeros
                Random geradorDeNumeros = new Random();
                int numeroSecreto = geradorDeNumeros.Next(1, 21);


                //Historico
                int[] numerosChutados = new int[11];
                int contadorNumerosChutados = 0;


                //Sistema de pontuação
                int pontuacao = 1000;


                //Loop das tentativas
                for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
                {
                    //========================

                    Console.Clear();

                    Console.WriteLine($"Sua pontuação é de {pontuacao}");

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
                    Console.WriteLine("---------------------------------");

                    Console.Write("Numeros já chutados: ");

                    for (int i = 0; i < numerosChutados.Length; i++)
                    {
                        if (numerosChutados[i] > 0)
                        {
                            Console.Write(numerosChutados[i] + " ");
                        }
                    }

                    Console.WriteLine("");

                    //========================


                    int numeroDigitado;
                    bool numeroRepetido;

                    do 
                    { 
                        numeroRepetido = true;

                        //Usuario vai chutar um numero
                        Console.Write("Digite um número (de 1 à 20) para chutar: ");
                        numeroDigitado = Convert.ToInt32(Console.ReadLine());


                        //Verificar se um numero não é repetido
                        for (int i = 0; i < numerosChutados.Length; i++)
                        {
                            if(numeroDigitado == numerosChutados[i])
                            {
                                Console.WriteLine($"Você já digitou o numero {numeroDigitado}. Para continuar, digite ENTER...");
                                Console.ReadLine();
                                numeroRepetido = false;
                                break;
                            }
                        }

                    } while (numeroRepetido == false);


                    

                    numerosChutados[contadorNumerosChutados] = numeroDigitado;
                    contadorNumerosChutados++;

                    Console.WriteLine($"Numero digitado: {numeroDigitado}");

                    //========================

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Parabéns! Você acertou de primeira");
                        Console.WriteLine("---------------------------------");
                        break;
                    }

                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("O numero digitado é --MAIOR-- que o numero secreto");
                        Console.WriteLine("---------------------------------");

                        pontuacao -= Math.Abs((numeroDigitado - numeroSecreto) / 2);
                    }

                    else
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("O numero digitado é --MENOR-- que o numero secreto");
                        Console.WriteLine("---------------------------------");

                        pontuacao -= Math.Abs((numeroDigitado - numeroSecreto) / 2);
                    }


                    Console.WriteLine($"Digite ENTER para continuar...");
                    Console.ReadLine();
                }

                Console.WriteLine("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                {
                    break;
                }
            }
        }
    }
}
