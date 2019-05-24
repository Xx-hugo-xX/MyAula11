using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    public class Program
    {
        // Propriedades e Variáveis
        private List<Player> players;

        // Método Construtor
        private Program()
        {
            players = new List<Player>()
            {
                new Player("Miguel", 1700), new Player("Catarina", 1000)
            };
        }


        // Main
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        // Início do Método Start
        private void Start()
        {
            //Variáveis
            string option;

            // Menu - Ciclo
            do
            {
                // Mostrar opções
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Adicionar um jogador");
                Console.WriteLine("2 - Listar jogadores existentes");
                Console.WriteLine("3 - Listar jogadores com pontuação" +
                                  "superior a X");
                Console.WriteLine("4 - Sair\n");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1": InsertPlayer(); break;

                    case "2": ListPlayers(players); break;

                    case "3": ListPlayersWithScoreGreaterThan(); break;

                    case "4": break;

                    default: Console.WriteLine("\nOpção Inválida\n"); break;
                }
            } while (option != "4");
        }
        // Fim do Método Start



        // Início do Método InsertPlayer
        private void InsertPlayer()
        {
            // Variáveis
            Player p;
            string name;
            int score;

            // Pedir valores ao utilizador
            Console.WriteLine("\nNome: ");
            name = Console.ReadLine();

            Console.WriteLine("\nPontuação: ");
            score = Convert.ToInt32(Console.ReadLine());

            p = new Player(name, score);
            players.Add(p);
        }
        // Fim do Método InsertPlayer


        // Início do Método ListPlayers
        private static void ListPlayers(IEnumerable<Player> myPlayers)
        {
            Console.WriteLine("\n");
            foreach (Player p in myPlayers)
                Console.WriteLine(p);
            Console.WriteLine("\n");
        }
        // Fim do Método ListPlayers


        // Início do Método ListPlayersWithScoreGreaterThan
        private void ListPlayersWithScoreGreaterThan()
        {
            IEnumerable<Player> goodPlayers;
            int minimumScore;

            Console.WriteLine("\nQual a pontuação mínima?\n");
            minimumScore = Convert.ToInt32(Console.ReadLine());

            goodPlayers = GetPlayersWithScoreGreaterThan(minimumScore);

            ListPlayers(goodPlayers);


            foreach (Player p in players)
                if (p.Score > minimumScore)
                    Console.WriteLine(p);

        }
        // Fim do Método ListPlayersWithScoreGreaterThan




        // Início do Método GetPlayersWithScoreGreaterThan
        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minimumScore)
        {
            foreach (Player p in players)
                if (p.Score > minimumScore)
                    yield return p;
        }
        // Fim do Método GetPlayersWithScoreGreaterThan
    }
}
