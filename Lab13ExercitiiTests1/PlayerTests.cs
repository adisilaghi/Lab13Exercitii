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
    public class PlayerTests
    {
        [TestMethod()]
        public void TestGetDescription()
        {
            var playerId = Guid.NewGuid();
            var playerName = "John";
            var playerCards = new Card[] { new Card(10, Card.CardSuit.Hearts), new Card(8, Card.CardSuit.Spades) };

            var player = new Player(playerId, playerName);

            foreach (var card in playerCards)
            {
                player.AddCard(card);
            }
            var expectedDescription = $"Player ID: {playerId}, Name: {playerName}, Cards: 10 Hearts, 8 Spades";
            
            var actualDescription = player.GetDescription();
                      
            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [TestMethod()]
        public void TestGetTotal()
        {
            var playerId = Guid.NewGuid();
            var playerName = "John";
            var playerCards = new Card[] { new Card(10, Card.CardSuit.Hearts), new Card(8, Card.CardSuit.Spades) };

            var player = new Player(playerId, playerName);

            foreach (var card in playerCards)
            {
                player.AddCard(card);
            }

            var expectedTotal = 18;

            var actualTotal = player.GetTotal();
            
            Assert.AreEqual(expectedTotal, actualTotal);
        }
             
    }
}