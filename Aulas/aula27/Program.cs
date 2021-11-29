using System;

namespace aula27
{
    class Program
    {
        static void Main(string[] args)
        {
            soma(1, 2);
        }
        static void soma(params int[] values)
        {
            int result = 0;
            if (values.Length < 1)
            {
                Console.WriteLine("Nenhun valor informado");
            }
            else if (values.Length < 2)
            {
                Console.WriteLine("Valores insuficientes para soma");
            }
            else
            {
                foreach (int v in values)
                {
                    result += v;
                }
                Console.WriteLine("A soma dos valores foram {0}", result);
            }
        }

    }
}
