using System;

namespace aula33
{
    internal class Program
    {
        class Player
        {
            private int energia;
            private string nome;

            public Player(string nomePlayer)
            {
                this.nome = nomePlayer;
            }
            public int getEnergia()
            {
                return energia;
            }
            public string getNome()
            {
                return nome;
            }

        }
        static void Main(string[] args)
        {
            Player p1 = new Player("Player");

            Console.WriteLine($"Energia: {p1.getEnergia()}");
            Console.WriteLine($"Nome...: {p1.getNome()}");


        }
    }
}
