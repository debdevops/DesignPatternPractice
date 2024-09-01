namespace ObserverPattern
{

    /// <summary>
    /// The Observer interface
    /// </summary>
    public interface IInvestor
    {
        /// <summary>
        /// Updates the specified stock name.
        /// </summary>
        /// <param name="stockName">Name of the stock.</param>
        /// <param name="price">The price.</param>
        void Update(string stockName, float price);
    }


    /// <summary>
    /// The subject interface
    /// </summary>
    public interface IStock
    {
        /// <summary>
        /// Attaches the specified investor.
        /// </summary>
        /// <param name="investor">The investor.</param>
        void Attach(IInvestor investor);
        /// <summary>
        /// Detaches the specified investor.
        /// </summary>
        /// <param name="investor">The investor.</param>
        void Detach(IInvestor investor);
        /// <summary>
        /// Notifies this instance.
        /// </summary>
        void Notify();
    }

    /// <summary>
    /// Concrete Subject (Stock)
    /// </summary>
    /// <seealso cref="ObserverPattern.IStock" />
    public class Stock : IStock
    {
        /// <summary>
        /// The investor list
        /// </summary>
        private List<IInvestor> investorList = new List<IInvestor>();
        /// <summary>
        /// The stock name
        /// </summary>
        private string stockName;
        /// <summary>
        /// The price
        /// </summary>
        private float price;

        /// <summary>
        /// Initializes a new instance of the <see cref="Stock"/> class.
        /// </summary>
        /// <param name="stkName">Name of the STK.</param>
        /// <param name="price">The price.</param>
        public Stock(string stkName, float price)
        {
                this.stockName = stkName;
                this.price = price;
        }
        /// <summary>
        /// Attaches the specified investor.
        /// </summary>
        /// <param name="investor">The investor.</param>
        public void Attach(IInvestor investor)
        {
            investorList.Add(investor);
        }

        /// <summary>
        /// Detaches the specified investor.
        /// </summary>
        /// <param name="investor">The investor.</param>
        public void Detach(IInvestor investor)
        {
            investorList.Remove(investor);
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            foreach(var inv in investorList)
            {
                inv.Update(stockName, price);
            }
        }

        /// <summary>
        /// Sets the price.
        /// </summary>
        /// <param name="newPrice">The new price.</param>
        public void SetPrice(float newPrice) {
            Console.WriteLine($"{stockName}: New price is {newPrice}");
            price = newPrice;
            Notify();
        }
    }

    /// <summary>
    /// Concrete observer (Investor)
    /// </summary>
    /// <seealso cref="ObserverPattern.IInvestor" />
    public class Investor : IInvestor
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;
        /// <summary>
        /// Initializes a new instance of the <see cref="Investor"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Investor(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Updates the specified stock name.
        /// </summary>
        /// <param name="stockName">Name of the stock.</param>
        /// <param name="price">The price.</param>
        public void Update(string stockName, float price)
        {
            Console.WriteLine($"{name} notified of {stockName}'s price change to {price}");
        }
    }
}
