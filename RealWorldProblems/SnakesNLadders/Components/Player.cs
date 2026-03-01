namespace SnakesNLadders.Components;

public class Player(string name, int currentPosition)
{
    public string Name { get; set; } = name;
    public int CurrentPosition { get; set; } = currentPosition;
}