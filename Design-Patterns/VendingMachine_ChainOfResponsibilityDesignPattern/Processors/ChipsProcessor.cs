namespace VendingMachine_ChainOfResponsibilityDesignPattern.Processors;

public class ChipsProcessor(ProductProcessor? nextProcessor) : ProductProcessor(nextProcessor)
{
    public override void Process(Product product)
    {
        if (product == Product.CHIPS)
        {
            Console.WriteLine("Processing chips...");
        }
        else
        {
            base.Process(product);
        }
    }
}