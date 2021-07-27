using System;

namespace Goto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Duplicar linha  Ctrl + e,V
            //Formatar Documento  Ctrl + K,D

            int tempo = 0;
            char escolha = '0';
            string resp = "";

            inicio:

            Console.WriteLine("Viagens Rapidas LTDA");
            Console.WriteLine("Belo Horizonte >>>> a >>>> São Paulo");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Escolha de Tansport:" +
                "\n Avião:  [a]" +
                "\n Carro:  [c]" +
                "\n Onibus: [o]");

            try{
            escolha = char.Parse(Console.ReadLine());
            }
            catch
            {
                goto inicio;
            }


            switch (escolha)
            {
                case 'a':
                case 'A':
                    tempo = 50;
                    break;
                case 'c':
                case 'C':
                    tempo = 420;
                    break;
                case 'o':
                case 'O':
                    tempo = 660;
                    break;

                default:
                    tempo = -1;
                    break;
            }

            if(tempo < 0)
            {
                Console.WriteLine("Veiculo não disponivel");
                
            }else
            {
                Console.WriteLine($"O tempo para e essa viagem e de {(float)tempo / 60}h");
            }

            Console.WriteLine("Deseja continuas?");
            resp = Console.ReadLine().ToString().ToLower();

            if (resp == "s" || resp == "")
            {
                goto inicio;
            }
            else
            {
                Console.WriteLine("Obrigado pela preferencia.");
            }




        }
    }
}
