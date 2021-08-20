using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array dimensional
            // int[] teste = new int[2];
            // teste[0] = 1;
            // teste[1] = 2;
            // int[] num = new int[3] { 1, 2, 3 };
            // int[] num1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            #endregion

            int linha = 0;
            int coluna = 0;

            Console.WriteLine("Informe o tamanho da linha");
            linha = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Informe o tamanho da Coluna");
            coluna = int.Parse(Console.ReadLine()); 

            int[,] matrix = new int[linha, coluna];
            // int[,] v2 = new int[2, 2] { { 1, 1 }, { 2, 2 } };

            Random num = new Random();
           
            for (int l = 0; l < matrix.GetLength(0); l++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[l, c] = num.Next(10);
                    Console.Write($"| {matrix[l, c]} |");
                }
                Console.Write("\n");
            }
            

        }
    }
}
