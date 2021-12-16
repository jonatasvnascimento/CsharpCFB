using System;

namespace aula30
{
    internal class Program
    {


        public class Player
        {
            public int energia;
            public string nome;
            public bool vivo;

            public Player()
            {
                nome = "PlayerDefalt";
                energia = 0;
                vivo = false;
            }
            public Player(string nome_player)
            {
                nome = nome_player;
                energia = 0;
                vivo = true;
            }
            public Player(string nome_player, int energia_player)
            {
                nome = nome_player;
                energia = energia_player;
                vivo = true;
            }
            public Player(string nome_player, int energia_player, bool vivo_player)
            {
                nome = nome_player;
                energia = energia_player;
                vivo = vivo_player;
            }
            public void info_player()
            {
                Console.WriteLine($"Nome do Jogador...:{nome}");
                Console.WriteLine($"Energia do Jogador:{energia}");
                Console.WriteLine($"Estado do Jogador.:{vivo}");


            }
        }
        static void Main(string[] args)
        {
            Player p1 = new Player()
            {
                energia = 100,
                vivo = true,
                nome = "Player"
            };
            Player p2 = new Player()
            {
            };


            p2.info_player();


        }
    }
}
