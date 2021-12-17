using System;

namespace aula31
{
    internal class Program
    {
        
        
        public static class Player
        {
            public static string nome;
            public static int energia;
            public static bool vivo;
            public static void iniciar(string n)
            {
                nome = n;
                energia = 100;
                vivo = true;
            }
            public static void info()
            {
                Console.WriteLine($"Nome...: {nome}");
                Console.WriteLine($"energia: {energia}");
                Console.WriteLine($"Vivo...: {vivo}");

            }
        }
        class Inimigo
        {
            public static bool alerta;
            public string nome;

            public Inimigo(string n)
            {
                alerta = false;
                nome = n;
            }
            public void info()
            {
                Console.WriteLine($"{alerta}");
                Console.WriteLine($"{nome}");
            }
        }
        static void Main(string[] args)
        {
            Player.iniciar("PLayer");
            Player.info();

            Inimigo i1 = new Inimigo("Inimigo1");
            Inimigo i2 = new Inimigo("Inimigo2");
            Inimigo i3 = new Inimigo("Inimigo3");

            Inimigo.alerta = true;

            i1.info();
            i2.info();
            i3.info();



        }
    }
}
