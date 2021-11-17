using System;

namespace aula21
{
    class Program
    {
        static void Main(string[] args)
        {
            // string senha = "123";
            // string senhaUser = "";
            // int tentativas = 0;

            // do
            // {
            //     Console.Write("Digite sua senha: ");
            //     senhaUser = Console.ReadLine();
            //     Console.Clear();
            //     if (senha != senhaUser)
            //     {
            //         Console.WriteLine("Senha incorreta");
            //     }
            // } while (senha != senhaUser);
            // Console.WriteLine("Acesso liberado");

            string senha = "123";
            string senhaUser = "";
            int tentativas = 0;
            bool verif = true;
            bool exedido = false;

            do
            {
                Console.Write("Digite sua senha: ");
                senhaUser = Console.ReadLine();
                Console.Clear();
                if (senha != senhaUser)
                {
                    Console.WriteLine("Senha incorreta");
                    if (tentativas == 2)
                    {
                        Console.WriteLine("Numero de tentativas exedidas");
                        verif = false;
                        exedido = true;
                    }
                    tentativas++;
                }

            } while (verif);

            if (exedido == false)
            {
                Console.WriteLine("Acesso liberado");

            }
            else if (exedido == true)
            {
                Console.WriteLine("Acesso bloqueado");
            }

        }
    }
}
