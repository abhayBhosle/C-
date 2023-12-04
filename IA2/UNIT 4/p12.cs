using System;
class p12
{
    static void Main(string[] args)
    {
        int a = 10, b = 0;
        try
        {
            int result = a / b;
            Console.WriteLine(result);
        }
        // catch (DivideByZeroException e)
        // {
        //     Console.Error.WriteLine("Divide by zero is not allowed!.");
        // }
        catch (Exception e)
        {
            Console.Error.WriteLine(e);
        }
    }
}