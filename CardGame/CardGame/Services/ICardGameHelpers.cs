using CardGame.Models;

namespace CardGame.Services
{
    public interface ICardGameHelpers
    {
        IEnumerable<Card> CreateDecks(int numPacks);
        IEnumerable<Card> ShuffleDeck(IEnumerable<Card> deck);
    }
}