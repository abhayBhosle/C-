using System;

public class Student
{
    private string name;

    // Property with get and set blocks
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
class p1
{
    static void Main(string[] args)
    {
        Student stu = new Student();
        stu.Name = "John Cena";
        Console.WriteLine("Student Name : "+stu.Name);
    }

}