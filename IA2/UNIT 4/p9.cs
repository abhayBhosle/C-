using System;

class ExceptionHandlingExample
{
    public static void Main()
    {
        try
        {
            // Application-level exception
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("Attempting to access an element at index 5: " + numbers[5]);

            // System-level exception (NullReferenceException)
            string nullString = null;
            Console.WriteLine("Length of nullString: " + nullString.Length);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($ "Application-level Exception: {ex.GetType().Name} - {ex.Message}");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($ "System-level Exception: {ex.GetType().Name} - {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($ "Other Exception: {ex.GetType().Name} - {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");

        }

    }
}