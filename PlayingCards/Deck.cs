using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public static class Deck
    {
        private static Random _random = new Random();
        private static List<PlayingCard> _cards;

        static Deck() => NewHand();

        public static List<PlayingCard> Current => _cards;

        public static void NewHand()
        {
            if (_cards == null)
            {
                _cards = new List<PlayingCard>();
            }
            else
            {
                _cards.Clear();
            }
            CreateDeck();
            Shuffle();
        }

        private static void CreateDeck()
        {
            for (int s = 1; s <= 4; s++)
            {
                for (int v = 1; v <= 13; v++)
                {
                    PlayingCard playingCard = new PlayingCard(v, (Suit)s);
                    _cards.Add(playingCard);
                }
            }          
        }

        private static void Shuffle()
        {
            for (int i = 0; i < _cards.Count; i++)
            {
                int r = i + _random.Next(_cards.Count - i);
                var t = _cards[r];
                _cards[r] = _cards[i];
                _cards[i] = t;
            }
        }

        public static List<PlayingCard> GetCards(int cardCount)
        {
            List<PlayingCard> cards = _cards.GetRange(0, cardCount);
            _cards.RemoveRange(0, cardCount);
            return cards;
        }
    }
}
