namespace TicTacToe;

public class TicTacToeGame
{
    public Board gameBoard;
    public LinkedList<Player> players;
    private Player? winner;
    public TicTacToeGame()
    {
        players = new LinkedList<Player>();
        Player crossPlayer = new Player("Cross Player", new PlayingPieceX());
        Player noughtPlayer = new Player("Nought Player", new PlayingPieceO());

        players.AddFirst(crossPlayer);
        players.AddFirst(noughtPlayer);
        gameBoard = new Board(3);
    }

    public GameStatus startGame()
    {
        bool gameOver = false;
        while (!gameOver)
        {
            Player currentPlayer = players.First!.Value;
            gameBoard.Print();
            Console.WriteLine($"{currentPlayer.Name}'s turn. Please enter the row and column to place your piece (e.g., 1, 2):");
            string input = Console.ReadLine()!;
            string[] coordinates = input.Split(',');
            int row = int.Parse(coordinates[0].Trim());
            int col = int.Parse(coordinates[1].Trim());
            var validMove = gameBoard.fillPlace(row, col, currentPlayer.PlayingPiece);
            if (!validMove)
            {
                Console.WriteLine("Invalid move. Please try again.");
                continue;
            }
            if()



        }
    }
}