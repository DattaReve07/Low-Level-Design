namespace TicTacToe;

public class Board(int size)
{
    private readonly PlayingPiece?[,] board = new PlayingPiece[size, size];

    private int emptyPlaces = size * size;

    public bool FillPlace(int x, int y, PlayingPiece piece)
    {
        if (board[x, y] != null)
        {
            return false;
        }

        board[x, y] = piece;
        emptyPlaces--;
        return true;
    }

    public void Print()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (board[i, j] != null)
                {
                    Console.Write(" " + board[i, j]!.piece + "  ");
                }
                else
                {
                    Console.Write("    ");
                }

                Console.Write("  |  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("----------------------------------------------------------------");
    }

    public bool CheckWin(int row, int col, PieceType? pieceType)
    {
        bool rowWin = false;
        bool colWin = false;
        bool diagonalWin = false;
        bool revDiagonalWin = false;

        // Check row
        for (int i = 0; i < size; i++)
        {
            if (board[row, i] == null || board[row, i]!.piece != pieceType)
            {
                rowWin = false;
                break;
            }

            rowWin = true;
        }

        for (int i = 0; i < size; i++)
        {
            if (board[i, col] == null || board[i, col]!.piece != pieceType)
            {
                colWin = false;
                break;
            }

            colWin = true;
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (board[i, j] == null || board[i, j]!.piece != pieceType)
                {
                    diagonalWin = false;
                    break;
                }
            }

            if (diagonalWin == false)
            {
                break;
            }

            diagonalWin = true;
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = size - 1; j >= 0; j--)
            {
                if (board[i, j] == null || board[i, j]!.piece != pieceType)
                {
                    revDiagonalWin = false;
                    break;
                }
            }

            if (revDiagonalWin == false)
            {
                break;
            }

            revDiagonalWin = true;
        }

        return rowWin || colWin || diagonalWin || revDiagonalWin;
    }

    public bool IsFull()
    {
        return emptyPlaces == 0;
    }
}