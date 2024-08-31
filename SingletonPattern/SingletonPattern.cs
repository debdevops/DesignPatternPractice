namespace SingletonPattern
{
    /// <summary>
    /// Signleton class sample
    /// </summary>
    public class SingletonPatternClass
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static SingletonPatternClass instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="SingletonPatternClass"/> class from being created.
        /// </summary>
        private SingletonPatternClass()
        {
            Console.WriteLine("Singleton instance created");
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static SingletonPatternClass Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonPatternClass();
                }
                return instance;
            }
        }

        /// <summary>
        /// Prints the message.
        /// </summary>
        public void PrintMessage()
        {
            Console.WriteLine("Signleton instance working");
        }
    }
}
