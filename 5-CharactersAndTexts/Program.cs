using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project 05 - Characters and Texts");

        char letter = 'a';
        Console.WriteLine(letter);

        letter = (char)65;
        Console.WriteLine(letter);

        letter = (char)(65 + 1);
        Console.WriteLine(letter);
        
        letter = (char)(4 * 12 / 2);
        Console.WriteLine(letter);

        letter = (char)(letter + 1);
        Console.WriteLine(letter);

        int value = 92;
        letter = (char)(value - 10);
        Console.WriteLine(letter);

        letter = ' ';
        Console.WriteLine(letter);

        string firstSentence = "Alura - Online Technology Courses ";
        Console.WriteLine(firstSentence + 2023);

        string courses = @"Available courses:
- Go
- C#
- Python
- Java";
        Console.WriteLine(courses);

        string emptyString = "";
        Console.WriteLine(emptyString);

        Console.WriteLine("Press return to close...");
        Console.ReadLine();
    }
}
