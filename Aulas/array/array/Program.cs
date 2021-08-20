using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array dimensional
            int[] teste = new int[2];
            teste[0] = 1;
            teste[1] = 2;
            int[] num = new int[3] { 1, 2, 3 };
            int[] num1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            #endregion

            int[,] v = new int[3, 3];
            int[,] v2 = new int[2, 2] { { 1, 1 }, { 2, 2 } };

            v[0, 0] = 1;
            v[0, 1] = 2;
            v[0, 2] = 3;
            v[1, 0] = 4;
            v[1, 1] = 5;
            v[1, 2] = 6;
            v[2, 0] = 7;
            v[2, 1] = 8;
            v[2, 2] = 9;

            for (int l = 0; l < v.GetLength(0); l++)
            {
                for (int c = 0; c < v.GetLength(1); c++)
                {
                    Console.Write($"| {v[l, c]} |");
                }
                Console.Write("\n");
            }
            

        }
    }
}
