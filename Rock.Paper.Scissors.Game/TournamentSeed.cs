using System.Collections.Generic;
using Rock.Paper.Scissors.Game.Entities;

namespace Rock.Paper.Scissors.Game
{
    public static class TournamentSeed
    {
        public static List<Player> Players = new List<Player>();

        public static List<Player> GetTournament()
        {
            Players.Add(new Player("Armando", new HandSign(HandSignEnum.Paper)));
            Players.Add(new Player("Dave", new HandSign(HandSignEnum.Scissors)));
            Players.Add(new Player("Richard", new HandSign(HandSignEnum.Rock)));
            Players.Add(new Player("Michael", new HandSign(HandSignEnum.Scissors)));
            Players.Add(new Player("Allen", new HandSign(HandSignEnum.Scissors)));
            Players.Add(new Player("Omer", new HandSign(HandSignEnum.Paper)));
            Players.Add(new Player("David E.", new HandSign(HandSignEnum.Rock)));
            Players.Add(new Player("Richard X.", new HandSign(HandSignEnum.Paper)));
            return Players;
        }
    }
}