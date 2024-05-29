// See https://aka.ms/new-console-template for more information
// Create players
using Lab13Exercitii;
using static Lab13Exercitii.Card;

var player1 = new Player(Guid.NewGuid(), "John");
var player2 = new Player(Guid.NewGuid(), "James");

player1.AddCard(new Card(10, CardSuit.Hearts));
player1.AddCard(new Card(11, CardSuit.Spades));

player2.AddCard(new Card(7, CardSuit.Diamonds));
player2.AddCard(new Card(10, CardSuit.Spades));

var blackjackGame = new BlackjackGame();

var winnerId = blackjackGame.Evaluate(new List<Player> { player1, player2 });
if (winnerId != Guid.Empty)
{
    var winnerName = player1.Id == winnerId ? player1.Name : player2.Name;
    Console.WriteLine($"Player {winnerName} with ID {winnerId} wins!");
}
else
{
    Console.WriteLine("No winner. All players busted.");
}


