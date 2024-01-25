using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List01
{
    internal static class OperacoesFila
    {
        public static void JogoBatataQuente(int numeroDeJogadores)
        {
            Queue<int> filaDeJogadores = new Queue<int>();
            for (int i = 1; i <= numeroDeJogadores; i++)
            {
                filaDeJogadores.Enqueue(i);
            }

            Random random = new Random();
            int passesAteExplodir = random.Next(1, 101);

            Console.WriteLine($"Número de jogadores: {numeroDeJogadores}");
            Console.WriteLine($"Passes até a explosão: {passesAteExplodir}");

            while (filaDeJogadores.Count > 1)
            {
                for (int i = 1; i < passesAteExplodir; i++)
                {
                    int jogadorAtual = filaDeJogadores.Dequeue();
                    filaDeJogadores.Enqueue(jogadorAtual);
                }

                int jogadorExplodido = filaDeJogadores.Dequeue();
                Console.WriteLine($"Jogador {jogadorExplodido} está fora!");

                passesAteExplodir = random.Next(1, 101);
                Console.WriteLine($"Passes até a explosão: {passesAteExplodir}");
            }

            int jogadorVencedor = filaDeJogadores.Dequeue();
            Console.WriteLine($"Jogador {jogadorVencedor} é o vencedor!");
        }

    }
}
