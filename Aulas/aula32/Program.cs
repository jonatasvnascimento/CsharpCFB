using System;

namespace aula32
{
    internal class Program
    {
        class Calculos
        {
            public int v1;
            public int v2;

            public Calculos(int v1, int v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }
            public int soma()
            {
                return v1 + v2;
            }
        }
        static void Main(string[] args)
        {
            Calculos c = new Calculos(2,2);
            Console.WriteLine($"A soma e:{c.soma()}");
        }
    }
}
