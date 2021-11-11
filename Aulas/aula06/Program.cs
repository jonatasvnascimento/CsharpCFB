using System;

namespace aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorCompra = 1000.00;
            double venda = 0.0;
            double lucro = 0.2;
            string producto = "Pastel";

            Console.WriteLine("Produto {0,15}", producto);
            Console.WriteLine("Valor de compra {0,15:c}", valorCompra);
            Console.WriteLine("Valor de venda {0,15:p}", venda);
            Console.WriteLine("Lucro {0,15:c}", lucro);
        }
    }
}
