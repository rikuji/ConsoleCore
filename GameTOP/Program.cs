using System;
using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador3(),
                new Jogador1("Lucas")

            );
            jogo.IniciarJogo();
        }
    }
}
