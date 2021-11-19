using System;

namespace aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            Random rand = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rand.Next(1, 10);
            }

            foreach (int n in num)
            {
                Console.Write("|{0}|", n);
            }

        }
    }
}
