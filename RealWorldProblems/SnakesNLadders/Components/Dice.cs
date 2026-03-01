namespace SnakesNLadders.Components;

public class Dice(int numberOfDices)
{
    private const int MinValue = 1;
    private const int MaxValue = 6;

    public int Roll()
    {
        Random random = new Random();
        int total = 0;
        for (int i = 0; i < numberOfDices; i++)
        {
            total += random.Next(MinValue, MaxValue + 1);
        }

        return total;
    }
}