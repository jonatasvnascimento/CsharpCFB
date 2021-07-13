using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicial = 0;

            Console.Write("Iinsira o inicial da Tabuada: ");
            inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Final da tabuada: ");
            // final = Convert.ToInt32(Console.ReadLine()); usar parc ou convert para tranforma string em int


            Console.WriteLine($"Tabuada do {inicial}");
            Console.WriteLine($"{inicial} x 1 = {inicial * 1}");
            Console.WriteLine($"{inicial} x 2 = {inicial * 2}");
            Console.WriteLine($"{inicial} x 3 = {inicial * 3}");
            Console.WriteLine($"{inicial} x 4 = {inicial * 4}");
            Console.WriteLine($"{inicial} x 5 = {inicial * 5}");
            Console.WriteLine($"{inicial} x 6 = {inicial * 6}");
            Console.WriteLine($"{inicial} x 7 = {inicial * 7}");
            Console.WriteLine($"{inicial} x 8 = {inicial * 8}");
            Console.WriteLine($"{inicial} x 9 = {inicial * 9}");
            Console.WriteLine($"{inicial} x 10 = {inicial * 10}");

        }

    }                                                       

}                                                           

