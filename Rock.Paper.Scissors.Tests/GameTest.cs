using Rock.Paper.Scissors.Game;
using Rock.Paper.Scissors.Game.Entities;
using Xunit;

namespace Rock.Paper.Scissors.Test
{
    public class GameTest
    {
        public GameTest()
        {
        }

        [Fact]
        public void Should_return_paper_when_selected_stone()
        {
            var result = HandSign.GetWinningMove(HandSignEnum.Rock);
            Assert.Equal(HandSignEnum.Paper, result);
        }

        [Fact]
        public void Should_return_stone_when_selected_scissors()
        {
            var result = HandSign.GetWinningMove(HandSignEnum.Scissors);
            Assert.Equal(HandSignEnum.Rock, result);
        }

        [Fact]
        public void Should_return_scissors_when_selected_paper()
        {
            var result = HandSign.GetWinningMove(HandSignEnum.Paper);
            Assert.Equal(HandSignEnum.Scissors, result);
        }
    }
}