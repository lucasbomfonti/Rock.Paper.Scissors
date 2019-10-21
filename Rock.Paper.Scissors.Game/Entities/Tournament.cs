using System;
using System.Collections.Generic;
using System.Linq;

namespace Rock.Paper.Scissors.Game.Entities
{
    public class Tournament
    {
        public List<Player> Player { get; set; }

        public Tournament(List<Player> player)
        {
            Player = player;
        }

        public void StartTournament()
        {
            var NextGroup = new List<Player>();

            while (Player.Count % 2 == 0)
            {
                Player firstPlayer;
                Player secondPlayer;

                for (int i = 0; i < Player.Count; i++)
                {
                    firstPlayer = Player[i];
                    secondPlayer = Player[(i + 1)];

                    HandSign.ValidateRound(firstPlayer, secondPlayer);

                    var winner = HandSign.GetWinner(firstPlayer, secondPlayer);
                    NextGroup.Add(winner);
                    i++;
                }
                Player.Clear();
                Player.AddRange(NextGroup);
                NextGroup.Clear();
            }

            Console.WriteLine("**************************************************************************************************");
            Console.WriteLine($"Congratulations {Player.First().Name}, you were the winner of the paper rock scissors tournament");
        }
    }
}