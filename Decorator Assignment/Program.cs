namespace DecoratorAssignment
{
    // Instructions
    // You can implement your whole solution here
    // Optionally you can use folder structure if you deem it necessary
    // For this Assignment we will use Decorator pattern example introduced in the book Head First Design Patterns by O'Reilly
    // Chapeter 3 the DecoratorPattern: Decorating Objects (starts at page 79)
    // Link to pdf: https://github.com/ajitpal/BookBank/blob/master/%5BO%60Reilly.%20Head%20First%5D%20-%20Head%20First%20Design%20Patterns%20-%20%5BFreeman%5D.pdf
    // NOTE: Remember that the code examples in this book are written in java so you can't just copy the code examples given there
    // Beverage interface
    public interface Beverage
    {
        double Cost();
    }

    // Concrete Beverages
    public class HouseBlend : Beverage
    {
        public double Cost()
        {
            return 1.80;
        }
    }

    public class DarkRoast : Beverage
    {
        public double Cost()
        {
            return 2.20;
        }
    }

    public class Espresso : Beverage
    {
        public double Cost()
        {
            return 2.90;
        }
    }

    public class Decaf : Beverage
    {
        public double Cost()
        {
            return 2.00;
        }
    }

    // CondimentDecorator abstract class
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public abstract double Cost();
    }

    // Concrete Condiment Decorators
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.30;
        }
    }

    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.60;
        }
    }

    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.45;
        }
    }

    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.30;
        }
    }

    // Example
    class Program
    {
        static void Main(string[] args)
        {
            // Create a DarkRoast coffee with Mocha and Whip
            Beverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Whip(darkRoast);

            // Calculate the cost
            Console.WriteLine("Cost of DarkRoast with Mocha and Whip: $" + darkRoast.Cost());
        }
    }

}