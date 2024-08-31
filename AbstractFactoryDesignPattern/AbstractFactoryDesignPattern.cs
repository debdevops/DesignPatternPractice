namespace AbstractFactoryDesignPattern
{

    /// <summary>
    /// Abstract Factory Pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes.
    /// Abstract Product - Button
    /// </summary>
    public interface IButton
    {
        /// <summary>
        /// Draws the button.
        /// </summary>
        void DrawButton();
    }

    /// <summary>
    /// Abstract Product - CheckBox
    /// </summary>
    public interface ICheckBox
    {
        /// <summary>
        /// Draws the CheckBox.
        /// </summary>
        void DrawCheckBox();
    }


    /// <summary>
    /// Concrete product
    /// </summary>
    /// <seealso cref="AbstractFactoryDesignPattern.IButton" />
    public class WindowsOSButton : IButton
    {
        /// <summary>
        /// Draws the button.
        /// </summary>
        public void DrawButton()
        {
            Console.WriteLine("Window OS Button");
        }
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    /// <seealso cref="AbstractFactoryDesignPattern.ICheckBox" />
    public class WindowsOSCheckBox : ICheckBox
    {
        /// <summary>
        /// Draws the CheckBox.
        /// </summary>
        public void DrawCheckBox()
        {
            Console.WriteLine("Window OS CheckBox");
        }
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    /// <seealso cref="AbstractFactoryDesignPattern.IButton" />
    public class MacOSButton : IButton
    {
        /// <summary>
        /// Draws the button.
        /// </summary>
        public void DrawButton()
        {
            Console.WriteLine("MAC OS Button");
        }
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    /// <seealso cref="AbstractFactoryDesignPattern.ICheckBox" />
    public class MacOSCheckBox : ICheckBox
    {
        /// <summary>
        /// Draws the CheckBox.
        /// </summary>
        public void DrawCheckBox()
        {
            Console.WriteLine("MAC OS CheckBox");
        }
    }

    /// <summary>
    /// Abstract Factory (IGUIFactory)
    /// </summary>
    public interface IGUIFactory
    {
        /// <summary>
        /// Creates the button.
        /// </summary>
        /// <returns></returns>
        IButton CreateButton();
        /// <summary>
        /// Creates the CheckBox.
        /// </summary>
        /// <returns></returns>
        ICheckBox CreateCheckBox();
    }

    /// <summary>
    /// Concrete Factory
    /// </summary>
    /// <seealso cref="AbstractFactoryDesignPattern.IGUIFactory" />
    public class WindowsFactory : IGUIFactory
    {
        /// <summary>
        /// Creates the button.
        /// </summary>
        /// <returns></returns>
        public IButton CreateButton()
        {
            return new WindowsOSButton();
        }

        /// <summary>
        /// Creates the CheckBox.
        /// </summary>
        /// <returns></returns>
        public ICheckBox CreateCheckBox()
        {
            return new WindowsOSCheckBox();
        }
    }

    /// <summary>
    /// Concrete Factory
    /// </summary>
    /// <seealso cref="AbstractFactoryDesignPattern.IGUIFactory" />
    public class MacFactory : IGUIFactory
    {
        /// <summary>
        /// Creates the button.
        /// </summary>
        /// <returns></returns>
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        /// <summary>
        /// Creates the CheckBox.
        /// </summary>
        /// <returns></returns>
        public ICheckBox CreateCheckBox()
        {
            return new MacOSCheckBox();
        }
    }

    /// <summary>
    /// Client Class
    /// </summary>
    public class Client
    {
        /// <summary>
        /// The button
        /// </summary>
        private IButton button;
        /// <summary>
        /// The check box
        /// </summary>
        private ICheckBox checkBox;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="gUIFactory">The g UI factory.</param>
        public Client(IGUIFactory gUIFactory)
        {
            button = gUIFactory.CreateButton();
            checkBox = gUIFactory.CreateCheckBox();
        }

        /// <summary>
        /// Runs the component.
        /// </summary>
        public void RunComponent()
        {
            button.DrawButton();
            checkBox.DrawCheckBox();
        }
    }
}
