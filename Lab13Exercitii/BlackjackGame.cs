using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Exercitii
{
    public class BlackjackGame
    {
        public Guid Evaluate(List<Player> players)
        {
            var winners = new List<Player>();
            var closestTo21 = 0;

            foreach (var player in players)
            {
                var total = player.GetTotal();
                if (total <= 21)
                {
                    if (total == 21)
                        return player.Id;

                    if (total > closestTo21 && total <= 21)
                    {
                        winners.Clear();
                        winners.Add(player);
                        closestTo21 = total;
                    }
                    else if (total == closestTo21 && total <= 21)
                    {
                        winners.Add(player);
                    }
                }
            }
            if (winners.Count > 0)
                return winners.First().Id;

            if (players.All(player => player.GetTotal() > 21))
                return Guid.Empty; 

            return Guid.NewGuid(); 
        }

    }
}
