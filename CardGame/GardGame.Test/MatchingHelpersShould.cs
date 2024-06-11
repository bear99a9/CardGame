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

        private readonly Card _lastPlayedCardMatch = new() { Suit = "diamonds", Value = "Ace" };
        private readonly Card _currentCardMatch = new() { Suit = "diamonds", Value = "Ace" };

        private readonly Card _lastPlayedCardMissMatch = new() { Suit = "hearts", Value = "Ace" };
        private readonly Card _currentCardMissMatch = new() { Suit = "diamonds", Value = "King" };

        [Fact]
        public void SuitMatchChecker_IsMatch_ShouldReturnTrueWhenSuitsMatch()
        {
            // Arrange
            var sut = new SuitMatchChecker();

            // Act
            var actual = sut.IsMatch(_lastPlayedCardMatch, _currentCardMatch);

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void SuitMatchChecker_IsMatch_ShouldReturnFalseWhenSuitsDoNotMatch()
        {
            // Arrange
            var sut = new SuitMatchChecker();

            // Act
            var actual = sut.IsMatch(_lastPlayedCardMissMatch, _currentCardMissMatch);

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void ValueMatchChecker_IsMatch_ShouldReturnTrueWhenValuesMatch()
        {
            // Arrange
            var sut = new ValueMatchChecker();

            // Act
            var actual = sut.IsMatch(_lastPlayedCardMatch, _currentCardMatch);

            // Assert
            Assert.True(actual);
        }


        [Fact]
        public void ValueMatchChecker_IsMatch_ShouldReturnFalseWhenValuesDoNotMatch()
        {
            // Arrange
            var sut = new ValueMatchChecker();

            // Act
            var actual = sut.IsMatch(_lastPlayedCardMissMatch, _currentCardMissMatch);

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void BothMatchChecker_IsMatch_ShouldReturnTrueWhenBothMatch()
        {
            // Arrange
            var sut = new BothMatchChecker();

            // Act
            var actual = sut.IsMatch(_lastPlayedCardMatch, _currentCardMatch);

            // Assert
            Assert.True(actual);
        }


        [Fact]
        public void BothMatchChecker_IsMatch_ShouldReturnFalseWhenBothDoNotMatch()
        {
            // Arrange
            var sut = new BothMatchChecker();

            // Act
            var actual = sut.IsMatch(_lastPlayedCardMissMatch, _currentCardMissMatch);

            // Assert
            Assert.False(actual);
        }

    }
}
