using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a CSV file");
            Console.WriteLine("4. Load the journal from a CSV file");
            Console.WriteLine("5. Calculate average rating");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        string randomPrompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {randomPrompt}");
                        Console.Write("Enter your response: ");
                        string response = Console.ReadLine();
                        Console.Write("Rate your day (1-5): ");
                        if (int.TryParse(Console.ReadLine(), out int rating) && rating >= 1 && rating <= 5)
                        {
                            journal.AddEntry(randomPrompt, response, rating);
                            Console.WriteLine("Entry added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid rating. Please enter a number between 1 and 5.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Journal Entries:");
                        journal.DisplayEntries();
                        break;
                    case 3:
                        Console.Write("Enter the filename to save (CSV): ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToCsv(saveFileName);
                        Console.WriteLine($"Journal saved to {saveFileName}");
                        break;
                    case 4:
                        Console.Write("Enter the filename to load (CSV): ");
                        string loadFileName = Console.ReadLine();
                        journal.LoadFromCsv(loadFileName);
                        Console.WriteLine($"Journal loaded from {loadFileName}");
                        break;
                    case 5:
                        double avgRating = journal.CalculateAverageRating();
                        Console.WriteLine($"Average Rating: {avgRating:F2}");
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
            }

            Console.WriteLine();
        }
    }
}
