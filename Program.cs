using System.Runtime.Loader;

namespace Mission4;

class Program
{
    static void Main(string[] args)
    {
        char[][] board =
        {
            new char[] { ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ' },
            new char[] { ' ', ' ', ' ' }
        };
        TicTacBoard ttb = new TicTacBoard(board);

        // player one starts the game
        char currentPlayer = 'O';
        bool gameWon = false;
        char winner = '\0';

        while (!gameWon)
        {
            // Clear console
            Console.Clear();
            
            // Switch current player
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            
            // Welcome user to the game 
            Console.WriteLine("Welcome to the Tic-Tac-Toe Game!");
            Console.WriteLine("Player 1 = X; Player 2 = O\n");
            
            // Print board
            ttb.PrintBoard();
            
            // Take a turn
            Console.WriteLine($"Player {(currentPlayer == 'X' ? "1" : "2")}:");
            ttb.Board = PlayTurn(currentPlayer, board);
            
            // Check winner
            (gameWon, winner) = ttb.IsWinner();
            
        }
        
        // Display winning board
        Console.Clear();
        Console.WriteLine("Welcome to the Tic-Tac-Toe Game!");
        Console.WriteLine("Player 1 = X; Player 2 = O\n");
        ttb.PrintBoard();
        Console.WriteLine($"Congratulations! Player {(winner == 'X' ? "1" : "2")} won the game!");

    }

    public static char[][] PlayTurn(char currentPlayer, char[][] board)
    {
        // Error handling loop
        while (true)
        {
            // We subtract 1 immediately to convert "1-3" (user view) to "0-2" (array view)
            int row = GetValidInput("Choose a row (1-3): ") - 1;
            int col = GetValidInput("Choose a column (1-3): ") - 1;

            // Check if the spot is already taken
            if (board[row][col] == ' ') 
            {
                // Spot is free, make the move
                board[row][col] = currentPlayer;
                return board;
            }
            else
            {
                Console.WriteLine("That spot is already taken! Try again.");
            }
        }
    }
    public static int GetValidInput(string prompt)
    {
        int userChoice;

        // Keep looping until the input is valid
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            // 1. Try to parse string to int
            // 2. Check if the number is between 1 and 3
            if (int.TryParse(input, out userChoice) && userChoice >= 1 && userChoice <= 3)
            {
                // Valid input found, break the loop and return the number
                return userChoice;
            }

            // If we get here, the input was bad
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        }
    }
}