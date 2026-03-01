namespace SnakesNLadders.Components;

public class Board
{
    public Cell[,]? Cells;

    public Board(int size, int noOfSnakes, int noOfLadders)
    {
        InitialiseCells(size);
        InitializeJumps(size, noOfSnakes, noOfLadders);
    }

    private void InitialiseCells(int size)
    {
        Cells = new Cell[size, size];
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                Cells[i, j] = new Cell();
            }
        }
    }

    private void InitializeJumps(int size, int noOfSnakes, int noOfLadders)
    {
        AssignSnakesPositions(size, noOfSnakes);
        AssignLaddersPositions(size, noOfLadders);
    }

    private void AssignSnakesPositions(int size, int noOfSnakes)
    {
        Random random = new Random();
        while (noOfSnakes > 0)
        {
            int startPos = random.Next(0, size * size);
            int endPos = random.Next(0, size * size);
            if (startPos <= endPos) continue;
            var startCell = GetCell(startPos);
            var endCell = GetCell(endPos);
            if (startCell.jump != null || endCell.jump != null) continue;
            startCell.jump = new Jump { start = startPos, end = endPos };
            noOfSnakes--;
        }
    }

    private void AssignLaddersPositions(int size, int noOfLadders)
    {
        Random random = new Random();
        while (noOfLadders > 0)
        {
            int startPos = random.Next(0, size * size);
            int endPos = random.Next(0, size * size);
            if (startPos >= endPos) continue;
            var startCell = GetCell(startPos);
            var endCell = GetCell(endPos);
            if (startCell.jump != null || endCell.jump != null) continue;
            startCell.jump = new Jump { start = startPos, end = endPos };
            noOfLadders--;
        }
    }

    public Cell GetCell(int position)
    {
        var startRow = position / Cells!.GetLength(0);
        var startCol = position % Cells.GetLength(1);
        if (startRow > Cells.GetLength(0) || startCol > Cells.GetLength(1))
        {
            throw new IndexOutOfRangeException();
        }

        return Cells[startRow, startCol];
    }
}