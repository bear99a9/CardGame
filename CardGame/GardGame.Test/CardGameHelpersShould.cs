namespace GardGame.Test
{
    public class CardGameHelpersShould
    {
        private readonly CardGameHelpers _sut;
        public CardGameHelpersShould()
        {
            _sut = new CardGameHelpers();
        }

        [Fact]
        public void CreateDecks_ShouldReturnCorrectNumberOfCards()
        {
            // Arrange
            int numPacks = 1;
            int expectedCardCount = numPacks * 52; // 52 cards per deck

            // Act
            var actual = _sut.CreateDecks(numPacks);

            // Assert
            Assert.Equal(expectedCardCount, actual.Count());
        }
    }
}
