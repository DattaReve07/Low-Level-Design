namespace NULLObject;

public class VehicleFactory
{
    public static Vehicle getVehicle(string vehicleType)
    {
        if (vehicleType == "Car")
        {
            return new Car();
        }

        return new NullObject();
    }
}