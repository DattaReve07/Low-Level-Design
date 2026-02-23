namespace TicTacToe;

public class Board(int size)
{
    private PlayingPiece?[,] board = new PlayingPiece[size, size];

    public bool fillPlace(int x, int y, PlayingPiece piece)
    {
        if (board[x, y] != null)
        {
            return false;
        }
        board[x, y] = piece;
        return true;
    }

    public void Print()
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board.Length; j++)
            {
                if (board[i, j] != null)
                {
                    Console.Write(board[i, j] + " ");
                }
                else
                {
                    Console.Write("  |  ");
                }
            }
        }
    }
}