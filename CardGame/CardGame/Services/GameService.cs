using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Services
{
    public class GameService
    {
        public GameService()
        {
            
        }

        public string PlayGame(int numberOfDecks, string matchCondtion)
        {
            // need to add players
            var players = new List<Player>() { new() { Name = "Player 1" }, new() { Name = "Player 2" } };

            // need played cards list
            var playedCards = new List<Card>();

            // need a deck of cards

            // need a shuffled deck of cards

            // foreach over the cards

            // get the last played card check if it is null then add it to the played cards else check the match 

            // if matched select a random player add the score to the winner and clear the played cards

            // else add the card to played cards

            // after the foreach each return the string result with the player who has the most the points

            return "draw";
        }
    }
}
