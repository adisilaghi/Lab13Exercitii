using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab13Exercitii;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Exercitii.Tests
{
    [TestClass()]
    public class BlackjackGameTests
    {
        [TestMethod()]
        public void TestEvaluate_OneWinner()
        {
            var player1 = new Player(Guid.NewGuid(), "Player 1");
            player1.AddCard(new Card(8, "Hearts"));
            player1.AddCard(new Card(8, "Spades"));

            var player2 = new Player(Guid.NewGuid(), "Player 2");
            player2.AddCard(new Card(8, "Diamonds"));
            player2.AddCard(new Card(8, "Clubs"));

            var blackjackGame = new BlackjackGame();
            var winnerId = blackjackGame.Evaluate(new List<Player> { player1, player2 });

            Assert.AreEqual(player1.Id, winnerId);
        }

        [TestMethod()]
        public void TestEvaluate_NoWinner()
        {
            var player1Id = Guid.NewGuid();
            var player1 = new Player(player1Id, "Player 1");
            player1.AddCard(new Card(8, "Hearts"));
            player1.AddCard(new Card(8, "Spades"));

            var player2Id = Guid.NewGuid();
            var player2 = new Player(player2Id, "Player 2");
            player2.AddCard(new Card(8, "Diamonds"));
            player2.AddCard(new Card(8, "Clubs"));

            var blackjackGame = new BlackjackGame();
            var winnerId = blackjackGame.Evaluate(new List<Player> { player1, player2 });

            Assert.AreEqual(Guid.Empty, winnerId);
        }
    }
}