// See https://aka.ms/new-console-template for more information
using AbstractFactoryDesignPattern;
using BuilderDesignPattern;
using FactoryDesignPattern;
using SingletonPattern;

Console.WriteLine("Hello, World!");

//Factory Design Pattern
ShapeFactory calculateShape = new ShapeFactory();
IShape shape = calculateShape.GetShape("Rectangle");
shape.DrawShape();

IShape shape1 = calculateShape.GetShape("Square");
shape1.DrawShape();


//Abstract Factory Design Pattern
IGUIFactory windowsFactory = new WindowsFactory();
Client windowsClient = new Client(windowsFactory);
windowsClient.RunComponent();

IGUIFactory macOSFactory = new MacFactory();
Client macOsClient = new Client(macOSFactory);
macOsClient.RunComponent();


// Attempt to create the first instance.
SingletonPatternClass singleton1 = SingletonPatternClass.Instance;
singleton1.PrintMessage();

// Attempt to create another instance.
SingletonPatternClass singleton2 = SingletonPatternClass.Instance;
singleton2.PrintMessage();

// Check if both references point to the same instance.
if (singleton1 == singleton2)
{
    Console.WriteLine("Both variables hold the same instance.");
}
else
{
    Console.WriteLine("Variables hold different instances.");
}

//Builder pattern
HouseBuilder builder = new HouseBuilder();
House house = builder.AddWindow(1)
    .AddDoors(2)
    .AddGarage()
    .Build();
Console.WriteLine(house);

