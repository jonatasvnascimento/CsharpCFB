using System;

namespace aula28
{
    internal class Program
    {
        public class jogador
        {
            int energia = 100;
            bool vivo = true;
            static void Main(string[] args)
            {
                jogador Player = new jogador();
                Player.vivo = false;
                Player.energia = 0;
                Console.WriteLine($"Jogador: {Player.vivo} Energia: {Player.energia}");
                jogador Player2 = new jogador();
                Player2.vivo = false;
                Player2.energia = 0;
                Console.WriteLine($"Jogador: {Player2.vivo} Energia: {Player2.energia}");
            }
        }
        
    }
}
