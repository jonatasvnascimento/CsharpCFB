using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string teste = ">";

            Random randNum = new Random();

            int[,] num = new int[5, 5];

            for (int l = 0; l < num.GetLength(0); l++)
            {
                for (int c = 0; c < num.GetLength(0); c++)
                {
                    Console.Write($"| {num[l, c]} |");
                }
                Console.Write("\n");
            }


            Console.Write("------------------------------------");
            for (int i = 0; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("\n");
                    Console.Write($" {teste} {i}");
                }
                if (i % 2 == 1)
                {
                    Console.Write($" {teste} {i}");

                }
            }
        }
    }
}
