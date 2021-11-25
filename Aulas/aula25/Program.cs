using System;

namespace aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            dobrar(num);
            Console.WriteLine(num);
        }
        static void dobrar(int valor)
        {
            valor *= 2;
        }
    }
}
