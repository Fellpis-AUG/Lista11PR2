using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            int[] vet;
            

            vet = new int[1000];
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                vet[i] = rand.Next(1, 1000);
            }
            Console.WriteLine("digite um número: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                if (n == vet[i])
                {
                    Console.WriteLine("o número digitado esta no vetor.");
                    break;
                }
            }

        }
        public static void Exercicio2()
        {
            int[] vet;
            int cont = 0, i;

            vet = new int[20000];
            Random rand = new Random();

            for ( i = 0; i < 20000; i++)
            {
                vet[i] = rand.Next(1, 20000);
            }
            Console.WriteLine("Digite um numero:");
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < 20000; i++)
            {
                if(n== vet[i])
                {
                    cont++;
                }
            }
            Console.WriteLine("a quantidade de vezes que aparece o numero " + n + "é " + cont);
        }
        public static void Exercicio3()
        {
            int[] vet;
            int[] vet2;
            int i;

            vet = new int[10];
            vet2 = new int[10];
            Random rand = new Random();

            for (i = 0; i < 10; i++)
            {
                vet[i] = rand.Next(1, 10);
            }
            for (i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    vet2[i] = vet[i] / 2;
                }
                else
                {
                    vet2[i] = vet[i] * 3;
                }
            }
            Console.WriteLine("vet1");
            for (i = 0; i < 10; i++)
            {
                
                Console.WriteLine("posição [{0}] = {1}", i, vet[i]);
            }
            Console.WriteLine("vet2");
            for ( i = 0; i < 10; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);
            }
 
        }
        public static void Exercicio4()
        {
            int[] vet;


            vet = new int[5000];
            Random rand = new Random();

            for (int i = 0; i < 5000; i++)
            {
                vet[i] = rand.Next(1, 5000);
            }
            for (int i = 0; i < 5000; i++)
            {
                if (vet[i] % 2 != 0 && vet[i] % 3 != 0 && vet[i] % 5 != 0)
                {
                    Console.WriteLine(vet[i] + " é um numero primo");
                }
            }
        }

        static void Main(string[] args)
        {
            int opcao;

            do
            {

                Console.WriteLine("==================menu=================");
                Console.WriteLine("para sair digite 0");
                Console.WriteLine("para executar o exercicio 1 - digite 1");
                Console.WriteLine("para executar o exercicio 2 - digite 2");
                Console.WriteLine("para executar o exercicio 3 - digite 3");
                Console.WriteLine("para executar o exercicio 4 - digite 4");
                Console.WriteLine("======================================");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    default:
                        Console.WriteLine("o numero não é um exercicio valido");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
