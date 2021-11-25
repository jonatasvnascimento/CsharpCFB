using System;

namespace aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2;
            v1 = Convert.ToInt32(Console.ReadLine());
            v2 = Convert.ToInt32(Console.ReadLine());
            soma(v1, v2);

            Console.WriteLine("A soma e: {0}", soma2(v1, v2));
        }
        static void teste()
        {
            Console.WriteLine("teste");
        }
        static void soma(int n1, int n2)
        {
            int somaFinal = n1 + n2;
            Console.WriteLine("A soma de {0} + {1} = {2}", n1, n2, somaFinal);
        }
        static int soma2(int n1, int n2)
        {
            int somafinal = n1 + n2;
            return somafinal;
        }
    }
}
