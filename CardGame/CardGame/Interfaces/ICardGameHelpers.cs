﻿using CardGame.Models;

namespace CardGame.Interfaces
{
    public interface ICardGameHelpers
    {
        IEnumerable<Card> CreateDecks(int numPacks);
        IEnumerable<Card> ShuffleDeck(IEnumerable<Card> deck);
    }
}