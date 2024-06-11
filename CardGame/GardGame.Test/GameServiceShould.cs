using CardGame.Services;

namespace GardGame.Test
{
    public class GameServiceShould
    {
        [Fact]
        public void PlayGame_And_ReturnDraw()
        {
            var sut = new GameService();

            var actual = sut.PlayGame(1, "string");

            var expectd = "draw";

            Assert.Equal(expectd, actual);
        }
    }
}