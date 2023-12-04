using System;
public class ReadOnlyExample
{
    private readonly int readOnlyField;

    public ReadOnlyExample(int value)
    {
        readOnlyField = value;
    }

    public void displayValues()
    {
        Console.WriteLine($"Read-Only Field Value : {readOnlyField}");
    }
}
class p5
{
    static void Main(string[] args)
    {
        ReadOnlyExample ex = new ReadOnlyExample(42);
        ex.displayValues();
        //ex.readOnlyField = 100;error 
    }
}