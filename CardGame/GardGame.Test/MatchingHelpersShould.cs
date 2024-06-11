using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardGame.Test
{
    public class MatchingHelpersShould
    {
        [Fact]
        public void SuitMatchChecker_IsMatch_ShouldReturnTrueWhenSuitsMatch()
        {
            // Arrange
            var lastPlayedCard = new Card { Suit = "hearts", Value = "Ace" };
            var currentCard = new Card { Suit = "hearts", Value = "King" };
            var sut = new SuitMatchChecker();

            // Act
            var actual = sut.IsMatch(lastPlayedCard, currentCard);

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void SuitMatchChecker_IsMatch_ShouldReturnFalseWhenSuitsDoNotMatch()
        {
            // Arrange
            var lastPlayedCard = new Card { Suit = "hearts", Value = "Ace" };
            var currentCard = new Card { Suit = "diamonds", Value = "King" };
            var sut = new SuitMatchChecker();

            // Act
            var actual = sut.IsMatch(lastPlayedCard, currentCard);

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void ValueMatchChecker_IsMatch_ShouldReturnTrueWhenValuesMatch()
        {
            // Arrange
            var lastPlayedCard = new Card { Suit = "hearts", Value = "Ace" };
            var currentCard = new Card { Suit = "hearts", Value = "Ace" };
            var sut = new ValueMatchChecker();

            // Act
            var actual = sut.IsMatch(lastPlayedCard, currentCard);

            // Assert
            Assert.True(actual);
        }


        [Fact]
        public void ValueMatchChecker_IsMatch_ShouldReturnFalseWhenValuesDoNotMatch()
        {
            // Arrange
            var lastPlayedCard = new Card { Suit = "hearts", Value = "Ace" };
            var currentCard = new Card { Suit = "diamonds", Value = "King" };
            var sut = new ValueMatchChecker();

            // Act
            var actual = sut.IsMatch(lastPlayedCard, currentCard);

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void BothMatchChecker_IsMatch_ShouldReturnTrueWhenBothMatch()
        {
            // Arrange
            var lastPlayedCard = new Card { Suit = "hearts", Value = "Ace" };
            var currentCard = new Card { Suit = "hearts", Value = "Ace" };
            var sut = new BothMatchChecker();

            // Act
            var actual = sut.IsMatch(lastPlayedCard, currentCard);

            // Assert
            Assert.True(actual);
        }


        [Fact]
        public void BothMatchChecker_IsMatch_ShouldReturnFalseWhenBothDoNotMatch()
        {
            // Arrange
            var lastPlayedCard = new Card { Suit = "hearts", Value = "Ace" };
            var currentCard = new Card { Suit = "diamonds", Value = "King" };
            var sut = new BothMatchChecker();

            // Act
            var actual = sut.IsMatch(lastPlayedCard, currentCard);

            // Assert
            Assert.False(actual);
        }

    }
}
