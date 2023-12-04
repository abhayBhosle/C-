using System;
class pp
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 0, 3, 4 };
        try
        {
            int res = arr[0] / arr[1];

            // Console.WriteLine(arr[10]);
            Console.WriteLine(res);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("The try catch is finished!");
        }
    }
}