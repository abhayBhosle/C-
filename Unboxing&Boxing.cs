using System;

class Program
{
    static void Main()
    {
        // Boxing: Converting a value type (int) to a reference type (object)
        int myValue = 42; // Value type (int) on the stack
        object boxedValue = myValue; // Boxing: Convert int to object (reference type)

        // Unboxing: Converting a reference type (object) back to a value type (int)
        int unboxedValue = (int)boxedValue; // Unboxing: Convert object to int (value type)

        Console.WriteLine("Original value (int): " + myValue);
        Console.WriteLine("Boxed value (object): " + boxedValue);
        Console.WriteLine("Unboxed value (int): " + unboxedValue);
    }
}
