using System;

namespace aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < 10; i++)
            {
                num[i] = i;
                Console.Write(num[i]);
            }
        }
    }
}
