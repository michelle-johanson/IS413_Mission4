namespace DefaultNamespace;

public class TicTacBoard
{
    public char[][] Board;
    
    public TicTacBoard(char[][] board)
    {
        this.Board = board;
    }
    
        
    public char[][] PrintBoard()
    {
        foreach (char[] row in this.Board)
        {
            foreach (char col in row)
            {
                Console.Write(col.ToUpper());
                if (col != row[^1])
                {
                    Console.Write(' | ');
                }
                
            }
            if (row != this.Board[^1])
            {
                Console.WriteLine("---+---+---");
            }
        }

        return this.Board;
    }

    public (bool, char) IsWinner()
    {

        //chec if there is '3 in a row'
        foreach (char[] row in this.Board)
        {
            if (row[0].ToUpper() == 'X' || row[0].ToUpper() == 'O')
            {
                if (row[0] == row[1] && row[1] == row[2])
                { 
                    return (true, row[0]);
                }
            }
        }
        
        
        //check if there is '3 in a column'
        for (int col = 0; col < this.Board.Length; col++)
        {
            if (row[0].ToUpper() == 'X' || row[0].ToUpper() == 'O')
            {
                if (this.Board[0][col] == this.Board[1][col] && this.Board[1][col] == this.Board[2][col])
                {
                    return (true, this.Board[0][col]);
                }
            }
        }

        
        if (row[0].ToUpper() == 'X' || row[0].ToUpper() == 'O')
        {
            //check diagonal 1
            if (this.Board[0][0] == this.Board[1][1] == this.Board[2][2])
                {
                    return (true, this.Board[0][0]);
                }
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
                if (col.ToUpper() != 'X' && col.ToUpper() != 'O')
                {
                    return false;
                }
            }
        }
        return true;
    }
    
}