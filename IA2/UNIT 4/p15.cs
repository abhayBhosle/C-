using System;

class A : Exception
{
    public A(string message) : base(message)
    {

    }
}

class p15
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            int userinp = int.Parse(name);


            if (name.Length > 15)
            {
                throw new A("Name length should not exceed 15 characters.");
            }

            Console.WriteLine("Your name is: " + name);
        }
        catch (A ex)
        {
            Console.WriteLine("A: " + ex.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}