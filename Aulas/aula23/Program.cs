using System;

namespace aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2, 5]{
                {1,2,3,4,5},
                {6,7,8,9,10}
            };

            Random rand = new Random();

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = rand.Next(50);
            }
            foreach (int i in vetor1)
            {
                Console.Write(i);
            }

            //public stativ int BinarySearch(array, valor); //Retorna posição do valor procurado dentro de uma array
            Console.WriteLine("BinarySearch(array, valor)");
            int procurado = 33;
            int pos = Array.BinarySearch(vetor1, procurado);
            Console.WriteLine($"O valor {procurado} está na posição {pos}");
        }
    }
}
}
