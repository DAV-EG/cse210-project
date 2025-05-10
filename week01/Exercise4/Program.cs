using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ADD YOUR NUMBERS.");
        Console.WriteLine();
        Console.WriteLine("Enter a List of Number, Type 0 when finished");
        Console.WriteLine();

        List<int> numbers = new List<int>();

        int InputNumber = -1;

        while (InputNumber != 0)
        {
            Console.Write("Enter a Number: ");
            string UserInput = Console.ReadLine();
            InputNumber = int.Parse(UserInput);

            if (InputNumber != 0)
            {
                numbers.Add(InputNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int LargestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > LargestNumber)
            {
                LargestNumber = number;
            }
        }

        Console.WriteLine($"The Largest Number is: {LargestNumber}");
    }

}