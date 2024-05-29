using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Exercitii
{
    public interface IPlayer
    {
        public Guid Id { get; }
        public string Name { get; }
        public void AddCard(Card card);
        public string GetDescription();
        public int GetTotal();
    }
}
