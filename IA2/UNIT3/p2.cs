using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking...");
    }
}

class p2
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        d.Bark();
        d.Eat();
        d.Sleep();
    }
}