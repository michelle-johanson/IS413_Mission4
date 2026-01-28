using System.Runtime.Loader;

namespace Mission4;

class Program
{
    static void Main(string[] args)
    {
        // Game Starts
        
        // Player X places X in row 1, col 1
        UpdateBoard('X', 1, 1);
        
        char[][] boardArray =
        {
            new char[3],
            new char[3],
            new char[3]
        };

    }

    public void UpdateBoard(char player, int row, int col, char[][] boardArray)
    {
        boardArray[row][col] = player;
        TicTacBoard board = new TicTacBoard(boardArray);
    }
}