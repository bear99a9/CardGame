using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Services
{
    public class CardGameHelpers
    {
        public IEnumerable<Card> CreateDecks(int numPacks)
        {
            List<string> suits = ["hearts", "diamonds", "clubs", "spades"];
            List<string> values = ["Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"];

            var deck = new List<Card>();

            for (int i = 0; i < numPacks; i++)
            {
                foreach (var suit in suits)
                {
                    foreach (var value in values)
                    {
                        deck.Add(new Card() { Suit = suit, Value = value });
                    }
                }
            }

            return deck;
        }

    }
}
