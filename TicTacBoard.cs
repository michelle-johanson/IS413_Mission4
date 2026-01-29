namespace Mission4;

public class TicTacBoard
{
    public char[][] Board;
    
    public TicTacBoard(char[][] board)
    {
        this.Board = board;
    }
    public char[][] PrintBoard()
    {
        for (int row = 0; row < this.Board.Length; row++)
        {
            for (int col = 0; col < this.Board[row].Length; col++)
            {
                Console.Write($" {char.ToUpper(this.Board[row][col])} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        return this.Board;
    }
    
    public (bool, char) IsWinner()
    {
        // 1. Check Rows
        // We iterate 0 to 2 to check every row
        for (int row = 0; row < 3; row++)
        {
            // Check if the first cell is not a dash, and if all three match
            if (this.Board[row][0] != '-' && 
                this.Board[row][0] == this.Board[row][1] && 
                this.Board[row][1] == this.Board[row][2])
            {
                return (true, this.Board[row][0]);
            }
        }

        // 2. Check Columns
        // We iterate 0 to 2 to check every column
        for (int col = 0; col < 3; col++)
        {
            // Check if the top cell is not a dash, and if all three match downwards
            if (this.Board[0][col] != '-' && 
                this.Board[0][col] == this.Board[1][col] && 
                this.Board[1][col] == this.Board[2][col])
            {
                return (true, this.Board[0][col]);
            }
        }

        // 3. Check Diagonals
    
        // Diagonal 1 (Top-Left to Bottom-Right)
        if (this.Board[0][0] != '-' && 
            this.Board[0][0] == this.Board[1][1] && 
            this.Board[1][1] == this.Board[2][2])
        {
            return (true, this.Board[0][0]);
        }

        // Diagonal 2 (Top-Right to Bottom-Left)
        if (this.Board[0][2] != '-' && 
            this.Board[0][2] == this.Board[1][1] && 
            this.Board[1][1] == this.Board[2][0])
        {
            return (true, this.Board[0][2]);
        }

        // 4. Check for Draw (Cat's Game)
        // If the board is full and no one won yet, the game is over (true) but the winner is 'C' (Cat)
        if (IsBoardFull())
        {
            return (true, 'C'); 
        }
    
        // Game continues
        return (false, ' ');
    }

    // Check if board is full
    public bool IsBoardFull()
    {
        foreach (char[] row in this.Board)
        {
            foreach (char col in row)
            {
                if (char.ToUpper(col) != 'X' && char.ToUpper(col) != 'O')
                {
                    return false;
                }
            }
        }
        return true;
    }
    
}