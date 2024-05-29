using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Exercitii
{
    public class Card
    {
       public enum CardSuit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }
        public int Value { get; }
        public CardSuit Suit { get; }
        public Card(int value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
        }
     }
}
