using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO CSE 210.");
        Console.WriteLine();

        Console.Write("What is your first name? ");
        string FirstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string LastName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");
    }
}