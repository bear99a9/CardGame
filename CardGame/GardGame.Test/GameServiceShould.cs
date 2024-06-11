using CardGame.Interfaces;
using CardGame.Services;
using NSubstitute;

namespace GardGame.Test
{
    public class GameServiceShould
    {
        private readonly ICardGameHelpers _cardGameHelpersMock;
        public GameServiceShould()
        {
            _cardGameHelpersMock = Substitute.For<ICardGameHelpers>();
        }

        [Fact]
        public void PlayGame_And_ReturnDraw()
        {
            var sut = new GameService(_cardGameHelpersMock);

            var actual = sut.PlayGame(1, "string");

            var expectd = "draw";

            Assert.Equal(expectd, actual);
        }
    }
}