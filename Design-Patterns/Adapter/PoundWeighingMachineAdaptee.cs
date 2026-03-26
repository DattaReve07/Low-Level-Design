namespace Adapter;

public interface PoundWeighingMachineAdaptee
{
    public void ReadWeight(decimal weight);
    public decimal GetWeight();
}