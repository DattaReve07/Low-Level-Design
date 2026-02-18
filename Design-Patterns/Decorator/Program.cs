/// <summary>
/// Decorator Design Pattern
/// </summary>

// Converted to idiomatic C#
using System;

    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    public class PlainCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Plain Coffee";
        }

        public double GetCost()
        {
            return 2.0;
        }
    }

    public abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee decoratedCoffee;

        protected CoffeeDecorator(ICoffee decoratedCoffee)
        {
            this.decoratedCoffee = decoratedCoffee ?? throw new ArgumentNullException(nameof(decoratedCoffee));
        }

        public virtual string GetDescription()
        {
            return decoratedCoffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return decoratedCoffee.GetCost();
        }
    }

    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee)
        {
        }

        public override string GetDescription()
        {
            return decoratedCoffee.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return decoratedCoffee.GetCost() + 0.5;
        }
    }

    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee)
        {
        }

        public override string GetDescription()
        {
            return decoratedCoffee.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return decoratedCoffee.GetCost() + 0.2;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Plain Coffee
            ICoffee coffee = new PlainCoffee();
            Console.WriteLine("Description: " + coffee.GetDescription());
            Console.WriteLine("Cost: $" + coffee.GetCost());

            // Coffee with Milk
            ICoffee milkCoffee = new MilkDecorator(new PlainCoffee());
            Console.WriteLine("\nDescription: " + milkCoffee.GetDescription());
            Console.WriteLine("Cost: $" + milkCoffee.GetCost());

            // Coffee with Sugar and Milk
            ICoffee sugarMilkCoffee = new SugarDecorator(new MilkDecorator(new PlainCoffee()));
            Console.WriteLine("Description: " + sugarMilkCoffee.GetDescription());
            Console.WriteLine("Cost: $" + sugarMilkCoffee.GetCost());
        }
    }

