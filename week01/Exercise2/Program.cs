using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO GRADE CALCULATOR. ENSURE TO INPUT THE RIGHT DIGITS. GOODLUCK");
        Console.WriteLine();

        Console.Write("What is your Grade Percentage? ");
        string Grade = Console.ReadLine();
        int number = int.Parse(Grade);
        Char Letter = ' ';
        Char Sign = ' ';
        int LastDigit = number / 10;


        Console.WriteLine();
        Console.WriteLine("Remember that you need atleast a total of 70% to pass this class.");
        Console.WriteLine();

        if (number >= 90)
        {
            Letter = 'A';
        }

        else if (number >= 80)
        {
            Letter = 'B';
        }

        else if (number >= 70)
        {
            Letter = 'C';
        }

        else if (number >= 60)
        {
            Letter = 'D';
        }

        else
        {
            Letter = 'F';
        }


        Console.WriteLine();

        if (LastDigit >= 7)
        {
            Sign = '+';
        }

        else if (LastDigit <= 3)
        {
            Sign = '-';
        }

        else
        {
            Sign = ' ';
        }

        if (number >= 93)
        {
            Sign = ' ';
        }

        if (Letter == 'F')
        {
            Sign = ' ';
        }

        Console.WriteLine();
        Console.WriteLine($"Your Grade is {Letter}{Sign}.");
        Console.WriteLine();

        if (number >= 70)
        {
            Console.WriteLine("Congratulation you Passed the course");
        }

        else
        {
            Console.WriteLine("You Failed you will have to repeat this Class. Remember Failure is not the end of a Man");
        }

    }
}