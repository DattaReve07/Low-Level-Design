// See https://aka.ms/new-console-template for more information

/*
 * This example demonstrates the Chain of Responsibility design pattern in a vending machine context.
 * The vending machine can Process different types of products such as candy, chips, soda, and milkshakes.
 * Each product type has its own processor that handles the processing logic.
 * If a processor cannot handle a product, it passes it to the next processor in the chain until it finds one that can Process it or reaches the end of the chain.
 */

using VendingMachine_ChainOfResponsibilityDesignPattern;
using VendingMachine_ChainOfResponsibilityDesignPattern.Processors;

Console.WriteLine("Vending machine processing...");

ProductProcessor productProcessor =
    new MilkShakeProcessor(new ChipsProcessor(new SodaProcessor(new CandyProcessor(null))));
productProcessor.Process(Product.SODA);
productProcessor.Process(Product.MILKSHAKE);
productProcessor.Process(Product.CANDY);
productProcessor.Process(Product.CHIPS);

Console.WriteLine("All products processed.");