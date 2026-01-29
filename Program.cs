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

        //Welcome user to the game 
        Console.WriteLine("Welcome to the Tic-Tac-Toe Game!");
        Console.WriteLine("Player 1 = X, Player 2 = O\n");

        // player one starts the game
        char currentPlayer = 'X';
        bool gameWon = false;
        char winner = ' ';

        while (!gameWon)
        {
            Console.WriteLine($"Player {(currentPlayer == 'X' ? "1" : "2")}:");

            ttb.Board = PlayTurn(currentPlayer, board);
            ttb.PrintBoard();
            
            (gameWon, winner) = ttb.IsWinner();
            
            // Switch player
            if (currentPlayer == 'X')
            {
                currentPlayer = 'O';
            }
            else
            {
                currentPlayer = 'X';
            }
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