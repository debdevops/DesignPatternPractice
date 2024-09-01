namespace StrategyPattern
{

    //Strategy Pattern is a behavioral design pattern that allows you to define a family of algorithms,
    //encapsulate each one as a separate class, and make them interchangeable.
    //The strategy pattern lets the algorithm vary independently from the clients that use it.

    //The Strategy interface (Payment Strategy)
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    //Concrete Strategy (Credit Card Payment)
    public class CreditCardPayment : IPaymentStrategy 
    {
        private string CardNumber;
        public CreditCardPayment(string cardNumber)
        {
            CardNumber = cardNumber;
        }
        public void Pay(decimal amount) {
            Console.WriteLine($"Paid {amount} using Credit Card with number: {CardNumber}");
        }
    }

    //Concrete Startegy PayPal Payment
    public class PayPalPayment : IPaymentStrategy {
        private string email;

        public PayPalPayment(string email)
        {
            this.email = email;
        }
        public void Pay(decimal amount) {
            Console.WriteLine($"Paid {amount} using Pay Pal account: {email}");
        }
    }

    //Concrete Strategy (Bank Account Transfer)
    public class BankTransferPayment : IPaymentStrategy
    {
        private string bankAccount;

        public BankTransferPayment(string bankAccount)
        {
            this.bankAccount = bankAccount;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Bank Transfer to account: {bankAccount}");
        }
    }

    //The Context Class (Payment processor)
    public class PaymentProcessor
    {
        private IPaymentStrategy paymentStrategy;
        public PaymentProcessor(IPaymentStrategy strategy)
        {
            paymentStrategy = strategy;
        }
        public void ProcessPayment(decimal amount)
        {
            paymentStrategy.Pay(amount);
        }
    }
}
