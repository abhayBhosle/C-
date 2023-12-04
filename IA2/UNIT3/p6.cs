using System;

public interface Ishape
{
    const double PI = 3.14; //Constant

    void draw();//Abstract method 
}

public class Circle : Ishape
{
    public void draw()
    {
        Console.WriteLine("Draw a circle using red Pen!");
    }
}

class p6
{
    static void Main(string[] args)
    {
        //Create an instance of the Circle class
        Circle cc = new Circle();
        //Invoke the abstract method from the interface
        cc.draw();

        //Access the constant from the  interface.
        Console.WriteLine(Ishape.PI);

    }
}