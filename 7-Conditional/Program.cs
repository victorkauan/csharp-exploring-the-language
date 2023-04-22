using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 07 - Conditional");

        int johnAge = 16;
        int numberOfPeople = 3;

        if (johnAge >= 18)
        {
            Console.WriteLine("You are over 18 years old!");
            Console.WriteLine("Welcome!");
        }
        else
        {
            if (numberOfPeople > 1)
            {
                Console.WriteLine("You are not 18 years old, but you can enter, " +
                    "as you are accompanied!");
            }
            else
            {
                Console.WriteLine("Unfortunately, you cannot enter!");
            }
        }

        Console.WriteLine("Press return to close...");
        Console.ReadLine();
    }
}
