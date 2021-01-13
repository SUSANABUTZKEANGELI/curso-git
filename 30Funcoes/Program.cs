using System;

namespace _30Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());   // marcar um breakpoint - F9 - F5 para iniciar

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior = " + n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("Maior = " + n2);
            }
            else
            {
                Console.WriteLine("Maior = " + n3);
            }

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
        }
        static int Maior(int p1, int p2, int p3)
        {
            int m;
            if (p1 > p2 && p1 > p3)
            {
                m = p1;
            }
            else if (p2 > p3)
            {
                m = p2;
            }
            else
            {
                m = p3;
            }
            return m;
        }
    }
}
