using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 04 - Casting and Other Data Types");

        double doubleSalary = 2000.25;
        int integerSalary = (int)doubleSalary;

        Console.WriteLine(doubleSalary);
        Console.WriteLine(integerSalary);

        // short = 16 bits
        short signedSixteenBits = 32767;
        Console.WriteLine(signedSixteenBits);

        // int = 32 bits
        int signedThirtyTwoBits = 2147483647;
        Console.WriteLine(signedThirtyTwoBits);

        // long = 64 bits
        long signedSixtyFourBits = 9223372036854775807;
        Console.WriteLine(signedSixtyFourBits);

        // float = 32 bits
        float height = 1.74f;
        Console.WriteLine(height);

        height = (float)1.74;
        Console.WriteLine(height);

        float floatValueOne = 0.2f;
        float floatValueTwo = 0.1f;
        float floatTotal = floatValueOne + floatValueTwo;
        Console.WriteLine(floatTotal);

        // double = 64 bits
        double doubleValueOne = 0.2;
        double doubleValueTwo = 0.1;
        double doubleTotal = doubleValueOne + doubleValueTwo;
        Console.WriteLine(doubleTotal);

        Console.WriteLine("Press return to close...");
        Console.ReadLine();
    }
}
