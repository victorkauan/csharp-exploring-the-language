using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 03 - Creating Floating-Point Variables");

        double salary = 1930.10;
        Console.WriteLine("My salary is R$ " + salary + ".");

        salary = 1930;
        Console.WriteLine("My salary is R$ " + salary + ".");

        double age = 7.0 / 5;
        Console.WriteLine("I am " + age + " years old.");

        age = 7 / 5;
        Console.WriteLine("I am " + age + " years old.");

        int integerDivision = 8 / 3;
        Console.WriteLine("Integer division result: " + integerDivision + ".");

        double doubleDivision = 8.0 / 3;
        Console.WriteLine("Floating-point division result: " + doubleDivision + ".");

        int integerMultiplication = 5 * 4;
        Console.WriteLine("Integer multiplication result: " + integerMultiplication + ".");

        double doubleMultiplication = 5.0 * 4.0;
        Console.WriteLine("Floating-point multiplication result: " + doubleMultiplication + ".");

        Console.WriteLine("Press return to close...");
        Console.ReadLine();
    }
}
