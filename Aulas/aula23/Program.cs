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
                {11,22,33,44,55},
                {66,77,88,99,00}
        };

            Random rand = new Random();

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = rand.Next(50);
            }
            foreach (int i in vetor1)
            {
                Console.WriteLine("|{0}|", i);
            }

            //public stativ int BinarySearch(array, valor); //Retorna posição do valor procurado dentro de uma array
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("BinarySearch");
            int procurado = 33;
            int pos = Array.BinarySearch(vetor1, procurado);
            Console.WriteLine("O valor {0} está na posição {1}", procurado, pos);
            Console.WriteLine("-------------------------------------------------------------------");

            //public static void Copy(Ar_origem, Ar_destino, qtd_elementos);
            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);
            foreach (int i in vetor2)
            {
                Console.Write("|{0}|", i);
            }
            Console.WriteLine("\n-------------------------------------------------------------------");

            //public void CopyTo(array_destno, posição_inicial);
            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0);
            foreach (int i in vetor3)
            {
                Console.Write("|{0}|", i);
            }
            Console.WriteLine("\n-------------------------------------------------------------------");

            //public long GetLongLength(int dimensão); // quantidade de elementos de um vetor
            Console.WriteLine("GetLongLength");
            long qtd_elementos = vetor1.GetLongLength(0);
            Console.Write("Quantidade de elementos: {0}", qtd_elementos);
            Console.WriteLine("\n-------------------------------------------------------------------");

            //public int GetLowerBound(int dimensão); // retorna o menor indice de um vetor
            Console.WriteLine("GetLowerBound");
            int menor_indice_vetorGLB = vetor1.GetLowerBound(0);
            Console.Write("Menor indice: {0}", menor_indice_vetorGLB);
            int menor_indice_matrizGLP = matriz.GetLowerBound(1);
            Console.Write("\nMenor index da matriz: {0}", menor_indice_matrizGLP);
            Console.WriteLine("\n-------------------------------------------------------------------");

            //public int GetUpperBound(int dimensão); // retorna o maior indice de um vetor
            Console.WriteLine("GetUpperBound");
            int maior_indice_vetorGUP = vetor1.GetUpperBound(0);
            Console.Write("Maior indice: {0}", maior_indice_vetorGUP);
            int maior_indice_matrizGUP = matriz.GetUpperBound(1);
            Console.Write("\nMaior index da matriz: {0}", maior_indice_matrizGUP);
            Console.WriteLine("\n-------------------------------------------------------------------");

            //public object GetValue(int indice); // retorna o valor na posição indicada
            Console.WriteLine("GetValue");
            int valor0 = Convert.ToInt32(vetor1.GetValue(0));
            int valor1 = Convert.ToInt32(matriz.GetValue(1, 4));
            Console.WriteLine("\n-------------------------------------------------------------------");

            //public static int IndexOf(array, valor) // retorna a ultima posição do valor procurado dentro de uma array
            Console.WriteLine("IndexOf");
            int index_valor = Array.IndexOf(vetor1, 3);
            Console.Write("O do valor 3 esta {0}", index_valor);
            Console.WriteLine("\n-------------------------------------------------------------------");

            //public static void LastIndexOf(array, valor) // retorna a ultima posição do valor procurado dentro de uma array
            Console.WriteLine("LastIndexOf");
            int index_valor_last = Array.LastIndexOf(vetor1, 3);
            Console.Write("O do valor 3 esta {0}", index_valor_last);
            Console.WriteLine("\n-------------------------------------------------------------------");

            //public static void Reverse(array); // Inverte a ordem dos elementos de um array
            Console.WriteLine("Reverse");
            Array.Reverse(vetor1);
            foreach (int i in vetor1)
            {
                Console.Write("|{0}|", i);
            }
            Console.WriteLine("\n-------------------------------------------------------------------");

            //public static void Sort(array); // Ordena os elementos de um array
            Console.WriteLine("Sort");
            vetor1.Sort();//Posibilidade 1 de usar metodo Sort
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            foreach (int i in vetor1)
            {
                Console.Write("|{0}|", i);
            }
            foreach (int i in vetor2)
            {
                Console.Write("|{0}|", i);
            }
            foreach (int i in vetor3)
            {
                Console.Write("|{0}|", i);
            }
            Console.WriteLine("\n-------------------------------------------------------------------");




        }
    }
}

