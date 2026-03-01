namespace VendingMachine_ChainOfResponsibilityDesignPattern.Processors;

public class MilkShakeProcessor(ProductProcessor? nextProcessor) : ProductProcessor(nextProcessor)
{
    public override void Process(Product product)
    {
        if (product == Product.MILKSHAKE)
        {
            Console.WriteLine("Processing milkshake...");
        }
        else
        {
            base.Process(product);
        }
    }
}