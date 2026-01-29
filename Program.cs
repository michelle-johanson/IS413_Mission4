using System.Runtime.Loader;

namespace Mission4;

class Program
{
    static void Main(string[] args)
    {
        char[][] board =
        {
            new char[3],
            new char[3],
            new char[3]
        };
        TicTacBoard ttb = new TicTacBoard(board);

        // player one starts the game
        char currentPlayer = 'O';
        bool gameWon = false;
        char winner = ' ';

        while (!gameWon)
        {
            // Clear console
            Console.Clear();
            
            // Switch current player
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            
            // Welcome user to the game 
            Console.WriteLine("Welcome to the Tic-Tac-Toe Game!");
            Console.WriteLine("Player 1 = X, Player 2 = O\n");
            
            // Print board
            ttb.PrintBoard();
            Console.WriteLine("\n");
            
            // Take a turn
            Console.WriteLine($"Player {(currentPlayer == 'X' ? "1" : "2")}:");
            ttb.Board = PlayTurn(currentPlayer, board);
            
            // Check winner
            (gameWon, winner) = ttb.IsWinner();
            
        }
        
        Console.WriteLine($"Congratulations! Player {(winner == 'X' ? "1" : "2")} won the game!");

    }

    public static char[][] PlayTurn(char currentPlayer, char[][] board)
    {
        Console.Write($"Choose a row (1-3): ");
        int row = int.Parse(Console.ReadLine()) - 1;
        Console.Write($"Choose a column (1-3): ");
        int col = int.Parse(Console.ReadLine()) - 1;
        
        board[row][col] = currentPlayer;
        return board;
    }
}