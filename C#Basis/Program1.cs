using System;

class Program1
{
    static bool isPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        for (int i = 2; i < 50; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
