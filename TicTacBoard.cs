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

        //chec if there is '3 in a row'
        foreach (char[] row in this.Board)
        {
            if (char.ToUpper(row[0]) == 'X' || char.ToUpper(row[0]) == 'O')
            {
                if (row[0] == row[1] && row[0] == row[2])
                {
                    return (true, row[0]);
                }
            }



            //check if there is '3 in a column'
            for (int col = 0; col < this.Board.Length; col++)
            {
                if (char.ToUpper(row[0]) == 'X' || char.ToUpper(row[0]) == 'O')
                {
                    if (this.Board[0][col] == this.Board[1][col] && this.Board[1][col] == this.Board[2][col])
                    {
                        return (true, this.Board[0][col]);
                    }
                }
            }
        }


        if (char.ToUpper(this.Board[0][0]) == 'X' || char.ToUpper(this.Board[0][0]) == 'O')
        {
            //check diagonal 1
            if (this.Board[0][0] == this.Board[1][1] && this.Board[1][1] == this.Board[2][2])
            {
                return (true, this.Board[0][0]);
            }
        }

        if (char.ToUpper(this.Board[0][2]) == 'X' || char.ToUpper(this.Board[0][2]) == 'O')
        {
            //check diagonal 2
            if (this.Board[0][2] == this.Board[1][1] && this.Board[1][1] == this.Board[2][0])
            {
                return (true, this.Board[0][2]);
            }
        }


        //check if there is a cat's game (draw)
        if (IsBoardFull())
        {
            return (false, 'C');
        }
        
        return (false, 'U');
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