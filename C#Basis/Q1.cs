using System;
class A{
    public readonly int ReadOnly;
    
    public A(int value){
        ReadOnly = value;
    }
    public void Print(){
        Console.WriteLine(ReadOnly);
    }
    
}
class Q1{
    static void Main(string[] args){
        A aa = new A(12);
        aa.Print();

        A ab = new A(34);
        ab.Print();
    }
}