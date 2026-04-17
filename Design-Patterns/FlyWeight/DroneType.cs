namespace FlyWeight;

public class DroneType(DroneTypesEnum name, string role, string colour)
{
    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing {role} drone of type {name} and colour {colour} at coordinates ({x}, {y})");
    }
}