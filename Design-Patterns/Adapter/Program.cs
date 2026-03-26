// See https://aka.ms/new-console-template for more information

using Adapter;

Console.WriteLine("=============== Adapter Design Pattern ===================");

PoundWeighingMachine poundWeighingMachine = new PoundWeighingMachine();
poundWeighingMachine.ReadWeight(150);
Console.WriteLine("weight in pounds: " + poundWeighingMachine.GetWeight());

MetricWeightMachineAdapter metricWeightMachineAdapter = new MetricWeightMachineAdapter(poundWeighingMachine);
Console.WriteLine("weight in kg: " + metricWeightMachineAdapter.GetWeightInKG());