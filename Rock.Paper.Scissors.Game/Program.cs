using Rock.Paper.Scissors.Game.Entities;
using System;

namespace Rock.Paper.Scissors.Game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var tournament = new Tournament(TournamentSeed.GetTournament());
            tournament.StartTournament();
            Console.ReadLine();
        }
    }
}