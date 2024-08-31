namespace BuilderDesignPattern
{

    /// <summary>
    /// Product
    /// </summary>
    public class House
    {
        /// <summary>
        /// Gets or sets the windows.
        /// </summary>
        /// <value>
        /// The windows.
        /// </value>
        public int Windows { get; set; }
        /// <summary>
        /// Gets or sets the doors.
        /// </summary>
        /// <value>
        /// The doors.
        /// </value>
        public int Doors { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance has garage.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has garage; otherwise, <c>false</c>.
        /// </value>
        public bool HasGarage { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"House with {Windows}, doors {Doors}, Garage {HasGarage}";
        }
    }


    /// <summary>
    /// Builder class
    /// </summary>
    public class HouseBuilder
    {
        /// <summary>
        /// The house
        /// </summary>
        private House house = new House();

        /// <summary>
        /// Adds the window.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <returns></returns>
        public HouseBuilder AddWindow(int window)
        {
            house.Windows = window;
            return this;
        }

        /// <summary>
        /// Adds the doors.
        /// </summary>
        /// <param name="door">The door.</param>
        /// <returns></returns>
        public HouseBuilder AddDoors(int door)
        {
            house.Doors = door;
            return this;
        }

        /// <summary>
        /// Adds the garage.
        /// </summary>
        /// <returns></returns>
        public HouseBuilder AddGarage()
        {
            house.HasGarage = true;
            return this;
        }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public House Build() { 
            return house;
        }

    }
    
}
