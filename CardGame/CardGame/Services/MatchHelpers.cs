using CardGame.Interfaces;
using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Services
{
    public class SuitMatchChecker : IMatchChecker
    {
        public bool IsMatch(Card lastPlayedCard, Card currentCard)
        {
            return lastPlayedCard.Suit == currentCard.Suit;
        }
    }

    public class ValueMatchChecker : IMatchChecker
    {
        public bool IsMatch(Card lastPlayedCard, Card currentCard)
        {
            return lastPlayedCard.Value == currentCard.Value;
        }
    }

    public class BothMatchChecker : IMatchChecker
    {
        public bool IsMatch(Card lastPlayedCard, Card currentCard)
        {
            return lastPlayedCard.Suit == currentCard.Suit && lastPlayedCard.Value == currentCard.Value;
        }
    }


}
