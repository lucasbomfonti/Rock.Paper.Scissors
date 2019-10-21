namespace Rock.Paper.Scissors.Game.Entities
{
    public class Player
    {
        public Player(string name, HandSign sign)
        {
            Name = name;
            HandSign = sign;
        }

        public string Name { get; }

        public HandSign HandSign { get; set; }
    }
}