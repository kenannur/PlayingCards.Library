using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public class PlayingCard
    {
        public string Rank { get; private set; }
        public Suit Suit { get; private set; }
        public int Value { get; private set; }
        public int BlackjackValue { get; private set; }
        public int BlackjackValue2 { get; private set; }
        public int PokerValue { get; private set; }
        public int PokerValue2 { get; private set; }
        public int KingValue { get; private set; }
        public bool IsAce { get; private set; }

        public PlayingCard(int value, Suit suit)
        {
            Value = value;
            Suit = suit;
            Rank = value == 1 ? "A" : value == 11 ? "J" : value == 12 ? "Q" : value == 13 ? "K" : value.ToString();
            IsAce = value == 1;
            KingValue = value == 1 ? 14 : value;
            PokerValue = value == 1 ? 14 : value;
            PokerValue2 = value;
            BlackjackValue = value == 1 ? 11 : value;
            BlackjackValue2 = value;
        }
    }
}
