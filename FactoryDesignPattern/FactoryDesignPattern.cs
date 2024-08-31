namespace FactoryDesignPattern
{
    /// <summary>
    /// Factory Design Pattern
    /// Factory Pattern can be used to encapsulate the object creation logic, so the client code doesn't need to know the exact class name but can still create objects.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Draws the shape.
        /// </summary>
        void DrawShape();
    }

    /// <summary>
    ///  Rectangle Shape
    ///  Concrete Classes
    /// </summary>
    /// <seealso cref="IShape" />
    public class Rectangle : IShape
    {
        /// <summary>
        /// Draws the shape.
        /// </summary>
        public void DrawShape()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    /// <summary>
    ///  Square Shape
    ///  Concrete Classes
    /// </summary>
    /// <seealso cref="IShape" />
    public class Square : IShape
    {
        /// <summary>
        /// Draws the shape.
        /// </summary>
        public void DrawShape()
        {
            Console.WriteLine("Drawing Square");
        }
    }

    /// <summary>
    /// The ShapeFactory class contains a method GetShape that takes a string shapeType as an argument and returns an object of type IShape. 
    /// Depending on the shapeType provided, it creates and returns an instance of the corresponding shape class.
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// Factory method to create instances of IShape
        /// </summary>
        /// <param name="shapeType">Type of the shape.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException">Invalid shape type.</exception>
        public IShape GetShape(string shapeType)
        {
            #region switch case statement
            //switch (shapeType)
            //{
            //    case "Rectangle":
            //        return new Rectangle();
            //    case "Square":
            //        return new Square();
            //    default:
            //        throw new NotImplementedException("Invalid shape type.");
            //}

            #endregion

            return shapeType switch
            {
                "Rectangle" => new Rectangle(),
                "Square" => new Square(),
                _ => throw new NotImplementedException("Invalid shape type."),
            };

        }
    }


}
