using System;
class p10
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        try
        {
            Console.WriteLine(arr[10]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.Error.WriteLine("Index out of range. Please provide a valid index");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}