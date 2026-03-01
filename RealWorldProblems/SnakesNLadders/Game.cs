using SnakesNLadders.Components;

namespace SnakesNLadders;

public class Game
{
    private readonly Board board;
    private readonly LinkedList<Player> players = [];
    private readonly Dice dice;
    private Player? winner;
    private readonly int boardSize;

    public Game()
    {
        board = new Board(10, 10, 5);
        AddPlayers();
        dice = new Dice(1);
        winner = null;
        boardSize = board.Cells!.GetLength(0) * board.Cells.GetLength(1);
    }

    private void AddPlayers()
    {
        var player1 = new Player("Player 1", 0);
        var player2 = new Player("Player 2", 0);
        players.AddFirst(player1);
        players.AddLast(player2);
    }

    public void Start()
    {
        while (winner == null)
        {
            Player currentPlayer = GetPlayerTurn();
            Console.WriteLine($"It's {currentPlayer.Name}'s turn. Current position: {currentPlayer.CurrentPosition}");

            int diceNumber = dice.Roll();
            Console.WriteLine($"{currentPlayer.Name} rolled a {diceNumber}");

            int newPosition = currentPlayer.CurrentPosition + diceNumber;
            newPosition = JumpCheck(newPosition);
            if (newPosition > boardSize - 1)
            {
                winner = currentPlayer;
            }

            currentPlayer.CurrentPosition = newPosition;
            Console.WriteLine($"{currentPlayer.Name} moved to position {currentPlayer.CurrentPosition}");
            Console.WriteLine("--------------------------------------------------");
        }

        Console.WriteLine($"Congratulations! {winner.Name} wins the game!");
    }

    private int JumpCheck(int positionToCheck)
    {
        if (positionToCheck >= boardSize - 1)
        {
            return positionToCheck;
        }

        var cell = board.GetCell(positionToCheck);
        if (cell.jump == null) return positionToCheck;
        Console.WriteLine(cell.jump.start < cell.jump.end
            ? $"Yay! {cell.jump.start} is a ladder 🪜. Climb up to {cell.jump.end}"
            : $"Oh no! {cell.jump.start} is a snake 🐍. Slide down to {cell.jump.end}");
        return cell.jump.end;
    }

    private Player GetPlayerTurn()
    {
        var currentPlayer = players.First!.Value;
        players.RemoveFirst();
        players.AddLast(currentPlayer);
        return currentPlayer;
    }
}