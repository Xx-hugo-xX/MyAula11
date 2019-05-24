using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerManager1
{
    public class Player
    {
        //Variáveis de instância
        public string Name { get; }
        public int Score { get; set; }

        //Método Construtor
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return $"Nome = {Name}, Pontuação = {Score}";
        }
    }
}
