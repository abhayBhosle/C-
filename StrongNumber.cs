using System;

class Program
{
    // Function to calculate the factorial of a number
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number; // Store the original number for comparison

        int sumOfFactorials = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sumOfFactorials += Factorial(digit);
            number /= 10;
        }

        if (sumOfFactorials == originalNumber)
        {
            Console.WriteLine($"{originalNumber} is a Strong number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not a Strong number.");
        }
    }
}
