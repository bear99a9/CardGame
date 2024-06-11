using CardGame.Interfaces;
using CardGame.Models;
using CardGame.Services;
using NSubstitute;

namespace GardGame.Test
{
    public class GameServiceShould
    {
        private readonly ICardGameHelpers _cardGameHelpersMock;
        private readonly GameService _sut;

        public GameServiceShould()
        {
            _cardGameHelpersMock = Substitute.For<ICardGameHelpers>();
            _sut = new GameService(_cardGameHelpersMock);
        }

        [Theory]
        [InlineData(3, "suit")]
        [InlineData(3, "value")]
        [InlineData(3, "both")]
        public void PlayGame_ShouldContainCorrectResult(int numberOfDecks, string matchCondition)
        {
            // Arrange
            var expected = new[]
            {
               "Player 1 wins",
               "Player 2 wins",
               "It is a draw"
            };

            // Act
            var actual = _sut.PlayGame(numberOfDecks, GetMatchChecker(matchCondition));

            // Assert
            Assert.Contains(actual, expected);
        }

        private static IMatchChecker GetMatchChecker(string matchOption)
        {
            return matchOption switch
            {
                "suit" => new SuitMatchChecker(),
                "value" => new ValueMatchChecker(),
                "both" => new BothMatchChecker(),
                _ => throw new ArgumentException("Invalid match option")
            };
        }

    }
}