using System;

namespace aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Random cont = new Random();

            int i = 0;
            while (i < num.Length)
            {
                num[i] = cont.Next(1, num.Length);
                Console.Write("{0}|", num[i]);
                i++;
            }
        }
    }
}
