namespace Adapter;

public class MetricWeightMachineAdapter(PoundWeighingMachineAdaptee poundWeighingMachine)
{
    public decimal GetWeightInKG()
    {
        decimal weightInPounds = poundWeighingMachine.GetWeight();
        return weightInPounds / 2.20462m;
    }
}