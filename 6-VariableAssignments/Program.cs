using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 06 - Variable Assignments");

        int age = 30;
        int annaAge = age;

        Console.WriteLine(age);
        Console.WriteLine(annaAge);

        age = 25;

        Console.WriteLine(age);
        Console.WriteLine(annaAge);

        Console.WriteLine("Press return to close...");
        Console.ReadLine();
    }
}
