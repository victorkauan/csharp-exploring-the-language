using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 02 - Creating Variables");

        int age = 16;
        Console.WriteLine("I am " + age + " years old.");

        age = 16 - 5;
        Console.WriteLine("I am " + age + " years old.");

        age = 8 * 2 / 3;
        Console.WriteLine("I am " + age + " years old.");

        age = (8 + 3) * 2;
        Console.WriteLine("I am " + age + " years old.");

        Console.WriteLine("Press return to close...");
        Console.ReadLine();
    }
}
