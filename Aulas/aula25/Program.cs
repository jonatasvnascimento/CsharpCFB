using System;

namespace aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num1 = 10;
            dobrar(num);
            triplicar(ref num1);
            Console.WriteLine(num);//valor
            Console.WriteLine(num1);//referencia
        }
        static void dobrar(int valor)//passagem de parametros por valor
        {
            valor *= 2;
        }
        static void triplicar(ref int valor)// passagem de parametros por referencia
        {
            valor *= 3;
        }
    }
}
