using System.Runtime.Loader;

namespace Mission4;

class Program
{
    static void Main(string[] args)
    {
     TicTacBoard ttb = new TicTacBoard();

    //Welcome user to the game 
    Console.WriteLine("Welcome to the Tic-Tac-Toe Game!");
    Console.WriteLine("Player 1 = X, Player 2 = O\n");
    
    // player one starts the game
    char currentPlayer = "X";
    bool gameWon = false;
    
    while (!gameWon)
    {
        Console.WriteLine($"Player {(currentPlayer == "X" ? "1" : "2")}, choose a position (1-9):");
        int choice = int.Parse(Console.ReadLine());
    
        ttb.PlaceMarker(choice, currentPlayer);
        ttb.PrintBoard();
        }
}
