using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Exercitii
{
    public class Player : IPlayer
    {
        public Guid Id { get; }
        public string Name { get; }
        private List<Card> cards;

        public Player(Guid id, string name)
        {
            Id = id;
            Name = name;
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public string GetDescription()
        {
            return $"Player ID: {Id}, Name: {Name}, Cards: {string.Join(", ", cards.Select(c => $"{c.Value} {c.Suit}"))}";
        }

        public int GetTotal()
        {
            return cards.Sum(c => c.Value);
        }
    }
}
