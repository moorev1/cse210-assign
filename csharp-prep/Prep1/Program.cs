using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for their first name
        // It ugent
        Console.Write("What is your first name: ");
        string firstName = Console.ReadLine();

        // Prompt the user for their last name
        Console.Write("What is your last name: ");
        string lastName = Console.ReadLine();

        // Display the name in the specified format
        Console.WriteLine("Your name is {0}, {1}, {0}", lastName, firstName);

        // Pause to keep the console window open
        Console.ReadLine();
    }
}