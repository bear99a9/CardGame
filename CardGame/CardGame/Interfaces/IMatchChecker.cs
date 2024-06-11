using CardGame.Models;

namespace CardGame.Interfaces
{
    public interface IMatchChecker
    {
        bool IsMatch(Card lastPlayedCard, Card currentCard);
    }
}