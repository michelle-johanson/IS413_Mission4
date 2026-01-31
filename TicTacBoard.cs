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
        for (int r = 0; r < Board.Length; r++)
        {
            Console.Write(" ");
            for (int c = 0; c < Board[r].Length; c++)
            {
                Console.Write(char.ToUpperInvariant(Board[r][c]));

                if (c < Board[r].Length - 1)
                    Console.Write(" | ");
            }

            Console.WriteLine(); // end the row

            if (r < Board.Length - 1)
                Console.WriteLine("---+---+---");
        }

        return Board;
    }

    public (bool, char) IsWinner()
    {
        // rows
        for (int r = 0; r < 3; r++)
        {
            char a = char.ToUpperInvariant(Board[r][0]);
            char b = char.ToUpperInvariant(Board[r][1]);
            char c = char.ToUpperInvariant(Board[r][2]);

            if ((a == 'X' || a == 'O') && a == b && a == c)
                return (true, a);
        }

        // columns
        for (int col = 0; col < 3; col++)
        {
            char a = char.ToUpperInvariant(Board[0][col]);
            char b = char.ToUpperInvariant(Board[1][col]);
            char c = char.ToUpperInvariant(Board[2][col]);

            if ((a == 'X' || a == 'O') && a == b && a == c)
                return (true, a);
        }

        // diagonal top-left -> bottom-right
        {
            char a = char.ToUpperInvariant(Board[0][0]);
            char b = char.ToUpperInvariant(Board[1][1]);
            char c = char.ToUpperInvariant(Board[2][2]);

            if ((a == 'X' || a == 'O') && a == b && a == c)
                return (true, a);
        }

        // diagonal top-right -> bottom-left
        {
            char a = char.ToUpperInvariant(Board[0][2]);
            char b = char.ToUpperInvariant(Board[1][1]);
            char c = char.ToUpperInvariant(Board[2][0]);

            if ((a == 'X' || a == 'O') && a == b && a == c)
                return (true, a);
        }

        if (IsBoardFull())
            return (true, 'C'); // cat's game

        return (false, 'U'); // unfinished
    }

    //check if board is full
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