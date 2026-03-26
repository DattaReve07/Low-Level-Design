namespace Adapter;

public class PoundWeighingMachine : PoundWeighingMachineAdaptee
{
    private decimal weight;
    public void ReadWeight(decimal input)
    {
        this.weight = input;
    }

    public decimal GetWeight()
    {
        return weight;
    }
}