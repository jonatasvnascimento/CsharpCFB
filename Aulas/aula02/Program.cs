using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste");
            if (args.GetLength(0) > 0)
            {
                Console.WriteLine(args.GetValue(0));
            }

            //Primeiro programa no padrão c# .net - Curso Programação Completo C# - Aula 02
        }
    }
}
