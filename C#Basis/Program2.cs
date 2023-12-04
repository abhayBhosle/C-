using System;
class MyClass
{
    public static int counter;

    static MyClass()
    {
        Console.WriteLine("Static Constructor is Called.");
        counter = 0;
    }
    public static void IncrementCounter()
    {
        counter++;
    }
}
class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Before accessing Counter : " + MyClass.counter);
        MyClass.IncrementCounter();
        Console.WriteLine("After accessing Counter : " + MyClass.counter);

    }
}