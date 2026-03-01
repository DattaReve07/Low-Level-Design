namespace VendingMachine_ChainOfResponsibilityDesignPattern.Processors;

public class CandyProcessor(ProductProcessor? nextProcessor) : ProductProcessor(nextProcessor)
{
    public override void Process(Product product)
    {
        if (product == Product.CANDY)
        {
            Console.WriteLine("Processing candy...");
        }
        else
        {
            base.Process(product);
        }
    }
}