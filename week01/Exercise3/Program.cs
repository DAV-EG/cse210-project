using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO GUESS MY NUMBER GAME");

        string KeepPlaying = "Yes";

        while (KeepPlaying == "Yes")
        {

            Random randomGenerator = new Random();
            int MagicNumber = randomGenerator.Next(1, 101);
            int Guess = -1;
            int guessCount = 0;

            while (Guess != MagicNumber)
            {
                Console.Write("Guess the number? ");
                string input = Console.ReadLine();
                Guess = int.Parse(input);
                guessCount++;


                if (Guess < MagicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (Guess > MagicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine("Congratulations! you Guessed It");
                }
            }

            Console.WriteLine($"You Made a Total of {guessCount} Guesses");

            Console.Write("Will you Like to keep Playing?(Yes/No) ");
            string Question = Console.ReadLine();

            if (Question == "Yes")
            {
                KeepPlaying = "Yes";
            }
            else if (Question == "No")
            {
                KeepPlaying = "No";
                Console.WriteLine("Thank You For Playing");
            }
            else
            {
                Console.WriteLine("Please select Yes/No");
            }
        }
    }
}