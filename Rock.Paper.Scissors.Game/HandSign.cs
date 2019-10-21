using Rock.Paper.Scissors.Game.Entities;
using System;
using System.Linq;

namespace Rock.Paper.Scissors.Game
{
    public class HandSign
    {
        public HandSignEnum Sign { get; }

        public HandSign(HandSignEnum sign)
        {
            Sign = sign;
        }

        public static HandSignEnum GetWinningMove(HandSignEnum move)
        {
            switch (move)
            {
                case HandSignEnum.Rock:
                    return HandSignEnum.Paper;

                case HandSignEnum.Paper:
                    return HandSignEnum.Scissors;

                default:
                    return HandSignEnum.Rock;
            }
        }

        public static Player GetWinner(Player player1, Player player2)
        {
            Console.WriteLine($"{player1.Name}: {GameEnumHelper.GetName(player1.HandSign.Sign)} vs {player2.Name}: {GameEnumHelper.GetName(player2.HandSign.Sign)} ");
            if (GetWinningMove(player1.HandSign.Sign).Equals(player2.HandSign.Sign))
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Player {player2.Name} the round, advances to the next round");

                return player2;
            }

            if (GetWinningMove(player2.HandSign.Sign).Equals(player1.HandSign.Sign))
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Player {player1.Name} the round, advances to the next round");
                return player1;
            }

            return null;
        }

        public static void ValidateRound(params Player[] round)
        {
            if (round.ToList().Count != 2)
                throw new Exception("insufficient players");
            var listError = round.Where(s => !s.HandSign.Sign.ToString().Contains(GameEnumHelper.GetName(HandSignEnum.Paper))
                                                      && !s.HandSign.Sign.ToString().Contains(GameEnumHelper.GetName(HandSignEnum.Rock))
                                                      && !s.HandSign.Sign.ToString().Contains(GameEnumHelper.GetName(HandSignEnum.Scissors)));
            if (listError.Any())
                throw new Exception("invalid values");
        }
    }
}