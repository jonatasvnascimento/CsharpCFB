using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
           int [,] matrix = new int[2, 2]{{2,2},{3,3}};

          Random num = new Random();

          int l = 0;
          int c = 0;

          while(l < matrix.GetLength(0)){
            while(c < matrix.GetLength(1)){
              Console.WriteLine(matrix[l, c]);
              c++;
            };
            l++;
            Console.Write("\n");
          };

        }
    }
}
