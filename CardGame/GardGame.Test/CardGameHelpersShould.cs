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

        [Fact]
        public void CreateDecks_ShouldContainAllSuitsAndValues()
        {
            // Arrange
            int numPacks = 1;
            List<string> suits = ["hearts", "diamonds", "clubs", "spades"];
            List<string> values = ["Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"];

            // Act
            var actual = _sut.CreateDecks(numPacks);

            // Assert
            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    Assert.Contains(actual, card => card.Suit == suit && card.Value == value);
                }
            }
        }


        [Fact]
        public void CreateDecks_ShouldReturnCorrectNumberOfPacks()
        {
            // Arrange
            int numPacks = 3;
            int expectedCardCount = numPacks * 52; // 52 cards per deck

            // Act
            var actual = _sut.CreateDecks(numPacks);

            // Assert
            Assert.Equal(expectedCardCount, actual.Count());
        }
    }
}

