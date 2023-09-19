using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        float percentage = float.Parse(Console.ReadLine());

        // Initialize variables for letter grade and sign
        string letter = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int last_digit = (int)(percentage % 10);
        if (last_digit >= 7)
        {
            sign = "+";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }

        if (letter == "A" && last_digit >= 7)
        {
            letter = "A+";
        }
        else if (letter == "F")
        {
            letter = "F";
        }

        if (!string.IsNullOrEmpty(sign))
        {
            Console.WriteLine($"Your grade is {letter}{sign}");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}
