using System;

namespace aula26
{
    class Program
    {
        static void Main(string[] args)
        {
            int divid, divis, quoc, rest;
            divid = 10;
            divis = 5;
            quoc = divide(divid, divis, out rest);
            Console.WriteLine("{0}/{1}:quociente = {2} e o resto {3}", divid, divis, quoc, rest);
            //Passa a varieavel rest para dentro do devide para ela retornar o resto
        }
        static int divide(int dividendo, int divisor, out int resto)
        {
            int quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }
    }
}
