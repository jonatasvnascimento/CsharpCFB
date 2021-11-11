using System;

namespace aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, soma;
            string nome = "";
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine()); //Convert.ToInt32(v1);

            Console.Write("Digite o primeiro valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            soma = v1 + v2;

            Console.WriteLine("A soma de {0} + {1} = {2}", v1, v2, soma);

        }
    }
}
