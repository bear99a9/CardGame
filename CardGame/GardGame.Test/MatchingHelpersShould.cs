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
    }
}
