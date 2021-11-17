using System;

namespace aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Random num2 = new Random();

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = num2.Next(1, 10);
                Console.Write("|{0}", num[i]);

            }

        }
    }
}
