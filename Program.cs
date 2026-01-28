using System.Runtime.Loader;

namespace Mission4;

class Program
{
    static void Main(string[] args)
    {
        TicTacBoard ttb = new TicTacBoard();
        char[][] board =
        {
            new char[3],
            new char[3],
            new char[3]
        };

        //Welcome user to the game 
        Console.WriteLine("Welcome to the Tic-Tac-Toe Game!");
        Console.WriteLine("Player 1 = X, Player 2 = O\n");

        // player one starts the game
        char currentPlayer = 'X';
        bool gameWon = false;

        while (!gameWon)
        {
            Console.Write($"Player {(currentPlayer == 'X' ? "1" : "2")}: \nChoose a row (1-3): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write($"Choose a column (1-3): ");
            int col = int.Parse(Console.ReadLine());

            board[row][col] = currentPlayer;
            ttb.PrintBoard();
        }

    }
}