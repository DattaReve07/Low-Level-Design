namespace VendingMachine_ChainOfResponsibilityDesignPattern.Processors;

public class SodaProcessor(ProductProcessor? nextProcessor) : ProductProcessor(nextProcessor)
{
    public override void Process(Product product)
    {
        if (product == Product.SODA)
        {
            Console.WriteLine("Processing soda...");
        }
        else
        {
            base.Process(product);
        }
    }
}