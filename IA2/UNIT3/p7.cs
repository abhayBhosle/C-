using System;

public class Shape
{
    public virtual void draw()
    {
        Console.WriteLine("Draw a Generic shape.");
    }
}

public class Rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing a Rectangle.");
    }

    public void DisplaySides()
    {
        Console.WriteLine("Rectangle has 4 sides.");
    }
}

public class Square : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing a Square.");
    }

    public void DisplaySides()
    {
        Console.WriteLine("Square has 4 sides.");
    }
}

public class Triangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Drawing a Triangle.");
    }

    public void DisplaySides()
    {
        Console.WriteLine("Triangle has 3 sides.");
    }
}
class p7
{
    static void Main(string[] args)
    {
        //create instance of each shape.
        Shape genericShape = new Shape();
        Shape rectangle = new Rectangle();
        Shape square = new Square();
        Shape triangle = new Triangle();

        Console.WriteLine("Polymorphism behaviour: ");

        Console.WriteLine("\nCalling Draw method on genericShape: ");
        genericShape.draw();

        Console.WriteLine("\nCalling Draw method on rectangle: ");
        rectangle.draw();

        Console.WriteLine("\nCalling Draw method on square: ");
        square.draw();

        Console.WriteLine("\nCalling Draw method on triangle: ");
        triangle.draw();

        Console.WriteLine("\nDisplaying number of sides ");

        Rectangle rr = new Rectangle();
        Square ss = new Square();
        Triangle tt = new Triangle();

        rr.DisplaySides();
        ss.DisplaySides();
        tt.DisplaySides();


    }
}