namespace FlyWeight;

public class Drone(DroneType droneType, int x, int y)
{
    public void Draw()
    {
        droneType.Draw(x, y);
    }
}