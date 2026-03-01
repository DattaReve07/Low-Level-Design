namespace TicTacToe;

public class Player(string name, PlayingPiece playingPiece)
{
    public string Name { get; set; } = name;
    public PlayingPiece PlayingPiece { get; set; } = playingPiece;
}