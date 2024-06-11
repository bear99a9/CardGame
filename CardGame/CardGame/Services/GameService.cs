using CardGame.Models;
using CardGame.Interfaces;
using System;

namespace CardGame.Services
{
    public class GameService
    {
        private readonly ICardGameHelpers _gameHelpers;
        private readonly Random _random;

        public GameService(ICardGameHelpers gameHelpers)
        {
            _gameHelpers = gameHelpers;
            _random = new Random();
        }

        public string PlayGame(int numberOfDecks, string matchCondtion)
        {
            // need to add players
            var players = new List<Player>() { new() { Name = "Player 1" }, new() { Name = "Player 2" } };

            // need played cards list
            var playedCards = new List<Card>();

            // need a deck of cards
            var decks = _gameHelpers.CreateDecks(numberOfDecks);

            // need a shuffled deck of cards
            var shuffledDecks = _gameHelpers.ShuffleDeck(decks);

            // foreach over the cards
            foreach (var card in shuffledDecks)
            {

                // get the last played card check if it is null then add it to the played cards else check the match 
                var lastPlayedCard = playedCards.LastOrDefault();

                // if matched select a random player add the score to the winner and clear the played cards

                // else add the card to played cards

                if (lastPlayedCard == null)
                {
                    playedCards.Add(card);
                }
                else
                {
                    var isMatch = (matchCondtion.ToLower() == "suit" && lastPlayedCard.Suit == card.Suit) ||
                                    (matchCondtion.ToLower() == "value" && lastPlayedCard.Value == card.Value) ||
                                    (matchCondtion.ToLower() == "both" && lastPlayedCard.Value == card.Value && lastPlayedCard.Suit == card.Suit);
                    if (isMatch) // match condtion selected
                    {
                        var winner = players[_random.Next(0, 2)];
                        winner.Score += playedCards.Count + 1;
                        playedCards.Clear();
                    }
                    else
                    {
                        playedCards.Add(card);
                    }
                }
            }

            // after the foreach each return the string result with the player who has the most the points

            return players.First().Score == players.Last().Score ? "It is a draw" :
                players.First().Score > players.Last().Score ? "Player 1 wins" : "Player 2 wins";
        }
    }
}
