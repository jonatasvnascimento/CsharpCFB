using System;

namespace aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            float n2 = n1;
            Console.WriteLine("n2 = {0}", n2);

            float v1 = 15.5f;
            int v2 = (int)v1;//Type Cast
            Console.WriteLine("v2 = {0}", v2);
        }
    }
}
