namespace AdapterPattern
{
    //Imagine you're developing an e-commerce application that calculates the total cost of orders.
    //You have a legacy system that calculates costs in USD, but now you need to adapt it to work with a
    //third-party library that calculates costs in EUR. You can use the Adapter Pattern to make the new
    //library work seamlessly with your existing code.

    //The target interface (expected by the client)
    public interface ICostCalculator
    {
        decimal GetTotalCost(decimal amount);
    }

    //The Adaptee class (third-party library with incompatible interface)
    public class EuroCostCalculator
    {
        public decimal GetTotalCostInEuro(decimal amount)
        {
            return amount * 0.85m; //assuming 1USD = 0.85 EURO
        }
    }

    //The Adapter Class (adapts EuroCostCalculator to ICostCalculator)
    public class EuroCostCalculatorAdapter : ICostCalculator
    {
        private EuroCostCalculator EuroCostCalculator;

        public EuroCostCalculatorAdapter(EuroCostCalculator euroCostCalculator)
        {
                EuroCostCalculator = euroCostCalculator;
        }
        public decimal GetTotalCost(decimal amount)
        {
            return EuroCostCalculator.GetTotalCostInEuro(amount);
        }
    }

    //The Client class (uses the Target interface)
    public class Order
    {
        private ICostCalculator CostCalculator;

        public Order(ICostCalculator costCalculator)
        {
            CostCalculator = costCalculator;
        }

        public void PrintTotalCost(decimal amount)
        {
            var totalCost = CostCalculator.GetTotalCost(amount);
            Console.WriteLine("Total cost: " + totalCost);
        }
    }

    public class UsdCostCalculator : ICostCalculator
    {
        public decimal GetTotalCost(decimal amount)
        {
            return amount;
        }
    }


}
