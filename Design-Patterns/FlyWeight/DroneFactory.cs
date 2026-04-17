namespace FlyWeight;

public static class DroneFactory
{
    private static readonly Dictionary<DroneTypesEnum, DroneType> DroneTypes = new();

    public static DroneType GetDroneType(DroneTypesEnum name, string role, string colour)
    {
        if (!DroneTypes.ContainsKey(name))
        {
            DroneTypes[name] = new DroneType(name, role, colour);
        }

        return DroneTypes[name];
    }
}