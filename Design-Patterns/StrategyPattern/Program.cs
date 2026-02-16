// Strategy Design Pattern Example
using System;

// Strategy interface
public interface IPaymentStrategy
{
    void Pay(double amount);
}

// Concrete strategies
public class CreditCardPayment : IPaymentStrategy
{
    private string cardNumber;
    private string cardHolderName;

    public CreditCardPayment(string cardNumber, string cardHolderName)
    {
        this.cardNumber = cardNumber;
        this.cardHolderName = cardHolderName;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ${amount:F2} using Credit Card ending in {cardNumber.Substring(cardNumber.Length - 4)}");
        Console.WriteLine($"Cardholder: {cardHolderName}");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    private string email;

    public PayPalPayment(string email)
    {
        this.email = email;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ${amount:F2} using PayPal account: {email}");
    }
}

public class BankTransferPayment : IPaymentStrategy
{
    private string accountNumber;
    private string bankName;

    public BankTransferPayment(string accountNumber, string bankName)
    {
        this.accountNumber = accountNumber;
        this.bankName = bankName;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ${amount:F2} via Bank Transfer from {bankName}");
        Console.WriteLine($"Account: ***{accountNumber.Substring(accountNumber.Length - 4)}");
    }
}

// Context class
public class ShoppingCart
{
    private IPaymentStrategy? paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        paymentStrategy = strategy;
    }

    public void Checkout(double totalAmount)
    {
        if (paymentStrategy == null)
        {
            Console.WriteLine("Please select a payment method!");
            return;
        }

        Console.WriteLine($"\nProcessing payment for total amount: ${totalAmount:F2}");
        Console.WriteLine("----------------------------------------");
        paymentStrategy.Pay(totalAmount);
        Console.WriteLine("Payment completed successfully!\n");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Strategy Design Pattern Demo ===\n");

        // Create shopping cart
        ShoppingCart cart = new ShoppingCart();
        double totalAmount = 299.99;

        // Demonstrate different payment strategies
        Console.WriteLine("1. Paying with Credit Card:");
        cart.SetPaymentStrategy(new CreditCardPayment("1234567812345678", "John Doe"));
        cart.Checkout(totalAmount);

        Console.WriteLine("2. Paying with PayPal:");
        cart.SetPaymentStrategy(new PayPalPayment("john.doe@email.com"));
        cart.Checkout(totalAmount);

        Console.WriteLine("3. Paying with Bank Transfer:");
        cart.SetPaymentStrategy(new BankTransferPayment("9876543210", "Chase Bank"));
        cart.Checkout(totalAmount);

        Console.WriteLine("4. Attempting checkout without payment strategy:");
        cart.SetPaymentStrategy(null!);
        cart.Checkout(totalAmount);

        Console.WriteLine("=== Strategy Pattern Benefits ===");
        Console.WriteLine("✓ Easy to add new payment methods without modifying existing code");
        Console.WriteLine("✓ Payment logic is encapsulated in separate classes");
        Console.WriteLine("✓ Runtime strategy switching capability");
        Console.WriteLine("✓ Follows Open/Closed Principle");
    }
}
