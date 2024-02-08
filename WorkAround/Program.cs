using Entities.Concrete;
using System;

class Program
{
    static void Main(string[] args)
    {
        SayHello("Canan");
        SayHello();  // name burada 
    }
    static void SayHello(string name = "noname")
    {
        Console.WriteLine("Welcome", name);
    }
}



