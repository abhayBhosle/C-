using System;

interface IVehicle
{
    void Honk();
}

class Car : IVehicle
{
    public string Brand { get; set; }
    public string ModelName { get; set; }

    public Car(string brand, string modelName)
    {
        Brand = brand;
        ModelName = modelName;
    }

    public void Honk()
    {
        Console.WriteLine("Tutt, yutt!");
    }
}

class SCar : IVehicle
{
    public void Display()
    {
        Console.WriteLine("Multiple Inheritance: 1 parent with 2 derived classes");
    }

    public void Honk()
    {
        Console.WriteLine("SCar Honk");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("BMW", "X5");
        SCar sCar = new SCar();

        car.Honk();   // Calls the Honk method in Car
        sCar.Honk();  // Calls the Honk method in SCar

        sCar.Display();
    }
}
