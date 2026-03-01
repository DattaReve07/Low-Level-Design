namespace VendingMachine_ChainOfResponsibilityDesignPattern;

public abstract class ProductProcessor(ProductProcessor? nextProcessor)
{
    public virtual void Process(Product product)
    {
        nextProcessor?.Process(product);
    }
}