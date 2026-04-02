namespace Prototype;

public class UniTree(int id, string name, string description, int noOfLegs, int noOfArms)
    : Prototype
{
    public Prototype Clone()
    {
        return new UniTree(0, name, description, noOfLegs, noOfArms);
    }

    public void printDetails()
    {
        Console.WriteLine($"ID: {id}, Name: {name}, Description: {description}, No of Legs: {noOfLegs}, No of Arms: {noOfArms}");
    }
}