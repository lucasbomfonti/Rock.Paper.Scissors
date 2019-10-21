using System.Collections.Generic;

namespace Rock.Paper.Scissors.Game.Entities
{
    public enum HandSignEnum
    {
        Rock,
        Paper,
        Scissors
    }

    public static class GameEnumHelper
    {
        private static readonly Dictionary<HandSignEnum, string> Dictionary = new Dictionary<HandSignEnum, string>
        {
            { HandSignEnum.Rock, "R" },
            { HandSignEnum.Paper, "P" },
            { HandSignEnum.Scissors, "S" }
        };

        public static string GetName(HandSignEnum status)
        {
            return Dictionary[status];
        }
    }
}